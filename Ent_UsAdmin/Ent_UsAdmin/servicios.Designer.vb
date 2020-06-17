<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class servicios
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblmodificar = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.lbleliminar = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.MonoFlat_Label1 = New ConfiaAdmin.MonoFlat.MonoFlat_Label()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(535, 289)
        Me.DataGridView1.TabIndex = 1
        '
        'lblmodificar
        '
        Me.lblmodificar.AutoEllipsis = True
        Me.lblmodificar.AutoSize = True
        Me.lblmodificar.BackColor = System.Drawing.Color.Transparent
        Me.lblmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmodificar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblmodificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblmodificar.Image = Global.ConfiaAdmin.My.Resources.Resources.modificar
        Me.lblmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblmodificar.Location = New System.Drawing.Point(102, 34)
        Me.lblmodificar.Name = "lblmodificar"
        Me.lblmodificar.Size = New System.Drawing.Size(73, 15)
        Me.lblmodificar.TabIndex = 4
        Me.lblmodificar.Text = "     Modificar"
        '
        'lbleliminar
        '
        Me.lbleliminar.AutoEllipsis = True
        Me.lbleliminar.AutoSize = True
        Me.lbleliminar.BackColor = System.Drawing.Color.Transparent
        Me.lbleliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbleliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbleliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbleliminar.Image = Global.ConfiaAdmin.My.Resources.Resources.eliminar
        Me.lbleliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbleliminar.Location = New System.Drawing.Point(187, 34)
        Me.lbleliminar.Name = "lbleliminar"
        Me.lbleliminar.Size = New System.Drawing.Size(68, 15)
        Me.lbleliminar.TabIndex = 3
        Me.lbleliminar.Text = "      Eliminar"
        '
        'MonoFlat_Label1
        '
        Me.MonoFlat_Label1.AutoEllipsis = True
        Me.MonoFlat_Label1.AutoSize = True
        Me.MonoFlat_Label1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MonoFlat_Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MonoFlat_Label1.Image = Global.ConfiaAdmin.My.Resources.Resources.mas2
        Me.MonoFlat_Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MonoFlat_Label1.Location = New System.Drawing.Point(22, 34)
        Me.MonoFlat_Label1.Name = "MonoFlat_Label1"
        Me.MonoFlat_Label1.Size = New System.Drawing.Size(64, 15)
        Me.MonoFlat_Label1.TabIndex = 2
        Me.MonoFlat_Label1.Text = "     Agregar"
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.Red
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(-2, -2)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(71, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 0
        Me.MonoFlat_HeaderLabel1.Text = "Servicios"
        '
        'servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 363)
        Me.Controls.Add(Me.lblmodificar)
        Me.Controls.Add(Me.lbleliminar)
        Me.Controls.Add(Me.MonoFlat_Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "servicios"
        Me.Text = "servicios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonoFlat_HeaderLabel1 As ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MonoFlat_Label1 As ConfiaAdmin.MonoFlat.MonoFlat_Label
    Friend WithEvents lbleliminar As ConfiaAdmin.MonoFlat.MonoFlat_Label
    Friend WithEvents lblmodificar As ConfiaAdmin.MonoFlat.MonoFlat_Label
End Class
