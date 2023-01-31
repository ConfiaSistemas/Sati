using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CaputarMotocicleta : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CaputarMotocicleta));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            EvolveControlBox1 = new EvolveControlBox();
            TabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            TabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            txtValor = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            txtAño = new VB.Windows.Forms.ControlExt.TextBoxEx();
            Label1 = new Label();
            txtNoFactura = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtMarca = new VB.Windows.Forms.ControlExt.TextBoxEx();
            Label11 = new Label();
            txtModelo = new VB.Windows.Forms.ControlExt.TextBoxEx();
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            txtCilindraje = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtNoPedimento = new VB.Windows.Forms.ControlExt.TextBoxEx();
            Label15 = new Label();
            Label16 = new Label();
            txtColor = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtNoMotor = new VB.Windows.Forms.ControlExt.TextBoxEx();
            Label17 = new Label();
            Label18 = new Label();
            Label19 = new Label();
            txtNCI = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtSerie = new VB.Windows.Forms.ControlExt.TextBoxEx();
            Label20 = new Label();
            TabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            TabControl2 = new TabControl();
            TabPage6 = new TabPage();
            dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            TabPage7 = new TabPage();
            dtdatosDocumentosNuevos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            idTipoDocumento = new DataGridViewTextBoxColumn();
            NombreDocumento = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            BackgroundMotocicleta = new System.ComponentModel.BackgroundWorker();
            BackgroundMotocicleta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundMotocicleta_DoWork);
            BackgroundMotocicleta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundMotocicleta_RunWorkerCompleted);
            BackgroundDocumentosMotocicleta = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentosMotocicleta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentosMotocicleta_DoWork);
            BackgroundDocumentosMotocicleta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentosMotocicleta_RunWorkerCompleted);
            BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentos_DoWork);
            BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentos_RunWorkerCompleted);
            BackgroundActualizarDatos = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizarDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizarDatos_DoWork);
            BackgroundActualizarDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizarDatos_RunWorkerCompleted);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabControlAdv1).BeginInit();
            TabControlAdv1.SuspendLayout();
            TabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            TabPageAdv2.SuspendLayout();
            TabControl2.SuspendLayout();
            TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).BeginInit();
            TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentosNuevos).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(1, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(735, 40);
            Panel1.TabIndex = 3;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 4);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(156, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Capturar Motocicleta";
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(666, 4);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 0;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // TabControlAdv1
            // 
            TabControlAdv1.BeforeTouchSize = new Size(735, 419);
            TabControlAdv1.Controls.Add(TabPageAdv1);
            TabControlAdv1.Controls.Add(TabPageAdv2);
            TabControlAdv1.Location = new Point(1, 47);
            TabControlAdv1.Name = "TabControlAdv1";
            TabControlAdv1.Size = new Size(735, 419);
            TabControlAdv1.TabIndex = 31;
            // 
            // TabPageAdv1
            // 
            TabPageAdv1.Controls.Add(txtValor);
            TabPageAdv1.Controls.Add(txtAño);
            TabPageAdv1.Controls.Add(Label1);
            TabPageAdv1.Controls.Add(txtNoFactura);
            TabPageAdv1.Controls.Add(txtMarca);
            TabPageAdv1.Controls.Add(Label11);
            TabPageAdv1.Controls.Add(txtModelo);
            TabPageAdv1.Controls.Add(Label12);
            TabPageAdv1.Controls.Add(Label13);
            TabPageAdv1.Controls.Add(Label14);
            TabPageAdv1.Controls.Add(txtCilindraje);
            TabPageAdv1.Controls.Add(txtNoPedimento);
            TabPageAdv1.Controls.Add(Label15);
            TabPageAdv1.Controls.Add(Label16);
            TabPageAdv1.Controls.Add(txtColor);
            TabPageAdv1.Controls.Add(txtNoMotor);
            TabPageAdv1.Controls.Add(Label17);
            TabPageAdv1.Controls.Add(Label18);
            TabPageAdv1.Controls.Add(Label19);
            TabPageAdv1.Controls.Add(txtNCI);
            TabPageAdv1.Controls.Add(txtSerie);
            TabPageAdv1.Controls.Add(Label20);
            TabPageAdv1.Image = null;
            TabPageAdv1.ImageSize = new Size(16, 16);
            TabPageAdv1.Location = new Point(1, 25);
            TabPageAdv1.Name = "TabPageAdv1";
            TabPageAdv1.ShowCloseButton = false;
            TabPageAdv1.Size = new Size(732, 392);
            TabPageAdv1.TabForeColor = SystemColors.Control;
            TabPageAdv1.TabIndex = 1;
            TabPageAdv1.Text = "Datos";
            TabPageAdv1.ThemesEnabled = false;
            // 
            // txtValor
            // 
            txtValor.DecimalValue = new decimal(new int[] { 0, 0, 0, 131072 });
            txtValor.Location = new Point(238, 253);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 20);
            txtValor.TabIndex = 54;
            txtValor.Text = "$0.00";
            // 
            // txtAño
            // 
            txtAño.BackColor = Color.FromArgb(0, 5, 11);
            txtAño.BorderColor = Color.Gray;
            txtAño.ForeColor = Color.White;
            txtAño.Location = new Point(238, 113);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(178, 20);
            txtAño.TabIndex = 53;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(7, 225);
            Label1.Name = "Label1";
            Label1.Size = new Size(98, 13);
            Label1.TabIndex = 52;
            Label1.Text = "Número de Factura";
            // 
            // txtNoFactura
            // 
            txtNoFactura.BackColor = Color.FromArgb(0, 5, 11);
            txtNoFactura.BorderColor = Color.Gray;
            txtNoFactura.ForeColor = Color.White;
            txtNoFactura.Location = new Point(10, 253);
            txtNoFactura.Name = "txtNoFactura";
            txtNoFactura.Size = new Size(178, 20);
            txtNoFactura.TabIndex = 51;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(0, 5, 11);
            txtMarca.BorderColor = Color.Gray;
            txtMarca.ForeColor = Color.White;
            txtMarca.Location = new Point(10, 46);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(178, 20);
            txtMarca.TabIndex = 31;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(7, 18);
            Label11.Name = "Label11";
            Label11.Size = new Size(37, 13);
            Label11.TabIndex = 32;
            Label11.Text = "Marca";
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(0, 5, 11);
            txtModelo.BorderColor = Color.Gray;
            txtModelo.ForeColor = Color.White;
            txtModelo.Location = new Point(238, 46);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(178, 20);
            txtModelo.TabIndex = 33;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.ForeColor = Color.White;
            Label12.Location = new Point(235, 227);
            Label12.Name = "Label12";
            Label12.Size = new Size(31, 13);
            Label12.TabIndex = 48;
            Label12.Text = "Valor";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.ForeColor = Color.White;
            Label13.Location = new Point(235, 18);
            Label13.Name = "Label13";
            Label13.Size = new Size(42, 13);
            Label13.TabIndex = 34;
            Label13.Text = "Modelo";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.ForeColor = Color.White;
            Label14.Location = new Point(461, 153);
            Label14.Name = "Label14";
            Label14.Size = new Size(111, 13);
            Label14.TabIndex = 47;
            Label14.Text = "Número de pedimento";
            // 
            // txtCilindraje
            // 
            txtCilindraje.BackColor = Color.FromArgb(0, 5, 11);
            txtCilindraje.BorderColor = Color.Gray;
            txtCilindraje.ForeColor = Color.White;
            txtCilindraje.Location = new Point(464, 46);
            txtCilindraje.Name = "txtCilindraje";
            txtCilindraje.Size = new Size(178, 20);
            txtCilindraje.TabIndex = 35;
            // 
            // txtNoPedimento
            // 
            txtNoPedimento.BackColor = Color.FromArgb(0, 5, 11);
            txtNoPedimento.BorderColor = Color.Gray;
            txtNoPedimento.ForeColor = Color.White;
            txtNoPedimento.Location = new Point(464, 181);
            txtNoPedimento.Name = "txtNoPedimento";
            txtNoPedimento.Size = new Size(178, 20);
            txtNoPedimento.TabIndex = 46;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.ForeColor = Color.White;
            Label15.Location = new Point(461, 18);
            Label15.Name = "Label15";
            Label15.Size = new Size(49, 13);
            Label15.TabIndex = 36;
            Label15.Text = "Cilindraje";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.ForeColor = Color.White;
            Label16.Location = new Point(235, 153);
            Label16.Name = "Label16";
            Label16.Size = new Size(88, 13);
            Label16.TabIndex = 45;
            Label16.Text = "Número de motor";
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.FromArgb(0, 5, 11);
            txtColor.BorderColor = Color.Gray;
            txtColor.ForeColor = Color.White;
            txtColor.Location = new Point(10, 113);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(178, 20);
            txtColor.TabIndex = 37;
            // 
            // txtNoMotor
            // 
            txtNoMotor.BackColor = Color.FromArgb(0, 5, 11);
            txtNoMotor.BorderColor = Color.Gray;
            txtNoMotor.ForeColor = Color.White;
            txtNoMotor.Location = new Point(238, 181);
            txtNoMotor.Name = "txtNoMotor";
            txtNoMotor.Size = new Size(178, 20);
            txtNoMotor.TabIndex = 44;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.ForeColor = Color.White;
            Label17.Location = new Point(7, 85);
            Label17.Name = "Label17";
            Label17.Size = new Size(31, 13);
            Label17.TabIndex = 38;
            Label17.Text = "Color";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.ForeColor = Color.White;
            Label18.Location = new Point(7, 153);
            Label18.Name = "Label18";
            Label18.Size = new Size(78, 13);
            Label18.TabIndex = 43;
            Label18.Text = "NCI (REPUVE)";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.ForeColor = Color.White;
            Label19.Location = new Point(235, 85);
            Label19.Name = "Label19";
            Label19.Size = new Size(26, 13);
            Label19.TabIndex = 39;
            Label19.Text = "Año";
            // 
            // txtNCI
            // 
            txtNCI.BackColor = Color.FromArgb(0, 5, 11);
            txtNCI.BorderColor = Color.Gray;
            txtNCI.ForeColor = Color.White;
            txtNCI.Location = new Point(10, 181);
            txtNCI.Name = "txtNCI";
            txtNCI.Size = new Size(178, 20);
            txtNCI.TabIndex = 42;
            // 
            // txtSerie
            // 
            txtSerie.BackColor = Color.FromArgb(0, 5, 11);
            txtSerie.BorderColor = Color.Gray;
            txtSerie.ForeColor = Color.White;
            txtSerie.Location = new Point(464, 113);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(178, 20);
            txtSerie.TabIndex = 40;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.ForeColor = Color.White;
            Label20.Location = new Point(461, 85);
            Label20.Name = "Label20";
            Label20.Size = new Size(31, 13);
            Label20.TabIndex = 41;
            Label20.Text = "Serie";
            // 
            // TabPageAdv2
            // 
            TabPageAdv2.Controls.Add(btn_Procesar);
            TabPageAdv2.Controls.Add(btn_agregar);
            TabPageAdv2.Controls.Add(TabControl2);
            TabPageAdv2.Image = null;
            TabPageAdv2.ImageSize = new Size(16, 16);
            TabPageAdv2.Location = new Point(1, 25);
            TabPageAdv2.Name = "TabPageAdv2";
            TabPageAdv2.ShowCloseButton = true;
            TabPageAdv2.Size = new Size(732, 392);
            TabPageAdv2.TabForeColor = SystemColors.Control;
            TabPageAdv2.TabIndex = 2;
            TabPageAdv2.Text = "Documentos";
            TabPageAdv2.ThemesEnabled = false;
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
            btn_Procesar.Location = new Point(246, 264);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 158;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(18, 4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(27, 21);
            btn_agregar.TabIndex = 157;
            btn_agregar.Text = "+";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // TabControl2
            // 
            TabControl2.Controls.Add(TabPage6);
            TabControl2.Controls.Add(TabPage7);
            TabControl2.Location = new Point(8, 31);
            TabControl2.Name = "TabControl2";
            TabControl2.SelectedIndex = 0;
            TabControl2.Size = new Size(719, 204);
            TabControl2.TabIndex = 156;
            // 
            // TabPage6
            // 
            TabPage6.Controls.Add(dtdatosDocumentos);
            TabPage6.Location = new Point(4, 22);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(711, 178);
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
            dtdatosDocumentos.Location = new Point(6, 6);
            dtdatosDocumentos.Name = "dtdatosDocumentos";
            dtdatosDocumentos.ReadOnly = true;
            dtdatosDocumentos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatosDocumentos.RowHeadersVisible = false;
            dtdatosDocumentos.Size = new Size(699, 166);
            dtdatosDocumentos.TabIndex = 26;
            // 
            // TabPage7
            // 
            TabPage7.Controls.Add(dtdatosDocumentosNuevos);
            TabPage7.Location = new Point(4, 22);
            TabPage7.Name = "TabPage7";
            TabPage7.Padding = new Padding(3);
            TabPage7.Size = new Size(711, 178);
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
            dtdatosDocumentosNuevos.Size = new Size(699, 166);
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
            // BackgroundMotocicleta
            // 
            // 
            // BackgroundDocumentosMotocicleta
            // 
            // 
            // BackgroundDocumentos
            // 
            // 
            // BackgroundActualizarDatos
            // 
            // 
            // CaputarMotocicleta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(737, 467);
            Controls.Add(TabControlAdv1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CaputarMotocicleta";
            Text = "Capturar Motocicleta";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabControlAdv1).EndInit();
            TabControlAdv1.ResumeLayout(false);
            TabPageAdv1.ResumeLayout(false);
            TabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit();
            TabPageAdv2.ResumeLayout(false);
            TabControl2.ResumeLayout(false);
            TabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).EndInit();
            TabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentosNuevos).EndInit();
            Load += new EventHandler(CaputarMotocicleta_Load);
            ResumeLayout(false);

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        internal Syncfusion.Windows.Forms.Tools.TabControlAdv TabControlAdv1;
        internal Syncfusion.Windows.Forms.Tools.TabPageAdv TabPageAdv1;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtMarca;
        internal Label Label11;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtModelo;
        internal Label Label12;
        internal Label Label13;
        internal Label Label14;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtCilindraje;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtNoPedimento;
        internal Label Label15;
        internal Label Label16;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtColor;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtNoMotor;
        internal Label Label17;
        internal Label Label18;
        internal Label Label19;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtNCI;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtSerie;
        internal Label Label20;
        internal Syncfusion.Windows.Forms.Tools.TabPageAdv TabPageAdv2;
        internal Label Label1;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtNoFactura;
        internal System.ComponentModel.BackgroundWorker BackgroundMotocicleta;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentosMotocicleta;
        internal TabControl TabControl2;
        internal TabPage TabPage6;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentos;
        internal TabPage TabPage7;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentosNuevos;
        internal DataGridViewTextBoxColumn idTipoDocumento;
        internal DataGridViewTextBoxColumn NombreDocumento;
        internal DataGridViewImageColumn Imagen;
        internal Button btn_agregar;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizarDatos;
        internal Syncfusion.Windows.Forms.Tools.CurrencyTextBox txtValor;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtAño;
    }
}