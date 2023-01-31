using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EntregarDocumentacionEmpeño : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregarDocumentacionEmpeño));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            lblNombre = new MonoFlat.MonoFlat_Label();
            lblMonto = new MonoFlat.MonoFlat_Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            BackgroundContrato = new System.ComponentModel.BackgroundWorker();
            BackgroundContrato.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundContrato_DoWork);
            BackgroundContrato.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundContrato_RunWorkerCompleted);
            BackgroundEntrega = new System.ComponentModel.BackgroundWorker();
            BackgroundEntrega.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundEntrega_DoWork);
            BackgroundEntrega.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundEntrega_RunWorkerCompleted);
            BackgroundTestimonial = new System.ComponentModel.BackgroundWorker();
            BackgroundTestimonial.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTestimonial_DoWork);
            BackgroundTestimonial.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTestimonial_RunWorkerCompleted);
            labelimagen = new Bunifu.Framework.UI.BunifuCustomLabel();
            BackgroundActivar = new System.ComponentModel.BackgroundWorker();
            BackgroundActivar.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActivar_DoWork);
            BackgroundActivar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActivar_RunWorkerCompleted);
            BackgroundBoleta = new System.ComponentModel.BackgroundWorker();
            BackgroundBoleta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundBoleta_DoWork);
            BackgroundBoleta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundBoleta_RunWorkerCompleted);
            BackgroundTarjeta = new System.ComponentModel.BackgroundWorker();
            //BackgroundTarjeta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTarjeta_DoWork);
           // BackgroundTarjeta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTarjeta_RunWorkerCompleted);
            btn_Boleta = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Boleta.Click += new EventHandler(BunifuThinButton24_Click);
            btn_activarEmpeño = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_activarEmpeño.Click += new EventHandler(btn_activar_Click);
            btn_Webcam = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Webcam.Click += new EventHandler(BunifuThinButton23_Click);
            BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            BunifuImageButton1.DragDrop += new DragEventHandler(BunifuImageButton1_DragDrop);
            BunifuImageButton1.DragEnter += new DragEventHandler(BunifuImageButton1_DragEnter);
            BunifuImageButton1.Click += new EventHandler(BunifuImageButton1_Click);
            btn_Testimonial = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Testimonial.Click += new EventHandler(Btn_Testimonial_Click);
            btn_Contrato = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Contrato.Click += new EventHandler(btn_Contrato_Click);
            btn_EntregarEmpeño = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_EntregarEmpeño.Click += new EventHandler(btn_EntregarEmpeño_Click);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(2, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(598, 40);
            Panel1.TabIndex = 2;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 4);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(183, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Entregar Documentación";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(530, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(116, 125, 132);
            lblNombre.Location = new Point(159, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(13, 21);
            lblNombre.TabIndex = 35;
            lblNombre.Text = ".";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.Transparent;
            lblMonto.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.ForeColor = Color.FromArgb(116, 125, 132);
            lblMonto.Location = new Point(159, 94);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(13, 21);
            lblMonto.TabIndex = 36;
            lblMonto.Text = ".";
            // 
            // BackgroundWorker1
            // 
            // 
            // BackgroundContrato
            // 
            // 
            // BackgroundEntrega
            // 
            // 
            // BackgroundTestimonial
            // 
            // 
            // labelimagen
            // 
            labelimagen.AutoSize = true;
            labelimagen.ForeColor = SystemColors.ButtonFace;
            labelimagen.Location = new Point(249, 461);
            labelimagen.Name = "labelimagen";
            labelimagen.Size = new Size(42, 13);
            labelimagen.TabIndex = 39;
            labelimagen.Text = "Imagen";
            labelimagen.Visible = false;
            // 
            // BackgroundActivar
            // 
            // 
            // BackgroundBoleta
            // 
            // 
            // BackgroundTarjeta
            // 
            // 
            // btn_Boleta
            // 
            btn_Boleta.ActiveBorderThickness = 1;
            btn_Boleta.ActiveCornerRadius = 20;
            btn_Boleta.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Boleta.ActiveForecolor = Color.White;
            btn_Boleta.ActiveLineColor = Color.SeaGreen;
            btn_Boleta.BackColor = Color.FromArgb(0, 5, 11);
            btn_Boleta.BackgroundImage = (Image)resources.GetObject("btn_Boleta.BackgroundImage");
            btn_Boleta.ButtonText = "Boleta de Empeño";
            btn_Boleta.Cursor = Cursors.Hand;
            btn_Boleta.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Boleta.ForeColor = Color.DarkBlue;
            btn_Boleta.IdleBorderThickness = 1;
            btn_Boleta.IdleCornerRadius = 20;
            btn_Boleta.IdleFillColor = Color.White;
            btn_Boleta.IdleForecolor = Color.Gray;
            btn_Boleta.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Boleta.Location = new Point(162, 324);
            btn_Boleta.Margin = new Padding(5);
            btn_Boleta.Name = "btn_Boleta";
            btn_Boleta.Size = new Size(216, 38);
            btn_Boleta.TabIndex = 42;
            btn_Boleta.TextAlign = ContentAlignment.MiddleCenter;
            btn_Boleta.Visible = false;
            // 
            // btn_activarEmpeño
            // 
            btn_activarEmpeño.ActiveBorderThickness = 1;
            btn_activarEmpeño.ActiveCornerRadius = 20;
            btn_activarEmpeño.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_activarEmpeño.ActiveForecolor = Color.White;
            btn_activarEmpeño.ActiveLineColor = Color.SeaGreen;
            btn_activarEmpeño.BackColor = Color.FromArgb(0, 5, 11);
            btn_activarEmpeño.BackgroundImage = (Image)resources.GetObject("btn_activarEmpeño.BackgroundImage");
            btn_activarEmpeño.ButtonText = "Activar Crédito";
            btn_activarEmpeño.Cursor = Cursors.Hand;
            btn_activarEmpeño.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_activarEmpeño.ForeColor = Color.DarkBlue;
            btn_activarEmpeño.IdleBorderThickness = 1;
            btn_activarEmpeño.IdleCornerRadius = 20;
            btn_activarEmpeño.IdleFillColor = Color.White;
            btn_activarEmpeño.IdleForecolor = Color.Gray;
            btn_activarEmpeño.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_activarEmpeño.Location = new Point(162, 593);
            btn_activarEmpeño.Margin = new Padding(5);
            btn_activarEmpeño.Name = "btn_activarEmpeño";
            btn_activarEmpeño.Size = new Size(216, 38);
            btn_activarEmpeño.TabIndex = 41;
            btn_activarEmpeño.TextAlign = ContentAlignment.MiddleCenter;
            btn_activarEmpeño.Visible = false;
            // 
            // btn_Webcam
            // 
            btn_Webcam.ActiveBorderThickness = 1;
            btn_Webcam.ActiveCornerRadius = 20;
            btn_Webcam.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Webcam.ActiveForecolor = Color.White;
            btn_Webcam.ActiveLineColor = Color.SeaGreen;
            btn_Webcam.BackColor = Color.FromArgb(0, 5, 11);
            btn_Webcam.BackgroundImage = (Image)resources.GetObject("btn_Webcam.BackgroundImage");
            btn_Webcam.ButtonText = "Webcam";
            btn_Webcam.Cursor = Cursors.Hand;
            btn_Webcam.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Webcam.ForeColor = Color.DarkBlue;
            btn_Webcam.IdleBorderThickness = 1;
            btn_Webcam.IdleCornerRadius = 20;
            btn_Webcam.IdleFillColor = Color.White;
            btn_Webcam.IdleForecolor = Color.Gray;
            btn_Webcam.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Webcam.Location = new Point(354, 436);
            btn_Webcam.Margin = new Padding(5);
            btn_Webcam.Name = "btn_Webcam";
            btn_Webcam.Size = new Size(94, 38);
            btn_Webcam.TabIndex = 40;
            btn_Webcam.TextAlign = ContentAlignment.MiddleCenter;
            btn_Webcam.Visible = false;
            // 
            // BunifuImageButton1
            // 
            BunifuImageButton1.BackColor = Color.Transparent;
            BunifuImageButton1.BorderStyle = BorderStyle.FixedSingle;
            BunifuImageButton1.Image = (Image)resources.GetObject("BunifuImageButton1.Image");
            BunifuImageButton1.ImageActive = null;
            BunifuImageButton1.InitialImage = null;
            BunifuImageButton1.Location = new Point(207, 403);
            BunifuImageButton1.Name = "BunifuImageButton1";
            BunifuImageButton1.Size = new Size(125, 133);
            BunifuImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            BunifuImageButton1.TabIndex = 38;
            BunifuImageButton1.TabStop = false;
            BunifuImageButton1.Visible = false;
            BunifuImageButton1.Zoom = 10;
            // 
            // btn_Testimonial
            // 
            btn_Testimonial.ActiveBorderThickness = 1;
            btn_Testimonial.ActiveCornerRadius = 20;
            btn_Testimonial.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Testimonial.ActiveForecolor = Color.White;
            btn_Testimonial.ActiveLineColor = Color.SeaGreen;
            btn_Testimonial.BackColor = Color.FromArgb(0, 5, 11);
            btn_Testimonial.BackgroundImage = (Image)resources.GetObject("btn_Testimonial.BackgroundImage");
            btn_Testimonial.ButtonText = "Testimonial";
            btn_Testimonial.Cursor = Cursors.Hand;
            btn_Testimonial.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Testimonial.ForeColor = Color.DarkBlue;
            btn_Testimonial.IdleBorderThickness = 1;
            btn_Testimonial.IdleCornerRadius = 20;
            btn_Testimonial.IdleFillColor = Color.White;
            btn_Testimonial.IdleForecolor = Color.Gray;
            btn_Testimonial.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Testimonial.Location = new Point(163, 265);
            btn_Testimonial.Margin = new Padding(5);
            btn_Testimonial.Name = "btn_Testimonial";
            btn_Testimonial.Size = new Size(216, 38);
            btn_Testimonial.TabIndex = 32;
            btn_Testimonial.TextAlign = ContentAlignment.MiddleCenter;
            btn_Testimonial.Visible = false;
            // 
            // btn_Contrato
            // 
            btn_Contrato.ActiveBorderThickness = 1;
            btn_Contrato.ActiveCornerRadius = 20;
            btn_Contrato.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Contrato.ActiveForecolor = Color.White;
            btn_Contrato.ActiveLineColor = Color.SeaGreen;
            btn_Contrato.BackColor = Color.FromArgb(0, 5, 11);
            btn_Contrato.BackgroundImage = (Image)resources.GetObject("btn_Contrato.BackgroundImage");
            btn_Contrato.ButtonText = "Contrato";
            btn_Contrato.Cursor = Cursors.Hand;
            btn_Contrato.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Contrato.ForeColor = Color.DarkBlue;
            btn_Contrato.IdleBorderThickness = 1;
            btn_Contrato.IdleCornerRadius = 20;
            btn_Contrato.IdleFillColor = Color.White;
            btn_Contrato.IdleForecolor = Color.Gray;
            btn_Contrato.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Contrato.Location = new Point(162, 202);
            btn_Contrato.Margin = new Padding(5);
            btn_Contrato.Name = "btn_Contrato";
            btn_Contrato.Size = new Size(216, 38);
            btn_Contrato.TabIndex = 31;
            btn_Contrato.TextAlign = ContentAlignment.MiddleCenter;
            btn_Contrato.Visible = false;
            // 
            // btn_EntregarEmpeño
            // 
            btn_EntregarEmpeño.ActiveBorderThickness = 1;
            btn_EntregarEmpeño.ActiveCornerRadius = 20;
            btn_EntregarEmpeño.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_EntregarEmpeño.ActiveForecolor = Color.White;
            btn_EntregarEmpeño.ActiveLineColor = Color.SeaGreen;
            btn_EntregarEmpeño.BackColor = Color.FromArgb(0, 5, 11);
            btn_EntregarEmpeño.BackgroundImage = (Image)resources.GetObject("btn_EntregarEmpeño.BackgroundImage");
            btn_EntregarEmpeño.ButtonText = "Entregar Empeño";
            btn_EntregarEmpeño.Cursor = Cursors.Hand;
            btn_EntregarEmpeño.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EntregarEmpeño.ForeColor = Color.DarkBlue;
            btn_EntregarEmpeño.IdleBorderThickness = 1;
            btn_EntregarEmpeño.IdleCornerRadius = 20;
            btn_EntregarEmpeño.IdleFillColor = Color.White;
            btn_EntregarEmpeño.IdleForecolor = Color.Gray;
            btn_EntregarEmpeño.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_EntregarEmpeño.Location = new Point(163, 142);
            btn_EntregarEmpeño.Margin = new Padding(5);
            btn_EntregarEmpeño.Name = "btn_EntregarEmpeño";
            btn_EntregarEmpeño.Size = new Size(216, 38);
            btn_EntregarEmpeño.TabIndex = 43;
            btn_EntregarEmpeño.TextAlign = ContentAlignment.MiddleCenter;
            btn_EntregarEmpeño.Visible = false;
            // 
            // EntregarDocumentacionEmpeño
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(602, 707);
            Controls.Add(btn_EntregarEmpeño);
            Controls.Add(btn_Boleta);
            Controls.Add(btn_activarEmpeño);
            Controls.Add(btn_Webcam);
            Controls.Add(labelimagen);
            Controls.Add(BunifuImageButton1);
            Controls.Add(lblMonto);
            Controls.Add(lblNombre);
            Controls.Add(btn_Testimonial);
            Controls.Add(btn_Contrato);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntregarDocumentacionEmpeño";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entregar Documentación";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).EndInit();
            Load += new EventHandler(EntregarDocumentacion_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Contrato;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Testimonial;
        internal MonoFlat.MonoFlat_Label lblNombre;
        internal MonoFlat.MonoFlat_Label lblMonto;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.ComponentModel.BackgroundWorker BackgroundContrato;
        internal System.ComponentModel.BackgroundWorker BackgroundEntrega;
        internal System.ComponentModel.BackgroundWorker BackgroundTestimonial;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        internal Bunifu.Framework.UI.BunifuCustomLabel labelimagen;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Webcam;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_activarEmpeño;
        internal System.ComponentModel.BackgroundWorker BackgroundActivar;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Boleta;
        internal System.ComponentModel.BackgroundWorker BackgroundBoleta;
        internal System.ComponentModel.BackgroundWorker BackgroundTarjeta;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_EntregarEmpeño;
    }
}