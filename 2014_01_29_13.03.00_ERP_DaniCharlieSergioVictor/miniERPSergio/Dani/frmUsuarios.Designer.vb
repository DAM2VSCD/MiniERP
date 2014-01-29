<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnElimina = New System.Windows.Forms.Button()
        Me.btnRestaura = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLisCamb = New System.Windows.Forms.Button()
        Me.lblErrorBusca = New System.Windows.Forms.Label()
        Me.jcbTipoUser = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(38, 75)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(109, 16)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Filtro por nombre"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(44, 100)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(140, 20)
        Me.txtUser.TabIndex = 1
        '
        'dgvUser
        '
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUser.Location = New System.Drawing.Point(41, 159)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(196, 266)
        Me.dgvUser.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(259, 159)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(259, 197)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(75, 23)
        Me.btnModif.TabIndex = 5
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnElimina
        '
        Me.btnElimina.Location = New System.Drawing.Point(259, 235)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(75, 23)
        Me.btnElimina.TabIndex = 6
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.UseVisualStyleBackColor = True
        '
        'btnRestaura
        '
        Me.btnRestaura.Enabled = False
        Me.btnRestaura.Location = New System.Drawing.Point(259, 290)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(75, 23)
        Me.btnRestaura.TabIndex = 7
        Me.btnRestaura.Text = "Restaurar"
        Me.btnRestaura.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(259, 402)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLisCamb
        '
        Me.btnLisCamb.Location = New System.Drawing.Point(259, 341)
        Me.btnLisCamb.Name = "btnLisCamb"
        Me.btnLisCamb.Size = New System.Drawing.Size(75, 41)
        Me.btnLisCamb.TabIndex = 9
        Me.btnLisCamb.Text = "Lista Cambios"
        Me.btnLisCamb.UseVisualStyleBackColor = True
        '
        'lblErrorBusca
        '
        Me.lblErrorBusca.AutoSize = True
        Me.lblErrorBusca.Location = New System.Drawing.Point(203, 103)
        Me.lblErrorBusca.Name = "lblErrorBusca"
        Me.lblErrorBusca.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorBusca.TabIndex = 10
        '
        'jcbTipoUser
        '
        Me.jcbTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbTipoUser.FormattingEnabled = True
        Me.jcbTipoUser.Items.AddRange(New Object() {"Usuarios Activos", "Usuarios Eliminados"})
        Me.jcbTipoUser.Location = New System.Drawing.Point(44, 41)
        Me.jcbTipoUser.Name = "jcbTipoUser"
        Me.jcbTipoUser.Size = New System.Drawing.Size(196, 21)
        Me.jcbTipoUser.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Activo / Eliminado"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 454)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jcbTipoUser)
        Me.Controls.Add(Me.lblErrorBusca)
        Me.Controls.Add(Me.btnLisCamb)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRestaura)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.Text = "Usuarios"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnElimina As System.Windows.Forms.Button
    Friend WithEvents btnRestaura As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLisCamb As System.Windows.Forms.Button
    Friend WithEvents lblErrorBusca As System.Windows.Forms.Label
    Friend WithEvents jcbTipoUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
