Public Class frmArticulos
    Shared id As Integer
    Private primera_entrada As Boolean
    'para saber si lo abre pedidos
    Dim elegir As Boolean

   

    Private Sub frmArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = frmPrincipal

        'Para controlar las ejecuciones de eventos al entrar
        primera_entrada = True

        'Iniciamos la interfaz
        Dim consulta As String = "select idtipo, nombre from tipos where eliminado=0"
        rellenacombobox(jcbTipo, consulta, "-Elija el género-")
        estilodgvArtDani(dgvArticulos)
        jcbActElim.SelectedIndex = 0
        jcbPrecioStock.SelectedIndex = 0
        jcbCompara.SelectedIndex = 0

        id = -1

        'Si hay articulos en la lista cogemos el primer id.
        If dgvArticulos.Rows.Count > 0 Then
            id = dgvArticulos.Item(0, 0).Value
        End If

        ' si lo abre pedidos oculto lo de cambiar a eliminados y el boton salir
        If elegir Then
            jcbActElim.Visible = False
            lblActElm.Visible = False
            btnSalir.Visible = False
        Else
            'si no oculto el boton aceptar
            btnAceptar.Visible = False
        End If

        primera_entrada = False
    End Sub

    Private Sub frm_Articulos_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmPedidosNuevo.Enabled = True
        frmPedidosNuevo.obtenerArticulo()
        lblActElm.Visible = True
        jcbActElim.Visible = True
    End Sub

    Public WriteOnly Property setElegir
        Set(ByVal value)
            elegir = value
        End Set
    End Property

    Public ReadOnly Property getId
        Get
            Return id
        End Get
    End Property

    Private Sub dgvArticulos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticulos.CellClick
        If (e.RowIndex >= 0) Then
            id = dgvArticulos.Rows(e.RowIndex).Cells(0).Value()
        End If
    End Sub

    Private Sub dgvClientes_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvArticulos.CellMouseDoubleClick
        If elegir Then
            If (e.RowIndex >= 0) Then
                id = dgvArticulos.Rows(e.RowIndex).Cells(0).Value
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub jcbActElim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jcbActElim.SelectedIndexChanged

        'Según el elemento desactivamos nuevo, modificar, eliminar y activamos restaurar o viceversa.
        If jcbActElim.SelectedIndex = 1 Then
            act_desact_campos(False)
            btnRestaura.Enabled = True
        Else
            btnRestaura.Enabled = False
            act_desact_campos(True)
        End If

        actualiza_tabla()

    End Sub


    Public Sub actualiza_tabla()

        Dim comodin As String = "%"

        'Filtra por codigo
        Dim cod = comodin
        If (Not txtCod.Text.Equals("")) Then
            cod = comodin & txtCod.Text & comodin
        End If

        'Filtra por nombre
        Dim nom = comodin
        If (Not txtNom.Text.Equals("")) Then
            nom = comodin & txtNom.Text & comodin
        End If

        Dim filtrops As String
        If jcbPrecioStock.SelectedIndex <> 0 And Not txtValor.Text.Equals("") Then
            filtrops = "and " & jcbPrecioStock.SelectedItem.ToString & jcbCompara.SelectedItem.ToString &
                txtValor.Text
        Else
            filtrops = ""
        End If

        'Rellenamos el dgv
        Dim request As New DataSet

        Dim consulta As String

        'Dependiendo de si hemos elegido tipo o no, así ejecutamos los filtros.
        If jcbTipo.SelectedValue = -1 Then
            consulta = "SELECT art.idarticulo, art.numarticulo as articulo, art.nombre," &
                                   "ti.nombre as tipo, art.precio, art.stock from articulos art, tipos ti " &
                                   "where art.eliminado = " & jcbActElim.SelectedIndex & " and " &
                                   "upper(art.nombre) like '" & nom.ToUpper & "' and art.numarticulo like '" & cod & "' " &
                                   "and art.reftipo = ti.idtipo " & filtrops & "order by art.numarticulo"
        Else
            consulta = "SELECT art.idarticulo, art.numarticulo as articulo, art.nombre," &
                                   "ti.nombre as tipo, art.precio, art.stock from articulos art, tipos ti " &
                                   "where art.eliminado = " & jcbActElim.SelectedIndex & " and " &
                                   "upper(art.nombre) like '" & nom.ToUpper & "' and art.numarticulo like '" & cod & "' " &
                                   "and art.reftipo = " & jcbTipo.SelectedValue & " " &
                                   "and art.reftipo = ti.idtipo " & filtrops & "order by art.numarticulo"
        End If

        'Mostramos los resultados
        request = conexion.getData(consulta, "ARTICULOS")

        Dim t As DataTable = request.Tables("ARTICULOS")

        dgvArticulos.DataSource = t

        dgvArticulos.Columns(0).Visible = False

    End Sub

    'Activamos o desactivamos campos.
    Private Sub act_desact_campos(ByVal interruptor As Boolean)
        btnNuevo.Enabled = interruptor
        btnModif.Enabled = interruptor
        btnElimina.Enabled = interruptor
    End Sub


    Private Sub btnElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.Click
        'Comprobamos dataGrid no vacío.
        If Not IsDataGridViewEmpty(dgvArticulos) Then
            'Nos aseguramos de la elección
            Dim result = MessageBox.Show("¿Seguro que desea borrar el articulo?", "", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                'Lo marcamos como eliminado de la BBDD
                conexion.setData("update articulos set eliminado = 1 where idarticulo = " & dgvArticulos.CurrentRow.Cells(0).Value)
                MsgBox("Artículo eliminado")
                insertarCambio("Artículo eliminado", 0)
            End If
        Else
            MsgBox("No hay artículos para eliminar")
        End If

        actualiza_tabla()
    End Sub

    Private Sub btnRestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaura.Click
        'Comprueba si el dgv está vacío
        If Not IsDataGridViewEmpty(dgvArticulos) Then
            Dim result = MessageBox.Show("¿Seguro que desea restaurar el articulo?", "", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                'Actualiza el articulo seleccionado y lo recupera.
                conexion.setData("update articulos set eliminado = 0 where idarticulo = " & dgvArticulos.CurrentRow.Cells(0).Value)
                MsgBox("Artículo restaurado")
                insertarCambio("Artículo restaurado", 0)
            End If
        Else
            MsgBox("No hay artículos para restaurar.")
        End If

        actualiza_tabla()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub


    Private Sub txtCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod.TextChanged
        txtCod.Text = txtCod.Text.Replace("'", "")
        actualiza_tabla()
    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged
        txtNom.Text = txtNom.Text.Replace("'", "")
        actualiza_tabla()
    End Sub

    Private Sub jcbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jcbTipo.SelectedIndexChanged
        If Not primera_entrada Then
            actualiza_tabla()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        actualiza_tabla()
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        'Pasamos por parámetro el campo de texto, la etiqueta de error, el manejador
        'y la longitud máxima de la cadena.

        control_solonums(txtValor, lblErrorValor, e, 10)
    End Sub

    Private Sub txtValor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.TextChanged
        'Controlamos que no haya comillas simples en el código para evitar problemas con SQL
        'txtValor.Text = txtValor.Text.Replace("'", "")

        'Comprobamos al longitud y que realmente sea un número.
        Try
            pbError.Visible = False
            pbCorrecto.Visible = True
            If txtValor.TextLength >= 10 Then
                pbError.Visible = True
                pbCorrecto.Visible = False
            Else
                Dim num = Convert.ToInt64(txtValor.Text)
            End If
        Catch ex As FormatException
            pbError.Visible = True
            pbCorrecto.Visible = False
        End Try
    End Sub

    Private Sub jcbPrecioStock_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jcbPrecioStock.SelectedIndexChanged
        If jcbPrecioStock.SelectedIndex = 0 Then
            actualiza_tabla()
        End If
    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click

        If IsDataGridViewEmpty(dgvArticulos) Then
            MsgBox("No hay artículos para modificar.")
        Else
            'Dim frmNArt As New frmNewArticulo(dgvArticulos.CurrentRow)
            'frmNArt.Text = "Modificar Artículo"
            'frmNArt.ShowDialog()

            Me.Enabled = False
            frmNewArticulo.Text = "Nuevo Articulo"
            frmNewArticulo.selecc = "U"
            frmNewArticulo.dataGR = dgvArticulos.CurrentRow
            frmNewArticulo.Show()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim indice As Integer

        'Preparamos el id que pasaremos como parámetro.
        indice = conexion.DLookUp("idarticulo", "ARTICULOS", "idarticulo = (select max(idarticulo) from articulos)")

        If indice = -1 Then
            indice = 0
        End If

        'Pasamos por parámetro el id máximo que está en uso.
        'Dim frmNArt As New frmNewArticulo()
        'frmNArt.Text = "Nuevo Artículo"
        'frmNArt.ShowDialog()

        Me.Enabled = False
        frmNewArticulo.Text = "Nuevo Articulo"
        frmNewArticulo.selecc = "N"
        frmNewArticulo.Show()
    End Sub

    Private Sub btnLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLC.Click
        frmCambios.Show()
    End Sub
    'boton aceptar
    'JunaLuis
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    ' Crea una copia de seguridad en xml de la tabla ARTICULOS
    Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_articulos.xml", "articulos")
        Dim respuesta As MsgBoxResult
        Dim mensaje As String = "De forma adicional, usted puede realizar una copia de seguridad de las relaciones de los artículos de la empresa con los artículos de los proveedores, ¿desea realizar esta operación?"
        respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_relacionarticulos.xml", "relacionarticulos")
        End If
    End Sub
End Class