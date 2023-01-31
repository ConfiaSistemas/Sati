using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Levantar_Solicitud : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Levantar_Solicitud));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtNombreSolicitud = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtplazo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtInteres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ComboGestor = new System.Windows.Forms.ComboBox();
            this.ComboPromotor = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label7 = new System.Windows.Forms.Label();
            this.dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MonoFlat_Separator1 = new ConfiaAdmin.MonoFlat.MonoFlat_Separator();
            this.txtIntegrantes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.BackgroundGestores = new System.ComponentModel.BackgroundWorker();
            this.BackgroundPromotores = new System.ComponentModel.BackgroundWorker();
            this.txtResponsable = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label9 = new System.Windows.Forms.Label();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMontopPersona = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtMoratorios = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMoratorios = new System.Windows.Forms.Label();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CheckNombre = new ConfiaAdmin.MonoFlat.MonoFlat_CheckBox();
            this.lblGestorLegal = new System.Windows.Forms.Label();
            this.ComboLegal = new System.Windows.Forms.ComboBox();
            this.BackgroundLegal = new System.ComponentModel.BackgroundWorker();
            this.BackgroundSolicitudLegal = new System.ComponentModel.BackgroundWorker();
            this.txtTotalMoratorios = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTotalMoratorios = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(1, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1062, 36);
            this.Panel1.TabIndex = 2;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(993, 3);
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
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(134, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Levantar Solicitud";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(31, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Tipo Prestamo";
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTipo.ForeColor = System.Drawing.Color.White;
            this.txtTipo.HintForeColor = System.Drawing.Color.White;
            this.txtTipo.HintText = "";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTipo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTipo.LineThickness = 3;
            this.txtTipo.Location = new System.Drawing.Point(34, 70);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(58, 25);
            this.txtTipo.TabIndex = 0;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipo.OnValueChanged += new System.EventHandler(this.txtTipo_OnValueChanged);
            this.txtTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipo_KeyDown);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(31, 108);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(13, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "..";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(99, 74);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(27, 21);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "F2";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtNombreSolicitud
            // 
            this.txtNombreSolicitud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreSolicitud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreSolicitud.ForeColor = System.Drawing.Color.White;
            this.txtNombreSolicitud.HintForeColor = System.Drawing.Color.White;
            this.txtNombreSolicitud.HintText = "";
            this.txtNombreSolicitud.isPassword = false;
            this.txtNombreSolicitud.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombreSolicitud.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreSolicitud.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombreSolicitud.LineThickness = 3;
            this.txtNombreSolicitud.Location = new System.Drawing.Point(21, 307);
            this.txtNombreSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreSolicitud.Name = "txtNombreSolicitud";
            this.txtNombreSolicitud.Size = new System.Drawing.Size(226, 25);
            this.txtNombreSolicitud.TabIndex = 6;
            this.txtNombreSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(18, 290);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Nombre";
            // 
            // txtplazo
            // 
            this.txtplazo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtplazo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtplazo.ForeColor = System.Drawing.Color.White;
            this.txtplazo.HintForeColor = System.Drawing.Color.White;
            this.txtplazo.HintText = "";
            this.txtplazo.isPassword = false;
            this.txtplazo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtplazo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtplazo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtplazo.LineThickness = 3;
            this.txtplazo.Location = new System.Drawing.Point(415, 307);
            this.txtplazo.Margin = new System.Windows.Forms.Padding(4);
            this.txtplazo.Name = "txtplazo";
            this.txtplazo.Size = new System.Drawing.Size(85, 25);
            this.txtplazo.TabIndex = 8;
            this.txtplazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(412, 290);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 13);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Plazo";
            // 
            // txtInteres
            // 
            this.txtInteres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInteres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtInteres.ForeColor = System.Drawing.Color.White;
            this.txtInteres.HintForeColor = System.Drawing.Color.White;
            this.txtInteres.HintText = "";
            this.txtInteres.isPassword = false;
            this.txtInteres.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtInteres.LineIdleColor = System.Drawing.Color.Gray;
            this.txtInteres.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtInteres.LineThickness = 3;
            this.txtInteres.Location = new System.Drawing.Point(538, 307);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(93, 25);
            this.txtInteres.TabIndex = 9;
            this.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(535, 290);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(39, 13);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "Interés";
            // 
            // ComboGestor
            // 
            this.ComboGestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGestor.FormattingEnabled = true;
            this.ComboGestor.Location = new System.Drawing.Point(89, 404);
            this.ComboGestor.Name = "ComboGestor";
            this.ComboGestor.Size = new System.Drawing.Size(240, 21);
            this.ComboGestor.TabIndex = 11;
            // 
            // ComboPromotor
            // 
            this.ComboPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPromotor.FormattingEnabled = true;
            this.ComboPromotor.ItemHeight = 13;
            this.ComboPromotor.Location = new System.Drawing.Point(380, 404);
            this.ComboPromotor.Name = "ComboPromotor";
            this.ComboPromotor.Size = new System.Drawing.Size(239, 21);
            this.ComboPromotor.TabIndex = 12;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(218, 74);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(27, 21);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "F2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(150, 108);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(13, 13);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "..";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdCliente.ForeColor = System.Drawing.Color.White;
            this.txtIdCliente.HintForeColor = System.Drawing.Color.White;
            this.txtIdCliente.HintText = "";
            this.txtIdCliente.isPassword = false;
            this.txtIdCliente.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIdCliente.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdCliente.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIdCliente.LineThickness = 3;
            this.txtIdCliente.Location = new System.Drawing.Point(153, 70);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(58, 25);
            this.txtIdCliente.TabIndex = 2;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdCliente.OnValueChanged += new System.EventHandler(this.txtIdCliente_OnValueChanged);
            this.txtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdCliente_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(150, 53);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 13);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Cliente";
            // 
            // dtdatos
            // 
            this.dtdatos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtdatos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Monto});
            this.dtdatos.DoubleBuffered = true;
            this.dtdatos.EnableHeadersVisualStyles = false;
            this.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatos.Location = new System.Drawing.Point(514, 45);
            this.dtdatos.Name = "dtdatos";
            this.dtdatos.ReadOnly = true;
            this.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatos.RowHeadersVisible = false;
            this.dtdatos.Size = new System.Drawing.Size(542, 183);
            this.dtdatos.TabIndex = 24;
            this.dtdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellContentClick);
            this.dtdatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellDoubleClick);
            this.dtdatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtdatos_KeyDown);
            // 
            // MonoFlat_Separator1
            // 
            this.MonoFlat_Separator1.Location = new System.Drawing.Point(1, 257);
            this.MonoFlat_Separator1.Name = "MonoFlat_Separator1";
            this.MonoFlat_Separator1.Size = new System.Drawing.Size(1062, 12);
            this.MonoFlat_Separator1.TabIndex = 25;
            this.MonoFlat_Separator1.Text = "MonoFlat_Separator1";
            // 
            // txtIntegrantes
            // 
            this.txtIntegrantes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIntegrantes.Enabled = false;
            this.txtIntegrantes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntegrantes.ForeColor = System.Drawing.Color.White;
            this.txtIntegrantes.HintForeColor = System.Drawing.Color.White;
            this.txtIntegrantes.HintText = "";
            this.txtIntegrantes.isPassword = false;
            this.txtIntegrantes.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIntegrantes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIntegrantes.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIntegrantes.LineThickness = 3;
            this.txtIntegrantes.Location = new System.Drawing.Point(658, 307);
            this.txtIntegrantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntegrantes.Name = "txtIntegrantes";
            this.txtIntegrantes.Size = new System.Drawing.Size(58, 25);
            this.txtIntegrantes.TabIndex = 9;
            this.txtIntegrantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(655, 290);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Integrantes";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(86, 374);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 13);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "Gestor";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(377, 374);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 13);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Promotor";
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
            this.btn_Procesar.ButtonText = "Ingresar e iniciar proceso";
            this.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Procesar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Procesar.IdleBorderThickness = 1;
            this.btn_Procesar.IdleCornerRadius = 20;
            this.btn_Procesar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_Procesar.Location = new System.Drawing.Point(358, 451);
            this.btn_Procesar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(216, 38);
            this.btn_Procesar.TabIndex = 13;
            this.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(339, 74);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(87, 21);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar Cliente";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Visible = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_ClickAsync);
            // 
            // BackgroundGestores
            // 
            this.BackgroundGestores.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundGestores_DoWork);
            this.BackgroundGestores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundGestores_RunWorkerCompleted);
            // 
            // BackgroundPromotores
            // 
            this.BackgroundPromotores.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundPromotores_DoWork);
            this.BackgroundPromotores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundPromotores_RunWorkerCompleted);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResponsable.Enabled = false;
            this.txtResponsable.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtResponsable.ForeColor = System.Drawing.Color.White;
            this.txtResponsable.HintForeColor = System.Drawing.Color.White;
            this.txtResponsable.HintText = "";
            this.txtResponsable.isPassword = false;
            this.txtResponsable.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtResponsable.LineIdleColor = System.Drawing.Color.Gray;
            this.txtResponsable.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtResponsable.LineThickness = 3;
            this.txtResponsable.Location = new System.Drawing.Point(745, 307);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(58, 25);
            this.txtResponsable.TabIndex = 10;
            this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(742, 290);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(69, 13);
            this.Label9.TabIndex = 32;
            this.Label9.Text = "Responsable";
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // txtMontopPersona
            // 
            this.txtMontopPersona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontopPersona.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontopPersona.ForeColor = System.Drawing.Color.White;
            this.txtMontopPersona.HintForeColor = System.Drawing.Color.White;
            this.txtMontopPersona.HintText = "";
            this.txtMontopPersona.isPassword = false;
            this.txtMontopPersona.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMontopPersona.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMontopPersona.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMontopPersona.LineThickness = 3;
            this.txtMontopPersona.Location = new System.Drawing.Point(274, 70);
            this.txtMontopPersona.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontopPersona.Name = "txtMontopPersona";
            this.txtMontopPersona.Size = new System.Drawing.Size(58, 25);
            this.txtMontopPersona.TabIndex = 4;
            this.txtMontopPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(271, 53);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(37, 13);
            this.Label10.TabIndex = 34;
            this.Label10.Text = "Monto";
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
            this.txtMontoTotal.Location = new System.Drawing.Point(290, 307);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(101, 25);
            this.txtMontoTotal.TabIndex = 7;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(287, 290);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(37, 13);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "Monto";
            // 
            // txtMoratorios
            // 
            this.txtMoratorios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoratorios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMoratorios.ForeColor = System.Drawing.Color.White;
            this.txtMoratorios.HintForeColor = System.Drawing.Color.White;
            this.txtMoratorios.HintText = "";
            this.txtMoratorios.isPassword = false;
            this.txtMoratorios.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMoratorios.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMoratorios.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMoratorios.LineThickness = 3;
            this.txtMoratorios.Location = new System.Drawing.Point(340, 123);
            this.txtMoratorios.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoratorios.Name = "txtMoratorios";
            this.txtMoratorios.Size = new System.Drawing.Size(58, 25);
            this.txtMoratorios.TabIndex = 37;
            this.txtMoratorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMoratorios.Visible = false;
            // 
            // lblMoratorios
            // 
            this.lblMoratorios.AutoSize = true;
            this.lblMoratorios.ForeColor = System.Drawing.Color.White;
            this.lblMoratorios.Location = new System.Drawing.Point(337, 106);
            this.lblMoratorios.Name = "lblMoratorios";
            this.lblMoratorios.Size = new System.Drawing.Size(56, 13);
            this.lblMoratorios.TabIndex = 38;
            this.lblMoratorios.Text = "Moratorios";
            this.lblMoratorios.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.HintForeColor = System.Drawing.Color.White;
            this.txtTotal.HintText = "";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotal.LineThickness = 3;
            this.txtTotal.Location = new System.Drawing.Point(920, 307);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(114, 25);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(917, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 13);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Deuda Total";
            this.lblTotal.Visible = false;
            // 
            // CheckNombre
            // 
            this.CheckNombre.Checked = false;
            this.CheckNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CheckNombre.Location = new System.Drawing.Point(340, 166);
            this.CheckNombre.Name = "CheckNombre";
            this.CheckNombre.Size = new System.Drawing.Size(160, 16);
            this.CheckNombre.TabIndex = 41;
            this.CheckNombre.Text = "Usar Nombre de Cliente";
            this.CheckNombre.Visible = false;
            this.CheckNombre.CheckedChanged += new ConfiaAdmin.MonoFlat.MonoFlat_CheckBox.CheckedChangedEventHandler(this.CheckNombre_CheckedChanged);
            // 
            // lblGestorLegal
            // 
            this.lblGestorLegal.AutoSize = true;
            this.lblGestorLegal.ForeColor = System.Drawing.Color.White;
            this.lblGestorLegal.Location = new System.Drawing.Point(655, 374);
            this.lblGestorLegal.Name = "lblGestorLegal";
            this.lblGestorLegal.Size = new System.Drawing.Size(67, 13);
            this.lblGestorLegal.TabIndex = 43;
            this.lblGestorLegal.Text = "Gestor Legal";
            this.lblGestorLegal.Visible = false;
            // 
            // ComboLegal
            // 
            this.ComboLegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLegal.FormattingEnabled = true;
            this.ComboLegal.ItemHeight = 13;
            this.ComboLegal.Location = new System.Drawing.Point(658, 404);
            this.ComboLegal.Name = "ComboLegal";
            this.ComboLegal.Size = new System.Drawing.Size(239, 21);
            this.ComboLegal.TabIndex = 42;
            this.ComboLegal.Visible = false;
            this.ComboLegal.SelectedIndexChanged += new System.EventHandler(this.ComboLegal_SelectedIndexChanged);
            // 
            // BackgroundLegal
            // 
            this.BackgroundLegal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundLegal_DoWork);
            this.BackgroundLegal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundLegal_RunWorkerCompleted);
            // 
            // BackgroundSolicitudLegal
            // 
            this.BackgroundSolicitudLegal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSolicitudLegal_DoWork);
            this.BackgroundSolicitudLegal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundSolicitudLegal_RunWorkerCompleted);
            // 
            // txtTotalMoratorios
            // 
            this.txtTotalMoratorios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalMoratorios.Enabled = false;
            this.txtTotalMoratorios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTotalMoratorios.ForeColor = System.Drawing.Color.White;
            this.txtTotalMoratorios.HintForeColor = System.Drawing.Color.White;
            this.txtTotalMoratorios.HintText = "";
            this.txtTotalMoratorios.isPassword = false;
            this.txtTotalMoratorios.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTotalMoratorios.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTotalMoratorios.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotalMoratorios.LineThickness = 3;
            this.txtTotalMoratorios.Location = new System.Drawing.Point(827, 307);
            this.txtTotalMoratorios.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalMoratorios.Name = "txtTotalMoratorios";
            this.txtTotalMoratorios.Size = new System.Drawing.Size(80, 25);
            this.txtTotalMoratorios.TabIndex = 44;
            this.txtTotalMoratorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalMoratorios.Visible = false;
            // 
            // lblTotalMoratorios
            // 
            this.lblTotalMoratorios.AutoSize = true;
            this.lblTotalMoratorios.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoratorios.Location = new System.Drawing.Point(824, 290);
            this.lblTotalMoratorios.Name = "lblTotalMoratorios";
            this.lblTotalMoratorios.Size = new System.Drawing.Size(83, 13);
            this.lblTotalMoratorios.TabIndex = 45;
            this.lblTotalMoratorios.Text = "Total Moratorios";
            this.lblTotalMoratorios.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Cliente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 74;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 79;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 70;
            // 
            // Levantar_Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1065, 503);
            this.Controls.Add(this.txtTotalMoratorios);
            this.Controls.Add(this.lblTotalMoratorios);
            this.Controls.Add(this.lblGestorLegal);
            this.Controls.Add(this.ComboLegal);
            this.Controls.Add(this.CheckNombre);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtMoratorios);
            this.Controls.Add(this.lblMoratorios);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtMontopPersona);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_Procesar);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtIntegrantes);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.MonoFlat_Separator1);
            this.Controls.Add(this.dtdatos);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.ComboPromotor);
            this.Controls.Add(this.ComboGestor);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtplazo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtNombreSolicitud);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Levantar_Solicitud";
            this.Text = "Levantar_Solicitud";
            this.Load += new System.EventHandler(this.Levantar_Solicitud_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Label Label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        internal Label lblTipo;
        internal Button Button1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreSolicitud;
        internal Label Label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtplazo;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtInteres;
        internal Label Label5;
        internal ComboBox ComboGestor;
        internal ComboBox ComboPromotor;
        internal Button Button2;
        internal Label lblCliente;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIdCliente;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal MonoFlat.MonoFlat_Separator MonoFlat_Separator1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtIntegrantes;
        internal Label Label2;
        internal Label Label6;
        internal Label Label8;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal EvolveControlBox EvolveControlBox1;
        internal Button btn_agregar;
        internal System.ComponentModel.BackgroundWorker BackgroundGestores;
        internal System.ComponentModel.BackgroundWorker BackgroundPromotores;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtResponsable;
        internal Label Label9;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontopPersona;
        internal Label Label10;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoTotal;
        internal Label Label11;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMoratorios;
        internal Label lblMoratorios;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        internal Label lblTotal;
        internal MonoFlat.MonoFlat_CheckBox CheckNombre;
        internal Label lblGestorLegal;
        internal ComboBox ComboLegal;
        internal System.ComponentModel.BackgroundWorker BackgroundLegal;
        internal System.ComponentModel.BackgroundWorker BackgroundSolicitudLegal;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtTotalMoratorios;
        internal Label lblTotalMoratorios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
    }
}