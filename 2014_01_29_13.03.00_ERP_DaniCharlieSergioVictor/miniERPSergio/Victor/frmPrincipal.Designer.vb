<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmIniciasSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmArticulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTipos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCopiaGeneralXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCambios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 526)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(775, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'msMenu
        '
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.tsmPedidos, Me.tsmCambios, Me.tsmCaja})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(775, 24)
        Me.msMenu.TabIndex = 2
        Me.msMenu.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSesion, Me.tsmUsuarios, Me.tsmClientes, Me.tsmArticulos, Me.tsmTipos, Me.ProveedoresToolStripMenuItem, Me.tsmCopiaGeneralXML, Me.tsmSalir, Me.FacturasToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'tsmSesion
        '
        Me.tsmSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmIniciasSesion, Me.tsmCerrarSesion})
        Me.tsmSesion.Name = "tsmSesion"
        Me.tsmSesion.Size = New System.Drawing.Size(198, 22)
        Me.tsmSesion.Text = "Sesión"
        '
        'tsmIniciasSesion
        '
        Me.tsmIniciasSesion.Name = "tsmIniciasSesion"
        Me.tsmIniciasSesion.Size = New System.Drawing.Size(142, 22)
        Me.tsmIniciasSesion.Text = "Iniciar sesión"
        '
        'tsmCerrarSesion
        '
        Me.tsmCerrarSesion.Name = "tsmCerrarSesion"
        Me.tsmCerrarSesion.Size = New System.Drawing.Size(142, 22)
        Me.tsmCerrarSesion.Text = "Cerrar sesión"
        '
        'tsmUsuarios
        '
        Me.tsmUsuarios.Name = "tsmUsuarios"
        Me.tsmUsuarios.Size = New System.Drawing.Size(198, 22)
        Me.tsmUsuarios.Text = "Usuarios"
        '
        'tsmClientes
        '
        Me.tsmClientes.Name = "tsmClientes"
        Me.tsmClientes.Size = New System.Drawing.Size(198, 22)
        Me.tsmClientes.Text = "Clientes"
        '
        'tsmArticulos
        '
        Me.tsmArticulos.Name = "tsmArticulos"
        Me.tsmArticulos.Size = New System.Drawing.Size(198, 22)
        Me.tsmArticulos.Text = "Articulos"
        '
        'tsmTipos
        '
        Me.tsmTipos.Name = "tsmTipos"
        Me.tsmTipos.Size = New System.Drawing.Size(198, 22)
        Me.tsmTipos.Text = "Generos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'tsmCopiaGeneralXML
        '
        Me.tsmCopiaGeneralXML.Name = "tsmCopiaGeneralXML"
        Me.tsmCopiaGeneralXML.Size = New System.Drawing.Size(198, 22)
        Me.tsmCopiaGeneralXML.Text = "Copia seguridad en xml"
        '
        'tsmSalir
        '
        Me.tsmSalir.Name = "tsmSalir"
        Me.tsmSalir.Size = New System.Drawing.Size(198, 22)
        Me.tsmSalir.Text = "Salir"
        '
        'tsmPedidos
        '
        Me.tsmPedidos.Name = "tsmPedidos"
        Me.tsmPedidos.Size = New System.Drawing.Size(61, 20)
        Me.tsmPedidos.Text = "Pedidos"
        '
        'tsmCambios
        '
        Me.tsmCambios.Name = "tsmCambios"
        Me.tsmCambios.Size = New System.Drawing.Size(91, 20)
        Me.tsmCambios.Text = "Lista cambios"
        '
        'tsmCaja
        '
        Me.tsmCaja.Name = "tsmCaja"
        Me.tsmCaja.Size = New System.Drawing.Size(42, 20)
        Me.tsmCaja.Text = "Caja"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 548)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.msMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmPedidos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCambios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmIniciasSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmArticulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmTipos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCopiaGeneralXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmCaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
