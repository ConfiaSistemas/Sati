using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class vistPreviaSolicitud : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(vistPreviaSolicitud));
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.Resize += new EventHandler(Panel1_Resize);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            lblNombre = new MonoFlat.MonoFlat_HeaderLabel();
            lblMonto = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            lblPlazo = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel5 = new MonoFlat.MonoFlat_HeaderLabel();
            lblTipo = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel6 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            lblInteres = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel8 = new MonoFlat.MonoFlat_HeaderLabel();
            lblPromotor = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel9 = new MonoFlat.MonoFlat_HeaderLabel();
            lblGestor = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel11 = new MonoFlat.MonoFlat_HeaderLabel();
            btnSi = new Bunifu.Framework.UI.BunifuThinButton2();
            btnSi.Click += new EventHandler(btnSi_Click);
            btnNo = new Bunifu.Framework.UI.BunifuThinButton2();
            btnNo.Click += new EventHandler(btnNo_Click);
            MonoFlat_HeaderLabel7 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel10 = new MonoFlat.MonoFlat_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            dtdatos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3;
            dtdatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtdatos.BackgroundColor = Color.Gainsboro;
            dtdatos.BorderStyle = BorderStyle.None;
            dtdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle4.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dtdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(12, 215);
            dtdatos.Name = "dtdatos";
            dtdatos.ReadOnly = true;
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(528, 122);
            dtdatos.TabIndex = 29;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(769, 36);
            Panel1.TabIndex = 30;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(725, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = false;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(41, 16);
            EvolveControlBox1.TabIndex = 2;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = true;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(120, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Solicitud a crear";
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(8, 57);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(71, 20);
            MonoFlat_HeaderLabel2.TabIndex = 3;
            MonoFlat_HeaderLabel2.Text = "Nombre:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(255, 255, 255);
            lblNombre.Location = new Point(85, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(21, 20);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "...";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(255, 255, 255);
            lblMonto.Location = new Point(85, 89);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(21, 20);
            lblMonto.TabIndex = 33;
            lblMonto.Text = "...";
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(8, 89);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(60, 20);
            MonoFlat_HeaderLabel4.TabIndex = 32;
            MonoFlat_HeaderLabel4.Text = "Monto:";
            // 
            // lblPlazo
            // 
            lblPlazo.AutoSize = true;
            lblPlazo.BackColor = Color.Transparent;
            lblPlazo.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblPlazo.ForeColor = Color.FromArgb(255, 255, 255);
            lblPlazo.Location = new Point(265, 89);
            lblPlazo.Name = "lblPlazo";
            lblPlazo.Size = new Size(21, 20);
            lblPlazo.TabIndex = 35;
            lblPlazo.Text = "...";
            // 
            // MonoFlat_HeaderLabel5
            // 
            MonoFlat_HeaderLabel5.AutoSize = true;
            MonoFlat_HeaderLabel5.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel5.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel5.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel5.Location = new Point(209, 89);
            MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            MonoFlat_HeaderLabel5.Size = new Size(50, 20);
            MonoFlat_HeaderLabel5.TabIndex = 34;
            MonoFlat_HeaderLabel5.Text = "Plazo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(255, 255, 255);
            lblTipo.Location = new Point(421, 89);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(21, 20);
            lblTipo.TabIndex = 37;
            lblTipo.Text = "...";
            // 
            // MonoFlat_HeaderLabel6
            // 
            MonoFlat_HeaderLabel6.AutoSize = true;
            MonoFlat_HeaderLabel6.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel6.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel6.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel6.Location = new Point(365, 89);
            MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6";
            MonoFlat_HeaderLabel6.Size = new Size(44, 20);
            MonoFlat_HeaderLabel6.TabIndex = 36;
            MonoFlat_HeaderLabel6.Text = "Tipo:";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(12, 192);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(90, 20);
            MonoFlat_HeaderLabel3.TabIndex = 38;
            MonoFlat_HeaderLabel3.Text = "Integrantes";
            // 
            // lblInteres
            // 
            lblInteres.AutoSize = true;
            lblInteres.BackColor = Color.Transparent;
            lblInteres.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblInteres.ForeColor = Color.FromArgb(255, 255, 255);
            lblInteres.Location = new Point(85, 119);
            lblInteres.Name = "lblInteres";
            lblInteres.Size = new Size(21, 20);
            lblInteres.TabIndex = 40;
            lblInteres.Text = "...";
            // 
            // MonoFlat_HeaderLabel8
            // 
            MonoFlat_HeaderLabel8.AutoSize = true;
            MonoFlat_HeaderLabel8.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel8.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel8.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel8.Location = new Point(12, 119);
            MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8";
            MonoFlat_HeaderLabel8.Size = new Size(62, 20);
            MonoFlat_HeaderLabel8.TabIndex = 39;
            MonoFlat_HeaderLabel8.Text = "Interés:";
            // 
            // lblPromotor
            // 
            lblPromotor.AutoSize = true;
            lblPromotor.BackColor = Color.Transparent;
            lblPromotor.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblPromotor.ForeColor = Color.FromArgb(255, 255, 255);
            lblPromotor.Location = new Point(292, 119);
            lblPromotor.Name = "lblPromotor";
            lblPromotor.Size = new Size(21, 20);
            lblPromotor.TabIndex = 42;
            lblPromotor.Text = "...";
            // 
            // MonoFlat_HeaderLabel9
            // 
            MonoFlat_HeaderLabel9.AutoSize = true;
            MonoFlat_HeaderLabel9.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel9.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel9.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel9.Location = new Point(209, 119);
            MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9";
            MonoFlat_HeaderLabel9.Size = new Size(82, 20);
            MonoFlat_HeaderLabel9.TabIndex = 41;
            MonoFlat_HeaderLabel9.Text = "Promotor:";
            // 
            // lblGestor
            // 
            lblGestor.AutoSize = true;
            lblGestor.BackColor = Color.Transparent;
            lblGestor.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblGestor.ForeColor = Color.FromArgb(255, 255, 255);
            lblGestor.Location = new Point(85, 148);
            lblGestor.Name = "lblGestor";
            lblGestor.Size = new Size(21, 20);
            lblGestor.TabIndex = 44;
            lblGestor.Text = "...";
            // 
            // MonoFlat_HeaderLabel11
            // 
            MonoFlat_HeaderLabel11.AutoSize = true;
            MonoFlat_HeaderLabel11.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel11.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel11.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel11.Location = new Point(12, 148);
            MonoFlat_HeaderLabel11.Name = "MonoFlat_HeaderLabel11";
            MonoFlat_HeaderLabel11.Size = new Size(61, 20);
            MonoFlat_HeaderLabel11.TabIndex = 43;
            MonoFlat_HeaderLabel11.Text = "Gestor:";
            // 
            // btnSi
            // 
            btnSi.ActiveBorderThickness = 1;
            btnSi.ActiveCornerRadius = 20;
            btnSi.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnSi.ActiveForecolor = Color.White;
            btnSi.ActiveLineColor = Color.SeaGreen;
            btnSi.BackColor = Color.FromArgb(0, 5, 11);
            btnSi.BackgroundImage = (Image)resources.GetObject("btnSi.BackgroundImage");
            btnSi.ButtonText = "Sí";
            btnSi.Cursor = Cursors.Hand;
            btnSi.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSi.ForeColor = Color.DarkBlue;
            btnSi.IdleBorderThickness = 1;
            btnSi.IdleCornerRadius = 20;
            btnSi.IdleFillColor = Color.White;
            btnSi.IdleForecolor = Color.Gray;
            btnSi.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnSi.Location = new Point(269, 402);
            btnSi.Margin = new Padding(5);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(102, 49);
            btnSi.TabIndex = 45;
            btnSi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNo
            // 
            btnNo.ActiveBorderThickness = 1;
            btnNo.ActiveCornerRadius = 20;
            btnNo.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnNo.ActiveForecolor = Color.White;
            btnNo.ActiveLineColor = Color.SeaGreen;
            btnNo.BackColor = Color.FromArgb(0, 5, 11);
            btnNo.BackgroundImage = (Image)resources.GetObject("btnNo.BackgroundImage");
            btnNo.ButtonText = "No";
            btnNo.Cursor = Cursors.Hand;
            btnNo.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.DarkBlue;
            btnNo.IdleBorderThickness = 1;
            btnNo.IdleCornerRadius = 20;
            btnNo.IdleFillColor = Color.White;
            btnNo.IdleForecolor = Color.Gray;
            btnNo.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnNo.Location = new Point(425, 402);
            btnNo.Margin = new Padding(5);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(102, 49);
            btnNo.TabIndex = 46;
            btnNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel7
            // 
            MonoFlat_HeaderLabel7.AutoSize = true;
            MonoFlat_HeaderLabel7.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel7.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel7.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel7.Location = new Point(265, 352);
            MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7";
            MonoFlat_HeaderLabel7.Size = new Size(201, 20);
            MonoFlat_HeaderLabel7.TabIndex = 3;
            MonoFlat_HeaderLabel7.Text = "Revisa los datos ingresados";
            // 
            // MonoFlat_HeaderLabel10
            // 
            MonoFlat_HeaderLabel10.AutoSize = true;
            MonoFlat_HeaderLabel10.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel10.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel10.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel10.Location = new Point(265, 377);
            MonoFlat_HeaderLabel10.Name = "MonoFlat_HeaderLabel10";
            MonoFlat_HeaderLabel10.Size = new Size(143, 20);
            MonoFlat_HeaderLabel10.TabIndex = 47;
            MonoFlat_HeaderLabel10.Text = "¿Deseas continuar?";
            // 
            // vistPreviaSolicitud
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(772, 465);
            Controls.Add(MonoFlat_HeaderLabel10);
            Controls.Add(MonoFlat_HeaderLabel7);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblGestor);
            Controls.Add(MonoFlat_HeaderLabel11);
            Controls.Add(lblPromotor);
            Controls.Add(MonoFlat_HeaderLabel9);
            Controls.Add(lblInteres);
            Controls.Add(MonoFlat_HeaderLabel8);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(lblTipo);
            Controls.Add(MonoFlat_HeaderLabel6);
            Controls.Add(lblPlazo);
            Controls.Add(MonoFlat_HeaderLabel5);
            Controls.Add(lblMonto);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(lblNombre);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(Panel1);
            Controls.Add(dtdatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "vistPreviaSolicitud";
            Text = "vistPreviaSolicitud";
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(vistPreviaSolicitud_Load);
            FormClosing += new FormClosingEventHandler(vistPreviaSolicitud_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel lblNombre;
        internal MonoFlat.MonoFlat_HeaderLabel lblMonto;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal MonoFlat.MonoFlat_HeaderLabel lblPlazo;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal MonoFlat.MonoFlat_HeaderLabel lblTipo;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel6;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel lblInteres;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel8;
        internal MonoFlat.MonoFlat_HeaderLabel lblPromotor;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel9;
        internal MonoFlat.MonoFlat_HeaderLabel lblGestor;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel11;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnSi;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnNo;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel7;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel10;
    }
}