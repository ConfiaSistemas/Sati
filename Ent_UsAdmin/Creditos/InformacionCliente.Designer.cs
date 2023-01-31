using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InformacionCliente : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionCliente));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dtSolicitud = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.dtCredito = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BackgroundSolicitud = new System.ComponentModel.BackgroundWorker();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel3 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblfecha = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel7 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblnombre = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lbltelefono = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblcelular = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundCreditos = new System.ComponentModel.BackgroundWorker();
            this.MonoFlat_HeaderLabel4 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblfechanacimiento = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel5 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundDatos = new System.ComponentModel.BackgroundWorker();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitud)).BeginInit();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.Panel1.Controls.Add(this.EvolveControlBox1);
            this.Panel1.Controls.Add(this.MonoFlat_HeaderLabel1);
            this.Panel1.Location = new System.Drawing.Point(1, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1094, 36);
            this.Panel1.TabIndex = 4;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // EvolveControlBox1
            // 
            this.EvolveControlBox1.Colors = new ConfiaAdmin.Bloom[0];
            this.EvolveControlBox1.Customization = "";
            this.EvolveControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.EvolveControlBox1.Image = null;
            this.EvolveControlBox1.Location = new System.Drawing.Point(1025, 3);
            this.EvolveControlBox1.MaxButton = false;
            this.EvolveControlBox1.MinButton = true;
            this.EvolveControlBox1.Name = "EvolveControlBox1";
            this.EvolveControlBox1.NoRounding = false;
            this.EvolveControlBox1.Size = new System.Drawing.Size(66, 16);
            this.EvolveControlBox1.TabIndex = 31;
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
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(166, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Información de cliente";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Location = new System.Drawing.Point(8, 319);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1084, 328);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage2.Controls.Add(this.dtSolicitud);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1076, 302);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Solicitud";
            // 
            // dtSolicitud
            // 
            this.dtSolicitud.AllowUserToAddRows = false;
            this.dtSolicitud.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtSolicitud.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.Fecha,
            this.Nombre,
            this.DataGridViewTextBoxColumn2,
            this.Monto,
            this.Tipo});
            this.dtSolicitud.DoubleBuffered = true;
            this.dtSolicitud.EnableHeadersVisualStyles = false;
            this.dtSolicitud.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtSolicitud.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtSolicitud.Location = new System.Drawing.Point(6, 6);
            this.dtSolicitud.Name = "dtSolicitud";
            this.dtSolicitud.ReadOnly = true;
            this.dtSolicitud.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtSolicitud.RowHeadersVisible = false;
            this.dtSolicitud.Size = new System.Drawing.Size(1066, 290);
            this.dtSolicitud.TabIndex = 5;
            this.dtSolicitud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSolicitud_CellContentClick);
            this.dtSolicitud.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSolicitud_CellDoubleClick);
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.dtCredito);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1076, 302);
            this.TabPage1.TabIndex = 4;
            this.TabPage1.Text = "Créditos";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // dtCredito
            // 
            this.dtCredito.AllowUserToAddRows = false;
            this.dtCredito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCredito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtCredito.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn7});
            this.dtCredito.DoubleBuffered = true;
            this.dtCredito.EnableHeadersVisualStyles = false;
            this.dtCredito.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtCredito.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtCredito.Location = new System.Drawing.Point(5, 6);
            this.dtCredito.Name = "dtCredito";
            this.dtCredito.ReadOnly = true;
            this.dtCredito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtCredito.RowHeadersVisible = false;
            this.dtCredito.Size = new System.Drawing.Size(1066, 290);
            this.dtCredito.TabIndex = 6;
            this.dtCredito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCredito_CellDoubleClick);
            // 
            // BackgroundSolicitud
            // 
            this.BackgroundSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSolicitud_DoWork);
            this.BackgroundSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundSolicitud_RunWorkerCompleted);
            // 
            // MonoFlat_HeaderLabel2
            // 
            this.MonoFlat_HeaderLabel2.AutoSize = true;
            this.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel2.Location = new System.Drawing.Point(14, 54);
            this.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            this.MonoFlat_HeaderLabel2.Size = new System.Drawing.Size(67, 20);
            this.MonoFlat_HeaderLabel2.TabIndex = 32;
            this.MonoFlat_HeaderLabel2.Text = "Nombre";
            // 
            // MonoFlat_HeaderLabel3
            // 
            this.MonoFlat_HeaderLabel3.AutoSize = true;
            this.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel3.Location = new System.Drawing.Point(432, 54);
            this.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            this.MonoFlat_HeaderLabel3.Size = new System.Drawing.Size(100, 20);
            this.MonoFlat_HeaderLabel3.TabIndex = 33;
            this.MonoFlat_HeaderLabel3.Text = "Fecha de alta";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblfecha.Location = new System.Drawing.Point(432, 80);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(13, 20);
            this.lblfecha.TabIndex = 35;
            this.lblfecha.Text = ".";
            // 
            // MonoFlat_HeaderLabel7
            // 
            this.MonoFlat_HeaderLabel7.AutoSize = true;
            this.MonoFlat_HeaderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel7.Location = new System.Drawing.Point(432, 129);
            this.MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7";
            this.MonoFlat_HeaderLabel7.Size = new System.Drawing.Size(57, 20);
            this.MonoFlat_HeaderLabel7.TabIndex = 37;
            this.MonoFlat_HeaderLabel7.Text = "Celular";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblnombre.Location = new System.Drawing.Point(14, 80);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(13, 20);
            this.lblnombre.TabIndex = 38;
            this.lblnombre.Text = ".";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbltelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltelefono.Location = new System.Drawing.Point(15, 159);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(13, 20);
            this.lbltelefono.TabIndex = 40;
            this.lbltelefono.Text = ".";
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.BackColor = System.Drawing.Color.Transparent;
            this.lblcelular.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblcelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblcelular.Location = new System.Drawing.Point(432, 159);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(13, 20);
            this.lblcelular.TabIndex = 41;
            this.lblcelular.Text = ".";
            // 
            // BackgroundCreditos
            // 
            this.BackgroundCreditos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCreditos_DoWork);
            this.BackgroundCreditos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCreditos_RunWorkerCompleted);
            // 
            // MonoFlat_HeaderLabel4
            // 
            this.MonoFlat_HeaderLabel4.AutoSize = true;
            this.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel4.Location = new System.Drawing.Point(772, 54);
            this.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            this.MonoFlat_HeaderLabel4.Size = new System.Drawing.Size(152, 20);
            this.MonoFlat_HeaderLabel4.TabIndex = 34;
            this.MonoFlat_HeaderLabel4.Text = "Fecha de nacimiento";
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblfechanacimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblfechanacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblfechanacimiento.Location = new System.Drawing.Point(772, 80);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(13, 20);
            this.lblfechanacimiento.TabIndex = 39;
            this.lblfechanacimiento.Text = ".";
            // 
            // MonoFlat_HeaderLabel5
            // 
            this.MonoFlat_HeaderLabel5.AutoSize = true;
            this.MonoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel5.Location = new System.Drawing.Point(21, 129);
            this.MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            this.MonoFlat_HeaderLabel5.Size = new System.Drawing.Size(70, 20);
            this.MonoFlat_HeaderLabel5.TabIndex = 42;
            this.MonoFlat_HeaderLabel5.Text = "Teléfono";
            // 
            // BackgroundDatos
            // 
            this.BackgroundDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDatos_DoWork);
            this.BackgroundDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDatos_RunWorkerCompleted);
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "Credito";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 76;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Fecha de Entrega";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 124;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Width = 79;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText = "Monto";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            this.DataGridViewTextBoxColumn6.Width = 70;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.HeaderText = "Tipo";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly = true;
            this.DataGridViewTextBoxColumn8.Visible = false;
            this.DataGridViewTextBoxColumn8.Width = 55;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            this.DataGridViewTextBoxColumn7.Width = 71;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Solicitud";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 83;
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
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "Monto Solicitado";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 122;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto Autorizado";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 126;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Visible = false;
            this.Tipo.Width = 55;
            // 
            // InformacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1096, 687);
            this.Controls.Add(this.MonoFlat_HeaderLabel5);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.MonoFlat_HeaderLabel7);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.MonoFlat_HeaderLabel4);
            this.Controls.Add(this.MonoFlat_HeaderLabel3);
            this.Controls.Add(this.MonoFlat_HeaderLabel2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformacionCliente";
            this.Text = "Información de crédito";
            this.Load += new System.EventHandler(this.InformacionSolicitud_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitud)).EndInit();
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal TabControl TabControl1;
        internal TabPage TabPage2;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundSolicitud;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel lblfecha;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel7;
        internal MonoFlat.MonoFlat_HeaderLabel lblnombre;
        internal MonoFlat.MonoFlat_HeaderLabel lbltelefono;
        internal MonoFlat.MonoFlat_HeaderLabel lblcelular;
        internal TabPage TabPage1;
        internal System.ComponentModel.BackgroundWorker BackgroundCreditos;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtCredito;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal MonoFlat.MonoFlat_HeaderLabel lblfechanacimiento;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal System.ComponentModel.BackgroundWorker BackgroundDatos;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
    }
}