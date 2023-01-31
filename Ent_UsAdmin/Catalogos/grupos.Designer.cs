using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class grupos : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(grupos));
            Panel1 = new Panel();
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            txtfiltro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Combofiltro = new ComboBox();
            Combofiltro.SelectedIndexChanged += new EventHandler(Combofiltro_SelectedIndexChanged);
            EvolveControlBox1 = new EvolveControlBox();
            dtgrupos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtgrupos.CellContentClick += new DataGridViewCellEventHandler(dtgrupos_CellContentClick);
            dtgrupos.CellContentDoubleClick += new DataGridViewCellEventHandler(dtgrupos_CellContentDoubleClick);
            id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            btn_agregar = new Button();
            btn_agregar.Click += new EventHandler(btn_agregar_Click);
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrupos).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Controls.Add(MonoFlat_Label1);
            Panel1.Controls.Add(txtfiltro);
            Panel1.Controls.Add(Combofiltro);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(560, 36);
            Panel1.TabIndex = 0;
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel1.Location = new Point(12, 3);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(60, 20);
            MonoFlat_HeaderLabel1.TabIndex = 2;
            MonoFlat_HeaderLabel1.Text = "Grupos";
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(116, 125, 132);
            MonoFlat_Label1.Location = new Point(136, 9);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(73, 15);
            MonoFlat_Label1.TabIndex = 5;
            MonoFlat_Label1.Text = "Mostrar sólo";
            // 
            // txtfiltro
            // 
            txtfiltro.Cursor = Cursors.IBeam;
            txtfiltro.Font = new Font("Century Gothic", 9.75f);
            txtfiltro.ForeColor = Color.White;
            txtfiltro.HintForeColor = Color.White;
            txtfiltro.HintText = "";
            txtfiltro.isPassword = false;
            txtfiltro.LineFocusedColor = Color.Blue;
            txtfiltro.LineIdleColor = Color.Gray;
            txtfiltro.LineMouseHoverColor = Color.Blue;
            txtfiltro.LineThickness = 3;
            txtfiltro.Location = new Point(343, 3);
            txtfiltro.Margin = new Padding(4);
            txtfiltro.Name = "txtfiltro";
            txtfiltro.Size = new Size(111, 25);
            txtfiltro.TabIndex = 4;
            txtfiltro.TextAlign = HorizontalAlignment.Left;
            // 
            // Combofiltro
            // 
            Combofiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            Combofiltro.FormattingEnabled = true;
            Combofiltro.Location = new Point(215, 5);
            Combofiltro.Name = "Combofiltro";
            Combofiltro.Size = new Size(121, 21);
            Combofiltro.TabIndex = 6;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(491, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 1;
            EvolveControlBox1.Text = "EvolveControlBox1";
            EvolveControlBox1.Transparent = false;
            // 
            // dtgrupos
            // 
            dtgrupos.AllowUserToAddRows = false;
            dtgrupos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dtgrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            dtgrupos.BackgroundColor = Color.Gainsboro;
            dtgrupos.BorderStyle = BorderStyle.None;
            dtgrupos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle2.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dtgrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgrupos.Columns.AddRange(new DataGridViewColumn[] { id, Codigo, Nombre });
            dtgrupos.DoubleBuffered = true;
            dtgrupos.EnableHeadersVisualStyles = false;
            dtgrupos.HeaderBgColor = Color.DarkSlateGray;
            dtgrupos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtgrupos.Location = new Point(58, 42);
            dtgrupos.Name = "dtgrupos";
            dtgrupos.ReadOnly = true;
            dtgrupos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgrupos.RowHeadersVisible = false;
            dtgrupos.Size = new Size(442, 274);
            dtgrupos.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 341;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(233, 233, 233);
            btn_agregar.BackgroundImage = My.Resources.Resources.grupos_agregar;
            btn_agregar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.Silver;
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 246, 245);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(12, 42);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(40, 35);
            btn_agregar.TabIndex = 2;
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // grupos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(561, 321);
            Controls.Add(btn_agregar);
            Controls.Add(dtgrupos);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "grupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupos";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgrupos).EndInit();
            Load += new EventHandler(grupos_Load);
            ResumeLayout(false);

        }
        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtgrupos;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox txtfiltro;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal ComboBox Combofiltro;
        internal Button btn_agregar;
        internal DataGridViewTextBoxColumn id;
        internal DataGridViewTextBoxColumn Codigo;
        internal DataGridViewTextBoxColumn Nombre;
    }
}