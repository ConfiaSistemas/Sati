using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Renovacion : Form
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
            RadPageView1 = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)RadPageView1).BeginInit();
            SuspendLayout();
            // 
            // RadPageView1
            // 
            RadPageView1.Location = new Point(12, 25);
            RadPageView1.Name = "RadPageView1";
            RadPageView1.Size = new Size(957, 411);
            RadPageView1.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView1.GetChildAt(0)).ShowItemCloseButton = false;
            // 
            // Renovacion
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 549);
            Controls.Add(RadPageView1);
            Name = "Renovacion";
            Text = "Renovacion";
            ((System.ComponentModel.ISupportInitialize)RadPageView1).EndInit();
            ResumeLayout(false);

        }

        internal Telerik.WinControls.UI.RadPageView RadPageView1;
    }
}