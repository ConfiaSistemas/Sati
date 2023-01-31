using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class login : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            MonoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button2.Click += new EventHandler(MonoFlat_Button2_Click);
            Button1 = new Button();
            MonoFlat_LinkLabel1 = new MonoFlat.MonoFlat_LinkLabel();
            MonoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button1.Click += new EventHandler(MonoFlat_Button1_ClickAsync);
            MonoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            txtcontra = new MonoFlat.MonoFlat_TextBox();
            txtcontra.TextChanged += new EventHandler(txtcontra_TextChanged);
            txtusr = new MonoFlat.MonoFlat_TextBox();
            PictureBox1 = new PictureBox();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Timer1
            // 
            // 
            // MonoFlat_Button2
            // 
            MonoFlat_Button2.BackColor = Color.Transparent;
            MonoFlat_Button2.Cursor = Cursors.Hand;
            MonoFlat_Button2.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button2.Image = null;
            MonoFlat_Button2.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button2.Location = new Point(202, 366);
            MonoFlat_Button2.Name = "MonoFlat_Button2";
            MonoFlat_Button2.Size = new Size(146, 41);
            MonoFlat_Button2.TabIndex = 18;
            MonoFlat_Button2.Text = "Auto Login";
            MonoFlat_Button2.TextAlignment = StringAlignment.Center;
            MonoFlat_Button2.Visible = false;
            // 
            // Button1
            // 
            Button1.Location = new Point(356, 54);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 17;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            Button1.Visible = false;
            // 
            // MonoFlat_LinkLabel1
            // 
            MonoFlat_LinkLabel1.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            MonoFlat_LinkLabel1.AutoSize = true;
            MonoFlat_LinkLabel1.BackColor = Color.Transparent;
            MonoFlat_LinkLabel1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            MonoFlat_LinkLabel1.LinkColor = Color.FromArgb(181, 41, 42);
            MonoFlat_LinkLabel1.Location = new Point(317, 258);
            MonoFlat_LinkLabel1.Name = "MonoFlat_LinkLabel1";
            MonoFlat_LinkLabel1.Size = new Size(141, 15);
            MonoFlat_LinkLabel1.TabIndex = 14;
            MonoFlat_LinkLabel1.TabStop = true;
            MonoFlat_LinkLabel1.Text = "¿Olvidaste tu contraseña?";
            MonoFlat_LinkLabel1.VisitedLinkColor = Color.FromArgb(181, 41, 42);
            // 
            // MonoFlat_Button1
            // 
            MonoFlat_Button1.BackColor = Color.Transparent;
            MonoFlat_Button1.Cursor = Cursors.Hand;
            MonoFlat_Button1.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button1.Image = null;
            MonoFlat_Button1.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button1.Location = new Point(345, 292);
            MonoFlat_Button1.Name = "MonoFlat_Button1";
            MonoFlat_Button1.Size = new Size(146, 41);
            MonoFlat_Button1.TabIndex = 13;
            MonoFlat_Button1.Text = "Ingresar";
            MonoFlat_Button1.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Label2
            // 
            MonoFlat_Label2.AutoSize = true;
            MonoFlat_Label2.BackColor = Color.Transparent;
            MonoFlat_Label2.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label2.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label2.Location = new Point(317, 98);
            MonoFlat_Label2.Name = "MonoFlat_Label2";
            MonoFlat_Label2.Size = new Size(47, 15);
            MonoFlat_Label2.TabIndex = 16;
            MonoFlat_Label2.Text = "Usuario";
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(317, 181);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(67, 15);
            MonoFlat_Label1.TabIndex = 15;
            MonoFlat_Label1.Text = "Contraseña";
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.Transparent;
            txtcontra.Font = new Font("Tahoma", 11.0f);
            txtcontra.ForeColor = Color.FromArgb(176, 183, 191);
            txtcontra.Image = My.Resources.Resources.contraseña;
            txtcontra.Location = new Point(320, 199);
            txtcontra.MaxLength = 32767;
            txtcontra.Multiline = false;
            txtcontra.Name = "txtcontra";
            txtcontra.ReadOnly = false;
            txtcontra.Size = new Size(202, 41);
            txtcontra.TabIndex = 11;
            txtcontra.TextAlignment = HorizontalAlignment.Left;
            txtcontra.UseSystemPasswordChar = true;
            // 
            // txtusr
            // 
            txtusr.BackColor = Color.Transparent;
            txtusr.Font = new Font("Tahoma", 11.0f);
            txtusr.ForeColor = Color.FromArgb(176, 183, 191);
            txtusr.Image = My.Resources.Resources.usr;
            txtusr.Location = new Point(320, 116);
            txtusr.MaxLength = 32767;
            txtusr.Multiline = false;
            txtusr.Name = "txtusr";
            txtusr.ReadOnly = false;
            txtusr.Size = new Size(202, 41);
            txtusr.TabIndex = 9;
            txtusr.TextAlignment = HorizontalAlignment.Left;
            txtusr.UseSystemPasswordChar = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.logo_dando_vueltas;
            PictureBox1.Location = new Point(45, 119);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(189, 178);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 10;
            PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(565, 36);
            Panel1.TabIndex = 19;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(178, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Préstamos Confía - SATI";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(496, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(567, 452);
            Controls.Add(Panel1);
            Controls.Add(MonoFlat_Button2);
            Controls.Add(Button1);
            Controls.Add(MonoFlat_LinkLabel1);
            Controls.Add(MonoFlat_Button1);
            Controls.Add(MonoFlat_Label2);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(txtcontra);
            Controls.Add(txtusr);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(login_Load);
            Closing += new System.ComponentModel.CancelEventHandler(login_Closing);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Timer Timer1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button2;
        internal Button Button1;
        internal MonoFlat.MonoFlat_LinkLabel MonoFlat_LinkLabel1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label2;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_TextBox txtcontra;
        internal MonoFlat.MonoFlat_TextBox txtusr;
        internal PictureBox PictureBox1;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
    }
}