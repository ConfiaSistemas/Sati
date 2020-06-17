<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Levantar_Solicitud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Levantar_Solicitud))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombreSolicitud = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtplazo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInteres = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboGestor = New System.Windows.Forms.ComboBox()
        Me.ComboPromotor = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtIdCliente = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtdatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonoFlat_Separator1 = New ConfiaAdmin.MonoFlat.MonoFlat_Separator()
        Me.txtIntegrantes = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Procesar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.BackgroundGestores = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundPromotores = New System.ComponentModel.BackgroundWorker()
        Me.txtResponsable = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtMontopPersona = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMontoTotal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMoratorios = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblMoratorios = New System.Windows.Forms.Label()
        Me.txtTotal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.CheckNombre = New ConfiaAdmin.MonoFlat.MonoFlat_CheckBox()
        Me.lblGestorLegal = New System.Windows.Forms.Label()
        Me.ComboLegal = New System.Windows.Forms.ComboBox()
        Me.BackgroundLegal = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundSolicitudLegal = New System.ComponentModel.BackgroundWorker()
        Me.txtTotalMoratorios = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblTotalMoratorios = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 36)
        Me.Panel1.TabIndex = 2
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(993, 3)
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(134, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Levantar Solicitud"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTipo.ForeColor = System.Drawing.Color.White
        Me.txtTipo.HintForeColor = System.Drawing.Color.White
        Me.txtTipo.HintText = ""
        Me.txtTipo.isPassword = False
        Me.txtTipo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTipo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTipo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTipo.LineThickness = 3
        Me.txtTipo.Location = New System.Drawing.Point(34, 70)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(58, 25)
        Me.txtTipo.TabIndex = 0
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(31, 108)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(13, 13)
        Me.lblTipo.TabIndex = 10
        Me.lblTipo.Text = ".."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 21)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "F2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNombreSolicitud
        '
        Me.txtNombreSolicitud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreSolicitud.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombreSolicitud.ForeColor = System.Drawing.Color.White
        Me.txtNombreSolicitud.HintForeColor = System.Drawing.Color.White
        Me.txtNombreSolicitud.HintText = ""
        Me.txtNombreSolicitud.isPassword = False
        Me.txtNombreSolicitud.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNombreSolicitud.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNombreSolicitud.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNombreSolicitud.LineThickness = 3
        Me.txtNombreSolicitud.Location = New System.Drawing.Point(21, 307)
        Me.txtNombreSolicitud.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreSolicitud.Name = "txtNombreSolicitud"
        Me.txtNombreSolicitud.Size = New System.Drawing.Size(226, 25)
        Me.txtNombreSolicitud.TabIndex = 6
        Me.txtNombreSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre"
        '
        'txtplazo
        '
        Me.txtplazo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtplazo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtplazo.ForeColor = System.Drawing.Color.White
        Me.txtplazo.HintForeColor = System.Drawing.Color.White
        Me.txtplazo.HintText = ""
        Me.txtplazo.isPassword = False
        Me.txtplazo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtplazo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtplazo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtplazo.LineThickness = 3
        Me.txtplazo.Location = New System.Drawing.Point(415, 307)
        Me.txtplazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtplazo.Name = "txtplazo"
        Me.txtplazo.Size = New System.Drawing.Size(85, 25)
        Me.txtplazo.TabIndex = 8
        Me.txtplazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(412, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Plazo"
        '
        'txtInteres
        '
        Me.txtInteres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInteres.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtInteres.ForeColor = System.Drawing.Color.White
        Me.txtInteres.HintForeColor = System.Drawing.Color.White
        Me.txtInteres.HintText = ""
        Me.txtInteres.isPassword = False
        Me.txtInteres.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtInteres.LineIdleColor = System.Drawing.Color.Gray
        Me.txtInteres.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtInteres.LineThickness = 3
        Me.txtInteres.Location = New System.Drawing.Point(538, 307)
        Me.txtInteres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(93, 25)
        Me.txtInteres.TabIndex = 9
        Me.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(535, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Interés"
        '
        'ComboGestor
        '
        Me.ComboGestor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboGestor.FormattingEnabled = True
        Me.ComboGestor.Location = New System.Drawing.Point(89, 404)
        Me.ComboGestor.Name = "ComboGestor"
        Me.ComboGestor.Size = New System.Drawing.Size(240, 21)
        Me.ComboGestor.TabIndex = 11
        '
        'ComboPromotor
        '
        Me.ComboPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPromotor.FormattingEnabled = True
        Me.ComboPromotor.ItemHeight = 13
        Me.ComboPromotor.Location = New System.Drawing.Point(380, 404)
        Me.ComboPromotor.Name = "ComboPromotor"
        Me.ComboPromotor.Size = New System.Drawing.Size(239, 21)
        Me.ComboPromotor.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 21)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "F2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(233, 108)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(13, 13)
        Me.lblCliente.TabIndex = 22
        Me.lblCliente.Text = ".."
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIdCliente.ForeColor = System.Drawing.Color.White
        Me.txtIdCliente.HintForeColor = System.Drawing.Color.White
        Me.txtIdCliente.HintText = ""
        Me.txtIdCliente.isPassword = False
        Me.txtIdCliente.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtIdCliente.LineIdleColor = System.Drawing.Color.Gray
        Me.txtIdCliente.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtIdCliente.LineThickness = 3
        Me.txtIdCliente.Location = New System.Drawing.Point(236, 70)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(58, 25)
        Me.txtIdCliente.TabIndex = 2
        Me.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(233, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cliente"
        '
        'dtdatos
        '
        Me.dtdatos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtdatos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Monto})
        Me.dtdatos.DoubleBuffered = True
        Me.dtdatos.EnableHeadersVisualStyles = False
        Me.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatos.Location = New System.Drawing.Point(514, 45)
        Me.dtdatos.Name = "dtdatos"
        Me.dtdatos.ReadOnly = True
        Me.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatos.RowHeadersVisible = False
        Me.dtdatos.Size = New System.Drawing.Size(542, 183)
        Me.dtdatos.TabIndex = 24
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 70
        '
        'MonoFlat_Separator1
        '
        Me.MonoFlat_Separator1.Location = New System.Drawing.Point(1, 257)
        Me.MonoFlat_Separator1.Name = "MonoFlat_Separator1"
        Me.MonoFlat_Separator1.Size = New System.Drawing.Size(1062, 12)
        Me.MonoFlat_Separator1.TabIndex = 25
        Me.MonoFlat_Separator1.Text = "MonoFlat_Separator1"
        '
        'txtIntegrantes
        '
        Me.txtIntegrantes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIntegrantes.Enabled = False
        Me.txtIntegrantes.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIntegrantes.ForeColor = System.Drawing.Color.White
        Me.txtIntegrantes.HintForeColor = System.Drawing.Color.White
        Me.txtIntegrantes.HintText = ""
        Me.txtIntegrantes.isPassword = False
        Me.txtIntegrantes.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtIntegrantes.LineIdleColor = System.Drawing.Color.Gray
        Me.txtIntegrantes.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtIntegrantes.LineThickness = 3
        Me.txtIntegrantes.Location = New System.Drawing.Point(658, 307)
        Me.txtIntegrantes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIntegrantes.Name = "txtIntegrantes"
        Me.txtIntegrantes.Size = New System.Drawing.Size(58, 25)
        Me.txtIntegrantes.TabIndex = 9
        Me.txtIntegrantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(655, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Integrantes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(86, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Gestor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(377, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Promotor"
        '
        'btn_Procesar
        '
        Me.btn_Procesar.ActiveBorderThickness = 1
        Me.btn_Procesar.ActiveCornerRadius = 20
        Me.btn_Procesar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Procesar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Procesar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Procesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_Procesar.BackgroundImage = CType(resources.GetObject("btn_Procesar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Procesar.ButtonText = "Ingresar e iniciar proceso"
        Me.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Procesar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Procesar.IdleBorderThickness = 1
        Me.btn_Procesar.IdleCornerRadius = 20
        Me.btn_Procesar.IdleFillColor = System.Drawing.Color.White
        Me.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Procesar.Location = New System.Drawing.Point(358, 451)
        Me.btn_Procesar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Procesar.Name = "btn_Procesar"
        Me.btn_Procesar.Size = New System.Drawing.Size(216, 38)
        Me.btn_Procesar.TabIndex = 13
        Me.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(422, 74)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(27, 21)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        Me.btn_agregar.Visible = False
        '
        'BackgroundGestores
        '
        '
        'BackgroundPromotores
        '
        '
        'txtResponsable
        '
        Me.txtResponsable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResponsable.Enabled = False
        Me.txtResponsable.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtResponsable.ForeColor = System.Drawing.Color.White
        Me.txtResponsable.HintForeColor = System.Drawing.Color.White
        Me.txtResponsable.HintText = ""
        Me.txtResponsable.isPassword = False
        Me.txtResponsable.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtResponsable.LineIdleColor = System.Drawing.Color.Gray
        Me.txtResponsable.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtResponsable.LineThickness = 3
        Me.txtResponsable.Location = New System.Drawing.Point(745, 307)
        Me.txtResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(58, 25)
        Me.txtResponsable.TabIndex = 10
        Me.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(742, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Responsable"
        '
        'BackgroundWorker1
        '
        '
        'txtMontopPersona
        '
        Me.txtMontopPersona.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMontopPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontopPersona.ForeColor = System.Drawing.Color.White
        Me.txtMontopPersona.HintForeColor = System.Drawing.Color.White
        Me.txtMontopPersona.HintText = ""
        Me.txtMontopPersona.isPassword = False
        Me.txtMontopPersona.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMontopPersona.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMontopPersona.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMontopPersona.LineThickness = 3
        Me.txtMontopPersona.Location = New System.Drawing.Point(357, 70)
        Me.txtMontopPersona.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontopPersona.Name = "txtMontopPersona"
        Me.txtMontopPersona.Size = New System.Drawing.Size(58, 25)
        Me.txtMontopPersona.TabIndex = 4
        Me.txtMontopPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(354, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Monto"
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMontoTotal.Enabled = False
        Me.txtMontoTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoTotal.ForeColor = System.Drawing.Color.White
        Me.txtMontoTotal.HintForeColor = System.Drawing.Color.White
        Me.txtMontoTotal.HintText = ""
        Me.txtMontoTotal.isPassword = False
        Me.txtMontoTotal.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMontoTotal.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMontoTotal.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMontoTotal.LineThickness = 3
        Me.txtMontoTotal.Location = New System.Drawing.Point(290, 307)
        Me.txtMontoTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(101, 25)
        Me.txtMontoTotal.TabIndex = 7
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(287, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Monto"
        '
        'txtMoratorios
        '
        Me.txtMoratorios.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMoratorios.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMoratorios.ForeColor = System.Drawing.Color.White
        Me.txtMoratorios.HintForeColor = System.Drawing.Color.White
        Me.txtMoratorios.HintText = ""
        Me.txtMoratorios.isPassword = False
        Me.txtMoratorios.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMoratorios.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMoratorios.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMoratorios.LineThickness = 3
        Me.txtMoratorios.Location = New System.Drawing.Point(357, 123)
        Me.txtMoratorios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMoratorios.Name = "txtMoratorios"
        Me.txtMoratorios.Size = New System.Drawing.Size(58, 25)
        Me.txtMoratorios.TabIndex = 37
        Me.txtMoratorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMoratorios.Visible = False
        '
        'lblMoratorios
        '
        Me.lblMoratorios.AutoSize = True
        Me.lblMoratorios.ForeColor = System.Drawing.Color.White
        Me.lblMoratorios.Location = New System.Drawing.Point(354, 106)
        Me.lblMoratorios.Name = "lblMoratorios"
        Me.lblMoratorios.Size = New System.Drawing.Size(56, 13)
        Me.lblMoratorios.TabIndex = 38
        Me.lblMoratorios.Text = "Moratorios"
        Me.lblMoratorios.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.HintForeColor = System.Drawing.Color.White
        Me.txtTotal.HintText = ""
        Me.txtTotal.isPassword = False
        Me.txtTotal.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTotal.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTotal.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTotal.LineThickness = 3
        Me.txtTotal.Location = New System.Drawing.Point(920, 307)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(114, 25)
        Me.txtTotal.TabIndex = 39
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTotal.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(917, 290)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 13)
        Me.lblTotal.TabIndex = 40
        Me.lblTotal.Text = "Deuda Total"
        Me.lblTotal.Visible = False
        '
        'CheckNombre
        '
        Me.CheckNombre.Checked = False
        Me.CheckNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CheckNombre.Location = New System.Drawing.Point(340, 166)
        Me.CheckNombre.Name = "CheckNombre"
        Me.CheckNombre.Size = New System.Drawing.Size(160, 16)
        Me.CheckNombre.TabIndex = 41
        Me.CheckNombre.Text = "Usar Nombre de Cliente"
        Me.CheckNombre.Visible = False
        '
        'lblGestorLegal
        '
        Me.lblGestorLegal.AutoSize = True
        Me.lblGestorLegal.ForeColor = System.Drawing.Color.White
        Me.lblGestorLegal.Location = New System.Drawing.Point(655, 374)
        Me.lblGestorLegal.Name = "lblGestorLegal"
        Me.lblGestorLegal.Size = New System.Drawing.Size(67, 13)
        Me.lblGestorLegal.TabIndex = 43
        Me.lblGestorLegal.Text = "Gestor Legal"
        Me.lblGestorLegal.Visible = False
        '
        'ComboLegal
        '
        Me.ComboLegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboLegal.FormattingEnabled = True
        Me.ComboLegal.ItemHeight = 13
        Me.ComboLegal.Location = New System.Drawing.Point(658, 404)
        Me.ComboLegal.Name = "ComboLegal"
        Me.ComboLegal.Size = New System.Drawing.Size(239, 21)
        Me.ComboLegal.TabIndex = 42
        Me.ComboLegal.Visible = False
        '
        'BackgroundLegal
        '
        '
        'BackgroundSolicitudLegal
        '
        '
        'txtTotalMoratorios
        '
        Me.txtTotalMoratorios.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalMoratorios.Enabled = False
        Me.txtTotalMoratorios.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTotalMoratorios.ForeColor = System.Drawing.Color.White
        Me.txtTotalMoratorios.HintForeColor = System.Drawing.Color.White
        Me.txtTotalMoratorios.HintText = ""
        Me.txtTotalMoratorios.isPassword = False
        Me.txtTotalMoratorios.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTotalMoratorios.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTotalMoratorios.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTotalMoratorios.LineThickness = 3
        Me.txtTotalMoratorios.Location = New System.Drawing.Point(827, 307)
        Me.txtTotalMoratorios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalMoratorios.Name = "txtTotalMoratorios"
        Me.txtTotalMoratorios.Size = New System.Drawing.Size(80, 25)
        Me.txtTotalMoratorios.TabIndex = 44
        Me.txtTotalMoratorios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTotalMoratorios.Visible = False
        '
        'lblTotalMoratorios
        '
        Me.lblTotalMoratorios.AutoSize = True
        Me.lblTotalMoratorios.ForeColor = System.Drawing.Color.White
        Me.lblTotalMoratorios.Location = New System.Drawing.Point(824, 290)
        Me.lblTotalMoratorios.Name = "lblTotalMoratorios"
        Me.lblTotalMoratorios.Size = New System.Drawing.Size(83, 13)
        Me.lblTotalMoratorios.TabIndex = 45
        Me.lblTotalMoratorios.Text = "Total Moratorios"
        Me.lblTotalMoratorios.Visible = False
        '
        'Levantar_Solicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1065, 503)
        Me.Controls.Add(Me.txtTotalMoratorios)
        Me.Controls.Add(Me.lblTotalMoratorios)
        Me.Controls.Add(Me.lblGestorLegal)
        Me.Controls.Add(Me.ComboLegal)
        Me.Controls.Add(Me.CheckNombre)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtMoratorios)
        Me.Controls.Add(Me.lblMoratorios)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMontopPersona)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_Procesar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIntegrantes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonoFlat_Separator1)
        Me.Controls.Add(Me.dtdatos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboPromotor)
        Me.Controls.Add(Me.ComboGestor)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtplazo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreSolicitud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Levantar_Solicitud"
        Me.Text = "Levantar_Solicitud"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblTipo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNombreSolicitud As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtplazo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInteres As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboGestor As ComboBox
    Friend WithEvents ComboPromotor As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtIdCliente As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtdatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MonoFlat_Separator1 As MonoFlat.MonoFlat_Separator
    Friend WithEvents txtIntegrantes As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Procesar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents BackgroundGestores As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundPromotores As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtResponsable As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents txtMontopPersona As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMontoTotal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMoratorios As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblMoratorios As Label
    Friend WithEvents txtTotal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblTotal As Label
    Friend WithEvents CheckNombre As MonoFlat.MonoFlat_CheckBox
    Friend WithEvents lblGestorLegal As Label
    Friend WithEvents ComboLegal As ComboBox
    Friend WithEvents BackgroundLegal As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundSolicitudLegal As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtTotalMoratorios As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblTotalMoratorios As Label
End Class
