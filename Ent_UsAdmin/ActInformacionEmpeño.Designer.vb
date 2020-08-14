<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActInformacionEmpeño
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActInformacionEmpeño))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.ComboTipo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtDomicilio = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.txtColonia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.txtCiudad = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.PanelDomicilio = New System.Windows.Forms.Panel()
        Me.txtEstado = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblEntidad = New System.Windows.Forms.Label()
        Me.PanelValor = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtMotivo = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundConsultaInformacion = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundActualizacion = New System.ComponentModel.BackgroundWorker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboCliente = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.PanelDomicilio.SuspendLayout()
        Me.PanelValor.SuspendLayout()
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(286, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Actualizar Información de Crédito Legal"
        '
        'ComboTipo
        '
        Me.ComboTipo.BackColor = System.Drawing.Color.Transparent
        Me.ComboTipo.BorderRadius = 10
        Me.ComboTipo.DisabledColor = System.Drawing.Color.Gray
        Me.ComboTipo.ForeColor = System.Drawing.Color.White
        Me.ComboTipo.Items = New String() {"Nombre", "Domicilio", "Número de Teléfono", "CURP", "INE"}
        Me.ComboTipo.Location = New System.Drawing.Point(41, 66)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboTipo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboTipo.selectedIndex = -1
        Me.ComboTipo.Size = New System.Drawing.Size(203, 35)
        Me.ComboTipo.TabIndex = 33
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDomicilio.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDomicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtDomicilio.HintForeColor = System.Drawing.Color.White
        Me.txtDomicilio.HintText = ""
        Me.txtDomicilio.isPassword = False
        Me.txtDomicilio.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtDomicilio.LineIdleColor = System.Drawing.Color.Gray
        Me.txtDomicilio.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtDomicilio.LineThickness = 3
        Me.txtDomicilio.Location = New System.Drawing.Point(27, 37)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(379, 33)
        Me.txtDomicilio.TabIndex = 35
        Me.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.ForeColor = System.Drawing.Color.White
        Me.lblDomicilio.Location = New System.Drawing.Point(24, 20)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(112, 13)
        Me.lblDomicilio.TabIndex = 34
        Me.lblDomicilio.Text = "Calle, No Ext., No. Int."
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
        Me.txtCodigoPostal.Location = New System.Drawing.Point(27, 110)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(379, 33)
        Me.txtCodigoPostal.TabIndex = 37
        Me.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.ForeColor = System.Drawing.Color.White
        Me.lblCodigoPostal.Location = New System.Drawing.Point(24, 93)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(72, 13)
        Me.lblCodigoPostal.TabIndex = 36
        Me.lblCodigoPostal.Text = "Código Postal"
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
        Me.txtColonia.Location = New System.Drawing.Point(27, 181)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(379, 33)
        Me.txtColonia.TabIndex = 39
        Me.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.ForeColor = System.Drawing.Color.White
        Me.lblColonia.Location = New System.Drawing.Point(24, 164)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 38
        Me.lblColonia.Text = "Colonia"
        '
        'txtCiudad
        '
        Me.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCiudad.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtCiudad.HintForeColor = System.Drawing.Color.White
        Me.txtCiudad.HintText = ""
        Me.txtCiudad.isPassword = False
        Me.txtCiudad.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCiudad.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCiudad.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCiudad.LineThickness = 3
        Me.txtCiudad.Location = New System.Drawing.Point(27, 249)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(379, 33)
        Me.txtCiudad.TabIndex = 41
        Me.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ForeColor = System.Drawing.Color.White
        Me.lblMunicipio.Location = New System.Drawing.Point(24, 232)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(40, 13)
        Me.lblMunicipio.TabIndex = 40
        Me.lblMunicipio.Text = "Ciudad"
        '
        'PanelDomicilio
        '
        Me.PanelDomicilio.Controls.Add(Me.txtEstado)
        Me.PanelDomicilio.Controls.Add(Me.txtCiudad)
        Me.PanelDomicilio.Controls.Add(Me.lblEntidad)
        Me.PanelDomicilio.Controls.Add(Me.lblDomicilio)
        Me.PanelDomicilio.Controls.Add(Me.txtDomicilio)
        Me.PanelDomicilio.Controls.Add(Me.lblCodigoPostal)
        Me.PanelDomicilio.Controls.Add(Me.lblMunicipio)
        Me.PanelDomicilio.Controls.Add(Me.txtCodigoPostal)
        Me.PanelDomicilio.Controls.Add(Me.txtColonia)
        Me.PanelDomicilio.Controls.Add(Me.lblColonia)
        Me.PanelDomicilio.Location = New System.Drawing.Point(41, 124)
        Me.PanelDomicilio.Name = "PanelDomicilio"
        Me.PanelDomicilio.Size = New System.Drawing.Size(431, 412)
        Me.PanelDomicilio.TabIndex = 42
        '
        'txtEstado
        '
        Me.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtEstado.HintForeColor = System.Drawing.Color.White
        Me.txtEstado.HintText = ""
        Me.txtEstado.isPassword = False
        Me.txtEstado.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtEstado.LineIdleColor = System.Drawing.Color.Gray
        Me.txtEstado.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtEstado.LineThickness = 3
        Me.txtEstado.Location = New System.Drawing.Point(27, 320)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(379, 33)
        Me.txtEstado.TabIndex = 44
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblEntidad
        '
        Me.lblEntidad.AutoSize = True
        Me.lblEntidad.ForeColor = System.Drawing.Color.White
        Me.lblEntidad.Location = New System.Drawing.Point(24, 303)
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(40, 13)
        Me.lblEntidad.TabIndex = 43
        Me.lblEntidad.Text = "Estado"
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
        'ActInformacionEmpeño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 558)
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
        Me.Name = "ActInformacionEmpeño"
        Me.Text = "ActInformacionLegal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelDomicilio.ResumeLayout(False)
        Me.PanelDomicilio.PerformLayout()
        Me.PanelValor.ResumeLayout(False)
        Me.PanelValor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents ComboTipo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtDomicilio As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents txtCodigoPostal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblCodigoPostal As Label
    Friend WithEvents txtColonia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblColonia As Label
    Friend WithEvents txtCiudad As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents PanelDomicilio As Panel
    Friend WithEvents txtEstado As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblEntidad As Label
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
End Class
