<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActInformacionCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActInformacionCredito))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.ComboTipo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtCalle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoExt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoInt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelDomicilio = New System.Windows.Forms.Panel()
        Me.txtColonia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelValor = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtMotivo = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundConsultaInformacion = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundActualizacion = New System.ComponentModel.BackgroundWorker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboCliente = New Bunifu.Framework.UI.BunifuDropdown()
        Me.PanelR = New System.Windows.Forms.Panel()
        Me.ComboColoniaR = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNombreR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtTelefonoR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRelacionR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCPR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCalleR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoExtR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNoIntR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelDomicilio.SuspendLayout()
        Me.PanelValor.SuspendLayout()
        Me.PanelR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 36)
        Me.Panel1.TabIndex = 5
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(941, 3)
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(245, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Actualizar Información de Crédito"
        '
        'ComboTipo
        '
        Me.ComboTipo.BackColor = System.Drawing.Color.Transparent
        Me.ComboTipo.BorderRadius = 10
        Me.ComboTipo.DisabledColor = System.Drawing.Color.Gray
        Me.ComboTipo.ForeColor = System.Drawing.Color.White
        Me.ComboTipo.Items = New String() {"Domicilio", "Número de Teléfono", "Número de Celular", "Domicilio de Trabajo", "Teléfono de Trabajo", "Referencia 1", "Referencia 2"}
        Me.ComboTipo.Location = New System.Drawing.Point(41, 66)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboTipo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboTipo.selectedIndex = -1
        Me.ComboTipo.Size = New System.Drawing.Size(203, 35)
        Me.ComboTipo.TabIndex = 33
        '
        'txtCalle
        '
        Me.txtCalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalle.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCalle.HintForeColor = System.Drawing.Color.White
        Me.txtCalle.HintText = ""
        Me.txtCalle.isPassword = False
        Me.txtCalle.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCalle.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCalle.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCalle.LineThickness = 3
        Me.txtCalle.Location = New System.Drawing.Point(27, 37)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(379, 33)
        Me.txtCalle.TabIndex = 35
        Me.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Calle"
        '
        'txtNoExt
        '
        Me.txtNoExt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoExt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNoExt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNoExt.HintForeColor = System.Drawing.Color.White
        Me.txtNoExt.HintText = ""
        Me.txtNoExt.isPassword = False
        Me.txtNoExt.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNoExt.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNoExt.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNoExt.LineThickness = 3
        Me.txtNoExt.Location = New System.Drawing.Point(27, 110)
        Me.txtNoExt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoExt.Name = "txtNoExt"
        Me.txtNoExt.Size = New System.Drawing.Size(379, 33)
        Me.txtNoExt.TabIndex = 37
        Me.txtNoExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Número Exterior"
        '
        'txtNoInt
        '
        Me.txtNoInt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoInt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNoInt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNoInt.HintForeColor = System.Drawing.Color.White
        Me.txtNoInt.HintText = ""
        Me.txtNoInt.isPassword = False
        Me.txtNoInt.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNoInt.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNoInt.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNoInt.LineThickness = 3
        Me.txtNoInt.Location = New System.Drawing.Point(27, 181)
        Me.txtNoInt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoInt.Name = "txtNoInt"
        Me.txtNoInt.Size = New System.Drawing.Size(379, 33)
        Me.txtNoInt.TabIndex = 39
        Me.txtNoInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Número Interior"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCodigoPostal.HintForeColor = System.Drawing.Color.White
        Me.txtCodigoPostal.HintText = ""
        Me.txtCodigoPostal.isPassword = False
        Me.txtCodigoPostal.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCodigoPostal.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCodigoPostal.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCodigoPostal.LineThickness = 3
        Me.txtCodigoPostal.Location = New System.Drawing.Point(27, 249)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(379, 33)
        Me.txtCodigoPostal.TabIndex = 41
        Me.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Código Postal"
        '
        'PanelDomicilio
        '
        Me.PanelDomicilio.Controls.Add(Me.txtColonia)
        Me.PanelDomicilio.Controls.Add(Me.txtCodigoPostal)
        Me.PanelDomicilio.Controls.Add(Me.Label5)
        Me.PanelDomicilio.Controls.Add(Me.Label4)
        Me.PanelDomicilio.Controls.Add(Me.txtCalle)
        Me.PanelDomicilio.Controls.Add(Me.Label1)
        Me.PanelDomicilio.Controls.Add(Me.Label3)
        Me.PanelDomicilio.Controls.Add(Me.txtNoExt)
        Me.PanelDomicilio.Controls.Add(Me.txtNoInt)
        Me.PanelDomicilio.Controls.Add(Me.Label2)
        Me.PanelDomicilio.Location = New System.Drawing.Point(41, 124)
        Me.PanelDomicilio.Name = "PanelDomicilio"
        Me.PanelDomicilio.Size = New System.Drawing.Size(431, 412)
        Me.PanelDomicilio.TabIndex = 42
        '
        'txtColonia
        '
        Me.txtColonia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtColonia.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtColonia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtColonia.HintForeColor = System.Drawing.Color.White
        Me.txtColonia.HintText = ""
        Me.txtColonia.isPassword = False
        Me.txtColonia.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtColonia.LineIdleColor = System.Drawing.Color.Gray
        Me.txtColonia.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtColonia.LineThickness = 3
        Me.txtColonia.Location = New System.Drawing.Point(27, 320)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(379, 33)
        Me.txtColonia.TabIndex = 44
        Me.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Colonia"
        '
        'PanelValor
        '
        Me.PanelValor.Controls.Add(Me.Label7)
        Me.PanelValor.Controls.Add(Me.txtValor)
        Me.PanelValor.Location = New System.Drawing.Point(555, 124)
        Me.PanelValor.Name = "PanelValor"
        Me.PanelValor.Size = New System.Drawing.Size(431, 106)
        Me.PanelValor.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtValor.HintForeColor = System.Drawing.Color.White
        Me.txtValor.HintText = ""
        Me.txtValor.isPassword = False
        Me.txtValor.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtValor.LineIdleColor = System.Drawing.Color.Gray
        Me.txtValor.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtValor.LineThickness = 3
        Me.txtValor.Location = New System.Drawing.Point(27, 37)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(379, 33)
        Me.txtValor.TabIndex = 35
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(555, 288)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(431, 118)
        Me.txtMotivo.TabIndex = 46
        Me.txtMotivo.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(552, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Motivo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Campo a Actualizar"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Actualizar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(509, 513)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton21.TabIndex = 47
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundConsultaInformacion
        '
        '
        'BackgroundActualizacion
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(552, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Cliente"
        '
        'ComboCliente
        '
        Me.ComboCliente.BackColor = System.Drawing.Color.Transparent
        Me.ComboCliente.BorderRadius = 10
        Me.ComboCliente.DisabledColor = System.Drawing.Color.Gray
        Me.ComboCliente.ForeColor = System.Drawing.Color.White
        Me.ComboCliente.Items = New String(-1) {}
        Me.ComboCliente.Location = New System.Drawing.Point(555, 66)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboCliente.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboCliente.selectedIndex = -1
        Me.ComboCliente.Size = New System.Drawing.Size(203, 35)
        Me.ComboCliente.TabIndex = 48
        '
        'PanelR
        '
        Me.PanelR.Controls.Add(Me.ComboColoniaR)
        Me.PanelR.Controls.Add(Me.Label17)
        Me.PanelR.Controls.Add(Me.txtNombreR)
        Me.PanelR.Controls.Add(Me.txtTelefonoR)
        Me.PanelR.Controls.Add(Me.Label16)
        Me.PanelR.Controls.Add(Me.txtRelacionR)
        Me.PanelR.Controls.Add(Me.Label15)
        Me.PanelR.Controls.Add(Me.txtCPR)
        Me.PanelR.Controls.Add(Me.Label10)
        Me.PanelR.Controls.Add(Me.Label11)
        Me.PanelR.Controls.Add(Me.txtCalleR)
        Me.PanelR.Controls.Add(Me.Label12)
        Me.PanelR.Controls.Add(Me.Label13)
        Me.PanelR.Controls.Add(Me.txtNoExtR)
        Me.PanelR.Controls.Add(Me.txtNoIntR)
        Me.PanelR.Controls.Add(Me.Label14)
        Me.PanelR.Location = New System.Drawing.Point(70, 107)
        Me.PanelR.Name = "PanelR"
        Me.PanelR.Size = New System.Drawing.Size(431, 559)
        Me.PanelR.TabIndex = 45
        Me.PanelR.Visible = False
        '
        'ComboColoniaR
        '
        Me.ComboColoniaR.BackColor = System.Drawing.Color.Transparent
        Me.ComboColoniaR.BorderRadius = 10
        Me.ComboColoniaR.DisabledColor = System.Drawing.Color.Gray
        Me.ComboColoniaR.ForeColor = System.Drawing.Color.White
        Me.ComboColoniaR.Items = New String(-1) {}
        Me.ComboColoniaR.Location = New System.Drawing.Point(27, 380)
        Me.ComboColoniaR.Name = "ComboColoniaR"
        Me.ComboColoniaR.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboColoniaR.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboColoniaR.selectedIndex = -1
        Me.ComboColoniaR.Size = New System.Drawing.Size(384, 35)
        Me.ComboColoniaR.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(24, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Nombre"
        '
        'txtNombreR
        '
        Me.txtNombreR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombreR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNombreR.HintForeColor = System.Drawing.Color.White
        Me.txtNombreR.HintText = ""
        Me.txtNombreR.isPassword = False
        Me.txtNombreR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNombreR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNombreR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNombreR.LineThickness = 3
        Me.txtNombreR.Location = New System.Drawing.Point(27, 23)
        Me.txtNombreR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreR.Name = "txtNombreR"
        Me.txtNombreR.Size = New System.Drawing.Size(379, 33)
        Me.txtNombreR.TabIndex = 50
        Me.txtNombreR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTelefonoR
        '
        Me.txtTelefonoR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefonoR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTelefonoR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtTelefonoR.HintForeColor = System.Drawing.Color.White
        Me.txtTelefonoR.HintText = ""
        Me.txtTelefonoR.isPassword = False
        Me.txtTelefonoR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTelefonoR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTelefonoR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTelefonoR.LineThickness = 3
        Me.txtTelefonoR.Location = New System.Drawing.Point(30, 513)
        Me.txtTelefonoR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefonoR.Name = "txtTelefonoR"
        Me.txtTelefonoR.Size = New System.Drawing.Size(379, 33)
        Me.txtTelefonoR.TabIndex = 48
        Me.txtTelefonoR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(27, 496)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Teléfono"
        '
        'txtRelacionR
        '
        Me.txtRelacionR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRelacionR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRelacionR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtRelacionR.HintForeColor = System.Drawing.Color.White
        Me.txtRelacionR.HintText = ""
        Me.txtRelacionR.isPassword = False
        Me.txtRelacionR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtRelacionR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtRelacionR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtRelacionR.LineThickness = 3
        Me.txtRelacionR.Location = New System.Drawing.Point(30, 450)
        Me.txtRelacionR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRelacionR.Name = "txtRelacionR"
        Me.txtRelacionR.Size = New System.Drawing.Size(379, 33)
        Me.txtRelacionR.TabIndex = 46
        Me.txtRelacionR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(27, 433)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Relación"
        '
        'txtCPR
        '
        Me.txtCPR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCPR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCPR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCPR.HintForeColor = System.Drawing.Color.White
        Me.txtCPR.HintText = ""
        Me.txtCPR.isPassword = False
        Me.txtCPR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCPR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCPR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCPR.LineThickness = 3
        Me.txtCPR.Location = New System.Drawing.Point(27, 304)
        Me.txtCPR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCPR.Name = "txtCPR"
        Me.txtCPR.Size = New System.Drawing.Size(379, 33)
        Me.txtCPR.TabIndex = 41
        Me.txtCPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Colonia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(24, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Calle"
        '
        'txtCalleR
        '
        Me.txtCalleR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalleR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCalleR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCalleR.HintForeColor = System.Drawing.Color.White
        Me.txtCalleR.HintText = ""
        Me.txtCalleR.isPassword = False
        Me.txtCalleR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCalleR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCalleR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCalleR.LineThickness = 3
        Me.txtCalleR.Location = New System.Drawing.Point(27, 92)
        Me.txtCalleR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalleR.Name = "txtCalleR"
        Me.txtCalleR.Size = New System.Drawing.Size(379, 33)
        Me.txtCalleR.TabIndex = 35
        Me.txtCalleR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(24, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Número Exterior"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(24, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Código Postal"
        '
        'txtNoExtR
        '
        Me.txtNoExtR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoExtR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNoExtR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNoExtR.HintForeColor = System.Drawing.Color.White
        Me.txtNoExtR.HintText = ""
        Me.txtNoExtR.isPassword = False
        Me.txtNoExtR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNoExtR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNoExtR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNoExtR.LineThickness = 3
        Me.txtNoExtR.Location = New System.Drawing.Point(27, 165)
        Me.txtNoExtR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoExtR.Name = "txtNoExtR"
        Me.txtNoExtR.Size = New System.Drawing.Size(379, 33)
        Me.txtNoExtR.TabIndex = 37
        Me.txtNoExtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNoIntR
        '
        Me.txtNoIntR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoIntR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNoIntR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNoIntR.HintForeColor = System.Drawing.Color.White
        Me.txtNoIntR.HintText = ""
        Me.txtNoIntR.isPassword = False
        Me.txtNoIntR.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNoIntR.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNoIntR.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNoIntR.LineThickness = 3
        Me.txtNoIntR.Location = New System.Drawing.Point(27, 236)
        Me.txtNoIntR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoIntR.Name = "txtNoIntR"
        Me.txtNoIntR.Size = New System.Drawing.Size(379, 33)
        Me.txtNoIntR.TabIndex = 39
        Me.txtNoIntR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(24, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Número Interior"
        '
        'ActInformacionCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 692)
        Me.Controls.Add(Me.PanelR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboCliente)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.PanelValor)
        Me.Controls.Add(Me.PanelDomicilio)
        Me.Controls.Add(Me.ComboTipo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ActInformacionCredito"
        Me.Text = "ActInformacionLegal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelDomicilio.ResumeLayout(False)
        Me.PanelDomicilio.PerformLayout()
        Me.PanelValor.ResumeLayout(False)
        Me.PanelValor.PerformLayout()
        Me.PanelR.ResumeLayout(False)
        Me.PanelR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents ComboTipo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtCalle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoExt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoInt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoPostal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelDomicilio As Panel
    Friend WithEvents txtColonia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelValor As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValor As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtMotivo As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundConsultaInformacion As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundActualizacion As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboCliente As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents PanelR As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNombreR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtTelefonoR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRelacionR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCPR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCalleR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNoExtR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNoIntR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboColoniaR As Bunifu.Framework.UI.BunifuDropdown
End Class
