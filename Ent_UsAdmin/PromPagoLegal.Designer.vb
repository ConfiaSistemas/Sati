<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PromPagoLegal

    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadWizard1 = New Telerik.WinControls.UI.RadWizard()
        Me.WizardCompletionPage1 = New Telerik.WinControls.UI.WizardCompletionPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage()
        Me.BackgroundTotal = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCrearPromesa = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundConsultarPromesa = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundPromesaNotificacion = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundConsultaPromesaPendiente = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadWizard1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupTotal.SuspendLayout()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCollapsiblePanel1.PanelContainer.SuspendLayout()
        Me.RadCollapsiblePanel1.SuspendLayout()
        CType(Me.dtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWizard1
        '
        Me.RadWizard1.CompletionPage = Me.WizardCompletionPage1
        Me.RadWizard1.Controls.Add(Me.Panel1)
        Me.RadWizard1.Controls.Add(Me.Panel2)
        Me.RadWizard1.Controls.Add(Me.Panel3)
        Me.RadWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadWizard1.HideCompletionImage = True
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
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardAeroView).HideCompletionImage = True
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WizardCommandArea).IsWelcomePage = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.WizardCommandArea).IsCompletionPage = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(1), Telerik.WinControls.UI.WizardCommandAreaButtonElement).IsFocusedWizardButton = False
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(1), Telerik.WinControls.UI.WizardCommandAreaButtonElement).Text = "Generar"
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(2), Telerik.WinControls.UI.WizardCommandAreaButtonElement).IsFocusedWizardButton = True
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(2), Telerik.WinControls.UI.WizardCommandAreaButtonElement).Text = "Siguiente >"
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(3), Telerik.WinControls.UI.BaseWizardElement).Text = "<html><u>Ayuda</u></html>"
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(3), Telerik.WinControls.UI.BaseWizardElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(0), Telerik.WinControls.UI.WizardAeroButtonElement).Enabled = True
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(0), Telerik.WinControls.UI.WizardAeroButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'WizardCompletionPage1
        '
        Me.WizardCompletionPage1.ContentArea = Me.Panel3
        Me.WizardCompletionPage1.Header = "Page header"
        Me.WizardCompletionPage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Visible
        Me.WizardCompletionPage1.Name = "WizardCompletionPage1"
        Me.WizardCompletionPage1.Title = "Generar promesa de pago"
        Me.WizardCompletionPage1.TitleVisibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(939, 428)
        Me.Panel3.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Light", 22.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(120, 103)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(706, 186)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.CheckTotal.Checked = True
        Me.CheckTotal.CheckState = System.Windows.Forms.CheckState.Checked
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
        'BackgroundTotal
        '
        '
        'BackgroundCrearPromesa
        '
        '
        'BackgroundConsultarPromesa
        '
        '
        'BackgroundPromesaNotificacion
        '
        '
        'BackgroundConsultaPromesaPendiente
        '
        '
        'PromPagoLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(939, 517)
        Me.Controls.Add(Me.RadWizard1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(955, 556)
        Me.MinimumSize = New System.Drawing.Size(955, 556)
        Me.Name = "PromPagoLegal"
        Me.Text = "Promesa de pago"
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadWizard1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupTotal.ResumeLayout(False)
        Me.GroupTotal.PerformLayout()
        Me.RadCollapsiblePanel1.PanelContainer.ResumeLayout(False)
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadCollapsiblePanel1.ResumeLayout(False)
        CType(Me.dtTotal, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMultasTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents GroupTotal As GroupBox
    Friend WithEvents CheckTotal As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPagoNormalTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents dtTotal As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundTotal As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblTotalTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDescuentoTotal As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblDescuentoTotaltext As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BackgroundCrearPromesa As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundConsultarPromesa As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundPromesaNotificacion As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundConsultaPromesaPendiente As System.ComponentModel.BackgroundWorker
End Class
