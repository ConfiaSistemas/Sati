<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Impuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Impuestos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtApellidoM = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateNacimiento = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCelular = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(118, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Agregar Cliente"
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
        Me.txtnombre.Location = New System.Drawing.Point(35, 78)
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
        Me.Label1.Location = New System.Drawing.Point(32, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(264, 61)
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
        Me.txtApellidoP.Location = New System.Drawing.Point(267, 78)
        Me.txtApellidoP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(170, 25)
        Me.txtApellidoP.TabIndex = 8
        Me.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.btn_agregar.ButtonText = "Agregar"
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.IdleBorderThickness = 1
        Me.btn_agregar.IdleCornerRadius = 20
        Me.btn_agregar.IdleFillColor = System.Drawing.Color.White
        Me.btn_agregar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.Location = New System.Drawing.Point(257, 275)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(207, 38)
        Me.btn_agregar.TabIndex = 15
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtApellidoM.Location = New System.Drawing.Point(469, 78)
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
        Me.Label5.Location = New System.Drawing.Point(466, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(33, 139)
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
        Me.DateNacimiento.Location = New System.Drawing.Point(36, 165)
        Me.DateNacimiento.Name = "DateNacimiento"
        Me.DateNacimiento.Size = New System.Drawing.Size(170, 36)
        Me.DateNacimiento.TabIndex = 21
        Me.DateNacimiento.Value = New Date(2019, 12, 20, 10, 35, 45, 980)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(264, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Teléfono"
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
        Me.txtTelefono.Location = New System.Drawing.Point(267, 165)
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
        Me.Label4.Location = New System.Drawing.Point(466, 148)
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
        Me.txtCelular.Location = New System.Drawing.Point(469, 165)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(170, 25)
        Me.txtCelular.TabIndex = 24
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Agregar_Impuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 347)
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
        Me.Name = "Agregar_Impuestos"
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
End Class
