<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenero
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgvTipos = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cboEliminados = New System.Windows.Forms.ComboBox()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        CType(Me.dgvTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(71, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(178, 20)
        Me.txtNombre.TabIndex = 0
        '
        'dgvTipos
        '
        Me.dgvTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipos.Location = New System.Drawing.Point(12, 70)
        Me.dgvTipos.Name = "dgvTipos"
        Me.dgvTipos.Size = New System.Drawing.Size(237, 215)
        Me.dgvTipos.TabIndex = 1
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(93, 291)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(93, 320)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(174, 291)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(174, 320)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre:"
        '
        'cboEliminados
        '
        Me.cboEliminados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEliminados.FormattingEnabled = True
        Me.cboEliminados.Items.AddRange(New Object() {"Ver NO eliminados", "Ver ELIMINADOS"})
        Me.cboEliminados.Location = New System.Drawing.Point(71, 38)
        Me.cboEliminados.Name = "cboEliminados"
        Me.cboEliminados.Size = New System.Drawing.Size(178, 21)
        Me.cboEliminados.TabIndex = 7
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(12, 291)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(75, 52)
        Me.btnGenerarXML.TabIndex = 29
        Me.btnGenerarXML.Text = "Generar XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'frmGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 355)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.cboEliminados)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvTipos)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGenero"
        Me.Text = "Generos"
        CType(Me.dgvTipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents dgvTipos As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cboEliminados As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerarXML As System.Windows.Forms.Button
End Class
