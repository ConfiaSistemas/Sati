using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]

    public partial class SolicitudesEmpeños : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesEmpeños));
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtimpuestos.SelectionChanged += new EventHandler(dtimpuestos_SelectionChanged);
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            MontoAutorizado = new DataGridViewTextBoxColumn();
            TipoCredito = new DataGridViewTextBoxColumn();
            Promotor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            Panel1 = new Panel();
            BunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            BunifuMaterialTextbox1.KeyDown += new KeyEventHandler(BunifuMaterialTextbox1_KeyDown);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            Combofiltro = new ComboBox();
            Combofiltro.SelectedIndexChanged += new EventHandler(Combofiltro_SelectedIndexChanged);
            ContextMenuVerificar = new ContextMenuStrip(components);
            VerificarToolStripMenuItem = new ToolStripMenuItem();
            VerificarToolStripMenuItem.Click += new EventHandler(VerificarToolStripMenuItem_Click);
            VerHistoriaToolStripMenuItem = new ToolStripMenuItem();
            VerHistoriaToolStripMenuItem.Click += new EventHandler(VerHistoriaToolStripMenuItem_Click);
            ContextMenuIncompleto = new ContextMenuStrip(components);
            SeguimientoToolStripMenuItem = new ToolStripMenuItem();
            SeguimientoToolStripMenuItem.Click += new EventHandler(SeguimientoToolStripMenuItem_Click);
            ContextMenuAprobado = new ContextMenuStrip(components);
            ToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem2.Click += new EventHandler(ToolStripMenuItem2_Click);
            VerSolicitudToolStripMenuItem = new ToolStripMenuItem();
            VerSolicitudToolStripMenuItem.Click += new EventHandler(VerSolicitudToolStripMenuItem_Click);
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            Panel1.SuspendLayout();
            ContextMenuVerificar.SuspendLayout();
            ContextMenuIncompleto.SuspendLayout();
            ContextMenuAprobado.SuspendLayout();
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
            dtimpuestos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Fecha, Monto, MontoAutorizado, TipoCredito, Promotor, Estado, Tipo });
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(60, 44);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(705, 446);
            dtimpuestos.TabIndex = 4;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 79;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 68;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 70;
            // 
            // MontoAutorizado
            // 
            MontoAutorizado.HeaderText = "Monto Autorizado";
            MontoAutorizado.Name = "MontoAutorizado";
            MontoAutorizado.ReadOnly = true;
            MontoAutorizado.Width = 126;
            // 
            // TipoCredito
            // 
            TipoCredito.HeaderText = "Tipo";
            TipoCredito.Name = "TipoCredito";
            TipoCredito.ReadOnly = true;
            TipoCredito.Width = 55;
            // 
            // Promotor
            // 
            Promotor.HeaderText = "Promotor";
            Promotor.Name = "Promotor";
            Promotor.ReadOnly = true;
            Promotor.Width = 86;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 71;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Visible = false;
            Tipo.Width = 55;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(152, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Solicitudes Empeños";
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(BunifuMaterialTextbox1);
            Panel1.Controls.Add(BunifuThinButton21);
            Panel1.Controls.Add(MonoFlat_Label1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(Combofiltro);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(764, 36);
            Panel1.TabIndex = 5;
            // 
            // BunifuMaterialTextbox1
            // 
            BunifuMaterialTextbox1.Cursor = Cursors.IBeam;
            BunifuMaterialTextbox1.Font = new Font("Century Gothic", 9.75f);
            BunifuMaterialTextbox1.ForeColor = Color.White;
            BunifuMaterialTextbox1.HintForeColor = Color.White;
            BunifuMaterialTextbox1.HintText = "";
            BunifuMaterialTextbox1.isPassword = false;
            BunifuMaterialTextbox1.LineFocusedColor = Color.Blue;
            BunifuMaterialTextbox1.LineIdleColor = Color.Gray;
            BunifuMaterialTextbox1.LineMouseHoverColor = Color.Blue;
            BunifuMaterialTextbox1.LineThickness = 3;
            BunifuMaterialTextbox1.Location = new Point(438, 3);
            BunifuMaterialTextbox1.Margin = new Padding(4);
            BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1";
            BunifuMaterialTextbox1.Size = new Size(152, 25);
            BunifuMaterialTextbox1.TabIndex = 7;
            BunifuMaterialTextbox1.TextAlign = HorizontalAlignment.Left;
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
            BunifuThinButton21.Location = new Point(667, 3);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 4;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(249, 12);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(48, 15);
            MonoFlat_Label1.TabIndex = 8;
            MonoFlat_Label1.Text = "Mostrar";
            // 
            // Combofiltro
            // 
            Combofiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            Combofiltro.FormattingEnabled = true;
            Combofiltro.Items.AddRange(new object[] { "Por Nombre" });
            Combofiltro.Location = new Point(305, 8);
            Combofiltro.Name = "Combofiltro";
            Combofiltro.Size = new Size(121, 21);
            Combofiltro.TabIndex = 9;
            // 
            // ContextMenuVerificar
            // 
            ContextMenuVerificar.ImageScalingSize = new Size(24, 24);
            ContextMenuVerificar.Items.AddRange(new ToolStripItem[] { VerificarToolStripMenuItem, VerHistoriaToolStripMenuItem });
            ContextMenuVerificar.Name = "ContextMenuVerificar";
            ContextMenuVerificar.Size = new Size(135, 48);
            // 
            // VerificarToolStripMenuItem
            // 
            VerificarToolStripMenuItem.Name = "VerificarToolStripMenuItem";
            VerificarToolStripMenuItem.Size = new Size(134, 22);
            VerificarToolStripMenuItem.Text = "Verificar";
            // 
            // VerHistoriaToolStripMenuItem
            // 
            VerHistoriaToolStripMenuItem.Name = "VerHistoriaToolStripMenuItem";
            VerHistoriaToolStripMenuItem.Size = new Size(134, 22);
            VerHistoriaToolStripMenuItem.Text = "Ver Historia";
            // 
            // ContextMenuIncompleto
            // 
            ContextMenuIncompleto.ImageScalingSize = new Size(24, 24);
            ContextMenuIncompleto.Items.AddRange(new ToolStripItem[] { SeguimientoToolStripMenuItem });
            ContextMenuIncompleto.Name = "ContextMenuIncompleto";
            ContextMenuIncompleto.Size = new Size(142, 26);
            // 
            // SeguimientoToolStripMenuItem
            // 
            SeguimientoToolStripMenuItem.Name = "SeguimientoToolStripMenuItem";
            SeguimientoToolStripMenuItem.Size = new Size(141, 22);
            SeguimientoToolStripMenuItem.Text = "Seguimiento";
            // 
            // ContextMenuAprobado
            // 
            ContextMenuAprobado.ImageScalingSize = new Size(24, 24);
            ContextMenuAprobado.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem2, VerSolicitudToolStripMenuItem });
            ContextMenuAprobado.Name = "ContextMenuIncompleto";
            ContextMenuAprobado.Size = new Size(140, 48);
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(139, 22);
            ToolStripMenuItem2.Text = "Ver historia";
            // 
            // VerSolicitudToolStripMenuItem
            // 
            VerSolicitudToolStripMenuItem.Name = "VerSolicitudToolStripMenuItem";
            VerSolicitudToolStripMenuItem.Size = new Size(139, 22);
            VerSolicitudToolStripMenuItem.Text = "Ver Solicitud";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(233, 233, 233);
            btn_agregar.BackgroundImage = My.Resources.Resources.impuestos_mas;
            btn_agregar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 246, 245);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(12, 53);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(40, 35);
            btn_agregar.TabIndex = 6;
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // SolicitudesEmpeños
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(767, 493);
            Controls.Add(btn_agregar);
            Controls.Add(dtimpuestos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SolicitudesEmpeños";
            Text = "Solicitudes";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ContextMenuVerificar.ResumeLayout(false);
            ContextMenuIncompleto.ResumeLayout(false);
            ContextMenuAprobado.ResumeLayout(false);
            Load += new EventHandler(Solicitudes_Load);
            ResumeLayout(false);

        }

        internal Button btn_agregar;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Panel Panel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal ContextMenuStrip ContextMenuVerificar;
        internal ToolStripMenuItem VerificarToolStripMenuItem;
        internal ContextMenuStrip ContextMenuIncompleto;
        internal ToolStripMenuItem SeguimientoToolStripMenuItem;
        internal ContextMenuStrip ContextMenuAprobado;
        internal ToolStripMenuItem ToolStripMenuItem2;
        internal ToolStripMenuItem VerSolicitudToolStripMenuItem;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox BunifuMaterialTextbox1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal ComboBox Combofiltro;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn Monto;
        internal DataGridViewTextBoxColumn MontoAutorizado;
        internal DataGridViewTextBoxColumn TipoCredito;
        internal DataGridViewTextBoxColumn Promotor;
        internal DataGridViewTextBoxColumn Estado;
        internal DataGridViewTextBoxColumn Tipo;
        internal ToolStripMenuItem VerHistoriaToolStripMenuItem;
    }
}