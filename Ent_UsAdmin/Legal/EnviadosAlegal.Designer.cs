using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EnviadosAlegal : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviadosAlegal));
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.MonoFlat_Label2 = new ConfiaAdmin.MonoFlat.MonoFlat_Label();
            this.dateDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.MonoFlat_Label1 = new ConfiaAdmin.MonoFlat.MonoFlat_Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.ComboFiltro = new System.Windows.Forms.ComboBox();
            this.BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundGestores = new System.ComponentModel.BackgroundWorker();
            this.BackgroundPromotores = new System.ComponentModel.BackgroundWorker();
            this.ComboElección = new System.Windows.Forms.ComboBox();
            this.BackgroundConsulta = new System.ComponentModel.BackgroundWorker();
            this.BackgroundExcel = new System.ComponentModel.BackgroundWorker();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel3 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblEntregado = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblPagare = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblTotal = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel5 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(63, 0);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(120, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Enviados a legal";
            // 
            // dtimpuestos
            // 
            this.dtimpuestos.AllowUserToAddRows = false;
            this.dtimpuestos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtimpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtimpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtimpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtimpuestos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtimpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtimpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtimpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtimpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtimpuestos.DoubleBuffered = true;
            this.dtimpuestos.EnableHeadersVisualStyles = false;
            this.dtimpuestos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtimpuestos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtimpuestos.Location = new System.Drawing.Point(1, 156);
            this.dtimpuestos.Name = "dtimpuestos";
            this.dtimpuestos.ReadOnly = true;
            this.dtimpuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtimpuestos.RowHeadersVisible = false;
            this.dtimpuestos.Size = new System.Drawing.Size(1194, 413);
            this.dtimpuestos.TabIndex = 7;
            this.dtimpuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtimpuestos_CellContentClick);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.BunifuThinButton21);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Controls.Add(this.dateHasta);
            this.Panel1.Controls.Add(this.MonoFlat_Label2);
            this.Panel1.Controls.Add(this.dateDesde);
            this.Panel1.Controls.Add(this.MonoFlat_Label1);
            this.Panel1.Location = new System.Drawing.Point(1, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1194, 62);
            this.Panel1.TabIndex = 8;
            // 
            // Button2
            // 
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.ForeColor = System.Drawing.SystemColors.Control;
            this.Button2.Location = new System.Drawing.Point(3, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(54, 23);
            this.Button2.TabIndex = 33;
            this.Button2.Text = "Atrás";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BunifuThinButton21
            // 
            this.BunifuThinButton21.ActiveBorderThickness = 1;
            this.BunifuThinButton21.ActiveCornerRadius = 20;
            this.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton21.BackgroundImage")));
            this.BunifuThinButton21.ButtonText = "Exportar";
            this.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleBorderThickness = 1;
            this.BunifuThinButton21.IdleCornerRadius = 20;
            this.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.Location = new System.Drawing.Point(1097, 3);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(92, 31);
            this.BunifuThinButton21.TabIndex = 4;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // dateHasta
            // 
            this.dateHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.dateHasta.BorderRadius = 0;
            this.dateHasta.ForeColor = System.Drawing.Color.White;
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.FormatCustom = null;
            this.dateHasta.Location = new System.Drawing.Point(597, 26);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(177, 33);
            this.dateHasta.TabIndex = 7;
            this.dateHasta.Value = new System.DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_Label2
            // 
            this.MonoFlat_Label2.AutoSize = true;
            this.MonoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.MonoFlat_Label2.Location = new System.Drawing.Point(594, 8);
            this.MonoFlat_Label2.Name = "MonoFlat_Label2";
            this.MonoFlat_Label2.Size = new System.Drawing.Size(37, 15);
            this.MonoFlat_Label2.TabIndex = 9;
            this.MonoFlat_Label2.Text = "Hasta";
            // 
            // dateDesde
            // 
            this.dateDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.dateDesde.BorderRadius = 0;
            this.dateDesde.ForeColor = System.Drawing.Color.White;
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.FormatCustom = null;
            this.dateDesde.Location = new System.Drawing.Point(354, 26);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(177, 33);
            this.dateDesde.TabIndex = 6;
            this.dateDesde.Value = new System.DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_Label1
            // 
            this.MonoFlat_Label1.AutoSize = true;
            this.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.MonoFlat_Label1.Location = new System.Drawing.Point(351, 8);
            this.MonoFlat_Label1.Name = "MonoFlat_Label1";
            this.MonoFlat_Label1.Size = new System.Drawing.Size(39, 15);
            this.MonoFlat_Label1.TabIndex = 8;
            this.MonoFlat_Label1.Text = "Desde";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(19, 69);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(50, 13);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "Filtrar por";
            // 
            // ComboFiltro
            // 
            this.ComboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFiltro.FormattingEnabled = true;
            this.ComboFiltro.Items.AddRange(new object[] {
            "Todos",
            "Gestor",
            "Promotor"});
            this.ComboFiltro.Location = new System.Drawing.Point(22, 99);
            this.ComboFiltro.Name = "ComboFiltro";
            this.ComboFiltro.Size = new System.Drawing.Size(240, 21);
            this.ComboFiltro.TabIndex = 30;
            this.ComboFiltro.SelectedIndexChanged += new System.EventHandler(this.ComboFiltro_SelectedIndexChanged);
            // 
            // BunifuThinButton22
            // 
            this.BunifuThinButton22.ActiveBorderThickness = 1;
            this.BunifuThinButton22.ActiveCornerRadius = 20;
            this.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.BunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton22.BackgroundImage")));
            this.BunifuThinButton22.ButtonText = "Consultar";
            this.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.IdleBorderThickness = 1;
            this.BunifuThinButton22.IdleCornerRadius = 20;
            this.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton22.Location = new System.Drawing.Point(1011, 89);
            this.BunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton22.Name = "BunifuThinButton22";
            this.BunifuThinButton22.Size = new System.Drawing.Size(92, 31);
            this.BunifuThinButton22.TabIndex = 5;
            this.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
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
            // ComboElección
            // 
            this.ComboElección.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboElección.FormattingEnabled = true;
            this.ComboElección.ItemHeight = 13;
            this.ComboElección.Location = new System.Drawing.Point(268, 99);
            this.ComboElección.Name = "ComboElección";
            this.ComboElección.Size = new System.Drawing.Size(239, 21);
            this.ComboElección.TabIndex = 31;
            // 
            // BackgroundConsulta
            // 
            this.BackgroundConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundConsulta_DoWork);
            this.BackgroundConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundConsulta_RunWorkerCompleted);
            // 
            // BackgroundExcel
            // 
            this.BackgroundExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundExcel_DoWork);
            this.BackgroundExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundExcel_RunWorkerCompleted);
            // 
            // MonoFlat_HeaderLabel2
            // 
            this.MonoFlat_HeaderLabel2.AutoSize = true;
            this.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel2.Location = new System.Drawing.Point(546, 78);
            this.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            this.MonoFlat_HeaderLabel2.Size = new System.Drawing.Size(103, 20);
            this.MonoFlat_HeaderLabel2.TabIndex = 34;
            this.MonoFlat_HeaderLabel2.Text = "Total Crédito:";
            // 
            // MonoFlat_HeaderLabel3
            // 
            this.MonoFlat_HeaderLabel3.AutoSize = true;
            this.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel3.Location = new System.Drawing.Point(546, 100);
            this.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            this.MonoFlat_HeaderLabel3.Size = new System.Drawing.Size(130, 20);
            this.MonoFlat_HeaderLabel3.TabIndex = 35;
            this.MonoFlat_HeaderLabel3.Text = "Total Moratorios:";
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.BackColor = System.Drawing.Color.Transparent;
            this.lblEntregado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntregado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEntregado.Location = new System.Drawing.Point(676, 78);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(21, 20);
            this.lblEntregado.TabIndex = 36;
            this.lblEntregado.Text = "...";
            // 
            // lblPagare
            // 
            this.lblPagare.AutoSize = true;
            this.lblPagare.BackColor = System.Drawing.Color.Transparent;
            this.lblPagare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPagare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPagare.Location = new System.Drawing.Point(676, 100);
            this.lblPagare.Name = "lblPagare";
            this.lblPagare.Size = new System.Drawing.Size(21, 20);
            this.lblPagare.TabIndex = 37;
            this.lblPagare.Text = "...";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(676, 122);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 20);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "...";
            // 
            // monoFlat_HeaderLabel5
            // 
            this.monoFlat_HeaderLabel5.AutoSize = true;
            this.monoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel5.Location = new System.Drawing.Point(546, 122);
            this.monoFlat_HeaderLabel5.Name = "monoFlat_HeaderLabel5";
            this.monoFlat_HeaderLabel5.Size = new System.Drawing.Size(107, 20);
            this.monoFlat_HeaderLabel5.TabIndex = 38;
            this.monoFlat_HeaderLabel5.Text = "Total Enviado:";
            // 
            // EnviadosAlegal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1197, 581);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.monoFlat_HeaderLabel5);
            this.Controls.Add(this.lblPagare);
            this.Controls.Add(this.lblEntregado);
            this.Controls.Add(this.MonoFlat_HeaderLabel3);
            this.Controls.Add(this.MonoFlat_HeaderLabel2);
            this.Controls.Add(this.BunifuThinButton22);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.ComboElección);
            this.Controls.Add(this.ComboFiltro);
            this.Controls.Add(this.dtimpuestos);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnviadosAlegal";
            this.Text = "Enviados a legal";
            this.Load += new System.EventHandler(this.Desembolsos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuDatepicker dateDesde;
        internal Bunifu.Framework.UI.BunifuDatepicker dateHasta;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label2;
        internal Label Label6;
        internal ComboBox ComboFiltro;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal System.ComponentModel.BackgroundWorker BackgroundGestores;
        internal System.ComponentModel.BackgroundWorker BackgroundPromotores;
        internal ComboBox ComboElección;
        internal System.ComponentModel.BackgroundWorker BackgroundConsulta;
        internal System.ComponentModel.BackgroundWorker BackgroundExcel;
        internal Button Button2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel lblEntregado;
        internal MonoFlat.MonoFlat_HeaderLabel lblPagare;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotal;
        internal MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel5;
    }
}