Public Class frmGenero

    Private idTipo As Integer

    Private Sub frmTiposArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        Me.TopMost = True

        cboEliminados.SelectedIndex = 0
        btnModificar.Enabled = False
        inhabilitaClickDerecho(txtNombre)
        actualizar()
    End Sub

    Private Sub actualizar()
        'Filtra por numero si hay algo introducido
        Dim nom As String = "%"
        If (Not txtNombre.Text.Equals("")) Then
            nom = txtNombre.Text.Trim()
        End If

        Dim eli = cboEliminados.SelectedIndex

        'dgvTipos.Rows.Clear()

        Dim consultaTexto As String = "SELECT IDTIPO, NOMBRE FROM TIPOS WHERE UPPER(NOMBRE) LIKE '" & nom.ToUpper & "%' AND ELIMINADO = " & eli & " ORDER BY IDTIPO"

        Dim request As DataSet = conexion.getData(consultaTexto, "tipo")

        Dim t As DataTable = request.Tables("tipo")

        dgvTipos.DataSource = t

        dgvTipos.Columns(0).Visible = False

        estilodgvArt(dgvTipos)
        dgvTipos.ReadOnly = True
        If dgvTipos.Rows.Count > 0 Then
            dgvTipos.Rows(0).Selected = True
            idTipo = dgvTipos.Rows(0).Cells(0).Value
            habilitarBotonesBorrarModificar(True)
        Else
            idTipo = -1
            habilitarBotonesBorrarModificar(False)
        End If
    End Sub

    Private Sub habilitarBotonesBorrarModificar(ByVal habilitar As Boolean)
        btnEliminar.Enabled = habilitar
        btnModificar.Enabled = habilitar
    End Sub

    ' Botón para añadir un nuevo tipo.
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim nuevo As frmGeneroNuevoModificar = New frmGeneroNuevoModificar(True, False)
        nuevo.Text = "Nuevo genero"
        nuevo.ShowDialog()
        actualizar()
    End Sub

    ' Botón para modificar un tipo existente.
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim nuevo As frmGeneroNuevoModificar = New frmGeneroNuevoModificar(False, idTipo)
        nuevo.Text = "Modificar genero"
        nuevo.ShowDialog()
        actualizar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub


    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        actualizar()
    End Sub

    Private Sub cboEliminados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEliminados.SelectedIndexChanged
        actualizar()
        If cboEliminados.SelectedIndex = 1 Then
            btnEliminar.Text = "Restaurar"
        Else
            btnEliminar.Text = "Eliminar"
        End If
    End Sub

    Private Sub dgvTipos_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvTipos.CellMouseClick
        If (e.RowIndex >= 0) Then
            idTipo = dgvTipos.Rows(e.RowIndex).Cells(0).Value
            nombre = dgvTipos.Rows(e.RowIndex).Cells(1).Value
            btnModificar.Enabled = True
        Else
            idTipo = -1
            nombre = ""
            btnModificar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result = MessageBox.Show("¿Seguro que desea completar la acción de borrado/restauración?", "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim numero As Integer = 0
            Dim cadenaTexto As String = "restaurado"
            Dim tipoAccion As String = "restauración"
            If cboEliminados.SelectedIndex = 0 Then
                tipoAccion = "borrado"
                numero = 1
                cadenaTexto = "eliminado"
            End If
            Dim sentencia As String = "UPDATE TIPOS SET ELIMINADO = " & numero & " WHERE IDTIPO = " & idTipo

            ' Ahora se elige el nombre para inventariar los cambios.
            conexion.setData(sentencia)
            sentencia = "SELECT NOMBRE FROM TIPOS WHERE IDTIPO=" & idTipo
            Dim Data As DataSet = Comun.conexion.getData(sentencia, "CAM")
            Dim t As DataTable = Data.Tables("CAM")
            Dim filaAqui As DataRow = t.Rows(0)
            Dim nombreAPoner As String = filaAqui("NOMBRE").ToString
            insertarCambio("Tipo " & nombreAPoner & " " & cadenaTexto, 0)
            MsgBox("La acción de " & tipoAccion & " se completó con éxito")
            actualizar()
        End If
    End Sub

    ' Crea una copia de seguridad en xml de la tabla FORMASDEPAGO
    Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_formasdepago.xml", "formasdepago")
    End Sub
End Class