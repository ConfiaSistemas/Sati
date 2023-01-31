using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarDocumentoVerificacion : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDocumentoVerificacion));
            Panel1 = new Panel();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            ComboDocumento = new ComboBox();
            Label11 = new Label();
            BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            BunifuImageButton1.Click += new EventHandler(BunifuImageButton1_Click);
            Label1 = new Label();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            BackgroundTiposDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundTiposDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTiposDocumentos_DoWork);
            BackgroundTiposDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTiposDocumentos_RunWorkerCompleted);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(461, 36);
            Panel1.TabIndex = 2;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 7);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(152, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Documento";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(392, 4);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // ComboDocumento
            // 
            ComboDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDocumento.FormattingEnabled = true;
            ComboDocumento.Location = new Point(86, 128);
            ComboDocumento.Name = "ComboDocumento";
            ComboDocumento.Size = new Size(240, 21);
            ComboDocumento.TabIndex = 19;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(83, 112);
            Label11.Name = "Label11";
            Label11.Size = new Size(28, 13);
            Label11.TabIndex = 63;
            Label11.Text = "Tipo";
            // 
            // BunifuImageButton1
            // 
            BunifuImageButton1.BackColor = Color.Transparent;
            BunifuImageButton1.Image = My.Resources.Resources.new_seo2_38_512;
            BunifuImageButton1.ImageActive = null;
            BunifuImageButton1.Location = new Point(86, 200);
            BunifuImageButton1.Name = "BunifuImageButton1";
            BunifuImageButton1.Size = new Size(240, 201);
            BunifuImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            BunifuImageButton1.TabIndex = 64;
            BunifuImageButton1.TabStop = false;
            BunifuImageButton1.Zoom = 10;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(83, 184);
            Label1.Name = "Label1";
            Label1.Size = new Size(42, 13);
            Label1.TabIndex = 65;
            Label1.Text = "Imagen";
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
            btn_Procesar.ButtonText = "Cargar";
            btn_Procesar.Cursor = Cursors.Hand;
            btn_Procesar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Procesar.ForeColor = Color.DarkBlue;
            btn_Procesar.IdleBorderThickness = 1;
            btn_Procesar.IdleCornerRadius = 20;
            btn_Procesar.IdleFillColor = Color.White;
            btn_Procesar.IdleForecolor = Color.Gray;
            btn_Procesar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.Location = new Point(110, 427);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 152;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundTiposDocumentos
            // 
            // 
            // AgregarDocumentoVerificacion
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(464, 479);
            Controls.Add(btn_Procesar);
            Controls.Add(Label1);
            Controls.Add(BunifuImageButton1);
            Controls.Add(Label11);
            Controls.Add(ComboDocumento);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarDocumentoVerificacion";
            Text = "Agregar Documento";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).EndInit();
            Load += new EventHandler(AgregarDocumentoDatosSolicitud_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal ComboBox ComboDocumento;
        internal Label Label11;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal System.ComponentModel.BackgroundWorker BackgroundTiposDocumentos;
    }
}