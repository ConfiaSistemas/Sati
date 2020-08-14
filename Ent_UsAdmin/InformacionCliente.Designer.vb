<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformacionCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacionCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtSolicitud = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtCredito = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundSolicitud = New System.ComponentModel.BackgroundWorker()
        Me.MonoFlat_HeaderLabel2 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel3 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblfecha = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel7 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblnombre = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lbltelefono = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblcelular = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundCreditos = New System.ComponentModel.BackgroundWorker()
        Me.MonoFlat_HeaderLabel4 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.lblfechanacimiento = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel5 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundDatos = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtCredito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(166, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Información de cliente"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 319)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 328)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.dtSolicitud)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1076, 302)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Solicitud"
        '
        'dtSolicitud
        '
        Me.dtSolicitud.AllowUserToAddRows = False
        Me.dtSolicitud.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtSolicitud.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtSolicitud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtSolicitud.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtSolicitud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtSolicitud.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSolicitud.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Fecha, Me.Nombre, Me.DataGridViewTextBoxColumn2, Me.Monto, Me.Tipo})
        Me.dtSolicitud.DoubleBuffered = True
        Me.dtSolicitud.EnableHeadersVisualStyles = False
        Me.dtSolicitud.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtSolicitud.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtSolicitud.Location = New System.Drawing.Point(6, 6)
        Me.dtSolicitud.Name = "dtSolicitud"
        Me.dtSolicitud.ReadOnly = True
        Me.dtSolicitud.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtSolicitud.RowHeadersVisible = False
        Me.dtSolicitud.Size = New System.Drawing.Size(1066, 290)
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
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
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
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtCredito)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1076, 302)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Créditos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtCredito
        '
        Me.dtCredito.AllowUserToAddRows = False
        Me.dtCredito.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtCredito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtCredito.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtCredito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7})
        Me.dtCredito.DoubleBuffered = True
        Me.dtCredito.EnableHeadersVisualStyles = False
        Me.dtCredito.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtCredito.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtCredito.Location = New System.Drawing.Point(5, 6)
        Me.dtCredito.Name = "dtCredito"
        Me.dtCredito.ReadOnly = True
        Me.dtCredito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtCredito.RowHeadersVisible = False
        Me.dtCredito.Size = New System.Drawing.Size(1066, 290)
        Me.dtCredito.TabIndex = 6
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 42
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha de Entrega"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 124
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 55
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 71
        '
        'BackgroundSolicitud
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
        Me.MonoFlat_HeaderLabel3.Size = New System.Drawing.Size(100, 20)
        Me.MonoFlat_HeaderLabel3.TabIndex = 33
        Me.MonoFlat_HeaderLabel3.Text = "Fecha de alta"
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
        'MonoFlat_HeaderLabel7
        '
        Me.MonoFlat_HeaderLabel7.AutoSize = True
        Me.MonoFlat_HeaderLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel7.Location = New System.Drawing.Point(432, 129)
        Me.MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7"
        Me.MonoFlat_HeaderLabel7.Size = New System.Drawing.Size(57, 20)
        Me.MonoFlat_HeaderLabel7.TabIndex = 37
        Me.MonoFlat_HeaderLabel7.Text = "Celular"
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
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.BackColor = System.Drawing.Color.Transparent
        Me.lbltelefono.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbltelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltelefono.Location = New System.Drawing.Point(15, 159)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(13, 20)
        Me.lbltelefono.TabIndex = 40
        Me.lbltelefono.Text = "."
        '
        'lblcelular
        '
        Me.lblcelular.AutoSize = True
        Me.lblcelular.BackColor = System.Drawing.Color.Transparent
        Me.lblcelular.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblcelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcelular.Location = New System.Drawing.Point(432, 159)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(13, 20)
        Me.lblcelular.TabIndex = 41
        Me.lblcelular.Text = "."
        '
        'BackgroundCreditos
        '
        '
        'MonoFlat_HeaderLabel4
        '
        Me.MonoFlat_HeaderLabel4.AutoSize = True
        Me.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel4.Location = New System.Drawing.Point(772, 54)
        Me.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4"
        Me.MonoFlat_HeaderLabel4.Size = New System.Drawing.Size(152, 20)
        Me.MonoFlat_HeaderLabel4.TabIndex = 34
        Me.MonoFlat_HeaderLabel4.Text = "Fecha de nacimiento"
        '
        'lblfechanacimiento
        '
        Me.lblfechanacimiento.AutoSize = True
        Me.lblfechanacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lblfechanacimiento.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblfechanacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblfechanacimiento.Location = New System.Drawing.Point(772, 80)
        Me.lblfechanacimiento.Name = "lblfechanacimiento"
        Me.lblfechanacimiento.Size = New System.Drawing.Size(13, 20)
        Me.lblfechanacimiento.TabIndex = 39
        Me.lblfechanacimiento.Text = "."
        '
        'MonoFlat_HeaderLabel5
        '
        Me.MonoFlat_HeaderLabel5.AutoSize = True
        Me.MonoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel5.Location = New System.Drawing.Point(21, 129)
        Me.MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5"
        Me.MonoFlat_HeaderLabel5.Size = New System.Drawing.Size(70, 20)
        Me.MonoFlat_HeaderLabel5.TabIndex = 42
        Me.MonoFlat_HeaderLabel5.Text = "Teléfono"
        '
        'BackgroundDatos
        '
        '
        'InformacionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 687)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel5)
        Me.Controls.Add(Me.lblcelular)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.lblfechanacimiento)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel7)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel4)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel3)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformacionCliente"
        Me.Text = "Información de crédito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dtSolicitud As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundSolicitud As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonoFlat_HeaderLabel2 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel3 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblfecha As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel7 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblnombre As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lbltelefono As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblcelular As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundCreditos As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtCredito As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents MonoFlat_HeaderLabel4 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents lblfechanacimiento As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel5 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents BackgroundDatos As System.ComponentModel.BackgroundWorker
End Class
