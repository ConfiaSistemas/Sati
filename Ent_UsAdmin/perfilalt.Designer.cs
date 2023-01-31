using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class perfilalt : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(perfilalt));
            lblgrp = new Label();
            lblnm_complete = new Label();
            lblnm = new Label();
            Label1 = new Label();
            lbldireccion = new Label();
            Label2 = new Label();
            lbltlf = new Label();
            Label3 = new Label();
            lblSesion = new Label();
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            PictureBox2 = new PictureBox();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton23.Click += new EventHandler(BunifuThinButton23_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblgrp
            // 
            lblgrp.Location = new Point(98, 268);
            lblgrp.Name = "lblgrp";
            lblgrp.Size = new Size(100, 27);
            lblgrp.TabIndex = 11;
            lblgrp.Text = "Grupo_Usuario";
            lblgrp.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblnm_complete
            // 
            lblnm_complete.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnm_complete.Location = new Point(51, 161);
            lblnm_complete.Name = "lblnm_complete";
            lblnm_complete.Size = new Size(194, 62);
            lblnm_complete.TabIndex = 10;
            lblnm_complete.Text = "Nombre_Usuario";
            lblnm_complete.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblnm
            // 
            lblnm.Location = new Point(116, 230);
            lblnm.Name = "lblnm";
            lblnm.Size = new Size(61, 24);
            lblnm.TabIndex = 9;
            lblnm.Text = "Usuario";
            lblnm.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            Label1.Location = new Point(52, 308);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 16);
            Label1.TabIndex = 12;
            Label1.Text = "Dirección:";
            // 
            // lbldireccion
            // 
            lbldireccion.Location = new Point(116, 308);
            lbldireccion.Name = "lbldireccion";
            lbldireccion.Size = new Size(129, 52);
            lbldireccion.TabIndex = 13;
            lbldireccion.Text = "Dirección_Usuario";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(52, 369);
            Label2.Name = "Label2";
            Label2.Size = new Size(52, 13);
            Label2.TabIndex = 14;
            Label2.Text = "Teléfono:";
            // 
            // lbltlf
            // 
            lbltlf.Location = new Point(119, 368);
            lbltlf.Name = "lbltlf";
            lbltlf.Size = new Size(117, 28);
            lbltlf.TabIndex = 15;
            lbltlf.Text = "Teléfono_Usuario";
            // 
            // Label3
            // 
            Label3.Location = new Point(0, 31);
            Label3.Name = "Label3";
            Label3.Size = new Size(61, 24);
            Label3.TabIndex = 17;
            Label3.Text = "Sesión";
            Label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSesion
            // 
            lblSesion.Location = new Point(0, 55);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(61, 24);
            lblSesion.TabIndex = 18;
            lblSesion.Text = "...";
            lblSesion.TextAlign = ContentAlignment.TopCenter;
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
            BunifuThinButton22.ButtonText = "Cerrar Sesión";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.WhiteSmoke;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.FromArgb(51, 0, 204);
            BunifuThinButton22.IdleForecolor = Color.WhiteSmoke;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(55, 466);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(181, 41);
            BunifuThinButton22.TabIndex = 16;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBox2
            // 
            PictureBox2.Image = My.Resources.Resources.usuarionegro;
            PictureBox2.Location = new Point(64, 12);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(181, 146);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 8;
            PictureBox2.TabStop = false;
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
            BunifuThinButton21.Location = new Point(55, 415);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(181, 41);
            BunifuThinButton21.TabIndex = 7;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton23
            // 
            BunifuThinButton23.ActiveBorderThickness = 1;
            BunifuThinButton23.ActiveCornerRadius = 20;
            BunifuThinButton23.ActiveFillColor = Color.DimGray;
            BunifuThinButton23.ActiveForecolor = Color.White;
            BunifuThinButton23.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton23.BackColor = SystemColors.Control;
            BunifuThinButton23.BackgroundImage = (Image)resources.GetObject("BunifuThinButton23.BackgroundImage");
            BunifuThinButton23.ButtonText = "Cerrar Empresa";
            BunifuThinButton23.Cursor = Cursors.Hand;
            BunifuThinButton23.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton23.ForeColor = Color.WhiteSmoke;
            BunifuThinButton23.IdleBorderThickness = 1;
            BunifuThinButton23.IdleCornerRadius = 20;
            BunifuThinButton23.IdleFillColor = Color.FromArgb(51, 0, 204);
            BunifuThinButton23.IdleForecolor = Color.WhiteSmoke;
            BunifuThinButton23.IdleLineColor = Color.SeaGreen;
            BunifuThinButton23.Location = new Point(55, 517);
            BunifuThinButton23.Margin = new Padding(5);
            BunifuThinButton23.Name = "BunifuThinButton23";
            BunifuThinButton23.Size = new Size(181, 41);
            BunifuThinButton23.TabIndex = 19;
            BunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // perfilalt
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 572);
            Controls.Add(BunifuThinButton23);
            Controls.Add(lblSesion);
            Controls.Add(Label3);
            Controls.Add(BunifuThinButton22);
            Controls.Add(lbltlf);
            Controls.Add(Label2);
            Controls.Add(lbldireccion);
            Controls.Add(Label1);
            Controls.Add(lblgrp);
            Controls.Add(lblnm);
            Controls.Add(PictureBox2);
            Controls.Add(BunifuThinButton21);
            Controls.Add(lblnm_complete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "perfilalt";
            Opacity = 0.9d;
            Text = "perfilalt";
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            Load += new EventHandler(perfilalt_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label lblgrp;
        internal Label lblnm_complete;
        internal Label lblnm;
        internal PictureBox PictureBox2;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Label Label1;
        internal Label lbldireccion;
        internal Label Label2;
        internal Label lbltlf;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal Label Label3;
        internal Label lblSesion;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton23;
    }
}