<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarTipoCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarTipoCredito))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboModalidad = New System.Windows.Forms.ComboBox()
        Me.ComboTipo = New System.Windows.Forms.ComboBox()
        Me.ComboPlazo = New System.Windows.Forms.ComboBox()
        Me.txtInteres = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Procesar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 36)
        Me.Panel1.TabIndex = 3
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(177, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Agregar Tipo de Crédito"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(560, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'txtNombre
        '
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNombre.HintForeColor = System.Drawing.Color.White
        Me.txtNombre.HintText = ""
        Me.txtNombre.isPassword = False
        Me.txtNombre.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNombre.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNombre.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNombre.LineThickness = 3
        Me.txtNombre.Location = New System.Drawing.Point(23, 76)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(379, 33)
        Me.txtNombre.TabIndex = 14
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre"
        '
        'ComboModalidad
        '
        Me.ComboModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboModalidad.FormattingEnabled = True
        Me.ComboModalidad.Location = New System.Drawing.Point(20, 147)
        Me.ComboModalidad.Name = "ComboModalidad"
        Me.ComboModalidad.Size = New System.Drawing.Size(121, 21)
        Me.ComboModalidad.TabIndex = 15
        '
        'ComboTipo
        '
        Me.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipo.FormattingEnabled = True
        Me.ComboTipo.Location = New System.Drawing.Point(210, 147)
        Me.ComboTipo.Name = "ComboTipo"
        Me.ComboTipo.Size = New System.Drawing.Size(121, 21)
        Me.ComboTipo.TabIndex = 16
        '
        'ComboPlazo
        '
        Me.ComboPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPlazo.FormattingEnabled = True
        Me.ComboPlazo.Location = New System.Drawing.Point(20, 204)
        Me.ComboPlazo.Name = "ComboPlazo"
        Me.ComboPlazo.Size = New System.Drawing.Size(121, 21)
        Me.ComboPlazo.TabIndex = 17
        '
        'txtInteres
        '
        Me.txtInteres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInteres.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtInteres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtInteres.HintForeColor = System.Drawing.Color.White
        Me.txtInteres.HintText = ""
        Me.txtInteres.isPassword = False
        Me.txtInteres.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtInteres.LineIdleColor = System.Drawing.Color.Gray
        Me.txtInteres.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtInteres.LineThickness = 3
        Me.txtInteres.Location = New System.Drawing.Point(210, 192)
        Me.txtInteres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(178, 33)
        Me.txtInteres.TabIndex = 18
        Me.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Modalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(207, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Plazo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(207, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Interés"
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
        Me.btn_Procesar.ButtonText = "Agregar"
        Me.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Procesar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Procesar.IdleBorderThickness = 1
        Me.btn_Procesar.IdleCornerRadius = 20
        Me.btn_Procesar.IdleFillColor = System.Drawing.Color.White
        Me.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Procesar.Location = New System.Drawing.Point(210, 281)
        Me.btn_Procesar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Procesar.Name = "btn_Procesar"
        Me.btn_Procesar.Size = New System.Drawing.Size(216, 38)
        Me.btn_Procesar.TabIndex = 32
        Me.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgregarTipoCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 356)
        Me.Controls.Add(Me.btn_Procesar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.ComboPlazo)
        Me.Controls.Add(Me.ComboTipo)
        Me.Controls.Add(Me.ComboModalidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarTipoCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarTipoCredito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboModalidad As ComboBox
    Friend WithEvents ComboTipo As ComboBox
    Friend WithEvents ComboPlazo As ComboBox
    Friend WithEvents txtInteres As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Procesar As Bunifu.Framework.UI.BunifuThinButton2
End Class
