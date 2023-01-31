using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class DatosSolicitudReenviarCorreo : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosSolicitudReenviarCorreo));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            btnReenviar = new Bunifu.Framework.UI.BunifuThinButton2();
            btnReenviar.Click += new EventHandler(btnReenviar_Click);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            TabPage1.Click += new EventHandler(TabPage1_Click);
            txtEntreCalles = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label35 = new Label();
            txtRelacionConyuge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label17 = new Label();
            txtdatosConyuge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label16 = new Label();
            txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label15 = new Label();
            txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label14 = new Label();
            txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label13 = new Label();
            txtTiempoDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label12 = new Label();
            txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label10 = new Label();
            txtNoInterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label9 = new Label();
            txtNoExterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label8 = new Label();
            txtCalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label7 = new Label();
            TxtCasaDondeVive = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label6 = new Label();
            txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label5 = new Label();
            txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            txtEdad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label3 = new Label();
            txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label2 = new Label();
            txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label11 = new Label();
            TabPage2 = new TabPage();
            txtCodigoPostalTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label38 = new Label();
            txtNoInteriorTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label37 = new Label();
            txtNoExteriorTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label36 = new Label();
            txtObjetivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label22 = new Label();
            txtFrecuenciaCobro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label23 = new Label();
            txtJefeDirecto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label24 = new Label();
            txtTelefonoTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label25 = new Label();
            txtColoniaTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label26 = new Label();
            txtCalleTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label27 = new Label();
            txtIngresoPromedio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label28 = new Label();
            txtTipoEstablecimiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label29 = new Label();
            txtHorariosTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label30 = new Label();
            txtAntiguedad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label31 = new Label();
            txtVende = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label32 = new Label();
            txtSeDedica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label33 = new Label();
            txtNombreLugarTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label34 = new Label();
            TabPage3 = new TabPage();
            GroupBox3 = new GroupBox();
            txtColoniaR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtNoIntR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label62 = new Label();
            txtNoExtR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label63 = new Label();
            txtCalleR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label64 = new Label();
            txtCodigoPostalR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label65 = new Label();
            Label66 = new Label();
            GroupBox2 = new GroupBox();
            txtColoniaR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtNoIntR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label57 = new Label();
            txtNoExtR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label58 = new Label();
            txtCalleR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label59 = new Label();
            txtCodigoPostalR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label60 = new Label();
            Label61 = new Label();
            txtRelacionR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label18 = new Label();
            txtTelefonoR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label19 = new Label();
            txtNombreR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label20 = new Label();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_Separator1 = new MonoFlat.MonoFlat_Separator();
            txtRelacionR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label41 = new Label();
            txtTelefonoR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label42 = new Label();
            txtNombreR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label43 = new Label();
            TabPage4 = new TabPage();
            txtFrecuenciaInversion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label40 = new Label();
            txtEmpleados = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label44 = new Label();
            txtPersonasDependientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label45 = new Label();
            txtServicios = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label46 = new Label();
            txtDeudas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label47 = new Label();
            txtFamiliasEnCasa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label48 = new Label();
            txtEnfermedad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label49 = new Label();
            TabPage5 = new TabPage();
            Label39 = new Label();
            txtMontoAutorizado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtComentarios = new TextBox();
            Label50 = new Label();
            Label54 = new Label();
            txtComentariosVerificacion = new TextBox();
            txtMontoVerificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label53 = new Label();
            txtMontoSolicitado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label52 = new Label();
            dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatosDocumentos.CellContentClick += new DataGridViewCellEventHandler(dtdatosDocumentos_CellContentClick);
            dtdatosDocumentos.CellContentDoubleClick += new DataGridViewCellEventHandler(dtdatosDocumentos_CellContentDoubleClick);
            Label21 = new Label();
            txtObservacionesDomicilio = new TextBox();
            txtHorarioVerificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label55 = new Label();
            Label56 = new Label();
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatos.CellContentClick += new DataGridViewCellEventHandler(dtdatos_CellContentClick);
            dtdatos.CellDoubleClick += new DataGridViewCellEventHandler(dtdatos_CellDoubleClick);
            Id = new DataGridViewTextBoxColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
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
            BackgroundDatosSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDatosSolicitud_DoWork);
            BackgroundDatosSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDatosSolicitud_RunWorkerCompleted);
            BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentos_DoWork);
            BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentos_RunWorkerCompleted);
            BackgroundRechazo = new System.ComponentModel.BackgroundWorker();
            BackgroundRechazo.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundRechazo_DoWork);
            BackgroundRechazo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundRechazo_RunWorkerCompleted);
            BackgroundCorreo = new System.ComponentModel.BackgroundWorker();
            BackgroundCorreo.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCorreo_DoWork);
            BackgroundCorreo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCorreo_RunWorkerCompleted);
            Panel1.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            GroupBox3.SuspendLayout();
            GroupBox2.SuspendLayout();
            TabPage4.SuspendLayout();
            TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(btnReenviar);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1148, 36);
            Panel1.TabIndex = 3;
            // 
            // btnReenviar
            // 
            btnReenviar.ActiveBorderThickness = 1;
            btnReenviar.ActiveCornerRadius = 20;
            btnReenviar.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnReenviar.ActiveForecolor = Color.White;
            btnReenviar.ActiveLineColor = Color.SeaGreen;
            btnReenviar.BackColor = Color.FromArgb(14, 21, 38);
            btnReenviar.BackgroundImage = (Image)resources.GetObject("btnReenviar.BackgroundImage");
            btnReenviar.ButtonText = "Reenviar Correo";
            btnReenviar.Cursor = Cursors.Hand;
            btnReenviar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReenviar.ForeColor = Color.DarkBlue;
            btnReenviar.IdleBorderThickness = 1;
            btnReenviar.IdleCornerRadius = 20;
            btnReenviar.IdleFillColor = Color.White;
            btnReenviar.IdleForecolor = Color.Gray;
            btnReenviar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnReenviar.Location = new Point(823, -2);
            btnReenviar.Margin = new Padding(5);
            btnReenviar.Name = "btnReenviar";
            btnReenviar.Size = new Size(173, 38);
            btnReenviar.TabIndex = 153;
            btnReenviar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(1076, 7);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 153;
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
            MonoFlat_HeaderLabel1.Size = new Size(134, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Datos de solicitud";
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Controls.Add(TabPage4);
            TabControl1.Controls.Add(TabPage5);
            TabControl1.Location = new Point(8, 231);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1141, 584);
            TabControl1.TabIndex = 4;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.FromArgb(0, 5, 11);
            TabPage1.Controls.Add(txtEntreCalles);
            TabPage1.Controls.Add(Label35);
            TabPage1.Controls.Add(txtRelacionConyuge);
            TabPage1.Controls.Add(Label17);
            TabPage1.Controls.Add(txtdatosConyuge);
            TabPage1.Controls.Add(Label16);
            TabPage1.Controls.Add(txtEstado);
            TabPage1.Controls.Add(Label15);
            TabPage1.Controls.Add(txtCiudad);
            TabPage1.Controls.Add(Label14);
            TabPage1.Controls.Add(txtColonia);
            TabPage1.Controls.Add(Label13);
            TabPage1.Controls.Add(txtTiempoDomicilio);
            TabPage1.Controls.Add(Label12);
            TabPage1.Controls.Add(txtCodigoPostal);
            TabPage1.Controls.Add(Label10);
            TabPage1.Controls.Add(txtNoInterior);
            TabPage1.Controls.Add(Label9);
            TabPage1.Controls.Add(txtNoExterior);
            TabPage1.Controls.Add(Label8);
            TabPage1.Controls.Add(txtCalle);
            TabPage1.Controls.Add(Label7);
            TabPage1.Controls.Add(TxtCasaDondeVive);
            TabPage1.Controls.Add(Label6);
            TabPage1.Controls.Add(txtCelular);
            TabPage1.Controls.Add(Label5);
            TabPage1.Controls.Add(txtTelefono);
            TabPage1.Controls.Add(Label4);
            TabPage1.Controls.Add(txtEdad);
            TabPage1.Controls.Add(Label3);
            TabPage1.Controls.Add(txtApellidoM);
            TabPage1.Controls.Add(Label2);
            TabPage1.Controls.Add(txtApellidoP);
            TabPage1.Controls.Add(Label1);
            TabPage1.Controls.Add(txtnombre);
            TabPage1.Controls.Add(Label11);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1133, 558);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Datos Personales";
            // 
            // txtEntreCalles
            // 
            txtEntreCalles.Cursor = Cursors.IBeam;
            txtEntreCalles.Enabled = false;
            txtEntreCalles.Font = new Font("Century Gothic", 9.75f);
            txtEntreCalles.ForeColor = Color.White;
            txtEntreCalles.HintForeColor = Color.White;
            txtEntreCalles.HintText = "";
            txtEntreCalles.isPassword = false;
            txtEntreCalles.LineFocusedColor = Color.Blue;
            txtEntreCalles.LineIdleColor = Color.Gray;
            txtEntreCalles.LineMouseHoverColor = Color.Blue;
            txtEntreCalles.LineThickness = 3;
            txtEntreCalles.Location = new Point(45, 287);
            txtEntreCalles.Margin = new Padding(4);
            txtEntreCalles.Name = "txtEntreCalles";
            txtEntreCalles.Size = new Size(213, 29);
            txtEntreCalles.TabIndex = 97;
            txtEntreCalles.TextAlign = HorizontalAlignment.Left;
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.ForeColor = Color.White;
            Label35.Location = new Point(42, 270);
            Label35.Name = "Label35";
            Label35.Size = new Size(62, 13);
            Label35.TabIndex = 96;
            Label35.Text = "Entre calles";
            // 
            // txtRelacionConyuge
            // 
            txtRelacionConyuge.Cursor = Cursors.IBeam;
            txtRelacionConyuge.Enabled = false;
            txtRelacionConyuge.Font = new Font("Century Gothic", 9.75f);
            txtRelacionConyuge.ForeColor = Color.White;
            txtRelacionConyuge.HintForeColor = Color.White;
            txtRelacionConyuge.HintText = "";
            txtRelacionConyuge.isPassword = false;
            txtRelacionConyuge.LineFocusedColor = Color.Blue;
            txtRelacionConyuge.LineIdleColor = Color.Gray;
            txtRelacionConyuge.LineMouseHoverColor = Color.Blue;
            txtRelacionConyuge.LineThickness = 3;
            txtRelacionConyuge.Location = new Point(266, 353);
            txtRelacionConyuge.Margin = new Padding(4);
            txtRelacionConyuge.Name = "txtRelacionConyuge";
            txtRelacionConyuge.Size = new Size(199, 29);
            txtRelacionConyuge.TabIndex = 95;
            txtRelacionConyuge.TextAlign = HorizontalAlignment.Left;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(263, 336);
            Label17.Name = "Label17";
            Label17.Size = new Size(131, 13);
            Label17.TabIndex = 94;
            Label17.Text = "Relación con el solicitante";
            // 
            // txtdatosConyuge
            // 
            txtdatosConyuge.Cursor = Cursors.IBeam;
            txtdatosConyuge.Enabled = false;
            txtdatosConyuge.Font = new Font("Century Gothic", 9.75f);
            txtdatosConyuge.ForeColor = Color.White;
            txtdatosConyuge.HintForeColor = Color.White;
            txtdatosConyuge.HintText = "";
            txtdatosConyuge.isPassword = false;
            txtdatosConyuge.LineFocusedColor = Color.Blue;
            txtdatosConyuge.LineIdleColor = Color.Gray;
            txtdatosConyuge.LineMouseHoverColor = Color.Blue;
            txtdatosConyuge.LineThickness = 3;
            txtdatosConyuge.Location = new Point(45, 353);
            txtdatosConyuge.Margin = new Padding(4);
            txtdatosConyuge.Name = "txtdatosConyuge";
            txtdatosConyuge.Size = new Size(213, 29);
            txtdatosConyuge.TabIndex = 93;
            txtdatosConyuge.TextAlign = HorizontalAlignment.Left;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.ForeColor = Color.White;
            Label16.Location = new Point(42, 336);
            Label16.Name = "Label16";
            Label16.Size = new Size(219, 13);
            Label16.TabIndex = 92;
            Label16.Text = "Datos del cónyuge o persona con quien viva";
            // 
            // txtEstado
            // 
            txtEstado.Cursor = Cursors.IBeam;
            txtEstado.Enabled = false;
            txtEstado.Font = new Font("Century Gothic", 9.75f);
            txtEstado.ForeColor = Color.White;
            txtEstado.HintForeColor = Color.White;
            txtEstado.HintText = "";
            txtEstado.isPassword = false;
            txtEstado.LineFocusedColor = Color.Blue;
            txtEstado.LineIdleColor = Color.Gray;
            txtEstado.LineMouseHoverColor = Color.Blue;
            txtEstado.LineThickness = 3;
            txtEstado.Location = new Point(664, 287);
            txtEstado.Margin = new Padding(4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(228, 29);
            txtEstado.TabIndex = 91;
            txtEstado.TextAlign = HorizontalAlignment.Left;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.ForeColor = Color.White;
            Label15.Location = new Point(661, 270);
            Label15.Name = "Label15";
            Label15.Size = new Size(40, 13);
            Label15.TabIndex = 90;
            Label15.Text = "Estado";
            // 
            // txtCiudad
            // 
            txtCiudad.Cursor = Cursors.IBeam;
            txtCiudad.Enabled = false;
            txtCiudad.Font = new Font("Century Gothic", 9.75f);
            txtCiudad.ForeColor = Color.White;
            txtCiudad.HintForeColor = Color.White;
            txtCiudad.HintText = "";
            txtCiudad.isPassword = false;
            txtCiudad.LineFocusedColor = Color.Blue;
            txtCiudad.LineIdleColor = Color.Gray;
            txtCiudad.LineMouseHoverColor = Color.Blue;
            txtCiudad.LineThickness = 3;
            txtCiudad.Location = new Point(475, 287);
            txtCiudad.Margin = new Padding(4);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(181, 29);
            txtCiudad.TabIndex = 89;
            txtCiudad.TextAlign = HorizontalAlignment.Left;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.ForeColor = Color.White;
            Label14.Location = new Point(472, 270);
            Label14.Name = "Label14";
            Label14.Size = new Size(40, 13);
            Label14.TabIndex = 88;
            Label14.Text = "Ciudad";
            // 
            // txtColonia
            // 
            txtColonia.Cursor = Cursors.IBeam;
            txtColonia.Enabled = false;
            txtColonia.Font = new Font("Century Gothic", 9.75f);
            txtColonia.ForeColor = Color.White;
            txtColonia.HintForeColor = Color.White;
            txtColonia.HintText = "";
            txtColonia.isPassword = false;
            txtColonia.LineFocusedColor = Color.Blue;
            txtColonia.LineIdleColor = Color.Gray;
            txtColonia.LineMouseHoverColor = Color.Blue;
            txtColonia.LineThickness = 3;
            txtColonia.Location = new Point(266, 287);
            txtColonia.Margin = new Padding(4);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(199, 29);
            txtColonia.TabIndex = 87;
            txtColonia.TextAlign = HorizontalAlignment.Left;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = Color.White;
            Label13.Location = new Point(263, 270);
            Label13.Name = "Label13";
            Label13.Size = new Size(42, 13);
            Label13.TabIndex = 86;
            Label13.Text = "Colonia";
            // 
            // txtTiempoDomicilio
            // 
            txtTiempoDomicilio.Cursor = Cursors.IBeam;
            txtTiempoDomicilio.Enabled = false;
            txtTiempoDomicilio.Font = new Font("Century Gothic", 9.75f);
            txtTiempoDomicilio.ForeColor = Color.White;
            txtTiempoDomicilio.HintForeColor = Color.White;
            txtTiempoDomicilio.HintText = "";
            txtTiempoDomicilio.isPassword = false;
            txtTiempoDomicilio.LineFocusedColor = Color.Blue;
            txtTiempoDomicilio.LineIdleColor = Color.Gray;
            txtTiempoDomicilio.LineMouseHoverColor = Color.Blue;
            txtTiempoDomicilio.LineThickness = 3;
            txtTiempoDomicilio.Location = new Point(664, 146);
            txtTiempoDomicilio.Margin = new Padding(4);
            txtTiempoDomicilio.Name = "txtTiempoDomicilio";
            txtTiempoDomicilio.Size = new Size(228, 29);
            txtTiempoDomicilio.TabIndex = 85;
            txtTiempoDomicilio.TextAlign = HorizontalAlignment.Left;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.ForeColor = Color.White;
            Label12.Location = new Point(661, 129);
            Label12.Name = "Label12";
            Label12.Size = new Size(154, 13);
            Label12.TabIndex = 84;
            Label12.Text = "Tiempo viviendo en el domicilio";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Cursor = Cursors.IBeam;
            txtCodigoPostal.Enabled = false;
            txtCodigoPostal.Font = new Font("Century Gothic", 9.75f);
            txtCodigoPostal.ForeColor = Color.White;
            txtCodigoPostal.HintForeColor = Color.White;
            txtCodigoPostal.HintText = "";
            txtCodigoPostal.isPassword = false;
            txtCodigoPostal.LineFocusedColor = Color.Blue;
            txtCodigoPostal.LineIdleColor = Color.Gray;
            txtCodigoPostal.LineMouseHoverColor = Color.Blue;
            txtCodigoPostal.LineThickness = 3;
            txtCodigoPostal.Location = new Point(664, 223);
            txtCodigoPostal.Margin = new Padding(4);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(228, 29);
            txtCodigoPostal.TabIndex = 83;
            txtCodigoPostal.TextAlign = HorizontalAlignment.Left;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.ForeColor = Color.White;
            Label10.Location = new Point(661, 206);
            Label10.Name = "Label10";
            Label10.Size = new Size(72, 13);
            Label10.TabIndex = 82;
            Label10.Text = "Código Postal";
            // 
            // txtNoInterior
            // 
            txtNoInterior.Cursor = Cursors.IBeam;
            txtNoInterior.Enabled = false;
            txtNoInterior.Font = new Font("Century Gothic", 9.75f);
            txtNoInterior.ForeColor = Color.White;
            txtNoInterior.HintForeColor = Color.White;
            txtNoInterior.HintText = "";
            txtNoInterior.isPassword = false;
            txtNoInterior.LineFocusedColor = Color.Blue;
            txtNoInterior.LineIdleColor = Color.Gray;
            txtNoInterior.LineMouseHoverColor = Color.Blue;
            txtNoInterior.LineThickness = 3;
            txtNoInterior.Location = new Point(473, 223);
            txtNoInterior.Margin = new Padding(4);
            txtNoInterior.Name = "txtNoInterior";
            txtNoInterior.Size = new Size(183, 29);
            txtNoInterior.TabIndex = 81;
            txtNoInterior.TextAlign = HorizontalAlignment.Left;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.ForeColor = Color.White;
            Label9.Location = new Point(470, 206);
            Label9.Name = "Label9";
            Label9.Size = new Size(58, 13);
            Label9.TabIndex = 80;
            Label9.Text = "No. interior";
            // 
            // txtNoExterior
            // 
            txtNoExterior.Cursor = Cursors.IBeam;
            txtNoExterior.Enabled = false;
            txtNoExterior.Font = new Font("Century Gothic", 9.75f);
            txtNoExterior.ForeColor = Color.White;
            txtNoExterior.HintForeColor = Color.White;
            txtNoExterior.HintText = "";
            txtNoExterior.isPassword = false;
            txtNoExterior.LineFocusedColor = Color.Blue;
            txtNoExterior.LineIdleColor = Color.Gray;
            txtNoExterior.LineMouseHoverColor = Color.Blue;
            txtNoExterior.LineThickness = 3;
            txtNoExterior.Location = new Point(266, 223);
            txtNoExterior.Margin = new Padding(4);
            txtNoExterior.Name = "txtNoExterior";
            txtNoExterior.Size = new Size(199, 29);
            txtNoExterior.TabIndex = 79;
            txtNoExterior.TextAlign = HorizontalAlignment.Left;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(263, 206);
            Label8.Name = "Label8";
            Label8.Size = new Size(61, 13);
            Label8.TabIndex = 78;
            Label8.Text = "No. exterior";
            // 
            // txtCalle
            // 
            txtCalle.Cursor = Cursors.IBeam;
            txtCalle.Enabled = false;
            txtCalle.Font = new Font("Century Gothic", 9.75f);
            txtCalle.ForeColor = Color.White;
            txtCalle.HintForeColor = Color.White;
            txtCalle.HintText = "";
            txtCalle.isPassword = false;
            txtCalle.LineFocusedColor = Color.Blue;
            txtCalle.LineIdleColor = Color.Gray;
            txtCalle.LineMouseHoverColor = Color.Blue;
            txtCalle.LineThickness = 3;
            txtCalle.Location = new Point(45, 223);
            txtCalle.Margin = new Padding(4);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(213, 29);
            txtCalle.TabIndex = 77;
            txtCalle.TextAlign = HorizontalAlignment.Left;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(42, 206);
            Label7.Name = "Label7";
            Label7.Size = new Size(30, 13);
            Label7.TabIndex = 76;
            Label7.Text = "Calle";
            // 
            // TxtCasaDondeVive
            // 
            TxtCasaDondeVive.Cursor = Cursors.IBeam;
            TxtCasaDondeVive.Enabled = false;
            TxtCasaDondeVive.Font = new Font("Century Gothic", 9.75f);
            TxtCasaDondeVive.ForeColor = Color.White;
            TxtCasaDondeVive.HintForeColor = Color.White;
            TxtCasaDondeVive.HintText = "";
            TxtCasaDondeVive.isPassword = false;
            TxtCasaDondeVive.LineFocusedColor = Color.Blue;
            TxtCasaDondeVive.LineIdleColor = Color.Gray;
            TxtCasaDondeVive.LineMouseHoverColor = Color.Blue;
            TxtCasaDondeVive.LineThickness = 3;
            TxtCasaDondeVive.Location = new Point(473, 146);
            TxtCasaDondeVive.Margin = new Padding(4);
            TxtCasaDondeVive.Name = "TxtCasaDondeVive";
            TxtCasaDondeVive.Size = new Size(183, 29);
            TxtCasaDondeVive.TabIndex = 75;
            TxtCasaDondeVive.TextAlign = HorizontalAlignment.Left;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(470, 129);
            Label6.Name = "Label6";
            Label6.Size = new Size(118, 13);
            Label6.TabIndex = 74;
            Label6.Text = "La casa donde vive es:";
            // 
            // txtCelular
            // 
            txtCelular.Cursor = Cursors.IBeam;
            txtCelular.Enabled = false;
            txtCelular.Font = new Font("Century Gothic", 9.75f);
            txtCelular.ForeColor = Color.White;
            txtCelular.HintForeColor = Color.White;
            txtCelular.HintText = "";
            txtCelular.isPassword = false;
            txtCelular.LineFocusedColor = Color.Blue;
            txtCelular.LineIdleColor = Color.Gray;
            txtCelular.LineMouseHoverColor = Color.Blue;
            txtCelular.LineThickness = 3;
            txtCelular.Location = new Point(266, 146);
            txtCelular.Margin = new Padding(4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(199, 29);
            txtCelular.TabIndex = 73;
            txtCelular.TextAlign = HorizontalAlignment.Left;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(263, 129);
            Label5.Name = "Label5";
            Label5.Size = new Size(39, 13);
            Label5.TabIndex = 72;
            Label5.Text = "Celular";
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Enabled = false;
            txtTelefono.Font = new Font("Century Gothic", 9.75f);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.HintForeColor = Color.White;
            txtTelefono.HintText = "";
            txtTelefono.isPassword = false;
            txtTelefono.LineFocusedColor = Color.Blue;
            txtTelefono.LineIdleColor = Color.Gray;
            txtTelefono.LineMouseHoverColor = Color.Blue;
            txtTelefono.LineThickness = 3;
            txtTelefono.Location = new Point(45, 146);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(213, 29);
            txtTelefono.TabIndex = 71;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(42, 129);
            Label4.Name = "Label4";
            Label4.Size = new Size(96, 13);
            Label4.TabIndex = 70;
            Label4.Text = "Teléfono Particular";
            // 
            // txtEdad
            // 
            txtEdad.Cursor = Cursors.IBeam;
            txtEdad.Enabled = false;
            txtEdad.Font = new Font("Century Gothic", 9.75f);
            txtEdad.ForeColor = Color.White;
            txtEdad.HintForeColor = Color.White;
            txtEdad.HintText = "";
            txtEdad.isPassword = false;
            txtEdad.LineFocusedColor = Color.Blue;
            txtEdad.LineIdleColor = Color.Gray;
            txtEdad.LineMouseHoverColor = Color.Blue;
            txtEdad.LineThickness = 3;
            txtEdad.Location = new Point(664, 71);
            txtEdad.Margin = new Padding(4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(228, 29);
            txtEdad.TabIndex = 69;
            txtEdad.TextAlign = HorizontalAlignment.Left;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(661, 54);
            Label3.Name = "Label3";
            Label3.Size = new Size(32, 13);
            Label3.TabIndex = 68;
            Label3.Text = "Edad";
            // 
            // txtApellidoM
            // 
            txtApellidoM.Cursor = Cursors.IBeam;
            txtApellidoM.Enabled = false;
            txtApellidoM.Font = new Font("Century Gothic", 9.75f);
            txtApellidoM.ForeColor = Color.White;
            txtApellidoM.HintForeColor = Color.White;
            txtApellidoM.HintText = "";
            txtApellidoM.isPassword = false;
            txtApellidoM.LineFocusedColor = Color.Blue;
            txtApellidoM.LineIdleColor = Color.Gray;
            txtApellidoM.LineMouseHoverColor = Color.Blue;
            txtApellidoM.LineThickness = 3;
            txtApellidoM.Location = new Point(473, 71);
            txtApellidoM.Margin = new Padding(4);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(183, 29);
            txtApellidoM.TabIndex = 67;
            txtApellidoM.TextAlign = HorizontalAlignment.Left;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(470, 54);
            Label2.Name = "Label2";
            Label2.Size = new Size(86, 13);
            Label2.TabIndex = 66;
            Label2.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            txtApellidoP.Cursor = Cursors.IBeam;
            txtApellidoP.Enabled = false;
            txtApellidoP.Font = new Font("Century Gothic", 9.75f);
            txtApellidoP.ForeColor = Color.White;
            txtApellidoP.HintForeColor = Color.White;
            txtApellidoP.HintText = "";
            txtApellidoP.isPassword = false;
            txtApellidoP.LineFocusedColor = Color.Blue;
            txtApellidoP.LineIdleColor = Color.Gray;
            txtApellidoP.LineMouseHoverColor = Color.Blue;
            txtApellidoP.LineThickness = 3;
            txtApellidoP.Location = new Point(266, 71);
            txtApellidoP.Margin = new Padding(4);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(199, 29);
            txtApellidoP.TabIndex = 65;
            txtApellidoP.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(263, 54);
            Label1.Name = "Label1";
            Label1.Size = new Size(84, 13);
            Label1.TabIndex = 64;
            Label1.Text = "Apellido Paterno";
            // 
            // txtnombre
            // 
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Enabled = false;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.White;
            txtnombre.HintForeColor = Color.White;
            txtnombre.HintText = "";
            txtnombre.isPassword = false;
            txtnombre.LineFocusedColor = Color.Blue;
            txtnombre.LineIdleColor = Color.Gray;
            txtnombre.LineMouseHoverColor = Color.Blue;
            txtnombre.LineThickness = 3;
            txtnombre.Location = new Point(45, 71);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(213, 29);
            txtnombre.TabIndex = 63;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(42, 54);
            Label11.Name = "Label11";
            Label11.Size = new Size(55, 13);
            Label11.TabIndex = 62;
            Label11.Text = "Nombre(s)";
            // 
            // TabPage2
            // 
            TabPage2.BackColor = Color.FromArgb(0, 5, 11);
            TabPage2.Controls.Add(txtCodigoPostalTrabajo);
            TabPage2.Controls.Add(Label38);
            TabPage2.Controls.Add(txtNoInteriorTrabajo);
            TabPage2.Controls.Add(Label37);
            TabPage2.Controls.Add(txtNoExteriorTrabajo);
            TabPage2.Controls.Add(Label36);
            TabPage2.Controls.Add(txtObjetivo);
            TabPage2.Controls.Add(Label22);
            TabPage2.Controls.Add(txtFrecuenciaCobro);
            TabPage2.Controls.Add(Label23);
            TabPage2.Controls.Add(txtJefeDirecto);
            TabPage2.Controls.Add(Label24);
            TabPage2.Controls.Add(txtTelefonoTrabajo);
            TabPage2.Controls.Add(Label25);
            TabPage2.Controls.Add(txtColoniaTrabajo);
            TabPage2.Controls.Add(Label26);
            TabPage2.Controls.Add(txtCalleTrabajo);
            TabPage2.Controls.Add(Label27);
            TabPage2.Controls.Add(txtIngresoPromedio);
            TabPage2.Controls.Add(Label28);
            TabPage2.Controls.Add(txtTipoEstablecimiento);
            TabPage2.Controls.Add(Label29);
            TabPage2.Controls.Add(txtHorariosTrabajo);
            TabPage2.Controls.Add(Label30);
            TabPage2.Controls.Add(txtAntiguedad);
            TabPage2.Controls.Add(Label31);
            TabPage2.Controls.Add(txtVende);
            TabPage2.Controls.Add(Label32);
            TabPage2.Controls.Add(txtSeDedica);
            TabPage2.Controls.Add(Label33);
            TabPage2.Controls.Add(txtNombreLugarTrabajo);
            TabPage2.Controls.Add(Label34);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(1133, 558);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Trabajo";
            // 
            // txtCodigoPostalTrabajo
            // 
            txtCodigoPostalTrabajo.Cursor = Cursors.IBeam;
            txtCodigoPostalTrabajo.Enabled = false;
            txtCodigoPostalTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtCodigoPostalTrabajo.ForeColor = Color.White;
            txtCodigoPostalTrabajo.HintForeColor = Color.White;
            txtCodigoPostalTrabajo.HintText = "";
            txtCodigoPostalTrabajo.isPassword = false;
            txtCodigoPostalTrabajo.LineFocusedColor = Color.Blue;
            txtCodigoPostalTrabajo.LineIdleColor = Color.Gray;
            txtCodigoPostalTrabajo.LineMouseHoverColor = Color.Blue;
            txtCodigoPostalTrabajo.LineThickness = 3;
            txtCodigoPostalTrabajo.Location = new Point(645, 219);
            txtCodigoPostalTrabajo.Margin = new Padding(4);
            txtCodigoPostalTrabajo.Name = "txtCodigoPostalTrabajo";
            txtCodigoPostalTrabajo.Size = new Size(210, 29);
            txtCodigoPostalTrabajo.TabIndex = 127;
            txtCodigoPostalTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label38
            // 
            Label38.AutoSize = true;
            Label38.ForeColor = Color.White;
            Label38.Location = new Point(642, 202);
            Label38.Name = "Label38";
            Label38.Size = new Size(72, 13);
            Label38.TabIndex = 126;
            Label38.Text = "Código Postal";
            // 
            // txtNoInteriorTrabajo
            // 
            txtNoInteriorTrabajo.Cursor = Cursors.IBeam;
            txtNoInteriorTrabajo.Enabled = false;
            txtNoInteriorTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtNoInteriorTrabajo.ForeColor = Color.White;
            txtNoInteriorTrabajo.HintForeColor = Color.White;
            txtNoInteriorTrabajo.HintText = "";
            txtNoInteriorTrabajo.isPassword = false;
            txtNoInteriorTrabajo.LineFocusedColor = Color.Blue;
            txtNoInteriorTrabajo.LineIdleColor = Color.Gray;
            txtNoInteriorTrabajo.LineMouseHoverColor = Color.Blue;
            txtNoInteriorTrabajo.LineThickness = 3;
            txtNoInteriorTrabajo.Location = new Point(454, 219);
            txtNoInteriorTrabajo.Margin = new Padding(4);
            txtNoInteriorTrabajo.Name = "txtNoInteriorTrabajo";
            txtNoInteriorTrabajo.Size = new Size(183, 29);
            txtNoInteriorTrabajo.TabIndex = 125;
            txtNoInteriorTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.ForeColor = Color.White;
            Label37.Location = new Point(451, 202);
            Label37.Name = "Label37";
            Label37.Size = new Size(56, 13);
            Label37.TabIndex = 124;
            Label37.Text = "No Interior";
            // 
            // txtNoExteriorTrabajo
            // 
            txtNoExteriorTrabajo.Cursor = Cursors.IBeam;
            txtNoExteriorTrabajo.Enabled = false;
            txtNoExteriorTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtNoExteriorTrabajo.ForeColor = Color.White;
            txtNoExteriorTrabajo.HintForeColor = Color.White;
            txtNoExteriorTrabajo.HintText = "";
            txtNoExteriorTrabajo.isPassword = false;
            txtNoExteriorTrabajo.LineFocusedColor = Color.Blue;
            txtNoExteriorTrabajo.LineIdleColor = Color.Gray;
            txtNoExteriorTrabajo.LineMouseHoverColor = Color.Blue;
            txtNoExteriorTrabajo.LineThickness = 3;
            txtNoExteriorTrabajo.Location = new Point(247, 219);
            txtNoExteriorTrabajo.Margin = new Padding(4);
            txtNoExteriorTrabajo.Name = "txtNoExteriorTrabajo";
            txtNoExteriorTrabajo.Size = new Size(199, 29);
            txtNoExteriorTrabajo.TabIndex = 123;
            txtNoExteriorTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label36
            // 
            Label36.AutoSize = true;
            Label36.ForeColor = Color.White;
            Label36.Location = new Point(244, 202);
            Label36.Name = "Label36";
            Label36.Size = new Size(59, 13);
            Label36.TabIndex = 122;
            Label36.Text = "No Exterior";
            // 
            // txtObjetivo
            // 
            txtObjetivo.Cursor = Cursors.IBeam;
            txtObjetivo.Enabled = false;
            txtObjetivo.Font = new Font("Century Gothic", 9.75f);
            txtObjetivo.ForeColor = Color.White;
            txtObjetivo.HintForeColor = Color.White;
            txtObjetivo.HintText = "";
            txtObjetivo.isPassword = false;
            txtObjetivo.LineFocusedColor = Color.Blue;
            txtObjetivo.LineIdleColor = Color.Gray;
            txtObjetivo.LineMouseHoverColor = Color.Blue;
            txtObjetivo.LineThickness = 3;
            txtObjetivo.Location = new Point(26, 351);
            txtObjetivo.Margin = new Padding(4);
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.Size = new Size(607, 29);
            txtObjetivo.TabIndex = 121;
            txtObjetivo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.ForeColor = Color.White;
            Label22.Location = new Point(23, 334);
            Label22.Name = "Label22";
            Label22.Size = new Size(98, 13);
            Label22.TabIndex = 120;
            Label22.Text = "Objetivo del crédito";
            // 
            // txtFrecuenciaCobro
            // 
            txtFrecuenciaCobro.Cursor = Cursors.IBeam;
            txtFrecuenciaCobro.Enabled = false;
            txtFrecuenciaCobro.Font = new Font("Century Gothic", 9.75f);
            txtFrecuenciaCobro.ForeColor = Color.White;
            txtFrecuenciaCobro.HintForeColor = Color.White;
            txtFrecuenciaCobro.HintText = "";
            txtFrecuenciaCobro.isPassword = false;
            txtFrecuenciaCobro.LineFocusedColor = Color.Blue;
            txtFrecuenciaCobro.LineIdleColor = Color.Gray;
            txtFrecuenciaCobro.LineMouseHoverColor = Color.Blue;
            txtFrecuenciaCobro.LineThickness = 3;
            txtFrecuenciaCobro.Location = new Point(645, 142);
            txtFrecuenciaCobro.Margin = new Padding(4);
            txtFrecuenciaCobro.Name = "txtFrecuenciaCobro";
            txtFrecuenciaCobro.Size = new Size(210, 29);
            txtFrecuenciaCobro.TabIndex = 119;
            txtFrecuenciaCobro.TextAlign = HorizontalAlignment.Left;
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.ForeColor = Color.White;
            Label23.Location = new Point(642, 125);
            Label23.Name = "Label23";
            Label23.Size = new Size(105, 13);
            Label23.TabIndex = 118;
            Label23.Text = "Frecuencia de cobro";
            // 
            // txtJefeDirecto
            // 
            txtJefeDirecto.Cursor = Cursors.IBeam;
            txtJefeDirecto.Enabled = false;
            txtJefeDirecto.Font = new Font("Century Gothic", 9.75f);
            txtJefeDirecto.ForeColor = Color.White;
            txtJefeDirecto.HintForeColor = Color.White;
            txtJefeDirecto.HintText = "";
            txtJefeDirecto.isPassword = false;
            txtJefeDirecto.LineFocusedColor = Color.Blue;
            txtJefeDirecto.LineIdleColor = Color.Gray;
            txtJefeDirecto.LineMouseHoverColor = Color.Blue;
            txtJefeDirecto.LineThickness = 3;
            txtJefeDirecto.Location = new Point(26, 284);
            txtJefeDirecto.Margin = new Padding(4);
            txtJefeDirecto.Name = "txtJefeDirecto";
            txtJefeDirecto.Size = new Size(213, 29);
            txtJefeDirecto.TabIndex = 117;
            txtJefeDirecto.TextAlign = HorizontalAlignment.Left;
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.ForeColor = Color.White;
            Label24.Location = new Point(23, 267);
            Label24.Name = "Label24";
            Label24.Size = new Size(116, 13);
            Label24.TabIndex = 116;
            Label24.Text = "Nombre del jefe directo";
            // 
            // txtTelefonoTrabajo
            // 
            txtTelefonoTrabajo.Cursor = Cursors.IBeam;
            txtTelefonoTrabajo.Enabled = false;
            txtTelefonoTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtTelefonoTrabajo.ForeColor = Color.White;
            txtTelefonoTrabajo.HintForeColor = Color.White;
            txtTelefonoTrabajo.HintText = "";
            txtTelefonoTrabajo.isPassword = false;
            txtTelefonoTrabajo.LineFocusedColor = Color.Blue;
            txtTelefonoTrabajo.LineIdleColor = Color.Gray;
            txtTelefonoTrabajo.LineMouseHoverColor = Color.Blue;
            txtTelefonoTrabajo.LineThickness = 3;
            txtTelefonoTrabajo.Location = new Point(454, 284);
            txtTelefonoTrabajo.Margin = new Padding(4);
            txtTelefonoTrabajo.Name = "txtTelefonoTrabajo";
            txtTelefonoTrabajo.Size = new Size(183, 29);
            txtTelefonoTrabajo.TabIndex = 115;
            txtTelefonoTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.ForeColor = Color.White;
            Label25.Location = new Point(451, 267);
            Label25.Name = "Label25";
            Label25.Size = new Size(49, 13);
            Label25.TabIndex = 114;
            Label25.Text = "Teléfono";
            // 
            // txtColoniaTrabajo
            // 
            txtColoniaTrabajo.Cursor = Cursors.IBeam;
            txtColoniaTrabajo.Enabled = false;
            txtColoniaTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtColoniaTrabajo.ForeColor = Color.White;
            txtColoniaTrabajo.HintForeColor = Color.White;
            txtColoniaTrabajo.HintText = "";
            txtColoniaTrabajo.isPassword = false;
            txtColoniaTrabajo.LineFocusedColor = Color.Blue;
            txtColoniaTrabajo.LineIdleColor = Color.Gray;
            txtColoniaTrabajo.LineMouseHoverColor = Color.Blue;
            txtColoniaTrabajo.LineThickness = 3;
            txtColoniaTrabajo.Location = new Point(247, 284);
            txtColoniaTrabajo.Margin = new Padding(4);
            txtColoniaTrabajo.Name = "txtColoniaTrabajo";
            txtColoniaTrabajo.Size = new Size(199, 29);
            txtColoniaTrabajo.TabIndex = 113;
            txtColoniaTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label26
            // 
            Label26.AutoSize = true;
            Label26.ForeColor = Color.White;
            Label26.Location = new Point(244, 267);
            Label26.Name = "Label26";
            Label26.Size = new Size(42, 13);
            Label26.TabIndex = 112;
            Label26.Text = "Colonia";
            // 
            // txtCalleTrabajo
            // 
            txtCalleTrabajo.Cursor = Cursors.IBeam;
            txtCalleTrabajo.Enabled = false;
            txtCalleTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtCalleTrabajo.ForeColor = Color.White;
            txtCalleTrabajo.HintForeColor = Color.White;
            txtCalleTrabajo.HintText = "";
            txtCalleTrabajo.isPassword = false;
            txtCalleTrabajo.LineFocusedColor = Color.Blue;
            txtCalleTrabajo.LineIdleColor = Color.Gray;
            txtCalleTrabajo.LineMouseHoverColor = Color.Blue;
            txtCalleTrabajo.LineThickness = 3;
            txtCalleTrabajo.Location = new Point(26, 219);
            txtCalleTrabajo.Margin = new Padding(4);
            txtCalleTrabajo.Name = "txtCalleTrabajo";
            txtCalleTrabajo.Size = new Size(213, 29);
            txtCalleTrabajo.TabIndex = 111;
            txtCalleTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.ForeColor = Color.White;
            Label27.Location = new Point(23, 202);
            Label27.Name = "Label27";
            Label27.Size = new Size(98, 13);
            Label27.TabIndex = 110;
            Label27.Text = "Calle donde trabaja";
            // 
            // txtIngresoPromedio
            // 
            txtIngresoPromedio.Cursor = Cursors.IBeam;
            txtIngresoPromedio.Enabled = false;
            txtIngresoPromedio.Font = new Font("Century Gothic", 9.75f);
            txtIngresoPromedio.ForeColor = Color.White;
            txtIngresoPromedio.HintForeColor = Color.White;
            txtIngresoPromedio.HintText = "";
            txtIngresoPromedio.isPassword = false;
            txtIngresoPromedio.LineFocusedColor = Color.Blue;
            txtIngresoPromedio.LineIdleColor = Color.Gray;
            txtIngresoPromedio.LineMouseHoverColor = Color.Blue;
            txtIngresoPromedio.LineThickness = 3;
            txtIngresoPromedio.Location = new Point(454, 142);
            txtIngresoPromedio.Margin = new Padding(4);
            txtIngresoPromedio.Name = "txtIngresoPromedio";
            txtIngresoPromedio.Size = new Size(183, 29);
            txtIngresoPromedio.TabIndex = 109;
            txtIngresoPromedio.TextAlign = HorizontalAlignment.Left;
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.ForeColor = Color.White;
            Label28.Location = new Point(451, 125);
            Label28.Name = "Label28";
            Label28.Size = new Size(132, 13);
            Label28.TabIndex = 108;
            Label28.Text = "Ingreso Promedio Mensual";
            // 
            // txtTipoEstablecimiento
            // 
            txtTipoEstablecimiento.Cursor = Cursors.IBeam;
            txtTipoEstablecimiento.Enabled = false;
            txtTipoEstablecimiento.Font = new Font("Century Gothic", 9.75f);
            txtTipoEstablecimiento.ForeColor = Color.White;
            txtTipoEstablecimiento.HintForeColor = Color.White;
            txtTipoEstablecimiento.HintText = "";
            txtTipoEstablecimiento.isPassword = false;
            txtTipoEstablecimiento.LineFocusedColor = Color.Blue;
            txtTipoEstablecimiento.LineIdleColor = Color.Gray;
            txtTipoEstablecimiento.LineMouseHoverColor = Color.Blue;
            txtTipoEstablecimiento.LineThickness = 3;
            txtTipoEstablecimiento.Location = new Point(247, 142);
            txtTipoEstablecimiento.Margin = new Padding(4);
            txtTipoEstablecimiento.Name = "txtTipoEstablecimiento";
            txtTipoEstablecimiento.Size = new Size(199, 29);
            txtTipoEstablecimiento.TabIndex = 107;
            txtTipoEstablecimiento.TextAlign = HorizontalAlignment.Left;
            // 
            // Label29
            // 
            Label29.AutoSize = true;
            Label29.ForeColor = Color.White;
            Label29.Location = new Point(244, 125);
            Label29.Name = "Label29";
            Label29.Size = new Size(120, 13);
            Label29.TabIndex = 106;
            Label29.Text = "Tipo de Establecimiento";
            // 
            // txtHorariosTrabajo
            // 
            txtHorariosTrabajo.Cursor = Cursors.IBeam;
            txtHorariosTrabajo.Enabled = false;
            txtHorariosTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtHorariosTrabajo.ForeColor = Color.White;
            txtHorariosTrabajo.HintForeColor = Color.White;
            txtHorariosTrabajo.HintText = "";
            txtHorariosTrabajo.isPassword = false;
            txtHorariosTrabajo.LineFocusedColor = Color.Blue;
            txtHorariosTrabajo.LineIdleColor = Color.Gray;
            txtHorariosTrabajo.LineMouseHoverColor = Color.Blue;
            txtHorariosTrabajo.LineThickness = 3;
            txtHorariosTrabajo.Location = new Point(26, 142);
            txtHorariosTrabajo.Margin = new Padding(4);
            txtHorariosTrabajo.Name = "txtHorariosTrabajo";
            txtHorariosTrabajo.Size = new Size(213, 29);
            txtHorariosTrabajo.TabIndex = 105;
            txtHorariosTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.ForeColor = Color.White;
            Label30.Location = new Point(23, 125);
            Label30.Name = "Label30";
            Label30.Size = new Size(46, 13);
            Label30.TabIndex = 104;
            Label30.Text = "Horarios";
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Cursor = Cursors.IBeam;
            txtAntiguedad.Enabled = false;
            txtAntiguedad.Font = new Font("Century Gothic", 9.75f);
            txtAntiguedad.ForeColor = Color.White;
            txtAntiguedad.HintForeColor = Color.White;
            txtAntiguedad.HintText = "";
            txtAntiguedad.isPassword = false;
            txtAntiguedad.LineFocusedColor = Color.Blue;
            txtAntiguedad.LineIdleColor = Color.Gray;
            txtAntiguedad.LineMouseHoverColor = Color.Blue;
            txtAntiguedad.LineThickness = 3;
            txtAntiguedad.Location = new Point(645, 67);
            txtAntiguedad.Margin = new Padding(4);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(210, 29);
            txtAntiguedad.TabIndex = 103;
            txtAntiguedad.TextAlign = HorizontalAlignment.Left;
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.ForeColor = Color.White;
            Label31.Location = new Point(642, 50);
            Label31.Name = "Label31";
            Label31.Size = new Size(61, 13);
            Label31.TabIndex = 102;
            Label31.Text = "Antigüedad";
            // 
            // txtVende
            // 
            txtVende.Cursor = Cursors.IBeam;
            txtVende.Enabled = false;
            txtVende.Font = new Font("Century Gothic", 9.75f);
            txtVende.ForeColor = Color.White;
            txtVende.HintForeColor = Color.White;
            txtVende.HintText = "";
            txtVende.isPassword = false;
            txtVende.LineFocusedColor = Color.Blue;
            txtVende.LineIdleColor = Color.Gray;
            txtVende.LineMouseHoverColor = Color.Blue;
            txtVende.LineThickness = 3;
            txtVende.Location = new Point(454, 67);
            txtVende.Margin = new Padding(4);
            txtVende.Name = "txtVende";
            txtVende.Size = new Size(183, 29);
            txtVende.TabIndex = 101;
            txtVende.TextAlign = HorizontalAlignment.Left;
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.ForeColor = Color.White;
            Label32.Location = new Point(451, 50);
            Label32.Name = "Label32";
            Label32.Size = new Size(163, 13);
            Label32.TabIndex = 100;
            Label32.Text = "¿Qué vende? (si es comerciante)";
            // 
            // txtSeDedica
            // 
            txtSeDedica.Cursor = Cursors.IBeam;
            txtSeDedica.Enabled = false;
            txtSeDedica.Font = new Font("Century Gothic", 9.75f);
            txtSeDedica.ForeColor = Color.White;
            txtSeDedica.HintForeColor = Color.White;
            txtSeDedica.HintText = "";
            txtSeDedica.isPassword = false;
            txtSeDedica.LineFocusedColor = Color.Blue;
            txtSeDedica.LineIdleColor = Color.Gray;
            txtSeDedica.LineMouseHoverColor = Color.Blue;
            txtSeDedica.LineThickness = 3;
            txtSeDedica.Location = new Point(247, 67);
            txtSeDedica.Margin = new Padding(4);
            txtSeDedica.Name = "txtSeDedica";
            txtSeDedica.Size = new Size(199, 29);
            txtSeDedica.TabIndex = 99;
            txtSeDedica.TextAlign = HorizontalAlignment.Left;
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.ForeColor = Color.White;
            Label33.Location = new Point(244, 50);
            Label33.Name = "Label33";
            Label33.Size = new Size(84, 13);
            Label33.TabIndex = 98;
            Label33.Text = "Usted se dedica";
            // 
            // txtNombreLugarTrabajo
            // 
            txtNombreLugarTrabajo.Cursor = Cursors.IBeam;
            txtNombreLugarTrabajo.Enabled = false;
            txtNombreLugarTrabajo.Font = new Font("Century Gothic", 9.75f);
            txtNombreLugarTrabajo.ForeColor = Color.White;
            txtNombreLugarTrabajo.HintForeColor = Color.White;
            txtNombreLugarTrabajo.HintText = "";
            txtNombreLugarTrabajo.isPassword = false;
            txtNombreLugarTrabajo.LineFocusedColor = Color.Blue;
            txtNombreLugarTrabajo.LineIdleColor = Color.Gray;
            txtNombreLugarTrabajo.LineMouseHoverColor = Color.Blue;
            txtNombreLugarTrabajo.LineThickness = 3;
            txtNombreLugarTrabajo.Location = new Point(26, 67);
            txtNombreLugarTrabajo.Margin = new Padding(4);
            txtNombreLugarTrabajo.Name = "txtNombreLugarTrabajo";
            txtNombreLugarTrabajo.Size = new Size(213, 29);
            txtNombreLugarTrabajo.TabIndex = 97;
            txtNombreLugarTrabajo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.ForeColor = Color.White;
            Label34.Location = new Point(23, 50);
            Label34.Name = "Label34";
            Label34.Size = new Size(155, 13);
            Label34.TabIndex = 96;
            Label34.Text = "Nombre del lugar donde trabaja";
            // 
            // TabPage3
            // 
            TabPage3.BackColor = Color.FromArgb(0, 5, 11);
            TabPage3.Controls.Add(GroupBox3);
            TabPage3.Controls.Add(GroupBox2);
            TabPage3.Controls.Add(txtRelacionR2);
            TabPage3.Controls.Add(Label18);
            TabPage3.Controls.Add(txtTelefonoR2);
            TabPage3.Controls.Add(Label19);
            TabPage3.Controls.Add(txtNombreR2);
            TabPage3.Controls.Add(Label20);
            TabPage3.Controls.Add(MonoFlat_HeaderLabel3);
            TabPage3.Controls.Add(MonoFlat_HeaderLabel2);
            TabPage3.Controls.Add(MonoFlat_Separator1);
            TabPage3.Controls.Add(txtRelacionR1);
            TabPage3.Controls.Add(Label41);
            TabPage3.Controls.Add(txtTelefonoR1);
            TabPage3.Controls.Add(Label42);
            TabPage3.Controls.Add(txtNombreR1);
            TabPage3.Controls.Add(Label43);
            TabPage3.Location = new Point(4, 22);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(1133, 558);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Referencias";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(txtColoniaR2);
            GroupBox3.Controls.Add(txtNoIntR2);
            GroupBox3.Controls.Add(Label62);
            GroupBox3.Controls.Add(txtNoExtR2);
            GroupBox3.Controls.Add(Label63);
            GroupBox3.Controls.Add(txtCalleR2);
            GroupBox3.Controls.Add(Label64);
            GroupBox3.Controls.Add(txtCodigoPostalR2);
            GroupBox3.Controls.Add(Label65);
            GroupBox3.Controls.Add(Label66);
            GroupBox3.ForeColor = SystemColors.ButtonHighlight;
            GroupBox3.Location = new Point(27, 347);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(1050, 100);
            GroupBox3.TabIndex = 148;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Dirección";
            // 
            // txtColoniaR2
            // 
            txtColoniaR2.Cursor = Cursors.IBeam;
            txtColoniaR2.Enabled = false;
            txtColoniaR2.Font = new Font("Century Gothic", 9.75f);
            txtColoniaR2.ForeColor = Color.White;
            txtColoniaR2.HintForeColor = Color.White;
            txtColoniaR2.HintText = "";
            txtColoniaR2.isPassword = false;
            txtColoniaR2.LineFocusedColor = Color.Blue;
            txtColoniaR2.LineIdleColor = Color.Gray;
            txtColoniaR2.LineMouseHoverColor = Color.Blue;
            txtColoniaR2.LineThickness = 3;
            txtColoniaR2.Location = new Point(128, 36);
            txtColoniaR2.Margin = new Padding(4);
            txtColoniaR2.Name = "txtColoniaR2";
            txtColoniaR2.Size = new Size(226, 35);
            txtColoniaR2.TabIndex = 145;
            txtColoniaR2.TextAlign = HorizontalAlignment.Left;
            // 
            // txtNoIntR2
            // 
            txtNoIntR2.Cursor = Cursors.IBeam;
            txtNoIntR2.Enabled = false;
            txtNoIntR2.Font = new Font("Century Gothic", 9.75f);
            txtNoIntR2.ForeColor = Color.White;
            txtNoIntR2.HintForeColor = Color.White;
            txtNoIntR2.HintText = "";
            txtNoIntR2.isPassword = false;
            txtNoIntR2.LineFocusedColor = Color.Blue;
            txtNoIntR2.LineIdleColor = Color.Gray;
            txtNoIntR2.LineMouseHoverColor = Color.Blue;
            txtNoIntR2.LineThickness = 3;
            txtNoIntR2.Location = new Point(647, 42);
            txtNoIntR2.Margin = new Padding(4);
            txtNoIntR2.Name = "txtNoIntR2";
            txtNoIntR2.Size = new Size(102, 29);
            txtNoIntR2.TabIndex = 141;
            txtNoIntR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label62
            // 
            Label62.AutoSize = true;
            Label62.ForeColor = Color.White;
            Label62.Location = new Point(644, 25);
            Label62.Name = "Label62";
            Label62.Size = new Size(58, 13);
            Label62.TabIndex = 144;
            Label62.Text = "No. interior";
            // 
            // txtNoExtR2
            // 
            txtNoExtR2.Cursor = Cursors.IBeam;
            txtNoExtR2.Enabled = false;
            txtNoExtR2.Font = new Font("Century Gothic", 9.75f);
            txtNoExtR2.ForeColor = Color.White;
            txtNoExtR2.HintForeColor = Color.White;
            txtNoExtR2.HintText = "";
            txtNoExtR2.isPassword = false;
            txtNoExtR2.LineFocusedColor = Color.Blue;
            txtNoExtR2.LineIdleColor = Color.Gray;
            txtNoExtR2.LineMouseHoverColor = Color.Blue;
            txtNoExtR2.LineThickness = 3;
            txtNoExtR2.Location = new Point(773, 42);
            txtNoExtR2.Margin = new Padding(4);
            txtNoExtR2.Name = "txtNoExtR2";
            txtNoExtR2.Size = new Size(93, 29);
            txtNoExtR2.TabIndex = 140;
            txtNoExtR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label63
            // 
            Label63.AutoSize = true;
            Label63.ForeColor = Color.White;
            Label63.Location = new Point(770, 25);
            Label63.Name = "Label63";
            Label63.Size = new Size(61, 13);
            Label63.TabIndex = 143;
            Label63.Text = "No. exterior";
            // 
            // txtCalleR2
            // 
            txtCalleR2.Cursor = Cursors.IBeam;
            txtCalleR2.Enabled = false;
            txtCalleR2.Font = new Font("Century Gothic", 9.75f);
            txtCalleR2.ForeColor = Color.White;
            txtCalleR2.HintForeColor = Color.White;
            txtCalleR2.HintText = "";
            txtCalleR2.isPassword = false;
            txtCalleR2.LineFocusedColor = Color.Blue;
            txtCalleR2.LineIdleColor = Color.Gray;
            txtCalleR2.LineMouseHoverColor = Color.Blue;
            txtCalleR2.LineThickness = 3;
            txtCalleR2.Location = new Point(383, 42);
            txtCalleR2.Margin = new Padding(4);
            txtCalleR2.Name = "txtCalleR2";
            txtCalleR2.Size = new Size(214, 29);
            txtCalleR2.TabIndex = 139;
            txtCalleR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label64
            // 
            Label64.AutoSize = true;
            Label64.ForeColor = Color.White;
            Label64.Location = new Point(380, 25);
            Label64.Name = "Label64";
            Label64.Size = new Size(30, 13);
            Label64.TabIndex = 142;
            Label64.Text = "Calle";
            // 
            // txtCodigoPostalR2
            // 
            txtCodigoPostalR2.Cursor = Cursors.IBeam;
            txtCodigoPostalR2.Enabled = false;
            txtCodigoPostalR2.Font = new Font("Century Gothic", 9.75f);
            txtCodigoPostalR2.ForeColor = Color.White;
            txtCodigoPostalR2.HintForeColor = Color.White;
            txtCodigoPostalR2.HintText = "";
            txtCodigoPostalR2.isPassword = false;
            txtCodigoPostalR2.LineFocusedColor = Color.Blue;
            txtCodigoPostalR2.LineIdleColor = Color.Gray;
            txtCodigoPostalR2.LineMouseHoverColor = Color.Blue;
            txtCodigoPostalR2.LineThickness = 3;
            txtCodigoPostalR2.Location = new Point(7, 42);
            txtCodigoPostalR2.Margin = new Padding(4);
            txtCodigoPostalR2.Name = "txtCodigoPostalR2";
            txtCodigoPostalR2.Size = new Size(89, 29);
            txtCodigoPostalR2.TabIndex = 135;
            txtCodigoPostalR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label65
            // 
            Label65.AutoSize = true;
            Label65.ForeColor = Color.White;
            Label65.Location = new Point(4, 25);
            Label65.Name = "Label65";
            Label65.Size = new Size(72, 13);
            Label65.TabIndex = 136;
            Label65.Text = "Código Postal";
            // 
            // Label66
            // 
            Label66.AutoSize = true;
            Label66.ForeColor = Color.White;
            Label66.Location = new Point(125, 25);
            Label66.Name = "Label66";
            Label66.Size = new Size(42, 13);
            Label66.TabIndex = 137;
            Label66.Text = "Colonia";
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(txtColoniaR1);
            GroupBox2.Controls.Add(txtNoIntR1);
            GroupBox2.Controls.Add(Label57);
            GroupBox2.Controls.Add(txtNoExtR1);
            GroupBox2.Controls.Add(Label58);
            GroupBox2.Controls.Add(txtCalleR1);
            GroupBox2.Controls.Add(Label59);
            GroupBox2.Controls.Add(txtCodigoPostalR1);
            GroupBox2.Controls.Add(Label60);
            GroupBox2.Controls.Add(Label61);
            GroupBox2.ForeColor = SystemColors.ButtonHighlight;
            GroupBox2.Location = new Point(27, 115);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(1050, 100);
            GroupBox2.TabIndex = 142;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Dirección";
            // 
            // txtColoniaR1
            // 
            txtColoniaR1.Cursor = Cursors.IBeam;
            txtColoniaR1.Enabled = false;
            txtColoniaR1.Font = new Font("Century Gothic", 9.75f);
            txtColoniaR1.ForeColor = Color.White;
            txtColoniaR1.HintForeColor = Color.White;
            txtColoniaR1.HintText = "";
            txtColoniaR1.isPassword = false;
            txtColoniaR1.LineFocusedColor = Color.Blue;
            txtColoniaR1.LineIdleColor = Color.Gray;
            txtColoniaR1.LineMouseHoverColor = Color.Blue;
            txtColoniaR1.LineThickness = 3;
            txtColoniaR1.Location = new Point(128, 42);
            txtColoniaR1.Margin = new Padding(4);
            txtColoniaR1.Name = "txtColoniaR1";
            txtColoniaR1.Size = new Size(226, 29);
            txtColoniaR1.TabIndex = 145;
            txtColoniaR1.TextAlign = HorizontalAlignment.Left;
            // 
            // txtNoIntR1
            // 
            txtNoIntR1.Cursor = Cursors.IBeam;
            txtNoIntR1.Enabled = false;
            txtNoIntR1.Font = new Font("Century Gothic", 9.75f);
            txtNoIntR1.ForeColor = Color.White;
            txtNoIntR1.HintForeColor = Color.White;
            txtNoIntR1.HintText = "";
            txtNoIntR1.isPassword = false;
            txtNoIntR1.LineFocusedColor = Color.Blue;
            txtNoIntR1.LineIdleColor = Color.Gray;
            txtNoIntR1.LineMouseHoverColor = Color.Blue;
            txtNoIntR1.LineThickness = 3;
            txtNoIntR1.Location = new Point(647, 42);
            txtNoIntR1.Margin = new Padding(4);
            txtNoIntR1.Name = "txtNoIntR1";
            txtNoIntR1.Size = new Size(102, 29);
            txtNoIntR1.TabIndex = 141;
            txtNoIntR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label57
            // 
            Label57.AutoSize = true;
            Label57.ForeColor = Color.White;
            Label57.Location = new Point(644, 25);
            Label57.Name = "Label57";
            Label57.Size = new Size(58, 13);
            Label57.TabIndex = 144;
            Label57.Text = "No. interior";
            // 
            // txtNoExtR1
            // 
            txtNoExtR1.Cursor = Cursors.IBeam;
            txtNoExtR1.Enabled = false;
            txtNoExtR1.Font = new Font("Century Gothic", 9.75f);
            txtNoExtR1.ForeColor = Color.White;
            txtNoExtR1.HintForeColor = Color.White;
            txtNoExtR1.HintText = "";
            txtNoExtR1.isPassword = false;
            txtNoExtR1.LineFocusedColor = Color.Blue;
            txtNoExtR1.LineIdleColor = Color.Gray;
            txtNoExtR1.LineMouseHoverColor = Color.Blue;
            txtNoExtR1.LineThickness = 3;
            txtNoExtR1.Location = new Point(773, 42);
            txtNoExtR1.Margin = new Padding(4);
            txtNoExtR1.Name = "txtNoExtR1";
            txtNoExtR1.Size = new Size(93, 29);
            txtNoExtR1.TabIndex = 140;
            txtNoExtR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label58
            // 
            Label58.AutoSize = true;
            Label58.ForeColor = Color.White;
            Label58.Location = new Point(770, 25);
            Label58.Name = "Label58";
            Label58.Size = new Size(61, 13);
            Label58.TabIndex = 143;
            Label58.Text = "No. exterior";
            // 
            // txtCalleR1
            // 
            txtCalleR1.Cursor = Cursors.IBeam;
            txtCalleR1.Enabled = false;
            txtCalleR1.Font = new Font("Century Gothic", 9.75f);
            txtCalleR1.ForeColor = Color.White;
            txtCalleR1.HintForeColor = Color.White;
            txtCalleR1.HintText = "";
            txtCalleR1.isPassword = false;
            txtCalleR1.LineFocusedColor = Color.Blue;
            txtCalleR1.LineIdleColor = Color.Gray;
            txtCalleR1.LineMouseHoverColor = Color.Blue;
            txtCalleR1.LineThickness = 3;
            txtCalleR1.Location = new Point(383, 42);
            txtCalleR1.Margin = new Padding(4);
            txtCalleR1.Name = "txtCalleR1";
            txtCalleR1.Size = new Size(214, 29);
            txtCalleR1.TabIndex = 139;
            txtCalleR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label59
            // 
            Label59.AutoSize = true;
            Label59.ForeColor = Color.White;
            Label59.Location = new Point(380, 25);
            Label59.Name = "Label59";
            Label59.Size = new Size(30, 13);
            Label59.TabIndex = 142;
            Label59.Text = "Calle";
            // 
            // txtCodigoPostalR1
            // 
            txtCodigoPostalR1.Cursor = Cursors.IBeam;
            txtCodigoPostalR1.Enabled = false;
            txtCodigoPostalR1.Font = new Font("Century Gothic", 9.75f);
            txtCodigoPostalR1.ForeColor = Color.White;
            txtCodigoPostalR1.HintForeColor = Color.White;
            txtCodigoPostalR1.HintText = "";
            txtCodigoPostalR1.isPassword = false;
            txtCodigoPostalR1.LineFocusedColor = Color.Blue;
            txtCodigoPostalR1.LineIdleColor = Color.Gray;
            txtCodigoPostalR1.LineMouseHoverColor = Color.Blue;
            txtCodigoPostalR1.LineThickness = 3;
            txtCodigoPostalR1.Location = new Point(7, 42);
            txtCodigoPostalR1.Margin = new Padding(4);
            txtCodigoPostalR1.Name = "txtCodigoPostalR1";
            txtCodigoPostalR1.Size = new Size(89, 29);
            txtCodigoPostalR1.TabIndex = 135;
            txtCodigoPostalR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label60
            // 
            Label60.AutoSize = true;
            Label60.ForeColor = Color.White;
            Label60.Location = new Point(4, 25);
            Label60.Name = "Label60";
            Label60.Size = new Size(72, 13);
            Label60.TabIndex = 136;
            Label60.Text = "Código Postal";
            // 
            // Label61
            // 
            Label61.AutoSize = true;
            Label61.ForeColor = Color.White;
            Label61.Location = new Point(125, 25);
            Label61.Name = "Label61";
            Label61.Size = new Size(42, 13);
            Label61.TabIndex = 137;
            Label61.Text = "Colonia";
            // 
            // txtRelacionR2
            // 
            txtRelacionR2.Cursor = Cursors.IBeam;
            txtRelacionR2.Enabled = false;
            txtRelacionR2.Font = new Font("Century Gothic", 9.75f);
            txtRelacionR2.ForeColor = Color.White;
            txtRelacionR2.HintForeColor = Color.White;
            txtRelacionR2.HintText = "";
            txtRelacionR2.isPassword = false;
            txtRelacionR2.LineFocusedColor = Color.Blue;
            txtRelacionR2.LineIdleColor = Color.Gray;
            txtRelacionR2.LineMouseHoverColor = Color.Blue;
            txtRelacionR2.LineThickness = 3;
            txtRelacionR2.Location = new Point(455, 298);
            txtRelacionR2.Margin = new Padding(4);
            txtRelacionR2.Name = "txtRelacionR2";
            txtRelacionR2.Size = new Size(204, 29);
            txtRelacionR2.TabIndex = 135;
            txtRelacionR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.ForeColor = Color.White;
            Label18.Location = new Point(452, 281);
            Label18.Name = "Label18";
            Label18.Size = new Size(49, 13);
            Label18.TabIndex = 134;
            Label18.Text = "Relación";
            // 
            // txtTelefonoR2
            // 
            txtTelefonoR2.Cursor = Cursors.IBeam;
            txtTelefonoR2.Enabled = false;
            txtTelefonoR2.Font = new Font("Century Gothic", 9.75f);
            txtTelefonoR2.ForeColor = Color.White;
            txtTelefonoR2.HintForeColor = Color.White;
            txtTelefonoR2.HintText = "";
            txtTelefonoR2.isPassword = false;
            txtTelefonoR2.LineFocusedColor = Color.Blue;
            txtTelefonoR2.LineIdleColor = Color.Gray;
            txtTelefonoR2.LineMouseHoverColor = Color.Blue;
            txtTelefonoR2.LineThickness = 3;
            txtTelefonoR2.Location = new Point(248, 298);
            txtTelefonoR2.Margin = new Padding(4);
            txtTelefonoR2.Name = "txtTelefonoR2";
            txtTelefonoR2.Size = new Size(199, 29);
            txtTelefonoR2.TabIndex = 133;
            txtTelefonoR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.ForeColor = Color.White;
            Label19.Location = new Point(245, 281);
            Label19.Name = "Label19";
            Label19.Size = new Size(49, 13);
            Label19.TabIndex = 132;
            Label19.Text = "Teléfono";
            // 
            // txtNombreR2
            // 
            txtNombreR2.Cursor = Cursors.IBeam;
            txtNombreR2.Enabled = false;
            txtNombreR2.Font = new Font("Century Gothic", 9.75f);
            txtNombreR2.ForeColor = Color.White;
            txtNombreR2.HintForeColor = Color.White;
            txtNombreR2.HintText = "";
            txtNombreR2.isPassword = false;
            txtNombreR2.LineFocusedColor = Color.Blue;
            txtNombreR2.LineIdleColor = Color.Gray;
            txtNombreR2.LineMouseHoverColor = Color.Blue;
            txtNombreR2.LineThickness = 3;
            txtNombreR2.Location = new Point(27, 298);
            txtNombreR2.Margin = new Padding(4);
            txtNombreR2.Name = "txtNombreR2";
            txtNombreR2.Size = new Size(213, 29);
            txtNombreR2.TabIndex = 131;
            txtNombreR2.TextAlign = HorizontalAlignment.Left;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.ForeColor = Color.White;
            Label20.Location = new Point(24, 281);
            Label20.Name = "Label20";
            Label20.Size = new Size(44, 13);
            Label20.TabIndex = 130;
            Label20.Text = "Nombre";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(23, 242);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(96, 20);
            MonoFlat_HeaderLabel3.TabIndex = 129;
            MonoFlat_HeaderLabel3.Text = "Referencia 2";
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(23, 15);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(96, 20);
            MonoFlat_HeaderLabel2.TabIndex = 32;
            MonoFlat_HeaderLabel2.Text = "Referencia 1";
            // 
            // MonoFlat_Separator1
            // 
            MonoFlat_Separator1.Location = new Point(3, 221);
            MonoFlat_Separator1.Name = "MonoFlat_Separator1";
            MonoFlat_Separator1.Size = new Size(1124, 10);
            MonoFlat_Separator1.TabIndex = 128;
            MonoFlat_Separator1.Text = "MonoFlat_Separator1";
            // 
            // txtRelacionR1
            // 
            txtRelacionR1.Cursor = Cursors.IBeam;
            txtRelacionR1.Enabled = false;
            txtRelacionR1.Font = new Font("Century Gothic", 9.75f);
            txtRelacionR1.ForeColor = Color.White;
            txtRelacionR1.HintForeColor = Color.White;
            txtRelacionR1.HintText = "";
            txtRelacionR1.isPassword = false;
            txtRelacionR1.LineFocusedColor = Color.Blue;
            txtRelacionR1.LineIdleColor = Color.Gray;
            txtRelacionR1.LineMouseHoverColor = Color.Blue;
            txtRelacionR1.LineThickness = 3;
            txtRelacionR1.Location = new Point(455, 79);
            txtRelacionR1.Margin = new Padding(4);
            txtRelacionR1.Name = "txtRelacionR1";
            txtRelacionR1.Size = new Size(204, 29);
            txtRelacionR1.TabIndex = 127;
            txtRelacionR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label41
            // 
            Label41.AutoSize = true;
            Label41.ForeColor = Color.White;
            Label41.Location = new Point(452, 62);
            Label41.Name = "Label41";
            Label41.Size = new Size(49, 13);
            Label41.TabIndex = 126;
            Label41.Text = "Relación";
            // 
            // txtTelefonoR1
            // 
            txtTelefonoR1.Cursor = Cursors.IBeam;
            txtTelefonoR1.Enabled = false;
            txtTelefonoR1.Font = new Font("Century Gothic", 9.75f);
            txtTelefonoR1.ForeColor = Color.White;
            txtTelefonoR1.HintForeColor = Color.White;
            txtTelefonoR1.HintText = "";
            txtTelefonoR1.isPassword = false;
            txtTelefonoR1.LineFocusedColor = Color.Blue;
            txtTelefonoR1.LineIdleColor = Color.Gray;
            txtTelefonoR1.LineMouseHoverColor = Color.Blue;
            txtTelefonoR1.LineThickness = 3;
            txtTelefonoR1.Location = new Point(248, 79);
            txtTelefonoR1.Margin = new Padding(4);
            txtTelefonoR1.Name = "txtTelefonoR1";
            txtTelefonoR1.Size = new Size(199, 29);
            txtTelefonoR1.TabIndex = 125;
            txtTelefonoR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label42
            // 
            Label42.AutoSize = true;
            Label42.ForeColor = Color.White;
            Label42.Location = new Point(245, 62);
            Label42.Name = "Label42";
            Label42.Size = new Size(49, 13);
            Label42.TabIndex = 124;
            Label42.Text = "Teléfono";
            // 
            // txtNombreR1
            // 
            txtNombreR1.Cursor = Cursors.IBeam;
            txtNombreR1.Enabled = false;
            txtNombreR1.Font = new Font("Century Gothic", 9.75f);
            txtNombreR1.ForeColor = Color.White;
            txtNombreR1.HintForeColor = Color.White;
            txtNombreR1.HintText = "";
            txtNombreR1.isPassword = false;
            txtNombreR1.LineFocusedColor = Color.Blue;
            txtNombreR1.LineIdleColor = Color.Gray;
            txtNombreR1.LineMouseHoverColor = Color.Blue;
            txtNombreR1.LineThickness = 3;
            txtNombreR1.Location = new Point(27, 79);
            txtNombreR1.Margin = new Padding(4);
            txtNombreR1.Name = "txtNombreR1";
            txtNombreR1.Size = new Size(213, 29);
            txtNombreR1.TabIndex = 123;
            txtNombreR1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label43
            // 
            Label43.AutoSize = true;
            Label43.ForeColor = Color.White;
            Label43.Location = new Point(24, 62);
            Label43.Name = "Label43";
            Label43.Size = new Size(44, 13);
            Label43.TabIndex = 122;
            Label43.Text = "Nombre";
            // 
            // TabPage4
            // 
            TabPage4.BackColor = Color.FromArgb(0, 5, 11);
            TabPage4.Controls.Add(txtFrecuenciaInversion);
            TabPage4.Controls.Add(Label40);
            TabPage4.Controls.Add(txtEmpleados);
            TabPage4.Controls.Add(Label44);
            TabPage4.Controls.Add(txtPersonasDependientes);
            TabPage4.Controls.Add(Label45);
            TabPage4.Controls.Add(txtServicios);
            TabPage4.Controls.Add(Label46);
            TabPage4.Controls.Add(txtDeudas);
            TabPage4.Controls.Add(Label47);
            TabPage4.Controls.Add(txtFamiliasEnCasa);
            TabPage4.Controls.Add(Label48);
            TabPage4.Controls.Add(txtEnfermedad);
            TabPage4.Controls.Add(Label49);
            TabPage4.Location = new Point(4, 22);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(1133, 558);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "Otros";
            // 
            // txtFrecuenciaInversion
            // 
            txtFrecuenciaInversion.Cursor = Cursors.IBeam;
            txtFrecuenciaInversion.Enabled = false;
            txtFrecuenciaInversion.Font = new Font("Century Gothic", 9.75f);
            txtFrecuenciaInversion.ForeColor = Color.White;
            txtFrecuenciaInversion.HintForeColor = Color.White;
            txtFrecuenciaInversion.HintText = "";
            txtFrecuenciaInversion.isPassword = false;
            txtFrecuenciaInversion.LineFocusedColor = Color.Blue;
            txtFrecuenciaInversion.LineIdleColor = Color.Gray;
            txtFrecuenciaInversion.LineMouseHoverColor = Color.Blue;
            txtFrecuenciaInversion.LineThickness = 3;
            txtFrecuenciaInversion.Location = new Point(454, 115);
            txtFrecuenciaInversion.Margin = new Padding(4);
            txtFrecuenciaInversion.Name = "txtFrecuenciaInversion";
            txtFrecuenciaInversion.Size = new Size(217, 29);
            txtFrecuenciaInversion.TabIndex = 135;
            txtFrecuenciaInversion.TextAlign = HorizontalAlignment.Left;
            // 
            // Label40
            // 
            Label40.AutoSize = true;
            Label40.ForeColor = Color.White;
            Label40.Location = new Point(451, 98);
            Label40.Name = "Label40";
            Label40.Size = new Size(314, 13);
            Label40.TabIndex = 134;
            Label40.Text = "Frecuencia de invesión en su negocio (Solo en caso de ser APC)";
            // 
            // txtEmpleados
            // 
            txtEmpleados.Cursor = Cursors.IBeam;
            txtEmpleados.Enabled = false;
            txtEmpleados.Font = new Font("Century Gothic", 9.75f);
            txtEmpleados.ForeColor = Color.White;
            txtEmpleados.HintForeColor = Color.White;
            txtEmpleados.HintText = "";
            txtEmpleados.isPassword = false;
            txtEmpleados.LineFocusedColor = Color.Blue;
            txtEmpleados.LineIdleColor = Color.Gray;
            txtEmpleados.LineMouseHoverColor = Color.Blue;
            txtEmpleados.LineThickness = 3;
            txtEmpleados.Location = new Point(247, 115);
            txtEmpleados.Margin = new Padding(4);
            txtEmpleados.Name = "txtEmpleados";
            txtEmpleados.Size = new Size(183, 29);
            txtEmpleados.TabIndex = 133;
            txtEmpleados.TextAlign = HorizontalAlignment.Left;
            // 
            // Label44
            // 
            Label44.AutoSize = true;
            Label44.ForeColor = Color.White;
            Label44.Location = new Point(244, 98);
            Label44.Name = "Label44";
            Label44.Size = new Size(186, 13);
            Label44.TabIndex = 132;
            Label44.Text = "Empleados (Sólo en caso de ser APC)";
            // 
            // txtPersonasDependientes
            // 
            txtPersonasDependientes.Cursor = Cursors.IBeam;
            txtPersonasDependientes.Enabled = false;
            txtPersonasDependientes.Font = new Font("Century Gothic", 9.75f);
            txtPersonasDependientes.ForeColor = Color.White;
            txtPersonasDependientes.HintForeColor = Color.White;
            txtPersonasDependientes.HintText = "";
            txtPersonasDependientes.isPassword = false;
            txtPersonasDependientes.LineFocusedColor = Color.Blue;
            txtPersonasDependientes.LineIdleColor = Color.Gray;
            txtPersonasDependientes.LineMouseHoverColor = Color.Blue;
            txtPersonasDependientes.LineThickness = 3;
            txtPersonasDependientes.Location = new Point(26, 115);
            txtPersonasDependientes.Margin = new Padding(4);
            txtPersonasDependientes.Name = "txtPersonasDependientes";
            txtPersonasDependientes.Size = new Size(201, 29);
            txtPersonasDependientes.TabIndex = 131;
            txtPersonasDependientes.TextAlign = HorizontalAlignment.Left;
            // 
            // Label45
            // 
            Label45.AutoSize = true;
            Label45.ForeColor = Color.White;
            Label45.Location = new Point(23, 98);
            Label45.Name = "Label45";
            Label45.Size = new Size(185, 13);
            Label45.TabIndex = 130;
            Label45.Text = "Personas dependientes del solicitante";
            // 
            // txtServicios
            // 
            txtServicios.Cursor = Cursors.IBeam;
            txtServicios.Enabled = false;
            txtServicios.Font = new Font("Century Gothic", 9.75f);
            txtServicios.ForeColor = Color.White;
            txtServicios.HintForeColor = Color.White;
            txtServicios.HintText = "";
            txtServicios.isPassword = false;
            txtServicios.LineFocusedColor = Color.Blue;
            txtServicios.LineIdleColor = Color.Gray;
            txtServicios.LineMouseHoverColor = Color.Blue;
            txtServicios.LineThickness = 3;
            txtServicios.Location = new Point(752, 40);
            txtServicios.Margin = new Padding(4);
            txtServicios.Name = "txtServicios";
            txtServicios.Size = new Size(374, 29);
            txtServicios.TabIndex = 129;
            txtServicios.TextAlign = HorizontalAlignment.Left;
            // 
            // Label46
            // 
            Label46.AutoSize = true;
            Label46.ForeColor = Color.White;
            Label46.Location = new Point(749, 23);
            Label46.Name = "Label46";
            Label46.Size = new Size(216, 13);
            Label46.TabIndex = 128;
            Label46.Text = "Servicios con los que cuenta en su domicilio";
            // 
            // txtDeudas
            // 
            txtDeudas.Cursor = Cursors.IBeam;
            txtDeudas.Enabled = false;
            txtDeudas.Font = new Font("Century Gothic", 9.75f);
            txtDeudas.ForeColor = Color.White;
            txtDeudas.HintForeColor = Color.White;
            txtDeudas.HintText = "";
            txtDeudas.isPassword = false;
            txtDeudas.LineFocusedColor = Color.Blue;
            txtDeudas.LineIdleColor = Color.Gray;
            txtDeudas.LineMouseHoverColor = Color.Blue;
            txtDeudas.LineThickness = 3;
            txtDeudas.Location = new Point(519, 40);
            txtDeudas.Margin = new Padding(4);
            txtDeudas.Name = "txtDeudas";
            txtDeudas.Size = new Size(217, 29);
            txtDeudas.TabIndex = 127;
            txtDeudas.TextAlign = HorizontalAlignment.Left;
            // 
            // Label47
            // 
            Label47.AutoSize = true;
            Label47.ForeColor = Color.White;
            Label47.Location = new Point(516, 23);
            Label47.Name = "Label47";
            Label47.Size = new Size(220, 13);
            Label47.TabIndex = 126;
            Label47.Text = "¿Tiene más deudas? (Especifique con quién)";
            // 
            // txtFamiliasEnCasa
            // 
            txtFamiliasEnCasa.Cursor = Cursors.IBeam;
            txtFamiliasEnCasa.Enabled = false;
            txtFamiliasEnCasa.Font = new Font("Century Gothic", 9.75f);
            txtFamiliasEnCasa.ForeColor = Color.White;
            txtFamiliasEnCasa.HintForeColor = Color.White;
            txtFamiliasEnCasa.HintText = "";
            txtFamiliasEnCasa.isPassword = false;
            txtFamiliasEnCasa.LineFocusedColor = Color.Blue;
            txtFamiliasEnCasa.LineIdleColor = Color.Gray;
            txtFamiliasEnCasa.LineMouseHoverColor = Color.Blue;
            txtFamiliasEnCasa.LineThickness = 3;
            txtFamiliasEnCasa.Location = new Point(312, 40);
            txtFamiliasEnCasa.Margin = new Padding(4);
            txtFamiliasEnCasa.Name = "txtFamiliasEnCasa";
            txtFamiliasEnCasa.Size = new Size(189, 29);
            txtFamiliasEnCasa.TabIndex = 125;
            txtFamiliasEnCasa.TextAlign = HorizontalAlignment.Left;
            // 
            // Label48
            // 
            Label48.AutoSize = true;
            Label48.ForeColor = Color.White;
            Label48.Location = new Point(309, 23);
            Label48.Name = "Label48";
            Label48.Size = new Size(179, 13);
            Label48.TabIndex = 124;
            Label48.Text = "¿Cuántas familias viven en su casa?";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Cursor = Cursors.IBeam;
            txtEnfermedad.Enabled = false;
            txtEnfermedad.Font = new Font("Century Gothic", 9.75f);
            txtEnfermedad.ForeColor = Color.White;
            txtEnfermedad.HintForeColor = Color.White;
            txtEnfermedad.HintText = "";
            txtEnfermedad.isPassword = false;
            txtEnfermedad.LineFocusedColor = Color.Blue;
            txtEnfermedad.LineIdleColor = Color.Gray;
            txtEnfermedad.LineMouseHoverColor = Color.Blue;
            txtEnfermedad.LineThickness = 3;
            txtEnfermedad.Location = new Point(26, 39);
            txtEnfermedad.Margin = new Padding(4);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(246, 29);
            txtEnfermedad.TabIndex = 123;
            txtEnfermedad.TextAlign = HorizontalAlignment.Left;
            // 
            // Label49
            // 
            Label49.AutoSize = true;
            Label49.ForeColor = Color.White;
            Label49.Location = new Point(23, 22);
            Label49.Name = "Label49";
            Label49.Size = new Size(275, 13);
            Label49.TabIndex = 122;
            Label49.Text = "¿Padece alguna enfermedad crónica? (Especifique cuál)";
            // 
            // TabPage5
            // 
            TabPage5.BackColor = Color.FromArgb(0, 5, 11);
            TabPage5.Controls.Add(Label39);
            TabPage5.Controls.Add(txtMontoAutorizado);
            TabPage5.Controls.Add(txtComentarios);
            TabPage5.Controls.Add(Label50);
            TabPage5.Controls.Add(Label54);
            TabPage5.Controls.Add(txtComentariosVerificacion);
            TabPage5.Controls.Add(txtMontoVerificacion);
            TabPage5.Controls.Add(Label53);
            TabPage5.Controls.Add(txtMontoSolicitado);
            TabPage5.Controls.Add(Label52);
            TabPage5.Controls.Add(dtdatosDocumentos);
            TabPage5.Controls.Add(Label21);
            TabPage5.Controls.Add(txtObservacionesDomicilio);
            TabPage5.Controls.Add(txtHorarioVerificacion);
            TabPage5.Controls.Add(Label55);
            TabPage5.Controls.Add(Label56);
            TabPage5.Location = new Point(4, 22);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(1133, 558);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "Verificación";
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.ForeColor = Color.White;
            Label39.Location = new Point(18, 289);
            Label39.Name = "Label39";
            Label39.Size = new Size(65, 13);
            Label39.TabIndex = 155;
            Label39.Text = "Comentarios";
            // 
            // txtMontoAutorizado
            // 
            txtMontoAutorizado.Cursor = Cursors.IBeam;
            txtMontoAutorizado.Enabled = false;
            txtMontoAutorizado.Font = new Font("Century Gothic", 9.75f);
            txtMontoAutorizado.ForeColor = Color.White;
            txtMontoAutorizado.HintForeColor = Color.White;
            txtMontoAutorizado.HintText = "";
            txtMontoAutorizado.isPassword = false;
            txtMontoAutorizado.LineFocusedColor = Color.Blue;
            txtMontoAutorizado.LineIdleColor = Color.Gray;
            txtMontoAutorizado.LineMouseHoverColor = Color.Blue;
            txtMontoAutorizado.LineThickness = 3;
            txtMontoAutorizado.Location = new Point(271, 263);
            txtMontoAutorizado.Margin = new Padding(4);
            txtMontoAutorizado.Name = "txtMontoAutorizado";
            txtMontoAutorizado.Size = new Size(101, 29);
            txtMontoAutorizado.TabIndex = 155;
            txtMontoAutorizado.TextAlign = HorizontalAlignment.Left;
            // 
            // txtComentarios
            // 
            txtComentarios.Enabled = false;
            txtComentarios.Location = new Point(21, 315);
            txtComentarios.Multiline = true;
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(222, 113);
            txtComentarios.TabIndex = 154;
            // 
            // Label50
            // 
            Label50.AutoSize = true;
            Label50.ForeColor = Color.White;
            Label50.Location = new Point(268, 246);
            Label50.Name = "Label50";
            Label50.Size = new Size(115, 13);
            Label50.TabIndex = 154;
            Label50.Text = "Monto Autorizado Final";
            // 
            // Label54
            // 
            Label54.AutoSize = true;
            Label54.ForeColor = Color.White;
            Label54.Location = new Point(18, 148);
            Label54.Name = "Label54";
            Label54.Size = new Size(95, 13);
            Label54.TabIndex = 162;
            Label54.Text = "Comentarios V Y C";
            // 
            // txtComentariosVerificacion
            // 
            txtComentariosVerificacion.Enabled = false;
            txtComentariosVerificacion.Location = new Point(21, 170);
            txtComentariosVerificacion.Multiline = true;
            txtComentariosVerificacion.Name = "txtComentariosVerificacion";
            txtComentariosVerificacion.Size = new Size(222, 97);
            txtComentariosVerificacion.TabIndex = 160;
            // 
            // txtMontoVerificacion
            // 
            txtMontoVerificacion.Cursor = Cursors.IBeam;
            txtMontoVerificacion.Enabled = false;
            txtMontoVerificacion.Font = new Font("Century Gothic", 9.75f);
            txtMontoVerificacion.ForeColor = Color.White;
            txtMontoVerificacion.HintForeColor = Color.White;
            txtMontoVerificacion.HintText = "";
            txtMontoVerificacion.isPassword = false;
            txtMontoVerificacion.LineFocusedColor = Color.Blue;
            txtMontoVerificacion.LineIdleColor = Color.Gray;
            txtMontoVerificacion.LineMouseHoverColor = Color.Blue;
            txtMontoVerificacion.LineThickness = 3;
            txtMontoVerificacion.Location = new Point(271, 187);
            txtMontoVerificacion.Margin = new Padding(4);
            txtMontoVerificacion.Name = "txtMontoVerificacion";
            txtMontoVerificacion.Size = new Size(101, 29);
            txtMontoVerificacion.TabIndex = 165;
            txtMontoVerificacion.TextAlign = HorizontalAlignment.Left;
            // 
            // Label53
            // 
            Label53.AutoSize = true;
            Label53.ForeColor = Color.White;
            Label53.Location = new Point(268, 170);
            Label53.Name = "Label53";
            Label53.Size = new Size(136, 13);
            Label53.TabIndex = 164;
            Label53.Text = "Monto Autorizado por V y C";
            // 
            // txtMontoSolicitado
            // 
            txtMontoSolicitado.Cursor = Cursors.IBeam;
            txtMontoSolicitado.Enabled = false;
            txtMontoSolicitado.Font = new Font("Century Gothic", 9.75f);
            txtMontoSolicitado.ForeColor = Color.White;
            txtMontoSolicitado.HintForeColor = Color.White;
            txtMontoSolicitado.HintText = "";
            txtMontoSolicitado.isPassword = false;
            txtMontoSolicitado.LineFocusedColor = Color.Blue;
            txtMontoSolicitado.LineIdleColor = Color.Gray;
            txtMontoSolicitado.LineMouseHoverColor = Color.Blue;
            txtMontoSolicitado.LineThickness = 3;
            txtMontoSolicitado.Location = new Point(271, 118);
            txtMontoSolicitado.Margin = new Padding(4);
            txtMontoSolicitado.Name = "txtMontoSolicitado";
            txtMontoSolicitado.Size = new Size(101, 29);
            txtMontoSolicitado.TabIndex = 163;
            txtMontoSolicitado.TextAlign = HorizontalAlignment.Left;
            // 
            // Label52
            // 
            Label52.AutoSize = true;
            Label52.ForeColor = Color.White;
            Label52.Location = new Point(268, 101);
            Label52.Name = "Label52";
            Label52.Size = new Size(86, 13);
            Label52.TabIndex = 161;
            Label52.Text = "Monto Solicitado";
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
            dtdatosDocumentos.Location = new Point(504, 59);
            dtdatosDocumentos.Name = "dtdatosDocumentos";
            dtdatosDocumentos.ReadOnly = true;
            dtdatosDocumentos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatosDocumentos.RowHeadersVisible = false;
            dtdatosDocumentos.Size = new Size(480, 266);
            dtdatosDocumentos.TabIndex = 26;
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.ForeColor = Color.White;
            Label21.Location = new Point(501, 27);
            Label21.Name = "Label21";
            Label21.Size = new Size(67, 13);
            Label21.TabIndex = 150;
            Label21.Text = "Documentos";
            // 
            // txtObservacionesDomicilio
            // 
            txtObservacionesDomicilio.Enabled = false;
            txtObservacionesDomicilio.Location = new Point(21, 44);
            txtObservacionesDomicilio.Multiline = true;
            txtObservacionesDomicilio.Name = "txtObservacionesDomicilio";
            txtObservacionesDomicilio.Size = new Size(222, 93);
            txtObservacionesDomicilio.TabIndex = 148;
            // 
            // txtHorarioVerificacion
            // 
            txtHorarioVerificacion.Cursor = Cursors.IBeam;
            txtHorarioVerificacion.Enabled = false;
            txtHorarioVerificacion.Font = new Font("Century Gothic", 9.75f);
            txtHorarioVerificacion.ForeColor = Color.White;
            txtHorarioVerificacion.HintForeColor = Color.White;
            txtHorarioVerificacion.HintText = "";
            txtHorarioVerificacion.isPassword = false;
            txtHorarioVerificacion.LineFocusedColor = Color.Blue;
            txtHorarioVerificacion.LineIdleColor = Color.Gray;
            txtHorarioVerificacion.LineMouseHoverColor = Color.Blue;
            txtHorarioVerificacion.LineThickness = 3;
            txtHorarioVerificacion.Location = new Point(271, 44);
            txtHorarioVerificacion.Margin = new Padding(4);
            txtHorarioVerificacion.Name = "txtHorarioVerificacion";
            txtHorarioVerificacion.Size = new Size(101, 29);
            txtHorarioVerificacion.TabIndex = 125;
            txtHorarioVerificacion.TextAlign = HorizontalAlignment.Left;
            // 
            // Label55
            // 
            Label55.AutoSize = true;
            Label55.ForeColor = Color.White;
            Label55.Location = new Point(268, 27);
            Label55.Name = "Label55";
            Label55.Size = new Size(113, 13);
            Label55.TabIndex = 124;
            Label55.Text = "Horario de verificación";
            // 
            // Label56
            // 
            Label56.AutoSize = true;
            Label56.ForeColor = Color.White;
            Label56.Location = new Point(23, 28);
            Label56.Name = "Label56";
            Label56.Size = new Size(138, 13);
            Label56.TabIndex = 122;
            Label56.Text = "Observaciones del domicilio";
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            dtdatos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3;
            dtdatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtdatos.BackgroundColor = Color.Gainsboro;
            dtdatos.BorderStyle = BorderStyle.None;
            dtdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle4.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dtdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatos.Columns.AddRange(new DataGridViewColumn[] { Id, IdCliente, Nombre, Estado, Monto });
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(12, 43);
            dtdatos.Name = "dtdatos";
            dtdatos.ReadOnly = true;
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(945, 158);
            dtdatos.TabIndex = 25;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "IdCliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            IdCliente.Width = 85;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 79;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 71;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto Autorizado";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 126;
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
            // BackgroundDatosSolicitud
            // 
            // 
            // BackgroundDocumentos
            // 
            // 
            // BackgroundRechazo
            // 
            // 
            // BackgroundCorreo
            // 
            // 
            // DatosSolicitudReenviarCorreo
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1155, 788);
            Controls.Add(dtdatos);
            Controls.Add(TabControl1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatosSolicitudReenviarCorreo";
            Text = "Datos Verificación";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            TabPage5.ResumeLayout(false);
            TabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Load += new EventHandler(DatosSolicitud_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtRelacionConyuge;
        internal Label Label17;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtdatosConyuge;
        internal Label Label16;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        internal Label Label15;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        internal Label Label14;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColonia;
        internal Label Label13;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTiempoDomicilio;
        internal Label Label12;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostal;
        internal Label Label10;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoInterior;
        internal Label Label9;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExterior;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalle;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox TxtCasaDondeVive;
        internal Label Label6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCelular;
        internal Label Label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEdad;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoM;
        internal Label Label2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoP;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal Label Label11;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtObjetivo;
        internal Label Label22;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtFrecuenciaCobro;
        internal Label Label23;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtJefeDirecto;
        internal Label Label24;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefonoTrabajo;
        internal Label Label25;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColoniaTrabajo;
        internal Label Label26;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalleTrabajo;
        internal Label Label27;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIngresoPromedio;
        internal Label Label28;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTipoEstablecimiento;
        internal Label Label29;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtHorariosTrabajo;
        internal Label Label30;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtAntiguedad;
        internal Label Label31;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtVende;
        internal Label Label32;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtSeDedica;
        internal Label Label33;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreLugarTrabajo;
        internal Label Label34;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtRelacionR2;
        internal Label Label18;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefonoR2;
        internal Label Label19;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreR2;
        internal Label Label20;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_Separator MonoFlat_Separator1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtRelacionR1;
        internal Label Label41;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefonoR1;
        internal Label Label42;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreR1;
        internal Label Label43;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtFrecuenciaInversion;
        internal Label Label40;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEmpleados;
        internal Label Label44;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPersonasDependientes;
        internal Label Label45;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtServicios;
        internal Label Label46;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtDeudas;
        internal Label Label47;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtFamiliasEnCasa;
        internal Label Label48;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEnfermedad;
        internal Label Label49;
        internal TabPage TabPage5;
        internal Label Label21;
        internal TextBox txtObservacionesDomicilio;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtHorarioVerificacion;
        internal Label Label55;
        internal Label Label56;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.ComponentModel.BackgroundWorker BackgroundAct;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEntreCalles;
        internal Label Label35;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoInteriorTrabajo;
        internal Label Label37;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExteriorTrabajo;
        internal Label Label36;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostalTrabajo;
        internal Label Label38;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentosSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificacion;
        internal System.ComponentModel.BackgroundWorker BackgroundDatosSolicitud;
        internal Label Label39;
        internal TextBox txtComentarios;
        internal EvolveControlBox EvolveControlBox1;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoAutorizado;
        internal Label Label50;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn IdCliente;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Estado;
        internal DataGridViewTextBoxColumn Monto;
        internal System.ComponentModel.BackgroundWorker BackgroundRechazo;
        internal Label Label54;
        internal TextBox txtComentariosVerificacion;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoVerificacion;
        internal Label Label53;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoSolicitado;
        internal Label Label52;
        internal GroupBox GroupBox2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoIntR1;
        internal Label Label57;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExtR1;
        internal Label Label58;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalleR1;
        internal Label Label59;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostalR1;
        internal Label Label60;
        internal Label Label61;
        internal GroupBox GroupBox3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoIntR2;
        internal Label Label62;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExtR2;
        internal Label Label63;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalleR2;
        internal Label Label64;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoPostalR2;
        internal Label Label65;
        internal Label Label66;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColoniaR2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColoniaR1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnReenviar;
        internal System.ComponentModel.BackgroundWorker BackgroundCorreo;
    }
}