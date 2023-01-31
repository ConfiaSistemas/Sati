using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]


    public partial class AutorizacionNotificacionBuenFin : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizacionNotificacionBuenFin));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            txtcontra = new MonoFlat.MonoFlat_TextBox();
            txtcontra.TextChanged += new EventHandler(txtcontra_TextChanged);
            MonoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button1.Click += new EventHandler(MonoFlat_Button1_ClickAsync);
            MonoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button2.Click += new EventHandler(MonoFlat_Button2_Click);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            FlowEspere = new FlowLayoutPanel();
            MonoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            BackgroundActNotificacion = new System.ComponentModel.BackgroundWorker();
            Panel1.SuspendLayout();
            FlowEspere.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(2, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(292, 36);
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
            MonoFlat_HeaderLabel1.Size = new Size(163, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Autorización Buen Fin";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(223, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(50, 92);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(67, 15);
            MonoFlat_Label1.TabIndex = 19;
            MonoFlat_Label1.Text = "Contraseña";
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.Transparent;
            txtcontra.Font = new Font("Tahoma", 11.0f);
            txtcontra.ForeColor = Color.FromArgb(176, 183, 191);
            txtcontra.Image = My.Resources.Resources.contraseña;
            txtcontra.Location = new Point(53, 110);
            txtcontra.MaxLength = 32767;
            txtcontra.Multiline = false;
            txtcontra.Name = "txtcontra";
            txtcontra.ReadOnly = false;
            txtcontra.Size = new Size(202, 41);
            txtcontra.TabIndex = 18;
            txtcontra.TextAlignment = HorizontalAlignment.Left;
            txtcontra.UseSystemPasswordChar = true;
            // 
            // MonoFlat_Button1
            // 
            MonoFlat_Button1.BackColor = Color.Transparent;
            MonoFlat_Button1.Cursor = Cursors.Hand;
            MonoFlat_Button1.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button1.Image = null;
            MonoFlat_Button1.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button1.Location = new Point(53, 183);
            MonoFlat_Button1.Name = "MonoFlat_Button1";
            MonoFlat_Button1.Size = new Size(85, 41);
            MonoFlat_Button1.TabIndex = 21;
            MonoFlat_Button1.Text = "Aceptar";
            MonoFlat_Button1.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Button2
            // 
            MonoFlat_Button2.BackColor = Color.Transparent;
            MonoFlat_Button2.Cursor = Cursors.Hand;
            MonoFlat_Button2.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button2.Image = null;
            MonoFlat_Button2.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button2.Location = new Point(170, 183);
            MonoFlat_Button2.Name = "MonoFlat_Button2";
            MonoFlat_Button2.Size = new Size(85, 41);
            MonoFlat_Button2.TabIndex = 22;
            MonoFlat_Button2.Text = "Cancelar";
            MonoFlat_Button2.TextAlignment = StringAlignment.Center;
            // 
            // BackgroundWorker1
            // 
            // 
            // FlowEspere
            // 
            FlowEspere.Controls.Add(MonoFlat_Label3);
            FlowEspere.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FlowEspere.Location = new Point(268, 44);
            FlowEspere.Name = "FlowEspere";
            FlowEspere.Size = new Size(23, 180);
            FlowEspere.TabIndex = 23;
            FlowEspere.Visible = false;
            // 
            // MonoFlat_Label3
            // 
            MonoFlat_Label3.AutoSize = true;
            MonoFlat_Label3.BackColor = Color.Transparent;
            MonoFlat_Label3.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonoFlat_Label3.ForeColor = Color.White;
            MonoFlat_Label3.Location = new Point(3, 0);
            MonoFlat_Label3.Name = "MonoFlat_Label3";
            MonoFlat_Label3.Size = new Size(18, 140);
            MonoFlat_Label3.TabIndex = 0;
            MonoFlat_Label3.Text = "Espere.";
            // 
            // AutorizacionNotificacionBuenFin
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(296, 241);
            Controls.Add(FlowEspere);
            Controls.Add(MonoFlat_Button2);
            Controls.Add(MonoFlat_Button1);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(txtcontra);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AutorizacionNotificacionBuenFin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autorizacion";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            FlowEspere.ResumeLayout(false);
            FlowEspere.PerformLayout();
            Load += new EventHandler(Autorizacion_Load);
            FormClosing += new FormClosingEventHandler(Autorizacion_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_TextBox txtcontra;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button2;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal FlowLayoutPanel FlowEspere;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label3;
        internal System.ComponentModel.BackgroundWorker BackgroundActNotificacion;
    }
}