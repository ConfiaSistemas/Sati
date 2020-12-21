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
        'mysql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 338)
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
End Class
