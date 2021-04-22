<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mysql
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ServerTXT = New System.Windows.Forms.TextBox()
        Me.UsuarioTxt = New System.Windows.Forms.TextBox()
        Me.PswdTxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtfbeep1 = New System.Windows.Forms.TextBox()
        Me.txtfbeep2 = New System.Windows.Forms.TextBox()
        Me.txtfbeep3 = New System.Windows.Forms.TextBox()
        Me.txtDbeep1 = New System.Windows.Forms.TextBox()
        Me.txtDbeep2 = New System.Windows.Forms.TextBox()
        Me.txtDbeep3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ServerTXT
        '
        Me.ServerTXT.Location = New System.Drawing.Point(153, 77)
        Me.ServerTXT.Name = "ServerTXT"
        Me.ServerTXT.Size = New System.Drawing.Size(100, 20)
        Me.ServerTXT.TabIndex = 1
        '
        'UsuarioTxt
        '
        Me.UsuarioTxt.Location = New System.Drawing.Point(305, 77)
        Me.UsuarioTxt.Name = "UsuarioTxt"
        Me.UsuarioTxt.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTxt.TabIndex = 2
        '
        'PswdTxt
        '
        Me.PswdTxt.Location = New System.Drawing.Point(455, 77)
        Me.PswdTxt.Name = "PswdTxt"
        Me.PswdTxt.Size = New System.Drawing.Size(100, 20)
        Me.PswdTxt.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtfbeep1
        '
        Me.txtfbeep1.Location = New System.Drawing.Point(440, 150)
        Me.txtfbeep1.Name = "txtfbeep1"
        Me.txtfbeep1.Size = New System.Drawing.Size(100, 20)
        Me.txtfbeep1.TabIndex = 5
        '
        'txtfbeep2
        '
        Me.txtfbeep2.Location = New System.Drawing.Point(440, 182)
        Me.txtfbeep2.Name = "txtfbeep2"
        Me.txtfbeep2.Size = New System.Drawing.Size(100, 20)
        Me.txtfbeep2.TabIndex = 6
        '
        'txtfbeep3
        '
        Me.txtfbeep3.Location = New System.Drawing.Point(440, 221)
        Me.txtfbeep3.Name = "txtfbeep3"
        Me.txtfbeep3.Size = New System.Drawing.Size(100, 20)
        Me.txtfbeep3.TabIndex = 7
        '
        'txtDbeep1
        '
        Me.txtDbeep1.Location = New System.Drawing.Point(555, 150)
        Me.txtDbeep1.Name = "txtDbeep1"
        Me.txtDbeep1.Size = New System.Drawing.Size(100, 20)
        Me.txtDbeep1.TabIndex = 8
        '
        'txtDbeep2
        '
        Me.txtDbeep2.Location = New System.Drawing.Point(555, 182)
        Me.txtDbeep2.Name = "txtDbeep2"
        Me.txtDbeep2.Size = New System.Drawing.Size(100, 20)
        Me.txtDbeep2.TabIndex = 9
        '
        'txtDbeep3
        '
        Me.txtDbeep3.Location = New System.Drawing.Point(555, 221)
        Me.txtDbeep3.Name = "txtDbeep3"
        Me.txtDbeep3.Size = New System.Drawing.Size(100, 20)
        Me.txtDbeep3.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(250, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mysql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 338)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtDbeep3)
        Me.Controls.Add(Me.txtDbeep2)
        Me.Controls.Add(Me.txtDbeep1)
        Me.Controls.Add(Me.txtfbeep3)
        Me.Controls.Add(Me.txtfbeep2)
        Me.Controls.Add(Me.txtfbeep1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PswdTxt)
        Me.Controls.Add(Me.UsuarioTxt)
        Me.Controls.Add(Me.ServerTXT)
        Me.Controls.Add(Me.Button1)
        Me.Name = "mysql"
        Me.Text = "mysql"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ServerTXT As TextBox
    Friend WithEvents UsuarioTxt As TextBox
    Friend WithEvents PswdTxt As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtfbeep1 As TextBox
    Friend WithEvents txtfbeep2 As TextBox
    Friend WithEvents txtfbeep3 As TextBox
    Friend WithEvents txtDbeep1 As TextBox
    Friend WithEvents txtDbeep2 As TextBox
    Friend WithEvents txtDbeep3 As TextBox
    Friend WithEvents Button3 As Button
End Class
