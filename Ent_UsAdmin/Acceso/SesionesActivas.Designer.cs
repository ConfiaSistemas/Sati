using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]


    public partial class SesionesActivas : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SesionesActivas));
            dtdatos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatos.SelectionChanged += new EventHandler(dtdatos_SelectionChanged);
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            txtnombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            txtnombre.KeyDown += new KeyEventHandler(txtnombre_KeyDown);
            Label1 = new Label();
            BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
            ContextCerrarSesion = new ContextMenuStrip(components);
            CerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            CerrarSesiónToolStripMenuItem.Click += new EventHandler(CerrarSesiónToolStripMenuItem_Click);
            BackgroundCerrarSesion = new System.ComponentModel.BackgroundWorker();
            BackgroundCerrarSesion.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCerrarSesion_DoWork);
            BackgroundCerrarSesion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCerrarSesion_RunWorkerCompleted);
            ((System.ComponentModel.ISupportInitialize)dtdatos).BeginInit();
            Panel1.SuspendLayout();
            ContextCerrarSesion.SuspendLayout();
            SuspendLayout();
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
            dtdatos.DoubleBuffered = true;
            dtdatos.EnableHeadersVisualStyles = false;
            dtdatos.HeaderBgColor = Color.DarkSlateGray;
            dtdatos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatos.Location = new Point(3, 52);
            dtdatos.Name = "dtdatos";
            dtdatos.ReadOnly = true;
            dtdatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatos.RowHeadersVisible = false;
            dtdatos.Size = new Size(677, 303);
            dtdatos.TabIndex = 25;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(3, 1);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(679, 36);
            Panel1.TabIndex = 26;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(627, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = false;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(41, 16);
            EvolveControlBox1.TabIndex = 2;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = true;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(3, 4);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(124, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Sesiones Activas";
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
            txtnombre.Location = new Point(101, 393);
            txtnombre.Margin = new Padding(4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(309, 33);
            txtnombre.TabIndex = 0;
            txtnombre.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = SystemColors.Control;
            Label1.Location = new Point(12, 413);
            Label1.Name = "Label1";
            Label1.Size = new Size(79, 13);
            Label1.TabIndex = 28;
            Label1.Text = "Buscar Usuario";
            // 
            // BackgroundWorker1
            // 
            // 
            // ContextCerrarSesion
            // 
            ContextCerrarSesion.Items.AddRange(new ToolStripItem[] { CerrarSesiónToolStripMenuItem });
            ContextCerrarSesion.Name = "ContextCerrarSesion";
            ContextCerrarSesion.Size = new Size(144, 26);
            // 
            // CerrarSesiónToolStripMenuItem
            // 
            CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem";
            CerrarSesiónToolStripMenuItem.Size = new Size(143, 22);
            CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // BackgroundCerrarSesion
            // 
            // 
            // SesionesActivas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(683, 463);
            Controls.Add(txtnombre);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            Controls.Add(dtdatos);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SesionesActivas";
            Text = "BuscarClienteSolicitud";
            ((System.ComponentModel.ISupportInitialize)dtdatos).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ContextCerrarSesion.ResumeLayout(false);
            Load += new EventHandler(BuscarClienteSolicitud_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatos;
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtnombre;
        internal Label Label1;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal ContextMenuStrip ContextCerrarSesion;
        internal ToolStripMenuItem CerrarSesiónToolStripMenuItem;
        internal System.ComponentModel.BackgroundWorker BackgroundCerrarSesion;
    }
}