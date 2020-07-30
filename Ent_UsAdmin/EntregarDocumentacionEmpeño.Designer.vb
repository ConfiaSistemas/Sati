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
        Me.BackgroundTestimonial = New System.ComponentModel.BackgroundWorker()
        Me.labelimagen = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BackgroundActivar = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundBoleta = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundTarjeta = New System.ComponentModel.BackgroundWorker()
        Me.btn_Boleta = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_activarEmpeño = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_Webcam = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_Testimonial = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_Contrato = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_EntregarEmpeño = New Bunifu.Framework.UI.BunifuThinButton2()
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
        'BackgroundTestimonial
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
        'BackgroundBoleta
        '
        '
        'BackgroundTarjeta
        '
        '
        'btn_Boleta
        '
        Me.btn_Boleta.ActiveBorderThickness = 1
        Me.btn_Boleta.ActiveCornerRadius = 20
        Me.btn_Boleta.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Boleta.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Boleta.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Boleta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_Boleta.BackgroundImage = CType(resources.GetObject("btn_Boleta.BackgroundImage"), System.Drawing.Image)
        Me.btn_Boleta.ButtonText = "Boleta de Empeño"
        Me.btn_Boleta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Boleta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Boleta.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Boleta.IdleBorderThickness = 1
        Me.btn_Boleta.IdleCornerRadius = 20
        Me.btn_Boleta.IdleFillColor = System.Drawing.Color.White
        Me.btn_Boleta.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Boleta.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Boleta.Location = New System.Drawing.Point(162, 324)
        Me.btn_Boleta.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Boleta.Name = "btn_Boleta"
        Me.btn_Boleta.Size = New System.Drawing.Size(216, 38)
        Me.btn_Boleta.TabIndex = 42
        Me.btn_Boleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Boleta.Visible = False
        '
        'btn_activarEmpeño
        '
        Me.btn_activarEmpeño.ActiveBorderThickness = 1
        Me.btn_activarEmpeño.ActiveCornerRadius = 20
        Me.btn_activarEmpeño.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_activarEmpeño.ActiveForecolor = System.Drawing.Color.White
        Me.btn_activarEmpeño.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_activarEmpeño.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_activarEmpeño.BackgroundImage = CType(resources.GetObject("btn_activarEmpeño.BackgroundImage"), System.Drawing.Image)
        Me.btn_activarEmpeño.ButtonText = "Activar Crédito"
        Me.btn_activarEmpeño.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_activarEmpeño.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activarEmpeño.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_activarEmpeño.IdleBorderThickness = 1
        Me.btn_activarEmpeño.IdleCornerRadius = 20
        Me.btn_activarEmpeño.IdleFillColor = System.Drawing.Color.White
        Me.btn_activarEmpeño.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_activarEmpeño.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_activarEmpeño.Location = New System.Drawing.Point(162, 593)
        Me.btn_activarEmpeño.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_activarEmpeño.Name = "btn_activarEmpeño"
        Me.btn_activarEmpeño.Size = New System.Drawing.Size(216, 38)
        Me.btn_activarEmpeño.TabIndex = 41
        Me.btn_activarEmpeño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_activarEmpeño.Visible = False
        '
        'btn_Webcam
        '
        Me.btn_Webcam.ActiveBorderThickness = 1
        Me.btn_Webcam.ActiveCornerRadius = 20
        Me.btn_Webcam.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Webcam.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Webcam.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Webcam.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_Webcam.BackgroundImage = CType(resources.GetObject("btn_Webcam.BackgroundImage"), System.Drawing.Image)
        Me.btn_Webcam.ButtonText = "Webcam"
        Me.btn_Webcam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Webcam.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Webcam.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Webcam.IdleBorderThickness = 1
        Me.btn_Webcam.IdleCornerRadius = 20
        Me.btn_Webcam.IdleFillColor = System.Drawing.Color.White
        Me.btn_Webcam.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Webcam.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Webcam.Location = New System.Drawing.Point(354, 436)
        Me.btn_Webcam.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Webcam.Name = "btn_Webcam"
        Me.btn_Webcam.Size = New System.Drawing.Size(94, 38)
        Me.btn_Webcam.TabIndex = 40
        Me.btn_Webcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Webcam.Visible = False
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
        'btn_Testimonial
        '
        Me.btn_Testimonial.ActiveBorderThickness = 1
        Me.btn_Testimonial.ActiveCornerRadius = 20
        Me.btn_Testimonial.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Testimonial.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Testimonial.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Testimonial.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_Testimonial.BackgroundImage = CType(resources.GetObject("btn_Testimonial.BackgroundImage"), System.Drawing.Image)
        Me.btn_Testimonial.ButtonText = "Testimonial"
        Me.btn_Testimonial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Testimonial.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Testimonial.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Testimonial.IdleBorderThickness = 1
        Me.btn_Testimonial.IdleCornerRadius = 20
        Me.btn_Testimonial.IdleFillColor = System.Drawing.Color.White
        Me.btn_Testimonial.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Testimonial.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Testimonial.Location = New System.Drawing.Point(163, 265)
        Me.btn_Testimonial.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Testimonial.Name = "btn_Testimonial"
        Me.btn_Testimonial.Size = New System.Drawing.Size(216, 38)
        Me.btn_Testimonial.TabIndex = 32
        Me.btn_Testimonial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Testimonial.Visible = False
        '
        'btn_Contrato
        '
        Me.btn_Contrato.ActiveBorderThickness = 1
        Me.btn_Contrato.ActiveCornerRadius = 20
        Me.btn_Contrato.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Contrato.ActiveForecolor = System.Drawing.Color.White
        Me.btn_Contrato.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_Contrato.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_Contrato.BackgroundImage = CType(resources.GetObject("btn_Contrato.BackgroundImage"), System.Drawing.Image)
        Me.btn_Contrato.ButtonText = "Contrato"
        Me.btn_Contrato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Contrato.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Contrato.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_Contrato.IdleBorderThickness = 1
        Me.btn_Contrato.IdleCornerRadius = 20
        Me.btn_Contrato.IdleFillColor = System.Drawing.Color.White
        Me.btn_Contrato.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_Contrato.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_Contrato.Location = New System.Drawing.Point(162, 202)
        Me.btn_Contrato.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Contrato.Name = "btn_Contrato"
        Me.btn_Contrato.Size = New System.Drawing.Size(216, 38)
        Me.btn_Contrato.TabIndex = 31
        Me.btn_Contrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_Contrato.Visible = False
        '
        'btn_EntregarEmpeño
        '
        Me.btn_EntregarEmpeño.ActiveBorderThickness = 1
        Me.btn_EntregarEmpeño.ActiveCornerRadius = 20
        Me.btn_EntregarEmpeño.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_EntregarEmpeño.ActiveForecolor = System.Drawing.Color.White
        Me.btn_EntregarEmpeño.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_EntregarEmpeño.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_EntregarEmpeño.BackgroundImage = CType(resources.GetObject("btn_EntregarEmpeño.BackgroundImage"), System.Drawing.Image)
        Me.btn_EntregarEmpeño.ButtonText = "Entregar Empeño"
        Me.btn_EntregarEmpeño.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EntregarEmpeño.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EntregarEmpeño.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_EntregarEmpeño.IdleBorderThickness = 1
        Me.btn_EntregarEmpeño.IdleCornerRadius = 20
        Me.btn_EntregarEmpeño.IdleFillColor = System.Drawing.Color.White
        Me.btn_EntregarEmpeño.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_EntregarEmpeño.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_EntregarEmpeño.Location = New System.Drawing.Point(163, 142)
        Me.btn_EntregarEmpeño.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_EntregarEmpeño.Name = "btn_EntregarEmpeño"
        Me.btn_EntregarEmpeño.Size = New System.Drawing.Size(216, 38)
        Me.btn_EntregarEmpeño.TabIndex = 43
        Me.btn_EntregarEmpeño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_EntregarEmpeño.Visible = False
        '
        'EntregarDocumentacionEmpeño
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(602, 707)
        Me.Controls.Add(Me.btn_EntregarEmpeño)
        Me.Controls.Add(Me.btn_Boleta)
        Me.Controls.Add(Me.btn_activarEmpeño)
        Me.Controls.Add(Me.btn_Webcam)
        Me.Controls.Add(Me.labelimagen)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btn_Testimonial)
        Me.Controls.Add(Me.btn_Contrato)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EntregarDocumentacionEmpeño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents btn_Contrato As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_Testimonial As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lblNombre As MonoFlat.MonoFlat_Label
    Friend WithEvents lblMonto As MonoFlat.MonoFlat_Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundContrato As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundEntrega As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundTestimonial As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents labelimagen As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_Webcam As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_activarEmpeño As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundActivar As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Boleta As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundBoleta As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundTarjeta As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_EntregarEmpeño As Bunifu.Framework.UI.BunifuThinButton2
End Class
