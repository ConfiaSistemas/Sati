<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformacionEmpeño
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacionEmpeño))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtArticulos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtSolicitud = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.dtActualizaciones = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BackgroundArticulos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundSolicitud = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.MonoFlat_HeaderLabel2 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel3 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel4 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblfecha = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel6 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel7 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblnombre = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblmonto = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblmontorefrendo = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lbltipo = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundPagos = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnAgregarDocumentos = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundActualizaciones = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.dtActualizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(181, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Información del Empeño"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(8, 210)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 437)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dtArticulos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1076, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Artículos"
        '
        'dtArticulos
        '
        Me.dtArticulos.AllowUserToAddRows = False
        Me.dtArticulos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtArticulos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtArticulos.DoubleBuffered = True
        Me.dtArticulos.EnableHeadersVisualStyles = False
        Me.dtArticulos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtArticulos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtArticulos.Location = New System.Drawing.Point(6, 6)
        Me.dtArticulos.Name = "dtArticulos"
        Me.dtArticulos.ReadOnly = True
        Me.dtArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtArticulos.RowHeadersVisible = False
        Me.dtArticulos.Size = New System.Drawing.Size(1064, 399)
        Me.dtArticulos.TabIndex = 1
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
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtdatosDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatosDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatosDocumentos.DoubleBuffered = True
        Me.dtdatosDocumentos.EnableHeadersVisualStyles = False
        Me.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatosDocumentos.Location = New System.Drawing.Point(6, 6)
        Me.dtdatosDocumentos.Name = "dtdatosDocumentos"
        Me.dtdatosDocumentos.ReadOnly = True
        Me.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatosDocumentos.RowHeadersVisible = False
        Me.dtdatosDocumentos.RowTemplate.Height = 195
        Me.dtdatosDocumentos.Size = New System.Drawing.Size(1064, 399)
        Me.dtdatosDocumentos.TabIndex = 2
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtActualizaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dtActualizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtActualizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtActualizaciones.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtActualizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtActualizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtActualizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
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
        'BackgroundArticulos
        '
        '
        'BackgroundSolicitud
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
        Me.MonoFlat_HeaderLabel6.Size = New System.Drawing.Size(125, 20)
        Me.MonoFlat_HeaderLabel6.TabIndex = 36
        Me.MonoFlat_HeaderLabel6.Text = "Monto Refrendo"
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
        'lblmontorefrendo
        '
        Me.lblmontorefrendo.AutoSize = True
        Me.lblmontorefrendo.BackColor = System.Drawing.Color.Transparent
        Me.lblmontorefrendo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblmontorefrendo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblmontorefrendo.Location = New System.Drawing.Point(15, 159)
        Me.lblmontorefrendo.Name = "lblmontorefrendo"
        Me.lblmontorefrendo.Size = New System.Drawing.Size(13, 20)
        Me.lblmontorefrendo.TabIndex = 40
        Me.lblmontorefrendo.Text = "."
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
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BunifuThinButton21)
        Me.Panel2.Controls.Add(Me.btnAgregarDocumentos)
        Me.Panel2.Location = New System.Drawing.Point(814, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 85)
        Me.Panel2.TabIndex = 157
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConfiaAdmin.My.Resources.Resources.Logo_Confia
        Me.PictureBox1.Location = New System.Drawing.Point(3, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(54, 5)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(102, 79)
        Me.BunifuThinButton21.TabIndex = 156
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarDocumentos
        '
        Me.btnAgregarDocumentos.ActiveBorderThickness = 1
        Me.btnAgregarDocumentos.ActiveCornerRadius = 20
        Me.btnAgregarDocumentos.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnAgregarDocumentos.ActiveForecolor = System.Drawing.Color.White
        Me.btnAgregarDocumentos.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarDocumentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnAgregarDocumentos.BackgroundImage = CType(resources.GetObject("btnAgregarDocumentos.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarDocumentos.ButtonText = "Agregar Documentos"
        Me.btnAgregarDocumentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarDocumentos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDocumentos.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnAgregarDocumentos.IdleBorderThickness = 1
        Me.btnAgregarDocumentos.IdleCornerRadius = 20
        Me.btnAgregarDocumentos.IdleFillColor = System.Drawing.Color.White
        Me.btnAgregarDocumentos.IdleForecolor = System.Drawing.Color.Gray
        Me.btnAgregarDocumentos.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnAgregarDocumentos.Location = New System.Drawing.Point(166, 4)
        Me.btnAgregarDocumentos.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAgregarDocumentos.Name = "btnAgregarDocumentos"
        Me.btnAgregarDocumentos.Size = New System.Drawing.Size(102, 79)
        Me.btnAgregarDocumentos.TabIndex = 155
        Me.btnAgregarDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundActualizaciones
        '
        '
        'InformacionEmpeño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 687)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.lblmontorefrendo)
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
        Me.Name = "InformacionEmpeño"
        Me.Text = "Información de crédito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dtActualizaciones, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dtArticulos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtSolicitud As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundArticulos As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundSolicitud As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonoFlat_HeaderLabel2 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel3 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel4 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblfecha As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel6 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel7 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblnombre As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblmonto As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblmontorefrendo As MonoFlat.MonoFlat_HeaderLabel
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
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnAgregarDocumentos As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents BackgroundActualizaciones As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtActualizaciones As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtdatosDocumentos As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
