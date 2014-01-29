<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambios
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
        Me.dgvCambios = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        CType(Me.dgvCambios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCambios
        '
        Me.dgvCambios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCambios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.Nombre, Me.Fecha, Me.Descripción})
        Me.dgvCambios.Location = New System.Drawing.Point(12, 80)
        Me.dgvCambios.Name = "dgvCambios"
        Me.dgvCambios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvCambios.Size = New System.Drawing.Size(617, 397)
        Me.dgvCambios.TabIndex = 0
        '
        'numero
        '
        Me.numero.HeaderText = "Numero"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(57, 54)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(81, 20)
        Me.txtNumero.TabIndex = 1
        '
        'cboUsuario
        '
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(144, 54)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(170, 21)
        Me.cboUsuario.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(320, 55)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(195, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'cbFecha
        '
        Me.cbFecha.AutoSize = True
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.Location = New System.Drawing.Point(320, 32)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(130, 22)
        Me.cbFecha.TabIndex = 4
        Me.cbFecha.Text = "Filtrar por fecha"
        Me.cbFecha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Usuario:"
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(554, 22)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(75, 52)
        Me.btnGenerarXML.TabIndex = 29
        Me.btnGenerarXML.Text = "Generar XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'frmCambios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 489)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.dgvCambios)
        Me.Name = "frmCambios"
        Me.Text = "Cambios"
        CType(Me.dgvCambios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCambios As System.Windows.Forms.DataGridView
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarXML As System.Windows.Forms.Button
End Class
