using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class ValorCartera : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ValorCartera));
            var ChartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            var Legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            var Series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            var Series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            Panel1 = new Panel();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            Label6 = new Label();
            ComboFiltro = new ComboBox();
            ComboFiltro.SelectedIndexChanged += new EventHandler(ComboFiltro_SelectedIndexChanged);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            BackgroundGestores = new System.ComponentModel.BackgroundWorker();
            BackgroundGestores.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGestores_DoWork);
            BackgroundGestores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGestores_RunWorkerCompleted);
            BackgroundPromotores = new System.ComponentModel.BackgroundWorker();
            BackgroundPromotores.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPromotores_DoWork);
            BackgroundPromotores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundPromotores_RunWorkerCompleted);
            ComboElección = new ComboBox();
            BackgroundConsulta = new System.ComponentModel.BackgroundWorker();
            BackgroundConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsulta_DoWork);
            BackgroundConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsulta_RunWorkerCompleted);
            BackgroundExcel = new System.ComponentModel.BackgroundWorker();
            BackgroundExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundExcel_DoWork);
            BackgroundExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundExcel_RunWorkerCompleted);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label7 = new Label();
            Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            WebBrowser1 = new WebBrowser();
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart2).BeginInit();
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
            MonoFlat_HeaderLabel1.Size = new Size(100, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Valor Cartera";
            // 
            // dtimpuestos
            // 
            dtimpuestos.AllowUserToAddRows = false;
            dtimpuestos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dtimpuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3;
            dtimpuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtimpuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtimpuestos.BackgroundColor = Color.Gainsboro;
            dtimpuestos.BorderStyle = BorderStyle.None;
            dtimpuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle4.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtimpuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dtimpuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(1, 229);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(1194, 340);
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
            Panel1.Size = new Size(1194, 36);
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
            Button2.TabIndex = 36;
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
            BunifuThinButton21.Location = new Point(1097, 3);
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
            Label6.Location = new Point(19, 47);
            Label6.Name = "Label6";
            Label6.Size = new Size(50, 13);
            Label6.TabIndex = 32;
            Label6.Text = "Filtrar por";
            // 
            // ComboFiltro
            // 
            ComboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFiltro.FormattingEnabled = true;
            ComboFiltro.Items.AddRange(new object[] { "Todos", "Gestor", "Promotor" });
            ComboFiltro.Location = new Point(22, 77);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(240, 21);
            ComboFiltro.TabIndex = 30;
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
            BunifuThinButton22.Location = new Point(515, 67);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 5;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundGestores
            // 
            // 
            // BackgroundPromotores
            // 
            // 
            // ComboElección
            // 
            ComboElección.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboElección.FormattingEnabled = true;
            ComboElección.ItemHeight = 13;
            ComboElección.Location = new Point(268, 77);
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
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel1.Location = new Point(8, 154);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(781, 69);
            FlowLayoutPanel1.TabIndex = 33;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(12, 138);
            Label1.Name = "Label1";
            Label1.Size = new Size(120, 13);
            Label1.TabIndex = 34;
            Label1.Text = "Valor Cartera Sin Multas";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(142, 138);
            Label2.Name = "Label2";
            Label2.Size = new Size(124, 13);
            Label2.TabIndex = 35;
            Label2.Text = "Valor Cartera Con Multas";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(272, 138);
            Label3.Name = "Label3";
            Label3.Size = new Size(80, 13);
            Label3.TabIndex = 36;
            Label3.Text = "Vencido normal";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(398, 138);
            Label4.Name = "Label4";
            Label4.Size = new Size(101, 13);
            Label4.TabIndex = 37;
            Label4.Text = "Vencido con Multas";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(527, 138);
            Label5.Name = "Label5";
            Label5.Size = new Size(109, 13);
            Label5.TabIndex = 38;
            Label5.Text = "% en Mora Sin Multas";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(656, 138);
            Label7.Name = "Label7";
            Label7.Size = new Size(113, 13);
            Label7.TabIndex = 39;
            Label7.Text = "% en Mora Con Multas";
            // 
            // Chart2
            // 
            ChartArea2.Name = "ChartArea1";
            Chart2.ChartAreas.Add(ChartArea2);
            Legend2.Name = "Legend1";
            Chart2.Legends.Add(Legend2);
            Chart2.Location = new Point(862, 56);
            Chart2.Name = "Chart2";
            Series3.ChartArea = "ChartArea1";
            Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Series3.Legend = "Legend1";
            Series3.Name = "Créditos Morosos";
            Series4.ChartArea = "ChartArea1";
            Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Series4.Legend = "Legend1";
            Series4.Name = "Créditos Sanos";
            Chart2.Series.Add(Series3);
            Chart2.Series.Add(Series4);
            Chart2.Size = new Size(323, 121);
            Chart2.TabIndex = 41;
            Chart2.Text = "Chart2";
            // 
            // WebBrowser1
            // 
            WebBrowser1.Location = new Point(815, 47);
            WebBrowser1.MinimumSize = new Size(20, 20);
            WebBrowser1.Name = "WebBrowser1";
            WebBrowser1.Size = new Size(380, 202);
            WebBrowser1.TabIndex = 42;
            WebBrowser1.Visible = false;
            // 
            // ValorCartera
            // 
            AutoScaleDimensions = new SizeF(96.0f, 96.0f);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1197, 581);
            Controls.Add(WebBrowser1);
            Controls.Add(Chart2);
            Controls.Add(Label7);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label6);
            Controls.Add(ComboElección);
            Controls.Add(ComboFiltro);
            Controls.Add(dtimpuestos);
            Controls.Add(Panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ValorCartera";
            Text = "Desembolsos";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Chart2).EndInit();
            Load += new EventHandler(Desembolsos_Load);
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
        internal System.ComponentModel.BackgroundWorker BackgroundGestores;
        internal System.ComponentModel.BackgroundWorker BackgroundPromotores;
        internal ComboBox ComboElección;
        internal System.ComponentModel.BackgroundWorker BackgroundConsulta;
        internal System.ComponentModel.BackgroundWorker BackgroundExcel;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label7;
        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart2;
        internal Button Button2;
        internal WebBrowser WebBrowser1;
    }
}