﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearConvenioLegal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearConvenioLegal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnombre = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblParteCredito = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblParteMoratorios = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblTotal = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckPorcentaje = New ConfiaAdmin.MonoFlat.MonoFlat_CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblModalidad = New System.Windows.Forms.Label()
        Me.SwitchModalidad = New Zeroit.Framework.Metro.ZeroitMetroSwitch()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datePrimerPago = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.MonoFlat_LinkLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantPagos = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblTipoPagos = New System.Windows.Forms.Label()
        Me.txtPago = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ZeroitMetroSwitch1 = New Zeroit.Framework.Metro.ZeroitMetroSwitch()
        Me.btnGenerarCalendario = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundDatos = New System.ComponentModel.BackgroundWorker()
        Me.lblGastos = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckSubtotal = New ConfiaAdmin.MonoFlat.MonoFlat_CheckBox()
        Me.CheckTotal = New ConfiaAdmin.MonoFlat.MonoFlat_CheckBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 36)
        Me.Panel1.TabIndex = 4
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(1017, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 31
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(156, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Crear Convenio Legal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(50, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(49, 87)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(21, 20)
        Me.lblnombre.TabIndex = 32
        Me.lblnombre.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(51, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Parte Crédito"
        '
        'lblParteCredito
        '
        Me.lblParteCredito.AutoSize = True
        Me.lblParteCredito.BackColor = System.Drawing.Color.Transparent
        Me.lblParteCredito.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblParteCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblParteCredito.Location = New System.Drawing.Point(50, 158)
        Me.lblParteCredito.Name = "lblParteCredito"
        Me.lblParteCredito.Size = New System.Drawing.Size(21, 20)
        Me.lblParteCredito.TabIndex = 34
        Me.lblParteCredito.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(304, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Parte Moratorios"
        '
        'lblParteMoratorios
        '
        Me.lblParteMoratorios.AutoSize = True
        Me.lblParteMoratorios.BackColor = System.Drawing.Color.Transparent
        Me.lblParteMoratorios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblParteMoratorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblParteMoratorios.Location = New System.Drawing.Point(303, 158)
        Me.lblParteMoratorios.Name = "lblParteMoratorios"
        Me.lblParteMoratorios.Size = New System.Drawing.Size(21, 20)
        Me.lblParteMoratorios.TabIndex = 36
        Me.lblParteMoratorios.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(738, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Subtotal"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSubtotal.Location = New System.Drawing.Point(737, 158)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(21, 20)
        Me.lblSubtotal.TabIndex = 38
        Me.lblSubtotal.Text = "..."
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(944, 158)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(21, 20)
        Me.lblTotal.TabIndex = 40
        Me.lblTotal.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(945, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Deuda Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckPorcentaje)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblModalidad)
        Me.GroupBox1.Controls.Add(Me.SwitchModalidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.datePrimerPago)
        Me.GroupBox1.Controls.Add(Me.MonoFlat_LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCantPagos)
        Me.GroupBox1.Controls.Add(Me.lblTipoPagos)
        Me.GroupBox1.Controls.Add(Me.txtPago)
        Me.GroupBox1.Controls.Add(Me.ZeroitMetroSwitch1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(53, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(990, 207)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Calendario en Base A:"
        '
        'CheckPorcentaje
        '
        Me.CheckPorcentaje.Checked = False
        Me.CheckPorcentaje.Enabled = False
        Me.CheckPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckPorcentaje.Location = New System.Drawing.Point(484, 149)
        Me.CheckPorcentaje.Name = "CheckPorcentaje"
        Me.CheckPorcentaje.Size = New System.Drawing.Size(148, 16)
        Me.CheckPorcentaje.TabIndex = 50
        Me.CheckPorcentaje.Text = "Incluye Porcentaje"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(13, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Modalidad"
        '
        'lblModalidad
        '
        Me.lblModalidad.AutoSize = True
        Me.lblModalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblModalidad.Location = New System.Drawing.Point(108, 152)
        Me.lblModalidad.Name = "lblModalidad"
        Me.lblModalidad.Size = New System.Drawing.Size(48, 13)
        Me.lblModalidad.TabIndex = 48
        Me.lblModalidad.Text = "Semanal"
        '
        'SwitchModalidad
        '
        Me.SwitchModalidad.BackColor = System.Drawing.Color.Transparent
        Me.SwitchModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SwitchModalidad.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SwitchModalidad.CheckColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SwitchModalidad.Checked = True
        Me.SwitchModalidad.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.SwitchModalidad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SwitchModalidad.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchModalidad.Location = New System.Drawing.Point(16, 152)
        Me.SwitchModalidad.Name = "SwitchModalidad"
        Me.SwitchModalidad.Size = New System.Drawing.Size(75, 23)
        Me.SwitchModalidad.SwitchColor = System.Drawing.Color.White
        Me.SwitchModalidad.TabIndex = 47
        Me.SwitchModalidad.Text = "ZeroitMetroSwitch2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(481, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Fecha del primer pago"
        '
        'datePrimerPago
        '
        Me.datePrimerPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.datePrimerPago.BorderRadius = 0
        Me.datePrimerPago.ForeColor = System.Drawing.Color.White
        Me.datePrimerPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePrimerPago.FormatCustom = Nothing
        Me.datePrimerPago.Location = New System.Drawing.Point(484, 65)
        Me.datePrimerPago.Name = "datePrimerPago"
        Me.datePrimerPago.Size = New System.Drawing.Size(177, 33)
        Me.datePrimerPago.TabIndex = 42
        Me.datePrimerPago.Value = New Date(2020, 2, 20, 0, 0, 0, 0)
        '
        'MonoFlat_LinkLabel1
        '
        Me.MonoFlat_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MonoFlat_LinkLabel1.AutoSize = True
        Me.MonoFlat_LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.MonoFlat_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.MonoFlat_LinkLabel1.Location = New System.Drawing.Point(297, 79)
        Me.MonoFlat_LinkLabel1.Name = "MonoFlat_LinkLabel1"
        Me.MonoFlat_LinkLabel1.Size = New System.Drawing.Size(61, 15)
        Me.MonoFlat_LinkLabel1.TabIndex = 46
        Me.MonoFlat_LinkLabel1.TabStop = True
        Me.MonoFlat_LinkLabel1.Text = "Saber Más"
        Me.MonoFlat_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(161, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Cantidad de Pagos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(13, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Pago"
        '
        'txtCantPagos
        '
        Me.txtCantPagos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantPagos.Enabled = False
        Me.txtCantPagos.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCantPagos.ForeColor = System.Drawing.Color.White
        Me.txtCantPagos.HintForeColor = System.Drawing.Color.White
        Me.txtCantPagos.HintText = ""
        Me.txtCantPagos.isPassword = False
        Me.txtCantPagos.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCantPagos.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCantPagos.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCantPagos.LineThickness = 3
        Me.txtCantPagos.Location = New System.Drawing.Point(164, 65)
        Me.txtCantPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantPagos.Name = "txtCantPagos"
        Me.txtCantPagos.Size = New System.Drawing.Size(107, 29)
        Me.txtCantPagos.TabIndex = 43
        Me.txtCantPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblTipoPagos
        '
        Me.lblTipoPagos.AutoSize = True
        Me.lblTipoPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipoPagos.Location = New System.Drawing.Point(108, 19)
        Me.lblTipoPagos.Name = "lblTipoPagos"
        Me.lblTipoPagos.Size = New System.Drawing.Size(32, 13)
        Me.lblTipoPagos.TabIndex = 42
        Me.lblTipoPagos.Text = "Pago"
        '
        'txtPago
        '
        Me.txtPago.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPago.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPago.ForeColor = System.Drawing.Color.White
        Me.txtPago.HintForeColor = System.Drawing.Color.White
        Me.txtPago.HintText = ""
        Me.txtPago.isPassword = False
        Me.txtPago.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPago.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPago.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPago.LineThickness = 3
        Me.txtPago.Location = New System.Drawing.Point(16, 65)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(107, 29)
        Me.txtPago.TabIndex = 3
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ZeroitMetroSwitch1
        '
        Me.ZeroitMetroSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.ZeroitMetroSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ZeroitMetroSwitch1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.ZeroitMetroSwitch1.CheckColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ZeroitMetroSwitch1.Checked = True
        Me.ZeroitMetroSwitch1.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ZeroitMetroSwitch1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ZeroitMetroSwitch1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ZeroitMetroSwitch1.Location = New System.Drawing.Point(16, 19)
        Me.ZeroitMetroSwitch1.Name = "ZeroitMetroSwitch1"
        Me.ZeroitMetroSwitch1.Size = New System.Drawing.Size(75, 23)
        Me.ZeroitMetroSwitch1.SwitchColor = System.Drawing.Color.White
        Me.ZeroitMetroSwitch1.TabIndex = 0
        Me.ZeroitMetroSwitch1.Text = "ZeroitMetroSwitch1"
        '
        'btnGenerarCalendario
        '
        Me.btnGenerarCalendario.ActiveBorderThickness = 1
        Me.btnGenerarCalendario.ActiveCornerRadius = 20
        Me.btnGenerarCalendario.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnGenerarCalendario.ActiveForecolor = System.Drawing.Color.White
        Me.btnGenerarCalendario.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnGenerarCalendario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnGenerarCalendario.BackgroundImage = CType(resources.GetObject("btnGenerarCalendario.BackgroundImage"), System.Drawing.Image)
        Me.btnGenerarCalendario.ButtonText = "Generar Calendario"
        Me.btnGenerarCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarCalendario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCalendario.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnGenerarCalendario.IdleBorderThickness = 1
        Me.btnGenerarCalendario.IdleCornerRadius = 20
        Me.btnGenerarCalendario.IdleFillColor = System.Drawing.Color.White
        Me.btnGenerarCalendario.IdleForecolor = System.Drawing.Color.Gray
        Me.btnGenerarCalendario.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnGenerarCalendario.Location = New System.Drawing.Point(450, 462)
        Me.btnGenerarCalendario.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGenerarCalendario.Name = "btnGenerarCalendario"
        Me.btnGenerarCalendario.Size = New System.Drawing.Size(173, 38)
        Me.btnGenerarCalendario.TabIndex = 154
        Me.btnGenerarCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundDatos
        '
        '
        'lblGastos
        '
        Me.lblGastos.AutoSize = True
        Me.lblGastos.BackColor = System.Drawing.Color.Transparent
        Me.lblGastos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblGastos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGastos.Location = New System.Drawing.Point(548, 158)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(21, 20)
        Me.lblGastos.TabIndex = 156
        Me.lblGastos.Text = "..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(549, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "Gastos"
        '
        'CheckSubtotal
        '
        Me.CheckSubtotal.Checked = False
        Me.CheckSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckSubtotal.Location = New System.Drawing.Point(790, 133)
        Me.CheckSubtotal.Name = "CheckSubtotal"
        Me.CheckSubtotal.Size = New System.Drawing.Size(24, 16)
        Me.CheckSubtotal.TabIndex = 51
        '
        'CheckTotal
        '
        Me.CheckTotal.Checked = False
        Me.CheckTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckTotal.Location = New System.Drawing.Point(1017, 130)
        Me.CheckTotal.Name = "CheckTotal"
        Me.CheckTotal.Size = New System.Drawing.Size(24, 16)
        Me.CheckTotal.TabIndex = 157
        '
        'CrearConvenioLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1086, 526)
        Me.Controls.Add(Me.CheckTotal)
        Me.Controls.Add(Me.CheckSubtotal)
        Me.Controls.Add(Me.lblGastos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnGenerarCalendario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblParteMoratorios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblParteCredito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrearConvenioLegal"
        Me.Text = "CrearConvenioLegal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnombre As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblParteCredito As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblParteMoratorios As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSubtotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ZeroitMetroSwitch1 As Zeroit.Framework.Metro.ZeroitMetroSwitch
    Friend WithEvents lblTipoPagos As Label
    Friend WithEvents txtPago As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_LinkLabel1 As MonoFlat.MonoFlat_LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantPagos As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents datePrimerPago As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents btnGenerarCalendario As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label9 As Label
    Friend WithEvents lblModalidad As Label
    Friend WithEvents SwitchModalidad As Zeroit.Framework.Metro.ZeroitMetroSwitch
    Friend WithEvents BackgroundDatos As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckPorcentaje As MonoFlat.MonoFlat_CheckBox
    Friend WithEvents lblGastos As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckSubtotal As MonoFlat.MonoFlat_CheckBox
    Friend WithEvents CheckTotal As MonoFlat.MonoFlat_CheckBox
End Class
