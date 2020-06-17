<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsPfecha
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketsPfecha))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TreeListView1 = New WinControls.ListView.TreeListView()
        Me.ContainerColumnHeader1 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader2 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader3 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader10 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader9 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader4 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader5 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader6 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader7 = New WinControls.ListView.ContainerColumnHeader()
        Me.ContainerColumnHeader8 = New WinControls.ListView.ContainerColumnHeader()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboFiltro = New System.Windows.Forms.ComboBox()
        Me.MonoFlat_Label2 = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.MonoFlat_Label1 = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.dateHasta = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.dateDesde = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundCajas = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(379, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TreeListView1
        '
        Me.TreeListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeListView1.Columns.AddRange(New WinControls.ListView.ContainerColumnHeader() {Me.ContainerColumnHeader1, Me.ContainerColumnHeader2, Me.ContainerColumnHeader3, Me.ContainerColumnHeader10, Me.ContainerColumnHeader9, Me.ContainerColumnHeader4, Me.ContainerColumnHeader5, Me.ContainerColumnHeader6, Me.ContainerColumnHeader7, Me.ContainerColumnHeader8})
        Me.TreeListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TreeListView1.Location = New System.Drawing.Point(2, 177)
        Me.TreeListView1.Name = "TreeListView1"
        Me.TreeListView1.Size = New System.Drawing.Size(1375, 489)
        Me.TreeListView1.TabIndex = 2
        '
        'ContainerColumnHeader1
        '
        Me.ContainerColumnHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader1.Text = "ID"
        '
        'ContainerColumnHeader2
        '
        Me.ContainerColumnHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader2.Text = "IdCrédito"
        '
        'ContainerColumnHeader3
        '
        Me.ContainerColumnHeader3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader3.Text = "Nombre"
        '
        'ContainerColumnHeader10
        '
        Me.ContainerColumnHeader10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader10.Text = "PagoNormal"
        '
        'ContainerColumnHeader9
        '
        Me.ContainerColumnHeader9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader9.Text = "Intereses"
        '
        'ContainerColumnHeader4
        '
        Me.ContainerColumnHeader4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader4.Text = "Monto"
        '
        'ContainerColumnHeader5
        '
        Me.ContainerColumnHeader5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader5.Text = "Fecha"
        '
        'ContainerColumnHeader6
        '
        Me.ContainerColumnHeader6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader6.Text = "Hora"
        '
        'ContainerColumnHeader7
        '
        Me.ContainerColumnHeader7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader7.Text = "Tipo"
        '
        'ContainerColumnHeader8
        '
        Me.ContainerColumnHeader8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContainerColumnHeader8.Text = "Caja"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1375, 36)
        Me.Panel1.TabIndex = 9
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(128, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Tickets por fecha"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(1229, 66)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton21.TabIndex = 34
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(1127, 66)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(92, 31)
        Me.BunifuThinButton22.TabIndex = 35
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Cajas"
        '
        'ComboFiltro
        '
        Me.ComboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFiltro.FormattingEnabled = True
        Me.ComboFiltro.ItemHeight = 13
        Me.ComboFiltro.Location = New System.Drawing.Point(12, 76)
        Me.ComboFiltro.Name = "ComboFiltro"
        Me.ComboFiltro.Size = New System.Drawing.Size(239, 21)
        Me.ComboFiltro.TabIndex = 40
        '
        'MonoFlat_Label2
        '
        Me.MonoFlat_Label2.AutoSize = True
        Me.MonoFlat_Label2.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.MonoFlat_Label2.Location = New System.Drawing.Point(514, 46)
        Me.MonoFlat_Label2.Name = "MonoFlat_Label2"
        Me.MonoFlat_Label2.Size = New System.Drawing.Size(37, 15)
        Me.MonoFlat_Label2.TabIndex = 39
        Me.MonoFlat_Label2.Text = "Hasta"
        '
        'MonoFlat_Label1
        '
        Me.MonoFlat_Label1.AutoSize = True
        Me.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.MonoFlat_Label1.Location = New System.Drawing.Point(271, 46)
        Me.MonoFlat_Label1.Name = "MonoFlat_Label1"
        Me.MonoFlat_Label1.Size = New System.Drawing.Size(39, 15)
        Me.MonoFlat_Label1.TabIndex = 38
        Me.MonoFlat_Label1.Text = "Desde"
        '
        'dateHasta
        '
        Me.dateHasta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.dateHasta.BorderRadius = 0
        Me.dateHasta.ForeColor = System.Drawing.Color.White
        Me.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateHasta.FormatCustom = Nothing
        Me.dateHasta.Location = New System.Drawing.Point(517, 64)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(177, 33)
        Me.dateHasta.TabIndex = 37
        Me.dateHasta.Value = New Date(2020, 2, 20, 0, 0, 0, 0)
        '
        'dateDesde
        '
        Me.dateDesde.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.dateDesde.BorderRadius = 0
        Me.dateDesde.ForeColor = System.Drawing.Color.White
        Me.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDesde.FormatCustom = Nothing
        Me.dateDesde.Location = New System.Drawing.Point(274, 64)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(177, 33)
        Me.dateDesde.TabIndex = 36
        Me.dateDesde.Value = New Date(2020, 2, 20, 0, 0, 0, 0)
        '
        'BackgroundWorker1
        '
        '
        'BackgroundCajas
        '
        '
        'TicketsPfecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1380, 671)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboFiltro)
        Me.Controls.Add(Me.MonoFlat_Label2)
        Me.Controls.Add(Me.MonoFlat_Label1)
        Me.Controls.Add(Me.dateHasta)
        Me.Controls.Add(Me.dateDesde)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeListView1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TicketsPfecha"
        Me.Text = "TicketsPfecha"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TreeListView1 As WinControls.ListView.TreeListView
    Friend WithEvents ContainerColumnHeader1 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader2 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader3 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader4 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader5 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader6 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader7 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader8 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader10 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents ContainerColumnHeader9 As WinControls.ListView.ContainerColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboFiltro As ComboBox
    Friend WithEvents MonoFlat_Label2 As MonoFlat.MonoFlat_Label
    Friend WithEvents MonoFlat_Label1 As MonoFlat.MonoFlat_Label
    Friend WithEvents dateHasta As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents dateDesde As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundCajas As System.ComponentModel.BackgroundWorker
End Class
