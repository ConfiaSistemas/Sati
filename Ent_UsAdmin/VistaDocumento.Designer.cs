using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VistaDocumento : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaDocumento));
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox1.KeyDown += new KeyEventHandler(PictureBox1_KeyDown);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            GuardarToolStripMenuItem = new ToolStripMenuItem();
            GuardarToolStripMenuItem.Click += new EventHandler(GuardarToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            PictureBox1.ContextMenuStrip = ContextMenuStrip1;
            PictureBox1.Location = new Point(0, -1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(814, 392);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { GuardarToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(117, 26);
            // 
            // GuardarToolStripMenuItem
            // 
            GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            GuardarToolStripMenuItem.Size = new Size(116, 22);
            GuardarToolStripMenuItem.Text = "Guardar";
            // 
            // VistaDocumento
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 387);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VistaDocumento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaDocumento";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ContextMenuStrip1.ResumeLayout(false);
            ClientSizeChanged += new EventHandler(VistaDocumento_ClientSizeChanged);
            KeyDown += new KeyEventHandler(VistaDocumento_KeyDown);
            Load += new EventHandler(VistaDocumento_Load);
            ResumeLayout(false);

        }

        internal PictureBox PictureBox1;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem GuardarToolStripMenuItem;
    }
}