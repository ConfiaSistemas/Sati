using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ActInformacionLegal : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ActInformacionLegal));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            ComboTipo = new Bunifu.Framework.UI.BunifuDropdown();
            ComboTipo.onItemSelected += new EventHandler(ComboTipo_onItemSelected);
            txtCalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            txtNoExt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            txtNoInt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label2 = new Label();
            txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label3 = new Label();
            PanelDomicilio = new Panel();
            txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label5 = new Label();
            PanelValor = new Panel();
            Label7 = new Label();
            txtValor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtMotivo = new RichTextBox();
            Label6 = new Label();
            Label8 = new Label();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BackgroundConsultaInformacion = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultaInformacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultaInformacion_DoWork);
            BackgroundConsultaInformacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultaInformacion_RunWorkerCompleted);
            BackgroundActualizacion = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizacion_DoWork);
            BackgroundActualizacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizacion_RunWorkerCompleted);
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
            ComboTipo.Items = new string[] { "Domicilio", "Número de Expediente", "Juzgado", "Etapa Procesal", "Actuario" };
            ComboTipo.Location = new Point(41, 66);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.NomalColor = Color.FromArgb(0, 5, 11);
            ComboTipo.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboTipo.selectedIndex = 0;
            ComboTipo.Size = new Size(203, 35);
            ComboTipo.TabIndex = 33;
            // 
            // txtCalle
            // 
            txtCalle.Cursor = Cursors.IBeam;
            txtCalle.Font = new Font("Century Gothic", 9.75f);
            txtCalle.ForeColor = Color.FromArgb(223, 223, 223);
            txtCalle.HintForeColor = Color.White;
            txtCalle.HintText = "";
            txtCalle.isPassword = false;
            txtCalle.LineFocusedColor = Color.Blue;
            txtCalle.LineIdleColor = Color.Gray;
            txtCalle.LineMouseHoverColor = Color.Blue;
            txtCalle.LineThickness = 3;
            txtCalle.Location = new Point(27, 37);
            txtCalle.Margin = new Padding(4);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(379, 33);
            txtCalle.TabIndex = 35;
            txtCalle.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(24, 20);
            Label4.Name = "Label4";
            Label4.Size = new Size(30, 13);
            Label4.TabIndex = 34;
            Label4.Text = "Calle";
            // 
            // txtNoExt
            // 
            txtNoExt.Cursor = Cursors.IBeam;
            txtNoExt.Font = new Font("Century Gothic", 9.75f);
            txtNoExt.ForeColor = Color.FromArgb(223, 223, 223);
            txtNoExt.HintForeColor = Color.White;
            txtNoExt.HintText = "";
            txtNoExt.isPassword = false;
            txtNoExt.LineFocusedColor = Color.Blue;
            txtNoExt.LineIdleColor = Color.Gray;
            txtNoExt.LineMouseHoverColor = Color.Blue;
            txtNoExt.LineThickness = 3;
            txtNoExt.Location = new Point(27, 110);
            txtNoExt.Margin = new Padding(4);
            txtNoExt.Name = "txtNoExt";
            txtNoExt.Size = new Size(379, 33);
            txtNoExt.TabIndex = 37;
            txtNoExt.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(24, 93);
            Label1.Name = "Label1";
            Label1.Size = new Size(82, 13);
            Label1.TabIndex = 36;
            Label1.Text = "Número Exterior";
            // 
            // txtNoInt
            // 
            txtNoInt.Cursor = Cursors.IBeam;
            txtNoInt.Font = new Font("Century Gothic", 9.75f);
            txtNoInt.ForeColor = Color.FromArgb(223, 223, 223);
            txtNoInt.HintForeColor = Color.White;
            txtNoInt.HintText = "";
            txtNoInt.isPassword = false;
            txtNoInt.LineFocusedColor = Color.Blue;
            txtNoInt.LineIdleColor = Color.Gray;
            txtNoInt.LineMouseHoverColor = Color.Blue;
            txtNoInt.LineThickness = 3;
            txtNoInt.Location = new Point(27, 181);
            txtNoInt.Margin = new Padding(4);
            txtNoInt.Name = "txtNoInt";
            txtNoInt.Size = new Size(379, 33);
            txtNoInt.TabIndex = 39;
            txtNoInt.TextAlign = HorizontalAlignment.Left;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(24, 164);
            Label2.Name = "Label2";
            Label2.Size = new Size(79, 13);
            Label2.TabIndex = 38;
            Label2.Text = "Número Interior";
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
            txtCodigoPostal.Location = new Point(27, 249);
            txtCodigoPostal.Margin = new Padding(4);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(379, 33);
            txtCodigoPostal.TabIndex = 41;
            txtCodigoPostal.TextAlign = HorizontalAlignment.Left;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(24, 232);
            Label3.Name = "Label3";
            Label3.Size = new Size(72, 13);
            Label3.TabIndex = 40;
            Label3.Text = "Código Postal";
            // 
            // PanelDomicilio
            // 
            PanelDomicilio.Controls.Add(txtColonia);
            PanelDomicilio.Controls.Add(txtCodigoPostal);
            PanelDomicilio.Controls.Add(Label5);
            PanelDomicilio.Controls.Add(Label4);
            PanelDomicilio.Controls.Add(txtCalle);
            PanelDomicilio.Controls.Add(Label1);
            PanelDomicilio.Controls.Add(Label3);
            PanelDomicilio.Controls.Add(txtNoExt);
            PanelDomicilio.Controls.Add(txtNoInt);
            PanelDomicilio.Controls.Add(Label2);
            PanelDomicilio.Location = new Point(41, 124);
            PanelDomicilio.Name = "PanelDomicilio";
            PanelDomicilio.Size = new Size(431, 412);
            PanelDomicilio.TabIndex = 42;
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
            txtColonia.Location = new Point(27, 320);
            txtColonia.Margin = new Padding(4);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(379, 33);
            txtColonia.TabIndex = 44;
            txtColonia.TextAlign = HorizontalAlignment.Left;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(24, 303);
            Label5.Name = "Label5";
            Label5.Size = new Size(42, 13);
            Label5.TabIndex = 43;
            Label5.Text = "Colonia";
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
            // BackgroundConsultaInformacion
            // 
            // 
            // BackgroundActualizacion
            // 
            // 
            // ActInformacionLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1010, 558);
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
            Name = "ActInformacionLegal";
            Text = "ActInformacionLegal";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            PanelDomicilio.ResumeLayout(false);
            PanelDomicilio.PerformLayout();
            PanelValor.ResumeLayout(false);
            PanelValor.PerformLayout();
            Load += new EventHandler(ActInformacionLegal_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuDropdown ComboTipo;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalle;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExt;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoInt;
        internal Label Label2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        internal Label Label3;
        internal Panel PanelDomicilio;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColonia;
        internal Label Label5;
        internal Panel PanelValor;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtValor;
        internal RichTextBox txtMotivo;
        internal Label Label6;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultaInformacion;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizacion;
    }
}