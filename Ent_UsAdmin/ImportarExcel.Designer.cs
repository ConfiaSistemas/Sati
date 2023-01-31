using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ImportarExcel : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportarExcel));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtfila = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Combocodigo = new ComboBox();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(438, 36);
            Panel1.TabIndex = 5;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(111, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Importar Excel";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(369, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtfila
            // 
            txtfila.Cursor = Cursors.IBeam;
            txtfila.Font = new Font("Century Gothic", 9.75f);
            txtfila.ForeColor = Color.White;
            txtfila.HintForeColor = Color.White;
            txtfila.HintText = "";
            txtfila.isPassword = false;
            txtfila.LineFocusedColor = Color.Blue;
            txtfila.LineIdleColor = Color.Gray;
            txtfila.LineMouseHoverColor = Color.Blue;
            txtfila.LineThickness = 3;
            txtfila.Location = new Point(251, 109);
            txtfila.Margin = new Padding(4);
            txtfila.Name = "txtfila";
            txtfila.Size = new Size(109, 33);
            txtfila.TabIndex = 11;
            txtfila.TextAlign = HorizontalAlignment.Left;
            // 
            // Combocodigo
            // 
            Combocodigo.FormattingEnabled = true;
            Combocodigo.Location = new Point(96, 121);
            Combocodigo.Name = "Combocodigo";
            Combocodigo.Size = new Size(74, 21);
            Combocodigo.TabIndex = 12;
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(92, 98);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(71, 20);
            MonoFlat_HeaderLabel2.TabIndex = 2;
            MonoFlat_HeaderLabel2.Text = "Columna";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(247, 98);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(33, 20);
            MonoFlat_HeaderLabel3.TabIndex = 13;
            MonoFlat_HeaderLabel3.Text = "Fila";
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Aceptar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(174, 179);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 14;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ImportarExcel
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(441, 250);
            Controls.Add(BunifuThinButton21);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(Combocodigo);
            Controls.Add(txtfila);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ImportarExcel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImportarExcel";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(ImportarExcel_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtfila;
        internal ComboBox Combocodigo;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
    }
}