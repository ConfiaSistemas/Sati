using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VistaPreviaDocumento : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var PageLayout1 = new Gnostice.Core.Viewer.PageLayout();
            var FormatterSettings1 = new Gnostice.Documents.FormatterSettings();
            var SpreadSheetFormatterSettings1 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            var PageSettings1 = new Gnostice.Documents.PageSettings();
            var Margins1 = new Gnostice.Documents.Margins();
            var SheetOptions1 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            var SheetOptions2 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            var TxtFormatterSettings1 = new Gnostice.Documents.TXTFormatterSettings();
            var PageSettings2 = new Gnostice.Documents.PageSettings();
            var Margins2 = new Gnostice.Documents.Margins();
            var RenderingSettings1 = new Gnostice.Core.Graphics.RenderingSettings();
            var ImageRenderingSettings1 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            var ResolutionSettings1 = new Gnostice.Core.Graphics.ResolutionSettings();
            var ShapeRenderingSettings1 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            var TextRenderingSettings1 = new Gnostice.Core.Graphics.TextRenderingSettings();
            var ViewerSettings1 = new Gnostice.Core.Viewer.ViewerSettings();
            var Zoom1 = new Gnostice.Core.Viewer.Zoom();
            var PrinterPreferences1 = new Gnostice.Documents.PrinterPreferences();
            var FormatterSettings2 = new Gnostice.Documents.FormatterSettings();
            var SpreadSheetFormatterSettings2 = new Gnostice.Documents.Spreadsheet.SpreadSheetFormatterSettings();
            var PageSettings3 = new Gnostice.Documents.PageSettings();
            var Margins3 = new Gnostice.Documents.Margins();
            var SheetOptions3 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            var SheetOptions4 = new Gnostice.Documents.Spreadsheet.SheetOptions();
            var TxtFormatterSettings2 = new Gnostice.Documents.TXTFormatterSettings();
            var PageSettings4 = new Gnostice.Documents.PageSettings();
            var Margins4 = new Gnostice.Documents.Margins();
            var RenderingSettings2 = new Gnostice.Core.Graphics.RenderingSettings();
            var ImageRenderingSettings2 = new Gnostice.Core.Graphics.ImageRenderingSettings();
            var ResolutionSettings2 = new Gnostice.Core.Graphics.ResolutionSettings();
            var ShapeRenderingSettings2 = new Gnostice.Core.Graphics.ShapeRenderingSettings();
            var TextRenderingSettings2 = new Gnostice.Core.Graphics.TextRenderingSettings();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPreviaDocumento));
            DocumentViewer1 = new Gnostice.Controls.WinForms.DocumentViewer();
            DocumentPrinter1 = new Gnostice.Controls.WinForms.DocumentPrinter();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DocumentViewer1
            // 
            DocumentViewer1.AllowInteractivity = false;
            DocumentViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DocumentViewer1.BackColor = SystemColors.ControlDark;
            DocumentViewer1.BorderWidth = 0f;
            DocumentViewer1.HScrollBar.Enabled = false;
            DocumentViewer1.HScrollBar.LargeChange = 40.0f;
            DocumentViewer1.HScrollBar.Maximum = 0f;
            DocumentViewer1.HScrollBar.Minimum = 0f;
            DocumentViewer1.HScrollBar.SmallChange = 20.0f;
            DocumentViewer1.HScrollBar.Value = 0f;
            DocumentViewer1.HScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            DocumentViewer1.HScrollBar.Visible = false;
            DocumentViewer1.Location = new Point(3, 109);
            DocumentViewer1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            DocumentViewer1.Name = "DocumentViewer1";
            // 
            // 
            // 
            DocumentViewer1.NavigationPane.ActivePage = null;
            DocumentViewer1.NavigationPane.Location = new Point(0, 0);
            DocumentViewer1.NavigationPane.Name = "";
            DocumentViewer1.NavigationPane.TabIndex = 0;
            DocumentViewer1.NavigationPane.Visibility = Gnostice.Core.Viewer.Visibility.Auto;
            DocumentViewer1.NavigationPane.WidthPercentage = 35;
            DocumentViewer1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            DocumentViewer1.PageBreakWidth = 10.0f;
            PageLayout1.Columns = 1;
            PageLayout1.HorizontalSpacing = 5.0d;
            PageLayout1.LayoutMode = Gnostice.Core.Viewer.PageLayoutMode.SinglePage;
            PageLayout1.ScrollMode = Gnostice.Core.Viewer.ScrollMode.Continuous;
            PageLayout1.ShowCoverPage = false;
            PageLayout1.VerticalSpacing = 5.0d;
            DocumentViewer1.PageLayout = PageLayout1;
            DocumentViewer1.PageRotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            SpreadSheetFormatterSettings1.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            PageSettings1.Height = 11.6929f;
            Margins1.Bottom = 1.0f;
            Margins1.Footer = 0f;
            Margins1.Header = 0f;
            Margins1.Left = 1.0f;
            Margins1.Right = 1.0f;
            Margins1.Top = 1.0f;
            PageSettings1.Margin = Margins1;
            PageSettings1.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            PageSettings1.PageSize = Gnostice.Documents.PageSize.A4;
            PageSettings1.Width = 8.2677f;
            SpreadSheetFormatterSettings1.PageSettings = PageSettings1;
            SheetOptions1.Print = false;
            SheetOptions1.View = true;
            SpreadSheetFormatterSettings1.ShowGridlines = SheetOptions1;
            SheetOptions2.Print = false;
            SheetOptions2.View = true;
            SpreadSheetFormatterSettings1.ShowHeadings = SheetOptions2;
            FormatterSettings1.SpreadSheet = SpreadSheetFormatterSettings1;
            PageSettings2.Height = 11.6929f;
            Margins2.Bottom = 1.0f;
            Margins2.Footer = 0f;
            Margins2.Header = 0f;
            Margins2.Left = 1.0f;
            Margins2.Right = 1.0f;
            Margins2.Top = 1.0f;
            PageSettings2.Margin = Margins2;
            PageSettings2.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            PageSettings2.PageSize = Gnostice.Documents.PageSize.A4;
            PageSettings2.Width = 8.2677f;
            TxtFormatterSettings1.PageSettings = PageSettings2;
            FormatterSettings1.TXT = TxtFormatterSettings1;
            DocumentViewer1.Preferences.FormatterSettings = FormatterSettings1;
            DocumentViewer1.Preferences.KeyNavigation = true;
            ImageRenderingSettings1.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            RenderingSettings1.Image = ImageRenderingSettings1;
            ResolutionSettings1.DpiX = 96.0f;
            ResolutionSettings1.DpiY = 96.0f;
            ResolutionSettings1.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            RenderingSettings1.Resolution = ResolutionSettings1;
            ShapeRenderingSettings1.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            ShapeRenderingSettings1.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            ShapeRenderingSettings1.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            ShapeRenderingSettings1.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            RenderingSettings1.Shape = ShapeRenderingSettings1;
            TextRenderingSettings1.TextContrast = 4;
            TextRenderingSettings1.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            RenderingSettings1.Text = TextRenderingSettings1;
            DocumentViewer1.Preferences.RenderingSettings = RenderingSettings1;
            DocumentViewer1.Preferences.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            ViewerSettings1.AllowInteractivity = false;
            ViewerSettings1.MouseMode = Gnostice.Core.DOM.CursorPreferences.Pan;
            ViewerSettings1.Orientation = Gnostice.Core.Viewer.ViewerOrientation.Vertical;
            ViewerSettings1.PageBreakWidth = 10.0f;
            ViewerSettings1.PageLayout = PageLayout1;
            ViewerSettings1.Rotation = Gnostice.Core.Viewer.RotationAngle.Zero;
            Zoom1.InternalZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize;
            Zoom1.InternalZoomPercent = 100.0d;
            Zoom1.ZoomMode = Gnostice.Core.Viewer.ZoomMode.ActualSize;
            Zoom1.ZoomPercent = 100.0d;
            ViewerSettings1.Zoom = Zoom1;
            DocumentViewer1.Preferences.ViewerSettings = ViewerSettings1;
            DocumentViewer1.Size = new Size(1194, 617);
            DocumentViewer1.TabIndex = 0;
            DocumentViewer1.VScrollBar.Enabled = false;
            DocumentViewer1.VScrollBar.LargeChange = 40.0f;
            DocumentViewer1.VScrollBar.Maximum = 0f;
            DocumentViewer1.VScrollBar.Minimum = 0f;
            DocumentViewer1.VScrollBar.SmallChange = 20.0f;
            DocumentViewer1.VScrollBar.Value = 0f;
            DocumentViewer1.VScrollBar.Visibility = Gnostice.Core.Viewer.ScrollBarVisibility.Always;
            DocumentViewer1.VScrollBar.Visible = false;
            // 
            // DocumentPrinter1
            // 
            DocumentPrinter1.AutoRotate = true;
            DocumentPrinter1.OffsetHardMargins = false;
            DocumentPrinter1.PagePositioning.Horizontal = Gnostice.Core.Printer.HPagePosition.Left;
            DocumentPrinter1.PagePositioning.Vertical = Gnostice.Core.Printer.VPagePosition.Top;
            DocumentPrinter1.PageScaling = Gnostice.Core.Printer.PageScalingOptions.Original;
            DocumentPrinter1.PageSelection.CurrentPageNumber = 1;
            DocumentPrinter1.PageSelection.CustomRange = "";
            DocumentPrinter1.PageSelection.SelectionType = Gnostice.Core.Printer.PageSelectionType.All;
            SpreadSheetFormatterSettings2.FormattingMode = Gnostice.Core.DOM.FormattingMode.PreferDocumentSettings;
            PageSettings3.Height = 11.6929f;
            Margins3.Bottom = 1.0f;
            Margins3.Footer = 0f;
            Margins3.Header = 0f;
            Margins3.Left = 1.0f;
            Margins3.Right = 1.0f;
            Margins3.Top = 1.0f;
            PageSettings3.Margin = Margins3;
            PageSettings3.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            PageSettings3.PageSize = Gnostice.Documents.PageSize.A4;
            PageSettings3.Width = 8.2677f;
            SpreadSheetFormatterSettings2.PageSettings = PageSettings3;
            SheetOptions3.Print = false;
            SheetOptions3.View = true;
            SpreadSheetFormatterSettings2.ShowGridlines = SheetOptions3;
            SheetOptions4.Print = false;
            SheetOptions4.View = true;
            SpreadSheetFormatterSettings2.ShowHeadings = SheetOptions4;
            FormatterSettings2.SpreadSheet = SpreadSheetFormatterSettings2;
            PageSettings4.Height = 11.6929f;
            Margins4.Bottom = 1.0f;
            Margins4.Footer = 0f;
            Margins4.Header = 0f;
            Margins4.Left = 1.0f;
            Margins4.Right = 1.0f;
            Margins4.Top = 1.0f;
            PageSettings4.Margin = Margins4;
            PageSettings4.Orientation = Gnostice.Core.Graphics.Orientation.Portrait;
            PageSettings4.PageSize = Gnostice.Documents.PageSize.A4;
            PageSettings4.Width = 8.2677f;
            TxtFormatterSettings2.PageSettings = PageSettings4;
            FormatterSettings2.TXT = TxtFormatterSettings2;
            PrinterPreferences1.FormatterSettings = FormatterSettings2;
            ImageRenderingSettings2.InterpolationMode = Gnostice.Core.Graphics.InterpolationMode.NearestNeighbor;
            RenderingSettings2.Image = ImageRenderingSettings2;
            ResolutionSettings2.DpiX = 96.0f;
            ResolutionSettings2.DpiY = 96.0f;
            ResolutionSettings2.ResolutionMode = Gnostice.Core.Graphics.ResolutionMode.UseSource;
            RenderingSettings2.Resolution = ResolutionSettings2;
            ShapeRenderingSettings2.CompositingMode = Gnostice.Core.Graphics.CompositingMode.SourceOver;
            ShapeRenderingSettings2.CompositingQuality = Gnostice.Core.Graphics.CompositingQuality.Default;
            ShapeRenderingSettings2.PixelOffsetMode = Gnostice.Core.Graphics.PixelOffsetMode.HighQuality;
            ShapeRenderingSettings2.SmoothingMode = Gnostice.Core.Graphics.SmoothingMode.AntiAlias;
            RenderingSettings2.Shape = ShapeRenderingSettings2;
            TextRenderingSettings2.TextContrast = 4;
            TextRenderingSettings2.TextRenderingHint = Gnostice.Core.Graphics.TextRenderingHint.AntiAlias;
            RenderingSettings2.Text = TextRenderingSettings2;
            PrinterPreferences1.RenderingSettings = RenderingSettings2;
            PrinterPreferences1.Units = Gnostice.Core.Graphics.MeasurementUnit.Inches;
            DocumentPrinter1.Preferences = PrinterPreferences1;
            // 
            // Button1
            // 
            Button1.Location = new Point(24, 65);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Imprimir";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(357, 65);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 2;
            Button2.Text = "Button2";
            Button2.UseVisualStyleBackColor = true;
            Button2.Visible = false;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1194, 36);
            Panel1.TabIndex = 3;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(91, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Vista Previa";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(1125, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // VistaPreviaDocumento
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1198, 726);
            Controls.Add(Panel1);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(DocumentViewer1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VistaPreviaDocumento";
            Text = "VistaPreviaDocumento";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(VistaPreviaDocumento_Load);
            Closing += new System.ComponentModel.CancelEventHandler(VistaPreviaDocumento_Closing);
            FormClosed += new FormClosedEventHandler(VistaPreviaDocumento_FormClosed);
            ResumeLayout(false);

        }

        internal Gnostice.Controls.WinForms.DocumentViewer DocumentViewer1;
        internal Gnostice.Controls.WinForms.DocumentPrinter DocumentPrinter1;
        internal Button Button1;
        internal Button Button2;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
    }
}