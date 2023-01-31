using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class slider : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(slider));
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            FolderBrowserDialog1 = new FolderBrowserDialog();
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(129, 194);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Button1";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Timer1
            // 
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox1.Location = new Point(90, 27);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(164, 142);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // slider
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 316);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "slider";
            Text = "slider";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(slider_Load);
            ResumeLayout(false);

        }
        internal PictureBox PictureBox1;
        internal Button Button1;
        internal Timer Timer1;
        internal FolderBrowserDialog FolderBrowserDialog1;
    }
}