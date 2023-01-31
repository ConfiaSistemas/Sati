using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class editarperfil : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(editarperfil));
            labelimagen = new Bunifu.Framework.UI.BunifuCustomLabel();
            Label1 = new Label();
            txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            Label2 = new Label();
            Label3 = new Label();
            txtdireccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            txttelefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            txttelefono.KeyPress += new KeyPressEventHandler(txttelefono_KeyPress);
            Label4 = new Label();
            Label5 = new Label();
            PictureBox2 = new PictureBox();
            BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            BunifuImageButton1.DragDrop += new DragEventHandler(BunifuImageButton1_DragDrop);
            BunifuImageButton1.DragEnter += new DragEventHandler(BunifuImageButton1_DragEnter);
            BunifuImageButton1.Click += new EventHandler(BunifuImageButton1_Click);
            PictureBox1 = new PictureBox();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            LinkLabeldelimage = new LinkLabel();
            LinkLabeldelimage.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabeldelimage_LinkClicked);
            EvolveControlBox1 = new EvolveControlBox();
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelimagen
            // 
            labelimagen.AutoSize = true;
            labelimagen.Location = new Point(53, 143);
            labelimagen.Name = "labelimagen";
            labelimagen.Size = new Size(42, 13);
            labelimagen.TabIndex = 1;
            labelimagen.Text = "Imagen";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(143, 101);
            Label1.Name = "Label1";
            Label1.Size = new Size(44, 13);
            Label1.TabIndex = 2;
            Label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.BorderColorFocused = Color.Blue;
            txtnombre.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtnombre.BorderColorMouseHover = Color.Blue;
            txtnombre.BorderThickness = 3;
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.FromArgb(64, 64, 64);
            txtnombre.isPassword = false;
            txtnombre.Location = new Point(206, 83);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(316, 44);
            txtnombre.TabIndex = 3;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(203, 66);
            Label2.Name = "Label2";
            Label2.Size = new Size(43, 13);
            Label2.TabIndex = 4;
            Label2.Text = "Usuario";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(143, 154);
            Label3.Name = "Label3";
            Label3.Size = new Size(52, 13);
            Label3.TabIndex = 5;
            Label3.Text = "Dirección";
            // 
            // txtdireccion
            // 
            txtdireccion.BorderColorFocused = Color.Blue;
            txtdireccion.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtdireccion.BorderColorMouseHover = Color.Blue;
            txtdireccion.BorderThickness = 3;
            txtdireccion.Cursor = Cursors.IBeam;
            txtdireccion.Font = new Font("Century Gothic", 9.75f);
            txtdireccion.ForeColor = Color.FromArgb(64, 64, 64);
            txtdireccion.isPassword = false;
            txtdireccion.Location = new Point(206, 135);
            txtdireccion.Margin = new Padding(4);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(316, 44);
            txtdireccion.TabIndex = 6;
            txtdireccion.TextAlign = HorizontalAlignment.Left;
            // 
            // txttelefono
            // 
            txttelefono.BorderColorFocused = Color.Blue;
            txttelefono.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txttelefono.BorderColorMouseHover = Color.Blue;
            txttelefono.BorderThickness = 3;
            txttelefono.Cursor = Cursors.IBeam;
            txttelefono.Font = new Font("Century Gothic", 9.75f);
            txttelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txttelefono.isPassword = false;
            txttelefono.Location = new Point(206, 187);
            txttelefono.Margin = new Padding(4);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(316, 44);
            txttelefono.TabIndex = 7;
            txttelefono.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(146, 205);
            Label4.Name = "Label4";
            Label4.Size = new Size(49, 13);
            Label4.TabIndex = 8;
            Label4.Text = "Teléfono";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(20, 9);
            Label5.Name = "Label5";
            Label5.Size = new Size(114, 13);
            Label5.TabIndex = 12;
            Label5.Text = "Editar Perfil de Usuario";
            // 
            // PictureBox2
            // 
            PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            PictureBox2.Location = new Point(12, 5);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(125, 23);
            PictureBox2.TabIndex = 11;
            PictureBox2.TabStop = false;
            // 
            // BunifuImageButton1
            // 
            BunifuImageButton1.BackColor = Color.Transparent;
            BunifuImageButton1.BorderStyle = BorderStyle.FixedSingle;
            BunifuImageButton1.Image = (Image)resources.GetObject("BunifuImageButton1.Image");
            BunifuImageButton1.ImageActive = null;
            BunifuImageButton1.InitialImage = null;
            BunifuImageButton1.Location = new Point(12, 85);
            BunifuImageButton1.Name = "BunifuImageButton1";
            BunifuImageButton1.Size = new Size(125, 133);
            BunifuImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            BunifuImageButton1.TabIndex = 0;
            BunifuImageButton1.TabStop = false;
            BunifuImageButton1.Zoom = 10;
            // 
            // PictureBox1
            // 
            PictureBox1.BorderStyle = BorderStyle.FixedSingle;
            PictureBox1.Location = new Point(453, -1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(79, 29);
            PictureBox1.TabIndex = 10;
            PictureBox1.TabStop = false;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.DimGray;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.BackColor = SystemColors.Control;
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Actualizar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.WhiteSmoke;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.FromArgb(51, 0, 204);
            BunifuThinButton21.IdleForecolor = Color.WhiteSmoke;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(171, 271);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(181, 41);
            BunifuThinButton21.TabIndex = 13;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinkLabeldelimage
            // 
            LinkLabeldelimage.AutoSize = true;
            LinkLabeldelimage.Location = new Point(36, 230);
            LinkLabeldelimage.Name = "LinkLabeldelimage";
            LinkLabeldelimage.Size = new Size(81, 13);
            LinkLabeldelimage.TabIndex = 14;
            LinkLabeldelimage.TabStop = true;
            LinkLabeldelimage.Text = "Eliminar Imagen";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.BackColor = SystemColors.ButtonFace;
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(460, 5);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 9;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.DimGray;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.BackColor = SystemColors.Control;
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Webcam";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.WhiteSmoke;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.FromArgb(51, 0, 204);
            BunifuThinButton22.IdleForecolor = Color.WhiteSmoke;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(12, 38);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(125, 41);
            BunifuThinButton22.TabIndex = 15;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editarperfil
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 326);
            Controls.Add(BunifuThinButton22);
            Controls.Add(LinkLabeldelimage);
            Controls.Add(BunifuThinButton21);
            Controls.Add(Label5);
            Controls.Add(PictureBox2);
            Controls.Add(EvolveControlBox1);
            Controls.Add(Label4);
            Controls.Add(txttelefono);
            Controls.Add(txtdireccion);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(txtnombre);
            Controls.Add(Label1);
            Controls.Add(labelimagen);
            Controls.Add(BunifuImageButton1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editarperfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Perfil";
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BunifuImageButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(editarperfil_Load);
            MouseDown += new MouseEventHandler(editarperfil_MouseDown);
            MouseUp += new MouseEventHandler(editarperfil_MouseUp);
            MouseMove += new MouseEventHandler(editarperfil_MouseMove);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        internal Bunifu.Framework.UI.BunifuCustomLabel labelimagen;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        internal Label Label2;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuMetroTextbox txtdireccion;
        internal Bunifu.Framework.UI.BunifuMetroTextbox txttelefono;
        internal Label Label4;
        internal EvolveControlBox EvolveControlBox1;
        internal PictureBox PictureBox1;
        internal PictureBox PictureBox2;
        internal Label Label5;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal LinkLabel LinkLabeldelimage;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
    }
}