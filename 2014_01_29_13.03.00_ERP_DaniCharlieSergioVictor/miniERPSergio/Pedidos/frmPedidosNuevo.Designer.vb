<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosNuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.ARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOUNITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevoPedido = New System.Windows.Forms.Button()
        Me.btnAnyadirProducto = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.panelFechaPedido = New System.Windows.Forms.Panel()
        Me.pboxHoraAdvertencia = New System.Windows.Forms.PictureBox()
        Me.btnReiniciarFechaHora = New System.Windows.Forms.Button()
        Me.lblReiniciarFechaHora = New System.Windows.Forms.Label()
        Me.lblComboSegundo = New System.Windows.Forms.Label()
        Me.lblComboMinuto = New System.Windows.Forms.Label()
        Me.lblComboHora = New System.Windows.Forms.Label()
        Me.comboBoxSegundo = New System.Windows.Forms.ComboBox()
        Me.comboBoxMinuto = New System.Windows.Forms.ComboBox()
        Me.comboBoxHora = New System.Windows.Forms.ComboBox()
        Me.lblFechaHoraPedido = New System.Windows.Forms.Label()
        Me.pboxHoraAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxClienteAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxClienteError = New System.Windows.Forms.PictureBox()
        Me.pboxPagoAcierto = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pboxPagoError = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFechaLlegada = New System.Windows.Forms.TextBox()
        Me.comboBoxDiasDefecto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pboxHoraLlegadaAdvertencia = New System.Windows.Forms.PictureBox()
        Me.btnReiniciarFechaHoraLlegada = New System.Windows.Forms.Button()
        Me.lblReiniciarFechaHoraLlegada = New System.Windows.Forms.Label()
        Me.lblFechaHoraEntrega = New System.Windows.Forms.Label()
        Me.pboxHoraLlegadaAcierto = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.pboxViajePasadoAdvertencia = New System.Windows.Forms.PictureBox()
        Me.txtBoxOculta1 = New System.Windows.Forms.TextBox()
        Me.pboxProductoElegidoError = New System.Windows.Forms.PictureBox()
        Me.pboxProductoElegidoAcierto = New System.Windows.Forms.PictureBox()
        Me.btnEliminarArticulo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrarArticulos = New System.Windows.Forms.Button()
        Me.btnLimpiarTodo = New System.Windows.Forms.Button()
        Me.btnCambios = New System.Windows.Forms.Button()
        Me.lblAdvertenciaArticuloExiste = New System.Windows.Forms.Label()
        Me.lblCuidadoLimiteStock = New System.Windows.Forms.Label()
        Me.txtDineroPagado = New System.Windows.Forms.TextBox()
        Me.lblErrorCantidadPagar = New System.Windows.Forms.Label()
        Me.txtOculto2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFechaPedido.SuspendLayout()
        CType(Me.pboxHoraAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxHoraAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxClienteAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxClienteError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPagoAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPagoError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxHoraLlegadaAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxHoraLlegadaAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxViajePasadoAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProductoElegidoError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProductoElegidoAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(32, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(109, 26)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(138, 25)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(442, 20)
        Me.txtCliente.TabIndex = 1
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.Location = New System.Drawing.Point(29, 57)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(109, 26)
        Me.lblFormaPago.TabIndex = 4
        Me.lblFormaPago.Text = "Forma de pago"
        Me.lblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(137, 57)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(257, 21)
        Me.cmbFormaPago.TabIndex = 5
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(613, 23)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(164, 22)
        Me.btnBuscarCliente.TabIndex = 6
        Me.btnBuscarCliente.Text = "BUSCAR CLIENTE"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ARTICULO, Me.NOMBRE, Me.TIPO, Me.STOCK, Me.CANTIDAD, Me.PRECIOUNITARIO, Me.PRECIOTOTAL, Me.ID})
        Me.dgvPedidos.Location = New System.Drawing.Point(29, 299)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.Size = New System.Drawing.Size(748, 174)
        Me.dgvPedidos.TabIndex = 7
        '
        'ARTICULO
        '
        Me.ARTICULO.HeaderText = "ARTICULO"
        Me.ARTICULO.Name = "ARTICULO"
        Me.ARTICULO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'STOCK
        '
        Me.STOCK.HeaderText = "STOCK"
        Me.STOCK.Name = "STOCK"
        Me.STOCK.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'PRECIOUNITARIO
        '
        Me.PRECIOUNITARIO.HeaderText = "PRECIO UNITARIO"
        Me.PRECIOUNITARIO.Name = "PRECIOUNITARIO"
        Me.PRECIOUNITARIO.ReadOnly = True
        '
        'PRECIOTOTAL
        '
        Me.PRECIOTOTAL.HeaderText = "PRECIO TOTAL"
        Me.PRECIOTOTAL.Name = "PRECIOTOTAL"
        Me.PRECIOTOTAL.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'btnNuevoPedido
        '
        Me.btnNuevoPedido.Enabled = False
        Me.btnNuevoPedido.Location = New System.Drawing.Point(213, 568)
        Me.btnNuevoPedido.Name = "btnNuevoPedido"
        Me.btnNuevoPedido.Size = New System.Drawing.Size(124, 22)
        Me.btnNuevoPedido.TabIndex = 14
        Me.btnNuevoPedido.Text = "INSERTAR PEDIDO"
        Me.btnNuevoPedido.UseVisualStyleBackColor = True
        '
        'btnAnyadirProducto
        '
        Me.btnAnyadirProducto.Location = New System.Drawing.Point(29, 533)
        Me.btnAnyadirProducto.Name = "btnAnyadirProducto"
        Me.btnAnyadirProducto.Size = New System.Drawing.Size(127, 22)
        Me.btnAnyadirProducto.TabIndex = 24
        Me.btnAnyadirProducto.Text = "AÑADIR ARTICULO"
        Me.btnAnyadirProducto.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(23, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(288, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(23, 117)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(102, 20)
        Me.txtHora.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(662, 503)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PRECIO TOTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(655, 533)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(122, 20)
        Me.txtPrecio.TabIndex = 30
        '
        'txtFormaPago
        '
        Me.txtFormaPago.Location = New System.Drawing.Point(437, 57)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(340, 20)
        Me.txtFormaPago.TabIndex = 31
        '
        'panelFechaPedido
        '
        Me.panelFechaPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelFechaPedido.Controls.Add(Me.pboxHoraAdvertencia)
        Me.panelFechaPedido.Controls.Add(Me.btnReiniciarFechaHora)
        Me.panelFechaPedido.Controls.Add(Me.lblReiniciarFechaHora)
        Me.panelFechaPedido.Controls.Add(Me.lblComboSegundo)
        Me.panelFechaPedido.Controls.Add(Me.lblComboMinuto)
        Me.panelFechaPedido.Controls.Add(Me.lblComboHora)
        Me.panelFechaPedido.Controls.Add(Me.comboBoxSegundo)
        Me.panelFechaPedido.Controls.Add(Me.comboBoxMinuto)
        Me.panelFechaPedido.Controls.Add(Me.comboBoxHora)
        Me.panelFechaPedido.Controls.Add(Me.lblFechaHoraPedido)
        Me.panelFechaPedido.Controls.Add(Me.txtHora)
        Me.panelFechaPedido.Controls.Add(Me.pboxHoraAcierto)
        Me.panelFechaPedido.Controls.Add(Me.DateTimePicker1)
        Me.panelFechaPedido.Location = New System.Drawing.Point(29, 104)
        Me.panelFechaPedido.Name = "panelFechaPedido"
        Me.panelFechaPedido.Size = New System.Drawing.Size(348, 186)
        Me.panelFechaPedido.TabIndex = 32
        '
        'pboxHoraAdvertencia
        '
        Me.pboxHoraAdvertencia.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoAlerta
        Me.pboxHoraAdvertencia.Location = New System.Drawing.Point(284, 15)
        Me.pboxHoraAdvertencia.Name = "pboxHoraAdvertencia"
        Me.pboxHoraAdvertencia.Size = New System.Drawing.Size(20, 20)
        Me.pboxHoraAdvertencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxHoraAdvertencia.TabIndex = 33
        Me.pboxHoraAdvertencia.TabStop = False
        Me.pboxHoraAdvertencia.Visible = False
        '
        'btnReiniciarFechaHora
        '
        Me.btnReiniciarFechaHora.Location = New System.Drawing.Point(237, 156)
        Me.btnReiniciarFechaHora.Name = "btnReiniciarFechaHora"
        Me.btnReiniciarFechaHora.Size = New System.Drawing.Size(56, 22)
        Me.btnReiniciarFechaHora.TabIndex = 33
        Me.btnReiniciarFechaHora.Text = "OK"
        Me.btnReiniciarFechaHora.UseVisualStyleBackColor = True
        '
        'lblReiniciarFechaHora
        '
        Me.lblReiniciarFechaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReiniciarFechaHora.Location = New System.Drawing.Point(20, 156)
        Me.lblReiniciarFechaHora.Name = "lblReiniciarFechaHora"
        Me.lblReiniciarFechaHora.Size = New System.Drawing.Size(211, 26)
        Me.lblReiniciarFechaHora.TabIndex = 39
        Me.lblReiniciarFechaHora.Text = "Establecer fecha y hora actual"
        Me.lblReiniciarFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComboSegundo
        '
        Me.lblComboSegundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComboSegundo.Location = New System.Drawing.Point(255, 87)
        Me.lblComboSegundo.Name = "lblComboSegundo"
        Me.lblComboSegundo.Size = New System.Drawing.Size(56, 26)
        Me.lblComboSegundo.TabIndex = 38
        Me.lblComboSegundo.Text = "Seg"
        Me.lblComboSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComboMinuto
        '
        Me.lblComboMinuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComboMinuto.Location = New System.Drawing.Point(193, 87)
        Me.lblComboMinuto.Name = "lblComboMinuto"
        Me.lblComboMinuto.Size = New System.Drawing.Size(56, 26)
        Me.lblComboMinuto.TabIndex = 37
        Me.lblComboMinuto.Text = "Min"
        Me.lblComboMinuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComboHora
        '
        Me.lblComboHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComboHora.Location = New System.Drawing.Point(131, 87)
        Me.lblComboHora.Name = "lblComboHora"
        Me.lblComboHora.Size = New System.Drawing.Size(56, 26)
        Me.lblComboHora.TabIndex = 33
        Me.lblComboHora.Text = "Hora"
        Me.lblComboHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comboBoxSegundo
        '
        Me.comboBoxSegundo.FormattingEnabled = True
        Me.comboBoxSegundo.Location = New System.Drawing.Point(255, 116)
        Me.comboBoxSegundo.Name = "comboBoxSegundo"
        Me.comboBoxSegundo.Size = New System.Drawing.Size(56, 21)
        Me.comboBoxSegundo.TabIndex = 36
        '
        'comboBoxMinuto
        '
        Me.comboBoxMinuto.FormattingEnabled = True
        Me.comboBoxMinuto.Location = New System.Drawing.Point(193, 116)
        Me.comboBoxMinuto.Name = "comboBoxMinuto"
        Me.comboBoxMinuto.Size = New System.Drawing.Size(56, 21)
        Me.comboBoxMinuto.TabIndex = 35
        '
        'comboBoxHora
        '
        Me.comboBoxHora.FormattingEnabled = True
        Me.comboBoxHora.Location = New System.Drawing.Point(131, 116)
        Me.comboBoxHora.Name = "comboBoxHora"
        Me.comboBoxHora.Size = New System.Drawing.Size(56, 21)
        Me.comboBoxHora.TabIndex = 34
        '
        'lblFechaHoraPedido
        '
        Me.lblFechaHoraPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHoraPedido.Location = New System.Drawing.Point(50, 9)
        Me.lblFechaHoraPedido.Name = "lblFechaHoraPedido"
        Me.lblFechaHoraPedido.Size = New System.Drawing.Size(228, 26)
        Me.lblFechaHoraPedido.TabIndex = 33
        Me.lblFechaHoraPedido.Text = "Fecha y hora del pedido"
        Me.lblFechaHoraPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxHoraAcierto
        '
        Me.pboxHoraAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxHoraAcierto.Location = New System.Drawing.Point(284, 15)
        Me.pboxHoraAcierto.Name = "pboxHoraAcierto"
        Me.pboxHoraAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxHoraAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxHoraAcierto.TabIndex = 27
        Me.pboxHoraAcierto.TabStop = False
        '
        'pboxClienteAcierto
        '
        Me.pboxClienteAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxClienteAcierto.Location = New System.Drawing.Point(587, 23)
        Me.pboxClienteAcierto.Name = "pboxClienteAcierto"
        Me.pboxClienteAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxClienteAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxClienteAcierto.TabIndex = 22
        Me.pboxClienteAcierto.TabStop = False
        Me.pboxClienteAcierto.Visible = False
        '
        'pboxClienteError
        '
        Me.pboxClienteError.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxClienteError.Location = New System.Drawing.Point(587, 23)
        Me.pboxClienteError.Name = "pboxClienteError"
        Me.pboxClienteError.Size = New System.Drawing.Size(20, 20)
        Me.pboxClienteError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxClienteError.TabIndex = 21
        Me.pboxClienteError.TabStop = False
        Me.pboxClienteError.Visible = False
        '
        'pboxPagoAcierto
        '
        Me.pboxPagoAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxPagoAcierto.Location = New System.Drawing.Point(407, 58)
        Me.pboxPagoAcierto.Name = "pboxPagoAcierto"
        Me.pboxPagoAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxPagoAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPagoAcierto.TabIndex = 19
        Me.pboxPagoAcierto.TabStop = False
        Me.pboxPagoAcierto.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.PictureBox2.Location = New System.Drawing.Point(757, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'pboxPagoError
        '
        Me.pboxPagoError.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxPagoError.Location = New System.Drawing.Point(407, 57)
        Me.pboxPagoError.Name = "pboxPagoError"
        Me.pboxPagoError.Size = New System.Drawing.Size(20, 20)
        Me.pboxPagoError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPagoError.TabIndex = 17
        Me.pboxPagoError.TabStop = False
        Me.pboxPagoError.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtFechaLlegada)
        Me.Panel1.Controls.Add(Me.comboBoxDiasDefecto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.pboxHoraLlegadaAdvertencia)
        Me.Panel1.Controls.Add(Me.btnReiniciarFechaHoraLlegada)
        Me.Panel1.Controls.Add(Me.lblReiniciarFechaHoraLlegada)
        Me.Panel1.Controls.Add(Me.lblFechaHoraEntrega)
        Me.Panel1.Controls.Add(Me.pboxHoraLlegadaAcierto)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Location = New System.Drawing.Point(451, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 186)
        Me.Panel1.TabIndex = 40
        '
        'txtFechaLlegada
        '
        Me.txtFechaLlegada.Location = New System.Drawing.Point(53, 119)
        Me.txtFechaLlegada.Name = "txtFechaLlegada"
        Me.txtFechaLlegada.ReadOnly = True
        Me.txtFechaLlegada.Size = New System.Drawing.Size(123, 20)
        Me.txtFechaLlegada.TabIndex = 40
        '
        'comboBoxDiasDefecto
        '
        Me.comboBoxDiasDefecto.FormattingEnabled = True
        Me.comboBoxDiasDefecto.Location = New System.Drawing.Point(194, 94)
        Me.comboBoxDiasDefecto.Name = "comboBoxDiasDefecto"
        Me.comboBoxDiasDefecto.Size = New System.Drawing.Size(99, 21)
        Me.comboBoxDiasDefecto.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 26)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Margen de días por defecto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxHoraLlegadaAdvertencia
        '
        Me.pboxHoraLlegadaAdvertencia.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoAlerta
        Me.pboxHoraLlegadaAdvertencia.Location = New System.Drawing.Point(271, 15)
        Me.pboxHoraLlegadaAdvertencia.Name = "pboxHoraLlegadaAdvertencia"
        Me.pboxHoraLlegadaAdvertencia.Size = New System.Drawing.Size(20, 20)
        Me.pboxHoraLlegadaAdvertencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxHoraLlegadaAdvertencia.TabIndex = 33
        Me.pboxHoraLlegadaAdvertencia.TabStop = False
        Me.pboxHoraLlegadaAdvertencia.Visible = False
        '
        'btnReiniciarFechaHoraLlegada
        '
        Me.btnReiniciarFechaHoraLlegada.Location = New System.Drawing.Point(237, 156)
        Me.btnReiniciarFechaHoraLlegada.Name = "btnReiniciarFechaHoraLlegada"
        Me.btnReiniciarFechaHoraLlegada.Size = New System.Drawing.Size(56, 22)
        Me.btnReiniciarFechaHoraLlegada.TabIndex = 33
        Me.btnReiniciarFechaHoraLlegada.Text = "OK"
        Me.btnReiniciarFechaHoraLlegada.UseVisualStyleBackColor = True
        '
        'lblReiniciarFechaHoraLlegada
        '
        Me.lblReiniciarFechaHoraLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReiniciarFechaHoraLlegada.Location = New System.Drawing.Point(20, 156)
        Me.lblReiniciarFechaHoraLlegada.Name = "lblReiniciarFechaHoraLlegada"
        Me.lblReiniciarFechaHoraLlegada.Size = New System.Drawing.Size(211, 26)
        Me.lblReiniciarFechaHoraLlegada.TabIndex = 39
        Me.lblReiniciarFechaHoraLlegada.Text = "Establecer fecha actual"
        Me.lblReiniciarFechaHoraLlegada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaHoraEntrega
        '
        Me.lblFechaHoraEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHoraEntrega.Location = New System.Drawing.Point(50, 9)
        Me.lblFechaHoraEntrega.Name = "lblFechaHoraEntrega"
        Me.lblFechaHoraEntrega.Size = New System.Drawing.Size(215, 26)
        Me.lblFechaHoraEntrega.TabIndex = 33
        Me.lblFechaHoraEntrega.Text = "Fecha y hora de entrega estimada"
        Me.lblFechaHoraEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxHoraLlegadaAcierto
        '
        Me.pboxHoraLlegadaAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxHoraLlegadaAcierto.Location = New System.Drawing.Point(271, 15)
        Me.pboxHoraLlegadaAcierto.Name = "pboxHoraLlegadaAcierto"
        Me.pboxHoraLlegadaAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxHoraLlegadaAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxHoraLlegadaAcierto.TabIndex = 27
        Me.pboxHoraLlegadaAcierto.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(23, 54)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(270, 20)
        Me.DateTimePicker2.TabIndex = 25
        '
        'pboxViajePasadoAdvertencia
        '
        Me.pboxViajePasadoAdvertencia.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxViajePasadoAdvertencia.Location = New System.Drawing.Point(396, 189)
        Me.pboxViajePasadoAdvertencia.Name = "pboxViajePasadoAdvertencia"
        Me.pboxViajePasadoAdvertencia.Size = New System.Drawing.Size(31, 32)
        Me.pboxViajePasadoAdvertencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxViajePasadoAdvertencia.TabIndex = 41
        Me.pboxViajePasadoAdvertencia.TabStop = False
        Me.pboxViajePasadoAdvertencia.Visible = False
        '
        'txtBoxOculta1
        '
        Me.txtBoxOculta1.Location = New System.Drawing.Point(396, 163)
        Me.txtBoxOculta1.Name = "txtBoxOculta1"
        Me.txtBoxOculta1.ReadOnly = True
        Me.txtBoxOculta1.Size = New System.Drawing.Size(31, 20)
        Me.txtBoxOculta1.TabIndex = 40
        Me.txtBoxOculta1.Visible = False
        '
        'pboxProductoElegidoError
        '
        Me.pboxProductoElegidoError.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxProductoElegidoError.Location = New System.Drawing.Point(165, 531)
        Me.pboxProductoElegidoError.Name = "pboxProductoElegidoError"
        Me.pboxProductoElegidoError.Size = New System.Drawing.Size(20, 20)
        Me.pboxProductoElegidoError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProductoElegidoError.TabIndex = 42
        Me.pboxProductoElegidoError.TabStop = False
        '
        'pboxProductoElegidoAcierto
        '
        Me.pboxProductoElegidoAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxProductoElegidoAcierto.Location = New System.Drawing.Point(165, 533)
        Me.pboxProductoElegidoAcierto.Name = "pboxProductoElegidoAcierto"
        Me.pboxProductoElegidoAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxProductoElegidoAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProductoElegidoAcierto.TabIndex = 43
        Me.pboxProductoElegidoAcierto.TabStop = False
        Me.pboxProductoElegidoAcierto.Visible = False
        '
        'btnEliminarArticulo
        '
        Me.btnEliminarArticulo.Enabled = False
        Me.btnEliminarArticulo.Location = New System.Drawing.Point(213, 533)
        Me.btnEliminarArticulo.Name = "btnEliminarArticulo"
        Me.btnEliminarArticulo.Size = New System.Drawing.Size(124, 22)
        Me.btnEliminarArticulo.TabIndex = 44
        Me.btnEliminarArticulo.Text = "ELIMINAR ARTICULO"
        Me.btnEliminarArticulo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 26)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "PAGADO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(655, 568)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 22)
        Me.btnSalir.TabIndex = 48
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrarArticulos
        '
        Me.btnBorrarArticulos.Location = New System.Drawing.Point(29, 569)
        Me.btnBorrarArticulos.Name = "btnBorrarArticulos"
        Me.btnBorrarArticulos.Size = New System.Drawing.Size(127, 22)
        Me.btnBorrarArticulos.TabIndex = 49
        Me.btnBorrarArticulos.Text = "BORRAR ARTICULOS"
        Me.btnBorrarArticulos.UseVisualStyleBackColor = True
        '
        'btnLimpiarTodo
        '
        Me.btnLimpiarTodo.Location = New System.Drawing.Point(363, 569)
        Me.btnLimpiarTodo.Name = "btnLimpiarTodo"
        Me.btnLimpiarTodo.Size = New System.Drawing.Size(126, 22)
        Me.btnLimpiarTodo.TabIndex = 50
        Me.btnLimpiarTodo.Text = "LIMPIAR FORMULARIO"
        Me.btnLimpiarTodo.UseVisualStyleBackColor = True
        '
        'btnCambios
        '
        Me.btnCambios.Location = New System.Drawing.Point(509, 569)
        Me.btnCambios.Name = "btnCambios"
        Me.btnCambios.Size = New System.Drawing.Size(128, 22)
        Me.btnCambios.TabIndex = 61
        Me.btnCambios.Text = "LISTA DE CAMBIOS"
        Me.btnCambios.UseVisualStyleBackColor = True
        '
        'lblAdvertenciaArticuloExiste
        '
        Me.lblAdvertenciaArticuloExiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertenciaArticuloExiste.ForeColor = System.Drawing.Color.Red
        Me.lblAdvertenciaArticuloExiste.Location = New System.Drawing.Point(32, 476)
        Me.lblAdvertenciaArticuloExiste.Name = "lblAdvertenciaArticuloExiste"
        Me.lblAdvertenciaArticuloExiste.Size = New System.Drawing.Size(292, 26)
        Me.lblAdvertenciaArticuloExiste.TabIndex = 40
        Me.lblAdvertenciaArticuloExiste.Text = "Artículo ya añadido. Modifique cantidad."
        Me.lblAdvertenciaArticuloExiste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCuidadoLimiteStock
        '
        Me.lblCuidadoLimiteStock.BackColor = System.Drawing.Color.Transparent
        Me.lblCuidadoLimiteStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuidadoLimiteStock.ForeColor = System.Drawing.Color.Red
        Me.lblCuidadoLimiteStock.Location = New System.Drawing.Point(338, 477)
        Me.lblCuidadoLimiteStock.Name = "lblCuidadoLimiteStock"
        Me.lblCuidadoLimiteStock.Size = New System.Drawing.Size(439, 26)
        Me.lblCuidadoLimiteStock.TabIndex = 62
        Me.lblCuidadoLimiteStock.Text = "La cantidad pedida para el artículo podría no estar disponible"
        Me.lblCuidadoLimiteStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDineroPagado
        '
        Me.txtDineroPagado.Location = New System.Drawing.Point(509, 533)
        Me.txtDineroPagado.Name = "txtDineroPagado"
        Me.txtDineroPagado.Size = New System.Drawing.Size(128, 20)
        Me.txtDineroPagado.TabIndex = 63
        '
        'lblErrorCantidadPagar
        '
        Me.lblErrorCantidadPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorCantidadPagar.ForeColor = System.Drawing.Color.Red
        Me.lblErrorCantidadPagar.Location = New System.Drawing.Point(360, 529)
        Me.lblErrorCantidadPagar.Name = "lblErrorCantidadPagar"
        Me.lblErrorCantidadPagar.Size = New System.Drawing.Size(143, 26)
        Me.lblErrorCantidadPagar.TabIndex = 64
        Me.lblErrorCantidadPagar.Text = "Cantidad incorrecta"
        Me.lblErrorCantidadPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOculto2
        '
        Me.txtOculto2.Location = New System.Drawing.Point(191, 535)
        Me.txtOculto2.Name = "txtOculto2"
        Me.txtOculto2.ReadOnly = True
        Me.txtOculto2.Size = New System.Drawing.Size(16, 20)
        Me.txtOculto2.TabIndex = 41
        Me.txtOculto2.Visible = False
        '
        'frmPedidosNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 602)
        Me.Controls.Add(Me.lblErrorCantidadPagar)
        Me.Controls.Add(Me.txtDineroPagado)
        Me.Controls.Add(Me.lblCuidadoLimiteStock)
        Me.Controls.Add(Me.lblAdvertenciaArticuloExiste)
        Me.Controls.Add(Me.btnCambios)
        Me.Controls.Add(Me.btnLimpiarTodo)
        Me.Controls.Add(Me.btnBorrarArticulos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminarArticulo)
        Me.Controls.Add(Me.pboxProductoElegidoAcierto)
        Me.Controls.Add(Me.txtOculto2)
        Me.Controls.Add(Me.pboxProductoElegidoError)
        Me.Controls.Add(Me.txtBoxOculta1)
        Me.Controls.Add(Me.pboxViajePasadoAdvertencia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelFechaPedido)
        Me.Controls.Add(Me.txtFormaPago)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnyadirProducto)
        Me.Controls.Add(Me.pboxClienteAcierto)
        Me.Controls.Add(Me.pboxClienteError)
        Me.Controls.Add(Me.pboxPagoAcierto)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pboxPagoError)
        Me.Controls.Add(Me.btnNuevoPedido)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.lblFormaPago)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPedidosNuevo"
        Me.Text = "Gestion de pedidos"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFechaPedido.ResumeLayout(False)
        Me.panelFechaPedido.PerformLayout()
        CType(Me.pboxHoraAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxHoraAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxClienteAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxClienteError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPagoAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPagoError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pboxHoraLlegadaAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxHoraLlegadaAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxViajePasadoAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProductoElegidoError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProductoElegidoAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevoPedido As System.Windows.Forms.Button
    Friend WithEvents pboxPagoError As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPagoAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxClienteError As System.Windows.Forms.PictureBox
    Friend WithEvents pboxClienteAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents btnAnyadirProducto As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents pboxHoraAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents panelFechaPedido As System.Windows.Forms.Panel
    Friend WithEvents lblFechaHoraPedido As System.Windows.Forms.Label
    Friend WithEvents lblComboSegundo As System.Windows.Forms.Label
    Friend WithEvents lblComboMinuto As System.Windows.Forms.Label
    Friend WithEvents lblComboHora As System.Windows.Forms.Label
    Friend WithEvents comboBoxSegundo As System.Windows.Forms.ComboBox
    Friend WithEvents comboBoxMinuto As System.Windows.Forms.ComboBox
    Friend WithEvents comboBoxHora As System.Windows.Forms.ComboBox
    Friend WithEvents btnReiniciarFechaHora As System.Windows.Forms.Button
    Friend WithEvents lblReiniciarFechaHora As System.Windows.Forms.Label
    Friend WithEvents pboxHoraAdvertencia As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pboxHoraLlegadaAdvertencia As System.Windows.Forms.PictureBox
    Friend WithEvents btnReiniciarFechaHoraLlegada As System.Windows.Forms.Button
    Friend WithEvents lblReiniciarFechaHoraLlegada As System.Windows.Forms.Label
    Friend WithEvents lblFechaHoraEntrega As System.Windows.Forms.Label
    Friend WithEvents pboxHoraLlegadaAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboBoxDiasDefecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaLlegada As System.Windows.Forms.TextBox
    Friend WithEvents pboxViajePasadoAdvertencia As System.Windows.Forms.PictureBox
    Friend WithEvents txtBoxOculta1 As System.Windows.Forms.TextBox
    Friend WithEvents pboxProductoElegidoError As System.Windows.Forms.PictureBox
    Friend WithEvents pboxProductoElegidoAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminarArticulo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBorrarArticulos As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarTodo As System.Windows.Forms.Button
    Friend WithEvents ARTICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOCK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIOUNITARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIOTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCambios As System.Windows.Forms.Button
    Friend WithEvents lblAdvertenciaArticuloExiste As System.Windows.Forms.Label
    Friend WithEvents lblCuidadoLimiteStock As System.Windows.Forms.Label
    Friend WithEvents txtDineroPagado As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorCantidadPagar As System.Windows.Forms.Label
    Friend WithEvents txtOculto2 As System.Windows.Forms.TextBox
End Class
