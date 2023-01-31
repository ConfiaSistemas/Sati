<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActualizarCliente

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtApellidoM = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateNacimiento = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCelular = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcurp = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BackgroundConsultarCurp = New System.ComponentModel.BackgroundWorker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundAgregar = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundValidar = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundValidaExistencia = New System.ComponentModel.BackgroundWorker()
        Me.btnConsultaCurp = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundConsultarCliente = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCreditosActivos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundActualizarTodo = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundConsultaCurpOp2 = New System.ComponentModel.BackgroundWorker()
        Me.RadioOp2 = New System.Windows.Forms.RadioButton()
        Me.RadioOp1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RadioOp2)
        Me.Panel1.Controls.Add(Me.RadioOp1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 36)
        Me.Panel1.TabIndex = 1
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(131, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Actualizar Cliente"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(605, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
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
        Me.txtnombre.Location = New System.Drawing.Point(37, 127)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(171, 25)
        Me.txtnombre.TabIndex = 6
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(266, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido Paterno"
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
        Me.txtApellidoP.Location = New System.Drawing.Point(269, 127)
        Me.txtApellidoP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(170, 25)
        Me.txtApellidoP.TabIndex = 8
        Me.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtApellidoM.Location = New System.Drawing.Point(471, 127)
        Me.txtApellidoM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(170, 25)
        Me.txtApellidoM.TabIndex = 17
        Me.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(468, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'DateNacimiento
        '
        Me.DateNacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.DateNacimiento.BorderRadius = 0
        Me.DateNacimiento.ForeColor = System.Drawing.Color.White
        Me.DateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNacimiento.FormatCustom = Nothing
        Me.DateNacimiento.Location = New System.Drawing.Point(38, 214)
        Me.DateNacimiento.Name = "DateNacimiento"
        Me.DateNacimiento.Size = New System.Drawing.Size(170, 36)
        Me.DateNacimiento.TabIndex = 21
        Me.DateNacimiento.Value = New Date(2019, 12, 20, 10, 35, 45, 980)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Curp:"
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
        Me.txtTelefono.Location = New System.Drawing.Point(269, 214)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(170, 25)
        Me.txtTelefono.TabIndex = 22
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(468, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Celular"
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
        Me.txtCelular.Location = New System.Drawing.Point(471, 214)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(170, 25)
        Me.txtCelular.TabIndex = 24
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcurp
        '
        Me.txtcurp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurp.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtcurp.ForeColor = System.Drawing.Color.White
        Me.txtcurp.HintForeColor = System.Drawing.Color.White
        Me.txtcurp.HintText = ""
        Me.txtcurp.isPassword = False
        Me.txtcurp.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtcurp.LineIdleColor = System.Drawing.Color.Gray
        Me.txtcurp.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtcurp.LineThickness = 3
        Me.txtcurp.Location = New System.Drawing.Point(38, 64)
        Me.txtcurp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcurp.Name = "txtcurp"
        Me.txtcurp.Size = New System.Drawing.Size(170, 25)
        Me.txtcurp.TabIndex = 27
        Me.txtcurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BackgroundConsultarCurp
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(266, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Teléfono:"
        '
        'BackgroundAgregar
        '
        '
        'BackgroundValidar
        '
        '
        'BackgroundValidaExistencia
        '
        '
        'btnConsultaCurp
        '
        Me.btnConsultaCurp.ActiveBorderThickness = 1
        Me.btnConsultaCurp.ActiveCornerRadius = 20
        Me.btnConsultaCurp.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnConsultaCurp.ActiveForecolor = System.Drawing.Color.White
        Me.btnConsultaCurp.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnConsultaCurp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btnConsultaCurp.BackgroundImage = CType(resources.GetObject("btnConsultaCurp.BackgroundImage"), System.Drawing.Image)
        Me.btnConsultaCurp.ButtonText = "Consultar"
        Me.btnConsultaCurp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultaCurp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaCurp.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnConsultaCurp.IdleBorderThickness = 1
        Me.btnConsultaCurp.IdleCornerRadius = 20
        Me.btnConsultaCurp.IdleFillColor = System.Drawing.Color.White
        Me.btnConsultaCurp.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnConsultaCurp.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnConsultaCurp.Location = New System.Drawing.Point(260, 51)
        Me.btnConsultaCurp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnConsultaCurp.Name = "btnConsultaCurp"
        Me.btnConsultaCurp.Size = New System.Drawing.Size(207, 38)
        Me.btnConsultaCurp.TabIndex = 28
        Me.btnConsultaCurp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Agregar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(505, 426)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(207, 38)
        Me.BunifuThinButton21.TabIndex = 26
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_agregar
        '
        Me.btn_agregar.ActiveBorderThickness = 1
        Me.btn_agregar.ActiveCornerRadius = 20
        Me.btn_agregar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_agregar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.ButtonText = "Actualizar"
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.IdleBorderThickness = 1
        Me.btn_agregar.IdleCornerRadius = 20
        Me.btn_agregar.IdleFillColor = System.Drawing.Color.White
        Me.btn_agregar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.Location = New System.Drawing.Point(249, 287)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(207, 38)
        Me.btn_agregar.TabIndex = 15
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundConsultarCliente
        '
        '
        'BackgroundCreditosActivos
        '
        '
        'BackgroundActualizarTodo
        '
        '
        'BackgroundConsultaCurpOp2
        '
        '
        'RadioOp2
        '
        Me.RadioOp2.AutoSize = True
        Me.RadioOp2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioOp2.Location = New System.Drawing.Point(423, 6)
        Me.RadioOp2.Name = "RadioOp2"
        Me.RadioOp2.Size = New System.Drawing.Size(68, 17)
        Me.RadioOp2.TabIndex = 31
        Me.RadioOp2.TabStop = True
        Me.RadioOp2.Text = "Opción 2"
        Me.RadioOp2.UseVisualStyleBackColor = True
        '
        'RadioOp1
        '
        Me.RadioOp1.AutoSize = True
        Me.RadioOp1.Checked = True
        Me.RadioOp1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioOp1.Location = New System.Drawing.Point(340, 6)
        Me.RadioOp1.Name = "RadioOp1"
        Me.RadioOp1.Size = New System.Drawing.Size(68, 17)
        Me.RadioOp1.TabIndex = 30
        Me.RadioOp1.TabStop = True
        Me.RadioOp1.Text = "Opción 1"
        Me.RadioOp1.UseVisualStyleBackColor = True
        '
        'ActualizarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 341)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnConsultaCurp)
        Me.Controls.Add(Me.txtcurp)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.DateNacimiento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellidoM)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApellidoP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ActualizarCliente"
        Me.Text = "Agregar Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As ConfiaAdmin.EvolveControlBox
    Friend WithEvents txtnombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoP As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_agregar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtApellidoM As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateNacimiento As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCelular As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtcurp As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnConsultaCurp As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundConsultarCurp As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label7 As Label
    Friend WithEvents BackgroundAgregar As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundValidar As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundValidaExistencia As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundConsultarCliente As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundCreditosActivos As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundActualizarTodo As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundConsultaCurpOp2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadioOp2 As RadioButton
    Friend WithEvents RadioOp1 As RadioButton
End Class
