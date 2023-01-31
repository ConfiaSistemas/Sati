using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DatosSolicitudBoletaVerificar : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosSolicitudBoletaVerificar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btn_rechazar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_a_autorizacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtIne = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ComboColonia = new System.Windows.Forms.ComboBox();
            this.txtCurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtDomicilio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Label39 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BackgroundAct = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDocumentosSolicitud = new System.ComponentModel.BackgroundWorker();
            this.BackgroundVerificacion = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDatosSolicitud = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            this.BackgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.BackgroundCargaDocumentos = new System.ComponentModel.BackgroundWorker();
            this.BackgroundVerificaDocumentos = new System.ComponentModel.BackgroundWorker();
            this.BackgroundActivarLegal = new System.ComponentModel.BackgroundWorker();
            this.BackgroundRechazarSolicitud = new System.ComponentModel.BackgroundWorker();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSolicitudColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoValuado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoSugerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAutorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.NombreTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autorizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.btn_rechazar);
            this.Panel1.Controls.Add(this.btn_a_autorizacion);
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1158, 36);
            this.Panel1.TabIndex = 3;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
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
            this.btn_rechazar.ButtonText = "Rechazar Solicitud";
            this.btn_rechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rechazar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechazar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_rechazar.IdleBorderThickness = 1;
            this.btn_rechazar.IdleCornerRadius = 20;
            this.btn_rechazar.IdleFillColor = System.Drawing.Color.White;
            this.btn_rechazar.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_rechazar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_rechazar.Location = new System.Drawing.Point(487, -1);
            this.btn_rechazar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(184, 38);
            this.btn_rechazar.TabIndex = 153;
            this.btn_rechazar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_rechazar.Visible = false;
            this.btn_rechazar.Click += new System.EventHandler(this.btn_rechazar_Click);
            // 
            // btn_a_autorizacion
            // 
            this.btn_a_autorizacion.ActiveBorderThickness = 1;
            this.btn_a_autorizacion.ActiveCornerRadius = 20;
            this.btn_a_autorizacion.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_a_autorizacion.ActiveForecolor = System.Drawing.Color.White;
            this.btn_a_autorizacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_a_autorizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_a_autorizacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_a_autorizacion.BackgroundImage")));
            this.btn_a_autorizacion.ButtonText = "Autorizar Solicitud";
            this.btn_a_autorizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_a_autorizacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a_autorizacion.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_a_autorizacion.IdleBorderThickness = 1;
            this.btn_a_autorizacion.IdleCornerRadius = 20;
            this.btn_a_autorizacion.IdleFillColor = System.Drawing.Color.White;
            this.btn_a_autorizacion.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_a_autorizacion.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_a_autorizacion.Location = new System.Drawing.Point(768, -2);
            this.btn_a_autorizacion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_a_autorizacion.Name = "btn_a_autorizacion";
            this.btn_a_autorizacion.Size = new System.Drawing.Size(184, 38);
            this.btn_a_autorizacion.TabIndex = 152;
            this.btn_a_autorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_a_autorizacion.Visible = false;
            this.btn_a_autorizacion.Click += new System.EventHandler(this.btn_a_verificacion_Click);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(1089, 3);
            this.EvolveControlBox1.MaxButton = false;
            this.EvolveControlBox1.MinButton = true;
            this.EvolveControlBox1.Name = "EvolveControlBox1";
            this.EvolveControlBox1.NoRounding = false;
            this.EvolveControlBox1.Size = new System.Drawing.Size(66, 16);
            this.EvolveControlBox1.TabIndex = 31;
            this.EvolveControlBox1.Text = "EvolveControlBox1";
            this.EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(3, 3);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(217, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Datos de Solicitud de Empeño";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(12, 327);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1141, 362);
            this.TabControl1.TabIndex = 4;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage1.Controls.Add(this.txtIne);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.ComboColonia);
            this.TabPage1.Controls.Add(this.txtCurp);
            this.TabPage1.Controls.Add(this.Label16);
            this.TabPage1.Controls.Add(this.txtEstado);
            this.TabPage1.Controls.Add(this.Label15);
            this.TabPage1.Controls.Add(this.txtCiudad);
            this.TabPage1.Controls.Add(this.Label14);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.txtCodigoPostal);
            this.TabPage1.Controls.Add(this.Label10);
            this.TabPage1.Controls.Add(this.txtDomicilio);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.txtCelular);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.txtApellidoM);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.txtApellidoP);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.txtnombre);
            this.TabPage1.Controls.Add(this.Label11);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1133, 336);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Datos Personales";
            // 
            // txtIne
            // 
            this.txtIne.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIne.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIne.ForeColor = System.Drawing.Color.White;
            this.txtIne.HintForeColor = System.Drawing.Color.White;
            this.txtIne.HintText = "";
            this.txtIne.isPassword = false;
            this.txtIne.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIne.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIne.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIne.LineThickness = 3;
            this.txtIne.Location = new System.Drawing.Point(881, 71);
            this.txtIne.Margin = new System.Windows.Forms.Padding(4);
            this.txtIne.Name = "txtIne";
            this.txtIne.Size = new System.Drawing.Size(214, 29);
            this.txtIne.TabIndex = 99;
            this.txtIne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(878, 54);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(105, 13);
            this.Label3.TabIndex = 100;
            this.Label3.Text = "No. de Identificación";
            // 
            // ComboColonia
            // 
            this.ComboColonia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ComboColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboColonia.Enabled = false;
            this.ComboColonia.ForeColor = System.Drawing.SystemColors.Control;
            this.ComboColonia.FormattingEnabled = true;
            this.ComboColonia.Location = new System.Drawing.Point(881, 163);
            this.ComboColonia.Name = "ComboColonia";
            this.ComboColonia.Size = new System.Drawing.Size(214, 21);
            this.ComboColonia.TabIndex = 98;
            // 
            // txtCurp
            // 
            this.txtCurp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCurp.ForeColor = System.Drawing.Color.White;
            this.txtCurp.HintForeColor = System.Drawing.Color.White;
            this.txtCurp.HintText = "";
            this.txtCurp.isPassword = false;
            this.txtCurp.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCurp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCurp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCurp.LineThickness = 3;
            this.txtCurp.Location = new System.Drawing.Point(45, 155);
            this.txtCurp.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(242, 29);
            this.txtCurp.TabIndex = 18;
            this.txtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(42, 138);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(37, 13);
            this.Label16.TabIndex = 92;
            this.Label16.Text = "CURP";
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
            this.txtEstado.Location = new System.Drawing.Point(604, 235);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(214, 29);
            this.txtEstado.TabIndex = 17;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(601, 218);
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
            this.txtCiudad.Location = new System.Drawing.Point(332, 235);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(237, 29);
            this.txtCiudad.TabIndex = 16;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(329, 218);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(40, 13);
            this.Label14.TabIndex = 88;
            this.Label14.Text = "Ciudad";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(878, 138);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(42, 13);
            this.Label13.TabIndex = 86;
            this.Label13.Text = "Colonia";
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
            this.txtCodigoPostal.Location = new System.Drawing.Point(604, 155);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(214, 29);
            this.txtCodigoPostal.TabIndex = 13;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPostal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoPostal_KeyDown);
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPostal_KeyPress);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(601, 138);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 13);
            this.Label10.TabIndex = 82;
            this.Label10.Text = "Código Postal";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDomicilio.ForeColor = System.Drawing.Color.White;
            this.txtDomicilio.HintForeColor = System.Drawing.Color.White;
            this.txtDomicilio.HintText = "";
            this.txtDomicilio.isPassword = false;
            this.txtDomicilio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDomicilio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDomicilio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDomicilio.LineThickness = 3;
            this.txtDomicilio.Location = new System.Drawing.Point(45, 235);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(242, 29);
            this.txtDomicilio.TabIndex = 10;
            this.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(42, 218);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(49, 13);
            this.Label7.TabIndex = 76;
            this.Label7.Text = "Domicilio";
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
            this.txtCelular.Location = new System.Drawing.Point(332, 155);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(237, 29);
            this.txtCelular.TabIndex = 7;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(329, 138);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 72;
            this.Label5.Text = "Celular";
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
            this.txtApellidoM.Location = new System.Drawing.Point(604, 71);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(214, 29);
            this.txtApellidoM.TabIndex = 4;
            this.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(601, 54);
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
            this.txtApellidoP.Location = new System.Drawing.Point(332, 71);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(237, 29);
            this.txtApellidoP.TabIndex = 3;
            this.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(329, 54);
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
            this.txtnombre.Size = new System.Drawing.Size(242, 29);
            this.txtnombre.TabIndex = 2;
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
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage5.Controls.Add(this.TabControl2);
            this.TabPage5.Controls.Add(this.Label39);
            this.TabPage5.Controls.Add(this.FlowLayoutPanel1);
            this.TabPage5.Controls.Add(this.btn_Procesar);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(1133, 336);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Documentación";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Location = new System.Drawing.Point(361, 28);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(723, 247);
            this.TabControl2.TabIndex = 155;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.dtdatosDocumentos);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(715, 221);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Documentos Cargados";
            this.TabPage6.UseVisualStyleBackColor = true;
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
            this.dtdatosDocumentos.Location = new System.Drawing.Point(6, 6);
            this.dtdatosDocumentos.Name = "dtdatosDocumentos";
            this.dtdatosDocumentos.ReadOnly = true;
            this.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatosDocumentos.RowHeadersVisible = false;
            this.dtdatosDocumentos.Size = new System.Drawing.Size(703, 209);
            this.dtdatosDocumentos.TabIndex = 26;
            this.dtdatosDocumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatosDocumentos_CellDoubleClick);
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.ForeColor = System.Drawing.Color.White;
            this.Label39.Location = new System.Drawing.Point(19, 28);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(123, 13);
            this.Label39.TabIndex = 154;
            this.Label39.Text = "Documentos Necesarios";
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(22, 60);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(135, 166);
            this.FlowLayoutPanel1.TabIndex = 153;
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
            this.btn_Procesar.Location = new System.Drawing.Point(469, 282);
            this.btn_Procesar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(216, 38);
            this.btn_Procesar.TabIndex = 53;
            this.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // dtdatos
            // 
            this.dtdatos.AllowUserToAddRows = false;
            this.dtdatos.AllowUserToDeleteRows = false;
            this.dtdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtdatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.id,
            this.idSolicitudColumn,
            this.Descripcion,
            this.Marca,
            this.Modelo,
            this.NoSerie,
            this.MontoValuado,
            this.MontoSugerido,
            this.MontoAutorizado,
            this.ImagenColumn,
            this.NombreTipo,
            this.Autorizado});
            this.dtdatos.DoubleBuffered = true;
            this.dtdatos.EnableHeadersVisualStyles = false;
            this.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatos.Location = new System.Drawing.Point(12, 43);
            this.dtdatos.Name = "dtdatos";
            this.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatos.RowHeadersVisible = false;
            this.dtdatos.Size = new System.Drawing.Size(1144, 270);
            this.dtdatos.TabIndex = 25;
            this.dtdatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellDoubleClick);
            this.dtdatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellEndEdit);
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
            // BackgroundDocumentos
            // 
            this.BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDocumentos_DoWork);
            this.BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDocumentos_RunWorkerCompleted);
            // 
            // BackgroundWorker2
            // 
            this.BackgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            this.BackgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker2_RunWorkerCompleted);
            // 
            // BackgroundCargaDocumentos
            // 
            this.BackgroundCargaDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCargaDocumentos_DoWork);
            this.BackgroundCargaDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCargaDocumentos_RunWorkerCompleted);
            // 
            // BackgroundVerificaDocumentos
            // 
            this.BackgroundVerificaDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundVerificaDocumentos_DoWork);
            this.BackgroundVerificaDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundVerificaDocumentos_RunWorkerCompleted);
            // 
            // BackgroundRechazarSolicitud
            // 
            this.BackgroundRechazarSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundRechazarSolicitud_DoWork);
            this.BackgroundRechazarSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundRechazarSolicitud_RunWorkerCompleted);
            // 
            // id
            // 
            this.id.HeaderText = "Empeño";
            this.id.Name = "id";
            this.id.Width = 45;
            // 
            // idSolicitudColumn
            // 
            this.idSolicitudColumn.HeaderText = "Solicitud";
            this.idSolicitudColumn.Name = "idSolicitudColumn";
            this.idSolicitudColumn.ReadOnly = true;
            this.idSolicitudColumn.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 75;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 70;
            // 
            // NoSerie
            // 
            this.NoSerie.HeaderText = "No de Serie";
            this.NoSerie.Name = "NoSerie";
            this.NoSerie.ReadOnly = true;
            this.NoSerie.Width = 80;
            // 
            // MontoValuado
            // 
            this.MontoValuado.HeaderText = "Monto Valuado";
            this.MontoValuado.Name = "MontoValuado";
            this.MontoValuado.ReadOnly = true;
            this.MontoValuado.Width = 75;
            // 
            // MontoSugerido
            // 
            this.MontoSugerido.HeaderText = "Monto Sugerido";
            this.MontoSugerido.Name = "MontoSugerido";
            this.MontoSugerido.ReadOnly = true;
            this.MontoSugerido.Width = 75;
            // 
            // MontoAutorizado
            // 
            this.MontoAutorizado.HeaderText = "Monto Autorizado";
            this.MontoAutorizado.Name = "MontoAutorizado";
            this.MontoAutorizado.Width = 75;
            // 
            // ImagenColumn
            // 
            this.ImagenColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ImagenColumn.HeaderText = "Imagen";
            this.ImagenColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImagenColumn.Name = "ImagenColumn";
            this.ImagenColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImagenColumn.Width = 200;
            // 
            // NombreTipo
            // 
            this.NombreTipo.HeaderText = "Tipo";
            this.NombreTipo.Name = "NombreTipo";
            this.NombreTipo.ReadOnly = true;
            this.NombreTipo.Width = 55;
            // 
            // Autorizado
            // 
            this.Autorizado.HeaderText = "Autorizado";
            this.Autorizado.Name = "Autorizado";
            this.Autorizado.Width = 75;
            // 
            // DatosSolicitudBoletaVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1161, 715);
            this.Controls.Add(this.dtdatos);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosSolicitudBoletaVerificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosSolicitud";
            this.Load += new System.EventHandler(this.DatosSolicitud_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).EndInit();
            this.ResumeLayout(false);

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
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal System.ComponentModel.BackgroundWorker BackgroundAct;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentos;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_a_autorizacion;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentosSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificacion;
        internal Label Label39;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal System.ComponentModel.BackgroundWorker BackgroundDatosSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal TabControl TabControl2;
        internal TabPage TabPage6;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker2;
        internal System.ComponentModel.BackgroundWorker BackgroundCargaDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundVerificaDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundActivarLegal;
        internal ComboBox ComboColonia;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_rechazar;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIne;
        internal Label Label3;
        internal System.ComponentModel.BackgroundWorker BackgroundRechazarSolicitud;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn idSolicitudColumn;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn NoSerie;
        private DataGridViewTextBoxColumn MontoValuado;
        private DataGridViewTextBoxColumn MontoSugerido;
        private DataGridViewTextBoxColumn MontoAutorizado;
        private DataGridViewImageColumn ImagenColumn;
        private DataGridViewTextBoxColumn NombreTipo;
        private DataGridViewCheckBoxColumn Autorizado;
    }
}