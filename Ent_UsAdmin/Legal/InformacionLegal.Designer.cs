using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ConfiaAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InformacionLegal : Form
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
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle19 = new DataGridViewCellStyle();
            var DataGridViewCellStyle20 = new DataGridViewCellStyle();
            var DataGridViewCellStyle21 = new DataGridViewCellStyle();
            var DataGridViewCellStyle22 = new DataGridViewCellStyle();
            var DataGridViewCellStyle23 = new DataGridViewCellStyle();
            var DataGridViewCellStyle24 = new DataGridViewCellStyle();
            var DataGridViewCellStyle25 = new DataGridViewCellStyle();
            var DataGridViewCellStyle26 = new DataGridViewCellStyle();
            var DataGridViewCellStyle27 = new DataGridViewCellStyle();
            var DataGridViewCellStyle28 = new DataGridViewCellStyle();
            var DataGridViewCellStyle29 = new DataGridViewCellStyle();
            var DataGridViewCellStyle30 = new DataGridViewCellStyle();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionLegal));
            Panel1 = new Panel();
            Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            Panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            EvolveControlBox1 = new EvolveControlBox();
            MonoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            dtClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            TabPage2 = new TabPage();
            dtSolicitud = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtSolicitud.CellDoubleClick += new DataGridViewCellEventHandler(dtSolicitud_CellDoubleClick);
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            TabPage3 = new TabPage();
            dtCalendarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            TabPage4 = new TabPage();
            dtdatosDocumentos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtdatosDocumentos.CellContentDoubleClick += new DataGridViewCellEventHandler(dtdatosDocumentos_CellContentDoubleClick);
            TabPage5 = new TabPage();
            TreeListView1 = new WinControls.ListView.TreeListView();
            ContainerColumnHeader1 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader2 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader3 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader10 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader9 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader4 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader5 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader6 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader7 = new WinControls.ListView.ContainerColumnHeader();
            ContainerColumnHeader8 = new WinControls.ListView.ContainerColumnHeader();
            TabPage6 = new TabPage();
            dtGestiones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            TabPage7 = new TabPage();
            dtActualizaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            TabPage8 = new TabPage();
            dtGastos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            BackgroundClientes = new System.ComponentModel.BackgroundWorker();
            BackgroundClientes.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundClientes_DoWork);
            BackgroundClientes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundClientes_RunWorkerCompleted);
            BackgroundSolicitud = new System.ComponentModel.BackgroundWorker();
            BackgroundSolicitud.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundSolicitud_DoWork);
            BackgroundSolicitud.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundSolicitud_RunWorkerCompleted);
            BackgroundCalendario = new System.ComponentModel.BackgroundWorker();
            BackgroundCalendario.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCalendario_DoWork);
            BackgroundCalendario.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCalendario_RunWorkerCompleted);
            BackgroundDocumentos = new System.ComponentModel.BackgroundWorker();
            BackgroundDocumentos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundDocumentos_DoWork);
            BackgroundDocumentos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundDocumentos_RunWorkerCompleted);
            MonoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel4 = new MonoFlat.MonoFlat_HeaderLabel();
            lblfecha = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel6 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel7 = new MonoFlat.MonoFlat_HeaderLabel();
            lblnombre = new MonoFlat.MonoFlat_HeaderLabel();
            lblParteCredito = new MonoFlat.MonoFlat_HeaderLabel();
            lblParteMoratorios = new MonoFlat.MonoFlat_HeaderLabel();
            lblSubTotal = new MonoFlat.MonoFlat_HeaderLabel();
            BackgroundPagos = new System.ComponentModel.BackgroundWorker();
            BackgroundPagos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundPagos_DoWork);
            BackgroundPagos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundPagos_RunWorkerCompleted);
            lblAbonado = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel10 = new MonoFlat.MonoFlat_HeaderLabel();
            lblRestante = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel12 = new MonoFlat.MonoFlat_HeaderLabel();
            Panel2 = new Panel();
            BunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton24.Click += new EventHandler(BunifuThinButton24_Click);
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            PictureBox1.MouseHover += new EventHandler(PictureBox1_MouseHover);
            BunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton23.Click += new EventHandler(BunifuThinButton23_Click);
            BunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton22.Click += new EventHandler(BunifuThinButton22_Click);
            BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            BunifuThinButton21.Click += new EventHandler(BunifuThinButton21_Click);
            btnGenerarCalendario = new Bunifu.Framework.UI.BunifuThinButton2();
            btnGenerarCalendario.Click += new EventHandler(btnGenerarCalendario_Click);
            BackgroundGestiones = new System.ComponentModel.BackgroundWorker();
            BackgroundGestiones.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGestiones_DoWork);
            BackgroundGestiones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGestiones_RunWorkerCompleted);
            BackgroundActualizaciones = new System.ComponentModel.BackgroundWorker();
            BackgroundActualizaciones.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundActualizaciones_DoWork);
            BackgroundActualizaciones.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundActualizaciones_RunWorkerCompleted);
            BackgroundGastos = new System.ComponentModel.BackgroundWorker();
            BackgroundGastos.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundGastos_DoWork);
            BackgroundGastos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundGastos_RunWorkerCompleted);
            BackgroundCalConvenio = new System.ComponentModel.BackgroundWorker();
            BackgroundCalConvenio.DoWork += new System.ComponentModel.DoWorkEventHandler(BackgroundCalConvenio_DoWork);
            BackgroundCalConvenio.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundCalConvenio_RunWorkerCompleted);
            MonoFlat_HeaderLabel8 = new MonoFlat.MonoFlat_HeaderLabel();
            lblTotal = new MonoFlat.MonoFlat_HeaderLabel();
            lblConvenio = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel9 = new MonoFlat.MonoFlat_HeaderLabel();
            lblgastos = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel11 = new MonoFlat.MonoFlat_HeaderLabel();
            MonoFlat_HeaderLabel5 = new MonoFlat.MonoFlat_HeaderLabel();
            lblMultas = new MonoFlat.MonoFlat_HeaderLabel();
            Panel1.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtClientes).BeginInit();
            TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtSolicitud).BeginInit();
            TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCalendarios).BeginInit();
            TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).BeginInit();
            TabPage5.SuspendLayout();
            TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGestiones).BeginInit();
            TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtActualizaciones).BeginInit();
            TabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGastos).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.FromArgb(14, 21, 38);
            Panel1.Controls.Add(EvolveControlBox1);
            Panel1.Controls.Add(MonoFlat_HeaderLabel1);
            Panel1.Location = new Point(1, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1130, 36);
            Panel1.TabIndex = 4;
            // 
            // EvolveControlBox1
            // 
            EvolveControlBox1.Colors = new Bloom[0];
            EvolveControlBox1.Customization = "";
            EvolveControlBox1.Font = new Font("Verdana", 8.0f);
            EvolveControlBox1.Image = null;
            EvolveControlBox1.Location = new Point(1025, 3);
            EvolveControlBox1.MaxButton = false;
            EvolveControlBox1.MinButton = true;
            EvolveControlBox1.Name = "EvolveControlBox1";
            EvolveControlBox1.NoRounding = false;
            EvolveControlBox1.Size = new Size(66, 16);
            EvolveControlBox1.TabIndex = 31;
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
            MonoFlat_HeaderLabel1.Size = new Size(231, 20);
            MonoFlat_HeaderLabel1.TabIndex = 1;
            MonoFlat_HeaderLabel1.Text = "Información de crédito en Legal";
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Controls.Add(TabPage4);
            TabControl1.Controls.Add(TabPage5);
            TabControl1.Controls.Add(TabPage6);
            TabControl1.Controls.Add(TabPage7);
            TabControl1.Controls.Add(TabPage8);
            TabControl1.Location = new Point(8, 330);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1084, 387);
            TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.FromArgb(0, 5, 11);
            TabPage1.Controls.Add(dtClientes);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1076, 361);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Clientes";
            // 
            // dtClientes
            // 
            dtClientes.AllowUserToAddRows = false;
            dtClientes.AllowUserToDeleteRows = false;
            DataGridViewCellStyle16.BackColor = Color.FromArgb(224, 224, 224);
            dtClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16;
            dtClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtClientes.BackgroundColor = Color.Gainsboro;
            dtClientes.BorderStyle = BorderStyle.None;
            dtClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle17.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle17.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle17.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dtClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17;
            dtClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtClientes.DoubleBuffered = true;
            dtClientes.EnableHeadersVisualStyles = false;
            dtClientes.HeaderBgColor = Color.DarkSlateGray;
            dtClientes.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtClientes.Location = new Point(6, 6);
            dtClientes.Name = "dtClientes";
            dtClientes.ReadOnly = true;
            dtClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtClientes.RowHeadersVisible = false;
            dtClientes.Size = new Size(1064, 349);
            dtClientes.TabIndex = 1;
            // 
            // TabPage2
            // 
            TabPage2.BackColor = Color.FromArgb(0, 5, 11);
            TabPage2.Controls.Add(dtSolicitud);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(1076, 361);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Solicitud";
            // 
            // dtSolicitud
            // 
            dtSolicitud.AllowUserToAddRows = false;
            dtSolicitud.AllowUserToDeleteRows = false;
            DataGridViewCellStyle18.BackColor = Color.FromArgb(224, 224, 224);
            dtSolicitud.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18;
            dtSolicitud.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtSolicitud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtSolicitud.BackgroundColor = Color.Gainsboro;
            dtSolicitud.BorderStyle = BorderStyle.None;
            dtSolicitud.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle19.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle19.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle19.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dtSolicitud.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19;
            dtSolicitud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSolicitud.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, Fecha, DataGridViewTextBoxColumn2, Monto, Tipo });
            dtSolicitud.DoubleBuffered = true;
            dtSolicitud.EnableHeadersVisualStyles = false;
            dtSolicitud.HeaderBgColor = Color.DarkSlateGray;
            dtSolicitud.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtSolicitud.Location = new Point(6, 6);
            dtSolicitud.Name = "dtSolicitud";
            dtSolicitud.ReadOnly = true;
            dtSolicitud.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtSolicitud.RowHeadersVisible = false;
            dtSolicitud.Size = new Size(1066, 349);
            dtSolicitud.TabIndex = 5;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.HeaderText = "Id";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Width = 42;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 68;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.HeaderText = "Monto Solicitado";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.ReadOnly = true;
            DataGridViewTextBoxColumn2.Width = 122;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto Autorizado";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 126;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Visible = false;
            Tipo.Width = 55;
            // 
            // TabPage3
            // 
            TabPage3.BackColor = Color.FromArgb(0, 5, 11);
            TabPage3.Controls.Add(dtCalendarios);
            TabPage3.Location = new Point(4, 22);
            TabPage3.Name = "TabPage3";
            TabPage3.Size = new Size(1076, 361);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Calendario";
            // 
            // dtCalendarios
            // 
            dtCalendarios.AllowUserToAddRows = false;
            dtCalendarios.AllowUserToDeleteRows = false;
            DataGridViewCellStyle20.BackColor = Color.FromArgb(224, 224, 224);
            dtCalendarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle20;
            dtCalendarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtCalendarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtCalendarios.BackgroundColor = Color.Gainsboro;
            dtCalendarios.BorderStyle = BorderStyle.None;
            dtCalendarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle21.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle21.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle21.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dtCalendarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21;
            dtCalendarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCalendarios.DoubleBuffered = true;
            dtCalendarios.EnableHeadersVisualStyles = false;
            dtCalendarios.HeaderBgColor = Color.DarkSlateGray;
            dtCalendarios.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtCalendarios.Location = new Point(5, 6);
            dtCalendarios.Name = "dtCalendarios";
            dtCalendarios.ReadOnly = true;
            dtCalendarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtCalendarios.RowHeadersVisible = false;
            dtCalendarios.Size = new Size(1066, 349);
            dtCalendarios.TabIndex = 6;
            // 
            // TabPage4
            // 
            TabPage4.BackColor = Color.FromArgb(0, 5, 11);
            TabPage4.Controls.Add(dtdatosDocumentos);
            TabPage4.Location = new Point(4, 22);
            TabPage4.Name = "TabPage4";
            TabPage4.Size = new Size(1076, 361);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "Documentos";
            // 
            // dtdatosDocumentos
            // 
            dtdatosDocumentos.AllowUserToAddRows = false;
            dtdatosDocumentos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle22.BackColor = Color.FromArgb(224, 224, 224);
            dtdatosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22;
            dtdatosDocumentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtdatosDocumentos.BackgroundColor = Color.Gainsboro;
            dtdatosDocumentos.BorderStyle = BorderStyle.None;
            dtdatosDocumentos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle23.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle23.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle23.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dtdatosDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23;
            dtdatosDocumentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtdatosDocumentos.DoubleBuffered = true;
            dtdatosDocumentos.EnableHeadersVisualStyles = false;
            dtdatosDocumentos.HeaderBgColor = Color.DarkSlateGray;
            dtdatosDocumentos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtdatosDocumentos.Location = new Point(3, 3);
            dtdatosDocumentos.Name = "dtdatosDocumentos";
            dtdatosDocumentos.ReadOnly = true;
            dtdatosDocumentos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtdatosDocumentos.RowHeadersVisible = false;
            dtdatosDocumentos.Size = new Size(1069, 349);
            dtdatosDocumentos.TabIndex = 27;
            // 
            // TabPage5
            // 
            TabPage5.Controls.Add(TreeListView1);
            TabPage5.Location = new Point(4, 22);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(1076, 361);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "Pagos";
            TabPage5.UseVisualStyleBackColor = true;
            // 
            // TreeListView1
            // 
            TreeListView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TreeListView1.Columns.AddRange(new WinControls.ListView.ContainerColumnHeader[] { ContainerColumnHeader1, ContainerColumnHeader2, ContainerColumnHeader3, ContainerColumnHeader10, ContainerColumnHeader9, ContainerColumnHeader4, ContainerColumnHeader5, ContainerColumnHeader6, ContainerColumnHeader7, ContainerColumnHeader8 });
            TreeListView1.Font = new Font("Microsoft Sans Serif", 8.25f);
            TreeListView1.Location = new Point(0, 5);
            TreeListView1.Name = "TreeListView1";
            TreeListView1.Size = new Size(1076, 349);
            TreeListView1.TabIndex = 3;
            // 
            // ContainerColumnHeader1
            // 
            ContainerColumnHeader1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader1.Text = "Id Ticket";
            ContainerColumnHeader1.Width = 175;
            // 
            // ContainerColumnHeader2
            // 
            ContainerColumnHeader2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader2.Text = "Id Legal";
            ContainerColumnHeader2.Width = 72;
            // 
            // ContainerColumnHeader3
            // 
            ContainerColumnHeader3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader3.Text = "Nombre";
            ContainerColumnHeader3.Width = 296;
            // 
            // ContainerColumnHeader10
            // 
            ContainerColumnHeader10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader10.Text = "Pago Normal";
            ContainerColumnHeader10.Width = 99;
            // 
            // ContainerColumnHeader9
            // 
            ContainerColumnHeader9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader9.Text = "Intereses";
            ContainerColumnHeader9.Width = 75;
            // 
            // ContainerColumnHeader4
            // 
            ContainerColumnHeader4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader4.Text = "Monto";
            ContainerColumnHeader4.Width = 70;
            // 
            // ContainerColumnHeader5
            // 
            ContainerColumnHeader5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader5.Text = "Fecha";
            ContainerColumnHeader5.Width = 77;
            // 
            // ContainerColumnHeader6
            // 
            ContainerColumnHeader6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader6.Text = "Hora";
            ContainerColumnHeader6.Width = 64;
            // 
            // ContainerColumnHeader7
            // 
            ContainerColumnHeader7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader7.Text = "Tipo";
            ContainerColumnHeader7.Width = 75;
            // 
            // ContainerColumnHeader8
            // 
            ContainerColumnHeader8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContainerColumnHeader8.Text = "Caja";
            ContainerColumnHeader8.Width = 54;
            // 
            // TabPage6
            // 
            TabPage6.Controls.Add(dtGestiones);
            TabPage6.Location = new Point(4, 22);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(1076, 361);
            TabPage6.TabIndex = 5;
            TabPage6.Text = "Gestiones";
            TabPage6.UseVisualStyleBackColor = true;
            // 
            // dtGestiones
            // 
            dtGestiones.AllowUserToAddRows = false;
            dtGestiones.AllowUserToDeleteRows = false;
            DataGridViewCellStyle24.BackColor = Color.FromArgb(224, 224, 224);
            dtGestiones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle24;
            dtGestiones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtGestiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGestiones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtGestiones.BackgroundColor = Color.Gainsboro;
            dtGestiones.BorderStyle = BorderStyle.None;
            dtGestiones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle25.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle25.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle25.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dtGestiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25;
            dtGestiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle26.BackColor = SystemColors.Window;
            DataGridViewCellStyle26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle26.ForeColor = SystemColors.ControlText;
            DataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            dtGestiones.DefaultCellStyle = DataGridViewCellStyle26;
            dtGestiones.DoubleBuffered = true;
            dtGestiones.EnableHeadersVisualStyles = false;
            dtGestiones.HeaderBgColor = Color.DarkSlateGray;
            dtGestiones.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtGestiones.Location = new Point(5, 6);
            dtGestiones.Name = "dtGestiones";
            dtGestiones.ReadOnly = true;
            dtGestiones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtGestiones.RowHeadersVisible = false;
            dtGestiones.Size = new Size(1066, 349);
            dtGestiones.TabIndex = 7;
            // 
            // TabPage7
            // 
            TabPage7.Controls.Add(dtActualizaciones);
            TabPage7.Location = new Point(4, 22);
            TabPage7.Name = "TabPage7";
            TabPage7.Padding = new Padding(3);
            TabPage7.Size = new Size(1076, 361);
            TabPage7.TabIndex = 6;
            TabPage7.Text = "Actualizaciones";
            TabPage7.UseVisualStyleBackColor = true;
            // 
            // dtActualizaciones
            // 
            dtActualizaciones.AllowUserToAddRows = false;
            dtActualizaciones.AllowUserToDeleteRows = false;
            DataGridViewCellStyle27.BackColor = Color.FromArgb(224, 224, 224);
            dtActualizaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27;
            dtActualizaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtActualizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtActualizaciones.BackgroundColor = Color.Gainsboro;
            dtActualizaciones.BorderStyle = BorderStyle.None;
            dtActualizaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle28.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle28.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle28.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle28.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle28.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle28.WrapMode = DataGridViewTriState.True;
            dtActualizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28;
            dtActualizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtActualizaciones.DoubleBuffered = true;
            dtActualizaciones.EnableHeadersVisualStyles = false;
            dtActualizaciones.HeaderBgColor = Color.DarkSlateGray;
            dtActualizaciones.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtActualizaciones.Location = new Point(6, 6);
            dtActualizaciones.Name = "dtActualizaciones";
            dtActualizaciones.ReadOnly = true;
            dtActualizaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtActualizaciones.RowHeadersVisible = false;
            dtActualizaciones.Size = new Size(1064, 349);
            dtActualizaciones.TabIndex = 2;
            // 
            // TabPage8
            // 
            TabPage8.Controls.Add(dtGastos);
            TabPage8.Location = new Point(4, 22);
            TabPage8.Name = "TabPage8";
            TabPage8.Size = new Size(1076, 361);
            TabPage8.TabIndex = 7;
            TabPage8.Text = "Gastos";
            TabPage8.UseVisualStyleBackColor = true;
            // 
            // dtGastos
            // 
            dtGastos.AllowUserToAddRows = false;
            dtGastos.AllowUserToDeleteRows = false;
            DataGridViewCellStyle29.BackColor = Color.FromArgb(224, 224, 224);
            dtGastos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29;
            dtGastos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dtGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGastos.BackgroundColor = Color.Gainsboro;
            dtGastos.BorderStyle = BorderStyle.None;
            dtGastos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle30.BackColor = Color.DarkSlateGray;
            DataGridViewCellStyle30.Font = new Font("Century Gothic", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle30.ForeColor = Color.FromArgb(223, 223, 223);
            DataGridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            dtGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30;
            dtGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGastos.DoubleBuffered = true;
            dtGastos.EnableHeadersVisualStyles = false;
            dtGastos.HeaderBgColor = Color.DarkSlateGray;
            dtGastos.HeaderForeColor = Color.FromArgb(223, 223, 223);
            dtGastos.Location = new Point(6, 6);
            dtGastos.Name = "dtGastos";
            dtGastos.ReadOnly = true;
            dtGastos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtGastos.RowHeadersVisible = false;
            dtGastos.Size = new Size(1064, 349);
            dtGastos.TabIndex = 3;
            // 
            // BackgroundClientes
            // 
            // 
            // BackgroundSolicitud
            // 
            // 
            // BackgroundCalendario
            // 
            // 
            // BackgroundDocumentos
            // 
            // 
            // MonoFlat_HeaderLabel2
            // 
            MonoFlat_HeaderLabel2.AutoSize = true;
            MonoFlat_HeaderLabel2.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel2.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel2.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel2.Location = new Point(14, 54);
            MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2";
            MonoFlat_HeaderLabel2.Size = new Size(67, 20);
            MonoFlat_HeaderLabel2.TabIndex = 32;
            MonoFlat_HeaderLabel2.Text = "Nombre";
            // 
            // MonoFlat_HeaderLabel3
            // 
            MonoFlat_HeaderLabel3.AutoSize = true;
            MonoFlat_HeaderLabel3.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel3.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel3.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel3.Location = new Point(432, 54);
            MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3";
            MonoFlat_HeaderLabel3.Size = new Size(131, 20);
            MonoFlat_HeaderLabel3.TabIndex = 33;
            MonoFlat_HeaderLabel3.Text = "Fecha de traslado";
            // 
            // MonoFlat_HeaderLabel4
            // 
            MonoFlat_HeaderLabel4.AutoSize = true;
            MonoFlat_HeaderLabel4.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel4.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel4.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel4.Location = new Point(697, 54);
            MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4";
            MonoFlat_HeaderLabel4.Size = new Size(101, 20);
            MonoFlat_HeaderLabel4.TabIndex = 34;
            MonoFlat_HeaderLabel4.Text = "Parte Crédito";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.BackColor = Color.Transparent;
            lblfecha.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblfecha.ForeColor = Color.FromArgb(255, 255, 255);
            lblfecha.Location = new Point(432, 80);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(13, 20);
            lblfecha.TabIndex = 35;
            lblfecha.Text = ".";
            // 
            // MonoFlat_HeaderLabel6
            // 
            MonoFlat_HeaderLabel6.AutoSize = true;
            MonoFlat_HeaderLabel6.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel6.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel6.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel6.Location = new Point(925, 54);
            MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6";
            MonoFlat_HeaderLabel6.Size = new Size(128, 20);
            MonoFlat_HeaderLabel6.TabIndex = 36;
            MonoFlat_HeaderLabel6.Text = "Parte Moratorios";
            // 
            // MonoFlat_HeaderLabel7
            // 
            MonoFlat_HeaderLabel7.AutoSize = true;
            MonoFlat_HeaderLabel7.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel7.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel7.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel7.Location = new Point(11, 130);
            MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7";
            MonoFlat_HeaderLabel7.Size = new Size(70, 20);
            MonoFlat_HeaderLabel7.TabIndex = 37;
            MonoFlat_HeaderLabel7.Text = "SubTotal";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.Transparent;
            lblnombre.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblnombre.ForeColor = Color.FromArgb(255, 255, 255);
            lblnombre.Location = new Point(14, 80);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(13, 20);
            lblnombre.TabIndex = 38;
            lblnombre.Text = ".";
            // 
            // lblParteCredito
            // 
            lblParteCredito.AutoSize = true;
            lblParteCredito.BackColor = Color.Transparent;
            lblParteCredito.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblParteCredito.ForeColor = Color.FromArgb(255, 255, 255);
            lblParteCredito.Location = new Point(697, 80);
            lblParteCredito.Name = "lblParteCredito";
            lblParteCredito.Size = new Size(13, 20);
            lblParteCredito.TabIndex = 39;
            lblParteCredito.Text = ".";
            // 
            // lblParteMoratorios
            // 
            lblParteMoratorios.AutoSize = true;
            lblParteMoratorios.BackColor = Color.Transparent;
            lblParteMoratorios.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblParteMoratorios.ForeColor = Color.FromArgb(255, 255, 255);
            lblParteMoratorios.Location = new Point(925, 84);
            lblParteMoratorios.Name = "lblParteMoratorios";
            lblParteMoratorios.Size = new Size(13, 20);
            lblParteMoratorios.TabIndex = 40;
            lblParteMoratorios.Text = ".";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblSubTotal.ForeColor = Color.FromArgb(255, 255, 255);
            lblSubTotal.Location = new Point(11, 160);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(13, 20);
            lblSubTotal.TabIndex = 41;
            lblSubTotal.Text = ".";
            // 
            // BackgroundPagos
            // 
            // 
            // lblAbonado
            // 
            lblAbonado.AutoSize = true;
            lblAbonado.BackColor = Color.Transparent;
            lblAbonado.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblAbonado.ForeColor = Color.FromArgb(255, 255, 255);
            lblAbonado.Location = new Point(432, 233);
            lblAbonado.Name = "lblAbonado";
            lblAbonado.Size = new Size(13, 20);
            lblAbonado.TabIndex = 45;
            lblAbonado.Text = ".";
            // 
            // MonoFlat_HeaderLabel10
            // 
            MonoFlat_HeaderLabel10.AutoSize = true;
            MonoFlat_HeaderLabel10.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel10.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel10.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel10.Location = new Point(432, 203);
            MonoFlat_HeaderLabel10.Name = "MonoFlat_HeaderLabel10";
            MonoFlat_HeaderLabel10.Size = new Size(73, 20);
            MonoFlat_HeaderLabel10.TabIndex = 44;
            MonoFlat_HeaderLabel10.Text = "Abonado";
            // 
            // lblRestante
            // 
            lblRestante.AutoSize = true;
            lblRestante.BackColor = Color.Transparent;
            lblRestante.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblRestante.ForeColor = Color.FromArgb(255, 255, 255);
            lblRestante.Location = new Point(697, 233);
            lblRestante.Name = "lblRestante";
            lblRestante.Size = new Size(13, 20);
            lblRestante.TabIndex = 47;
            lblRestante.Text = ".";
            // 
            // MonoFlat_HeaderLabel12
            // 
            MonoFlat_HeaderLabel12.AutoSize = true;
            MonoFlat_HeaderLabel12.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel12.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel12.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel12.Location = new Point(697, 203);
            MonoFlat_HeaderLabel12.Name = "MonoFlat_HeaderLabel12";
            MonoFlat_HeaderLabel12.Size = new Size(71, 20);
            MonoFlat_HeaderLabel12.TabIndex = 46;
            MonoFlat_HeaderLabel12.Text = "Restante";
            // 
            // Panel2
            // 
            Panel2.Controls.Add(BunifuThinButton24);
            Panel2.Controls.Add(PictureBox1);
            Panel2.Controls.Add(BunifuThinButton23);
            Panel2.Controls.Add(BunifuThinButton22);
            Panel2.Controls.Add(BunifuThinButton21);
            Panel2.Controls.Add(btnGenerarCalendario);
            Panel2.Location = new Point(477, 264);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(615, 85);
            Panel2.TabIndex = 156;
            // 
            // BunifuThinButton24
            // 
            BunifuThinButton24.ActiveBorderThickness = 1;
            BunifuThinButton24.ActiveCornerRadius = 20;
            BunifuThinButton24.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton24.ActiveForecolor = Color.White;
            BunifuThinButton24.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton24.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton24.BackgroundImage = (Image)resources.GetObject("BunifuThinButton24.BackgroundImage");
            BunifuThinButton24.ButtonText = "Agregar Gastos";
            BunifuThinButton24.Cursor = Cursors.Hand;
            BunifuThinButton24.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton24.ForeColor = Color.DarkBlue;
            BunifuThinButton24.IdleBorderThickness = 1;
            BunifuThinButton24.IdleCornerRadius = 20;
            BunifuThinButton24.IdleFillColor = Color.White;
            BunifuThinButton24.IdleForecolor = Color.Gray;
            BunifuThinButton24.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton24.Location = new Point(507, 5);
            BunifuThinButton24.Margin = new Padding(5);
            BunifuThinButton24.Name = "BunifuThinButton24";
            BunifuThinButton24.Size = new Size(102, 79);
            BunifuThinButton24.TabIndex = 160;
            BunifuThinButton24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Logo_Confia;
            PictureBox1.Location = new Point(14, 31);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(38, 32);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 159;
            PictureBox1.TabStop = false;
            // 
            // BunifuThinButton23
            // 
            BunifuThinButton23.ActiveBorderThickness = 1;
            BunifuThinButton23.ActiveCornerRadius = 20;
            BunifuThinButton23.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton23.ActiveForecolor = Color.White;
            BunifuThinButton23.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton23.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton23.BackgroundImage = (Image)resources.GetObject("BunifuThinButton23.BackgroundImage");
            BunifuThinButton23.ButtonText = "Agregar Gestión";
            BunifuThinButton23.Cursor = Cursors.Hand;
            BunifuThinButton23.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton23.ForeColor = Color.DarkBlue;
            BunifuThinButton23.IdleBorderThickness = 1;
            BunifuThinButton23.IdleCornerRadius = 20;
            BunifuThinButton23.IdleFillColor = Color.White;
            BunifuThinButton23.IdleForecolor = Color.Gray;
            BunifuThinButton23.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton23.Location = new Point(60, 5);
            BunifuThinButton23.Margin = new Padding(5);
            BunifuThinButton23.Name = "BunifuThinButton23";
            BunifuThinButton23.Size = new Size(102, 79);
            BunifuThinButton23.TabIndex = 158;
            BunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton22
            // 
            BunifuThinButton22.ActiveBorderThickness = 1;
            BunifuThinButton22.ActiveCornerRadius = 20;
            BunifuThinButton22.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton22.ActiveForecolor = Color.White;
            BunifuThinButton22.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton22.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton22.BackgroundImage = (Image)resources.GetObject("BunifuThinButton22.BackgroundImage");
            BunifuThinButton22.ButtonText = "Imprimir Convenio";
            BunifuThinButton22.Cursor = Cursors.Hand;
            BunifuThinButton22.Enabled = false;
            BunifuThinButton22.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton22.ForeColor = Color.DarkBlue;
            BunifuThinButton22.IdleBorderThickness = 1;
            BunifuThinButton22.IdleCornerRadius = 20;
            BunifuThinButton22.IdleFillColor = Color.White;
            BunifuThinButton22.IdleForecolor = Color.Gray;
            BunifuThinButton22.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton22.Location = new Point(283, 5);
            BunifuThinButton22.Margin = new Padding(5);
            BunifuThinButton22.Name = "BunifuThinButton22";
            BunifuThinButton22.Size = new Size(102, 79);
            BunifuThinButton22.TabIndex = 157;
            BunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BunifuThinButton21
            // 
            BunifuThinButton21.ActiveBorderThickness = 1;
            BunifuThinButton21.ActiveCornerRadius = 20;
            BunifuThinButton21.ActiveFillColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton21.ActiveForecolor = Color.White;
            BunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            BunifuThinButton21.BackColor = Color.FromArgb(0, 5, 11);
            BunifuThinButton21.BackgroundImage = (Image)resources.GetObject("BunifuThinButton21.BackgroundImage");
            BunifuThinButton21.ButtonText = "Actualizar Información";
            BunifuThinButton21.Cursor = Cursors.Hand;
            BunifuThinButton21.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BunifuThinButton21.ForeColor = Color.DarkBlue;
            BunifuThinButton21.IdleBorderThickness = 1;
            BunifuThinButton21.IdleCornerRadius = 20;
            BunifuThinButton21.IdleFillColor = Color.White;
            BunifuThinButton21.IdleForecolor = Color.Gray;
            BunifuThinButton21.IdleLineColor = Color.FromArgb(14, 21, 38);
            BunifuThinButton21.Location = new Point(172, 5);
            BunifuThinButton21.Margin = new Padding(5);
            BunifuThinButton21.Name = "BunifuThinButton21";
            BunifuThinButton21.Size = new Size(102, 79);
            BunifuThinButton21.TabIndex = 156;
            BunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerarCalendario
            // 
            btnGenerarCalendario.ActiveBorderThickness = 1;
            btnGenerarCalendario.ActiveCornerRadius = 20;
            btnGenerarCalendario.ActiveFillColor = Color.FromArgb(14, 21, 38);
            btnGenerarCalendario.ActiveForecolor = Color.White;
            btnGenerarCalendario.ActiveLineColor = Color.SeaGreen;
            btnGenerarCalendario.BackColor = Color.FromArgb(0, 5, 11);
            btnGenerarCalendario.BackgroundImage = (Image)resources.GetObject("btnGenerarCalendario.BackgroundImage");
            btnGenerarCalendario.ButtonText = "Agregar Documentos";
            btnGenerarCalendario.Cursor = Cursors.Hand;
            btnGenerarCalendario.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarCalendario.ForeColor = Color.DarkBlue;
            btnGenerarCalendario.IdleBorderThickness = 1;
            btnGenerarCalendario.IdleCornerRadius = 20;
            btnGenerarCalendario.IdleFillColor = Color.White;
            btnGenerarCalendario.IdleForecolor = Color.Gray;
            btnGenerarCalendario.IdleLineColor = Color.FromArgb(14, 21, 38);
            btnGenerarCalendario.Location = new Point(395, 5);
            btnGenerarCalendario.Margin = new Padding(5);
            btnGenerarCalendario.Name = "btnGenerarCalendario";
            btnGenerarCalendario.Size = new Size(102, 79);
            btnGenerarCalendario.TabIndex = 155;
            btnGenerarCalendario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundGestiones
            // 
            // 
            // BackgroundActualizaciones
            // 
            // 
            // BackgroundGastos
            // 
            // 
            // BackgroundCalConvenio
            // 
            // 
            // MonoFlat_HeaderLabel8
            // 
            MonoFlat_HeaderLabel8.AutoSize = true;
            MonoFlat_HeaderLabel8.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel8.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel8.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel8.Location = new Point(697, 130);
            MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8";
            MonoFlat_HeaderLabel8.Size = new Size(93, 20);
            MonoFlat_HeaderLabel8.TabIndex = 42;
            MonoFlat_HeaderLabel8.Text = "Deuda Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(255, 255, 255);
            lblTotal.Location = new Point(697, 160);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 20);
            lblTotal.TabIndex = 43;
            lblTotal.Text = ".";
            // 
            // lblConvenio
            // 
            lblConvenio.AutoSize = true;
            lblConvenio.BackColor = Color.Transparent;
            lblConvenio.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblConvenio.ForeColor = Color.FromArgb(255, 255, 255);
            lblConvenio.Location = new Point(925, 160);
            lblConvenio.Name = "lblConvenio";
            lblConvenio.Size = new Size(13, 20);
            lblConvenio.TabIndex = 158;
            lblConvenio.Text = ".";
            // 
            // MonoFlat_HeaderLabel9
            // 
            MonoFlat_HeaderLabel9.AutoSize = true;
            MonoFlat_HeaderLabel9.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel9.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel9.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel9.Location = new Point(925, 130);
            MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9";
            MonoFlat_HeaderLabel9.Size = new Size(123, 20);
            MonoFlat_HeaderLabel9.TabIndex = 157;
            MonoFlat_HeaderLabel9.Text = "Deuda Convenio";
            // 
            // lblgastos
            // 
            lblgastos.AutoSize = true;
            lblgastos.BackColor = Color.Transparent;
            lblgastos.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblgastos.ForeColor = Color.FromArgb(255, 255, 255);
            lblgastos.Location = new Point(432, 160);
            lblgastos.Name = "lblgastos";
            lblgastos.Size = new Size(13, 20);
            lblgastos.TabIndex = 160;
            lblgastos.Text = ".";
            // 
            // MonoFlat_HeaderLabel11
            // 
            MonoFlat_HeaderLabel11.AutoSize = true;
            MonoFlat_HeaderLabel11.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel11.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel11.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel11.Location = new Point(432, 130);
            MonoFlat_HeaderLabel11.Name = "MonoFlat_HeaderLabel11";
            MonoFlat_HeaderLabel11.Size = new Size(57, 20);
            MonoFlat_HeaderLabel11.TabIndex = 159;
            MonoFlat_HeaderLabel11.Text = "Gastos";
            // 
            // MonoFlat_HeaderLabel5
            // 
            MonoFlat_HeaderLabel5.AutoSize = true;
            MonoFlat_HeaderLabel5.BackColor = Color.Transparent;
            MonoFlat_HeaderLabel5.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            MonoFlat_HeaderLabel5.ForeColor = Color.FromArgb(255, 255, 255);
            MonoFlat_HeaderLabel5.Location = new Point(11, 203);
            MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5";
            MonoFlat_HeaderLabel5.Size = new Size(135, 20);
            MonoFlat_HeaderLabel5.TabIndex = 161;
            MonoFlat_HeaderLabel5.Text = "Multas Generadas";
            // 
            // lblMultas
            // 
            lblMultas.AutoSize = true;
            lblMultas.BackColor = Color.Transparent;
            lblMultas.Font = new Font("Segoe UI", 11.0f, FontStyle.Bold);
            lblMultas.ForeColor = Color.FromArgb(255, 255, 255);
            lblMultas.Location = new Point(11, 233);
            lblMultas.Name = "lblMultas";
            lblMultas.Size = new Size(13, 20);
            lblMultas.TabIndex = 162;
            lblMultas.Text = ".";
            // 
            // InformacionLegal
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(10, 10);
            BackColor = Color.FromArgb(0, 5, 11);
            ClientSize = new Size(1096, 731);
            Controls.Add(lblMultas);
            Controls.Add(MonoFlat_HeaderLabel5);
            Controls.Add(lblgastos);
            Controls.Add(MonoFlat_HeaderLabel11);
            Controls.Add(lblConvenio);
            Controls.Add(MonoFlat_HeaderLabel9);
            Controls.Add(Panel2);
            Controls.Add(lblRestante);
            Controls.Add(MonoFlat_HeaderLabel12);
            Controls.Add(lblAbonado);
            Controls.Add(MonoFlat_HeaderLabel10);
            Controls.Add(lblTotal);
            Controls.Add(MonoFlat_HeaderLabel8);
            Controls.Add(lblSubTotal);
            Controls.Add(lblParteMoratorios);
            Controls.Add(lblParteCredito);
            Controls.Add(lblnombre);
            Controls.Add(MonoFlat_HeaderLabel7);
            Controls.Add(MonoFlat_HeaderLabel6);
            Controls.Add(lblfecha);
            Controls.Add(MonoFlat_HeaderLabel4);
            Controls.Add(MonoFlat_HeaderLabel3);
            Controls.Add(MonoFlat_HeaderLabel2);
            Controls.Add(TabControl1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InformacionLegal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Información de crédito";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtClientes).EndInit();
            TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtSolicitud).EndInit();
            TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtCalendarios).EndInit();
            TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtdatosDocumentos).EndInit();
            TabPage5.ResumeLayout(false);
            TabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGestiones).EndInit();
            TabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtActualizaciones).EndInit();
            TabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGastos).EndInit();
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(InformacionSolicitud_Load);
            MouseHover += new EventHandler(InformacionLegal_MouseHover);
            ResumeLayout(false);
            PerformLayout();

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
        internal MonoFlat.MonoFlat_HeaderLabel lblParteCredito;
        internal MonoFlat.MonoFlat_HeaderLabel lblParteMoratorios;
        internal MonoFlat.MonoFlat_HeaderLabel lblSubTotal;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn Fecha;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn Monto;
        internal DataGridViewTextBoxColumn Tipo;
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
        internal MonoFlat.MonoFlat_HeaderLabel lblAbonado;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel10;
        internal MonoFlat.MonoFlat_HeaderLabel lblRestante;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel12;
        internal TabPage TabPage6;
        internal Bunifu.Framework.UI.BunifuThinButton2 btnGenerarCalendario;
        internal Panel Panel2;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton22;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton23;
        internal PictureBox PictureBox1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton24;
        internal TabPage TabPage7;
        internal TabPage TabPage8;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtGestiones;
        internal System.ComponentModel.BackgroundWorker BackgroundGestiones;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtActualizaciones;
        internal System.ComponentModel.BackgroundWorker BackgroundActualizaciones;
        internal Bunifu.Framework.UI.BunifuCustomDataGrid dtGastos;
        internal System.ComponentModel.BackgroundWorker BackgroundGastos;
        internal System.ComponentModel.BackgroundWorker BackgroundCalConvenio;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel8;
        internal MonoFlat.MonoFlat_HeaderLabel lblTotal;
        internal MonoFlat.MonoFlat_HeaderLabel lblConvenio;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel9;
        internal MonoFlat.MonoFlat_HeaderLabel lblgastos;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel11;
        internal MonoFlat.MonoFlat_HeaderLabel MonoFlat_HeaderLabel5;
        internal MonoFlat.MonoFlat_HeaderLabel lblMultas;
    }
}