using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ActInformacionEmpeño : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ActInformacionEmpeño));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            ComboTipo = new Bunifu.Framework.UI.BunifuDropdown();
            ComboTipo.onItemSelected += new EventHandler(ComboTipo_onItemSelected);
            txtDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            lblDomicilio = new Label();
            txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            lblCodigoPostal = new Label();
            txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            lblColonia = new Label();
            txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            lblMunicipio = new Label();
            PanelDomicilio = new Panel();
            txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            lblEntidad = new Label();
            PanelValor = new Panel();
            Label7 = new Label();
            txtValor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtMotivo = new RichTextBox();
            Label6 = new Label();
            Label8 = new Label();
            BackgroundConsultaInformacion = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultaInformacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultaInformacion_DoWork);
            BackgroundConsultaInformacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultaInformacion_RunWorkerCompleted);
            BackgroundActualizacion = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizacion_DoWork);
            BackgroundActualizacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizacion_RunWorkerCompleted);
            Label9 = new Label();
            ComboCliente = new Bunifu.Framework.UI.BunifuDropdown();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            Panel1.SuspendLayout();
            PanelDomicilio.SuspendLayout();
            PanelValor.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(0, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1010, 36);
            Panel1.TabIndex = 5;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(941, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 31;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(286, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Actualizar Información de Crédito Legal";
            // 
            // ComboTipo
            // 
            ComboTipo.BackColor = Color.Transparent;
            ComboTipo.BorderRadius = 10;
            ComboTipo.DisabledColor = Color.Gray;
            ComboTipo.ForeColor = Color.White;
            ComboTipo.Items = new string[] { "Nombre", "Domicilio", "Número de Teléfono", "CURP", "INE" };
            ComboTipo.Location = new Point(41, 66);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.NomalColor = Color.FromArgb(0, 5, 11);
            ComboTipo.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboTipo.selectedIndex = -1;
            ComboTipo.Size = new Size(203, 35);
            ComboTipo.TabIndex = 33;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Cursor = Cursors.IBeam;
            txtDomicilio.Font = new Font("Century Gothic", 9.75f);
            txtDomicilio.ForeColor = Color.FromArgb(223, 223, 223);
            txtDomicilio.HintForeColor = Color.White;
            txtDomicilio.HintText = "";
            txtDomicilio.isPassword = false;
            txtDomicilio.LineFocusedColor = Color.Blue;
            txtDomicilio.LineIdleColor = Color.Gray;
            txtDomicilio.LineMouseHoverColor = Color.Blue;
            txtDomicilio.LineThickness = 3;
            txtDomicilio.Location = new Point(27, 37);
            txtDomicilio.Margin = new Padding(4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(379, 33);
            txtDomicilio.TabIndex = 35;
            txtDomicilio.TextAlign = HorizontalAlignment.Left;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.ForeColor = Color.White;
            lblDomicilio.Location = new Point(24, 20);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(112, 13);
            lblDomicilio.TabIndex = 34;
            lblDomicilio.Text = "Calle, No Ext., No. Int.";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Cursor = Cursors.IBeam;
            txtCodigoPostal.Font = new Font("Century Gothic", 9.75f);
            txtCodigoPostal.ForeColor = Color.FromArgb(223, 223, 223);
            txtCodigoPostal.HintForeColor = Color.White;
            txtCodigoPostal.HintText = "";
            txtCodigoPostal.isPassword = false;
            txtCodigoPostal.LineFocusedColor = Color.Blue;
            txtCodigoPostal.LineIdleColor = Color.Gray;
            txtCodigoPostal.LineMouseHoverColor = Color.Blue;
            txtCodigoPostal.LineThickness = 3;
            txtCodigoPostal.Location = new Point(27, 110);
            txtCodigoPostal.Margin = new Padding(4);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(379, 33);
            txtCodigoPostal.TabIndex = 37;
            txtCodigoPostal.TextAlign = HorizontalAlignment.Left;
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.ForeColor = Color.White;
            lblCodigoPostal.Location = new Point(24, 93);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(72, 13);
            lblCodigoPostal.TabIndex = 36;
            lblCodigoPostal.Text = "Código Postal";
            // 
            // txtColonia
            // 
            txtColonia.Cursor = Cursors.IBeam;
            txtColonia.Font = new Font("Century Gothic", 9.75f);
            txtColonia.ForeColor = Color.FromArgb(223, 223, 223);
            txtColonia.HintForeColor = Color.White;
            txtColonia.HintText = "";
            txtColonia.isPassword = false;
            txtColonia.LineFocusedColor = Color.Blue;
            txtColonia.LineIdleColor = Color.Gray;
            txtColonia.LineMouseHoverColor = Color.Blue;
            txtColonia.LineThickness = 3;
            txtColonia.Location = new Point(27, 181);
            txtColonia.Margin = new Padding(4);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(379, 33);
            txtColonia.TabIndex = 39;
            txtColonia.TextAlign = HorizontalAlignment.Left;
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.ForeColor = Color.White;
            lblColonia.Location = new Point(24, 164);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(42, 13);
            lblColonia.TabIndex = 38;
            lblColonia.Text = "Colonia";
            // 
            // txtCiudad
            // 
            txtCiudad.Cursor = Cursors.IBeam;
            txtCiudad.Font = new Font("Century Gothic", 9.75f);
            txtCiudad.ForeColor = Color.FromArgb(223, 223, 223);
            txtCiudad.HintForeColor = Color.White;
            txtCiudad.HintText = "";
            txtCiudad.isPassword = false;
            txtCiudad.LineFocusedColor = Color.Blue;
            txtCiudad.LineIdleColor = Color.Gray;
            txtCiudad.LineMouseHoverColor = Color.Blue;
            txtCiudad.LineThickness = 3;
            txtCiudad.Location = new Point(27, 249);
            txtCiudad.Margin = new Padding(4);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(379, 33);
            txtCiudad.TabIndex = 41;
            txtCiudad.TextAlign = HorizontalAlignment.Left;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.ForeColor = Color.White;
            lblMunicipio.Location = new Point(24, 232);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(40, 13);
            lblMunicipio.TabIndex = 40;
            lblMunicipio.Text = "Ciudad";
            // 
            // PanelDomicilio
            // 
            PanelDomicilio.Controls.Add(txtEstado);
            PanelDomicilio.Controls.Add(txtCiudad);
            PanelDomicilio.Controls.Add(lblEntidad);
            PanelDomicilio.Controls.Add(lblDomicilio);
            PanelDomicilio.Controls.Add(txtDomicilio);
            PanelDomicilio.Controls.Add(lblCodigoPostal);
            PanelDomicilio.Controls.Add(lblMunicipio);
            PanelDomicilio.Controls.Add(txtCodigoPostal);
            PanelDomicilio.Controls.Add(txtColonia);
            PanelDomicilio.Controls.Add(lblColonia);
            PanelDomicilio.Location = new Point(41, 124);
            PanelDomicilio.Name = "PanelDomicilio";
            PanelDomicilio.Size = new Size(431, 412);
            PanelDomicilio.TabIndex = 42;
            // 
            // txtEstado
            // 
            txtEstado.Cursor = Cursors.IBeam;
            txtEstado.Font = new Font("Century Gothic", 9.75f);
            txtEstado.ForeColor = Color.FromArgb(223, 223, 223);
            txtEstado.HintForeColor = Color.White;
            txtEstado.HintText = "";
            txtEstado.isPassword = false;
            txtEstado.LineFocusedColor = Color.Blue;
            txtEstado.LineIdleColor = Color.Gray;
            txtEstado.LineMouseHoverColor = Color.Blue;
            txtEstado.LineThickness = 3;
            txtEstado.Location = new Point(27, 320);
            txtEstado.Margin = new Padding(4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(379, 33);
            txtEstado.TabIndex = 44;
            txtEstado.TextAlign = HorizontalAlignment.Left;
            // 
            // lblEntidad
            // 
            lblEntidad.AutoSize = true;
            lblEntidad.ForeColor = Color.White;
            lblEntidad.Location = new Point(24, 303);
            lblEntidad.Name = "lblEntidad";
            lblEntidad.Size = new Size(40, 13);
            lblEntidad.TabIndex = 43;
            lblEntidad.Text = "Estado";
            // 
            // PanelValor
            // 
            PanelValor.Controls.Add(Label7);
            PanelValor.Controls.Add(txtValor);
            PanelValor.Location = new Point(555, 124);
            PanelValor.Name = "PanelValor";
            PanelValor.Size = new Size(431, 106);
            PanelValor.TabIndex = 45;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(24, 20);
            Label7.Name = "Label7";
            Label7.Size = new Size(31, 13);
            Label7.TabIndex = 34;
            Label7.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Font = new Font("Century Gothic", 9.75f);
            txtValor.ForeColor = Color.FromArgb(223, 223, 223);
            txtValor.HintForeColor = Color.White;
            txtValor.HintText = "";
            txtValor.isPassword = false;
            txtValor.LineFocusedColor = Color.Blue;
            txtValor.LineIdleColor = Color.Gray;
            txtValor.LineMouseHoverColor = Color.Blue;
            txtValor.LineThickness = 3;
            txtValor.Location = new Point(27, 37);
            txtValor.Margin = new Padding(4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(379, 33);
            txtValor.TabIndex = 35;
            txtValor.TextAlign = HorizontalAlignment.Left;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(555, 288);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(431, 118);
            txtMotivo.TabIndex = 46;
            txtMotivo.Text = "";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(552, 263);
            Label6.Name = "Label6";
            Label6.Size = new Size(39, 13);
            Label6.TabIndex = 36;
            Label6.Text = "Motivo";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(38, 50);
            Label8.Name = "Label8";
            Label8.Size = new Size(98, 13);
            Label8.TabIndex = 36;
            Label8.Text = "Campo a Actualizar";
            // 
            // BackgroundConsultaInformacion
            // 
            // 
            // BackgroundActualizacion
            // 
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.ForeColor = Color.White;
            Label9.Location = new Point(552, 50);
            Label9.Name = "Label9";
            Label9.Size = new Size(39, 13);
            Label9.TabIndex = 49;
            Label9.Text = "Cliente";
            // 
            // ComboCliente
            // 
            ComboCliente.BackColor = Color.Transparent;
            ComboCliente.BorderRadius = 10;
            ComboCliente.DisabledColor = Color.Gray;
            ComboCliente.ForeColor = Color.White;
            ComboCliente.Items = new string[0];
            ComboCliente.Location = new Point(555, 66);
            ComboCliente.Name = "ComboCliente";
            ComboCliente.NomalColor = Color.FromArgb(0, 5, 11);
            ComboCliente.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboCliente.selectedIndex = -1;
            ComboCliente.Size = new Size(203, 35);
            ComboCliente.TabIndex = 48;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Actualizar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(509, 513);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 47;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ActInformacionEmpeño
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1010, 558);
            Controls.Add(Label9);
            Controls.Add(ComboCliente);
            Controls.Add(BunifuThinButton21);
            Controls.Add(Label8);
            Controls.Add(Label6);
            Controls.Add(txtMotivo);
            Controls.Add(PanelValor);
            Controls.Add(PanelDomicilio);
            Controls.Add(ComboTipo);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ActInformacionEmpeño";
            Text = "ActInformacionLegal";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            PanelDomicilio.ResumeLayout(false);
            PanelDomicilio.PerformLayout();
            PanelValor.ResumeLayout(false);
            PanelValor.PerformLayout();
            Load += new EventHandler(ActInformacionEmpeño_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuDropdown ComboTipo;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtDomicilio;
        internal Label lblDomicilio;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        internal Label lblCodigoPostal;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColonia;
        internal Label lblColonia;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        internal Label lblMunicipio;
        internal Panel PanelDomicilio;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        internal Label lblEntidad;
        internal Panel PanelValor;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtValor;
        internal RichTextBox txtMotivo;
        internal Label Label6;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultaInformacion;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizacion;
        internal Label Label9;
        internal Bunifu.Framework.UI.BunifuDropdown ComboCliente;
    }
}