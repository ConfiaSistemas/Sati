<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionSolicitud
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacionSolicitud))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtClientes = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtSolicitud = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dtCalendarios = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dtdatosDocumentos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TreeListView1 = New WinControls.ListView.TreeListView()
        Me.ContainerColumnHeader1 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader2 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader3 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader10 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader9 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader4 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader5 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader6 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader7 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader8 = New WinControls.ListView.ContainerColumnHeader()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dtGestiones = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.dtActualizaciones = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TreeListView2 = New WinControls.ListView.TreeListView()
        Me.ContainerColumnHeader13 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader11 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader12 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader14 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader15 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader16 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader21 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader17 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader18 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader22 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader20 = New WinControls.ListView.ContainerColumnHeader()
        Me.BackgroundClientes = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundSolicitud = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCalendario = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.MonoFlat_HeaderLabel2 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel3 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel4 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblfecha = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel6 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel7 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblnombre = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblmonto = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblmontopagare = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lbltipo = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundPagos = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_convenio = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGenerarCalendario = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundGestiones = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundActualizaciones = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundComportamiento = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtCalendarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dtGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.dtActualizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 36)
        Me.Panel1.TabIndex = 4
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(1025, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 31
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(169, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Información de crédito"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(8, 210)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 437)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dtClientes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        '
        'dtClientes
        '
        Me.dtClientes.AllowUserToAddRows = False
        Me.dtClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtClientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtClientes.DoubleBuffered = True
        Me.dtClientes.EnableHeadersVisualStyles = False
        Me.dtClientes.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtClientes.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtClientes.Location = New System.Drawing.Point(6, 6)
        Me.dtClientes.Name = "dtClientes"
        Me.dtClientes.ReadOnly = True
        Me.dtClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtClientes.RowHeadersVisible = False
        Me.dtClientes.Size = New System.Drawing.Size(1064, 399)
        Me.dtClientes.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dtSolicitud)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Solicitud"
        '
        'dtSolicitud
        '
        Me.dtSolicitud.AllowUserToAddRows = False
        Me.dtSolicitud.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtSolicitud.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtSolicitud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtSolicitud.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtSolicitud.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSolicitud.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Fecha, Me.DataGridViewTextBoxColumn2, Me.Monto, Me.Tipo})
        Me.dtSolicitud.DoubleBuffered = True
        Me.dtSolicitud.EnableHeadersVisualStyles = False
        Me.dtSolicitud.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtSolicitud.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtSolicitud.Location = New System.Drawing.Point(6, 6)
        Me.dtSolicitud.Name = "dtSolicitud"
        Me.dtSolicitud.ReadOnly = True
        Me.dtSolicitud.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtSolicitud.RowHeadersVisible = False
        Me.dtSolicitud.Size = New System.Drawing.Size(1066, 399)
        Me.dtSolicitud.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 42
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 68
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Monto Solicitado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 122
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto Autorizado"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 126
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Visible = False
        Me.Tipo.Width = 55
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.dtCalendarios)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Calendario"
        '
        'dtCalendarios
        '
        Me.dtCalendarios.AllowUserToAddRows = False
        Me.dtCalendarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtCalendarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtCalendarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCalendarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtCalendarios.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtCalendarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtCalendarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtCalendarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtCalendarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCalendarios.DoubleBuffered = True
        Me.dtCalendarios.EnableHeadersVisualStyles = False
        Me.dtCalendarios.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtCalendarios.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtCalendarios.Location = New System.Drawing.Point(5, 6)
        Me.dtCalendarios.Name = "dtCalendarios"
        Me.dtCalendarios.ReadOnly = True
        Me.dtCalendarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtCalendarios.RowHeadersVisible = False
        Me.dtCalendarios.Size = New System.Drawing.Size(1066, 399)
        Me.dtCalendarios.TabIndex = 6
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.dtdatosDocumentos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Documentos"
        '
        'dtdatosDocumentos
        '
        Me.dtdatosDocumentos.AllowUserToAddRows = False
        Me.dtdatosDocumentos.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dtdatosDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatosDocumentos.DoubleBuffered = True
        Me.dtdatosDocumentos.EnableHeadersVisualStyles = False
        Me.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatosDocumentos.Location = New System.Drawing.Point(3, 3)
        Me.dtdatosDocumentos.Name = "dtdatosDocumentos"
        Me.dtdatosDocumentos.ReadOnly = True
        Me.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatosDocumentos.RowHeadersVisible = False
        Me.dtdatosDocumentos.Size = New System.Drawing.Size(1069, 405)
        Me.dtdatosDocumentos.TabIndex = 27
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TreeListView1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Pagos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TreeListView1
        '
        Me.TreeListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeListView1.Columns.AddRange(New WinControls.ListView.ContainerColumnHeader() {Me.ContainerColumnHeader1, Me.ContainerColumnHeader2, Me.ContainerColumnHeader3, Me.ContainerColumnHeader10, Me.ContainerColumnHeader9, Me.ContainerColumnHeader4, Me.ContainerColumnHeader5, Me.ContainerColumnHeader6, Me.ContainerColumnHeader7, Me.ContainerColumnHeader8})
        Me.TreeListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TreeListView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeListView1.Name = "TreeListView1"
        Me.TreeListView1.Size = New System.Drawing.Size(1076, 411)
        Me.TreeListView1.TabIndex = 3
        '
        'ContainerColumnHeader1
        '
        Me.ContainerColumnHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader1.Text = "ID"
        '
        'ContainerColumnHeader2
        '
        Me.ContainerColumnHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader2.Text = "IdCrédito"
        '
        'ContainerColumnHeader3
        '
        Me.ContainerColumnHeader3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader3.Text = "Nombre"
        '
        'ContainerColumnHeader10
        '
        Me.ContainerColumnHeader10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader10.Text = "PagoNormal"
        '
        'ContainerColumnHeader9
        '
        Me.ContainerColumnHeader9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader9.Text = "Intereses"
        '
        'ContainerColumnHeader4
        '
        Me.ContainerColumnHeader4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader4.Text = "Monto"
        '
        'ContainerColumnHeader5
        '
        Me.ContainerColumnHeader5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader5.Text = "Fecha"
        '
        'ContainerColumnHeader6
        '
        Me.ContainerColumnHeader6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader6.Text = "Hora"
        '
        'ContainerColumnHeader7
        '
        Me.ContainerColumnHeader7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader7.Text = "Tipo"
        '
        'ContainerColumnHeader8
        '
        Me.ContainerColumnHeader8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader8.Text = "Caja"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dtGestiones)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Gestiones"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dtGestiones
        '
        Me.dtGestiones.AllowUserToAddRows = False
        Me.dtGestiones.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtGestiones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dtGestiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtGestiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtGestiones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtGestiones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtGestiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGestiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dtGestiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGestiones.DoubleBuffered = True
        Me.dtGestiones.EnableHeadersVisualStyles = False
        Me.dtGestiones.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtGestiones.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtGestiones.Location = New System.Drawing.Point(5, 6)
        Me.dtGestiones.Name = "dtGestiones"
        Me.dtGestiones.ReadOnly = True
        Me.dtGestiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtGestiones.RowHeadersVisible = False
        Me.dtGestiones.Size = New System.Drawing.Size(1066, 399)
        Me.dtGestiones.TabIndex = 7
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.dtActualizaciones)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Actualizaciones"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'dtActualizaciones
        '
        Me.dtActualizaciones.AllowUserToAddRows = False
        Me.dtActualizaciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtActualizaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dtActualizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtActualizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtActualizaciones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtActualizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtActualizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtActualizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dtActualizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtActualizaciones.DoubleBuffered = True
        Me.dtActualizaciones.EnableHeadersVisualStyles = False
        Me.dtActualizaciones.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtActualizaciones.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtActualizaciones.Location = New System.Drawing.Point(5, 6)
        Me.dtActualizaciones.Name = "dtActualizaciones"
        Me.dtActualizaciones.ReadOnly = True
        Me.dtActualizaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtActualizaciones.RowHeadersVisible = False
        Me.dtActualizaciones.Size = New System.Drawing.Size(1066, 399)
        Me.dtActualizaciones.TabIndex = 7
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.TreeListView2)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Comportamiento"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TreeListView2
        '
        Me.TreeListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeListView2.Columns.AddRange(New WinControls.ListView.ContainerColumnHeader() {Me.ContainerColumnHeader13, Me.ContainerColumnHeader11, Me.ContainerColumnHeader12, Me.ContainerColumnHeader14, Me.ContainerColumnHeader15, Me.ContainerColumnHeader16, Me.ContainerColumnHeader21, Me.ContainerColumnHeader17, Me.ContainerColumnHeader18, Me.ContainerColumnHeader22, Me.ContainerColumnHeader20})
        Me.TreeListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TreeListView2.Location = New System.Drawing.Point(8, 8)
        Me.TreeListView2.Name = "TreeListView2"
        Me.TreeListView2.Size = New System.Drawing.Size(1065, 411)
        Me.TreeListView2.TabIndex = 4
        '
        'ContainerColumnHeader13
        '
        Me.ContainerColumnHeader13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader13.Text = "Tipo de Pago"
        '
        'ContainerColumnHeader11
        '
        Me.ContainerColumnHeader11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader11.Text = "ID"
        '
        'ContainerColumnHeader12
        '
        Me.ContainerColumnHeader12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader12.Text = "NPago"
        '
        'ContainerColumnHeader14
        '
        Me.ContainerColumnHeader14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader14.Text = "PagoNormal"
        '
        'ContainerColumnHeader15
        '
        Me.ContainerColumnHeader15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader15.Text = "Intereses"
        '
        'ContainerColumnHeader16
        '
        Me.ContainerColumnHeader16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader16.Text = "Abonado"
        '
        'ContainerColumnHeader21
        '
        Me.ContainerColumnHeader21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader21.Text = "Pendiente"
        '
        'ContainerColumnHeader17
        '
        Me.ContainerColumnHeader17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader17.Text = "Fecha"
        '
        'ContainerColumnHeader18
        '
        Me.ContainerColumnHeader18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader18.Text = "Fecha de pago"
        '
        'ContainerColumnHeader22
        '
        Me.ContainerColumnHeader22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader22.Text = "Hora"
        '
        'ContainerColumnHeader20
        '
        Me.ContainerColumnHeader20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader20.Text = "Caja"
        '
        'BackgroundClientes
        '
        '
        'BackgroundSolicitud
        '
        '
        'BackgroundCalendario
        '
        '
        'BackgroundDocumentos
        '
        '
        'MonoFlat_HeaderLabel2
        '
        Me.MonoFlat_HeaderLabel2.AutoSize = True
        Me.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel2.Location = New System.Drawing.Point(14, 54)
        Me.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2"
        Me.MonoFlat_HeaderLabel2.Size = New System.Drawing.Size(67, 20)
        Me.MonoFlat_HeaderLabel2.TabIndex = 32
        Me.MonoFlat_HeaderLabel2.Text = "Nombre"
        '
        'MonoFlat_HeaderLabel3
        '
        Me.MonoFlat_HeaderLabel3.AutoSize = True
        Me.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel3.Location = New System.Drawing.Point(432, 54)
        Me.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3"
        Me.MonoFlat_HeaderLabel3.Size = New System.Drawing.Size(158, 20)
        Me.MonoFlat_HeaderLabel3.TabIndex = 33
        Me.MonoFlat_HeaderLabel3.Text = "Fecha de desembolso"
        '
        'MonoFlat_HeaderLabel4
        '
        Me.MonoFlat_HeaderLabel4.AutoSize = True
        Me.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel4.Location = New System.Drawing.Point(772, 54)
        Me.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4"
        Me.MonoFlat_HeaderLabel4.Size = New System.Drawing.Size(56, 20)
        Me.MonoFlat_HeaderLabel4.TabIndex = 34
        Me.MonoFlat_HeaderLabel4.Text = "Monto"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblfecha.Location = New System.Drawing.Point(432, 80)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(13, 20)
        Me.lblfecha.TabIndex = 35
        Me.lblfecha.Text = "."
        '
        'MonoFlat_HeaderLabel6
        '
        Me.MonoFlat_HeaderLabel6.AutoSize = True
        Me.MonoFlat_HeaderLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel6.Location = New System.Drawing.Point(15, 129)
        Me.MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6"
        Me.MonoFlat_HeaderLabel6.Size = New System.Drawing.Size(108, 20)
        Me.MonoFlat_HeaderLabel6.TabIndex = 36
        Me.MonoFlat_HeaderLabel6.Text = "Monto Pagaré"
        '
        'MonoFlat_HeaderLabel7
        '
        Me.MonoFlat_HeaderLabel7.AutoSize = True
        Me.MonoFlat_HeaderLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel7.Location = New System.Drawing.Point(432, 129)
        Me.MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7"
        Me.MonoFlat_HeaderLabel7.Size = New System.Drawing.Size(40, 20)
        Me.MonoFlat_HeaderLabel7.TabIndex = 37
        Me.MonoFlat_HeaderLabel7.Text = "Tipo"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblnombre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(14, 80)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(13, 20)
        Me.lblnombre.TabIndex = 38
        Me.lblnombre.Text = "."
        '
        'lblmonto
        '
        Me.lblmonto.AutoSize = True
        Me.lblmonto.BackColor = System.Drawing.Color.Transparent
        Me.lblmonto.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblmonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblmonto.Location = New System.Drawing.Point(772, 80)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(13, 20)
        Me.lblmonto.TabIndex = 39
        Me.lblmonto.Text = "."
        '
        'lblmontopagare
        '
        Me.lblmontopagare.AutoSize = True
        Me.lblmontopagare.BackColor = System.Drawing.Color.Transparent
        Me.lblmontopagare.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblmontopagare.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblmontopagare.Location = New System.Drawing.Point(15, 159)
        Me.lblmontopagare.Name = "lblmontopagare"
        Me.lblmontopagare.Size = New System.Drawing.Size(13, 20)
        Me.lblmontopagare.TabIndex = 40
        Me.lblmontopagare.Text = "."
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.BackColor = System.Drawing.Color.Transparent
        Me.lbltipo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbltipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltipo.Location = New System.Drawing.Point(432, 159)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(13, 20)
        Me.lbltipo.TabIndex = 41
        Me.lbltipo.Text = "."
        '
        'BackgroundPagos
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_convenio)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BunifuThinButton23)
        Me.Panel2.Controls.Add(Me.BunifuThinButton21)
        Me.Panel2.Controls.Add(Me.btnGenerarCalendario)
        Me.Panel2.Location = New System.Drawing.Point(596, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(499, 85)
        Me.Panel2.TabIndex = 157
        '
        'btn_convenio
        '
        Me.btn_convenio.ActiveBorderThickness = 1
        Me.btn_convenio.ActiveCornerRadius = 20
        Me.btn_convenio.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_convenio.ActiveForecolor = System.Drawing.Color.White
        Me.btn_convenio.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_convenio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_convenio.BackgroundImage = CType(resources.GetObject("btn_convenio.BackgroundImage"), System.Drawing.Image)
        Me.btn_convenio.ButtonText = "Imprimir convenio"
        Me.btn_convenio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_convenio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_convenio.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_convenio.IdleBorderThickness = 1
        Me.btn_convenio.IdleCornerRadius = 20
        Me.btn_convenio.IdleFillColor = System.Drawing.Color.White
        Me.btn_convenio.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_convenio.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_convenio.Location = New System.Drawing.Point(387, 6)
        Me.btn_convenio.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_convenio.Name = "btn_convenio"
        Me.btn_convenio.Size = New System.Drawing.Size(102, 79)
        Me.btn_convenio.TabIndex = 160
        Me.btn_convenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConfiaAdmin.My.Resources.Resources.Logo_Confia
        Me.PictureBox1.Location = New System.Drawing.Point(5, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Agregar Gestión"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.DarkBlue
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(51, 6)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(102, 79)
        Me.BunifuThinButton23.TabIndex = 158
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Actualizar Información"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(163, 6)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(102, 79)
        Me.BunifuThinButton21.TabIndex = 156
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarCalendario
        '
        Me.btnGenerarCalendario.ActiveBorderThickness = 1
        Me.btnGenerarCalendario.ActiveCornerRadius = 20
        Me.btnGenerarCalendario.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnGenerarCalendario.ActiveForecolor = System.Drawing.Color.White
        Me.btnGenerarCalendario.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnGenerarCalendario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnGenerarCalendario.BackgroundImage = CType(resources.GetObject("btnGenerarCalendario.BackgroundImage"), System.Drawing.Image)
        Me.btnGenerarCalendario.ButtonText = "Agregar Documentos"
        Me.btnGenerarCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerarCalendario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCalendario.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnGenerarCalendario.IdleBorderThickness = 1
        Me.btnGenerarCalendario.IdleCornerRadius = 20
        Me.btnGenerarCalendario.IdleFillColor = System.Drawing.Color.White
        Me.btnGenerarCalendario.IdleForecolor = System.Drawing.Color.Gray
        Me.btnGenerarCalendario.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnGenerarCalendario.Location = New System.Drawing.Point(275, 5)
        Me.btnGenerarCalendario.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGenerarCalendario.Name = "btnGenerarCalendario"
        Me.btnGenerarCalendario.Size = New System.Drawing.Size(102, 79)
        Me.btnGenerarCalendario.TabIndex = 155
        Me.btnGenerarCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundGestiones
        '
        '
        'BackgroundActualizaciones
        '
        '
        'BackgroundComportamiento
        '
        '
        'InformacionSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 687)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.lblmontopagare)
        Me.Controls.Add(Me.lblmonto)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel7)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel6)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel4)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel3)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformacionSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de crédito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dtCalendarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dtGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dtActualizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dtClientes As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtSolicitud As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtCalendarios As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtdatosDocumentos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundClientes As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundSolicitud As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundCalendario As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonoFlat_HeaderLabel2 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel3 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel4 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblfecha As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel6 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel7 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblnombre As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblmonto As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblmontopagare As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lbltipo As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TreeListView1 As WinControls.ListView.TreeListView
    Friend WithEvents ContainerColumnHeader1 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader2 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader3 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader10 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader9 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader4 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader5 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader6 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader7 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader8 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents BackgroundPagos As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGenerarCalendario As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents BackgroundGestiones As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundActualizaciones As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtGestiones As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtActualizaciones As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btn_convenio As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TreeListView2 As WinControls.ListView.TreeListView
    Friend WithEvents ContainerColumnHeader11 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader14 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader15 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader16 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader21 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader17 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader18 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader22 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader20 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents BackgroundComportamiento As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContainerColumnHeader12 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader13 As WinControls.ListView.ContainerColumnHeader
End Class
