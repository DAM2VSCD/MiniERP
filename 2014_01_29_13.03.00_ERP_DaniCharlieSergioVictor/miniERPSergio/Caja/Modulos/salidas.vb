Module salidas
    Public Sub nuevo()

        Dim consultasql As String

        Dim fecha_insert As Integer = Fecha2number(frmNuevoCaja.dtpInicio.Value)
        Dim hora_insert As Integer = hora2number(frmNuevoCaja.dtpInicio.Value)

        Dim importeParcial As String = frmNuevoCaja.txtImporte.Text.Trim
        Dim importeString As String = ""

        Dim myChar As Char = "0"
        For i = 0 To importeParcial.Length - 1
            myChar = importeParcial.Chars(i)
            If myChar = "." Then
                importeString += ","
            Else
                importeString += myChar
            End If
        Next

        Dim importe As Double = Convert.ToDouble(importeString)


        If importe > frmCaja.ppEfectivo And frmNuevoCaja.cboTipo.SelectedValue.ToString = 1 Then
            MsgBox("La operación solicitada dejaría el efectivo en negativo, luego no puede realizarse")
            frmNuevoCaja.ppSeQuedariaSaldoNegativo = True
        Else
            frmNuevoCaja.ppSeQuedariaSaldoNegativo = False
            consultasql = "insert into caja_apuntes (tipoapunte, proced_destino, tipo_pago, concepto, importe, fecha, hora, usuario) values " & _
            "('S'," & frmNuevoCaja.cboProDes.SelectedValue.ToString & ", " &
                     "" & frmNuevoCaja.cboTipo.SelectedValue.ToString & ",'" & frmNuevoCaja.txtConcepto.Text & "','" & importe & "'," &
                     "" & fecha_insert & "," & hora_insert & ", " & idUsuario & ")"

            conexion.setData(consultasql)

            MsgBox("Apunte grabado")

            filtro()
        End If

        
        'frmNuevoCaja.Dispose()

    End Sub

    Public Sub filtro()
        'Filtra el dgv de frmCaja

        filtroES("S")
    End Sub

    Public Sub comprobarValores()
        'Comprueba los valores introducidos en  frmNuevoCaja

        compruebaES()
    End Sub

    Public Sub generarXML()
        'Lo haría de entradas y salidas
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_EntradasYSalidas.xml", "CAJA_APUNTES")
    End Sub

    Public Sub rectificarRegistroErroneo(ByVal idACambiar As Integer)
        creaEntradaSalidaOpuesta(idACambiar)
    End Sub

End Module
