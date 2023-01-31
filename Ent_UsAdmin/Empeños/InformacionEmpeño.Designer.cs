using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InformacionEmpeño : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionEmpeño));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.dtArticulos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dtSolicitud = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.TreeListView1 = new WinControls.ListView.TreeListView();
            this.ContainerColumnHeader1 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader2 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader3 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader10 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader9 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader4 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader5 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader6 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader7 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader8 = new WinControls.ListView.ContainerColumnHeader();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.dtActualizaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BackgroundArticulos = new System.ComponentModel.BackgroundWorker();
            this.BackgroundSolicitud = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel3 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel4 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblfecha = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel6 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel7 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblnombre = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblmonto = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblmontorefrendo = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lbltipo = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundPagos = new System.ComponentModel.BackgroundWorker();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregarDocumentos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundActualizaciones = new System.ComponentModel.BackgroundWorker();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulos)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitud)).BeginInit();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).BeginInit();
            this.TabPage5.SuspendLayout();
            this.TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtActualizaciones)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
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
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(181, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Información del Empeño";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Location = new System.Drawing.Point(8, 210);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1084, 437);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage1.Controls.Add(this.dtArticulos);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1076, 411);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Artículos";
            // 
            // dtArticulos
            // 
            this.dtArticulos.AllowUserToAddRows = false;
            this.dtArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtArticulos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtArticulos.DoubleBuffered = true;
            this.dtArticulos.EnableHeadersVisualStyles = false;
            this.dtArticulos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtArticulos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtArticulos.Location = new System.Drawing.Point(6, 6);
            this.dtArticulos.Name = "dtArticulos";
            this.dtArticulos.ReadOnly = true;
            this.dtArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtArticulos.RowHeadersVisible = false;
            this.dtArticulos.Size = new System.Drawing.Size(1064, 399);
            this.dtArticulos.TabIndex = 1;
            this.dtArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtArticulos_CellContentClick);
            this.dtArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtArticulos_CellDoubleClick);
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage2.Controls.Add(this.dtSolicitud);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1076, 411);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Solicitud";
            // 
            // dtSolicitud
            // 
            this.dtSolicitud.AllowUserToAddRows = false;
            this.dtSolicitud.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtSolicitud.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSolicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.Fecha,
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
            this.dtSolicitud.Size = new System.Drawing.Size(1066, 399);
            this.dtSolicitud.TabIndex = 5;
            this.dtSolicitud.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSolicitud_CellDoubleClick);
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage4.Controls.Add(this.dtdatosDocumentos);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(1076, 411);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Documentos";
            // 
            // dtdatosDocumentos
            // 
            this.dtdatosDocumentos.AllowUserToAddRows = false;
            this.dtdatosDocumentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtdatosDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtdatosDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdatosDocumentos.DoubleBuffered = true;
            this.dtdatosDocumentos.EnableHeadersVisualStyles = false;
            this.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatosDocumentos.Location = new System.Drawing.Point(6, 6);
            this.dtdatosDocumentos.Name = "dtdatosDocumentos";
            this.dtdatosDocumentos.ReadOnly = true;
            this.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatosDocumentos.RowHeadersVisible = false;
            this.dtdatosDocumentos.RowTemplate.Height = 195;
            this.dtdatosDocumentos.Size = new System.Drawing.Size(1064, 399);
            this.dtdatosDocumentos.TabIndex = 2;
            this.dtdatosDocumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdatosDocumentos_CellDoubleClick);
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.TreeListView1);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(1076, 411);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Pagos";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // TreeListView1
            // 
            this.TreeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeListView1.Columns.AddRange(new WinControls.ListView.ContainerColumnHeader[] {
            this.ContainerColumnHeader1,
            this.ContainerColumnHeader2,
            this.ContainerColumnHeader3,
            this.ContainerColumnHeader10,
            this.ContainerColumnHeader9,
            this.ContainerColumnHeader4,
            this.ContainerColumnHeader5,
            this.ContainerColumnHeader6,
            this.ContainerColumnHeader7,
            this.ContainerColumnHeader8});
            this.TreeListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TreeListView1.Location = new System.Drawing.Point(0, 0);
            this.TreeListView1.Name = "TreeListView1";
            this.TreeListView1.Size = new System.Drawing.Size(1076, 411);
            this.TreeListView1.TabIndex = 3;
            // 
            // ContainerColumnHeader1
            // 
            this.ContainerColumnHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader1.Text = "Pago";
            // 
            // ContainerColumnHeader2
            // 
            this.ContainerColumnHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader2.Text = "Crédito";
            // 
            // ContainerColumnHeader3
            // 
            this.ContainerColumnHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader3.Text = "Nombre";
            // 
            // ContainerColumnHeader10
            // 
            this.ContainerColumnHeader10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader10.Text = "PagoNormal";
            // 
            // ContainerColumnHeader9
            // 
            this.ContainerColumnHeader9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader9.Text = "Intereses";
            // 
            // ContainerColumnHeader4
            // 
            this.ContainerColumnHeader4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader4.Text = "Monto";
            // 
            // ContainerColumnHeader5
            // 
            this.ContainerColumnHeader5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader5.Text = "Fecha";
            // 
            // ContainerColumnHeader6
            // 
            this.ContainerColumnHeader6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader6.Text = "Hora";
            // 
            // ContainerColumnHeader7
            // 
            this.ContainerColumnHeader7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader7.Text = "Tipo";
            // 
            // ContainerColumnHeader8
            // 
            this.ContainerColumnHeader8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader8.Text = "Caja";
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.dtActualizaciones);
            this.TabPage7.Location = new System.Drawing.Point(4, 22);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage7.Size = new System.Drawing.Size(1076, 411);
            this.TabPage7.TabIndex = 6;
            this.TabPage7.Text = "Actualizaciones";
            this.TabPage7.UseVisualStyleBackColor = true;
            // 
            // dtActualizaciones
            // 
            this.dtActualizaciones.AllowUserToAddRows = false;
            this.dtActualizaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtActualizaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtActualizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtActualizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtActualizaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtActualizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtActualizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtActualizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtActualizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtActualizaciones.DoubleBuffered = true;
            this.dtActualizaciones.EnableHeadersVisualStyles = false;
            this.dtActualizaciones.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtActualizaciones.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtActualizaciones.Location = new System.Drawing.Point(5, 6);
            this.dtActualizaciones.Name = "dtActualizaciones";
            this.dtActualizaciones.ReadOnly = true;
            this.dtActualizaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtActualizaciones.RowHeadersVisible = false;
            this.dtActualizaciones.Size = new System.Drawing.Size(1066, 399);
            this.dtActualizaciones.TabIndex = 7;
            // 
            // BackgroundArticulos
            // 
            this.BackgroundArticulos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundArticulos_DoWork);
            this.BackgroundArticulos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundArticulos_RunWorkerCompleted);
            // 
            // BackgroundSolicitud
            // 
            this.BackgroundSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSolicitud_DoWork);
            this.BackgroundSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundSolicitud_RunWorkerCompleted);
            // 
            // BackgroundDocumentos
            // 
            this.BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundDocumentos_DoWork);
            this.BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundDocumentos_RunWorkerCompleted);
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
            this.MonoFlat_HeaderLabel3.Size = new System.Drawing.Size(158, 20);
            this.MonoFlat_HeaderLabel3.TabIndex = 33;
            this.MonoFlat_HeaderLabel3.Text = "Fecha de desembolso";
            // 
            // MonoFlat_HeaderLabel4
            // 
            this.MonoFlat_HeaderLabel4.AutoSize = true;
            this.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel4.Location = new System.Drawing.Point(772, 54);
            this.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            this.MonoFlat_HeaderLabel4.Size = new System.Drawing.Size(56, 20);
            this.MonoFlat_HeaderLabel4.TabIndex = 34;
            this.MonoFlat_HeaderLabel4.Text = "Monto";
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
            // MonoFlat_HeaderLabel6
            // 
            this.MonoFlat_HeaderLabel6.AutoSize = true;
            this.MonoFlat_HeaderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel6.Location = new System.Drawing.Point(15, 129);
            this.MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6";
            this.MonoFlat_HeaderLabel6.Size = new System.Drawing.Size(125, 20);
            this.MonoFlat_HeaderLabel6.TabIndex = 36;
            this.MonoFlat_HeaderLabel6.Text = "Monto Refrendo";
            // 
            // MonoFlat_HeaderLabel7
            // 
            this.MonoFlat_HeaderLabel7.AutoSize = true;
            this.MonoFlat_HeaderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel7.Location = new System.Drawing.Point(432, 129);
            this.MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7";
            this.MonoFlat_HeaderLabel7.Size = new System.Drawing.Size(40, 20);
            this.MonoFlat_HeaderLabel7.TabIndex = 37;
            this.MonoFlat_HeaderLabel7.Text = "Tipo";
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
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.BackColor = System.Drawing.Color.Transparent;
            this.lblmonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblmonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblmonto.Location = new System.Drawing.Point(772, 80);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(13, 20);
            this.lblmonto.TabIndex = 39;
            this.lblmonto.Text = ".";
            // 
            // lblmontorefrendo
            // 
            this.lblmontorefrendo.AutoSize = true;
            this.lblmontorefrendo.BackColor = System.Drawing.Color.Transparent;
            this.lblmontorefrendo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblmontorefrendo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblmontorefrendo.Location = new System.Drawing.Point(15, 159);
            this.lblmontorefrendo.Name = "lblmontorefrendo";
            this.lblmontorefrendo.Size = new System.Drawing.Size(13, 20);
            this.lblmontorefrendo.TabIndex = 40;
            this.lblmontorefrendo.Text = ".";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbltipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltipo.Location = new System.Drawing.Point(432, 159);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(13, 20);
            this.lbltipo.TabIndex = 41;
            this.lbltipo.Text = ".";
            // 
            // BackgroundPagos
            // 
            this.BackgroundPagos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundPagos_DoWork);
            this.BackgroundPagos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundPagos_RunWorkerCompleted);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this.BunifuThinButton21);
            this.Panel2.Controls.Add(this.btnAgregarDocumentos);
            this.Panel2.Location = new System.Drawing.Point(814, 141);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(281, 85);
            this.Panel2.TabIndex = 157;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::ConfiaAdmin.My.Resources.Resources.Logo_Confia;
            this.PictureBox1.Location = new System.Drawing.Point(3, 31);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(38, 32);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 159;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            // 
            // BunifuThinButton21
            // 
            this.BunifuThinButton21.ActiveBorderThickness = 1;
            this.BunifuThinButton21.ActiveCornerRadius = 20;
            this.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.BunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton21.BackgroundImage")));
            this.BunifuThinButton21.ButtonText = "Actualizar Información";
            this.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue;
            this.BunifuThinButton21.IdleBorderThickness = 1;
            this.BunifuThinButton21.IdleCornerRadius = 20;
            this.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Gray;
            this.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BunifuThinButton21.Location = new System.Drawing.Point(54, 5);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(102, 79);
            this.BunifuThinButton21.TabIndex = 156;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // btnAgregarDocumentos
            // 
            this.btnAgregarDocumentos.ActiveBorderThickness = 1;
            this.btnAgregarDocumentos.ActiveCornerRadius = 20;
            this.btnAgregarDocumentos.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnAgregarDocumentos.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregarDocumentos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnAgregarDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDocumentos.BackgroundImage")));
            this.btnAgregarDocumentos.ButtonText = "Agregar Documentos";
            this.btnAgregarDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDocumentos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocumentos.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarDocumentos.IdleBorderThickness = 1;
            this.btnAgregarDocumentos.IdleCornerRadius = 20;
            this.btnAgregarDocumentos.IdleFillColor = System.Drawing.Color.White;
            this.btnAgregarDocumentos.IdleForecolor = System.Drawing.Color.Gray;
            this.btnAgregarDocumentos.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnAgregarDocumentos.Location = new System.Drawing.Point(166, 4);
            this.btnAgregarDocumentos.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarDocumentos.Name = "btnAgregarDocumentos";
            this.btnAgregarDocumentos.Size = new System.Drawing.Size(102, 79);
            this.btnAgregarDocumentos.TabIndex = 155;
            this.btnAgregarDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarDocumentos.Click += new System.EventHandler(this.btnAgregarDocumentos_Click);
            // 
            // BackgroundActualizaciones
            // 
            this.BackgroundActualizaciones.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundActualizaciones_DoWork);
            this.BackgroundActualizaciones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundActualizaciones_RunWorkerCompleted);
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
            // InformacionEmpeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1096, 687);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblmontorefrendo);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.MonoFlat_HeaderLabel7);
            this.Controls.Add(this.MonoFlat_HeaderLabel6);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.MonoFlat_HeaderLabel4);
            this.Controls.Add(this.MonoFlat_HeaderLabel3);
            this.Controls.Add(this.MonoFlat_HeaderLabel2);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformacionEmpeño";
            this.Text = "Información de crédito";
            this.Load += new System.EventHandler(this.InformacionSolicitud_Load);
            this.MouseHover += new System.EventHandler(this.InformacionSolicitud_MouseHover);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtArticulos)).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitud)).EndInit();
            this.TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtActualizaciones)).EndInit();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage4;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtArticulos;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundArticulos;
        internal System.ComponentModel.BackgroundWorker BackgroundSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal MonoFlat.MonoFlat_HeaderLabel lblfecha;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel6;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel7;
        internal MonoFlat.MonoFlat_HeaderLabel lblnombre;
        internal MonoFlat.MonoFlat_HeaderLabel lblmonto;
        internal MonoFlat.MonoFlat_HeaderLabel lblmontorefrendo;
        internal MonoFlat.MonoFlat_HeaderLabel lbltipo;
        internal TabPage TabPage5;
        internal WinControls.ListView.TreeListView TreeListView1;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader1;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader2;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader3;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader10;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader9;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader4;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader5;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader6;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader7;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader8;
        internal System.ComponentModel.BackgroundWorker BackgroundPagos;
        internal Panel Panel2;
        internal PictureBox PictureBox1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnAgregarDocumentos;
        internal TabPage TabPage7;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizaciones;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtActualizaciones;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentos;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Tipo;
    }
}