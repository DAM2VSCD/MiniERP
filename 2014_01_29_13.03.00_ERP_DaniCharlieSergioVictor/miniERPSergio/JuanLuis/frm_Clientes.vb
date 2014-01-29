Public Class frm_Clientes
    Dim search As ConnectDB
    Dim data As DataSet
    Shared id As Integer
    Dim elegir As Boolean

    Private Sub frm_Clientes_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmPedidosNuevo.obtenerCliente(False)
        frmPedidosNuevo.Enabled = True
        Me.TopMost = True
    End Sub

    Private Sub frm_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        search = New ConnectDB
        data = New DataSet
        cboTipo.SelectedIndex = 0
        If elegir Then
            cboTipo.Visible = False
            lblActElm.Visible = False
            btnSalir.Visible = False
        Else
            btnAceptar.Visible = False
        End If
    End Sub


    Public WriteOnly Property setElegir
        Set(ByVal value)
            elegir = value
        End Set
    End Property

    'rellena el dgv con los clientes que hay en ese momenot
    Sub iniciardgv(ByVal eliminiado As Integer)
        data = search.getData("Select idcliente,numcliente, nombre, apellido1, apellido2 ,direccion,refcppoblaciones,mail,telefono from clientes where eliminado=" & eliminiado, "tclientes")

        Dim tClientes As DataTable = data.Tables("tclientes")

        estilodgvArtDani(dgvClientes)

        For i As Integer = 0 To dgvClientes.ColumnCount
            dgvClientes.Rows.Clear()
        Next
        Dim fila As String()
        For Each row As DataRow In tClientes.Rows
            Dim refpob As String = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row(6).ToString)
            fila = {row(0).ToString, row(1).ToString, row(2).ToString, row(3).ToString, row(4).ToString, row(5).ToString, search.DLookUp("poblacion", "poblaciones", "idpoblacion = " & refpob), row(7).ToString, row(8).ToString}
            dgvClientes.Rows.Add(fila)
        Next

        dgvClientes.Columns(0).Visible = False

        If (dgvClientes.RowCount > 0) Then
            id = dgvClientes.Rows(0).Cells(0).Value
        Else
            id = -1
        End If

    End Sub

    'procedimiento buscar que es capaz de buscar por nombre y apellidos a la vez
    Private Sub buscar()
        Dim numero As String
        If txtNumero.Text.Equals("") Then
            numero = "%"
        Else
            numero = txtNumero.Text.ToUpper
        End If

        Dim nombre As String
        If txtNombre.Text.Equals("") Then
            nombre = "%"
        Else
            nombre = txtNombre.Text.ToUpper
        End If

        Dim apellido1 As String
        If txtApellido1.Text.Equals("") Then
            apellido1 = "%"
        Else
            apellido1 = txtApellido1.Text.ToUpper
        End If

        Dim apellido2 As String
        If txtApellido2.Text.Equals("") Then
            apellido2 = "%"
        Else
            apellido2 = txtApellido2.Text.ToUpper
        End If
        data = search.getData("Select idcliente,numcliente, nombre, apellido1, apellido2 ,direccion,refcppoblaciones,mail,telefono from clientes" & _
                            " where eliminado=" & cboTipo.SelectedIndex & " and upper(nombre) like '" & nombre & "%' and " & _
                            "upper(numcliente) like'" & numero & "%' and " & _
                            "upper(apellido1) like '" & apellido1 & "%' and " & _
                            "upper(apellido2) like '" & apellido2 & "%'", "tclientes")

        Dim tClientes As DataTable = data.Tables("tclientes")

        Dim fila As String()
        For i As Integer = 0 To dgvClientes.ColumnCount
            dgvClientes.Rows.Clear()
        Next

        For Each row As DataRow In tClientes.Rows
            Dim refpob As String = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row(6).ToString)
            fila = {row(0).ToString, row(1).ToString, row(2).ToString, row(3).ToString, row(4).ToString, row(5).ToString, search.DLookUp("poblacion", "poblaciones", "idpoblacion = " & refpob), row(7).ToString, row(8).ToString}
            dgvClientes.Rows.Add(fila)
        Next

        dgvClientes.Columns(0).Visible = False

        If (dgvClientes.RowCount > 0) Then
            id = dgvClientes.Rows(0).Cells(0).Value
        Else
            id = -1
        End If
    End Sub

    'procedimiento que ocurre al pulsar el boton nuevo
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim nuevo As frm_Nuevo_Modificar_Clientes = New frm_Nuevo_Modificar_Clientes(-1)
        nuevo.ShowDialog()
        iniciardgv(0)
    End Sub

    'procedimiento que ocurre al pulsar el boton recuperar
    Private Sub btnRecuperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecuperar.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea recuperar el cliente?", MsgBoxStyle.YesNo, "Confirmacion")
        If respuesta = MsgBoxResult.Yes Then
            search.setData("UPDATE clientes set eliminado=0 where IDCLIENTE=" & id)
            Dim nombre As String = search.DLookUp("nombre", "clientes", "idcliente=" & id)
            insertarCambio("Recuperado cliente " & nombre, 0)
        End If
        iniciardgv(1)
    End Sub

    'procedimiento que ocurre al pulsar el boton salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    'procedimiento que ocurre al pulsar en el datagridview
    Private Sub dgvClientes_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClientes.CellMouseClick
        If (e.RowIndex >= 0) Then
            id = dgvClientes.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    'Control doble_click
    Private Sub dgvClientes_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvClientes.CellMouseDoubleClick
        If elegir Then
            If (e.RowIndex >= 0) Then
                id = dgvClientes.Rows(e.RowIndex).Cells(0).Value
                Me.Dispose()
            End If
        End If
    End Sub

    'propiedad que devuelve la id
    Public ReadOnly Property getId()
        Get
            Return id
        End Get
    End Property

    'procedimiento que ocurre al pulsar el boton modificar
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim modificar As frm_Nuevo_Modificar_Clientes = New frm_Nuevo_Modificar_Clientes(id)
        modificar.ShowDialog()
        iniciardgv(0)
    End Sub

    'procedimiento que ocurre al pulsar el boton borrar
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea borrar el cliente?", MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            search.setData("UPDATE clientes set eliminado=1 where IDCLIENTE=" & id)
            Dim nombre As String = search.DLookUp("nombre", "clientes", "idcliente=" & id)
            insertarCambio("Borrado cliente " & nombre, 0)
            MsgBox("Borrado con exito")
            iniciardgv(0)
            If id = -1 Then
                btnModificar.Enabled = False
                btnNuevo.Enabled = True
                btnBorrar.Enabled = False
                btnRecuperar.Enabled = False
            End If
        End If
    End Sub

    'procedimiento que al cambiar el texto en el nombre busca conicidencias y las escribe en el dgv
    Private Sub txtNombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        buscar()
    End Sub

    'procedimiento que al cambiar el texto en el apellido1 busca conicidencias y las escribe en el dgv
    Private Sub txtApellido2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellido2.TextChanged
        buscar()
    End Sub

    'procedimiento que al cambiar el texto en el apellido2 busca conicidencias y las escribe en el dgv
    Private Sub txtApellido1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellido1.TextChanged
        buscar()
    End Sub

    'procedimiento que cambia de clientes activos a inactivos
    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        iniciardgv(cboTipo.SelectedIndex)
        txtNumero.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        txtNombre.Text = ""
        If (cboTipo.SelectedIndex = 0) Then
            If id = -1 Then
                btnModificar.Enabled = False
                btnNuevo.Enabled = True
                btnBorrar.Enabled = False
                btnRecuperar.Enabled = False
            Else
                btnModificar.Enabled = True
                btnNuevo.Enabled = True
                btnBorrar.Enabled = True
                btnRecuperar.Enabled = False
            End If
        Else
            If id = -1 Then
                btnModificar.Enabled = False
                btnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnRecuperar.Enabled = False
            Else
                btnModificar.Enabled = False
                btnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnRecuperar.Enabled = True
            End If
        End If
    End Sub

    'procedimiento que al cambiar el texto en el numero busca conicidencias y las escribe en el dgv
    Private Sub txtNumero_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged
        buscar()
    End Sub

    'lo que ocurre al pulsar el boton lista de cambios
    Private Sub btnLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLC.Click
        frmCambios.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    ' Crea una copia de seguridad en xml de la tabla ARTICULOS
    Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_clientes.xml", "clientes")
    End Sub
End Class