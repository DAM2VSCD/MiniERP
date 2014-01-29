Module deudas
    Public Sub nuevo()
        insertaDeudaPendiente(0)
    End Sub

    Public Sub modificar()

    End Sub

    Public Sub filtro()
        cargarDGVDeudas_Pendientes(0)
    End Sub

    Public Sub comprobarValores()
        compruebaValores(0)
    End Sub

    Public Sub generarXML()
        ' Esto lo hace de toda la tabla CAJA_COBRODEUDAS.
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_pendientesYdeudas.xml", "CAJA_COBRODEUDAS")

        ' Esto lo haría solo de los que son del tipo deudas (tipo = 0).
        'guardaConsultaUnaUnicaTablaBDenXML("SEG_PARCIAL_deudasSolo.xml", "SELECT * FROM CAJA_COBRODEUDAS WHERE TIPO=0", "CAJA_COBRODEUDAS")
    End Sub

    Public Sub rectificarRegistroErroneo(ByVal idACambiar As Integer)
        creaDeudaPendienteOpuesta(idACambiar, 0)
    End Sub


End Module
