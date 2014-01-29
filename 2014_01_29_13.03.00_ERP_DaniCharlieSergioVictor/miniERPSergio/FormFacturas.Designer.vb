<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFacturas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAniadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.NFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ineto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Itotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTIÓN DE FACTURACIÓN"
        '
        'btnAniadir
        '
        Me.btnAniadir.Location = New System.Drawing.Point(21, 68)
        Me.btnAniadir.Name = "btnAniadir"
        Me.btnAniadir.Size = New System.Drawing.Size(75, 44)
        Me.btnAniadir.TabIndex = 1
        Me.btnAniadir.Text = "Añadir Factura"
        Me.btnAniadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(128, 68)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 44)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar Factura"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(232, 68)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 44)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar Factura"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(339, 68)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 44)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir Factura"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(474, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña:"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(544, 81)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(147, 20)
        Me.txtContrasenia.TabIndex = 6
        '
        'dgvFacturas
        '
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NFactura, Me.fecha, Me.cliente, Me.Ineto, Me.Itotal})
        Me.dgvFacturas.Location = New System.Drawing.Point(21, 118)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.Size = New System.Drawing.Size(670, 327)
        Me.dgvFacturas.TabIndex = 7
        '
        'NFactura
        '
        Me.NFactura.HeaderText = "Nº de Factura"
        Me.NFactura.Name = "NFactura"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha Factura"
        Me.fecha.Name = "fecha"
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        '
        'Ineto
        '
        Me.Ineto.HeaderText = "Importe Neto"
        Me.Ineto.Name = "Ineto"
        '
        'Itotal
        '
        Me.Itotal.HeaderText = "Importe Total"
        Me.Itotal.Name = "Itotal"
        '
        'FormFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 457)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAniadir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormFacturas"
        Me.Text = "Control de Facturas"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAniadir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents NFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ineto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Itotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
