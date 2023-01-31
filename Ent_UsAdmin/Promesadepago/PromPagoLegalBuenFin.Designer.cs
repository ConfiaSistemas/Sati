using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]


    public partial class PromPagoLegalBuenFin : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            RadWizard1 = new Telerik.WinControls.UI.RadWizard();
            RadWizard1.Next += new Telerik.WinControls.UI.WizardCancelEventHandler(RadWizard1_Next);
            RadWizard1.Finish += new EventHandler(RadWizard1_Finish);
            RadWizard1.Cancel += new EventHandler(RadWizard1_Cancel);
            WizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
            Panel3 = new Panel();
            TextBox1 = new TextBox();
            Panel1 = new Panel();
            Label8 = new Label();
            dateFechaLimite = new Bunifu.Framework.UI.BunifuDatepicker();
            Panel2 = new Panel();
            GroupTotal = new GroupBox();
            lblTotalTotal = new MonoFlat.MonoFlat_HeaderLabel();
            CheckTotal = new CheckBox();
            Label3 = new Label();
            Label16 = new Label();
            lblDescuentoTotal = new MonoFlat.MonoFlat_HeaderLabel();
            lblPagoNormalTotal = new MonoFlat.MonoFlat_HeaderLabel();
            lblDescuentoTotaltext = new Label();
            Label4 = new Label();
            lblMultasTotal = new MonoFlat.MonoFlat_HeaderLabel();
            RadCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            RadCollapsiblePanel1.Expanded += new EventHandler(RadCollapsiblePanel1_Expanded);
            RadCollapsiblePanel1.Expanding += new System.ComponentModel.CancelEventHandler(RadCollapsiblePanel1_Expanding);
            RadCollapsiblePanel1.SizeChanged += new EventHandler(RadCollapsiblePanel1_SizeChanged);
            dtTotal = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            WizardWelcomePage1 = new Telerik.WinControls.UI.WizardWelcomePage();
            WizardPage1 = new Telerik.WinControls.UI.WizardPage();
            BackgroundTotal = new System.ComponentModel.BackgroundWorker();
            BackgroundTotal.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTotal_DoWork);
            BackgroundTotal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTotal_RunWorkerCompleted);
            BackgroundCrearPromesa = new System.ComponentModel.BackgroundWorker();
            BackgroundCrearPromesa.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCrearPromesa_DoWork);
            BackgroundCrearPromesa.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCrearPromesa_RunWorkerCompleted);
            BackgroundConsultarPromesa = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultarPromesa.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultarPromesa_DoWork);
            BackgroundConsultarPromesa.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultarPromesa_RunWorkerCompleted);
            BackgroundPromesaNotificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundPromesaNotificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPromesaNotificacion_DoWork);
            BackgroundPromesaNotificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundPromesaNotificacion_RunWorkerCompleted);
            BackgroundConsultaPromesaPendiente = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultaPromesaPendiente.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultaPromesaPendiente_DoWork);
            BackgroundConsultaPromesaPendiente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultaPromesaPendiente_RunWorkerCompleted);
            ((System.ComponentModel.ISupportInitialize)RadWizard1).BeginInit();
            RadWizard1.SuspendLayout();
            Panel3.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            GroupTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel1).BeginInit();
            RadCollapsiblePanel1.PanelContainer.SuspendLayout();
            RadCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTotal).BeginInit();
            SuspendLayout();
            // 
            // RadWizard1
            // 
            RadWizard1.CompletionPage = WizardCompletionPage1;
            RadWizard1.Controls.Add(Panel1);
            RadWizard1.Controls.Add(Panel2);
            RadWizard1.Controls.Add(Panel3);
            RadWizard1.Dock = DockStyle.Fill;
            RadWizard1.HideCompletionImage = true;
            RadWizard1.HideWelcomeImage = true;
            RadWizard1.Location = new Point(0, 0);
            RadWizard1.Mode = Telerik.WinControls.UI.WizardMode.Aero;
            RadWizard1.Name = "RadWizard1";
            RadWizard1.PageHeaderIcon = null;
            RadWizard1.Pages.Add(WizardWelcomePage1);
            RadWizard1.Pages.Add(WizardPage1);
            RadWizard1.Pages.Add(WizardCompletionPage1);
            RadWizard1.Size = new Size(939, 517);
            RadWizard1.TabIndex = 0;
            RadWizard1.WelcomePage = WizardWelcomePage1;
            ((Telerik.WinControls.UI.WizardAeroView)RadWizard1.GetChildAt(0).GetChildAt(0)).HideWelcomeImage = true;
            ((Telerik.WinControls.UI.WizardAeroView)RadWizard1.GetChildAt(0).GetChildAt(0)).HideCompletionImage = true;
            ((Telerik.WinControls.UI.WizardCommandArea)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3)).IsWelcomePage = false;
            ((Telerik.WinControls.UI.WizardCommandArea)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3)).IsCompletionPage = false;
            ((Telerik.WinControls.UI.WizardCommandAreaButtonElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(1)).IsFocusedWizardButton = false;
            ((Telerik.WinControls.UI.WizardCommandAreaButtonElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(1)).Text = "Generar";
            ((Telerik.WinControls.UI.WizardCommandAreaButtonElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(2)).IsFocusedWizardButton = true;
            ((Telerik.WinControls.UI.WizardCommandAreaButtonElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(2)).Text = "Siguiente >";
            ((Telerik.WinControls.UI.BaseWizardElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(3)).Text = "<html><u>Ayuda</u></html>";
            ((Telerik.WinControls.UI.BaseWizardElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(3)).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.WizardAeroButtonElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(0)).Enabled = true;
            ((Telerik.WinControls.UI.WizardAeroButtonElement)RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(0)).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // WizardCompletionPage1
            // 
            WizardCompletionPage1.ContentArea = Panel3;
            WizardCompletionPage1.Header = "Page header";
            WizardCompletionPage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Visible;
            WizardCompletionPage1.Name = "WizardCompletionPage1";
            WizardCompletionPage1.Title = "Generar promesa de pago";
            WizardCompletionPage1.TitleVisibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.Controls.Add(TextBox1);
            Panel3.Location = new Point(0, 41);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(939, 428);
            Panel3.TabIndex = 2;
            // 
            // TextBox1
            // 
            TextBox1.BorderStyle = BorderStyle.None;
            TextBox1.Font = new Font("Segoe UI Light", 22.0f);
            TextBox1.ForeColor = Color.White;
            TextBox1.Location = new Point(120, 103);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(706, 186);
            TextBox1.TabIndex = 5;
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(dateFechaLimite);
            Panel1.Location = new Point(0, 41);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(939, 428);
            Panel1.TabIndex = 0;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Light", 22.0f);
            Label8.ForeColor = Color.FromArgb(21, 66, 139);
            Label8.Location = new Point(48, 52);
            Label8.Name = "Label8";
            Label8.Size = new Size(572, 41);
            Label8.TabIndex = 43;
            Label8.Text = "Elige la fecha en que deberá pagar el cliente";
            // 
            // dateFechaLimite
            // 
            dateFechaLimite.BackColor = Color.FromArgb(191, 219, 255);
            dateFechaLimite.BorderRadius = 0;
            dateFechaLimite.Enabled = false;
            dateFechaLimite.ForeColor = Color.FromArgb(21, 66, 139);
            dateFechaLimite.Format = DateTimePickerFormat.Short;
            dateFechaLimite.FormatCustom = null;
            dateFechaLimite.Location = new Point(55, 158);
            dateFechaLimite.Name = "dateFechaLimite";
            dateFechaLimite.Size = new Size(177, 33);
            dateFechaLimite.TabIndex = 44;
            dateFechaLimite.Value = new DateTime(2021, 11, 16, 0, 0, 0, 0);
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.White;
            Panel2.Controls.Add(GroupTotal);
            Panel2.Controls.Add(RadCollapsiblePanel1);
            Panel2.Location = new Point(0, 41);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(939, 428);
            Panel2.TabIndex = 1;
            // 
            // GroupTotal
            // 
            GroupTotal.Controls.Add(lblTotalTotal);
            GroupTotal.Controls.Add(CheckTotal);
            GroupTotal.Controls.Add(Label3);
            GroupTotal.Controls.Add(Label16);
            GroupTotal.Controls.Add(lblDescuentoTotal);
            GroupTotal.Controls.Add(lblPagoNormalTotal);
            GroupTotal.Controls.Add(lblDescuentoTotaltext);
            GroupTotal.Controls.Add(Label4);
            GroupTotal.Controls.Add(lblMultasTotal);
            GroupTotal.Location = new Point(13, 0);
            GroupTotal.Name = "GroupTotal";
            GroupTotal.Size = new Size(898, 42);
            GroupTotal.TabIndex = 179;
            GroupTotal.TabStop = false;
            GroupTotal.Text = "Deuda total";
            // 
            // lblTotalTotal
            // 
            lblTotalTotal.AutoSize = true;
            lblTotalTotal.BackColor = Color.Transparent;
            lblTotalTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotalTotal.ForeColor = Color.FromArgb(21, 66, 139);
            lblTotalTotal.Location = new Point(634, 11);
            lblTotalTotal.Name = "lblTotalTotal";
            lblTotalTotal.Size = new Size(21, 20);
            lblTotalTotal.TabIndex = 184;
            lblTotalTotal.Text = "...";
            // 
            // CheckTotal
            // 
            CheckTotal.AutoSize = true;
            CheckTotal.Checked = true;
            CheckTotal.CheckState = CheckState.Checked;
            CheckTotal.Location = new Point(12, 18);
            CheckTotal.Name = "CheckTotal";
            CheckTotal.Size = new Size(15, 14);
            CheckTotal.TabIndex = 174;
            CheckTotal.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.FromArgb(21, 66, 139);
            Label3.Location = new Point(598, 18);
            Label3.Name = "Label3";
            Label3.Size = new Size(34, 13);
            Label3.TabIndex = 185;
            Label3.Text = "Total:";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.ForeColor = Color.FromArgb(21, 66, 139);
            Label16.Location = new Point(44, 19);
            Label16.Name = "Label16";
            Label16.Size = new Size(71, 13);
            Label16.TabIndex = 169;
            Label16.Text = "Pago Normal:";
            // 
            // lblDescuentoTotal
            // 
            lblDescuentoTotal.AutoSize = true;
            lblDescuentoTotal.BackColor = Color.Transparent;
            lblDescuentoTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblDescuentoTotal.ForeColor = Color.FromArgb(21, 66, 139);
            lblDescuentoTotal.Location = new Point(488, 11);
            lblDescuentoTotal.Name = "lblDescuentoTotal";
            lblDescuentoTotal.Size = new Size(21, 20);
            lblDescuentoTotal.TabIndex = 182;
            lblDescuentoTotal.Text = "...";
            // 
            // lblPagoNormalTotal
            // 
            lblPagoNormalTotal.AutoSize = true;
            lblPagoNormalTotal.BackColor = Color.Transparent;
            lblPagoNormalTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblPagoNormalTotal.ForeColor = Color.FromArgb(21, 66, 139);
            lblPagoNormalTotal.Location = new Point(121, 12);
            lblPagoNormalTotal.Name = "lblPagoNormalTotal";
            lblPagoNormalTotal.Size = new Size(21, 20);
            lblPagoNormalTotal.TabIndex = 170;
            lblPagoNormalTotal.Text = "...";
            // 
            // lblDescuentoTotaltext
            // 
            lblDescuentoTotaltext.AutoSize = true;
            lblDescuentoTotaltext.ForeColor = Color.FromArgb(21, 66, 139);
            lblDescuentoTotaltext.Location = new Point(421, 18);
            lblDescuentoTotaltext.Name = "lblDescuentoTotaltext";
            lblDescuentoTotaltext.Size = new Size(62, 13);
            lblDescuentoTotaltext.TabIndex = 183;
            lblDescuentoTotaltext.Text = "Descuento:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.FromArgb(21, 66, 139);
            Label4.Location = new Point(258, 19);
            Label4.Name = "Label4";
            Label4.Size = new Size(41, 13);
            Label4.TabIndex = 173;
            Label4.Text = "Multas:";
            // 
            // lblMultasTotal
            // 
            lblMultasTotal.AutoSize = true;
            lblMultasTotal.BackColor = Color.Transparent;
            lblMultasTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMultasTotal.ForeColor = Color.FromArgb(21, 66, 139);
            lblMultasTotal.Location = new Point(305, 12);
            lblMultasTotal.Name = "lblMultasTotal";
            lblMultasTotal.Size = new Size(21, 20);
            lblMultasTotal.TabIndex = 172;
            lblMultasTotal.Text = "...";
            // 
            // RadCollapsiblePanel1
            // 
            RadCollapsiblePanel1.IsExpanded = false;
            RadCollapsiblePanel1.Location = new Point(15, 48);
            RadCollapsiblePanel1.Name = "RadCollapsiblePanel1";
            RadCollapsiblePanel1.OwnerBoundsCache = new Rectangle(15, 48, 898, 259);
            // 
            // RadCollapsiblePanel1.PanelContainer
            // 
            RadCollapsiblePanel1.PanelContainer.Controls.Add(dtTotal);
            RadCollapsiblePanel1.PanelContainer.Size = new Size(0, 0);
            RadCollapsiblePanel1.Size = new Size(898, 21);
            RadCollapsiblePanel1.TabIndex = 0;
            // 
            // dtTotal
            // 
            dtTotal.AllowUserToAddRows = false;
            dtTotal.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(158, 185, 220);
            dtTotal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtTotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtTotal.BackgroundColor = Color.FromArgb(191, 219, 255);
            dtTotal.BorderStyle = BorderStyle.None;
            dtTotal.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dtTotal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(191, 219, 255);
            DataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25f);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(21, 66, 139);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtTotal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(191, 219, 255);
            DataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25f);
            DataGridViewCellStyle3.ForeColor = Color.Black;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtTotal.DefaultCellStyle = DataGridViewCellStyle3;
            dtTotal.DoubleBuffered = true;
            dtTotal.EnableHeadersVisualStyles = false;
            dtTotal.GridColor = Color.FromArgb(191, 219, 255);
            dtTotal.HeaderBgColor = Color.FromArgb(191, 219, 255);
            dtTotal.HeaderForeColor = Color.FromArgb(21, 66, 139);
            dtTotal.Location = new Point(2, -2);
            dtTotal.Name = "dtTotal";
            dtTotal.ReadOnly = true;
            dtTotal.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtTotal.RowHeadersVisible = false;
            dtTotal.Size = new Size(0, 4);
            dtTotal.TabIndex = 179;
            // 
            // WizardWelcomePage1
            // 
            WizardWelcomePage1.ContentArea = Panel1;
            WizardWelcomePage1.Header = "Page header";
            WizardWelcomePage1.Name = "WizardWelcomePage1";
            WizardWelcomePage1.Title = "Fecha límite";
            // 
            // WizardPage1
            // 
            WizardPage1.ContentArea = Panel2;
            WizardPage1.Header = "Page header";
            WizardPage1.Name = "WizardPage1";
            WizardPage1.Title = "Deuda a pagar";
            // 
            // BackgroundTotal
            // 
            // 
            // BackgroundCrearPromesa
            // 
            // 
            // BackgroundConsultarPromesa
            // 
            // 
            // BackgroundPromesaNotificacion
            // 
            // 
            // BackgroundConsultaPromesaPendiente
            // 
            // 
            // PromPagoLegalBuenFin
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(939, 517);
            Controls.Add(RadWizard1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            KeyPreview = true;
            MaximumSize = new Size(955, 556);
            MinimumSize = new Size(955, 556);
            Name = "PromPagoLegalBuenFin";
            Text = "Promesa de pago";
            ((System.ComponentModel.ISupportInitialize)RadWizard1).EndInit();
            RadWizard1.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            GroupTotal.ResumeLayout(false);
            GroupTotal.PerformLayout();
            RadCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel1).EndInit();
            RadCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtTotal).EndInit();
            Load += new EventHandler(PromPago_Load);
            ResumeLayout(false);

        }

        internal Telerik.WinControls.UI.RadWizard RadWizard1;
        internal Telerik.WinControls.UI.WizardCompletionPage WizardCompletionPage1;
        internal Panel Panel3;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Telerik.WinControls.UI.WizardWelcomePage WizardWelcomePage1;
        internal Telerik.WinControls.UI.WizardPage WizardPage1;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuDatepicker dateFechaLimite;
        internal Telerik.WinControls.UI.RadCollapsiblePanel RadCollapsiblePanel1;
        internal Label Label4;
        internal MonoFlat.MonoFlat_HeaderLabel lblMultasTotal;
        internal GroupBox GroupTotal;
        internal CheckBox CheckTotal;
        internal Label Label16;
        internal MonoFlat.MonoFlat_HeaderLabel lblPagoNormalTotal;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtTotal;
        internal System.ComponentModel.BackgroundWorker BackgroundTotal;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotalTotal;
        internal Label Label3;
        internal MonoFlat.MonoFlat_HeaderLabel lblDescuentoTotal;
        internal Label lblDescuentoTotaltext;
        internal TextBox TextBox1;
        internal System.ComponentModel.BackgroundWorker BackgroundCrearPromesa;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultarPromesa;
        internal System.ComponentModel.BackgroundWorker BackgroundPromesaNotificacion;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultaPromesaPendiente;
    }
}