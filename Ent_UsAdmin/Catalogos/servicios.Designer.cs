using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class servicios : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(servicios));
            DataGridView1 = new DataGridView();
            lblmodificar = new MonoFlat.MonoFlat_Label();
            lblmodificar.MouseDown += new MouseEventHandler(lblmodificar_MouseDown);
            lblmodificar.MouseHover += new EventHandler(lblmodificar_MouseHover);
            lblmodificar.MouseLeave += new EventHandler(lblmodificar_MouseLeave);
            lblmodificar.MouseUp += new MouseEventHandler(lblmodificar_MouseUp);
            lbleliminar = new MonoFlat.MonoFlat_Label();
            lbleliminar.Click += new EventHandler(lbleliminar_Click);
            lbleliminar.MouseDown += new MouseEventHandler(lbleliminar_MouseDown);
            lbleliminar.MouseHover += new EventHandler(lbleliminar_MouseHover);
            lbleliminar.MouseLeave += new EventHandler(lbleliminar_MouseLeave);
            lbleliminar.MouseUp += new MouseEventHandler(lbleliminar_MouseUp);
            MonoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            MonoFlat_Label1.MouseClick += new MouseEventHandler(MonoFlat_Label1_MouseClick);
            MonoFlat_Label1.MouseDown += new MouseEventHandler(MonoFlat_Label1_MouseDown);
            MonoFlat_Label1.MouseUp += new MouseEventHandler(MonoFlat_Label1_MouseUp);
            MonoFlat_Label1.MouseHover += new EventHandler(MonoFlat_Label1_MouseHover);
            MonoFlat_Label1.MouseLeave += new EventHandler(MonoFlat_Label1_MouseLeave);
            MonoFlat_Label1.Click += new EventHandler(MonoFlat_Label1_Click);
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(2, 74);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(535, 289);
            DataGridView1.TabIndex = 1;
            // 
            // lblmodificar
            // 
            lblmodificar.AutoEllipsis = true;
            lblmodificar.AutoSize = true;
            lblmodificar.BackColor = Color.Transparent;
            lblmodificar.FlatStyle = FlatStyle.Flat;
            lblmodificar.Font = new Font("Segoe UI", 9.0f);
            lblmodificar.ForeColor = Color.FromArgb(64, 64, 64);
            lblmodificar.Image = My.Resources.Resources.modificar;
            lblmodificar.ImageAlign = ContentAlignment.MiddleLeft;
            lblmodificar.Location = new Point(102, 34);
            lblmodificar.Name = "lblmodificar";
            lblmodificar.Size = new Size(73, 15);
            lblmodificar.TabIndex = 4;
            lblmodificar.Text = "     Modificar";
            // 
            // lbleliminar
            // 
            lbleliminar.AutoEllipsis = true;
            lbleliminar.AutoSize = true;
            lbleliminar.BackColor = Color.Transparent;
            lbleliminar.FlatStyle = FlatStyle.Flat;
            lbleliminar.Font = new Font("Segoe UI", 9.0f);
            lbleliminar.ForeColor = Color.FromArgb(64, 64, 64);
            lbleliminar.Image = My.Resources.Resources.eliminar;
            lbleliminar.ImageAlign = ContentAlignment.MiddleLeft;
            lbleliminar.Location = new Point(187, 34);
            lbleliminar.Name = "lbleliminar";
            lbleliminar.Size = new Size(68, 15);
            lbleliminar.TabIndex = 3;
            lbleliminar.Text = "      Eliminar";
            // 
            // MonoFlat_Label1
            // 
            MonoFlat_Label1.AutoEllipsis = true;
            MonoFlat_Label1.AutoSize = true;
            MonoFlat_Label1.BackColor = Color.Transparent;
            MonoFlat_Label1.FlatStyle = FlatStyle.Flat;
            MonoFlat_Label1.Font = new Font("Segoe UI", 9.0f);
            MonoFlat_Label1.ForeColor = Color.FromArgb(64, 64, 64);
            MonoFlat_Label1.Image = My.Resources.Resources.mas2;
            MonoFlat_Label1.ImageAlign = ContentAlignment.MiddleLeft;
            MonoFlat_Label1.Location = new Point(22, 34);
            MonoFlat_Label1.Name = "MonoFlat_Label1";
            MonoFlat_Label1.Size = new Size(64, 15);
            MonoFlat_Label1.TabIndex = 2;
            MonoFlat_Label1.Text = "     Agregar";
            // 
            // MonoFlat_HeaderLabel1
            // 
            MonoFlat_HeaderLabel1.AutoSize = true;
            MonoFlat_HeaderLabel1.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel1.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel1.ForeColor = Color.Red;
            MonoFlat_HeaderLabel1.Location = new Point(-2, -2);
            MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            MonoFlat_HeaderLabel1.Size = new Size(71, 20);
            MonoFlat_HeaderLabel1.TabIndex = 0;
            MonoFlat_HeaderLabel1.Text = "Servicios";
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 363);
            Controls.Add(lblmodificar);
            Controls.Add(lbleliminar);
            Controls.Add(MonoFlat_Label1);
            Controls.Add(DataGridView1);
            Controls.Add(MonoFlat_HeaderLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "servicios";
            Text = "servicios";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal DataGridView DataGridView1;
        internal MonoFlat.MonoFlat_Label MonoFlat_Label1;
        internal MonoFlat.MonoFlat_Label lbleliminar;
        internal MonoFlat.MonoFlat_Label lblmodificar;
    }
}