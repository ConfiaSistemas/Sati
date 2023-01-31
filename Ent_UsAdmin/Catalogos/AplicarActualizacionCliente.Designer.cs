using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class AplicarActualizacionCliente : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AplicarActualizacionCliente));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            lblNoTicket = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            txtComentario = new TextBox();
            MonoFlat_HeaderLabel7 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel8 = new MonoFlat.MonoFlat_HeaderLabel();
            txtAddComentario = new TextBox();
            MonoFlat_HeaderLabel9 = new MonoFlat.MonoFlat_HeaderLabel();
            BackgroundActNotificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundActNotificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActNotificacion_DoWork);
            BackgroundActNotificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActNotificacion_RunWorkerCompleted);
            BackgroundVerificaNotificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundVerificaNotificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundVerificaNotificacion_DoWork);
            BackgroundVerificaNotificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundVerificaNotificacion_RunWorkerCompleted);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            dtDetalle = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtDetalle).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(2, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(563, 36);
            Panel1.TabIndex = 1;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(4, 1);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(131, 20);
            MonoFlat_HeaderLabel1.TabIndex = 0;
            MonoFlat_HeaderLabel1.Text = "Actualizar Cliente";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(494, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 1;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // lblNoTicket
            // 
            lblNoTicket.AutoSize = true;
            lblNoTicket.BackColor = Color.Transparent;
            lblNoTicket.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblNoTicket.ForeColor = Color.FromArgb(255, 255, 255);
            lblNoTicket.Location = new Point(122, 75);
            lblNoTicket.Name = "lblNoTicket";
            lblNoTicket.Size = new Size(21, 20);
            lblNoTicket.TabIndex = 5;
            lblNoTicket.Text = "...";
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(12, 75);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(106, 20);
            MonoFlat_HeaderLabel4.TabIndex = 4;
            MonoFlat_HeaderLabel4.Text = "Actualización:";
            // 
            // BackgroundWorker1
            // 
            // 
            // txtComentario
            // 
            txtComentario.BorderStyle = BorderStyle.None;
            txtComentario.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            txtComentario.ForeColor = Color.White;
            txtComentario.Location = new Point(116, 131);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.ReadOnly = true;
            txtComentario.Size = new Size(260, 35);
            txtComentario.TabIndex = 9;
            // 
            // MonoFlat_HeaderLabel7
            // 
            MonoFlat_HeaderLabel7.AutoSize = true;
            MonoFlat_HeaderLabel7.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel7.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel7.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel7.Location = new Point(15, 131);
            MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7";
            MonoFlat_HeaderLabel7.Size = new Size(95, 20);
            MonoFlat_HeaderLabel7.TabIndex = 10;
            MonoFlat_HeaderLabel7.Text = "Comentario:";
            // 
            // MonoFlat_HeaderLabel8
            // 
            MonoFlat_HeaderLabel8.AutoSize = true;
            MonoFlat_HeaderLabel8.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel8.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel8.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel8.Location = new Point(13, 194);
            MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8";
            MonoFlat_HeaderLabel8.Size = new Size(62, 20);
            MonoFlat_HeaderLabel8.TabIndex = 11;
            MonoFlat_HeaderLabel8.Text = "Detalle:";
            // 
            // txtAddComentario
            // 
            txtAddComentario.Location = new Point(16, 335);
            txtAddComentario.Multiline = true;
            txtAddComentario.Name = "txtAddComentario";
            txtAddComentario.Size = new Size(400, 46);
            txtAddComentario.TabIndex = 12;
            // 
            // MonoFlat_HeaderLabel9
            // 
            MonoFlat_HeaderLabel9.AutoSize = true;
            MonoFlat_HeaderLabel9.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel9.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel9.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel9.Location = new Point(13, 312);
            MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9";
            MonoFlat_HeaderLabel9.Size = new Size(144, 20);
            MonoFlat_HeaderLabel9.TabIndex = 13;
            MonoFlat_HeaderLabel9.Text = "Añadir comentario:";
            // 
            // BackgroundActNotificacion
            // 
            // 
            // BackgroundVerificaNotificacion
            // 
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Rechazar";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.SeaGreen;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.SeaGreen;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(306, 407);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(100, 41);
            BunifuThinButton22.TabIndex = 15;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
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
            BunifuThinButton21.ButtonText = "Autorizar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(156, 407);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(102, 41);
            BunifuThinButton21.TabIndex = 14;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtDetalle
            // 
            dtDetalle.AllowUserToAddRows = false;
            dtDetalle.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtDetalle.BackgroundColor = Color.Gainsboro;
            dtDetalle.BorderStyle = BorderStyle.None;
            dtDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDetalle.DoubleBuffered = true;
            dtDetalle.EnableHeadersVisualStyles = false;
            dtDetalle.HeaderBgColor = Color.DarkSlateGray;
            dtDetalle.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtDetalle.Location = new Point(17, 217);
            dtDetalle.Name = "dtDetalle";
            dtDetalle.ReadOnly = true;
            dtDetalle.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtDetalle.RowHeadersVisible = false;
            dtDetalle.Size = new Size(532, 72);
            dtDetalle.TabIndex = 8;
            // 
            // AplicarActualizacionCliente
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(561, 462);
            Controls.Add(BunifuThinButton22);
            Controls.Add(BunifuThinButton21);
            Controls.Add(MonoFlat_HeaderLabel9);
            Controls.Add(txtAddComentario);
            Controls.Add(MonoFlat_HeaderLabel8);
            Controls.Add(MonoFlat_HeaderLabel7);
            Controls.Add(txtComentario);
            Controls.Add(dtDetalle);
            Controls.Add(lblNoTicket);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AplicarActualizacionCliente";
            Text = "Aplicar actualización de cliente";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtDetalle).EndInit();
            Load += new EventHandler(CancelarTicket_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel lblNoTicket;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal TextBox txtComentario;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel7;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel8;
        internal TextBox txtAddComentario;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel9;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal System.ComponentModel.BackgroundWorker BackgroundActNotificacion;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificaNotificacion;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtDetalle;
    }
}