using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InformacionSolicitud : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionSolicitud));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EvolveControlBox1 = new ConfiaAdmin.EvolveControlBox();
            this.MonoFlat_HeaderLabel1 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.dtClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dtSolicitud = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.dtCalendarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
            this.ContainerColumnHeader19 = new WinControls.ListView.ContainerColumnHeader();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.dtGestiones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.dtActualizaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage8 = new System.Windows.Forms.TabPage();
            this.TreeListView2 = new WinControls.ListView.TreeListView();
            this.ContainerColumnHeader13 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader11 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader12 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader14 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader15 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader16 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader21 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader17 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader18 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader22 = new WinControls.ListView.ContainerColumnHeader();
            this.ContainerColumnHeader20 = new WinControls.ListView.ContainerColumnHeader();
            this.TabPage9 = new System.Windows.Forms.TabPage();
            this.dtPromesas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TabPage10 = new System.Windows.Forms.TabPage();
            this.monoFlat_HeaderLabel23 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel24 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel25 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreditoTerminal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMultasTerminal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTotalTerminal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.monoFlat_HeaderLabel26 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel22 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel19 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel20 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.FlowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreditoTotal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMultasTotal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTotal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MonoFlat_HeaderLabel21 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel18 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel17 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel16 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel13 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel14 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.FlowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreditoReestructura = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMultasReestructura = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTotalReestructura = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MonoFlat_HeaderLabel15 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel10 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel11 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreditoConvenio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMultasConvenio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTotalConvenio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MonoFlat_HeaderLabel12 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel9 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel8 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreditoNormal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMultasNormal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTotalNormal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MonoFlat_HeaderLabel5 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundClientes = new System.ComponentModel.BackgroundWorker();
            this.BackgroundSolicitud = new System.ComponentModel.BackgroundWorker();
            this.BackgroundCalendario = new System.ComponentModel.BackgroundWorker();
            this.BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            this.MonoFlat_HeaderLabel2 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel3 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel4 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblfecha = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel6 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.MonoFlat_HeaderLabel7 = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblnombre = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblmonto = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lblmontopagare = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.lbltipo = new ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel();
            this.BackgroundPagos = new System.ComponentModel.BackgroundWorker();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btn_convenio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGenerarCalendario = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackgroundGestiones = new System.ComponentModel.BackgroundWorker();
            this.BackgroundActualizaciones = new System.ComponentModel.BackgroundWorker();
            this.BackgroundComportamiento = new System.ComponentModel.BackgroundWorker();
            this.BackgroundPromesas = new System.ComponentModel.BackgroundWorker();
            this.ContextMenuPromesa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReimprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundConcentrado = new System.ComponentModel.BackgroundWorker();
            this.btn_Moto = new System.Windows.Forms.Button();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitud)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCalendarios)).BeginInit();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).BeginInit();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGestiones)).BeginInit();
            this.TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtActualizaciones)).BeginInit();
            this.TabPage8.SuspendLayout();
            this.TabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPromesas)).BeginInit();
            this.TabPage10.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.FlowLayoutPanel4.SuspendLayout();
            this.FlowLayoutPanel3.SuspendLayout();
            this.FlowLayoutPanel2.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ContextMenuPromesa.SuspendLayout();
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
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.MonoFlat_HeaderLabel1.Size = new System.Drawing.Size(169, 20);
            this.MonoFlat_HeaderLabel1.TabIndex = 1;
            this.MonoFlat_HeaderLabel1.Text = "Información de crédito";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage9);
            this.TabControl1.Controls.Add(this.TabPage10);
            this.TabControl1.Location = new System.Drawing.Point(8, 210);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1084, 437);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage1.Controls.Add(this.dtClientes);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1076, 411);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Clientes";
            // 
            // dtClientes
            // 
            this.dtClientes.AllowUserToAddRows = false;
            this.dtClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.DoubleBuffered = true;
            this.dtClientes.EnableHeadersVisualStyles = false;
            this.dtClientes.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtClientes.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtClientes.Location = new System.Drawing.Point(6, 6);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.ReadOnly = true;
            this.dtClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtClientes.RowHeadersVisible = false;
            this.dtClientes.Size = new System.Drawing.Size(1064, 399);
            this.dtClientes.TabIndex = 1;
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
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtSolicitud.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtSolicitud.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtSolicitud.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage3.Controls.Add(this.dtCalendarios);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1076, 411);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Calendario";
            // 
            // dtCalendarios
            // 
            this.dtCalendarios.AllowUserToAddRows = false;
            this.dtCalendarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCalendarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dtCalendarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCalendarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtCalendarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtCalendarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtCalendarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtCalendarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtCalendarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCalendarios.DoubleBuffered = true;
            this.dtCalendarios.EnableHeadersVisualStyles = false;
            this.dtCalendarios.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtCalendarios.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtCalendarios.Location = new System.Drawing.Point(5, 6);
            this.dtCalendarios.Name = "dtCalendarios";
            this.dtCalendarios.ReadOnly = true;
            this.dtCalendarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtCalendarios.RowHeadersVisible = false;
            this.dtCalendarios.Size = new System.Drawing.Size(1066, 399);
            this.dtCalendarios.TabIndex = 6;
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
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dtdatosDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdatosDocumentos.DoubleBuffered = true;
            this.dtdatosDocumentos.EnableHeadersVisualStyles = false;
            this.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtdatosDocumentos.Location = new System.Drawing.Point(3, 3);
            this.dtdatosDocumentos.Name = "dtdatosDocumentos";
            this.dtdatosDocumentos.ReadOnly = true;
            this.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtdatosDocumentos.RowHeadersVisible = false;
            this.dtdatosDocumentos.Size = new System.Drawing.Size(1069, 405);
            this.dtdatosDocumentos.TabIndex = 27;
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
            this.TreeListView1.AllowMultiSelectActivation = true;
            this.TreeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeListView1.CheckBoxSelection = System.Windows.Forms.ItemActivation.TwoClick;
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
            this.ContainerColumnHeader8,
            this.ContainerColumnHeader19});
            this.TreeListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TreeListView1.Location = new System.Drawing.Point(0, 0);
            this.TreeListView1.MultiSelect = true;
            this.TreeListView1.Name = "TreeListView1";
            this.TreeListView1.Size = new System.Drawing.Size(1080, 411);
            this.TreeListView1.TabIndex = 3;
            // 
            // ContainerColumnHeader1
            // 
            this.ContainerColumnHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader1.Text = "Ticket";
            this.ContainerColumnHeader1.Width = 175;
            // 
            // ContainerColumnHeader2
            // 
            this.ContainerColumnHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader2.Text = "Crédito";
            this.ContainerColumnHeader2.Width = 72;
            // 
            // ContainerColumnHeader3
            // 
            this.ContainerColumnHeader3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader3.Text = "Nombre";
            this.ContainerColumnHeader3.Width = 296;
            // 
            // ContainerColumnHeader10
            // 
            this.ContainerColumnHeader10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader10.Text = "Pago Normal";
            this.ContainerColumnHeader10.Width = 99;
            // 
            // ContainerColumnHeader9
            // 
            this.ContainerColumnHeader9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader9.Text = "Intereses";
            this.ContainerColumnHeader9.Width = 75;
            // 
            // ContainerColumnHeader4
            // 
            this.ContainerColumnHeader4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader4.Text = "Monto";
            this.ContainerColumnHeader4.Width = 70;
            // 
            // ContainerColumnHeader5
            // 
            this.ContainerColumnHeader5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader5.Text = "Fecha";
            this.ContainerColumnHeader5.Width = 77;
            // 
            // ContainerColumnHeader6
            // 
            this.ContainerColumnHeader6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader6.Text = "Hora";
            this.ContainerColumnHeader6.Width = 64;
            // 
            // ContainerColumnHeader7
            // 
            this.ContainerColumnHeader7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader7.Text = "Tipo";
            this.ContainerColumnHeader7.Width = 75;
            // 
            // ContainerColumnHeader8
            // 
            this.ContainerColumnHeader8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader8.Text = "Caja";
            this.ContainerColumnHeader8.Width = 54;
            // 
            // ContainerColumnHeader19
            // 
            this.ContainerColumnHeader19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader19.Text = "Estado";
            this.ContainerColumnHeader19.Width = 54;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.dtGestiones);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(1076, 411);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "Gestiones";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // dtGestiones
            // 
            this.dtGestiones.AllowUserToAddRows = false;
            this.dtGestiones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGestiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dtGestiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGestiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGestiones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtGestiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGestiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGestiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dtGestiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGestiones.DoubleBuffered = true;
            this.dtGestiones.EnableHeadersVisualStyles = false;
            this.dtGestiones.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtGestiones.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtGestiones.Location = new System.Drawing.Point(5, 6);
            this.dtGestiones.Name = "dtGestiones";
            this.dtGestiones.ReadOnly = true;
            this.dtGestiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGestiones.RowHeadersVisible = false;
            this.dtGestiones.Size = new System.Drawing.Size(1066, 399);
            this.dtGestiones.TabIndex = 7;
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
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtActualizaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dtActualizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtActualizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtActualizaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtActualizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtActualizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtActualizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
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
            // TabPage8
            // 
            this.TabPage8.Controls.Add(this.TreeListView2);
            this.TabPage8.Location = new System.Drawing.Point(4, 22);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage8.Size = new System.Drawing.Size(1076, 411);
            this.TabPage8.TabIndex = 7;
            this.TabPage8.Text = "Comportamiento";
            this.TabPage8.UseVisualStyleBackColor = true;
            // 
            // TreeListView2
            // 
            this.TreeListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeListView2.Columns.AddRange(new WinControls.ListView.ContainerColumnHeader[] {
            this.ContainerColumnHeader13,
            this.ContainerColumnHeader11,
            this.ContainerColumnHeader12,
            this.ContainerColumnHeader14,
            this.ContainerColumnHeader15,
            this.ContainerColumnHeader16,
            this.ContainerColumnHeader21,
            this.ContainerColumnHeader17,
            this.ContainerColumnHeader18,
            this.ContainerColumnHeader22,
            this.ContainerColumnHeader20});
            this.TreeListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TreeListView2.Location = new System.Drawing.Point(8, 8);
            this.TreeListView2.Name = "TreeListView2";
            this.TreeListView2.Size = new System.Drawing.Size(1065, 411);
            this.TreeListView2.TabIndex = 4;
            // 
            // ContainerColumnHeader13
            // 
            this.ContainerColumnHeader13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader13.Text = "Tipo de Pago";
            this.ContainerColumnHeader13.Width = 181;
            // 
            // ContainerColumnHeader11
            // 
            this.ContainerColumnHeader11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader11.Text = "ID";
            this.ContainerColumnHeader11.Width = 67;
            // 
            // ContainerColumnHeader12
            // 
            this.ContainerColumnHeader12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader12.Text = "NPago";
            this.ContainerColumnHeader12.Width = 58;
            // 
            // ContainerColumnHeader14
            // 
            this.ContainerColumnHeader14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader14.Text = "PagoNormal";
            this.ContainerColumnHeader14.Width = 85;
            // 
            // ContainerColumnHeader15
            // 
            this.ContainerColumnHeader15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader15.Text = "Intereses";
            this.ContainerColumnHeader15.Width = 85;
            // 
            // ContainerColumnHeader16
            // 
            this.ContainerColumnHeader16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader16.Text = "Abonado";
            this.ContainerColumnHeader16.Width = 85;
            // 
            // ContainerColumnHeader21
            // 
            this.ContainerColumnHeader21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader21.Text = "Pendiente";
            this.ContainerColumnHeader21.Width = 85;
            // 
            // ContainerColumnHeader17
            // 
            this.ContainerColumnHeader17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader17.Text = "Fecha";
            this.ContainerColumnHeader17.Width = 93;
            // 
            // ContainerColumnHeader18
            // 
            this.ContainerColumnHeader18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader18.Text = "Fecha de pago";
            this.ContainerColumnHeader18.Width = 93;
            // 
            // ContainerColumnHeader22
            // 
            this.ContainerColumnHeader22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader22.Text = "Hora";
            this.ContainerColumnHeader22.Width = 83;
            // 
            // ContainerColumnHeader20
            // 
            this.ContainerColumnHeader20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainerColumnHeader20.Text = "Caja";
            this.ContainerColumnHeader20.Width = 80;
            // 
            // TabPage9
            // 
            this.TabPage9.Controls.Add(this.dtPromesas);
            this.TabPage9.Location = new System.Drawing.Point(4, 22);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage9.Size = new System.Drawing.Size(1076, 411);
            this.TabPage9.TabIndex = 8;
            this.TabPage9.Text = "Promesas";
            this.TabPage9.UseVisualStyleBackColor = true;
            // 
            // dtPromesas
            // 
            this.dtPromesas.AllowUserToAddRows = false;
            this.dtPromesas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtPromesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dtPromesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPromesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtPromesas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtPromesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtPromesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPromesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dtPromesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPromesas.DoubleBuffered = true;
            this.dtPromesas.EnableHeadersVisualStyles = false;
            this.dtPromesas.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dtPromesas.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtPromesas.Location = new System.Drawing.Point(5, 6);
            this.dtPromesas.Name = "dtPromesas";
            this.dtPromesas.ReadOnly = true;
            this.dtPromesas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtPromesas.RowHeadersVisible = false;
            this.dtPromesas.Size = new System.Drawing.Size(1066, 399);
            this.dtPromesas.TabIndex = 8;
            this.dtPromesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPromesas_CellContentClick);
            this.dtPromesas.SelectionChanged += new System.EventHandler(this.dtPromesas_SelectionChanged);
            // 
            // TabPage10
            // 
            this.TabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.TabPage10.Controls.Add(this.monoFlat_HeaderLabel23);
            this.TabPage10.Controls.Add(this.monoFlat_HeaderLabel24);
            this.TabPage10.Controls.Add(this.monoFlat_HeaderLabel25);
            this.TabPage10.Controls.Add(this.flowLayoutPanel5);
            this.TabPage10.Controls.Add(this.monoFlat_HeaderLabel26);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel22);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel19);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel20);
            this.TabPage10.Controls.Add(this.FlowLayoutPanel4);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel21);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel18);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel17);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel16);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel13);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel14);
            this.TabPage10.Controls.Add(this.FlowLayoutPanel3);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel15);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel10);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel11);
            this.TabPage10.Controls.Add(this.FlowLayoutPanel2);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel12);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel9);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel8);
            this.TabPage10.Controls.Add(this.FlowLayoutPanel1);
            this.TabPage10.Controls.Add(this.MonoFlat_HeaderLabel5);
            this.TabPage10.Location = new System.Drawing.Point(4, 22);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage10.Size = new System.Drawing.Size(1076, 411);
            this.TabPage10.TabIndex = 9;
            this.TabPage10.Text = "Concentrado";
            // 
            // monoFlat_HeaderLabel23
            // 
            this.monoFlat_HeaderLabel23.AutoSize = true;
            this.monoFlat_HeaderLabel23.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel23.Location = new System.Drawing.Point(264, 223);
            this.monoFlat_HeaderLabel23.Name = "monoFlat_HeaderLabel23";
            this.monoFlat_HeaderLabel23.Size = new System.Drawing.Size(44, 20);
            this.monoFlat_HeaderLabel23.TabIndex = 57;
            this.monoFlat_HeaderLabel23.Text = "Total";
            // 
            // monoFlat_HeaderLabel24
            // 
            this.monoFlat_HeaderLabel24.AutoSize = true;
            this.monoFlat_HeaderLabel24.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel24.Location = new System.Drawing.Point(149, 223);
            this.monoFlat_HeaderLabel24.Name = "monoFlat_HeaderLabel24";
            this.monoFlat_HeaderLabel24.Size = new System.Drawing.Size(57, 20);
            this.monoFlat_HeaderLabel24.TabIndex = 56;
            this.monoFlat_HeaderLabel24.Text = "Multas";
            // 
            // monoFlat_HeaderLabel25
            // 
            this.monoFlat_HeaderLabel25.AutoSize = true;
            this.monoFlat_HeaderLabel25.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel25.Location = new System.Drawing.Point(40, 223);
            this.monoFlat_HeaderLabel25.Name = "monoFlat_HeaderLabel25";
            this.monoFlat_HeaderLabel25.Size = new System.Drawing.Size(60, 20);
            this.monoFlat_HeaderLabel25.TabIndex = 55;
            this.monoFlat_HeaderLabel25.Text = "Crédito";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.btnCreditoTerminal);
            this.flowLayoutPanel5.Controls.Add(this.btnMultasTerminal);
            this.flowLayoutPanel5.Controls.Add(this.btnTotalTerminal);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(13, 246);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(338, 90);
            this.flowLayoutPanel5.TabIndex = 54;
            // 
            // btnCreditoTerminal
            // 
            this.btnCreditoTerminal.ActiveBorderThickness = 1;
            this.btnCreditoTerminal.ActiveCornerRadius = 20;
            this.btnCreditoTerminal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoTerminal.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreditoTerminal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreditoTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnCreditoTerminal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditoTerminal.BackgroundImage")));
            this.btnCreditoTerminal.ButtonText = "...";
            this.btnCreditoTerminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditoTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditoTerminal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCreditoTerminal.IdleBorderThickness = 1;
            this.btnCreditoTerminal.IdleCornerRadius = 20;
            this.btnCreditoTerminal.IdleFillColor = System.Drawing.Color.White;
            this.btnCreditoTerminal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCreditoTerminal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoTerminal.Location = new System.Drawing.Point(5, 5);
            this.btnCreditoTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreditoTerminal.Name = "btnCreditoTerminal";
            this.btnCreditoTerminal.Size = new System.Drawing.Size(102, 79);
            this.btnCreditoTerminal.TabIndex = 158;
            this.btnCreditoTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMultasTerminal
            // 
            this.btnMultasTerminal.ActiveBorderThickness = 1;
            this.btnMultasTerminal.ActiveCornerRadius = 20;
            this.btnMultasTerminal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasTerminal.ActiveForecolor = System.Drawing.Color.White;
            this.btnMultasTerminal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMultasTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnMultasTerminal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultasTerminal.BackgroundImage")));
            this.btnMultasTerminal.ButtonText = "...";
            this.btnMultasTerminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultasTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultasTerminal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMultasTerminal.IdleBorderThickness = 1;
            this.btnMultasTerminal.IdleCornerRadius = 20;
            this.btnMultasTerminal.IdleFillColor = System.Drawing.Color.White;
            this.btnMultasTerminal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnMultasTerminal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasTerminal.Location = new System.Drawing.Point(117, 5);
            this.btnMultasTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultasTerminal.Name = "btnMultasTerminal";
            this.btnMultasTerminal.Size = new System.Drawing.Size(102, 79);
            this.btnMultasTerminal.TabIndex = 159;
            this.btnMultasTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalTerminal
            // 
            this.btnTotalTerminal.ActiveBorderThickness = 1;
            this.btnTotalTerminal.ActiveCornerRadius = 20;
            this.btnTotalTerminal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalTerminal.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotalTerminal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnTotalTerminal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalTerminal.BackgroundImage")));
            this.btnTotalTerminal.ButtonText = "...";
            this.btnTotalTerminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalTerminal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTotalTerminal.IdleBorderThickness = 1;
            this.btnTotalTerminal.IdleCornerRadius = 20;
            this.btnTotalTerminal.IdleFillColor = System.Drawing.Color.White;
            this.btnTotalTerminal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnTotalTerminal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalTerminal.Location = new System.Drawing.Point(229, 5);
            this.btnTotalTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.btnTotalTerminal.Name = "btnTotalTerminal";
            this.btnTotalTerminal.Size = new System.Drawing.Size(102, 79);
            this.btnTotalTerminal.TabIndex = 160;
            this.btnTotalTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monoFlat_HeaderLabel26
            // 
            this.monoFlat_HeaderLabel26.AutoSize = true;
            this.monoFlat_HeaderLabel26.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel26.Location = new System.Drawing.Point(9, 186);
            this.monoFlat_HeaderLabel26.Name = "monoFlat_HeaderLabel26";
            this.monoFlat_HeaderLabel26.Size = new System.Drawing.Size(139, 20);
            this.monoFlat_HeaderLabel26.TabIndex = 53;
            this.monoFlat_HeaderLabel26.Text = "Convenio Terminal";
            // 
            // MonoFlat_HeaderLabel22
            // 
            this.MonoFlat_HeaderLabel22.AutoSize = true;
            this.MonoFlat_HeaderLabel22.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel22.Location = new System.Drawing.Point(616, 223);
            this.MonoFlat_HeaderLabel22.Name = "MonoFlat_HeaderLabel22";
            this.MonoFlat_HeaderLabel22.Size = new System.Drawing.Size(44, 20);
            this.MonoFlat_HeaderLabel22.TabIndex = 52;
            this.MonoFlat_HeaderLabel22.Text = "Total";
            // 
            // MonoFlat_HeaderLabel19
            // 
            this.MonoFlat_HeaderLabel19.AutoSize = true;
            this.MonoFlat_HeaderLabel19.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel19.Location = new System.Drawing.Point(501, 223);
            this.MonoFlat_HeaderLabel19.Name = "MonoFlat_HeaderLabel19";
            this.MonoFlat_HeaderLabel19.Size = new System.Drawing.Size(57, 20);
            this.MonoFlat_HeaderLabel19.TabIndex = 51;
            this.MonoFlat_HeaderLabel19.Text = "Multas";
            // 
            // MonoFlat_HeaderLabel20
            // 
            this.MonoFlat_HeaderLabel20.AutoSize = true;
            this.MonoFlat_HeaderLabel20.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel20.Location = new System.Drawing.Point(392, 223);
            this.MonoFlat_HeaderLabel20.Name = "MonoFlat_HeaderLabel20";
            this.MonoFlat_HeaderLabel20.Size = new System.Drawing.Size(60, 20);
            this.MonoFlat_HeaderLabel20.TabIndex = 50;
            this.MonoFlat_HeaderLabel20.Text = "Crédito";
            // 
            // FlowLayoutPanel4
            // 
            this.FlowLayoutPanel4.Controls.Add(this.btnCreditoTotal);
            this.FlowLayoutPanel4.Controls.Add(this.btnMultasTotal);
            this.FlowLayoutPanel4.Controls.Add(this.btnTotal);
            this.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel4.Location = new System.Drawing.Point(365, 246);
            this.FlowLayoutPanel4.Name = "FlowLayoutPanel4";
            this.FlowLayoutPanel4.Size = new System.Drawing.Size(338, 90);
            this.FlowLayoutPanel4.TabIndex = 49;
            // 
            // btnCreditoTotal
            // 
            this.btnCreditoTotal.ActiveBorderThickness = 1;
            this.btnCreditoTotal.ActiveCornerRadius = 20;
            this.btnCreditoTotal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoTotal.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreditoTotal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreditoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnCreditoTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditoTotal.BackgroundImage")));
            this.btnCreditoTotal.ButtonText = "...";
            this.btnCreditoTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditoTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCreditoTotal.IdleBorderThickness = 1;
            this.btnCreditoTotal.IdleCornerRadius = 20;
            this.btnCreditoTotal.IdleFillColor = System.Drawing.Color.White;
            this.btnCreditoTotal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCreditoTotal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoTotal.Location = new System.Drawing.Point(5, 5);
            this.btnCreditoTotal.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreditoTotal.Name = "btnCreditoTotal";
            this.btnCreditoTotal.Size = new System.Drawing.Size(102, 79);
            this.btnCreditoTotal.TabIndex = 158;
            this.btnCreditoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMultasTotal
            // 
            this.btnMultasTotal.ActiveBorderThickness = 1;
            this.btnMultasTotal.ActiveCornerRadius = 20;
            this.btnMultasTotal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasTotal.ActiveForecolor = System.Drawing.Color.White;
            this.btnMultasTotal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMultasTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnMultasTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultasTotal.BackgroundImage")));
            this.btnMultasTotal.ButtonText = "...";
            this.btnMultasTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultasTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultasTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMultasTotal.IdleBorderThickness = 1;
            this.btnMultasTotal.IdleCornerRadius = 20;
            this.btnMultasTotal.IdleFillColor = System.Drawing.Color.White;
            this.btnMultasTotal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnMultasTotal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasTotal.Location = new System.Drawing.Point(117, 5);
            this.btnMultasTotal.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultasTotal.Name = "btnMultasTotal";
            this.btnMultasTotal.Size = new System.Drawing.Size(102, 79);
            this.btnMultasTotal.TabIndex = 159;
            this.btnMultasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotal
            // 
            this.btnTotal.ActiveBorderThickness = 1;
            this.btnTotal.ActiveCornerRadius = 20;
            this.btnTotal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotal.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotal.BackgroundImage")));
            this.btnTotal.ButtonText = "...";
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTotal.IdleBorderThickness = 1;
            this.btnTotal.IdleCornerRadius = 20;
            this.btnTotal.IdleFillColor = System.Drawing.Color.White;
            this.btnTotal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnTotal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotal.Location = new System.Drawing.Point(229, 5);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(5);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(102, 79);
            this.btnTotal.TabIndex = 160;
            this.btnTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel21
            // 
            this.MonoFlat_HeaderLabel21.AutoSize = true;
            this.MonoFlat_HeaderLabel21.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel21.Location = new System.Drawing.Point(361, 186);
            this.MonoFlat_HeaderLabel21.Name = "MonoFlat_HeaderLabel21";
            this.MonoFlat_HeaderLabel21.Size = new System.Drawing.Size(44, 20);
            this.MonoFlat_HeaderLabel21.TabIndex = 48;
            this.MonoFlat_HeaderLabel21.Text = "Total";
            // 
            // MonoFlat_HeaderLabel18
            // 
            this.MonoFlat_HeaderLabel18.AutoSize = true;
            this.MonoFlat_HeaderLabel18.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel18.Location = new System.Drawing.Point(264, 57);
            this.MonoFlat_HeaderLabel18.Name = "MonoFlat_HeaderLabel18";
            this.MonoFlat_HeaderLabel18.Size = new System.Drawing.Size(44, 20);
            this.MonoFlat_HeaderLabel18.TabIndex = 47;
            this.MonoFlat_HeaderLabel18.Text = "Total";
            // 
            // MonoFlat_HeaderLabel17
            // 
            this.MonoFlat_HeaderLabel17.AutoSize = true;
            this.MonoFlat_HeaderLabel17.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel17.Location = new System.Drawing.Point(617, 57);
            this.MonoFlat_HeaderLabel17.Name = "MonoFlat_HeaderLabel17";
            this.MonoFlat_HeaderLabel17.Size = new System.Drawing.Size(44, 20);
            this.MonoFlat_HeaderLabel17.TabIndex = 46;
            this.MonoFlat_HeaderLabel17.Text = "Total";
            // 
            // MonoFlat_HeaderLabel16
            // 
            this.MonoFlat_HeaderLabel16.AutoSize = true;
            this.MonoFlat_HeaderLabel16.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel16.Location = new System.Drawing.Point(967, 57);
            this.MonoFlat_HeaderLabel16.Name = "MonoFlat_HeaderLabel16";
            this.MonoFlat_HeaderLabel16.Size = new System.Drawing.Size(44, 20);
            this.MonoFlat_HeaderLabel16.TabIndex = 45;
            this.MonoFlat_HeaderLabel16.Text = "Total";
            // 
            // MonoFlat_HeaderLabel13
            // 
            this.MonoFlat_HeaderLabel13.AutoSize = true;
            this.MonoFlat_HeaderLabel13.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel13.Location = new System.Drawing.Point(855, 57);
            this.MonoFlat_HeaderLabel13.Name = "MonoFlat_HeaderLabel13";
            this.MonoFlat_HeaderLabel13.Size = new System.Drawing.Size(57, 20);
            this.MonoFlat_HeaderLabel13.TabIndex = 44;
            this.MonoFlat_HeaderLabel13.Text = "Multas";
            // 
            // MonoFlat_HeaderLabel14
            // 
            this.MonoFlat_HeaderLabel14.AutoSize = true;
            this.MonoFlat_HeaderLabel14.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel14.Location = new System.Drawing.Point(743, 57);
            this.MonoFlat_HeaderLabel14.Name = "MonoFlat_HeaderLabel14";
            this.MonoFlat_HeaderLabel14.Size = new System.Drawing.Size(60, 20);
            this.MonoFlat_HeaderLabel14.TabIndex = 43;
            this.MonoFlat_HeaderLabel14.Text = "Crédito";
            // 
            // FlowLayoutPanel3
            // 
            this.FlowLayoutPanel3.Controls.Add(this.btnCreditoReestructura);
            this.FlowLayoutPanel3.Controls.Add(this.btnMultasReestructura);
            this.FlowLayoutPanel3.Controls.Add(this.btnTotalReestructura);
            this.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel3.Location = new System.Drawing.Point(716, 80);
            this.FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            this.FlowLayoutPanel3.Size = new System.Drawing.Size(343, 90);
            this.FlowLayoutPanel3.TabIndex = 42;
            // 
            // btnCreditoReestructura
            // 
            this.btnCreditoReestructura.ActiveBorderThickness = 1;
            this.btnCreditoReestructura.ActiveCornerRadius = 20;
            this.btnCreditoReestructura.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoReestructura.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreditoReestructura.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreditoReestructura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnCreditoReestructura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditoReestructura.BackgroundImage")));
            this.btnCreditoReestructura.ButtonText = "...";
            this.btnCreditoReestructura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditoReestructura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditoReestructura.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCreditoReestructura.IdleBorderThickness = 1;
            this.btnCreditoReestructura.IdleCornerRadius = 20;
            this.btnCreditoReestructura.IdleFillColor = System.Drawing.Color.White;
            this.btnCreditoReestructura.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCreditoReestructura.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoReestructura.Location = new System.Drawing.Point(5, 5);
            this.btnCreditoReestructura.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreditoReestructura.Name = "btnCreditoReestructura";
            this.btnCreditoReestructura.Size = new System.Drawing.Size(102, 79);
            this.btnCreditoReestructura.TabIndex = 158;
            this.btnCreditoReestructura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMultasReestructura
            // 
            this.btnMultasReestructura.ActiveBorderThickness = 1;
            this.btnMultasReestructura.ActiveCornerRadius = 20;
            this.btnMultasReestructura.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasReestructura.ActiveForecolor = System.Drawing.Color.White;
            this.btnMultasReestructura.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMultasReestructura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnMultasReestructura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultasReestructura.BackgroundImage")));
            this.btnMultasReestructura.ButtonText = "...";
            this.btnMultasReestructura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultasReestructura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultasReestructura.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMultasReestructura.IdleBorderThickness = 1;
            this.btnMultasReestructura.IdleCornerRadius = 20;
            this.btnMultasReestructura.IdleFillColor = System.Drawing.Color.White;
            this.btnMultasReestructura.IdleForecolor = System.Drawing.Color.Gray;
            this.btnMultasReestructura.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasReestructura.Location = new System.Drawing.Point(117, 5);
            this.btnMultasReestructura.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultasReestructura.Name = "btnMultasReestructura";
            this.btnMultasReestructura.Size = new System.Drawing.Size(102, 79);
            this.btnMultasReestructura.TabIndex = 159;
            this.btnMultasReestructura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalReestructura
            // 
            this.btnTotalReestructura.ActiveBorderThickness = 1;
            this.btnTotalReestructura.ActiveCornerRadius = 20;
            this.btnTotalReestructura.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalReestructura.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotalReestructura.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalReestructura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnTotalReestructura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalReestructura.BackgroundImage")));
            this.btnTotalReestructura.ButtonText = "...";
            this.btnTotalReestructura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalReestructura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalReestructura.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTotalReestructura.IdleBorderThickness = 1;
            this.btnTotalReestructura.IdleCornerRadius = 20;
            this.btnTotalReestructura.IdleFillColor = System.Drawing.Color.White;
            this.btnTotalReestructura.IdleForecolor = System.Drawing.Color.Gray;
            this.btnTotalReestructura.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalReestructura.Location = new System.Drawing.Point(229, 5);
            this.btnTotalReestructura.Margin = new System.Windows.Forms.Padding(5);
            this.btnTotalReestructura.Name = "btnTotalReestructura";
            this.btnTotalReestructura.Size = new System.Drawing.Size(102, 79);
            this.btnTotalReestructura.TabIndex = 160;
            this.btnTotalReestructura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel15
            // 
            this.MonoFlat_HeaderLabel15.AutoSize = true;
            this.MonoFlat_HeaderLabel15.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel15.Location = new System.Drawing.Point(712, 20);
            this.MonoFlat_HeaderLabel15.Name = "MonoFlat_HeaderLabel15";
            this.MonoFlat_HeaderLabel15.Size = new System.Drawing.Size(99, 20);
            this.MonoFlat_HeaderLabel15.TabIndex = 41;
            this.MonoFlat_HeaderLabel15.Text = "Reestructura";
            // 
            // MonoFlat_HeaderLabel10
            // 
            this.MonoFlat_HeaderLabel10.AutoSize = true;
            this.MonoFlat_HeaderLabel10.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel10.Location = new System.Drawing.Point(502, 57);
            this.MonoFlat_HeaderLabel10.Name = "MonoFlat_HeaderLabel10";
            this.MonoFlat_HeaderLabel10.Size = new System.Drawing.Size(57, 20);
            this.MonoFlat_HeaderLabel10.TabIndex = 40;
            this.MonoFlat_HeaderLabel10.Text = "Multas";
            // 
            // MonoFlat_HeaderLabel11
            // 
            this.MonoFlat_HeaderLabel11.AutoSize = true;
            this.MonoFlat_HeaderLabel11.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel11.Location = new System.Drawing.Point(392, 57);
            this.MonoFlat_HeaderLabel11.Name = "MonoFlat_HeaderLabel11";
            this.MonoFlat_HeaderLabel11.Size = new System.Drawing.Size(60, 20);
            this.MonoFlat_HeaderLabel11.TabIndex = 39;
            this.MonoFlat_HeaderLabel11.Text = "Crédito";
            // 
            // FlowLayoutPanel2
            // 
            this.FlowLayoutPanel2.Controls.Add(this.btnCreditoConvenio);
            this.FlowLayoutPanel2.Controls.Add(this.btnMultasConvenio);
            this.FlowLayoutPanel2.Controls.Add(this.btnTotalConvenio);
            this.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel2.Location = new System.Drawing.Point(365, 80);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new System.Drawing.Size(339, 90);
            this.FlowLayoutPanel2.TabIndex = 38;
            // 
            // btnCreditoConvenio
            // 
            this.btnCreditoConvenio.ActiveBorderThickness = 1;
            this.btnCreditoConvenio.ActiveCornerRadius = 20;
            this.btnCreditoConvenio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoConvenio.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreditoConvenio.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreditoConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnCreditoConvenio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditoConvenio.BackgroundImage")));
            this.btnCreditoConvenio.ButtonText = "...";
            this.btnCreditoConvenio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditoConvenio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditoConvenio.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCreditoConvenio.IdleBorderThickness = 1;
            this.btnCreditoConvenio.IdleCornerRadius = 20;
            this.btnCreditoConvenio.IdleFillColor = System.Drawing.Color.White;
            this.btnCreditoConvenio.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCreditoConvenio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoConvenio.Location = new System.Drawing.Point(5, 5);
            this.btnCreditoConvenio.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreditoConvenio.Name = "btnCreditoConvenio";
            this.btnCreditoConvenio.Size = new System.Drawing.Size(102, 79);
            this.btnCreditoConvenio.TabIndex = 158;
            this.btnCreditoConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMultasConvenio
            // 
            this.btnMultasConvenio.ActiveBorderThickness = 1;
            this.btnMultasConvenio.ActiveCornerRadius = 20;
            this.btnMultasConvenio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasConvenio.ActiveForecolor = System.Drawing.Color.White;
            this.btnMultasConvenio.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMultasConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnMultasConvenio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultasConvenio.BackgroundImage")));
            this.btnMultasConvenio.ButtonText = "...";
            this.btnMultasConvenio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultasConvenio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultasConvenio.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMultasConvenio.IdleBorderThickness = 1;
            this.btnMultasConvenio.IdleCornerRadius = 20;
            this.btnMultasConvenio.IdleFillColor = System.Drawing.Color.White;
            this.btnMultasConvenio.IdleForecolor = System.Drawing.Color.Gray;
            this.btnMultasConvenio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasConvenio.Location = new System.Drawing.Point(117, 5);
            this.btnMultasConvenio.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultasConvenio.Name = "btnMultasConvenio";
            this.btnMultasConvenio.Size = new System.Drawing.Size(102, 79);
            this.btnMultasConvenio.TabIndex = 159;
            this.btnMultasConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalConvenio
            // 
            this.btnTotalConvenio.ActiveBorderThickness = 1;
            this.btnTotalConvenio.ActiveCornerRadius = 20;
            this.btnTotalConvenio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalConvenio.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotalConvenio.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalConvenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnTotalConvenio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalConvenio.BackgroundImage")));
            this.btnTotalConvenio.ButtonText = "...";
            this.btnTotalConvenio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalConvenio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalConvenio.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTotalConvenio.IdleBorderThickness = 1;
            this.btnTotalConvenio.IdleCornerRadius = 20;
            this.btnTotalConvenio.IdleFillColor = System.Drawing.Color.White;
            this.btnTotalConvenio.IdleForecolor = System.Drawing.Color.Gray;
            this.btnTotalConvenio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalConvenio.Location = new System.Drawing.Point(229, 5);
            this.btnTotalConvenio.Margin = new System.Windows.Forms.Padding(5);
            this.btnTotalConvenio.Name = "btnTotalConvenio";
            this.btnTotalConvenio.Size = new System.Drawing.Size(102, 79);
            this.btnTotalConvenio.TabIndex = 160;
            this.btnTotalConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel12
            // 
            this.MonoFlat_HeaderLabel12.AutoSize = true;
            this.MonoFlat_HeaderLabel12.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel12.Location = new System.Drawing.Point(361, 20);
            this.MonoFlat_HeaderLabel12.Name = "MonoFlat_HeaderLabel12";
            this.MonoFlat_HeaderLabel12.Size = new System.Drawing.Size(74, 20);
            this.MonoFlat_HeaderLabel12.TabIndex = 37;
            this.MonoFlat_HeaderLabel12.Text = "Convenio";
            // 
            // MonoFlat_HeaderLabel9
            // 
            this.MonoFlat_HeaderLabel9.AutoSize = true;
            this.MonoFlat_HeaderLabel9.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel9.Location = new System.Drawing.Point(149, 57);
            this.MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9";
            this.MonoFlat_HeaderLabel9.Size = new System.Drawing.Size(57, 20);
            this.MonoFlat_HeaderLabel9.TabIndex = 36;
            this.MonoFlat_HeaderLabel9.Text = "Multas";
            // 
            // MonoFlat_HeaderLabel8
            // 
            this.MonoFlat_HeaderLabel8.AutoSize = true;
            this.MonoFlat_HeaderLabel8.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel8.Location = new System.Drawing.Point(40, 57);
            this.MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8";
            this.MonoFlat_HeaderLabel8.Size = new System.Drawing.Size(60, 20);
            this.MonoFlat_HeaderLabel8.TabIndex = 35;
            this.MonoFlat_HeaderLabel8.Text = "Crédito";
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Controls.Add(this.btnCreditoNormal);
            this.FlowLayoutPanel1.Controls.Add(this.btnMultasNormal);
            this.FlowLayoutPanel1.Controls.Add(this.btnTotalNormal);
            this.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(13, 80);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(338, 90);
            this.FlowLayoutPanel1.TabIndex = 34;
            // 
            // btnCreditoNormal
            // 
            this.btnCreditoNormal.ActiveBorderThickness = 1;
            this.btnCreditoNormal.ActiveCornerRadius = 20;
            this.btnCreditoNormal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoNormal.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreditoNormal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreditoNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnCreditoNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreditoNormal.BackgroundImage")));
            this.btnCreditoNormal.ButtonText = "...";
            this.btnCreditoNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditoNormal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditoNormal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCreditoNormal.IdleBorderThickness = 1;
            this.btnCreditoNormal.IdleCornerRadius = 20;
            this.btnCreditoNormal.IdleFillColor = System.Drawing.Color.White;
            this.btnCreditoNormal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnCreditoNormal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnCreditoNormal.Location = new System.Drawing.Point(5, 5);
            this.btnCreditoNormal.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreditoNormal.Name = "btnCreditoNormal";
            this.btnCreditoNormal.Size = new System.Drawing.Size(102, 79);
            this.btnCreditoNormal.TabIndex = 158;
            this.btnCreditoNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMultasNormal
            // 
            this.btnMultasNormal.ActiveBorderThickness = 1;
            this.btnMultasNormal.ActiveCornerRadius = 20;
            this.btnMultasNormal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasNormal.ActiveForecolor = System.Drawing.Color.White;
            this.btnMultasNormal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMultasNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnMultasNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultasNormal.BackgroundImage")));
            this.btnMultasNormal.ButtonText = "...";
            this.btnMultasNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultasNormal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultasNormal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMultasNormal.IdleBorderThickness = 1;
            this.btnMultasNormal.IdleCornerRadius = 20;
            this.btnMultasNormal.IdleFillColor = System.Drawing.Color.White;
            this.btnMultasNormal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnMultasNormal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnMultasNormal.Location = new System.Drawing.Point(117, 5);
            this.btnMultasNormal.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultasNormal.Name = "btnMultasNormal";
            this.btnMultasNormal.Size = new System.Drawing.Size(102, 79);
            this.btnMultasNormal.TabIndex = 159;
            this.btnMultasNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTotalNormal
            // 
            this.btnTotalNormal.ActiveBorderThickness = 1;
            this.btnTotalNormal.ActiveCornerRadius = 20;
            this.btnTotalNormal.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalNormal.ActiveForecolor = System.Drawing.Color.White;
            this.btnTotalNormal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTotalNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnTotalNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalNormal.BackgroundImage")));
            this.btnTotalNormal.ButtonText = "...";
            this.btnTotalNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalNormal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalNormal.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTotalNormal.IdleBorderThickness = 1;
            this.btnTotalNormal.IdleCornerRadius = 20;
            this.btnTotalNormal.IdleFillColor = System.Drawing.Color.White;
            this.btnTotalNormal.IdleForecolor = System.Drawing.Color.Gray;
            this.btnTotalNormal.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnTotalNormal.Location = new System.Drawing.Point(229, 5);
            this.btnTotalNormal.Margin = new System.Windows.Forms.Padding(5);
            this.btnTotalNormal.Name = "btnTotalNormal";
            this.btnTotalNormal.Size = new System.Drawing.Size(102, 79);
            this.btnTotalNormal.TabIndex = 160;
            this.btnTotalNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonoFlat_HeaderLabel5
            // 
            this.MonoFlat_HeaderLabel5.AutoSize = true;
            this.MonoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.MonoFlat_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.MonoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonoFlat_HeaderLabel5.Location = new System.Drawing.Point(9, 20);
            this.MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            this.MonoFlat_HeaderLabel5.Size = new System.Drawing.Size(62, 20);
            this.MonoFlat_HeaderLabel5.TabIndex = 33;
            this.MonoFlat_HeaderLabel5.Text = "Normal";
            // 
            // BackgroundClientes
            // 
            this.BackgroundClientes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundClientes_DoWork);
            this.BackgroundClientes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundClientes_RunWorkerCompleted);
            // 
            // BackgroundSolicitud
            // 
            this.BackgroundSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSolicitud_DoWork);
            this.BackgroundSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundSolicitud_RunWorkerCompleted);
            // 
            // BackgroundCalendario
            // 
            this.BackgroundCalendario.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCalendario_DoWork);
            this.BackgroundCalendario.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCalendario_RunWorkerCompleted);
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
            this.MonoFlat_HeaderLabel6.Size = new System.Drawing.Size(108, 20);
            this.MonoFlat_HeaderLabel6.TabIndex = 36;
            this.MonoFlat_HeaderLabel6.Text = "Monto Pagaré";
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
            // lblmontopagare
            // 
            this.lblmontopagare.AutoSize = true;
            this.lblmontopagare.BackColor = System.Drawing.Color.Transparent;
            this.lblmontopagare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblmontopagare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblmontopagare.Location = new System.Drawing.Point(15, 159);
            this.lblmontopagare.Name = "lblmontopagare";
            this.lblmontopagare.Size = new System.Drawing.Size(13, 20);
            this.lblmontopagare.TabIndex = 40;
            this.lblmontopagare.Text = ".";
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
            this.Panel2.Controls.Add(this.btn_convenio);
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this.BunifuThinButton23);
            this.Panel2.Controls.Add(this.BunifuThinButton21);
            this.Panel2.Controls.Add(this.btnGenerarCalendario);
            this.Panel2.Location = new System.Drawing.Point(596, 141);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(499, 85);
            this.Panel2.TabIndex = 157;
            // 
            // btn_convenio
            // 
            this.btn_convenio.ActiveBorderThickness = 1;
            this.btn_convenio.ActiveCornerRadius = 20;
            this.btn_convenio.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_convenio.ActiveForecolor = System.Drawing.Color.White;
            this.btn_convenio.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_convenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btn_convenio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_convenio.BackgroundImage")));
            this.btn_convenio.ButtonText = "Imprimir convenio";
            this.btn_convenio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_convenio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convenio.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_convenio.IdleBorderThickness = 1;
            this.btn_convenio.IdleCornerRadius = 20;
            this.btn_convenio.IdleFillColor = System.Drawing.Color.White;
            this.btn_convenio.IdleForecolor = System.Drawing.Color.Gray;
            this.btn_convenio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btn_convenio.Location = new System.Drawing.Point(387, 6);
            this.btn_convenio.Margin = new System.Windows.Forms.Padding(5);
            this.btn_convenio.Name = "btn_convenio";
            this.btn_convenio.Size = new System.Drawing.Size(102, 79);
            this.btn_convenio.TabIndex = 160;
            this.btn_convenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_convenio.Click += new System.EventHandler(this.btn_convenio_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::ConfiaAdmin.My.Resources.Resources.Logo_Confia;
            this.PictureBox1.Location = new System.Drawing.Point(5, 32);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(38, 32);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 159;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.PictureBox1.MouseHover += new System.EventHandler(this.PictureBox1_MouseHover);
            // 
            // BunifuThinButton23
            // 
            this.BunifuThinButton23.ActiveBorderThickness = 1;
            this.BunifuThinButton23.ActiveCornerRadius = 20;
            this.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.BunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton23.BackgroundImage")));
            this.BunifuThinButton23.ButtonText = "Agregar Gestión";
            this.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton23.ForeColor = System.Drawing.Color.DarkBlue;
            this.BunifuThinButton23.IdleBorderThickness = 1;
            this.BunifuThinButton23.IdleCornerRadius = 20;
            this.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Gray;
            this.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BunifuThinButton23.Location = new System.Drawing.Point(51, 6);
            this.BunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton23.Name = "BunifuThinButton23";
            this.BunifuThinButton23.Size = new System.Drawing.Size(102, 79);
            this.BunifuThinButton23.TabIndex = 158;
            this.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton23.Click += new System.EventHandler(this.BunifuThinButton23_Click);
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
            this.BunifuThinButton21.Location = new System.Drawing.Point(163, 6);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(102, 79);
            this.BunifuThinButton21.TabIndex = 156;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // btnGenerarCalendario
            // 
            this.btnGenerarCalendario.ActiveBorderThickness = 1;
            this.btnGenerarCalendario.ActiveCornerRadius = 20;
            this.btnGenerarCalendario.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnGenerarCalendario.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerarCalendario.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenerarCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.btnGenerarCalendario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarCalendario.BackgroundImage")));
            this.btnGenerarCalendario.ButtonText = "Agregar Documentos";
            this.btnGenerarCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarCalendario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCalendario.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGenerarCalendario.IdleBorderThickness = 1;
            this.btnGenerarCalendario.IdleCornerRadius = 20;
            this.btnGenerarCalendario.IdleFillColor = System.Drawing.Color.White;
            this.btnGenerarCalendario.IdleForecolor = System.Drawing.Color.Gray;
            this.btnGenerarCalendario.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.btnGenerarCalendario.Location = new System.Drawing.Point(275, 5);
            this.btnGenerarCalendario.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerarCalendario.Name = "btnGenerarCalendario";
            this.btnGenerarCalendario.Size = new System.Drawing.Size(102, 79);
            this.btnGenerarCalendario.TabIndex = 155;
            this.btnGenerarCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerarCalendario.Click += new System.EventHandler(this.btnGenerarCalendario_Click);
            // 
            // BackgroundGestiones
            // 
            this.BackgroundGestiones.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundGestiones_DoWork);
            this.BackgroundGestiones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundGestiones_RunWorkerCompleted);
            // 
            // BackgroundActualizaciones
            // 
            this.BackgroundActualizaciones.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundActualizaciones_DoWork);
            this.BackgroundActualizaciones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundActualizaciones_RunWorkerCompleted);
            // 
            // BackgroundComportamiento
            // 
            this.BackgroundComportamiento.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundComportamiento_DoWork);
            this.BackgroundComportamiento.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundComportamiento_RunWorkerCompleted);
            // 
            // BackgroundPromesas
            // 
            this.BackgroundPromesas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundPromesas_DoWork);
            this.BackgroundPromesas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundPromesas_RunWorkerCompleted);
            // 
            // ContextMenuPromesa
            // 
            this.ContextMenuPromesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReimprimirToolStripMenuItem});
            this.ContextMenuPromesa.Name = "ContextMenuPromesa";
            this.ContextMenuPromesa.Size = new System.Drawing.Size(134, 26);
            // 
            // ReimprimirToolStripMenuItem
            // 
            this.ReimprimirToolStripMenuItem.Name = "ReimprimirToolStripMenuItem";
            this.ReimprimirToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ReimprimirToolStripMenuItem.Text = "Reimprimir";
            this.ReimprimirToolStripMenuItem.Click += new System.EventHandler(this.ReimprimirToolStripMenuItem_Click);
            // 
            // BackgroundConcentrado
            // 
            this.BackgroundConcentrado.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundConcentrado_DoWork);
            this.BackgroundConcentrado.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundConcentrado_RunWorkerCompleted);
            // 
            // btn_Moto
            // 
            this.btn_Moto.Enabled = false;
            this.btn_Moto.Location = new System.Drawing.Point(493, 130);
            this.btn_Moto.Name = "btn_Moto";
            this.btn_Moto.Size = new System.Drawing.Size(27, 21);
            this.btn_Moto.TabIndex = 158;
            this.btn_Moto.Text = "+";
            this.btn_Moto.UseVisualStyleBackColor = true;
            this.btn_Moto.Click += new System.EventHandler(this.btn_Moto_Click);
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
            // InformacionSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1096, 687);
            this.Controls.Add(this.btn_Moto);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblmontopagare);
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
            this.Name = "InformacionSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de crédito";
            this.Load += new System.EventHandler(this.InformacionSolicitud_Load);
            this.MouseHover += new System.EventHandler(this.InformacionSolicitud_MouseHover);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSolicitud)).EndInit();
            this.TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCalendarios)).EndInit();
            this.TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdatosDocumentos)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGestiones)).EndInit();
            this.TabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtActualizaciones)).EndInit();
            this.TabPage8.ResumeLayout(false);
            this.TabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPromesas)).EndInit();
            this.TabPage10.ResumeLayout(false);
            this.TabPage10.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.FlowLayoutPanel4.ResumeLayout(false);
            this.FlowLayoutPanel3.ResumeLayout(false);
            this.FlowLayoutPanel2.ResumeLayout(false);
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ContextMenuPromesa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal EvolveControlBox EvolveControlBox1;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel1;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtClientes;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtSolicitud;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtCalendarios;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtdatosDocumentos;
        internal System.ComponentModel.BackgroundWorker BackgroundClientes;
        internal System.ComponentModel.BackgroundWorker BackgroundSolicitud;
        internal System.ComponentModel.BackgroundWorker BackgroundCalendario;
        internal System.ComponentModel.BackgroundWorker BackgroundDocumentos;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel2;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel3;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel4;
        internal MonoFlat.MonoFlat_HeaderLabel lblfecha;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel6;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel7;
        internal MonoFlat.MonoFlat_HeaderLabel lblnombre;
        internal MonoFlat.MonoFlat_HeaderLabel lblmonto;
        internal MonoFlat.MonoFlat_HeaderLabel lblmontopagare;
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
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton23;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnGenerarCalendario;
        internal TabPage TabPage6;
        internal TabPage TabPage7;
        internal System.ComponentModel.BackgroundWorker BackgroundGestiones;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizaciones;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtGestiones;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtActualizaciones;
        internal Bunifu.Framework.UI.BunifuThinButton2 btn_convenio;
        internal TabPage TabPage8;
        internal WinControls.ListView.TreeListView TreeListView2;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader11;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader14;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader15;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader16;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader21;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader17;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader18;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader22;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader20;
        internal System.ComponentModel.BackgroundWorker BackgroundComportamiento;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader12;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader13;
        internal TabPage TabPage9;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtPromesas;
        internal System.ComponentModel.BackgroundWorker BackgroundPromesas;
        internal ContextMenuStrip ContextMenuPromesa;
        internal ToolStripMenuItem ReimprimirToolStripMenuItem;
        internal WinControls.ListView.ContainerColumnHeader ContainerColumnHeader19;
        internal TabPage TabPage10;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel13;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel14;
        internal FlowLayoutPanel FlowLayoutPanel3;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnCreditoReestructura;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnMultasReestructura;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel15;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel10;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel11;
        internal FlowLayoutPanel FlowLayoutPanel2;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnCreditoConvenio;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnMultasConvenio;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel12;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel9;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel8;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnCreditoNormal;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnMultasNormal;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal System.ComponentModel.BackgroundWorker BackgroundConcentrado;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnTotalReestructura;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnTotalConvenio;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnTotalNormal;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel22;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel19;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel20;
        internal FlowLayoutPanel FlowLayoutPanel4;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnCreditoTotal;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnMultasTotal;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnTotal;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel21;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel18;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel17;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel16;
        internal Button btn_Moto;
        internal MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel23;
        internal MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel24;
        internal MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel25;
        internal FlowLayoutPanel flowLayoutPanel5;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnCreditoTerminal;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnMultasTerminal;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnTotalTerminal;
        internal MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel26;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Tipo;
    }
}