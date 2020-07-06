<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosSolicitudBoleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosSolicitudBoleta))
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_a_autorizacion = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtIne = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboColonia = New System.Windows.Forms.ComboBox()
        Me.txtCurp = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEstado = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCiudad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCelular = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidoM = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dtdatosDocumentos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.dtdatosDocumentosNuevos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.idTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_Procesar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dtdatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundAct = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDocumentosSolicitud = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundVerificacion = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDatosSolicitud = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCargaDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundVerificaDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundActivarLegal = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.dtdatosDocumentosNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_a_autorizacion)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 36)
        Me.Panel1.TabIndex = 3
        '
        'btn_a_autorizacion
        '
        Me.btn_a_autorizacion.ActiveBorderThickness = 1
        Me.btn_a_autorizacion.ActiveCornerRadius = 20
        Me.btn_a_autorizacion.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_a_autorizacion.ActiveForecolor = System.Drawing.Color.White
        Me.btn_a_autorizacion.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_a_autorizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_a_autorizacion.BackgroundImage = CType(resources.GetObject("btn_a_autorizacion.BackgroundImage"), System.Drawing.Image)
        Me.btn_a_autorizacion.ButtonText = "Enviar A Autorización"
        Me.btn_a_autorizacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_a_autorizacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_a_autorizacion.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_a_autorizacion.IdleBorderThickness = 1
        Me.btn_a_autorizacion.IdleCornerRadius = 20
        Me.btn_a_autorizacion.IdleFillColor = System.Drawing.Color.White
        Me.btn_a_autorizacion.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_a_autorizacion.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_a_autorizacion.Location = New System.Drawing.Point(768, -2)
        Me.btn_a_autorizacion.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_a_autorizacion.Name = "btn_a_autorizacion"
        Me.btn_a_autorizacion.Size = New System.Drawing.Size(184, 38)
        Me.btn_a_autorizacion.TabIndex = 152
        Me.btn_a_autorizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_a_autorizacion.Visible = False
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(1089, 3)
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(135, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Datos de Solicitud"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 358)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1141, 345)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txtIne)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ComboColonia)
        Me.TabPage1.Controls.Add(Me.txtCurp)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtEstado)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtCiudad)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtCodigoPostal)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtDomicilio)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtCelular)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtApellidoM)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtApellidoP)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtnombre)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1133, 319)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        '
        'txtIne
        '
        Me.txtIne.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIne.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIne.ForeColor = System.Drawing.Color.White
        Me.txtIne.HintForeColor = System.Drawing.Color.White
        Me.txtIne.HintText = ""
        Me.txtIne.isPassword = False
        Me.txtIne.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtIne.LineIdleColor = System.Drawing.Color.Gray
        Me.txtIne.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtIne.LineThickness = 3
        Me.txtIne.Location = New System.Drawing.Point(846, 40)
        Me.txtIne.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIne.Name = "txtIne"
        Me.txtIne.Size = New System.Drawing.Size(237, 29)
        Me.txtIne.TabIndex = 5
        Me.txtIne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(843, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "No de Identificación"
        '
        'ComboColonia
        '
        Me.ComboColonia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboColonia.ForeColor = System.Drawing.SystemColors.Control
        Me.ComboColonia.FormattingEnabled = True
        Me.ComboColonia.Location = New System.Drawing.Point(592, 142)
        Me.ComboColonia.Name = "ComboColonia"
        Me.ComboColonia.Size = New System.Drawing.Size(214, 21)
        Me.ComboColonia.TabIndex = 8
        '
        'txtCurp
        '
        Me.txtCurp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurp.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCurp.ForeColor = System.Drawing.Color.White
        Me.txtCurp.HintForeColor = System.Drawing.Color.White
        Me.txtCurp.HintText = ""
        Me.txtCurp.isPassword = False
        Me.txtCurp.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCurp.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCurp.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCurp.LineThickness = 3
        Me.txtCurp.Location = New System.Drawing.Point(33, 134)
        Me.txtCurp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(248, 29)
        Me.txtCurp.TabIndex = 6
        Me.txtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(30, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "CURP"
        '
        'txtEstado
        '
        Me.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEstado.ForeColor = System.Drawing.Color.White
        Me.txtEstado.HintForeColor = System.Drawing.Color.White
        Me.txtEstado.HintText = ""
        Me.txtEstado.isPassword = False
        Me.txtEstado.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtEstado.LineIdleColor = System.Drawing.Color.Gray
        Me.txtEstado.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtEstado.LineThickness = 3
        Me.txtEstado.Location = New System.Drawing.Point(320, 230)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(237, 29)
        Me.txtEstado.TabIndex = 11
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(317, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Estado"
        '
        'txtCiudad
        '
        Me.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCiudad.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCiudad.ForeColor = System.Drawing.Color.White
        Me.txtCiudad.HintForeColor = System.Drawing.Color.White
        Me.txtCiudad.HintText = ""
        Me.txtCiudad.isPassword = False
        Me.txtCiudad.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCiudad.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCiudad.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCiudad.LineThickness = 3
        Me.txtCiudad.Location = New System.Drawing.Point(33, 230)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(248, 29)
        Me.txtCiudad.TabIndex = 10
        Me.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(30, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Ciudad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(589, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Colonia"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigoPostal.ForeColor = System.Drawing.Color.White
        Me.txtCodigoPostal.HintForeColor = System.Drawing.Color.White
        Me.txtCodigoPostal.HintText = ""
        Me.txtCodigoPostal.isPassword = False
        Me.txtCodigoPostal.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCodigoPostal.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCodigoPostal.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCodigoPostal.LineThickness = 3
        Me.txtCodigoPostal.Location = New System.Drawing.Point(320, 134)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(237, 29)
        Me.txtCodigoPostal.TabIndex = 7
        Me.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(317, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Código Postal"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDomicilio.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDomicilio.ForeColor = System.Drawing.Color.White
        Me.txtDomicilio.HintForeColor = System.Drawing.Color.White
        Me.txtDomicilio.HintText = ""
        Me.txtDomicilio.isPassword = False
        Me.txtDomicilio.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtDomicilio.LineIdleColor = System.Drawing.Color.Gray
        Me.txtDomicilio.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtDomicilio.LineThickness = 3
        Me.txtDomicilio.Location = New System.Drawing.Point(846, 134)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(237, 29)
        Me.txtDomicilio.TabIndex = 9
        Me.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(843, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Domicilio"
        '
        'txtCelular
        '
        Me.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCelular.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCelular.ForeColor = System.Drawing.Color.White
        Me.txtCelular.HintForeColor = System.Drawing.Color.White
        Me.txtCelular.HintText = ""
        Me.txtCelular.isPassword = False
        Me.txtCelular.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCelular.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCelular.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCelular.LineThickness = 3
        Me.txtCelular.Location = New System.Drawing.Point(592, 230)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(214, 29)
        Me.txtCelular.TabIndex = 12
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(589, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Celular"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidoM.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtApellidoM.ForeColor = System.Drawing.Color.White
        Me.txtApellidoM.HintForeColor = System.Drawing.Color.White
        Me.txtApellidoM.HintText = ""
        Me.txtApellidoM.isPassword = False
        Me.txtApellidoM.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtApellidoM.LineIdleColor = System.Drawing.Color.Gray
        Me.txtApellidoM.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtApellidoM.LineThickness = 3
        Me.txtApellidoM.Location = New System.Drawing.Point(592, 40)
        Me.txtApellidoM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(214, 29)
        Me.txtApellidoM.TabIndex = 4
        Me.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(589, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Apellido Materno"
        '
        'txtApellidoP
        '
        Me.txtApellidoP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidoP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtApellidoP.ForeColor = System.Drawing.Color.White
        Me.txtApellidoP.HintForeColor = System.Drawing.Color.White
        Me.txtApellidoP.HintText = ""
        Me.txtApellidoP.isPassword = False
        Me.txtApellidoP.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtApellidoP.LineIdleColor = System.Drawing.Color.Gray
        Me.txtApellidoP.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtApellidoP.LineThickness = 3
        Me.txtApellidoP.Location = New System.Drawing.Point(320, 40)
        Me.txtApellidoP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(237, 29)
        Me.txtApellidoP.TabIndex = 3
        Me.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(317, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Apellido Paterno"
        '
        'txtnombre
        '
        Me.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtnombre.ForeColor = System.Drawing.Color.White
        Me.txtnombre.HintForeColor = System.Drawing.Color.White
        Me.txtnombre.HintText = ""
        Me.txtnombre.isPassword = False
        Me.txtnombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtnombre.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtnombre.LineThickness = 3
        Me.txtnombre.Location = New System.Drawing.Point(33, 40)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(248, 29)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(30, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Nombre(s)"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.TabControl2)
        Me.TabPage5.Controls.Add(Me.Label39)
        Me.TabPage5.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage5.Controls.Add(Me.btn_agregar)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.btn_Procesar)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1133, 319)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Verificación"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(351, 45)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(723, 217)
        Me.TabControl2.TabIndex = 155
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dtdatosDocumentos)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(715, 191)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Documentos Cargados"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dtdatosDocumentos
        '
        Me.dtdatosDocumentos.AllowUserToAddRows = False
        Me.dtdatosDocumentos.AllowUserToDeleteRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dtdatosDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatosDocumentos.DoubleBuffered = True
        Me.dtdatosDocumentos.EnableHeadersVisualStyles = False
        Me.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatosDocumentos.Location = New System.Drawing.Point(6, 5)
        Me.dtdatosDocumentos.Name = "dtdatosDocumentos"
        Me.dtdatosDocumentos.ReadOnly = True
        Me.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatosDocumentos.RowHeadersVisible = False
        Me.dtdatosDocumentos.Size = New System.Drawing.Size(703, 179)
        Me.dtdatosDocumentos.TabIndex = 26
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.dtdatosDocumentosNuevos)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(715, 191)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Documentos Por Cargar"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'dtdatosDocumentosNuevos
        '
        Me.dtdatosDocumentosNuevos.AllowUserToAddRows = False
        Me.dtdatosDocumentosNuevos.AllowUserToDeleteRows = False
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatosDocumentosNuevos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.dtdatosDocumentosNuevos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatosDocumentosNuevos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatosDocumentosNuevos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatosDocumentosNuevos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatosDocumentosNuevos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dtdatosDocumentosNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatosDocumentosNuevos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTipoDocumento, Me.NombreDocumento, Me.Imagen})
        Me.dtdatosDocumentosNuevos.DoubleBuffered = True
        Me.dtdatosDocumentosNuevos.EnableHeadersVisualStyles = False
        Me.dtdatosDocumentosNuevos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatosDocumentosNuevos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatosDocumentosNuevos.Location = New System.Drawing.Point(6, 6)
        Me.dtdatosDocumentosNuevos.Name = "dtdatosDocumentosNuevos"
        Me.dtdatosDocumentosNuevos.ReadOnly = True
        Me.dtdatosDocumentosNuevos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatosDocumentosNuevos.RowHeadersVisible = False
        Me.dtdatosDocumentosNuevos.Size = New System.Drawing.Size(703, 179)
        Me.dtdatosDocumentosNuevos.TabIndex = 27
        '
        'idTipoDocumento
        '
        Me.idTipoDocumento.HeaderText = "idTipoDocumento"
        Me.idTipoDocumento.Name = "idTipoDocumento"
        Me.idTipoDocumento.ReadOnly = True
        '
        'NombreDocumento
        '
        Me.NombreDocumento.HeaderText = "NombreDocumento"
        Me.NombreDocumento.Name = "NombreDocumento"
        Me.NombreDocumento.ReadOnly = True
        '
        'Imagen
        '
        Me.Imagen.FillWeight = 300.0!
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Width = 300
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(21, 12)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(123, 13)
        Me.Label39.TabIndex = 154
        Me.Label39.Text = "Documentos Necesarios"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(24, 44)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(135, 166)
        Me.FlowLayoutPanel1.TabIndex = 153
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(443, 8)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(27, 21)
        Me.btn_agregar.TabIndex = 52
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(348, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 150
        Me.Label21.Text = "Documentos"
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
        Me.btn_Procesar.ButtonText = "Registrar Captura"
        Me.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Procesar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Procesar.IdleBorderThickness = 1
        Me.btn_Procesar.IdleCornerRadius = 20
        Me.btn_Procesar.IdleFillColor = System.Drawing.Color.White
        Me.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Procesar.Location = New System.Drawing.Point(458, 271)
        Me.btn_Procesar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Procesar.Name = "btn_Procesar"
        Me.btn_Procesar.Size = New System.Drawing.Size(216, 38)
        Me.btn_Procesar.TabIndex = 53
        Me.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtdatos
        '
        Me.dtdatos.AllowUserToAddRows = False
        Me.dtdatos.AllowUserToDeleteRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.dtdatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dtdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatos.DoubleBuffered = True
        Me.dtdatos.EnableHeadersVisualStyles = False
        Me.dtdatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatos.Location = New System.Drawing.Point(12, 43)
        Me.dtdatos.Name = "dtdatos"
        Me.dtdatos.ReadOnly = True
        Me.dtdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatos.RowHeadersVisible = False
        Me.dtdatos.Size = New System.Drawing.Size(1144, 309)
        Me.dtdatos.TabIndex = 25
        '
        'BackgroundWorker1
        '
        '
        'BackgroundAct
        '
        '
        'BackgroundDocumentosSolicitud
        '
        '
        'BackgroundVerificacion
        '
        '
        'BackgroundDocumentos
        '
        '
        'BackgroundWorker2
        '
        '
        'BackgroundCargaDocumentos
        '
        '
        'BackgroundVerificaDocumentos
        '
        '
        'DatosSolicitudBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 715)
        Me.Controls.Add(Me.dtdatos)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DatosSolicitudBoleta"
        Me.Text = "DatosSolicitud"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dtdatosDocumentosNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtdatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtCurp As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEstado As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCiudad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCodigoPostal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDomicilio As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCelular As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidoM As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellidoP As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label21 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Procesar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundAct As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtdatosDocumentos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_a_autorizacion As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundDocumentosSolicitud As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundVerificacion As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label39 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BackgroundDatosSolicitud As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents dtdatosDocumentosNuevos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents idTipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NombreDocumento As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents BackgroundCargaDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundVerificaDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundActivarLegal As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboColonia As ComboBox
    Friend WithEvents txtIne As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
End Class
