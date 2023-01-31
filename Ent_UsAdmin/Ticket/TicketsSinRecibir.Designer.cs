using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class TicketsSinRecibir : Form
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
            var CheckBoxProperties1 = new PresentationControls.CheckBoxProperties();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsSinRecibir));
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatos.CellContentClick += new DataGridViewCellEventHandler(dtdatos_CellContentClick);
            Id = new DataGridViewTextBoxColumn();
            idCredito = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Caja = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Panel1 = new Panel();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            ComboFiltro = new ComboBox();
            Label8 = new Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            lbltotal = new MonoFlat.MonoFlat_HeaderLabel();
            lbltotal.Click += new EventHandler(MonoFlat_HeaderLabel3_Click);
            BackgroundCajas = new System.ComponentModel.BackgroundWorker();
            BackgroundCajas.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCajas_DoWork);
            BackgroundCajas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCajas_RunWorkerCompleted);
            BackgroundExcel = new System.ComponentModel.BackgroundWorker();
            BackgroundExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundExcel_DoWork);
            BackgroundExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundExcel_RunWorkerCompleted);
            CheckedCajas = new PresentationControls.CheckBoxComboBox();
            BackgroundCancelar = new System.ComponentModel.BackgroundWorker();
            BackgroundCancelar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCancelar_RunWorkerCompleted);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(71, 8);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(125, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Tickets sin cierre";
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            dtdatos.AllowUserToDeleteRows = false;
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
            dtdatos.Columns.AddRange(new DataGridViewColumn[] { Id, idCredito, Nombre, Monto, Fecha, Hora, Tipo, Caja, Estado });
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(1, 122);
            dtdatos.Name = "dtdatos";
            dtdatos.ReadOnly = true;
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(1194, 447);
            dtdatos.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // idCredito
            // 
            idCredito.HeaderText = "idCrédito";
            idCredito.Name = "idCredito";
            idCredito.ReadOnly = true;
            idCredito.Width = 87;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 79;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 70;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 68;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 59;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 55;
            // 
            // Caja
            // 
            Caja.HeaderText = "Caja";
            Caja.Name = "Caja";
            Caja.ReadOnly = true;
            Caja.Width = 59;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 71;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(Button1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1194, 36);
            Panel1.TabIndex = 8;
            // 
            // Button1
            // 
            Button1.FlatAppearance.BorderColor = Color.White;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.ForeColor = SystemColors.Control;
            Button1.Location = new Point(11, 8);
            Button1.Name = "Button1";
            Button1.Size = new Size(54, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Atrás";
            Button1.UseVisualStyleBackColor = true;
            // 
            // ComboFiltro
            // 
            ComboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFiltro.FormattingEnabled = true;
            ComboFiltro.ItemHeight = 13;
            ComboFiltro.Location = new Point(974, 49);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(58, 21);
            ComboFiltro.TabIndex = 31;
            ComboFiltro.Visible = false;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.ForeColor = Color.White;
            Label8.Location = new Point(20, 49);
            Label8.Name = "Label8";
            Label8.Size = new Size(33, 13);
            Label8.TabIndex = 33;
            Label8.Text = "Cajas";
            // 
            // BackgroundWorker1
            // 
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(988, 99);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(44, 20);
            MonoFlat_HeaderLabel2.TabIndex = 2;
            MonoFlat_HeaderLabel2.Text = "Total";
            // 
            // lbltotal
            // 
            lbltotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.Transparent;
            lbltotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lbltotal.ForeColor = Color.FromArgb(255, 255, 255);
            lbltotal.Location = new Point(1059, 99);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(21, 20);
            lbltotal.TabIndex = 34;
            lbltotal.Text = "...";
            // 
            // BackgroundCajas
            // 
            // 
            // BackgroundExcel
            // 
            // 
            // CheckedCajas
            // 
            CheckBoxProperties1.ForeColor = SystemColors.ControlText;
            CheckedCajas.CheckBoxProperties = CheckBoxProperties1;
            CheckedCajas.DisplayMemberSingleItem = "";
            CheckedCajas.FormattingEnabled = true;
            CheckedCajas.Location = new Point(23, 77);
            CheckedCajas.Name = "CheckedCajas";
            CheckedCajas.Size = new Size(256, 21);
            CheckedCajas.TabIndex = 35;
            // 
            // BackgroundCancelar
            // 
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
            BunifuThinButton21.ButtonText = "Exportar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(439, 67);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 4;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Consultar";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.SeaGreen;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.SeaGreen;
            BunifuThinButton22.IdleLineColor = Color.SeaGreen;
            BunifuThinButton22.Location = new Point(323, 67);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 5;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TicketsSinRecibir
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1197, 581);
            Controls.Add(CheckedCajas);
            Controls.Add(lbltotal);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(BunifuThinButton21);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label8);
            Controls.Add(ComboFiltro);
            Controls.Add(dtdatos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicketsSinRecibir";
            Text = "Tickets sin cierre";
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Tickets_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal ComboBox ComboFiltro;
        internal Label Label8;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel lbltotal;
        internal System.ComponentModel.BackgroundWorker BackgroundCajas;
        internal System.ComponentModel.BackgroundWorker BackgroundExcel;
        internal PresentationControls.CheckBoxComboBox CheckedCajas;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn idCredito;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Monto;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn Hora;
        internal DataGridViewTextBoxColumn Tipo;
        internal DataGridViewTextBoxColumn Caja;
        internal DataGridViewTextBoxColumn Estado;
        internal System.ComponentModel.BackgroundWorker BackgroundCancelar;
        internal Button Button1;
    }
}