<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Clientes
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pobliacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Filtros = New System.Windows.Forms.Panel()
        Me.btnLC = New System.Windows.Forms.Button()
        Me.lblActElm = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(20, 53)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(20, 90)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido1.TabIndex = 1
        Me.lblApellido1.Text = "Apellido1"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(20, 128)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(50, 13)
        Me.lblApellido2.TabIndex = 2
        Me.lblApellido2.Text = "Apellido2"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcliente, Me.numCliente, Me.Nombre, Me.Apellido1, Me.apellido2, Me.Direccion, Me.Pobliacion, Me.mail, Me.tel})
        Me.dgvClientes.Location = New System.Drawing.Point(12, 217)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(642, 166)
        Me.dgvClientes.TabIndex = 3
        '
        'idcliente
        '
        Me.idcliente.HeaderText = "idcliente"
        Me.idcliente.Name = "idcliente"
        '
        'numCliente
        '
        Me.numCliente.HeaderText = "Numero Cliente"
        Me.numCliente.Name = "numCliente"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellido1
        '
        Me.Apellido1.HeaderText = "Apellido1"
        Me.Apellido1.Name = "Apellido1"
        '
        'apellido2
        '
        Me.apellido2.HeaderText = "Apellido2"
        Me.apellido2.Name = "apellido2"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'Pobliacion
        '
        Me.Pobliacion.HeaderText = "Poblacion"
        Me.Pobliacion.Name = "Pobliacion"
        '
        'mail
        '
        Me.mail.HeaderText = "Mail"
        Me.mail.Name = "mail"
        '
        'tel
        '
        Me.tel.HeaderText = "Telefono"
        Me.tel.Name = "tel"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(56, 407)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(181, 407)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(67, 23)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Location = New System.Drawing.Point(419, 407)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(67, 23)
        Me.btnRecuperar.TabIndex = 6
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(535, 407)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(111, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(274, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(111, 125)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(274, 20)
        Me.txtApellido2.TabIndex = 9
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(111, 87)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(274, 20)
        Me.txtApellido1.TabIndex = 10
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(305, 407)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(67, 23)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Activos", "Eliminados"})
        Me.cboTipo.Location = New System.Drawing.Point(502, 174)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(100, 21)
        Me.cboTipo.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Numero"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(111, 14)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(274, 20)
        Me.txtNumero.TabIndex = 18
        '
        'Filtros
        '
        Me.Filtros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Filtros.Controls.Add(Me.txtNumero)
        Me.Filtros.Controls.Add(Me.Label1)
        Me.Filtros.Controls.Add(Me.txtApellido1)
        Me.Filtros.Controls.Add(Me.txtApellido2)
        Me.Filtros.Controls.Add(Me.txtNombre)
        Me.Filtros.Controls.Add(Me.lblApellido2)
        Me.Filtros.Controls.Add(Me.lblApellido1)
        Me.Filtros.Controls.Add(Me.lblNombre)
        Me.Filtros.Location = New System.Drawing.Point(56, 37)
        Me.Filtros.Name = "Filtros"
        Me.Filtros.Size = New System.Drawing.Size(409, 158)
        Me.Filtros.TabIndex = 19
        Me.Filtros.Tag = ""
        '
        'btnLC
        '
        Me.btnLC.Location = New System.Drawing.Point(498, 37)
        Me.btnLC.Name = "btnLC"
        Me.btnLC.Size = New System.Drawing.Size(75, 52)
        Me.btnLC.TabIndex = 20
        Me.btnLC.Text = "Lista de Cambios"
        Me.btnLC.UseVisualStyleBackColor = True
        '
        'lblActElm
        '
        Me.lblActElm.AutoSize = True
        Me.lblActElm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActElm.Location = New System.Drawing.Point(499, 141)
        Me.lblActElm.Name = "lblActElm"
        Me.lblActElm.Size = New System.Drawing.Size(115, 16)
        Me.lblActElm.TabIndex = 21
        Me.lblActElm.Text = "Activo / Eliminado"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(64, 9)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(37, 16)
        Me.lbltipo.TabIndex = 22
        Me.lbltipo.Text = "Filtro"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(535, 408)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(67, 23)
        Me.btnAceptar.TabIndex = 28
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(579, 36)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(75, 52)
        Me.btnGenerarXML.TabIndex = 29
        Me.btnGenerarXML.Text = "Generar XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'frm_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 469)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.lblActElm)
        Me.Controls.Add(Me.btnLC)
        Me.Controls.Add(Me.Filtros)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Filtros.ResumeLayout(False)
        Me.Filtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Filtros As System.Windows.Forms.Panel
    Friend WithEvents btnLC As System.Windows.Forms.Button
    Friend WithEvents lblActElm As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents idcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pobliacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGenerarXML As System.Windows.Forms.Button

End Class