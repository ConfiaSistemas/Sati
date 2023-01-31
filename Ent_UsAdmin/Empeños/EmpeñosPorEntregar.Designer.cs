using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EmpeñosPorEntregar : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpeñosPorEntregar));
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtimpuestos.SelectionChanged += new EventHandler(dtimpuestos_SelectionChanged);
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            MontoRefrendo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ContextMenuEntregar = new ContextMenuStrip(components);
            EntregarToolStripMenuItem = new ToolStripMenuItem();
            EntregarToolStripMenuItem.Click += new EventHandler(EntregarToolStripMenuItem_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
            ContextMenuEntregar.SuspendLayout();
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
            dtimpuestos.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Nombre, Monto, MontoRefrendo, Estado });
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(12, 68);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.Size = new Size(969, 475);
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
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 70;
            // 
            // MontoRefrendo
            // 
            MontoRefrendo.HeaderText = "Monto Refrendo";
            MontoRefrendo.Name = "MontoRefrendo";
            MontoRefrendo.ReadOnly = true;
            MontoRefrendo.Width = 116;
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
            ContextMenuEntregar.Items.AddRange(new ToolStripItem[] { EntregarToolStripMenuItem });
            ContextMenuEntregar.Name = "ContextMenuEntregar";
            ContextMenuEntregar.Size = new Size(119, 26);
            // 
            // EntregarToolStripMenuItem
            // 
            EntregarToolStripMenuItem.Name = "EntregarToolStripMenuItem";
            EntregarToolStripMenuItem.Size = new Size(118, 22);
            EntregarToolStripMenuItem.Text = "Entregar";
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
            BunifuThinButton21.ButtonText = "Actualizar";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.SeaGreen;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.SeaGreen;
            BunifuThinButton21.IdleLineColor = Color.SeaGreen;
            BunifuThinButton21.Location = new Point(887, 14);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(92, 31);
            BunifuThinButton21.TabIndex = 7;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(12, 14);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(165, 20);
            MonoFlat_HeaderLabel1.TabIndex = 8;
            MonoFlat_HeaderLabel1.Text = "Empeños por Entregar";
            // 
            // EmpeñosPorEntregar
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(993, 555);
            Controls.Add(MonoFlat_HeaderLabel1);
            Controls.Add(BunifuThinButton21);
            Controls.Add(dtimpuestos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmpeñosPorEntregar";
            Text = "CreditosPorEntregar";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            ContextMenuEntregar.ResumeLayout(false);
            Load += new EventHandler(CreditosPorEntregar_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal ContextMenuStrip ContextMenuEntregar;
        internal ToolStripMenuItem EntregarToolStripMenuItem;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Monto;
        internal DataGridViewTextBoxColumn MontoRefrendo;
        internal DataGridViewTextBoxColumn Estado;
    }
}