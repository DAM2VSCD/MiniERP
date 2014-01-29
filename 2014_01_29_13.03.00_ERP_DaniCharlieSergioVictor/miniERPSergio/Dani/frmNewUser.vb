Imports System.Text.RegularExpressions

Public Class frmNewUser

    'Declaración de variables
    Dim valida As Boolean
    Dim long_pass, long_pass_max, id_max_actual As Integer
    Dim id As Integer
    Dim selecc As String

    Public Sub New(ByVal tipo As String, id_actual As Integer)

        'Constructor
        InitializeComponent()
        selecc = tipo
        id = id_actual

        If tipo.Equals("U") Then
            Dim nom_usr = conexion.DLookUp("nombre", "USUARIOS", "idusuario = " & id)
            txtUser.Text = nom_usr
        End If


    End Sub

    Private Sub frmNewUser_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmUsuarios.Enabled = True
    End Sub

    Private Sub frmNewUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.MdiParent = frmPrincipal

        'Establecemos la longitud mínima de la pass
        long_pass = 6

        'Establecemos la longitud máxima de la pass
        long_pass_max = 10

        'Inicializamos el valor máximo del id de usuario.
        id_max_actual = 0

        'Rellenamos la etiqueta de información.
        lblInfo.Text = "El usuario debe" & vbCrLf & "tener entre " & vbCrLf & "6 y 30 car." & vbCrLf & vbCrLf & vbCrLf &
                   "La contraseña debe" & vbCrLf & "tener entre" & vbCrLf & long_pass & " y " & long_pass_max &
                   " carácteres." & vbCrLf & vbCrLf & "Entre ellos: mayúsculas," & vbCrLf & "minúsculas, algún" & vbCrLf &
                   "número y alguno" & vbCrLf & "de estos símbolos: " & vbCrLf & " @ # $ % ^ & + = _ " & vbCrLf & vbCrLf & ""

       
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtUser_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        'Ejecutamos el control de login para evitar espacios y símbolos no alfanuméricos.
        'También controlamos la longitud del nombre
        control_login(txtUser, lblErrorUser, e)
        If txtUser.TextLength >= 29 And Not Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = True
            lblErrorUser.Text = "Máximo 30 carácteres"
        Else
            'Llamamos al método para controlar las etiquetas de error y ok.
            controlUser()
        End If

    End Sub

    Private Sub txtPass_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        'Ejecutamos el control de password para evitar espacios y controlamos la longitud de la misma.
        control_password_sinespacios(txtPass, lblErrorPass, e)
        If txtPass.TextLength >= long_pass_max And Not Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = True
            lblErrorPass.Text = "Máximo " & long_pass_max & " carácteres"
        End If

        'Llamamos al método para controlar las etiquetas de error y ok.
        controlPass()
    End Sub

    Private Sub txtPassC_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassC.KeyPress
        'Ejecutamos el control de password para evitar espacios y controlamos la longitud de la misma.
        control_password_sinespacios(txtPassC, lblErrorPassC, e)
        If txtPassC.TextLength >= long_pass_max And Not Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = True
            lblErrorPassC.Text = "Máximo " & long_pass_max & " carácteres"
        End If
        controlPassC()
    End Sub

    Private Sub txtUser_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyUp
        'Control de longitud
        If txtUser.TextLength >= 29 Then
            lblErrorUser.Text = "Máximo 30 carácteres"
        Else
            controlUser()
        End If
    End Sub

    Private Sub txtUserLostFocusHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.LostFocus
        controlUser()
    End Sub

    Private Sub txtPass_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyUp
        controlPass()
    End Sub

    Private Sub txtPassLostFocusHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.LostFocus
        controlPass()
        If Not valid_pass(txtPass, long_pass) Then
            lblErrorPass.Text = "Contraseña no válida"
        End If
    End Sub

    Private Sub txtPassC_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPassC.KeyUp
        controlPassC()
    End Sub

    Private Sub txtPassCLostFocusHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassC.LostFocus
        controlPassC()
        If Not valid_pass(txtPassC, long_pass) Then
            lblErrorPassC.Text = "Contraseña no válida"
        End If
    End Sub

    'Ejecución del guardado.
    Private Sub btnGuarda_Click(sender As System.Object, e As System.EventArgs) Handles btnGuarda.Click


        If txtUser.TextLength >= 6 And valid_pass(txtPass, long_pass) And
            valid_pass(txtPassC, long_pass) And txtPass.Text.Equals(txtPassC.Text) Then

            ''Seleccionamos el id máximo
            'id_max_actual = conexion.DLookUp("idusuario", "USUARIOS", "idusuario = (select max(idusuario) from usuarios)")
            'If id_max_actual = -1 Then
            '    id_max_actual = 0
            'End If

            'Generamos la clave cifrada.
            Dim cifrada = crypt.EncryptData(txtPass.Text)

            'Si es nuevo usuario lo insertamos y si ya existe lo modificamos.
            If selecc.Equals("N") Then
                conexion.setData("INSERT INTO USUARIOS (nombre, password, eliminado) VALUES ('" & txtUser.Text & "', '" & cifrada & "', 0)")
                MsgBox("Usuario registrado")


                insertarCambio("Usuario registrado", 0)
            ElseIf selecc.Equals("U") Then
                conexion.setData("UPDATE USUARIOS SET NOMBRE='" & txtUser.Text & "', PASSWORD='" & cifrada & "', ELIMINADO = 0 where IDUSUARIO = " & id)
                MsgBox("Usuario modificado")
                insertarCambio("Usuario modificado", 0)
            End If

            'Actualizamos la tabla del formulario Usuarios
            frmUsuarios.actualiza_tabla()
            Me.Close()
        Else
            MsgBox("Error detectado." & vbCrLf &
                   "Revise los campos. ")
        End If
    End Sub

    Private Sub controlUser()

        'Controlamos adicionalmente los espacios, por si se pega contenido.
        If txtUser.Text.Contains(" ") Then
            pbErrorUser.Visible = True
            pbOkUser.Visible = False
            lblErrorUser.Text = "Sin espacios"
        Else
            'Si es un nuevo y existe mostramos la etiqueta de error y un mensaje advirtiendo.
            If selecc.Equals("N") And existe_user() Then
                pbErrorUser.Visible = True
                pbOkUser.Visible = False
                lblErrorUser.Text = "Usuario Repetido"
                txtUser.Focus()

                'Usuario correcto.
            ElseIf txtUser.TextLength > 5 And txtUser.TextLength < 30 Then
                lblErrorUser.Text = ""
                pbErrorUser.Visible = False
                pbOkUser.Visible = True
            Else
                'Error
                pbErrorUser.Visible = True
                pbOkUser.Visible = False
            End If
        End If

    End Sub

    Private Sub controlPass()
        'Comprobamos si es válida.
        valid_pass(txtPass, long_pass)


        If Not valida Then
            pbErrorPass.Visible = True
            pbOkPass.Visible = False
        Else
            lblErrorPass.Text = ""
            pbErrorPass.Visible = False
            pbOkPass.Visible = True
        End If
    End Sub

    Private Sub controlPassC()
        'Comprobamos si es válida.
        valid_pass(txtPassC, long_pass)

        If valida Then
            'Comprobamos si son iguales.
            If Not txtPassC.Text.Equals(txtPass.Text) Then
                lblErrorPassC.Text = "Contraseñas diferentes"
                pbErrorPassC.Visible = True
                pbOkPassC.Visible = False
            Else
                lblErrorPassC.Text = ""
                pbErrorPassC.Visible = False
                pbOkPassC.Visible = True
            End If
        End If
    End Sub

    'Comprobador de contraseña.
    Private Function valid_pass(txt As TextBox, longitud As Integer) As Boolean

        'La contraseña debe cumplir la expresión regular
        Dim MatchNumberPattern As String = "^.*(?=.{" & longitud & ",})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=_]).*$"
        If txt.Text.Trim <> "" Then
            If Not Regex.IsMatch(txt.Text, MatchNumberPattern) Then
                valida = False
            Else
                valida = True
            End If
        Else
            valida = False
        End If

        Return valida

    End Function

    'Comprueba si existe un usuario en la base de datos.
    Public Function existe_user() As Boolean

        Dim nom As String
        nom = conexion.DLookUp("idusuario", "USUARIOS", "nombre = '" & txtUser.Text & "'")
        If nom = -1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub txtUser_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.TextChanged
        'Controlamos las comillas simples evitando que se pongan
        txtUser.Text = txtUser.Text.Replace("'", "")
    End Sub

    Private Sub txtPass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPass.TextChanged
        'Controlamos las comillas simples evitando que se pongan
        txtPass.Text = txtPass.Text.Replace("'", "")
    End Sub

    Private Sub txtPassC_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPassC.TextChanged
        'Controlamos las comillas simples evitando que se pongan
        txtPassC.Text = txtPassC.Text.Replace("'", "")
    End Sub
End Class