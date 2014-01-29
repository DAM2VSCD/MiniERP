<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
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
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabEntradas = New System.Windows.Forms.TabPage()
        Me.panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCorregirError = New System.Windows.Forms.Button()
        Me.lblTipoProblema = New System.Windows.Forms.Label()
        Me.btnModificarTotal = New System.Windows.Forms.Button()
        Me.btnModificarParcial = New System.Windows.Forms.Button()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.lblProDes = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbIntervalo = New System.Windows.Forms.CheckBox()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboImporte = New System.Windows.Forms.ComboBox()
        Me.cboProDes = New System.Windows.Forms.ComboBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.tabSalidas = New System.Windows.Forms.TabPage()
        Me.tabPendientes = New System.Windows.Forms.TabPage()
        Me.tabDeudas = New System.Windows.Forms.TabPage()
        Me.tabValidacion = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGenerarInforme = New System.Windows.Forms.Button()
        Me.lblInforme = New System.Windows.Forms.Label()
        Me.btnTXTvalidar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCheques = New System.Windows.Forms.TextBox()
        Me.txtRecibos = New System.Windows.Forms.TextBox()
        Me.txtEfectivos = New System.Windows.Forms.TextBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal2 = New System.Windows.Forms.TextBox()
        Me.tabControl.SuspendLayout()
        Me.tabEntradas.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabValidacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabEntradas)
        Me.tabControl.Controls.Add(Me.tabSalidas)
        Me.tabControl.Controls.Add(Me.tabPendientes)
        Me.tabControl.Controls.Add(Me.tabDeudas)
        Me.tabControl.Controls.Add(Me.tabValidacion)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(754, 455)
        Me.tabControl.TabIndex = 0
        '
        'tabEntradas
        '
        Me.tabEntradas.Controls.Add(Me.panel)
        Me.tabEntradas.Location = New System.Drawing.Point(4, 22)
        Me.tabEntradas.Name = "tabEntradas"
        Me.tabEntradas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEntradas.Size = New System.Drawing.Size(746, 429)
        Me.tabEntradas.TabIndex = 0
        Me.tabEntradas.Text = "Entradas"
        Me.tabEntradas.UseVisualStyleBackColor = True
        '
        'panel
        '
        Me.panel.Controls.Add(Me.Panel2)
        Me.panel.Controls.Add(Me.lblTipoProblema)
        Me.panel.Controls.Add(Me.btnModificarTotal)
        Me.panel.Controls.Add(Me.btnModificarParcial)
        Me.panel.Controls.Add(Me.btnXML)
        Me.panel.Controls.Add(Me.btnNuevo)
        Me.panel.Controls.Add(Me.lblConcepto)
        Me.panel.Controls.Add(Me.txtImporte)
        Me.panel.Controls.Add(Me.lblProDes)
        Me.panel.Controls.Add(Me.txtConcepto)
        Me.panel.Controls.Add(Me.cboTipo)
        Me.panel.Controls.Add(Me.GroupBox1)
        Me.panel.Controls.Add(Me.cboImporte)
        Me.panel.Controls.Add(Me.cboProDes)
        Me.panel.Controls.Add(Me.lblImporte)
        Me.panel.Controls.Add(Me.lblTipo)
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(750, 433)
        Me.panel.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnCorregirError)
        Me.Panel2.Location = New System.Drawing.Point(400, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(97, 89)
        Me.Panel2.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Anular"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCorregirError
        '
        Me.btnCorregirError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCorregirError.Image = Global.miniERPSoloAprobados.My.Resources.Resources.icono
        Me.btnCorregirError.Location = New System.Drawing.Point(15, 5)
        Me.btnCorregirError.Name = "btnCorregirError"
        Me.btnCorregirError.Size = New System.Drawing.Size(68, 52)
        Me.btnCorregirError.TabIndex = 16
        Me.btnCorregirError.UseVisualStyleBackColor = True
        '
        'lblTipoProblema
        '
        Me.lblTipoProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoProblema.ForeColor = System.Drawing.Color.Blue
        Me.lblTipoProblema.Location = New System.Drawing.Point(489, 129)
        Me.lblTipoProblema.Name = "lblTipoProblema"
        Me.lblTipoProblema.Size = New System.Drawing.Size(234, 32)
        Me.lblTipoProblema.TabIndex = 17
        Me.lblTipoProblema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModificarTotal
        '
        Me.btnModificarTotal.Location = New System.Drawing.Point(100, 138)
        Me.btnModificarTotal.Name = "btnModificarTotal"
        Me.btnModificarTotal.Size = New System.Drawing.Size(126, 23)
        Me.btnModificarTotal.TabIndex = 15
        Me.btnModificarTotal.Text = "Modificar total"
        Me.btnModificarTotal.UseVisualStyleBackColor = True
        '
        'btnModificarParcial
        '
        Me.btnModificarParcial.Location = New System.Drawing.Point(235, 138)
        Me.btnModificarParcial.Name = "btnModificarParcial"
        Me.btnModificarParcial.Size = New System.Drawing.Size(143, 23)
        Me.btnModificarParcial.TabIndex = 14
        Me.btnModificarParcial.Text = "Modificar parcial"
        Me.btnModificarParcial.UseVisualStyleBackColor = True
        '
        'btnXML
        '
        Me.btnXML.Location = New System.Drawing.Point(303, 104)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(75, 23)
        Me.btnXML.TabIndex = 13
        Me.btnXML.Text = "XML"
        Me.btnXML.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(8, 138)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = " Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(8, 15)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(56, 13)
        Me.lblConcepto.TabIndex = 0
        Me.lblConcepto.Text = "Concepto:"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(126, 70)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 6
        '
        'lblProDes
        '
        Me.lblProDes.AutoSize = True
        Me.lblProDes.Location = New System.Drawing.Point(8, 104)
        Me.lblProDes.Name = "lblProDes"
        Me.lblProDes.Size = New System.Drawing.Size(70, 13)
        Me.lblProDes.TabIndex = 3
        Me.lblProDes.Text = "Procedencia:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(65, 12)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(432, 48)
        Me.txtConcepto.TabIndex = 5
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(269, 70)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(96, 21)
        Me.cboTipo.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbIntervalo)
        Me.GroupBox1.Controls.Add(Me.cbFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFin)
        Me.GroupBox1.Controls.Add(Me.dtpInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(503, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 118)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'cbIntervalo
        '
        Me.cbIntervalo.AutoSize = True
        Me.cbIntervalo.Location = New System.Drawing.Point(16, 69)
        Me.cbIntervalo.Name = "cbIntervalo"
        Me.cbIntervalo.Size = New System.Drawing.Size(124, 17)
        Me.cbIntervalo.TabIndex = 3
        Me.cbIntervalo.Text = "Fechas anteriores al:"
        Me.cbIntervalo.UseVisualStyleBackColor = True
        '
        'cbFecha
        '
        Me.cbFecha.AutoSize = True
        Me.cbFecha.Location = New System.Drawing.Point(16, 19)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(116, 17)
        Me.cbFecha.TabIndex = 2
        Me.cbFecha.Text = "Fechas a partir del:"
        Me.cbFecha.UseVisualStyleBackColor = True
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(16, 92)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFin.TabIndex = 1
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(16, 42)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'cboImporte
        '
        Me.cboImporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImporte.FormattingEnabled = True
        Me.cboImporte.Items.AddRange(New Object() {">", "=", "<"})
        Me.cboImporte.Location = New System.Drawing.Point(81, 69)
        Me.cboImporte.Name = "cboImporte"
        Me.cboImporte.Size = New System.Drawing.Size(39, 21)
        Me.cboImporte.TabIndex = 8
        '
        'cboProDes
        '
        Me.cboProDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProDes.FormattingEnabled = True
        Me.cboProDes.Items.AddRange(New Object() {"--Procedencia--", "Venta de productos", "Ingreso directo de administración", "Variacion de saldo", "Varios"})
        Me.cboProDes.Location = New System.Drawing.Point(84, 101)
        Me.cboProDes.Name = "cboProDes"
        Me.cboProDes.Size = New System.Drawing.Size(184, 21)
        Me.cboProDes.TabIndex = 10
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(8, 73)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(45, 13)
        Me.lblImporte.TabIndex = 1
        Me.lblImporte.Text = "Importe:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(232, 73)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo:"
        '
        'tabSalidas
        '
        Me.tabSalidas.Location = New System.Drawing.Point(4, 22)
        Me.tabSalidas.Name = "tabSalidas"
        Me.tabSalidas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSalidas.Size = New System.Drawing.Size(746, 429)
        Me.tabSalidas.TabIndex = 1
        Me.tabSalidas.Text = "Salidas"
        Me.tabSalidas.UseVisualStyleBackColor = True
        '
        'tabPendientes
        '
        Me.tabPendientes.Location = New System.Drawing.Point(4, 22)
        Me.tabPendientes.Name = "tabPendientes"
        Me.tabPendientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPendientes.Size = New System.Drawing.Size(746, 429)
        Me.tabPendientes.TabIndex = 2
        Me.tabPendientes.Text = "Pendientes de cobro"
        Me.tabPendientes.UseVisualStyleBackColor = True
        '
        'tabDeudas
        '
        Me.tabDeudas.Location = New System.Drawing.Point(4, 22)
        Me.tabDeudas.Name = "tabDeudas"
        Me.tabDeudas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDeudas.Size = New System.Drawing.Size(746, 429)
        Me.tabDeudas.TabIndex = 3
        Me.tabDeudas.Text = "Deudas"
        Me.tabDeudas.UseVisualStyleBackColor = True
        '
        'tabValidacion
        '
        Me.tabValidacion.Controls.Add(Me.Panel1)
        Me.tabValidacion.Controls.Add(Me.btnTXTvalidar)
        Me.tabValidacion.Controls.Add(Me.txtTotal)
        Me.tabValidacion.Controls.Add(Me.txtCheques)
        Me.tabValidacion.Controls.Add(Me.txtRecibos)
        Me.tabValidacion.Controls.Add(Me.txtEfectivos)
        Me.tabValidacion.Controls.Add(Me.btnValidar)
        Me.tabValidacion.Controls.Add(Me.Label4)
        Me.tabValidacion.Controls.Add(Me.Label3)
        Me.tabValidacion.Controls.Add(Me.Label2)
        Me.tabValidacion.Controls.Add(Me.Label1)
        Me.tabValidacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabValidacion.Location = New System.Drawing.Point(4, 22)
        Me.tabValidacion.Name = "tabValidacion"
        Me.tabValidacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabValidacion.Size = New System.Drawing.Size(746, 429)
        Me.tabValidacion.TabIndex = 4
        Me.tabValidacion.Text = "Validación"
        Me.tabValidacion.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnGenerarInforme)
        Me.Panel1.Controls.Add(Me.lblInforme)
        Me.Panel1.Location = New System.Drawing.Point(556, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 119)
        Me.Panel1.TabIndex = 18
        '
        'btnGenerarInforme
        '
        Me.btnGenerarInforme.BackgroundImage = Global.miniERPSoloAprobados.My.Resources.Resources.iconoGenerarInforme
        Me.btnGenerarInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGenerarInforme.Location = New System.Drawing.Point(33, 7)
        Me.btnGenerarInforme.Name = "btnGenerarInforme"
        Me.btnGenerarInforme.Size = New System.Drawing.Size(76, 73)
        Me.btnGenerarInforme.TabIndex = 16
        Me.btnGenerarInforme.UseVisualStyleBackColor = True
        '
        'lblInforme
        '
        Me.lblInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInforme.Location = New System.Drawing.Point(3, 90)
        Me.lblInforme.Name = "lblInforme"
        Me.lblInforme.Size = New System.Drawing.Size(134, 23)
        Me.lblInforme.TabIndex = 17
        Me.lblInforme.Text = "Generar informe"
        Me.lblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTXTvalidar
        '
        Me.btnTXTvalidar.Location = New System.Drawing.Point(423, 113)
        Me.btnTXTvalidar.Name = "btnTXTvalidar"
        Me.btnTXTvalidar.Size = New System.Drawing.Size(75, 23)
        Me.btnTXTvalidar.TabIndex = 14
        Me.btnTXTvalidar.Text = "XML"
        Me.btnTXTvalidar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(293, 78)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        '
        'txtCheques
        '
        Me.txtCheques.BackColor = System.Drawing.SystemColors.Control
        Me.txtCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheques.Location = New System.Drawing.Point(111, 115)
        Me.txtCheques.Name = "txtCheques"
        Me.txtCheques.ReadOnly = True
        Me.txtCheques.Size = New System.Drawing.Size(100, 20)
        Me.txtCheques.TabIndex = 7
        '
        'txtRecibos
        '
        Me.txtRecibos.BackColor = System.Drawing.SystemColors.Control
        Me.txtRecibos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibos.ForeColor = System.Drawing.Color.Black
        Me.txtRecibos.Location = New System.Drawing.Point(111, 78)
        Me.txtRecibos.Name = "txtRecibos"
        Me.txtRecibos.ReadOnly = True
        Me.txtRecibos.Size = New System.Drawing.Size(100, 20)
        Me.txtRecibos.TabIndex = 6
        '
        'txtEfectivos
        '
        Me.txtEfectivos.BackColor = System.Drawing.SystemColors.Control
        Me.txtEfectivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivos.ForeColor = System.Drawing.Color.Black
        Me.txtEfectivos.Location = New System.Drawing.Point(111, 44)
        Me.txtEfectivos.Name = "txtEfectivos"
        Me.txtEfectivos.ReadOnly = True
        Me.txtEfectivos.Size = New System.Drawing.Size(100, 20)
        Me.txtEfectivos.TabIndex = 5
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(293, 113)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(75, 23)
        Me.btnValidar.TabIndex = 4
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Caja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total recibos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total cheques:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total efectivos:"
        '
        'dgvCaja
        '
        Me.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Location = New System.Drawing.Point(10, 189)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.Size = New System.Drawing.Size(731, 257)
        Me.dgvCaja.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(500, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Total caja:"
        '
        'txtTotal2
        '
        Me.txtTotal2.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal2.Location = New System.Drawing.Point(560, 0)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.ReadOnly = True
        Me.txtTotal2.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal2.TabIndex = 13
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 459)
        Me.Controls.Add(Me.dgvCaja)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.tabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCaja"
        Me.Text = "Caja"
        Me.tabControl.ResumeLayout(False)
        Me.tabEntradas.ResumeLayout(False)
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabValidacion.ResumeLayout(False)
        Me.tabValidacion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabEntradas As System.Windows.Forms.TabPage
    Friend WithEvents tabSalidas As System.Windows.Forms.TabPage
    Friend WithEvents tabPendientes As System.Windows.Forms.TabPage
    Friend WithEvents tabDeudas As System.Windows.Forms.TabPage
    Friend WithEvents tabValidacion As System.Windows.Forms.TabPage
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblProDes As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents cboImporte As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboProDes As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCheques As System.Windows.Forms.TextBox
    Friend WithEvents txtRecibos As System.Windows.Forms.TextBox
    Friend WithEvents txtEfectivos As System.Windows.Forms.TextBox
    Friend WithEvents btnValidar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbIntervalo As System.Windows.Forms.CheckBox
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotal2 As System.Windows.Forms.TextBox
    Friend WithEvents btnXML As System.Windows.Forms.Button
    Friend WithEvents btnTXTvalidar As System.Windows.Forms.Button
    Friend WithEvents btnModificarParcial As System.Windows.Forms.Button
    Friend WithEvents btnModificarTotal As System.Windows.Forms.Button
    Friend WithEvents btnCorregirError As System.Windows.Forms.Button
    Friend WithEvents lblTipoProblema As System.Windows.Forms.Label
    Friend WithEvents btnGenerarInforme As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblInforme As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
