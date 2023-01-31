using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarGestionLegal : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarGestionLegal));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtConcepto = new RichTextBox();
            txtConcepto.TextChanged += new EventHandler(txtConcepto_TextChanged);
            Label11 = new Label();
            btn_actualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_actualizar.Click += new EventHandler(btn_actualizar_Click);
            BackgroundGestion = new System.ComponentModel.BackgroundWorker();
            BackgroundGestion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGestion_DoWork);
            BackgroundGestion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGestion_RunWorkerCompleted);
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
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
            Panel1.Size = new Size(660, 36);
            Panel1.TabIndex = 30;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 2);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(124, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Gestión";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(591, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(61, 110);
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(540, 96);
            txtConcepto.TabIndex = 31;
            txtConcepto.Text = "";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(58, 82);
            Label11.Name = "Label11";
            Label11.Size = new Size(53, 13);
            Label11.TabIndex = 63;
            Label11.Text = "Concepto";
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
            btn_actualizar.Location = new Point(236, 261);
            btn_actualizar.Margin = new Padding(5);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(207, 38);
            btn_actualizar.TabIndex = 64;
            btn_actualizar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundGestion
            // 
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(536, 50);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(49, 20);
            MonoFlat_HeaderLabel2.TabIndex = 65;
            MonoFlat_HeaderLabel2.Text = "1,000";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(381, 50);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(159, 20);
            MonoFlat_HeaderLabel3.TabIndex = 66;
            MonoFlat_HeaderLabel3.Text = "Caracteres restantes: ";
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(580, 50);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(70, 20);
            MonoFlat_HeaderLabel4.TabIndex = 67;
            MonoFlat_HeaderLabel4.Text = "de 1,000";
            // 
            // AgregarGestionLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(665, 329);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(btn_actualizar);
            Controls.Add(Label11);
            Controls.Add(txtConcepto);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarGestionLegal";
            Text = "AgregarGestionLegal";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(AgregarGestionLegal_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal RichTextBox txtConcepto;
        internal Label Label11;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_actualizar;
        internal System.ComponentModel.BackgroundWorker BackgroundGestion;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
    }
}