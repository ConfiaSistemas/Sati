using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ActInformacionCredito : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ActInformacionCredito));
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
            Label9 = new Label();
            ComboCliente = new Bunifu.Framework.UI.BunifuDropdown();
            PanelR = new Panel();
            ComboColoniaR = new Bunifu.Framework.UI.BunifuDropdown();
            Label17 = new Label();
            txtNombreR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtTelefonoR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label16 = new Label();
            txtRelacionR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label15 = new Label();
            txtCPR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtCPR.OnValueChanged += new EventHandler(txtCPR_OnValueChanged);
            Label10 = new Label();
            Label11 = new Label();
            txtCalleR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label12 = new Label();
            Label13 = new Label();
            txtNoExtR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtNoIntR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label14 = new Label();
            Panel1.SuspendLayout();
            PanelDomicilio.SuspendLayout();
            PanelValor.SuspendLayout();
            PanelR.SuspendLayout();
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
            MonoFlat_HeaderLabel1.Size = new Size(245, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Actualizar Información de Crédito";
            // 
            // ComboTipo
            // 
            ComboTipo.BackColor = Color.Transparent;
            ComboTipo.BorderRadius = 10;
            ComboTipo.DisabledColor = Color.Gray;
            ComboTipo.ForeColor = Color.White;
            ComboTipo.Items = new string[] { "Domicilio", "Número de Teléfono", "Número de Celular", "Domicilio de Trabajo", "Teléfono de Trabajo", "Referencia 1", "Referencia 2" };
            ComboTipo.Location = new Point(41, 66);
            ComboTipo.Name = "ComboTipo";
            ComboTipo.NomalColor = Color.FromArgb(0, 5, 11);
            ComboTipo.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboTipo.selectedIndex = -1;
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
            // PanelR
            // 
            PanelR.Controls.Add(ComboColoniaR);
            PanelR.Controls.Add(Label17);
            PanelR.Controls.Add(txtNombreR);
            PanelR.Controls.Add(txtTelefonoR);
            PanelR.Controls.Add(Label16);
            PanelR.Controls.Add(txtRelacionR);
            PanelR.Controls.Add(Label15);
            PanelR.Controls.Add(txtCPR);
            PanelR.Controls.Add(Label10);
            PanelR.Controls.Add(Label11);
            PanelR.Controls.Add(txtCalleR);
            PanelR.Controls.Add(Label12);
            PanelR.Controls.Add(Label13);
            PanelR.Controls.Add(txtNoExtR);
            PanelR.Controls.Add(txtNoIntR);
            PanelR.Controls.Add(Label14);
            PanelR.Location = new Point(70, 107);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(431, 559);
            PanelR.TabIndex = 45;
            PanelR.Visible = false;
            // 
            // ComboColoniaR
            // 
            ComboColoniaR.BackColor = Color.Transparent;
            ComboColoniaR.BorderRadius = 10;
            ComboColoniaR.DisabledColor = Color.Gray;
            ComboColoniaR.ForeColor = Color.White;
            ComboColoniaR.Items = new string[0];
            ComboColoniaR.Location = new Point(27, 380);
            ComboColoniaR.Name = "ComboColoniaR";
            ComboColoniaR.NomalColor = Color.FromArgb(0, 5, 11);
            ComboColoniaR.onHoverColor = Color.FromArgb(0, 5, 11);
            ComboColoniaR.selectedIndex = -1;
            ComboColoniaR.Size = new Size(384, 35);
            ComboColoniaR.TabIndex = 50;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(24, 6);
            Label17.Name = "Label17";
            Label17.Size = new Size(44, 13);
            Label17.TabIndex = 49;
            Label17.Text = "Nombre";
            // 
            // txtNombreR
            // 
            txtNombreR.Cursor = Cursors.IBeam;
            txtNombreR.Font = new Font("Century Gothic", 9.75f);
            txtNombreR.ForeColor = Color.FromArgb(223, 223, 223);
            txtNombreR.HintForeColor = Color.White;
            txtNombreR.HintText = "";
            txtNombreR.isPassword = false;
            txtNombreR.LineFocusedColor = Color.Blue;
            txtNombreR.LineIdleColor = Color.Gray;
            txtNombreR.LineMouseHoverColor = Color.Blue;
            txtNombreR.LineThickness = 3;
            txtNombreR.Location = new Point(27, 23);
            txtNombreR.Margin = new Padding(4);
            txtNombreR.Name = "txtNombreR";
            txtNombreR.Size = new Size(379, 33);
            txtNombreR.TabIndex = 50;
            txtNombreR.TextAlign = HorizontalAlignment.Left;
            // 
            // txtTelefonoR
            // 
            txtTelefonoR.Cursor = Cursors.IBeam;
            txtTelefonoR.Font = new Font("Century Gothic", 9.75f);
            txtTelefonoR.ForeColor = Color.FromArgb(223, 223, 223);
            txtTelefonoR.HintForeColor = Color.White;
            txtTelefonoR.HintText = "";
            txtTelefonoR.isPassword = false;
            txtTelefonoR.LineFocusedColor = Color.Blue;
            txtTelefonoR.LineIdleColor = Color.Gray;
            txtTelefonoR.LineMouseHoverColor = Color.Blue;
            txtTelefonoR.LineThickness = 3;
            txtTelefonoR.Location = new Point(30, 513);
            txtTelefonoR.Margin = new Padding(4);
            txtTelefonoR.Name = "txtTelefonoR";
            txtTelefonoR.Size = new Size(379, 33);
            txtTelefonoR.TabIndex = 48;
            txtTelefonoR.TextAlign = HorizontalAlignment.Left;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.ForeColor = Color.White;
            Label16.Location = new Point(27, 496);
            Label16.Name = "Label16";
            Label16.Size = new Size(49, 13);
            Label16.TabIndex = 47;
            Label16.Text = "Teléfono";
            // 
            // txtRelacionR
            // 
            txtRelacionR.Cursor = Cursors.IBeam;
            txtRelacionR.Font = new Font("Century Gothic", 9.75f);
            txtRelacionR.ForeColor = Color.FromArgb(223, 223, 223);
            txtRelacionR.HintForeColor = Color.White;
            txtRelacionR.HintText = "";
            txtRelacionR.isPassword = false;
            txtRelacionR.LineFocusedColor = Color.Blue;
            txtRelacionR.LineIdleColor = Color.Gray;
            txtRelacionR.LineMouseHoverColor = Color.Blue;
            txtRelacionR.LineThickness = 3;
            txtRelacionR.Location = new Point(30, 450);
            txtRelacionR.Margin = new Padding(4);
            txtRelacionR.Name = "txtRelacionR";
            txtRelacionR.Size = new Size(379, 33);
            txtRelacionR.TabIndex = 46;
            txtRelacionR.TextAlign = HorizontalAlignment.Left;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.ForeColor = Color.White;
            Label15.Location = new Point(27, 433);
            Label15.Name = "Label15";
            Label15.Size = new Size(49, 13);
            Label15.TabIndex = 45;
            Label15.Text = "Relación";
            // 
            // txtCPR
            // 
            txtCPR.Cursor = Cursors.IBeam;
            txtCPR.Font = new Font("Century Gothic", 9.75f);
            txtCPR.ForeColor = Color.FromArgb(223, 223, 223);
            txtCPR.HintForeColor = Color.White;
            txtCPR.HintText = "";
            txtCPR.isPassword = false;
            txtCPR.LineFocusedColor = Color.Blue;
            txtCPR.LineIdleColor = Color.Gray;
            txtCPR.LineMouseHoverColor = Color.Blue;
            txtCPR.LineThickness = 3;
            txtCPR.Location = new Point(27, 304);
            txtCPR.Margin = new Padding(4);
            txtCPR.Name = "txtCPR";
            txtCPR.Size = new Size(379, 33);
            txtCPR.TabIndex = 41;
            txtCPR.TextAlign = HorizontalAlignment.Left;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.ForeColor = Color.White;
            Label10.Location = new Point(24, 358);
            Label10.Name = "Label10";
            Label10.Size = new Size(42, 13);
            Label10.TabIndex = 43;
            Label10.Text = "Colonia";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(24, 75);
            Label11.Name = "Label11";
            Label11.Size = new Size(30, 13);
            Label11.TabIndex = 34;
            Label11.Text = "Calle";
            // 
            // txtCalleR
            // 
            txtCalleR.Cursor = Cursors.IBeam;
            txtCalleR.Font = new Font("Century Gothic", 9.75f);
            txtCalleR.ForeColor = Color.FromArgb(223, 223, 223);
            txtCalleR.HintForeColor = Color.White;
            txtCalleR.HintText = "";
            txtCalleR.isPassword = false;
            txtCalleR.LineFocusedColor = Color.Blue;
            txtCalleR.LineIdleColor = Color.Gray;
            txtCalleR.LineMouseHoverColor = Color.Blue;
            txtCalleR.LineThickness = 3;
            txtCalleR.Location = new Point(27, 92);
            txtCalleR.Margin = new Padding(4);
            txtCalleR.Name = "txtCalleR";
            txtCalleR.Size = new Size(379, 33);
            txtCalleR.TabIndex = 35;
            txtCalleR.TextAlign = HorizontalAlignment.Left;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.ForeColor = Color.White;
            Label12.Location = new Point(24, 148);
            Label12.Name = "Label12";
            Label12.Size = new Size(82, 13);
            Label12.TabIndex = 36;
            Label12.Text = "Número Exterior";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = Color.White;
            Label13.Location = new Point(24, 287);
            Label13.Name = "Label13";
            Label13.Size = new Size(72, 13);
            Label13.TabIndex = 40;
            Label13.Text = "Código Postal";
            // 
            // txtNoExtR
            // 
            txtNoExtR.Cursor = Cursors.IBeam;
            txtNoExtR.Font = new Font("Century Gothic", 9.75f);
            txtNoExtR.ForeColor = Color.FromArgb(223, 223, 223);
            txtNoExtR.HintForeColor = Color.White;
            txtNoExtR.HintText = "";
            txtNoExtR.isPassword = false;
            txtNoExtR.LineFocusedColor = Color.Blue;
            txtNoExtR.LineIdleColor = Color.Gray;
            txtNoExtR.LineMouseHoverColor = Color.Blue;
            txtNoExtR.LineThickness = 3;
            txtNoExtR.Location = new Point(27, 165);
            txtNoExtR.Margin = new Padding(4);
            txtNoExtR.Name = "txtNoExtR";
            txtNoExtR.Size = new Size(379, 33);
            txtNoExtR.TabIndex = 37;
            txtNoExtR.TextAlign = HorizontalAlignment.Left;
            // 
            // txtNoIntR
            // 
            txtNoIntR.Cursor = Cursors.IBeam;
            txtNoIntR.Font = new Font("Century Gothic", 9.75f);
            txtNoIntR.ForeColor = Color.FromArgb(223, 223, 223);
            txtNoIntR.HintForeColor = Color.White;
            txtNoIntR.HintText = "";
            txtNoIntR.isPassword = false;
            txtNoIntR.LineFocusedColor = Color.Blue;
            txtNoIntR.LineIdleColor = Color.Gray;
            txtNoIntR.LineMouseHoverColor = Color.Blue;
            txtNoIntR.LineThickness = 3;
            txtNoIntR.Location = new Point(27, 236);
            txtNoIntR.Margin = new Padding(4);
            txtNoIntR.Name = "txtNoIntR";
            txtNoIntR.Size = new Size(379, 33);
            txtNoIntR.TabIndex = 39;
            txtNoIntR.TextAlign = HorizontalAlignment.Left;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.ForeColor = Color.White;
            Label14.Location = new Point(24, 219);
            Label14.Name = "Label14";
            Label14.Size = new Size(79, 13);
            Label14.TabIndex = 38;
            Label14.Text = "Número Interior";
            // 
            // ActInformacionCredito
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1010, 692);
            Controls.Add(PanelR);
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
            Name = "ActInformacionCredito";
            Text = "ActInformacionLegal";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            PanelDomicilio.ResumeLayout(false);
            PanelDomicilio.PerformLayout();
            PanelValor.ResumeLayout(false);
            PanelValor.PerformLayout();
            PanelR.ResumeLayout(false);
            PanelR.PerformLayout();
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
        internal Label Label9;
        internal Bunifu.Framework.UI.BunifuDropdown ComboCliente;
        internal Panel PanelR;
        internal Label Label17;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreR;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefonoR;
        internal Label Label16;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtRelacionR;
        internal Label Label15;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCPR;
        internal Label Label10;
        internal Label Label11;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalleR;
        internal Label Label12;
        internal Label Label13;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExtR;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoIntR;
        internal Label Label14;
        internal Bunifu.Framework.UI.BunifuDropdown ComboColoniaR;
    }
}