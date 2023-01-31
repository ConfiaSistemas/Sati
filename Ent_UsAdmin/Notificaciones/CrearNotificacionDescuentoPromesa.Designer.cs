using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CrearNotificacionDescuentoPromesa : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearNotificacionDescuentoPromesa));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            lblPromesa = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            ComboUsuarios = new Bunifu.Framework.UI.BunifuDropdown();
            ComboUsuarios.onItemSelected += new EventHandler(ComboUsuarios_onItemSelected);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            lblNombreUsuario = new MonoFlat.MonoFlat_HeaderLabel();
            txtComentario = new TextBox();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BackgroundNotificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundNotificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundNotificacion_DoWork);
            BackgroundNotificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundNotificacion_RunWorkerCompleted);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(355, 36);
            Panel1.TabIndex = 2;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(4, 1);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(71, 20);
            MonoFlat_HeaderLabel1.TabIndex = 0;
            MonoFlat_HeaderLabel1.Text = "Notificar";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(286, 5);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 1;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // lblPromesa
            // 
            lblPromesa.AutoSize = true;
            lblPromesa.BackColor = Color.Transparent;
            lblPromesa.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblPromesa.ForeColor = Color.FromArgb(255, 255, 255);
            lblPromesa.Location = new Point(100, 56);
            lblPromesa.Name = "lblPromesa";
            lblPromesa.Size = new Size(21, 20);
            lblPromesa.TabIndex = 5;
            lblPromesa.Text = "...";
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(24, 56);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(74, 20);
            MonoFlat_HeaderLabel2.TabIndex = 4;
            MonoFlat_HeaderLabel2.Text = "Promesa:";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(31, 103);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(67, 20);
            MonoFlat_HeaderLabel3.TabIndex = 6;
            MonoFlat_HeaderLabel3.Text = "Usuario:";
            // 
            // ComboUsuarios
            // 
            ComboUsuarios.BackColor = Color.Transparent;
            ComboUsuarios.BorderRadius = 10;
            ComboUsuarios.DisabledColor = Color.Gray;
            ComboUsuarios.ForeColor = Color.White;
            ComboUsuarios.Items = new string[0];
            ComboUsuarios.Location = new Point(104, 103);
            ComboUsuarios.Name = "ComboUsuarios";
            ComboUsuarios.NomalColor = Color.FromArgb(0, 5, 11);
            ComboUsuarios.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboUsuarios.selectedIndex = -1;
            ComboUsuarios.Size = new Size(180, 35);
            ComboUsuarios.TabIndex = 49;
            // 
            // BackgroundWorker1
            // 
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblNombreUsuario.ForeColor = Color.FromArgb(255, 255, 255);
            lblNombreUsuario.Location = new Point(100, 151);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(21, 20);
            lblNombreUsuario.TabIndex = 50;
            lblNombreUsuario.Text = "...";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(104, 204);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(180, 53);
            txtComentario.TabIndex = 51;
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(3, 202);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(95, 20);
            MonoFlat_HeaderLabel4.TabIndex = 52;
            MonoFlat_HeaderLabel4.Text = "Comentario:";
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Notificar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(134, 276);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(102, 41);
            BunifuThinButton21.TabIndex = 53;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundNotificacion
            // 
            // 
            // CrearNotificacionDescuentoPromesa
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(358, 331);
            Controls.Add(BunifuThinButton21);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(txtComentario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(ComboUsuarios);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(lblPromesa);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearNotificacionDescuentoPromesa";
            Text = "CrearNotificacionDescuentoPromesa";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(CrearNotificacionCancelarTicket_Load);
            FormClosing += new FormClosingEventHandler(CrearNotificacionDescuentoPromesa_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel lblPromesa;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal Bunifu.Framework.UI.BunifuDropdown ComboUsuarios;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal MonoFlat.MonoFlat_HeaderLabel lblNombreUsuario;
        internal TextBox txtComentario;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal System.ComponentModel.BackgroundWorker BackgroundNotificacion;
    }
}