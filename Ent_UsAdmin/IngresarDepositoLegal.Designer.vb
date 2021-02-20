<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarDepositoLegal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarDepositoLegal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel2 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtMonto = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.MonoFlat_HeaderLabel3 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel4 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.MonoFlat_HeaderLabel5 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblNombreUsuario = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.ComboUsuarios = New Bunifu.Framework.UI.BunifuDropdown()
        Me.MonoFlat_HeaderLabel6 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundUsuarios = New System.ComponentModel.BackgroundWorker()
        Me.dateFechaDeposito = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(433, 36)
        Me.Panel1.TabIndex = 9
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(363, 7)
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
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(132, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Ingresar depósito"
        '
        'MonoFlat_HeaderLabel2
        '
        Me.MonoFlat_HeaderLabel2.AutoSize = True
        Me.MonoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel2.Location = New System.Drawing.Point(265, 58)
        Me.MonoFlat_HeaderLabel2.Name = "MonoFlat_HeaderLabel2"
        Me.MonoFlat_HeaderLabel2.Size = New System.Drawing.Size(148, 20)
        Me.MonoFlat_HeaderLabel2.TabIndex = 32
        Me.MonoFlat_HeaderLabel2.Text = "Imagen de depósito"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtMonto.BorderColor = System.Drawing.Color.Gray
        Me.txtMonto.ForeColor = System.Drawing.Color.White
        Me.txtMonto.Location = New System.Drawing.Point(36, 82)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(93, 20)
        Me.txtMonto.TabIndex = 33
        '
        'MonoFlat_HeaderLabel3
        '
        Me.MonoFlat_HeaderLabel3.AutoSize = True
        Me.MonoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel3.Location = New System.Drawing.Point(32, 58)
        Me.MonoFlat_HeaderLabel3.Name = "MonoFlat_HeaderLabel3"
        Me.MonoFlat_HeaderLabel3.Size = New System.Drawing.Size(56, 20)
        Me.MonoFlat_HeaderLabel3.TabIndex = 35
        Me.MonoFlat_HeaderLabel3.Text = "Monto"
        '
        'MonoFlat_HeaderLabel4
        '
        Me.MonoFlat_HeaderLabel4.AutoSize = True
        Me.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel4.Location = New System.Drawing.Point(131, 58)
        Me.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4"
        Me.MonoFlat_HeaderLabel4.Size = New System.Drawing.Size(49, 20)
        Me.MonoFlat_HeaderLabel4.TabIndex = 36
        Me.MonoFlat_HeaderLabel4.Text = "Fecha"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(274, 81)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(125, 120)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 37
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'MonoFlat_HeaderLabel5
        '
        Me.MonoFlat_HeaderLabel5.AutoSize = True
        Me.MonoFlat_HeaderLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel5.Location = New System.Drawing.Point(32, 108)
        Me.MonoFlat_HeaderLabel5.Name = "MonoFlat_HeaderLabel5"
        Me.MonoFlat_HeaderLabel5.Size = New System.Drawing.Size(91, 20)
        Me.MonoFlat_HeaderLabel5.TabIndex = 38
        Me.MonoFlat_HeaderLabel5.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(36, 131)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(201, 70)
        Me.txtComentario.TabIndex = 39
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
        Me.BunifuThinButton21.ButtonText = "Notificar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(172, 309)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(102, 41)
        Me.BunifuThinButton21.TabIndex = 54
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(102, 270)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(21, 20)
        Me.lblNombreUsuario.TabIndex = 57
        Me.lblNombreUsuario.Text = "..."
        '
        'ComboUsuarios
        '
        Me.ComboUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.ComboUsuarios.BorderRadius = 10
        Me.ComboUsuarios.DisabledColor = System.Drawing.Color.Gray
        Me.ComboUsuarios.ForeColor = System.Drawing.Color.White
        Me.ComboUsuarios.Items = New String(-1) {}
        Me.ComboUsuarios.Location = New System.Drawing.Point(106, 222)
        Me.ComboUsuarios.Name = "ComboUsuarios"
        Me.ComboUsuarios.NomalColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboUsuarios.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ComboUsuarios.selectedIndex = -1
        Me.ComboUsuarios.Size = New System.Drawing.Size(180, 35)
        Me.ComboUsuarios.TabIndex = 56
        '
        'MonoFlat_HeaderLabel6
        '
        Me.MonoFlat_HeaderLabel6.AutoSize = True
        Me.MonoFlat_HeaderLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel6.Location = New System.Drawing.Point(33, 222)
        Me.MonoFlat_HeaderLabel6.Name = "MonoFlat_HeaderLabel6"
        Me.MonoFlat_HeaderLabel6.Size = New System.Drawing.Size(67, 20)
        Me.MonoFlat_HeaderLabel6.TabIndex = 55
        Me.MonoFlat_HeaderLabel6.Text = "Usuario:"
        '
        'BackgroundUsuarios
        '
        '
        'dateFechaDeposito
        '
        Me.dateFechaDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.dateFechaDeposito.Checked = True
        Me.dateFechaDeposito.CustomFormat = "yyyy-MM-dd"
        Me.dateFechaDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dateFechaDeposito.ForeColor = System.Drawing.Color.White
        Me.dateFechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaDeposito.Location = New System.Drawing.Point(135, 81)
        Me.dateFechaDeposito.Name = "dateFechaDeposito"
        Me.dateFechaDeposito.Size = New System.Drawing.Size(102, 18)
        Me.dateFechaDeposito.TabIndex = 58
        Me.dateFechaDeposito.TabStop = False
        Me.dateFechaDeposito.Text = "30/01/2021"
        Me.dateFechaDeposito.Value = New Date(2021, 1, 30, 12, 58, 19, 42)
        '
        'IngresarDepositoLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(436, 364)
        Me.Controls.Add(Me.dateFechaDeposito)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.ComboUsuarios)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel6)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel5)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel4)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel3)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IngresarDepositoLegal"
        Me.Text = "IngresarDepositoLegal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel2 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtMonto As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents MonoFlat_HeaderLabel3 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel4 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MonoFlat_HeaderLabel5 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblNombreUsuario As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents ComboUsuarios As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents MonoFlat_HeaderLabel6 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents BackgroundUsuarios As System.ComponentModel.BackgroundWorker
    Friend WithEvents dateFechaDeposito As Telerik.WinControls.UI.RadDateTimePicker
End Class
