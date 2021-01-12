<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizadorUpdater
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblTiempoSistema = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProgreso = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblTamaño = New Telerik.WinControls.UI.RadLabel()
        Me.lblDescargado = New Telerik.WinControls.UI.RadLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblProgresoDescompresion = New Telerik.WinControls.UI.RadLabel()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.lblTotalArchivos = New Telerik.WinControls.UI.RadLabel()
        Me.lblDescompreso = New Telerik.WinControls.UI.RadLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundDescomprimir = New System.ComponentModel.BackgroundWorker()
        Me.TimerCuentaRegresiva = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.lblProgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTamaño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescargado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.lblProgresoDescompresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDescompreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(481, 24)
        Me.Panel3.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ConfiaAdmin.My.Resources.Resources.boton_de_quitar_cuadrado
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(454, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 24)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ConfiaAdmin.My.Resources.Resources.minimizar_pestana
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(424, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 24)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Actualizador Préstamos Confía"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(395, 39)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.ForeColor = System.Drawing.Color.White
        Me.lblTiempo.Location = New System.Drawing.Point(279, 52)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(16, 13)
        Me.lblTiempo.TabIndex = 23
        Me.lblTiempo.Text = "..."
        Me.lblTiempo.Visible = False
        '
        'lblTiempoSistema
        '
        Me.lblTiempoSistema.AutoSize = True
        Me.lblTiempoSistema.ForeColor = System.Drawing.Color.White
        Me.lblTiempoSistema.Location = New System.Drawing.Point(153, 52)
        Me.lblTiempoSistema.Name = "lblTiempoSistema"
        Me.lblTiempoSistema.Size = New System.Drawing.Size(125, 13)
        Me.lblTiempoSistema.TabIndex = 22
        Me.lblTiempoSistema.Text = "El equipo se apagará en "
        Me.lblTiempoSistema.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sistema:"
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.ForeColor = System.Drawing.Color.White
        Me.lblSistema.Location = New System.Drawing.Point(55, 29)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(16, 13)
        Me.lblSistema.TabIndex = 20
        Me.lblSistema.Text = "..."
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-1, 68)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(481, 287)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblProgreso)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.lblTamaño)
        Me.Panel1.Controls.Add(Me.lblDescargado)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 136)
        Me.Panel1.TabIndex = 7
        '
        'lblProgreso
        '
        Me.lblProgreso.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgreso.ForeColor = System.Drawing.Color.Gray
        Me.lblProgreso.Location = New System.Drawing.Point(153, 46)
        Me.lblProgreso.Name = "lblProgreso"
        '
        '
        '
        Me.lblProgreso.RootElement.ApplyShapeToControl = True
        Me.lblProgreso.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.lblProgreso.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.lblProgreso.RootElement.ClipDrawing = False
        Me.lblProgreso.RootElement.EnableBorderHighlight = True
        Me.lblProgreso.RootElement.EnableFocusBorder = True
        Me.lblProgreso.RootElement.EnableHighlight = True
        Me.lblProgreso.RootElement.Shape = Nothing
        Me.lblProgreso.Size = New System.Drawing.Size(58, 49)
        Me.lblProgreso.TabIndex = 6
        Me.lblProgreso.Text = "0%"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.Gray
        Me.RadLabel2.Location = New System.Drawing.Point(274, 7)
        Me.RadLabel2.Name = "RadLabel2"
        '
        '
        '
        Me.RadLabel2.RootElement.ApplyShapeToControl = True
        Me.RadLabel2.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.RadLabel2.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.RadLabel2.RootElement.ClipDrawing = False
        Me.RadLabel2.RootElement.EnableBorderHighlight = True
        Me.RadLabel2.RootElement.EnableFocusBorder = True
        Me.RadLabel2.RootElement.EnableHighlight = True
        Me.RadLabel2.RootElement.Shape = Nothing
        Me.RadLabel2.Size = New System.Drawing.Size(86, 33)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "Tamaño"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.Gray
        Me.RadLabel1.Location = New System.Drawing.Point(11, 3)
        Me.RadLabel1.Name = "RadLabel1"
        '
        '
        '
        Me.RadLabel1.RootElement.ApplyShapeToControl = True
        Me.RadLabel1.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.RadLabel1.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.RadLabel1.RootElement.ClipDrawing = False
        Me.RadLabel1.RootElement.EnableBorderHighlight = True
        Me.RadLabel1.RootElement.EnableFocusBorder = True
        Me.RadLabel1.RootElement.EnableHighlight = True
        Me.RadLabel1.RootElement.Shape = Nothing
        Me.RadLabel1.Size = New System.Drawing.Size(123, 33)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "Descargado"
        '
        'lblTamaño
        '
        Me.lblTamaño.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamaño.ForeColor = System.Drawing.Color.Gray
        Me.lblTamaño.Location = New System.Drawing.Point(275, 46)
        Me.lblTamaño.Name = "lblTamaño"
        Me.lblTamaño.Size = New System.Drawing.Size(24, 33)
        Me.lblTamaño.TabIndex = 4
        Me.lblTamaño.Text = "..."
        '
        'lblDescargado
        '
        Me.lblDescargado.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescargado.ForeColor = System.Drawing.Color.Gray
        Me.lblDescargado.Location = New System.Drawing.Point(14, 46)
        Me.lblDescargado.Name = "lblDescargado"
        '
        '
        '
        Me.lblDescargado.RootElement.ApplyShapeToControl = True
        Me.lblDescargado.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.lblDescargado.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.lblDescargado.RootElement.ClipDrawing = False
        Me.lblDescargado.RootElement.EnableBorderHighlight = True
        Me.lblDescargado.RootElement.EnableFocusBorder = True
        Me.lblDescargado.RootElement.EnableHighlight = True
        Me.lblDescargado.RootElement.Shape = Nothing
        Me.lblDescargado.Size = New System.Drawing.Size(24, 33)
        Me.lblDescargado.TabIndex = 3
        Me.lblDescargado.Text = "..."
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblProgresoDescompresion)
        Me.Panel2.Controls.Add(Me.lblArchivo)
        Me.Panel2.Controls.Add(Me.RadLabel4)
        Me.Panel2.Controls.Add(Me.RadLabel5)
        Me.Panel2.Controls.Add(Me.lblTotalArchivos)
        Me.Panel2.Controls.Add(Me.lblDescompreso)
        Me.Panel2.Location = New System.Drawing.Point(3, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 136)
        Me.Panel2.TabIndex = 8
        '
        'lblProgresoDescompresion
        '
        Me.lblProgresoDescompresion.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgresoDescompresion.ForeColor = System.Drawing.Color.Gray
        Me.lblProgresoDescompresion.Location = New System.Drawing.Point(153, 46)
        Me.lblProgresoDescompresion.Name = "lblProgresoDescompresion"
        '
        '
        '
        Me.lblProgresoDescompresion.RootElement.ApplyShapeToControl = True
        Me.lblProgresoDescompresion.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.lblProgresoDescompresion.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.lblProgresoDescompresion.RootElement.ClipDrawing = False
        Me.lblProgresoDescompresion.RootElement.EnableBorderHighlight = True
        Me.lblProgresoDescompresion.RootElement.EnableFocusBorder = True
        Me.lblProgresoDescompresion.RootElement.EnableHighlight = True
        Me.lblProgresoDescompresion.RootElement.Shape = Nothing
        Me.lblProgresoDescompresion.Size = New System.Drawing.Size(58, 49)
        Me.lblProgresoDescompresion.TabIndex = 11
        Me.lblProgresoDescompresion.Text = "0%"
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.BackColor = System.Drawing.Color.Transparent
        Me.lblArchivo.ForeColor = System.Drawing.Color.Gray
        Me.lblArchivo.Location = New System.Drawing.Point(11, 110)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(16, 13)
        Me.lblArchivo.TabIndex = 5
        Me.lblArchivo.Text = "..."
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.ForeColor = System.Drawing.Color.Gray
        Me.RadLabel4.Location = New System.Drawing.Point(274, 7)
        Me.RadLabel4.Name = "RadLabel4"
        '
        '
        '
        Me.RadLabel4.RootElement.ApplyShapeToControl = True
        Me.RadLabel4.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.RadLabel4.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.RadLabel4.RootElement.ClipDrawing = False
        Me.RadLabel4.RootElement.EnableBorderHighlight = True
        Me.RadLabel4.RootElement.EnableFocusBorder = True
        Me.RadLabel4.RootElement.EnableHighlight = True
        Me.RadLabel4.RootElement.Shape = Nothing
        Me.RadLabel4.Size = New System.Drawing.Size(144, 33)
        Me.RadLabel4.TabIndex = 10
        Me.RadLabel4.Text = "Total Archivos"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.ForeColor = System.Drawing.Color.Gray
        Me.RadLabel5.Location = New System.Drawing.Point(11, 3)
        Me.RadLabel5.Name = "RadLabel5"
        '
        '
        '
        Me.RadLabel5.RootElement.ApplyShapeToControl = True
        Me.RadLabel5.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.RadLabel5.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.RadLabel5.RootElement.ClipDrawing = False
        Me.RadLabel5.RootElement.EnableBorderHighlight = True
        Me.RadLabel5.RootElement.EnableFocusBorder = True
        Me.RadLabel5.RootElement.EnableHighlight = True
        Me.RadLabel5.RootElement.Shape = Nothing
        Me.RadLabel5.Size = New System.Drawing.Size(257, 33)
        Me.RadLabel5.TabIndex = 8
        Me.RadLabel5.Text = "Archivos Descomprimidos"
        '
        'lblTotalArchivos
        '
        Me.lblTotalArchivos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalArchivos.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalArchivos.Location = New System.Drawing.Point(275, 46)
        Me.lblTotalArchivos.Name = "lblTotalArchivos"
        Me.lblTotalArchivos.Size = New System.Drawing.Size(24, 33)
        Me.lblTotalArchivos.TabIndex = 9
        Me.lblTotalArchivos.Text = "..."
        '
        'lblDescompreso
        '
        Me.lblDescompreso.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescompreso.ForeColor = System.Drawing.Color.Gray
        Me.lblDescompreso.Location = New System.Drawing.Point(14, 46)
        Me.lblDescompreso.Name = "lblDescompreso"
        '
        '
        '
        Me.lblDescompreso.RootElement.ApplyShapeToControl = True
        Me.lblDescompreso.RootElement.BorderHighlightColor = System.Drawing.Color.Black
        Me.lblDescompreso.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release
        Me.lblDescompreso.RootElement.ClipDrawing = False
        Me.lblDescompreso.RootElement.EnableBorderHighlight = True
        Me.lblDescompreso.RootElement.EnableFocusBorder = True
        Me.lblDescompreso.RootElement.EnableHighlight = True
        Me.lblDescompreso.RootElement.Shape = Nothing
        Me.lblDescompreso.Size = New System.Drawing.Size(24, 33)
        Me.lblDescompreso.TabIndex = 7
        Me.lblDescompreso.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Estado:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(55, 52)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(16, 13)
        Me.lblEstado.TabIndex = 17
        Me.lblEstado.Text = "..."
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        '
        'BackgroundDescomprimir
        '
        '
        'ActualizadorUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 384)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblTiempoSistema)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSistema)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActualizadorUpdater"
        Me.Text = "ActualizadorUpdater"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lblProgreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTamaño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescargado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.lblProgresoDescompresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDescompreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblTiempoSistema As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSistema As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblProgreso As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblTamaño As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDescargado As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProgresoDescompresion As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblArchivo As Label
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblTotalArchivos As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDescompreso As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundDescomprimir As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerCuentaRegresiva As Timer
End Class
