Public Class frmCaja


    '
    '
    '
    'NO MODIFICAR ESTA CLASE UTILIZAR SOLO LOS MODULOS QUE YA ESTAN CREADOS
    '
    '
    '
    '


    ' Cantidad en efectivo que hay en cada momento.
    Private efectivo As Double

    Public Property ppEfectivo As Double
        Get
            Return efectivo
        End Get
        Set(ByVal value As Double)
            efectivo = value
        End Set
    End Property



    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = frmPrincipal
        dtpInicio.Enabled = False
        dtpFin.Enabled = False

        cbIntervalo.Enabled = False

        'AÑADIDO POR DANI
        inicioTabControl()


        validar.mostrarTotal()


    End Sub



    Private Sub frmCaja_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        tabControl.Height = Me.Height - 37
        tabControl.Width = Me.Width - 14
    End Sub

    Private Sub limpiarValores()
        cboImporte.SelectedIndex = 0
        cboProDes.SelectedIndex = 0
        'cboTipo.SelectedIndex = 0

        txtConcepto.Text = ""
        txtImporte.Text = ""

        dtpInicio.Enabled = False
        dtpFin.Enabled = False

        cbFecha.Checked = False
        cbIntervalo.Checked = False
        cbIntervalo.Enabled = False


        validar.mostrarTotal()
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Select Case tabControl.SelectedIndex
            'Entradas
            Case 0
                frmNuevoCaja.tipo = "E"
                frmNuevoCaja.Text = "Nueva entrada"
                frmNuevoCaja.lblTipoProblema.Text = "NUEVA ENTRADA"
                frmNuevoCaja.Show()


                'Salidas
            Case 1
                frmNuevoCaja.tipo = "S"
                frmNuevoCaja.Text = "Nueva salida"
                frmNuevoCaja.lblTipoProblema.Text = " NUEVA SALIDA"
                frmNuevoCaja.Show()

                'Pendientes
            Case 2
                frmNuevoCaja.tipo = "P"
                frmNuevoCaja.Text = "Pendientes de cobro"
                frmNuevoCaja.lblTipoProblema.Text = "NUEVO PENDIENTE DE COBRO"
                frmNuevoCaja.Show()
                'Deudas
            Case 3
                frmNuevoCaja.tipo = "D"
                frmNuevoCaja.Text = "Nueva deuda"
                frmNuevoCaja.lblTipoProblema.Text = "NUEVA DEUDA INSATISFECHA"
                frmNuevoCaja.Show()

        End Select

        validar.mostrarTotal()
        'actualizarDGV()
    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click
        validar.validar()
        validar.mostrarTotal()
    End Sub


    Public Sub actualizarDGV()
        Select Case tabControl.SelectedIndex
            'Entradas
            Case 0
                entradas.filtro()
                'Salidas
            Case 1
                salidas.filtro()
                'Pendientes
            Case 2
                pendientes.filtro()
                'Deudas
            Case 3
                deudas.filtro()
                'Validar
            Case 4
                validar.filtro()
        End Select
    End Sub
    Private Sub txtConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.TextChanged
        actualizarDGV()
    End Sub

    Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        actualizarDGV()
    End Sub

    Private Sub cboImporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboImporte.SelectedIndexChanged
        actualizarDGV()
    End Sub

    Private Sub cboProcedenciaPendientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizarDGV()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        actualizarDGV()
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        actualizarDGV()
    End Sub

    Private Sub dtpFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.ValueChanged
        actualizarDGV()
    End Sub


    Private Sub cboProcedencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProDes.SelectedIndexChanged
        actualizarDGV()
    End Sub

    Private Sub cboDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        actualizarDGV()
    End Sub



    Private Sub cbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
        If cbFecha.Checked Then

            dtpInicio.Enabled = True
            dtpFin.Enabled = False

            cbIntervalo.Enabled = True

        Else

            dtpInicio.Enabled = False
            dtpFin.Enabled = False

            cbIntervalo.Enabled = False
            cbIntervalo.Checked = False

        End If

        actualizarDGV()
    End Sub

    Private Sub cbIntervalo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIntervalo.CheckedChanged
        If cbIntervalo.Checked Then

            dtpFin.Enabled = True

        Else
            dtpFin.Enabled = False
        End If

        actualizarDGV()
    End Sub

    Private Sub actualizarCBO()

        Dim sql As String = "select id, descripcion from caja_procedenciadestino where tipo=" & tabControl.SelectedIndex
        Dim sqlTipo As String = "select id, descripcion from caja_tipospago"

        Select Case tabControl.SelectedIndex
            'Entradas
            Case 0
                rellenacombobox(cboProDes, sql, "--Procedencia--")
                rellenacombobox(cboTipo, sqlTipo, "--Tipos Pago--")
                'Salidas
            Case 1
                rellenacombobox(cboProDes, sql, "--Destino--")
                rellenacombobox(cboTipo, sqlTipo, "--Tipos Pago--")
                'Pendientes
            Case 2
                rellenacombobox(cboProDes, sql, "--Procedencia--")

        End Select




    End Sub

    Private Sub btnXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXML.Click
        Select Case tabControl.SelectedIndex
            'Entradas
            Case 0
                entradas.generarXML()
                'Salidas
            Case 1
                salidas.generarXML()
                'Pendientes
            Case 2
                pendientes.generarXML()
                'Deudas
            Case 3
                deudas.generarXML()

        End Select
    End Sub

    Private Sub btnTXTvalidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTXTvalidar.Click
        validar.generarXML()
    End Sub


    'AÑADIDO POR DANI - CONTROL DE CAMBIO DE PESTAÑA
    Private Sub tabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl.SelectedIndexChanged
        If tabControl.SelectedIndex = 0 Then
            lblProDes.Visible = True

            lblProDes.Text = "Procedencia:"
            lblTipoProblema.Text = "ENTRADAS"
            cboProDes.Visible = True

            lblTipo.Visible = True
            cboTipo.Visible = True

            limpiarValores()

            panel.Parent = tabEntradas

            btnModificarParcial.Visible = False
            btnModificarTotal.Visible = False


            actualizarCBO()
            actualizarDGV()
        ElseIf tabControl.SelectedIndex = 1 Then
            lblProDes.Visible = True

            lblProDes.Text = "Destino:"
            lblTipoProblema.Text = "SALIDAS"
            cboProDes.Visible = True

            lblTipo.Visible = True
            cboTipo.Visible = True

            limpiarValores()

            panel.Parent = tabSalidas

            btnModificarParcial.Visible = False
            btnModificarTotal.Visible = False

            actualizarCBO()
            actualizarDGV()
        ElseIf tabControl.SelectedIndex = 2 Then
            btnModificarParcial.Text = "Ingresar parcialmente"
            btnModificarTotal.Text = "Ingresar por completo"

            lblProDes.Visible = True

            lblProDes.Text = "Procedencia:"
            lblTipoProblema.Text = "PENDIENTES DE COBRO"
            cboProDes.Visible = True

            lblTipo.Visible = False
            cboTipo.Visible = False

            limpiarValores()

            panel.Parent = tabPendientes

            btnModificarParcial.Visible = True
            btnModificarTotal.Visible = True

            actualizarCBO()
            actualizarDGV()
        ElseIf tabControl.SelectedIndex = 3 Then
            btnModificarParcial.Text = "Reducir deuda"
            btnModificarTotal.Text = "Liquidar deuda"
            lblTipoProblema.Text = "DEUDAS INSATISFECHAS"

            lblProDes.Visible = False

            cboProDes.Visible = False

            lblTipo.Visible = False
            cboTipo.Visible = False

            limpiarValores()

            panel.Parent = tabDeudas

            btnModificarParcial.Visible = True
            btnModificarTotal.Visible = True

            actualizarCBO()
            actualizarDGV()
        Else
            actualizarDGV()
            lblTipoProblema.Text = "VALIDACIÓN"
        End If
    End Sub

    'AÑADIDO POR DANI
    Private Sub inicioTabControl()
        lblProDes.Visible = True

        lblProDes.Text = "Procedencia:"
        lblTipoProblema.Text = "ENTRADAS"

        cboProDes.Visible = True

        lblTipo.Visible = True
        cboTipo.Visible = True

        limpiarValores()

        panel.Parent = tabEntradas

        btnModificarParcial.Visible = False
        btnModificarTotal.Visible = False

        actualizarCBO()
        actualizarDGV()
    End Sub

    Private Sub btnModificarTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarTotal.Click
        If dgvCaja.Rows.Count > 0 Then
            ' Solo hará operaciones si al menos hay un registro en el dgv.

            ' Se hace comprobación para solventar el caso de que no haga click en el DGV.
            If dgvCaja.CurrentCell Is Nothing Then
                dgvCaja.CurrentCell = dgvCaja(1, 0)
            End If

            If dgvCaja.CurrentCell.RowIndex >= 0 Then
                ' Solo tiene sentido que entre si hay alguna celda seleccionada.

                ' Se captura el id del elemento seleccionado.
                Dim idElementoSeleccionado As Integer = dgvCaja.Item(0, dgvCaja.CurrentCell.RowIndex).Value

                frmModificar_Pendiente_Deuda.ppIdPendienteDeuda = idElementoSeleccionado

                Select Case tabControl.SelectedIndex

                    'Pendientes
                    Case 2
                        frmModificar_Pendiente_Deuda.ppTipoOperacionRealizar = 1
                        frmModificar_Pendiente_Deuda.Text = "Efectuar ingreso en caja"

                        'Deudas
                    Case 3
                        frmModificar_Pendiente_Deuda.ppTipoOperacionRealizar = 0
                        frmModificar_Pendiente_Deuda.Text = "Realizar liquidación de la deuda"

                End Select

                Me.Enabled = False

                ' Para evitar problemas a la hora de estanciar de nuevo el frame.
                If frmNuevoCaja.Visible Then
                    frmNuevoCaja.Dispose()
                End If

                frmModificar_Pendiente_Deuda.realizaUpdateenPendienteDeuda(frmModificar_Pendiente_Deuda.dameCantidadMaxima())
            Else
                MsgBox("No hay ningún elemento seleccionado")
            End If
        Else
            MsgBox("No hay ningún elemento seleccionado")
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarParcial.Click

        If dgvCaja.Rows.Count > 0 Then
            ' Solo hará operaciones si al menos hay un registro en el dgv.

            ' Se hace comprobación para solventar el caso de que no haga click en el DGV.
            If dgvCaja.CurrentCell Is Nothing Then
                dgvCaja.CurrentCell = dgvCaja(1, 0)
            End If

            If dgvCaja.CurrentCell.RowIndex >= 0 Then
                ' Solo tiene sentido que entre si hay alguna celda seleccionada.

                ' Se captura el id del elemento seleccionado.
                Dim idElementoSeleccionado As Integer = dgvCaja.Item(0, dgvCaja.CurrentCell.RowIndex).Value

                frmModificar_Pendiente_Deuda.ppIdPendienteDeuda = idElementoSeleccionado

                Select Case tabControl.SelectedIndex

                    'Pendientes
                    Case 2
                        frmModificar_Pendiente_Deuda.ppTipoOperacionRealizar = 1
                        frmModificar_Pendiente_Deuda.Text = "Efectuar ingreso en caja"

                        'Deudas
                    Case 3
                        frmModificar_Pendiente_Deuda.ppTipoOperacionRealizar = 0
                        frmModificar_Pendiente_Deuda.Text = "Realizar liquidación de la deuda"

                End Select

                Me.Enabled = False

                ' Para evitar problemas a la hora de estanciar de nuevo el frame.
                If frmNuevoCaja.Visible Then
                    frmNuevoCaja.Dispose()
                End If
                frmModificar_Pendiente_Deuda.Show()

            Else
                MsgBox("No hay ningún elemento seleccionado")
            End If
        Else
            MsgBox("No hay ningún elemento seleccionado")
        End If
    End Sub

    Private Sub btnCorregirError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorregirError.Click

        If dgvCaja.Rows.Count > 0 Then
            ' Solo hará operaciones si al menos hay un registro en el dgv.

            ' Se hace comprobación para solventar el caso de que no haga click en el DGV.
            If dgvCaja.CurrentCell Is Nothing Then
                dgvCaja.CurrentCell = dgvCaja(1, 0)
            End If

            If dgvCaja.CurrentCell.RowIndex >= 0 Then

                Dim respuesta As MsgBoxResult
                Dim mensaje As String = "¿Está seguro de querer corregir esta línea?"
                respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
                If (respuesta = MsgBoxResult.Yes) Then

                    Dim idAPasar = dgvCaja.Item(0, dgvCaja.CurrentCell.RowIndex).Value

                    Select Case tabControl.SelectedIndex
                        'Entradas
                        Case 0
                            entradas.rectificarRegistroErroneo(idAPasar)
                            'Salidas
                        Case 1
                            salidas.rectificarRegistroErroneo(idAPasar)
                            'Pendientes
                        Case 2
                            pendientes.rectificarRegistroErroneo(idAPasar)
                            'Deudas
                        Case 3
                            deudas.rectificarRegistroErroneo(idAPasar)

                    End Select

                Else
                    MsgBox("No hay ningún registro seleccionado en la tabla")
                End If
            Else
                MsgBox("No hay ningún registro seleccionado en la tabla")
            End If

        End If

    End Sub

    Private Sub btnGenerarInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarInforme.Click
        If MsgBox("¿Quiere realizar una validación antes de abrir el informe?", vbYesNo) = vbYes Then
            validar.validar()
        End If

        Try
            InformeFormularios.Show()
        Catch ex As Exception
        End Try

    End Sub
End Class