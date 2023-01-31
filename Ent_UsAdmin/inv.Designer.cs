using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class inv : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(inv));
            Panel1 = new Panel();
            MonoFlat_Button2 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button2.Click += new EventHandler(MonoFlat_Button2_Click);
            MonoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button1.Click += new EventHandler(MonoFlat_Button1_Click);
            MonoFlat_Button3 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button3.Click += new EventHandler(MonoFlat_Button3_Click);
            MonoFlat_Button4 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button4.Click += new EventHandler(MonoFlat_Button4_Click);
            MonoFlat_Button5 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button5.Click += new EventHandler(MonoFlat_Button5_Click);
            MonoFlat_Button6 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button6.Click += new EventHandler(MonoFlat_Button6_Click);
            FlowLayoutPanel1 = new FlowLayoutPanel();
            MonoFlat_Button7 = new MonoFlat.MonoFlat_Button();
            MonoFlat_Button7.Click += new EventHandler(MonoFlat_Button7_Click);
            btnEmpeños = new MonoFlat.MonoFlat_Button();
            btnEmpeños.Click += new EventHandler(btnEmpeños_Click);
            btnLegalTerminal = new MonoFlat.MonoFlat_Button();
            btnLegalTerminal.Click += new EventHandler(btnLegalTerminal_Click);
            FlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel1.Location = new Point(2, 42);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(765, 348);
            Panel1.TabIndex = 2;
            // 
            // MonoFlat_Button2
            // 
            MonoFlat_Button2.BackColor = Color.Transparent;
            MonoFlat_Button2.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button2.Image = null;
            MonoFlat_Button2.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button2.Location = new Point(408, 3);
            MonoFlat_Button2.Name = "MonoFlat_Button2";
            MonoFlat_Button2.Size = new Size(89, 24);
            MonoFlat_Button2.TabIndex = 1;
            MonoFlat_Button2.Text = "Empleados";
            MonoFlat_Button2.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Button1
            // 
            MonoFlat_Button1.BackColor = Color.Transparent;
            MonoFlat_Button1.Font = new Font("Segoe UI", 11.0f);
            MonoFlat_Button1.Image = null;
            MonoFlat_Button1.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button1.Location = new Point(503, 3);
            MonoFlat_Button1.Name = "MonoFlat_Button1";
            MonoFlat_Button1.Size = new Size(125, 24);
            MonoFlat_Button1.TabIndex = 0;
            MonoFlat_Button1.Text = "Tipos de Crédito";
            MonoFlat_Button1.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Button3
            // 
            MonoFlat_Button3.BackColor = Color.Transparent;
            MonoFlat_Button3.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button3.Image = null;
            MonoFlat_Button3.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button3.Location = new Point(138, 3);
            MonoFlat_Button3.Name = "MonoFlat_Button3";
            MonoFlat_Button3.Size = new Size(86, 24);
            MonoFlat_Button3.TabIndex = 3;
            MonoFlat_Button3.Text = "Clientes";
            MonoFlat_Button3.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Button4
            // 
            MonoFlat_Button4.BackColor = Color.Transparent;
            MonoFlat_Button4.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button4.Image = null;
            MonoFlat_Button4.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button4.Location = new Point(230, 3);
            MonoFlat_Button4.Name = "MonoFlat_Button4";
            MonoFlat_Button4.Size = new Size(172, 24);
            MonoFlat_Button4.TabIndex = 4;
            MonoFlat_Button4.Text = "Tipos de Documentos";
            MonoFlat_Button4.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Button5
            // 
            MonoFlat_Button5.BackColor = Color.Transparent;
            MonoFlat_Button5.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button5.Image = null;
            MonoFlat_Button5.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button5.Location = new Point(3, 3);
            MonoFlat_Button5.Name = "MonoFlat_Button5";
            MonoFlat_Button5.Size = new Size(129, 24);
            MonoFlat_Button5.TabIndex = 5;
            MonoFlat_Button5.Text = "Créditos Activos";
            MonoFlat_Button5.TextAlignment = StringAlignment.Center;
            // 
            // MonoFlat_Button6
            // 
            MonoFlat_Button6.BackColor = Color.Transparent;
            MonoFlat_Button6.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button6.Image = null;
            MonoFlat_Button6.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button6.Location = new Point(634, 3);
            MonoFlat_Button6.Name = "MonoFlat_Button6";
            MonoFlat_Button6.Size = new Size(73, 24);
            MonoFlat_Button6.TabIndex = 6;
            MonoFlat_Button6.Text = "Cajas";
            MonoFlat_Button6.TextAlignment = StringAlignment.Center;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button5);
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button3);
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button4);
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button2);
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button1);
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button6);
            FlowLayoutPanel1.Controls.Add(MonoFlat_Button7);
            FlowLayoutPanel1.Controls.Add(btnEmpeños);
            FlowLayoutPanel1.Controls.Add(btnLegalTerminal);
            FlowLayoutPanel1.Location = new Point(2, -2);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(765, 38);
            FlowLayoutPanel1.TabIndex = 3;
            // 
            // MonoFlat_Button7
            // 
            MonoFlat_Button7.BackColor = Color.Transparent;
            MonoFlat_Button7.Font = new Font("Segoe UI", 12.0f);
            MonoFlat_Button7.Image = null;
            MonoFlat_Button7.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Button7.Location = new Point(3, 33);
            MonoFlat_Button7.Name = "MonoFlat_Button7";
            MonoFlat_Button7.Size = new Size(140, 24);
            MonoFlat_Button7.TabIndex = 7;
            MonoFlat_Button7.Text = "Créditos en Legal";
            MonoFlat_Button7.TextAlignment = StringAlignment.Center;
            // 
            // btnEmpeños
            // 
            btnEmpeños.BackColor = Color.Transparent;
            btnEmpeños.Font = new Font("Segoe UI", 12.0f);
            btnEmpeños.Image = null;
            btnEmpeños.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpeños.Location = new Point(149, 33);
            btnEmpeños.Name = "btnEmpeños";
            btnEmpeños.Size = new Size(140, 24);
            btnEmpeños.TabIndex = 8;
            btnEmpeños.Text = "Empeños Activos";
            btnEmpeños.TextAlignment = StringAlignment.Center;
            // 
            // btnLegalTerminal
            // 
            btnLegalTerminal.BackColor = Color.Transparent;
            btnLegalTerminal.Font = new Font("Segoe UI", 12.0f);
            btnLegalTerminal.Image = null;
            btnLegalTerminal.ImageAlign = ContentAlignment.MiddleLeft;
            btnLegalTerminal.Location = new Point(295, 33);
            btnLegalTerminal.Name = "btnLegalTerminal";
            btnLegalTerminal.Size = new Size(140, 24);
            btnLegalTerminal.TabIndex = 9;
            btnLegalTerminal.Text = "Legal Terminal";
            btnLegalTerminal.TextAlignment = StringAlignment.Center;
            // 
            // inv
            // 
            AutoScaleDimensions = new SizeF(96.0f, 96.0f);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(769, 402);
            Controls.Add(FlowLayoutPanel1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inv";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            FlowLayoutPanel1.ResumeLayout(false);
            SizeChanged += new EventHandler(inv_SizeChanged);
            Load += new EventHandler(inv_Load);
            ResumeLayout(false);

        }
        internal MonoFlat.MonoFlat_Button MonoFlat_Button1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button2;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button3;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button4;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button5;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button6;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal MonoFlat.MonoFlat_Button MonoFlat_Button7;
        internal MonoFlat.MonoFlat_Button btnEmpeños;
        internal MonoFlat.MonoFlat_Button btnLegalTerminal;
    }
}