using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class ConfigurarEmpresa : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarEmpresa));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseEnter += new EventHandler(Panel1_MouseEnter);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtIp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtBD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            Label4 = new Label();
            Label1 = new Label();
            ComboImpresora = new ComboBox();
            Label2 = new Label();
            Label3 = new Label();
            BunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label5 = new Label();
            BunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(2, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(738, 36);
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
            MonoFlat_HeaderLabel1.Size = new Size(207, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Configuración de la terminal";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(669, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtIp
            // 
            txtIp.Cursor = Cursors.IBeam;
            txtIp.Font = new Font("Century Gothic", 9.75f);
            txtIp.ForeColor = Color.White;
            txtIp.HintForeColor = Color.Empty;
            txtIp.HintText = "";
            txtIp.isPassword = false;
            txtIp.LineFocusedColor = Color.Blue;
            txtIp.LineIdleColor = Color.Gray;
            txtIp.LineMouseHoverColor = Color.Blue;
            txtIp.LineThickness = 3;
            txtIp.Location = new Point(65, 81);
            txtIp.Margin = new Padding(4);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(274, 33);
            txtIp.TabIndex = 4;
            txtIp.TextAlign = HorizontalAlignment.Left;
            // 
            // txtBD
            // 
            txtBD.Cursor = Cursors.IBeam;
            txtBD.Font = new Font("Century Gothic", 9.75f);
            txtBD.ForeColor = Color.White;
            txtBD.HintForeColor = Color.Empty;
            txtBD.HintText = "";
            txtBD.isPassword = false;
            txtBD.LineFocusedColor = Color.Blue;
            txtBD.LineIdleColor = Color.Gray;
            txtBD.LineMouseHoverColor = Color.Blue;
            txtBD.LineThickness = 3;
            txtBD.Location = new Point(65, 168);
            txtBD.Margin = new Padding(4);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(274, 33);
            txtBD.TabIndex = 5;
            txtBD.TextAlign = HorizontalAlignment.Left;
            // 
            // btn_Procesar
            // 
            btn_Procesar.ActiveBorderThickness = 1;
            btn_Procesar.ActiveCornerRadius = 20;
            btn_Procesar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.ActiveForecolor = Color.White;
            btn_Procesar.ActiveLineColor = Color.SeaGreen;
            btn_Procesar.BackColor = Color.FromArgb(0, 5, 11);
            btn_Procesar.BackgroundImage = (Image)resources.GetObject("btn_Procesar.BackgroundImage");
            btn_Procesar.ButtonText = "Guardar";
            btn_Procesar.Cursor = Cursors.Hand;
            btn_Procesar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Procesar.ForeColor = Color.DarkBlue;
            btn_Procesar.IdleBorderThickness = 1;
            btn_Procesar.IdleCornerRadius = 20;
            btn_Procesar.IdleFillColor = Color.White;
            btn_Procesar.IdleForecolor = Color.Gray;
            btn_Procesar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.Location = new Point(211, 537);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 32;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(62, 64);
            Label4.Name = "Label4";
            Label4.Size = new Size(90, 13);
            Label4.TabIndex = 33;
            Label4.Text = "Nombre a mostrar";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(62, 136);
            Label1.Name = "Label1";
            Label1.Size = new Size(70, 13);
            Label1.TabIndex = 34;
            Label1.Text = "Razón Social";
            // 
            // ComboImpresora
            // 
            ComboImpresora.FormattingEnabled = true;
            ComboImpresora.Location = new Point(48, 476);
            ComboImpresora.Name = "ComboImpresora";
            ComboImpresora.Size = new Size(379, 21);
            ComboImpresora.TabIndex = 35;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(43, 432);
            Label2.Name = "Label2";
            Label2.Size = new Size(130, 13);
            Label2.TabIndex = 36;
            Label2.Text = "Impresora Predeterminada";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(62, 220);
            Label3.Name = "Label3";
            Label3.Size = new Size(40, 13);
            Label3.TabIndex = 38;
            Label3.Text = "R.F.C.:";
            // 
            // BunifuMaterialTextbox1
            // 
            BunifuMaterialTextbox1.Cursor = Cursors.IBeam;
            BunifuMaterialTextbox1.Font = new Font("Century Gothic", 9.75f);
            BunifuMaterialTextbox1.ForeColor = Color.White;
            BunifuMaterialTextbox1.HintForeColor = Color.Empty;
            BunifuMaterialTextbox1.HintText = "";
            BunifuMaterialTextbox1.isPassword = false;
            BunifuMaterialTextbox1.LineFocusedColor = Color.Blue;
            BunifuMaterialTextbox1.LineIdleColor = Color.Gray;
            BunifuMaterialTextbox1.LineMouseHoverColor = Color.Blue;
            BunifuMaterialTextbox1.LineThickness = 3;
            BunifuMaterialTextbox1.Location = new Point(65, 252);
            BunifuMaterialTextbox1.Margin = new Padding(4);
            BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1";
            BunifuMaterialTextbox1.Size = new Size(274, 33);
            BunifuMaterialTextbox1.TabIndex = 37;
            BunifuMaterialTextbox1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(62, 317);
            Label5.Name = "Label5";
            Label5.Size = new Size(33, 13);
            Label5.TabIndex = 40;
            Label5.Text = "Calle:";
            // 
            // BunifuMaterialTextbox2
            // 
            BunifuMaterialTextbox2.Cursor = Cursors.IBeam;
            BunifuMaterialTextbox2.Font = new Font("Century Gothic", 9.75f);
            BunifuMaterialTextbox2.ForeColor = Color.White;
            BunifuMaterialTextbox2.HintForeColor = Color.Empty;
            BunifuMaterialTextbox2.HintText = "";
            BunifuMaterialTextbox2.isPassword = false;
            BunifuMaterialTextbox2.LineFocusedColor = Color.Blue;
            BunifuMaterialTextbox2.LineIdleColor = Color.Gray;
            BunifuMaterialTextbox2.LineMouseHoverColor = Color.Blue;
            BunifuMaterialTextbox2.LineThickness = 3;
            BunifuMaterialTextbox2.Location = new Point(65, 334);
            BunifuMaterialTextbox2.Margin = new Padding(4);
            BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2";
            BunifuMaterialTextbox2.Size = new Size(274, 33);
            BunifuMaterialTextbox2.TabIndex = 39;
            BunifuMaterialTextbox2.TextAlign = HorizontalAlignment.Left;
            // 
            // ConfigurarEmpresa
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(744, 604);
            Controls.Add(Label5);
            Controls.Add(BunifuMaterialTextbox2);
            Controls.Add(Label3);
            Controls.Add(BunifuMaterialTextbox1);
            Controls.Add(Label2);
            Controls.Add(ComboImpresora);
            Controls.Add(Label1);
            Controls.Add(Label4);
            Controls.Add(btn_Procesar);
            Controls.Add(txtBD);
            Controls.Add(txtIp);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConfigurarEmpresa";
            Text = "Configuraciones";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Configuraciones_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIp;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtBD;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal Label Label4;
        internal Label Label1;
        internal ComboBox ComboImpresora;
        internal Label Label2;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox BunifuMaterialTextbox1;
        internal Label Label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox BunifuMaterialTextbox2;
    }
}