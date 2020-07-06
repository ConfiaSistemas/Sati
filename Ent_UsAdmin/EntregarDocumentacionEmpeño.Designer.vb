<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntregarDocumentacionEmpeño
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntregarDocumentacionEmpeño))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.lblNombre = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.lblMonto = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundContrato = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundEntrega = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCalendario = New System.ComponentModel.BackgroundWorker()
        Me.labelimagen = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BackgroundActivar = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCatatula = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundTarjeta = New System.ComponentModel.BackgroundWorker()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_activar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_Procesar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 40)
        Me.Panel1.TabIndex = 2
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 4)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(183, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Entregar Documentación"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(530, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(159, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(13, 21)
        Me.lblNombre.TabIndex = 35
        Me.lblNombre.Text = "."
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblMonto.Location = New System.Drawing.Point(159, 94)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(13, 21)
        Me.lblMonto.TabIndex = 36
        Me.lblMonto.Text = "."
        '
        'BackgroundWorker1
        '
        '
        'BackgroundContrato
        '
        '
        'BackgroundEntrega
        '
        '
        'BackgroundCalendario
        '
        '
        'labelimagen
        '
        Me.labelimagen.AutoSize = True
        Me.labelimagen.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labelimagen.Location = New System.Drawing.Point(249, 461)
        Me.labelimagen.Name = "labelimagen"
        Me.labelimagen.Size = New System.Drawing.Size(42, 13)
        Me.labelimagen.TabIndex = 39
        Me.labelimagen.Text = "Imagen"
        Me.labelimagen.Visible = False
        '
        'BackgroundActivar
        '
        '
        'BackgroundCatatula
        '
        '
        'BackgroundTarjeta
        '
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Boleta de Empeño"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.DarkBlue
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton24.Location = New System.Drawing.Point(162, 324)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(216, 38)
        Me.BunifuThinButton24.TabIndex = 42
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuThinButton24.Visible = False
        '
        'btn_activar
        '
        Me.btn_activar.ActiveBorderThickness = 1
        Me.btn_activar.ActiveCornerRadius = 20
        Me.btn_activar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_activar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_activar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_activar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_activar.BackgroundImage = CType(resources.GetObject("btn_activar.BackgroundImage"), System.Drawing.Image)
        Me.btn_activar.ButtonText = "Activar Crédito"
        Me.btn_activar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_activar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_activar.IdleBorderThickness = 1
        Me.btn_activar.IdleCornerRadius = 20
        Me.btn_activar.IdleFillColor = System.Drawing.Color.White
        Me.btn_activar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_activar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_activar.Location = New System.Drawing.Point(162, 593)
        Me.btn_activar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_activar.Name = "btn_activar"
        Me.btn_activar.Size = New System.Drawing.Size(216, 38)
        Me.btn_activar.TabIndex = 41
        Me.btn_activar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_activar.Visible = False
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Webcam"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.DarkBlue
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(354, 436)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(94, 38)
        Me.BunifuThinButton23.TabIndex = 40
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuThinButton23.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(207, 403)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(125, 133)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 38
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Visible = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Testimonial"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.DarkBlue
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(163, 265)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(216, 38)
        Me.BunifuThinButton21.TabIndex = 32
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuThinButton21.Visible = False
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
        Me.btn_Procesar.ButtonText = "Contrato"
        Me.btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Procesar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Procesar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Procesar.IdleBorderThickness = 1
        Me.btn_Procesar.IdleCornerRadius = 20
        Me.btn_Procesar.IdleFillColor = System.Drawing.Color.White
        Me.btn_Procesar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Procesar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Procesar.Location = New System.Drawing.Point(162, 202)
        Me.btn_Procesar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Procesar.Name = "btn_Procesar"
        Me.btn_Procesar.Size = New System.Drawing.Size(216, 38)
        Me.btn_Procesar.TabIndex = 31
        Me.btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Procesar.Visible = False
        '
        'EntregarDocumentacionEmpeño
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(602, 707)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.btn_activar)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.labelimagen)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.btn_Procesar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EntregarDocumentacionEmpeño"
        Me.Text = "Entregar Documentación"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents btn_Procesar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblNombre As MonoFlat.MonoFlat_Label
    Friend WithEvents lblMonto As MonoFlat.MonoFlat_Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundContrato As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundEntrega As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundCalendario As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents labelimagen As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_activar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundActivar As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundCatatula As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundTarjeta As System.ComponentModel.BackgroundWorker
End Class
