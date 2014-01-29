Imports System.Text.RegularExpressions

Public Class frmNewArticulo

    Dim id, id_max_actual, idProv As Integer
    Public selecc As String
    Public dataGR As DataGridViewRow
    Dim numero_art, nombre_art, precio_art, stock_art As String
    Dim proveedorElegido As Boolean

    'Public Sub New()

    '    'Constructor
    '    InitializeComponent()
    '    selecc = "N"
    '    'id = id_actual
    '    If id = 1 Then
    '        txtNum.Text = 1000
    '    Else
    '        Dim max_num = conexion.DLookUp("numarticulo", "ARTICULOS", "numarticulo = (select max(numarticulo) from articulos)")
    '        txtNum.Text = max_num + 1
    '    End If
    'End Sub

    'Public Sub New(dr As DataGridViewRow)

    '    ' Llamada necesaria para el diseñador.
    '    InitializeComponent()


    '    selecc = "U"
    '    dataGR = dr
    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    '    id = dataGR.Cells("idarticulo").Value
    'End Sub

    Private Sub frmNewArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        estilodgvArt(dgvProveedor)

        If id = 1 Then
            txtNum.Text = 1000
        Else
            Dim max_num = conexion.DLookUp("numarticulo", "ARTICULOS", "numarticulo = (select max(numarticulo) from articulos)")
            txtNum.Text = max_num + 1
        End If

        idProv = -1
        Me.MdiParent = frmPrincipal

        'Rellenamos la etiqueta de información.
        lblInfo.Text = vbCrLf & "Nombre: " & vbCrLf & "  Máx 50 carácteres" & vbCrLf & vbCrLf & vbCrLf &
                        vbCrLf & "Elija algún tipo. " & vbCrLf & vbCrLf &
                       "Precio: " & vbCrLf & "Formato ####.## " & vbCrLf & vbCrLf

        Dim consulta As String = "select idtipo, nombre from tipos where eliminado=0"
        rellenacombobox(cmbTipoArt, consulta, "-Elija el tipo-")


        If cmbTipoArt.Items.Count = 1 Then
            btnGuarda.Enabled = False
        End If

        If selecc.Equals("U") Then
            id = dataGR.Cells("idarticulo").Value
            rellena_datos()

        Else
            Dim maxNum = conexion.DlookUp("max(numarticulo)", "articulos", "")
            If IsDBNull(maxNum) Then
                txtNum.Text = "1000"
            Else
                txtNum.Text = maxNum + 1
            End If
        End If

    End Sub

    Private Sub frm_Articulos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmArticulos.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        Dim precio = txtPrecio.Text

        If Not pbErrorNombre.Visible And Not pbErrorPrecio.Visible And Not pbErrorTipo.Visible And
            Not pbErrorStock.Visible Then

            'Si es nuevo
            If selecc.Equals("N") Then
                If Not existe_articulo() Then
                    conexion.setData("insert into articulos (nombre, reftipo, precio, eliminado, numarticulo, stock) " &
                                 "values ('" & txtNombre.Text & "'," &
                                 cmbTipoArt.SelectedValue & ", " & txtPrecio.Text & ", 0, " & txtNum.Text & ", " &
                                 txtStock.Text & ")")

                    inserta_relacion()

                    MsgBox("Artículo insertado")
                    insertarCambio("Artículo insertado", 0)
                    frmArticulos.actualiza_tabla()
                    Me.Dispose()
                Else
                    MsgBox("Artículo repetido")
                    txtNombre.Focus()
                End If

            Else
                'Si el precio ha variado en la modificacíón lo insertamos como elemento nuevo.

                If Not txtPrecio.Text.Equals(precio_art) Then
                    If Not existe_articulo() Then
                        id = conexion.DLookUp("idarticulo", "ARTICULOS", "idarticulo = (select max(idarticulo) from articulos)")
                        Dim max_num = conexion.DLookUp("numarticulo", "ARTICULOS", "numarticulo = (select max(numarticulo) from articulos)")
                        conexion.setData("insert into articulos (nombre, reftipo, precio, eliminado, numarticulo, stock) " &
                                 "values ('" & txtNombre.Text & "'," &
                                 cmbTipoArt.SelectedValue & ", '" & txtPrecio.Text & "', 0, " & max_num + 1 & ", " &
                                 txtStock.Text & ")")

                        inserta_relacion()

                        MsgBox("Artículo insertado")
                        insertarCambio("Artículo insertado", 0)
                        frmArticulos.actualiza_tabla()
                        Me.Dispose()
                    Else
                        MsgBox("Artículo repetido")
                        txtNombre.Focus()
                    End If
                Else
                    'Modificación
                    If Not existe_articulo() Or Not existe_relacion() Then
                        conexion.setData("update articulos set idarticulo=" & id & ", nombre= '" & txtNombre.Text & "', " &
                                    "reftipo=" & cmbTipoArt.SelectedValue & ", precio= '" & txtPrecio.Text & "', " &
                                    "eliminado = 0, numarticulo=" & txtNum.Text & ", stock=" & txtStock.Text & " where " &
                                    "idarticulo = " & id & "")

                        If Not existe_relacion() Then
                            inserta_relacion()
                        End If

                        MsgBox("Artículo actualizado")
                        insertarCambio("Artículo " & id & " actualizado", 0)
                        frmArticulos.actualiza_tabla()
                        Me.Dispose()
                    Else
                        MsgBox("Artículo repetido")
                        txtNombre.Focus()
                    End If

                End If
            End If

        Else

            MsgBox("Error detectado. " & vbCrLf & "Revise los campos")

        End If

    End Sub

    Private Sub txtNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        control_nombre()
    End Sub

    Private Sub txtNombre_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyUp
        control_nombre()
    End Sub

    Private Sub txtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles txtNombre.LostFocus
        control_nombre()
    End Sub



    Private Sub txtPrecio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        control_precio()
    End Sub

    Private Sub txtPrecio_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPrecio.KeyUp
        control_precio()
    End Sub

    Private Sub txtPrecio_LostFocus(sender As Object, e As System.EventArgs) Handles txtPrecio.LostFocus
        control_precio()
    End Sub



    Private Sub txtStock_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        control_solonums(txtStock, lblErrorStock, e)
    End Sub

    Private Sub txtStock_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtStock.KeyUp
        If ValidarNumeroPositivo(txtStock.Text) Then
            pbErrorStock.Visible = False
            pbOkStock.Visible = True
        Else
            pbErrorStock.Visible = True
            pbOkStock.Visible = False
        End If
    End Sub

    Private Sub txtStock_LostFocus(sender As Object, e As System.EventArgs) Handles txtStock.LostFocus
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

    End Sub

    Private Sub selecc_tipo()

        Dim cad2 = dataGR.Cells("tipo").Value.ToString

        cmbTipoArt.SelectedIndex = cmbTipoArt.FindString(cad2)


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


            Dim Data As DataSet = Comun.conexion.getData("select proveedores.nombre, " & _
                                                         "relacionarticulos.nombreprov, relacionarticulos.precioprov " & _
                "from proveedores, relacionarticulos " & _
                "where refproveedor=proveedores.id " & _
                "and relacionarticulos.eliminado=0 " & _
                "and refarticulo=" & id, "CAM")
            '---------------------------------------------------------------
            Dim t As DataTable = Data.Tables("CAM")

            For Each f As DataRow In t.Rows

                dgvProveedor.Rows.Add(f("nombre"), f("nombreprov"), f("precioprov"))
            Next

            'txtProv.Text = t.Rows(0)(0).ToString
            'txtArtProv.Text = t.Rows(0)(1).ToString

        End If
    End Sub

    Private Sub inserta_relacion()

        Dim id_art


        If selecc.Equals("N") Then
            id_art = conexion.DLookUp("max(idarticulo)", "articulos", "")
        Else
            id_art = id
        End If

        For i As Integer = 0 To dgvProveedor.Rows.Count - 1

            'MsgBox(i)


            Dim id_relacion = conexion.DLookUp("max(id)", "relacionarticulos", "")

            If IsDBNull(id_relacion) Then
                id_relacion = 0
            End If

            If Not dgvProveedor.Rows(i).Cells(2).Value = -1 Then



                'Insertamos en la tabla de que relaciona los artículos ///// AÑADIR ID DE LA TABLA QUE NO EXISTEN LOS AUTO-ID /////
                conexion.setData("insert into relacionarticulos (id, refarticulo, refarticuloproveedor, eliminado) " &
                                 "values (" & id_relacion + 1 & "," & id_art & "," & dgvProveedor.Rows(i).Cells(2).Value & ", 0)")

            ElseIf dgvProveedor.Rows(i).Visible = False Then
                'MsgBox("asd " & i)
                conexion.setData("update relacionarticulos set eliminado=1 where id=" & dgvProveedor.Rows(i).Cells(3).Value)

            End If



        Next

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



    Function ValidarNumeroPositivo(numero As String) As Boolean
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

    Function validarFloat(numero As String) As Boolean
        Dim valida = "^\d{1,3}(?:\.\d{1,2})?$"

        If Regex.IsMatch(numero, valida) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub jcbTipoArt_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipoArt.SelectedIndexChanged
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
        nom = conexion.DLookUp("idarticulo", "articulos",
                               "nombre = '" & txtNombre.Text & "' and reftipo = " & cmbTipoArt.SelectedValue &
                               " and precio = '" & txtPrecio.Text & "' and stock = " & txtStock.Text)


        If nom = -1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function existe_relacion() As Boolean

        Dim esta As String
        esta = False

        If idProv <> 0 Then

            esta = conexion.DLookUp("id", "relacionarticulos",
                                   "refarticulo = " & id & " and refarticuloproveedor = " & idProv)
            If esta = -1 Then
                Return False
            Else
                Return True
            End If
        End If

        Return esta

    End Function

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        txtNombre.Text = txtNombre.Text.Replace("'", "")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'clienteElegido = False
        Me.Enabled = False
        frmArticulosProv.setElegir = True
        frmArticulosProv.lblActElm.Visible = False
        frmArticulosProv.Show()
    End Sub


    Public Sub obtenerProveedor()
        ' Solo tiene sentido que entre aquí si el cliente fue abierto desde creación de pedidos.
        ' De no hacerlo así saltaría excepción.
        frm_Clientes.lblActElm.Visible = True
        frm_Clientes.cboTipo.Visible = True
        If Me.Visible Then
            'If soyModificar Then
            '    idProv = frmPedidosBuscar.ppIdCliente
            'Else
            '    idProv = frmArticulosProv.getId
            'End If

            idProv = frmArticulosProv.getId

            Me.Focus()
            Me.TopMost = True

            If idProv >= 0 Then

                Dim datosProv As DataSet = conexion.getData("SELECT ARTICULOSPROVEEDORES.NOMBRE AS ART, PROVEEDORES.NOMBRE AS PRO, ARTICULOSPROVEEDORES.ID " & _
                                                            "FROM ARTICULOSPROVEEDORES, PROVEEDORES " & _
                                                            "WHERE REFPROVEEDOR=PROVEEDORES.ID AND " & _
                                                            "ARTICULOSPROVEEDORES.ID=" & idProv, "tabla")

                Dim t As DataTable = datosProv.Tables("tabla")



                Dim fila As DataRow = t.Rows(0)



                dgvProveedor.Rows.Add(fila("PRO"), fila("ART"), fila("ID"))

                proveedorElegido = True


            Else
                If idProv = -1 Then

                    proveedorElegido = False

                End If
            End If

        End If
    End Sub



    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not dgvProveedor.Rows(dgvProveedor.CurrentRow.Index).Cells(2).Value = -1 Then
            dgvProveedor.Rows.Remove(dgvProveedor.CurrentRow)
        Else
            dgvProveedor.Rows(dgvProveedor.CurrentRow.Index).Visible = False
        End If

    End Sub

End Class