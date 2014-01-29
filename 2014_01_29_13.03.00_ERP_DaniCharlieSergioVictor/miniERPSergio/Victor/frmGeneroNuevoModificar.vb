Public Class frmGeneroNuevoModificar

    Private id As Integer

    Dim tip As ToolTip

    Public Sub New(ByVal nuevoTipo As Boolean, ByVal id As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not nuevoTipo Then
            Me.id = id
        Else
            Me.id = 0 ' Este será el indicador de que se va a crear un nuevo tipo.
        End If

        Me.TopMost = True

        tip = New ToolTip()

        inhabilitaClickDerecho(txtNombre)

    End Sub

    Private Sub frmTiposNuevo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmGenero.Enabled = True
    End Sub

    'Crea un nuevo tipo
    Private Sub nuevo()
        Dim contenidoConsulta As String = "SELECT IDTIPO, NOMBRE FROM TIPOS WHERE IDTIPO = (SELECT MAX(IDTIPO) FROM TIPOS)"
        Dim Data As DataSet = Comun.conexion.getData(contenidoConsulta, "TIPO")
        Dim t As DataTable = Data.Tables("TIPO")

        Dim idc As Integer

        If t.Rows.Count = 0 Then 'Si no hat ningun registro empieza en id=1
            idc = 1
        Else
            idc = t.Rows(0)(0) + 1
        End If

        Dim nombre = txtNombre.Text

        conexion.setData("INSERT INTO TIPOS (nombre, eliminado) VALUES('" & nombre & "', 0)")

        insertarCambio("Tipo " & nombre & " creado", 0)

    End Sub

    'Modifica un tipo
    Private Sub modificar()

        Dim nombre = txtNombre.Text
        conexion.setData("UPDATE TIPOS SET NOMBRE = '" & nombre & "' WHERE IDTIPO = " & id)

        insertarCambio("Tipo " & nombre & " modificado", 0)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Not txtNombre.Text.Equals("") Then
            If id = 0 Then 'Si se a llamado con id=0 se crea un nuevo tipo sino se modifica el id introducido
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Crea nuevo tipo?", MsgBoxStyle.YesNo, "Confirmacion")

                If respuesta = MsgBoxResult.Yes Then
                    nuevo()
                    MsgBox("Tipo guardado")
                End If
            Else
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox("¿Modificar tipo?", MsgBoxStyle.YesNo, "Confirmacion")

                If respuesta = MsgBoxResult.Yes Then
                    modificar()
                    MsgBox("Tipo modificado")
                End If
            End If
            Me.Dispose()

        Else ' Si el nombre está vacío.
            MsgBox("El nombre no puede estar vacío")

        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    ' Se comprueba que las pulsaciones cumpla con los requisitos marcados.
    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If (ValorAlfabeticoNumerico(AscW(e.KeyChar)) = False Or txtNombre.Text.Length = 20 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tip.Show("Solo puede introducir 20 caracteres", txtNombre)
        Else
            tip.Hide(txtNombre)
        End If
    End Sub

    'Comprobación en la que se mira si el campo de texto esta vacio
    Private Sub txtNombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyUp
        If txtNombre.Text.Equals("") Then
            pboxTipoAcierto.Visible = False
            pboxTipoFallo.Visible = True
        Else
            pboxTipoAcierto.Visible = True
            pboxTipoFallo.Visible = False
        End If
    End Sub

    Private Sub frmGeneroNuevoModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class