<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosBuscar
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
        Me.btnDetallePedido = New System.Windows.Forms.Button()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtApellidoCliente1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.NUMPEDIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRECLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO1CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO2CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIONAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORMAPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAREALIZACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHAENTREGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFUSUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFPEDIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFFORMAPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.pboxFalloNumeroPedido = New System.Windows.Forms.PictureBox()
        Me.pboxFalloNombreCliente = New System.Windows.Forms.PictureBox()
        Me.txtApellidoCliente2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pboxFalloApellidoCliente1 = New System.Windows.Forms.PictureBox()
        Me.pboxFalloApellidoCliente2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboFormaPago = New System.Windows.Forms.ComboBox()
        Me.btnCrearPedido = New System.Windows.Forms.Button()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.cboEliminados = New System.Windows.Forms.ComboBox()
        Me.lblEliminado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.jcbComparaFechaLlegada = New System.Windows.Forms.ComboBox()
        Me.jcbComparaFechaRealizacion = New System.Windows.Forms.ComboBox()
        Me.dtpFechaLlegada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaRealizacion = New System.Windows.Forms.DateTimePicker()
        Me.cbFechaLlegada = New System.Windows.Forms.CheckBox()
        Me.cbFechaRealizacion = New System.Windows.Forms.CheckBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCambios = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFalloNumeroPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFalloNombreCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFalloApellidoCliente1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFalloApellidoCliente2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDetallePedido
        '
        Me.btnDetallePedido.Enabled = False
        Me.btnDetallePedido.Location = New System.Drawing.Point(654, 461)
        Me.btnDetallePedido.Name = "btnDetallePedido"
        Me.btnDetallePedido.Size = New System.Drawing.Size(131, 22)
        Me.btnDetallePedido.TabIndex = 24
        Me.btnDetallePedido.Text = "DETALLE PEDIDO"
        Me.btnDetallePedido.UseVisualStyleBackColor = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(237, 55)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(193, 20)
        Me.txtNombreCliente.TabIndex = 26
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(69, 51)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(117, 26)
        Me.lblCliente.TabIndex = 25
        Me.lblCliente.Text = "Nombre Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoCliente1
        '
        Me.txtApellidoCliente1.Location = New System.Drawing.Point(237, 91)
        Me.txtApellidoCliente1.Name = "txtApellidoCliente1"
        Me.txtApellidoCliente1.Size = New System.Drawing.Size(193, 20)
        Me.txtApellidoCliente1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 26)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Primer Apellido Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 26)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Seleccione usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Location = New System.Drawing.Point(237, 17)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(98, 20)
        Me.txtNumPedido.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 26)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Número de pedido"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToOrderColumns = True
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMPEDIDO, Me.NOMBRECLIENTE, Me.APELLIDO1CLIENTE, Me.APELLIDO2CLIENTE, Me.USUARIONAME, Me.TOTAL, Me.PAGADO, Me.FORMAPAGO, Me.FECHAREALIZACION, Me.FECHAENTREGA, Me.REFCLIENTE, Me.REFUSUARIO, Me.REFPEDIDO, Me.REFFORMAPAGO})
        Me.dgvPedido.Location = New System.Drawing.Point(21, 264)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(1073, 179)
        Me.dgvPedido.TabIndex = 39
        '
        'NUMPEDIDO
        '
        Me.NUMPEDIDO.HeaderText = "NUMPEDIDO"
        Me.NUMPEDIDO.Name = "NUMPEDIDO"
        Me.NUMPEDIDO.ReadOnly = True
        '
        'NOMBRECLIENTE
        '
        Me.NOMBRECLIENTE.HeaderText = "NOMBRE CLIENTE"
        Me.NOMBRECLIENTE.Name = "NOMBRECLIENTE"
        Me.NOMBRECLIENTE.ReadOnly = True
        '
        'APELLIDO1CLIENTE
        '
        Me.APELLIDO1CLIENTE.HeaderText = "APELLIDO 1 CLIENTE"
        Me.APELLIDO1CLIENTE.Name = "APELLIDO1CLIENTE"
        Me.APELLIDO1CLIENTE.ReadOnly = True
        '
        'APELLIDO2CLIENTE
        '
        Me.APELLIDO2CLIENTE.HeaderText = "APELLIDO 2 CLIENTE"
        Me.APELLIDO2CLIENTE.Name = "APELLIDO2CLIENTE"
        Me.APELLIDO2CLIENTE.ReadOnly = True
        '
        'USUARIONAME
        '
        Me.USUARIONAME.HeaderText = "USUARIO"
        Me.USUARIONAME.Name = "USUARIONAME"
        Me.USUARIONAME.ReadOnly = True
        '
        'TOTAL
        '
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        '
        'PAGADO
        '
        Me.PAGADO.HeaderText = "PAGADO"
        Me.PAGADO.Name = "PAGADO"
        Me.PAGADO.ReadOnly = True
        '
        'FORMAPAGO
        '
        Me.FORMAPAGO.HeaderText = "FORMA DE PAGO"
        Me.FORMAPAGO.Name = "FORMAPAGO"
        Me.FORMAPAGO.ReadOnly = True
        '
        'FECHAREALIZACION
        '
        Me.FECHAREALIZACION.HeaderText = "FECHA DE REALIZACION"
        Me.FECHAREALIZACION.Name = "FECHAREALIZACION"
        Me.FECHAREALIZACION.ReadOnly = True
        '
        'FECHAENTREGA
        '
        Me.FECHAENTREGA.HeaderText = "FECHA DE ENTREGA"
        Me.FECHAENTREGA.Name = "FECHAENTREGA"
        Me.FECHAENTREGA.ReadOnly = True
        '
        'REFCLIENTE
        '
        Me.REFCLIENTE.HeaderText = "REFCLIENTE"
        Me.REFCLIENTE.Name = "REFCLIENTE"
        Me.REFCLIENTE.ReadOnly = True
        Me.REFCLIENTE.Visible = False
        '
        'REFUSUARIO
        '
        Me.REFUSUARIO.HeaderText = "REFUSUARIO"
        Me.REFUSUARIO.Name = "REFUSUARIO"
        Me.REFUSUARIO.ReadOnly = True
        Me.REFUSUARIO.Visible = False
        '
        'REFPEDIDO
        '
        Me.REFPEDIDO.HeaderText = "REFPEDIDO"
        Me.REFPEDIDO.Name = "REFPEDIDO"
        Me.REFPEDIDO.ReadOnly = True
        Me.REFPEDIDO.Visible = False
        '
        'REFFORMAPAGO
        '
        Me.REFFORMAPAGO.HeaderText = "REFFORMAPAGO"
        Me.REFFORMAPAGO.Name = "REFFORMAPAGO"
        Me.REFFORMAPAGO.ReadOnly = True
        Me.REFFORMAPAGO.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(136, 21)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(98, 20)
        Me.TextBox6.TabIndex = 38
        '
        'pboxFalloNumeroPedido
        '
        Me.pboxFalloNumeroPedido.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoAlerta
        Me.pboxFalloNumeroPedido.Location = New System.Drawing.Point(344, 19)
        Me.pboxFalloNumeroPedido.Name = "pboxFalloNumeroPedido"
        Me.pboxFalloNumeroPedido.Size = New System.Drawing.Size(20, 20)
        Me.pboxFalloNumeroPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxFalloNumeroPedido.TabIndex = 40
        Me.pboxFalloNumeroPedido.TabStop = False
        Me.pboxFalloNumeroPedido.Visible = False
        '
        'pboxFalloNombreCliente
        '
        Me.pboxFalloNombreCliente.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoAlerta
        Me.pboxFalloNombreCliente.Location = New System.Drawing.Point(439, 57)
        Me.pboxFalloNombreCliente.Name = "pboxFalloNombreCliente"
        Me.pboxFalloNombreCliente.Size = New System.Drawing.Size(20, 20)
        Me.pboxFalloNombreCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxFalloNombreCliente.TabIndex = 41
        Me.pboxFalloNombreCliente.TabStop = False
        Me.pboxFalloNombreCliente.Visible = False
        '
        'txtApellidoCliente2
        '
        Me.txtApellidoCliente2.Location = New System.Drawing.Point(237, 132)
        Me.txtApellidoCliente2.Name = "txtApellidoCliente2"
        Me.txtApellidoCliente2.Size = New System.Drawing.Size(193, 20)
        Me.txtApellidoCliente2.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 26)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Segundo Apellido Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pboxFalloApellidoCliente1
        '
        Me.pboxFalloApellidoCliente1.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoAlerta
        Me.pboxFalloApellidoCliente1.Location = New System.Drawing.Point(439, 93)
        Me.pboxFalloApellidoCliente1.Name = "pboxFalloApellidoCliente1"
        Me.pboxFalloApellidoCliente1.Size = New System.Drawing.Size(20, 20)
        Me.pboxFalloApellidoCliente1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxFalloApellidoCliente1.TabIndex = 44
        Me.pboxFalloApellidoCliente1.TabStop = False
        Me.pboxFalloApellidoCliente1.Visible = False
        '
        'pboxFalloApellidoCliente2
        '
        Me.pboxFalloApellidoCliente2.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoAlerta
        Me.pboxFalloApellidoCliente2.Location = New System.Drawing.Point(439, 132)
        Me.pboxFalloApellidoCliente2.Name = "pboxFalloApellidoCliente2"
        Me.pboxFalloApellidoCliente2.Size = New System.Drawing.Size(20, 20)
        Me.pboxFalloApellidoCliente2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxFalloApellidoCliente2.TabIndex = 45
        Me.pboxFalloApellidoCliente2.TabStop = False
        Me.pboxFalloApellidoCliente2.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(553, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 26)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Forma de pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboFormaPago
        '
        Me.comboFormaPago.FormattingEnabled = True
        Me.comboFormaPago.Location = New System.Drawing.Point(786, 23)
        Me.comboFormaPago.Name = "comboFormaPago"
        Me.comboFormaPago.Size = New System.Drawing.Size(204, 21)
        Me.comboFormaPago.TabIndex = 48
        '
        'btnCrearPedido
        '
        Me.btnCrearPedido.Location = New System.Drawing.Point(496, 461)
        Me.btnCrearPedido.Name = "btnCrearPedido"
        Me.btnCrearPedido.Size = New System.Drawing.Size(135, 22)
        Me.btnCrearPedido.TabIndex = 49
        Me.btnCrearPedido.Text = "NUEVO"
        Me.btnCrearPedido.UseVisualStyleBackColor = True
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(237, 171)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(196, 21)
        Me.cboUsuario.TabIndex = 50
        '
        'cboEliminados
        '
        Me.cboEliminados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEliminados.FormattingEnabled = True
        Me.cboEliminados.Location = New System.Drawing.Point(786, 56)
        Me.cboEliminados.Name = "cboEliminados"
        Me.cboEliminados.Size = New System.Drawing.Size(205, 21)
        Me.cboEliminados.TabIndex = 51
        '
        'lblEliminado
        '
        Me.lblEliminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminado.Location = New System.Drawing.Point(552, 57)
        Me.lblEliminado.Name = "lblEliminado"
        Me.lblEliminado.Size = New System.Drawing.Size(136, 26)
        Me.lblEliminado.TabIndex = 52
        Me.lblEliminado.Text = "¿Eliminado?"
        Me.lblEliminado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.jcbComparaFechaLlegada)
        Me.Panel1.Controls.Add(Me.jcbComparaFechaRealizacion)
        Me.Panel1.Controls.Add(Me.dtpFechaLlegada)
        Me.Panel1.Controls.Add(Me.dtpFechaRealizacion)
        Me.Panel1.Controls.Add(Me.cbFechaLlegada)
        Me.Panel1.Controls.Add(Me.cbFechaRealizacion)
        Me.Panel1.Controls.Add(Me.lblEliminado)
        Me.Panel1.Controls.Add(Me.cboEliminados)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cboUsuario)
        Me.Panel1.Controls.Add(Me.comboFormaPago)
        Me.Panel1.Controls.Add(Me.pboxFalloApellidoCliente2)
        Me.Panel1.Controls.Add(Me.pboxFalloApellidoCliente1)
        Me.Panel1.Controls.Add(Me.txtApellidoCliente2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.pboxFalloNombreCliente)
        Me.Panel1.Controls.Add(Me.pboxFalloNumeroPedido)
        Me.Panel1.Controls.Add(Me.txtNumPedido)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtApellidoCliente1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombreCliente)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Location = New System.Drawing.Point(21, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 211)
        Me.Panel1.TabIndex = 53
        '
        'jcbComparaFechaLlegada
        '
        Me.jcbComparaFechaLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbComparaFechaLlegada.FormattingEnabled = True
        Me.jcbComparaFechaLlegada.Items.AddRange(New Object() {">", "=", "<"})
        Me.jcbComparaFechaLlegada.Location = New System.Drawing.Point(1015, 131)
        Me.jcbComparaFechaLlegada.Name = "jcbComparaFechaLlegada"
        Me.jcbComparaFechaLlegada.Size = New System.Drawing.Size(34, 21)
        Me.jcbComparaFechaLlegada.TabIndex = 58
        '
        'jcbComparaFechaRealizacion
        '
        Me.jcbComparaFechaRealizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbComparaFechaRealizacion.FormattingEnabled = True
        Me.jcbComparaFechaRealizacion.Items.AddRange(New Object() {">", "=", "<"})
        Me.jcbComparaFechaRealizacion.Location = New System.Drawing.Point(1015, 90)
        Me.jcbComparaFechaRealizacion.Name = "jcbComparaFechaRealizacion"
        Me.jcbComparaFechaRealizacion.Size = New System.Drawing.Size(34, 21)
        Me.jcbComparaFechaRealizacion.TabIndex = 57
        '
        'dtpFechaLlegada
        '
        Me.dtpFechaLlegada.Enabled = False
        Me.dtpFechaLlegada.Location = New System.Drawing.Point(785, 134)
        Me.dtpFechaLlegada.Name = "dtpFechaLlegada"
        Me.dtpFechaLlegada.Size = New System.Drawing.Size(205, 20)
        Me.dtpFechaLlegada.TabIndex = 56
        '
        'dtpFechaRealizacion
        '
        Me.dtpFechaRealizacion.Enabled = False
        Me.dtpFechaRealizacion.Location = New System.Drawing.Point(785, 91)
        Me.dtpFechaRealizacion.Name = "dtpFechaRealizacion"
        Me.dtpFechaRealizacion.Size = New System.Drawing.Size(205, 20)
        Me.dtpFechaRealizacion.TabIndex = 55
        '
        'cbFechaLlegada
        '
        Me.cbFechaLlegada.AutoSize = True
        Me.cbFechaLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFechaLlegada.Location = New System.Drawing.Point(555, 132)
        Me.cbFechaLlegada.Name = "cbFechaLlegada"
        Me.cbFechaLlegada.Size = New System.Drawing.Size(187, 20)
        Me.cbFechaLlegada.TabIndex = 54
        Me.cbFechaLlegada.Text = "Filtrar por fecha de llegada"
        Me.cbFechaLlegada.UseVisualStyleBackColor = True
        '
        'cbFechaRealizacion
        '
        Me.cbFechaRealizacion.AutoSize = True
        Me.cbFechaRealizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFechaRealizacion.Location = New System.Drawing.Point(556, 93)
        Me.cbFechaRealizacion.Name = "cbFechaRealizacion"
        Me.cbFechaRealizacion.Size = New System.Drawing.Size(206, 20)
        Me.cbFechaRealizacion.TabIndex = 53
        Me.cbFechaRealizacion.Text = "Filtrar por fecha de realizacion"
        Me.cbFechaRealizacion.UseVisualStyleBackColor = True
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(18, 18)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(37, 16)
        Me.lbltipo.TabIndex = 53
        Me.lbltipo.Text = "Filtro"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(809, 461)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(131, 23)
        Me.btnEliminar.TabIndex = 57
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(963, 461)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(131, 23)
        Me.btnSalir.TabIndex = 58
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCambios
        '
        Me.btnCambios.Location = New System.Drawing.Point(169, 462)
        Me.btnCambios.Name = "btnCambios"
        Me.btnCambios.Size = New System.Drawing.Size(148, 22)
        Me.btnCambios.TabIndex = 59
        Me.btnCambios.Text = "LISTA DE CAMBIOS"
        Me.btnCambios.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(334, 461)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(148, 22)
        Me.btnModificar.TabIndex = 60
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(21, 461)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(130, 23)
        Me.btnGenerarXML.TabIndex = 61
        Me.btnGenerarXML.Text = "GENERAR XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'frmPedidosBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 507)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCambios)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCrearPedido)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.btnDetallePedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPedidosBuscar"
        Me.Text = "PedidosBuscar"
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFalloNumeroPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFalloNombreCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFalloApellidoCliente1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFalloApellidoCliente2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetallePedido As System.Windows.Forms.Button
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtApellidoCliente1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvPedido As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents pboxFalloNumeroPedido As System.Windows.Forms.PictureBox
    Friend WithEvents pboxFalloNombreCliente As System.Windows.Forms.PictureBox
    Friend WithEvents txtApellidoCliente2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pboxFalloApellidoCliente1 As System.Windows.Forms.PictureBox
    Friend WithEvents pboxFalloApellidoCliente2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents btnCrearPedido As System.Windows.Forms.Button
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cboEliminados As System.Windows.Forms.ComboBox
    Friend WithEvents lblEliminado As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents NUMPEDIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRECLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO1CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO2CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIONAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORMAPAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAREALIZACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAENTREGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFUSUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFPEDIDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFFORMAPAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbFechaRealizacion As System.Windows.Forms.CheckBox
    Friend WithEvents cbFechaLlegada As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaLlegada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaRealizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCambios As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents jcbComparaFechaRealizacion As System.Windows.Forms.ComboBox
    Friend WithEvents jcbComparaFechaLlegada As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerarXML As System.Windows.Forms.Button
End Class
