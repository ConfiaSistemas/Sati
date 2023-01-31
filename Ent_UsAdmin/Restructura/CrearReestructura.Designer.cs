using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class CrearReestructura : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearReestructura));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblnombre = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblParteCredito = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblParteMoratorios = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblTotal = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.SwitchModalidad = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.Label8 = new System.Windows.Forms.Label();
            this.datePrimerPago = new Bunifu.Framework.UI.BunifuDatepicker();
            this.MonoFlat_LinkLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_LinkLabel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtCantPagos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTipoPagos = new System.Windows.Forms.Label();
            this.txtPago = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ZeroitMetroSwitch1 = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            this.btnGenerarCalendario = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundDatos = new System.ComponentModel.BackgroundWorker();
            this.lblpagare = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label10 = new System.Windows.Forms.Label();
            this.lblAbonadoSmultas = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblmultas = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label12 = new System.Windows.Forms.Label();
            this.lblMultasAbonadas = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label13 = new System.Windows.Forms.Label();
            this.lbldiasCancelado = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblAbonadoCancelacion = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label14 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(0, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1086, 36);
            this.Panel1.TabIndex = 4;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(1017, 3);
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
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(140, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Crear Reestructura";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(50, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Nombre";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblnombre.Location = new System.Drawing.Point(49, 87);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(21, 20);
            this.lblnombre.TabIndex = 32;
            this.lblnombre.Text = "...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label2.Location = new System.Drawing.Point(907, 129);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 13);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Parte Crédito";
            // 
            // lblParteCredito
            // 
            this.lblParteCredito.AutoSize = true;
            this.lblParteCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblParteCredito.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblParteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblParteCredito.Location = new System.Drawing.Point(906, 154);
            this.lblParteCredito.Name = "lblParteCredito";
            this.lblParteCredito.Size = new System.Drawing.Size(21, 20);
            this.lblParteCredito.TabIndex = 34;
            this.lblParteCredito.Text = "...";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label3.Location = new System.Drawing.Point(54, 202);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 13);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "Parte Moratorios";
            // 
            // lblParteMoratorios
            // 
            this.lblParteMoratorios.AutoSize = true;
            this.lblParteMoratorios.BackColor = System.Drawing.Color.Transparent;
            this.lblParteMoratorios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblParteMoratorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblParteMoratorios.Location = new System.Drawing.Point(53, 227);
            this.lblParteMoratorios.Name = "lblParteMoratorios";
            this.lblParteMoratorios.Size = new System.Drawing.Size(21, 20);
            this.lblParteMoratorios.TabIndex = 36;
            this.lblParteMoratorios.Text = "...";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(234, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 20);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "...";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label5.Location = new System.Drawing.Point(235, 202);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 13);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Deuda Total";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.lblModalidad);
            this.GroupBox1.Controls.Add(this.SwitchModalidad);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.datePrimerPago);
            this.GroupBox1.Controls.Add(this.MonoFlat_LinkLabel1);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtCantPagos);
            this.GroupBox1.Controls.Add(this.lblTipoPagos);
            this.GroupBox1.Controls.Add(this.txtPago);
            this.GroupBox1.Controls.Add(this.ZeroitMetroSwitch1);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox1.Location = new System.Drawing.Point(53, 290);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(990, 207);
            this.GroupBox1.TabIndex = 41;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Generar Calendario en Base A:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label9.Location = new System.Drawing.Point(13, 125);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(56, 13);
            this.Label9.TabIndex = 49;
            this.Label9.Text = "Modalidad";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModalidad.Location = new System.Drawing.Point(108, 152);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(48, 13);
            this.lblModalidad.TabIndex = 48;
            this.lblModalidad.Text = "Semanal";
            // 
            // SwitchModalidad
            // 
            this.SwitchModalidad.BackColor = System.Drawing.Color.Transparent;
            this.SwitchModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SwitchModalidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.SwitchModalidad.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SwitchModalidad.Checked = true;
            this.SwitchModalidad.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.SwitchModalidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SwitchModalidad.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SwitchModalidad.Location = new System.Drawing.Point(16, 152);
            this.SwitchModalidad.Name = "SwitchModalidad";
            this.SwitchModalidad.Size = new System.Drawing.Size(75, 23);
            this.SwitchModalidad.SwitchColor = System.Drawing.Color.White;
            this.SwitchModalidad.TabIndex = 47;
            this.SwitchModalidad.Text = "ZeroitMetroSwitch2";
            this.SwitchModalidad.CheckedChanged += new Zeroit.Framework.Metro.ZeroitMetroSwitch.CheckedChangedEventHandler(this.SwitchModalidad_CheckedChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label8.Location = new System.Drawing.Point(481, 39);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(112, 13);
            this.Label8.TabIndex = 42;
            this.Label8.Text = "Fecha del primer pago";
            // 
            // datePrimerPago
            // 
            this.datePrimerPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.datePrimerPago.BorderRadius = 0;
            this.datePrimerPago.ForeColor = System.Drawing.Color.White;
            this.datePrimerPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePrimerPago.FormatCustom = null;
            this.datePrimerPago.Location = new System.Drawing.Point(484, 65);
            this.datePrimerPago.Name = "datePrimerPago";
            this.datePrimerPago.Size = new System.Drawing.Size(177, 33);
            this.datePrimerPago.TabIndex = 42;
            this.datePrimerPago.Value = new System.DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_LinkLabel1
            // 
            this.MonoFlat_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MonoFlat_LinkLabel1.AutoSize = true;
            this.MonoFlat_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonoFlat_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.MonoFlat_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.MonoFlat_LinkLabel1.Location = new System.Drawing.Point(297, 79);
            this.MonoFlat_LinkLabel1.Name = "MonoFlat_LinkLabel1";
            this.MonoFlat_LinkLabel1.Size = new System.Drawing.Size(61, 15);
            this.MonoFlat_LinkLabel1.TabIndex = 46;
            this.MonoFlat_LinkLabel1.TabStop = true;
            this.MonoFlat_LinkLabel1.Text = "Saber Más";
            this.MonoFlat_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.MonoFlat_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MonoFlat_LinkLabel1_LinkClicked);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label7.Location = new System.Drawing.Point(161, 48);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(97, 13);
            this.Label7.TabIndex = 45;
            this.Label7.Text = "Cantidad de Pagos";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label6.Location = new System.Drawing.Point(13, 48);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "Pago";
            // 
            // txtCantPagos
            // 
            this.txtCantPagos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantPagos.Enabled = false;
            this.txtCantPagos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantPagos.ForeColor = System.Drawing.Color.White;
            this.txtCantPagos.HintForeColor = System.Drawing.Color.White;
            this.txtCantPagos.HintText = "";
            this.txtCantPagos.isPassword = false;
            this.txtCantPagos.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCantPagos.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCantPagos.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCantPagos.LineThickness = 3;
            this.txtCantPagos.Location = new System.Drawing.Point(164, 65);
            this.txtCantPagos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantPagos.Name = "txtCantPagos";
            this.txtCantPagos.Size = new System.Drawing.Size(107, 29);
            this.txtCantPagos.TabIndex = 43;
            this.txtCantPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantPagos.OnValueChanged += new System.EventHandler(this.txtCantPagos_OnValueChanged);
            this.txtCantPagos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantPagos_KeyDown);
            // 
            // lblTipoPagos
            // 
            this.lblTipoPagos.AutoSize = true;
            this.lblTipoPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipoPagos.Location = new System.Drawing.Point(108, 19);
            this.lblTipoPagos.Name = "lblTipoPagos";
            this.lblTipoPagos.Size = new System.Drawing.Size(32, 13);
            this.lblTipoPagos.TabIndex = 42;
            this.lblTipoPagos.Text = "Pago";
            // 
            // txtPago
            // 
            this.txtPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPago.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPago.ForeColor = System.Drawing.Color.White;
            this.txtPago.HintForeColor = System.Drawing.Color.White;
            this.txtPago.HintText = "";
            this.txtPago.isPassword = false;
            this.txtPago.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPago.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPago.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPago.LineThickness = 3;
            this.txtPago.Location = new System.Drawing.Point(16, 65);
            this.txtPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(107, 29);
            this.txtPago.TabIndex = 3;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPago.OnValueChanged += new System.EventHandler(this.txtPago_OnValueChanged);
            this.txtPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPago_KeyDown);
            // 
            // ZeroitMetroSwitch1
            // 
            this.ZeroitMetroSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.ZeroitMetroSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ZeroitMetroSwitch1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ZeroitMetroSwitch1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ZeroitMetroSwitch1.Checked = true;
            this.ZeroitMetroSwitch1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.ZeroitMetroSwitch1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ZeroitMetroSwitch1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ZeroitMetroSwitch1.Location = new System.Drawing.Point(16, 19);
            this.ZeroitMetroSwitch1.Name = "ZeroitMetroSwitch1";
            this.ZeroitMetroSwitch1.Size = new System.Drawing.Size(75, 23);
            this.ZeroitMetroSwitch1.SwitchColor = System.Drawing.Color.White;
            this.ZeroitMetroSwitch1.TabIndex = 0;
            this.ZeroitMetroSwitch1.Text = "ZeroitMetroSwitch1";
            this.ZeroitMetroSwitch1.CheckedChanged += new Zeroit.Framework.Metro.ZeroitMetroSwitch.CheckedChangedEventHandler(this.ZeroitMetroSwitch1_CheckedChanged);
            // 
            // btnGenerarCalendario
            // 
            this.btnGenerarCalendario.ActiveBorderThickness = 1;
            this.btnGenerarCalendario.ActiveCornerRadius = 20;
            this.btnGenerarCalendario.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnGenerarCalendario.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerarCalendario.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenerarCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnGenerarCalendario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarCalendario.BackgroundImage")));
            this.btnGenerarCalendario.ButtonText = "Generar Calendario";
            this.btnGenerarCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarCalendario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCalendario.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGenerarCalendario.IdleBorderThickness = 1;
            this.btnGenerarCalendario.IdleCornerRadius = 20;
            this.btnGenerarCalendario.IdleFillColor = System.Drawing.Color.White;
            this.btnGenerarCalendario.IdleForecolor = System.Drawing.Color.Gray;
            this.btnGenerarCalendario.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnGenerarCalendario.Location = new System.Drawing.Point(446, 505);
            this.btnGenerarCalendario.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerarCalendario.Name = "btnGenerarCalendario";
            this.btnGenerarCalendario.Size = new System.Drawing.Size(173, 38);
            this.btnGenerarCalendario.TabIndex = 154;
            this.btnGenerarCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerarCalendario.Click += new System.EventHandler(this.btnGenerarCalendario_Click);

            // 
            // BackgroundDatos
            // 
            this.BackgroundDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDatos_DoWork);
            this.BackgroundDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDatos_RunWorkerCompleted);
            // 
            // lblpagare
            // 
            this.lblpagare.AutoSize = true;
            this.lblpagare.BackColor = System.Drawing.Color.Transparent;
            this.lblpagare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblpagare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblpagare.Location = new System.Drawing.Point(53, 154);
            this.lblpagare.Name = "lblpagare";
            this.lblpagare.Size = new System.Drawing.Size(21, 20);
            this.lblpagare.TabIndex = 156;
            this.lblpagare.Text = "...";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label10.Location = new System.Drawing.Point(54, 129);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(41, 13);
            this.Label10.TabIndex = 155;
            this.Label10.Text = "Pagaré";
            // 
            // lblAbonadoSmultas
            // 
            this.lblAbonadoSmultas.AutoSize = true;
            this.lblAbonadoSmultas.BackColor = System.Drawing.Color.Transparent;
            this.lblAbonadoSmultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAbonadoSmultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAbonadoSmultas.Location = new System.Drawing.Point(234, 154);
            this.lblAbonadoSmultas.Name = "lblAbonadoSmultas";
            this.lblAbonadoSmultas.Size = new System.Drawing.Size(21, 20);
            this.lblAbonadoSmultas.TabIndex = 158;
            this.lblAbonadoSmultas.Text = "...";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label11.Location = new System.Drawing.Point(235, 129);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(102, 13);
            this.Label11.TabIndex = 157;
            this.Label11.Text = "Abonado Sin Multas";
            // 
            // lblmultas
            // 
            this.lblmultas.AutoSize = true;
            this.lblmultas.BackColor = System.Drawing.Color.Transparent;
            this.lblmultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblmultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblmultas.Location = new System.Drawing.Point(457, 154);
            this.lblmultas.Name = "lblmultas";
            this.lblmultas.Size = new System.Drawing.Size(21, 20);
            this.lblmultas.TabIndex = 160;
            this.lblmultas.Text = "...";
            this.lblmultas.Click += new System.EventHandler(this.lblmultas_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label12.Location = new System.Drawing.Point(458, 129);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(93, 13);
            this.Label12.TabIndex = 159;
            this.Label12.Text = "Multas Generadas";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // lblMultasAbonadas
            // 
            this.lblMultasAbonadas.AutoSize = true;
            this.lblMultasAbonadas.BackColor = System.Drawing.Color.Transparent;
            this.lblMultasAbonadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMultasAbonadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMultasAbonadas.Location = new System.Drawing.Point(699, 154);
            this.lblMultasAbonadas.Name = "lblMultasAbonadas";
            this.lblMultasAbonadas.Size = new System.Drawing.Size(21, 20);
            this.lblMultasAbonadas.TabIndex = 162;
            this.lblMultasAbonadas.Text = "...";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label13.Location = new System.Drawing.Point(700, 129);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(89, 13);
            this.Label13.TabIndex = 161;
            this.Label13.Text = "Multas Abonadas";
            // 
            // lbldiasCancelado
            // 
            this.lbldiasCancelado.AutoSize = true;
            this.lbldiasCancelado.BackColor = System.Drawing.Color.Transparent;
            this.lbldiasCancelado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbldiasCancelado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbldiasCancelado.Location = new System.Drawing.Point(457, 227);
            this.lbldiasCancelado.Name = "lbldiasCancelado";
            this.lbldiasCancelado.Size = new System.Drawing.Size(21, 20);
            this.lbldiasCancelado.TabIndex = 164;
            this.lbldiasCancelado.Text = "...";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(458, 202);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(187, 13);
            this.Label4.TabIndex = 163;
            this.Label4.Text = "Días desde cancelación del convenio";
            // 
            // lblAbonadoCancelacion
            // 
            this.lblAbonadoCancelacion.AutoSize = true;
            this.lblAbonadoCancelacion.BackColor = System.Drawing.Color.Transparent;
            this.lblAbonadoCancelacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAbonadoCancelacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAbonadoCancelacion.Location = new System.Drawing.Point(699, 227);
            this.lblAbonadoCancelacion.Name = "lblAbonadoCancelacion";
            this.lblAbonadoCancelacion.Size = new System.Drawing.Size(21, 20);
            this.lblAbonadoCancelacion.TabIndex = 166;
            this.lblAbonadoCancelacion.Text = "...";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label14.Location = new System.Drawing.Point(700, 202);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(154, 13);
            this.Label14.TabIndex = 165;
            this.Label14.Text = "Abonado desde la cancelación";
            // 
            // CrearReestructura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1086, 557);
            this.Controls.Add(this.lblAbonadoCancelacion);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.lbldiasCancelado);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblMultasAbonadas);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.lblmultas);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.lblAbonadoSmultas);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.lblpagare);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.btnGenerarCalendario);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lblParteMoratorios);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblParteCredito);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearReestructura";
            this.Text = "Crear Convenio";
            this.Load += new System.EventHandler(this.CrearConvenioLegal_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Label Label1;
        internal MonoFlat.MonoFlat_HeaderLabel lblnombre;
        internal Label Label2;
        internal MonoFlat.MonoFlat_HeaderLabel lblParteCredito;
        internal Label Label3;
        internal MonoFlat.MonoFlat_HeaderLabel lblParteMoratorios;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotal;
        internal Label Label5;
        internal GroupBox GroupBox1;
        internal Zeroit.Framework.Metro.ZeroitMetroSwitch ZeroitMetroSwitch1;
        internal Label lblTipoPagos;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPago;
        internal MonoFlat.MonoFlat_LinkLabel MonoFlat_LinkLabel1;
        internal Label Label7;
        internal Label Label6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCantPagos;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuDatepicker datePrimerPago;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnGenerarCalendario;
        internal Label Label9;
        internal Label lblModalidad;
        internal Zeroit.Framework.Metro.ZeroitMetroSwitch SwitchModalidad;
        internal System.ComponentModel.BackgroundWorker BackgroundDatos;
        internal MonoFlat.MonoFlat_HeaderLabel lblpagare;
        internal Label Label10;
        internal MonoFlat.MonoFlat_HeaderLabel lblAbonadoSmultas;
        internal Label Label11;
        internal MonoFlat.MonoFlat_HeaderLabel lblmultas;
        internal Label Label12;
        internal MonoFlat.MonoFlat_HeaderLabel lblMultasAbonadas;
        internal Label Label13;
        internal MonoFlat.MonoFlat_HeaderLabel lbldiasCancelado;
        internal Label Label4;
        internal MonoFlat.MonoFlat_HeaderLabel lblAbonadoCancelacion;
        internal Label Label14;
    }
}