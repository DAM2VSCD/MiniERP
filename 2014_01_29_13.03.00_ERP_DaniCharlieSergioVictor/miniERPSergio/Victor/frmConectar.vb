Public Class frmConectar


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub btnCancelar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Disposed
        'Habilita el menu principal si se cierra
        frmPrincipal.msMenu.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim nombre As String = txtNombre.Text 'Nombre
        Dim con As String = txtContraseña.Text 'Contraseña


        Dim Data As DataSet = conexion.getData("SELECT IDUSUARIO, NOMBRE, PASSWORD " & _
                                               "FROM USUARIOS WHERE NOMBRE='" & nombre & "'", "USU")

        Dim t As DataTable = Data.Tables("USU")

        If (t.Rows.Count > 0) Then 'Si devuelve algun usuario

            Dim value As String = t.Rows(0)(2) 'Contraseña devuelta

            'DANI
            Dim conCrypt = crypt.EncryptData(con)

            'Compara la contraseña introducida con la devuelta
            If (value.Equals(conCrypt)) Then

                idUsuario = t.Rows(0)(0) 'Guarda el id
                nombre = t.Rows(0)(1) 'Guarda el nombre
                Comun.nombre = nombre

                frmPrincipal.actualizarMenus()
                frmPrincipal.msMenu.Enabled = True

                insertarCambio("Inicio de sesión", 0)

                Dispose()
            Else
                MsgBox("Nombre o contraseña incorrectos")

            End If
        Else
            MsgBox("Nombre o contraseña incorrectos")
        End If

    End Sub

    Private Sub Conectar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal

        txtContraseña.PasswordChar = "*"
    End Sub
End Class