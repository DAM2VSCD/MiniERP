<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulosProv
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
        Me.lblActElm = New System.Windows.Forms.Label()
        Me.lblnomCod = New System.Windows.Forms.Label()
        Me.jcbActElim = New System.Windows.Forms.ComboBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.jcbTipo = New System.Windows.Forms.ComboBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.jcbCompara = New System.Windows.Forms.ComboBox()
        Me.lblprecStock = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.jcbPrecioStock = New System.Windows.Forms.ComboBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnElimina = New System.Windows.Forms.Button()
        Me.btnRestaura = New System.Windows.Forms.Button()
        Me.btnLC = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbError = New System.Windows.Forms.PictureBox()
        Me.pbCorrecto = New System.Windows.Forms.PictureBox()
        Me.lblErrorValor = New System.Windows.Forms.Label()
        Me.pFiltro1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnGenerarXML = New System.Windows.Forms.Button()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFiltro1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblActElm
        '
        Me.lblActElm.AutoSize = True
        Me.lblActElm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActElm.Location = New System.Drawing.Point(282, 30)
        Me.lblActElm.Name = "lblActElm"
        Me.lblActElm.Size = New System.Drawing.Size(115, 16)
        Me.lblActElm.TabIndex = 0
        Me.lblActElm.Text = "Activo / Eliminado"
        '
        'lblnomCod
        '
        Me.lblnomCod.AutoSize = True
        Me.lblnomCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomCod.Location = New System.Drawing.Point(7, 11)
        Me.lblnomCod.Name = "lblnomCod"
        Me.lblnomCod.Size = New System.Drawing.Size(161, 16)
        Me.lblnomCod.TabIndex = 1
        Me.lblnomCod.Text = "Filtro por nombre / código"
        '
        'jcbActElim
        '
        Me.jcbActElim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbActElim.FormattingEnabled = True
        Me.jcbActElim.Items.AddRange(New Object() {"Artículos Activos", "Artículos Eliminados"})
        Me.jcbActElim.Location = New System.Drawing.Point(285, 59)
        Me.jcbActElim.Name = "jcbActElim"
        Me.jcbActElim.Size = New System.Drawing.Size(131, 21)
        Me.jcbActElim.TabIndex = 2
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(68, 46)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(116, 20)
        Me.txtCod.TabIndex = 3
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(42, 264)
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.Size = New System.Drawing.Size(499, 250)
        Me.dgvArticulos.TabIndex = 4
        '
        'jcbTipo
        '
        Me.jcbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbTipo.FormattingEnabled = True
        Me.jcbTipo.Location = New System.Drawing.Point(10, 29)
        Me.jcbTipo.Name = "jcbTipo"
        Me.jcbTipo.Size = New System.Drawing.Size(147, 21)
        Me.jcbTipo.TabIndex = 5
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(8, 10)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(108, 16)
        Me.lbltipo.TabIndex = 6
        Me.lbltipo.Text = "Filtro por Género"
        '
        'jcbCompara
        '
        Me.jcbCompara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbCompara.FormattingEnabled = True
        Me.jcbCompara.Items.AddRange(New Object() {">", "=", "<"})
        Me.jcbCompara.Location = New System.Drawing.Point(125, 36)
        Me.jcbCompara.Name = "jcbCompara"
        Me.jcbCompara.Size = New System.Drawing.Size(34, 21)
        Me.jcbCompara.TabIndex = 7
        '
        'lblprecStock
        '
        Me.lblprecStock.AutoSize = True
        Me.lblprecStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecStock.Location = New System.Drawing.Point(7, 11)
        Me.lblprecStock.Name = "lblprecStock"
        Me.lblprecStock.Size = New System.Drawing.Size(143, 16)
        Me.lblprecStock.TabIndex = 8
        Me.lblprecStock.Text = "Filtro por precio / stock"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(162, 37)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(73, 20)
        Me.txtValor.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(10, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(53, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'jcbPrecioStock
        '
        Me.jcbPrecioStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jcbPrecioStock.FormattingEnabled = True
        Me.jcbPrecioStock.Items.AddRange(New Object() {"- Elige categoría -", "Precio", "Stock"})
        Me.jcbPrecioStock.Location = New System.Drawing.Point(10, 36)
        Me.jcbPrecioStock.Name = "jcbPrecioStock"
        Me.jcbPrecioStock.Size = New System.Drawing.Size(112, 21)
        Me.jcbPrecioStock.TabIndex = 11
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(68, 73)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(116, 20)
        Me.txtNom.TabIndex = 12
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(8, 76)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(44, 13)
        Me.lblNom.TabIndex = 13
        Me.lblNom.Text = "Nombre"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(8, 49)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCod.TabIndex = 14
        Me.lblCod.Text = "Código"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(46, 533)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(139, 533)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(75, 23)
        Me.btnModif.TabIndex = 16
        Me.btnModif.Text = "Modificar"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnElimina
        '
        Me.btnElimina.Location = New System.Drawing.Point(230, 533)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(75, 23)
        Me.btnElimina.TabIndex = 17
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.UseVisualStyleBackColor = True
        '
        'btnRestaura
        '
        Me.btnRestaura.Location = New System.Drawing.Point(361, 533)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(75, 23)
        Me.btnRestaura.TabIndex = 18
        Me.btnRestaura.Text = "Restaurar"
        Me.btnRestaura.UseVisualStyleBackColor = True
        '
        'btnLC
        '
        Me.btnLC.Location = New System.Drawing.Point(433, 30)
        Me.btnLC.Name = "btnLC"
        Me.btnLC.Size = New System.Drawing.Size(75, 52)
        Me.btnLC.TabIndex = 19
        Me.btnLC.Text = "Lista de Cambios"
        Me.btnLC.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(467, 533)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbError
        '
        Me.pbError.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pbError.Location = New System.Drawing.Point(239, 37)
        Me.pbError.Name = "pbError"
        Me.pbError.Size = New System.Drawing.Size(20, 20)
        Me.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbError.TabIndex = 21
        Me.pbError.TabStop = False
        '
        'pbCorrecto
        '
        Me.pbCorrecto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pbCorrecto.Location = New System.Drawing.Point(239, 37)
        Me.pbCorrecto.Name = "pbCorrecto"
        Me.pbCorrecto.Size = New System.Drawing.Size(20, 20)
        Me.pbCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCorrecto.TabIndex = 22
        Me.pbCorrecto.TabStop = False
        Me.pbCorrecto.Visible = False
        '
        'lblErrorValor
        '
        Me.lblErrorValor.AutoSize = True
        Me.lblErrorValor.Location = New System.Drawing.Point(416, 166)
        Me.lblErrorValor.Name = "lblErrorValor"
        Me.lblErrorValor.Size = New System.Drawing.Size(0, 13)
        Me.lblErrorValor.TabIndex = 23
        '
        'pFiltro1
        '
        Me.pFiltro1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pFiltro1.Controls.Add(Me.lblprecStock)
        Me.pFiltro1.Controls.Add(Me.pbError)
        Me.pFiltro1.Controls.Add(Me.pbCorrecto)
        Me.pFiltro1.Controls.Add(Me.jcbPrecioStock)
        Me.pFiltro1.Controls.Add(Me.jcbCompara)
        Me.pFiltro1.Controls.Add(Me.txtValor)
        Me.pFiltro1.Controls.Add(Me.btnBuscar)
        Me.pFiltro1.Location = New System.Drawing.Point(273, 158)
        Me.pFiltro1.Name = "pFiltro1"
        Me.pFiltro1.Size = New System.Drawing.Size(269, 100)
        Me.pFiltro1.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblnomCod)
        Me.Panel1.Controls.Add(Me.txtCod)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.lblNom)
        Me.Panel1.Controls.Add(Me.lblCod)
        Me.Panel1.Location = New System.Drawing.Point(42, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 100)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtProveedor)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbltipo)
        Me.Panel2.Controls.Add(Me.jcbTipo)
        Me.Panel2.Location = New System.Drawing.Point(42, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 124)
        Me.Panel2.TabIndex = 26
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(11, 88)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(146, 20)
        Me.txtProveedor.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filtro por Proveedor"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(467, 534)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 21)
        Me.btnAceptar.TabIndex = 27
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnGenerarXML
        '
        Me.btnGenerarXML.Location = New System.Drawing.Point(514, 30)
        Me.btnGenerarXML.Name = "btnGenerarXML"
        Me.btnGenerarXML.Size = New System.Drawing.Size(75, 52)
        Me.btnGenerarXML.TabIndex = 29
        Me.btnGenerarXML.Text = "Generar XML"
        Me.btnGenerarXML.UseVisualStyleBackColor = True
        '
        'frmArticulosProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 581)
        Me.Controls.Add(Me.btnGenerarXML)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.jcbActElim)
        Me.Controls.Add(Me.lblActElm)
        Me.Controls.Add(Me.lblErrorValor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLC)
        Me.Controls.Add(Me.btnRestaura)
        Me.Controls.Add(Me.btnElimina)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.pFiltro1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmArticulosProv"
        Me.Text = "Articulos Proveedores"
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCorrecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFiltro1.ResumeLayout(False)
        Me.pFiltro1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblActElm As System.Windows.Forms.Label
    Friend WithEvents lblnomCod As System.Windows.Forms.Label
    Friend WithEvents jcbActElim As System.Windows.Forms.ComboBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents dgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents jcbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents jcbCompara As System.Windows.Forms.ComboBox
    Friend WithEvents lblprecStock As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents jcbPrecioStock As System.Windows.Forms.ComboBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnElimina As System.Windows.Forms.Button
    Friend WithEvents btnRestaura As System.Windows.Forms.Button
    Friend WithEvents btnLC As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pbError As System.Windows.Forms.PictureBox
    Friend WithEvents pbCorrecto As System.Windows.Forms.PictureBox
    Friend WithEvents lblErrorValor As System.Windows.Forms.Label
    Friend WithEvents pFiltro1 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerarXML As System.Windows.Forms.Button
End Class
