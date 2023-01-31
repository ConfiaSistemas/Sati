using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class CreditosActivos : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditosActivos));
            this.dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ContextMenuEntregar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EntregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearConvenioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearReestructuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PromesaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescuentoBuenFinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.craToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MonoFlat_Label1 = new ConfiaAdmin.MonoFlat.MonoFlat_Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).BeginInit();
            this.ContextMenuEntregar.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtimpuestos
            // 
            this.dtimpuestos.AllowUserToAddRows = false;
            this.dtimpuestos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtimpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtimpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtimpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtimpuestos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtimpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtimpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtimpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtimpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtimpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Nombre,
            this.Monto,
            this.Plazo,
            this.FechaEntrega,
            this.Estado});
            this.dtimpuestos.DoubleBuffered = true;
            this.dtimpuestos.EnableHeadersVisualStyles = false;
            this.dtimpuestos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtimpuestos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtimpuestos.Location = new System.Drawing.Point(12, 43);
            this.dtimpuestos.Name = "dtimpuestos";
            this.dtimpuestos.ReadOnly = true;
            this.dtimpuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtimpuestos.RowHeadersVisible = false;
            this.dtimpuestos.Size = new System.Drawing.Size(969, 500);
            this.dtimpuestos.TabIndex = 6;
            this.dtimpuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtimpuestos_CellContentClick);
            this.dtimpuestos.SelectionChanged += new System.EventHandler(this.dtimpuestos_SelectionChanged);
            // 
            // ContextMenuEntregar
            // 
            this.ContextMenuEntregar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntregarToolStripMenuItem,
            this.InformacionToolStripMenuItem,
            this.CrearConvenioToolStripMenuItem,
            this.CrearReestructuraToolStripMenuItem,
            this.EstadoDeCuentaToolStripMenuItem,
            this.PromesaDePagoToolStripMenuItem,
            this.DescuentoBuenFinToolStripMenuItem,
            this.craToolStripMenuItem});
            this.ContextMenuEntregar.Name = "ContextMenuEntregar";
            this.ContextMenuEntregar.Size = new System.Drawing.Size(222, 180);
            // 
            // EntregarToolStripMenuItem
            // 
            this.EntregarToolStripMenuItem.Name = "EntregarToolStripMenuItem";
            this.EntregarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.EntregarToolStripMenuItem.Text = "Reimprimir Documentación";
            this.EntregarToolStripMenuItem.Click += new System.EventHandler(this.EntregarToolStripMenuItem_Click);
            // 
            // InformacionToolStripMenuItem
            // 
            this.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem";
            this.InformacionToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.InformacionToolStripMenuItem.Text = "Ver Información";
            this.InformacionToolStripMenuItem.Click += new System.EventHandler(this.InformacionToolStripMenuItem_Click);
            // 
            // CrearConvenioToolStripMenuItem
            // 
            this.CrearConvenioToolStripMenuItem.Name = "CrearConvenioToolStripMenuItem";
            this.CrearConvenioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.CrearConvenioToolStripMenuItem.Text = "Crear Convenio";
            this.CrearConvenioToolStripMenuItem.Click += new System.EventHandler(this.CrearConvenioToolStripMenuItem_Click);
            // 
            // CrearReestructuraToolStripMenuItem
            // 
            this.CrearReestructuraToolStripMenuItem.Name = "CrearReestructuraToolStripMenuItem";
            this.CrearReestructuraToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.CrearReestructuraToolStripMenuItem.Text = "Crear Reestructura";
            this.CrearReestructuraToolStripMenuItem.Click += new System.EventHandler(this.CrearReestructuraToolStripMenuItem_Click);
            // 
            // EstadoDeCuentaToolStripMenuItem
            // 
            this.EstadoDeCuentaToolStripMenuItem.Name = "EstadoDeCuentaToolStripMenuItem";
            this.EstadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.EstadoDeCuentaToolStripMenuItem.Text = "Estado de Cuenta";
            this.EstadoDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.EstadoDeCuentaToolStripMenuItem_Click);
            // 
            // PromesaDePagoToolStripMenuItem
            // 
            this.PromesaDePagoToolStripMenuItem.Name = "PromesaDePagoToolStripMenuItem";
            this.PromesaDePagoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.PromesaDePagoToolStripMenuItem.Text = "Promesa de pago";
            this.PromesaDePagoToolStripMenuItem.Click += new System.EventHandler(this.PromesaDePagoToolStripMenuItem_Click);
            // 
            // DescuentoBuenFinToolStripMenuItem
            // 
            this.DescuentoBuenFinToolStripMenuItem.Name = "DescuentoBuenFinToolStripMenuItem";
            this.DescuentoBuenFinToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.DescuentoBuenFinToolStripMenuItem.Text = "Descuento Buen Fin";
            this.DescuentoBuenFinToolStripMenuItem.Click += new System.EventHandler(this.DescuentoBuenFinToolStripMenuItem_Click);
            // 
            // craToolStripMenuItem
            // 
            this.craToolStripMenuItem.Name = "craToolStripMenuItem";
            this.craToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.craToolStripMenuItem.Text = "Crear Convenio Terminal";
            this.craToolStripMenuItem.Click += new System.EventHandler(this.craToolStripMenuItem_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.White;
            this.txtnombre.HintForeColor = System.Drawing.Color.White;
            this.txtnombre.HintText = "";
            this.txtnombre.isPassword = false;
            this.txtnombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombre.LineThickness = 3;
            this.txtnombre.Location = new System.Drawing.Point(274, 7);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(217, 25);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnombre.OnValueChanged += new System.EventHandler(this.txtnombre_OnValueChanged);
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // MonoFlat_Label1
            // 
            this.MonoFlat_Label1.AutoSize = true;
            this.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.MonoFlat_Label1.Location = new System.Drawing.Point(164, 17);
            this.MonoFlat_Label1.Name = "MonoFlat_Label1";
            this.MonoFlat_Label1.Size = new System.Drawing.Size(103, 15);
            this.MonoFlat_Label1.TabIndex = 10;
            this.MonoFlat_Label1.Text = "Filtrar por nombre";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Controls.Add(this.BunifuThinButton21);
            this.Panel1.Controls.Add(this.txtnombre);
            this.Panel1.Controls.Add(this.MonoFlat_Label1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(992, 36);
            this.Panel1.TabIndex = 11;
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(3, 3);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(123, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Créditos Activos";
            this.MonoFlat_HeaderLabel1.Click += new System.EventHandler(this.MonoFlat_HeaderLabel1_Click);
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
            this.BunifuThinButton21.ButtonText = "Actualizar";
            this.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleBorderThickness = 1;
            this.BunifuThinButton21.IdleCornerRadius = 20;
            this.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.Location = new System.Drawing.Point(877, 5);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(92, 28);
            this.BunifuThinButton21.TabIndex = 7;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Credito";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 76;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 68;
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
            // Plazo
            // 
            this.Plazo.HeaderText = "Plazo";
            this.Plazo.Name = "Plazo";
            this.Plazo.ReadOnly = true;
            this.Plazo.Width = 62;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "FechaEntrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 114;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 71;
            // 
            // CreditosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(993, 555);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dtimpuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditosActivos";
            this.Text = "CreditosPorEntregar";
            this.Load += new System.EventHandler(this.CreditosPorEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).EndInit();
            this.ContextMenuEntregar.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal ContextMenuStrip ContextMenuEntregar;
        internal ToolStripMenuItem EntregarToolStripMenuItem;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal ToolStripMenuItem InformacionToolStripMenuItem;
        internal ToolStripMenuItem CrearConvenioToolStripMenuItem;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal ToolStripMenuItem EstadoDeCuentaToolStripMenuItem;
        internal ToolStripMenuItem CrearReestructuraToolStripMenuItem;
        internal ToolStripMenuItem PromesaDePagoToolStripMenuItem;
        internal ToolStripMenuItem DescuentoBuenFinToolStripMenuItem;
        private ToolStripMenuItem craToolStripMenuItem;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Plazo;
        private DataGridViewTextBoxColumn FechaEntrega;
        private DataGridViewTextBoxColumn Estado;
    }
}