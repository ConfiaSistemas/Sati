<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Solicitud_Boleta

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Solicitud_Boleta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtMontoTotalSugerido = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPorcentajeRefrendo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtdatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TipoPrenda = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoValuado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoSugerido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonoFlat_Separator1 = New ConfiaAdmin.MonoFlat.MonoFlat_Separator()
        Me.btn_Procesar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.BackgroundGestores = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundPromotores = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMontoTotalValuado = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboPromotor = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.BackgroundTipos = New System.ComponentModel.BackgroundWorker()
        Me.txtIdCLiente = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.txtPrenda = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.txtTipo = New VB.Windows.Forms.ControlExt.TextBoxEx()
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
        Me.Panel1.Size = New System.Drawing.Size(1057, 36)
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(151, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Solicitud de Empeño"
        '
        'txtMontoTotalSugerido
        '
        Me.txtMontoTotalSugerido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMontoTotalSugerido.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoTotalSugerido.ForeColor = System.Drawing.Color.White
        Me.txtMontoTotalSugerido.HintForeColor = System.Drawing.Color.White
        Me.txtMontoTotalSugerido.HintText = ""
        Me.txtMontoTotalSugerido.isPassword = False
        Me.txtMontoTotalSugerido.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMontoTotalSugerido.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMontoTotalSugerido.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMontoTotalSugerido.LineThickness = 3
        Me.txtMontoTotalSugerido.Location = New System.Drawing.Point(592, 430)
        Me.txtMontoTotalSugerido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoTotalSugerido.Name = "txtMontoTotalSugerido"
        Me.txtMontoTotalSugerido.Size = New System.Drawing.Size(107, 25)
        Me.txtMontoTotalSugerido.TabIndex = 6
        Me.txtMontoTotalSugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(589, 413)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Monto Sugerido"
        '
        'txtPorcentajeRefrendo
        '
        Me.txtPorcentajeRefrendo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPorcentajeRefrendo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPorcentajeRefrendo.ForeColor = System.Drawing.Color.White
        Me.txtPorcentajeRefrendo.HintForeColor = System.Drawing.Color.White
        Me.txtPorcentajeRefrendo.HintText = ""
        Me.txtPorcentajeRefrendo.isPassword = False
        Me.txtPorcentajeRefrendo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPorcentajeRefrendo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPorcentajeRefrendo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPorcentajeRefrendo.LineThickness = 3
        Me.txtPorcentajeRefrendo.Location = New System.Drawing.Point(803, 430)
        Me.txtPorcentajeRefrendo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPorcentajeRefrendo.Name = "txtPorcentajeRefrendo"
        Me.txtPorcentajeRefrendo.Size = New System.Drawing.Size(115, 25)
        Me.txtPorcentajeRefrendo.TabIndex = 7
        Me.txtPorcentajeRefrendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(798, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Porcentaje de Refrendo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(601, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 21)
        Me.Button2.TabIndex = 21
        Me.Button2.TabStop = False
        Me.Button2.Text = "F2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(339, 53)
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
        Me.dtdatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Foto, Me.TipoPrenda, Me.Marca, Me.Modelo, Me.NoSerie, Me.Descripcion, Me.MontoValuado, Me.MontoSugerido})
        Me.dtdatos.DoubleBuffered = True
        Me.dtdatos.EnableHeadersVisualStyles = False
        Me.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatos.Location = New System.Drawing.Point(34, 137)
        Me.dtdatos.Name = "dtdatos"
        Me.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatos.RowHeadersVisible = False
        Me.dtdatos.Size = New System.Drawing.Size(1000, 255)
        Me.dtdatos.TabIndex = 4
        '
        'Foto
        '
        Me.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Foto.FillWeight = 150.0!
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Foto.MinimumWidth = 20
        Me.Foto.Name = "Foto"
        Me.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Foto.Width = 200
        '
        'TipoPrenda
        '
        Me.TipoPrenda.HeaderText = "Tipo"
        Me.TipoPrenda.Name = "TipoPrenda"
        Me.TipoPrenda.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoPrenda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TipoPrenda.Width = 55
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 70
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Width = 77
        '
        'NoSerie
        '
        Me.NoSerie.HeaderText = "No. de Serie"
        Me.NoSerie.Name = "NoSerie"
        Me.NoSerie.Width = 94
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        '
        'MontoValuado
        '
        Me.MontoValuado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MontoValuado.HeaderText = "Monto Valuado"
        Me.MontoValuado.Name = "MontoValuado"
        Me.MontoValuado.Width = 90
        '
        'MontoSugerido
        '
        Me.MontoSugerido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MontoSugerido.HeaderText = "Monto Sugerido"
        Me.MontoSugerido.Name = "MontoSugerido"
        Me.MontoSugerido.Width = 90
        '
        'MonoFlat_Separator1
        '
        Me.MonoFlat_Separator1.Location = New System.Drawing.Point(1, 398)
        Me.MonoFlat_Separator1.Name = "MonoFlat_Separator1"
        Me.MonoFlat_Separator1.Size = New System.Drawing.Size(1062, 12)
        Me.MonoFlat_Separator1.TabIndex = 25
        Me.MonoFlat_Separator1.Text = "MonoFlat_Separator1"
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
        Me.btn_Procesar.Location = New System.Drawing.Point(433, 487)
        Me.btn_Procesar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Procesar.Name = "btn_Procesar"
        Me.btn_Procesar.Size = New System.Drawing.Size(216, 38)
        Me.btn_Procesar.TabIndex = 13
        Me.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(956, 74)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(27, 21)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.TabStop = False
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
        'BackgroundWorker1
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(687, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Prenda"
        '
        'txtMontoTotalValuado
        '
        Me.txtMontoTotalValuado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMontoTotalValuado.Enabled = False
        Me.txtMontoTotalValuado.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoTotalValuado.ForeColor = System.Drawing.Color.White
        Me.txtMontoTotalValuado.HintForeColor = System.Drawing.Color.White
        Me.txtMontoTotalValuado.HintText = ""
        Me.txtMontoTotalValuado.isPassword = False
        Me.txtMontoTotalValuado.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMontoTotalValuado.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMontoTotalValuado.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMontoTotalValuado.LineThickness = 3
        Me.txtMontoTotalValuado.Location = New System.Drawing.Point(380, 430)
        Me.txtMontoTotalValuado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoTotalValuado.Name = "txtMontoTotalValuado"
        Me.txtMontoTotalValuado.Size = New System.Drawing.Size(103, 25)
        Me.txtMontoTotalValuado.TabIndex = 20
        Me.txtMontoTotalValuado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(377, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Monto Total Valuado"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 21)
        Me.Button1.TabIndex = 20
        Me.Button1.TabStop = False
        Me.Button1.Text = "F2"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(31, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Promotor"
        '
        'ComboPromotor
        '
        Me.ComboPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPromotor.FormattingEnabled = True
        Me.ComboPromotor.ItemHeight = 13
        Me.ComboPromotor.Location = New System.Drawing.Point(34, 434)
        Me.ComboPromotor.Name = "ComboPromotor"
        Me.ComboPromotor.Size = New System.Drawing.Size(239, 21)
        Me.ComboPromotor.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ForeColor = System.Drawing.Color.White
        Me.lblCliente.Location = New System.Drawing.Point(339, 108)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(13, 13)
        Me.lblCliente.TabIndex = 22
        Me.lblCliente.Text = ".."
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
        'BackgroundTipos
        '
        '
        'txtIdCLiente
        '
        Me.txtIdCLiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtIdCLiente.BorderColor = System.Drawing.Color.Gray
        Me.txtIdCLiente.ForeColor = System.Drawing.Color.White
        Me.txtIdCLiente.Location = New System.Drawing.Point(342, 76)
        Me.txtIdCLiente.Name = "txtIdCLiente"
        Me.txtIdCLiente.Size = New System.Drawing.Size(253, 20)
        Me.txtIdCLiente.TabIndex = 1
        '
        'txtPrenda
        '
        Me.txtPrenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtPrenda.BorderColor = System.Drawing.Color.Gray
        Me.txtPrenda.ForeColor = System.Drawing.Color.White
        Me.txtPrenda.Location = New System.Drawing.Point(690, 76)
        Me.txtPrenda.Name = "txtPrenda"
        Me.txtPrenda.Size = New System.Drawing.Size(260, 20)
        Me.txtPrenda.TabIndex = 3
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtTipo.BorderColor = System.Drawing.Color.Gray
        Me.txtTipo.ForeColor = System.Drawing.Color.White
        Me.txtTipo.Location = New System.Drawing.Point(34, 76)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(178, 20)
        Me.txtTipo.TabIndex = 0
        '
        'Solicitud_Boleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 551)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtPrenda)
        Me.Controls.Add(Me.txtIdCLiente)
        Me.Controls.Add(Me.txtMontoTotalValuado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_Procesar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MonoFlat_Separator1)
        Me.Controls.Add(Me.dtdatos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboPromotor)
        Me.Controls.Add(Me.txtPorcentajeRefrendo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMontoTotalSugerido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Solicitud_Boleta"
        Me.Text = "Solicitud de Empeño"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtMontoTotalSugerido As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPorcentajeRefrendo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtdatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MonoFlat_Separator1 As MonoFlat.MonoFlat_Separator
    Friend WithEvents btn_Procesar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents BackgroundGestores As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundPromotores As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMontoTotalValuado As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboPromotor As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents TipoPrenda As DataGridViewComboBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents NoSerie As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents MontoValuado As DataGridViewTextBoxColumn
    Friend WithEvents MontoSugerido As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundTipos As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtIdCLiente As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents txtPrenda As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents txtTipo As VB.Windows.Forms.ControlExt.TextBoxEx
End Class
