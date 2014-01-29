<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Nuevo_Modificar_Proveedores
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
        Me.cboComunidades = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCodigoPostal = New System.Windows.Forms.ComboBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cboPoblacion = New System.Windows.Forms.ComboBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.pboxComunidadFallo = New System.Windows.Forms.PictureBox()
        Me.pboxComunidadAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxCPFallo = New System.Windows.Forms.PictureBox()
        Me.pboxCPAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxProvinciaAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxPoblacionAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxPoblacionFallo = New System.Windows.Forms.PictureBox()
        Me.pboxProvinciaFallo = New System.Windows.Forms.PictureBox()
        Me.pboxTelefonAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxNIFAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxNIFFallo = New System.Windows.Forms.PictureBox()
        Me.pboxTelefonoFallo = New System.Windows.Forms.PictureBox()
        Me.txtCIF = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblCIF = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.pboxDireccionAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxDireccionFallo = New System.Windows.Forms.PictureBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.pboxNombreAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxNombreFallo = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.numArtic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asociado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nombreProb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idRelacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pboxComunidadFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxComunidadAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxCPFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxCPAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProvinciaAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPoblacionAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPoblacionFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProvinciaFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTelefonAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNIFAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNIFFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTelefonoFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxDireccionAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxDireccionFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNombreAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNombreFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboComunidades
        '
        Me.cboComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComunidades.FormattingEnabled = True
        Me.cboComunidades.Location = New System.Drawing.Point(447, 20)
        Me.cboComunidades.Name = "cboComunidades"
        Me.cboComunidades.Size = New System.Drawing.Size(179, 21)
        Me.cboComunidades.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "C. Autonoma"
        '
        'cboCodigoPostal
        '
        Me.cboCodigoPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodigoPostal.FormattingEnabled = True
        Me.cboCodigoPostal.Location = New System.Drawing.Point(447, 102)
        Me.cboCodigoPostal.Name = "cboCodigoPostal"
        Me.cboCodigoPostal.Size = New System.Drawing.Size(179, 21)
        Me.cboCodigoPostal.TabIndex = 79
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(355, 105)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(72, 13)
        Me.lblCP.TabIndex = 78
        Me.lblCP.Text = "Codigo Postal"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 405)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 29)
        Me.btnNuevo.TabIndex = 67
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cboPoblacion
        '
        Me.cboPoblacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPoblacion.FormattingEnabled = True
        Me.cboPoblacion.Location = New System.Drawing.Point(447, 74)
        Me.cboPoblacion.Name = "cboPoblacion"
        Me.cboPoblacion.Size = New System.Drawing.Size(179, 21)
        Me.cboPoblacion.TabIndex = 66
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(447, 47)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(179, 21)
        Me.cboProvincia.TabIndex = 65
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(354, 78)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(54, 13)
        Me.lblPoblacion.TabIndex = 59
        Me.lblPoblacion.Text = "Poblacion"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(354, 50)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 58
        Me.lblProvincia.Text = "Provincia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-9, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = " "
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(584, 405)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 29)
        Me.btnSalir.TabIndex = 55
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(12, 405)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 29)
        Me.btnGuardar.TabIndex = 54
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'pboxComunidadFallo
        '
        Me.pboxComunidadFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxComunidadFallo.Location = New System.Drawing.Point(632, 21)
        Me.pboxComunidadFallo.Name = "pboxComunidadFallo"
        Me.pboxComunidadFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxComunidadFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxComunidadFallo.TabIndex = 85
        Me.pboxComunidadFallo.TabStop = False
        Me.pboxComunidadFallo.Visible = False
        '
        'pboxComunidadAcierto
        '
        Me.pboxComunidadAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxComunidadAcierto.Location = New System.Drawing.Point(632, 21)
        Me.pboxComunidadAcierto.Name = "pboxComunidadAcierto"
        Me.pboxComunidadAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxComunidadAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxComunidadAcierto.TabIndex = 84
        Me.pboxComunidadAcierto.TabStop = False
        Me.pboxComunidadAcierto.Visible = False
        '
        'pboxCPFallo
        '
        Me.pboxCPFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxCPFallo.Location = New System.Drawing.Point(631, 102)
        Me.pboxCPFallo.Name = "pboxCPFallo"
        Me.pboxCPFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxCPFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxCPFallo.TabIndex = 81
        Me.pboxCPFallo.TabStop = False
        Me.pboxCPFallo.Visible = False
        '
        'pboxCPAcierto
        '
        Me.pboxCPAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxCPAcierto.Location = New System.Drawing.Point(631, 102)
        Me.pboxCPAcierto.Name = "pboxCPAcierto"
        Me.pboxCPAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxCPAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxCPAcierto.TabIndex = 80
        Me.pboxCPAcierto.TabStop = False
        Me.pboxCPAcierto.Visible = False
        '
        'pboxProvinciaAcierto
        '
        Me.pboxProvinciaAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxProvinciaAcierto.Location = New System.Drawing.Point(632, 49)
        Me.pboxProvinciaAcierto.Name = "pboxProvinciaAcierto"
        Me.pboxProvinciaAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxProvinciaAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProvinciaAcierto.TabIndex = 77
        Me.pboxProvinciaAcierto.TabStop = False
        Me.pboxProvinciaAcierto.Visible = False
        '
        'pboxPoblacionAcierto
        '
        Me.pboxPoblacionAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxPoblacionAcierto.Location = New System.Drawing.Point(631, 75)
        Me.pboxPoblacionAcierto.Name = "pboxPoblacionAcierto"
        Me.pboxPoblacionAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxPoblacionAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPoblacionAcierto.TabIndex = 76
        Me.pboxPoblacionAcierto.TabStop = False
        Me.pboxPoblacionAcierto.Visible = False
        '
        'pboxPoblacionFallo
        '
        Me.pboxPoblacionFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxPoblacionFallo.Location = New System.Drawing.Point(631, 75)
        Me.pboxPoblacionFallo.Name = "pboxPoblacionFallo"
        Me.pboxPoblacionFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxPoblacionFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPoblacionFallo.TabIndex = 69
        Me.pboxPoblacionFallo.TabStop = False
        Me.pboxPoblacionFallo.Visible = False
        '
        'pboxProvinciaFallo
        '
        Me.pboxProvinciaFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxProvinciaFallo.Location = New System.Drawing.Point(632, 49)
        Me.pboxProvinciaFallo.Name = "pboxProvinciaFallo"
        Me.pboxProvinciaFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxProvinciaFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProvinciaFallo.TabIndex = 68
        Me.pboxProvinciaFallo.TabStop = False
        Me.pboxProvinciaFallo.Visible = False
        '
        'pboxTelefonAcierto
        '
        Me.pboxTelefonAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxTelefonAcierto.Location = New System.Drawing.Point(286, 49)
        Me.pboxTelefonAcierto.Name = "pboxTelefonAcierto"
        Me.pboxTelefonAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxTelefonAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTelefonAcierto.TabIndex = 93
        Me.pboxTelefonAcierto.TabStop = False
        Me.pboxTelefonAcierto.Visible = False
        '
        'pboxNIFAcierto
        '
        Me.pboxNIFAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxNIFAcierto.Location = New System.Drawing.Point(286, 78)
        Me.pboxNIFAcierto.Name = "pboxNIFAcierto"
        Me.pboxNIFAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxNIFAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNIFAcierto.TabIndex = 92
        Me.pboxNIFAcierto.TabStop = False
        Me.pboxNIFAcierto.Visible = False
        '
        'pboxNIFFallo
        '
        Me.pboxNIFFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxNIFFallo.Location = New System.Drawing.Point(286, 78)
        Me.pboxNIFFallo.Name = "pboxNIFFallo"
        Me.pboxNIFFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxNIFFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNIFFallo.TabIndex = 91
        Me.pboxNIFFallo.TabStop = False
        Me.pboxNIFFallo.Visible = False
        '
        'pboxTelefonoFallo
        '
        Me.pboxTelefonoFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxTelefonoFallo.Location = New System.Drawing.Point(286, 49)
        Me.pboxTelefonoFallo.Name = "pboxTelefonoFallo"
        Me.pboxTelefonoFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxTelefonoFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTelefonoFallo.TabIndex = 90
        Me.pboxTelefonoFallo.TabStop = False
        Me.pboxTelefonoFallo.Visible = False
        '
        'txtCIF
        '
        Me.txtCIF.Location = New System.Drawing.Point(101, 79)
        Me.txtCIF.Name = "txtCIF"
        Me.txtCIF.Size = New System.Drawing.Size(179, 20)
        Me.txtCIF.TabIndex = 89
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(101, 49)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(179, 20)
        Me.txtTelefono.TabIndex = 88
        '
        'lblCIF
        '
        Me.lblCIF.AutoSize = True
        Me.lblCIF.Location = New System.Drawing.Point(12, 82)
        Me.lblCIF.Name = "lblCIF"
        Me.lblCIF.Size = New System.Drawing.Size(51, 13)
        Me.lblCIF.TabIndex = 87
        Me.lblCIF.Text = "CIF / NIF"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(12, 52)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 86
        Me.lblTelefono.Text = "Telefono"
        '
        'pboxDireccionAcierto
        '
        Me.pboxDireccionAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxDireccionAcierto.Location = New System.Drawing.Point(286, 104)
        Me.pboxDireccionAcierto.Name = "pboxDireccionAcierto"
        Me.pboxDireccionAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxDireccionAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxDireccionAcierto.TabIndex = 97
        Me.pboxDireccionAcierto.TabStop = False
        Me.pboxDireccionAcierto.Visible = False
        '
        'pboxDireccionFallo
        '
        Me.pboxDireccionFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxDireccionFallo.Location = New System.Drawing.Point(286, 104)
        Me.pboxDireccionFallo.Name = "pboxDireccionFallo"
        Me.pboxDireccionFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxDireccionFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxDireccionFallo.TabIndex = 96
        Me.pboxDireccionFallo.TabStop = False
        Me.pboxDireccionFallo.Visible = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(101, 105)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(179, 20)
        Me.txtDireccion.TabIndex = 95
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(11, 108)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 94
        Me.lblDireccion.Text = "Direccion"
        '
        'pboxNombreAcierto
        '
        Me.pboxNombreAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxNombreAcierto.Location = New System.Drawing.Point(286, 23)
        Me.pboxNombreAcierto.Name = "pboxNombreAcierto"
        Me.pboxNombreAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxNombreAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNombreAcierto.TabIndex = 101
        Me.pboxNombreAcierto.TabStop = False
        Me.pboxNombreAcierto.Visible = False
        '
        'pboxNombreFallo
        '
        Me.pboxNombreFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxNombreFallo.Location = New System.Drawing.Point(286, 23)
        Me.pboxNombreFallo.Name = "pboxNombreFallo"
        Me.pboxNombreFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxNombreFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNombreFallo.TabIndex = 100
        Me.pboxNombreFallo.TabStop = False
        Me.pboxNombreFallo.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNombre.TabIndex = 99
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 98
        Me.lblNombre.Text = "Nombre"
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numArtic, Me.nombre, Me.asociado, Me.nombreProb, Me.precio, Me.idArticulo, Me.modificado, Me.idRelacion})
        Me.dgvArticulos.Location = New System.Drawing.Point(12, 156)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.Size = New System.Drawing.Size(639, 243)
        Me.dgvArticulos.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Numero:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Nombre articulo:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(65, 130)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(82, 20)
        Me.txtNumero.TabIndex = 105
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(271, 130)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(179, 20)
        Me.txtArticulo.TabIndex = 106
        '
        'numArtic
        '
        Me.numArtic.HeaderText = "Numero articulo"
        Me.numArtic.Name = "numArtic"
        Me.numArtic.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'asociado
        '
        Me.asociado.HeaderText = "Asociado"
        Me.asociado.Name = "asociado"
        '
        'nombreProb
        '
        Me.nombreProb.HeaderText = "Nombre proveedor"
        Me.nombreProb.Name = "nombreProb"
        Me.nombreProb.ReadOnly = True
        Me.nombreProb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombreProb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'precio
        '
        Me.precio.HeaderText = "Precio proveedor"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'idArticulo
        '
        Me.idArticulo.HeaderText = "idArticulo"
        Me.idArticulo.Name = "idArticulo"
        Me.idArticulo.ReadOnly = True
        Me.idArticulo.Visible = False
        '
        'modificado
        '
        Me.modificado.HeaderText = "Modificado"
        Me.modificado.Name = "modificado"
        Me.modificado.ReadOnly = True
        Me.modificado.Visible = False
        '
        'idRelacion
        '
        Me.idRelacion.HeaderText = "idRelacion"
        Me.idRelacion.Name = "idRelacion"
        Me.idRelacion.ReadOnly = True
        Me.idRelacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.idRelacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.idRelacion.Visible = False
        '
        'frm_Nuevo_Modificar_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 446)
        Me.Controls.Add(Me.txtArticulo)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.pboxNombreAcierto)
        Me.Controls.Add(Me.pboxNombreFallo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.pboxDireccionAcierto)
        Me.Controls.Add(Me.pboxDireccionFallo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.pboxTelefonAcierto)
        Me.Controls.Add(Me.pboxNIFAcierto)
        Me.Controls.Add(Me.pboxNIFFallo)
        Me.Controls.Add(Me.pboxTelefonoFallo)
        Me.Controls.Add(Me.txtCIF)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblCIF)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.pboxComunidadFallo)
        Me.Controls.Add(Me.pboxComunidadAcierto)
        Me.Controls.Add(Me.cboComunidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pboxCPFallo)
        Me.Controls.Add(Me.pboxCPAcierto)
        Me.Controls.Add(Me.cboCodigoPostal)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.pboxProvinciaAcierto)
        Me.Controls.Add(Me.pboxPoblacionAcierto)
        Me.Controls.Add(Me.pboxPoblacionFallo)
        Me.Controls.Add(Me.pboxProvinciaFallo)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboPoblacion)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frm_Nuevo_Modificar_Proveedores"
        Me.Text = "Nuevo Proveedores"
        CType(Me.pboxComunidadFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxComunidadAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxCPFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxCPAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProvinciaAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPoblacionAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPoblacionFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProvinciaFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTelefonAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNIFAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNIFFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTelefonoFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxDireccionAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxDireccionFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNombreAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNombreFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxComunidadFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxComunidadAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents cboComunidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pboxCPFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxCPAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents cboCodigoPostal As System.Windows.Forms.ComboBox
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents pboxProvinciaAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPoblacionAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPoblacionFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxProvinciaFallo As System.Windows.Forms.PictureBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents cboPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents lblPoblacion As System.Windows.Forms.Label
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents pboxTelefonAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxNIFAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxNIFFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxTelefonoFallo As System.Windows.Forms.PictureBox
    Friend WithEvents txtCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblCIF As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents pboxDireccionAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxDireccionFallo As System.Windows.Forms.PictureBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents pboxNombreAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxNombreFallo As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents numArtic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asociado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nombreProb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modificado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents idRelacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
