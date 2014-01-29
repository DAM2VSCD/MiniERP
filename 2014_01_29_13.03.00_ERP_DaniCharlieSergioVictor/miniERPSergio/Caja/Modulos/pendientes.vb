Module pendientes
    Public Sub nuevo()
        insertaDeudaPendiente(1)
    End Sub

    Public Sub modificar()

    End Sub

    Public Sub filtro()
        cargarDGVDeudas_Pendientes(1)
    End Sub

    Public Sub comprobarValores()
        compruebaValores(1)
    End Sub

    Public Sub generarXML()
        ' Esto lo hace de toda la tabla CAJA_COBRODEUDAS.
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_pendientesYdeudas.xml", "CAJA_COBRODEUDAS")

        ' Esto lo haría solo de los que son del tipo pendientes (tipo = 1).
        'guardaConsultaUnaUnicaTablaBDenXML("SEG_PARCIAL_pendientesSolo.xml", "SELECT * FROM CAJA_COBRODEUDAS WHERE TIPO=1", "CAJA_COBRODEUDAS")
    End Sub

    Public Sub rectificarRegistroErroneo(ByVal idACambiar As Integer)
        creaDeudaPendienteOpuesta(idACambiar, 1)
    End Sub

End Module
