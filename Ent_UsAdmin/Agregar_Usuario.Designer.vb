<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Usuario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtcontra = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.dateusr = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblgrupo = New System.Windows.Forms.Label()
        Me.lblcdggrp = New System.Windows.Forms.Label()
        Me.lblnmgrp = New System.Windows.Forms.Label()
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.timerformato = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Switchactivo = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtempleado = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 36)
        Me.Panel1.TabIndex = 1
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(148, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Dar de alta usuarios"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(392, 4)
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
        Me.txtnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtnombre.HintForeColor = System.Drawing.Color.White
        Me.txtnombre.HintText = ""
        Me.txtnombre.isPassword = False
        Me.txtnombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtnombre.LineIdleColor = System.Drawing.Color.Gray
        Me.txtnombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtnombre.LineThickness = 3
        Me.txtnombre.Location = New System.Drawing.Point(38, 131)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(379, 33)
        Me.txtnombre.TabIndex = 2
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtcontra
        '
        Me.txtcontra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontra.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtcontra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtcontra.HintForeColor = System.Drawing.Color.White
        Me.txtcontra.HintText = ""
        Me.txtcontra.isPassword = True
        Me.txtcontra.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtcontra.LineIdleColor = System.Drawing.Color.Gray
        Me.txtcontra.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtcontra.LineThickness = 3
        Me.txtcontra.Location = New System.Drawing.Point(38, 194)
        Me.txtcontra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(379, 33)
        Me.txtcontra.TabIndex = 4
        Me.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.ForeColor = System.Drawing.Color.White
        Me.lblcontraseña.Location = New System.Drawing.Point(35, 182)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblcontraseña.TabIndex = 3
        Me.lblcontraseña.Text = "Contraseña"
        '
        'dateusr
        '
        Me.dateusr.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.dateusr.BorderRadius = 0
        Me.dateusr.ForeColor = System.Drawing.Color.White
        Me.dateusr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateusr.FormatCustom = Nothing
        Me.dateusr.Location = New System.Drawing.Point(26, 279)
        Me.dateusr.Name = "dateusr"
        Me.dateusr.Size = New System.Drawing.Size(177, 36)
        Me.dateusr.TabIndex = 5
        Me.dateusr.Value = New Date(2018, 2, 8, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha de Alta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(339, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Activo"
        '
        'txtusuario
        '
        Me.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtusuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtusuario.HintForeColor = System.Drawing.Color.White
        Me.txtusuario.HintText = ""
        Me.txtusuario.isPassword = False
        Me.txtusuario.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtusuario.LineIdleColor = System.Drawing.Color.Gray
        Me.txtusuario.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtusuario.LineThickness = 3
        Me.txtusuario.Location = New System.Drawing.Point(38, 69)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(379, 33)
        Me.txtusuario.TabIndex = 10
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(35, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Usuario"
        '
        'lblgrupo
        '
        Me.lblgrupo.AutoSize = True
        Me.lblgrupo.ForeColor = System.Drawing.Color.White
        Me.lblgrupo.Location = New System.Drawing.Point(219, 249)
        Me.lblgrupo.Name = "lblgrupo"
        Me.lblgrupo.Size = New System.Drawing.Size(36, 13)
        Me.lblgrupo.TabIndex = 11
        Me.lblgrupo.Text = "Grupo"
        '
        'lblcdggrp
        '
        Me.lblcdggrp.AutoSize = True
        Me.lblcdggrp.ForeColor = System.Drawing.Color.White
        Me.lblcdggrp.Location = New System.Drawing.Point(297, 269)
        Me.lblcdggrp.Name = "lblcdggrp"
        Me.lblcdggrp.Size = New System.Drawing.Size(33, 13)
        Me.lblcdggrp.TabIndex = 13
        Me.lblcdggrp.Text = "Label"
        '
        'lblnmgrp
        '
        Me.lblnmgrp.ForeColor = System.Drawing.Color.White
        Me.lblnmgrp.Location = New System.Drawing.Point(297, 287)
        Me.lblnmgrp.Name = "lblnmgrp"
        Me.lblnmgrp.Size = New System.Drawing.Size(133, 43)
        Me.lblnmgrp.TabIndex = 14
        Me.lblnmgrp.Text = "Label"
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(222, 279)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(47, 20)
        Me.txtgrupo.TabIndex = 15
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(55, 109)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 151)
        Me.FlowLayoutPanel1.TabIndex = 17
        Me.FlowLayoutPanel1.Visible = False
        '
        'timerformato
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Button1.BackgroundImage = Global.ConfiaAdmin.My.Resources.Resources._196766_200
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(267, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 20)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Switchactivo
        '
        Me.Switchactivo.BackColor = System.Drawing.Color.Transparent
        Me.Switchactivo.BackgroundImage = CType(resources.GetObject("Switchactivo.BackgroundImage"), System.Drawing.Image)
        Me.Switchactivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Switchactivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Switchactivo.Location = New System.Drawing.Point(382, 42)
        Me.Switchactivo.Name = "Switchactivo"
        Me.Switchactivo.OffColor = System.Drawing.Color.Gray
        Me.Switchactivo.OnColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Switchactivo.Size = New System.Drawing.Size(35, 20)
        Me.Switchactivo.TabIndex = 7
        Me.Switchactivo.Value = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Image = Global.ConfiaAdmin.My.Resources.Resources.ojochico
        Me.Label5.Location = New System.Drawing.Point(389, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "       "
        '
        'btn_agregar
        '
        Me.btn_agregar.ActiveBorderThickness = 1
        Me.btn_agregar.ActiveCornerRadius = 20
        Me.btn_agregar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_agregar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_agregar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.ButtonText = "Dar de alta"
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_agregar.IdleBorderThickness = 1
        Me.btn_agregar.IdleCornerRadius = 20
        Me.btn_agregar.IdleFillColor = System.Drawing.Color.White
        Me.btn_agregar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_agregar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_agregar.Location = New System.Drawing.Point(123, 411)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(207, 38)
        Me.btn_agregar.TabIndex = 19
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtempleado
        '
        Me.txtempleado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtempleado.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtempleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtempleado.HintForeColor = System.Drawing.Color.White
        Me.txtempleado.HintText = ""
        Me.txtempleado.isPassword = False
        Me.txtempleado.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtempleado.LineIdleColor = System.Drawing.Color.Gray
        Me.txtempleado.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtempleado.LineThickness = 3
        Me.txtempleado.Location = New System.Drawing.Point(38, 334)
        Me.txtempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtempleado.Name = "txtempleado"
        Me.txtempleado.Size = New System.Drawing.Size(143, 33)
        Me.txtempleado.TabIndex = 21
        Me.txtempleado.Text = "0"
        Me.txtempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Empleado"
        '
        'lblempleado
        '
        Me.lblempleado.AutoSize = True
        Me.lblempleado.ForeColor = System.Drawing.Color.White
        Me.lblempleado.Location = New System.Drawing.Point(201, 354)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(16, 13)
        Me.lblempleado.TabIndex = 22
        Me.lblempleado.Text = "..."
        '
        'Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(463, 463)
        Me.Controls.Add(Me.lblempleado)
        Me.Controls.Add(Me.txtempleado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtgrupo)
        Me.Controls.Add(Me.lblnmgrp)
        Me.Controls.Add(Me.lblcdggrp)
        Me.Controls.Add(Me.lblgrupo)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Switchactivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateusr)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dar de alta usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EvolveControlBox1 As ConfiaAdmin.EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtnombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtcontra As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents dateusr As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Switchactivo As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblgrupo As System.Windows.Forms.Label
    Friend WithEvents lblcdggrp As System.Windows.Forms.Label
    Friend WithEvents lblnmgrp As System.Windows.Forms.Label
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents timerformato As System.Windows.Forms.Timer
    Friend WithEvents txtusuario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtempleado As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblempleado As Label
End Class
