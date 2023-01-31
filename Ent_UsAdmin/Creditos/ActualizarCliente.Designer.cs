using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class ActualizarCliente : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarCliente));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label1 = new Label();
            Label2 = new Label();
            txtApellidoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtApellidoM = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label5 = new Label();
            Label6 = new Label();
            DateNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            Label3 = new Label();
            txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            txtCelular = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtcurp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            BackgroundConsultarCurp = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultarCurp.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultarCurp_DoWork);
            BackgroundConsultarCurp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultarCurp_RunWorkerCompleted);
            Label7 = new Label();
            BackgroundAgregar = new System.ComponentModel.BackgroundWorker();
            BackgroundAgregar.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundAgregar_DoWork);
            BackgroundAgregar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundAgregar_RunWorkerCompleted);
            BackgroundValidar = new System.ComponentModel.BackgroundWorker();
            BackgroundValidar.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundValidar_DoWork);
            BackgroundValidar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundValidar_RunWorkerCompleted);
            BackgroundValidaExistencia = new System.ComponentModel.BackgroundWorker();
            BackgroundValidaExistencia.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundValidaExistencia_DoWork);
            BackgroundValidaExistencia.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundValidaExistencia_RunWorkerCompleted);
            btnConsultaCurp = new Bunifu.Framework.UI.BunifuThinButton2();
            btnConsultaCurp.Click += new EventHandler(BunifuThinButton22_ClickAsync);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            btn_agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            BackgroundConsultarCliente = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultarCliente.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsultarCliente_DoWork);
            BackgroundConsultarCliente.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultarCliente_RunWorkerCompleted);
            BackgroundCreditosActivos = new System.ComponentModel.BackgroundWorker();
            BackgroundCreditosActivos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCreditosActivos_DoWork);
            BackgroundCreditosActivos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCreditosActivos_RunWorkerCompleted);
            BackgroundActualizarTodo = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizarTodo.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizarTodo_DoWork);
            BackgroundActualizarTodo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizarTodo_RunWorkerCompleted);
            BackgroundConsultaCurpOp2 = new System.ComponentModel.BackgroundWorker();
            BackgroundConsultaCurpOp2.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCurpOp2_DoWork);
            BackgroundConsultaCurpOp2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsultaCurpOp2_RunWorkerCompleted);
            RadioOp2 = new RadioButton();
            RadioOp2.CheckedChanged += new EventHandler(RadioOp2_CheckedChanged);
            RadioOp1 = new RadioButton();
            RadioOp1.CheckedChanged += new EventHandler(RadioOp1_CheckedChanged);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(RadioOp2);
            Panel1.Controls.Add(RadioOp1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(675, 36);
            Panel1.TabIndex = 1;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(131, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Actualizar Cliente";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(605, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
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
            txtnombre.Location = new Point(37, 127);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(171, 25);
            txtnombre.TabIndex = 6;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(34, 110);
            Label1.Name = "Label1";
            Label1.Size = new Size(44, 13);
            Label1.TabIndex = 7;
            Label1.Text = "Nombre";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(266, 110);
            Label2.Name = "Label2";
            Label2.Size = new Size(84, 13);
            Label2.TabIndex = 9;
            Label2.Text = "Apellido Paterno";
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
            txtApellidoP.Location = new Point(269, 127);
            txtApellidoP.Margin = new Padding(4);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(170, 25);
            txtApellidoP.TabIndex = 8;
            txtApellidoP.TextAlign = HorizontalAlignment.Left;
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
            txtApellidoM.Location = new Point(471, 127);
            txtApellidoM.Margin = new Padding(4);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(170, 25);
            txtApellidoM.TabIndex = 17;
            txtApellidoM.TextAlign = HorizontalAlignment.Left;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(468, 110);
            Label5.Name = "Label5";
            Label5.Size = new Size(86, 13);
            Label5.TabIndex = 18;
            Label5.Text = "Apellido Materno";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(35, 188);
            Label6.Name = "Label6";
            Label6.Size = new Size(108, 13);
            Label6.TabIndex = 20;
            Label6.Text = "Fecha de Nacimiento";
            // 
            // DateNacimiento
            // 
            DateNacimiento.BackColor = Color.FromArgb(0, 5, 11);
            DateNacimiento.BorderRadius = 0;
            DateNacimiento.ForeColor = Color.White;
            DateNacimiento.Format = DateTimePickerFormat.Short;
            DateNacimiento.FormatCustom = null;
            DateNacimiento.Location = new Point(38, 214);
            DateNacimiento.Name = "DateNacimiento";
            DateNacimiento.Size = new Size(170, 36);
            DateNacimiento.TabIndex = 21;
            DateNacimiento.Value = new DateTime(2019, 12, 20, 10, 35, 45, 980);
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(34, 47);
            Label3.Name = "Label3";
            Label3.Size = new Size(32, 13);
            Label3.TabIndex = 23;
            Label3.Text = "Curp:";
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Century Gothic", 9.75f);
            txtTelefono.ForeColor = Color.White;
            txtTelefono.HintForeColor = Color.White;
            txtTelefono.HintText = "";
            txtTelefono.isPassword = false;
            txtTelefono.LineFocusedColor = Color.Blue;
            txtTelefono.LineIdleColor = Color.Gray;
            txtTelefono.LineMouseHoverColor = Color.Blue;
            txtTelefono.LineThickness = 3;
            txtTelefono.Location = new Point(269, 214);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(170, 25);
            txtTelefono.TabIndex = 22;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(468, 197);
            Label4.Name = "Label4";
            Label4.Size = new Size(39, 13);
            Label4.TabIndex = 25;
            Label4.Text = "Celular";
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
            txtCelular.Location = new Point(471, 214);
            txtCelular.Margin = new Padding(4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(170, 25);
            txtCelular.TabIndex = 24;
            txtCelular.TextAlign = HorizontalAlignment.Left;
            // 
            // txtcurp
            // 
            txtcurp.Cursor = Cursors.IBeam;
            txtcurp.Font = new Font("Century Gothic", 9.75f);
            txtcurp.ForeColor = Color.White;
            txtcurp.HintForeColor = Color.White;
            txtcurp.HintText = "";
            txtcurp.isPassword = false;
            txtcurp.LineFocusedColor = Color.Blue;
            txtcurp.LineIdleColor = Color.Gray;
            txtcurp.LineMouseHoverColor = Color.Blue;
            txtcurp.LineThickness = 3;
            txtcurp.Location = new Point(38, 64);
            txtcurp.Margin = new Padding(4);
            txtcurp.Name = "txtcurp";
            txtcurp.Size = new Size(170, 25);
            txtcurp.TabIndex = 27;
            txtcurp.TextAlign = HorizontalAlignment.Left;
            // 
            // BackgroundConsultarCurp
            // 
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(266, 188);
            Label7.Name = "Label7";
            Label7.Size = new Size(52, 13);
            Label7.TabIndex = 29;
            Label7.Text = "Teléfono:";
            // 
            // BackgroundAgregar
            // 
            // 
            // BackgroundValidar
            // 
            // 
            // BackgroundValidaExistencia
            // 
            // 
            // btnConsultaCurp
            // 
            btnConsultaCurp.ActiveBorderThickness = 1;
            btnConsultaCurp.ActiveCornerRadius = 20;
            btnConsultaCurp.ActiveFillColor = Color.SeaGreen;
            btnConsultaCurp.ActiveForecolor = Color.White;
            btnConsultaCurp.ActiveLineColor = Color.SeaGreen;
            btnConsultaCurp.BackColor = Color.FromArgb(0, 5, 11);
            btnConsultaCurp.BackgroundImage = (Image)resources.GetObject("btnConsultaCurp.BackgroundImage");
            btnConsultaCurp.ButtonText = "Consultar";
            btnConsultaCurp.Cursor = Cursors.Hand;
            btnConsultaCurp.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultaCurp.ForeColor = Color.SeaGreen;
            btnConsultaCurp.IdleBorderThickness = 1;
            btnConsultaCurp.IdleCornerRadius = 20;
            btnConsultaCurp.IdleFillColor = Color.White;
            btnConsultaCurp.IdleForecolor = Color.SeaGreen;
            btnConsultaCurp.IdleLineColor = Color.SeaGreen;
            btnConsultaCurp.Location = new Point(260, 51);
            btnConsultaCurp.Margin = new Padding(5);
            btnConsultaCurp.Name = "btnConsultaCurp";
            btnConsultaCurp.Size = new Size(207, 38);
            btnConsultaCurp.TabIndex = 28;
            btnConsultaCurp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Agregar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(505, 426);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(207, 38);
            BunifuThinButton21.TabIndex = 26;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_agregar
            // 
            btn_agregar.ActiveBorderThickness = 1;
            btn_agregar.ActiveCornerRadius = 20;
            btn_agregar.ActiveFillColor = Color.SeaGreen;
            btn_agregar.ActiveForecolor = Color.White;
            btn_agregar.ActiveLineColor = Color.SeaGreen;
            btn_agregar.BackColor = Color.FromArgb(0, 5, 11);
            btn_agregar.BackgroundImage = (Image)resources.GetObject("btn_agregar.BackgroundImage");
            btn_agregar.ButtonText = "Actualizar";
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.SeaGreen;
            btn_agregar.IdleBorderThickness = 1;
            btn_agregar.IdleCornerRadius = 20;
            btn_agregar.IdleFillColor = Color.White;
            btn_agregar.IdleForecolor = Color.SeaGreen;
            btn_agregar.IdleLineColor = Color.SeaGreen;
            btn_agregar.Location = new Point(249, 287);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(207, 38);
            btn_agregar.TabIndex = 15;
            btn_agregar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundConsultarCliente
            // 
            // 
            // BackgroundCreditosActivos
            // 
            // 
            // BackgroundActualizarTodo
            // 
            // 
            // BackgroundConsultaCurpOp2
            // 
            // 
            // RadioOp2
            // 
            RadioOp2.AutoSize = true;
            RadioOp2.ForeColor = SystemColors.ButtonFace;
            RadioOp2.Location = new Point(423, 6);
            RadioOp2.Name = "RadioOp2";
            RadioOp2.Size = new Size(68, 17);
            RadioOp2.TabIndex = 31;
            RadioOp2.TabStop = true;
            RadioOp2.Text = "Opción 2";
            RadioOp2.UseVisualStyleBackColor = true;
            // 
            // RadioOp1
            // 
            RadioOp1.AutoSize = true;
            RadioOp1.Checked = true;
            RadioOp1.ForeColor = SystemColors.ButtonFace;
            RadioOp1.Location = new Point(340, 6);
            RadioOp1.Name = "RadioOp1";
            RadioOp1.Size = new Size(68, 17);
            RadioOp1.TabIndex = 30;
            RadioOp1.TabStop = true;
            RadioOp1.Text = "Opción 1";
            RadioOp1.UseVisualStyleBackColor = true;
            // 
            // ActualizarCliente
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(677, 341);
            Controls.Add(Label7);
            Controls.Add(btnConsultaCurp);
            Controls.Add(txtcurp);
            Controls.Add(BunifuThinButton21);
            Controls.Add(Label4);
            Controls.Add(txtCelular);
            Controls.Add(Label3);
            Controls.Add(txtTelefono);
            Controls.Add(DateNacimiento);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(txtApellidoM);
            Controls.Add(btn_agregar);
            Controls.Add(Label2);
            Controls.Add(txtApellidoP);
            Controls.Add(Label1);
            Controls.Add(txtnombre);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ActualizarCliente";
            Text = "Agregar Cliente";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            FormClosing += new FormClosingEventHandler(Agregar_Impuestos_FormClosing);
            Load += new EventHandler(Agregar_Impuestos_Load);
            ResumeLayout(false);
            PerformLayout();

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
        internal System.ComponentModel.BackgroundWorker BackgroundConsultarCliente;
        internal System.ComponentModel.BackgroundWorker BackgroundCreditosActivos;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizarTodo;
        internal System.ComponentModel.BackgroundWorker BackgroundConsultaCurpOp2;
        internal RadioButton RadioOp2;
        internal RadioButton RadioOp1;
    }
}