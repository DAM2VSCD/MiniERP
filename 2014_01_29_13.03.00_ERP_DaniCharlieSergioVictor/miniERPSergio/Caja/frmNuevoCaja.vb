Public Class frmNuevoCaja




    '
    '
    '
    'NO MODIFICAR ESTA CLASE UTILIZAR SOLO LOS MODULOS QUE YA ESTAN CREADOS
    '
    '
    '
    '









    Private seQuedariaSaldoNegativo As Boolean



    Private t As String 'Diferencia como se ha abierto 
    'E=entradas
    'S=Salidas
    'P=Pendientes
    'PM=Pendiente modificar
    'D=Deudas
    'DM=Deudas modficar

    ' Será true cuando se esté modificando una deuda o un pendiente de cobro.
    Private modificoPendienteDeuda As Boolean

    Public Property tipo As String
        Set(ByVal value As String)
            t = value
        End Set
        Get
            Return t
        End Get
    End Property

    Public Property ppModificoPendienteDeuda As Boolean
        Get
            Return modificoPendienteDeuda
        End Get
        Set(ByVal value As Boolean)
            modificoPendienteDeuda = value
        End Set
    End Property

    Public Property ppSeQuedariaSaldoNegativo As Boolean
        Get
            Return seQuedariaSaldoNegativo
        End Get
        Set(ByVal value As Boolean)
            seQuedariaSaldoNegativo = value
        End Set
    End Property

    Private Sub frmNuevoCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = frmPrincipal

        Me.ppModificoPendienteDeuda = False

        Me.ppSeQuedariaSaldoNegativo = False

        iniciar()

        actualizarCBO()


        'Añadido por DANI
        rellenatipo()
    End Sub

    Private Sub frmNuevoCaja_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        ' Línea necesaria para el caso en que se esté modificando una pendiente de cobro u una deuda.
        frmCaja.Enabled = True
        frmCaja.Focus()
        frmCaja.TopMost = True
        frmModificar_Pendiente_Deuda.Dispose()
        Me.lblMensajeTipoAccion.Text = ""
        Me.ppModificoPendienteDeuda = False
        Me.ppSeQuedariaSaldoNegativo = False
    End Sub


    'Filtra los objetos visibles
    Private Sub iniciar()
        cboProDes.SelectedIndex = 0
        cboTipo.SelectedIndex = 0

        pboxFechaAcierto.Visible = True
        pboxFechaFallo.Visible = False


        Select Case t
            'Entradas
            Case "E"
                lblProDes.Visible = True

                lblProDes.Text = "Procedencia:"

                cboProDes.Visible = True

                lblTipo.Visible = True
                cboTipo.Visible = True

                pboxConceptoAcierto.Visible = False
                pboxConceptoFallo.Visible = True

                pboxImporteAcierto.Visible = False
                pboxImporteFallo.Visible = True

                pboxProcedenciaAcierto.Visible = False
                pboxProcedenciaFallo.Visible = True

                pboxTipoAcierto.Visible = False
                pboxTipoFallo.Visible = True

                'Salidas
            Case "S"
                lblProDes.Visible = True

                lblProDes.Text = "Destino:"

                cboProDes.Visible = True

                lblTipo.Visible = True
                cboTipo.Visible = True

                pboxConceptoAcierto.Visible = False
                pboxConceptoFallo.Visible = True

                pboxImporteAcierto.Visible = False
                pboxImporteFallo.Visible = True

                pboxProcedenciaAcierto.Visible = False
                pboxProcedenciaFallo.Visible = True

                pboxTipoAcierto.Visible = False
                pboxTipoFallo.Visible = True
                'Pendientes
            Case "P", "PM"
                lblProDes.Visible = True

                lblProDes.Text = "Procedencia:"

                cboProDes.Visible = True

                lblTipo.Visible = False
                cboTipo.Visible = False

                pboxConceptoAcierto.Visible = False
                pboxConceptoFallo.Visible = True

                pboxImporteAcierto.Visible = False
                pboxImporteFallo.Visible = True

                pboxProcedenciaAcierto.Visible = False
                pboxProcedenciaFallo.Visible = True

                pboxTipoAcierto.Visible = False
                pboxTipoFallo.Visible = False

                'Deudas
            Case "D", "DM"
                lblProDes.Visible = False

                cboProDes.Visible = False

                lblTipo.Visible = False
                cboTipo.Visible = False

                pboxConceptoAcierto.Visible = False
                pboxConceptoFallo.Visible = True

                pboxImporteAcierto.Visible = False
                pboxImporteFallo.Visible = True

                pboxProcedenciaAcierto.Visible = False
                pboxProcedenciaFallo.Visible = False

                pboxTipoAcierto.Visible = False
                pboxTipoFallo.Visible = False

        End Select
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        ' Hay que poner esta condición porque de lo contrario recarga el dgv dos veces y hace un 
        ' efecto muy feo en pantalla.
        'If Me.ppModificoPendienteDeuda = False Then

        Select Case t
            'Entradas
            Case "E"
                entradas.nuevo()


                'Salidas
            Case "S"
                salidas.nuevo()

                'Pendientes
            Case "P"
                pendientes.nuevo()
            Case "PM"
                pendientes.modificar()

                'Deudas
            Case "D"
                deudas.nuevo()
            Case "DM"
                deudas.modificar()

        End Select

        'Else

        ' La única posibilidad de que se entre aquí es cuando se está modificando un pendiente de cobro o
        ' una deuda. Por lo tanto, tras realizar la operación hay que hacer dispose.

        If Me.ppSeQuedariaSaldoNegativo = False Then
            frmModificar_Pendiente_Deuda.realizaActualizacion()
            'frmModificar_Pendiente_Deuda.Dispose()

        End If

        If Me.ppModificoPendienteDeuda Then
            Me.Dispose()
        End If

        'End If

        validar.mostrarTotal()
        frmCaja.actualizarDGV()


    End Sub


    Private Sub comprobarValores()
        Select Case t
            'Entradas
            Case "E"
                entradas.comprobarValores()

                'Salidas
            Case "S"
                salidas.comprobarValores()

                'Pendientes
            Case "P"
                pendientes.comprobarValores()
            Case "PM"
                pendientes.comprobarValores()

                'Deudas
            Case "D"
                deudas.comprobarValores()
            Case "DM"
                deudas.comprobarValores()

        End Select
    End Sub


    Private Sub txtConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.TextChanged
        comprobarValores()
    End Sub

    Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        comprobarValores()
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        comprobarValores()
    End Sub

    Private Sub cboProcedencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProDes.SelectedIndexChanged
        comprobarValores()
    End Sub

    Private Sub cboProcedenciaPendientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        comprobarValores()
    End Sub

    Private Sub cboDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        comprobarValores()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        comprobarValores()
    End Sub

    Private Sub actualizarCBO()

        Dim sql As String = "select id, descripcion from caja_procedenciadestino where tipo="


        Select Case t
            'Entradas
            Case "E"
                rellenacombobox(cboProDes, sql & 0, "--Procedencia--")

                'Salidas
            Case "S"
                rellenacombobox(cboProDes, sql & 1, "--Destino--")

                'Pendientes
            Case "P"
                rellenacombobox(cboProDes, sql & 2, "--Procedencia--")
            Case "PM"
                rellenacombobox(cboProDes, sql & 2, "--Procedencia--")

        End Select

    End Sub

    '''''''''''''''
    '' MÉTODO HECHO POR DANI PARA CBOTIPO
    '''''''''''''''

    Private Sub rellenatipo()

        Dim sql As String = "select id, descripcion from caja_tipospago"

        rellenacombobox(cboTipo, sql, "--Tipos Pago--")


    End Sub

    '' ''''''
    '' FIN MÉTODO CBOTIPO
    '' ''''''

End Class