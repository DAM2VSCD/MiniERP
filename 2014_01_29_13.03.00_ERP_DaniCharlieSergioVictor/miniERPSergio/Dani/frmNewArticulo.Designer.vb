<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewArticulo
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
        Me.lblNumArt = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbTipoArt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnGuarda = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblErrorNombre = New System.Windows.Forms.Label()
        Me.lblErrorStock = New System.Windows.Forms.Label()
        Me.pbOkNombre = New System.Windows.Forms.PictureBox()
        Me.pbOkPrecio = New System.Windows.Forms.PictureBox()
        Me.pbOkStock = New System.Windows.Forms.PictureBox()
        Me.pbOkTipo = New System.Windows.Forms.PictureBox()
        Me.pbErrorNombre = New System.Windows.Forms.PictureBox()
        Me.pbErrorTipo = New System.Windows.Forms.PictureBox()
        Me.pbErrorPrecio = New System.Windows.Forms.PictureBox()
        Me.pbErrorStock = New System.Windows.Forms.PictureBox()
        Me.lblErrorPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblErrorArtic = New System.Windows.Forms.Label()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbOkNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOkPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOkStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOkTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumArt
        '
        Me.lblNumArt.AutoSize = True
        Me.lblNumArt.Location = New System.Drawing.Point(148, 40)
        Me.lblNumArt.Name = "lblNumArt"
        Me.lblNumArt.Size = New System.Drawing.Size(72, 13)
        Me.lblNumArt.TabIndex = 0
        Me.lblNumArt.Text = "Núm. Artículo"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(235, 37)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(148, 80)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(148, 143)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(235, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(188, 20)
        Me.txtNombre.TabIndex = 4
        '
        'cmbTipoArt
        '
        Me.cmbTipoArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoArt.FormattingEnabled = True
        Me.cmbTipoArt.Location = New System.Drawing.Point(235, 140)
        Me.cmbTipoArt.Name = "cmbTipoArt"
        Me.cmbTipoArt.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoArt.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Precio"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(148, 237)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(35, 13)
        Me.lblStock.TabIndex = 8
        Me.lblStock.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(235, 234)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 9
        '
        'btnGuarda
        '
        Me.btnGuarda.Location = New System.Drawing.Point(151, 439)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(75, 23)
        Me.btnGuarda.TabIndex = 10
        Me.btnGuarda.Text = "Guardar"
        Me.btnGuarda.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(348, 439)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(23, 50)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(47, 17)
        Me.lblInfo.TabIndex = 12
        Me.lblInfo.Text = "Label3"
        '
        'lblErrorNombre
        '
        Me.lblErrorNombre.AutoSize = True
        Me.lblErrorNombre.Location = New System.Drawing.Point(232, 113)
        Me.lblErrorNombre.Name = "lblErrorNombre"
        Me.lblErrorNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorNombre.TabIndex = 14
        '
        'lblErrorStock
        '
        Me.lblErrorStock.AutoSize = True
        Me.lblErrorStock.Location = New System.Drawing.Point(232, 308)
        Me.lblErrorStock.Name = "lblErrorStock"
        Me.lblErrorStock.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorStock.TabIndex = 17
        '
        'pbOkNombre
        '
        Me.pbOkNombre.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkNombre.Location = New System.Drawing.Point(440, 77)
        Me.pbOkNombre.Name = "pbOkNombre"
        Me.pbOkNombre.Size = New System.Drawing.Size(20, 20)
        Me.pbOkNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkNombre.TabIndex = 18
        Me.pbOkNombre.TabStop = False
        Me.pbOkNombre.Visible = False
        '
        'pbOkPrecio
        '
        Me.pbOkPrecio.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkPrecio.Location = New System.Drawing.Point(440, 180)
        Me.pbOkPrecio.Name = "pbOkPrecio"
        Me.pbOkPrecio.Size = New System.Drawing.Size(20, 20)
        Me.pbOkPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkPrecio.TabIndex = 19
        Me.pbOkPrecio.TabStop = False
        Me.pbOkPrecio.Visible = False
        '
        'pbOkStock
        '
        Me.pbOkStock.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkStock.Location = New System.Drawing.Point(440, 234)
        Me.pbOkStock.Name = "pbOkStock"
        Me.pbOkStock.Size = New System.Drawing.Size(20, 20)
        Me.pbOkStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkStock.TabIndex = 20
        Me.pbOkStock.TabStop = False
        Me.pbOkStock.Visible = False
        '
        'pbOkTipo
        '
        Me.pbOkTipo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkTipo.Location = New System.Drawing.Point(440, 140)
        Me.pbOkTipo.Name = "pbOkTipo"
        Me.pbOkTipo.Size = New System.Drawing.Size(20, 20)
        Me.pbOkTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkTipo.TabIndex = 21
        Me.pbOkTipo.TabStop = False
        Me.pbOkTipo.Visible = False
        '
        'pbErrorNombre
        '
        Me.pbErrorNombre.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorNombre.Location = New System.Drawing.Point(440, 77)
        Me.pbErrorNombre.Name = "pbErrorNombre"
        Me.pbErrorNombre.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorNombre.TabIndex = 22
        Me.pbErrorNombre.TabStop = False
        '
        'pbErrorTipo
        '
        Me.pbErrorTipo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorTipo.Location = New System.Drawing.Point(440, 140)
        Me.pbErrorTipo.Name = "pbErrorTipo"
        Me.pbErrorTipo.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorTipo.TabIndex = 23
        Me.pbErrorTipo.TabStop = False
        '
        'pbErrorPrecio
        '
        Me.pbErrorPrecio.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorPrecio.Location = New System.Drawing.Point(440, 180)
        Me.pbErrorPrecio.Name = "pbErrorPrecio"
        Me.pbErrorPrecio.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorPrecio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorPrecio.TabIndex = 24
        Me.pbErrorPrecio.TabStop = False
        '
        'pbErrorStock
        '
        Me.pbErrorStock.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorStock.Location = New System.Drawing.Point(440, 234)
        Me.pbErrorStock.Name = "pbErrorStock"
        Me.pbErrorStock.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorStock.TabIndex = 25
        Me.pbErrorStock.TabStop = False
        '
        'lblErrorPrecio
        '
        Me.lblErrorPrecio.AutoSize = True
        Me.lblErrorPrecio.Location = New System.Drawing.Point(232, 209)
        Me.lblErrorPrecio.Name = "lblErrorPrecio"
        Me.lblErrorPrecio.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorPrecio.TabIndex = 16
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(235, 177)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'lblErrorArtic
        '
        Me.lblErrorArtic.AutoSize = True
        Me.lblErrorArtic.ForeColor = System.Drawing.Color.Red
        Me.lblErrorArtic.Location = New System.Drawing.Point(232, 394)
        Me.lblErrorArtic.Name = "lblErrorArtic"
        Me.lblErrorArtic.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorArtic.TabIndex = 34
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.proveedor, Me.articulo, Me.idProveedor})
        Me.dgvProveedor.Location = New System.Drawing.Point(23, 273)
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.RowHeadersVisible = False
        Me.dgvProveedor.Size = New System.Drawing.Size(437, 146)
        Me.dgvProveedor.TabIndex = 38
        '
        'proveedor
        '
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        '
        'articulo
        '
        Me.articulo.HeaderText = "Articulo proveedor"
        Me.articulo.Name = "articulo"
        Me.articulo.ReadOnly = True
        '
        'idProveedor
        '
        Me.idProveedor.HeaderText = "Precio proveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        '
        'frmNewArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 501)
        Me.Controls.Add(Me.dgvProveedor)
        Me.Controls.Add(Me.lblErrorArtic)
        Me.Controls.Add(Me.pbErrorStock)
        Me.Controls.Add(Me.pbErrorPrecio)
        Me.Controls.Add(Me.pbErrorTipo)
        Me.Controls.Add(Me.pbErrorNombre)
        Me.Controls.Add(Me.pbOkTipo)
        Me.Controls.Add(Me.pbOkStock)
        Me.Controls.Add(Me.pbOkPrecio)
        Me.Controls.Add(Me.pbOkNombre)
        Me.Controls.Add(Me.lblErrorStock)
        Me.Controls.Add(Me.lblErrorPrecio)
        Me.Controls.Add(Me.lblErrorNombre)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoArt)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblNumArt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewArticulo"
        CType(Me.pbOkNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOkPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOkStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOkTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumArt As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoArt As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblErrorNombre As System.Windows.Forms.Label
    Friend WithEvents lblErrorStock As System.Windows.Forms.Label
    Friend WithEvents pbOkNombre As System.Windows.Forms.PictureBox
    Friend WithEvents pbOkPrecio As System.Windows.Forms.PictureBox
    Friend WithEvents pbOkStock As System.Windows.Forms.PictureBox
    Friend WithEvents pbOkTipo As System.Windows.Forms.PictureBox
    Friend WithEvents pbErrorNombre As System.Windows.Forms.PictureBox
    Friend WithEvents pbErrorTipo As System.Windows.Forms.PictureBox
    Friend WithEvents pbErrorPrecio As System.Windows.Forms.PictureBox
    Friend WithEvents pbErrorStock As System.Windows.Forms.PictureBox
    Friend WithEvents lblErrorPrecio As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorArtic As System.Windows.Forms.Label
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
