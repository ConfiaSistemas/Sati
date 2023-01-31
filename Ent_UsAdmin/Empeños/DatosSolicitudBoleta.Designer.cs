using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DatosSolicitudBoleta : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosSolicitudBoleta));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            btn_a_autorizacion = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_a_autorizacion.Click += new EventHandler(btn_a_verificacion_Click);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            txtIne = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtIne.OnValueChanged += new EventHandler(txtIne_OnValueChanged);
            Label3 = new Label();
            ComboColonia = new ComboBox();
            txtCurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtCurp.OnValueChanged += new EventHandler(txtCurp_OnValueChanged);
            Label16 = new Label();
            txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label15 = new Label();
            txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label14 = new Label();
            Label13 = new Label();
            txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtCodigoPostal.KeyPress += new KeyPressEventHandler(txtCodigoPostal_KeyPress);
            txtCodigoPostal.KeyDown += new KeyEventHandler(txtCodigoPostal_KeyDown);
            txtCodigoPostal.OnValueChanged += new EventHandler(txtCodigoPostal_OnValueChanged);
            Label10 = new Label();
            txtDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label7 = new Label();
            txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtCelular.OnValueChanged += new EventHandler(txtCelular_OnValueChanged);
            Label5 = new Label();
            txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label2 = new Label();
            txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label11 = new Label();
            TabPage5 = new TabPage();
            TabControl2 = new TabControl();
            TabPage6 = new TabPage();
            dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatosDocumentos.CellContentDoubleClick += new DataGridViewCellEventHandler(dtdatosDocumentos_CellContentDoubleClick);
            TabPage7 = new TabPage();
            dtdatosDocumentosNuevos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatosDocumentosNuevos.KeyDown += new KeyEventHandler(dtdatosDocumentosNuevos_KeyDown);
            idTipoDocumento = new DataGridViewTextBoxColumn();
            NombreDocumento = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Label39 = new Label();
            FlowLayoutPanel1 = new FlowLayoutPanel();
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            Label21 = new Label();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            BackgroundAct = new System.ComponentModel.BackgroundWorker();
            BackgroundAct.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundAct_DoWork);
            BackgroundAct.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundAct_RunWorkerCompleted);
            BackgroundDocumentosSolicitud = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentosSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentosSolicitud_DoWork);
            BackgroundDocumentosSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentosSolicitud_RunWorkerCompleted);
            BackgroundVerificacion = new System.ComponentModel.BackgroundWorker();
            BackgroundVerificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundVerificacion_DoWork);
            BackgroundVerificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundVerificacion_RunWorkerCompleted);
            BackgroundDatosSolicitud = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentos_DoWork);
            BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentos_RunWorkerCompleted);
            BackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker2_DoWork);
            BackgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker2_RunWorkerCompleted);
            BackgroundCargaDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundCargaDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCargaDocumentos_DoWork);
            BackgroundCargaDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCargaDocumentos_RunWorkerCompleted);
            BackgroundVerificaDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundVerificaDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundVerificaDocumentos_DoWork);
            BackgroundVerificaDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundVerificaDocumentos_RunWorkerCompleted);
            BackgroundActivarLegal = new System.ComponentModel.BackgroundWorker();
            Panel1.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage5.SuspendLayout();
            TabControl2.SuspendLayout();
            TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).BeginInit();
            TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentosNuevos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(btn_a_autorizacion);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1158, 36);
            Panel1.TabIndex = 3;
            // 
            // btn_a_autorizacion
            // 
            btn_a_autorizacion.ActiveBorderThickness = 1;
            btn_a_autorizacion.ActiveCornerRadius = 20;
            btn_a_autorizacion.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btn_a_autorizacion.ActiveForecolor = Color.White;
            btn_a_autorizacion.ActiveLineColor = Color.SeaGreen;
            btn_a_autorizacion.BackColor = Color.FromArgb(14, 21, 38);
            btn_a_autorizacion.BackgroundImage = (Image)resources.GetObject("btn_a_autorizacion.BackgroundImage");
            btn_a_autorizacion.ButtonText = "Enviar A Autorización";
            btn_a_autorizacion.Cursor = Cursors.Hand;
            btn_a_autorizacion.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_a_autorizacion.ForeColor = Color.DarkBlue;
            btn_a_autorizacion.IdleBorderThickness = 1;
            btn_a_autorizacion.IdleCornerRadius = 20;
            btn_a_autorizacion.IdleFillColor = Color.White;
            btn_a_autorizacion.IdleForecolor = Color.Gray;
            btn_a_autorizacion.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_a_autorizacion.Location = new Point(768, -2);
            btn_a_autorizacion.Margin = new Padding(5);
            btn_a_autorizacion.Name = "btn_a_autorizacion";
            btn_a_autorizacion.Size = new Size(184, 38);
            btn_a_autorizacion.TabIndex = 152;
            btn_a_autorizacion.TextAlign = ContentAlignment.MiddleCenter;
            btn_a_autorizacion.Visible = false;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(1089, 3);
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
            MonoFlat_HeaderLabel1.Size = new Size(135, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Datos de Solicitud";
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage5);
            TabControl1.Location = new Point(12, 358);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1141, 345);
            TabControl1.TabIndex = 4;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.FromArgb(0, 5, 11);
            TabPage1.Controls.Add(txtIne);
            TabPage1.Controls.Add(Label3);
            TabPage1.Controls.Add(ComboColonia);
            TabPage1.Controls.Add(txtCurp);
            TabPage1.Controls.Add(Label16);
            TabPage1.Controls.Add(txtEstado);
            TabPage1.Controls.Add(Label15);
            TabPage1.Controls.Add(txtCiudad);
            TabPage1.Controls.Add(Label14);
            TabPage1.Controls.Add(Label13);
            TabPage1.Controls.Add(txtCodigoPostal);
            TabPage1.Controls.Add(Label10);
            TabPage1.Controls.Add(txtDomicilio);
            TabPage1.Controls.Add(Label7);
            TabPage1.Controls.Add(txtCelular);
            TabPage1.Controls.Add(Label5);
            TabPage1.Controls.Add(txtApellidoM);
            TabPage1.Controls.Add(Label2);
            TabPage1.Controls.Add(txtApellidoP);
            TabPage1.Controls.Add(Label1);
            TabPage1.Controls.Add(txtnombre);
            TabPage1.Controls.Add(Label11);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1133, 319);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Datos Personales";
            // 
            // txtIne
            // 
            txtIne.Cursor = Cursors.IBeam;
            txtIne.Font = new Font("Century Gothic", 9.75f);
            txtIne.ForeColor = Color.White;
            txtIne.HintForeColor = Color.White;
            txtIne.HintText = "";
            txtIne.isPassword = false;
            txtIne.LineFocusedColor = Color.Blue;
            txtIne.LineIdleColor = Color.Gray;
            txtIne.LineMouseHoverColor = Color.Blue;
            txtIne.LineThickness = 3;
            txtIne.Location = new Point(846, 40);
            txtIne.Margin = new Padding(4);
            txtIne.Name = "txtIne";
            txtIne.Size = new Size(237, 29);
            txtIne.TabIndex = 5;
            txtIne.TextAlign = HorizontalAlignment.Left;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(843, 23);
            Label3.Name = "Label3";
            Label3.Size = new Size(102, 13);
            Label3.TabIndex = 94;
            Label3.Text = "No de Identificación";
            // 
            // ComboColonia
            // 
            ComboColonia.BackColor = Color.FromArgb(0, 5, 11);
            ComboColonia.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboColonia.ForeColor = SystemColors.Control;
            ComboColonia.FormattingEnabled = true;
            ComboColonia.Location = new Point(592, 142);
            ComboColonia.Name = "ComboColonia";
            ComboColonia.Size = new Size(214, 21);
            ComboColonia.TabIndex = 8;
            // 
            // txtCurp
            // 
            txtCurp.Cursor = Cursors.IBeam;
            txtCurp.Font = new Font("Century Gothic", 9.75f);
            txtCurp.ForeColor = Color.White;
            txtCurp.HintForeColor = Color.White;
            txtCurp.HintText = "";
            txtCurp.isPassword = false;
            txtCurp.LineFocusedColor = Color.Blue;
            txtCurp.LineIdleColor = Color.Gray;
            txtCurp.LineMouseHoverColor = Color.Blue;
            txtCurp.LineThickness = 3;
            txtCurp.Location = new Point(33, 134);
            txtCurp.Margin = new Padding(4);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(248, 29);
            txtCurp.TabIndex = 6;
            txtCurp.TextAlign = HorizontalAlignment.Left;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.ForeColor = Color.White;
            Label16.Location = new Point(30, 117);
            Label16.Name = "Label16";
            Label16.Size = new Size(37, 13);
            Label16.TabIndex = 92;
            Label16.Text = "CURP";
            // 
            // txtEstado
            // 
            txtEstado.Cursor = Cursors.IBeam;
            txtEstado.Font = new Font("Century Gothic", 9.75f);
            txtEstado.ForeColor = Color.White;
            txtEstado.HintForeColor = Color.White;
            txtEstado.HintText = "";
            txtEstado.isPassword = false;
            txtEstado.LineFocusedColor = Color.Blue;
            txtEstado.LineIdleColor = Color.Gray;
            txtEstado.LineMouseHoverColor = Color.Blue;
            txtEstado.LineThickness = 3;
            txtEstado.Location = new Point(320, 230);
            txtEstado.Margin = new Padding(4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(237, 29);
            txtEstado.TabIndex = 11;
            txtEstado.TextAlign = HorizontalAlignment.Left;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.ForeColor = Color.White;
            Label15.Location = new Point(317, 214);
            Label15.Name = "Label15";
            Label15.Size = new Size(40, 13);
            Label15.TabIndex = 90;
            Label15.Text = "Estado";
            // 
            // txtCiudad
            // 
            txtCiudad.Cursor = Cursors.IBeam;
            txtCiudad.Font = new Font("Century Gothic", 9.75f);
            txtCiudad.ForeColor = Color.White;
            txtCiudad.HintForeColor = Color.White;
            txtCiudad.HintText = "";
            txtCiudad.isPassword = false;
            txtCiudad.LineFocusedColor = Color.Blue;
            txtCiudad.LineIdleColor = Color.Gray;
            txtCiudad.LineMouseHoverColor = Color.Blue;
            txtCiudad.LineThickness = 3;
            txtCiudad.Location = new Point(33, 230);
            txtCiudad.Margin = new Padding(4);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(248, 29);
            txtCiudad.TabIndex = 10;
            txtCiudad.TextAlign = HorizontalAlignment.Left;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.ForeColor = Color.White;
            Label14.Location = new Point(30, 214);
            Label14.Name = "Label14";
            Label14.Size = new Size(40, 13);
            Label14.TabIndex = 88;
            Label14.Text = "Ciudad";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = Color.White;
            Label13.Location = new Point(589, 117);
            Label13.Name = "Label13";
            Label13.Size = new Size(42, 13);
            Label13.TabIndex = 86;
            Label13.Text = "Colonia";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Cursor = Cursors.IBeam;
            txtCodigoPostal.Font = new Font("Century Gothic", 9.75f);
            txtCodigoPostal.ForeColor = Color.White;
            txtCodigoPostal.HintForeColor = Color.White;
            txtCodigoPostal.HintText = "";
            txtCodigoPostal.isPassword = false;
            txtCodigoPostal.LineFocusedColor = Color.Blue;
            txtCodigoPostal.LineIdleColor = Color.Gray;
            txtCodigoPostal.LineMouseHoverColor = Color.Blue;
            txtCodigoPostal.LineThickness = 3;
            txtCodigoPostal.Location = new Point(320, 134);
            txtCodigoPostal.Margin = new Padding(4);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(237, 29);
            txtCodigoPostal.TabIndex = 7;
            txtCodigoPostal.TextAlign = HorizontalAlignment.Left;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.ForeColor = Color.White;
            Label10.Location = new Point(317, 117);
            Label10.Name = "Label10";
            Label10.Size = new Size(72, 13);
            Label10.TabIndex = 82;
            Label10.Text = "Código Postal";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Cursor = Cursors.IBeam;
            txtDomicilio.Font = new Font("Century Gothic", 9.75f);
            txtDomicilio.ForeColor = Color.White;
            txtDomicilio.HintForeColor = Color.White;
            txtDomicilio.HintText = "";
            txtDomicilio.isPassword = false;
            txtDomicilio.LineFocusedColor = Color.Blue;
            txtDomicilio.LineIdleColor = Color.Gray;
            txtDomicilio.LineMouseHoverColor = Color.Blue;
            txtDomicilio.LineThickness = 3;
            txtDomicilio.Location = new Point(846, 134);
            txtDomicilio.Margin = new Padding(4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(237, 29);
            txtDomicilio.TabIndex = 9;
            txtDomicilio.TextAlign = HorizontalAlignment.Left;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(843, 117);
            Label7.Name = "Label7";
            Label7.Size = new Size(49, 13);
            Label7.TabIndex = 76;
            Label7.Text = "Domicilio";
            // 
            // txtCelular
            // 
            txtCelular.Cursor = Cursors.IBeam;
            txtCelular.Font = new Font("Century Gothic", 9.75f);
            txtCelular.ForeColor = Color.White;
            txtCelular.HintForeColor = Color.White;
            txtCelular.HintText = "";
            txtCelular.isPassword = false;
            txtCelular.LineFocusedColor = Color.Blue;
            txtCelular.LineIdleColor = Color.Gray;
            txtCelular.LineMouseHoverColor = Color.Blue;
            txtCelular.LineThickness = 3;
            txtCelular.Location = new Point(592, 230);
            txtCelular.Margin = new Padding(4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(214, 29);
            txtCelular.TabIndex = 12;
            txtCelular.TextAlign = HorizontalAlignment.Left;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(589, 213);
            Label5.Name = "Label5";
            Label5.Size = new Size(39, 13);
            Label5.TabIndex = 72;
            Label5.Text = "Celular";
            // 
            // txtApellidoM
            // 
            txtApellidoM.Cursor = Cursors.IBeam;
            txtApellidoM.Font = new Font("Century Gothic", 9.75f);
            txtApellidoM.ForeColor = Color.White;
            txtApellidoM.HintForeColor = Color.White;
            txtApellidoM.HintText = "";
            txtApellidoM.isPassword = false;
            txtApellidoM.LineFocusedColor = Color.Blue;
            txtApellidoM.LineIdleColor = Color.Gray;
            txtApellidoM.LineMouseHoverColor = Color.Blue;
            txtApellidoM.LineThickness = 3;
            txtApellidoM.Location = new Point(592, 40);
            txtApellidoM.Margin = new Padding(4);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(214, 29);
            txtApellidoM.TabIndex = 4;
            txtApellidoM.TextAlign = HorizontalAlignment.Left;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(589, 23);
            Label2.Name = "Label2";
            Label2.Size = new Size(86, 13);
            Label2.TabIndex = 66;
            Label2.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            txtApellidoP.Cursor = Cursors.IBeam;
            txtApellidoP.Font = new Font("Century Gothic", 9.75f);
            txtApellidoP.ForeColor = Color.White;
            txtApellidoP.HintForeColor = Color.White;
            txtApellidoP.HintText = "";
            txtApellidoP.isPassword = false;
            txtApellidoP.LineFocusedColor = Color.Blue;
            txtApellidoP.LineIdleColor = Color.Gray;
            txtApellidoP.LineMouseHoverColor = Color.Blue;
            txtApellidoP.LineThickness = 3;
            txtApellidoP.Location = new Point(320, 40);
            txtApellidoP.Margin = new Padding(4);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(237, 29);
            txtApellidoP.TabIndex = 3;
            txtApellidoP.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(317, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(84, 13);
            Label1.TabIndex = 64;
            Label1.Text = "Apellido Paterno";
            // 
            // txtnombre
            // 
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.White;
            txtnombre.HintForeColor = Color.White;
            txtnombre.HintText = "";
            txtnombre.isPassword = false;
            txtnombre.LineFocusedColor = Color.Blue;
            txtnombre.LineIdleColor = Color.Gray;
            txtnombre.LineMouseHoverColor = Color.Blue;
            txtnombre.LineThickness = 3;
            txtnombre.Location = new Point(33, 40);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(248, 29);
            txtnombre.TabIndex = 2;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(30, 23);
            Label11.Name = "Label11";
            Label11.Size = new Size(55, 13);
            Label11.TabIndex = 62;
            Label11.Text = "Nombre(s)";
            // 
            // TabPage5
            // 
            TabPage5.BackColor = Color.FromArgb(0, 5, 11);
            TabPage5.Controls.Add(TabControl2);
            TabPage5.Controls.Add(Label39);
            TabPage5.Controls.Add(FlowLayoutPanel1);
            TabPage5.Controls.Add(btn_agregar);
            TabPage5.Controls.Add(Label21);
            TabPage5.Controls.Add(btn_Procesar);
            TabPage5.Location = new Point(4, 22);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(1133, 319);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "Verificación";
            // 
            // TabControl2
            // 
            TabControl2.Controls.Add(TabPage6);
            TabControl2.Controls.Add(TabPage7);
            TabControl2.Location = new Point(351, 45);
            TabControl2.Name = "TabControl2";
            TabControl2.SelectedIndex = 0;
            TabControl2.Size = new Size(723, 217);
            TabControl2.TabIndex = 155;
            // 
            // TabPage6
            // 
            TabPage6.Controls.Add(dtdatosDocumentos);
            TabPage6.Location = new Point(4, 22);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(715, 191);
            TabPage6.TabIndex = 0;
            TabPage6.Text = "Documentos Cargados";
            TabPage6.UseVisualStyleBackColor = true;
            // 
            // dtdatosDocumentos
            // 
            dtdatosDocumentos.AllowUserToAddRows = false;
            dtdatosDocumentos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtdatosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtdatosDocumentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatosDocumentos.BackgroundColor = Color.Gainsboro;
            dtdatosDocumentos.BorderStyle = BorderStyle.None;
            dtdatosDocumentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtdatosDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtdatosDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatosDocumentos.DoubleBuffered = true;
            dtdatosDocumentos.EnableHeadersVisualStyles = false;
            dtdatosDocumentos.HeaderBgColor = Color.DarkSlateGray;
            dtdatosDocumentos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatosDocumentos.Location = new Point(6, 5);
            dtdatosDocumentos.Name = "dtdatosDocumentos";
            dtdatosDocumentos.ReadOnly = true;
            dtdatosDocumentos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatosDocumentos.RowHeadersVisible = false;
            dtdatosDocumentos.Size = new Size(703, 179);
            dtdatosDocumentos.TabIndex = 26;
            // 
            // TabPage7
            // 
            TabPage7.Controls.Add(dtdatosDocumentosNuevos);
            TabPage7.Location = new Point(4, 22);
            TabPage7.Name = "TabPage7";
            TabPage7.Padding = new Padding(3);
            TabPage7.Size = new Size(715, 191);
            TabPage7.TabIndex = 1;
            TabPage7.Text = "Documentos Por Cargar";
            TabPage7.UseVisualStyleBackColor = true;
            // 
            // dtdatosDocumentosNuevos
            // 
            dtdatosDocumentosNuevos.AllowUserToAddRows = false;
            dtdatosDocumentosNuevos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dtdatosDocumentosNuevos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3;
            dtdatosDocumentosNuevos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatosDocumentosNuevos.BackgroundColor = Color.Gainsboro;
            dtdatosDocumentosNuevos.BorderStyle = BorderStyle.None;
            dtdatosDocumentosNuevos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle4.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtdatosDocumentosNuevos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dtdatosDocumentosNuevos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatosDocumentosNuevos.Columns.AddRange(new DataGridViewColumn[] { idTipoDocumento, NombreDocumento, Imagen });
            dtdatosDocumentosNuevos.DoubleBuffered = true;
            dtdatosDocumentosNuevos.EnableHeadersVisualStyles = false;
            dtdatosDocumentosNuevos.HeaderBgColor = Color.DarkSlateGray;
            dtdatosDocumentosNuevos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatosDocumentosNuevos.Location = new Point(6, 6);
            dtdatosDocumentosNuevos.Name = "dtdatosDocumentosNuevos";
            dtdatosDocumentosNuevos.ReadOnly = true;
            dtdatosDocumentosNuevos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatosDocumentosNuevos.RowHeadersVisible = false;
            dtdatosDocumentosNuevos.Size = new Size(703, 179);
            dtdatosDocumentosNuevos.TabIndex = 27;
            // 
            // idTipoDocumento
            // 
            idTipoDocumento.HeaderText = "idTipoDocumento";
            idTipoDocumento.Name = "idTipoDocumento";
            idTipoDocumento.ReadOnly = true;
            // 
            // NombreDocumento
            // 
            NombreDocumento.HeaderText = "NombreDocumento";
            NombreDocumento.Name = "NombreDocumento";
            NombreDocumento.ReadOnly = true;
            // 
            // Imagen
            // 
            Imagen.FillWeight = 300.0f;
            Imagen.HeaderText = "Imagen";
            Imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Width = 300;
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.ForeColor = Color.White;
            Label39.Location = new Point(21, 12);
            Label39.Name = "Label39";
            Label39.Size = new Size(123, 13);
            Label39.TabIndex = 154;
            Label39.Text = "Documentos Necesarios";
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.BackColor = Color.White;
            FlowLayoutPanel1.Location = new Point(24, 44);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(135, 166);
            FlowLayoutPanel1.TabIndex = 153;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(443, 8);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(27, 21);
            btn_agregar.TabIndex = 52;
            btn_agregar.Text = "+";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.ForeColor = Color.White;
            Label21.Location = new Point(348, 12);
            Label21.Name = "Label21";
            Label21.Size = new Size(67, 13);
            Label21.TabIndex = 150;
            Label21.Text = "Documentos";
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
            btn_Procesar.ButtonText = "Registrar Captura";
            btn_Procesar.Cursor = Cursors.Hand;
            btn_Procesar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Procesar.ForeColor = Color.DarkBlue;
            btn_Procesar.IdleBorderThickness = 1;
            btn_Procesar.IdleCornerRadius = 20;
            btn_Procesar.IdleFillColor = Color.White;
            btn_Procesar.IdleForecolor = Color.Gray;
            btn_Procesar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.Location = new Point(458, 271);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 53;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            dtdatos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5;
            dtdatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtdatos.BackgroundColor = Color.Gainsboro;
            dtdatos.BorderStyle = BorderStyle.None;
            dtdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle6.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle6.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6;
            dtdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(12, 43);
            dtdatos.Name = "dtdatos";
            dtdatos.ReadOnly = true;
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(1144, 309);
            dtdatos.TabIndex = 25;
            // 
            // BackgroundWorker1
            // 
            // 
            // BackgroundAct
            // 
            // 
            // BackgroundDocumentosSolicitud
            // 
            // 
            // BackgroundVerificacion
            // 
            // 
            // BackgroundDocumentos
            // 
            // 
            // BackgroundWorker2
            // 
            // 
            // BackgroundCargaDocumentos
            // 
            // 
            // BackgroundVerificaDocumentos
            // 
            // 
            // DatosSolicitudBoleta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1161, 715);
            Controls.Add(dtdatos);
            Controls.Add(TabControl1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatosSolicitudBoleta";
            Text = "DatosSolicitud";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage5.ResumeLayout(false);
            TabPage5.PerformLayout();
            TabControl2.ResumeLayout(false);
            TabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).EndInit();
            TabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentosNuevos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Load += new EventHandler(DatosSolicitud_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCurp;
        internal Label Label16;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        internal Label Label15;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        internal Label Label14;
        internal Label Label13;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        internal Label Label10;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtDomicilio;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCelular;
        internal Label Label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoM;
        internal Label Label2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoP;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal Label Label11;
        internal TabPage TabPage5;
        internal Label Label21;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal System.ComponentModel.BackgroundWorker BackgroundAct;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentos;
        internal Button btn_agregar;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_a_autorizacion;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentosSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificacion;
        internal Label Label39;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal System.ComponentModel.BackgroundWorker BackgroundDatosSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal TabControl TabControl2;
        internal TabPage TabPage6;
        internal TabPage TabPage7;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentosNuevos;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker2;
        internal DataGridViewTextBoxColumn idTipoDocumento;
        internal DataGridViewTextBoxColumn NombreDocumento;
        internal DataGridViewImageColumn Imagen;
        internal System.ComponentModel.BackgroundWorker BackgroundCargaDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificaDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundActivarLegal;
        internal ComboBox ComboColonia;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIne;
        internal Label Label3;
    }
}