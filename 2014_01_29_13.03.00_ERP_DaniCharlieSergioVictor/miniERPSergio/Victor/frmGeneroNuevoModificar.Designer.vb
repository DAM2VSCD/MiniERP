<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneroNuevoModificar
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pboxTipoAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxTipoFallo = New System.Windows.Forms.PictureBox()
        CType(Me.pboxTipoAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTipoFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(207, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(25, 64)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(197, 65)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pboxTipoAcierto
        '
        Me.pboxTipoAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxTipoAcierto.Location = New System.Drawing.Point(278, 38)
        Me.pboxTipoAcierto.Name = "pboxTipoAcierto"
        Me.pboxTipoAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxTipoAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTipoAcierto.TabIndex = 20
        Me.pboxTipoAcierto.TabStop = False
        Me.pboxTipoAcierto.Visible = False
        '
        'pboxTipoFallo
        '
        Me.pboxTipoFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxTipoFallo.Location = New System.Drawing.Point(278, 38)
        Me.pboxTipoFallo.Name = "pboxTipoFallo"
        Me.pboxTipoFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxTipoFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTipoFallo.TabIndex = 21
        Me.pboxTipoFallo.TabStop = False
        '
        'frmGeneroNuevoModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 119)
        Me.Controls.Add(Me.pboxTipoFallo)
        Me.Controls.Add(Me.pboxTipoAcierto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGeneroNuevoModificar"
        Me.Text = "frmTiposNuevo"
        CType(Me.pboxTipoAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTipoFallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pboxTipoAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxTipoFallo As System.Windows.Forms.PictureBox
End Class
