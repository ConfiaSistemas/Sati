<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Solicitudes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Solicitudes))
        Me.dtimpuestos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.MonoFlat_Label1 = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.Combofiltro = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuVerificar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuIncompleto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeguimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuAprobacion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerHistoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuAprobado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoAutorizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gestor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtimpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuVerificar.SuspendLayout()
        Me.ContextMenuIncompleto.SuspendLayout()
        Me.ContextMenuAprobacion.SuspendLayout()
        Me.ContextMenuAprobado.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dtimpuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Fecha, Me.Monto, Me.MontoAutorizado, Me.TipoCredito, Me.Gestor, Me.Promotor, Me.Estado, Me.Tipo})
        Me.dtimpuestos.DoubleBuffered = True
        Me.dtimpuestos.EnableHeadersVisualStyles = False
        Me.dtimpuestos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtimpuestos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtimpuestos.Location = New System.Drawing.Point(60, 44)
        Me.dtimpuestos.Name = "dtimpuestos"
        Me.dtimpuestos.ReadOnly = True
        Me.dtimpuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtimpuestos.RowHeadersVisible = False
        Me.dtimpuestos.Size = New System.Drawing.Size(705, 446)
        Me.dtimpuestos.TabIndex = 4
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(84, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Solicitudes"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.MonoFlat_Label1)
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.Combofiltro)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 36)
        Me.Panel1.TabIndex = 5
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(438, 6)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(111, 25)
        Me.BunifuMaterialTextbox1.TabIndex = 7
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(667, 3)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton21.TabIndex = 4
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonoFlat_Label1
        '
        Me.MonoFlat_Label1.AutoSize = True
        Me.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.MonoFlat_Label1.Location = New System.Drawing.Point(249, 9)
        Me.MonoFlat_Label1.Name = "MonoFlat_Label1"
        Me.MonoFlat_Label1.Size = New System.Drawing.Size(48, 15)
        Me.MonoFlat_Label1.TabIndex = 8
        Me.MonoFlat_Label1.Text = "Mostrar"
        '
        'Combofiltro
        '
        Me.Combofiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combofiltro.FormattingEnabled = True
        Me.Combofiltro.Items.AddRange(New Object() {"Por Nombre", "Rechazadas", "Autorizadas", "En Espera", "Verificadas", "Incompletas", "Todas"})
        Me.Combofiltro.Location = New System.Drawing.Point(305, 5)
        Me.Combofiltro.Name = "Combofiltro"
        Me.Combofiltro.Size = New System.Drawing.Size(121, 21)
        Me.Combofiltro.TabIndex = 9
        '
        'BackgroundWorker1
        '
        '
        'ContextMenuVerificar
        '
        Me.ContextMenuVerificar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuVerificar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerificarToolStripMenuItem})
        Me.ContextMenuVerificar.Name = "ContextMenuVerificar"
        Me.ContextMenuVerificar.Size = New System.Drawing.Size(117, 26)
        '
        'VerificarToolStripMenuItem
        '
        Me.VerificarToolStripMenuItem.Name = "VerificarToolStripMenuItem"
        Me.VerificarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.VerificarToolStripMenuItem.Text = "Verificar"
        '
        'ContextMenuIncompleto
        '
        Me.ContextMenuIncompleto.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuIncompleto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeguimientoToolStripMenuItem})
        Me.ContextMenuIncompleto.Name = "ContextMenuIncompleto"
        Me.ContextMenuIncompleto.Size = New System.Drawing.Size(142, 26)
        '
        'SeguimientoToolStripMenuItem
        '
        Me.SeguimientoToolStripMenuItem.Name = "SeguimientoToolStripMenuItem"
        Me.SeguimientoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SeguimientoToolStripMenuItem.Text = "Seguimiento"
        '
        'ContextMenuAprobacion
        '
        Me.ContextMenuAprobacion.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuAprobacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.VerHistoriaToolStripMenuItem})
        Me.ContextMenuAprobacion.Name = "ContextMenuIncompleto"
        Me.ContextMenuAprobacion.Size = New System.Drawing.Size(133, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem1.Text = "Revisar"
        '
        'VerHistoriaToolStripMenuItem
        '
        Me.VerHistoriaToolStripMenuItem.Name = "VerHistoriaToolStripMenuItem"
        Me.VerHistoriaToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.VerHistoriaToolStripMenuItem.Text = "Ver historia"
        '
        'ContextMenuAprobado
        '
        Me.ContextMenuAprobado.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuAprobado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.VerSolicitudToolStripMenuItem})
        Me.ContextMenuAprobado.Name = "ContextMenuIncompleto"
        Me.ContextMenuAprobado.Size = New System.Drawing.Size(140, 48)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem2.Text = "Ver historia"
        '
        'VerSolicitudToolStripMenuItem
        '
        Me.VerSolicitudToolStripMenuItem.Name = "VerSolicitudToolStripMenuItem"
        Me.VerSolicitudToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.VerSolicitudToolStripMenuItem.Text = "Ver Solicitud"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_agregar.BackgroundImage = Global.ConfiaAdmin.My.Resources.Resources.impuestos_mas
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Location = New System.Drawing.Point(12, 53)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(40, 35)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 42
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 68
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 70
        '
        'MontoAutorizado
        '
        Me.MontoAutorizado.HeaderText = "Monto Autorizado"
        Me.MontoAutorizado.Name = "MontoAutorizado"
        Me.MontoAutorizado.ReadOnly = True
        Me.MontoAutorizado.Width = 126
        '
        'TipoCredito
        '
        Me.TipoCredito.HeaderText = "Tipo"
        Me.TipoCredito.Name = "TipoCredito"
        Me.TipoCredito.ReadOnly = True
        Me.TipoCredito.Width = 55
        '
        'Gestor
        '
        Me.Gestor.HeaderText = "Gestor"
        Me.Gestor.Name = "Gestor"
        Me.Gestor.ReadOnly = True
        Me.Gestor.Width = 71
        '
        'Promotor
        '
        Me.Promotor.HeaderText = "Promotor"
        Me.Promotor.Name = "Promotor"
        Me.Promotor.ReadOnly = True
        Me.Promotor.Width = 86
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 71
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Visible = False
        Me.Tipo.Width = 55
        '
        'Solicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 493)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dtimpuestos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Solicitudes"
        Me.Text = "Solicitudes"
        CType(Me.dtimpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuVerificar.ResumeLayout(False)
        Me.ContextMenuIncompleto.ResumeLayout(False)
        Me.ContextMenuAprobacion.ResumeLayout(False)
        Me.ContextMenuAprobado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_agregar As Button
    Friend WithEvents dtimpuestos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuVerificar As ContextMenuStrip
    Friend WithEvents VerificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuIncompleto As ContextMenuStrip
    Friend WithEvents SeguimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuAprobacion As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuAprobado As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents VerHistoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSolicitudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents MonoFlat_Label1 As MonoFlat.MonoFlat_Label
    Friend WithEvents Combofiltro As ComboBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents MontoAutorizado As DataGridViewTextBoxColumn
    Friend WithEvents TipoCredito As DataGridViewTextBoxColumn
    Friend WithEvents Gestor As DataGridViewTextBoxColumn
    Friend WithEvents Promotor As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
End Class
