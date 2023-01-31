using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]


    public partial class CreditosEnLegal : Form
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
            components = new System.ComponentModel.Container();
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditosEnLegal));
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtimpuestos.CellContentClick += new DataGridViewCellEventHandler(dtimpuestos_CellContentClick);
            dtimpuestos.SelectionChanged += new EventHandler(dtimpuestos_SelectionChanged);
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TotalDeuda = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Gestor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ContextMenuEntregar = new ContextMenuStrip(components);
            EntregarToolStripMenuItem = new ToolStripMenuItem();
            EntregarToolStripMenuItem.Click += new EventHandler(EntregarToolStripMenuItem_Click);
            InformacionToolStripMenuItem = new ToolStripMenuItem();
            InformacionToolStripMenuItem.Click += new EventHandler(InformacionToolStripMenuItem_Click);
            CrearPromesaDePagoToolStripMenuItem = new ToolStripMenuItem();
            CrearPromesaDePagoToolStripMenuItem.Click += new EventHandler(CrearPromesaDePagoToolStripMenuItem_Click);
            ContextMenuInformacion = new ContextMenuStrip(components);
            ToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem2.Click += new EventHandler(ToolStripMenuItem2_Click);
            Panel1 = new Panel();
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click_1);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel1.Click += new EventHandler(MonoFlat_HeaderLabel1_Click);
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtnombre.OnValueChanged += new EventHandler(txtnombre_OnValueChanged);
            txtnombre.KeyDown += new KeyEventHandler(txtnombre_KeyDown);
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            DescuentoBuenFinToolStripMenuItem = new ToolStripMenuItem();
            DescuentoBuenFinToolStripMenuItem.Click += new EventHandler(DescuentoBuenFinToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            ContextMenuEntregar.SuspendLayout();
            ContextMenuInformacion.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
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
            dtimpuestos.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Nombre, TotalDeuda, Tipo, Gestor, Estado });
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(7, 48);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(974, 501);
            dtimpuestos.TabIndex = 6;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 68;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 79;
            // 
            // TotalDeuda
            // 
            TotalDeuda.HeaderText = "Total Deuda";
            TotalDeuda.Name = "TotalDeuda";
            TotalDeuda.ReadOnly = true;
            TotalDeuda.Width = 103;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 55;
            // 
            // Gestor
            // 
            Gestor.HeaderText = "Gestor";
            Gestor.Name = "Gestor";
            Gestor.ReadOnly = true;
            Gestor.Width = 71;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 71;
            // 
            // ContextMenuEntregar
            // 
            ContextMenuEntregar.Items.AddRange(new ToolStripItem[] { EntregarToolStripMenuItem, InformacionToolStripMenuItem, CrearPromesaDePagoToolStripMenuItem, DescuentoBuenFinToolStripMenuItem });
            ContextMenuEntregar.Name = "ContextMenuEntregar";
            ContextMenuEntregar.Size = new Size(198, 114);
            // 
            // EntregarToolStripMenuItem
            // 
            EntregarToolStripMenuItem.Name = "EntregarToolStripMenuItem";
            EntregarToolStripMenuItem.Size = new Size(197, 22);
            EntregarToolStripMenuItem.Text = "Crear Convenio";
            // 
            // InformacionToolStripMenuItem
            // 
            InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem";
            InformacionToolStripMenuItem.Size = new Size(197, 22);
            InformacionToolStripMenuItem.Text = "Ver Información";
            // 
            // CrearPromesaDePagoToolStripMenuItem
            // 
            CrearPromesaDePagoToolStripMenuItem.Name = "CrearPromesaDePagoToolStripMenuItem";
            CrearPromesaDePagoToolStripMenuItem.Size = new Size(197, 22);
            CrearPromesaDePagoToolStripMenuItem.Text = "Crear Promesa de Pago";
            // 
            // ContextMenuInformacion
            // 
            ContextMenuInformacion.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem2 });
            ContextMenuInformacion.Name = "ContextMenuEntregar";
            ContextMenuInformacion.Size = new Size(159, 26);
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(158, 22);
            ToolStripMenuItem2.Text = "Ver Información";
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(txtnombre);
            Panel1.Controls.Add(MonoFlat_Label1);
            Panel1.Location = new Point(1, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(992, 41);
            Panel1.TabIndex = 12;
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
            BunifuThinButton21.ButtonText = "Actualizar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(873, 8);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 28);
            BunifuThinButton21.TabIndex = 11;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(129, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Créditos en Legal";
            // 
            // txtnombre
            // 
            txtnombre.Cursor = Cursors.IBeam;
            txtnombre.Font = new Font("Century Gothic", 9.75f);
            txtnombre.ForeColor = Color.White;
            txtnombre.HintForeColor = Color.White;
            txtnombre.HintText = "";
            txtnombre.isPassword = false;
            txtnombre.LineFocusedColor = Color.Blue;
            txtnombre.LineIdleColor = Color.Gray;
            txtnombre.LineMouseHoverColor = Color.Blue;
            txtnombre.LineThickness = 3;
            txtnombre.Location = new Point(274, 7);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(232, 25);
            txtnombre.TabIndex = 9;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(164, 17);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(103, 15);
            MonoFlat_Label1.TabIndex = 10;
            MonoFlat_Label1.Text = "Filtrar por nombre";
            // 
            // DescuentoBuenFinToolStripMenuItem
            // 
            DescuentoBuenFinToolStripMenuItem.Name = "DescuentoBuenFinToolStripMenuItem";
            DescuentoBuenFinToolStripMenuItem.Size = new Size(197, 22);
            DescuentoBuenFinToolStripMenuItem.Text = "Descuento Buen Fin";
            // 
            // CreditosEnLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(993, 555);
            Controls.Add(Panel1);
            Controls.Add(dtimpuestos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreditosEnLegal";
            Text = "CreditosPorEntregar";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            ContextMenuEntregar.ResumeLayout(false);
            ContextMenuInformacion.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(CreditosPorEntregar_Load);
            ResumeLayout(false);

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal ContextMenuStrip ContextMenuEntregar;
        internal ToolStripMenuItem EntregarToolStripMenuItem;
        internal ToolStripMenuItem InformacionToolStripMenuItem;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn TotalDeuda;
        internal DataGridViewTextBoxColumn Tipo;
        internal DataGridViewTextBoxColumn Gestor;
        internal DataGridViewTextBoxColumn Estado;
        internal ContextMenuStrip ContextMenuInformacion;
        internal ToolStripMenuItem ToolStripMenuItem2;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal ToolStripMenuItem CrearPromesaDePagoToolStripMenuItem;
        internal ToolStripMenuItem DescuentoBuenFinToolStripMenuItem;
    }
}