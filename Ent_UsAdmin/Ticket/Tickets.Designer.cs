using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class Tickets : Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.dateDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.MonoFlat_Label1 = new ConfiaAdmin.MonoFlat.MonoFlat_Label();
            this.MonoFlat_Label2 = new ConfiaAdmin.MonoFlat.MonoFlat_Label();
            this.ComboFiltro = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lbltotal = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundCajas = new System.ComponentModel.BackgroundWorker();
            this.BackgroundExcel = new System.ComponentModel.BackgroundWorker();
            this.CheckedCajas = new PresentationControls.CheckBoxComboBox();
            this.ContextMenuCancelar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundCancelar = new System.ComponentModel.BackgroundWorker();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).BeginInit();
            this.Panel1.SuspendLayout();
            this.ContextMenuCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(71, 8);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(128, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Tickets por fecha";
            // 
            // dtdatos
            // 
            this.dtdatos.AllowUserToAddRows = false;
            this.dtdatos.AllowUserToDeleteRows = false;
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
            this.idCredito,
            this.Nombre,
            this.Monto,
            this.Fecha,
            this.Hora,
            this.Tipo,
            this.Caja,
            this.Estado});
            this.dtdatos.DoubleBuffered = true;
            this.dtdatos.EnableHeadersVisualStyles = false;
            this.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatos.Location = new System.Drawing.Point(1, 122);
            this.dtdatos.Name = "dtdatos";
            this.dtdatos.ReadOnly = true;
            this.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatos.RowHeadersVisible = false;
            this.dtdatos.Size = new System.Drawing.Size(1194, 447);
            this.dtdatos.TabIndex = 7;
            this.dtdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatos_CellContentClick);
            this.dtdatos.SelectionChanged += new System.EventHandler(this.dtdatos_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // idCredito
            // 
            this.idCredito.HeaderText = "idCrédito";
            this.idCredito.Name = "idCredito";
            this.idCredito.ReadOnly = true;
            this.idCredito.Width = 87;
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
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 68;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 59;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 55;
            // 
            // Caja
            // 
            this.Caja.HeaderText = "Caja";
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            this.Caja.Width = 59;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 71;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(1, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1194, 36);
            this.Panel1.TabIndex = 8;
            // 
            // Button1
            // 
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.SystemColors.Control;
            this.Button1.Location = new System.Drawing.Point(11, 8);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(54, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Atrás";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateDesde
            // 
            this.dateDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.dateDesde.BorderRadius = 0;
            this.dateDesde.ForeColor = System.Drawing.Color.White;
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDesde.FormatCustom = null;
            this.dateDesde.Location = new System.Drawing.Point(285, 67);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(177, 33);
            this.dateDesde.TabIndex = 6;
            this.dateDesde.Value = new System.DateTime(2020, 2, 20, 0, 0, 0, 0);
            this.dateDesde.onValueChanged += new System.EventHandler(this.dateDesde_onValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.dateHasta.BorderRadius = 0;
            this.dateHasta.ForeColor = System.Drawing.Color.White;
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHasta.FormatCustom = null;
            this.dateHasta.Location = new System.Drawing.Point(528, 67);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(177, 33);
            this.dateHasta.TabIndex = 7;
            this.dateHasta.Value = new System.DateTime(2020, 2, 20, 0, 0, 0, 0);
            // 
            // MonoFlat_Label1
            // 
            this.MonoFlat_Label1.AutoSize = true;
            this.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.MonoFlat_Label1.Location = new System.Drawing.Point(282, 49);
            this.MonoFlat_Label1.Name = "MonoFlat_Label1";
            this.MonoFlat_Label1.Size = new System.Drawing.Size(39, 15);
            this.MonoFlat_Label1.TabIndex = 8;
            this.MonoFlat_Label1.Text = "Desde";
            // 
            // MonoFlat_Label2
            // 
            this.MonoFlat_Label2.AutoSize = true;
            this.MonoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.MonoFlat_Label2.Location = new System.Drawing.Point(525, 49);
            this.MonoFlat_Label2.Name = "MonoFlat_Label2";
            this.MonoFlat_Label2.Size = new System.Drawing.Size(37, 15);
            this.MonoFlat_Label2.TabIndex = 9;
            this.MonoFlat_Label2.Text = "Hasta";
            // 
            // ComboFiltro
            // 
            this.ComboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFiltro.FormattingEnabled = true;
            this.ComboFiltro.ItemHeight = 13;
            this.ComboFiltro.Location = new System.Drawing.Point(974, 49);
            this.ComboFiltro.Name = "ComboFiltro";
            this.ComboFiltro.Size = new System.Drawing.Size(58, 21);
            this.ComboFiltro.TabIndex = 31;
            this.ComboFiltro.Visible = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(20, 49);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(33, 13);
            this.Label8.TabIndex = 33;
            this.Label8.Text = "Cajas";
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // MonoFlat_HeaderLabel2
            // 
            this.MonoFlat_HeaderLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MonoFlat_HeaderLabel2.AutoSize = true;
            this.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel2.Location = new System.Drawing.Point(988, 99);
            this.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            this.MonoFlat_HeaderLabel2.Size = new System.Drawing.Size(44, 20);
            this.MonoFlat_HeaderLabel2.TabIndex = 2;
            this.MonoFlat_HeaderLabel2.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Transparent;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltotal.Location = new System.Drawing.Point(1059, 99);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(21, 20);
            this.lbltotal.TabIndex = 34;
            this.lbltotal.Text = "...";
            this.lbltotal.Click += new System.EventHandler(this.MonoFlat_HeaderLabel3_Click);
            // 
            // BackgroundCajas
            // 
            this.BackgroundCajas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCajas_DoWork);
            this.BackgroundCajas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCajas_RunWorkerCompleted);
            // 
            // BackgroundExcel
            // 
            this.BackgroundExcel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundExcel_DoWork);
            this.BackgroundExcel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundExcel_RunWorkerCompleted);
            // 
            // CheckedCajas
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckedCajas.CheckBoxProperties = checkBoxProperties1;
            this.CheckedCajas.DisplayMemberSingleItem = "";
            this.CheckedCajas.FormattingEnabled = true;
            this.CheckedCajas.Location = new System.Drawing.Point(23, 77);
            this.CheckedCajas.Name = "CheckedCajas";
            this.CheckedCajas.Size = new System.Drawing.Size(256, 21);
            this.CheckedCajas.TabIndex = 35;
            // 
            // ContextMenuCancelar
            // 
            this.ContextMenuCancelar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelarToolStripMenuItem});
            this.ContextMenuCancelar.Name = "ContextMenuCancelar";
            this.ContextMenuCancelar.Size = new System.Drawing.Size(153, 48);
            this.ContextMenuCancelar.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuCancelar_Opening);
            // 
            // CancelarToolStripMenuItem
            // 
            this.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem";
            this.CancelarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CancelarToolStripMenuItem.Text = "Cancelar";
            this.CancelarToolStripMenuItem.Click += new System.EventHandler(this.CancelarToolStripMenuItem_Click);
            // 
            // BackgroundCancelar
            // 
            this.BackgroundCancelar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCancelar_DoWork);
            this.BackgroundCancelar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCancelar_RunWorkerCompleted);
            // 
            // BunifuThinButton21
            // 
            this.BunifuThinButton21.ActiveBorderThickness = 1;
            this.BunifuThinButton21.ActiveCornerRadius = 20;
            this.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
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
            this.BunifuThinButton21.Location = new System.Drawing.Point(865, 67);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(92, 31);
            this.BunifuThinButton21.TabIndex = 4;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
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
            this.BunifuThinButton22.Location = new System.Drawing.Point(749, 67);
            this.BunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton22.Name = "BunifuThinButton22";
            this.BunifuThinButton22.Size = new System.Drawing.Size(92, 31);
            this.BunifuThinButton22.TabIndex = 5;
            this.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1197, 581);
            this.Controls.Add(this.CheckedCajas);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.MonoFlat_HeaderLabel2);
            this.Controls.Add(this.BunifuThinButton21);
            this.Controls.Add(this.BunifuThinButton22);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ComboFiltro);
            this.Controls.Add(this.MonoFlat_Label2);
            this.Controls.Add(this.MonoFlat_Label1);
            this.Controls.Add(this.dtdatos);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtdatos)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ContextMenuCancelar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        internal ContextMenuStrip ContextMenuCancelar;
        internal ToolStripMenuItem CancelarToolStripMenuItem;
        internal System.ComponentModel.BackgroundWorker BackgroundCancelar;
        internal Button Button1;
    }
}