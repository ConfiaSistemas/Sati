using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class GestionesLegal : Form
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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionesLegal));
            dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            BackgroundGestiones = new System.ComponentModel.BackgroundWorker();
            BackgroundGestiones.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGestiones_DoWork);
            BackgroundGestiones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGestiones_RunWorkerCompleted);
            Fecha = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).BeginInit();
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
            dtimpuestos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            dtimpuestos.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, Usuario });
            dtimpuestos.DoubleBuffered = true;
            dtimpuestos.EnableHeadersVisualStyles = false;
            dtimpuestos.HeaderBgColor = Color.DarkSlateGray;
            dtimpuestos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtimpuestos.Location = new Point(12, 72);
            dtimpuestos.Name = "dtimpuestos";
            dtimpuestos.ReadOnly = true;
            dtimpuestos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtimpuestos.RowHeadersVisible = false;
            dtimpuestos.ScrollBars = ScrollBars.None;
            dtimpuestos.Size = new Size(631, 383);
            dtimpuestos.TabIndex = 5;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(2, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(650, 36);
            Panel1.TabIndex = 7;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(581, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 2;
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
            MonoFlat_HeaderLabel1.Size = new Size(162, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Historial de Gestiones";
            // 
            // BackgroundGestiones
            // 
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Resizable = DataGridViewTriState.False;
            Fecha.Width = 68;
            // 
            // Concepto
            // 
            Concepto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Concepto.DefaultCellStyle = DataGridViewCellStyle3;
            Concepto.HeaderText = "Concepto";
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 74;
            // 
            // GestionesLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(655, 467);
            Controls.Add(Panel1);
            Controls.Add(dtimpuestos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestionesLegal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Gestiones";
            ((System.ComponentModel.ISupportInitialize)dtimpuestos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Retiros_Load);
            ResumeLayout(false);

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal System.ComponentModel.BackgroundWorker BackgroundGestiones;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn Concepto;
        internal DataGridViewTextBoxColumn Usuario;
    }
}