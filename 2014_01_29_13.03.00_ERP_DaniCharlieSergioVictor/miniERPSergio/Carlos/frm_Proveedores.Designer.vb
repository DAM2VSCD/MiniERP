<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proveedores
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
        Me.lblCIFNIF = New System.Windows.Forms.Label()
        Me.txtCIFNIF = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Población = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblActElm = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.btnLC = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCIFNIF
        '
        Me.lblCIFNIF.AutoSize = True
        Me.lblCIFNIF.Location = New System.Drawing.Point(33, 24)
        Me.lblCIFNIF.Name = "lblCIFNIF"
        Me.lblCIFNIF.Size = New System.Drawing.Size(51, 13)
        Me.lblCIFNIF.TabIndex = 0
        Me.lblCIFNIF.Text = "CIF / NIF"
        '
        'txtCIFNIF
        '
        Me.txtCIFNIF.Location = New System.Drawing.Point(90, 21)
        Me.txtCIFNIF.Name = "txtCIFNIF"
        Me.txtCIFNIF.Size = New System.Drawing.Size(167, 20)
        Me.txtCIFNIF.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(40, 55)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtNombre.TabIndex = 3
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(40, 87)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(90, 87)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(167, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'dgvProveedores
        '
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.numCliente, Me.Nombre, Me.Población, Me.Apellido1, Me.tel})
        Me.dgvProveedores.Location = New System.Drawing.Point(43, 144)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.Size = New System.Drawing.Size(643, 177)
        Me.dgvProveedores.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        '
        'numCliente
        '
        Me.numCliente.HeaderText = "CIF / NIF"
        Me.numCliente.Name = "numCliente"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Población
        '
        Me.Población.HeaderText = "Población"
        Me.Población.Name = "Población"
        '
        'Apellido1
        '
        Me.Apellido1.HeaderText = "Direccion"
        Me.Apellido1.Name = "Apellido1"
        '
        'tel
        '
        Me.tel.HeaderText = "Telefono"
        Me.tel.Name = "tel"
        '
        'lblActElm
        '
        Me.lblActElm.AutoSize = True
        Me.lblActElm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActElm.Location = New System.Drawing.Point(346, 38)
        Me.lblActElm.Name = "lblActElm"
        Me.lblActElm.Size = New System.Drawing.Size(115, 16)
        Me.lblActElm.TabIndex = 23
        Me.lblActElm.Text = "Activo / Eliminado"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Activos", "Eliminados"})
        Me.cboTipo.Location = New System.Drawing.Point(361, 69)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(100, 21)
        Me.cboTipo.TabIndex = 22
        '
        'btnLC
        '
        Me.btnLC.Location = New System.Drawing.Point(509, 38)
        Me.btnLC.Name = "btnLC"
        Me.btnLC.Size = New System.Drawing.Size(75, 52)
        Me.btnLC.TabIndex = 24
        Me.btnLC.Text = "Lista de Cambios"
        Me.btnLC.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(619, 355)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(67, 23)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(322, 355)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(67, 23)
        Me.btnBorrar.TabIndex = 33
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(619, 355)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 23)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Location = New System.Drawing.Point(468, 355)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(67, 23)
        Me.btnRecuperar.TabIndex = 31
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(178, 355)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(67, 23)
        Me.btnModificar.TabIndex = 30
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(43, 355)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 23)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(611, 38)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(75, 52)
        Me.btnGenerarXML.TabIndex = 35
        Me.btnGenerarXML.Text = "Generar XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 417)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnLC)
        Me.Controls.Add(Me.lblActElm)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.dgvProveedores)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCIFNIF)
        Me.Controls.Add(Me.lblCIFNIF)
        Me.Name = "frm_Proveedores"
        Me.Text = "Proveedores"
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCIFNIF As System.Windows.Forms.Label
    Friend WithEvents txtCIFNIF As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents lblActElm As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnLC As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Población As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGenerarXML As System.Windows.Forms.Button
End Class
