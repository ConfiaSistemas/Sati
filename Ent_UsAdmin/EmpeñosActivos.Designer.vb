<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmpeñosActivos

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpeñosActivos))
        Me.dtDatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoPrestado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoRefrendo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPrimerRefrendo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuEntregar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EntregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtnombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MonoFlat_Label1 = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        CType(Me.dtDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuEntregar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtDatos
        '
        Me.dtDatos.AllowUserToAddRows = False
        Me.dtDatos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtDatos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Fecha, Me.Nombre, Me.MontoPrestado, Me.MontoRefrendo, Me.FechaPrimerRefrendo, Me.Estado})
        Me.dtDatos.DoubleBuffered = True
        Me.dtDatos.EnableHeadersVisualStyles = False
        Me.dtDatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtDatos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtDatos.Location = New System.Drawing.Point(12, 43)
        Me.dtDatos.Name = "dtDatos"
        Me.dtDatos.ReadOnly = True
        Me.dtDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtDatos.RowHeadersVisible = False
        Me.dtDatos.Size = New System.Drawing.Size(969, 500)
        Me.dtDatos.TabIndex = 6
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 68
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
        '
        'MontoPrestado
        '
        Me.MontoPrestado.HeaderText = "Monto Prestado"
        Me.MontoPrestado.Name = "MontoPrestado"
        Me.MontoPrestado.ReadOnly = True
        Me.MontoPrestado.Width = 115
        '
        'MontoRefrendo
        '
        Me.MontoRefrendo.HeaderText = "Monto Refrendo"
        Me.MontoRefrendo.Name = "MontoRefrendo"
        Me.MontoRefrendo.ReadOnly = True
        Me.MontoRefrendo.Width = 116
        '
        'FechaPrimerRefrendo
        '
        Me.FechaPrimerRefrendo.HeaderText = "Primer Refrendo"
        Me.FechaPrimerRefrendo.Name = "FechaPrimerRefrendo"
        Me.FechaPrimerRefrendo.ReadOnly = True
        Me.FechaPrimerRefrendo.Width = 114
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 71
        '
        'ContextMenuEntregar
        '
        Me.ContextMenuEntregar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntregarToolStripMenuItem, Me.InformacionToolStripMenuItem})
        Me.ContextMenuEntregar.Name = "ContextMenuEntregar"
        Me.ContextMenuEntregar.Size = New System.Drawing.Size(222, 48)
        '
        'EntregarToolStripMenuItem
        '
        Me.EntregarToolStripMenuItem.Name = "EntregarToolStripMenuItem"
        Me.EntregarToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.EntregarToolStripMenuItem.Text = "Reimprimir Documentación"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.InformacionToolStripMenuItem.Text = "Ver Información"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Actualizar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(877, 5)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(92, 28)
        Me.BunifuThinButton21.TabIndex = 7
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txtnombre.Location = New System.Drawing.Point(274, 7)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(217, 25)
        Me.txtnombre.TabIndex = 9
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MonoFlat_Label1
        '
        Me.MonoFlat_Label1.AutoSize = True
        Me.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.MonoFlat_Label1.Location = New System.Drawing.Point(164, 17)
        Me.MonoFlat_Label1.Name = "MonoFlat_Label1"
        Me.MonoFlat_Label1.Size = New System.Drawing.Size(103, 15)
        Me.MonoFlat_Label1.TabIndex = 10
        Me.MonoFlat_Label1.Text = "Filtrar por nombre"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.MonoFlat_Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 36)
        Me.Panel1.TabIndex = 11
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(129, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Empeños Activos"
        '
        'EmpeñosActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 555)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmpeñosActivos"
        Me.Text = "CreditosPorEntregar"
        CType(Me.dtDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuEntregar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtDatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ContextMenuEntregar As ContextMenuStrip
    Friend WithEvents EntregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtnombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_Label1 As MonoFlat.MonoFlat_Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents MontoPrestado As DataGridViewTextBoxColumn
    Friend WithEvents MontoRefrendo As DataGridViewTextBoxColumn
    Friend WithEvents FechaPrimerRefrendo As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
