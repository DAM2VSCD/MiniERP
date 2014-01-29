Public Class frmPedidosBuscar

    Shared idPedido As Integer

    Shared idCliente As Integer

    Shared idFormaPago As Integer

    Private datosGeneralesPedidos As DataSet = Nothing

    Private datosGeneralesClientes As DataSet = Nothing

    Private datosGeneralesUsuario As DataSet = Nothing

    Private datosGeneralesFormaPago As DataSet = Nothing

    Private tablas As DataTable = Nothing

    Private tipBuscar As ToolTip = Nothing


    Dim sec As String

    ' Flag para controlar que realmente no se haya introducido un carácter prohibido donde corresponda.
    Private SePulsoTipoProhibido As Boolean = False

    Public ReadOnly Property ppIdPedido As Integer
        Get
            Return idPedido
        End Get

    End Property

    Public ReadOnly Property ppIdCliente As Integer
        Get
            Return idCliente
        End Get

    End Property

    Public ReadOnly Property ppFormaPago As Integer
        Get
            Return idFormaPago
        End Get

    End Property


    'rellena el dgv con los clientes que hay en ese momenot
    Sub iniciardgv()

        estilodgvArt(dgvPedido)

        buscar()

    End Sub

    Private Sub cargarValoresIniciales()

        jcbComparaFechaRealizacion.SelectedIndex = 0
        jcbComparaFechaLlegada.SelectedIndex = 0

        tipBuscar = New ToolTip()

        ' Se le da formado al combobox de los usuarios.
        rellenacombobox(cboUsuario, "SELECT IDUSUARIO, NOMBRE FROM USUARIOS", "--Todos--")
        If cboUsuario.Items.Count > 0 Then ' Hay que asegurarse de que no falle si no hay usuarios (a esto JAMÁS se debería llegar)
            cboUsuario.SelectedIndex = 0
        End If

        ' Se le da formato al comboBox de las formas de pago.
        rellenacombobox(comboFormaPago, "SELECT * FROM FORMASDEPAGO", "--Todas--")
        If comboFormaPago.Items.Count > 0 Then ' Hay que asegurarse de que no falle si no hay formas de pago (podría darse el caso).
            comboFormaPago.SelectedIndex = 0
        End If

        ' Se le da formato al comboBox de eliminado / no eliminado
        Dim cadena As String()
        ReDim cadena(1)
        cadena(0) = "No eliminados"
        cadena(1) = "Eliminados"
        rellenacomboboxStr(cboEliminados, cadena)
        If cboEliminados.Items.Count > 0 Then ' Hay que asegurarse de que no falle si no hay formas de pago (podría darse el caso).
            cboEliminados.SelectedIndex = 0
        End If
    End Sub

    Private Sub frmPedidosBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        iniciardgv()
        cargarValoresIniciales()
        Me.TopMost = True

        inhabilitaClickDerecho(txtNumPedido)
        inhabilitaClickDerecho(txtNombreCliente)
        inhabilitaClickDerecho(txtApellidoCliente1)
        inhabilitaClickDerecho(txtApellidoCliente2)
    End Sub


    ' Al cerrar el frmPedidosNuevo o frmDetallePedidos se desencadena este método que actualiza el frame.
    Public Sub actualizaLista()
        ' Solo tiene sentido que entre aquí si el Articulo fue abierto desde creación de pedidos.
        If Me.Visible Then
            Me.Focus()
            Me.TopMost = True
            buscar()
        End If
    End Sub

    ' Añade una fila al datagridview.
    Public Sub anyadeFilaAlDGV(ByVal filaPedido As DataRow, ByVal filaCliente As DataRow, ByVal filaUsuario As DataRow, ByVal filaFormaPago As DataRow)

        dgvPedido.Rows.Add()
        Dim fila As Integer = dgvPedido.Rows.Count() - 1


        Dim fechaRealizacionDate As Date = number2Date(Convert.ToInt32(filaPedido("FECHA").ToString), 0)
        Dim fechaRealizacion As String = fechaRealizacionDate.ToString("yyyy/MM/dd")
        Dim fechaLlegadaDate As Date = number2Date(Convert.ToInt32(filaPedido("FECHAENTREGA").ToString), 0)
        Dim fechaLlegada As String = fechaLlegadaDate.ToString("yyyy/mm/dd")

        dgvPedido.Item(0, fila).Value = filaPedido("NUMPEDIDO").ToString
        dgvPedido.Item(1, fila).Value = filaCliente("NOMBRE").ToString
        dgvPedido.Item(2, fila).Value = filaCliente("APELLIDO1").ToString
        dgvPedido.Item(3, fila).Value = filaCliente("APELLIDO2").ToString
        dgvPedido.Item(4, fila).Value = filaUsuario("NOMBRE").ToString
        dgvPedido.Item(5, fila).Value = filaPedido("TOTAL").ToString
        dgvPedido.Item(6, fila).Value = filaPedido("PAGADO").ToString
        dgvPedido.Item(7, fila).Value = filaFormaPago("FORMAPAGO").ToString
        dgvPedido.Item(8, fila).Value = fechaRealizacion
        dgvPedido.Item(9, fila).Value = fechaLlegada
        dgvPedido.Item(10, fila).Value = filaPedido("REFCLIENTE").ToString
        dgvPedido.Item(11, fila).Value = filaPedido("REFUSUARIO").ToString
        dgvPedido.Item(12, fila).Value = filaPedido("IDPEDIDO").ToString
        dgvPedido.Item(13, fila).Value = filaPedido("REFFORMAPAGO").ToString

    End Sub

    'procedimiento buscar que es capaz de buscar por nombre y apellidos a la vez
    Private Sub buscar()

        For j = 0 To dgvPedido.Rows.Count - 1
            dgvPedido.Rows.RemoveAt(0)
        Next

        Dim filaPedido As DataRow = Nothing

        Dim refCliente As String = ""
        Dim filaCliente As DataRow = Nothing
        Dim tablasClientes As DataTable = Nothing
        Dim sentenciaNombreApellidos As String = ""

        Dim refUsuario As String = ""
        Dim filaUsuario As DataRow = Nothing
        Dim tablasUsuario As DataTable = Nothing
        Dim sentenciaUsuario As String = ""

        Dim refFormaPago As String = ""
        Dim filaFormaPago As DataRow = Nothing
        Dim tablasFormaPago As DataTable = Nothing
        Dim sentenciaFormaPago As String = ""

        ' GESTIÓN DEL IDPEDIDO.
        Dim numPedido As String
        If txtNumPedido.Text.Equals("") Then
            numPedido = "%"
        Else
            numPedido = txtNumPedido.Text
        End If

        ' GESTIÓN DE LOS DATOS DEL CLIENTE.
        Dim nombre As String ' Nombre.
        If txtNombreCliente.Text.Equals("") Then
            nombre = "%"
        Else
            nombre = txtNombreCliente.Text
        End If

        Dim apellido1 As String ' Apellido 1.
        If txtApellidoCliente1.Text.Equals("") Then
            apellido1 = "%"
        Else
            apellido1 = txtApellidoCliente1.Text
        End If

        Dim apellido2 As String ' Apellido 2.
        If txtApellidoCliente2.Text.Equals("") Then
            apellido2 = "%"
        Else
            apellido2 = txtApellidoCliente2.Text
        End If

        ' Se obtienen las id de los clientes que cumplen esa condición.
        Dim sentenciaParteClientes = "Select idcliente from clientes" & _
                            " where eliminado=0 and UPPER(nombre) like UPPER('" & nombre & "%') and " & _
                            "UPPER(apellido1) like UPPER('" & apellido1 & "%') and " & _
                            "UPPER(apellido2) like UPPER('" & apellido2 & "%')"

        ' GESTIÓN DE LOS DATOS DEL USUARIO.
        ' Se obtienen las id de los usuarios que cumplen esa condición.
        Dim sentenciaParteUsuarios As String = "Select idusuario from usuarios" & _
                            " where eliminado=0 and REFUSUARIO like '" & sec & "'"


        ' GESTIÓN DE LA FORMA DE PAGO.
        Dim formaPagoValue As String = "%"
        If comboFormaPago.SelectedIndex > 0 Then
            formaPagoValue = comboFormaPago.SelectedValue
        End If

        ' GESTIÓN DEL COMBOBOX ELIMINADO/NOELIMINADO.
        Dim eliminado As String = "0"
        If cboEliminados.SelectedIndex = 1 Then
            eliminado = "1"
        End If

        ' GESTIÓN DE LAS OPCIÓN DE FECHA DE REALIZACIÓN.
        'Filtra por fecha si el checkbox esta activo
        Dim fecRealizacion As String = "%"
        Dim consultaFechaRealizacion As String = " FECHA LIKE '%' "
        If cbFechaRealizacion.Checked Then
            fecRealizacion = Fecha2number(dtpFechaRealizacion.Value)
            consultaFechaRealizacion = " FECHA " & jcbComparaFechaRealizacion.SelectedItem.ToString & " " & fecRealizacion
        End If

        ' GESTIÓN DE LAS OPCIÓN DE FECHA DE LLEGADA.
        'Filtra por fecha si el checkbox esta activo
        Dim fecLlegada As String = "%"
        Dim consultaFechaLlegada As String = " FECHAENTREGA LIKE '%' "
        If cbFechaLlegada.Checked Then
            fecLlegada = Fecha2number(dtpFechaLlegada.Value)
            consultaFechaLlegada = " FECHAENTREGA " & jcbComparaFechaLlegada.SelectedItem.ToString & " " & fecLlegada
        End If

        Dim sentenciaDatosGeneralesPedidos As String = "SELECT IDPEDIDO, NUMPEDIDO, REFCLIENTE, REFUSUARIO, TOTAL, PAGADO, REFFORMAPAGO, FECHA, HORAPEDIDO, FECHAENTREGA, ELIMINADO FROM PEDIDOS_CLIENTES " & _
                                        " WHERE ((" & _
                                        "NUMPEDIDO LIKE '" & numPedido & "%' " & _
                                        ") AND (" & _
                                        "REFCLIENTE IN (" & sentenciaParteClientes & ") " & _
                                        ") AND (" & _
                                        "REFUSUARIO IN (" & sentenciaParteUsuarios & ") " & _
                                        ") AND (" & _
                                        "REFFORMAPAGO LIKE ('" & formaPagoValue & "') " & _
                                        ") AND (" & _
                                        consultaFechaRealizacion & _
                                        ") AND (" & _
                                        consultaFechaLlegada & _
                                        ") AND (" & _
                                        "ELIMINADO ='" & eliminado & "'" & _
                                        "))"

        datosGeneralesPedidos = conexion.getData(sentenciaDatosGeneralesPedidos, "tablas")

        datosGeneralesPedidos = conexion.getData(sentenciaDatosGeneralesPedidos, "tablasPedidos")
        Dim tablaspedidos As DataTable = datosGeneralesPedidos.Tables("tablaspedidos")

        For i = 0 To tablaspedidos.Rows.Count - 1
            filaPedido = tablaspedidos.Rows(i)

            refCliente = filaPedido("refcliente").ToString
            sentenciaNombreApellidos = " select nombre, apellido1, apellido2 from clientes where idcliente = '" & refCliente & "'"
            datosGeneralesClientes = conexion.getdata(sentenciaNombreApellidos, "tablasclientes")
            tablasClientes = datosGeneralesClientes.Tables("tablasclientes")
            filaCliente = tablasClientes.Rows(0)

            refUsuario = filaPedido("refusuario").ToString
            sentenciaUsuario = "select nombre from usuarios where idusuario = '" & refUsuario & "'"
            datosGeneralesUsuario = conexion.getdata(sentenciaUsuario, "tablasusuario")
            tablasUsuario = datosGeneralesUsuario.Tables("tablasusuario")
            filaUsuario = tablasUsuario.Rows(0)

            refFormaPago = filaPedido("refformapago").ToString
            sentenciaFormaPago = "select formapago from formasdepago where idformapago = '" & refFormaPago & "'"
            datosGeneralesFormaPago = conexion.getdata(sentenciaFormaPago, "tablasformapago")
            tablasFormaPago = datosGeneralesFormaPago.Tables("tablasformapago")
            filaFormaPago = tablasFormaPago.Rows(0)

            anyadeFilaAlDGV(filaPedido, filaCliente, filaUsuario, filaFormaPago)
        Next



        Dim datatabla As DataTable = datosGeneralesPedidos.Tables("tablas")
        dgvPedido.DataSource = datatabla

        dgvPedido.Columns(0).Visible = False

        ' Solo se muestra el botón si hay al menos un resultado
        If dgvPedido.Rows.Count > 0 Then
            If cboEliminados.SelectedIndex = 0 Then
                btnDetallePedido.Enabled = True
            End If
            btnEliminar.Enabled = True
            dgvPedido.Rows(0).Selected = True
            idPedido = dgvPedido.Rows(0).Cells(12).Value
            idCliente = dgvPedido.Rows(0).Cells(10).Value
            idFormaPago = dgvPedido.Rows(0).Cells(13).Value
        Else
            btnDetallePedido.Enabled = False
            btnEliminar.Enabled = False
            idPedido = -1
            idCliente = -1
            idFormaPago = -1
        End If

    End Sub

    ' Evento al cambiar el valor del combobox para elegir la forma de pago.
    Private Sub cmbFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboFormaPago.SelectedIndexChanged
        buscar()
    End Sub

    'procedimiento que ocurre al pulsar en el datagridview
    Private Sub dgvPedido_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPedido.CellMouseClick
        If e.RowIndex > -1 Then
            idPedido = dgvPedido.Rows(e.RowIndex).Cells(12).Value
            idCliente = dgvPedido.Rows(e.RowIndex).Cells(10).Value
            idFormaPago = dgvPedido.Rows(e.RowIndex).Cells(13).Value
        End If
    End Sub

    ' Gestiona el consumo de eventos de KeyDown en los que solo se permitan cifras.
    Private Sub gestionaEventoNumerosKeyDown(ByRef txt As TextBox, ByVal iconoFallo As PictureBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        SePulsoTipoProhibido = seMarcoNoCifra(e)
        If SePulsoTipoProhibido Then
            iconoFallo.Visible = True
            tipBuscar.Show("Solo se admiten cifras", txt)
        Else
            tipBuscar.Hide(txt)
            iconoFallo.Visible = False
        End If
    End Sub

    ' Gestiona el consumo de eventos de KeyPress en los que solo se permitan cifras.
    Private Sub gestionaEventoNumeroKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If SePulsoTipoProhibido = True Then
            e.Handled = True
        End If
    End Sub

    ' Gestiona el consumo de eventos de KeyDown en los que o se permitirán caracteres especiales..
    Private Sub gestionaEventoSoloAlbafetoKeyDown(ByRef txt As TextBox, ByVal iconoFallo As PictureBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        SePulsoTipoProhibido = seMarcoNoLetraAlfabeto(e)
        If SePulsoTipoProhibido Then
            iconoFallo.Visible = True
            tipBuscar.Show("Solo se admiten cifras y letras", txt)
        Else
            tipBuscar.Hide(txt)
            iconoFallo.Visible = False
        End If
    End Sub

    ' Gestiona el consumo de eventos de KeyPress en los que no se permitirán caracteres especiales.
    Private Sub gestionaEventoLetrasProhibidasKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Check for the flag being set in the KeyDown event. 
        If SePulsoTipoProhibido = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub

    'procedimiento que al cambiar el texto en el numPedido busca coincidencias y las escribe en el dgv
    Private Sub txtNumPedido_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumPedido.TextChanged
        buscar()
    End Sub

    Private Sub txtNumPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumPedido.KeyDown
        gestionaEventoNumerosKeyDown(txtNumPedido, pboxFalloNumeroPedido, e)
    End Sub

    Private Sub txtNumPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumPedido.KeyPress
        If (ValorNumerico(AscW(e.KeyChar)) = False Or txtNumPedido.Text.Length = 5) And Not AscW(e.KeyChar) = 8 Then
            e.Handled() = True
            tipBuscar.Show("Solo puede introducir letras con una logitud máxima de 5", txtNumPedido)
        Else
            tipBuscar.Hide(txtNumPedido)
        End If
    End Sub

    'procedimiento que al cambiar el texto en el nombreCliente busca coincidencias y las escribe en el dgv
    Private Sub txtNombreCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreCliente.TextChanged
        buscar()
    End Sub

    Private Sub txtNombreCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreCliente.KeyDown
        gestionaEventoSoloAlbafetoKeyDown(txtNombreCliente, pboxFalloNombreCliente, e)
    End Sub

    Private Sub txtNombreCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreCliente.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtNombreCliente.Text.Length = 30 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tipBuscar.Show("Solo puede introducir letras con una logitud máxima de 30", txtNombreCliente)
        Else
            tipBuscar.Hide(txtNombreCliente)
        End If
    End Sub

    'procedimiento que al cambiar el texto en el apellidoCliente1 busca coincidencias y las escribe en el dgv
    Private Sub txtApellidoCliente1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoCliente1.TextChanged
        buscar()
    End Sub

    Private Sub txtApellidoCliente1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoCliente1.KeyDown
        gestionaEventoSoloAlbafetoKeyDown(txtApellidoCliente1, pboxFalloApellidoCliente1, e)
    End Sub

    Private Sub txtApellidoCliente1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoCliente1.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtApellidoCliente1.Text.Length = 20 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tipBuscar.Show("Solo puede introducir letras con una logitud máxima de 20", txtApellidoCliente1)
        Else
            tipBuscar.Hide(txtApellidoCliente1)
        End If
    End Sub

    'procedimiento que al cambiar el texto en el apellidoCliente2 busca coincidencias y las escribe en el dgv
    Private Sub txtApellidoCliente2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellidoCliente2.TextChanged
        buscar()
    End Sub

    Private Sub txtApellidoCliente2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoCliente2.KeyDown
        gestionaEventoSoloAlbafetoKeyDown(txtApellidoCliente2, pboxFalloApellidoCliente2, e)
    End Sub

    Private Sub txtApellidoCliente2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoCliente2.KeyPress
        If (ValorAlfabetico(AscW(e.KeyChar)) = False Or txtApellidoCliente2.Text.Length = 20 And Not AscW(e.KeyChar) = 8) Then
            e.Handled() = True
            tipBuscar.Show("Solo puede introducir letras con una logitud máxima de 20", txtApellidoCliente2)
        Else
            tipBuscar.Hide(txtApellidoCliente2)
        End If
    End Sub


    Private Sub btnBuscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearPedido.Click
        Me.Enabled = False
        frmPedidosNuevo.soyModificar = False
        frmPedidosNuevo.Show()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.Enabled = False
        frmPedidosNuevo.soyModificar = True
        frmPedidosNuevo.Show()
    End Sub

    Private Sub btnDetallePedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetallePedido.Click
        Me.Enabled = False
        frmDetallePedidos.Show()
    End Sub

    Private Sub cboUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUsuario.SelectedIndexChanged
        If IsNumeric(cboUsuario.SelectedValue.ToString) Then
            sec = cboUsuario.SelectedValue.ToString
            If sec = -1 Then
                sec = "%"
            End If
        Else
            sec = "%"
        End If

        buscar()
    End Sub

    Private Sub cboEliminados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEliminados.SelectedIndexChanged
        If cboEliminados.SelectedIndex = 1 Then
            btnEliminar.Text = "RESTAURAR"
            btnDetallePedido.Enabled = False
        Else
            btnEliminar.Text = "ELIMINAR"
            btnDetallePedido.Enabled = True
        End If
        buscar()
    End Sub

    Private Sub cbFechaRealizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFechaRealizacion.CheckedChanged
        'Habilita o inhabilita la fecha de realización.
        If cbFechaRealizacion.Checked Then
            dtpFechaRealizacion.Enabled = True
        Else
            dtpFechaRealizacion.Enabled = False
        End If

        buscar()
    End Sub

    Private Sub cbFechaLlegada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFechaLlegada.CheckedChanged
        'Habilita o inhabilita la fecha de llegada.
        If cbFechaLlegada.Checked Then
            dtpFechaLlegada.Enabled = True
        Else
            dtpFechaLlegada.Enabled = False
        End If

        buscar()
    End Sub

    Private Sub dtpFechaRealizacion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaRealizacion.ValueChanged
        buscar()
    End Sub

    Private Sub dtpFechaLlegada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaLlegada.ValueChanged
        buscar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim result = MessageBox.Show("¿Seguro que desea completar la acción de borrado/restauración?", "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim numero As Integer = 0
            Dim cadenaTexto As String = "restaurado"
            Dim cadenaTexto2 As String = "restauracion"
            If cboEliminados.SelectedIndex = 0 Then
                numero = 1
                cadenaTexto = "eliminado"
                cadenaTexto2 = "borrado"
            End If
            Dim sentencia As String = "UPDATE PEDIDOS_CLIENTES SET ELIMINADO = " & numero & " WHERE IDPEDIDO = " & idPedido

            ' Ahora se elige el nombre para inventariar los cambios.
            conexion.setData(sentencia)
            sentencia = "SELECT NUMPEDIDO FROM PEDIDOS_CLIENTES WHERE IDPEDIDO=" & idPedido
            Dim Data As DataSet = Comun.conexion.getData(sentencia, "CAM")
            Dim t As DataTable = Data.Tables("CAM")
            Dim filaAqui As DataRow = t.Rows(0)
            Dim nombreAPoner As String = filaAqui("NUMPEDIDO").ToString
            insertarCambio("Tipo " & nombreAPoner & " " & cadenaTexto, 0)
            buscar()
            MsgBox("La acción de " & cadenaTexto2 & " se completó con éxito")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambios.Click
        frmCambios.Show()
    End Sub

    Private Sub btnDetallePedido_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetallePedido.EnabledChanged
        btnModificar.Enabled = btnDetallePedido.Enabled
    End Sub

    Private Sub jcbComparaFechaRealizacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jcbComparaFechaRealizacion.SelectedIndexChanged
        buscar()
    End Sub

    Private Sub jcbComparaFechaLlegada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jcbComparaFechaLlegada.SelectedIndexChanged
        buscar()
    End Sub

    ' Crea una copia de seguridad en xml de la tabla PEDIDOS
    Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarXML.Click
        generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_pedidos_clientes.xml", "pedidos_clientes")
        Dim respuesta As MsgBoxResult
        Dim mensaje As String = "De forma adicional, usted puede realizar una copia de seguridad de la líneas de pedidos de todos los pedidos, ¿desea realizar esta operación?"
        respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            generarCopiaSeguridadParcialEnXML("SEG_PARCIAL_pedidos_clientes_articulos.xml", "pedidos_clientes_articulos")
        End If
    End Sub
End Class