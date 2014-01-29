<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Me.btnGuarda = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblErrorUser = New System.Windows.Forms.Label()
        Me.lblErrorPass = New System.Windows.Forms.Label()
        Me.lblErrorPassC = New System.Windows.Forms.Label()
        Me.txtPassC = New System.Windows.Forms.TextBox()
        Me.lblPassConf = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pbErrorUser = New System.Windows.Forms.PictureBox()
        Me.pbErrorPass = New System.Windows.Forms.PictureBox()
        Me.pbOkUser = New System.Windows.Forms.PictureBox()
        Me.pbOkPass = New System.Windows.Forms.PictureBox()
        Me.pbErrorPassC = New System.Windows.Forms.PictureBox()
        Me.pbOkPassC = New System.Windows.Forms.PictureBox()
        CType(Me.pbErrorUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOkUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOkPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbErrorPassC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOkPassC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'btnGuarda
        '
        Me.btnGuarda.Location = New System.Drawing.Point(164, 291)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(75, 23)
        Me.btnGuarda.TabIndex = 1
        Me.btnGuarda.Text = "Guardar"
        Me.btnGuarda.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(364, 291)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(304, 29)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(135, 20)
        Me.txtUser.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(304, 112)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(135, 20)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'lblErrorUser
        '
        Me.lblErrorUser.AutoSize = True
        Me.lblErrorUser.Location = New System.Drawing.Point(311, 57)
        Me.lblErrorUser.Name = "lblErrorUser"
        Me.lblErrorUser.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorUser.TabIndex = 6
        '
        'lblErrorPass
        '
        Me.lblErrorPass.AutoSize = True
        Me.lblErrorPass.Location = New System.Drawing.Point(311, 146)
        Me.lblErrorPass.Name = "lblErrorPass"
        Me.lblErrorPass.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorPass.TabIndex = 7
        '
        'lblErrorPassC
        '
        Me.lblErrorPassC.AutoSize = True
        Me.lblErrorPassC.Location = New System.Drawing.Point(311, 230)
        Me.lblErrorPassC.Name = "lblErrorPassC"
        Me.lblErrorPassC.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorPassC.TabIndex = 10
        '
        'txtPassC
        '
        Me.txtPassC.Location = New System.Drawing.Point(304, 197)
        Me.txtPassC.Name = "txtPassC"
        Me.txtPassC.Size = New System.Drawing.Size(135, 20)
        Me.txtPassC.TabIndex = 9
        Me.txtPassC.UseSystemPasswordChar = True
        '
        'lblPassConf
        '
        Me.lblPassConf.AutoSize = True
        Me.lblPassConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassConf.Location = New System.Drawing.Point(161, 201)
        Me.lblPassConf.Name = "lblPassConf"
        Me.lblPassConf.Size = New System.Drawing.Size(137, 16)
        Me.lblPassConf.TabIndex = 8
        Me.lblPassConf.Text = "Confirmar Contraseña"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 32)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(47, 17)
        Me.lblInfo.TabIndex = 11
        Me.lblInfo.Text = "Label3"
        '
        'pbErrorUser
        '
        Me.pbErrorUser.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorUser.Location = New System.Drawing.Point(449, 29)
        Me.pbErrorUser.Name = "pbErrorUser"
        Me.pbErrorUser.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorUser.TabIndex = 12
        Me.pbErrorUser.TabStop = False
        '
        'pbErrorPass
        '
        Me.pbErrorPass.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorPass.Location = New System.Drawing.Point(449, 112)
        Me.pbErrorPass.Name = "pbErrorPass"
        Me.pbErrorPass.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorPass.TabIndex = 13
        Me.pbErrorPass.TabStop = False
        '
        'pbOkUser
        '
        Me.pbOkUser.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkUser.Location = New System.Drawing.Point(449, 29)
        Me.pbOkUser.Name = "pbOkUser"
        Me.pbOkUser.Size = New System.Drawing.Size(20, 20)
        Me.pbOkUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkUser.TabIndex = 14
        Me.pbOkUser.TabStop = False
        Me.pbOkUser.Visible = False
        '
        'pbOkPass
        '
        Me.pbOkPass.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkPass.Location = New System.Drawing.Point(449, 112)
        Me.pbOkPass.Name = "pbOkPass"
        Me.pbOkPass.Size = New System.Drawing.Size(20, 20)
        Me.pbOkPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkPass.TabIndex = 15
        Me.pbOkPass.TabStop = False
        Me.pbOkPass.Visible = False
        '
        'pbErrorPassC
        '
        Me.pbErrorPassC.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbErrorPassC.Location = New System.Drawing.Point(449, 197)
        Me.pbErrorPassC.Name = "pbErrorPassC"
        Me.pbErrorPassC.Size = New System.Drawing.Size(20, 20)
        Me.pbErrorPassC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbErrorPassC.TabIndex = 16
        Me.pbErrorPassC.TabStop = False
        '
        'pbOkPassC
        '
        Me.pbOkPassC.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbOkPassC.Location = New System.Drawing.Point(449, 197)
        Me.pbOkPassC.Name = "pbOkPassC"
        Me.pbOkPassC.Size = New System.Drawing.Size(20, 20)
        Me.pbOkPassC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOkPassC.TabIndex = 17
        Me.pbOkPassC.TabStop = False
        Me.pbOkPassC.Visible = False
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 326)
        Me.Controls.Add(Me.pbOkPassC)
        Me.Controls.Add(Me.pbErrorPassC)
        Me.Controls.Add(Me.pbOkPass)
        Me.Controls.Add(Me.pbOkUser)
        Me.Controls.Add(Me.pbErrorPass)
        Me.Controls.Add(Me.pbErrorUser)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblErrorPassC)
        Me.Controls.Add(Me.txtPassC)
        Me.Controls.Add(Me.lblPassConf)
        Me.Controls.Add(Me.lblErrorPass)
        Me.Controls.Add(Me.lblErrorUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNewUser"
        Me.Text = "Nuevo Usuario"
        CType(Me.pbErrorUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOkUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOkPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbErrorPassC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOkPassC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorUser As System.Windows.Forms.Label
    Friend WithEvents lblErrorPass As System.Windows.Forms.Label
    Friend WithEvents lblErrorPassC As System.Windows.Forms.Label
    Friend WithEvents txtPassC As System.Windows.Forms.TextBox
    Friend WithEvents lblPassConf As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents pbErrorUser As System.Windows.Forms.PictureBox
    Friend WithEvents pbErrorPass As System.Windows.Forms.PictureBox
    Friend WithEvents pbOkUser As System.Windows.Forms.PictureBox
    Friend WithEvents pbOkPass As System.Windows.Forms.PictureBox
    Friend WithEvents pbErrorPassC As System.Windows.Forms.PictureBox
    Friend WithEvents pbOkPassC As System.Windows.Forms.PictureBox
End Class
