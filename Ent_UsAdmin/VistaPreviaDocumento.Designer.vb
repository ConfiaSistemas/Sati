<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VistaPreviaDocumento
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
        Dim PageLayout1 As Gnostice.Core.Viewer.PageLayout = New Gnostice.Core.Viewer.PageLayout()
        Dim FormatterSettings1 As Gnostice.Documents.FormatterSettings = New Gnostice.Documents.FormatterSettings()
        Dim SpreadSheetFormatterSettings1 As Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings = New Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings()
        Dim PageSettings1 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins1 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim SheetOptions1 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim SheetOptions2 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim TxtFormatterSettings1 As Gnostice.Documents.TXTFormatterSettings = New Gnostice.Documents.TXTFormatterSettings()
        Dim PageSettings2 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins2 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim RenderingSettings1 As Gnostice.Core.Graphics.RenderingSettings = New Gnostice.Core.Graphics.RenderingSettings()
        Dim ImageRenderingSettings1 As Gnostice.Core.Graphics.ImageRenderingSettings = New Gnostice.Core.Graphics.ImageRenderingSettings()
        Dim ResolutionSettings1 As Gnostice.Core.Graphics.ResolutionSettings = New Gnostice.Core.Graphics.ResolutionSettings()
        Dim ShapeRenderingSettings1 As Gnostice.Core.Graphics.ShapeRenderingSettings = New Gnostice.Core.Graphics.ShapeRenderingSettings()
        Dim TextRenderingSettings1 As Gnostice.Core.Graphics.TextRenderingSettings = New Gnostice.Core.Graphics.TextRenderingSettings()
        Dim ViewerSettings1 As Gnostice.Core.Viewer.ViewerSettings = New Gnostice.Core.Viewer.ViewerSettings()
        Dim Zoom1 As Gnostice.Core.Viewer.Zoom = New Gnostice.Core.Viewer.Zoom()
        Dim PrinterPreferences1 As Gnostice.Documents.PrinterPreferences = New Gnostice.Documents.PrinterPreferences()
        Dim FormatterSettings2 As Gnostice.Documents.FormatterSettings = New Gnostice.Documents.FormatterSettings()
        Dim SpreadSheetFormatterSettings2 As Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings = New Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings()
        Dim PageSettings3 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins3 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim SheetOptions3 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim SheetOptions4 As Gnostice.Documents.Spreadsheet.SheetOptions = New Gnostice.Documents.Spreadsheet.SheetOptions()
        Dim TxtFormatterSettings2 As Gnostice.Documents.TXTFormatterSettings = New Gnostice.Documents.TXTFormatterSettings()
        Dim PageSettings4 As Gnostice.Documents.PageSettings = New Gnostice.Documents.PageSettings()
        Dim Margins4 As Gnostice.Documents.Margins = New Gnostice.Documents.Margins()
        Dim RenderingSettings2 As Gnostice.Core.Graphics.RenderingSettings = New Gnostice.Core.Graphics.RenderingSettings()
        Dim ImageRenderingSettings2 As Gnostice.Core.Graphics.ImageRenderingSettings = New Gnostice.Core.Graphics.ImageRenderingSettings()
        Dim ResolutionSettings2 As Gnostice.Core.Graphics.ResolutionSettings = New Gnostice.Core.Graphics.ResolutionSettings()
        Dim ShapeRenderingSettings2 As Gnostice.Core.Graphics.ShapeRenderingSettings = New Gnostice.Core.Graphics.ShapeRenderingSettings()
        Dim TextRenderingSettings2 As Gnostice.Core.Graphics.TextRenderingSettings = New Gnostice.Core.Graphics.TextRenderingSettings()
        Me.DocumentViewer1 = New Gnostice.Controls.WinForms.DocumentViewer()
        Me.DocumentPrinter1 = New Gnostice.Controls.WinForms.DocumentPrinter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.AllowInteractivity = False
        Me.DocumentViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocumentViewer1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DocumentViewer1.BorderWidth = 0!
        Me.DocumentViewer1.HScrollBar.Enabled = False
        Me.DocumentViewer1.HScrollBar.LargeChange = 40.0!
        Me.DocumentViewer1.HScrollBar.Maximum = 0!
        Me.DocumentViewer1.HScrollBar.Minimum = 0!
        Me.DocumentViewer1.HScrollBar.SmallChange = 20.0!
        Me.DocumentViewer1.HScrollBar.Value = 0!
        Me.DocumentViewer1.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always
        Me.DocumentViewer1.HScrollBar.Visible = False
        Me.DocumentViewer1.Location = New System.Drawing.Point(3, 109)
        Me.DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan
        Me.DocumentViewer1.Name = "DocumentViewer1"
        '
        '
        '
        Me.DocumentViewer1.NavigationPane.ActivePage = Nothing
        Me.DocumentViewer1.NavigationPane.Location = New System.Drawing.Point(0, 0)
        Me.DocumentViewer1.NavigationPane.Name = ""
        Me.DocumentViewer1.NavigationPane.TabIndex = 0
        Me.DocumentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.[Auto]
        Me.DocumentViewer1.NavigationPane.WidthPercentage = 35
        Me.DocumentViewer1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical
        Me.DocumentViewer1.PageBreakWidth = 10.0!
        PageLayout1.Columns = 1
        PageLayout1.HorizontalSpacing = 5.0R
        PageLayout1.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage
        PageLayout1.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous
        PageLayout1.ShowCoverPage = False
        PageLayout1.VerticalSpacing = 5.0R
        Me.DocumentViewer1.PageLayout = PageLayout1
        Me.DocumentViewer1.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero
        SpreadSheetFormatterSettings1.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings
        PageSettings1.Height = 11.6929!
        Margins1.Bottom = 1.0!
        Margins1.Footer = 0!
        Margins1.Header = 0!
        Margins1.Left = 1.0!
        Margins1.Right = 1.0!
        Margins1.Top = 1.0!
        PageSettings1.Margin = Margins1
        PageSettings1.Orientation = Gnostice.Core.Graphics.Orientation.Portrait
        PageSettings1.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings1.Width = 8.2677!
        SpreadSheetFormatterSettings1.PageSettings = PageSettings1
        SheetOptions1.Print = False
        SheetOptions1.View = True
        SpreadSheetFormatterSettings1.ShowGridlines = SheetOptions1
        SheetOptions2.Print = False
        SheetOptions2.View = True
        SpreadSheetFormatterSettings1.ShowHeadings = SheetOptions2
        FormatterSettings1.SpreadSheet = SpreadSheetFormatterSettings1
        PageSettings2.Height = 11.6929!
        Margins2.Bottom = 1.0!
        Margins2.Footer = 0!
        Margins2.Header = 0!
        Margins2.Left = 1.0!
        Margins2.Right = 1.0!
        Margins2.Top = 1.0!
        PageSettings2.Margin = Margins2
        PageSettings2.Orientation = Gnostice.Core.Graphics.Orientation.Portrait
        PageSettings2.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings2.Width = 8.2677!
        TxtFormatterSettings1.PageSettings = PageSettings2
        FormatterSettings1.TXT = TxtFormatterSettings1
        Me.DocumentViewer1.Preferences.FormatterSettings = FormatterSettings1
        Me.DocumentViewer1.Preferences.KeyNavigation = True
        ImageRenderingSettings1.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor
        RenderingSettings1.Image = ImageRenderingSettings1
        ResolutionSettings1.DpiX = 96.0!
        ResolutionSettings1.DpiY = 96.0!
        ResolutionSettings1.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource
        RenderingSettings1.Resolution = ResolutionSettings1
        ShapeRenderingSettings1.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver
        ShapeRenderingSettings1.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.[Default]
        ShapeRenderingSettings1.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality
        ShapeRenderingSettings1.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias
        RenderingSettings1.Shape = ShapeRenderingSettings1
        TextRenderingSettings1.TextContrast = 4
        TextRenderingSettings1.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias
        RenderingSettings1.Text = TextRenderingSettings1
        Me.DocumentViewer1.Preferences.RenderingSettings = RenderingSettings1
        Me.DocumentViewer1.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches
        ViewerSettings1.AllowInteractivity = False
        ViewerSettings1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan
        ViewerSettings1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical
        ViewerSettings1.PageBreakWidth = 10.0!
        ViewerSettings1.PageLayout = PageLayout1
        ViewerSettings1.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero
        Zoom1.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize
        Zoom1.InternalZoomPercent = 100.0R
        Zoom1.ZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize
        Zoom1.ZoomPercent = 100.0R
        ViewerSettings1.Zoom = Zoom1
        Me.DocumentViewer1.Preferences.ViewerSettings = ViewerSettings1
        Me.DocumentViewer1.Size = New System.Drawing.Size(1194, 617)
        Me.DocumentViewer1.TabIndex = 0
        Me.DocumentViewer1.VScrollBar.Enabled = False
        Me.DocumentViewer1.VScrollBar.LargeChange = 40.0!
        Me.DocumentViewer1.VScrollBar.Maximum = 0!
        Me.DocumentViewer1.VScrollBar.Minimum = 0!
        Me.DocumentViewer1.VScrollBar.SmallChange = 20.0!
        Me.DocumentViewer1.VScrollBar.Value = 0!
        Me.DocumentViewer1.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always
        Me.DocumentViewer1.VScrollBar.Visible = False
        '
        'DocumentPrinter1
        '
        Me.DocumentPrinter1.AutoRotate = True
        Me.DocumentPrinter1.OffsetHardMargins = False
        Me.DocumentPrinter1.PagePositioning.Horizontal = Gnostice.Core.Printer.HPagePosition.Left
        Me.DocumentPrinter1.PagePositioning.Vertical = Gnostice.Core.Printer.VPagePosition.Top
        Me.DocumentPrinter1.PageScaling = Gnostice.Core.Printer.PageScalingOptions.Original
        Me.DocumentPrinter1.PageSelection.CurrentPageNumber = 1
        Me.DocumentPrinter1.PageSelection.CustomRange = ""
        Me.DocumentPrinter1.PageSelection.SelectionType = Gnostice.Core.Printer.PageSelectionType.All
        SpreadSheetFormatterSettings2.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings
        PageSettings3.Height = 11.6929!
        Margins3.Bottom = 1.0!
        Margins3.Footer = 0!
        Margins3.Header = 0!
        Margins3.Left = 1.0!
        Margins3.Right = 1.0!
        Margins3.Top = 1.0!
        PageSettings3.Margin = Margins3
        PageSettings3.Orientation = Gnostice.Core.Graphics.Orientation.Portrait
        PageSettings3.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings3.Width = 8.2677!
        SpreadSheetFormatterSettings2.PageSettings = PageSettings3
        SheetOptions3.Print = False
        SheetOptions3.View = True
        SpreadSheetFormatterSettings2.ShowGridlines = SheetOptions3
        SheetOptions4.Print = False
        SheetOptions4.View = True
        SpreadSheetFormatterSettings2.ShowHeadings = SheetOptions4
        FormatterSettings2.SpreadSheet = SpreadSheetFormatterSettings2
        PageSettings4.Height = 11.6929!
        Margins4.Bottom = 1.0!
        Margins4.Footer = 0!
        Margins4.Header = 0!
        Margins4.Left = 1.0!
        Margins4.Right = 1.0!
        Margins4.Top = 1.0!
        PageSettings4.Margin = Margins4
        PageSettings4.Orientation = Gnostice.Core.Graphics.Orientation.Portrait
        PageSettings4.PageSize = Gnostice.Documents.PageSize.A4
        PageSettings4.Width = 8.2677!
        TxtFormatterSettings2.PageSettings = PageSettings4
        FormatterSettings2.TXT = TxtFormatterSettings2
        PrinterPreferences1.FormatterSettings = FormatterSettings2
        ImageRenderingSettings2.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor
        RenderingSettings2.Image = ImageRenderingSettings2
        ResolutionSettings2.DpiX = 96.0!
        ResolutionSettings2.DpiY = 96.0!
        ResolutionSettings2.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource
        RenderingSettings2.Resolution = ResolutionSettings2
        ShapeRenderingSettings2.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver
        ShapeRenderingSettings2.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.[Default]
        ShapeRenderingSettings2.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality
        ShapeRenderingSettings2.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias
        RenderingSettings2.Shape = ShapeRenderingSettings2
        TextRenderingSettings2.TextContrast = 4
        TextRenderingSettings2.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias
        RenderingSettings2.Text = TextRenderingSettings2
        PrinterPreferences1.RenderingSettings = RenderingSettings2
        PrinterPreferences1.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches
        Me.DocumentPrinter1.Preferences = PrinterPreferences1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(357, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 36)
        Me.Panel1.TabIndex = 3
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(91, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Vista Previa"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(1125, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'VistaPreviaDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1198, 726)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VistaPreviaDocumento"
        Me.Text = "VistaPreviaDocumento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocumentViewer1 As Gnostice.Controls.WinForms.DocumentViewer
    Friend WithEvents DocumentPrinter1 As Gnostice.Controls.WinForms.DocumentPrinter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
End Class
