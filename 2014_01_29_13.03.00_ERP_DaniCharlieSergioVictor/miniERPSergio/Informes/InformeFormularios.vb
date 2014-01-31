Public Class InformeFormularios

    Dim data As New DataSet
    Dim tclientes As New DataTable


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Try
            tclientes.Columns.Add("Concepto", Type.GetType("System.String"))
            tclientes.Columns.Add("Fecha", Type.GetType("System.String"))
        Catch ex As Exception

        End Try


        data = conexion.getData("select descripcion, fecha , hora from cambios where tipo like 'V' order by fecha, hora", "Validaciones")
        Dim tmp As DataTable = Data.Tables("Validaciones")
        Dim fechayhora As String

        Dim estado As Integer = (calculaEntradas() + calculaPendienteCobro()) - (calcularSalidas() + calculaDeudas())

        For Each row As DataRow In tmp.Rows
            fechayhora = number2Date(Integer.Parse(row(1).ToString), Integer.Parse(row(2).ToString))
            tclientes.Rows.Add(New Object() {row(0), fechayhora})
        Next
        ' tclientes.Rows.Add(New Object() {"Luis", "Ayuga"})
        Dim miReporte As New CrystalReport1

        miReporte.Database.Tables("DataTable1").SetDataSource(tclientes)
        miReporte.SetParameterValue(0, estado & "€          " & estadoEmpresa(estado)) ' Resultado de la empresa.

        CrystalReportViewer1.ReportSource = miReporte

    End Sub

    'Metodo de calcular las Entradas
    Private Function calculaEntradas() As Double

        'Efectivo
        Dim Entradas As Double

        Try
            Entradas = devuelveDouble(conexion.DLookUp("sum(importe)", "caja_apuntes", "tipoapunte like 'E'"))
        Catch ex As Exception
            Entradas = 0.0
        End Try

        Return Entradas

    End Function

    'Metodo que calcula las Salidas
    Private Function calcularSalidas() As Double

        Dim Salidas As Double

        Try
            Salidas = devuelveDouble(conexion.DLookUp("sum(importe)", "caja_apuntes", "tipoapunte like 'S'"))
        Catch ex As Exception
            Salidas = 0.0
        End Try

        Return salidas

    End Function

    'Metodo que devuelve un double a partir de un String
    Private Function devuelveDouble(ByVal cadena As String) As Double

        Dim array() = cadena.ToCharArray
        Dim numeroAconvertir As String = ""

        For i As Integer = 0 To array.Length - 1

            If array(i) = "," Then
                array(i) = "."
            End If

            numeroAconvertir = numeroAconvertir + array(i)

        Next

        Return CDbl(Val(numeroAconvertir))

    End Function

    'Metodo de calcular los Pendientes de Cobro
    Private Function calculaPendienteCobro() As Double

        'Efectivo
        Dim Cobros As Double

        Try
            Cobros = devuelveDouble(conexion.DLookUp("sum(importe)", "caja_cobrodeudas", "tipo like '1'"))
        Catch ex As Exception
            Cobros = 0.0
        End Try

        Return Cobros

    End Function

    'Metodo de calcular las Deudas
    Private Function calculaDeudas() As Double

        'Efectivo
        Dim Deudas As Double

        Try
            Deudas = devuelveDouble(conexion.DLookUp("sum(importe)", "caja_cobrodeudas", "tipo like '0'"))
        Catch ex As Exception
            Deudas = 0.0
        End Try

        Return Deudas

    End Function

    'Metodo que calcula si el estado de la empresa es positivo o negativo
    Private Function estadoEmpresa(ByVal i As Double) As String
        If i > 0 Then
            Return "La empresa está obteniendo beneficios actualmente"
        ElseIf i = 0 Then
            Return "La empresa no está obteniendo beneficios ni pérdidas actualmente"
        Else
            Return "La empresa está sufriendo pérdidas actualmente"
        End If
    End Function

End Class