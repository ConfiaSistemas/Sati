using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class agregargrupos : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(agregargrupos));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            EvolveControlBox1.Click += new EventHandler(EvolveControlBox1_Click);
            Label2 = new Label();
            txtcodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(382, 36);
            Panel1.TabIndex = 0;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(121, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Grupos";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(313, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(21, 58);
            Label2.Name = "Label2";
            Label2.Size = new Size(40, 13);
            Label2.TabIndex = 3;
            Label2.Text = "Código";
            // 
            // txtcodigo
            // 
            txtcodigo.Cursor = Cursors.IBeam;
            txtcodigo.Font = new Font("Century Gothic", 9.75f);
            txtcodigo.ForeColor = Color.FromArgb(64, 64, 64);
            txtcodigo.HintForeColor = Color.White;
            txtcodigo.HintText = "";
            txtcodigo.isPassword = false;
            txtcodigo.LineFocusedColor = Color.Blue;
            txtcodigo.LineIdleColor = Color.Gray;
            txtcodigo.LineMouseHoverColor = Color.Blue;
            txtcodigo.LineThickness = 3;
            txtcodigo.Location = new Point(24, 75);
            txtcodigo.Margin = new Padding(4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(171, 25);
            txtcodigo.TabIndex = 5;
            txtcodigo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(22, 115);
            Label1.Name = "Label1";
            Label1.Size = new Size(44, 13);
            Label1.TabIndex = 6;
            Label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtnombre.HintForeColor = Color.White;
            txtnombre.HintText = "";
            txtnombre.isPassword = false;
            txtnombre.LineFocusedColor = Color.Blue;
            txtnombre.LineIdleColor = Color.Gray;
            txtnombre.LineMouseHoverColor = Color.Blue;
            txtnombre.LineThickness = 3;
            txtnombre.Location = new Point(25, 139);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(171, 25);
            txtnombre.TabIndex = 7;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // btn_agregar
            // 
            btn_agregar.ActiveBorderThickness = 1;
            btn_agregar.ActiveCornerRadius = 20;
            btn_agregar.ActiveFillColor = Color.SeaGreen;
            btn_agregar.ActiveForecolor = Color.White;
            btn_agregar.ActiveLineColor = Color.SeaGreen;
            btn_agregar.BackColor = Color.FromArgb(0, 5, 11);
            btn_agregar.BackgroundImage = (Image)resources.GetObject("btn_agregar.BackgroundImage");
            btn_agregar.ButtonText = "Agregar";
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.SeaGreen;
            btn_agregar.IdleBorderThickness = 1;
            btn_agregar.IdleCornerRadius = 20;
            btn_agregar.IdleFillColor = Color.White;
            btn_agregar.IdleForecolor = Color.SeaGreen;
            btn_agregar.IdleLineColor = Color.SeaGreen;
            btn_agregar.Location = new Point(83, 254);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(207, 38);
            btn_agregar.TabIndex = 8;
            btn_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // agregargrupos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(383, 348);
            Controls.Add(btn_agregar);
            Controls.Add(txtnombre);
            Controls.Add(Label1);
            Controls.Add(txtcodigo);
            Controls.Add(Label2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "agregargrupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Grupos";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            FormClosing += new FormClosingEventHandler(agregargrupos_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Label Label2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtcodigo;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_agregar;
    }
}