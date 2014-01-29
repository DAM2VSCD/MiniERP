<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Nuevo_Modificar_Clientes
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.cboPoblacion = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.cboCodigoPostal = New System.Windows.Forms.ComboBox()
        Me.btnLC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboComunidades = New System.Windows.Forms.ComboBox()
        Me.pboxComunidadFallo = New System.Windows.Forms.PictureBox()
        Me.pboxComunidadAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxCPFallo = New System.Windows.Forms.PictureBox()
        Me.pboxCPAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxProvinciaAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxPoblacionAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxTelefonAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxEmailAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxDireccionAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxDireccionFallo = New System.Windows.Forms.PictureBox()
        Me.pboxEmailFallo = New System.Windows.Forms.PictureBox()
        Me.pboxTelefonoFallo = New System.Windows.Forms.PictureBox()
        Me.pboxPoblacionFallo = New System.Windows.Forms.PictureBox()
        Me.pboxProvinciaFallo = New System.Windows.Forms.PictureBox()
        Me.pboxAp2Fallo = New System.Windows.Forms.PictureBox()
        Me.pboxAp2Acierto = New System.Windows.Forms.PictureBox()
        Me.pboxAp1Fallo = New System.Windows.Forms.PictureBox()
        Me.pboxAp1Acierto = New System.Windows.Forms.PictureBox()
        Me.pboxNombreAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxNombreFallo = New System.Windows.Forms.PictureBox()
        CType(Me.pboxComunidadFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxComunidadAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxCPFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxCPAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProvinciaAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPoblacionAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTelefonAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxEmailAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxDireccionAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxDireccionFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxEmailFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTelefonoFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPoblacionFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProvinciaFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxAp2Fallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxAp2Acierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxAp1Fallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxAp1Acierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNombreAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNombreFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(123, 492)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 29)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(295, 492)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 29)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(44, 58)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(44, 96)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido1.TabIndex = 3
        Me.lblApellido1.Text = "Apellido1"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(44, 136)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido2.TabIndex = 4
        Me.lblApellido2.Text = "Apellido2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " "
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(44, 177)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Direccion"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(47, 254)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.lblProvincia.TabIndex = 7
        Me.lblProvincia.Text = "Provincia"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(44, 299)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(54, 13)
        Me.lblPoblacion.TabIndex = 8
        Me.lblPoblacion.Text = "Poblacion"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(44, 391)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(44, 439)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(136, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(136, 96)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(179, 20)
        Me.txtApellido1.TabIndex = 12
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(136, 136)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(179, 20)
        Me.txtApellido2.TabIndex = 13
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(136, 174)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(179, 20)
        Me.txtDireccion.TabIndex = 14
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(136, 388)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(179, 20)
        Me.txtTelefono.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(136, 432)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(179, 20)
        Me.txtEmail.TabIndex = 16
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(136, 251)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(179, 21)
        Me.cboProvincia.TabIndex = 17
        '
        'cboPoblacion
        '
        Me.cboPoblacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPoblacion.FormattingEnabled = True
        Me.cboPoblacion.Location = New System.Drawing.Point(136, 299)
        Me.cboPoblacion.Name = "cboPoblacion"
        Me.cboPoblacion.Size = New System.Drawing.Size(179, 21)
        Me.cboPoblacion.TabIndex = 18
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(123, 492)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 29)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Numero"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(136, 20)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(179, 20)
        Me.txtNumero.TabIndex = 44
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(44, 346)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(72, 13)
        Me.lblCP.TabIndex = 45
        Me.lblCP.Text = "Codigo Postal"
        '
        'cboCodigoPostal
        '
        Me.cboCodigoPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodigoPostal.FormattingEnabled = True
        Me.cboCodigoPostal.Location = New System.Drawing.Point(136, 343)
        Me.cboCodigoPostal.Name = "cboCodigoPostal"
        Me.cboCodigoPostal.Size = New System.Drawing.Size(179, 21)
        Me.cboCodigoPostal.TabIndex = 46
        '
        'btnLC
        '
        Me.btnLC.Location = New System.Drawing.Point(397, 19)
        Me.btnLC.Name = "btnLC"
        Me.btnLC.Size = New System.Drawing.Size(75, 52)
        Me.btnLC.TabIndex = 49
        Me.btnLC.Text = "Lista de Cambios"
        Me.btnLC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "C. Autonoma"
        '
        'cboComunidades
        '
        Me.cboComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComunidades.FormattingEnabled = True
        Me.cboComunidades.Location = New System.Drawing.Point(136, 211)
        Me.cboComunidades.Name = "cboComunidades"
        Me.cboComunidades.Size = New System.Drawing.Size(179, 21)
        Me.cboComunidades.TabIndex = 51
        '
        'pboxComunidadFallo
        '
        Me.pboxComunidadFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxComunidadFallo.Location = New System.Drawing.Point(351, 214)
        Me.pboxComunidadFallo.Name = "pboxComunidadFallo"
        Me.pboxComunidadFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxComunidadFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxComunidadFallo.TabIndex = 53
        Me.pboxComunidadFallo.TabStop = False
        Me.pboxComunidadFallo.Visible = False
        '
        'pboxComunidadAcierto
        '
        Me.pboxComunidadAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxComunidadAcierto.Location = New System.Drawing.Point(351, 214)
        Me.pboxComunidadAcierto.Name = "pboxComunidadAcierto"
        Me.pboxComunidadAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxComunidadAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxComunidadAcierto.TabIndex = 52
        Me.pboxComunidadAcierto.TabStop = False
        Me.pboxComunidadAcierto.Visible = False
        '
        'pboxCPFallo
        '
        Me.pboxCPFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxCPFallo.Location = New System.Drawing.Point(351, 344)
        Me.pboxCPFallo.Name = "pboxCPFallo"
        Me.pboxCPFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxCPFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxCPFallo.TabIndex = 48
        Me.pboxCPFallo.TabStop = False
        Me.pboxCPFallo.Visible = False
        '
        'pboxCPAcierto
        '
        Me.pboxCPAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxCPAcierto.Location = New System.Drawing.Point(351, 343)
        Me.pboxCPAcierto.Name = "pboxCPAcierto"
        Me.pboxCPAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxCPAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxCPAcierto.TabIndex = 47
        Me.pboxCPAcierto.TabStop = False
        Me.pboxCPAcierto.Visible = False
        '
        'pboxProvinciaAcierto
        '
        Me.pboxProvinciaAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxProvinciaAcierto.Location = New System.Drawing.Point(351, 254)
        Me.pboxProvinciaAcierto.Name = "pboxProvinciaAcierto"
        Me.pboxProvinciaAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxProvinciaAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProvinciaAcierto.TabIndex = 42
        Me.pboxProvinciaAcierto.TabStop = False
        Me.pboxProvinciaAcierto.Visible = False
        '
        'pboxPoblacionAcierto
        '
        Me.pboxPoblacionAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxPoblacionAcierto.Location = New System.Drawing.Point(351, 300)
        Me.pboxPoblacionAcierto.Name = "pboxPoblacionAcierto"
        Me.pboxPoblacionAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxPoblacionAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPoblacionAcierto.TabIndex = 41
        Me.pboxPoblacionAcierto.TabStop = False
        Me.pboxPoblacionAcierto.Visible = False
        '
        'pboxTelefonAcierto
        '
        Me.pboxTelefonAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxTelefonAcierto.Location = New System.Drawing.Point(351, 384)
        Me.pboxTelefonAcierto.Name = "pboxTelefonAcierto"
        Me.pboxTelefonAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxTelefonAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTelefonAcierto.TabIndex = 40
        Me.pboxTelefonAcierto.TabStop = False
        Me.pboxTelefonAcierto.Visible = False
        '
        'pboxEmailAcierto
        '
        Me.pboxEmailAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxEmailAcierto.Location = New System.Drawing.Point(351, 432)
        Me.pboxEmailAcierto.Name = "pboxEmailAcierto"
        Me.pboxEmailAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxEmailAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxEmailAcierto.TabIndex = 39
        Me.pboxEmailAcierto.TabStop = False
        Me.pboxEmailAcierto.Visible = False
        '
        'pboxDireccionAcierto
        '
        Me.pboxDireccionAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxDireccionAcierto.Location = New System.Drawing.Point(351, 177)
        Me.pboxDireccionAcierto.Name = "pboxDireccionAcierto"
        Me.pboxDireccionAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxDireccionAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxDireccionAcierto.TabIndex = 38
        Me.pboxDireccionAcierto.TabStop = False
        Me.pboxDireccionAcierto.Visible = False
        '
        'pboxDireccionFallo
        '
        Me.pboxDireccionFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxDireccionFallo.Location = New System.Drawing.Point(351, 177)
        Me.pboxDireccionFallo.Name = "pboxDireccionFallo"
        Me.pboxDireccionFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxDireccionFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxDireccionFallo.TabIndex = 37
        Me.pboxDireccionFallo.TabStop = False
        Me.pboxDireccionFallo.Visible = False
        '
        'pboxEmailFallo
        '
        Me.pboxEmailFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxEmailFallo.Location = New System.Drawing.Point(351, 432)
        Me.pboxEmailFallo.Name = "pboxEmailFallo"
        Me.pboxEmailFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxEmailFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxEmailFallo.TabIndex = 36
        Me.pboxEmailFallo.TabStop = False
        Me.pboxEmailFallo.Visible = False
        '
        'pboxTelefonoFallo
        '
        Me.pboxTelefonoFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxTelefonoFallo.Location = New System.Drawing.Point(351, 384)
        Me.pboxTelefonoFallo.Name = "pboxTelefonoFallo"
        Me.pboxTelefonoFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxTelefonoFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTelefonoFallo.TabIndex = 35
        Me.pboxTelefonoFallo.TabStop = False
        Me.pboxTelefonoFallo.Visible = False
        '
        'pboxPoblacionFallo
        '
        Me.pboxPoblacionFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxPoblacionFallo.Location = New System.Drawing.Point(351, 299)
        Me.pboxPoblacionFallo.Name = "pboxPoblacionFallo"
        Me.pboxPoblacionFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxPoblacionFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPoblacionFallo.TabIndex = 34
        Me.pboxPoblacionFallo.TabStop = False
        Me.pboxPoblacionFallo.Visible = False
        '
        'pboxProvinciaFallo
        '
        Me.pboxProvinciaFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxProvinciaFallo.Location = New System.Drawing.Point(351, 254)
        Me.pboxProvinciaFallo.Name = "pboxProvinciaFallo"
        Me.pboxProvinciaFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxProvinciaFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProvinciaFallo.TabIndex = 33
        Me.pboxProvinciaFallo.TabStop = False
        Me.pboxProvinciaFallo.Visible = False
        '
        'pboxAp2Fallo
        '
        Me.pboxAp2Fallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxAp2Fallo.Location = New System.Drawing.Point(351, 136)
        Me.pboxAp2Fallo.Name = "pboxAp2Fallo"
        Me.pboxAp2Fallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxAp2Fallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxAp2Fallo.TabIndex = 32
        Me.pboxAp2Fallo.TabStop = False
        Me.pboxAp2Fallo.Visible = False
        '
        'pboxAp2Acierto
        '
        Me.pboxAp2Acierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxAp2Acierto.Location = New System.Drawing.Point(351, 136)
        Me.pboxAp2Acierto.Name = "pboxAp2Acierto"
        Me.pboxAp2Acierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxAp2Acierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxAp2Acierto.TabIndex = 31
        Me.pboxAp2Acierto.TabStop = False
        Me.pboxAp2Acierto.Visible = False
        '
        'pboxAp1Fallo
        '
        Me.pboxAp1Fallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxAp1Fallo.Location = New System.Drawing.Point(351, 96)
        Me.pboxAp1Fallo.Name = "pboxAp1Fallo"
        Me.pboxAp1Fallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxAp1Fallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxAp1Fallo.TabIndex = 30
        Me.pboxAp1Fallo.TabStop = False
        Me.pboxAp1Fallo.Visible = False
        '
        'pboxAp1Acierto
        '
        Me.pboxAp1Acierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxAp1Acierto.Location = New System.Drawing.Point(351, 96)
        Me.pboxAp1Acierto.Name = "pboxAp1Acierto"
        Me.pboxAp1Acierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxAp1Acierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxAp1Acierto.TabIndex = 29
        Me.pboxAp1Acierto.TabStop = False
        Me.pboxAp1Acierto.Visible = False
        '
        'pboxNombreAcierto
        '
        Me.pboxNombreAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxNombreAcierto.Location = New System.Drawing.Point(351, 55)
        Me.pboxNombreAcierto.Name = "pboxNombreAcierto"
        Me.pboxNombreAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxNombreAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNombreAcierto.TabIndex = 28
        Me.pboxNombreAcierto.TabStop = False
        Me.pboxNombreAcierto.Visible = False
        '
        'pboxNombreFallo
        '
        Me.pboxNombreFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxNombreFallo.Location = New System.Drawing.Point(351, 55)
        Me.pboxNombreFallo.Name = "pboxNombreFallo"
        Me.pboxNombreFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxNombreFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNombreFallo.TabIndex = 27
        Me.pboxNombreFallo.TabStop = False
        Me.pboxNombreFallo.Visible = False
        '
        'frm_Nuevo_Modificar_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 562)
        Me.Controls.Add(Me.pboxComunidadFallo)
        Me.Controls.Add(Me.pboxComunidadAcierto)
        Me.Controls.Add(Me.cboComunidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLC)
        Me.Controls.Add(Me.pboxCPFallo)
        Me.Controls.Add(Me.pboxCPAcierto)
        Me.Controls.Add(Me.cboCodigoPostal)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pboxProvinciaAcierto)
        Me.Controls.Add(Me.pboxPoblacionAcierto)
        Me.Controls.Add(Me.pboxTelefonAcierto)
        Me.Controls.Add(Me.pboxEmailAcierto)
        Me.Controls.Add(Me.pboxDireccionAcierto)
        Me.Controls.Add(Me.pboxDireccionFallo)
        Me.Controls.Add(Me.pboxEmailFallo)
        Me.Controls.Add(Me.pboxTelefonoFallo)
        Me.Controls.Add(Me.pboxPoblacionFallo)
        Me.Controls.Add(Me.pboxProvinciaFallo)
        Me.Controls.Add(Me.pboxAp2Fallo)
        Me.Controls.Add(Me.pboxAp2Acierto)
        Me.Controls.Add(Me.pboxAp1Fallo)
        Me.Controls.Add(Me.pboxAp1Acierto)
        Me.Controls.Add(Me.pboxNombreAcierto)
        Me.Controls.Add(Me.pboxNombreFallo)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboPoblacion)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Nuevo_Modificar_Clientes"
        Me.Text = "Nuevo_Modificar_Clientes"
        CType(Me.pboxComunidadFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxComunidadAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxCPFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxCPAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProvinciaAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPoblacionAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTelefonAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxEmailAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxDireccionAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxDireccionFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxEmailFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTelefonoFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPoblacionFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProvinciaFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxAp2Fallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxAp2Acierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxAp1Fallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxAp1Acierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNombreAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNombreFallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents lblPoblacion As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents cboPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents pboxNombreFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxNombreAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxAp1Acierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxAp1Fallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxAp2Acierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxAp2Fallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxProvinciaFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPoblacionFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxTelefonoFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxEmailFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxDireccionFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxDireccionAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxEmailAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxTelefonAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPoblacionAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxProvinciaAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents cboCodigoPostal As System.Windows.Forms.ComboBox
    Friend WithEvents pboxCPAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxCPFallo As System.Windows.Forms.PictureBox
    Friend WithEvents btnLC As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboComunidades As System.Windows.Forms.ComboBox
    Friend WithEvents pboxComunidadAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxComunidadFallo As System.Windows.Forms.PictureBox
End Class