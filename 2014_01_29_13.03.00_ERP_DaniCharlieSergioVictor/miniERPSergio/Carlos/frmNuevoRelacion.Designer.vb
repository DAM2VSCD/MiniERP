<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoRelacion
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtArt = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.pboxNombreAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxNombreFallo = New System.Windows.Forms.PictureBox()
        Me.pboxPrecioAcierto = New System.Windows.Forms.PictureBox()
        Me.pboxPrecioFallo = New System.Windows.Forms.PictureBox()
        CType(Me.pboxNombreAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxNombreFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPrecioAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxPrecioFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre articulo proveedor:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio articulo proveedor:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(150, 77)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 111)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(277, 111)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Articulo:"
        '
        'txtArt
        '
        Me.txtArt.Enabled = False
        Me.txtArt.Location = New System.Drawing.Point(150, 17)
        Me.txtArt.Name = "txtArt"
        Me.txtArt.Size = New System.Drawing.Size(208, 20)
        Me.txtArt.TabIndex = 7
        '
        'txtNum
        '
        Me.txtNum.Enabled = False
        Me.txtNum.Location = New System.Drawing.Point(58, 17)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(86, 20)
        Me.txtNum.TabIndex = 8
        '
        'pboxNombreAcierto
        '
        Me.pboxNombreAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxNombreAcierto.Location = New System.Drawing.Point(338, 47)
        Me.pboxNombreAcierto.Name = "pboxNombreAcierto"
        Me.pboxNombreAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxNombreAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNombreAcierto.TabIndex = 105
        Me.pboxNombreAcierto.TabStop = False
        Me.pboxNombreAcierto.Visible = False
        '
        'pboxNombreFallo
        '
        Me.pboxNombreFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxNombreFallo.Location = New System.Drawing.Point(338, 47)
        Me.pboxNombreFallo.Name = "pboxNombreFallo"
        Me.pboxNombreFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxNombreFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxNombreFallo.TabIndex = 104
        Me.pboxNombreFallo.TabStop = False
        Me.pboxNombreFallo.Visible = False
        '
        'pboxPrecioAcierto
        '
        Me.pboxPrecioAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxPrecioAcierto.Location = New System.Drawing.Point(338, 77)
        Me.pboxPrecioAcierto.Name = "pboxPrecioAcierto"
        Me.pboxPrecioAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxPrecioAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPrecioAcierto.TabIndex = 103
        Me.pboxPrecioAcierto.TabStop = False
        Me.pboxPrecioAcierto.Visible = False
        '
        'pboxPrecioFallo
        '
        Me.pboxPrecioFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxPrecioFallo.Location = New System.Drawing.Point(338, 77)
        Me.pboxPrecioFallo.Name = "pboxPrecioFallo"
        Me.pboxPrecioFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxPrecioFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxPrecioFallo.TabIndex = 102
        Me.pboxPrecioFallo.TabStop = False
        Me.pboxPrecioFallo.Visible = False
        '
        'frmNuevoRelacion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(364, 146)
        Me.Controls.Add(Me.pboxNombreAcierto)
        Me.Controls.Add(Me.pboxNombreFallo)
        Me.Controls.Add(Me.pboxPrecioAcierto)
        Me.Controls.Add(Me.pboxPrecioFallo)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtArt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNuevoRelacion"
        Me.Text = "Nueva relación articulos proveedor"
        CType(Me.pboxNombreAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxNombreFallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPrecioAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxPrecioFallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtArt As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents pboxNombreAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxNombreFallo As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPrecioAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents pboxPrecioFallo As System.Windows.Forms.PictureBox
End Class
