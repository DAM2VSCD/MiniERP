<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePedidos
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
        Me.dgvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.IDARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOUNITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKMAXIMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPEDIDOARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pboxUnidadesAcierto = New System.Windows.Forms.PictureBox()
        Me.txtOculto2 = New System.Windows.Forms.TextBox()
        Me.pboxUnidadesFallo = New System.Windows.Forms.PictureBox()
        Me.btnConfirmarModificaciones = New System.Windows.Forms.Button()
        Me.btnCambios = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxUnidadesAcierto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxUnidadesFallo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetallePedido
        '
        Me.dgvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDARTICULO, Me.NOMBREARTICULO, Me.CANTIDAD, Me.PRECIOUNITARIO, Me.STOCKMAXIMO, Me.PRECIOTOTAL, Me.IDPEDIDOARTICULO})
        Me.dgvDetallePedido.Location = New System.Drawing.Point(44, 61)
        Me.dgvDetallePedido.Name = "dgvDetallePedido"
        Me.dgvDetallePedido.Size = New System.Drawing.Size(456, 167)
        Me.dgvDetallePedido.TabIndex = 0
        '
        'IDARTICULO
        '
        Me.IDARTICULO.HeaderText = "ID ARTICULO"
        Me.IDARTICULO.Name = "IDARTICULO"
        Me.IDARTICULO.ReadOnly = True
        Me.IDARTICULO.Visible = False
        '
        'NOMBREARTICULO
        '
        Me.NOMBREARTICULO.HeaderText = "NOMBRE"
        Me.NOMBREARTICULO.Name = "NOMBREARTICULO"
        Me.NOMBREARTICULO.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "NUM UNIDADES"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'PRECIOUNITARIO
        '
        Me.PRECIOUNITARIO.HeaderText = "PRECIO UNITARIO"
        Me.PRECIOUNITARIO.Name = "PRECIOUNITARIO"
        Me.PRECIOUNITARIO.ReadOnly = True
        '
        'STOCKMAXIMO
        '
        Me.STOCKMAXIMO.HeaderText = "STOCK MAXIMO"
        Me.STOCKMAXIMO.Name = "STOCKMAXIMO"
        Me.STOCKMAXIMO.ReadOnly = True
        Me.STOCKMAXIMO.Visible = False
        '
        'PRECIOTOTAL
        '
        Me.PRECIOTOTAL.HeaderText = "PRECIO TOTAL"
        Me.PRECIOTOTAL.Name = "PRECIOTOTAL"
        Me.PRECIOTOTAL.ReadOnly = True
        Me.PRECIOTOTAL.Visible = False
        '
        'IDPEDIDOARTICULO
        '
        Me.IDPEDIDOARTICULO.HeaderText = "IDPEDIDOARTICULO"
        Me.IDPEDIDOARTICULO.Name = "IDPEDIDOARTICULO"
        Me.IDPEDIDOARTICULO.ReadOnly = True
        Me.IDPEDIDOARTICULO.Visible = False
        '
        'pboxUnidadesAcierto
        '
        Me.pboxUnidadesAcierto.Image = Global.miniERPSoloAprobados.My.Resources.Resources.iconoCorrecto_jpg
        Me.pboxUnidadesAcierto.Location = New System.Drawing.Point(131, 235)
        Me.pboxUnidadesAcierto.Name = "pboxUnidadesAcierto"
        Me.pboxUnidadesAcierto.Size = New System.Drawing.Size(20, 20)
        Me.pboxUnidadesAcierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxUnidadesAcierto.TabIndex = 44
        Me.pboxUnidadesAcierto.TabStop = False
        Me.pboxUnidadesAcierto.Visible = False
        '
        'txtOculto2
        '
        Me.txtOculto2.Location = New System.Drawing.Point(157, 262)
        Me.txtOculto2.Name = "txtOculto2"
        Me.txtOculto2.ReadOnly = True
        Me.txtOculto2.Size = New System.Drawing.Size(16, 20)
        Me.txtOculto2.TabIndex = 45
        Me.txtOculto2.Visible = False
        '
        'pboxUnidadesFallo
        '
        Me.pboxUnidadesFallo.Image = Global.miniERPSoloAprobados.My.Resources.Resources.IconoError
        Me.pboxUnidadesFallo.Location = New System.Drawing.Point(131, 261)
        Me.pboxUnidadesFallo.Name = "pboxUnidadesFallo"
        Me.pboxUnidadesFallo.Size = New System.Drawing.Size(20, 20)
        Me.pboxUnidadesFallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxUnidadesFallo.TabIndex = 46
        Me.pboxUnidadesFallo.TabStop = False
        Me.pboxUnidadesFallo.Visible = False
        '
        'btnConfirmarModificaciones
        '
        Me.btnConfirmarModificaciones.Enabled = False
        Me.btnConfirmarModificaciones.Location = New System.Drawing.Point(190, 262)
        Me.btnConfirmarModificaciones.Name = "btnConfirmarModificaciones"
        Me.btnConfirmarModificaciones.Size = New System.Drawing.Size(148, 22)
        Me.btnConfirmarModificaciones.TabIndex = 47
        Me.btnConfirmarModificaciones.Text = "CONFIRMAR CAMBIOS"
        Me.btnConfirmarModificaciones.UseVisualStyleBackColor = True
        '
        'btnCambios
        '
        Me.btnCambios.Location = New System.Drawing.Point(190, 235)
        Me.btnCambios.Name = "btnCambios"
        Me.btnCambios.Size = New System.Drawing.Size(148, 22)
        Me.btnCambios.TabIndex = 60
        Me.btnCambios.Text = "LISTA DE CAMBIOS"
        Me.btnCambios.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(369, 262)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(131, 23)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(369, 234)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(131, 23)
        Me.btnEliminar.TabIndex = 62
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmDetallePedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 308)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCambios)
        Me.Controls.Add(Me.btnConfirmarModificaciones)
        Me.Controls.Add(Me.pboxUnidadesFallo)
        Me.Controls.Add(Me.txtOculto2)
        Me.Controls.Add(Me.pboxUnidadesAcierto)
        Me.Controls.Add(Me.dgvDetallePedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDetallePedidos"
        Me.Text = "frmDetallePedidos"
        CType(Me.dgvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxUnidadesAcierto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxUnidadesFallo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetallePedido As System.Windows.Forms.DataGridView
    Friend WithEvents IDARTICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREARTICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIOUNITARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOCKMAXIMO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIOTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pboxUnidadesAcierto As System.Windows.Forms.PictureBox
    Friend WithEvents txtOculto2 As System.Windows.Forms.TextBox
    Friend WithEvents pboxUnidadesFallo As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfirmarModificaciones As System.Windows.Forms.Button
    Friend WithEvents IDPEDIDOARTICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCambios As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
