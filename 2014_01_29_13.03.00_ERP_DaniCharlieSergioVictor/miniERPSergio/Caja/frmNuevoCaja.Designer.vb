<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCaja
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
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.lblProDes = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboProDes = New System.Windows.Forms.ComboBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pboxConceptoAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxConceptoFallo = New System.Windows.Forms.PictureBox()
        Me.pboxFechaAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxFechaFallo = New System.Windows.Forms.PictureBox()
        Me.pboxImporteAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxImporteFallo = New System.Windows.Forms.PictureBox()
        Me.pboxProcedenciaFallo = New System.Windows.Forms.PictureBox()
        Me.pboxProcedenciaAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxTipoAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxTipoFallo = New System.Windows.Forms.PictureBox()
        Me.lblMensajeTipoAccion = New System.Windows.Forms.Label()
        Me.lblTipoProblema = New System.Windows.Forms.Label()
        CType(Me.pboxConceptoAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxConceptoFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFechaAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFechaFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxImporteAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxImporteFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProcedenciaFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxProcedenciaAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTipoAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxTipoFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(12, 45)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(56, 13)
        Me.lblConcepto.TabIndex = 15
        Me.lblConcepto.Text = "Concepto:"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(86, 138)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 20
        '
        'lblProDes
        '
        Me.lblProDes.AutoSize = True
        Me.lblProDes.Location = New System.Drawing.Point(12, 193)
        Me.lblProDes.Name = "lblProDes"
        Me.lblProDes.Size = New System.Drawing.Size(70, 13)
        Me.lblProDes.TabIndex = 17
        Me.lblProDes.Text = "Procedencia:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(74, 42)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(336, 86)
        Me.txtConcepto.TabIndex = 19
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"--Tipo--", "Efectivo", "Cheque", "Recibo"})
        Me.cboTipo.Location = New System.Drawing.Point(86, 217)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(83, 21)
        Me.cboTipo.TabIndex = 23
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(86, 164)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'cboProDes
        '
        Me.cboProDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProDes.FormattingEnabled = True
        Me.cboProDes.Items.AddRange(New Object() {"--Procedencia--", "Venta de productos", "Ingreso directo de administración", "Variacion de saldo", "Varios"})
        Me.cboProDes.Location = New System.Drawing.Point(88, 190)
        Me.cboProDes.Name = "cboProDes"
        Me.cboProDes.Size = New System.Drawing.Size(198, 21)
        Me.cboProDes.TabIndex = 24
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(12, 141)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(45, 13)
        Me.lblImporte.TabIndex = 16
        Me.lblImporte.Text = "Importe:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(12, 220)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 18
        Me.lblTipo.Text = "Tipo:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 170)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 27
        Me.lblFecha.Text = "Fecha:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(15, 263)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 28
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(335, 263)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pboxConceptoAcierto
        '
        Me.pboxConceptoAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxConceptoAcierto.Location = New System.Drawing.Point(416, 42)
        Me.pboxConceptoAcierto.Name = "pboxConceptoAcierto"
        Me.pboxConceptoAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxConceptoAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxConceptoAcierto.TabIndex = 113
        Me.pboxConceptoAcierto.TabStop = False
        Me.pboxConceptoAcierto.Visible = False
        '
        'pboxConceptoFallo
        '
        Me.pboxConceptoFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxConceptoFallo.Location = New System.Drawing.Point(416, 42)
        Me.pboxConceptoFallo.Name = "pboxConceptoFallo"
        Me.pboxConceptoFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxConceptoFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxConceptoFallo.TabIndex = 112
        Me.pboxConceptoFallo.TabStop = False
        Me.pboxConceptoFallo.Visible = False
        '
        'pboxFechaAcierto
        '
        Me.pboxFechaAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxFechaAcierto.Location = New System.Drawing.Point(416, 163)
        Me.pboxFechaAcierto.Name = "pboxFechaAcierto"
        Me.pboxFechaAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxFechaAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxFechaAcierto.TabIndex = 111
        Me.pboxFechaAcierto.TabStop = False
        Me.pboxFechaAcierto.Visible = False
        '
        'pboxFechaFallo
        '
        Me.pboxFechaFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxFechaFallo.Location = New System.Drawing.Point(416, 163)
        Me.pboxFechaFallo.Name = "pboxFechaFallo"
        Me.pboxFechaFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxFechaFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxFechaFallo.TabIndex = 110
        Me.pboxFechaFallo.TabStop = False
        Me.pboxFechaFallo.Visible = False
        '
        'pboxImporteAcierto
        '
        Me.pboxImporteAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxImporteAcierto.Location = New System.Drawing.Point(416, 134)
        Me.pboxImporteAcierto.Name = "pboxImporteAcierto"
        Me.pboxImporteAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxImporteAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxImporteAcierto.TabIndex = 108
        Me.pboxImporteAcierto.TabStop = False
        Me.pboxImporteAcierto.Visible = False
        '
        'pboxImporteFallo
        '
        Me.pboxImporteFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxImporteFallo.Location = New System.Drawing.Point(416, 134)
        Me.pboxImporteFallo.Name = "pboxImporteFallo"
        Me.pboxImporteFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxImporteFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxImporteFallo.TabIndex = 107
        Me.pboxImporteFallo.TabStop = False
        Me.pboxImporteFallo.Visible = False
        '
        'pboxProcedenciaFallo
        '
        Me.pboxProcedenciaFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxProcedenciaFallo.Location = New System.Drawing.Point(416, 187)
        Me.pboxProcedenciaFallo.Name = "pboxProcedenciaFallo"
        Me.pboxProcedenciaFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxProcedenciaFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProcedenciaFallo.TabIndex = 105
        Me.pboxProcedenciaFallo.TabStop = False
        Me.pboxProcedenciaFallo.Visible = False
        '
        'pboxProcedenciaAcierto
        '
        Me.pboxProcedenciaAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxProcedenciaAcierto.Location = New System.Drawing.Point(416, 187)
        Me.pboxProcedenciaAcierto.Name = "pboxProcedenciaAcierto"
        Me.pboxProcedenciaAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxProcedenciaAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxProcedenciaAcierto.TabIndex = 104
        Me.pboxProcedenciaAcierto.TabStop = False
        Me.pboxProcedenciaAcierto.Visible = False
        '
        'pboxTipoAcierto
        '
        Me.pboxTipoAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxTipoAcierto.Location = New System.Drawing.Point(416, 213)
        Me.pboxTipoAcierto.Name = "pboxTipoAcierto"
        Me.pboxTipoAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxTipoAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTipoAcierto.TabIndex = 103
        Me.pboxTipoAcierto.TabStop = False
        Me.pboxTipoAcierto.Visible = False
        '
        'pboxTipoFallo
        '
        Me.pboxTipoFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxTipoFallo.Location = New System.Drawing.Point(416, 213)
        Me.pboxTipoFallo.Name = "pboxTipoFallo"
        Me.pboxTipoFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxTipoFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxTipoFallo.TabIndex = 102
        Me.pboxTipoFallo.TabStop = False
        Me.pboxTipoFallo.Visible = False
        '
        'lblMensajeTipoAccion
        '
        Me.lblMensajeTipoAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeTipoAccion.ForeColor = System.Drawing.Color.Green
        Me.lblMensajeTipoAccion.Location = New System.Drawing.Point(12, 9)
        Me.lblMensajeTipoAccion.Name = "lblMensajeTipoAccion"
        Me.lblMensajeTipoAccion.Size = New System.Drawing.Size(432, 30)
        Me.lblMensajeTipoAccion.TabIndex = 114
        Me.lblMensajeTipoAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoProblema
        '
        Me.lblTipoProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoProblema.ForeColor = System.Drawing.Color.Blue
        Me.lblTipoProblema.Location = New System.Drawing.Point(12, 7)
        Me.lblTipoProblema.Name = "lblTipoProblema"
        Me.lblTipoProblema.Size = New System.Drawing.Size(432, 32)
        Me.lblTipoProblema.TabIndex = 115
        Me.lblTipoProblema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNuevoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 305)
        Me.Controls.Add(Me.lblTipoProblema)
        Me.Controls.Add(Me.lblMensajeTipoAccion)
        Me.Controls.Add(Me.pboxConceptoAcierto)
        Me.Controls.Add(Me.pboxConceptoFallo)
        Me.Controls.Add(Me.pboxFechaAcierto)
        Me.Controls.Add(Me.pboxFechaFallo)
        Me.Controls.Add(Me.pboxImporteAcierto)
        Me.Controls.Add(Me.pboxImporteFallo)
        Me.Controls.Add(Me.pboxProcedenciaFallo)
        Me.Controls.Add(Me.pboxProcedenciaAcierto)
        Me.Controls.Add(Me.pboxTipoAcierto)
        Me.Controls.Add(Me.pboxTipoFallo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblProDes)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.cboProDes)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblTipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNuevoCaja"
        Me.Text = "frmNuevoEntradaSalida"
        CType(Me.pboxConceptoAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxConceptoFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFechaAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFechaFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxImporteAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxImporteFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProcedenciaFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxProcedenciaAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTipoAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxTipoFallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents lblProDes As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboProDes As System.Windows.Forms.ComboBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pboxConceptoAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxConceptoFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxFechaAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxFechaFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxImporteAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxImporteFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxProcedenciaFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxProcedenciaAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxTipoAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxTipoFallo As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensajeTipoAccion As System.Windows.Forms.Label
    Friend WithEvents lblTipoProblema As System.Windows.Forms.Label
End Class
