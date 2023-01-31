using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class DescuentoPromesaLegal : Form
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
            txtOtraCantidad = new Button();
            txtOtraCantidad.Click += new EventHandler(txtOtraCantidad_Click);
            txtcantidad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            lblMaximo = new MonoFlat.MonoFlat_HeaderLabel();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtOtraCantidad
            // 
            txtOtraCantidad.FlatAppearance.BorderSize = 3;
            txtOtraCantidad.FlatStyle = FlatStyle.Flat;
            txtOtraCantidad.ForeColor = Color.Transparent;
            txtOtraCantidad.Location = new Point(213, 171);
            txtOtraCantidad.Name = "txtOtraCantidad";
            txtOtraCantidad.Size = new Size(76, 45);
            txtOtraCantidad.TabIndex = 46;
            txtOtraCantidad.Text = "Aceptar";
            txtOtraCantidad.UseVisualStyleBackColor = true;
            // 
            // txtcantidad
            // 
            txtcantidad.BorderColorFocused = Color.Blue;
            txtcantidad.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtcantidad.BorderColorMouseHover = Color.Blue;
            txtcantidad.BorderThickness = 3;
            txtcantidad.Cursor = Cursors.IBeam;
            txtcantidad.Font = new Font("Century Gothic", 9.75f);
            txtcantidad.ForeColor = Color.White;
            txtcantidad.isPassword = false;
            txtcantidad.Location = new Point(121, 109);
            txtcantidad.Margin = new Padding(4);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(260, 44);
            txtcantidad.TabIndex = 45;
            txtcantidad.TextAlign = HorizontalAlignment.Left;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(492, 36);
            Panel1.TabIndex = 44;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(423, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 32;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 1);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(136, 20);
            MonoFlat_HeaderLabel1.TabIndex = 2;
            MonoFlat_HeaderLabel1.Text = "Aplicar Descuento";
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(12, 53);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(156, 20);
            MonoFlat_HeaderLabel2.TabIndex = 33;
            MonoFlat_HeaderLabel2.Text = "Máximo a descontar:";
            // 
            // lblMaximo
            // 
            lblMaximo.AutoSize = true;
            lblMaximo.BackColor = Color.Transparent;
            lblMaximo.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMaximo.ForeColor = Color.FromArgb(255, 255, 255);
            lblMaximo.Location = new Point(174, 53);
            lblMaximo.Name = "lblMaximo";
            lblMaximo.Size = new Size(21, 20);
            lblMaximo.TabIndex = 47;
            lblMaximo.Text = "...";
            // 
            // DescuentoPromesa
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(494, 224);
            Controls.Add(lblMaximo);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(txtOtraCantidad);
            Controls.Add(txtcantidad);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DescuentoPromesa";
            Text = "DescuentoPromesa";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(DescuentoPromesa_Load);
            FormClosing += new FormClosingEventHandler(DescuentoPromesa_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button txtOtraCantidad;
        internal Bunifu.Framework.UI.BunifuMetroTextbox txtcantidad;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel lblMaximo;
    }
}