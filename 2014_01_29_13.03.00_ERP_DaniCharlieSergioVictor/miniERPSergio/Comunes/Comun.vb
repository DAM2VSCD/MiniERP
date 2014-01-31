Module Comun

    Private con As New ConnectDB 'Conexion a la base de datos
    Private id As Integer = 0 'ID del usuario conectado
    Private nom As String 'Nombre del usuario conectado
    Private iva As Double = 0.21

    ' Comprueba y gestiona si se deben poner etiquetas de error o de acierto.
    Public Sub gestionarErroresEtiquetas(ByVal esCorrecto As Boolean, ByRef incorrecto As PictureBox, ByRef correcto As PictureBox)
        correcto.Visible = esCorrecto
        incorrecto.Visible = Not esCorrecto
    End Sub

    ' Borra el contenido del DataGridView.
    Public Sub borraDataGridView(ByRef dgv As DataGridView)
        Dim numFilas As Integer = dgv.Rows.Count
        For i = 0 To numFilas - 1
            dgv.Rows.RemoveAt(0)
        Next
    End Sub

    Private inicio As Boolean
    Public crypt As Simple3Des 'Objeto de la clase de encriptación.

    Public Property primer_inicio
        Get
            Return inicio
        End Get
        Set(ByVal value)
            inicio = value
        End Set
    End Property

    Public ReadOnly Property conexion
        Get
            Return con
        End Get
    End Property
    Public Property idUsuario
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
        End Set
    End Property
    Public Property nombre
        Get
            Return nom
        End Get
        Set(ByVal value)
            nom = value
        End Set
    End Property

    'Inserta datos en la tabla lista cambios
    Public Sub insertarCambio(ByVal descripcion As String, ByVal tipo As String)

        ' tipo 0 = generico
        '       V=validacion de caja

        Dim data As DataSet = Comun.conexion.getdata("select idcambio, numcambio " & _
                                                     "from cambios " & _
                                                     "where idcambio = (select max(idcambio) " & _
                                                                    "from cambios)", "cambio")
        Dim t As DataTable = data.Tables("cambio")

        Dim idc As Integer
        Dim num As Integer

        If t.Rows.Count = 0 Then 'si no hat ningun registro empieza en id=1 y numero=1000
            idc = 1
            num = 1000
        Else
            idc = t.Rows(0)(0) + 1
            num = t.Rows(0)(1) + 1
        End If

        Dim fecha As String = Fecha2number(Date.Now)
        Dim hora As String = hora2number(Date.Now)

        con.setData("insert into CAMBIOS (numcambio, refusuario, fecha, hora, descripcion, tipo) " &
                    "VALUES(" & num & "," & id & "," & fecha & "," & hora & ",'" & descripcion & "','" & tipo & "')")

        MetodosComunesXML.guardaContenidoTablaBDenXML("proveedores.xml", "cambios")

    End Sub

    'Estilo a utilizar en la tablas
    Sub estilodgvArt(ByVal dgv As DataGridView)

        'dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False ' para que no se muestre la ultima fila en blanco
        dgv.ColumnHeadersVisible = True ' para que se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila

        'dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each c As DataGridViewColumn In dgv.Columns
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        With (dgv)
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

        With dgv.DefaultCellStyle
            .Font = New Font("Tahoma", 9)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Black
            .SelectionBackColor = Color.LightBlue
        End With

    End Sub

    'Rellenar combobox
    Sub rellenacombobox(ByVal combo As ComboBox, ByVal sOracle As String, ByVal inicio As String)
        Dim Data As New DataSet
        Dim Search As New ConnectDB

        Data = Search.getData(sOracle, "tabla")
        Dim ttablas As DataTable = Data.Tables("tabla")
        If Not inicio = "" Then
            Dim newrow2 As DataRow = ttablas.NewRow()
            newrow2(0) = -1
            newrow2(1) = inicio
            ttablas.Rows.InsertAt(newrow2, 0)

        End If
        combo.DataSource = ttablas
        combo.DisplayMember = ttablas.Columns(1).ToString
        combo.ValueMember = ttablas.Columns(0).ToString

    End Sub

    'Rellenar combobox con cadena de String
    Sub rellenacomboboxStr(ByVal combo As ComboBox, ByVal cadena As String())

        Dim newrow2 As DataRow = Nothing

        Dim ttablas = New DataTable()
        Dim dcID = New DataColumn("ID", GetType(Int32))
        Dim dcName = New DataColumn("NAME", GetType(String))
        ttablas.Columns.Add(dcID)
        ttablas.Columns.Add(dcName)

        For i = 0 To cadena.Length - 1
            newrow2 = ttablas.NewRow()
            newrow2(0) = -1
            newrow2(1) = cadena(i)
            ttablas.Rows.InsertAt(newrow2, i)
        Next

        combo.DataSource = ttablas
        combo.DisplayMember = ttablas.Columns(1).ToString
        combo.ValueMember = ttablas.Columns(0).ToString

    End Sub


    'DANI -- 
    Public Sub control_login(ByVal txt As TextBox, ByVal lblError As Label,
                          ByVal e As System.Windows.Forms.KeyPressEventArgs)

        lblError.Text = ""

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And
            Not Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = True
            lblError.Text = "Sólo letras y números"
        End If

        If e.KeyChar.Equals(Keys.Space) Then
            e.Handled = True
            lblError.Text = "Sin espacios"
        End If

    End Sub

    Public Sub control_password_sinespacios(ByVal txt As TextBox, ByVal lblError As Label,
                      ByVal e As System.Windows.Forms.KeyPressEventArgs)

        lblError.Text = ""

        If e.KeyChar.Equals(Keys.Space) Then
            e.Handled = True
            lblError.Text = "Sin espacios"
        End If

    End Sub

    Public Sub control_solonums(ByVal txt As TextBox, ByVal lblError As Label,
                                            ByVal e As System.Windows.Forms.KeyPressEventArgs,
                                            ByVal longitud As Integer)

        lblError.Text = ""

        If Not Convert.ToInt32(e.KeyChar) = 8 And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            lblError.Text = "Sólo números sin decimales"
        End If

        If txt.TextLength >= longitud Then
            lblError.Text = "10 cifras máximo"
        End If

    End Sub

    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    ' Check if the string only consists of spaces
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return isEmpty
    End Function

    'Estilo a utilizar en la tablas
    Sub estilodgvArtDani(ByVal dgv As DataGridView)

        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False ' para que no se muestre la ultima fila en blanco
        dgv.ColumnHeadersVisible = True ' para que se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila

        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each c As DataGridViewColumn In dgv.Columns
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        With (dgv)
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

        With dgv.DefaultCellStyle
            .Font = New Font("Tahoma", 9)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Black
            .SelectionBackColor = Color.LightBlue
        End With

    End Sub


    Function ValorAlfabeticoNumerico(ByVal CodigoTecla As Integer) As Boolean
        If (CodigoTecla > 47 And CodigoTecla < 58) Or (CodigoTecla > 64 And CodigoTecla < 91) Or (CodigoTecla > 96 And CodigoTecla < 123) Or CodigoTecla = 163 Or CodigoTecla = 164 Or CodigoTecla = 8 Or CodigoTecla = 32 Or CodigoTecla = 45 Then
            ValorAlfabeticoNumerico = True
        Else
            If CodigoTecla = 22 Then
                MsgBox("No Puedes Pegar", vbCritical, "Error")
            End If

            ValorAlfabeticoNumerico = False

        End If


    End Function

    Function ValorAlfabetico(ByVal CodigoTecla As Integer) As Boolean
        If (CodigoTecla > 64 And CodigoTecla < 91) Or (CodigoTecla > 96 And CodigoTecla < 123) Or CodigoTecla = 163 Or CodigoTecla = 164 Or CodigoTecla = 8 Or CodigoTecla = 32 Or CodigoTecla = 45 Then
            ValorAlfabetico = True
        Else
            If CodigoTecla = 22 Then
                MsgBox("No Puedes Pegar", vbCritical, "Error")
            End If

            ValorAlfabetico = False

            End If
    End Function

    Function ValorNumerico(ByVal CodigoTecla As Integer) As Boolean
        If (CodigoTecla > 47 And CodigoTecla < 58) Then
            ValorNumerico = True
        Else
            ValorNumerico = False
        End If
    End Function

    'Quita a todos los campos de texto el menu que se despliega con el click derecho
    Public Sub inhabilitaClickDerecho(ByRef txtCaja As TextBox)
        Dim contextmenusts As New ContextMenuStrip
        txtCaja.ContextMenuStrip = contextmenusts
    End Sub


    ' MÉTODOS PARA GESTIONAR LOS COMBOBOX COMUNIDAD, PROVINCIA, POBLACIÓN Y CP QUE APARECEN A LO LARGO DEL PROGRAMA.

    ' Ante un cambio en un combobox de comunidades autónomas, desencadena el evento.
    Public Sub cambioComboComunidades(ByRef cboComunidades As ComboBox, ByRef cboProvincia As ComboBox, ByRef cboPoblacion As ComboBox, ByRef cboCodigoPostal As ComboBox, ByRef tip As ToolTip, ByRef pboxComunidadAcierto As PictureBox, ByRef pboxComunidadFallo As PictureBox, ByRef pboxProvinciaAcierto As PictureBox, ByRef pboxProvinciaFallo As PictureBox, ByRef pboxPoblacionAcierto As PictureBox, ByRef pboxPoblacionFallo As PictureBox, ByRef pboxCPAcierto As PictureBox, ByRef pboxCPFallo As PictureBox)

        'si la comomunidad seleccionada es "Seleccione Comunidad"
        If (cboComunidades.SelectedValue = -1) Then
            pboxComunidadAcierto.Visible = False
            pboxComunidadFallo.Visible = True
            pboxProvinciaFallo.Visible = True
            pboxProvinciaAcierto.Visible = False
            pboxPoblacionAcierto.Visible = False
            pboxPoblacionFallo.Visible = True
            pboxCPAcierto.Visible = False
            pboxCPFallo.Visible = True
            cboProvincia.SelectedIndex = 0
        Else
            
            pboxComunidadAcierto.Visible = True
            pboxComunidadFallo.Visible = False
            pboxProvinciaFallo.Visible = True
            pboxProvinciaAcierto.Visible = False
            pboxPoblacionAcierto.Visible = False
            pboxPoblacionFallo.Visible = True
            pboxCPAcierto.Visible = False
            pboxCPFallo.Visible = True
        End If
        Dim sSql As String = ("Select distinct idprovincia, provincia from provincias " & _
                                  "where refcomunidad = " & cboComunidades.SelectedValue())
        rellenacombobox(cboProvincia, sSql, "-- Seleccione Provincia -- ")
        If (cboProvincia.Items.Count = 2) Then
            cboProvincia.SelectedIndex = 1
        Else
            If cboProvincia.Items.Count > 0 Then
                cboProvincia.SelectedIndex = 0
            End If
        End If
        cambioComboProvincias(cboProvincia, cboPoblacion, cboCodigoPostal, tip, pboxProvinciaAcierto, pboxProvinciaFallo, pboxPoblacionAcierto, pboxPoblacionFallo, pboxCPAcierto, pboxCPFallo)


    End Sub

    ' Ante un cambio en un combobox de provincias, desencadena el evento.
    Public Sub cambioComboProvincias(ByRef cboProvincia As ComboBox, ByRef cboPoblacion As ComboBox, ByRef cboCodigoPostal As ComboBox, ByRef tip As ToolTip, ByRef pboxProvinciaAcierto As PictureBox, ByRef pboxProvinciaFallo As PictureBox, ByRef pboxPoblacionAcierto As PictureBox, ByRef pboxPoblacionFallo As PictureBox, ByRef pboxCPAcierto As PictureBox, ByRef pboxCPFallo As PictureBox)
        If (cboProvincia.SelectedValue = -1) Then
            tip.Show("Seleccione una provincia", cboProvincia)
            pboxProvinciaFallo.Visible = True
            pboxProvinciaAcierto.Visible = False
            pboxPoblacionAcierto.Visible = False
            pboxPoblacionFallo.Visible = True
            If cboPoblacion.Items.Count > 0 Then
                cboPoblacion.SelectedIndex = 0
            End If
        Else
            pboxProvinciaFallo.Visible = False
            pboxProvinciaAcierto.Visible = True
            pboxPoblacionAcierto.Visible = False
            pboxPoblacionFallo.Visible = True
            pboxCPAcierto.Visible = False
            pboxCPFallo.Visible = True
            tip.Hide(cboProvincia)
        End If
        Dim sSql As String = ("Select distinct idpoblacion, poblacion from codigospostalespoblaciones, poblaciones " & _
                              "where refprovincia = " & cboProvincia.SelectedValue() & _
                              " and refpoblacion = idpoblacion order by poblacion")

        rellenacombobox(cboPoblacion, sSql, "-- Seleccione poblacion --")
        
        If (cboPoblacion.Items.Count = 2) Then
            cboPoblacion.SelectedIndex = 1
        Else
            If cboPoblacion.Items.Count > 0 Then
                cboPoblacion.SelectedIndex = 0
            End If
        End If
        cambioComboPoblacion(cboProvincia, cboPoblacion, cboCodigoPostal, tip, pboxPoblacionAcierto, pboxPoblacionFallo, pboxCPAcierto, pboxCPFallo)


    End Sub

    ' Ante un cambio en un combobox de población, desencadena el evento.
    Public Sub cambioComboPoblacion(ByRef cboProvincia As ComboBox, ByRef cboPoblacion As ComboBox, ByRef cboCodigoPostal As ComboBox, ByRef tip As ToolTip, ByRef pboxPoblacionAcierto As PictureBox, ByRef pboxPoblacionFallo As PictureBox, ByRef pboxCPAcierto As PictureBox, ByRef pboxCPFallo As PictureBox)
        If (cboPoblacion.SelectedValue = -1) Then
            tip.Show("Seleccione una poblacion", cboPoblacion)
            pboxPoblacionAcierto.Visible = False
            pboxPoblacionFallo.Visible = True
            pboxCPAcierto.Visible = False
            pboxCPFallo.Visible = True
            If cboCodigoPostal.Items.Count > 0 Then
                cboCodigoPostal.SelectedIndex = 0
            End If
        Else
            pboxPoblacionAcierto.Visible = True
            pboxPoblacionFallo.Visible = False

            pboxCPAcierto.Visible = True
            pboxCPFallo.Visible = False
        End If
        Dim sSql = ("Select distinct idcodigopostal, codigopostal from codigospostalespoblaciones, codigospostales, provincias " & _
                                "where refpoblacion = " & cboPoblacion.SelectedValue() & _
                                " and refprovincia=" & cboProvincia.SelectedValue() & " and refcodigopostal = idcodigopostal and " & _
                                "refprovincia = idprovincia")

        rellenacombobox(cboCodigoPostal, sSql, " -- Seleccione CP -- ")
        If (cboCodigoPostal.Items.Count = 2) Then
            cboCodigoPostal.SelectedIndex = 1
        Else
            If cboCodigoPostal.Items.Count > 0 Then
                cboCodigoPostal.SelectedIndex = 0
            End If
        End If

    End Sub

    ' Operación disponible para cualquier usuario.
    ' Genera un xml que será una copia de seguridad de una tabla concreta de la BBDD.
    Public Sub generarCopiaSeguridadParcialEnXML(ByVal nombre As String, ByVal tabla As String)
        Dim respuesta As MsgBoxResult
        Dim mensaje As String = "¿Está usted seguro de querer realizar una copia de seguridad de la tabla " & tabla.ToUpper & "?"
        respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            MetodosComunesXML.guardaContenidoTablaBDenXML(nombre, tabla)
            insertarCambio("Copia de seguridad parcial creada de la tabla " & tabla.ToUpper & " creada", 0)
            MsgBox("Copia de Seguridad Parcial de la tabla " & tabla.ToUpper & " realizada con éxito")
        End If
    End Sub

    ' Operación disponible para cualquier usuario.
    ' Genera un xml que será una copia de seguridad de una tabla concreta de la BBDD.
    Public Sub generarCopiaSeguridadParcialEnXML(ByVal nombre As String, ByVal sentencia As String, ByVal tabla As String)
        Dim respuesta As MsgBoxResult
        Dim mensaje As String = "¿Está usted seguro de querer realizar una copia de seguridad de " & tabla.ToUpper & "?"
        respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            MetodosComunesXML.guardaConsultaUnaUnicaTablaBDenXML(nombre, sentencia, tabla)
            insertarCambio("Copia de seguridad parcial creada de la tabla " & tabla.ToUpper & " creada", 0)
            MsgBox("Copia de Seguridad Parcial de la tabla " & tabla.ToUpper & " realizada con éxito")
        End If
    End Sub


    ' Opción solo disponible para el administrador.
    ' Genera varios xml con copias de seguridad de la BBDD.
    ' No se incluyen copias de codigos postales, poblaciones, provincias, comunidades autónomas ni tablas que las relacionan entre sí.
    Public Sub generaCopiaSeguridadGeneralEnXML()
        Dim respuesta As MsgBoxResult
        Dim mensaje As String = "Señor administrador, ¿está usted seguro de querer realizar una copia de seguridad general?"
        respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_articulos.xml", "articulos")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_cambios.xml", "cambios")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_clientes.xml", "clientes")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_formasdepago.xml", "formasdepago")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_pedidos.xml", "pedidos")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_pedidosarticulos.xml", "pedidosarticulos")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_proveedores.xml", "proveedores")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_relacionarticulos.xml", "relacionarticulos")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_tipos.xml", "tipos")
            MetodosComunesXML.guardaContenidoTablaBDenXML("SEG_GENERAL_usuarios.xml", "usuarios")
            insertarCambio("Copia de seguridad general creada", 0)
            MsgBox("Copia de Seguridad General de la Base de Datos realizada con éxito")
        End If
    End Sub

    Public Function numNuevaFactura() As Integer

        Dim search As ConnectDB = New ConnectDB
        
        If TypeOf search.DLookUp("max(numfactura)", "facturas_clientes", "") Is DBNull Then
            Dim numero As String = Year(DateTime.Now) & "001"
            Return Integer.Parse(numero)
        Else
            Return (search.DLookUp("max(numfactura)", "facturas_clientes", "") + 1)
        End If

    End Function

    Public Sub crearFacturaDesdePedidos(ByVal idpedido As Integer, ByVal idusuario As Integer)

        Dim search As ConnectDB = New ConnectDB
        Dim data As DataSet = New DataSet

        Dim idfactura As Integer
        Dim num As Integer
        Dim fecha As Integer
        Dim hora As Integer
        Dim importeneto As Double
        Dim importetotal As Double
        Dim contabilizada As Integer

        'Seleccionar el id de la factura
        If TypeOf search.DLookUp("max(idfactura)", "facturas_clientes", "") Is DBNull Then
            idfactura = 1
        Else
            idfactura = (search.DLookUp("max(idfactura)", "facturas_clientes", "") + 1)
        End If

        'Num de la factura
        num = numNuevaFactura()

        'Fecha de la factura
        fecha = Fecha2number(Date.Now)

        'Hora de la factura
        hora = hora2number(Date.Now)

        'Referencia al cliente al que va referido
        Dim cliente As Integer
        cliente = (search.DLookUp("refcliente", "pedidos_clientes", " idpedido like '" & idpedido & "'"))

        importeneto = 0.0

        importetotal = 0.0

        'Contabilizada
        contabilizada = 1


        'Insert de Factura
        con.setData("insert into facturas_clientes (idfactura,numfactura, fecha, hora, refcliente, refusuario, importeneto, importetotal, contabilizada) " &
                    "VALUES(" & idfactura & "," & num & "," & fecha & "," & hora & "," & cliente & "," & idusuario & ",'" & importeneto & "','" & importetotal & "', 0)")



        '---------------------------------------------------------------------------------------------------------------

        'Llamada al metodo generadDetallesFacturaPedidos
        generarDetallesFacturaPedidos(idpedido, idfactura)


        '----------------------------------------------------------------------------------------------------------------

        'Insertar en la tabla las referencias facturas y pedidos

        'Id ref
        Dim idref As Integer
        If TypeOf search.DLookUp("max(id)", "relacion_facturas_pedclientes", "") Is DBNull Then
            idref = 1
        Else
            idref = (search.DLookUp("max(id)", "relacion_facturas_pedclientes", "") + 1)
        End If

        'Insert
        con.setData("insert into relacion_facturas_pedclientes (id,refpedido, reffactura) " &
                    "VALUES(" & idref & "," & idpedido & ",'" & idfactura & "')")

        '-----------------------------------------------------------------------------------------------------------------

    End Sub

    'Metodo que genera unos Detalles de factura, dependiendo del id de un pedido

    Public Sub generarDetallesFacturaPedidos(ByVal idPedido As Integer, ByVal reffacturapas As Integer)

        Dim search As ConnectDB
        Dim data As DataSet
        search = New ConnectDB
        data = New DataSet


        'Declaracion Atributos
        Dim idfacturadetalles As Integer
        Dim refFactura As Integer = reffacturapas
        Dim concepto As String
        Dim cantidad As Integer
        Dim importenetounitario As Double
        Dim importenetototal As Double

        'Sacar los valores del Detallepedido
        data = search.getData("select articulos.nombre, pedidos_clientes_articulos.cantidad_obtenida, pedidos_clientes_articulos.precioventa from articulos, pedidos_clientes_articulos where articulos.idarticulo = pedidos_clientes_articulos.refarticulo", "tdetalles")
        Dim tDetalles As DataTable = data.Tables("tdetalles")



        'Establecer los valores y hacer el insert
        For Each row As DataRow In tDetalles.Rows

            'Id
            If TypeOf search.DLookUp("max(id)", "facturas_clientes_detalles", "") Is DBNull Then
                idfacturadetalles = 1
            Else
                idfacturadetalles = (search.DLookUp("max(id)", "facturas_clientes_detalles", "") + 1)
            End If

            'Concepto
            concepto = row(0).ToString
            'Cantidad
            cantidad = Integer.Parse(row(1).ToString)
            'ImporteUnitario
            Try
                importenetounitario = Convert.ToDouble(row(2).ToString)
            Catch ex As Exception
                MsgBox("Error al ejecutar un double")
            End Try

            'Importetotal
            importenetototal = cantidad * importenetounitario


            'Insert
            con.setData("insert into facturas_clientes_detalles (id,reffactura, concepto, cantidad, importenetounitario, importenetototal) " &
                        "VALUES(" & idfacturadetalles & "," & refFactura & ",'" & concepto & "'," & cantidad & "," & importenetounitario & "," & importenetototal & ")")

        Next


        '-------------------------------------------------------------------------------------------------------------------------------------

        'Hago un update en la factura para calcular el neto y el total

        Dim importeneto As Double
        Dim importetotal As Double

        'Importe Neto
        If TypeOf search.DLookUp("sum(importenetototal)", "facturas_clientes_detalles", "reffactura like '" & refFactura & "'") Is DBNull Then
            importeneto = 0
        Else
            importeneto = (search.DLookUp("sum(importenetototal)", "facturas_clientes_detalles", "reffactura like '" & refFactura & "'") + 1)
        End If

        'Importe Total
        importetotal = importeneto + (importeneto * iva)


        search.setData("update facturas_clientes set importeneto = '" & importeneto & "', importetotal = '" & importetotal & "' where idfactura = " & refFactura)


    End Sub

End Module
