using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarTipoDocumentoSolicitud : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTipoDocumentoSolicitud));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseWheel += new MouseEventHandler(Panel1_MouseWheel);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            ComboTipo = new Bunifu.Framework.UI.BunifuDropdown();
            Label1 = new Label();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(3, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(564, 36);
            Panel1.TabIndex = 2;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 0);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(208, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Tipo de Documento";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(495, 0);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Century Gothic", 9.75f);
            txtNombre.ForeColor = Color.FromArgb(223, 223, 223);
            txtNombre.HintForeColor = Color.White;
            txtNombre.HintText = "";
            txtNombre.isPassword = false;
            txtNombre.LineFocusedColor = Color.Blue;
            txtNombre.LineIdleColor = Color.Gray;
            txtNombre.LineMouseHoverColor = Color.Blue;
            txtNombre.LineThickness = 3;
            txtNombre.Location = new Point(88, 103);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(379, 33);
            txtNombre.TabIndex = 12;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(85, 86);
            Label4.Name = "Label4";
            Label4.Size = new Size(44, 13);
            Label4.TabIndex = 11;
            Label4.Text = "Nombre";
            // 
            // btn_Procesar
            // 
            btn_Procesar.ActiveBorderThickness = 1;
            btn_Procesar.ActiveCornerRadius = 20;
            btn_Procesar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.ActiveForecolor = Color.White;
            btn_Procesar.ActiveLineColor = Color.SeaGreen;
            btn_Procesar.BackColor = Color.FromArgb(0, 5, 11);
            btn_Procesar.BackgroundImage = (Image)resources.GetObject("btn_Procesar.BackgroundImage");
            btn_Procesar.ButtonText = "Agregar";
            btn_Procesar.Cursor = Cursors.Hand;
            btn_Procesar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Procesar.ForeColor = Color.DarkBlue;
            btn_Procesar.IdleBorderThickness = 1;
            btn_Procesar.IdleCornerRadius = 20;
            btn_Procesar.IdleFillColor = Color.White;
            btn_Procesar.IdleForecolor = Color.Gray;
            btn_Procesar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.Location = new Point(174, 246);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 31;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboTipo
            // 
            ComboTipo.BackColor = Color.Transparent;
            ComboTipo.BorderRadius = 10;
            ComboTipo.DisabledColor = Color.Gray;
            ComboTipo.ForeColor = Color.White;
            ComboTipo.Items = new string[] { "A", "V" };
            ComboTipo.Location = new Point(88, 171);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.NomalColor = Color.FromArgb(0, 5, 11);
            ComboTipo.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboTipo.selectedIndex = 0;
            ComboTipo.Size = new Size(72, 35);
            ComboTipo.TabIndex = 32;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(85, 155);
            Label1.Name = "Label1";
            Label1.Size = new Size(28, 13);
            Label1.TabIndex = 33;
            Label1.Text = "Tipo";
            // 
            // AgregarTipoDocumentoSolicitud
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(570, 324);
            Controls.Add(Label1);
            Controls.Add(ComboTipo);
            Controls.Add(btn_Procesar);
            Controls.Add(txtNombre);
            Controls.Add(Label4);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarTipoDocumentoSolicitud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarTipoDocumentoSolicitud";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Closing += new System.ComponentModel.CancelEventHandler(AgregarTipoDocumentoSolicitud_Closing);
            Load += new EventHandler(AgregarTipoDocumentoSolicitud_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal Bunifu.Framework.UI.BunifuDropdown ComboTipo;
        internal Label Label1;
    }
}