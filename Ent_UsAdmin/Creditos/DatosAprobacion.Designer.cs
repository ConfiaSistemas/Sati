using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DatosAprobacion : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAprobacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btn_Incompleta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_rechazar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.btn_a_verificacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtOcupacionConyuge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label72 = new System.Windows.Forms.Label();
            this.txtTelefonoConyuge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label71 = new System.Windows.Forms.Label();
            this.txtColoniaReal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label70 = new System.Windows.Forms.Label();
            this.txtDomicilioAlterno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label69 = new System.Windows.Forms.Label();
            this.txtHijos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label68 = new System.Windows.Forms.Label();
            this.txtEntreCalles = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label35 = new System.Windows.Forms.Label();
            this.txtRelacionConyuge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label17 = new System.Windows.Forms.Label();
            this.txtdatosConyuge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtTiempoDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtNoInterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtNoExterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtCasaDondeVive = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtEdad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txtCodigoPostalTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label38 = new System.Windows.Forms.Label();
            this.txtNoInteriorTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label37 = new System.Windows.Forms.Label();
            this.txtNoExteriorTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label36 = new System.Windows.Forms.Label();
            this.txtObjetivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtFrecuenciaCobro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtJefeDirecto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtTelefonoTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label25 = new System.Windows.Forms.Label();
            this.txtColoniaTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label26 = new System.Windows.Forms.Label();
            this.txtCalleTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtIngresoPromedio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label28 = new System.Windows.Forms.Label();
            this.txtTipoEstablecimiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label29 = new System.Windows.Forms.Label();
            this.txtHorariosTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label30 = new System.Windows.Forms.Label();
            this.txtAntiguedad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtVende = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label32 = new System.Windows.Forms.Label();
            this.txtSeDedica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtNombreLugarTrabajo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label34 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtColoniaR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoIntR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label62 = new System.Windows.Forms.Label();
            this.txtNoExtR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label63 = new System.Windows.Forms.Label();
            this.txtCalleR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label64 = new System.Windows.Forms.Label();
            this.txtCodigoPostalR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label65 = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtColoniaR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNoIntR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label57 = new System.Windows.Forms.Label();
            this.txtNoExtR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label58 = new System.Windows.Forms.Label();
            this.txtCalleR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label59 = new System.Windows.Forms.Label();
            this.txtCodigoPostalR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.txtRelacionR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtTelefonoR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtNombreR2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label20 = new System.Windows.Forms.Label();
            this.MonoFlat_HeaderLabel3 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_Separator1 = new ConfiaAdmin.MonoFlat.MonoFlat_Separator();
            this.txtRelacionR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label41 = new System.Windows.Forms.Label();
            this.txtTelefonoR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label42 = new System.Windows.Forms.Label();
            this.txtNombreR1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label43 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.txtFrecuenciaInversion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label40 = new System.Windows.Forms.Label();
            this.txtEmpleados = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label44 = new System.Windows.Forms.Label();
            this.txtPersonasDependientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label45 = new System.Windows.Forms.Label();
            this.txtServicios = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label46 = new System.Windows.Forms.Label();
            this.txtDeudas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label47 = new System.Windows.Forms.Label();
            this.txtFamiliasEnCasa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label48 = new System.Windows.Forms.Label();
            this.txtEnfermedad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label49 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.txtMontoMaximoAutorizado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label67 = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.txtComentariosVerificacion = new System.Windows.Forms.TextBox();
            this.txtMontoVerificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label53 = new System.Windows.Forms.Label();
            this.txtMontoSolicitado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label52 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMontoAutorizado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtObservacionesDomicilio = new System.Windows.Forms.TextBox();
            this.txtHorarioVerificacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BackgroundAct = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDocumentosSolicitud = new System.ComponentModel.BackgroundWorker();
            this.BackgroundVerificacion = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDatosSolicitud = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            this.txtMontoTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label51 = new System.Windows.Forms.Label();
            this.BackgroundRechazo = new System.ComponentModel.BackgroundWorker();
            this.backgroundIncompleta = new System.ComponentModel.BackgroundWorker();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.btn_Incompleta);
            this.Panel1.Controls.Add(this.btn_rechazar);
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.btn_a_verificacion);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1148, 36);
            this.Panel1.TabIndex = 3;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // btn_Incompleta
            // 
            this.btn_Incompleta.ActiveBorderThickness = 1;
            this.btn_Incompleta.ActiveCornerRadius = 20;
            this.btn_Incompleta.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Incompleta.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Incompleta.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Incompleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Incompleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Incompleta.BackgroundImage")));
            this.btn_Incompleta.ButtonText = "Incompleta";
            this.btn_Incompleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Incompleta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incompleta.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Incompleta.IdleBorderThickness = 1;
            this.btn_Incompleta.IdleCornerRadius = 20;
            this.btn_Incompleta.IdleFillColor = System.Drawing.Color.White;
            this.btn_Incompleta.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_Incompleta.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Incompleta.Location = new System.Drawing.Point(391, -2);
            this.btn_Incompleta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Incompleta.Name = "btn_Incompleta";
            this.btn_Incompleta.Size = new System.Drawing.Size(204, 38);
            this.btn_Incompleta.TabIndex = 155;
            this.btn_Incompleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Incompleta.Visible = false;
            this.btn_Incompleta.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btn_rechazar
            // 
            this.btn_rechazar.ActiveBorderThickness = 1;
            this.btn_rechazar.ActiveCornerRadius = 20;
            this.btn_rechazar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_rechazar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_rechazar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_rechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_rechazar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rechazar.BackgroundImage")));
            this.btn_rechazar.ButtonText = "Rechazar";
            this.btn_rechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rechazar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechazar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_rechazar.IdleBorderThickness = 1;
            this.btn_rechazar.IdleCornerRadius = 20;
            this.btn_rechazar.IdleFillColor = System.Drawing.Color.White;
            this.btn_rechazar.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_rechazar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_rechazar.Location = new System.Drawing.Point(616, -2);
            this.btn_rechazar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(204, 38);
            this.btn_rechazar.TabIndex = 154;
            this.btn_rechazar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_rechazar.Visible = false;
            this.btn_rechazar.Click += new System.EventHandler(this.btn_rechazar_Click);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(1076, 7);
            this.EvolveControlBox1.MaxButton = false;
            this.EvolveControlBox1.MinButton = true;
            this.EvolveControlBox1.Name = "EvolveControlBox1";
            this.EvolveControlBox1.NoRounding = false;
            this.EvolveControlBox1.Size = new System.Drawing.Size(66, 16);
            this.EvolveControlBox1.TabIndex = 153;
            this.EvolveControlBox1.Text = "EvolveControlBox1";
            this.EvolveControlBox1.Transparent = false;
            // 
            // btn_a_verificacion
            // 
            this.btn_a_verificacion.ActiveBorderThickness = 1;
            this.btn_a_verificacion.ActiveCornerRadius = 20;
            this.btn_a_verificacion.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_a_verificacion.ActiveForecolor = System.Drawing.Color.White;
            this.btn_a_verificacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_a_verificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_a_verificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_a_verificacion.BackgroundImage")));
            this.btn_a_verificacion.ButtonText = "Aprobar";
            this.btn_a_verificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_a_verificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a_verificacion.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_a_verificacion.IdleBorderThickness = 1;
            this.btn_a_verificacion.IdleCornerRadius = 20;
            this.btn_a_verificacion.IdleFillColor = System.Drawing.Color.White;
            this.btn_a_verificacion.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_a_verificacion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_a_verificacion.Location = new System.Drawing.Point(846, -2);
            this.btn_a_verificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_a_verificacion.Name = "btn_a_verificacion";
            this.btn_a_verificacion.Size = new System.Drawing.Size(204, 38);
            this.btn_a_verificacion.TabIndex = 152;
            this.btn_a_verificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_a_verificacion.Visible = false;
            this.btn_a_verificacion.Click += new System.EventHandler(this.btn_a_verificacion_Click);
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(3, 3);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(90, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Aprobación";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(8, 231);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1141, 545);
            this.TabControl1.TabIndex = 4;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage1.Controls.Add(this.txtOcupacionConyuge);
            this.TabPage1.Controls.Add(this.Label72);
            this.TabPage1.Controls.Add(this.txtTelefonoConyuge);
            this.TabPage1.Controls.Add(this.Label71);
            this.TabPage1.Controls.Add(this.txtColoniaReal);
            this.TabPage1.Controls.Add(this.Label70);
            this.TabPage1.Controls.Add(this.txtDomicilioAlterno);
            this.TabPage1.Controls.Add(this.Label69);
            this.TabPage1.Controls.Add(this.txtHijos);
            this.TabPage1.Controls.Add(this.Label68);
            this.TabPage1.Controls.Add(this.txtEntreCalles);
            this.TabPage1.Controls.Add(this.Label35);
            this.TabPage1.Controls.Add(this.txtRelacionConyuge);
            this.TabPage1.Controls.Add(this.Label17);
            this.TabPage1.Controls.Add(this.txtdatosConyuge);
            this.TabPage1.Controls.Add(this.Label16);
            this.TabPage1.Controls.Add(this.txtEstado);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Controls.Add(this.txtCiudad);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.txtColonia);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.txtTiempoDomicilio);
            this.TabPage1.Controls.Add(this.Label12);
            this.TabPage1.Controls.Add(this.txtCodigoPostal);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.txtNoInterior);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.txtNoExterior);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.txtCalle);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.TxtCasaDondeVive);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.txtCelular);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.txtTelefono);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.txtEdad);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.txtApellidoM);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.txtApellidoP);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.txtnombre);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1133, 519);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Datos Personales";
            this.TabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // txtOcupacionConyuge
            // 
            this.txtOcupacionConyuge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOcupacionConyuge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOcupacionConyuge.ForeColor = System.Drawing.Color.White;
            this.txtOcupacionConyuge.HintForeColor = System.Drawing.Color.White;
            this.txtOcupacionConyuge.HintText = "";
            this.txtOcupacionConyuge.isPassword = false;
            this.txtOcupacionConyuge.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOcupacionConyuge.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOcupacionConyuge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOcupacionConyuge.LineThickness = 3;
            this.txtOcupacionConyuge.Location = new System.Drawing.Point(475, 354);
            this.txtOcupacionConyuge.Margin = new System.Windows.Forms.Padding(4);
            this.txtOcupacionConyuge.Name = "txtOcupacionConyuge";
            this.txtOcupacionConyuge.Size = new System.Drawing.Size(181, 29);
            this.txtOcupacionConyuge.TabIndex = 107;
            this.txtOcupacionConyuge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.ForeColor = System.Drawing.Color.White;
            this.Label72.Location = new System.Drawing.Point(472, 337);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(104, 13);
            this.Label72.TabIndex = 106;
            this.Label72.Text = "Ocupación Cónyuge";
            // 
            // txtTelefonoConyuge
            // 
            this.txtTelefonoConyuge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoConyuge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefonoConyuge.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoConyuge.HintForeColor = System.Drawing.Color.White;
            this.txtTelefonoConyuge.HintText = "";
            this.txtTelefonoConyuge.isPassword = false;
            this.txtTelefonoConyuge.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefonoConyuge.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefonoConyuge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefonoConyuge.LineThickness = 3;
            this.txtTelefonoConyuge.Location = new System.Drawing.Point(266, 354);
            this.txtTelefonoConyuge.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoConyuge.Name = "txtTelefonoConyuge";
            this.txtTelefonoConyuge.Size = new System.Drawing.Size(201, 29);
            this.txtTelefonoConyuge.TabIndex = 105;
            this.txtTelefonoConyuge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label71
            // 
            this.Label71.AutoSize = true;
            this.Label71.ForeColor = System.Drawing.Color.White;
            this.Label71.Location = new System.Drawing.Point(263, 337);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(94, 13);
            this.Label71.TabIndex = 104;
            this.Label71.Text = "Teléfono Cónyuge";
            // 
            // txtColoniaReal
            // 
            this.txtColoniaReal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColoniaReal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColoniaReal.ForeColor = System.Drawing.Color.White;
            this.txtColoniaReal.HintForeColor = System.Drawing.Color.White;
            this.txtColoniaReal.HintText = "";
            this.txtColoniaReal.isPassword = false;
            this.txtColoniaReal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtColoniaReal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColoniaReal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtColoniaReal.LineThickness = 3;
            this.txtColoniaReal.Location = new System.Drawing.Point(45, 287);
            this.txtColoniaReal.Margin = new System.Windows.Forms.Padding(4);
            this.txtColoniaReal.Name = "txtColoniaReal";
            this.txtColoniaReal.Size = new System.Drawing.Size(213, 29);
            this.txtColoniaReal.TabIndex = 103;
            this.txtColoniaReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label70
            // 
            this.Label70.AutoSize = true;
            this.Label70.ForeColor = System.Drawing.Color.White;
            this.Label70.Location = new System.Drawing.Point(42, 270);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(67, 13);
            this.Label70.TabIndex = 102;
            this.Label70.Text = "Colonia Real";
            // 
            // txtDomicilioAlterno
            // 
            this.txtDomicilioAlterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDomicilioAlterno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDomicilioAlterno.ForeColor = System.Drawing.Color.White;
            this.txtDomicilioAlterno.HintForeColor = System.Drawing.Color.White;
            this.txtDomicilioAlterno.HintText = "";
            this.txtDomicilioAlterno.isPassword = false;
            this.txtDomicilioAlterno.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDomicilioAlterno.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDomicilioAlterno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDomicilioAlterno.LineThickness = 3;
            this.txtDomicilioAlterno.Location = new System.Drawing.Point(266, 287);
            this.txtDomicilioAlterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilioAlterno.Name = "txtDomicilioAlterno";
            this.txtDomicilioAlterno.Size = new System.Drawing.Size(201, 29);
            this.txtDomicilioAlterno.TabIndex = 101;
            this.txtDomicilioAlterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label69
            // 
            this.Label69.AutoSize = true;
            this.Label69.ForeColor = System.Drawing.Color.White;
            this.Label69.Location = new System.Drawing.Point(263, 270);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(85, 13);
            this.Label69.TabIndex = 100;
            this.Label69.Text = "Domicilio Alterno";
            // 
            // txtHijos
            // 
            this.txtHijos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHijos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHijos.ForeColor = System.Drawing.Color.White;
            this.txtHijos.HintForeColor = System.Drawing.Color.White;
            this.txtHijos.HintText = "";
            this.txtHijos.isPassword = false;
            this.txtHijos.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHijos.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHijos.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHijos.LineThickness = 3;
            this.txtHijos.Location = new System.Drawing.Point(473, 146);
            this.txtHijos.Margin = new System.Windows.Forms.Padding(4);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(183, 29);
            this.txtHijos.TabIndex = 99;
            this.txtHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label68
            // 
            this.Label68.AutoSize = true;
            this.Label68.ForeColor = System.Drawing.Color.White;
            this.Label68.Location = new System.Drawing.Point(470, 129);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(30, 13);
            this.Label68.TabIndex = 98;
            this.Label68.Text = "Hijos";
            // 
            // txtEntreCalles
            // 
            this.txtEntreCalles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEntreCalles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEntreCalles.ForeColor = System.Drawing.Color.White;
            this.txtEntreCalles.HintForeColor = System.Drawing.Color.White;
            this.txtEntreCalles.HintText = "";
            this.txtEntreCalles.isPassword = false;
            this.txtEntreCalles.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEntreCalles.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEntreCalles.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEntreCalles.LineThickness = 3;
            this.txtEntreCalles.Location = new System.Drawing.Point(664, 223);
            this.txtEntreCalles.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntreCalles.Name = "txtEntreCalles";
            this.txtEntreCalles.Size = new System.Drawing.Size(194, 29);
            this.txtEntreCalles.TabIndex = 97;
            this.txtEntreCalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.ForeColor = System.Drawing.Color.White;
            this.Label35.Location = new System.Drawing.Point(661, 206);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(62, 13);
            this.Label35.TabIndex = 96;
            this.Label35.Text = "Entre calles";
            // 
            // txtRelacionConyuge
            // 
            this.txtRelacionConyuge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRelacionConyuge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRelacionConyuge.ForeColor = System.Drawing.Color.White;
            this.txtRelacionConyuge.HintForeColor = System.Drawing.Color.White;
            this.txtRelacionConyuge.HintText = "";
            this.txtRelacionConyuge.isPassword = false;
            this.txtRelacionConyuge.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRelacionConyuge.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRelacionConyuge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRelacionConyuge.LineThickness = 3;
            this.txtRelacionConyuge.Location = new System.Drawing.Point(45, 354);
            this.txtRelacionConyuge.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelacionConyuge.Name = "txtRelacionConyuge";
            this.txtRelacionConyuge.Size = new System.Drawing.Size(213, 29);
            this.txtRelacionConyuge.TabIndex = 95;
            this.txtRelacionConyuge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(42, 337);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(131, 13);
            this.Label17.TabIndex = 94;
            this.Label17.Text = "Relación con el solicitante";
            // 
            // txtdatosConyuge
            // 
            this.txtdatosConyuge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdatosConyuge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdatosConyuge.ForeColor = System.Drawing.Color.White;
            this.txtdatosConyuge.HintForeColor = System.Drawing.Color.White;
            this.txtdatosConyuge.HintText = "";
            this.txtdatosConyuge.isPassword = false;
            this.txtdatosConyuge.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdatosConyuge.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdatosConyuge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdatosConyuge.LineThickness = 3;
            this.txtdatosConyuge.Location = new System.Drawing.Point(866, 287);
            this.txtdatosConyuge.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatosConyuge.Name = "txtdatosConyuge";
            this.txtdatosConyuge.Size = new System.Drawing.Size(213, 29);
            this.txtdatosConyuge.TabIndex = 93;
            this.txtdatosConyuge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(863, 270);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(219, 13);
            this.Label16.TabIndex = 92;
            this.Label16.Text = "Datos del cónyuge o persona con quien viva";
            // 
            // txtEstado
            // 
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.HintForeColor = System.Drawing.Color.White;
            this.txtEstado.HintText = "";
            this.txtEstado.isPassword = false;
            this.txtEstado.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEstado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEstado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEstado.LineThickness = 3;
            this.txtEstado.Location = new System.Drawing.Point(664, 287);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(194, 29);
            this.txtEstado.TabIndex = 91;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(661, 270);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(40, 13);
            this.Label15.TabIndex = 90;
            this.Label15.Text = "Estado";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCiudad.ForeColor = System.Drawing.Color.White;
            this.txtCiudad.HintForeColor = System.Drawing.Color.White;
            this.txtCiudad.HintText = "";
            this.txtCiudad.isPassword = false;
            this.txtCiudad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCiudad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCiudad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCiudad.LineThickness = 3;
            this.txtCiudad.Location = new System.Drawing.Point(475, 287);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(181, 29);
            this.txtCiudad.TabIndex = 89;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(472, 270);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(40, 13);
            this.Label14.TabIndex = 88;
            this.Label14.Text = "Ciudad";
            // 
            // txtColonia
            // 
            this.txtColonia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColonia.ForeColor = System.Drawing.Color.White;
            this.txtColonia.HintForeColor = System.Drawing.Color.White;
            this.txtColonia.HintText = "";
            this.txtColonia.isPassword = false;
            this.txtColonia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtColonia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColonia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtColonia.LineThickness = 3;
            this.txtColonia.Location = new System.Drawing.Point(866, 223);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(4);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(213, 29);
            this.txtColonia.TabIndex = 87;
            this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(863, 206);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(42, 13);
            this.Label13.TabIndex = 86;
            this.Label13.Text = "Colonia";
            // 
            // txtTiempoDomicilio
            // 
            this.txtTiempoDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTiempoDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTiempoDomicilio.ForeColor = System.Drawing.Color.White;
            this.txtTiempoDomicilio.HintForeColor = System.Drawing.Color.White;
            this.txtTiempoDomicilio.HintText = "";
            this.txtTiempoDomicilio.isPassword = false;
            this.txtTiempoDomicilio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTiempoDomicilio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTiempoDomicilio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTiempoDomicilio.LineThickness = 3;
            this.txtTiempoDomicilio.Location = new System.Drawing.Point(664, 146);
            this.txtTiempoDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoDomicilio.Name = "txtTiempoDomicilio";
            this.txtTiempoDomicilio.Size = new System.Drawing.Size(194, 29);
            this.txtTiempoDomicilio.TabIndex = 85;
            this.txtTiempoDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(661, 129);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(154, 13);
            this.Label12.TabIndex = 84;
            this.Label12.Text = "Tiempo viviendo en el domicilio";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostal.ForeColor = System.Drawing.Color.White;
            this.txtCodigoPostal.HintForeColor = System.Drawing.Color.White;
            this.txtCodigoPostal.HintText = "";
            this.txtCodigoPostal.isPassword = false;
            this.txtCodigoPostal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigoPostal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoPostal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigoPostal.LineThickness = 3;
            this.txtCodigoPostal.Location = new System.Drawing.Point(475, 223);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(181, 29);
            this.txtCodigoPostal.TabIndex = 83;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(472, 206);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 13);
            this.Label10.TabIndex = 82;
            this.Label10.Text = "Código Postal";
            // 
            // txtNoInterior
            // 
            this.txtNoInterior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoInterior.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoInterior.ForeColor = System.Drawing.Color.White;
            this.txtNoInterior.HintForeColor = System.Drawing.Color.White;
            this.txtNoInterior.HintText = "";
            this.txtNoInterior.isPassword = false;
            this.txtNoInterior.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoInterior.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoInterior.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoInterior.LineThickness = 3;
            this.txtNoInterior.Location = new System.Drawing.Point(266, 223);
            this.txtNoInterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoInterior.Name = "txtNoInterior";
            this.txtNoInterior.Size = new System.Drawing.Size(199, 29);
            this.txtNoInterior.TabIndex = 81;
            this.txtNoInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(263, 206);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(58, 13);
            this.Label9.TabIndex = 80;
            this.Label9.Text = "No. interior";
            // 
            // txtNoExterior
            // 
            this.txtNoExterior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoExterior.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoExterior.ForeColor = System.Drawing.Color.White;
            this.txtNoExterior.HintForeColor = System.Drawing.Color.White;
            this.txtNoExterior.HintText = "";
            this.txtNoExterior.isPassword = false;
            this.txtNoExterior.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoExterior.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoExterior.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoExterior.LineThickness = 3;
            this.txtNoExterior.Location = new System.Drawing.Point(45, 223);
            this.txtNoExterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExterior.Name = "txtNoExterior";
            this.txtNoExterior.Size = new System.Drawing.Size(213, 29);
            this.txtNoExterior.TabIndex = 79;
            this.txtNoExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(42, 206);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(61, 13);
            this.Label8.TabIndex = 78;
            this.Label8.Text = "No. exterior";
            // 
            // txtCalle
            // 
            this.txtCalle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCalle.ForeColor = System.Drawing.Color.White;
            this.txtCalle.HintForeColor = System.Drawing.Color.White;
            this.txtCalle.HintText = "";
            this.txtCalle.isPassword = false;
            this.txtCalle.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCalle.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCalle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCalle.LineThickness = 3;
            this.txtCalle.Location = new System.Drawing.Point(866, 146);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(213, 29);
            this.txtCalle.TabIndex = 77;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(863, 129);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 13);
            this.Label7.TabIndex = 76;
            this.Label7.Text = "Calle";
            // 
            // TxtCasaDondeVive
            // 
            this.TxtCasaDondeVive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCasaDondeVive.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCasaDondeVive.ForeColor = System.Drawing.Color.White;
            this.TxtCasaDondeVive.HintForeColor = System.Drawing.Color.White;
            this.TxtCasaDondeVive.HintText = "";
            this.TxtCasaDondeVive.isPassword = false;
            this.TxtCasaDondeVive.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtCasaDondeVive.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCasaDondeVive.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtCasaDondeVive.LineThickness = 3;
            this.TxtCasaDondeVive.Location = new System.Drawing.Point(266, 146);
            this.TxtCasaDondeVive.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCasaDondeVive.Name = "TxtCasaDondeVive";
            this.TxtCasaDondeVive.Size = new System.Drawing.Size(199, 29);
            this.TxtCasaDondeVive.TabIndex = 75;
            this.TxtCasaDondeVive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(263, 129);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 13);
            this.Label6.TabIndex = 74;
            this.Label6.Text = "La casa donde vive es:";
            // 
            // txtCelular
            // 
            this.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCelular.ForeColor = System.Drawing.Color.White;
            this.txtCelular.HintForeColor = System.Drawing.Color.White;
            this.txtCelular.HintText = "";
            this.txtCelular.isPassword = false;
            this.txtCelular.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCelular.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCelular.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCelular.LineThickness = 3;
            this.txtCelular.Location = new System.Drawing.Point(45, 146);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(213, 29);
            this.txtCelular.TabIndex = 73;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(42, 129);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 72;
            this.Label5.Text = "Celular";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.HintForeColor = System.Drawing.Color.White;
            this.txtTelefono.HintText = "";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefono.LineThickness = 3;
            this.txtTelefono.Location = new System.Drawing.Point(866, 71);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 29);
            this.txtTelefono.TabIndex = 71;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(863, 54);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 13);
            this.Label4.TabIndex = 70;
            this.Label4.Text = "Teléfono Particular";
            // 
            // txtEdad
            // 
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEdad.ForeColor = System.Drawing.Color.White;
            this.txtEdad.HintForeColor = System.Drawing.Color.White;
            this.txtEdad.HintText = "";
            this.txtEdad.isPassword = false;
            this.txtEdad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEdad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEdad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEdad.LineThickness = 3;
            this.txtEdad.Location = new System.Drawing.Point(664, 71);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(194, 29);
            this.txtEdad.TabIndex = 69;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(661, 54);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 13);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "Edad";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellidoM.ForeColor = System.Drawing.Color.White;
            this.txtApellidoM.HintForeColor = System.Drawing.Color.White;
            this.txtApellidoM.HintText = "";
            this.txtApellidoM.isPassword = false;
            this.txtApellidoM.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellidoM.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellidoM.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtApellidoM.LineThickness = 3;
            this.txtApellidoM.Location = new System.Drawing.Point(473, 71);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(183, 29);
            this.txtApellidoM.TabIndex = 67;
            this.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(470, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 13);
            this.Label2.TabIndex = 66;
            this.Label2.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellidoP.ForeColor = System.Drawing.Color.White;
            this.txtApellidoP.HintForeColor = System.Drawing.Color.White;
            this.txtApellidoP.HintText = "";
            this.txtApellidoP.isPassword = false;
            this.txtApellidoP.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellidoP.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellidoP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtApellidoP.LineThickness = 3;
            this.txtApellidoP.Location = new System.Drawing.Point(266, 71);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(199, 29);
            this.txtApellidoP.TabIndex = 65;
            this.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(263, 54);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 13);
            this.Label1.TabIndex = 64;
            this.Label1.Text = "Apellido Paterno";
            // 
            // txtnombre
            // 
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.HintForeColor = System.Drawing.Color.White;
            this.txtnombre.HintText = "";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombre.LineThickness = 3;
            this.txtnombre.Location = new System.Drawing.Point(45, 71);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(213, 29);
            this.txtnombre.TabIndex = 63;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(42, 54);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(55, 13);
            this.Label11.TabIndex = 62;
            this.Label11.Text = "Nombre(s)";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage2.Controls.Add(this.txtCodigoPostalTrabajo);
            this.TabPage2.Controls.Add(this.Label38);
            this.TabPage2.Controls.Add(this.txtNoInteriorTrabajo);
            this.TabPage2.Controls.Add(this.Label37);
            this.TabPage2.Controls.Add(this.txtNoExteriorTrabajo);
            this.TabPage2.Controls.Add(this.Label36);
            this.TabPage2.Controls.Add(this.txtObjetivo);
            this.TabPage2.Controls.Add(this.Label22);
            this.TabPage2.Controls.Add(this.txtFrecuenciaCobro);
            this.TabPage2.Controls.Add(this.Label23);
            this.TabPage2.Controls.Add(this.txtJefeDirecto);
            this.TabPage2.Controls.Add(this.Label24);
            this.TabPage2.Controls.Add(this.txtTelefonoTrabajo);
            this.TabPage2.Controls.Add(this.Label25);
            this.TabPage2.Controls.Add(this.txtColoniaTrabajo);
            this.TabPage2.Controls.Add(this.Label26);
            this.TabPage2.Controls.Add(this.txtCalleTrabajo);
            this.TabPage2.Controls.Add(this.Label27);
            this.TabPage2.Controls.Add(this.txtIngresoPromedio);
            this.TabPage2.Controls.Add(this.Label28);
            this.TabPage2.Controls.Add(this.txtTipoEstablecimiento);
            this.TabPage2.Controls.Add(this.Label29);
            this.TabPage2.Controls.Add(this.txtHorariosTrabajo);
            this.TabPage2.Controls.Add(this.Label30);
            this.TabPage2.Controls.Add(this.txtAntiguedad);
            this.TabPage2.Controls.Add(this.Label31);
            this.TabPage2.Controls.Add(this.txtVende);
            this.TabPage2.Controls.Add(this.Label32);
            this.TabPage2.Controls.Add(this.txtSeDedica);
            this.TabPage2.Controls.Add(this.Label33);
            this.TabPage2.Controls.Add(this.txtNombreLugarTrabajo);
            this.TabPage2.Controls.Add(this.Label34);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1133, 519);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Trabajo";
            // 
            // txtCodigoPostalTrabajo
            // 
            this.txtCodigoPostalTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostalTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostalTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtCodigoPostalTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtCodigoPostalTrabajo.HintText = "";
            this.txtCodigoPostalTrabajo.isPassword = false;
            this.txtCodigoPostalTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigoPostalTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoPostalTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigoPostalTrabajo.LineThickness = 3;
            this.txtCodigoPostalTrabajo.Location = new System.Drawing.Point(645, 219);
            this.txtCodigoPostalTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostalTrabajo.Name = "txtCodigoPostalTrabajo";
            this.txtCodigoPostalTrabajo.Size = new System.Drawing.Size(217, 29);
            this.txtCodigoPostalTrabajo.TabIndex = 127;
            this.txtCodigoPostalTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.ForeColor = System.Drawing.Color.White;
            this.Label38.Location = new System.Drawing.Point(642, 202);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(72, 13);
            this.Label38.TabIndex = 126;
            this.Label38.Text = "Código Postal";
            // 
            // txtNoInteriorTrabajo
            // 
            this.txtNoInteriorTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoInteriorTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoInteriorTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtNoInteriorTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtNoInteriorTrabajo.HintText = "";
            this.txtNoInteriorTrabajo.isPassword = false;
            this.txtNoInteriorTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoInteriorTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoInteriorTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoInteriorTrabajo.LineThickness = 3;
            this.txtNoInteriorTrabajo.Location = new System.Drawing.Point(454, 219);
            this.txtNoInteriorTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoInteriorTrabajo.Name = "txtNoInteriorTrabajo";
            this.txtNoInteriorTrabajo.Size = new System.Drawing.Size(183, 29);
            this.txtNoInteriorTrabajo.TabIndex = 125;
            this.txtNoInteriorTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.ForeColor = System.Drawing.Color.White;
            this.Label37.Location = new System.Drawing.Point(451, 202);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(56, 13);
            this.Label37.TabIndex = 124;
            this.Label37.Text = "No Interior";
            // 
            // txtNoExteriorTrabajo
            // 
            this.txtNoExteriorTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoExteriorTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoExteriorTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtNoExteriorTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtNoExteriorTrabajo.HintText = "";
            this.txtNoExteriorTrabajo.isPassword = false;
            this.txtNoExteriorTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoExteriorTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoExteriorTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoExteriorTrabajo.LineThickness = 3;
            this.txtNoExteriorTrabajo.Location = new System.Drawing.Point(247, 219);
            this.txtNoExteriorTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExteriorTrabajo.Name = "txtNoExteriorTrabajo";
            this.txtNoExteriorTrabajo.Size = new System.Drawing.Size(199, 29);
            this.txtNoExteriorTrabajo.TabIndex = 123;
            this.txtNoExteriorTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.ForeColor = System.Drawing.Color.White;
            this.Label36.Location = new System.Drawing.Point(244, 202);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(59, 13);
            this.Label36.TabIndex = 122;
            this.Label36.Text = "No Exterior";
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObjetivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtObjetivo.ForeColor = System.Drawing.Color.White;
            this.txtObjetivo.HintForeColor = System.Drawing.Color.White;
            this.txtObjetivo.HintText = "";
            this.txtObjetivo.isPassword = false;
            this.txtObjetivo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtObjetivo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtObjetivo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtObjetivo.LineThickness = 3;
            this.txtObjetivo.Location = new System.Drawing.Point(26, 351);
            this.txtObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(607, 29);
            this.txtObjetivo.TabIndex = 121;
            this.txtObjetivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.Color.White;
            this.Label22.Location = new System.Drawing.Point(23, 334);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(98, 13);
            this.Label22.TabIndex = 120;
            this.Label22.Text = "Objetivo del crédito";
            // 
            // txtFrecuenciaCobro
            // 
            this.txtFrecuenciaCobro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrecuenciaCobro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFrecuenciaCobro.ForeColor = System.Drawing.Color.White;
            this.txtFrecuenciaCobro.HintForeColor = System.Drawing.Color.White;
            this.txtFrecuenciaCobro.HintText = "";
            this.txtFrecuenciaCobro.isPassword = false;
            this.txtFrecuenciaCobro.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFrecuenciaCobro.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFrecuenciaCobro.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFrecuenciaCobro.LineThickness = 3;
            this.txtFrecuenciaCobro.Location = new System.Drawing.Point(645, 142);
            this.txtFrecuenciaCobro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrecuenciaCobro.Name = "txtFrecuenciaCobro";
            this.txtFrecuenciaCobro.Size = new System.Drawing.Size(217, 29);
            this.txtFrecuenciaCobro.TabIndex = 119;
            this.txtFrecuenciaCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.ForeColor = System.Drawing.Color.White;
            this.Label23.Location = new System.Drawing.Point(642, 125);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(105, 13);
            this.Label23.TabIndex = 118;
            this.Label23.Text = "Frecuencia de cobro";
            // 
            // txtJefeDirecto
            // 
            this.txtJefeDirecto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJefeDirecto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtJefeDirecto.ForeColor = System.Drawing.Color.White;
            this.txtJefeDirecto.HintForeColor = System.Drawing.Color.White;
            this.txtJefeDirecto.HintText = "";
            this.txtJefeDirecto.isPassword = false;
            this.txtJefeDirecto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtJefeDirecto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtJefeDirecto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtJefeDirecto.LineThickness = 3;
            this.txtJefeDirecto.Location = new System.Drawing.Point(26, 284);
            this.txtJefeDirecto.Margin = new System.Windows.Forms.Padding(4);
            this.txtJefeDirecto.Name = "txtJefeDirecto";
            this.txtJefeDirecto.Size = new System.Drawing.Size(213, 29);
            this.txtJefeDirecto.TabIndex = 117;
            this.txtJefeDirecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Location = new System.Drawing.Point(23, 267);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(116, 13);
            this.Label24.TabIndex = 116;
            this.Label24.Text = "Nombre del jefe directo";
            // 
            // txtTelefonoTrabajo
            // 
            this.txtTelefonoTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefonoTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtTelefonoTrabajo.HintText = "";
            this.txtTelefonoTrabajo.isPassword = false;
            this.txtTelefonoTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefonoTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefonoTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefonoTrabajo.LineThickness = 3;
            this.txtTelefonoTrabajo.Location = new System.Drawing.Point(454, 284);
            this.txtTelefonoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoTrabajo.Name = "txtTelefonoTrabajo";
            this.txtTelefonoTrabajo.Size = new System.Drawing.Size(183, 29);
            this.txtTelefonoTrabajo.TabIndex = 115;
            this.txtTelefonoTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.Color.White;
            this.Label25.Location = new System.Drawing.Point(451, 267);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(49, 13);
            this.Label25.TabIndex = 114;
            this.Label25.Text = "Teléfono";
            // 
            // txtColoniaTrabajo
            // 
            this.txtColoniaTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColoniaTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColoniaTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtColoniaTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtColoniaTrabajo.HintText = "";
            this.txtColoniaTrabajo.isPassword = false;
            this.txtColoniaTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtColoniaTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColoniaTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtColoniaTrabajo.LineThickness = 3;
            this.txtColoniaTrabajo.Location = new System.Drawing.Point(247, 284);
            this.txtColoniaTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtColoniaTrabajo.Name = "txtColoniaTrabajo";
            this.txtColoniaTrabajo.Size = new System.Drawing.Size(199, 29);
            this.txtColoniaTrabajo.TabIndex = 113;
            this.txtColoniaTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ForeColor = System.Drawing.Color.White;
            this.Label26.Location = new System.Drawing.Point(244, 267);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(42, 13);
            this.Label26.TabIndex = 112;
            this.Label26.Text = "Colonia";
            // 
            // txtCalleTrabajo
            // 
            this.txtCalleTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalleTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCalleTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtCalleTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtCalleTrabajo.HintText = "";
            this.txtCalleTrabajo.isPassword = false;
            this.txtCalleTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCalleTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCalleTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCalleTrabajo.LineThickness = 3;
            this.txtCalleTrabajo.Location = new System.Drawing.Point(26, 219);
            this.txtCalleTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalleTrabajo.Name = "txtCalleTrabajo";
            this.txtCalleTrabajo.Size = new System.Drawing.Size(213, 29);
            this.txtCalleTrabajo.TabIndex = 111;
            this.txtCalleTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.ForeColor = System.Drawing.Color.White;
            this.Label27.Location = new System.Drawing.Point(23, 202);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(98, 13);
            this.Label27.TabIndex = 110;
            this.Label27.Text = "Calle donde trabaja";
            // 
            // txtIngresoPromedio
            // 
            this.txtIngresoPromedio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIngresoPromedio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIngresoPromedio.ForeColor = System.Drawing.Color.White;
            this.txtIngresoPromedio.HintForeColor = System.Drawing.Color.White;
            this.txtIngresoPromedio.HintText = "";
            this.txtIngresoPromedio.isPassword = false;
            this.txtIngresoPromedio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIngresoPromedio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIngresoPromedio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIngresoPromedio.LineThickness = 3;
            this.txtIngresoPromedio.Location = new System.Drawing.Point(454, 142);
            this.txtIngresoPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresoPromedio.Name = "txtIngresoPromedio";
            this.txtIngresoPromedio.Size = new System.Drawing.Size(183, 29);
            this.txtIngresoPromedio.TabIndex = 109;
            this.txtIngresoPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.ForeColor = System.Drawing.Color.White;
            this.Label28.Location = new System.Drawing.Point(451, 125);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(132, 13);
            this.Label28.TabIndex = 108;
            this.Label28.Text = "Ingreso Promedio Mensual";
            // 
            // txtTipoEstablecimiento
            // 
            this.txtTipoEstablecimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipoEstablecimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipoEstablecimiento.ForeColor = System.Drawing.Color.White;
            this.txtTipoEstablecimiento.HintForeColor = System.Drawing.Color.White;
            this.txtTipoEstablecimiento.HintText = "";
            this.txtTipoEstablecimiento.isPassword = false;
            this.txtTipoEstablecimiento.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTipoEstablecimiento.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipoEstablecimiento.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTipoEstablecimiento.LineThickness = 3;
            this.txtTipoEstablecimiento.Location = new System.Drawing.Point(247, 142);
            this.txtTipoEstablecimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoEstablecimiento.Name = "txtTipoEstablecimiento";
            this.txtTipoEstablecimiento.Size = new System.Drawing.Size(199, 29);
            this.txtTipoEstablecimiento.TabIndex = 107;
            this.txtTipoEstablecimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.ForeColor = System.Drawing.Color.White;
            this.Label29.Location = new System.Drawing.Point(244, 125);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(120, 13);
            this.Label29.TabIndex = 106;
            this.Label29.Text = "Tipo de Establecimiento";
            // 
            // txtHorariosTrabajo
            // 
            this.txtHorariosTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorariosTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHorariosTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtHorariosTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtHorariosTrabajo.HintText = "";
            this.txtHorariosTrabajo.isPassword = false;
            this.txtHorariosTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHorariosTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHorariosTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHorariosTrabajo.LineThickness = 3;
            this.txtHorariosTrabajo.Location = new System.Drawing.Point(26, 142);
            this.txtHorariosTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorariosTrabajo.Name = "txtHorariosTrabajo";
            this.txtHorariosTrabajo.Size = new System.Drawing.Size(213, 29);
            this.txtHorariosTrabajo.TabIndex = 105;
            this.txtHorariosTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.ForeColor = System.Drawing.Color.White;
            this.Label30.Location = new System.Drawing.Point(23, 125);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(46, 13);
            this.Label30.TabIndex = 104;
            this.Label30.Text = "Horarios";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAntiguedad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAntiguedad.ForeColor = System.Drawing.Color.White;
            this.txtAntiguedad.HintForeColor = System.Drawing.Color.White;
            this.txtAntiguedad.HintText = "";
            this.txtAntiguedad.isPassword = false;
            this.txtAntiguedad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAntiguedad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAntiguedad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAntiguedad.LineThickness = 3;
            this.txtAntiguedad.Location = new System.Drawing.Point(645, 67);
            this.txtAntiguedad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(217, 29);
            this.txtAntiguedad.TabIndex = 103;
            this.txtAntiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.ForeColor = System.Drawing.Color.White;
            this.Label31.Location = new System.Drawing.Point(642, 50);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(61, 13);
            this.Label31.TabIndex = 102;
            this.Label31.Text = "Antigüedad";
            // 
            // txtVende
            // 
            this.txtVende.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVende.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVende.ForeColor = System.Drawing.Color.White;
            this.txtVende.HintForeColor = System.Drawing.Color.White;
            this.txtVende.HintText = "";
            this.txtVende.isPassword = false;
            this.txtVende.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtVende.LineIdleColor = System.Drawing.Color.Gray;
            this.txtVende.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtVende.LineThickness = 3;
            this.txtVende.Location = new System.Drawing.Point(454, 67);
            this.txtVende.Margin = new System.Windows.Forms.Padding(4);
            this.txtVende.Name = "txtVende";
            this.txtVende.Size = new System.Drawing.Size(183, 29);
            this.txtVende.TabIndex = 101;
            this.txtVende.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.ForeColor = System.Drawing.Color.White;
            this.Label32.Location = new System.Drawing.Point(451, 50);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(163, 13);
            this.Label32.TabIndex = 100;
            this.Label32.Text = "¿Qué vende? (si es comerciante)";
            // 
            // txtSeDedica
            // 
            this.txtSeDedica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeDedica.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSeDedica.ForeColor = System.Drawing.Color.White;
            this.txtSeDedica.HintForeColor = System.Drawing.Color.White;
            this.txtSeDedica.HintText = "";
            this.txtSeDedica.isPassword = false;
            this.txtSeDedica.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSeDedica.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSeDedica.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSeDedica.LineThickness = 3;
            this.txtSeDedica.Location = new System.Drawing.Point(247, 67);
            this.txtSeDedica.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeDedica.Name = "txtSeDedica";
            this.txtSeDedica.Size = new System.Drawing.Size(199, 29);
            this.txtSeDedica.TabIndex = 99;
            this.txtSeDedica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.ForeColor = System.Drawing.Color.White;
            this.Label33.Location = new System.Drawing.Point(244, 50);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(84, 13);
            this.Label33.TabIndex = 98;
            this.Label33.Text = "Usted se dedica";
            // 
            // txtNombreLugarTrabajo
            // 
            this.txtNombreLugarTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreLugarTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreLugarTrabajo.ForeColor = System.Drawing.Color.White;
            this.txtNombreLugarTrabajo.HintForeColor = System.Drawing.Color.White;
            this.txtNombreLugarTrabajo.HintText = "";
            this.txtNombreLugarTrabajo.isPassword = false;
            this.txtNombreLugarTrabajo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombreLugarTrabajo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreLugarTrabajo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombreLugarTrabajo.LineThickness = 3;
            this.txtNombreLugarTrabajo.Location = new System.Drawing.Point(26, 67);
            this.txtNombreLugarTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLugarTrabajo.Name = "txtNombreLugarTrabajo";
            this.txtNombreLugarTrabajo.Size = new System.Drawing.Size(213, 29);
            this.txtNombreLugarTrabajo.TabIndex = 97;
            this.txtNombreLugarTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.ForeColor = System.Drawing.Color.White;
            this.Label34.Location = new System.Drawing.Point(23, 50);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(155, 13);
            this.Label34.TabIndex = 96;
            this.Label34.Text = "Nombre del lugar donde trabaja";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage3.Controls.Add(this.GroupBox3);
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Controls.Add(this.txtRelacionR2);
            this.TabPage3.Controls.Add(this.Label18);
            this.TabPage3.Controls.Add(this.txtTelefonoR2);
            this.TabPage3.Controls.Add(this.Label19);
            this.TabPage3.Controls.Add(this.txtNombreR2);
            this.TabPage3.Controls.Add(this.Label20);
            this.TabPage3.Controls.Add(this.MonoFlat_HeaderLabel3);
            this.TabPage3.Controls.Add(this.MonoFlat_HeaderLabel2);
            this.TabPage3.Controls.Add(this.MonoFlat_Separator1);
            this.TabPage3.Controls.Add(this.txtRelacionR1);
            this.TabPage3.Controls.Add(this.Label41);
            this.TabPage3.Controls.Add(this.txtTelefonoR1);
            this.TabPage3.Controls.Add(this.Label42);
            this.TabPage3.Controls.Add(this.txtNombreR1);
            this.TabPage3.Controls.Add(this.Label43);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1133, 519);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Referencias";
            this.TabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtColoniaR2);
            this.GroupBox3.Controls.Add(this.txtNoIntR2);
            this.GroupBox3.Controls.Add(this.Label62);
            this.GroupBox3.Controls.Add(this.txtNoExtR2);
            this.GroupBox3.Controls.Add(this.Label63);
            this.GroupBox3.Controls.Add(this.txtCalleR2);
            this.GroupBox3.Controls.Add(this.Label64);
            this.GroupBox3.Controls.Add(this.txtCodigoPostalR2);
            this.GroupBox3.Controls.Add(this.Label65);
            this.GroupBox3.Controls.Add(this.Label66);
            this.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox3.Location = new System.Drawing.Point(27, 376);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(1050, 100);
            this.GroupBox3.TabIndex = 147;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Dirección";
            // 
            // txtColoniaR2
            // 
            this.txtColoniaR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColoniaR2.Enabled = false;
            this.txtColoniaR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColoniaR2.ForeColor = System.Drawing.Color.White;
            this.txtColoniaR2.HintForeColor = System.Drawing.Color.White;
            this.txtColoniaR2.HintText = "";
            this.txtColoniaR2.isPassword = false;
            this.txtColoniaR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtColoniaR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColoniaR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtColoniaR2.LineThickness = 3;
            this.txtColoniaR2.Location = new System.Drawing.Point(128, 42);
            this.txtColoniaR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtColoniaR2.Name = "txtColoniaR2";
            this.txtColoniaR2.Size = new System.Drawing.Size(240, 29);
            this.txtColoniaR2.TabIndex = 147;
            this.txtColoniaR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNoIntR2
            // 
            this.txtNoIntR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoIntR2.Enabled = false;
            this.txtNoIntR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoIntR2.ForeColor = System.Drawing.Color.White;
            this.txtNoIntR2.HintForeColor = System.Drawing.Color.White;
            this.txtNoIntR2.HintText = "";
            this.txtNoIntR2.isPassword = false;
            this.txtNoIntR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoIntR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoIntR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoIntR2.LineThickness = 3;
            this.txtNoIntR2.Location = new System.Drawing.Point(647, 42);
            this.txtNoIntR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoIntR2.Name = "txtNoIntR2";
            this.txtNoIntR2.Size = new System.Drawing.Size(102, 29);
            this.txtNoIntR2.TabIndex = 141;
            this.txtNoIntR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label62
            // 
            this.Label62.AutoSize = true;
            this.Label62.ForeColor = System.Drawing.Color.White;
            this.Label62.Location = new System.Drawing.Point(644, 25);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(58, 13);
            this.Label62.TabIndex = 144;
            this.Label62.Text = "No. interior";
            // 
            // txtNoExtR2
            // 
            this.txtNoExtR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoExtR2.Enabled = false;
            this.txtNoExtR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoExtR2.ForeColor = System.Drawing.Color.White;
            this.txtNoExtR2.HintForeColor = System.Drawing.Color.White;
            this.txtNoExtR2.HintText = "";
            this.txtNoExtR2.isPassword = false;
            this.txtNoExtR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoExtR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoExtR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoExtR2.LineThickness = 3;
            this.txtNoExtR2.Location = new System.Drawing.Point(773, 42);
            this.txtNoExtR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExtR2.Name = "txtNoExtR2";
            this.txtNoExtR2.Size = new System.Drawing.Size(93, 29);
            this.txtNoExtR2.TabIndex = 140;
            this.txtNoExtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label63
            // 
            this.Label63.AutoSize = true;
            this.Label63.ForeColor = System.Drawing.Color.White;
            this.Label63.Location = new System.Drawing.Point(770, 25);
            this.Label63.Name = "Label63";
            this.Label63.Size = new System.Drawing.Size(61, 13);
            this.Label63.TabIndex = 143;
            this.Label63.Text = "No. exterior";
            // 
            // txtCalleR2
            // 
            this.txtCalleR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalleR2.Enabled = false;
            this.txtCalleR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCalleR2.ForeColor = System.Drawing.Color.White;
            this.txtCalleR2.HintForeColor = System.Drawing.Color.White;
            this.txtCalleR2.HintText = "";
            this.txtCalleR2.isPassword = false;
            this.txtCalleR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCalleR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCalleR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCalleR2.LineThickness = 3;
            this.txtCalleR2.Location = new System.Drawing.Point(383, 42);
            this.txtCalleR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalleR2.Name = "txtCalleR2";
            this.txtCalleR2.Size = new System.Drawing.Size(214, 29);
            this.txtCalleR2.TabIndex = 139;
            this.txtCalleR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label64
            // 
            this.Label64.AutoSize = true;
            this.Label64.ForeColor = System.Drawing.Color.White;
            this.Label64.Location = new System.Drawing.Point(380, 25);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(30, 13);
            this.Label64.TabIndex = 142;
            this.Label64.Text = "Calle";
            // 
            // txtCodigoPostalR2
            // 
            this.txtCodigoPostalR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostalR2.Enabled = false;
            this.txtCodigoPostalR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostalR2.ForeColor = System.Drawing.Color.White;
            this.txtCodigoPostalR2.HintForeColor = System.Drawing.Color.White;
            this.txtCodigoPostalR2.HintText = "";
            this.txtCodigoPostalR2.isPassword = false;
            this.txtCodigoPostalR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigoPostalR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoPostalR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigoPostalR2.LineThickness = 3;
            this.txtCodigoPostalR2.Location = new System.Drawing.Point(7, 42);
            this.txtCodigoPostalR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostalR2.Name = "txtCodigoPostalR2";
            this.txtCodigoPostalR2.Size = new System.Drawing.Size(89, 29);
            this.txtCodigoPostalR2.TabIndex = 135;
            this.txtCodigoPostalR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label65
            // 
            this.Label65.AutoSize = true;
            this.Label65.ForeColor = System.Drawing.Color.White;
            this.Label65.Location = new System.Drawing.Point(4, 25);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(72, 13);
            this.Label65.TabIndex = 136;
            this.Label65.Text = "Código Postal";
            // 
            // Label66
            // 
            this.Label66.AutoSize = true;
            this.Label66.ForeColor = System.Drawing.Color.White;
            this.Label66.Location = new System.Drawing.Point(125, 25);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(42, 13);
            this.Label66.TabIndex = 137;
            this.Label66.Text = "Colonia";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtColoniaR1);
            this.GroupBox2.Controls.Add(this.txtNoIntR1);
            this.GroupBox2.Controls.Add(this.Label57);
            this.GroupBox2.Controls.Add(this.txtNoExtR1);
            this.GroupBox2.Controls.Add(this.Label58);
            this.GroupBox2.Controls.Add(this.txtCalleR1);
            this.GroupBox2.Controls.Add(this.Label59);
            this.GroupBox2.Controls.Add(this.txtCodigoPostalR1);
            this.GroupBox2.Controls.Add(this.Label60);
            this.GroupBox2.Controls.Add(this.Label61);
            this.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Location = new System.Drawing.Point(27, 128);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(1050, 100);
            this.GroupBox2.TabIndex = 141;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Dirección";
            // 
            // txtColoniaR1
            // 
            this.txtColoniaR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColoniaR1.Enabled = false;
            this.txtColoniaR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtColoniaR1.ForeColor = System.Drawing.Color.White;
            this.txtColoniaR1.HintForeColor = System.Drawing.Color.White;
            this.txtColoniaR1.HintText = "";
            this.txtColoniaR1.isPassword = false;
            this.txtColoniaR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtColoniaR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtColoniaR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtColoniaR1.LineThickness = 3;
            this.txtColoniaR1.Location = new System.Drawing.Point(128, 42);
            this.txtColoniaR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtColoniaR1.Name = "txtColoniaR1";
            this.txtColoniaR1.Size = new System.Drawing.Size(240, 29);
            this.txtColoniaR1.TabIndex = 146;
            this.txtColoniaR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNoIntR1
            // 
            this.txtNoIntR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoIntR1.Enabled = false;
            this.txtNoIntR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoIntR1.ForeColor = System.Drawing.Color.White;
            this.txtNoIntR1.HintForeColor = System.Drawing.Color.White;
            this.txtNoIntR1.HintText = "";
            this.txtNoIntR1.isPassword = false;
            this.txtNoIntR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoIntR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoIntR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoIntR1.LineThickness = 3;
            this.txtNoIntR1.Location = new System.Drawing.Point(647, 42);
            this.txtNoIntR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoIntR1.Name = "txtNoIntR1";
            this.txtNoIntR1.Size = new System.Drawing.Size(102, 29);
            this.txtNoIntR1.TabIndex = 141;
            this.txtNoIntR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label57
            // 
            this.Label57.AutoSize = true;
            this.Label57.ForeColor = System.Drawing.Color.White;
            this.Label57.Location = new System.Drawing.Point(644, 25);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(58, 13);
            this.Label57.TabIndex = 144;
            this.Label57.Text = "No. interior";
            // 
            // txtNoExtR1
            // 
            this.txtNoExtR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoExtR1.Enabled = false;
            this.txtNoExtR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNoExtR1.ForeColor = System.Drawing.Color.White;
            this.txtNoExtR1.HintForeColor = System.Drawing.Color.White;
            this.txtNoExtR1.HintText = "";
            this.txtNoExtR1.isPassword = false;
            this.txtNoExtR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNoExtR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNoExtR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNoExtR1.LineThickness = 3;
            this.txtNoExtR1.Location = new System.Drawing.Point(773, 42);
            this.txtNoExtR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoExtR1.Name = "txtNoExtR1";
            this.txtNoExtR1.Size = new System.Drawing.Size(93, 29);
            this.txtNoExtR1.TabIndex = 140;
            this.txtNoExtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label58
            // 
            this.Label58.AutoSize = true;
            this.Label58.ForeColor = System.Drawing.Color.White;
            this.Label58.Location = new System.Drawing.Point(770, 25);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(61, 13);
            this.Label58.TabIndex = 143;
            this.Label58.Text = "No. exterior";
            // 
            // txtCalleR1
            // 
            this.txtCalleR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalleR1.Enabled = false;
            this.txtCalleR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCalleR1.ForeColor = System.Drawing.Color.White;
            this.txtCalleR1.HintForeColor = System.Drawing.Color.White;
            this.txtCalleR1.HintText = "";
            this.txtCalleR1.isPassword = false;
            this.txtCalleR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCalleR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCalleR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCalleR1.LineThickness = 3;
            this.txtCalleR1.Location = new System.Drawing.Point(383, 42);
            this.txtCalleR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalleR1.Name = "txtCalleR1";
            this.txtCalleR1.Size = new System.Drawing.Size(214, 29);
            this.txtCalleR1.TabIndex = 139;
            this.txtCalleR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label59
            // 
            this.Label59.AutoSize = true;
            this.Label59.ForeColor = System.Drawing.Color.White;
            this.Label59.Location = new System.Drawing.Point(380, 25);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(30, 13);
            this.Label59.TabIndex = 142;
            this.Label59.Text = "Calle";
            // 
            // txtCodigoPostalR1
            // 
            this.txtCodigoPostalR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPostalR1.Enabled = false;
            this.txtCodigoPostalR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoPostalR1.ForeColor = System.Drawing.Color.White;
            this.txtCodigoPostalR1.HintForeColor = System.Drawing.Color.White;
            this.txtCodigoPostalR1.HintText = "";
            this.txtCodigoPostalR1.isPassword = false;
            this.txtCodigoPostalR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigoPostalR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoPostalR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigoPostalR1.LineThickness = 3;
            this.txtCodigoPostalR1.Location = new System.Drawing.Point(7, 42);
            this.txtCodigoPostalR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostalR1.Name = "txtCodigoPostalR1";
            this.txtCodigoPostalR1.Size = new System.Drawing.Size(89, 29);
            this.txtCodigoPostalR1.TabIndex = 135;
            this.txtCodigoPostalR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label60
            // 
            this.Label60.AutoSize = true;
            this.Label60.ForeColor = System.Drawing.Color.White;
            this.Label60.Location = new System.Drawing.Point(4, 25);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(72, 13);
            this.Label60.TabIndex = 136;
            this.Label60.Text = "Código Postal";
            // 
            // Label61
            // 
            this.Label61.AutoSize = true;
            this.Label61.ForeColor = System.Drawing.Color.White;
            this.Label61.Location = new System.Drawing.Point(125, 25);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(42, 13);
            this.Label61.TabIndex = 137;
            this.Label61.Text = "Colonia";
            // 
            // txtRelacionR2
            // 
            this.txtRelacionR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRelacionR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRelacionR2.ForeColor = System.Drawing.Color.White;
            this.txtRelacionR2.HintForeColor = System.Drawing.Color.White;
            this.txtRelacionR2.HintText = "";
            this.txtRelacionR2.isPassword = false;
            this.txtRelacionR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRelacionR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRelacionR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRelacionR2.LineThickness = 3;
            this.txtRelacionR2.Location = new System.Drawing.Point(455, 319);
            this.txtRelacionR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelacionR2.Name = "txtRelacionR2";
            this.txtRelacionR2.Size = new System.Drawing.Size(209, 29);
            this.txtRelacionR2.TabIndex = 135;
            this.txtRelacionR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(452, 302);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(49, 13);
            this.Label18.TabIndex = 134;
            this.Label18.Text = "Relación";
            // 
            // txtTelefonoR2
            // 
            this.txtTelefonoR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefonoR2.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoR2.HintForeColor = System.Drawing.Color.White;
            this.txtTelefonoR2.HintText = "";
            this.txtTelefonoR2.isPassword = false;
            this.txtTelefonoR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefonoR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefonoR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefonoR2.LineThickness = 3;
            this.txtTelefonoR2.Location = new System.Drawing.Point(248, 319);
            this.txtTelefonoR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoR2.Name = "txtTelefonoR2";
            this.txtTelefonoR2.Size = new System.Drawing.Size(199, 29);
            this.txtTelefonoR2.TabIndex = 133;
            this.txtTelefonoR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(245, 302);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(49, 13);
            this.Label19.TabIndex = 132;
            this.Label19.Text = "Teléfono";
            // 
            // txtNombreR2
            // 
            this.txtNombreR2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreR2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreR2.ForeColor = System.Drawing.Color.White;
            this.txtNombreR2.HintForeColor = System.Drawing.Color.White;
            this.txtNombreR2.HintText = "";
            this.txtNombreR2.isPassword = false;
            this.txtNombreR2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombreR2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreR2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombreR2.LineThickness = 3;
            this.txtNombreR2.Location = new System.Drawing.Point(27, 319);
            this.txtNombreR2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreR2.Name = "txtNombreR2";
            this.txtNombreR2.Size = new System.Drawing.Size(213, 29);
            this.txtNombreR2.TabIndex = 131;
            this.txtNombreR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.ForeColor = System.Drawing.Color.White;
            this.Label20.Location = new System.Drawing.Point(24, 302);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(44, 13);
            this.Label20.TabIndex = 130;
            this.Label20.Text = "Nombre";
            // 
            // MonoFlat_HeaderLabel3
            // 
            this.MonoFlat_HeaderLabel3.AutoSize = true;
            this.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel3.Location = new System.Drawing.Point(23, 263);
            this.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            this.MonoFlat_HeaderLabel3.Size = new System.Drawing.Size(96, 20);
            this.MonoFlat_HeaderLabel3.TabIndex = 129;
            this.MonoFlat_HeaderLabel3.Text = "Referencia 2";
            // 
            // MonoFlat_HeaderLabel2
            // 
            this.MonoFlat_HeaderLabel2.AutoSize = true;
            this.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel2.Location = new System.Drawing.Point(23, 15);
            this.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            this.MonoFlat_HeaderLabel2.Size = new System.Drawing.Size(96, 20);
            this.MonoFlat_HeaderLabel2.TabIndex = 32;
            this.MonoFlat_HeaderLabel2.Text = "Referencia 1";
            // 
            // MonoFlat_Separator1
            // 
            this.MonoFlat_Separator1.Location = new System.Drawing.Point(3, 245);
            this.MonoFlat_Separator1.Name = "MonoFlat_Separator1";
            this.MonoFlat_Separator1.Size = new System.Drawing.Size(1124, 10);
            this.MonoFlat_Separator1.TabIndex = 128;
            this.MonoFlat_Separator1.Text = "MonoFlat_Separator1";
            // 
            // txtRelacionR1
            // 
            this.txtRelacionR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRelacionR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRelacionR1.ForeColor = System.Drawing.Color.White;
            this.txtRelacionR1.HintForeColor = System.Drawing.Color.White;
            this.txtRelacionR1.HintText = "";
            this.txtRelacionR1.isPassword = false;
            this.txtRelacionR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRelacionR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRelacionR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRelacionR1.LineThickness = 3;
            this.txtRelacionR1.Location = new System.Drawing.Point(455, 79);
            this.txtRelacionR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelacionR1.Name = "txtRelacionR1";
            this.txtRelacionR1.Size = new System.Drawing.Size(209, 29);
            this.txtRelacionR1.TabIndex = 127;
            this.txtRelacionR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.ForeColor = System.Drawing.Color.White;
            this.Label41.Location = new System.Drawing.Point(452, 62);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(49, 13);
            this.Label41.TabIndex = 126;
            this.Label41.Text = "Relación";
            // 
            // txtTelefonoR1
            // 
            this.txtTelefonoR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefonoR1.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoR1.HintForeColor = System.Drawing.Color.White;
            this.txtTelefonoR1.HintText = "";
            this.txtTelefonoR1.isPassword = false;
            this.txtTelefonoR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefonoR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefonoR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefonoR1.LineThickness = 3;
            this.txtTelefonoR1.Location = new System.Drawing.Point(248, 79);
            this.txtTelefonoR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoR1.Name = "txtTelefonoR1";
            this.txtTelefonoR1.Size = new System.Drawing.Size(199, 29);
            this.txtTelefonoR1.TabIndex = 125;
            this.txtTelefonoR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.ForeColor = System.Drawing.Color.White;
            this.Label42.Location = new System.Drawing.Point(245, 62);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(49, 13);
            this.Label42.TabIndex = 124;
            this.Label42.Text = "Teléfono";
            // 
            // txtNombreR1
            // 
            this.txtNombreR1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreR1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreR1.ForeColor = System.Drawing.Color.White;
            this.txtNombreR1.HintForeColor = System.Drawing.Color.White;
            this.txtNombreR1.HintText = "";
            this.txtNombreR1.isPassword = false;
            this.txtNombreR1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombreR1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreR1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombreR1.LineThickness = 3;
            this.txtNombreR1.Location = new System.Drawing.Point(27, 79);
            this.txtNombreR1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreR1.Name = "txtNombreR1";
            this.txtNombreR1.Size = new System.Drawing.Size(213, 29);
            this.txtNombreR1.TabIndex = 123;
            this.txtNombreR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.ForeColor = System.Drawing.Color.White;
            this.Label43.Location = new System.Drawing.Point(24, 62);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(44, 13);
            this.Label43.TabIndex = 122;
            this.Label43.Text = "Nombre";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage4.Controls.Add(this.txtFrecuenciaInversion);
            this.TabPage4.Controls.Add(this.Label40);
            this.TabPage4.Controls.Add(this.txtEmpleados);
            this.TabPage4.Controls.Add(this.Label44);
            this.TabPage4.Controls.Add(this.txtPersonasDependientes);
            this.TabPage4.Controls.Add(this.Label45);
            this.TabPage4.Controls.Add(this.txtServicios);
            this.TabPage4.Controls.Add(this.Label46);
            this.TabPage4.Controls.Add(this.txtDeudas);
            this.TabPage4.Controls.Add(this.Label47);
            this.TabPage4.Controls.Add(this.txtFamiliasEnCasa);
            this.TabPage4.Controls.Add(this.Label48);
            this.TabPage4.Controls.Add(this.txtEnfermedad);
            this.TabPage4.Controls.Add(this.Label49);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(1133, 519);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Otros";
            // 
            // txtFrecuenciaInversion
            // 
            this.txtFrecuenciaInversion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrecuenciaInversion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFrecuenciaInversion.ForeColor = System.Drawing.Color.White;
            this.txtFrecuenciaInversion.HintForeColor = System.Drawing.Color.White;
            this.txtFrecuenciaInversion.HintText = "";
            this.txtFrecuenciaInversion.isPassword = false;
            this.txtFrecuenciaInversion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFrecuenciaInversion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFrecuenciaInversion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFrecuenciaInversion.LineThickness = 3;
            this.txtFrecuenciaInversion.Location = new System.Drawing.Point(454, 115);
            this.txtFrecuenciaInversion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrecuenciaInversion.Name = "txtFrecuenciaInversion";
            this.txtFrecuenciaInversion.Size = new System.Drawing.Size(209, 29);
            this.txtFrecuenciaInversion.TabIndex = 135;
            this.txtFrecuenciaInversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.ForeColor = System.Drawing.Color.White;
            this.Label40.Location = new System.Drawing.Point(451, 98);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(314, 13);
            this.Label40.TabIndex = 134;
            this.Label40.Text = "Frecuencia de invesión en su negocio (Solo en caso de ser APC)";
            // 
            // txtEmpleados
            // 
            this.txtEmpleados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmpleados.ForeColor = System.Drawing.Color.White;
            this.txtEmpleados.HintForeColor = System.Drawing.Color.White;
            this.txtEmpleados.HintText = "";
            this.txtEmpleados.isPassword = false;
            this.txtEmpleados.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmpleados.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmpleados.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmpleados.LineThickness = 3;
            this.txtEmpleados.Location = new System.Drawing.Point(247, 115);
            this.txtEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpleados.Name = "txtEmpleados";
            this.txtEmpleados.Size = new System.Drawing.Size(199, 29);
            this.txtEmpleados.TabIndex = 133;
            this.txtEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.ForeColor = System.Drawing.Color.White;
            this.Label44.Location = new System.Drawing.Point(244, 98);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(186, 13);
            this.Label44.TabIndex = 132;
            this.Label44.Text = "Empleados (Sólo en caso de ser APC)";
            // 
            // txtPersonasDependientes
            // 
            this.txtPersonasDependientes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonasDependientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonasDependientes.ForeColor = System.Drawing.Color.White;
            this.txtPersonasDependientes.HintForeColor = System.Drawing.Color.White;
            this.txtPersonasDependientes.HintText = "";
            this.txtPersonasDependientes.isPassword = false;
            this.txtPersonasDependientes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPersonasDependientes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPersonasDependientes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPersonasDependientes.LineThickness = 3;
            this.txtPersonasDependientes.Location = new System.Drawing.Point(26, 115);
            this.txtPersonasDependientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonasDependientes.Name = "txtPersonasDependientes";
            this.txtPersonasDependientes.Size = new System.Drawing.Size(202, 29);
            this.txtPersonasDependientes.TabIndex = 131;
            this.txtPersonasDependientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.ForeColor = System.Drawing.Color.White;
            this.Label45.Location = new System.Drawing.Point(23, 98);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(185, 13);
            this.Label45.TabIndex = 130;
            this.Label45.Text = "Personas dependientes del solicitante";
            // 
            // txtServicios
            // 
            this.txtServicios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtServicios.ForeColor = System.Drawing.Color.White;
            this.txtServicios.HintForeColor = System.Drawing.Color.White;
            this.txtServicios.HintText = "";
            this.txtServicios.isPassword = false;
            this.txtServicios.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtServicios.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServicios.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtServicios.LineThickness = 3;
            this.txtServicios.Location = new System.Drawing.Point(752, 40);
            this.txtServicios.Margin = new System.Windows.Forms.Padding(4);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(374, 29);
            this.txtServicios.TabIndex = 129;
            this.txtServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.ForeColor = System.Drawing.Color.White;
            this.Label46.Location = new System.Drawing.Point(749, 23);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(216, 13);
            this.Label46.TabIndex = 128;
            this.Label46.Text = "Servicios con los que cuenta en su domicilio";
            // 
            // txtDeudas
            // 
            this.txtDeudas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeudas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDeudas.ForeColor = System.Drawing.Color.White;
            this.txtDeudas.HintForeColor = System.Drawing.Color.White;
            this.txtDeudas.HintText = "";
            this.txtDeudas.isPassword = false;
            this.txtDeudas.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDeudas.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDeudas.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDeudas.LineThickness = 3;
            this.txtDeudas.Location = new System.Drawing.Point(519, 40);
            this.txtDeudas.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeudas.Name = "txtDeudas";
            this.txtDeudas.Size = new System.Drawing.Size(225, 29);
            this.txtDeudas.TabIndex = 127;
            this.txtDeudas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label47
            // 
            this.Label47.AutoSize = true;
            this.Label47.ForeColor = System.Drawing.Color.White;
            this.Label47.Location = new System.Drawing.Point(516, 23);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(220, 13);
            this.Label47.TabIndex = 126;
            this.Label47.Text = "¿Tiene más deudas? (Especifique con quién)";
            // 
            // txtFamiliasEnCasa
            // 
            this.txtFamiliasEnCasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFamiliasEnCasa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFamiliasEnCasa.ForeColor = System.Drawing.Color.White;
            this.txtFamiliasEnCasa.HintForeColor = System.Drawing.Color.White;
            this.txtFamiliasEnCasa.HintText = "";
            this.txtFamiliasEnCasa.isPassword = false;
            this.txtFamiliasEnCasa.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFamiliasEnCasa.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFamiliasEnCasa.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFamiliasEnCasa.LineThickness = 3;
            this.txtFamiliasEnCasa.Location = new System.Drawing.Point(312, 40);
            this.txtFamiliasEnCasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtFamiliasEnCasa.Name = "txtFamiliasEnCasa";
            this.txtFamiliasEnCasa.Size = new System.Drawing.Size(199, 29);
            this.txtFamiliasEnCasa.TabIndex = 125;
            this.txtFamiliasEnCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.ForeColor = System.Drawing.Color.White;
            this.Label48.Location = new System.Drawing.Point(309, 23);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(179, 13);
            this.Label48.TabIndex = 124;
            this.Label48.Text = "¿Cuántas familias viven en su casa?";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnfermedad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEnfermedad.ForeColor = System.Drawing.Color.White;
            this.txtEnfermedad.HintForeColor = System.Drawing.Color.White;
            this.txtEnfermedad.HintText = "";
            this.txtEnfermedad.isPassword = false;
            this.txtEnfermedad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEnfermedad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEnfermedad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEnfermedad.LineThickness = 3;
            this.txtEnfermedad.Location = new System.Drawing.Point(26, 39);
            this.txtEnfermedad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(229, 29);
            this.txtEnfermedad.TabIndex = 123;
            this.txtEnfermedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.ForeColor = System.Drawing.Color.White;
            this.Label49.Location = new System.Drawing.Point(23, 22);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(275, 13);
            this.Label49.TabIndex = 122;
            this.Label49.Text = "¿Padece alguna enfermedad crónica? (Especifique cuál)";
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage5.Controls.Add(this.txtMontoMaximoAutorizado);
            this.TabPage5.Controls.Add(this.Label67);
            this.TabPage5.Controls.Add(this.Label54);
            this.TabPage5.Controls.Add(this.txtComentariosVerificacion);
            this.TabPage5.Controls.Add(this.txtMontoVerificacion);
            this.TabPage5.Controls.Add(this.Label53);
            this.TabPage5.Controls.Add(this.txtMontoSolicitado);
            this.TabPage5.Controls.Add(this.Label52);
            this.TabPage5.Controls.Add(this.GroupBox1);
            this.TabPage5.Controls.Add(this.dtdatosDocumentos);
            this.TabPage5.Controls.Add(this.Label21);
            this.TabPage5.Controls.Add(this.txtObservacionesDomicilio);
            this.TabPage5.Controls.Add(this.txtHorarioVerificacion);
            this.TabPage5.Controls.Add(this.Label55);
            this.TabPage5.Controls.Add(this.Label56);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(1133, 519);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Verificación";
            // 
            // txtMontoMaximoAutorizado
            // 
            this.txtMontoMaximoAutorizado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoMaximoAutorizado.Enabled = false;
            this.txtMontoMaximoAutorizado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontoMaximoAutorizado.ForeColor = System.Drawing.Color.White;
            this.txtMontoMaximoAutorizado.HintForeColor = System.Drawing.Color.White;
            this.txtMontoMaximoAutorizado.HintText = "";
            this.txtMontoMaximoAutorizado.isPassword = false;
            this.txtMontoMaximoAutorizado.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontoMaximoAutorizado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMontoMaximoAutorizado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontoMaximoAutorizado.LineThickness = 3;
            this.txtMontoMaximoAutorizado.Location = new System.Drawing.Point(271, 242);
            this.txtMontoMaximoAutorizado.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoMaximoAutorizado.Name = "txtMontoMaximoAutorizado";
            this.txtMontoMaximoAutorizado.Size = new System.Drawing.Size(101, 29);
            this.txtMontoMaximoAutorizado.TabIndex = 157;
            this.txtMontoMaximoAutorizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label67
            // 
            this.Label67.AutoSize = true;
            this.Label67.ForeColor = System.Drawing.Color.White;
            this.Label67.Location = new System.Drawing.Point(268, 225);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(129, 13);
            this.Label67.TabIndex = 156;
            this.Label67.Text = "Monto Autorizado Máximo";
            // 
            // Label54
            // 
            this.Label54.AutoSize = true;
            this.Label54.ForeColor = System.Drawing.Color.White;
            this.Label54.Location = new System.Drawing.Point(18, 144);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(65, 13);
            this.Label54.TabIndex = 157;
            this.Label54.Text = "Comentarios";
            // 
            // txtComentariosVerificacion
            // 
            this.txtComentariosVerificacion.Enabled = false;
            this.txtComentariosVerificacion.Location = new System.Drawing.Point(21, 166);
            this.txtComentariosVerificacion.Multiline = true;
            this.txtComentariosVerificacion.Name = "txtComentariosVerificacion";
            this.txtComentariosVerificacion.Size = new System.Drawing.Size(222, 97);
            this.txtComentariosVerificacion.TabIndex = 156;
            // 
            // txtMontoVerificacion
            // 
            this.txtMontoVerificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoVerificacion.Enabled = false;
            this.txtMontoVerificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontoVerificacion.ForeColor = System.Drawing.Color.White;
            this.txtMontoVerificacion.HintForeColor = System.Drawing.Color.White;
            this.txtMontoVerificacion.HintText = "";
            this.txtMontoVerificacion.isPassword = false;
            this.txtMontoVerificacion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontoVerificacion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMontoVerificacion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontoVerificacion.LineThickness = 3;
            this.txtMontoVerificacion.Location = new System.Drawing.Point(271, 183);
            this.txtMontoVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoVerificacion.Name = "txtMontoVerificacion";
            this.txtMontoVerificacion.Size = new System.Drawing.Size(101, 29);
            this.txtMontoVerificacion.TabIndex = 159;
            this.txtMontoVerificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label53
            // 
            this.Label53.AutoSize = true;
            this.Label53.ForeColor = System.Drawing.Color.White;
            this.Label53.Location = new System.Drawing.Point(268, 166);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(136, 13);
            this.Label53.TabIndex = 158;
            this.Label53.Text = "Monto Autorizado por V y C";
            // 
            // txtMontoSolicitado
            // 
            this.txtMontoSolicitado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoSolicitado.Enabled = false;
            this.txtMontoSolicitado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontoSolicitado.ForeColor = System.Drawing.Color.White;
            this.txtMontoSolicitado.HintForeColor = System.Drawing.Color.White;
            this.txtMontoSolicitado.HintText = "";
            this.txtMontoSolicitado.isPassword = false;
            this.txtMontoSolicitado.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontoSolicitado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMontoSolicitado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontoSolicitado.LineThickness = 3;
            this.txtMontoSolicitado.Location = new System.Drawing.Point(271, 114);
            this.txtMontoSolicitado.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoSolicitado.Name = "txtMontoSolicitado";
            this.txtMontoSolicitado.Size = new System.Drawing.Size(101, 29);
            this.txtMontoSolicitado.TabIndex = 157;
            this.txtMontoSolicitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.ForeColor = System.Drawing.Color.White;
            this.Label52.Location = new System.Drawing.Point(268, 97);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(86, 13);
            this.Label52.TabIndex = 156;
            this.Label52.Text = "Monto Solicitado";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtMontoAutorizado);
            this.GroupBox1.Controls.Add(this.Label50);
            this.GroupBox1.Controls.Add(this.Label39);
            this.GroupBox1.Controls.Add(this.txtComentarios);
            this.GroupBox1.Controls.Add(this.btn_Procesar);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox1.Location = new System.Drawing.Point(21, 298);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(1083, 201);
            this.GroupBox1.TabIndex = 153;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Marcar Como";
            // 
            // txtMontoAutorizado
            // 
            this.txtMontoAutorizado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoAutorizado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontoAutorizado.ForeColor = System.Drawing.Color.White;
            this.txtMontoAutorizado.HintForeColor = System.Drawing.Color.White;
            this.txtMontoAutorizado.HintText = "";
            this.txtMontoAutorizado.isPassword = false;
            this.txtMontoAutorizado.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontoAutorizado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMontoAutorizado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontoAutorizado.LineThickness = 3;
            this.txtMontoAutorizado.Location = new System.Drawing.Point(747, 50);
            this.txtMontoAutorizado.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAutorizado.Name = "txtMontoAutorizado";
            this.txtMontoAutorizado.Size = new System.Drawing.Size(101, 29);
            this.txtMontoAutorizado.TabIndex = 155;
            this.txtMontoAutorizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.ForeColor = System.Drawing.Color.White;
            this.Label50.Location = new System.Drawing.Point(744, 33);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(90, 13);
            this.Label50.TabIndex = 154;
            this.Label50.Text = "Monto Autorizado";
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.ForeColor = System.Drawing.Color.White;
            this.Label39.Location = new System.Drawing.Point(205, 24);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(65, 13);
            this.Label39.TabIndex = 155;
            this.Label39.Text = "Comentarios";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(208, 50);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(526, 133);
            this.txtComentarios.TabIndex = 154;
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.ActiveBorderThickness = 1;
            this.btn_Procesar.ActiveCornerRadius = 20;
            this.btn_Procesar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Procesar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Procesar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Procesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btn_Procesar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Procesar.BackgroundImage")));
            this.btn_Procesar.ButtonText = "Registrar Captura";
            this.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Procesar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Procesar.IdleBorderThickness = 1;
            this.btn_Procesar.IdleCornerRadius = 20;
            this.btn_Procesar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Procesar.Location = new System.Drawing.Point(747, 104);
            this.btn_Procesar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(216, 38);
            this.btn_Procesar.TabIndex = 151;
            this.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // dtdatosDocumentos
            // 
            this.dtdatosDocumentos.AllowUserToAddRows = false;
            this.dtdatosDocumentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtdatosDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdatosDocumentos.DoubleBuffered = true;
            this.dtdatosDocumentos.EnableHeadersVisualStyles = false;
            this.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatosDocumentos.Location = new System.Drawing.Point(504, 59);
            this.dtdatosDocumentos.Name = "dtdatosDocumentos";
            this.dtdatosDocumentos.ReadOnly = true;
            this.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatosDocumentos.RowHeadersVisible = false;
            this.dtdatosDocumentos.Size = new System.Drawing.Size(480, 227);
            this.dtdatosDocumentos.TabIndex = 26;
            this.dtdatosDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatosDocumentos_CellContentClick);
            this.dtdatosDocumentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatosDocumentos_CellContentDoubleClick);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(501, 27);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(67, 13);
            this.Label21.TabIndex = 150;
            this.Label21.Text = "Documentos";
            // 
            // txtObservacionesDomicilio
            // 
            this.txtObservacionesDomicilio.Location = new System.Drawing.Point(21, 44);
            this.txtObservacionesDomicilio.Multiline = true;
            this.txtObservacionesDomicilio.Name = "txtObservacionesDomicilio";
            this.txtObservacionesDomicilio.Size = new System.Drawing.Size(222, 93);
            this.txtObservacionesDomicilio.TabIndex = 148;
            // 
            // txtHorarioVerificacion
            // 
            this.txtHorarioVerificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorarioVerificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHorarioVerificacion.ForeColor = System.Drawing.Color.White;
            this.txtHorarioVerificacion.HintForeColor = System.Drawing.Color.White;
            this.txtHorarioVerificacion.HintText = "";
            this.txtHorarioVerificacion.isPassword = false;
            this.txtHorarioVerificacion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHorarioVerificacion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHorarioVerificacion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHorarioVerificacion.LineThickness = 3;
            this.txtHorarioVerificacion.Location = new System.Drawing.Point(271, 44);
            this.txtHorarioVerificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorarioVerificacion.Name = "txtHorarioVerificacion";
            this.txtHorarioVerificacion.Size = new System.Drawing.Size(101, 29);
            this.txtHorarioVerificacion.TabIndex = 125;
            this.txtHorarioVerificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.ForeColor = System.Drawing.Color.White;
            this.Label55.Location = new System.Drawing.Point(268, 27);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(113, 13);
            this.Label55.TabIndex = 124;
            this.Label55.Text = "Horario de verificación";
            // 
            // Label56
            // 
            this.Label56.AutoSize = true;
            this.Label56.ForeColor = System.Drawing.Color.White;
            this.Label56.Location = new System.Drawing.Point(23, 28);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(138, 13);
            this.Label56.TabIndex = 122;
            this.Label56.Text = "Observaciones del domicilio";
            // 
            // dtdatos
            // 
            this.dtdatos.AllowUserToAddRows = false;
            this.dtdatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtdatos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdCliente,
            this.Nombre,
            this.Estado,
            this.Monto});
            this.dtdatos.DoubleBuffered = true;
            this.dtdatos.EnableHeadersVisualStyles = false;
            this.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatos.Location = new System.Drawing.Point(12, 43);
            this.dtdatos.Name = "dtdatos";
            this.dtdatos.ReadOnly = true;
            this.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatos.RowHeadersVisible = false;
            this.dtdatos.Size = new System.Drawing.Size(945, 158);
            this.dtdatos.TabIndex = 25;
            this.dtdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellContentClick);
            this.dtdatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Solicitud";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 83;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "# Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 79;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 79;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 71;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto Autorizado";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 126;
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // BackgroundAct
            // 
            this.BackgroundAct.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundAct_DoWork);
            this.BackgroundAct.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundAct_RunWorkerCompleted);
            // 
            // BackgroundDocumentosSolicitud
            // 
            this.BackgroundDocumentosSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDocumentosSolicitud_DoWork);
            this.BackgroundDocumentosSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDocumentosSolicitud_RunWorkerCompleted);
            // 
            // BackgroundVerificacion
            // 
            this.BackgroundVerificacion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundVerificacion_DoWork);
            this.BackgroundVerificacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundVerificacion_RunWorkerCompleted);
            // 
            // BackgroundDatosSolicitud
            // 
            this.BackgroundDatosSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDatosSolicitud_DoWork);
            this.BackgroundDatosSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDatosSolicitud_RunWorkerCompleted);
            // 
            // BackgroundDocumentos
            // 
            this.BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDocumentos_DoWork);
            this.BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDocumentos_RunWorkerCompleted);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontoTotal.ForeColor = System.Drawing.Color.White;
            this.txtMontoTotal.HintForeColor = System.Drawing.Color.White;
            this.txtMontoTotal.HintText = "";
            this.txtMontoTotal.isPassword = false;
            this.txtMontoTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontoTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMontoTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontoTotal.LineThickness = 3;
            this.txtMontoTotal.Location = new System.Drawing.Point(966, 70);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(101, 29);
            this.txtMontoTotal.TabIndex = 127;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.ForeColor = System.Drawing.Color.White;
            this.Label51.Location = new System.Drawing.Point(963, 53);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(64, 13);
            this.Label51.TabIndex = 126;
            this.Label51.Text = "Monto Total";
            // 
            // BackgroundRechazo
            // 
            this.BackgroundRechazo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundRechazo_DoWork);
            this.BackgroundRechazo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundRechazo_RunWorkerCompleted);
            // 
            // backgroundIncompleta
            // 
            this.backgroundIncompleta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundIncompleta_DoWork_1);
            // 
            // DatosAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1155, 788);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.Label51);
            this.Controls.Add(this.dtdatos);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosAprobacion";
            this.Text = "Datos Verificación";
            this.Load += new System.EventHandler(this.DatosSolicitud_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
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
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_a_verificacion;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentosSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificacion;
        internal System.ComponentModel.BackgroundWorker BackgroundDatosSolicitud;
        internal GroupBox GroupBox1;
        internal Label Label39;
        internal TextBox txtComentarios;
        internal EvolveControlBox EvolveControlBox1;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoAutorizado;
        internal Label Label50;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoTotal;
        internal Label Label51;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_rechazar;
        internal System.ComponentModel.BackgroundWorker BackgroundRechazo;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoVerificacion;
        internal Label Label53;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoSolicitado;
        internal Label Label52;
        internal Label Label54;
        internal TextBox txtComentariosVerificacion;
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
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtDomicilioAlterno;
        internal Label Label69;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtHijos;
        internal Label Label68;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoMaximoAutorizado;
        internal Label Label67;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtOcupacionConyuge;
        internal Label Label72;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefonoConyuge;
        internal Label Label71;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColoniaReal;
        internal Label Label70;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Monto;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Incompleta;
        internal System.ComponentModel.BackgroundWorker backgroundIncompleta;
    }
}