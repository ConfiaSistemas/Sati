using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarCaja : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCaja));
            Panel1 = new Panel();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtNocaja = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            txtFondo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            txtlimite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label2 = new Label();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(370, 36);
            Panel1.TabIndex = 3;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 7);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(99, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Caja";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(301, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtNocaja
            // 
            txtNocaja.Cursor = Cursors.IBeam;
            txtNocaja.Font = new Font("Century Gothic", 9.75f);
            txtNocaja.ForeColor = Color.FromArgb(223, 223, 223);
            txtNocaja.HintForeColor = Color.White;
            txtNocaja.HintText = "";
            txtNocaja.isPassword = false;
            txtNocaja.LineFocusedColor = Color.Blue;
            txtNocaja.LineIdleColor = Color.Gray;
            txtNocaja.LineMouseHoverColor = Color.Blue;
            txtNocaja.LineThickness = 3;
            txtNocaja.Location = new Point(102, 111);
            txtNocaja.Margin = new Padding(4);
            txtNocaja.Name = "txtNocaja";
            txtNocaja.Size = new Size(142, 33);
            txtNocaja.TabIndex = 12;
            txtNocaja.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(99, 94);
            Label4.Name = "Label4";
            Label4.Size = new Size(82, 13);
            Label4.TabIndex = 11;
            Label4.Text = "Número de caja";
            // 
            // txtFondo
            // 
            txtFondo.Cursor = Cursors.IBeam;
            txtFondo.Font = new Font("Century Gothic", 9.75f);
            txtFondo.ForeColor = Color.FromArgb(223, 223, 223);
            txtFondo.HintForeColor = Color.White;
            txtFondo.HintText = "";
            txtFondo.isPassword = false;
            txtFondo.LineFocusedColor = Color.Blue;
            txtFondo.LineIdleColor = Color.Gray;
            txtFondo.LineMouseHoverColor = Color.Blue;
            txtFondo.LineThickness = 3;
            txtFondo.Location = new Point(102, 175);
            txtFondo.Margin = new Padding(4);
            txtFondo.Name = "txtFondo";
            txtFondo.Size = new Size(142, 33);
            txtFondo.TabIndex = 14;
            txtFondo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(99, 158);
            Label1.Name = "Label1";
            Label1.Size = new Size(37, 13);
            Label1.TabIndex = 13;
            Label1.Text = "Fondo";
            // 
            // btn_agregar
            // 
            btn_agregar.ActiveBorderThickness = 1;
            btn_agregar.ActiveCornerRadius = 20;
            btn_agregar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_agregar.ActiveForecolor = Color.White;
            btn_agregar.ActiveLineColor = Color.SeaGreen;
            btn_agregar.BackColor = Color.FromArgb(0, 5, 11);
            btn_agregar.BackgroundImage = (Image)resources.GetObject("btn_agregar.BackgroundImage");
            btn_agregar.ButtonText = "Dar de alta";
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.DarkBlue;
            btn_agregar.IdleBorderThickness = 1;
            btn_agregar.IdleCornerRadius = 20;
            btn_agregar.IdleFillColor = Color.White;
            btn_agregar.IdleForecolor = Color.Gray;
            btn_agregar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_agregar.Location = new Point(75, 291);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(207, 38);
            btn_agregar.TabIndex = 20;
            btn_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundWorker1
            // 
            // 
            // txtlimite
            // 
            txtlimite.Cursor = Cursors.IBeam;
            txtlimite.Font = new Font("Century Gothic", 9.75f);
            txtlimite.ForeColor = Color.FromArgb(223, 223, 223);
            txtlimite.HintForeColor = Color.White;
            txtlimite.HintText = "";
            txtlimite.isPassword = false;
            txtlimite.LineFocusedColor = Color.Blue;
            txtlimite.LineIdleColor = Color.Gray;
            txtlimite.LineMouseHoverColor = Color.Blue;
            txtlimite.LineThickness = 3;
            txtlimite.Location = new Point(102, 236);
            txtlimite.Margin = new Padding(4);
            txtlimite.Name = "txtlimite";
            txtlimite.Size = new Size(142, 33);
            txtlimite.TabIndex = 22;
            txtlimite.TextAlign = HorizontalAlignment.Left;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(99, 222);
            Label2.Name = "Label2";
            Label2.Size = new Size(36, 13);
            Label2.TabIndex = 21;
            Label2.Text = "Límite";
            // 
            // AgregarCaja
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(370, 343);
            Controls.Add(txtlimite);
            Controls.Add(Label2);
            Controls.Add(btn_agregar);
            Controls.Add(txtFondo);
            Controls.Add(Label1);
            Controls.Add(txtNocaja);
            Controls.Add(Label4);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarCaja";
            Text = "AgregarCaja";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(AgregarCaja_Load);
            FormClosing += new FormClosingEventHandler(AgregarCaja_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNocaja;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtFondo;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_agregar;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtlimite;
        internal Label Label2;
    }
}