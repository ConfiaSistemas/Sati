using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ModificarEmpresa : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpresa));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            txtRazonSocial = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            txtRFC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel5 = new MonoFlat.MonoFlat_HeaderLabel();
            txtCalle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel6 = new MonoFlat.MonoFlat_HeaderLabel();
            txtNoExterior = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel8 = new MonoFlat.MonoFlat_HeaderLabel();
            txtCP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel9 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel10 = new MonoFlat.MonoFlat_HeaderLabel();
            txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel11 = new MonoFlat.MonoFlat_HeaderLabel();
            txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel12 = new MonoFlat.MonoFlat_HeaderLabel();
            txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel13 = new MonoFlat.MonoFlat_HeaderLabel();
            txtIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel14 = new MonoFlat.MonoFlat_HeaderLabel();
            txtBD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel15 = new MonoFlat.MonoFlat_HeaderLabel();
            txtPrefijo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel16 = new MonoFlat.MonoFlat_HeaderLabel();
            txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            MonoFlat_HeaderLabel17 = new MonoFlat.MonoFlat_HeaderLabel();
            txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            BackgroundInformacionEmpresa = new System.ComponentModel.BackgroundWorker();
            BackgroundInformacionEmpresa.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundInformacionEmpresa_DoWork);
            BackgroundInformacionEmpresa.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundInformacionEmpresa_RunWorkerCompleted);
            txtColonia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BackgroundActualizar = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizar.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizar_DoWork);
            BackgroundActualizar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizar_RunWorkerCompleted);
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(646, 36);
            Panel1.TabIndex = 7;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(580, 3);
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
            MonoFlat_HeaderLabel1.Size = new Size(140, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Modificar Empresa";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Century Gothic", 9.75f);
            txtNombre.ForeColor = Color.White;
            txtNombre.HintForeColor = Color.White;
            txtNombre.HintText = "";
            txtNombre.isPassword = false;
            txtNombre.LineFocusedColor = Color.Blue;
            txtNombre.LineIdleColor = Color.Gray;
            txtNombre.LineMouseHoverColor = Color.Blue;
            txtNombre.LineThickness = 3;
            txtNombre.Location = new Point(8, 68);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(354, 33);
            txtNombre.TabIndex = 8;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(4, 49);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(139, 20);
            MonoFlat_HeaderLabel2.TabIndex = 32;
            MonoFlat_HeaderLabel2.Text = "Nombre a mostrar";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(4, 110);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(95, 20);
            MonoFlat_HeaderLabel3.TabIndex = 34;
            MonoFlat_HeaderLabel3.Text = "Razón social";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Cursor = Cursors.IBeam;
            txtRazonSocial.Font = new Font("Century Gothic", 9.75f);
            txtRazonSocial.ForeColor = Color.White;
            txtRazonSocial.HintForeColor = Color.White;
            txtRazonSocial.HintText = "";
            txtRazonSocial.isPassword = false;
            txtRazonSocial.LineFocusedColor = Color.Blue;
            txtRazonSocial.LineIdleColor = Color.Gray;
            txtRazonSocial.LineMouseHoverColor = Color.Blue;
            txtRazonSocial.LineThickness = 3;
            txtRazonSocial.Location = new Point(8, 129);
            txtRazonSocial.Margin = new Padding(4);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(354, 33);
            txtRazonSocial.TabIndex = 33;
            txtRazonSocial.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(366, 110);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(47, 20);
            MonoFlat_HeaderLabel4.TabIndex = 36;
            MonoFlat_HeaderLabel4.Text = "R.F.C.";
            // 
            // txtRFC
            // 
            txtRFC.Cursor = Cursors.IBeam;
            txtRFC.Font = new Font("Century Gothic", 9.75f);
            txtRFC.ForeColor = Color.White;
            txtRFC.HintForeColor = Color.White;
            txtRFC.HintText = "";
            txtRFC.isPassword = false;
            txtRFC.LineFocusedColor = Color.Blue;
            txtRFC.LineIdleColor = Color.Gray;
            txtRFC.LineMouseHoverColor = Color.Blue;
            txtRFC.LineThickness = 3;
            txtRFC.Location = new Point(370, 129);
            txtRFC.Margin = new Padding(4);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(272, 33);
            txtRFC.TabIndex = 35;
            txtRFC.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel5
            // 
            MonoFlat_HeaderLabel5.AutoSize = true;
            MonoFlat_HeaderLabel5.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel5.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel5.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel5.Location = new Point(4, 179);
            MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            MonoFlat_HeaderLabel5.Size = new Size(42, 20);
            MonoFlat_HeaderLabel5.TabIndex = 38;
            MonoFlat_HeaderLabel5.Text = "Calle";
            // 
            // txtCalle
            // 
            txtCalle.Cursor = Cursors.IBeam;
            txtCalle.Font = new Font("Century Gothic", 9.75f);
            txtCalle.ForeColor = Color.White;
            txtCalle.HintForeColor = Color.White;
            txtCalle.HintText = "";
            txtCalle.isPassword = false;
            txtCalle.LineFocusedColor = Color.Blue;
            txtCalle.LineIdleColor = Color.Gray;
            txtCalle.LineMouseHoverColor = Color.Blue;
            txtCalle.LineThickness = 3;
            txtCalle.Location = new Point(8, 198);
            txtCalle.Margin = new Padding(4);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(354, 33);
            txtCalle.TabIndex = 37;
            txtCalle.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel6
            // 
            MonoFlat_HeaderLabel6.AutoSize = true;
            MonoFlat_HeaderLabel6.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel6.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel6.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel6.Location = new Point(366, 179);
            MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6";
            MonoFlat_HeaderLabel6.Size = new Size(93, 20);
            MonoFlat_HeaderLabel6.TabIndex = 40;
            MonoFlat_HeaderLabel6.Text = "No. Exterior";
            // 
            // txtNoExterior
            // 
            txtNoExterior.Cursor = Cursors.IBeam;
            txtNoExterior.Font = new Font("Century Gothic", 9.75f);
            txtNoExterior.ForeColor = Color.White;
            txtNoExterior.HintForeColor = Color.White;
            txtNoExterior.HintText = "";
            txtNoExterior.isPassword = false;
            txtNoExterior.LineFocusedColor = Color.Blue;
            txtNoExterior.LineIdleColor = Color.Gray;
            txtNoExterior.LineMouseHoverColor = Color.Blue;
            txtNoExterior.LineThickness = 3;
            txtNoExterior.Location = new Point(370, 198);
            txtNoExterior.Margin = new Padding(4);
            txtNoExterior.Name = "txtNoExterior";
            txtNoExterior.Size = new Size(145, 33);
            txtNoExterior.TabIndex = 39;
            txtNoExterior.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel8
            // 
            MonoFlat_HeaderLabel8.AutoSize = true;
            MonoFlat_HeaderLabel8.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel8.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel8.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel8.Location = new Point(9, 244);
            MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8";
            MonoFlat_HeaderLabel8.Size = new Size(105, 20);
            MonoFlat_HeaderLabel8.TabIndex = 44;
            MonoFlat_HeaderLabel8.Text = "Código Postal";
            // 
            // txtCP
            // 
            txtCP.Cursor = Cursors.IBeam;
            txtCP.Font = new Font("Century Gothic", 9.75f);
            txtCP.ForeColor = Color.White;
            txtCP.HintForeColor = Color.White;
            txtCP.HintText = "";
            txtCP.isPassword = false;
            txtCP.LineFocusedColor = Color.Blue;
            txtCP.LineIdleColor = Color.Gray;
            txtCP.LineMouseHoverColor = Color.Blue;
            txtCP.LineThickness = 3;
            txtCP.Location = new Point(13, 263);
            txtCP.Margin = new Padding(4);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(101, 33);
            txtCP.TabIndex = 43;
            txtCP.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel9
            // 
            MonoFlat_HeaderLabel9.AutoSize = true;
            MonoFlat_HeaderLabel9.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel9.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel9.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel9.Location = new Point(157, 244);
            MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9";
            MonoFlat_HeaderLabel9.Size = new Size(61, 20);
            MonoFlat_HeaderLabel9.TabIndex = 46;
            MonoFlat_HeaderLabel9.Text = "Colonia";
            // 
            // MonoFlat_HeaderLabel10
            // 
            MonoFlat_HeaderLabel10.AutoSize = true;
            MonoFlat_HeaderLabel10.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel10.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel10.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel10.Location = new Point(9, 309);
            MonoFlat_HeaderLabel10.Name = "MonoFlat_HeaderLabel10";
            MonoFlat_HeaderLabel10.Size = new Size(57, 20);
            MonoFlat_HeaderLabel10.TabIndex = 48;
            MonoFlat_HeaderLabel10.Text = "Ciudad";
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
            txtCiudad.Location = new Point(13, 328);
            txtCiudad.Margin = new Padding(4);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(205, 33);
            txtCiudad.TabIndex = 47;
            txtCiudad.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel11
            // 
            MonoFlat_HeaderLabel11.AutoSize = true;
            MonoFlat_HeaderLabel11.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel11.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel11.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel11.Location = new Point(225, 309);
            MonoFlat_HeaderLabel11.Name = "MonoFlat_HeaderLabel11";
            MonoFlat_HeaderLabel11.Size = new Size(56, 20);
            MonoFlat_HeaderLabel11.TabIndex = 50;
            MonoFlat_HeaderLabel11.Text = "Estado";
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
            txtEstado.Location = new Point(229, 328);
            txtEstado.Margin = new Padding(4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(222, 33);
            txtEstado.TabIndex = 49;
            txtEstado.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel12
            // 
            MonoFlat_HeaderLabel12.AutoSize = true;
            MonoFlat_HeaderLabel12.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel12.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel12.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel12.Location = new Point(455, 309);
            MonoFlat_HeaderLabel12.Name = "MonoFlat_HeaderLabel12";
            MonoFlat_HeaderLabel12.Size = new Size(70, 20);
            MonoFlat_HeaderLabel12.TabIndex = 52;
            MonoFlat_HeaderLabel12.Text = "Teléfono";
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
            txtTelefono.Location = new Point(459, 328);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 33);
            txtTelefono.TabIndex = 51;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel13
            // 
            MonoFlat_HeaderLabel13.AutoSize = true;
            MonoFlat_HeaderLabel13.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel13.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel13.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel13.Location = new Point(9, 377);
            MonoFlat_HeaderLabel13.Name = "MonoFlat_HeaderLabel13";
            MonoFlat_HeaderLabel13.Size = new Size(22, 20);
            MonoFlat_HeaderLabel13.TabIndex = 54;
            MonoFlat_HeaderLabel13.Text = "ip";
            // 
            // txtIP
            // 
            txtIP.Cursor = Cursors.IBeam;
            txtIP.Font = new Font("Century Gothic", 9.75f);
            txtIP.ForeColor = Color.White;
            txtIP.HintForeColor = Color.White;
            txtIP.HintText = "";
            txtIP.isPassword = false;
            txtIP.LineFocusedColor = Color.Blue;
            txtIP.LineIdleColor = Color.Gray;
            txtIP.LineMouseHoverColor = Color.Blue;
            txtIP.LineThickness = 3;
            txtIP.Location = new Point(13, 396);
            txtIP.Margin = new Padding(4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(155, 33);
            txtIP.TabIndex = 53;
            txtIP.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel14
            // 
            MonoFlat_HeaderLabel14.AutoSize = true;
            MonoFlat_HeaderLabel14.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel14.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel14.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel14.Location = new Point(184, 377);
            MonoFlat_HeaderLabel14.Name = "MonoFlat_HeaderLabel14";
            MonoFlat_HeaderLabel14.Size = new Size(106, 20);
            MonoFlat_HeaderLabel14.TabIndex = 56;
            MonoFlat_HeaderLabel14.Text = "Base de datos";
            // 
            // txtBD
            // 
            txtBD.Cursor = Cursors.IBeam;
            txtBD.Font = new Font("Century Gothic", 9.75f);
            txtBD.ForeColor = Color.White;
            txtBD.HintForeColor = Color.White;
            txtBD.HintText = "";
            txtBD.isPassword = false;
            txtBD.LineFocusedColor = Color.Blue;
            txtBD.LineIdleColor = Color.Gray;
            txtBD.LineMouseHoverColor = Color.Blue;
            txtBD.LineThickness = 3;
            txtBD.Location = new Point(188, 396);
            txtBD.Margin = new Padding(4);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(155, 33);
            txtBD.TabIndex = 55;
            txtBD.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel15
            // 
            MonoFlat_HeaderLabel15.AutoSize = true;
            MonoFlat_HeaderLabel15.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel15.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel15.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel15.Location = new Point(366, 377);
            MonoFlat_HeaderLabel15.Name = "MonoFlat_HeaderLabel15";
            MonoFlat_HeaderLabel15.Size = new Size(55, 20);
            MonoFlat_HeaderLabel15.TabIndex = 58;
            MonoFlat_HeaderLabel15.Text = "Prefijo";
            // 
            // txtPrefijo
            // 
            txtPrefijo.Cursor = Cursors.IBeam;
            txtPrefijo.Font = new Font("Century Gothic", 9.75f);
            txtPrefijo.ForeColor = Color.White;
            txtPrefijo.HintForeColor = Color.White;
            txtPrefijo.HintText = "";
            txtPrefijo.isPassword = false;
            txtPrefijo.LineFocusedColor = Color.Blue;
            txtPrefijo.LineIdleColor = Color.Gray;
            txtPrefijo.LineMouseHoverColor = Color.Blue;
            txtPrefijo.LineThickness = 3;
            txtPrefijo.Location = new Point(370, 396);
            txtPrefijo.Margin = new Padding(4);
            txtPrefijo.Name = "txtPrefijo";
            txtPrefijo.Size = new Size(155, 33);
            txtPrefijo.TabIndex = 57;
            txtPrefijo.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel16
            // 
            MonoFlat_HeaderLabel16.AutoSize = true;
            MonoFlat_HeaderLabel16.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel16.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel16.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel16.Location = new Point(9, 443);
            MonoFlat_HeaderLabel16.Name = "MonoFlat_HeaderLabel16";
            MonoFlat_HeaderLabel16.Size = new Size(56, 20);
            MonoFlat_HeaderLabel16.TabIndex = 60;
            MonoFlat_HeaderLabel16.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Century Gothic", 9.75f);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.HintForeColor = Color.White;
            txtCorreo.HintText = "";
            txtCorreo.isPassword = false;
            txtCorreo.LineFocusedColor = Color.Blue;
            txtCorreo.LineIdleColor = Color.Gray;
            txtCorreo.LineMouseHoverColor = Color.Blue;
            txtCorreo.LineThickness = 3;
            txtCorreo.Location = new Point(13, 462);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(345, 33);
            txtCorreo.TabIndex = 59;
            txtCorreo.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_HeaderLabel17
            // 
            MonoFlat_HeaderLabel17.AutoSize = true;
            MonoFlat_HeaderLabel17.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel17.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel17.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel17.Location = new Point(365, 443);
            MonoFlat_HeaderLabel17.Name = "MonoFlat_HeaderLabel17";
            MonoFlat_HeaderLabel17.Size = new Size(88, 20);
            MonoFlat_HeaderLabel17.TabIndex = 62;
            MonoFlat_HeaderLabel17.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Century Gothic", 9.75f);
            txtPassword.ForeColor = Color.White;
            txtPassword.HintForeColor = Color.White;
            txtPassword.HintText = "";
            txtPassword.isPassword = false;
            txtPassword.LineFocusedColor = Color.Blue;
            txtPassword.LineIdleColor = Color.Gray;
            txtPassword.LineMouseHoverColor = Color.Blue;
            txtPassword.LineThickness = 3;
            txtPassword.Location = new Point(369, 462);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 33);
            txtPassword.TabIndex = 61;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            // 
            // BackgroundInformacionEmpresa
            // 
            // 
            // txtColonia
            // 
            txtColonia.Cursor = Cursors.IBeam;
            txtColonia.Font = new Font("Century Gothic", 9.75f);
            txtColonia.ForeColor = Color.White;
            txtColonia.HintForeColor = Color.White;
            txtColonia.HintText = "";
            txtColonia.isPassword = false;
            txtColonia.LineFocusedColor = Color.Blue;
            txtColonia.LineIdleColor = Color.Gray;
            txtColonia.LineMouseHoverColor = Color.Blue;
            txtColonia.LineThickness = 3;
            txtColonia.Location = new Point(161, 263);
            txtColonia.Margin = new Padding(4);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(275, 33);
            txtColonia.TabIndex = 63;
            txtColonia.TextAlign = HorizontalAlignment.Left;
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
            BunifuThinButton21.Location = new Point(284, 528);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 64;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundActualizar
            // 
            // 
            // ModificarEmpresa
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(649, 573);
            Controls.Add(BunifuThinButton21);
            Controls.Add(txtColonia);
            Controls.Add(MonoFlat_HeaderLabel17);
            Controls.Add(txtPassword);
            Controls.Add(MonoFlat_HeaderLabel16);
            Controls.Add(txtCorreo);
            Controls.Add(MonoFlat_HeaderLabel15);
            Controls.Add(txtPrefijo);
            Controls.Add(MonoFlat_HeaderLabel14);
            Controls.Add(txtBD);
            Controls.Add(MonoFlat_HeaderLabel13);
            Controls.Add(txtIP);
            Controls.Add(MonoFlat_HeaderLabel12);
            Controls.Add(txtTelefono);
            Controls.Add(MonoFlat_HeaderLabel11);
            Controls.Add(txtEstado);
            Controls.Add(MonoFlat_HeaderLabel10);
            Controls.Add(txtCiudad);
            Controls.Add(MonoFlat_HeaderLabel9);
            Controls.Add(MonoFlat_HeaderLabel8);
            Controls.Add(txtCP);
            Controls.Add(MonoFlat_HeaderLabel6);
            Controls.Add(txtNoExterior);
            Controls.Add(MonoFlat_HeaderLabel5);
            Controls.Add(txtCalle);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(txtRFC);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(txtRazonSocial);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(txtNombre);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarEmpresa";
            Text = "ModificarEmpresa";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(ModificarEmpresa_Load);
            FormClosed += new FormClosedEventHandler(ModificarEmpresa_FormClosed);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtRazonSocial;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtRFC;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCalle;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNoExterior;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel8;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCP;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel9;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel10;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel11;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel12;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel13;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIP;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel14;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtBD;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel15;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPrefijo;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel16;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel17;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        internal System.ComponentModel.BackgroundWorker BackgroundInformacionEmpresa;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtColonia;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizar;
    }
}