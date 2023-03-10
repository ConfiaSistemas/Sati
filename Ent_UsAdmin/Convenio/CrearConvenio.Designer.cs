using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class CrearConvenio : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearConvenio));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            Label1 = new Label();
            lblnombre = new MonoFlat.MonoFlat_HeaderLabel();
            Label2 = new Label();
            lblParteCredito = new MonoFlat.MonoFlat_HeaderLabel();
            Label3 = new Label();
            lblParteMoratorios = new MonoFlat.MonoFlat_HeaderLabel();
            lblTotal = new MonoFlat.MonoFlat_HeaderLabel();
            Label5 = new Label();
            GroupBox1 = new GroupBox();
            Label9 = new Label();
            lblModalidad = new Label();
            SwitchModalidad = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            SwitchModalidad.CheckedChanged += new Zeroit.Framework.Metro.ZeroitMetroSwitch.CheckedChangedEventHandler(SwitchModalidad_CheckedChanged);
            Label8 = new Label();
            datePrimerPago = new Bunifu.Framework.UI.BunifuDatepicker();
            MonoFlat_LinkLabel1 = new MonoFlat.MonoFlat_LinkLabel();
            MonoFlat_LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(MonoFlat_LinkLabel1_LinkClicked);
            Label7 = new Label();
            Label6 = new Label();
            txtCantPagos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtCantPagos.OnValueChanged += new EventHandler(txtCantPagos_OnValueChanged);
            txtCantPagos.KeyDown += new KeyEventHandler(txtCantPagos_KeyDown);
            lblTipoPagos = new Label();
            txtPago = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtPago.OnValueChanged += new EventHandler(txtPago_OnValueChanged);
            txtPago.KeyDown += new KeyEventHandler(txtPago_KeyDown);
            ZeroitMetroSwitch1 = new Zeroit.Framework.Metro.ZeroitMetroSwitch();
            ZeroitMetroSwitch1.CheckedChanged += new Zeroit.Framework.Metro.ZeroitMetroSwitch.CheckedChangedEventHandler(ZeroitMetroSwitch1_CheckedChanged);
            btnGenerarCalendario = new Bunifu.Framework.UI.BunifuThinButton2();
            btnGenerarCalendario.Click += new EventHandler(btnGenerarCalendario_Click);
            BackgroundDatos = new System.ComponentModel.BackgroundWorker();
            BackgroundDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDatos_DoWork);
            BackgroundDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDatos_RunWorkerCompleted);
            lblpagare = new MonoFlat.MonoFlat_HeaderLabel();
            Label10 = new Label();
            lblAbonadoSmultas = new MonoFlat.MonoFlat_HeaderLabel();
            Label11 = new Label();
            lblmultas = new MonoFlat.MonoFlat_HeaderLabel();
            Label12 = new Label();
            lblMultasAbonadas = new MonoFlat.MonoFlat_HeaderLabel();
            Label13 = new Label();
            lblDiasAtraso = new MonoFlat.MonoFlat_HeaderLabel();
            Label4 = new Label();
            Label14 = new Label();
            lblPagosVencidos = new MonoFlat.MonoFlat_HeaderLabel();
            Panel1.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(0, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1086, 36);
            Panel1.TabIndex = 4;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(1017, 3);
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
            MonoFlat_HeaderLabel1.Size = new Size(115, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Crear Convenio";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = SystemColors.ButtonHighlight;
            Label1.Location = new Point(50, 62);
            Label1.Name = "Label1";
            Label1.Size = new Size(44, 13);
            Label1.TabIndex = 5;
            Label1.Text = "Nombre";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.Transparent;
            lblnombre.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblnombre.ForeColor = Color.FromArgb(255, 255, 255);
            lblnombre.Location = new Point(49, 87);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(21, 20);
            lblnombre.TabIndex = 32;
            lblnombre.Text = "...";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = SystemColors.ButtonHighlight;
            Label2.Location = new Point(905, 129);
            Label2.Name = "Label2";
            Label2.Size = new Size(68, 13);
            Label2.TabIndex = 33;
            Label2.Text = "Parte Crédito";
            // 
            // lblParteCredito
            // 
            lblParteCredito.AutoSize = true;
            lblParteCredito.BackColor = Color.Transparent;
            lblParteCredito.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblParteCredito.ForeColor = Color.FromArgb(255, 255, 255);
            lblParteCredito.Location = new Point(904, 154);
            lblParteCredito.Name = "lblParteCredito";
            lblParteCredito.Size = new Size(21, 20);
            lblParteCredito.TabIndex = 34;
            lblParteCredito.Text = "...";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = SystemColors.ButtonHighlight;
            Label3.Location = new Point(54, 202);
            Label3.Name = "Label3";
            Label3.Size = new Size(84, 13);
            Label3.TabIndex = 35;
            Label3.Text = "Parte Moratorios";
            // 
            // lblParteMoratorios
            // 
            lblParteMoratorios.AutoSize = true;
            lblParteMoratorios.BackColor = Color.Transparent;
            lblParteMoratorios.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblParteMoratorios.ForeColor = Color.FromArgb(255, 255, 255);
            lblParteMoratorios.Location = new Point(53, 227);
            lblParteMoratorios.Name = "lblParteMoratorios";
            lblParteMoratorios.Size = new Size(21, 20);
            lblParteMoratorios.TabIndex = 36;
            lblParteMoratorios.Text = "...";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(255, 255, 255);
            lblTotal.Location = new Point(222, 227);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 20);
            lblTotal.TabIndex = 40;
            lblTotal.Text = "...";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = SystemColors.ButtonHighlight;
            Label5.Location = new Point(223, 202);
            Label5.Name = "Label5";
            Label5.Size = new Size(66, 13);
            Label5.TabIndex = 39;
            Label5.Text = "Deuda Total";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label9);
            GroupBox1.Controls.Add(lblModalidad);
            GroupBox1.Controls.Add(SwitchModalidad);
            GroupBox1.Controls.Add(Label8);
            GroupBox1.Controls.Add(datePrimerPago);
            GroupBox1.Controls.Add(MonoFlat_LinkLabel1);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(txtCantPagos);
            GroupBox1.Controls.Add(lblTipoPagos);
            GroupBox1.Controls.Add(txtPago);
            GroupBox1.Controls.Add(ZeroitMetroSwitch1);
            GroupBox1.ForeColor = SystemColors.ButtonFace;
            GroupBox1.Location = new Point(53, 290);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(990, 207);
            GroupBox1.TabIndex = 41;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Generar Calendario en Base A:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.ForeColor = SystemColors.ButtonHighlight;
            Label9.Location = new Point(13, 125);
            Label9.Name = "Label9";
            Label9.Size = new Size(56, 13);
            Label9.TabIndex = 49;
            Label9.Text = "Modalidad";
            // 
            // lblModalidad
            // 
            lblModalidad.AutoSize = true;
            lblModalidad.ForeColor = SystemColors.ButtonHighlight;
            lblModalidad.Location = new Point(108, 152);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(48, 13);
            lblModalidad.TabIndex = 48;
            lblModalidad.Text = "Semanal";
            // 
            // SwitchModalidad
            // 
            SwitchModalidad.BackColor = Color.Transparent;
            SwitchModalidad.BackgroundImageLayout = ImageLayout.None;
            SwitchModalidad.BorderColor = Color.FromArgb(98, 98, 98);
            SwitchModalidad.CheckColor = Color.FromArgb(0, 122, 204);
            SwitchModalidad.Checked = true;
            SwitchModalidad.DefaultColor = Color.FromArgb(190, 190, 190);
            SwitchModalidad.Font = new Font("Segoe UI", 9.0f);
            SwitchModalidad.HoverColor = Color.FromArgb(0, 153, 255);
            SwitchModalidad.Location = new Point(16, 152);
            SwitchModalidad.Name = "SwitchModalidad";
            SwitchModalidad.Size = new Size(75, 23);
            SwitchModalidad.SwitchColor = Color.White;
            SwitchModalidad.TabIndex = 47;
            SwitchModalidad.Text = "ZeroitMetroSwitch2";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = SystemColors.ButtonHighlight;
            Label8.Location = new Point(481, 39);
            Label8.Name = "Label8";
            Label8.Size = new Size(112, 13);
            Label8.TabIndex = 42;
            Label8.Text = "Fecha del primer pago";
            // 
            // datePrimerPago
            // 
            datePrimerPago.BackColor = Color.FromArgb(0, 5, 11);
            datePrimerPago.BorderRadius = 0;
            datePrimerPago.ForeColor = Color.White;
            datePrimerPago.Format = DateTimePickerFormat.Short;
            datePrimerPago.FormatCustom = null;
            datePrimerPago.Location = new Point(484, 65);
            datePrimerPago.Name = "datePrimerPago";
            datePrimerPago.Size = new Size(177, 33);
            datePrimerPago.TabIndex = 42;
            datePrimerPago.Value = new DateTime(2020, 8, 14, 0, 0, 0, 0);
            // 
            // MonoFlat_LinkLabel1
            // 
            MonoFlat_LinkLabel1.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            MonoFlat_LinkLabel1.AutoSize = true;
            MonoFlat_LinkLabel1.BackColor = Color.Transparent;
            MonoFlat_LinkLabel1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            MonoFlat_LinkLabel1.LinkColor = Color.FromArgb(181, 41, 42);
            MonoFlat_LinkLabel1.Location = new Point(297, 79);
            MonoFlat_LinkLabel1.Name = "MonoFlat_LinkLabel1";
            MonoFlat_LinkLabel1.Size = new Size(61, 15);
            MonoFlat_LinkLabel1.TabIndex = 46;
            MonoFlat_LinkLabel1.TabStop = true;
            MonoFlat_LinkLabel1.Text = "Saber Más";
            MonoFlat_LinkLabel1.VisitedLinkColor = Color.FromArgb(181, 41, 42);
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = SystemColors.ButtonHighlight;
            Label7.Location = new Point(161, 48);
            Label7.Name = "Label7";
            Label7.Size = new Size(97, 13);
            Label7.TabIndex = 45;
            Label7.Text = "Cantidad de Pagos";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = SystemColors.ButtonHighlight;
            Label6.Location = new Point(13, 48);
            Label6.Name = "Label6";
            Label6.Size = new Size(32, 13);
            Label6.TabIndex = 44;
            Label6.Text = "Pago";
            // 
            // txtCantPagos
            // 
            txtCantPagos.Cursor = Cursors.IBeam;
            txtCantPagos.Enabled = false;
            txtCantPagos.Font = new Font("Century Gothic", 9.75f);
            txtCantPagos.ForeColor = Color.White;
            txtCantPagos.HintForeColor = Color.White;
            txtCantPagos.HintText = "";
            txtCantPagos.isPassword = false;
            txtCantPagos.LineFocusedColor = Color.Blue;
            txtCantPagos.LineIdleColor = Color.Gray;
            txtCantPagos.LineMouseHoverColor = Color.Blue;
            txtCantPagos.LineThickness = 3;
            txtCantPagos.Location = new Point(164, 65);
            txtCantPagos.Margin = new Padding(4);
            txtCantPagos.Name = "txtCantPagos";
            txtCantPagos.Size = new Size(107, 29);
            txtCantPagos.TabIndex = 43;
            txtCantPagos.TextAlign = HorizontalAlignment.Left;
            // 
            // lblTipoPagos
            // 
            lblTipoPagos.AutoSize = true;
            lblTipoPagos.ForeColor = SystemColors.ButtonHighlight;
            lblTipoPagos.Location = new Point(108, 19);
            lblTipoPagos.Name = "lblTipoPagos";
            lblTipoPagos.Size = new Size(32, 13);
            lblTipoPagos.TabIndex = 42;
            lblTipoPagos.Text = "Pago";
            // 
            // txtPago
            // 
            txtPago.Cursor = Cursors.IBeam;
            txtPago.Font = new Font("Century Gothic", 9.75f);
            txtPago.ForeColor = Color.White;
            txtPago.HintForeColor = Color.White;
            txtPago.HintText = "";
            txtPago.isPassword = false;
            txtPago.LineFocusedColor = Color.Blue;
            txtPago.LineIdleColor = Color.Gray;
            txtPago.LineMouseHoverColor = Color.Blue;
            txtPago.LineThickness = 3;
            txtPago.Location = new Point(16, 65);
            txtPago.Margin = new Padding(4);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(107, 29);
            txtPago.TabIndex = 3;
            txtPago.TextAlign = HorizontalAlignment.Left;
            // 
            // ZeroitMetroSwitch1
            // 
            ZeroitMetroSwitch1.BackColor = Color.Transparent;
            ZeroitMetroSwitch1.BackgroundImageLayout = ImageLayout.None;
            ZeroitMetroSwitch1.BorderColor = Color.FromArgb(98, 98, 98);
            ZeroitMetroSwitch1.CheckColor = Color.FromArgb(0, 122, 204);
            ZeroitMetroSwitch1.Checked = true;
            ZeroitMetroSwitch1.DefaultColor = Color.FromArgb(190, 190, 190);
            ZeroitMetroSwitch1.Font = new Font("Segoe UI", 9.0f);
            ZeroitMetroSwitch1.HoverColor = Color.FromArgb(0, 153, 255);
            ZeroitMetroSwitch1.Location = new Point(16, 19);
            ZeroitMetroSwitch1.Name = "ZeroitMetroSwitch1";
            ZeroitMetroSwitch1.Size = new Size(75, 23);
            ZeroitMetroSwitch1.SwitchColor = Color.White;
            ZeroitMetroSwitch1.TabIndex = 0;
            ZeroitMetroSwitch1.Text = "ZeroitMetroSwitch1";
            // 
            // btnGenerarCalendario
            // 
            btnGenerarCalendario.ActiveBorderThickness = 1;
            btnGenerarCalendario.ActiveCornerRadius = 20;
            btnGenerarCalendario.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnGenerarCalendario.ActiveForecolor = Color.White;
            btnGenerarCalendario.ActiveLineColor = Color.SeaGreen;
            btnGenerarCalendario.BackColor = Color.FromArgb(0, 5, 11);
            btnGenerarCalendario.BackgroundImage = (Image)resources.GetObject("btnGenerarCalendario.BackgroundImage");
            btnGenerarCalendario.ButtonText = "Generar Calendario";
            btnGenerarCalendario.Cursor = Cursors.Hand;
            btnGenerarCalendario.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarCalendario.ForeColor = Color.DarkBlue;
            btnGenerarCalendario.IdleBorderThickness = 1;
            btnGenerarCalendario.IdleCornerRadius = 20;
            btnGenerarCalendario.IdleFillColor = Color.White;
            btnGenerarCalendario.IdleForecolor = Color.Gray;
            btnGenerarCalendario.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnGenerarCalendario.Location = new Point(446, 505);
            btnGenerarCalendario.Margin = new Padding(5);
            btnGenerarCalendario.Name = "btnGenerarCalendario";
            btnGenerarCalendario.Size = new Size(173, 38);
            btnGenerarCalendario.TabIndex = 154;
            btnGenerarCalendario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundDatos
            // 
            // 
            // lblpagare
            // 
            lblpagare.AutoSize = true;
            lblpagare.BackColor = Color.Transparent;
            lblpagare.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblpagare.ForeColor = Color.FromArgb(255, 255, 255);
            lblpagare.Location = new Point(53, 154);
            lblpagare.Name = "lblpagare";
            lblpagare.Size = new Size(21, 20);
            lblpagare.TabIndex = 156;
            lblpagare.Text = "...";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.ForeColor = SystemColors.ButtonHighlight;
            Label10.Location = new Point(54, 129);
            Label10.Name = "Label10";
            Label10.Size = new Size(41, 13);
            Label10.TabIndex = 155;
            Label10.Text = "Pagaré";
            // 
            // lblAbonadoSmultas
            // 
            lblAbonadoSmultas.AutoSize = true;
            lblAbonadoSmultas.BackColor = Color.Transparent;
            lblAbonadoSmultas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblAbonadoSmultas.ForeColor = Color.FromArgb(255, 255, 255);
            lblAbonadoSmultas.Location = new Point(222, 154);
            lblAbonadoSmultas.Name = "lblAbonadoSmultas";
            lblAbonadoSmultas.Size = new Size(21, 20);
            lblAbonadoSmultas.TabIndex = 158;
            lblAbonadoSmultas.Text = "...";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = SystemColors.ButtonHighlight;
            Label11.Location = new Point(223, 129);
            Label11.Name = "Label11";
            Label11.Size = new Size(102, 13);
            Label11.TabIndex = 157;
            Label11.Text = "Abonado Sin Multas";
            // 
            // lblmultas
            // 
            lblmultas.AutoSize = true;
            lblmultas.BackColor = Color.Transparent;
            lblmultas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblmultas.ForeColor = Color.FromArgb(255, 255, 255);
            lblmultas.Location = new Point(437, 154);
            lblmultas.Name = "lblmultas";
            lblmultas.Size = new Size(21, 20);
            lblmultas.TabIndex = 160;
            lblmultas.Text = "...";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.ForeColor = SystemColors.ButtonHighlight;
            Label12.Location = new Point(438, 129);
            Label12.Name = "Label12";
            Label12.Size = new Size(93, 13);
            Label12.TabIndex = 159;
            Label12.Text = "Multas Generadas";
            // 
            // lblMultasAbonadas
            // 
            lblMultasAbonadas.AutoSize = true;
            lblMultasAbonadas.BackColor = Color.Transparent;
            lblMultasAbonadas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMultasAbonadas.ForeColor = Color.FromArgb(255, 255, 255);
            lblMultasAbonadas.Location = new Point(681, 154);
            lblMultasAbonadas.Name = "lblMultasAbonadas";
            lblMultasAbonadas.Size = new Size(21, 20);
            lblMultasAbonadas.TabIndex = 162;
            lblMultasAbonadas.Text = "...";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = SystemColors.ButtonHighlight;
            Label13.Location = new Point(682, 129);
            Label13.Name = "Label13";
            Label13.Size = new Size(89, 13);
            Label13.TabIndex = 161;
            Label13.Text = "Multas Abonadas";
            // 
            // lblDiasAtraso
            // 
            lblDiasAtraso.AutoSize = true;
            lblDiasAtraso.BackColor = Color.Transparent;
            lblDiasAtraso.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblDiasAtraso.ForeColor = Color.FromArgb(255, 255, 255);
            lblDiasAtraso.Location = new Point(437, 227);
            lblDiasAtraso.Name = "lblDiasAtraso";
            lblDiasAtraso.Size = new Size(21, 20);
            lblDiasAtraso.TabIndex = 164;
            lblDiasAtraso.Text = "...";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = SystemColors.ButtonHighlight;
            Label4.Location = new Point(438, 202);
            Label4.Name = "Label4";
            Label4.Size = new Size(177, 13);
            Label4.TabIndex = 163;
            Label4.Text = "Días de atraso desde el último pago";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.ForeColor = SystemColors.ButtonHighlight;
            Label14.Location = new Point(682, 202);
            Label14.Name = "Label14";
            Label14.Size = new Size(84, 13);
            Label14.TabIndex = 165;
            Label14.Text = "Pagos Vencidos";
            // 
            // lblPagosVencidos
            // 
            lblPagosVencidos.AutoSize = true;
            lblPagosVencidos.BackColor = Color.Transparent;
            lblPagosVencidos.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblPagosVencidos.ForeColor = Color.FromArgb(255, 255, 255);
            lblPagosVencidos.Location = new Point(681, 227);
            lblPagosVencidos.Name = "lblPagosVencidos";
            lblPagosVencidos.Size = new Size(21, 20);
            lblPagosVencidos.TabIndex = 166;
            lblPagosVencidos.Text = "...";
            // 
            // CrearConvenio
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1086, 557);
            Controls.Add(lblPagosVencidos);
            Controls.Add(Label14);
            Controls.Add(lblDiasAtraso);
            Controls.Add(Label4);
            Controls.Add(lblMultasAbonadas);
            Controls.Add(Label13);
            Controls.Add(lblmultas);
            Controls.Add(Label12);
            Controls.Add(lblAbonadoSmultas);
            Controls.Add(Label11);
            Controls.Add(lblpagare);
            Controls.Add(Label10);
            Controls.Add(btnGenerarCalendario);
            Controls.Add(GroupBox1);
            Controls.Add(lblTotal);
            Controls.Add(Label5);
            Controls.Add(lblParteMoratorios);
            Controls.Add(Label3);
            Controls.Add(lblParteCredito);
            Controls.Add(Label2);
            Controls.Add(lblnombre);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearConvenio";
            Text = "Crear Convenio";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(CrearConvenioLegal_Load);
            ResumeLayout(false);
            PerformLayout();

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
        internal MonoFlat.MonoFlat_HeaderLabel lblDiasAtraso;
        internal Label Label4;
        internal Label Label14;
        internal MonoFlat.MonoFlat_HeaderLabel lblPagosVencidos;
    }
}