using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class inicio : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            Panelsecundario = new Panel();
            BunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            BunifuFlatButton7.Click += new EventHandler(BunifuFlatButton7_Click);
            Panelsecundario.SuspendLayout();
            SuspendLayout();
            // 
            // Panelsecundario
            // 
            Panelsecundario.BackColor = Color.Transparent;
            Panelsecundario.Controls.Add(BunifuFlatButton7);
            Panelsecundario.Location = new Point(12, 12);
            Panelsecundario.Name = "Panelsecundario";
            Panelsecundario.Size = new Size(200, 100);
            Panelsecundario.TabIndex = 4;
            // 
            // BunifuFlatButton7
            // 
            BunifuFlatButton7.Activecolor = Color.FromArgb(46, 139, 87);
            BunifuFlatButton7.BackgroundImageLayout = ImageLayout.Stretch;
            BunifuFlatButton7.BorderRadius = 0;
            BunifuFlatButton7.ButtonText = "Grupos";
            BunifuFlatButton7.Cursor = Cursors.Hand;
            BunifuFlatButton7.DisabledColor = Color.Gray;
            BunifuFlatButton7.Iconcolor = Color.Transparent;
            BunifuFlatButton7.Iconimage = My.Resources.Resources.usuarios;
            BunifuFlatButton7.Iconimage_right = null;
            BunifuFlatButton7.Iconimage_right_Selected = null;
            BunifuFlatButton7.Iconimage_Selected = null;
            BunifuFlatButton7.IconMarginLeft = 0;
            BunifuFlatButton7.IconMarginRight = 0;
            BunifuFlatButton7.IconRightVisible = true;
            BunifuFlatButton7.IconRightZoom = 0d;
            BunifuFlatButton7.IconVisible = true;
            BunifuFlatButton7.IconZoom = 90.0d;
            BunifuFlatButton7.IsTab = false;
            BunifuFlatButton7.Location = new Point(3, 3);
            BunifuFlatButton7.Name = "BunifuFlatButton7";
            BunifuFlatButton7.Normalcolor = Color.Empty;
            BunifuFlatButton7.OnHovercolor = Color.Gray;
            BunifuFlatButton7.OnHoverTextColor = Color.White;
            BunifuFlatButton7.selected = false;
            BunifuFlatButton7.Size = new Size(111, 48);
            BunifuFlatButton7.TabIndex = 6;
            BunifuFlatButton7.Text = "Grupos";
            BunifuFlatButton7.TextAlign = ContentAlignment.MiddleLeft;
            BunifuFlatButton7.Textcolor = Color.Black;
            BunifuFlatButton7.TextFont = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(96.0f, 96.0f);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = My.Resources.Resources.pantalla_de_bienvenida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(646, 446);
            Controls.Add(Panelsecundario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inicio";
            Text = "inicio";
            TransparencyKey = Color.Transparent;
            Panelsecundario.ResumeLayout(false);
            Load += new EventHandler(inicio_Load);
            ResumeLayout(false);

        }
        internal Panel Panelsecundario;
        internal Bunifu.Framework.UI.BunifuFlatButton BunifuFlatButton7;
    }
}