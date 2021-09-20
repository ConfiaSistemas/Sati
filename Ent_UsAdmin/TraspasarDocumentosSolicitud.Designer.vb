<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraspasarDocumentosSolicitud
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnOrigen = New System.Windows.Forms.Button()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.btnDestino = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSQL = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.dtDatos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.IdOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnTraspasar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundTraspaso = New System.ComponentModel.BackgroundWorker()
        Me.RadioSolicitud = New System.Windows.Forms.RadioButton()
        Me.RadioCredito = New System.Windows.Forms.RadioButton()
        CType(Me.dtDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrigen
        '
        Me.btnOrigen.Location = New System.Drawing.Point(23, 21)
        Me.btnOrigen.Name = "btnOrigen"
        Me.btnOrigen.Size = New System.Drawing.Size(75, 40)
        Me.btnOrigen.TabIndex = 0
        Me.btnOrigen.Text = "Seleccionar Origen"
        Me.btnOrigen.UseVisualStyleBackColor = True
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Location = New System.Drawing.Point(20, 78)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(39, 13)
        Me.lblOrigen.TabIndex = 1
        Me.lblOrigen.Text = "Label1"
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Location = New System.Drawing.Point(176, 78)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(39, 13)
        Me.lblDestino.TabIndex = 3
        Me.lblDestino.Text = "Label2"
        '
        'btnDestino
        '
        Me.btnDestino.Location = New System.Drawing.Point(179, 21)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Size = New System.Drawing.Size(75, 40)
        Me.btnDestino.TabIndex = 2
        Me.btnDestino.Text = "Seleccionar Destino"
        Me.btnDestino.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Consulta SQL"
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(12, 130)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(729, 160)
        Me.txtSQL.TabIndex = 4
        Me.txtSQL.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "id's Datos Solicitud"
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(666, 84)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(75, 40)
        Me.btnConsulta.TabIndex = 7
        Me.btnConsulta.Text = "Ejecutar Consulta"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'dtDatos
        '
        Me.dtDatos.AllowUserToAddRows = False
        Me.dtDatos.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtDatos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdOrigen, Me.idDestino})
        Me.dtDatos.DoubleBuffered = True
        Me.dtDatos.EnableHeadersVisualStyles = False
        Me.dtDatos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtDatos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtDatos.Location = New System.Drawing.Point(12, 365)
        Me.dtDatos.Name = "dtDatos"
        Me.dtDatos.ReadOnly = True
        Me.dtDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtDatos.RowHeadersVisible = False
        Me.dtDatos.Size = New System.Drawing.Size(488, 262)
        Me.dtDatos.TabIndex = 8
        '
        'IdOrigen
        '
        Me.IdOrigen.HeaderText = "IdOrigen"
        Me.IdOrigen.Name = "IdOrigen"
        Me.IdOrigen.ReadOnly = True
        Me.IdOrigen.Width = 82
        '
        'idDestino
        '
        Me.idDestino.HeaderText = "idDestino"
        Me.idDestino.Name = "idDestino"
        Me.idDestino.ReadOnly = True
        Me.idDestino.Width = 87
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 336)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ruta Excel"
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(457, 329)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(54, 26)
        Me.btnCargar.TabIndex = 11
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnTraspasar
        '
        Me.btnTraspasar.Location = New System.Drawing.Point(374, 666)
        Me.btnTraspasar.Name = "btnTraspasar"
        Me.btnTraspasar.Size = New System.Drawing.Size(77, 26)
        Me.btnTraspasar.TabIndex = 12
        Me.btnTraspasar.Text = "Traspasar"
        Me.btnTraspasar.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BackgroundTraspaso
        '
        '
        'RadioSolicitud
        '
        Me.RadioSolicitud.AutoSize = True
        Me.RadioSolicitud.Location = New System.Drawing.Point(457, 43)
        Me.RadioSolicitud.Name = "RadioSolicitud"
        Me.RadioSolicitud.Size = New System.Drawing.Size(65, 17)
        Me.RadioSolicitud.TabIndex = 13
        Me.RadioSolicitud.TabStop = True
        Me.RadioSolicitud.Text = "Solicitud"
        Me.RadioSolicitud.UseVisualStyleBackColor = True
        '
        'RadioCredito
        '
        Me.RadioCredito.AutoSize = True
        Me.RadioCredito.Location = New System.Drawing.Point(553, 44)
        Me.RadioCredito.Name = "RadioCredito"
        Me.RadioCredito.Size = New System.Drawing.Size(58, 17)
        Me.RadioCredito.TabIndex = 14
        Me.RadioCredito.TabStop = True
        Me.RadioCredito.Text = "Crédito"
        Me.RadioCredito.UseVisualStyleBackColor = True
        '
        'TraspasarDocumentosSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 715)
        Me.Controls.Add(Me.RadioCredito)
        Me.Controls.Add(Me.RadioSolicitud)
        Me.Controls.Add(Me.btnTraspasar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtDatos)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.btnDestino)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.btnOrigen)
        Me.Name = "TraspasarDocumentosSolicitud"
        Me.Text = "TraspasarDocumentosSolicitud"
        CType(Me.dtDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOrigen As Button
    Friend WithEvents lblOrigen As Label
    Friend WithEvents lblDestino As Label
    Friend WithEvents btnDestino As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSQL As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConsulta As Button
    Friend WithEvents dtDatos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents IdOrigen As DataGridViewTextBoxColumn
    Friend WithEvents idDestino As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnTraspasar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundTraspaso As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadioSolicitud As RadioButton
    Friend WithEvents RadioCredito As RadioButton
End Class
