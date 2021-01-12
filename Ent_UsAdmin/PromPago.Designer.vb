<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromPago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadWizard1 = New Telerik.WinControls.UI.RadWizard()
        Me.WizardCompletionPage1 = New Telerik.WinControls.UI.WizardCompletionPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateFechaLimite = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotalTotal = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.CheckTotal = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDescuentoTotal = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblPagoNormalTotal = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblDescuentoTotaltext = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMultasTotal = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.RadCollapsiblePanel1 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.dtTotal = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupVencidos = New System.Windows.Forms.GroupBox()
        Me.lblTotalParcial = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDescuentoParcial = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckVencidos = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPagoNormalParcial = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblMultasParcial = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.RadCollapsiblePanel2 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.dtVencidos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage()
        Me.BackgroundVencidos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundTotal = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadWizard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupTotal.SuspendLayout()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCollapsiblePanel1.PanelContainer.SuspendLayout()
        Me.RadCollapsiblePanel1.SuspendLayout()
        CType(Me.dtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupVencidos.SuspendLayout()
        CType(Me.RadCollapsiblePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCollapsiblePanel2.PanelContainer.SuspendLayout()
        Me.RadCollapsiblePanel2.SuspendLayout()
        CType(Me.dtVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWizard1
        '
        Me.RadWizard1.CompletionPage = Me.WizardCompletionPage1
        Me.RadWizard1.Controls.Add(Me.Panel1)
        Me.RadWizard1.Controls.Add(Me.Panel2)
        Me.RadWizard1.Controls.Add(Me.Panel3)
        Me.RadWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadWizard1.HideWelcomeImage = True
        Me.RadWizard1.Location = New System.Drawing.Point(0, 0)
        Me.RadWizard1.Mode = Telerik.WinControls.UI.WizardMode.Aero
        Me.RadWizard1.Name = "RadWizard1"
        Me.RadWizard1.PageHeaderIcon = Nothing
        Me.RadWizard1.Pages.Add(Me.WizardWelcomePage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage1)
        Me.RadWizard1.Pages.Add(Me.WizardCompletionPage1)
        Me.RadWizard1.Size = New System.Drawing.Size(939, 517)
        Me.RadWizard1.TabIndex = 0
        Me.RadWizard1.WelcomePage = Me.WizardWelcomePage1
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardAeroView).HideWelcomeImage = True
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardAeroView).HideCompletionImage = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WizardCommandArea).IsWelcomePage = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WizardCommandArea).IsCompletionPage = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(1), Telerik.WinControls.UI.WizardCommandAreaButtonElement).IsFocusedWizardButton = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(1), Telerik.WinControls.UI.WizardCommandAreaButtonElement).Text = "Generar"
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(2), Telerik.WinControls.UI.WizardCommandAreaButtonElement).IsFocusedWizardButton = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(2), Telerik.WinControls.UI.WizardCommandAreaButtonElement).Text = "Siguiente >"
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(3), Telerik.WinControls.UI.BaseWizardElement).Text = "<html><u>Ayuda</u></html>"
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(3), Telerik.WinControls.UI.BaseWizardElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(0), Telerik.WinControls.UI.WizardAeroButtonElement).Enabled = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(0), Telerik.WinControls.UI.WizardAeroButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'WizardCompletionPage1
        '
        Me.WizardCompletionPage1.ContentArea = Me.Panel3
        Me.WizardCompletionPage1.Header = "Page header"
        Me.WizardCompletionPage1.Name = "WizardCompletionPage1"
        Me.WizardCompletionPage1.Title = "Generar promesa de pago"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(150, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(789, 428)
        Me.Panel3.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dateFechaLimite)
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 428)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 22.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(48, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(572, 41)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Elige la fecha en que deberá pagar el cliente"
        '
        'dateFechaLimite
        '
        Me.dateFechaLimite.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dateFechaLimite.BorderRadius = 0
        Me.dateFechaLimite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.dateFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaLimite.FormatCustom = Nothing
        Me.dateFechaLimite.Location = New System.Drawing.Point(55, 158)
        Me.dateFechaLimite.Name = "dateFechaLimite"
        Me.dateFechaLimite.Size = New System.Drawing.Size(177, 33)
        Me.dateFechaLimite.TabIndex = 44
        Me.dateFechaLimite.Value = New Date(2020, 8, 14, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupTotal)
        Me.Panel2.Controls.Add(Me.RadCollapsiblePanel1)
        Me.Panel2.Controls.Add(Me.GroupVencidos)
        Me.Panel2.Controls.Add(Me.RadCollapsiblePanel2)
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(939, 428)
        Me.Panel2.TabIndex = 1
        '
        'GroupTotal
        '
        Me.GroupTotal.Controls.Add(Me.lblTotalTotal)
        Me.GroupTotal.Controls.Add(Me.CheckTotal)
        Me.GroupTotal.Controls.Add(Me.Label3)
        Me.GroupTotal.Controls.Add(Me.Label16)
        Me.GroupTotal.Controls.Add(Me.lblDescuentoTotal)
        Me.GroupTotal.Controls.Add(Me.lblPagoNormalTotal)
        Me.GroupTotal.Controls.Add(Me.lblDescuentoTotaltext)
        Me.GroupTotal.Controls.Add(Me.Label4)
        Me.GroupTotal.Controls.Add(Me.lblMultasTotal)
        Me.GroupTotal.Location = New System.Drawing.Point(13, 0)
        Me.GroupTotal.Name = "GroupTotal"
        Me.GroupTotal.Size = New System.Drawing.Size(898, 42)
        Me.GroupTotal.TabIndex = 179
        Me.GroupTotal.TabStop = False
        Me.GroupTotal.Text = "Deuda total"
        '
        'lblTotalTotal
        '
        Me.lblTotalTotal.AutoSize = True
        Me.lblTotalTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblTotalTotal.Location = New System.Drawing.Point(634, 11)
        Me.lblTotalTotal.Name = "lblTotalTotal"
        Me.lblTotalTotal.Size = New System.Drawing.Size(21, 20)
        Me.lblTotalTotal.TabIndex = 184
        Me.lblTotalTotal.Text = "..."
        '
        'CheckTotal
        '
        Me.CheckTotal.AutoSize = True
        Me.CheckTotal.Location = New System.Drawing.Point(12, 18)
        Me.CheckTotal.Name = "CheckTotal"
        Me.CheckTotal.Size = New System.Drawing.Size(15, 14)
        Me.CheckTotal.TabIndex = 174
        Me.CheckTotal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(598, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "Total:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(44, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 169
        Me.Label16.Text = "Pago Normal:"
        '
        'lblDescuentoTotal
        '
        Me.lblDescuentoTotal.AutoSize = True
        Me.lblDescuentoTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblDescuentoTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescuentoTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblDescuentoTotal.Location = New System.Drawing.Point(488, 11)
        Me.lblDescuentoTotal.Name = "lblDescuentoTotal"
        Me.lblDescuentoTotal.Size = New System.Drawing.Size(21, 20)
        Me.lblDescuentoTotal.TabIndex = 182
        Me.lblDescuentoTotal.Text = "..."
        '
        'lblPagoNormalTotal
        '
        Me.lblPagoNormalTotal.AutoSize = True
        Me.lblPagoNormalTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblPagoNormalTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPagoNormalTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblPagoNormalTotal.Location = New System.Drawing.Point(121, 12)
        Me.lblPagoNormalTotal.Name = "lblPagoNormalTotal"
        Me.lblPagoNormalTotal.Size = New System.Drawing.Size(21, 20)
        Me.lblPagoNormalTotal.TabIndex = 170
        Me.lblPagoNormalTotal.Text = "..."
        '
        'lblDescuentoTotaltext
        '
        Me.lblDescuentoTotaltext.AutoSize = True
        Me.lblDescuentoTotaltext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblDescuentoTotaltext.Location = New System.Drawing.Point(421, 18)
        Me.lblDescuentoTotaltext.Name = "lblDescuentoTotaltext"
        Me.lblDescuentoTotaltext.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuentoTotaltext.TabIndex = 183
        Me.lblDescuentoTotaltext.Text = "Descuento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(258, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Multas:"
        '
        'lblMultasTotal
        '
        Me.lblMultasTotal.AutoSize = True
        Me.lblMultasTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblMultasTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblMultasTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblMultasTotal.Location = New System.Drawing.Point(305, 12)
        Me.lblMultasTotal.Name = "lblMultasTotal"
        Me.lblMultasTotal.Size = New System.Drawing.Size(21, 20)
        Me.lblMultasTotal.TabIndex = 172
        Me.lblMultasTotal.Text = "..."
        '
        'RadCollapsiblePanel1
        '
        Me.RadCollapsiblePanel1.IsExpanded = False
        Me.RadCollapsiblePanel1.Location = New System.Drawing.Point(15, 48)
        Me.RadCollapsiblePanel1.Name = "RadCollapsiblePanel1"
        Me.RadCollapsiblePanel1.OwnerBoundsCache = New System.Drawing.Rectangle(15, 48, 898, 259)
        '
        'RadCollapsiblePanel1.PanelContainer
        '
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.dtTotal)
        Me.RadCollapsiblePanel1.PanelContainer.Size = New System.Drawing.Size(0, 0)
        Me.RadCollapsiblePanel1.Size = New System.Drawing.Size(898, 21)
        Me.RadCollapsiblePanel1.TabIndex = 0
        '
        'dtTotal
        '
        Me.dtTotal.AllowUserToAddRows = False
        Me.dtTotal.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtTotal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtTotal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtTotal.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dtTotal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtTotal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtTotal.DoubleBuffered = True
        Me.dtTotal.EnableHeadersVisualStyles = False
        Me.dtTotal.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtTotal.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtTotal.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.dtTotal.Location = New System.Drawing.Point(2, -2)
        Me.dtTotal.Name = "dtTotal"
        Me.dtTotal.ReadOnly = True
        Me.dtTotal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtTotal.RowHeadersVisible = False
        Me.dtTotal.Size = New System.Drawing.Size(0, 4)
        Me.dtTotal.TabIndex = 179
        '
        'GroupVencidos
        '
        Me.GroupVencidos.Controls.Add(Me.lblTotalParcial)
        Me.GroupVencidos.Controls.Add(Me.Label2)
        Me.GroupVencidos.Controls.Add(Me.lblDescuentoParcial)
        Me.GroupVencidos.Controls.Add(Me.Label1)
        Me.GroupVencidos.Controls.Add(Me.CheckVencidos)
        Me.GroupVencidos.Controls.Add(Me.Label7)
        Me.GroupVencidos.Controls.Add(Me.lblPagoNormalParcial)
        Me.GroupVencidos.Controls.Add(Me.lblMultasParcial)
        Me.GroupVencidos.Controls.Add(Me.Label17)
        Me.GroupVencidos.Location = New System.Drawing.Point(12, 97)
        Me.GroupVencidos.Name = "GroupVencidos"
        Me.GroupVencidos.Size = New System.Drawing.Size(898, 42)
        Me.GroupVencidos.TabIndex = 178
        Me.GroupVencidos.TabStop = False
        Me.GroupVencidos.Text = "Pagos vencidos"
        '
        'lblTotalParcial
        '
        Me.lblTotalParcial.AutoSize = True
        Me.lblTotalParcial.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalParcial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalParcial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblTotalParcial.Location = New System.Drawing.Point(635, 11)
        Me.lblTotalParcial.Name = "lblTotalParcial"
        Me.lblTotalParcial.Size = New System.Drawing.Size(21, 20)
        Me.lblTotalParcial.TabIndex = 180
        Me.lblTotalParcial.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(599, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Total:"
        '
        'lblDescuentoParcial
        '
        Me.lblDescuentoParcial.AutoSize = True
        Me.lblDescuentoParcial.BackColor = System.Drawing.Color.Transparent
        Me.lblDescuentoParcial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescuentoParcial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblDescuentoParcial.Location = New System.Drawing.Point(489, 11)
        Me.lblDescuentoParcial.Name = "lblDescuentoParcial"
        Me.lblDescuentoParcial.Size = New System.Drawing.Size(21, 20)
        Me.lblDescuentoParcial.TabIndex = 178
        Me.lblDescuentoParcial.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(422, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Descuento:"
        '
        'CheckVencidos
        '
        Me.CheckVencidos.AutoSize = True
        Me.CheckVencidos.Location = New System.Drawing.Point(13, 18)
        Me.CheckVencidos.Name = "CheckVencidos"
        Me.CheckVencidos.Size = New System.Drawing.Size(15, 14)
        Me.CheckVencidos.TabIndex = 175
        Me.CheckVencidos.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(45, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 174
        Me.Label7.Text = "Pago Normal:"
        '
        'lblPagoNormalParcial
        '
        Me.lblPagoNormalParcial.AutoSize = True
        Me.lblPagoNormalParcial.BackColor = System.Drawing.Color.Transparent
        Me.lblPagoNormalParcial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPagoNormalParcial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblPagoNormalParcial.Location = New System.Drawing.Point(122, 13)
        Me.lblPagoNormalParcial.Name = "lblPagoNormalParcial"
        Me.lblPagoNormalParcial.Size = New System.Drawing.Size(21, 20)
        Me.lblPagoNormalParcial.TabIndex = 175
        Me.lblPagoNormalParcial.Text = "..."
        '
        'lblMultasParcial
        '
        Me.lblMultasParcial.AutoSize = True
        Me.lblMultasParcial.BackColor = System.Drawing.Color.Transparent
        Me.lblMultasParcial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblMultasParcial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblMultasParcial.Location = New System.Drawing.Point(306, 13)
        Me.lblMultasParcial.Name = "lblMultasParcial"
        Me.lblMultasParcial.Size = New System.Drawing.Size(21, 20)
        Me.lblMultasParcial.TabIndex = 176
        Me.lblMultasParcial.Text = "..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(259, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "Multas:"
        '
        'RadCollapsiblePanel2
        '
        Me.RadCollapsiblePanel2.IsExpanded = False
        Me.RadCollapsiblePanel2.Location = New System.Drawing.Point(12, 145)
        Me.RadCollapsiblePanel2.Name = "RadCollapsiblePanel2"
        Me.RadCollapsiblePanel2.OwnerBoundsCache = New System.Drawing.Rectangle(12, 145, 898, 280)
        '
        'RadCollapsiblePanel2.PanelContainer
        '
        Me.RadCollapsiblePanel2.PanelContainer.Controls.Add(Me.dtVencidos)
        Me.RadCollapsiblePanel2.PanelContainer.Size = New System.Drawing.Size(0, 0)
        Me.RadCollapsiblePanel2.Size = New System.Drawing.Size(898, 21)
        Me.RadCollapsiblePanel2.TabIndex = 177
        '
        'dtVencidos
        '
        Me.dtVencidos.AllowUserToAddRows = False
        Me.dtVencidos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dtVencidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtVencidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtVencidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtVencidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtVencidos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dtVencidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtVencidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtVencidos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtVencidos.DoubleBuffered = True
        Me.dtVencidos.EnableHeadersVisualStyles = False
        Me.dtVencidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtVencidos.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtVencidos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.dtVencidos.Location = New System.Drawing.Point(-1, 0)
        Me.dtVencidos.Name = "dtVencidos"
        Me.dtVencidos.ReadOnly = True
        Me.dtVencidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtVencidos.RowHeadersVisible = False
        Me.dtVencidos.Size = New System.Drawing.Size(0, 0)
        Me.dtVencidos.TabIndex = 178
        '
        'WizardWelcomePage1
        '
        Me.WizardWelcomePage1.ContentArea = Me.Panel1
        Me.WizardWelcomePage1.Header = "Page header"
        Me.WizardWelcomePage1.Name = "WizardWelcomePage1"
        Me.WizardWelcomePage1.Title = "Fecha límite"
        '
        'WizardPage1
        '
        Me.WizardPage1.ContentArea = Me.Panel2
        Me.WizardPage1.Header = "Page header"
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Title = "Deuda a pagar"
        '
        'BackgroundVencidos
        '
        '
        'BackgroundTotal
        '
        '
        'PromPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(939, 517)
        Me.Controls.Add(Me.RadWizard1)
        Me.Name = "PromPago"
        Me.Text = "PromPago"
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadWizard1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupTotal.ResumeLayout(False)
        Me.GroupTotal.PerformLayout()
        Me.RadCollapsiblePanel1.PanelContainer.ResumeLayout(False)
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCollapsiblePanel1.ResumeLayout(False)
        CType(Me.dtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupVencidos.ResumeLayout(False)
        Me.GroupVencidos.PerformLayout()
        Me.RadCollapsiblePanel2.PanelContainer.ResumeLayout(False)
        CType(Me.RadCollapsiblePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCollapsiblePanel2.ResumeLayout(False)
        CType(Me.dtVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadWizard1 As Telerik.WinControls.UI.RadWizard
    Friend WithEvents WizardCompletionPage1 As Telerik.WinControls.UI.WizardCompletionPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents WizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
    Friend WithEvents WizardPage1 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents Label8 As Label
    Friend WithEvents dateFechaLimite As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents RadCollapsiblePanel1 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents RadCollapsiblePanel2 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMultasTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents GroupTotal As GroupBox
    Friend WithEvents CheckTotal As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPagoNormalTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents GroupVencidos As GroupBox
    Friend WithEvents CheckVencidos As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPagoNormalParcial As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblMultasParcial As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents dtVencidos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundVencidos As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtTotal As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundTotal As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblTotalTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDescuentoTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblDescuentoTotaltext As Label
    Friend WithEvents lblTotalParcial As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDescuentoParcial As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label1 As Label
End Class
