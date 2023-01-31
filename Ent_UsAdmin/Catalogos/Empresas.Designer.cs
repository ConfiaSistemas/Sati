using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Empresas : Form
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresas));
            FlowLayoutPanel1 = new FlowLayoutPanel();
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Panel2 = new Panel();
            Timer2 = new Timer(components);
            Timer2.Tick += new EventHandler(Timer2_Tick);
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.AutoScroll = true;
            FlowLayoutPanel1.Location = new Point(12, 135);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(434, 511);
            FlowLayoutPanel1.TabIndex = 0;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(452, 36);
            Panel1.TabIndex = 2;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(76, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Empresas";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(376, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // Button1
            // 
            Button1.Location = new Point(3, 3);
            Button1.Name = "Button1";
            Button1.Size = new Size(98, 23);
            Button1.TabIndex = 3;
            Button1.Text = "Agregar Empresa";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Timer1
            // 
            // 
            // Panel2
            // 
            Panel2.Controls.Add(Button1);
            Panel2.Location = new Point(350, 44);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(103, 30);
            Panel2.TabIndex = 4;
            // 
            // Timer2
            // 
            // 
            // Empresas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(456, 658);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(FlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Empresas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresas";
            TransparencyKey = Color.Fuchsia;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            Load += new EventHandler(Empresas_Load);
            KeyDown += new KeyEventHandler(Empresas_KeyDownAsync);
            KeyUp += new KeyEventHandler(Empresas_KeyUp);
            ResumeLayout(false);

        }

        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Button Button1;
        internal Timer Timer1;
        internal Panel Panel2;
        internal Timer Timer2;
    }
}