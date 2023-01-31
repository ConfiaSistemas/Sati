using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class SolicitudPorFecha : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudPorFecha));
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtimpuestos.CellContentClick += new DataGridViewCellEventHandler(dtimpuestos_CellContentClick);
            Panel1 = new Panel();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            dateHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            MonoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            dateDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
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
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            lblEntregado = new MonoFlat.MonoFlat_HeaderLabel();
            lblIncompletas = new MonoFlat.MonoFlat_HeaderLabel();
            lblEspera = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel5 = new MonoFlat.MonoFlat_HeaderLabel();
            lblVerificadas = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel7 = new MonoFlat.MonoFlat_HeaderLabel();
            lblAprobadas = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel9 = new MonoFlat.MonoFlat_HeaderLabel();
            lblRechazadas = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel11 = new MonoFlat.MonoFlat_HeaderLabel();
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
            MonoFlat_HeaderLabel1.Location = new Point(63, 0);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(233, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Solicitudes ingresadas por fecha";
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
            dtimpuestos.Location = new Point(1, 207);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(1194, 362);
            dtimpuestos.TabIndex = 7;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(Button2);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(dateHasta);
            Panel1.Controls.Add(MonoFlat_Label2);
            Panel1.Controls.Add(dateDesde);
            Panel1.Controls.Add(MonoFlat_Label1);
            Panel1.Location = new Point(1, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1194, 62);
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
            Button2.TabIndex = 33;
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
            // dateHasta
            // 
            dateHasta.BackColor = Color.FromArgb(0, 5, 11);
            dateHasta.BorderRadius = 0;
            dateHasta.ForeColor = Color.White;
            dateHasta.Format = DateTimePickerFormat.Short;
            dateHasta.FormatCustom = null;
            dateHasta.Location = new Point(597, 26);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(177, 33);
            dateHasta.TabIndex = 7;
            dateHasta.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_Label2
            // 
            MonoFlat_Label2.AutoSize = true;
            MonoFlat_Label2.BackColor = Color.Transparent;
            MonoFlat_Label2.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label2.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label2.Location = new Point(594, 8);
            MonoFlat_Label2.Name = "MonoFlat_Label2";
            MonoFlat_Label2.Size = new Size(37, 15);
            MonoFlat_Label2.TabIndex = 9;
            MonoFlat_Label2.Text = "Hasta";
            // 
            // dateDesde
            // 
            dateDesde.BackColor = Color.FromArgb(0, 5, 11);
            dateDesde.BorderRadius = 0;
            dateDesde.ForeColor = Color.White;
            dateDesde.Format = DateTimePickerFormat.Short;
            dateDesde.FormatCustom = null;
            dateDesde.Location = new Point(354, 26);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(177, 33);
            dateDesde.TabIndex = 6;
            dateDesde.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(351, 8);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(39, 15);
            MonoFlat_Label1.TabIndex = 8;
            MonoFlat_Label1.Text = "Desde";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(19, 69);
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
            ComboFiltro.Location = new Point(22, 99);
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
            BunifuThinButton22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            BunifuThinButton22.Location = new Point(1011, 89);
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
            ComboElección.Location = new Point(268, 99);
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
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(546, 78);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(122, 20);
            MonoFlat_HeaderLabel2.TabIndex = 34;
            MonoFlat_HeaderLabel2.Text = "Total Ingresado:";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(546, 100);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(120, 20);
            MonoFlat_HeaderLabel3.TabIndex = 35;
            MonoFlat_HeaderLabel3.Text = "Incompletas (I):";
            // 
            // lblEntregado
            // 
            lblEntregado.AutoSize = true;
            lblEntregado.BackColor = Color.Transparent;
            lblEntregado.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblEntregado.ForeColor = Color.FromArgb(255, 255, 255);
            lblEntregado.Location = new Point(676, 78);
            lblEntregado.Name = "lblEntregado";
            lblEntregado.Size = new Size(21, 20);
            lblEntregado.TabIndex = 36;
            lblEntregado.Text = "...";
            // 
            // lblIncompletas
            // 
            lblIncompletas.AutoSize = true;
            lblIncompletas.BackColor = Color.Transparent;
            lblIncompletas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblIncompletas.ForeColor = Color.FromArgb(255, 255, 255);
            lblIncompletas.Location = new Point(676, 100);
            lblIncompletas.Name = "lblIncompletas";
            lblIncompletas.Size = new Size(21, 20);
            lblIncompletas.TabIndex = 37;
            lblIncompletas.Text = "...";
            // 
            // lblEspera
            // 
            lblEspera.AutoSize = true;
            lblEspera.BackColor = Color.Transparent;
            lblEspera.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblEspera.ForeColor = Color.FromArgb(255, 255, 255);
            lblEspera.Location = new Point(676, 120);
            lblEspera.Name = "lblEspera";
            lblEspera.Size = new Size(21, 20);
            lblEspera.TabIndex = 39;
            lblEspera.Text = "...";
            // 
            // MonoFlat_HeaderLabel5
            // 
            MonoFlat_HeaderLabel5.AutoSize = true;
            MonoFlat_HeaderLabel5.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel5.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel5.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel5.Location = new Point(546, 120);
            MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            MonoFlat_HeaderLabel5.Size = new Size(104, 20);
            MonoFlat_HeaderLabel5.TabIndex = 38;
            MonoFlat_HeaderLabel5.Text = "En espera (E):";
            // 
            // lblVerificadas
            // 
            lblVerificadas.AutoSize = true;
            lblVerificadas.BackColor = Color.Transparent;
            lblVerificadas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblVerificadas.ForeColor = Color.FromArgb(255, 255, 255);
            lblVerificadas.Location = new Point(676, 140);
            lblVerificadas.Name = "lblVerificadas";
            lblVerificadas.Size = new Size(21, 20);
            lblVerificadas.TabIndex = 41;
            lblVerificadas.Text = "...";
            // 
            // MonoFlat_HeaderLabel7
            // 
            MonoFlat_HeaderLabel7.AutoSize = true;
            MonoFlat_HeaderLabel7.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel7.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel7.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel7.Location = new Point(546, 140);
            MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7";
            MonoFlat_HeaderLabel7.Size = new Size(115, 20);
            MonoFlat_HeaderLabel7.TabIndex = 40;
            MonoFlat_HeaderLabel7.Text = "Verificadas (V):";
            // 
            // lblAprobadas
            // 
            lblAprobadas.AutoSize = true;
            lblAprobadas.BackColor = Color.Transparent;
            lblAprobadas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblAprobadas.ForeColor = Color.FromArgb(255, 255, 255);
            lblAprobadas.Location = new Point(676, 160);
            lblAprobadas.Name = "lblAprobadas";
            lblAprobadas.Size = new Size(21, 20);
            lblAprobadas.TabIndex = 43;
            lblAprobadas.Text = "...";
            // 
            // MonoFlat_HeaderLabel9
            // 
            MonoFlat_HeaderLabel9.AutoSize = true;
            MonoFlat_HeaderLabel9.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel9.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel9.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel9.Location = new Point(546, 160);
            MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9";
            MonoFlat_HeaderLabel9.Size = new Size(116, 20);
            MonoFlat_HeaderLabel9.TabIndex = 42;
            MonoFlat_HeaderLabel9.Text = "Aprobadas (A):";
            // 
            // lblRechazadas
            // 
            lblRechazadas.AutoSize = true;
            lblRechazadas.BackColor = Color.Transparent;
            lblRechazadas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblRechazadas.ForeColor = Color.FromArgb(255, 255, 255);
            lblRechazadas.Location = new Point(676, 180);
            lblRechazadas.Name = "lblRechazadas";
            lblRechazadas.Size = new Size(21, 20);
            lblRechazadas.TabIndex = 45;
            lblRechazadas.Text = "...";
            // 
            // MonoFlat_HeaderLabel11
            // 
            MonoFlat_HeaderLabel11.AutoSize = true;
            MonoFlat_HeaderLabel11.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel11.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel11.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel11.Location = new Point(546, 180);
            MonoFlat_HeaderLabel11.Name = "MonoFlat_HeaderLabel11";
            MonoFlat_HeaderLabel11.Size = new Size(120, 20);
            MonoFlat_HeaderLabel11.TabIndex = 44;
            MonoFlat_HeaderLabel11.Text = "Rechazadas (R):";
            // 
            // SolicitudPorFecha
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1197, 581);
            Controls.Add(lblRechazadas);
            Controls.Add(MonoFlat_HeaderLabel11);
            Controls.Add(lblAprobadas);
            Controls.Add(MonoFlat_HeaderLabel9);
            Controls.Add(lblVerificadas);
            Controls.Add(MonoFlat_HeaderLabel7);
            Controls.Add(lblEspera);
            Controls.Add(MonoFlat_HeaderLabel5);
            Controls.Add(lblIncompletas);
            Controls.Add(lblEntregado);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label6);
            Controls.Add(ComboElección);
            Controls.Add(ComboFiltro);
            Controls.Add(dtimpuestos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SolicitudPorFecha";
            Text = "Solicitudes ingresas por fecha";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Desembolsos_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuDatepicker dateDesde;
        internal Bunifu.Framework.UI.BunifuDatepicker dateHasta;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label2;
        internal Label Label6;
        internal ComboBox ComboFiltro;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal System.ComponentModel.BackgroundWorker BackgroundGestores;
        internal System.ComponentModel.BackgroundWorker BackgroundPromotores;
        internal ComboBox ComboElección;
        internal System.ComponentModel.BackgroundWorker BackgroundConsulta;
        internal System.ComponentModel.BackgroundWorker BackgroundExcel;
        internal Button Button2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel lblEntregado;
        internal MonoFlat.MonoFlat_HeaderLabel lblIncompletas;
        internal MonoFlat.MonoFlat_HeaderLabel lblEspera;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal MonoFlat.MonoFlat_HeaderLabel lblVerificadas;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel7;
        internal MonoFlat.MonoFlat_HeaderLabel lblAprobadas;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel9;
        internal MonoFlat.MonoFlat_HeaderLabel lblRechazadas;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel11;
    }
}