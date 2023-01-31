using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Alertas : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Alertas));
            PictureBox1 = new PictureBox();
            lblMensaje = new MonoFlat.MonoFlat_HeaderLabel();
            lblMensaje.Click += new EventHandler(lblMensaje_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            TextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.Transparent;
            PictureBox1.BackgroundImage = My.Resources.Resources._16606;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Image = My.Resources.Resources._16606;
            PictureBox1.Location = new Point(79, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(128, 113);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMensaje.ForeColor = Color.FromArgb(255, 255, 255);
            lblMensaje.Location = new Point(477, 106);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(260, 73);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "...";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 164, 223);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Entendido";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(95, 206);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(100, 41);
            BunifuThinButton21.TabIndex = 3;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox1
            // 
            TextBox1.BorderStyle = BorderStyle.None;
            TextBox1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            TextBox1.ForeColor = Color.White;
            TextBox1.Location = new Point(12, 131);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(260, 67);
            TextBox1.TabIndex = 4;
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Alertas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 164, 223);
            ClientSize = new Size(284, 261);
            Controls.Add(TextBox1);
            Controls.Add(BunifuThinButton21);
            Controls.Add(lblMensaje);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Alertas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alertas";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Alertas_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal MonoFlat.MonoFlat_HeaderLabel lblMensaje;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal TextBox TextBox1;
    }
}