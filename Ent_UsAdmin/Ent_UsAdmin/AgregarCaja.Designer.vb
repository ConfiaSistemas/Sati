<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCaja))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.txtNocaja = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFondo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtlimite = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 36)
        Me.Panel1.TabIndex = 3
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 7)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(99, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Agregar Caja"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(301, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'txtNocaja
        '
        Me.txtNocaja.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNocaja.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNocaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtNocaja.HintForeColor = System.Drawing.Color.White
        Me.txtNocaja.HintText = ""
        Me.txtNocaja.isPassword = False
        Me.txtNocaja.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNocaja.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNocaja.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNocaja.LineThickness = 3
        Me.txtNocaja.Location = New System.Drawing.Point(102, 111)
        Me.txtNocaja.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNocaja.Name = "txtNocaja"
        Me.txtNocaja.Size = New System.Drawing.Size(142, 33)
        Me.txtNocaja.TabIndex = 12
        Me.txtNocaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(99, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Número de caja"
        '
        'txtFondo
        '
        Me.txtFondo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFondo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFondo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtFondo.HintForeColor = System.Drawing.Color.White
        Me.txtFondo.HintText = ""
        Me.txtFondo.isPassword = False
        Me.txtFondo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtFondo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtFondo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtFondo.LineThickness = 3
        Me.txtFondo.Location = New System.Drawing.Point(102, 175)
        Me.txtFondo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFondo.Name = "txtFondo"
        Me.txtFondo.Size = New System.Drawing.Size(142, 33)
        Me.txtFondo.TabIndex = 14
        Me.txtFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fondo"
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
        Me.btn_agregar.Location = New System.Drawing.Point(75, 291)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(207, 38)
        Me.btn_agregar.TabIndex = 20
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        '
        'txtlimite
        '
        Me.txtlimite.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlimite.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtlimite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtlimite.HintForeColor = System.Drawing.Color.White
        Me.txtlimite.HintText = ""
        Me.txtlimite.isPassword = False
        Me.txtlimite.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtlimite.LineIdleColor = System.Drawing.Color.Gray
        Me.txtlimite.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtlimite.LineThickness = 3
        Me.txtlimite.Location = New System.Drawing.Point(102, 236)
        Me.txtlimite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlimite.Name = "txtlimite"
        Me.txtlimite.Size = New System.Drawing.Size(142, 33)
        Me.txtlimite.TabIndex = 22
        Me.txtlimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(99, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Límite"
        '
        'AgregarCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(370, 343)
        Me.Controls.Add(Me.txtlimite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txtFondo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNocaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarCaja"
        Me.Text = "AgregarCaja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents txtNocaja As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFondo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtlimite As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
End Class
