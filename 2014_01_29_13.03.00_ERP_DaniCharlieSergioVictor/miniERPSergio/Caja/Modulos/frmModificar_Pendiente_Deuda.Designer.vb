<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificar_Pendiente_Deuda
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnRealizarCambio = New System.Windows.Forms.Button()
        Me.lblTipoOperacion = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.pboxImporteAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxImporteFallo = New System.Windows.Forms.PictureBox()
        Me.lblImporteActual = New System.Windows.Forms.Label()
        Me.txtImporteActual = New System.Windows.Forms.TextBox()
        Me.lblAvisos = New System.Windows.Forms.Label()
        CType(Me.pboxImporteAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxImporteFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(272, 137)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRealizarCambio
        '
        Me.btnRealizarCambio.Location = New System.Drawing.Point(36, 137)
        Me.btnRealizarCambio.Name = "btnRealizarCambio"
        Me.btnRealizarCambio.Size = New System.Drawing.Size(75, 23)
        Me.btnRealizarCambio.TabIndex = 24
        Me.btnRealizarCambio.Text = "Confirmar"
        Me.btnRealizarCambio.UseVisualStyleBackColor = True
        '
        'lblTipoOperacion
        '
        Me.lblTipoOperacion.AutoSize = True
        Me.lblTipoOperacion.Location = New System.Drawing.Point(33, 76)
        Me.lblTipoOperacion.Name = "lblTipoOperacion"
        Me.lblTipoOperacion.Size = New System.Drawing.Size(101, 13)
        Me.lblTipoOperacion.TabIndex = 23
        Me.lblTipoOperacion.Text = "Cantidad a ingresar:"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(156, 73)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(137, 20)
        Me.txtImporte.TabIndex = 22
        '
        'pboxImporteAcierto
        '
        Me.pboxImporteAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxImporteAcierto.Location = New System.Drawing.Point(338, 73)
        Me.pboxImporteAcierto.Name = "pboxImporteAcierto"
        Me.pboxImporteAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxImporteAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxImporteAcierto.TabIndex = 27
        Me.pboxImporteAcierto.TabStop = False
        Me.pboxImporteAcierto.Visible = False
        '
        'pboxImporteFallo
        '
        Me.pboxImporteFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxImporteFallo.Location = New System.Drawing.Point(299, 73)
        Me.pboxImporteFallo.Name = "pboxImporteFallo"
        Me.pboxImporteFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxImporteFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxImporteFallo.TabIndex = 26
        Me.pboxImporteFallo.TabStop = False
        '
        'lblImporteActual
        '
        Me.lblImporteActual.AutoSize = True
        Me.lblImporteActual.Location = New System.Drawing.Point(33, 36)
        Me.lblImporteActual.Name = "lblImporteActual"
        Me.lblImporteActual.Size = New System.Drawing.Size(87, 13)
        Me.lblImporteActual.TabIndex = 29
        Me.lblImporteActual.Text = "Montante actual:"
        '
        'txtImporteActual
        '
        Me.txtImporteActual.Enabled = False
        Me.txtImporteActual.Location = New System.Drawing.Point(156, 33)
        Me.txtImporteActual.Name = "txtImporteActual"
        Me.txtImporteActual.Size = New System.Drawing.Size(137, 20)
        Me.txtImporteActual.TabIndex = 28
        '
        'lblAvisos
        '
        Me.lblAvisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvisos.ForeColor = System.Drawing.Color.Red
        Me.lblAvisos.Location = New System.Drawing.Point(33, 108)
        Me.lblAvisos.Name = "lblAvisos"
        Me.lblAvisos.Size = New System.Drawing.Size(325, 26)
        Me.lblAvisos.TabIndex = 30
        Me.lblAvisos.Text = "Texto inicial"
        Me.lblAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmModificar_Pendiente_Deuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 172)
        Me.Controls.Add(Me.lblAvisos)
        Me.Controls.Add(Me.lblImporteActual)
        Me.Controls.Add(Me.txtImporteActual)
        Me.Controls.Add(Me.pboxImporteAcierto)
        Me.Controls.Add(Me.pboxImporteFallo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRealizarCambio)
        Me.Controls.Add(Me.lblTipoOperacion)
        Me.Controls.Add(Me.txtImporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModificar_Pendiente_Deuda"
        Me.Text = "frmModificar_Pendiente_Deuda"
        CType(Me.pboxImporteAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxImporteFallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboxImporteFallo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnRealizarCambio As System.Windows.Forms.Button
    Friend WithEvents lblTipoOperacion As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents pboxImporteAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents lblImporteActual As System.Windows.Forms.Label
    Friend WithEvents txtImporteActual As System.Windows.Forms.TextBox
    Friend WithEvents lblAvisos As System.Windows.Forms.Label
End Class
