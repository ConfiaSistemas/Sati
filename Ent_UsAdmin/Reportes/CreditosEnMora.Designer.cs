using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class CreditosEnMora : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditosEnMora));
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            Panel1 = new Panel();
            lblFiltro = new MonoFlat.MonoFlat_HeaderLabel();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            Label6 = new Label();
            ComboFiltro = new ComboBox();
            ComboFiltro.SelectedIndexChanged += new EventHandler(ComboFiltro_SelectedIndexChanged);
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
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtnombre.KeyDown += new KeyEventHandler(txtnombre_KeyDown);
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            FlowEmpresas = new FlowLayoutPanel();
            BackgroundEmpresas = new System.ComponentModel.BackgroundWorker();
            BackgroundEmpresas.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundEmpresas_DoWork);
            BackgroundEmpresas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundEmpresas_RunWorkerCompleted);
            BackgroundConectarEmpresas = new System.ComponentModel.BackgroundWorker();
            BackgroundConectarEmpresas.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConectarEmpresas_DoWork);
            BackgroundConectarEmpresas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConectarEmpresas_RunWorkerCompleted);
            TabControl1 = new TabControl();
            Panel2 = new Panel();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            PictureBox1 = new PictureBox();
            TimerGrande = new Timer(components);
            TimerGrande.Tick += new EventHandler(Timer1_Tick);
            TimerChico = new Timer(components);
            TimerChico.Tick += new EventHandler(TimerChico_Tick);
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
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
            MonoFlat_HeaderLabel1.Size = new Size(129, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Créditos en Mora";
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(lblFiltro);
            Panel1.Controls.Add(Button1);
            Panel1.Controls.Add(Button2);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1194, 36);
            Panel1.TabIndex = 8;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.BackColor = Color.Transparent;
            lblFiltro.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblFiltro.ForeColor = Color.FromArgb(255, 255, 128);
            lblFiltro.Location = new Point(292, 3);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(317, 20);
            lblFiltro.TabIndex = 36;
            lblFiltro.Text = "¡El filtro sólo se aplicará a la empresa activa!";
            lblFiltro.Visible = false;
            // 
            // Button1
            // 
            Button1.Location = new Point(677, 8);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 35;
            Button1.Text = "Empresas";
            Button1.UseVisualStyleBackColor = true;
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
            Label6.Location = new Point(19, 45);
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
            ComboFiltro.Location = new Point(22, 62);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(240, 21);
            ComboFiltro.TabIndex = 30;
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
            ComboElección.Location = new Point(268, 62);
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
            BunifuThinButton22.Location = new Point(515, 56);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 5;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
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
            txtnombre.Location = new Point(71, 90);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(257, 25);
            txtnombre.TabIndex = 37;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(19, 99);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(42, 15);
            MonoFlat_Label1.TabIndex = 38;
            MonoFlat_Label1.Text = "Buscar";
            // 
            // FlowEmpresas
            // 
            FlowEmpresas.AutoScroll = true;
            FlowEmpresas.FlowDirection = FlowDirection.TopDown;
            FlowEmpresas.Location = new Point(678, 46);
            FlowEmpresas.Name = "FlowEmpresas";
            FlowEmpresas.Size = new Size(507, 68);
            FlowEmpresas.TabIndex = 39;
            // 
            // BackgroundEmpresas
            // 
            // 
            // BackgroundConectarEmpresas
            // 
            // 
            // TabControl1
            // 
            TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TabControl1.Location = new Point(12, 138);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1173, 431);
            TabControl1.TabIndex = 40;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(MonoFlat_HeaderLabel2);
            Panel2.Controls.Add(PictureBox1);
            Panel2.Location = new Point(472, 186);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(252, 208);
            Panel2.TabIndex = 41;
            Panel2.Visible = false;
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(84, 148);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(99, 20);
            MonoFlat_HeaderLabel2.TabIndex = 11;
            MonoFlat_HeaderLabel2.Text = "Trabajando...";
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.Image = My.Resources.Resources._164531372_453725909175899_8573093330485258261_n;
            PictureBox1.Location = new Point(47, 11);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(174, 134);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // TimerGrande
            // 
            // 
            // TimerChico
            // 
            // 
            // CreditosEnMora
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1197, 581);
            Controls.Add(Panel2);
            Controls.Add(TabControl1);
            Controls.Add(FlowEmpresas);
            Controls.Add(txtnombre);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label6);
            Controls.Add(ComboElección);
            Controls.Add(ComboFiltro);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreditosEnMora";
            Text = "Créditos en mora";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Desembolsos_Load);
            Resize += new EventHandler(CreditosEnMora_Resize);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
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
        internal Button Button2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal Button Button1;
        internal FlowLayoutPanel FlowEmpresas;
        internal System.ComponentModel.BackgroundWorker BackgroundEmpresas;
        internal System.ComponentModel.BackgroundWorker BackgroundConectarEmpresas;
        internal TabControl TabControl1;
        internal Panel Panel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal PictureBox PictureBox1;
        internal MonoFlat.MonoFlat_HeaderLabel lblFiltro;
        internal Timer TimerGrande;
        internal Timer TimerChico;
    }
}