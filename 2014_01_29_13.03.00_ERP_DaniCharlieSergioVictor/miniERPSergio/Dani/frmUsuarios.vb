Public Class frmUsuarios


    Private Sub frmUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = frmPrincipal

        'Aplicamos el estilo al dgv
        estilodgvArtDani(dgvUser)

        'Ponemos el valor por defecto del comboBox
        jcbTipoUser.SelectedIndex = 0

        actualiza_tabla()
    End Sub

    Private Sub txtUser_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        control_login(txtUser, lblErrorBusca, e)
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Dim frmNUser As frmNewUser

        'Llamamos al formulario de nuevoUsuario con el parámetro que indica que es nuevo.
        If IsDataGridViewEmpty(dgvUser) Then
            'Le pasamos un 2, ya que al estar vacía solo existirá el admin.
            frmNUser = New frmNewUser("N", 2)
        Else
            frmNUser = New frmNewUser("N", dgvUser.CurrentRow.Cells(0).Value)
        End If

        frmNUser.Text = "Nuevo Usuario"
        frmNUser.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnModif_Click(sender As System.Object, e As System.EventArgs) Handles btnModif.Click

        'Llamamos al formulario de nuevoUsuario con el parámetro que indica que es una modificación
        'y el nombre del usuario a modificar.
        If Not IsDataGridViewEmpty(dgvUser) Then
            Dim frmNUser As New frmNewUser("U", dgvUser.CurrentRow.Cells(0).Value)
            frmNUser.Text = "Modificar Usuario"
            frmNUser.pbErrorUser.Visible = False
            frmNUser.pbOkUser.Visible = True
            frmNUser.Show()
            Me.Enabled = False
        Else
            MsgBox("Tabla Vacía. No se puede modificar.")
        End If
        
    End Sub

    Private Sub btnElimina_Click(sender As System.Object, e As System.EventArgs) Handles btnElimina.Click

        'Comprobamos dataGrid no vacío.
        If Not IsDataGridViewEmpty(dgvUser) Then
            'Nos aseguramos de la elección
            Dim result = MessageBox.Show("¿Seguro que desea borrar el usuario?", "", MessageBoxButtons.YesNo)
            Dim pos As Integer

            If result = DialogResult.Yes Then
                'Obtenemos la posición
                pos = dgvUser.CurrentRow.Index

                'Lo marcamos como eliminado de la BBDD
                conexion.setData("update usuarios set eliminado = 1 where idusuario = " & dgvUser.CurrentRow.Cells(0).Value)

                MsgBox("Usuario eliminado")
                insertarCambio("Usuario eliminado", 0)
                actualiza_tabla()
            End If

        Else
            MsgBox("Tabla Vacía. No se puede eliminar.")
        End If

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub actualiza_tabla()

        'Filtra por nombre si hay algo introducido
        Dim comodin As String = "%"
        Dim nom = comodin
        If (Not txtUser.Text.Equals("")) Then
            nom = comodin & txtUser.Text & comodin
        End If

        'Rellenamos el dgv
        Dim request As New DataSet

        request = conexion.getData("SELECT idusuario, nombre FROM USUARIOS where eliminado =" &
                                   "" & jcbTipoUser.SelectedIndex & " and upper(nombre) like '" &
                                   "" & nom.ToUpper & "' and idusuario > 1", "USUARIOS")

        Dim t As DataTable = request.Tables("USUARIOS")

        dgvUser.DataSource = t

        dgvUser.Columns(0).Visible = False


        ''Si es la primera ejecución que no muestre el mensaje.
        'If primer_inicio Then
        'Else
        '    MsgBox("No hay usuarios.")
        'End If

    End Sub

    'Restaura usuarios eliminados.
    Private Sub btnRestaura_Click(sender As System.Object, e As System.EventArgs) Handles btnRestaura.Click

        'Comprobamos dataGrid no vacío.
        If Not IsDataGridViewEmpty(dgvUser) Then
            'Nos aseguramos de la elección
            Dim result = MessageBox.Show("¿Seguro que desea resturar el usuario?", "", MessageBoxButtons.YesNo)
            Dim pos As Integer

            If result = DialogResult.Yes Then
                'Obtenemos la posición
                pos = dgvUser.CurrentRow.Index

                'Lo marcamos como restaurado de la BBDD
                conexion.setData("update usuarios set eliminado = 0 where idusuario = " & dgvUser.CurrentRow.Cells(0).Value)

                MsgBox("Usuario eliminado")
                insertarCambio("Usuario eliminado", 0)
                actualiza_tabla()
            End If

        Else
            MsgBox("Tabla Vacía. No se puede eliminar.")
        End If

    End Sub

    Private Sub txtUser_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.TextChanged
        dgvUser.Columns(0).HeaderText = jcbTipoUser.SelectedItem.ToString
        actualiza_tabla()
    End Sub

    Private Sub jcbTipoUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jcbTipoUser.SelectedIndexChanged

        actualiza_tabla()

        'Según el elemento desactivamos nuevo, modificar, eliminar y activamos restaurar o viceversa.
        If jcbTipoUser.SelectedIndex = 1 Then
            act_desact_campos(False)
            btnRestaura.Enabled = True
        Else
            btnRestaura.Enabled = False
            act_desact_campos(True)
        End If

    End Sub

    'Activamos o desactivamos campos.
    Private Sub act_desact_campos(ByVal interruptor As Boolean)
        btnNuevo.Enabled = interruptor
        btnModif.Enabled = interruptor
        btnElimina.Enabled = interruptor
    End Sub

    Private Sub btnLisCamb_Click(sender As System.Object, e As System.EventArgs) Handles btnLisCamb.Click
        frmCambios.Show()
    End Sub
End Class
