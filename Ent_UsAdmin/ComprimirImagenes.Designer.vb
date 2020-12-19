<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprimirImagenes
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioSolicitud = New System.Windows.Forms.RadioButton()
        Me.RadioCredito = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'RadioSolicitud
        '
        Me.RadioSolicitud.AutoSize = True
        Me.RadioSolicitud.Location = New System.Drawing.Point(65, 64)
        Me.RadioSolicitud.Name = "RadioSolicitud"
        Me.RadioSolicitud.Size = New System.Drawing.Size(128, 17)
        Me.RadioSolicitud.TabIndex = 2
        Me.RadioSolicitud.TabStop = True
        Me.RadioSolicitud.Text = "Documentos Solicitud"
        Me.RadioSolicitud.UseVisualStyleBackColor = True
        '
        'RadioCredito
        '
        Me.RadioCredito.AutoSize = True
        Me.RadioCredito.Location = New System.Drawing.Point(220, 64)
        Me.RadioCredito.Name = "RadioCredito"
        Me.RadioCredito.Size = New System.Drawing.Size(121, 17)
        Me.RadioCredito.TabIndex = 3
        Me.RadioCredito.TabStop = True
        Me.RadioCredito.Text = "Documentos Crédito"
        Me.RadioCredito.UseVisualStyleBackColor = True
        '
        'ComprimirImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 333)
        Me.Controls.Add(Me.RadioCredito)
        Me.Controls.Add(Me.RadioSolicitud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ComprimirImagenes"
        Me.Text = "ComprimirImagenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioSolicitud As RadioButton
    Friend WithEvents RadioCredito As RadioButton
End Class
