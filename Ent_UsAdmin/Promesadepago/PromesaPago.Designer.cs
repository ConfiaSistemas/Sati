using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]


    public partial class PromesaPago : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PromesaPago));
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
            Label8 = new Label();
            dateFechaLimite = new Bunifu.Framework.UI.BunifuDatepicker();
            btnGenerarPromesa = new Bunifu.Framework.UI.BunifuThinButton2();
            btnGenerarPromesa.Click += new EventHandler(btnGenerarCalendario_Click);
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
            txtPago = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label6 = new Label();
            BackgroundCreaPromesa = new System.ComponentModel.BackgroundWorker();
            BackgroundCreaPromesa.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCreaPromesa_DoWork);
            BackgroundCreaPromesa.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCreaPromesa_RunWorkerCompleted);
            Windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            Panel1.SuspendLayout();
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
            MonoFlat_HeaderLabel1.Size = new Size(171, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Crear promesa de pago";
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
            Label2.Location = new Point(52, 202);
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
            lblParteCredito.Location = new Point(51, 227);
            lblParteCredito.Name = "lblParteCredito";
            lblParteCredito.Size = new Size(21, 20);
            lblParteCredito.TabIndex = 34;
            lblParteCredito.Text = "...";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = SystemColors.ButtonHighlight;
            Label3.Location = new Point(305, 202);
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
            lblParteMoratorios.Location = new Point(304, 227);
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
            lblTotal.Location = new Point(533, 227);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(21, 20);
            lblTotal.TabIndex = 40;
            lblTotal.Text = "...";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = SystemColors.ButtonHighlight;
            Label5.Location = new Point(534, 202);
            Label5.Name = "Label5";
            Label5.Size = new Size(66, 13);
            Label5.TabIndex = 39;
            Label5.Text = "Deuda Total";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = SystemColors.ButtonHighlight;
            Label8.Location = new Point(209, 312);
            Label8.Name = "Label8";
            Label8.Size = new Size(69, 13);
            Label8.TabIndex = 42;
            Label8.Text = "Fecha Límite";
            // 
            // dateFechaLimite
            // 
            dateFechaLimite.BackColor = Color.FromArgb(0, 5, 11);
            dateFechaLimite.BorderRadius = 0;
            dateFechaLimite.ForeColor = Color.White;
            dateFechaLimite.Format = DateTimePickerFormat.Short;
            dateFechaLimite.FormatCustom = null;
            dateFechaLimite.Location = new Point(212, 338);
            dateFechaLimite.Name = "dateFechaLimite";
            dateFechaLimite.Size = new Size(177, 33);
            dateFechaLimite.TabIndex = 42;
            dateFechaLimite.Value = new DateTime(2020, 8, 14, 0, 0, 0, 0);
            // 
            // btnGenerarPromesa
            // 
            btnGenerarPromesa.ActiveBorderThickness = 1;
            btnGenerarPromesa.ActiveCornerRadius = 20;
            btnGenerarPromesa.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnGenerarPromesa.ActiveForecolor = Color.White;
            btnGenerarPromesa.ActiveLineColor = Color.SeaGreen;
            btnGenerarPromesa.BackColor = Color.FromArgb(0, 5, 11);
            btnGenerarPromesa.BackgroundImage = (Image)resources.GetObject("btnGenerarPromesa.BackgroundImage");
            btnGenerarPromesa.ButtonText = "Generar promesa";
            btnGenerarPromesa.Cursor = Cursors.Hand;
            btnGenerarPromesa.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarPromesa.ForeColor = Color.DarkBlue;
            btnGenerarPromesa.IdleBorderThickness = 1;
            btnGenerarPromesa.IdleCornerRadius = 20;
            btnGenerarPromesa.IdleFillColor = Color.White;
            btnGenerarPromesa.IdleForecolor = Color.Gray;
            btnGenerarPromesa.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnGenerarPromesa.Location = new Point(455, 403);
            btnGenerarPromesa.Margin = new Padding(5);
            btnGenerarPromesa.Name = "btnGenerarPromesa";
            btnGenerarPromesa.Size = new Size(173, 38);
            btnGenerarPromesa.TabIndex = 154;
            btnGenerarPromesa.TextAlign = ContentAlignment.MiddleCenter;
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
            lblAbonadoSmultas.Location = new Point(304, 154);
            lblAbonadoSmultas.Name = "lblAbonadoSmultas";
            lblAbonadoSmultas.Size = new Size(21, 20);
            lblAbonadoSmultas.TabIndex = 158;
            lblAbonadoSmultas.Text = "...";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = SystemColors.ButtonHighlight;
            Label11.Location = new Point(305, 129);
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
            lblmultas.Location = new Point(534, 154);
            lblmultas.Name = "lblmultas";
            lblmultas.Size = new Size(21, 20);
            lblmultas.TabIndex = 160;
            lblmultas.Text = "...";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.ForeColor = SystemColors.ButtonHighlight;
            Label12.Location = new Point(535, 129);
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
            lblMultasAbonadas.Location = new Point(770, 154);
            lblMultasAbonadas.Name = "lblMultasAbonadas";
            lblMultasAbonadas.Size = new Size(21, 20);
            lblMultasAbonadas.TabIndex = 162;
            lblMultasAbonadas.Text = "...";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = SystemColors.ButtonHighlight;
            Label13.Location = new Point(771, 129);
            Label13.Name = "Label13";
            Label13.Size = new Size(89, 13);
            Label13.TabIndex = 161;
            Label13.Text = "Multas Abonadas";
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
            txtPago.Location = new Point(53, 338);
            txtPago.Margin = new Padding(4);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(107, 29);
            txtPago.TabIndex = 3;
            txtPago.TextAlign = HorizontalAlignment.Left;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = SystemColors.ButtonHighlight;
            Label6.Location = new Point(50, 321);
            Label6.Name = "Label6";
            Label6.Size = new Size(76, 13);
            Label6.TabIndex = 44;
            Label6.Text = "Monto a pagar";
            // 
            // BackgroundCreaPromesa
            // 
            // 
            // PromesaPago
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1086, 464);
            Controls.Add(lblMultasAbonadas);
            Controls.Add(Label13);
            Controls.Add(lblmultas);
            Controls.Add(Label8);
            Controls.Add(Label12);
            Controls.Add(Label6);
            Controls.Add(dateFechaLimite);
            Controls.Add(lblAbonadoSmultas);
            Controls.Add(Label11);
            Controls.Add(txtPago);
            Controls.Add(lblpagare);
            Controls.Add(Label10);
            Controls.Add(btnGenerarPromesa);
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
            Name = "PromesaPago";
            Text = "Crear promesa de pago";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
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
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuDatepicker dateFechaLimite;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnGenerarPromesa;
        internal System.ComponentModel.BackgroundWorker BackgroundDatos;
        internal MonoFlat.MonoFlat_HeaderLabel lblpagare;
        internal Label Label10;
        internal MonoFlat.MonoFlat_HeaderLabel lblAbonadoSmultas;
        internal Label Label11;
        internal MonoFlat.MonoFlat_HeaderLabel lblmultas;
        internal Label Label12;
        internal MonoFlat.MonoFlat_HeaderLabel lblMultasAbonadas;
        internal Label Label13;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPago;
        internal Label Label6;
        internal System.ComponentModel.BackgroundWorker BackgroundCreaPromesa;
        internal Telerik.WinControls.Themes.Windows8Theme Windows8Theme1;
    }
}