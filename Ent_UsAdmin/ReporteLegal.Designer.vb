<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteLegal

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteLegal))
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.dtimpuestos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboFiltro = New System.Windows.Forms.ComboBox()
        Me.BackgroundAbogados = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundPromotores = New System.ComponentModel.BackgroundWorker()
        Me.ComboElección = New System.Windows.Forms.ComboBox()
        Me.BackgroundConsulta = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundExcel = New System.ComponentModel.BackgroundWorker()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.dtimpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(63, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(179, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Cuentas activas en Legal"
        '
        'dtimpuestos
        '
        Me.dtimpuestos.AllowUserToAddRows = False
        Me.dtimpuestos.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtimpuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtimpuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtimpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtimpuestos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtimpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtimpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtimpuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtimpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtimpuestos.DoubleBuffered = True
        Me.dtimpuestos.EnableHeadersVisualStyles = False
        Me.dtimpuestos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtimpuestos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtimpuestos.Location = New System.Drawing.Point(1, 122)
        Me.dtimpuestos.Name = "dtimpuestos"
        Me.dtimpuestos.ReadOnly = True
        Me.dtimpuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtimpuestos.RowHeadersVisible = False
        Me.dtimpuestos.Size = New System.Drawing.Size(1194, 447)
        Me.dtimpuestos.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(1, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 36)
        Me.Panel1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 23)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Atrás"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.BunifuThinButton21.ButtonText = "Exportar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(1097, 3)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton21.TabIndex = 4
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Filtrar por"
        '
        'ComboFiltro
        '
        Me.ComboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFiltro.FormattingEnabled = True
        Me.ComboFiltro.Items.AddRange(New Object() {"Todos", "Abogado"})
        Me.ComboFiltro.Location = New System.Drawing.Point(22, 77)
        Me.ComboFiltro.Name = "ComboFiltro"
        Me.ComboFiltro.Size = New System.Drawing.Size(240, 21)
        Me.ComboFiltro.TabIndex = 30
        '
        'BackgroundAbogados
        '
        '
        'BackgroundPromotores
        '
        '
        'ComboElección
        '
        Me.ComboElección.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboElección.FormattingEnabled = True
        Me.ComboElección.ItemHeight = 13
        Me.ComboElección.Location = New System.Drawing.Point(268, 77)
        Me.ComboElección.Name = "ComboElección"
        Me.ComboElección.Size = New System.Drawing.Size(239, 21)
        Me.ComboElección.TabIndex = 31
        '
        'BackgroundConsulta
        '
        '
        'BackgroundExcel
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
        Me.BunifuThinButton22.ButtonText = "Consultar"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(515, 67)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton22.TabIndex = 5
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReporteLegal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1197, 581)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboElección)
        Me.Controls.Add(Me.ComboFiltro)
        Me.Controls.Add(Me.dtimpuestos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteLegal"
        Me.Text = "Créditos en mora"
        CType(Me.dtimpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents dtimpuestos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboFiltro As ComboBox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundAbogados As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundPromotores As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboElección As ComboBox
    Friend WithEvents BackgroundConsulta As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundExcel As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
End Class
