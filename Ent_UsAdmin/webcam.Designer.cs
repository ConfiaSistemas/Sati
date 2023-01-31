using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class webcam : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(webcam));
            PictureBox1 = new PictureBox();
            Label5 = new Label();
            PictureBox2 = new PictureBox();
            VideoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            ComboBox1 = new ComboBox();
            Btn_iniciar = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_iniciar.Click += new EventHandler(Btn_iniciar_Click);
            btn_detener = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_detener.Click += new EventHandler(btn_detener_Click);
            EvolveControlBox1 = new EvolveControlBox();
            btn_capturar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_capturar.Click += new EventHandler(btn_capturar_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            PictureBox1.Location = new Point(502, 6);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(79, 29);
            PictureBox1.TabIndex = 14;
            PictureBox1.TabStop = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(12, 9);
            Label5.Name = "Label5";
            Label5.Size = new Size(51, 13);
            Label5.TabIndex = 16;
            Label5.Text = "WebCam";
            // 
            // PictureBox2
            // 
            PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            PictureBox2.Location = new Point(4, 5);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(68, 23);
            PictureBox2.TabIndex = 15;
            PictureBox2.TabStop = false;
            // 
            // VideoSourcePlayer1
            // 
            VideoSourcePlayer1.Location = new Point(79, 81);
            VideoSourcePlayer1.Name = "VideoSourcePlayer1";
            VideoSourcePlayer1.Size = new Size(287, 179);
            VideoSourcePlayer1.TabIndex = 17;
            VideoSourcePlayer1.Text = "VideoSourcePlayer1";
            VideoSourcePlayer1.VideoSource = null;
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(79, 36);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(121, 21);
            ComboBox1.TabIndex = 18;
            // 
            // Btn_iniciar
            // 
            Btn_iniciar.ActiveBorderThickness = 1;
            Btn_iniciar.ActiveCornerRadius = 20;
            Btn_iniciar.ActiveFillColor = Color.DimGray;
            Btn_iniciar.ActiveForecolor = Color.White;
            Btn_iniciar.ActiveLineColor = Color.SeaGreen;
            Btn_iniciar.BackColor = SystemColors.Control;
            Btn_iniciar.BackgroundImage = (Image)resources.GetObject("Btn_iniciar.BackgroundImage");
            Btn_iniciar.ButtonText = "Iniciar";
            Btn_iniciar.Cursor = Cursors.Hand;
            Btn_iniciar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_iniciar.ForeColor = Color.WhiteSmoke;
            Btn_iniciar.IdleBorderThickness = 1;
            Btn_iniciar.IdleCornerRadius = 20;
            Btn_iniciar.IdleFillColor = Color.FromArgb(51, 0, 204);
            Btn_iniciar.IdleForecolor = Color.WhiteSmoke;
            Btn_iniciar.IdleLineColor = Color.SeaGreen;
            Btn_iniciar.Location = new Point(221, 25);
            Btn_iniciar.Margin = new Padding(5);
            Btn_iniciar.Name = "Btn_iniciar";
            Btn_iniciar.Size = new Size(89, 41);
            Btn_iniciar.TabIndex = 19;
            Btn_iniciar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_detener
            // 
            btn_detener.ActiveBorderThickness = 1;
            btn_detener.ActiveCornerRadius = 20;
            btn_detener.ActiveFillColor = Color.DimGray;
            btn_detener.ActiveForecolor = Color.White;
            btn_detener.ActiveLineColor = Color.SeaGreen;
            btn_detener.BackColor = SystemColors.Control;
            btn_detener.BackgroundImage = (Image)resources.GetObject("btn_detener.BackgroundImage");
            btn_detener.ButtonText = "Detener";
            btn_detener.Cursor = Cursors.Hand;
            btn_detener.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_detener.ForeColor = Color.WhiteSmoke;
            btn_detener.IdleBorderThickness = 1;
            btn_detener.IdleCornerRadius = 20;
            btn_detener.IdleFillColor = Color.FromArgb(51, 0, 204);
            btn_detener.IdleForecolor = Color.WhiteSmoke;
            btn_detener.IdleLineColor = Color.SeaGreen;
            btn_detener.Location = new Point(320, 25);
            btn_detener.Margin = new Padding(5);
            btn_detener.Name = "btn_detener";
            btn_detener.Size = new Size(89, 41);
            btn_detener.TabIndex = 20;
            btn_detener.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.BackColor = SystemColors.ButtonFace;
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(509, 12);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 13;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // btn_capturar
            // 
            btn_capturar.ActiveBorderThickness = 1;
            btn_capturar.ActiveCornerRadius = 20;
            btn_capturar.ActiveFillColor = Color.DimGray;
            btn_capturar.ActiveForecolor = Color.White;
            btn_capturar.ActiveLineColor = Color.SeaGreen;
            btn_capturar.BackColor = SystemColors.Control;
            btn_capturar.BackgroundImage = (Image)resources.GetObject("btn_capturar.BackgroundImage");
            btn_capturar.ButtonText = "Capturar";
            btn_capturar.Cursor = Cursors.Hand;
            btn_capturar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_capturar.ForeColor = Color.WhiteSmoke;
            btn_capturar.IdleBorderThickness = 1;
            btn_capturar.IdleCornerRadius = 20;
            btn_capturar.IdleFillColor = Color.FromArgb(51, 0, 204);
            btn_capturar.IdleForecolor = Color.WhiteSmoke;
            btn_capturar.IdleLineColor = Color.SeaGreen;
            btn_capturar.Location = new Point(412, 25);
            btn_capturar.Margin = new Padding(5);
            btn_capturar.Name = "btn_capturar";
            btn_capturar.Size = new Size(89, 41);
            btn_capturar.TabIndex = 21;
            btn_capturar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // webcam
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 304);
            Controls.Add(btn_capturar);
            Controls.Add(btn_detener);
            Controls.Add(Btn_iniciar);
            Controls.Add(ComboBox1);
            Controls.Add(VideoSourcePlayer1);
            Controls.Add(Label5);
            Controls.Add(PictureBox2);
            Controls.Add(EvolveControlBox1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "webcam";
            Text = "webcam";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(webcam_Load);
            MouseDown += new MouseEventHandler(webcam_MouseDown);
            MouseMove += new MouseEventHandler(webcam_MouseMove);
            MouseUp += new MouseEventHandler(webcam_MouseUp);
            ResumeLayout(false);
            PerformLayout();

        }
        internal EvolveControlBox EvolveControlBox1;
        internal PictureBox PictureBox1;
        internal Label Label5;
        internal PictureBox PictureBox2;
        internal AForge.Controls.VideoSourcePlayer VideoSourcePlayer1;
        internal ComboBox ComboBox1;
        internal Bunifu.Framework.UI.BunifuThinButton2 Btn_iniciar;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_detener;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_capturar;
    }
}