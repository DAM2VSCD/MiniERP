Imports System.Text.RegularExpressions

Public Class frmNuevoRelacion

    Public row As Integer 'fila que se tiene que modificar

    Public asociados As Boolean 'Valor para comprovar si estaba asociado antes

    Public numero As String 'numero del articulo
    Public nombre As String 'Nombre del articulo

    Public nomProb As String 'Nombre antiguo del proveedor
    Public preProb As String 'Precio antiguo del proveedor

    Private Sub frmNuevoRelacion_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_Nuevo_Modificar_Proveedores.Enabled = True
    End Sub

    Private Sub frmNuevoRelacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal

        txtNum.Text = numero
        txtArt.Text = nombre

        txtNombre.Text = nomProb
        txtPrecio.Text = preProb

        If txtNombre.Text.Length > 0 And txtNombre.TextLength <= 49 Then
            pboxNombreAcierto.Visible = True
            pboxNombreFallo.Visible = False

        Else
            pboxNombreAcierto.Visible = False
            pboxNombreFallo.Visible = True
        End If

        If validarFloat(txtPrecio.Text) Then
            pboxPrecioAcierto.Visible = True
            pboxPrecioFallo.Visible = False

        Else
            pboxPrecioAcierto.Visible = False
            pboxPrecioFallo.Visible = True

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        frm_Nuevo_Modificar_Proveedores.nuevoRelacion(Not asociados, nomProb, preProb, row)

        Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If pboxNombreAcierto.Visible And pboxPrecioAcierto.Visible Then
            frm_Nuevo_Modificar_Proveedores.nuevoRelacion(True, txtNombre.Text, txtPrecio.Text, row)

            Dispose()

        Else

            MsgBox("Datos no validos")
        End If



    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

        If txtNombre.Text.Length > 0 And txtNombre.TextLength <= 49 Then
            pboxNombreAcierto.Visible = True
            pboxNombreFallo.Visible = False

        Else
            pboxNombreAcierto.Visible = False
            pboxNombreFallo.Visible = True
        End If



    End Sub

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged

        If validarFloat(txtPrecio.Text) Then
            pboxPrecioAcierto.Visible = True
            pboxPrecioFallo.Visible = False

        Else
            pboxPrecioAcierto.Visible = False
            pboxPrecioFallo.Visible = True

        End If

    End Sub

    Function validarFloat(ByVal numero As String) As Boolean
        Dim valida = "^\d{1,3}(?:\,\d{1,2})?$"

        If Regex.IsMatch(numero, valida) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class