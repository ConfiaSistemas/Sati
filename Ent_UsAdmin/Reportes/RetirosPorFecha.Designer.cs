using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class RetirosPorFecha : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(RetirosPorFecha));
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatos.CellContentClick += new DataGridViewCellEventHandler(dtdatos_CellContentClick);
            Panel1 = new Panel();
            dateDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            dateHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            MonoFlat_Label2 = new MonoFlat.MonoFlat_Label();
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
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
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
            MonoFlat_HeaderLabel1.Location = new Point(63, 5);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(129, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Retiros por fecha";
            // 
            // dtdatos
            // 
            dtdatos.AllowUserToAddRows = false;
            dtdatos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3;
            dtdatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtdatos.BackgroundColor = Color.Gainsboro;
            dtdatos.BorderStyle = BorderStyle.None;
            dtdatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle4.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dtdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(Button2);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1194, 36);
            Panel1.TabIndex = 8;
            // 
            // dateDesde
            // 
            dateDesde.BackColor = Color.FromArgb(0, 5, 11);
            dateDesde.BorderRadius = 0;
            dateDesde.ForeColor = Color.White;
            dateDesde.Format = DateTimePickerFormat.Short;
            dateDesde.FormatCustom = null;
            dateDesde.Location = new Point(285, 67);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(177, 33);
            dateDesde.TabIndex = 6;
            dateDesde.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // dateHasta
            // 
            dateHasta.BackColor = Color.FromArgb(0, 5, 11);
            dateHasta.BorderRadius = 0;
            dateHasta.ForeColor = Color.White;
            dateHasta.Format = DateTimePickerFormat.Short;
            dateHasta.FormatCustom = null;
            dateHasta.Location = new Point(528, 67);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(177, 33);
            dateHasta.TabIndex = 7;
            dateHasta.Value = new DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(282, 49);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(39, 15);
            MonoFlat_Label1.TabIndex = 8;
            MonoFlat_Label1.Text = "Desde";
            // 
            // MonoFlat_Label2
            // 
            MonoFlat_Label2.AutoSize = true;
            MonoFlat_Label2.BackColor = Color.Transparent;
            MonoFlat_Label2.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label2.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label2.Location = new Point(525, 49);
            MonoFlat_Label2.Name = "MonoFlat_Label2";
            MonoFlat_Label2.Size = new Size(37, 15);
            MonoFlat_Label2.TabIndex = 9;
            MonoFlat_Label2.Text = "Hasta";
            // 
            // ComboFiltro
            // 
            ComboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFiltro.FormattingEnabled = true;
            ComboFiltro.ItemHeight = 13;
            ComboFiltro.Location = new Point(23, 79);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(239, 21);
            ComboFiltro.TabIndex = 31;
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
            BunifuThinButton21.Location = new Point(865, 67);
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
            BunifuThinButton22.Location = new Point(749, 67);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 5;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button2
            // 
            Button2.FlatAppearance.BorderColor = Color.White;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.ForeColor = SystemColors.Control;
            Button2.Location = new Point(3, 3);
            Button2.Name = "Button2";
            Button2.Size = new Size(54, 23);
            Button2.TabIndex = 35;
            Button2.Text = "Atrás";
            Button2.UseVisualStyleBackColor = true;
            // 
            // RetirosPorFecha
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1197, 581);
            Controls.Add(lbltotal);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(BunifuThinButton21);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label8);
            Controls.Add(ComboFiltro);
            Controls.Add(MonoFlat_Label2);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(dtdatos);
            Controls.Add(dateHasta);
            Controls.Add(dateDesde);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RetirosPorFecha";
            Text = "Retiros Por Fecha";
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
        internal Bunifu.Framework.UI.BunifuDatepicker dateDesde;
        internal Bunifu.Framework.UI.BunifuDatepicker dateHasta;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label2;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal ComboBox ComboFiltro;
        internal Label Label8;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel lbltotal;
        internal System.ComponentModel.BackgroundWorker BackgroundCajas;
        internal Button Button2;
    }
}