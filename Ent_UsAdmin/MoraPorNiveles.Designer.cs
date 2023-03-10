using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]


    public partial class MoraPorNiveles : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MoraPorNiveles));
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            Panel1 = new Panel();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            Label6 = new Label();
            ComboFiltro = new ComboBox();
            ComboFiltro.SelectedIndexChanged += new EventHandler(ComboFiltro_SelectedIndexChanged);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            BackgroundGestores = new System.ComponentModel.BackgroundWorker();
            BackgroundGestores.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGestores_DoWork);
            BackgroundGestores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGestores_RunWorkerCompleted);
            BackgroundPromotores = new System.ComponentModel.BackgroundWorker();
            BackgroundPromotores.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPromotores_DoWork);
            BackgroundPromotores.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundPromotores_RunWorkerCompleted);
            ComboElección = new ComboBox();
            BackgroundConsulta = new System.ComponentModel.BackgroundWorker();
            BackgroundConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundConsulta_DoWork);
            BackgroundConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundConsulta_RunWorkerCompleted);
            BackgroundExcel = new System.ComponentModel.BackgroundWorker();
            BackgroundExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundExcel_DoWork);
            BackgroundExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundExcel_RunWorkerCompleted);
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(209, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Créditos en mora por niveles";
            // 
            // dtimpuestos
            // 
            dtimpuestos.AllowUserToAddRows = false;
            dtimpuestos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtimpuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtimpuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtimpuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtimpuestos.BackgroundColor = Color.Gainsboro;
            dtimpuestos.BorderStyle = BorderStyle.None;
            dtimpuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtimpuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtimpuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(1, 122);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(1194, 447);
            dtimpuestos.TabIndex = 7;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1194, 36);
            Panel1.TabIndex = 8;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BunifuThinButton21.BackColor = Color.FromArgb(14, 21, 38);
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
            BunifuThinButton21.Location = new Point(1097, 3);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 4;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(19, 47);
            Label6.Name = "Label6";
            Label6.Size = new Size(50, 13);
            Label6.TabIndex = 32;
            Label6.Text = "Filtrar por";
            // 
            // ComboFiltro
            // 
            ComboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFiltro.FormattingEnabled = true;
            ComboFiltro.Items.AddRange(new object[] { "Todos", "Gestor", "Promotor" });
            ComboFiltro.Location = new Point(22, 77);
            ComboFiltro.Name = "ComboFiltro";
            ComboFiltro.Size = new Size(240, 21);
            ComboFiltro.TabIndex = 30;
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.SeaGreen;
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
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
            BunifuThinButton22.Location = new Point(515, 67);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(92, 31);
            BunifuThinButton22.TabIndex = 5;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundGestores
            // 
            // 
            // BackgroundPromotores
            // 
            // 
            // ComboElección
            // 
            ComboElección.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboElección.FormattingEnabled = true;
            ComboElección.ItemHeight = 13;
            ComboElección.Location = new Point(268, 77);
            ComboElección.Name = "ComboElección";
            ComboElección.Size = new Size(239, 21);
            ComboElección.TabIndex = 31;
            // 
            // BackgroundConsulta
            // 
            // 
            // BackgroundExcel
            // 
            // 
            // MoraPorNiveles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1197, 581);
            Controls.Add(BunifuThinButton22);
            Controls.Add(Label6);
            Controls.Add(ComboElección);
            Controls.Add(ComboFiltro);
            Controls.Add(dtimpuestos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MoraPorNiveles";
            Text = "Créditos en mora por niveles";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Desembolsos_Load);
            Resize += new EventHandler(CreditosEnMora_Resize);
            ResumeLayout(false);
            PerformLayout();

        }

        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Label Label6;
        internal ComboBox ComboFiltro;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal System.ComponentModel.BackgroundWorker BackgroundGestores;
        internal System.ComponentModel.BackgroundWorker BackgroundPromotores;
        internal ComboBox ComboElección;
        internal System.ComponentModel.BackgroundWorker BackgroundConsulta;
        internal System.ComponentModel.BackgroundWorker BackgroundExcel;
    }
}