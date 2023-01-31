using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Agregar_Impuestos : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Impuestos));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RadioOp2 = new System.Windows.Forms.RadioButton();
            this.RadioOp1 = new System.Windows.Forms.RadioButton();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.DateNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtcurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnConsultaCurp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundConsultarCurp = new System.ComponentModel.BackgroundWorker();
            this.Label7 = new System.Windows.Forms.Label();
            this.BackgroundAgregar = new System.ComponentModel.BackgroundWorker();
            this.BackgroundValidar = new System.ComponentModel.BackgroundWorker();
            this.BackgroundValidaExistencia = new System.ComponentModel.BackgroundWorker();
            this.BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundConsultaCurpOp2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundConsultaCurpOP1 = new System.ComponentModel.BackgroundWorker();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.RadioOp2);
            this.Panel1.Controls.Add(this.RadioOp1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(675, 36);
            this.Panel1.TabIndex = 1;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // RadioOp2
            // 
            this.RadioOp2.AutoSize = true;
            this.RadioOp2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RadioOp2.Location = new System.Drawing.Point(421, 6);
            this.RadioOp2.Name = "RadioOp2";
            this.RadioOp2.Size = new System.Drawing.Size(68, 17);
            this.RadioOp2.TabIndex = 3;
            this.RadioOp2.TabStop = true;
            this.RadioOp2.Text = "Opción 2";
            this.RadioOp2.UseVisualStyleBackColor = true;
            this.RadioOp2.CheckedChanged += new System.EventHandler(this.RadioOp2_CheckedChanged);
            // 
            // RadioOp1
            // 
            this.RadioOp1.AutoSize = true;
            this.RadioOp1.Checked = true;
            this.RadioOp1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RadioOp1.Location = new System.Drawing.Point(338, 6);
            this.RadioOp1.Name = "RadioOp1";
            this.RadioOp1.Size = new System.Drawing.Size(68, 17);
            this.RadioOp1.TabIndex = 2;
            this.RadioOp1.TabStop = true;
            this.RadioOp1.Text = "Opción 1";
            this.RadioOp1.UseVisualStyleBackColor = true;
            this.RadioOp1.CheckedChanged += new System.EventHandler(this.RadioOp1_CheckedChanged);
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(3, 3);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(118, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Agregar Cliente";
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(605, 3);
            this.EvolveControlBox1.MaxButton = false;
            this.EvolveControlBox1.MinButton = true;
            this.EvolveControlBox1.Name = "EvolveControlBox1";
            this.EvolveControlBox1.NoRounding = false;
            this.EvolveControlBox1.Size = new System.Drawing.Size(66, 16);
            this.EvolveControlBox1.TabIndex = 0;
            this.EvolveControlBox1.Text = "EvolveControlBox1";
            this.EvolveControlBox1.Transparent = false;
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
            this.txtnombre.Location = new System.Drawing.Point(37, 127);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(171, 25);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(34, 110);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Nombre";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(266, 110);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Apellido Paterno";
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
            this.txtApellidoP.Location = new System.Drawing.Point(269, 127);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(170, 25);
            this.txtApellidoP.TabIndex = 8;
            this.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_agregar
            // 
            this.btn_agregar.ActiveBorderThickness = 1;
            this.btn_agregar.ActiveCornerRadius = 20;
            this.btn_agregar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_agregar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btn_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.BackgroundImage")));
            this.btn_agregar.ButtonText = "Agregar";
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.IdleBorderThickness = 1;
            this.btn_agregar.IdleCornerRadius = 20;
            this.btn_agregar.IdleFillColor = System.Drawing.Color.White;
            this.btn_agregar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.Location = new System.Drawing.Point(249, 287);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(207, 38);
            this.btn_agregar.TabIndex = 15;
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
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
            this.txtApellidoM.Location = new System.Drawing.Point(471, 127);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(170, 25);
            this.txtApellidoM.TabIndex = 17;
            this.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(468, 110);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(86, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Apellido Materno";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(35, 188);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(108, 13);
            this.Label6.TabIndex = 20;
            this.Label6.Text = "Fecha de Nacimiento";
            // 
            // DateNacimiento
            // 
            this.DateNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.DateNacimiento.BorderRadius = 0;
            this.DateNacimiento.ForeColor = System.Drawing.Color.White;
            this.DateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNacimiento.FormatCustom = null;
            this.DateNacimiento.Location = new System.Drawing.Point(38, 214);
            this.DateNacimiento.Name = "DateNacimiento";
            this.DateNacimiento.Size = new System.Drawing.Size(170, 36);
            this.DateNacimiento.TabIndex = 21;
            this.DateNacimiento.Value = new System.DateTime(2019, 12, 20, 10, 35, 45, 980);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(34, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 13);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Curp:";
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
            this.txtTelefono.Location = new System.Drawing.Point(269, 214);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 25);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(468, 197);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "Celular";
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
            this.txtCelular.Location = new System.Drawing.Point(471, 214);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(170, 25);
            this.txtCelular.TabIndex = 24;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BunifuThinButton21
            // 
            this.BunifuThinButton21.ActiveBorderThickness = 1;
            this.BunifuThinButton21.ActiveCornerRadius = 20;
            this.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.BunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton21.BackgroundImage")));
            this.BunifuThinButton21.ButtonText = "Agregar";
            this.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleBorderThickness = 1;
            this.BunifuThinButton21.IdleCornerRadius = 20;
            this.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.Location = new System.Drawing.Point(505, 426);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(207, 38);
            this.BunifuThinButton21.TabIndex = 26;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // txtcurp
            // 
            this.txtcurp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcurp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcurp.ForeColor = System.Drawing.Color.White;
            this.txtcurp.HintForeColor = System.Drawing.Color.White;
            this.txtcurp.HintText = "";
            this.txtcurp.isPassword = false;
            this.txtcurp.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcurp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcurp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcurp.LineThickness = 3;
            this.txtcurp.Location = new System.Drawing.Point(38, 64);
            this.txtcurp.Margin = new System.Windows.Forms.Padding(4);
            this.txtcurp.Name = "txtcurp";
            this.txtcurp.Size = new System.Drawing.Size(170, 25);
            this.txtcurp.TabIndex = 27;
            this.txtcurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnConsultaCurp
            // 
            this.btnConsultaCurp.ActiveBorderThickness = 1;
            this.btnConsultaCurp.ActiveCornerRadius = 20;
            this.btnConsultaCurp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultaCurp.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultaCurp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultaCurp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnConsultaCurp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaCurp.BackgroundImage")));
            this.btnConsultaCurp.ButtonText = "Consultar";
            this.btnConsultaCurp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaCurp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCurp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultaCurp.IdleBorderThickness = 1;
            this.btnConsultaCurp.IdleCornerRadius = 20;
            this.btnConsultaCurp.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultaCurp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultaCurp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultaCurp.Location = new System.Drawing.Point(260, 51);
            this.btnConsultaCurp.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultaCurp.Name = "btnConsultaCurp";
            this.btnConsultaCurp.Size = new System.Drawing.Size(207, 38);
            this.btnConsultaCurp.TabIndex = 28;
            this.btnConsultaCurp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultaCurp.Click += new System.EventHandler(this.BunifuThinButton22_ClickAsync);
            // 
            // BackgroundConsultarCurp
            // 
            this.BackgroundConsultarCurp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundConsultarCurp_DoWork);
            this.BackgroundConsultarCurp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundConsultarCurp_RunWorkerCompleted);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(266, 188);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "Teléfono:";
            // 
            // BackgroundAgregar
            // 
            this.BackgroundAgregar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundAgregar_DoWork);
            this.BackgroundAgregar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundAgregar_RunWorkerCompleted);
            // 
            // BackgroundValidar
            // 
            this.BackgroundValidar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundValidar_DoWorkAsync);
            this.BackgroundValidar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundValidar_RunWorkerCompleted);
            // 
            // BackgroundValidaExistencia
            // 
            this.BackgroundValidaExistencia.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundValidaExistencia_DoWork);
            this.BackgroundValidaExistencia.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundValidaExistencia_RunWorkerCompleted);
            // 
            // BunifuThinButton22
            // 
            this.BunifuThinButton22.ActiveBorderThickness = 1;
            this.BunifuThinButton22.ActiveCornerRadius = 20;
            this.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.BunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton22.BackgroundImage")));
            this.BunifuThinButton22.ButtonText = "Consultar";
            this.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.IdleBorderThickness = 1;
            this.BunifuThinButton22.IdleCornerRadius = 20;
            this.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.Location = new System.Drawing.Point(502, 51);
            this.BunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton22.Name = "BunifuThinButton22";
            this.BunifuThinButton22.Size = new System.Drawing.Size(139, 38);
            this.BunifuThinButton22.TabIndex = 30;
            this.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton22.Visible = false;
            this.BunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click_1);
            // 
            // BackgroundConsultaCurpOp2
            // 
            this.BackgroundConsultaCurpOp2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundConsultaCurpOp2_DoWork);
            this.BackgroundConsultaCurpOp2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundConsultaCurpOp2_RunWorkerCompleted);
            // 
            // backgroundConsultaCurpOP1
            // 
            //this.backgroundConsultaCurpOP1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundConsultaCurpOP1_DoWork);
            // 
            // Agregar_Impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(677, 341);
            this.Controls.Add(this.BunifuThinButton22);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnConsultaCurp);
            this.Controls.Add(this.txtcurp);
            this.Controls.Add(this.BunifuThinButton21);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.DateNacimiento);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar_Impuestos";
            this.Text = "Agregar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Agregar_Impuestos_FormClosing);
            this.Load += new System.EventHandler(this.Agregar_Impuestos_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal Label Label1;
        internal Label Label2;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoP;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_agregar;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtApellidoM;
        internal Label Label5;
        internal Label Label6;
        internal Bunifu.Framework.UI.BunifuDatepicker DateNacimiento;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCelular;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtcurp;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnConsultaCurp;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultarCurp;
        internal Label Label7;
        internal System.ComponentModel.BackgroundWorker BackgroundAgregar;
        internal System.ComponentModel.BackgroundWorker BackgroundValidar;
        internal System.ComponentModel.BackgroundWorker BackgroundValidaExistencia;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal RadioButton RadioOp2;
        internal RadioButton RadioOp1;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultaCurpOp2;
        internal System.ComponentModel.BackgroundWorker backgroundConsultaCurpOP1;
    }
}