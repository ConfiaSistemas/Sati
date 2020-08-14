<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirConvenio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImprimirConvenio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.btn_convenio = New Zeroit.Framework.Metro.ZeroitMetroButton()
        Me.btn_calendario = New Zeroit.Framework.Metro.ZeroitMetroButton()
        Me.ClickAnimator1 = New Zeroit.Framework.Metro.ClickAnimator()
        Me.ClickAnimator2 = New Zeroit.Framework.Metro.ClickAnimator()
        Me.BackgroundConvenio = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundImprimirCalendario = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundImprimirConvenio = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 36)
        Me.Panel1.TabIndex = 1
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(12, 3)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(140, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 2
        Me.MonoFlat_HeaderLabel1.Text = "Imprimir Convenio"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(390, 7)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 1
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'btn_convenio
        '
        Me.btn_convenio.BackColor = System.Drawing.Color.Transparent
        Me.btn_convenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_convenio.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_convenio.DefaultColor = System.Drawing.Color.White
        Me.btn_convenio.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_convenio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_convenio.HoverColor = System.Drawing.Color.White
        Me.btn_convenio.IsRound = True
        Me.btn_convenio.Location = New System.Drawing.Point(80, 81)
        Me.btn_convenio.Name = "btn_convenio"
        Me.btn_convenio.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_convenio.RoundingArc = 106
        Me.btn_convenio.Size = New System.Drawing.Size(106, 106)
        Me.btn_convenio.TabIndex = 2
        Me.btn_convenio.Text = "Convenio"
        '
        'btn_calendario
        '
        Me.btn_calendario.BackColor = System.Drawing.Color.Transparent
        Me.btn_calendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_calendario.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btn_calendario.DefaultColor = System.Drawing.Color.White
        Me.btn_calendario.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_calendario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_calendario.HoverColor = System.Drawing.Color.White
        Me.btn_calendario.IsRound = True
        Me.btn_calendario.Location = New System.Drawing.Point(256, 81)
        Me.btn_calendario.Name = "btn_calendario"
        Me.btn_calendario.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_calendario.RoundingArc = 106
        Me.btn_calendario.Size = New System.Drawing.Size(106, 106)
        Me.btn_calendario.TabIndex = 3
        Me.btn_calendario.Text = "Calendario"
        '
        'ClickAnimator1
        '
        Me.ClickAnimator1.ClickControl = Me.btn_convenio
        Me.ClickAnimator1.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Circle
        Me.ClickAnimator1.Speed = 11
        '
        'ClickAnimator2
        '
        Me.ClickAnimator2.ClickControl = Me.btn_calendario
        Me.ClickAnimator2.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Rectangle
        Me.ClickAnimator2.Speed = 11
        '
        'BackgroundConvenio
        '
        '
        'BackgroundImprimirCalendario
        '
        '
        'BackgroundImprimirConvenio
        '
        '
        'ImprimirConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(467, 231)
        Me.Controls.Add(Me.btn_calendario)
        Me.Controls.Add(Me.btn_convenio)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImprimirConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImprimirConvenio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents btn_convenio As Zeroit.Framework.Metro.ZeroitMetroButton
    Friend WithEvents btn_calendario As Zeroit.Framework.Metro.ZeroitMetroButton
    Friend WithEvents ClickAnimator1 As Zeroit.Framework.Metro.ClickAnimator
    Friend WithEvents ClickAnimator2 As Zeroit.Framework.Metro.ClickAnimator
    Friend WithEvents BackgroundConvenio As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundImprimirCalendario As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundImprimirConvenio As System.ComponentModel.BackgroundWorker
End Class
