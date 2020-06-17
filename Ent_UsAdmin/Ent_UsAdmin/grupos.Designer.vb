<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grupos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.MonoFlat_Label1 = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.txtfiltro = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Combofiltro = New System.Windows.Forms.ComboBox()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.dtgrupos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.MonoFlat_Label1)
        Me.Panel1.Controls.Add(Me.txtfiltro)
        Me.Panel1.Controls.Add(Me.Combofiltro)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 36)
        Me.Panel1.TabIndex = 0
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(12, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(60, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 2
        Me.MonoFlat_HeaderLabel1.Text = "Grupos"
        '
        'MonoFlat_Label1
        '
        Me.MonoFlat_Label1.AutoSize = True
        Me.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.MonoFlat_Label1.Location = New System.Drawing.Point(136, 9)
        Me.MonoFlat_Label1.Name = "MonoFlat_Label1"
        Me.MonoFlat_Label1.Size = New System.Drawing.Size(73, 15)
        Me.MonoFlat_Label1.TabIndex = 5
        Me.MonoFlat_Label1.Text = "Mostrar sólo"
        '
        'txtfiltro
        '
        Me.txtfiltro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfiltro.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtfiltro.ForeColor = System.Drawing.Color.White
        Me.txtfiltro.HintForeColor = System.Drawing.Color.White
        Me.txtfiltro.HintText = ""
        Me.txtfiltro.isPassword = False
        Me.txtfiltro.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtfiltro.LineIdleColor = System.Drawing.Color.Gray
        Me.txtfiltro.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtfiltro.LineThickness = 3
        Me.txtfiltro.Location = New System.Drawing.Point(343, 3)
        Me.txtfiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(111, 25)
        Me.txtfiltro.TabIndex = 4
        Me.txtfiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Combofiltro
        '
        Me.Combofiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combofiltro.FormattingEnabled = True
        Me.Combofiltro.Location = New System.Drawing.Point(215, 5)
        Me.Combofiltro.Name = "Combofiltro"
        Me.Combofiltro.Size = New System.Drawing.Size(121, 21)
        Me.Combofiltro.TabIndex = 6
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(491, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 1
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'dtgrupos
        '
        Me.dtgrupos.AllowUserToAddRows = False
        Me.dtgrupos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgrupos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtgrupos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Codigo, Me.Nombre})
        Me.dtgrupos.DoubleBuffered = True
        Me.dtgrupos.EnableHeadersVisualStyles = False
        Me.dtgrupos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtgrupos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtgrupos.Location = New System.Drawing.Point(58, 42)
        Me.dtgrupos.Name = "dtgrupos"
        Me.dtgrupos.ReadOnly = True
        Me.dtgrupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgrupos.RowHeadersVisible = False
        Me.dtgrupos.Size = New System.Drawing.Size(442, 274)
        Me.dtgrupos.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Visible = False
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 341
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_agregar.BackgroundImage = Global.ConfiaAdmin.My.Resources.Resources.grupos_agregar
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Location = New System.Drawing.Point(12, 42)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(40, 35)
        Me.btn_agregar.TabIndex = 2
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 321)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dtgrupos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "grupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EvolveControlBox1 As ConfiaAdmin.EvolveControlBox
    Friend WithEvents MonoFlat_HeaderLabel1 As ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents dtgrupos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtfiltro As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_Label1 As ConfiaAdmin.MonoFlat.MonoFlat_Label
    Friend WithEvents Combofiltro As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
