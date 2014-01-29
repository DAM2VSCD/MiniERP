Module validar

    Dim search As ConnectDB = New ConnectDB
    Dim data As DataSet = New DataSet


    Public Sub validar()

        Try
            '----------------------FINALIZADO-----------------------------------------------

            Dim saldo As String = frmCaja.txtTotal.Text

            insertarCambio("Validación de caja: " & saldo, "V")

            MsgBox("Datos Validados")

            filtro()

        Catch ex As Exception
            MsgBox("No hay ningun registro de entrada o salida")
        End Try

    End Sub

    'Metodo que muestra el contenido en la tabla
    Public Sub filtro()

        For i As Integer = 0 To frmCaja.dgvCaja.ColumnCount
            frmCaja.dgvCaja.Columns.Clear()
        Next

        frmCaja.dgvCaja.Columns.Add("usuario", "Usuario")
        frmCaja.dgvCaja.Columns.Add("fecha", "Fecha")
        frmCaja.dgvCaja.Columns.Add("hora", "Hora")
        frmCaja.dgvCaja.Columns.Add("saldo", "Saldo")

        Dim fechayhora As Date

        data = search.getData("select usuarios.nombre, cambios.fecha, cambios.hora, cambios.descripcion from usuarios , cambios where usuarios.idusuario = cambios.refusuario and cambios.tipo like 'V' order by fecha desc, hora desc", "tproveedores")
        Dim tProveedores As DataTable = data.Tables("tproveedores")

        estilodgvArtDani(frmCaja.dgvCaja)

        For i As Integer = 0 To frmCaja.dgvCaja.ColumnCount
            frmCaja.dgvCaja.Rows.Clear()
        Next

        Dim fila As String()

        For Each row As DataRow In tProveedores.Rows

            fechayhora = number2Date(Integer.Parse(row(1).ToString), Integer.Parse(row(2).ToString))

            fila = {row(0).ToString, FormatDateTime(fechayhora, DateFormat.ShortDate), fechayhora.TimeOfDay.ToString, row(3).ToString}

            frmCaja.dgvCaja.Rows.Add(fila)

        Next

    End Sub

    'Metodo que rellena los campos con los valor obtenidos distinguiendo por tipo_pago y por tipoapunte
    Public Sub mostrarTotal()

        'filtro()

        'Efectivo
        Dim efectivoEntradas As Double
        Dim efectivoSalidas As Double
        Dim TipoEfectivo As String

        Try
            TipoEfectivo = search.DLookUp("id", "caja_tipospago", "descripcion like 'Efectivo'")
            efectivoEntradas = devuelveDouble(search.DLookUp("sum(importe)", "caja_apuntes", "tipo_pago like '" & TipoEfectivo & "' and tipoapunte like 'E'"))
        Catch ex As Exception
            efectivoEntradas = 0.0
        End Try

        Try
            TipoEfectivo = search.DLookUp("id", "caja_tipospago", "descripcion like 'Efectivo'")
            efectivoSalidas = devuelveDouble(search.DLookUp("sum(importe)", "caja_apuntes", "tipo_pago like '" & TipoEfectivo & "' and tipoapunte like 'S'"))
        Catch ex As Exception
            efectivoSalidas = 0.0
        End Try
        frmCaja.ppEfectivo = efectivoEntradas - efectivoSalidas

        'Cheque
        Dim chequeEntradas As Double
        Dim chequeSalidas As Double
        Dim cheque As Double
        Dim TipoCheque As String

        Try
            TipoCheque = search.DLookUp("id", "caja_tipospago", "descripcion like 'Cheque'")
            chequeEntradas = devuelveDouble(search.DLookUp("sum(importe)", "caja_apuntes", "tipo_pago like '" & TipoCheque & "' and tipoapunte like 'E'"))
        Catch ex As Exception
            chequeEntradas = 0.0
        End Try

        Try
            TipoCheque = search.DLookUp("id", "caja_tipospago", "descripcion like 'Cheque'")
            chequeSalidas = devuelveDouble(search.DLookUp("sum(importe)", "caja_apuntes", "tipo_pago like '" & TipoCheque & "' and tipoapunte like 'S'"))
        Catch ex As Exception
            chequeSalidas = 0.0
        End Try
        cheque = chequeEntradas - chequeSalidas

        'Concepto
        Dim conceptoEntradas As Double
        Dim conceptoSalidas As Double
        Dim concepto As Double
        Dim TipoConcepto As String

        Try
            TipoConcepto = search.DLookUp("id", "caja_tipospago", "descripcion like 'Recibo'")
            conceptoEntradas = devuelveDouble(search.DLookUp("sum(importe)", "caja_apuntes", "tipo_pago like '" & TipoConcepto & "' and tipoapunte like 'E'"))
        Catch ex As Exception
            conceptoEntradas = 0.0
        End Try

        Try
            TipoConcepto = search.DLookUp("id", "caja_tipospago", "descripcion like 'Recibo'")
            conceptoSalidas = devuelveDouble(search.DLookUp("sum(importe)", "caja_apuntes", "tipo_pago like '" & TipoConcepto & "' and tipoapunte like 'S'"))
        Catch ex As Exception
            conceptoSalidas = 0.0
        End Try
        concepto = conceptoEntradas - conceptoSalidas

        'Metemos en los TxtBox los valores
        frmCaja.txtEfectivos.Text = frmCaja.ppEfectivo.ToString
        frmCaja.txtCheques.Text = cheque.ToString
        frmCaja.txtRecibos.Text = concepto.ToString

        Dim total As Double = frmCaja.ppEfectivo + cheque + concepto

        frmCaja.txtTotal.Text = total.ToString
        frmCaja.txtTotal2.Text = total.ToString

        'Comprueba si los valores son positivos 
        esPositivo(frmCaja.txtEfectivos)
        esPositivo(frmCaja.txtCheques)
        esPositivo(frmCaja.txtRecibos)
        esPositivo(frmCaja.txtTotal)
        esPositivo(frmCaja.txtTotal2)


    End Sub

    'Metodo esPositivo si el contenido de un TextBox pasado es positivo el color de la fuente es negro si no es rojo
    Private Sub esPositivo(ByVal a As TextBox)
        Try
            If (Convert.ToDouble(a.Text) < 0) Then
                'a.BackColor = System.Drawing.Color.Red
                a.ForeColor = System.Drawing.Color.Red
            Else
                'a.BackColor = System.Drawing.Color.Green
                a.ForeColor = System.Drawing.Color.Green
            End If
        Catch ex As Exception
            MsgBox("Revisar conversión de validar de String a double")
        End Try
        

    End Sub

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

    Public Sub generarXML()
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_validar.xml", "select * from cambios where tipo = 'V'", "CAMBIOS")
    End Sub

End Module