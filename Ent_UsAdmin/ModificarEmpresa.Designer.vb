<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarEmpresa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel2 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel3 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtRazonSocial = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel4 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtRFC = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel5 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtCalle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel6 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtNoExterior = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel8 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtCP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel9 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel10 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtCiudad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel11 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtEstado = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel12 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtTelefono = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel13 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtIP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel14 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtBD = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel15 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtPrefijo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel16 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtCorreo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_HeaderLabel17 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BackgroundInformacionEmpresa = New System.ComponentModel.BackgroundWorker()
        Me.txtColonia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundActualizar = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 36)
        Me.Panel1.TabIndex = 7
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(580, 3)
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(140, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Modificar Empresa"
        '
        'txtNombre
        '
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.HintForeColor = System.Drawing.Color.White
        Me.txtNombre.HintText = ""
        Me.txtNombre.isPassword = False
        Me.txtNombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNombre.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNombre.LineThickness = 3
        Me.txtNombre.Location = New System.Drawing.Point(8, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(354, 33)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel2
        '
        Me.MonoFlat_HeaderLabel2.AutoSize = True
        Me.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel2.Location = New System.Drawing.Point(4, 49)
        Me.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2"
        Me.MonoFlat_HeaderLabel2.Size = New System.Drawing.Size(139, 20)
        Me.MonoFlat_HeaderLabel2.TabIndex = 32
        Me.MonoFlat_HeaderLabel2.Text = "Nombre a mostrar"
        '
        'MonoFlat_HeaderLabel3
        '
        Me.MonoFlat_HeaderLabel3.AutoSize = True
        Me.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel3.Location = New System.Drawing.Point(4, 110)
        Me.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3"
        Me.MonoFlat_HeaderLabel3.Size = New System.Drawing.Size(95, 20)
        Me.MonoFlat_HeaderLabel3.TabIndex = 34
        Me.MonoFlat_HeaderLabel3.Text = "Razón social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.White
        Me.txtRazonSocial.HintForeColor = System.Drawing.Color.White
        Me.txtRazonSocial.HintText = ""
        Me.txtRazonSocial.isPassword = False
        Me.txtRazonSocial.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtRazonSocial.LineIdleColor = System.Drawing.Color.Gray
        Me.txtRazonSocial.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtRazonSocial.LineThickness = 3
        Me.txtRazonSocial.Location = New System.Drawing.Point(8, 129)
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(354, 33)
        Me.txtRazonSocial.TabIndex = 33
        Me.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel4
        '
        Me.MonoFlat_HeaderLabel4.AutoSize = True
        Me.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel4.Location = New System.Drawing.Point(366, 110)
        Me.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4"
        Me.MonoFlat_HeaderLabel4.Size = New System.Drawing.Size(47, 20)
        Me.MonoFlat_HeaderLabel4.TabIndex = 36
        Me.MonoFlat_HeaderLabel4.Text = "R.F.C."
        '
        'txtRFC
        '
        Me.txtRFC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFC.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRFC.ForeColor = System.Drawing.Color.White
        Me.txtRFC.HintForeColor = System.Drawing.Color.White
        Me.txtRFC.HintText = ""
        Me.txtRFC.isPassword = False
        Me.txtRFC.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtRFC.LineIdleColor = System.Drawing.Color.Gray
        Me.txtRFC.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtRFC.LineThickness = 3
        Me.txtRFC.Location = New System.Drawing.Point(370, 129)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(272, 33)
        Me.txtRFC.TabIndex = 35
        Me.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel5
        '
        Me.MonoFlat_HeaderLabel5.AutoSize = True
        Me.MonoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel5.Location = New System.Drawing.Point(4, 179)
        Me.MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5"
        Me.MonoFlat_HeaderLabel5.Size = New System.Drawing.Size(42, 20)
        Me.MonoFlat_HeaderLabel5.TabIndex = 38
        Me.MonoFlat_HeaderLabel5.Text = "Calle"
        '
        'txtCalle
        '
        Me.txtCalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalle.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCalle.ForeColor = System.Drawing.Color.White
        Me.txtCalle.HintForeColor = System.Drawing.Color.White
        Me.txtCalle.HintText = ""
        Me.txtCalle.isPassword = False
        Me.txtCalle.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCalle.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCalle.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCalle.LineThickness = 3
        Me.txtCalle.Location = New System.Drawing.Point(8, 198)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(354, 33)
        Me.txtCalle.TabIndex = 37
        Me.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel6
        '
        Me.MonoFlat_HeaderLabel6.AutoSize = True
        Me.MonoFlat_HeaderLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel6.Location = New System.Drawing.Point(366, 179)
        Me.MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6"
        Me.MonoFlat_HeaderLabel6.Size = New System.Drawing.Size(93, 20)
        Me.MonoFlat_HeaderLabel6.TabIndex = 40
        Me.MonoFlat_HeaderLabel6.Text = "No. Exterior"
        '
        'txtNoExterior
        '
        Me.txtNoExterior.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoExterior.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNoExterior.ForeColor = System.Drawing.Color.White
        Me.txtNoExterior.HintForeColor = System.Drawing.Color.White
        Me.txtNoExterior.HintText = ""
        Me.txtNoExterior.isPassword = False
        Me.txtNoExterior.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNoExterior.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNoExterior.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNoExterior.LineThickness = 3
        Me.txtNoExterior.Location = New System.Drawing.Point(370, 198)
        Me.txtNoExterior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoExterior.Name = "txtNoExterior"
        Me.txtNoExterior.Size = New System.Drawing.Size(145, 33)
        Me.txtNoExterior.TabIndex = 39
        Me.txtNoExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel8
        '
        Me.MonoFlat_HeaderLabel8.AutoSize = True
        Me.MonoFlat_HeaderLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel8.Location = New System.Drawing.Point(9, 244)
        Me.MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8"
        Me.MonoFlat_HeaderLabel8.Size = New System.Drawing.Size(105, 20)
        Me.MonoFlat_HeaderLabel8.TabIndex = 44
        Me.MonoFlat_HeaderLabel8.Text = "Código Postal"
        '
        'txtCP
        '
        Me.txtCP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCP.ForeColor = System.Drawing.Color.White
        Me.txtCP.HintForeColor = System.Drawing.Color.White
        Me.txtCP.HintText = ""
        Me.txtCP.isPassword = False
        Me.txtCP.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCP.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCP.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCP.LineThickness = 3
        Me.txtCP.Location = New System.Drawing.Point(13, 263)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(101, 33)
        Me.txtCP.TabIndex = 43
        Me.txtCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel9
        '
        Me.MonoFlat_HeaderLabel9.AutoSize = True
        Me.MonoFlat_HeaderLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel9.Location = New System.Drawing.Point(157, 244)
        Me.MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9"
        Me.MonoFlat_HeaderLabel9.Size = New System.Drawing.Size(61, 20)
        Me.MonoFlat_HeaderLabel9.TabIndex = 46
        Me.MonoFlat_HeaderLabel9.Text = "Colonia"
        '
        'MonoFlat_HeaderLabel10
        '
        Me.MonoFlat_HeaderLabel10.AutoSize = True
        Me.MonoFlat_HeaderLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel10.Location = New System.Drawing.Point(9, 309)
        Me.MonoFlat_HeaderLabel10.Name = "MonoFlat_HeaderLabel10"
        Me.MonoFlat_HeaderLabel10.Size = New System.Drawing.Size(57, 20)
        Me.MonoFlat_HeaderLabel10.TabIndex = 48
        Me.MonoFlat_HeaderLabel10.Text = "Ciudad"
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
        Me.txtCiudad.Location = New System.Drawing.Point(13, 328)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(205, 33)
        Me.txtCiudad.TabIndex = 47
        Me.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel11
        '
        Me.MonoFlat_HeaderLabel11.AutoSize = True
        Me.MonoFlat_HeaderLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel11.Location = New System.Drawing.Point(225, 309)
        Me.MonoFlat_HeaderLabel11.Name = "MonoFlat_HeaderLabel11"
        Me.MonoFlat_HeaderLabel11.Size = New System.Drawing.Size(56, 20)
        Me.MonoFlat_HeaderLabel11.TabIndex = 50
        Me.MonoFlat_HeaderLabel11.Text = "Estado"
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
        Me.txtEstado.Location = New System.Drawing.Point(229, 328)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(222, 33)
        Me.txtEstado.TabIndex = 49
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel12
        '
        Me.MonoFlat_HeaderLabel12.AutoSize = True
        Me.MonoFlat_HeaderLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel12.Location = New System.Drawing.Point(455, 309)
        Me.MonoFlat_HeaderLabel12.Name = "MonoFlat_HeaderLabel12"
        Me.MonoFlat_HeaderLabel12.Size = New System.Drawing.Size(70, 20)
        Me.MonoFlat_HeaderLabel12.TabIndex = 52
        Me.MonoFlat_HeaderLabel12.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTelefono.ForeColor = System.Drawing.Color.White
        Me.txtTelefono.HintForeColor = System.Drawing.Color.White
        Me.txtTelefono.HintText = ""
        Me.txtTelefono.isPassword = False
        Me.txtTelefono.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTelefono.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTelefono.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTelefono.LineThickness = 3
        Me.txtTelefono.Location = New System.Drawing.Point(459, 328)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(155, 33)
        Me.txtTelefono.TabIndex = 51
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel13
        '
        Me.MonoFlat_HeaderLabel13.AutoSize = True
        Me.MonoFlat_HeaderLabel13.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel13.Location = New System.Drawing.Point(9, 377)
        Me.MonoFlat_HeaderLabel13.Name = "MonoFlat_HeaderLabel13"
        Me.MonoFlat_HeaderLabel13.Size = New System.Drawing.Size(22, 20)
        Me.MonoFlat_HeaderLabel13.TabIndex = 54
        Me.MonoFlat_HeaderLabel13.Text = "ip"
        '
        'txtIP
        '
        Me.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIP.ForeColor = System.Drawing.Color.White
        Me.txtIP.HintForeColor = System.Drawing.Color.White
        Me.txtIP.HintText = ""
        Me.txtIP.isPassword = False
        Me.txtIP.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtIP.LineIdleColor = System.Drawing.Color.Gray
        Me.txtIP.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtIP.LineThickness = 3
        Me.txtIP.Location = New System.Drawing.Point(13, 396)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(155, 33)
        Me.txtIP.TabIndex = 53
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel14
        '
        Me.MonoFlat_HeaderLabel14.AutoSize = True
        Me.MonoFlat_HeaderLabel14.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel14.Location = New System.Drawing.Point(184, 377)
        Me.MonoFlat_HeaderLabel14.Name = "MonoFlat_HeaderLabel14"
        Me.MonoFlat_HeaderLabel14.Size = New System.Drawing.Size(106, 20)
        Me.MonoFlat_HeaderLabel14.TabIndex = 56
        Me.MonoFlat_HeaderLabel14.Text = "Base de datos"
        '
        'txtBD
        '
        Me.txtBD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBD.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtBD.ForeColor = System.Drawing.Color.White
        Me.txtBD.HintForeColor = System.Drawing.Color.White
        Me.txtBD.HintText = ""
        Me.txtBD.isPassword = False
        Me.txtBD.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtBD.LineIdleColor = System.Drawing.Color.Gray
        Me.txtBD.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtBD.LineThickness = 3
        Me.txtBD.Location = New System.Drawing.Point(188, 396)
        Me.txtBD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(155, 33)
        Me.txtBD.TabIndex = 55
        Me.txtBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel15
        '
        Me.MonoFlat_HeaderLabel15.AutoSize = True
        Me.MonoFlat_HeaderLabel15.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel15.Location = New System.Drawing.Point(366, 377)
        Me.MonoFlat_HeaderLabel15.Name = "MonoFlat_HeaderLabel15"
        Me.MonoFlat_HeaderLabel15.Size = New System.Drawing.Size(55, 20)
        Me.MonoFlat_HeaderLabel15.TabIndex = 58
        Me.MonoFlat_HeaderLabel15.Text = "Prefijo"
        '
        'txtPrefijo
        '
        Me.txtPrefijo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrefijo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPrefijo.ForeColor = System.Drawing.Color.White
        Me.txtPrefijo.HintForeColor = System.Drawing.Color.White
        Me.txtPrefijo.HintText = ""
        Me.txtPrefijo.isPassword = False
        Me.txtPrefijo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPrefijo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPrefijo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPrefijo.LineThickness = 3
        Me.txtPrefijo.Location = New System.Drawing.Point(370, 396)
        Me.txtPrefijo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(155, 33)
        Me.txtPrefijo.TabIndex = 57
        Me.txtPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel16
        '
        Me.MonoFlat_HeaderLabel16.AutoSize = True
        Me.MonoFlat_HeaderLabel16.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel16.Location = New System.Drawing.Point(9, 443)
        Me.MonoFlat_HeaderLabel16.Name = "MonoFlat_HeaderLabel16"
        Me.MonoFlat_HeaderLabel16.Size = New System.Drawing.Size(56, 20)
        Me.MonoFlat_HeaderLabel16.TabIndex = 60
        Me.MonoFlat_HeaderLabel16.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCorreo.ForeColor = System.Drawing.Color.White
        Me.txtCorreo.HintForeColor = System.Drawing.Color.White
        Me.txtCorreo.HintText = ""
        Me.txtCorreo.isPassword = False
        Me.txtCorreo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCorreo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCorreo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCorreo.LineThickness = 3
        Me.txtCorreo.Location = New System.Drawing.Point(13, 462)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(345, 33)
        Me.txtCorreo.TabIndex = 59
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_HeaderLabel17
        '
        Me.MonoFlat_HeaderLabel17.AutoSize = True
        Me.MonoFlat_HeaderLabel17.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel17.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel17.Location = New System.Drawing.Point(365, 443)
        Me.MonoFlat_HeaderLabel17.Name = "MonoFlat_HeaderLabel17"
        Me.MonoFlat_HeaderLabel17.Size = New System.Drawing.Size(88, 20)
        Me.MonoFlat_HeaderLabel17.TabIndex = 62
        Me.MonoFlat_HeaderLabel17.Text = "Contraseña"
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.HintForeColor = System.Drawing.Color.White
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPassword.LineThickness = 3
        Me.txtPassword.Location = New System.Drawing.Point(369, 462)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(267, 33)
        Me.txtPassword.TabIndex = 61
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BackgroundInformacionEmpresa
        '
        '
        'txtColonia
        '
        Me.txtColonia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtColonia.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtColonia.ForeColor = System.Drawing.Color.White
        Me.txtColonia.HintForeColor = System.Drawing.Color.White
        Me.txtColonia.HintText = ""
        Me.txtColonia.isPassword = False
        Me.txtColonia.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtColonia.LineIdleColor = System.Drawing.Color.Gray
        Me.txtColonia.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtColonia.LineThickness = 3
        Me.txtColonia.Location = New System.Drawing.Point(161, 263)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(275, 33)
        Me.txtColonia.TabIndex = 63
        Me.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(284, 528)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton21.TabIndex = 64
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundActualizar
        '
        '
        'ModificarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 573)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel17)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel16)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel15)
        Me.Controls.Add(Me.txtPrefijo)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel14)
        Me.Controls.Add(Me.txtBD)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel13)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel12)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel11)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel10)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel9)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel8)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel6)
        Me.Controls.Add(Me.txtNoExterior)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel5)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel4)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel3)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarEmpresa"
        Me.Text = "ModificarEmpresa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel2 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel3 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtRazonSocial As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel4 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtRFC As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel5 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtCalle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel6 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtNoExterior As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel8 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtCP As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel9 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel10 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtCiudad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel11 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtEstado As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel12 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtTelefono As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel13 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtIP As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel14 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtBD As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel15 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtPrefijo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel16 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtCorreo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_HeaderLabel17 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BackgroundInformacionEmpresa As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtColonia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundActualizar As System.ComponentModel.BackgroundWorker
End Class
