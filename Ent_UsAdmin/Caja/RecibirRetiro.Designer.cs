using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class RecibirRetiro : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(RecibirRetiro));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtmonto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button1.Click += new EventHandler(MonoFlat_Button1_Click);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            lblMonto = new MonoFlat.MonoFlat_HeaderLabel();
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
            Panel1.Size = new Size(482, 36);
            Panel1.TabIndex = 4;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(104, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Recibir Retiro";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(410, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtmonto
            // 
            txtmonto.BackColor = Color.FromArgb(0, 5, 11);
            txtmonto.Cursor = Cursors.IBeam;
            txtmonto.Font = new Font("Century Gothic", 9.75f);
            txtmonto.ForeColor = Color.White;
            txtmonto.HintForeColor = Color.White;
            txtmonto.HintText = "";
            txtmonto.isPassword = false;
            txtmonto.LineFocusedColor = Color.Blue;
            txtmonto.LineIdleColor = Color.Gray;
            txtmonto.LineMouseHoverColor = Color.Blue;
            txtmonto.LineThickness = 3;
            txtmonto.Location = new Point(104, 135);
            txtmonto.Margin = new Padding(4);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(263, 33);
            txtmonto.TabIndex = 0;
            txtmonto.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(100, 111);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(120, 20);
            MonoFlat_HeaderLabel2.TabIndex = 2;
            MonoFlat_HeaderLabel2.Text = "Monto Recibido";
            // 
            // MonoFlat_Button1
            // 
            MonoFlat_Button1.BackColor = Color.Transparent;
            MonoFlat_Button1.Cursor = Cursors.Hand;
            MonoFlat_Button1.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button1.Image = null;
            MonoFlat_Button1.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button1.Location = new Point(189, 193);
            MonoFlat_Button1.Name = "MonoFlat_Button1";
            MonoFlat_Button1.Size = new Size(85, 41);
            MonoFlat_Button1.TabIndex = 22;
            MonoFlat_Button1.Text = "Aceptar";
            MonoFlat_Button1.TextAlignment = StringAlignment.Center;
            // 
            // BackgroundWorker1
            // 
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(255, 255, 255);
            lblMonto.Location = new Point(100, 50);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(21, 20);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "...";
            // 
            // RecibirRetiro
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(485, 250);
            Controls.Add(lblMonto);
            Controls.Add(MonoFlat_Button1);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(txtmonto);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RecibirRetiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecibirRetiro";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(RecibirRetiro_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtmonto;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button1;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal MonoFlat.MonoFlat_HeaderLabel lblMonto;
    }
}