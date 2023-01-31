using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class ReporteLegal : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteLegal));
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtimpuestos.CellToolTipTextNeeded += new DataGridViewCellToolTipTextNeededEventHandler(dtimpuestos_CellToolTipTextNeeded);
            dtimpuestos.CellDoubleClick += new DataGridViewCellEventHandler(dtimpuestos_CellDoubleClick);
            Panel1 = new Panel();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            Label6 = new Label();
            ComboFiltro = new ComboBox();
            ComboFiltro.SelectedIndexChanged += new EventHandler(ComboFiltro_SelectedIndexChanged);
            BackgroundAbogados = new System.ComponentModel.BackgroundWorker();
            BackgroundAbogados.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundAbogados_DoWork);
            BackgroundAbogados.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundAbogados_RunWorkerCompleted);
            ComboElección = new ComboBox();
            BackgroundConsulta = new System.ComponentModel.BackgroundWorker();
            BackgroundConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsulta_DoWork);
            BackgroundConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsulta_RunWorkerCompleted);
            BackgroundExcel = new System.ComponentModel.BackgroundWorker();
            BackgroundExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundExcel_DoWork);
            BackgroundExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundExcel_RunWorkerCompleted);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            lblTotal = new MonoFlat.MonoFlat_HeaderLabel();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtnombre.KeyDown += new KeyEventHandler(txtnombre_KeyDown);
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            lblConConvenio = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel6 = new MonoFlat.MonoFlat_HeaderLabel();
            lblSinConvenio = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel8 = new MonoFlat.MonoFlat_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(63, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(179, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Cuentas activas en Legal";
            // 
            // dtimpuestos
            // 
            dtimpuestos.AllowUserToAddRows = false;
            dtimpuestos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtimpuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtimpuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtimpuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtimpuestos.BackgroundColor = Color.Gainsboro;
            dtimpuestos.BorderStyle = BorderStyle.None;
            dtimpuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtimpuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtimpuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(1, 130);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(1066, 447);
            dtimpuestos.TabIndex = 7;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(Button2);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1066, 36);
            Panel1.TabIndex = 8;
            // 
            // Button2
            // 
            Button2.FlatAppearance.BorderColor = Color.White;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = SystemColors.Control;
            Button2.Location = new Point(3, 3);
            Button2.Name = "Button2";
            Button2.Size = new Size(54, 23);
            Button2.TabIndex = 34;
            Button2.Text = "Atrás";
            Button2.UseVisualStyleBackColor = true;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton21.BackColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Exportar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(969, 3);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 4;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(19, 46);
            Label6.Name = "Label6";
            Label6.Size = new Size(50, 13);
            Label6.TabIndex = 32;
            Label6.Text = "Filtrar por";
            // 
            // ComboFiltro
            // 
            ComboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFiltro.FormattingEnabled = true;
            ComboFiltro.Items.AddRange(new object[] { "Todos", "Abogado" });
            ComboFiltro.Location = new Point(22, 65);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(240, 21);
            ComboFiltro.TabIndex = 30;
            // 
            // BackgroundAbogados
            // 
            // 
            // ComboElección
            // 
            ComboElección.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboElección.FormattingEnabled = true;
            ComboElección.ItemHeight = 13;
            ComboElección.Location = new Point(268, 65);
            ComboElección.Name = "ComboElección";
            ComboElección.Size = new Size(239, 21);
            ComboElección.TabIndex = 31;
            // 
            // BackgroundConsulta
            // 
            // 
            // BackgroundExcel
            // 
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Consultar";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.SeaGreen;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.SeaGreen;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(527, 58);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 5;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(803, 103);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(122, 20);
            MonoFlat_HeaderLabel2.TabIndex = 33;
            MonoFlat_HeaderLabel2.Text = "Total Pendiente:";
            MonoFlat_HeaderLabel2.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(255, 255, 255);
            lblTotal.Location = new Point(935, 103);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 20);
            lblTotal.TabIndex = 34;
            lblTotal.Text = ".";
            lblTotal.Visible = false;
            // 
            // txtnombre
            // 
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.White;
            txtnombre.HintForeColor = Color.White;
            txtnombre.HintText = "";
            txtnombre.isPassword = false;
            txtnombre.LineFocusedColor = Color.Blue;
            txtnombre.LineIdleColor = Color.Gray;
            txtnombre.LineMouseHoverColor = Color.Blue;
            txtnombre.LineThickness = 3;
            txtnombre.Location = new Point(71, 93);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(217, 25);
            txtnombre.TabIndex = 35;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(19, 102);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(42, 15);
            MonoFlat_Label1.TabIndex = 36;
            MonoFlat_Label1.Text = "Buscar";
            // 
            // lblConConvenio
            // 
            lblConConvenio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblConConvenio.AutoSize = true;
            lblConConvenio.BackColor = Color.Transparent;
            lblConConvenio.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblConConvenio.ForeColor = Color.FromArgb(255, 255, 255);
            lblConConvenio.Location = new Point(935, 76);
            lblConConvenio.Name = "lblConConvenio";
            lblConConvenio.Size = new Size(13, 20);
            lblConConvenio.TabIndex = 40;
            lblConConvenio.Text = ".";
            lblConConvenio.Visible = false;
            // 
            // MonoFlat_HeaderLabel6
            // 
            MonoFlat_HeaderLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MonoFlat_HeaderLabel6.AutoSize = true;
            MonoFlat_HeaderLabel6.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel6.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel6.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel6.Location = new Point(746, 76);
            MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6";
            MonoFlat_HeaderLabel6.Size = new Size(179, 20);
            MonoFlat_HeaderLabel6.TabIndex = 39;
            MonoFlat_HeaderLabel6.Text = "Pendiente con convenio:";
            MonoFlat_HeaderLabel6.Visible = false;
            // 
            // lblSinConvenio
            // 
            lblSinConvenio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSinConvenio.AutoSize = true;
            lblSinConvenio.BackColor = Color.Transparent;
            lblSinConvenio.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblSinConvenio.ForeColor = Color.FromArgb(255, 255, 255);
            lblSinConvenio.Location = new Point(935, 56);
            lblSinConvenio.Name = "lblSinConvenio";
            lblSinConvenio.Size = new Size(13, 20);
            lblSinConvenio.TabIndex = 42;
            lblSinConvenio.Text = ".";
            lblSinConvenio.Visible = false;
            // 
            // MonoFlat_HeaderLabel8
            // 
            MonoFlat_HeaderLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MonoFlat_HeaderLabel8.AutoSize = true;
            MonoFlat_HeaderLabel8.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel8.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel8.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel8.Location = new Point(751, 56);
            MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8";
            MonoFlat_HeaderLabel8.Size = new Size(174, 20);
            MonoFlat_HeaderLabel8.TabIndex = 41;
            MonoFlat_HeaderLabel8.Text = "Pendiente sin convenio:";
            MonoFlat_HeaderLabel8.Visible = false;
            // 
            // ReporteLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1069, 581);
            Controls.Add(lblSinConvenio);
            Controls.Add(MonoFlat_HeaderLabel8);
            Controls.Add(lblConConvenio);
            Controls.Add(MonoFlat_HeaderLabel6);
            Controls.Add(txtnombre);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(lblTotal);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label6);
            Controls.Add(ComboElección);
            Controls.Add(ComboFiltro);
            Controls.Add(dtimpuestos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReporteLegal";
            Text = "Créditos en mora";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(ReporteLegal_Load);
            Resize += new EventHandler(CreditosEnMora_Resize);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Label Label6;
        internal ComboBox ComboFiltro;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal System.ComponentModel.BackgroundWorker BackgroundAbogados;
        internal ComboBox ComboElección;
        internal System.ComponentModel.BackgroundWorker BackgroundConsulta;
        internal System.ComponentModel.BackgroundWorker BackgroundExcel;
        internal Button Button2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotal;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_HeaderLabel lblConConvenio;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel6;
        internal MonoFlat.MonoFlat_HeaderLabel lblSinConvenio;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel8;
    }
}