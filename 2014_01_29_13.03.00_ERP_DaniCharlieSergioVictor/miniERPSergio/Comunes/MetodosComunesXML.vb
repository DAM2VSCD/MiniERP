Imports System.Xml
Imports System.IO
Imports System.Xml.Serialization

Module MetodosComunesXML

    ' Lee el contenido de una tabla de un XML y lo guarda en la BD.
    ' El XML tiene que estar en la carpeta debug.
    Public Sub guardaContenidoTablaXMLenBD(ByVal nombreXML As String, ByVal nombreTabla As String)

        ' Se obtiene la lista de nodos del XML para un nombre de elemento (es decir, una tabla).
        Dim listaNodos As XmlNodeList = obtenerListaDeNodos(nombreXML, nombreTabla)

        ' CAMPOS tiene los nombres de los campos (ID, NOMBRE, POBLACIÓN... los que correspondan).
        ' REGISTROS contiene los valores de dichos campos para cada registro.
        Dim campos() As String = obtenerCamposXML(nombreXML, nombreTabla)

        Dim registros(,) As String = obtenerRegistrosXML(nombreXML, nombreTabla)

        ' Ahora se borran los registros de la tabla que hay en la BD.
        borraRegistrosTabla(nombreTabla)

        ' Ahora se añade a la BD el contenido que se extrajo del XML
        anyadeRegistrosTabla(nombreTabla, campos, registros)

    End Sub



    ' Lee el contenido de una consulta de una tabla de una BD y la guarda en un XML.
    ' El XML tiene que estar en la carpeta debug.
    Public Sub guardaConsultaUnaUnicaTablaBDenXML(ByVal nombreXML As String, ByVal consulta As String, ByVal nombreTabla As String)

        Dim titulosColumnas As String() = obtenerNombreColumnas(nombreTabla)

        Dim writer As New XmlTextWriter(nombreXML, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement(nombreTabla)

        Dim conjuntoDatosTabla As DataTable = obtenerDataTableDeUnaUnicaTablaDesdeSentencia(consulta)

        Dim filaConcreta As DataRow = Nothing
        For j = 0 To conjuntoDatosTabla.Rows.Count - 1
            filaConcreta = conjuntoDatosTabla.Rows(j)
            Dim contenido() As String
            ReDim contenido(titulosColumnas.GetLength(0) - 1)
            For i = 0 To titulosColumnas.GetLength(0) - 1
                contenido(i) = filaConcreta(titulosColumnas(i)).ToString
            Next
            crearNodoGenerico(nombreTabla, titulosColumnas, contenido, writer)
        Next

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub

    Public Function obtenerDataTableDeUnaUnicaTablaDesdeSentencia(ByVal sentencia As String) As DataTable
        Dim datosTabla As DataSet = conexion.getData(sentencia, "tablaBuscada")
        Dim contenidoTablas As DataTable = datosTabla.Tables("tablaBuscada")

        Return contenidoTablas
    End Function

    ' Devuelve un String() con los títulos de las columans de la tabla.
    Public Function obtenerNombreColumnasDeUnaTablaDesdeSentencia(ByVal sentencia As String) As String()

        Dim contenidoTablas As DataTable = obtenerDataTableDeUnaUnicaTablaDesdeSentencia(sentencia)
        Dim filaBuscada As DataRow = contenidoTablas.Rows(0)
        Dim nombresColumnas() As String
        ReDim nombresColumnas(filaBuscada.Table.Columns.Count - 1)
        For i = 0 To nombresColumnas.GetLength(0) - 1
            nombresColumnas(i) = filaBuscada.Table.Columns(i).ToString()
        Next

        Return nombresColumnas
    End Function


    ' Lee el contenido de una tabla de la BD y la guarda en un XML.
    ' El XML tiene que estar en la carpeta debug.
    Public Sub guardaContenidoTablaBDenXML(ByVal nombreXML As String, ByVal nombreTabla As String)

        Dim titulosColumnas As String() = obtenerNombreColumnas(nombreTabla)

        Dim writer As New XmlTextWriter(nombreXML, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement(nombreTabla)

        Dim conjuntoDatosTabla As DataTable = obtenerDataTableDeTabla(nombreTabla)

        Dim filaConcreta As DataRow = Nothing
        For j = 0 To conjuntoDatosTabla.Rows.Count - 1
            filaConcreta = conjuntoDatosTabla.Rows(j)
            Dim contenido() As String
            ReDim contenido(titulosColumnas.GetLength(0) - 1)
            For i = 0 To titulosColumnas.GetLength(0) - 1
                contenido(i) = filaConcreta(titulosColumnas(i)).ToString
            Next
            crearNodoGenerico(nombreTabla, titulosColumnas, contenido, writer)
        Next

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub

    Public Sub crearXMLdesdeDGV(ByVal nombreFichero As String, ByVal dgv As DataGridView, ByVal nombreTabla As String)

        Dim titulosColumnas As String() = obtenerNombreColumnas(nombreTabla)

        Dim writer As New XmlTextWriter(nombreFichero, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Table")
        For i = 0 To dgv.Rows.Count() - 1
            Dim contenido() As String
            ReDim contenido(dgv.Columns.Count() - 1)
            For j = 0 To dgv.Columns.Count() - 1
                contenido(j) = dgv.Item(j, i).Value
            Next
            crearNodoGenerico(nombreTabla, titulosColumnas, contenido, writer)
        Next

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
        MsgBox("Done")
    End Sub
    

    ' Obtiene la lista de Nodos de un fichero que pertenezcan a un un tipo de elemento.
    ' El fichero tiene que estar dentro de DEBUG.
    ' Por ejemplo: nombreFichero = "products.xml"
    ' Por ejemplo: nombreElemento = "Product"
    Public Function obtenerListaDeNodos(ByVal nombreFichero As String, ByVal nombreElemento As String) As XmlNodeList
        Dim xmldoc As New XmlDataDocument()
        Dim xmlnode As XmlNodeList
        Dim fs As New FileStream(nombreFichero, FileMode.Open, FileAccess.Read)
        xmldoc.Load(fs)
        xmlnode = xmldoc.GetElementsByTagName(nombreElemento)
        fs.Close()

        Return xmlnode
    End Function

    ' Borra todos los registros de una tabla en la base de datos.
    Public Sub borraRegistrosTabla(ByVal nombreTabla As String)
        Dim sentenciaBorrar As String = "DELETE FROM " & nombreTabla
        conexion.setData(sentenciaBorrar)
    End Sub

    ' Para una TABLA realiza los INSERT de una serie de CAMPOS con un conjunto de REGISTROS.
    Public Sub anyadeRegistrosTabla(ByVal nombreTabla As String, ByVal campos() As String, ByVal registros(,) As String)

        Dim sentenciaInsert, parteInicial, parteCampos, parteRegistros As String

        For i = 0 To registros.GetLength(0) - 1

            sentenciaInsert = ""
            parteInicial = ""
            parteCampos = ""
            parteRegistros = ""
            parteInicial = "INSERT INTO " & nombreTabla & " ("

            For z = 0 To campos.Length - 1
                parteCampos += campos(z)
                If z < (campos.Length - 1) Then
                    parteCampos += ", "
                End If
            Next
            parteCampos += ") VALUES ("

            For j = 0 To registros.GetLength(1) - 1
                parteRegistros += "'" & registros(i, j) & "'"
                If j < (registros.GetLength(1) - 1) Then
                    parteRegistros += ", "
                End If
            Next
            parteRegistros += ")"

            sentenciaInsert = parteInicial + parteCampos + parteRegistros
            conexion.setData(sentenciaInsert)
        Next

    End Sub

    ' CAMPOS tiene los nombres de los campos (ID, NOMBRE, POBLACIÓN... los que correspondan).
    Public Function obtenerCamposXML(ByVal nombreXML As String, ByVal nombreTabla As String) As String()
        ' Se obtiene la lista de nodos del XML para un nombre de elemento (es decir, una tabla).
        Dim listaNodos As XmlNodeList = obtenerListaDeNodos(nombreXML, nombreTabla)

        Dim campos() As String
        ReDim campos(listaNodos(0).ChildNodes.Count - 1)
        For j = 0 To listaNodos(0).ChildNodes.Count - 1
            campos(j) = listaNodos(0).ChildNodes.Item(j).Name

        Next
        Return campos
    End Function

    ' Obtiene todos los registros de un XML para una TABLA concreta.
    Public Function obtenerRegistrosXML(ByVal nombreXML As String, ByVal nombreTabla As String) As String(,)

        ' Se obtiene la lista de nodos del XML para un nombre de elemento (es decir, una tabla).
        Dim listaNodos As XmlNodeList = obtenerListaDeNodos(nombreXML, nombreTabla)

        Dim registros(,) As String
        ReDim registros(listaNodos.Count - 1, listaNodos(0).ChildNodes.Count - 1)
        For j = 0 To listaNodos(0).ChildNodes.Count - 1
            For i = 0 To listaNodos.Count - 1
                registros(i, j) = listaNodos(i).ChildNodes.Item(j).InnerText.Trim()
            Next
        Next

        Return registros
    End Function

    ' Devuelve un String() con los títulos de las columans de la tabla.
    Public Function obtenerNombreColumnas(ByVal nombreTabla As String) As String()

        Dim contenidoTablas As DataTable = obtenerDataTableDeTabla(nombreTabla)
        Dim filaBuscada As DataRow = contenidoTablas.Rows(0)
        Dim nombresColumnas() As String
        ReDim nombresColumnas(filaBuscada.Table.Columns.Count - 1)
        For i = 0 To nombresColumnas.GetLength(0) - 1
            nombresColumnas(i) = filaBuscada.Table.Columns(i).ToString()
        Next

        Return nombresColumnas
    End Function

    Public Function obtenerDataTableDeTabla(ByVal nombreTabla As String) As DataTable
        Dim sentencia As String = "SELECT * FROM " & nombreTabla
        Dim datosTabla As DataSet = conexion.getData(sentencia, "tablaBuscada")
        Dim contenidoTablas As DataTable = datosTabla.Tables("tablaBuscada")

        Return contenidoTablas
    End Function

    ' Crea un nodo genérico a partir de NOMBRE TABLA, TITULOSNODO(), REGISTROSNODO()
    ' AVISO: No tolera que haya registros NOTHING. Si los hay NOTHING no los añade.
    Public Sub crearNodoGenerico(ByVal nombreTabla As String, ByVal titulosNodo() As String, ByVal registrosNodo() As String, ByVal writer As XmlTextWriter)

        ' Primero se comprueba que no haya campos a nothing (porque el datagridview como poco tiene una fila de más)
        Dim anyadir As Boolean = True
        For i = 0 To titulosNodo.GetLength(0) - 1
            If registrosNodo(i) Is Nothing Then
                anyadir = False
            End If
        Next

        If anyadir Then
            writer.WriteStartElement(nombreTabla)
            For i = 0 To titulosNodo.GetLength(0) - 1
                writer.WriteStartElement(titulosNodo(i))
                writer.WriteString(registrosNodo(i))
                writer.WriteEndElement()
            Next
            writer.WriteEndElement()
        End If

    End Sub


End Module
