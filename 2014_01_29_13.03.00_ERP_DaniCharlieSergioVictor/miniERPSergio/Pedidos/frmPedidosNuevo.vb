Imports System.Text.RegularExpressions

Public Class frmPedidosNuevo

    ' Será TRUE cuando se vaya a MODIFICAR un artículo en vez de CREARLO.
    Public Shared soyModificar As Boolean = False

    Private fechaEntrega As Date

    ' Controla que el DGV tenga valores adecuados antes de una inserción.
    Private esValidoElDGV As Boolean = False

    ' Para controlar que al cargar el formulario por primera vez no se hagan ciertas operaciones.
    Private primeraPasada As Boolean

    ' Identificador de cliente.
    ' Identificador del producto actual.
    Shared idCliente, idArticulo, idPedidos As Integer

    ' Etiquetas a mostrar en los errores.
    Private tip1, tip2, tip3, tip4 As ToolTip

    ' Determina si el cliente ha sido elegido y es válido.
    ' Determina si el articulo ha sido elegido y es válido.
    Private clienteElegido, articuloElegido As Boolean

    ' Determina si el tipo de pago ha sido elegido y es válido.
    Private tipoPagoElegido As Boolean

    ' Date a la que se realiza el pedido.
    Private FechaHoraPedido As Date

    ' Date a la que se estima que llegará el pedido.
    Private FechaHoraLlegada As Date

    ' La hora es correctar
    Private horaEsCorrecto As Boolean = True

    ' Sirve para controlar que se pueda añadir el pedido si en algún momento se validó que el DGV tiene los requisitos necesarios de Articulos
    Private seguimosAdelante As Boolean = False

    ' Total que hay que pagar.
    Private precioTotalAPagar As Double

    'Private cantidadAPagarValida As Boolean

    ' DataSet que contiene el resultado de la consulta para saber los distintos posibles productos que hay.
    ' DataSet que contiene el resultado de la consulta para saber los datos del cliente.
    ' DataSet con los resultados de consultas parciales que se van haciendo.
    Private datosArticulo, datosCliente, datosParciales As DataSet

    ' Elemento para controlar los keyPress y keyDown de la cantidad de elementos pedidos.
    Private WithEvents txtNumeric As New DataGridViewTextBoxEditingControl

    ' Flag para controlar que realmente no se haya introducido un número en la cantidad del producto.
    Private noSeIntrodujoNumero As Boolean = False

    ' Carga del formulario.
    Private Sub PedidosPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Se cargan los valores iniciales.
        Me.MdiParent = frmPrincipal
        cargaValoresIniciales()
        Me.TopMost = True
    End Sub

    '------------------------------------------------------------------------------------------------------

    ' Realiza las operaciones previas que debe tener este formulario y que se mostrarán por pantalla.
    Public Sub cargaValoresIniciales()
        'cantidadAPagarValida = True
        tip1 = New ToolTip()
        tip2 = New ToolTip()
        tip3 = New ToolTip()
        tip4 = New ToolTip()
        ' Se le da formato al comboBox de las formas de pago.
        rellenacombobox(cmbFormaPago, "SELECT * FROM FORMASDEPAGO WHERE ACTIVO = 0", "--Seleccione forma de pago--")

        lblAdvertenciaArticuloExiste.Hide()

        If Not soyModificar Then
            txtDineroPagado.Text = ""
            btnNuevoPedido.Text = "INSERTAR PEDIDO"
            idCliente = -1
            idArticulo = -1
            primeraPasada = True

            clienteElegido = False
            articuloElegido = False
            tipoPagoElegido = False
        Else
            btnNuevoPedido.Text = "MODIFICAR"
            idPedidos = frmPedidosBuscar.ppIdPedido
            If idPedidos < 1 Then
                idPedidos = 1
            End If
            obtenerCliente(True)
            obtenerTipoPago(idPedidos)
            obtenerHoras(idPedidos)
            clienteElegido = True
            tipoPagoElegido = True

        End If

        ' Se le da formato al datagridview.
        editarFormatoDGV()

        ' Se examina el estado inicial del apartado cliente.
        gestionarErroresCliente_Proveedor(idCliente, pboxClienteAcierto, pboxClienteError)

        primeraPasada = False

        ' Se rellenan los comboBox de hora, minuto, segundo y DÍAS retraso defecto.
        rellenaComboEnteros(comboBoxHora, 0, 23, 1, Nothing, -1)
        rellenaComboEnteros(comboBoxMinuto, 0, 59, 1, Nothing, -1)
        rellenaComboEnteros(comboBoxSegundo, 0, 59, 1, Nothing, -1)
        rellenaComboEnteros(comboBoxDiasDefecto, 0, 60, 1, "Eleccion libre", 0)
        'rellenaComboEnteros(comboBoxPorcentajePagado, 0, 100, 10, Nothing, 10)

        ActualizaTiempoPedido(True)
        actualizaTiempoLlegada(True)

        If soyModificar Then
            actualizaComboBoxHoraMinutoSegundo(fechaEntrega)

            rellenaDGVPrimeraPasadaModificar()
        End If

    End Sub

    ' Añade una fila al datagridview (PENDIENTE DE ACABAR POR PROBLEMAS).
    Public Sub rellenaDGVPrimeraPasadaModificar()
        Dim datosUsados As DataSet = Nothing
        Dim tablaUsada As DataTable = Nothing
        Dim filaUsada As DataRow = Nothing
        Dim tipo As String = Nothing

        Dim datosAuxiliares As DataSet = Nothing
        Dim tablasAuxiliar As DataTable = Nothing
        Dim filaAuxiliar As DataRow = Nothing

        Dim selectCadena As String = "SELECT * FROM PEDIDOS_CLIENTES WHERE IDPEDIDO= " & idPedidos
        datosUsados = conexion.getData(selectCadena, "tabla")
        tablaUsada = datosUsados.Tables("tabla")
        filaUsada = tablaUsada.Rows(0)
        txtDineroPagado.Text = filaUsada("PAGADO").ToString


        datosAuxiliares = conexion.getData("SELECT * FROM PEDIDOS_CLIENTES_ARTICULOS WHERE REFPEDIDO= " & idPedidos, "tablaAuxiliar")
        tablasAuxiliar = datosAuxiliares.Tables("tablaAuxiliar")

        For i = 0 To tablasAuxiliar.Rows.Count - 1
            dgvPedidos.Rows.Add()
            filaAuxiliar = tablasAuxiliar.Rows(i)

            dgvPedidos.Item(0, i).Value = filaAuxiliar("REFARTICULO").ToString

            Dim datosArticulos As DataSet = conexion.getData("SELECT * FROM ARTICULOS WHERE IDARTICULO= " & filaAuxiliar("REFARTICULO").ToString, "tablaArticulos")
            Dim tablaArticulo As DataTable = datosArticulos.Tables("tablaArticulos")
            Dim filaArticulo As DataRow = tablaArticulo.Rows(0)

            dgvPedidos.Item(1, i).Value = filaArticulo("NOMBRE").ToString

            Dim datosTipo As DataSet = conexion.getData("SELECT * FROM TIPOS WHERE IDTIPO= " & filaArticulo("REFTIPO").ToString, "tablaTipos")
            Dim tablaTipo As DataTable = datosArticulos.Tables("tablaTipos")
            Dim filaTipo As DataRow = tablaArticulo.Rows(0)

            dgvPedidos.Item(2, i).Value = filaTipo("NOMBRE").ToString

            dgvPedidos.Item(3, i).Value = filaArticulo("STOCK").ToString

            dgvPedidos.Item(4, i).Value = filaAuxiliar("CANTIDAD").ToString

            dgvPedidos.Item(5, i).Value = filaArticulo("PRECIO").ToString

            dgvPedidos.Item(6, i).Value = Convert.ToDouble(filaAuxiliar("CANTIDAD").ToString) * Convert.ToDouble(filaArticulo("PRECIO").ToString)

            dgvPedidos.Item(7, i).Value = filaArticulo("IDARTICULO").ToString
            dgvPedidos.Item(4, i).ReadOnly = False
        Next
        articuloElegido = True
        comprobarSiSePuedeInsertarPedido()

        If soyModificar Then
            If dgvPedidos.Rows.Count <= 1 Then
                btnEliminarArticulo.Enabled = False
            End If
        End If

    End Sub

    

    ' Configura el formato inicial del dataGridView
    Public Sub editarFormatoDGV()

        ' Se llama al método común.
        estilodgvArt(dgvPedidos)

        ' para que no se muestre una fila de más (la editable por defecto para el usuario).
        dgvPedidos.AllowUserToAddRows = False

        ' Para que el tamaño de la columnas se adapte al texto.
        dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Se le dice que columnas concretas pueden ser editables (solo puede ser editable CANTIDAD).
        For i = 0 To dgvPedidos.Columns.Count - 1
            dgvPedidos.Columns(i).ReadOnly = True
            If i = 4 Then
                dgvPedidos.Columns(i).ReadOnly = False
            End If
        Next

    End Sub


    ' Añade una fila al datagridview.
    Public Sub anyadeFilaAlDGV(ByVal filaUsada As DataRow)
        Dim tablaUsada As DataTable = Nothing
        Dim filaAqui As DataRow = Nothing
        Dim tipo As String = Nothing

        datosParciales = conexion.getData("SELECT NOMBRE FROM TIPOS WHERE IDTIPO=" & filaUsada("REFTIPO").ToString, "tabla")
        tablaUsada = datosParciales.Tables("tabla")
        filaAqui = tablaUsada.Rows(0)
        tipo = filaAqui("NOMBRE").ToString

        dgvPedidos.Rows.Add()
        dgvPedidos.Columns("CANTIDAD").ReadOnly = False
        Dim fila As Integer = dgvPedidos.Rows.Count() - 1
        dgvPedidos.Item(0, fila).Value = filaUsada("NUMARTICULO").ToString
        dgvPedidos.Item(1, fila).Value = filaUsada("NOMBRE").ToString
        dgvPedidos.Item(2, fila).Value = tipo
        dgvPedidos.Item(3, fila).Value = filaUsada("STOCK").ToString
        dgvPedidos.Item(5, fila).Value = filaUsada("PRECIO").ToString
        dgvPedidos.Item(7, fila).Value = filaUsada("IDARTICULO").ToString
        dgvPedidos.Item(4, fila).ReadOnly = False
    End Sub

    ' Se sobreescribe el Dispose de frmPedidosNuevo.
    Private Sub frmPedidosNuevo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmPedidosBuscar.Enabled = True
        frmPedidosBuscar.actualizaLista()
    End Sub

    ' -----------------------------------------------------

    ' MÉTODOS Y ZONAS QUE ESTÁN DIRECTAMENTE RELACIONADAS CON OTRAS CLASES (CAPTURA DE ID CLIENTE Y ARTÍCULO)

    ' Se pulsa el botón para buscar un cliente.
    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        clienteElegido = False
        Me.Enabled = False
        frm_Clientes.setElegir = True
        frm_Clientes.lblActElm.Visible = False
        frm_Clientes.cboTipo.Visible = False
        frm_Clientes.Show()
    End Sub

    ' Al cerrar el frm_Clientes se desencadena este método (captura el IdCliente elegido en frm_Clientes).
    ' Obtiene el idCliente del frame de clientes.
    Public Sub obtenerCliente(ByVal soyModificar As Boolean)
        ' Solo tiene sentido que entre aquí si el cliente fue abierto desde creación de pedidos.
        ' De no hacerlo así saltaría excepción.
        frm_Clientes.lblActElm.Visible = True
        frm_Clientes.cboTipo.Visible = True
        If Me.Visible Then
            If soyModificar Then
                idCliente = frmPedidosBuscar.ppIdCliente
            Else
                idCliente = frm_Clientes.getId
            End If

            Me.Focus()
            Me.TopMost = True

            If idCliente >= 0 Then
                tip1.Hide(txtCliente)
                datosCliente = conexion.getData("SELECT NOMBRE, APELLIDO1, APELLIDO2 FROM CLIENTES WHERE IDCLIENTE=" & idCliente, "tabla")
                Dim tablaUsada As DataTable = datosCliente.Tables("tabla")
                Dim fila As DataRow = tablaUsada.Rows(0)
                txtCliente.Text = fila("NOMBRE").ToString() & " " & fila("APELLIDO1").ToString() & " " & fila("APELLIDO2").ToString()
                clienteElegido = True
            Else
                If idCliente = -1 Then
                    txtCliente.Text = ""
                    tip1.Show("Usted debe elegir un cliente", txtCliente)
                    clienteElegido = False
                End If
            End If
            comprobarSiSePuedeInsertarPedido()
            gestionarErroresCliente_Proveedor(idCliente, pboxClienteAcierto, pboxClienteError)
        End If
    End Sub

    ' Al cerrar el frmArticulos se desencadena este método (captura el IdArticulo elegido en frmArticulos).
    ' Obtiene el IdArticulo del frame de articulo.
    Public Sub obtenerArticulo()
        ' Solo tiene sentido que entre aquí si el Articulo fue abierto desde creación de pedidos.
        If Me.Visible Then
            Me.Focus()
            Me.TopMost = True
            idArticulo = frmArticulos.getId
            If idArticulo >= 0 Then
                btnEliminarArticulo.Enabled = True
                datosArticulo = conexion.getData("SELECT IDARTICULO, NOMBRE, REFTIPO, PRECIO, ELIMINADO, NUMARTICULO, STOCK FROM ARTICULOS WHERE IDARTICULO=" & idArticulo, "tabla")
                Dim tablaUsada As DataTable = datosArticulo.Tables("tabla")
                Dim fila As DataRow = tablaUsada.Rows(0)

                ' Aquí se comprueba que ese artículo no se haya añadido ya.
                Dim estaRepetido As Boolean = False
                Dim contador As Integer = 0
                If dgvPedidos.Rows.Count > 0 Then
                    Do
                        If dgvPedidos.Item(7, contador).Value = idArticulo Then
                            estaRepetido = True
                        End If
                        contador += 1
                    Loop While (contador < dgvPedidos.Rows.Count And Not estaRepetido)
                End If

                If estaRepetido Then
                    'MsgBox("El artículo " & fila("NOMBRE").ToString & " " & fila("NUMARTICULO") & " ya estaba incluido, modifique su cantidad")
                    lblAdvertenciaArticuloExiste.Show()
                    btnAnyadirProducto.Enabled = True
                Else
                    lblAdvertenciaArticuloExiste.Hide()
                    anyadeFilaAlDGV(fila)
                    articuloElegido = True
                    tip4.Hide(txtOculto2)
                End If
            Else
                If idArticulo = -1 Then
                    tip4.Show("Si elige un artículo debe completar su elección", txtOculto2)
                    articuloElegido = False
                    btnAnyadirProducto.Enabled = True
                End If
            End If
        End If
    End Sub

    ' -----------------------------------------------------

    ' Comprueba que los posibles errores que haya en los artículos que se van añadiendo.
    Public Sub gestionarErroresArticulo(ByVal valido As Boolean)
        If valido Then
            gestionarErroresEtiquetas(True, pboxProductoElegidoError, pboxProductoElegidoAcierto)
        Else
            gestionarErroresEtiquetas(False, pboxProductoElegidoError, pboxProductoElegidoAcierto)
        End If
    End Sub

    Private Sub obtenerHoras(ByVal idPedido As Integer)
        Dim datosParciales As DataSet = conexion.getData("select fecha, horapedido, fechaentrega from PEDIDOS_CLIENTES where idpedido = " & idPedido, "tabla")
        Dim tablaUsada As DataTable = datosParciales.Tables("tabla")
        Dim fila As DataRow = tablaUsada.Rows(0)
        Dim fechaPedido As Date = number2Date(Convert.ToInt32(fila("FECHA").ToString), Convert.ToInt32(fila("HORAPEDIDO").ToString))
        fechaEntrega = number2Date(Convert.ToInt32(fila("FECHAENTREGA").ToString), Convert.ToInt32(fila("HORAPEDIDO").ToString))

        Try
            DateTimePicker1.Value = New DateTime(fechaPedido.Year, fechaPedido.Month, fechaPedido.Day)
        Catch exc1 As ArgumentOutOfRangeException

        End Try

        Try
            DateTimePicker2.Value = New DateTime(fechaEntrega.Year, fechaEntrega.Month, fechaEntrega.Day)
        Catch exc1 As ArgumentOutOfRangeException
        End Try

    End Sub

    ' Solo se usa al modificar.
    Private Sub obtenerTipoPago(ByVal idPedidos As Integer)
        Dim datosParciales As DataSet = conexion.getData("SELECT REFFORMAPAGO FROM PEDIDOS_CLIENTES WHERE IDPEDIDO=" & idPedidos, "tabla")
        Dim tablaUsada As DataTable = datosParciales.Tables("tabla")
        Dim fila As DataRow = tablaUsada.Rows(0)
        cmbFormaPago.SelectedValue = Convert.ToInt32(fila("REFFORMAPAGO").ToString)
    End Sub

    ' Evento al cambiar el valor del combobox FORMA DE PAGO.
    Private Sub cmbFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFormaPago.SelectedIndexChanged
        If cmbFormaPago.SelectedIndex = 0 Then
            If Not primeraPasada Then
                tip1.Show("Debe elegir una forma de pago", cmbFormaPago)
                txtFormaPago.Text = ""
            End If
            gestionarErroresEtiquetas(False, pboxPagoError, pboxPagoAcierto)
            tipoPagoElegido = False
        Else
            tip1.Hide(cmbFormaPago)
            gestionarErroresEtiquetas(True, pboxPagoError, pboxPagoAcierto)
            txtFormaPago.Text = cmbFormaPago.SelectedItem("DESCRIPCION").ToString
            tipoPagoElegido = True
        End If
        comprobarSiSePuedeInsertarPedido()
    End Sub

    ' Actualiza los comboBox a los valores marcados por la hora actual.
    Sub actualizaComboBoxHoraMinutoSegundo(ByVal actual As Date)
        comboBoxHora.SelectedIndex = actual.Hour.ToString
        comboBoxMinuto.SelectedIndex = actual.Minute.ToString
        comboBoxSegundo.SelectedIndex = actual.Second.ToString
    End Sub

    ' Actualiza la fecha a lo marcado en el Calendar.
    ' Si al llamarse tambienHora=true también hace lo mismo con la hora.
    Private Sub ActualizaTiempoPedido(ByVal tambienHora As Boolean)
        FechaHoraPedido = DateTimePicker1.Value
        If tambienHora Then
            actualizaComboBoxHoraMinutoSegundo(DateTimePicker1.Value)
        Else
            FechaHoraPedido = New Date(FechaHoraPedido.Year, FechaHoraPedido.Month, FechaHoraPedido.Day, comboBoxHora.SelectedIndex, comboBoxMinuto.SelectedIndex, comboBoxSegundo.SelectedIndex)
        End If
        actualizaEtiquetaHora(txtHora, FechaHoraPedido)
        gestionarEtiquetaHoraPedido()
        gestionarEtiquetaSalidaLlegada()
    End Sub

    ' Actualiza el tiempo de llegada estimada del pedido.
    Private Sub actualizaTiempoLlegada(ByVal seUsaPicker2 As Boolean)
        If Not seUsaPicker2 Then
            FechaHoraLlegada = DateTimePicker1.Value
            FechaHoraLlegada = FechaHoraLlegada.AddDays(comboBoxDiasDefecto.SelectedIndex - 1)
            FechaHoraLlegada = New Date(FechaHoraLlegada.Year, FechaHoraLlegada.Month, FechaHoraLlegada.Day, 0, 0, 0)
        Else
            FechaHoraLlegada = DateTimePicker2.Value
        End If
        actualizaEtiquetaFecha(txtFechaLlegada, FechaHoraLlegada)
        gestionarEtiquetaFechaLlegada()
        gestionarEtiquetaSalidaLlegada()
    End Sub

    ' Gestiona que la llegada del pedido no sea anterior a la salida del mismo.
    Private Sub gestionarEtiquetaSalidaLlegada()
        If FechaHoraLlegada.AddDays(1) <= FechaHoraPedido Then
            tip2.Show("¿El pedido NO PUEDE SALIR DESPUES de haber sido recibido?", txtBoxOculta1)
            pboxViajePasadoAdvertencia.Show()
        Else
            tip2.Hide(txtBoxOculta1)
            pboxViajePasadoAdvertencia.Hide()
        End If
    End Sub

    Private Sub btnAnyadirProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnyadirProducto.Click
        btnAnyadirProducto.Enabled = False
        Me.Enabled = False
        frmArticulos.setElegir = True
        frmArticulos.lblActElm.Visible = False
        frmArticulos.jcbActElim.Visible = False
        frmArticulos.Show()
        If soyModificar Then
            If dgvPedidos.Rows.Count <= 1 Then
                btnEliminarArticulo.Enabled = False
            End If
        End If
    End Sub

    ' Gestiona el consumo de eventos de KeyDown en los que solo se permitan cifras. 
    Private Sub txtNumeric_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeric.KeyDown
        seMarcoNoCifra(e)
    End Sub

    ' Gestiona el consumo de eventos de KeyPress en los que solo se permitan cifras.
    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeric.KeyPress
        If noSeIntrodujoNumero = True Then
            e.Handled = True
        End If
    End Sub

    ' Se controlan cambios en el dgvPedidos en la única casilla editable
    Private Sub dgvPedidos_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvPedidos.EditingControlShowing
        txtNumeric = TryCast(e.Control, DataGridViewTextBoxEditingControl)
    End Sub

    ' Cuando cambia el valor de una celda del datagridview se comprueba si el dgv es VALIDO, es decir, si respecto
    ' al DGV se puede o no INSERTAR / MODIFICAR el pedido.
    ' Hay otros aspectos que aquí no se incluyen (cliente elegido, fechas correctas, etc.).
    Private Sub DataGridCellValueChanged(ByVal sender As DataGridView, ByVal e As DataGridViewCellEventArgs) Handles dgvPedidos.CellValueChanged

        ' En principio se asume que el DGV es correcto, a partir de aquí se verificarán una serie de cuestiones.
        ' Si cualquiera de ellas da error, el DGV se asume como NO VÁLIDO.
        esValidoElDGV = True

        ' Además, se realizarán una serie de operaciones en el DGV ya que algún valor en él ha podido cambiar.
        If Not dgvPedidos.CurrentCell Is Nothing Then
            Dim filaSeleccionadaDGV = dgvPedidos.CurrentCell.RowIndex
            If (Not dgvPedidos.Item(4, filaSeleccionadaDGV).Value Is Nothing And Not dgvPedidos.Item(5, filaSeleccionadaDGV).Value Is Nothing) Then
                If esUnDoubleMayorQueCero(dgvPedidos.Item(4, filaSeleccionadaDGV).Value, Nothing) Then
                    calculaColumnaPrecioTotal(dgvPedidos, 6, filaSeleccionadaDGV, Convert.ToDouble(dgvPedidos.Item(4, filaSeleccionadaDGV).Value.ToString), Convert.ToDouble(dgvPedidos.Item(5, filaSeleccionadaDGV).Value.ToString))
                    precioTotalAPagar = calculaPrecioTotalAPagar(dgvPedidos)
                    asignaNuevoPrecioTotalAPagarASuCasilla(precioTotalAPagar, txtPrecio, soyModificar)
                    tip4.Hide(txtOculto2)
                Else
                    dgvPedidos.Item(6, dgvPedidos.CurrentRow.Index).Value = Nothing
                    tip4.Show("Los items pedidos no pueden ser nulos o menores a cero", txtOculto2)
                    esValidoElDGV = False
                End If
            Else
                dgvPedidos.Item(6, dgvPedidos.CurrentRow.Index).Value = Nothing
                tip4.Show("Los items pedidos no pueden ser nulos o menores a cero", txtOculto2)
                esValidoElDGV = False
            End If
        Else
            ' Si la celda actual es NOTHING es que hay algún problema con el DGV (posiblemente que no hay ningún artículo en él).
            esValidoElDGV = False
        End If

        If Not dgvPedidos.CurrentCell Is Nothing Then
            Dim contador As Integer = 0
            Do
                If dgvPedidos.Item(6, contador).Value Is Nothing Then
                    esValidoElDGV = False
                    tip4.Show("Uno o varios artículos no cumplen los criterios marcados", txtOculto2)
                    btnAnyadirProducto.Enabled = False
                End If
                contador += 1
            Loop While (contador < dgvPedidos.Rows.Count And esValidoElDGV)
            If esValidoElDGV Then
                tip4.Hide(txtOculto2)
                btnAnyadirProducto.Enabled = True
            End If
        Else
            esValidoElDGV = False
        End If
        lblCuidadoLimiteStock.Visible = False
        If Not dgvPedidos.CurrentCell Is Nothing Then
            Dim filaSeleccionadaDGV = dgvPedidos.CurrentCell.RowIndex
            If (Not dgvPedidos.Item(3, filaSeleccionadaDGV).Value Is Nothing And Not dgvPedidos.Item(4, filaSeleccionadaDGV).Value Is Nothing) Then
                If esUnDoubleMayorQueCero(dgvPedidos.Item(4, filaSeleccionadaDGV).Value, Nothing) Then
                    If Convert.ToInt32(dgvPedidos.Item(4, filaSeleccionadaDGV).Value) > Convert.ToInt32(dgvPedidos.Item(3, filaSeleccionadaDGV).Value) Then
                        If Not soyModificar Then
                            MsgBox("Usted introdujo una cantidad mayor que el limite de Stock, luego esa cantidad se ha ajustado")
                            dgvPedidos.Item(4, filaSeleccionadaDGV).Value = dgvPedidos.Item(3, filaSeleccionadaDGV).Value
                        Else
                            lblCuidadoLimiteStock.Visible = True
                        End If
                    End If
                Else
                    esValidoElDGV = False
                End If
            Else
                esValidoElDGV = False
            End If
        Else
            esValidoElDGV = False
        End If

        comprobarSiSePuedeInsertarPedido()
        gestionarErroresArticulo(esValidoElDGV)
    End Sub


    ' Se comprueba si se puede o no insertar el pedido.
    ' El botón de insertar pedido se habilitará o deshabilitará en función de si se puede o no insertar el pedido.
    Private Sub comprobarSiSePuedeInsertarPedido()

        ' Lo primero es si el DGV es correcto.
        Dim sePuedeCrearPedido As Boolean = esValidoElDGV

        ' Si el DGV está bien se hacen el resto de comprobaciones.
        If sePuedeCrearPedido Then
            Dim numeroColumnas As Integer = dgvPedidos.Columns.Count
            Dim numeroFilas As Integer = dgvPedidos.Rows.Count

            ' Se comprueban que todas las cantidades son mayores que cero.
            sePuedeCrearPedido = comprobarTodasCantidadesDGVMayorQueCero(dgvPedidos, 4)

            ' Aquí se manda un tooltip al interfaz.
            If sePuedeCrearPedido Then
                tip4.Hide(txtOculto2)
                gestionarErroresArticulo(True)
            End If

            If sePuedeCrearPedido Then
                sePuedeCrearPedido = verificaViajeNoAlPasado(FechaHoraPedido, FechaHoraLlegada)
            End If

            ' Ha de haber pago, cliente y artículo elegido.
            ' La hora ha de ser correcta.
            If sePuedeCrearPedido Then
                If Not tipoPagoElegido Or Not clienteElegido Or Not horaEsCorrecto Or Not articuloElegido Then
                    sePuedeCrearPedido = False
                End If
            End If

            ' El dgvPedidos ha de tener como poco una fila (un artículo).
            If sePuedeCrearPedido Then
                If Not dgvPedidos.RowCount > 0 Then
                    sePuedeCrearPedido = False
                End If
            End If

            ' Se comprueba que la cantidad que se va a pagar se adapta al formato (no es negativa ni mayor que la máxima)
            If sePuedeCrearPedido Then
                Try
                    If Not procesoCambioCantidadPagar(txtDineroPagado.Text, precioTotalAPagar, lblErrorCantidadPagar) Then
                        sePuedeCrearPedido = False
                    End If
                Catch ex As Exception
                    ' Provisional para que no falle esto.
                End Try
                
            End If
        End If

        If sePuedeCrearPedido Then
            btnNuevoPedido.Enabled = True
            btnAnyadirProducto.Enabled = True
        Else
            btnNuevoPedido.Enabled = False
        End If
    End Sub

    ' Cuando se escoge un valor en el datetimepicker.
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        ActualizaTiempoPedido(False)
        If (comboBoxDiasDefecto.SelectedIndex = 0) Then
            actualizaTiempoLlegada(True)
        Else
            actualizaTiempoLlegada(False)
        End If
        comprobarSiSePuedeInsertarPedido()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        actualizaTiempoLlegada(True)
    End Sub

    ' Insertar pedido en la base de datos.
    Private Sub btnNuevoPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPedido.Click
        Dim respuesta As MsgBoxResult
        Dim mensaje As String = "¿Esta seguro de que desea tramitar esta accion?"
        If soyModificar Then
            mensaje += "Recuerde que al modificar el pedido el STOCK no se ajustará"
        End If
        respuesta = MsgBox(mensaje, MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then

            Dim sentencia As String = Nothing
            Dim tablaUsada As DataTable = Nothing
            Dim fila As DataRow = Nothing
            Dim lecturaParcial As String = ""

            Dim IDPEDIDO, REFCLIENTE, REFUSUARIO, FECHA, HORAPEDIDO, FECHAENTREGA, REFFORMAPAGO, TOTAL, PAGADO, ELIMINADO, NUMPEDIDO As String

            datosParciales = conexion.getData("SELECT MAX(IDPEDIDO) FROM PEDIDOS_CLIENTES", "tabla")
            If datosParciales Is Nothing Then
                IDPEDIDO = "1"
            Else
                tablaUsada = datosParciales.Tables("tabla")
                fila = tablaUsada.Rows(0)
                lecturaParcial = fila("MAX(IDPEDIDO)").ToString
                If lecturaParcial = "" Then
                    lecturaParcial = "0"
                End If
                IDPEDIDO = 1 + Convert.ToInt32(lecturaParcial)
            End If


            REFCLIENTE = idCliente
            REFUSUARIO = idUsuario
            FECHA = Fecha2number(FechaHoraPedido)
            HORAPEDIDO = hora2number(FechaHoraPedido)
            FECHAENTREGA = Fecha2number(FechaHoraLlegada)
            REFFORMAPAGO = cmbFormaPago.SelectedValue
            TOTAL = precioTotalAPagar
            'PAGADO = precioTotal1 * (comboBoxPorcentajePagado.SelectedIndex * 10) * (1 / 100)
            PAGADO = txtDineroPagado.Text
            ELIMINADO = 0

            datosParciales = conexion.getData("SELECT MAX(NUMPEDIDO) FROM PEDIDOS_CLIENTES", "tabla")
            If datosParciales Is Nothing Then
                NUMPEDIDO = "1"
            Else
                tablaUsada = datosParciales.Tables("tabla")
                fila = tablaUsada.Rows(0)
                lecturaParcial = fila("MAX(NUMPEDIDO)").ToString
                If lecturaParcial = "" Then
                    lecturaParcial = "0"
                End If
                NUMPEDIDO = 1 + Convert.ToInt32(lecturaParcial)
            End If

            If soyModificar = True Then
                IDPEDIDO = idPedidos
                NUMPEDIDO = IDPEDIDO
                Dim sentenciaBorrarDetalles As String = "DELETE FROM PEDIDOS_CLIENTES_ARTICULOS WHERE REFPEDIDO= '" & idPedidos & "'"
                conexion.setData(sentenciaBorrarDetalles)
                'Dim sentenciaActualizaPedido As String = "DELETE FROM PEDIDOS WHERE IDPEDIDO= '" & idPedidos & "'"
                'conexion.setData(sentenciaActualizaPedido)
            End If

            If Not soyModificar Then
                ' FALTA LA HORA PORQUE NO ESTÁ EN LA BASE DE DATOS.
                sentencia = "INSERT INTO PEDIDOS_CLIENTES (REFCLIENTE, REFUSUARIO, FECHA, REFFORMAPAGO, TOTAL, PAGADO, ELIMINADO, NUMPEDIDO, HORAPEDIDO, FECHAENTREGA, REFESTADO) VALUES (" & _
                    REFCLIENTE & "," & _
                    REFUSUARIO & "," & _
                    FECHA & "," & _
                    REFFORMAPAGO & "," & _
                    "'" & TOTAL & "'," & _
                    "'" & PAGADO & "'," & _
                    ELIMINADO & "," & _
                    NUMPEDIDO & "," & _
                    HORAPEDIDO & "," & _
                    FECHAENTREGA & "," & _
                    " 0)"
            Else
                sentencia = "UPDATE PEDIDOS_CLIENTES SET " & _
                "REFCLIENTE = " & REFCLIENTE & "," & _
                "REFUSUARIO = " & REFUSUARIO & "," & _
                "FECHA = " & FECHA & "," & _
                "REFFORMAPAGO = " & REFFORMAPAGO & "," & _
                "TOTAL = '" & TOTAL & "'," & _
                "PAGADO = '" & PAGADO & "'," & _
                "ELIMINADO = " & ELIMINADO & "," & _
                "NUMPEDIDO = " & NUMPEDIDO & "," & _
                "HORAPEDIDO = " & HORAPEDIDO & "," & _
                "FECHAENTREGA = " & FECHAENTREGA & _
                "WHERE IDPEDIDO= " & IDPEDIDO
            End If

            conexion.setData(sentencia)


            Dim IDPEDIDOSARTICULOS, REFPEDIDO, REFARTICULO, CANTIDAD, PRECIOVENTA As String

            Dim sentenciaNumPedido As String = "SELECT IDPEDIDO FROM PEDIDOS_CLIENTES WHERE NUMPEDIDO= " & NUMPEDIDO
            Dim datosNumPedido As DataSet = conexion.getData(sentenciaNumPedido, "tablaNumPedido")
            Dim tablaUsadaNumPedido As DataTable = datosNumPedido.Tables("tablaNumPedido")
            Dim filaNumPedido As DataRow = tablaUsadaNumPedido.Rows(0)
            Dim lecturaParcialNumPedido As String = filaNumPedido("IDPEDIDO").ToString


            REFPEDIDO = lecturaParcialNumPedido
            For j = 0 To dgvPedidos.Rows.Count - 1

                Dim idLibre As Integer = 1
                Dim libreEncontrado As Boolean = False
                Do
                    sentencia = "SELECT IDPEDIDOSARTICULOS AS IDP FROM PEDIDOS_CLIENTES_ARTICULOS WHERE IDPEDIDOSARTICULOS =" & idLibre
                    datosParciales = conexion.getData(sentencia, "tablas")
                    tablaUsada = datosParciales.Tables("tablas")
                    If tablaUsada.Rows.Count = 0 Then
                        libreEncontrado = True
                    Else
                        idLibre += 1
                    End If

                Loop While (Not libreEncontrado)
                IDPEDIDOSARTICULOS = idLibre

                REFARTICULO = dgvPedidos.Item(7, j).Value

                CANTIDAD = dgvPedidos.Item(4, j).Value
                If Not soyModificar Then
                    datosParciales = conexion.getData("SELECT STOCK FROM ARTICULOS WHERE IDARTICULO=(" & REFARTICULO & ")", "tabla")
                    tablaUsada = datosParciales.Tables("tabla")
                    fila = tablaUsada.Rows(0)
                    lecturaParcial = fila("STOCK").ToString
                    If Convert.ToInt32(lecturaParcial) < CANTIDAD Then
                        MsgBox("El pedido del articulo " & REFARTICULO & " se ajustó porque el stock maximo cambio durante la ejecución")
                        CANTIDAD = Convert.ToInt32(lecturaParcial)
                    End If
                    sentencia = "UPDATE ARTICULOS " & _
                        "SET STOCK= " & (Convert.ToInt32(lecturaParcial) - Convert.ToInt32(CANTIDAD)) & _
                        " WHERE IDARTICULO= " & REFARTICULO
                    conexion.setData(sentencia)
                End If

                datosParciales = conexion.getData("SELECT PRECIO FROM ARTICULOS WHERE IDARTICULO=(" & REFARTICULO & ")", "tabla")
                tablaUsada = datosParciales.Tables("tabla")
                fila = tablaUsada.Rows(0)
                lecturaParcial = fila("PRECIO").ToString

                PRECIOVENTA = lecturaParcial

                sentencia = "INSERT INTO PEDIDOS_CLIENTES_ARTICULOS (IDPEDIDOSARTICULOS, REFPEDIDO, REFARTICULO, CANTIDAD_ESPERADA, PRECIOVENTA) VALUES (" & _
                    IDPEDIDOSARTICULOS & "," & _
                    REFPEDIDO & "," & _
                    REFARTICULO & "," & _
                    CANTIDAD & "," & _
                    "'" & PRECIOVENTA & "')"
                conexion.setData(sentencia)

            Next

            Dim texto As String = " introducido"
            If soyModificar Then
                texto = " modificado"
            End If
            insertarCambio("Pedido " & IDPEDIDO & texto, 0)
            MsgBox("El pedido fue tramitado con exito")
            procesoLimpiarTodo()
        End If

        If soyModificar Then
            Me.Dispose()
        End If

    End Sub

    Private Sub comboBoxHora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxHora.SelectedIndexChanged
        If comboBoxHora.SelectedIndex >= 0 Then
            FechaHoraPedido = New Date(FechaHoraPedido.Year, FechaHoraPedido.Month, FechaHoraPedido.Day, comboBoxHora.SelectedIndex, FechaHoraPedido.Minute, FechaHoraPedido.Second)
            actualizaEtiquetaHora(txtHora, FechaHoraPedido)
            gestionarEtiquetaHoraPedido()
        End If
    End Sub

    Private Sub comboBoxMinuto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxMinuto.SelectedIndexChanged
        If comboBoxMinuto.SelectedIndex >= 0 Then
            FechaHoraPedido = New Date(FechaHoraPedido.Year, FechaHoraPedido.Month, FechaHoraPedido.Day, FechaHoraPedido.Hour, comboBoxMinuto.SelectedIndex, FechaHoraPedido.Second)
            actualizaEtiquetaHora(txtHora, FechaHoraPedido)
            gestionarEtiquetaHoraPedido()
        End If
    End Sub

    Private Sub comboBoxSegundo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxSegundo.SelectedIndexChanged
        If comboBoxSegundo.SelectedIndex >= 0 Then
            FechaHoraPedido = New Date(FechaHoraPedido.Year, FechaHoraPedido.Month, FechaHoraPedido.Day, FechaHoraPedido.Hour, FechaHoraPedido.Minute, comboBoxSegundo.SelectedIndex)
            actualizaEtiquetaHora(txtHora, FechaHoraPedido)
            gestionarEtiquetaHoraPedido()
        End If
    End Sub

    Private Sub btnReiniciarFechaHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciarFechaHora.Click
        DateTimePicker1.Value = Date.Now
        ActualizaTiempoPedido(True)
    End Sub

    ' Gestiona si la fecha de llegada del pedido ha de dar una advertencia en el caso de que el pedido deba entregarse en el pasado u hoy.
    Sub gestionarEtiquetaFechaLlegada()
        If FechaHoraLlegada.AddDays(1) <= DateTime.Now() Then
            tip1.Show("¿Seguro que usted va a entregar este pedido en el pasado?", txtFechaLlegada)
            gestionarErroresEtiquetas(False, pboxHoraLlegadaAdvertencia, pboxHoraLlegadaAcierto)
        Else
            tip1.Hide(txtFechaLlegada)
            gestionarErroresEtiquetas(True, pboxHoraLlegadaAdvertencia, pboxHoraLlegadaAcierto)
        End If
    End Sub

    ' Gestiona si la hora del pedido ha de dar una advertencia en el caso de que el pedido se haga en el futuro.
    Sub gestionarEtiquetaHoraPedido()
        If FechaHoraPedido >= DateTime.Now Then
            tip3.Show("¿Seguro que usted está en el futuro?", txtHora)
            gestionarErroresEtiquetas(False, pboxHoraAdvertencia, pboxHoraAcierto)
        Else
            tip3.Hide(txtHora)
            gestionarErroresEtiquetas(True, pboxHoraAdvertencia, pboxHoraAcierto)
        End If
    End Sub

    Private Sub comboBoxDiasDefecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxDiasDefecto.SelectedIndexChanged
        If comboBoxDiasDefecto.SelectedIndex > 0 Then
            DateTimePicker2.Enabled = False
            actualizaTiempoLlegada(False)
        Else
            DateTimePicker2.Enabled = True
            actualizaTiempoLlegada(True)
        End If
        comprobarSiSePuedeInsertarPedido()

    End Sub

    Private Sub btnReiniciarFechaHoraLlegada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciarFechaHoraLlegada.Click
        DateTimePicker2.Value = Date.Now
        comboBoxDiasDefecto.SelectedIndex = 0
        actualizaTiempoLlegada(True)
    End Sub

    Private Sub btnEliminarArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarArticulo.Click

        ' Se elimina la fila selecciona del DataGridView.
        eliminarArticuloDelPedido(dgvPedidos)

        ' Si ya no quedan filas en el DataGridView, éste se resetea.
        If dgvPedidos.Rows.Count = 0 Then
            reseteaDGV()
        End If

        ' Ahora se calcula el precio total que correspondería pagar los artículos existentes.
        calculaPrecioTotalAPagar(dgvPedidos)

        ' Se asigna el precio total a la casilla del interfaz que toca.
        asignaNuevoPrecioTotalAPagarASuCasilla(precioTotalAPagar, txtDineroPagado, soyModificar)

        ' De cada artículo ha de haberse introducido una cantidad correcta mayor que CERO.
        ' Se comprueba este hecho.
        esValidoElDGV = comprobarTodasCantidadesDGVMayorQueCero(dgvPedidos, 4)

        comprobarSiSePuedeInsertarPedido()

        If soyModificar Then
            If dgvPedidos.Rows.Count <= 1 Then
                btnEliminarArticulo.Enabled = False
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnBorrarArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarArticulos.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea borrar todos los articulos de la lista del pedido?", MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            reseteaDGV()
        End If
    End Sub

    Private Sub reseteaDGV()
        esValidoElDGV = False
        borraDataGridView(dgvPedidos)
        btnEliminarArticulo.Enabled = False
        btnAnyadirProducto.Enabled = True
        gestionarErroresArticulo(False)
        comprobarSiSePuedeInsertarPedido()
    End Sub

    Private Sub procesoLimpiarTodo()
        reseteaDGV()
        txtCliente.Text = ""
        idCliente = -1
        gestionarErroresCliente_Proveedor(idCliente, pboxClienteAcierto, pboxClienteError)
        clienteElegido = False
        cmbFormaPago.SelectedIndex = 0
        DateTimePicker1.Value = Date.Now
        ActualizaTiempoPedido(True)
        DateTimePicker2.Value = Date.Now
        comboBoxDiasDefecto.SelectedIndex = 0
        actualizaTiempoLlegada(True)
        'comboBoxPorcentajePagado.SelectedIndex = comboBoxPorcentajePagado.Items.Count - 1
        txtDineroPagado.Text = ""
    End Sub

    Private Sub btnLimpiarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarTodo.Click
        Dim respuesta As MsgBoxResult
        respuesta = MsgBox("¿Esta seguro que desea reiniciar el formulario?", MsgBoxStyle.YesNo, "Confirmacion")
        If (respuesta = MsgBoxResult.Yes) Then
            procesoLimpiarTodo()
        End If
    End Sub

    Private Sub btnCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambios.Click
        frmCambios.Show()
    End Sub

    Private Sub txtDineroPagado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDineroPagado.TextChanged
        procesoCambioCantidadPagar(txtDineroPagado.Text, precioTotalAPagar, lblErrorCantidadPagar)
        comprobarSiSePuedeInsertarPedido()
    End Sub

End Class