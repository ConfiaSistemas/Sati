using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EntregarDocumentacion : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(EntregarDocumentacion));
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
            BackgroundPagare = new System.ComponentModel.BackgroundWorker();
            BackgroundPagare.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPagare_DoWork);
            BackgroundPagare.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundPagare_RunWorkerCompleted);
            BackgroundEntrega = new System.ComponentModel.BackgroundWorker();
            BackgroundEntrega.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundEntrega_DoWork);
            BackgroundEntrega.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundEntrega_RunWorkerCompleted);
            BackgroundEntrega.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BackgroundEntrega_ProgressChanged);
            BackgroundCalendario = new System.ComponentModel.BackgroundWorker();
            BackgroundCalendario.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCalendario_DoWork);
            BackgroundCalendario.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCalendario_RunWorkerCompleted);
            labelimagen = new Bunifu.Framework.UI.BunifuCustomLabel();
            BackgroundActivar = new System.ComponentModel.BackgroundWorker();
            BackgroundActivar.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActivar_DoWork);
            BackgroundActivar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActivar_RunWorkerCompleted);
            BackgroundCatatula = new System.ComponentModel.BackgroundWorker();
            BackgroundCatatula.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCatatula_DoWork);
            BackgroundCatatula.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCatatula_RunWorkerCompleted);
            BackgroundTarjeta = new System.ComponentModel.BackgroundWorker();
            BackgroundTarjeta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTarjeta_DoWork);
            BackgroundTarjeta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTarjeta_RunWorkerCompleted);
            BackgroundGrupal = new System.ComponentModel.BackgroundWorker();
            BackgroundGrupal.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGrupal_DoWork);
            BackgroundGrupal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGrupal_RunWorkerCompleted);
            lblMotoCapturada = new MonoFlat.MonoFlat_Label();
            btnGrupal = new Bunifu.Framework.UI.BunifuThinButton2();
            btnGrupal.Click += new EventHandler(btnGrupal_Click);
            btnMoto = new Bunifu.Framework.UI.BunifuThinButton2();
            btnMoto.Click += new EventHandler(btnTarjeta_Click);
            BunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton24.Click += new EventHandler(BunifuThinButton24_Click);
            btn_activar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_activar.Click += new EventHandler(btn_activar_Click);
            BunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton23.Click += new EventHandler(BunifuThinButton23_Click);
            BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            BunifuImageButton1.DragDrop += new DragEventHandler(BunifuImageButton1_DragDrop);
            BunifuImageButton1.DragEnter += new DragEventHandler(BunifuImageButton1_DragEnter);
            BunifuImageButton1.Click += new EventHandler(BunifuImageButton1_Click);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
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
            lblNombre.ForeColor = Color.White;
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
            lblMonto.ForeColor = Color.White;
            lblMonto.Location = new Point(159, 94);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(13, 21);
            lblMonto.TabIndex = 36;
            lblMonto.Text = ".";
            // 
            // BackgroundWorker1
            // 
            // 
            // BackgroundPagare
            // 
            // 
            // BackgroundEntrega
            // 
            // 
            // BackgroundCalendario
            // 
            // 
            // labelimagen
            // 
            labelimagen.AutoSize = true;
            labelimagen.ForeColor = SystemColors.ButtonFace;
            labelimagen.Location = new Point(249, 553);
            labelimagen.Name = "labelimagen";
            labelimagen.Size = new Size(40, 13);
            labelimagen.TabIndex = 39;
            labelimagen.Text = "Control";
            labelimagen.Visible = false;
            // 
            // BackgroundActivar
            // 
            // 
            // BackgroundCatatula
            // 
            // 
            // BackgroundTarjeta
            // 
            // 
            // BackgroundGrupal
            // 
            // 
            // lblMotoCapturada
            // 
            lblMotoCapturada.AutoSize = true;
            lblMotoCapturada.BackColor = Color.Transparent;
            lblMotoCapturada.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotoCapturada.ForeColor = Color.White;
            lblMotoCapturada.Location = new Point(159, 140);
            lblMotoCapturada.Name = "lblMotoCapturada";
            lblMotoCapturada.Size = new Size(13, 21);
            lblMotoCapturada.TabIndex = 45;
            lblMotoCapturada.Text = ".";
            // 
            // btnGrupal
            // 
            btnGrupal.ActiveBorderThickness = 1;
            btnGrupal.ActiveCornerRadius = 20;
            btnGrupal.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnGrupal.ActiveForecolor = Color.White;
            btnGrupal.ActiveLineColor = Color.SeaGreen;
            btnGrupal.BackColor = Color.FromArgb(0, 5, 11);
            btnGrupal.BackgroundImage = (Image)resources.GetObject("btnGrupal.BackgroundImage");
            btnGrupal.ButtonText = "...";
            btnGrupal.Cursor = Cursors.Hand;
            btnGrupal.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrupal.ForeColor = Color.DarkBlue;
            btnGrupal.IdleBorderThickness = 1;
            btnGrupal.IdleCornerRadius = 20;
            btnGrupal.IdleFillColor = Color.White;
            btnGrupal.IdleForecolor = Color.Gray;
            btnGrupal.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnGrupal.Location = new Point(384, 311);
            btnGrupal.Margin = new Padding(5);
            btnGrupal.Name = "btnGrupal";
            btnGrupal.Size = new Size(39, 38);
            btnGrupal.TabIndex = 44;
            btnGrupal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMoto
            // 
            btnMoto.ActiveBorderThickness = 1;
            btnMoto.ActiveCornerRadius = 20;
            btnMoto.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnMoto.ActiveForecolor = Color.White;
            btnMoto.ActiveLineColor = Color.SeaGreen;
            btnMoto.BackColor = Color.FromArgb(0, 5, 11);
            btnMoto.BackgroundImage = (Image)resources.GetObject("btnMoto.BackgroundImage");
            btnMoto.ButtonText = "Capturar Motocicleta";
            btnMoto.Cursor = Cursors.Hand;
            btnMoto.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMoto.ForeColor = Color.DarkBlue;
            btnMoto.IdleBorderThickness = 1;
            btnMoto.IdleCornerRadius = 20;
            btnMoto.IdleFillColor = Color.White;
            btnMoto.IdleForecolor = Color.Gray;
            btnMoto.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnMoto.Location = new Point(162, 422);
            btnMoto.Margin = new Padding(5);
            btnMoto.Name = "btnMoto";
            btnMoto.Size = new Size(216, 38);
            btnMoto.TabIndex = 43;
            btnMoto.TextAlign = ContentAlignment.MiddleCenter;
            btnMoto.Visible = false;
            // 
            // BunifuThinButton24
            // 
            BunifuThinButton24.ActiveBorderThickness = 1;
            BunifuThinButton24.ActiveCornerRadius = 20;
            BunifuThinButton24.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton24.ActiveForecolor = Color.White;
            BunifuThinButton24.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton24.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton24.BackgroundImage = (Image)resources.GetObject("BunifuThinButton24.BackgroundImage");
            BunifuThinButton24.ButtonText = "Carátula Informativa";
            BunifuThinButton24.Cursor = Cursors.Hand;
            BunifuThinButton24.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton24.ForeColor = Color.DarkBlue;
            BunifuThinButton24.IdleBorderThickness = 1;
            BunifuThinButton24.IdleCornerRadius = 20;
            BunifuThinButton24.IdleFillColor = Color.White;
            BunifuThinButton24.IdleForecolor = Color.Gray;
            BunifuThinButton24.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton24.Location = new Point(163, 369);
            BunifuThinButton24.Margin = new Padding(5);
            BunifuThinButton24.Name = "BunifuThinButton24";
            BunifuThinButton24.Size = new Size(216, 38);
            BunifuThinButton24.TabIndex = 42;
            BunifuThinButton24.TextAlign = ContentAlignment.MiddleCenter;
            BunifuThinButton24.Visible = false;
            // 
            // btn_activar
            // 
            btn_activar.ActiveBorderThickness = 1;
            btn_activar.ActiveCornerRadius = 20;
            btn_activar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_activar.ActiveForecolor = Color.White;
            btn_activar.ActiveLineColor = Color.SeaGreen;
            btn_activar.BackColor = Color.FromArgb(0, 5, 11);
            btn_activar.BackgroundImage = (Image)resources.GetObject("btn_activar.BackgroundImage");
            btn_activar.ButtonText = "Activar Crédito";
            btn_activar.Cursor = Cursors.Hand;
            btn_activar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_activar.ForeColor = Color.DarkBlue;
            btn_activar.IdleBorderThickness = 1;
            btn_activar.IdleCornerRadius = 20;
            btn_activar.IdleFillColor = Color.White;
            btn_activar.IdleForecolor = Color.Gray;
            btn_activar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_activar.Location = new Point(162, 639);
            btn_activar.Margin = new Padding(5);
            btn_activar.Name = "btn_activar";
            btn_activar.Size = new Size(216, 38);
            btn_activar.TabIndex = 41;
            btn_activar.TextAlign = ContentAlignment.MiddleCenter;
            btn_activar.Visible = false;
            // 
            // BunifuThinButton23
            // 
            BunifuThinButton23.ActiveBorderThickness = 1;
            BunifuThinButton23.ActiveCornerRadius = 20;
            BunifuThinButton23.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton23.ActiveForecolor = Color.White;
            BunifuThinButton23.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton23.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton23.BackgroundImage = (Image)resources.GetObject("BunifuThinButton23.BackgroundImage");
            BunifuThinButton23.ButtonText = "Webcam";
            BunifuThinButton23.Cursor = Cursors.Hand;
            BunifuThinButton23.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton23.ForeColor = Color.DarkBlue;
            BunifuThinButton23.IdleBorderThickness = 1;
            BunifuThinButton23.IdleCornerRadius = 20;
            BunifuThinButton23.IdleFillColor = Color.White;
            BunifuThinButton23.IdleForecolor = Color.Gray;
            BunifuThinButton23.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton23.Location = new Point(354, 528);
            BunifuThinButton23.Margin = new Padding(5);
            BunifuThinButton23.Name = "BunifuThinButton23";
            BunifuThinButton23.Size = new Size(94, 38);
            BunifuThinButton23.TabIndex = 40;
            BunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            BunifuThinButton23.Visible = false;
            // 
            // BunifuImageButton1
            // 
            BunifuImageButton1.BackColor = Color.Transparent;
            BunifuImageButton1.BorderStyle = BorderStyle.FixedSingle;
            BunifuImageButton1.Image = (Image)resources.GetObject("BunifuImageButton1.Image");
            BunifuImageButton1.ImageActive = null;
            BunifuImageButton1.InitialImage = null;
            BunifuImageButton1.Location = new Point(207, 495);
            BunifuImageButton1.Name = "BunifuImageButton1";
            BunifuImageButton1.Size = new Size(125, 133);
            BunifuImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            BunifuImageButton1.TabIndex = 38;
            BunifuImageButton1.TabStop = false;
            BunifuImageButton1.Visible = false;
            BunifuImageButton1.Zoom = 10;
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Entregar Crédito";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.DarkBlue;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.Gray;
            BunifuThinButton22.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton22.Location = new Point(162, 185);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(216, 38);
            BunifuThinButton22.TabIndex = 37;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            BunifuThinButton22.Visible = false;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Calendario";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.DarkBlue;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.Gray;
            BunifuThinButton21.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton21.Location = new Point(163, 311);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(216, 38);
            BunifuThinButton21.TabIndex = 32;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            BunifuThinButton21.Visible = false;
            // 
            // btn_Procesar
            // 
            btn_Procesar.ActiveBorderThickness = 1;
            btn_Procesar.ActiveCornerRadius = 20;
            btn_Procesar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.ActiveForecolor = Color.White;
            btn_Procesar.ActiveLineColor = Color.SeaGreen;
            btn_Procesar.BackColor = Color.FromArgb(0, 5, 11);
            btn_Procesar.BackgroundImage = (Image)resources.GetObject("btn_Procesar.BackgroundImage");
            btn_Procesar.ButtonText = "Pagaré";
            btn_Procesar.Cursor = Cursors.Hand;
            btn_Procesar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Procesar.ForeColor = Color.DarkBlue;
            btn_Procesar.IdleBorderThickness = 1;
            btn_Procesar.IdleCornerRadius = 20;
            btn_Procesar.IdleFillColor = Color.White;
            btn_Procesar.IdleForecolor = Color.Gray;
            btn_Procesar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.Location = new Point(162, 248);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 31;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            btn_Procesar.Visible = false;
            // 
            // EntregarDocumentacion
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(602, 707);
            Controls.Add(lblMotoCapturada);
            Controls.Add(btnGrupal);
            Controls.Add(btnMoto);
            Controls.Add(BunifuThinButton24);
            Controls.Add(btn_activar);
            Controls.Add(BunifuThinButton23);
            Controls.Add(labelimagen);
            Controls.Add(BunifuImageButton1);
            Controls.Add(BunifuThinButton22);
            Controls.Add(lblMonto);
            Controls.Add(lblNombre);
            Controls.Add(BunifuThinButton21);
            Controls.Add(btn_Procesar);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntregarDocumentacion";
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
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal MonoFlat.MonoFlat_Label lblNombre;
        internal MonoFlat.MonoFlat_Label lblMonto;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.ComponentModel.BackgroundWorker BackgroundPagare;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal System.ComponentModel.BackgroundWorker BackgroundEntrega;
        internal System.ComponentModel.BackgroundWorker BackgroundCalendario;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        internal Bunifu.Framework.UI.BunifuCustomLabel labelimagen;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton23;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_activar;
        internal System.ComponentModel.BackgroundWorker BackgroundActivar;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton24;
        internal System.ComponentModel.BackgroundWorker BackgroundCatatula;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnMoto;
        internal System.ComponentModel.BackgroundWorker BackgroundTarjeta;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnGrupal;
        internal System.ComponentModel.BackgroundWorker BackgroundGrupal;
        internal MonoFlat.MonoFlat_Label lblMotoCapturada;
    }
}