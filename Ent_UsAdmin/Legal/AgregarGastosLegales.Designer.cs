using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarGastosLegales : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarGastosLegales));
            Label11 = new Label();
            txtConcepto = new RichTextBox();
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            btn_actualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_actualizar.Click += new EventHandler(btn_actualizar_Click);
            txtMonto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            BackgroundGastos = new System.ComponentModel.BackgroundWorker();
            BackgroundGastos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGastos_DoWork);
            BackgroundGastos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGastos_RunWorkerCompleted);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(79, 162);
            Label11.Name = "Label11";
            Label11.Size = new Size(53, 13);
            Label11.TabIndex = 67;
            Label11.Text = "Concepto";
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(82, 191);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(314, 96);
            txtConcepto.TabIndex = 66;
            txtConcepto.Text = "";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(504, 36);
            Panel1.TabIndex = 65;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 2);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(118, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Gastos";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(435, 6);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // btn_actualizar
            // 
            btn_actualizar.ActiveBorderThickness = 1;
            btn_actualizar.ActiveCornerRadius = 20;
            btn_actualizar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_actualizar.ActiveForecolor = Color.White;
            btn_actualizar.ActiveLineColor = Color.SeaGreen;
            btn_actualizar.BackColor = Color.FromArgb(0, 5, 11);
            btn_actualizar.BackgroundImage = (Image)resources.GetObject("btn_actualizar.BackgroundImage");
            btn_actualizar.ButtonText = "Agregar";
            btn_actualizar.Cursor = Cursors.Hand;
            btn_actualizar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_actualizar.ForeColor = Color.DarkBlue;
            btn_actualizar.IdleBorderThickness = 1;
            btn_actualizar.IdleCornerRadius = 20;
            btn_actualizar.IdleFillColor = Color.White;
            btn_actualizar.IdleForecolor = Color.Gray;
            btn_actualizar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_actualizar.Location = new Point(137, 332);
            btn_actualizar.Margin = new Padding(5);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(207, 38);
            btn_actualizar.TabIndex = 68;
            btn_actualizar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMonto
            // 
            txtMonto.Cursor = Cursors.IBeam;
            txtMonto.Font = new Font("Century Gothic", 9.75f);
            txtMonto.ForeColor = Color.White;
            txtMonto.HintForeColor = Color.White;
            txtMonto.HintText = "";
            txtMonto.isPassword = false;
            txtMonto.LineFocusedColor = Color.Blue;
            txtMonto.LineIdleColor = Color.Gray;
            txtMonto.LineMouseHoverColor = Color.Blue;
            txtMonto.LineThickness = 3;
            txtMonto.Location = new Point(82, 107);
            txtMonto.Margin = new Padding(4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 29);
            txtMonto.TabIndex = 69;
            txtMonto.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(79, 90);
            Label1.Name = "Label1";
            Label1.Size = new Size(37, 13);
            Label1.TabIndex = 70;
            Label1.Text = "Monto";
            // 
            // BackgroundGastos
            // 
            // 
            // AgregarGastosLegales
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(505, 393);
            Controls.Add(txtMonto);
            Controls.Add(Label1);
            Controls.Add(btn_actualizar);
            Controls.Add(Label11);
            Controls.Add(txtConcepto);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarGastosLegales";
            Text = "AgregarGastosLegales";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(AgregarGastosLegales_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Bunifu.Framework.UI.BunifuThinButton2 btn_actualizar;
        internal Label Label11;
        internal RichTextBox txtConcepto;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMonto;
        internal Label Label1;
        internal System.ComponentModel.BackgroundWorker BackgroundGastos;
    }
}