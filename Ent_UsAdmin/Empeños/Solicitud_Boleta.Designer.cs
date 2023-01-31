using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class Solicitud_Boleta : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud_Boleta));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            txtMontoTotalSugerido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label4 = new Label();
            txtPorcentajeRefrendo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label5 = new Label();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Label7 = new Label();
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatos.KeyDown += new KeyEventHandler(dtdatos_KeyDown);
            dtdatos.CellContentClick += new DataGridViewCellEventHandler(dtdatos_CellContentClick);
            dtdatos.RowsAdded += new DataGridViewRowsAddedEventHandler(dtdatos_RowsAdded);
            dtdatos.CellEndEdit += new DataGridViewCellEventHandler(dtdatos_CellEndEdit);
            Foto = new DataGridViewImageColumn();
            TipoPrenda = new DataGridViewComboBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            NoSerie = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            MontoValuado = new DataGridViewTextBoxColumn();
            MontoSugerido = new DataGridViewTextBoxColumn();
            MonoFlat_Separator1 = new MonoFlat.MonoFlat_Separator();
            btn_Procesar = new Bunifu.Framework.UI.BunifuThinButton2();
            btn_Procesar.Click += new EventHandler(btn_Procesar_Click);
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_click);
            BackgroundGestores = new System.ComponentModel.BackgroundWorker();
            BackgroundGestores.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGestores_DoWork);
            BackgroundGestores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGestores_RunWorkerCompleted);
            BackgroundPromotores = new System.ComponentModel.BackgroundWorker();
            BackgroundPromotores.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPromotores_DoWork);
            BackgroundPromotores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundPromotores_RunWorkerCompleted);
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            Label10 = new Label();
            txtMontoTotalValuado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Label11 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label1 = new Label();
            Label8 = new Label();
            ComboPromotor = new ComboBox();
            lblCliente = new Label();
            lblTipo = new Label();
            BackgroundTipos = new System.ComponentModel.BackgroundWorker();
            BackgroundTipos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundTipos_DoWork);
            BackgroundTipos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundTipos_RunWorkerCompleted);
            txtIdCLiente = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtIdCLiente.TextChanged += new EventHandler(TextBoxEx1_TextChanged);
            txtIdCLiente.MouseHover += new EventHandler(TextBoxEx1_MouseHover);
            txtIdCLiente.MouseLeave += new EventHandler(TextBoxEx1_MouseLeave);
            txtIdCLiente.GotFocus += new EventHandler(TextBoxEx1_GotFocus);
            txtIdCLiente.LostFocus += new EventHandler(TextBoxEx1_LostFocus);
            txtIdCLiente.PreviewKeyDown += new PreviewKeyDownEventHandler(txtIdCLiente_PreviewKeyDown);
            txtIdCLiente.KeyDown += new KeyEventHandler(txtIdCLiente_KeyDown);
            txtPrenda = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtPrenda.TextChanged += new EventHandler(txtPrenda_TextChanged);
            txtPrenda.PreviewKeyDown += new PreviewKeyDownEventHandler(txtPrenda_PreviewKeyDown);
            txtPrenda.KeyDown += new KeyEventHandler(txtPrenda_KeyDown);
            txtPrenda.MouseHover += new EventHandler(txtPrenda_MouseHover);
            txtPrenda.MouseLeave += new EventHandler(txtPrenda_MouseLeave);
            txtPrenda.GotFocus += new EventHandler(txtPrenda_GotFocus);
            txtPrenda.LostFocus += new EventHandler(txtPrenda_LostFocus);
            txtTipo = new VB.Windows.Forms.ControlExt.TextBoxEx();
            txtTipo.MouseHover += new EventHandler(txtTipo_MouseHover);
            txtTipo.MouseLeave += new EventHandler(txtTipo_MouseLeave);
            txtTipo.GotFocus += new EventHandler(txtTipo_GotFocus);
            txtTipo.LostFocus += new EventHandler(txtTipo_LostFocus);
            txtTipo.KeyDown += new KeyEventHandler(txtTipo_KeyDown);
            txtTipo.PreviewKeyDown += new PreviewKeyDownEventHandler(txtTipo_PreviewKeyDown);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1057, 36);
            Panel1.TabIndex = 2;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(993, 3);
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
            MonoFlat_HeaderLabel1.Size = new Size(151, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Solicitud de Empeño";
            // 
            // txtMontoTotalSugerido
            // 
            txtMontoTotalSugerido.Cursor = Cursors.IBeam;
            txtMontoTotalSugerido.Font = new Font("Century Gothic", 9.75f);
            txtMontoTotalSugerido.ForeColor = Color.White;
            txtMontoTotalSugerido.HintForeColor = Color.White;
            txtMontoTotalSugerido.HintText = "";
            txtMontoTotalSugerido.isPassword = false;
            txtMontoTotalSugerido.LineFocusedColor = Color.Blue;
            txtMontoTotalSugerido.LineIdleColor = Color.Gray;
            txtMontoTotalSugerido.LineMouseHoverColor = Color.Blue;
            txtMontoTotalSugerido.LineThickness = 3;
            txtMontoTotalSugerido.Location = new Point(592, 430);
            txtMontoTotalSugerido.Margin = new Padding(4);
            txtMontoTotalSugerido.Name = "txtMontoTotalSugerido";
            txtMontoTotalSugerido.Size = new Size(107, 25);
            txtMontoTotalSugerido.TabIndex = 6;
            txtMontoTotalSugerido.TextAlign = HorizontalAlignment.Left;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(589, 413);
            Label4.Name = "Label4";
            Label4.Size = new Size(82, 13);
            Label4.TabIndex = 14;
            Label4.Text = "Monto Sugerido";
            // 
            // txtPorcentajeRefrendo
            // 
            txtPorcentajeRefrendo.Cursor = Cursors.IBeam;
            txtPorcentajeRefrendo.Font = new Font("Century Gothic", 9.75f);
            txtPorcentajeRefrendo.ForeColor = Color.White;
            txtPorcentajeRefrendo.HintForeColor = Color.White;
            txtPorcentajeRefrendo.HintText = "";
            txtPorcentajeRefrendo.isPassword = false;
            txtPorcentajeRefrendo.LineFocusedColor = Color.Blue;
            txtPorcentajeRefrendo.LineIdleColor = Color.Gray;
            txtPorcentajeRefrendo.LineMouseHoverColor = Color.Blue;
            txtPorcentajeRefrendo.LineThickness = 3;
            txtPorcentajeRefrendo.Location = new Point(803, 430);
            txtPorcentajeRefrendo.Margin = new Padding(4);
            txtPorcentajeRefrendo.Name = "txtPorcentajeRefrendo";
            txtPorcentajeRefrendo.Size = new Size(115, 25);
            txtPorcentajeRefrendo.TabIndex = 7;
            txtPorcentajeRefrendo.TextAlign = HorizontalAlignment.Left;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(798, 413);
            Label5.Name = "Label5";
            Label5.Size = new Size(120, 13);
            Label5.TabIndex = 16;
            Label5.Text = "Porcentaje de Refrendo";
            // 
            // Button2
            // 
            Button2.Location = new Point(601, 74);
            Button2.Name = "Button2";
            Button2.Size = new Size(27, 21);
            Button2.TabIndex = 21;
            Button2.TabStop = false;
            Button2.Text = "F2";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.ForeColor = Color.White;
            Label7.Location = new Point(339, 53);
            Label7.Name = "Label7";
            Label7.Size = new Size(39, 13);
            Label7.TabIndex = 20;
            Label7.Text = "Cliente";
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtdatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtdatos.BackgroundColor = Color.Gainsboro;
            dtdatos.BorderStyle = BorderStyle.None;
            dtdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatos.Columns.AddRange(new DataGridViewColumn[] { Foto, TipoPrenda, Marca, Modelo, NoSerie, Descripcion, MontoValuado, MontoSugerido });
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(34, 137);
            dtdatos.Name = "dtdatos";
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(1000, 255);
            dtdatos.TabIndex = 4;
            // 
            // Foto
            // 
            Foto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Foto.FillWeight = 150.0f;
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Foto.MinimumWidth = 20;
            Foto.Name = "Foto";
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            Foto.Width = 200;
            // 
            // TipoPrenda
            // 
            TipoPrenda.HeaderText = "Tipo";
            TipoPrenda.Name = "TipoPrenda";
            TipoPrenda.Resizable = DataGridViewTriState.True;
            TipoPrenda.SortMode = DataGridViewColumnSortMode.Automatic;
            TipoPrenda.Width = 55;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.Width = 70;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.Width = 77;
            // 
            // NoSerie
            // 
            NoSerie.HeaderText = "No. de Serie";
            NoSerie.Name = "NoSerie";
            NoSerie.Width = 94;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            // 
            // MontoValuado
            // 
            MontoValuado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MontoValuado.HeaderText = "Monto Valuado";
            MontoValuado.Name = "MontoValuado";
            MontoValuado.Width = 90;
            // 
            // MontoSugerido
            // 
            MontoSugerido.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MontoSugerido.HeaderText = "Monto Sugerido";
            MontoSugerido.Name = "MontoSugerido";
            MontoSugerido.Width = 90;
            // 
            // MonoFlat_Separator1
            // 
            MonoFlat_Separator1.Location = new Point(1, 398);
            MonoFlat_Separator1.Name = "MonoFlat_Separator1";
            MonoFlat_Separator1.Size = new Size(1062, 12);
            MonoFlat_Separator1.TabIndex = 25;
            MonoFlat_Separator1.Text = "MonoFlat_Separator1";
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
            btn_Procesar.ButtonText = "Ingresar e iniciar proceso";
            btn_Procesar.Cursor = Cursors.Hand;
            btn_Procesar.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Procesar.ForeColor = Color.DarkBlue;
            btn_Procesar.IdleBorderThickness = 1;
            btn_Procesar.IdleCornerRadius = 20;
            btn_Procesar.IdleFillColor = Color.White;
            btn_Procesar.IdleForecolor = Color.Gray;
            btn_Procesar.IdleLineColor = Color.FromArgb(14, 21, 38);
            btn_Procesar.Location = new Point(433, 487);
            btn_Procesar.Margin = new Padding(5);
            btn_Procesar.Name = "btn_Procesar";
            btn_Procesar.Size = new Size(216, 38);
            btn_Procesar.TabIndex = 13;
            btn_Procesar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(956, 74);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(27, 21);
            btn_agregar.TabIndex = 5;
            btn_agregar.TabStop = false;
            btn_agregar.Text = "+";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Visible = false;
            // 
            // BackgroundGestores
            // 
            // 
            // BackgroundPromotores
            // 
            // 
            // BackgroundWorker1
            // 
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.ForeColor = Color.White;
            Label10.Location = new Point(687, 53);
            Label10.Name = "Label10";
            Label10.Size = new Size(41, 13);
            Label10.TabIndex = 34;
            Label10.Text = "Prenda";
            // 
            // txtMontoTotalValuado
            // 
            txtMontoTotalValuado.Cursor = Cursors.IBeam;
            txtMontoTotalValuado.Enabled = false;
            txtMontoTotalValuado.Font = new Font("Century Gothic", 9.75f);
            txtMontoTotalValuado.ForeColor = Color.White;
            txtMontoTotalValuado.HintForeColor = Color.White;
            txtMontoTotalValuado.HintText = "";
            txtMontoTotalValuado.isPassword = false;
            txtMontoTotalValuado.LineFocusedColor = Color.Blue;
            txtMontoTotalValuado.LineIdleColor = Color.Gray;
            txtMontoTotalValuado.LineMouseHoverColor = Color.Blue;
            txtMontoTotalValuado.LineThickness = 3;
            txtMontoTotalValuado.Location = new Point(380, 430);
            txtMontoTotalValuado.Margin = new Padding(4);
            txtMontoTotalValuado.Name = "txtMontoTotalValuado";
            txtMontoTotalValuado.Size = new Size(103, 25);
            txtMontoTotalValuado.TabIndex = 20;
            txtMontoTotalValuado.TextAlign = HorizontalAlignment.Left;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.White;
            Label11.Location = new Point(377, 413);
            Label11.Name = "Label11";
            Label11.Size = new Size(106, 13);
            Label11.TabIndex = 36;
            Label11.Text = "Monto Total Valuado";
            // 
            // Button1
            // 
            Button1.Location = new Point(218, 74);
            Button1.Name = "Button1";
            Button1.Size = new Size(27, 21);
            Button1.TabIndex = 20;
            Button1.TabStop = false;
            Button1.Text = "F2";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(31, 53);
            Label1.Name = "Label1";
            Label1.Size = new Size(28, 13);
            Label1.TabIndex = 8;
            Label1.Text = "Tipo";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(31, 413);
            Label8.Name = "Label8";
            Label8.Size = new Size(49, 13);
            Label8.TabIndex = 29;
            Label8.Text = "Promotor";
            // 
            // ComboPromotor
            // 
            ComboPromotor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPromotor.FormattingEnabled = true;
            ComboPromotor.ItemHeight = 13;
            ComboPromotor.Location = new Point(34, 434);
            ComboPromotor.Name = "ComboPromotor";
            ComboPromotor.Size = new Size(239, 21);
            ComboPromotor.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(339, 108);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(13, 13);
            lblCliente.TabIndex = 22;
            lblCliente.Text = "..";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(31, 108);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(13, 13);
            lblTipo.TabIndex = 10;
            lblTipo.Text = "..";
            // 
            // BackgroundTipos
            // 
            // 
            // txtIdCLiente
            // 
            txtIdCLiente.BackColor = Color.FromArgb(0, 5, 11);
            txtIdCLiente.BorderColor = Color.Gray;
            txtIdCLiente.ForeColor = Color.White;
            txtIdCLiente.Location = new Point(342, 76);
            txtIdCLiente.Name = "txtIdCLiente";
            txtIdCLiente.Size = new Size(253, 20);
            txtIdCLiente.TabIndex = 1;
            // 
            // txtPrenda
            // 
            txtPrenda.BackColor = Color.FromArgb(0, 5, 11);
            txtPrenda.BorderColor = Color.Gray;
            txtPrenda.ForeColor = Color.White;
            txtPrenda.Location = new Point(690, 76);
            txtPrenda.Name = "txtPrenda";
            txtPrenda.Size = new Size(260, 20);
            txtPrenda.TabIndex = 3;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(0, 5, 11);
            txtTipo.BorderColor = Color.Gray;
            txtTipo.ForeColor = Color.White;
            txtTipo.Location = new Point(34, 76);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(178, 20);
            txtTipo.TabIndex = 0;
            // 
            // Solicitud_Boleta
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1060, 551);
            Controls.Add(txtTipo);
            Controls.Add(txtPrenda);
            Controls.Add(txtIdCLiente);
            Controls.Add(txtMontoTotalValuado);
            Controls.Add(Label11);
            Controls.Add(Label10);
            Controls.Add(btn_agregar);
            Controls.Add(btn_Procesar);
            Controls.Add(Label8);
            Controls.Add(MonoFlat_Separator1);
            Controls.Add(dtdatos);
            Controls.Add(Button2);
            Controls.Add(lblCliente);
            Controls.Add(Label7);
            Controls.Add(ComboPromotor);
            Controls.Add(txtPorcentajeRefrendo);
            Controls.Add(Label5);
            Controls.Add(txtMontoTotalSugerido);
            Controls.Add(Label4);
            Controls.Add(Button1);
            Controls.Add(lblTipo);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Solicitud_Boleta";
            Text = "Solicitud de Empeño";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Load += new EventHandler(Levantar_Solicitud_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoTotalSugerido;
        internal Label Label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtPorcentajeRefrendo;
        internal Label Label5;
        internal Button Button2;
        internal Label Label7;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal MonoFlat.MonoFlat_Separator MonoFlat_Separator1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_Procesar;
        internal EvolveControlBox EvolveControlBox1;
        internal Button btn_agregar;
        internal System.ComponentModel.BackgroundWorker BackgroundGestores;
        internal System.ComponentModel.BackgroundWorker BackgroundPromotores;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal Label Label10;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtMontoTotalValuado;
        internal Label Label11;
        internal Button Button1;
        internal Label Label1;
        internal Label Label8;
        internal ComboBox ComboPromotor;
        internal Label lblCliente;
        internal Label lblTipo;
        internal DataGridViewImageColumn Foto;
        internal DataGridViewComboBoxColumn TipoPrenda;
        internal DataGridViewTextBoxColumn Marca;
        internal DataGridViewTextBoxColumn Modelo;
        internal DataGridViewTextBoxColumn NoSerie;
        internal DataGridViewTextBoxColumn Descripcion;
        internal DataGridViewTextBoxColumn MontoValuado;
        internal DataGridViewTextBoxColumn MontoSugerido;
        internal System.ComponentModel.BackgroundWorker BackgroundTipos;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtIdCLiente;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtPrenda;
        internal VB.Windows.Forms.ControlExt.TextBoxEx txtTipo;
    }
}