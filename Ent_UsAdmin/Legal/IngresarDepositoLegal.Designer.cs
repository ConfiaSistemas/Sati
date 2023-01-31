using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class IngresarDepositoLegal : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarDepositoLegal));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            txtMonto = new VB.Windows.Forms.ControlExt.TextBoxEx();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            BunifuImageButton1.Click += new EventHandler(BunifuImageButton1_Click);
            MonoFlat_HeaderLabel5 = new MonoFlat.MonoFlat_HeaderLabel();
            txtComentario = new TextBox();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            lblNombreUsuario = new MonoFlat.MonoFlat_HeaderLabel();
            ComboUsuarios = new Bunifu.Framework.UI.BunifuDropdown();
            ComboUsuarios.onItemSelected += new EventHandler(ComboUsuarios_onItemSelected);
            MonoFlat_HeaderLabel6 = new MonoFlat.MonoFlat_HeaderLabel();
            BackgroundUsuarios = new System.ComponentModel.BackgroundWorker();
            BackgroundUsuarios.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundUsuarios_DoWork);
            BackgroundUsuarios.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundUsuarios_RunWorkerCompleted);
            dateFechaDeposito = new Telerik.WinControls.UI.RadDateTimePicker();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFechaDeposito).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(433, 36);
            Panel1.TabIndex = 9;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(363, 7);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 31;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(132, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Ingresar depósito";
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(265, 58);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(148, 20);
            MonoFlat_HeaderLabel2.TabIndex = 32;
            MonoFlat_HeaderLabel2.Text = "Imagen de depósito";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(0, 5, 11);
            txtMonto.BorderColor = Color.Gray;
            txtMonto.ForeColor = Color.White;
            txtMonto.Location = new Point(36, 82);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(93, 20);
            txtMonto.TabIndex = 33;
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(32, 58);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(56, 20);
            MonoFlat_HeaderLabel3.TabIndex = 35;
            MonoFlat_HeaderLabel3.Text = "Monto";
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(131, 58);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(49, 20);
            MonoFlat_HeaderLabel4.TabIndex = 36;
            MonoFlat_HeaderLabel4.Text = "Fecha";
            // 
            // BunifuImageButton1
            // 
            BunifuImageButton1.BackColor = Color.Transparent;
            BunifuImageButton1.BorderStyle = BorderStyle.FixedSingle;
            BunifuImageButton1.Image = (Image)resources.GetObject("BunifuImageButton1.Image");
            BunifuImageButton1.ImageActive = null;
            BunifuImageButton1.InitialImage = null;
            BunifuImageButton1.Location = new Point(274, 81);
            BunifuImageButton1.Name = "BunifuImageButton1";
            BunifuImageButton1.Size = new Size(125, 120);
            BunifuImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            BunifuImageButton1.TabIndex = 37;
            BunifuImageButton1.TabStop = false;
            BunifuImageButton1.Zoom = 10;
            // 
            // MonoFlat_HeaderLabel5
            // 
            MonoFlat_HeaderLabel5.AutoSize = true;
            MonoFlat_HeaderLabel5.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel5.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel5.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel5.Location = new Point(32, 108);
            MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            MonoFlat_HeaderLabel5.Size = new Size(91, 20);
            MonoFlat_HeaderLabel5.TabIndex = 38;
            MonoFlat_HeaderLabel5.Text = "Comentario";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(36, 131);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(201, 70);
            txtComentario.TabIndex = 39;
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
            BunifuThinButton21.Location = new Point(172, 309);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(102, 41);
            BunifuThinButton21.TabIndex = 54;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
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
            lblNombreUsuario.Location = new Point(102, 270);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(21, 20);
            lblNombreUsuario.TabIndex = 57;
            lblNombreUsuario.Text = "...";
            // 
            // ComboUsuarios
            // 
            ComboUsuarios.BackColor = Color.Transparent;
            ComboUsuarios.BorderRadius = 10;
            ComboUsuarios.DisabledColor = Color.Gray;
            ComboUsuarios.ForeColor = Color.White;
            ComboUsuarios.Items = new string[0];
            ComboUsuarios.Location = new Point(106, 222);
            ComboUsuarios.Name = "ComboUsuarios";
            ComboUsuarios.NomalColor = Color.FromArgb(0, 5, 11);
            ComboUsuarios.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboUsuarios.selectedIndex = -1;
            ComboUsuarios.Size = new Size(180, 35);
            ComboUsuarios.TabIndex = 56;
            // 
            // MonoFlat_HeaderLabel6
            // 
            MonoFlat_HeaderLabel6.AutoSize = true;
            MonoFlat_HeaderLabel6.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel6.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel6.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel6.Location = new Point(33, 222);
            MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6";
            MonoFlat_HeaderLabel6.Size = new Size(67, 20);
            MonoFlat_HeaderLabel6.TabIndex = 55;
            MonoFlat_HeaderLabel6.Text = "Usuario:";
            // 
            // BackgroundUsuarios
            // 
            // 
            // dateFechaDeposito
            // 
            dateFechaDeposito.BackColor = Color.FromArgb(0, 5, 11);
            dateFechaDeposito.Checked = true;
            dateFechaDeposito.CustomFormat = "yyyy-MM-dd";
            dateFechaDeposito.Font = new Font("Microsoft Sans Serif", 8.25f);
            dateFechaDeposito.ForeColor = Color.White;
            dateFechaDeposito.Format = DateTimePickerFormat.Short;
            dateFechaDeposito.Location = new Point(135, 81);
            dateFechaDeposito.Name = "dateFechaDeposito";
            dateFechaDeposito.Size = new Size(102, 18);
            dateFechaDeposito.TabIndex = 58;
            dateFechaDeposito.TabStop = false;
            dateFechaDeposito.Text = "30/01/2021";
            dateFechaDeposito.Value = new DateTime(2021, 1, 30, 12, 58, 19, 42);
            // 
            // IngresarDepositoLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(436, 364);
            Controls.Add(dateFechaDeposito);
            Controls.Add(lblNombreUsuario);
            Controls.Add(ComboUsuarios);
            Controls.Add(MonoFlat_HeaderLabel6);
            Controls.Add(BunifuThinButton21);
            Controls.Add(txtComentario);
            Controls.Add(MonoFlat_HeaderLabel5);
            Controls.Add(BunifuImageButton1);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(txtMonto);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngresarDepositoLegal";
            Text = "IngresarDepositoLegal";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFechaDeposito).EndInit();
            Load += new EventHandler(IngresarDepositoLegal_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtMonto;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal TextBox txtComentario;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal MonoFlat.MonoFlat_HeaderLabel lblNombreUsuario;
        internal Bunifu.Framework.UI.BunifuDropdown ComboUsuarios;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel6;
        internal System.ComponentModel.BackgroundWorker BackgroundUsuarios;
        internal Telerik.WinControls.UI.RadDateTimePicker dateFechaDeposito;
    }
}