<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PermisosGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PermisosGrupo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FlowLegal = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FlowCajas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowEmpleados = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowTiposCredito = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowAccesoSati = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FlowReportes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FlowCreditos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowSolicitudes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowTiposDeDocumentos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowDocumentos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowClientes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowCatalogos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowGrupos = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowUsuarios = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FlowSac = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.btn_agregar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BackgroundPermisos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundAplicarPermisos = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 44)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(726, 609)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.FlowLegal)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.FlowCajas)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.FlowEmpleados)
        Me.TabPage2.Controls.Add(Me.FlowTiposCredito)
        Me.TabPage2.Controls.Add(Me.FlowAccesoSati)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.FlowReportes)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.FlowCreditos)
        Me.TabPage2.Controls.Add(Me.FlowSolicitudes)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.FlowTiposDeDocumentos)
        Me.TabPage2.Controls.Add(Me.FlowDocumentos)
        Me.TabPage2.Controls.Add(Me.FlowClientes)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.FlowCatalogos)
        Me.TabPage2.Controls.Add(Me.FlowGrupos)
        Me.TabPage2.Controls.Add(Me.FlowUsuarios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(718, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SATI"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(12, 450)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Legal"
        '
        'FlowLegal
        '
        Me.FlowLegal.BackColor = System.Drawing.Color.White
        Me.FlowLegal.Location = New System.Drawing.Point(12, 466)
        Me.FlowLegal.Name = "FlowLegal"
        Me.FlowLegal.Size = New System.Drawing.Size(102, 100)
        Me.FlowLegal.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(610, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Cajas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(610, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Empleados"
        '
        'FlowCajas
        '
        Me.FlowCajas.BackColor = System.Drawing.Color.White
        Me.FlowCajas.Location = New System.Drawing.Point(610, 328)
        Me.FlowCajas.Name = "FlowCajas"
        Me.FlowCajas.Size = New System.Drawing.Size(102, 100)
        Me.FlowCajas.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(607, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Tipos de Crédito"
        '
        'FlowEmpleados
        '
        Me.FlowEmpleados.BackColor = System.Drawing.Color.White
        Me.FlowEmpleados.Location = New System.Drawing.Point(610, 190)
        Me.FlowEmpleados.Name = "FlowEmpleados"
        Me.FlowEmpleados.Size = New System.Drawing.Size(102, 100)
        Me.FlowEmpleados.TabIndex = 29
        '
        'FlowTiposCredito
        '
        Me.FlowTiposCredito.BackColor = System.Drawing.Color.White
        Me.FlowTiposCredito.Location = New System.Drawing.Point(610, 58)
        Me.FlowTiposCredito.Name = "FlowTiposCredito"
        Me.FlowTiposCredito.Size = New System.Drawing.Size(102, 100)
        Me.FlowTiposCredito.TabIndex = 27
        '
        'FlowAccesoSati
        '
        Me.FlowAccesoSati.Location = New System.Drawing.Point(12, 6)
        Me.FlowAccesoSati.Name = "FlowAccesoSati"
        Me.FlowAccesoSati.Size = New System.Drawing.Size(200, 33)
        Me.FlowAccesoSati.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(423, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Reportes"
        '
        'FlowReportes
        '
        Me.FlowReportes.BackColor = System.Drawing.Color.White
        Me.FlowReportes.Location = New System.Drawing.Point(426, 328)
        Me.FlowReportes.Name = "FlowReportes"
        Me.FlowReportes.Size = New System.Drawing.Size(102, 100)
        Me.FlowReportes.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(214, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Creditos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Solicitudes"
        '
        'FlowCreditos
        '
        Me.FlowCreditos.AutoScroll = True
        Me.FlowCreditos.BackColor = System.Drawing.Color.White
        Me.FlowCreditos.Location = New System.Drawing.Point(217, 328)
        Me.FlowCreditos.Name = "FlowCreditos"
        Me.FlowCreditos.Size = New System.Drawing.Size(97, 100)
        Me.FlowCreditos.TabIndex = 20
        '
        'FlowSolicitudes
        '
        Me.FlowSolicitudes.AutoScroll = True
        Me.FlowSolicitudes.BackColor = System.Drawing.Color.White
        Me.FlowSolicitudes.Location = New System.Drawing.Point(9, 328)
        Me.FlowSolicitudes.Name = "FlowSolicitudes"
        Me.FlowSolicitudes.Size = New System.Drawing.Size(99, 100)
        Me.FlowSolicitudes.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(422, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tipos de documentos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(214, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Documentos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Clientes"
        '
        'FlowTiposDeDocumentos
        '
        Me.FlowTiposDeDocumentos.BackColor = System.Drawing.Color.White
        Me.FlowTiposDeDocumentos.Location = New System.Drawing.Point(425, 190)
        Me.FlowTiposDeDocumentos.Name = "FlowTiposDeDocumentos"
        Me.FlowTiposDeDocumentos.Size = New System.Drawing.Size(102, 100)
        Me.FlowTiposDeDocumentos.TabIndex = 15
        '
        'FlowDocumentos
        '
        Me.FlowDocumentos.BackColor = System.Drawing.Color.White
        Me.FlowDocumentos.Location = New System.Drawing.Point(217, 190)
        Me.FlowDocumentos.Name = "FlowDocumentos"
        Me.FlowDocumentos.Size = New System.Drawing.Size(102, 100)
        Me.FlowDocumentos.TabIndex = 14
        '
        'FlowClientes
        '
        Me.FlowClientes.BackColor = System.Drawing.Color.White
        Me.FlowClientes.Location = New System.Drawing.Point(9, 190)
        Me.FlowClientes.Name = "FlowClientes"
        Me.FlowClientes.Size = New System.Drawing.Size(102, 100)
        Me.FlowClientes.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(419, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Catalogos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(211, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Grupos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Usuarios"
        '
        'FlowCatalogos
        '
        Me.FlowCatalogos.BackColor = System.Drawing.Color.White
        Me.FlowCatalogos.Location = New System.Drawing.Point(422, 58)
        Me.FlowCatalogos.Name = "FlowCatalogos"
        Me.FlowCatalogos.Size = New System.Drawing.Size(102, 100)
        Me.FlowCatalogos.TabIndex = 2
        '
        'FlowGrupos
        '
        Me.FlowGrupos.BackColor = System.Drawing.Color.White
        Me.FlowGrupos.Location = New System.Drawing.Point(214, 58)
        Me.FlowGrupos.Name = "FlowGrupos"
        Me.FlowGrupos.Size = New System.Drawing.Size(102, 100)
        Me.FlowGrupos.TabIndex = 1
        '
        'FlowUsuarios
        '
        Me.FlowUsuarios.BackColor = System.Drawing.Color.White
        Me.FlowUsuarios.Location = New System.Drawing.Point(6, 58)
        Me.FlowUsuarios.Name = "FlowUsuarios"
        Me.FlowUsuarios.Size = New System.Drawing.Size(102, 100)
        Me.FlowUsuarios.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.FlowSac)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(718, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "SAC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Permisos"
        '
        'FlowSac
        '
        Me.FlowSac.BackColor = System.Drawing.Color.White
        Me.FlowSac.Location = New System.Drawing.Point(6, 40)
        Me.FlowSac.Name = "FlowSac"
        Me.FlowSac.Size = New System.Drawing.Size(102, 383)
        Me.FlowSac.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 36)
        Me.Panel1.TabIndex = 6
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(140, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Permisos de grupo"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(681, 3)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'btn_agregar
        '
        Me.btn_agregar.ActiveBorderThickness = 1
        Me.btn_agregar.ActiveCornerRadius = 20
        Me.btn_agregar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_agregar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btn_agregar.BackgroundImage = CType(resources.GetObject("btn_agregar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agregar.ButtonText = "Aplicar"
        Me.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.IdleBorderThickness = 1
        Me.btn_agregar.IdleCornerRadius = 20
        Me.btn_agregar.IdleFillColor = System.Drawing.Color.White
        Me.btn_agregar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.Location = New System.Drawing.Point(282, 661)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(207, 38)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundPermisos
        '
        '
        'BackgroundAplicarPermisos
        '
        '
        'PermisosGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 724)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PermisosGrupo"
        Me.Text = "PermisosGrupo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents FlowCatalogos As FlowLayoutPanel
    Friend WithEvents FlowGrupos As FlowLayoutPanel
    Friend WithEvents FlowUsuarios As FlowLayoutPanel
    Friend WithEvents btn_agregar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label7 As Label
    Friend WithEvents FlowReportes As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FlowCreditos As FlowLayoutPanel
    Friend WithEvents FlowSolicitudes As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FlowTiposDeDocumentos As FlowLayoutPanel
    Friend WithEvents FlowDocumentos As FlowLayoutPanel
    Friend WithEvents FlowClientes As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundPermisos As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label10 As Label
    Friend WithEvents FlowSac As FlowLayoutPanel
    Friend WithEvents FlowAccesoSati As FlowLayoutPanel
    Friend WithEvents BackgroundAplicarPermisos As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents FlowCajas As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents FlowEmpleados As FlowLayoutPanel
    Friend WithEvents FlowTiposCredito As FlowLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents FlowLegal As FlowLayoutPanel
End Class
