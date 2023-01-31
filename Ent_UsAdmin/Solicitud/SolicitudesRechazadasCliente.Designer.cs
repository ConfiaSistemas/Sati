using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SolicitudesRechazadasCliente : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesRechazadasCliente));
            this.dtimpuestos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).BeginInit();
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
            this.Nombre,
            this.Fecha,
            this.Monto,
            this.Estado,
            this.Tipo});
            this.dtimpuestos.DoubleBuffered = true;
            this.dtimpuestos.EnableHeadersVisualStyles = false;
            this.dtimpuestos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtimpuestos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtimpuestos.Location = new System.Drawing.Point(12, 57);
            this.dtimpuestos.Name = "dtimpuestos";
            this.dtimpuestos.ReadOnly = true;
            this.dtimpuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtimpuestos.RowHeadersVisible = false;
            this.dtimpuestos.Size = new System.Drawing.Size(954, 469);
            this.dtimpuestos.TabIndex = 5;
            this.dtimpuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtimpuestos_CellContentClick);
            this.dtimpuestos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtimpuestos_CellContentDoubleClick);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(974, 36);
            this.Panel1.TabIndex = 6;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(908, 7);
            this.EvolveControlBox1.MaxButton = false;
            this.EvolveControlBox1.MinButton = true;
            this.EvolveControlBox1.Name = "EvolveControlBox1";
            this.EvolveControlBox1.NoRounding = false;
            this.EvolveControlBox1.Size = new System.Drawing.Size(66, 16);
            this.EvolveControlBox1.TabIndex = 2;
            this.EvolveControlBox1.Text = "EvolveControlBox1";
            this.EvolveControlBox1.Transparent = false;
            // 
            // MonoFlat_HeaderLabel1
            // 
            this.MonoFlat_HeaderLabel1.AutoSize = true;
            this.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel1.Location = new System.Drawing.Point(3, 3);
            this.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1";
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(171, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Solicitudes con rechazo";
            // 
            // Id
            // 
            this.Id.HeaderText = "Solicitud";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 83;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 79;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 68;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 71;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            this.Tipo.Width = 55;
            // 
            // SolicitudesRechazadasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(978, 538);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dtimpuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolicitudesRechazadasCliente";
            this.Text = "SolicitudesRechazadasCliente";
            this.Load += new System.EventHandler(this.SolicitudesRechazadasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtimpuestos)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtimpuestos;
        internal Panel Panel1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal EvolveControlBox EvolveControlBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Tipo;
    }
}