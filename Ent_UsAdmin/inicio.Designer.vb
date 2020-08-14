<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.Panelsecundario = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panelsecundario.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelsecundario
        '
        Me.Panelsecundario.BackColor = System.Drawing.Color.Transparent
        Me.Panelsecundario.Controls.Add(Me.BunifuFlatButton7)
        Me.Panelsecundario.Location = New System.Drawing.Point(12, 12)
        Me.Panelsecundario.Name = "Panelsecundario"
        Me.Panelsecundario.Size = New System.Drawing.Size(200, 100)
        Me.Panelsecundario.TabIndex = 4
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Grupos"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = Global.ConfiaAdmin.My.Resources.Resources.usuarios
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 90.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(3, 3)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Empty
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(111, 48)
        Me.BunifuFlatButton7.TabIndex = 6
        Me.BunifuFlatButton7.Text = "Grupos"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ConfiaAdmin.My.Resources.Resources.pantalla_de_bienvenida
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(646, 446)
        Me.Controls.Add(Me.Panelsecundario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "inicio"
        Me.Text = "inicio"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Panelsecundario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelsecundario As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
End Class
