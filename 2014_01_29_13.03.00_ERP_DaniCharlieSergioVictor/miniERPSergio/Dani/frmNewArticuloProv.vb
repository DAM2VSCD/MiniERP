Imports System.Text.RegularExpressions

Public Class frmNewArticuloProv

    Dim id, id_max_actual As Integer
    Public selecc As String
    Public dataGR As DataGridViewRow
    Dim numero_art, nombre_art, precio_art, stock_art As String
    Dim idprove As Integer



    Private Sub frmNewArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = frmPrincipal

        'Rellenamos la etiqueta de información.
        lblInfo.Text = vbCrLf & "Nombre: " & vbCrLf & "  Máx 50 carácteres" & vbCrLf & vbCrLf & vbCrLf &
                        vbCrLf & "Elija algún tipo. " & vbCrLf & vbCrLf &
                       "Precio: " & vbCrLf & "Formato ###.## " & vbCrLf & vbCrLf

        Dim consulta As String = "select idtipo, nombre from tipos where eliminado=0"
        rellenacombobox(cmbTipoArt, consulta, "-Elija el tipo-")



        If cmbTipoArt.Items.Count = 1 Then
            btnGuarda.Enabled = False
        End If

        If selecc.Equals("U") Then
            rellena_datos()
        Else
            Dim max_num = conexion.DLookUp("max(numarticulo)", "articulosproveedores", "")

            If IsDBNull(max_num) Then
                txtNum.Text = 1000
            Else
                txtNum.Text = max_num + 1
            End If
        End If

        

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        Dim precio = txtPrecio.Text

        If Not pbErrorNombre.Visible And Not pbErrorPrecio.Visible And Not pbErrorTipo.Visible And
            Not pbErrorStock.Visible And Not pbErrorProve.Visible Then

            'Si es nuevo
            If selecc.Equals("N") Then
                If Not existe_articulo() Then

                    Dim id_artic
                    id_artic = conexion.DLookUp("max(id)", "articulosproveedores", "")

                    If IsDBNull(id_artic) Then
                        id_artic = 0
                    End If

                    Dim sentenciaInsercion As String = "insert into articulosproveedores (id, refproveedor, nombre, precio, eliminado, numarticulo, stock, tipo) " &
                                 "values (" & id_artic + 1 & "," & idprove & ",'" & txtNombre.Text & "'," & txtPrecio.Text & ", 0," &
                                 "" & txtNum.Text & ", " & txtStock.Text & "," & cmbTipoArt.SelectedValue & ")"

                    conexion.setData(sentenciaInsercion)


                    MsgBox("Artículo insertado")
                    insertarCambio("Artículo insertado", 0)
                    frmArticulosProv.actualiza_tabla()
                    Me.Dispose()
                Else
                    MsgBox("Artículo repetido")
                    txtNombre.Focus()
                End If

            Else
                'Si el precio ha variado en la modificacíón lo insertamos como elemento nuevo.

                If Not txtPrecio.Text.Equals(precio_art) Then
                    If Not existe_articulo() Then
                        Dim id_artic = conexion.DLookUp("max(id)", "articulosproveedores", "")

                        If IsDBNull(id_artic) Then
                            id_artic = 0
                        End If

                        conexion.setData("insert into articulosproveedores (id, refproveedor, nombre, precio, eliminado, numarticulo, stock, tipo) " &
                                     "values (" & id_artic + 1 & "," & idprove & ",'" & txtNombre.Text & "'," & txtPrecio.Text & ", 0," &
                                     "" & txtNum.Text & ", " & txtStock.Text & "," & cmbTipoArt.SelectedValue & ")")


                        MsgBox("Artículo insertado")
                        insertarCambio("Artículo insertado", 0)
                        frmArticulosProv.actualiza_tabla()
                        Me.Dispose()
                    Else
                        MsgBox("Artículo repetido")
                        txtNombre.Focus()
                    End If
                Else
                    'Modificación
                    If Not existe_articulo() Then
                        conexion.setData("update articulosproveedores set id=" & id & ", refproveedor = " & idprove & ", " &
                                         "nombre= '" & txtNombre.Text & "', tipo=" & cmbTipoArt.SelectedValue & ", " &
                                         "precio= '" & txtPrecio.Text & "', eliminado = 0, numarticulo=" & txtNum.Text & ", " &
                                         "stock=" & txtStock.Text & " where id = " & id & "")

                        MsgBox("Artículo actualizado")
                        insertarCambio("Artículo " & id & " actualizado", 0)
                        frmArticulosProv.actualiza_tabla()
                        Me.Dispose()
                    Else
                        MsgBox("Artículo repetido")
                        txtNombre.Focus()
                    End If

                End If
            End If

            limpia_campos()
        Else

            MsgBox("Error detectado. " & vbCrLf & "Revise los campos")

        End If

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        control_nombre()
    End Sub

    Private Sub txtNombre_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyUp
        control_nombre()
    End Sub

    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        control_nombre()
    End Sub



    Private Sub txtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        control_precio()
    End Sub

    Private Sub txtPrecio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecio.KeyUp
        control_precio()
    End Sub

    Private Sub txtPrecio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.LostFocus
        control_precio()
    End Sub



    Private Sub txtStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        control_solonums(txtStock, lblErrorStock, e)
    End Sub

    Private Sub txtStock_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStock.KeyUp
        If ValidarNumeroPositivo(txtStock.Text) Then
            pbErrorStock.Visible = False
            pbOkStock.Visible = True
        Else
            pbErrorStock.Visible = True
            pbOkStock.Visible = False
        End If
    End Sub

    Private Sub txtStock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStock.LostFocus
        If Not ValidarNumeroPositivo(txtStock.Text) Then
            pbErrorStock.Visible = True
            pbOkStock.Visible = False
        Else
            pbErrorStock.Visible = False
            pbOkStock.Visible = True
        End If
    End Sub

    ''
    '' METODOS PROPIOS
    ''

    Private Sub limpia_campos()

        txtNombre.Text = ""
        cmbTipoArt.SelectedIndex = 0
        txtPrecio.Text = ""
        txtStock.Text = ""
        txtProv.Text = ""

    End Sub


    Private Sub selecc_tipo()

        Dim cad2 = dataGR.Cells("tipo").Value.ToString

        cmbTipoArt.SelectedIndex = cmbTipoArt.FindString(cad2)


    End Sub

    Private Sub selecc_prove(ByVal id_artic_interno As Integer)

        Dim id_articulo_prov = conexion.DLookUp("refarticuloproveedor", "relacionarticulos", "refarticulo = " & id_artic_interno)
        Dim id_proveedor = 0
        If Not IsDBNull(id_articulo_prov) Then
            id_proveedor = conexion.DLookUp("refproveedor", "articulosproveedores", "id = " & id_articulo_prov)
        End If

        If id_articulo_prov <> -1 And id_proveedor <> -1 Then
            idprove = id_proveedor

            pbErrorProve.Visible = False
            pbOkProve.Visible = True

        End If

    End Sub


    Private Sub rellena_datos()

        If dataGR.Cells.Count <> 0 Then

            numero_art = dataGR.Cells("articulo").Value
            txtNum.Text = numero_art
            nombre_art = dataGR.Cells("nombre").Value
            txtNombre.Text = nombre_art
            pbErrorNombre.Visible = False
            pbOkNombre.Visible = True
            precio_art = dataGR.Cells("precio").Value
            txtPrecio.Text = precio_art
            pbErrorPrecio.Visible = False
            pbOkPrecio.Visible = True
            stock_art = dataGR.Cells("stock").Value
            txtStock.Text = stock_art
            pbErrorStock.Visible = False
            pbOkStock.Visible = True
            selecc_tipo()
            selecc_prove(id)

        End If
    End Sub

    Public Sub control_solonums(ByVal txt As TextBox, ByVal lblError As Label,
                                        ByVal e As System.Windows.Forms.KeyPressEventArgs)

        lblError.Text = ""

        If Not Convert.ToInt32(e.KeyChar) = 8 And Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            lblError.Text = "Sólo números enteros"

        End If

    End Sub

    Public Sub control_nombre()
        If txtNombre.TextLength > 0 Then
            pbOkNombre.Visible = True
            pbErrorNombre.Visible = False
        Else
            pbOkNombre.Visible = False
            pbErrorNombre.Visible = True
        End If

        If txtNombre.Text.Equals("") Then
            pbErrorNombre.Visible = True
            pbOkNombre.Visible = False
        Else
            pbErrorNombre.Visible = False
            pbOkNombre.Visible = True
        End If

        If txtNombre.TextLength >= 49 Then
            pbErrorNombre.Visible = True
            pbOkNombre.Visible = False
            lblErrorNombre.Text = "Máximo 50 carácteres"
        End If
    End Sub

    Private Sub control_precio()
        lblErrorPrecio.Text = ""
        If Not validarFloat(txtPrecio.Text) Then
            pbErrorPrecio.Visible = True
            pbOkPrecio.Visible = False
            lblErrorPrecio.Text = "Precio no válido"
        Else
            pbErrorPrecio.Visible = False
            pbOkPrecio.Visible = True
        End If
    End Sub



    Function ValidarNumeroPositivo(ByVal numero As String) As Boolean
        Dim EsNumero As Boolean
        EsNumero = True

        Dim num As Integer

        Try
            num = Convert.ToInt32(numero)
        Catch ex As FormatException
            EsNumero = False
        End Try

        Return EsNumero
    End Function

    Function validarFloat(ByVal numero As String) As Boolean
        Dim valida = "^\d{1,3}(?:\.\d{1,2})?$"

        If Regex.IsMatch(numero, valida) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub jcbTipoArt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoArt.SelectedIndexChanged
        If cmbTipoArt.SelectedIndex <> 0 Then
            pbErrorTipo.Visible = False
            pbOkTipo.Visible = True
        Else
            pbErrorTipo.Visible = True
            pbOkTipo.Visible = False
        End If
    End Sub

    Public Function existe_articulo() As Boolean

        Dim nom As String
        nom = conexion.DLookUp("id", "articulosproveedores",
                               "nombre = '" & txtNombre.Text & "' and tipo = " & cmbTipoArt.SelectedValue &
                               " and precio = '" & txtPrecio.Text & "' and stock = " & txtStock.Text & " and refproveedor = " & idprove)
        If nom = -1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = txtNombre.Text.Replace("'", "")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.Enabled = False
        frm_Proveedores.setElegir = True
        frm_Proveedores.lblActElm.Visible = False
        frm_Proveedores.Show()
    End Sub

    Public Sub obtener_proveedor()

        Me.Focus()
        Me.TopMost = True
        idprove = frm_Proveedores.getId

        Dim nom = conexion.DLookUp("nombre", "proveedores", "id =" & idprove)


        If idprove = -1 Then
            pbErrorProve.Visible = True
            pbOkProve.Visible = False
        Else
            txtProv.Text = nom
            pbErrorProve.Visible = False
            pbOkProve.Visible = True
        End If
    End Sub
End Class