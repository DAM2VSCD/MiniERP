Public Class frm_Proveedores

    Dim search As ConnectDB
    Dim data As DataSet
    Dim id As Integer
    Dim elegir As Boolean

    Private Sub frm_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    'rellena el dgv con los proveedores que hay en ese momento
    Sub iniciardgv(ByVal eliminado As Integer)

        Dim poblacion As String
        Dim pob As Integer

        data = search.getData("Select id , cifnif, nombre , direccion , telefono , cp from proveedores where eliminado =" & eliminado, "tproveedores")

        Dim tProveedores As DataTable = data.Tables("tproveedores")


        estilodgvArtDani(dgvProveedores)

        For i As Integer = 0 To dgvProveedores.ColumnCount
            dgvProveedores.Rows.Clear()
        Next
        Dim fila As String()
        For Each row As DataRow In tProveedores.Rows

            pob = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row("cp"))
            poblacion = search.DLookUp("poblacion", "poblaciones", "idpoblacion = '" & pob & "'")


            fila = {row(0).ToString, row(1).ToString, row(2).ToString, poblacion, row(3).ToString, row(4).ToString}
            dgvProveedores.Rows.Add(fila)
        Next

        dgvProveedores.Columns(0).Visible = False

        If (dgvProveedores.RowCount > 0) Then
            id = dgvProveedores.Rows(0).Cells(0).Value
        Else
            id = -1
        End If

    End Sub

    Private Sub btnLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLC.Click
        frmCambios.Show()
    End Sub

    'procedimiento que cambia de clientes activos a inactivos
    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        iniciardgv(cboTipo.SelectedIndex)

        txtCIFNIF.Text = ""
        txtTelefono.Text = ""
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

    ' Método que limpia los filtros del dgv.
    Private Sub limpiarFiltros()
        txtCIFNIF.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        cboTipo.SelectedIndex = 0
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    'propiedad que devuelve la id
    Public ReadOnly Property getId()
        Get
            Return id
        End Get
    End Property

    'procedimiento que ocurre al pulsar el boton borrar
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Try
            Dim nombre As String

            data = search.getData("Select nombre from proveedores where id like " & id, "tproveedores")

            nombre = data.Tables(0).Rows(0)(0).ToString

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea borrar el proveedor " & nombre & "?", MsgBoxStyle.YesNo, "Confirmacion")
            If (respuesta = MsgBoxResult.Yes) Then
                search.setData("UPDATE proveedores set eliminado=1 where ID=" & id)

                insertarCambio("Borrado proveedor " & nombre, 0)
                MsgBox("Borrado con exito")
                iniciardgv(0)
                If id = -1 Then
                    btnModificar.Enabled = False
                    btnNuevo.Enabled = True
                    btnBorrar.Enabled = False
                    btnRecuperar.Enabled = False
                End If
            End If
        Catch ex As IndexOutOfRangeException

            MsgBox("Seleccione un usuario")

        End Try
        

        
    End Sub

    'procedimiento que ocurre al pulsar el boton recuperar
    Private Sub btnRecuperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecuperar.Click
        Try
            Dim nombre As String

            data = search.getData("Select nombre from proveedores where id like " & id, "tproveedores")

            nombre = data.Tables(0).Rows(0)(0).ToString

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Esta seguro que desea recuperar el proveedor " & nombre & "?", MsgBoxStyle.YesNo, "Confirmacion")
            If respuesta = MsgBoxResult.Yes Then
                search.setData("UPDATE proveedores set eliminado=0 where ID=" & id)

                insertarCambio("Recuperado proveedor " & nombre, 0)
            End If
            iniciardgv(1)

        Catch ex As IndexOutOfRangeException

            MsgBox("Seleccione un usuario")

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    'Método BUSCAR para los filtros
    Public Sub buscar()
        Dim numero As String
        If txtTelefono.Text.Equals("") Then
            numero = "%"
        Else
            numero = txtTelefono.Text.ToUpper
        End If

        Dim nombre As String
        If txtNombre.Text.Equals("") Then
            nombre = "%"
        Else
            nombre = txtNombre.Text.ToUpper
        End If

        Dim cifnif As String
        If txtCIFNIF.Text.Equals("") Then
            cifnif = "%"
        Else
            cifnif = txtCIFNIF.Text.ToUpper
        End If

        data = search.getData("Select id , cifnif, nombre , direccion , telefono, cp from proveedores" & _
                            " where eliminado=" & cboTipo.SelectedIndex & " and upper(nombre) like '" & nombre & "%' and " & _
                            "upper(telefono) like'" & numero & "%' and " & _
                            "upper(cifnif) like '" & cifnif & "%' ", "tproveedores")

        Dim tProveedores As DataTable = data.Tables("tproveedores")

        estilodgvArtDani(dgvProveedores)

        For i As Integer = 0 To dgvProveedores.ColumnCount
            dgvProveedores.Rows.Clear()
        Next
        Dim fila As String()
        For Each row As DataRow In tProveedores.Rows

            Dim pob As String = search.DLookUp("refpoblacion", "codigospostalespoblaciones", "refcodigopostal = " & row("cp"))
            Dim poblacion As String = search.DLookUp("poblacion", "poblaciones", "idpoblacion = '" & pob & "'")


            fila = {row(0).ToString, row(1).ToString, row(2).ToString, poblacion, row(3).ToString, row(4).ToString}
            dgvProveedores.Rows.Add(fila)
        Next

        dgvProveedores.Columns(0).Visible = False

        If (dgvProveedores.RowCount > 0) Then
            id = dgvProveedores.Rows(0).Cells(0).Value
        Else
            id = -1
        End If



    End Sub

    Private Sub txtCIFNIF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCIFNIF.TextChanged
        buscar()
        If id = -1 Or cboTipo.SelectedIndex <> 0 Then
            btnModificar.Enabled = False
        Else
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        buscar()
        If id = -1 Or cboTipo.SelectedIndex <> 0 Then
            btnModificar.Enabled = False



        Else
            btnModificar.Enabled = True



        End If
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged
        buscar()
        If id = -1 Or cboTipo.SelectedIndex <> 0 Then
            btnModificar.Enabled = False



        Else
            btnModificar.Enabled = True



        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'Dim nuevo As frm_Nuevo_Modificar_Proveedores = New frm_Nuevo_Modificar_Proveedores(-1)
        'nuevo.ShowDialog()
        'iniciardgv(0)
        'btnModificar.Enabled = True
        'btnBorrar.Enabled = True

        limpiarFiltros()

        frm_Nuevo_Modificar_Proveedores.id = -1
        frm_Nuevo_Modificar_Proveedores.Show()

        Me.Enabled = False
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'Dim modificar As frm_Nuevo_Modificar_Proveedores = New frm_Nuevo_Modificar_Proveedores(id)
        'modificar.ShowDialog()
        'iniciardgv(0)

        frm_Nuevo_Modificar_Proveedores.id = id
        frm_Nuevo_Modificar_Proveedores.Show()

        Me.Enabled = False
    End Sub

    'procedimiento que ocurre al pulsar en el datagridview
    Private Sub dgvClientes_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseClick
        If (e.RowIndex >= 0) Then
            id = dgvProveedores.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    'MODIFICADO POR DANI
    Private Sub btnAceptar_Disposed(sender As Object, e As System.EventArgs) Handles btnAceptar.Disposed
        frmNewArticuloProv.Enabled = True
        frmNewArticuloProv.obtener_proveedor()
        lblActElm.Visible = True
        cboTipo.Visible = True
    End Sub

    Private Sub dgvProveedores_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        If (e.RowIndex >= 0) Then
            id = dgvProveedores.Rows(e.RowIndex).Cells(0).Value()
        End If
    End Sub

    Private Sub dgvProveedores_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick
        If elegir Then
            If (e.RowIndex >= 0) Then
                id = dgvProveedores.Rows(e.RowIndex).Cells(0).Value
                Me.Dispose()
            End If
        End If
    End Sub

    ' Crea una copia de seguridad en xml de la tabla PROVEEDORES
    Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_proveedores.xml", "proveedores")
    End Sub


End Class