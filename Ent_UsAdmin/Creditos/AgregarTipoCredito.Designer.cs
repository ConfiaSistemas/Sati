using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AgregarTipoCredito : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTipoCredito));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            ComboModalidad = new ComboBox();
            ComboModalidad.SelectedIndexChanged += new EventHandler(ComboModalidad_SelectedIndexChanged);
            ComboTipo = new ComboBox();
            ComboPlazo = new ComboBox();
            ComboPlazo.SelectedIndexChanged += new EventHandler(ComboPlazo_SelectedIndexChanged);
            txtInteres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label5 = new Label();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            lblOtroPlazo = new Label();
            txtOtroPlazo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            checkMotocicleta = new MonoFlat.MonoFlat_CheckBox();
            Label6 = new Label();
            txtEnganche = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label7 = new Label();
            txtApertura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(2, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(629, 36);
            Panel1.TabIndex = 3;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 0);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(177, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Agregar Tipo de Crédito";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(560, 3);
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
            txtNombre.Location = new Point(23, 76);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(379, 33);
            txtNombre.TabIndex = 14;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(20, 59);
            Label4.Name = "Label4";
            Label4.Size = new Size(44, 13);
            Label4.TabIndex = 13;
            Label4.Text = "Nombre";
            // 
            // ComboModalidad
            // 
            ComboModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboModalidad.FormattingEnabled = true;
            ComboModalidad.Location = new Point(20, 147);
            ComboModalidad.Name = "ComboModalidad";
            ComboModalidad.Size = new Size(121, 21);
            ComboModalidad.TabIndex = 15;
            // 
            // ComboTipo
            // 
            ComboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTipo.FormattingEnabled = true;
            ComboTipo.Location = new Point(210, 147);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.Size = new Size(121, 21);
            ComboTipo.TabIndex = 16;
            // 
            // ComboPlazo
            // 
            ComboPlazo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPlazo.FormattingEnabled = true;
            ComboPlazo.Location = new Point(20, 204);
            ComboPlazo.Name = "ComboPlazo";
            ComboPlazo.Size = new Size(121, 21);
            ComboPlazo.TabIndex = 17;
            // 
            // txtInteres
            // 
            txtInteres.Cursor = Cursors.IBeam;
            txtInteres.Font = new Font("Century Gothic", 9.75f);
            txtInteres.ForeColor = Color.FromArgb(223, 223, 223);
            txtInteres.HintForeColor = Color.White;
            txtInteres.HintText = "";
            txtInteres.isPassword = false;
            txtInteres.LineFocusedColor = Color.Blue;
            txtInteres.LineIdleColor = Color.Gray;
            txtInteres.LineMouseHoverColor = Color.Blue;
            txtInteres.LineThickness = 3;
            txtInteres.Location = new Point(210, 192);
            txtInteres.Margin = new Padding(4);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(178, 33);
            txtInteres.TabIndex = 18;
            txtInteres.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(17, 118);
            Label1.Name = "Label1";
            Label1.Size = new Size(56, 13);
            Label1.TabIndex = 19;
            Label1.Text = "Modalidad";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(207, 118);
            Label2.Name = "Label2";
            Label2.Size = new Size(28, 13);
            Label2.TabIndex = 20;
            Label2.Text = "Tipo";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(20, 175);
            Label3.Name = "Label3";
            Label3.Size = new Size(33, 13);
            Label3.TabIndex = 21;
            Label3.Text = "Plazo";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(207, 175);
            Label5.Name = "Label5";
            Label5.Size = new Size(39, 13);
            Label5.TabIndex = 22;
            Label5.Text = "Interés";
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
            btn_Procesar.Location = new Point(210, 346);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 32;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOtroPlazo
            // 
            lblOtroPlazo.AutoSize = true;
            lblOtroPlazo.ForeColor = Color.White;
            lblOtroPlazo.Location = new Point(17, 241);
            lblOtroPlazo.Name = "lblOtroPlazo";
            lblOtroPlazo.Size = new Size(56, 13);
            lblOtroPlazo.TabIndex = 34;
            lblOtroPlazo.Text = "Otro Plazo";
            lblOtroPlazo.Visible = false;
            // 
            // txtOtroPlazo
            // 
            txtOtroPlazo.Cursor = Cursors.IBeam;
            txtOtroPlazo.Font = new Font("Century Gothic", 9.75f);
            txtOtroPlazo.ForeColor = Color.FromArgb(223, 223, 223);
            txtOtroPlazo.HintForeColor = Color.White;
            txtOtroPlazo.HintText = "";
            txtOtroPlazo.isPassword = false;
            txtOtroPlazo.LineFocusedColor = Color.Blue;
            txtOtroPlazo.LineIdleColor = Color.Gray;
            txtOtroPlazo.LineMouseHoverColor = Color.Blue;
            txtOtroPlazo.LineThickness = 3;
            txtOtroPlazo.Location = new Point(20, 258);
            txtOtroPlazo.Margin = new Padding(4);
            txtOtroPlazo.Name = "txtOtroPlazo";
            txtOtroPlazo.Size = new Size(53, 33);
            txtOtroPlazo.TabIndex = 33;
            txtOtroPlazo.TextAlign = HorizontalAlignment.Left;
            txtOtroPlazo.Visible = false;
            // 
            // checkMotocicleta
            // 
            checkMotocicleta.Checked = false;
            checkMotocicleta.Font = new Font("Microsoft Sans Serif", 9.0f);
            checkMotocicleta.Location = new Point(460, 147);
            checkMotocicleta.Name = "checkMotocicleta";
            checkMotocicleta.Size = new Size(148, 16);
            checkMotocicleta.TabIndex = 35;
            checkMotocicleta.Text = "Crédito de Motocicleta";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(207, 253);
            Label6.Name = "Label6";
            Label6.Size = new Size(56, 13);
            Label6.TabIndex = 37;
            Label6.Text = "Enganche";
            // 
            // txtEnganche
            // 
            txtEnganche.Cursor = Cursors.IBeam;
            txtEnganche.Font = new Font("Century Gothic", 9.75f);
            txtEnganche.ForeColor = Color.FromArgb(223, 223, 223);
            txtEnganche.HintForeColor = Color.White;
            txtEnganche.HintText = "";
            txtEnganche.isPassword = false;
            txtEnganche.LineFocusedColor = Color.Blue;
            txtEnganche.LineIdleColor = Color.Gray;
            txtEnganche.LineMouseHoverColor = Color.Blue;
            txtEnganche.LineThickness = 3;
            txtEnganche.Location = new Point(210, 270);
            txtEnganche.Margin = new Padding(4);
            txtEnganche.Name = "txtEnganche";
            txtEnganche.Size = new Size(53, 33);
            txtEnganche.TabIndex = 36;
            txtEnganche.TextAlign = HorizontalAlignment.Left;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(299, 253);
            Label7.Name = "Label7";
            Label7.Size = new Size(47, 13);
            Label7.TabIndex = 39;
            Label7.Text = "Apertura";
            // 
            // txtApertura
            // 
            txtApertura.Cursor = Cursors.IBeam;
            txtApertura.Font = new Font("Century Gothic", 9.75f);
            txtApertura.ForeColor = Color.FromArgb(223, 223, 223);
            txtApertura.HintForeColor = Color.White;
            txtApertura.HintText = "";
            txtApertura.isPassword = false;
            txtApertura.LineFocusedColor = Color.Blue;
            txtApertura.LineIdleColor = Color.Gray;
            txtApertura.LineMouseHoverColor = Color.Blue;
            txtApertura.LineThickness = 3;
            txtApertura.Location = new Point(302, 270);
            txtApertura.Margin = new Padding(4);
            txtApertura.Name = "txtApertura";
            txtApertura.Size = new Size(53, 33);
            txtApertura.TabIndex = 38;
            txtApertura.TextAlign = HorizontalAlignment.Left;
            // 
            // AgregarTipoCredito
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(632, 442);
            Controls.Add(Label7);
            Controls.Add(txtApertura);
            Controls.Add(Label6);
            Controls.Add(txtEnganche);
            Controls.Add(checkMotocicleta);
            Controls.Add(lblOtroPlazo);
            Controls.Add(txtOtroPlazo);
            Controls.Add(btn_Procesar);
            Controls.Add(Label5);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(txtInteres);
            Controls.Add(ComboPlazo);
            Controls.Add(ComboTipo);
            Controls.Add(ComboModalidad);
            Controls.Add(txtNombre);
            Controls.Add(Label4);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgregarTipoCredito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarTipoCredito";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(AgregarTipoCredito_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        internal Label Label4;
        internal ComboBox ComboModalidad;
        internal ComboBox ComboTipo;
        internal ComboBox ComboPlazo;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtInteres;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label5;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal Label lblOtroPlazo;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtOtroPlazo;
        internal MonoFlat.MonoFlat_CheckBox checkMotocicleta;
        internal Label Label6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEnganche;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApertura;
    }
}