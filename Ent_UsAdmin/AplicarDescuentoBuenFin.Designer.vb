<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AplicarDescuentoBuenFin

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AplicarDescuentoBuenFin))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.lblNoTicket = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel4 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.MonoFlat_HeaderLabel7 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_HeaderLabel8 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.txtAddComentario = New System.Windows.Forms.TextBox()
        Me.MonoFlat_HeaderLabel9 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BackgroundActNotificacion = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundVerificaNotificacion = New System.ComponentModel.BackgroundWorker()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dtDetalle = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1.SuspendLayout()
        CType(Me.dtDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 36)
        Me.Panel1.TabIndex = 1
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(4, 1)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(148, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 0
        Me.MonoFlat_HeaderLabel1.Text = "Descuento Buen Fin"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(494, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 1
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'lblNoTicket
        '
        Me.lblNoTicket.AutoSize = True
        Me.lblNoTicket.BackColor = System.Drawing.Color.Transparent
        Me.lblNoTicket.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNoTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNoTicket.Location = New System.Drawing.Point(92, 75)
        Me.lblNoTicket.Name = "lblNoTicket"
        Me.lblNoTicket.Size = New System.Drawing.Size(21, 20)
        Me.lblNoTicket.TabIndex = 5
        Me.lblNoTicket.Text = "..."
        '
        'MonoFlat_HeaderLabel4
        '
        Me.MonoFlat_HeaderLabel4.AutoSize = True
        Me.MonoFlat_HeaderLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel4.Location = New System.Drawing.Point(12, 75)
        Me.MonoFlat_HeaderLabel4.Name = "MonoFlat_HeaderLabel4"
        Me.MonoFlat_HeaderLabel4.Size = New System.Drawing.Size(87, 20)
        Me.MonoFlat_HeaderLabel4.TabIndex = 4
        Me.MonoFlat_HeaderLabel4.Text = "Descuento:"
        '
        'BackgroundWorker1
        '
        '
        'txtComentario
        '
        Me.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComentario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtComentario.ForeColor = System.Drawing.Color.White
        Me.txtComentario.Location = New System.Drawing.Point(116, 131)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ReadOnly = True
        Me.txtComentario.Size = New System.Drawing.Size(260, 35)
        Me.txtComentario.TabIndex = 9
        '
        'MonoFlat_HeaderLabel7
        '
        Me.MonoFlat_HeaderLabel7.AutoSize = True
        Me.MonoFlat_HeaderLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel7.Location = New System.Drawing.Point(15, 131)
        Me.MonoFlat_HeaderLabel7.Name = "MonoFlat_HeaderLabel7"
        Me.MonoFlat_HeaderLabel7.Size = New System.Drawing.Size(95, 20)
        Me.MonoFlat_HeaderLabel7.TabIndex = 10
        Me.MonoFlat_HeaderLabel7.Text = "Comentario:"
        '
        'MonoFlat_HeaderLabel8
        '
        Me.MonoFlat_HeaderLabel8.AutoSize = True
        Me.MonoFlat_HeaderLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel8.Location = New System.Drawing.Point(13, 194)
        Me.MonoFlat_HeaderLabel8.Name = "MonoFlat_HeaderLabel8"
        Me.MonoFlat_HeaderLabel8.Size = New System.Drawing.Size(62, 20)
        Me.MonoFlat_HeaderLabel8.TabIndex = 11
        Me.MonoFlat_HeaderLabel8.Text = "Detalle:"
        '
        'txtAddComentario
        '
        Me.txtAddComentario.Location = New System.Drawing.Point(16, 335)
        Me.txtAddComentario.Multiline = True
        Me.txtAddComentario.Name = "txtAddComentario"
        Me.txtAddComentario.Size = New System.Drawing.Size(400, 46)
        Me.txtAddComentario.TabIndex = 12
        '
        'MonoFlat_HeaderLabel9
        '
        Me.MonoFlat_HeaderLabel9.AutoSize = True
        Me.MonoFlat_HeaderLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel9.Location = New System.Drawing.Point(13, 312)
        Me.MonoFlat_HeaderLabel9.Name = "MonoFlat_HeaderLabel9"
        Me.MonoFlat_HeaderLabel9.Size = New System.Drawing.Size(144, 20)
        Me.MonoFlat_HeaderLabel9.TabIndex = 13
        Me.MonoFlat_HeaderLabel9.Text = "Añadir comentario:"
        '
        'BackgroundActNotificacion
        '
        '
        'BackgroundVerificaNotificacion
        '
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Rechazar"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(306, 407)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(100, 41)
        Me.BunifuThinButton22.TabIndex = 15
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuThinButton21.ButtonText = "Autorizar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(156, 407)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(102, 41)
        Me.BunifuThinButton21.TabIndex = 14
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtDetalle
        '
        Me.dtDetalle.AllowUserToAddRows = False
        Me.dtDetalle.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtDetalle.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetalle.DoubleBuffered = True
        Me.dtDetalle.EnableHeadersVisualStyles = False
        Me.dtDetalle.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtDetalle.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtDetalle.Location = New System.Drawing.Point(17, 217)
        Me.dtDetalle.Name = "dtDetalle"
        Me.dtDetalle.ReadOnly = True
        Me.dtDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtDetalle.RowHeadersVisible = False
        Me.dtDetalle.Size = New System.Drawing.Size(532, 72)
        Me.dtDetalle.TabIndex = 8
        '
        'AplicarDescuentoBuenFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 462)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel9)
        Me.Controls.Add(Me.txtAddComentario)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel8)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel7)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.dtDetalle)
        Me.Controls.Add(Me.lblNoTicket)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AplicarDescuentoBuenFin"
        Me.Text = "Aplicar descuento a promesa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents lblNoTicket As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel4 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents MonoFlat_HeaderLabel7 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents MonoFlat_HeaderLabel8 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents txtAddComentario As TextBox
    Friend WithEvents MonoFlat_HeaderLabel9 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundActNotificacion As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundVerificaNotificacion As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtDetalle As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
