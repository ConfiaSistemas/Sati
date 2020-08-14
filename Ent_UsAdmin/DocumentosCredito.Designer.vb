<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocumentosCredito
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentosCredito))
        Me.dtdatosDocumentosNuevos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.idTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.btn_actualizar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.BackgroundDocumentos = New System.ComponentModel.BackgroundWorker()
        CType(Me.dtdatosDocumentosNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtdatosDocumentosNuevos
        '
        Me.dtdatosDocumentosNuevos.AllowUserToAddRows = False
        Me.dtdatosDocumentosNuevos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatosDocumentosNuevos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtdatosDocumentosNuevos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatosDocumentosNuevos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatosDocumentosNuevos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatosDocumentosNuevos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatosDocumentosNuevos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtdatosDocumentosNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatosDocumentosNuevos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTipoDocumento, Me.NombreDocumento, Me.Imagen})
        Me.dtdatosDocumentosNuevos.DoubleBuffered = True
        Me.dtdatosDocumentosNuevos.EnableHeadersVisualStyles = False
        Me.dtdatosDocumentosNuevos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatosDocumentosNuevos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatosDocumentosNuevos.Location = New System.Drawing.Point(12, 117)
        Me.dtdatosDocumentosNuevos.Name = "dtdatosDocumentosNuevos"
        Me.dtdatosDocumentosNuevos.ReadOnly = True
        Me.dtdatosDocumentosNuevos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatosDocumentosNuevos.RowHeadersVisible = False
        Me.dtdatosDocumentosNuevos.Size = New System.Drawing.Size(685, 327)
        Me.dtdatosDocumentosNuevos.TabIndex = 28
        '
        'idTipoDocumento
        '
        Me.idTipoDocumento.HeaderText = "idTipoDocumento"
        Me.idTipoDocumento.Name = "idTipoDocumento"
        Me.idTipoDocumento.ReadOnly = True
        '
        'NombreDocumento
        '
        Me.NombreDocumento.HeaderText = "NombreDocumento"
        Me.NombreDocumento.Name = "NombreDocumento"
        Me.NombreDocumento.ReadOnly = True
        '
        'Imagen
        '
        Me.Imagen.FillWeight = 300.0!
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 36)
        Me.Panel1.TabIndex = 29
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(159, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Agregar Documentos"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(636, 4)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.ActiveBorderThickness = 1
        Me.btn_actualizar.ActiveCornerRadius = 20
        Me.btn_actualizar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_actualizar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_actualizar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_actualizar.BackgroundImage = CType(resources.GetObject("btn_actualizar.BackgroundImage"), System.Drawing.Image)
        Me.btn_actualizar.ButtonText = "Insertar"
        Me.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.DarkBlue
        Me.btn_actualizar.IdleBorderThickness = 1
        Me.btn_actualizar.IdleCornerRadius = 20
        Me.btn_actualizar.IdleFillColor = System.Drawing.Color.White
        Me.btn_actualizar.IdleForecolor = System.Drawing.Color.Gray
        Me.btn_actualizar.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btn_actualizar.Location = New System.Drawing.Point(230, 468)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(207, 38)
        Me.btn_actualizar.TabIndex = 30
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 76)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(27, 21)
        Me.btn_agregar.TabIndex = 53
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'BackgroundDocumentos
        '
        '
        'DocumentosCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(709, 530)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtdatosDocumentosNuevos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DocumentosCredito"
        Me.Text = "DocumentosCreditoLegal"
        CType(Me.dtdatosDocumentosNuevos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtdatosDocumentosNuevos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents idTipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NombreDocumento As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents btn_actualizar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_agregar As Button
    Friend WithEvents BackgroundDocumentos As System.ComponentModel.BackgroundWorker
End Class
