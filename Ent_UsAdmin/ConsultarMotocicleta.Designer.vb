<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarMotocicleta

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonoFlat_HeaderLabel1 = New ConfiaAdmin.MonoFlat.MonoFlat_HeaderLabel()
        Me.EvolveControlBox1 = New ConfiaAdmin.EvolveControlBox()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.txtValor = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.txtAño = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoFactura = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.txtMarca = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModelo = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCilindraje = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.txtNoPedimento = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtColor = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.txtNoMotor = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNCI = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.txtSerie = New VB.Windows.Forms.ControlExt.TextBoxEx()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dtdatosDocumentos = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BackgroundMotocicleta = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDocumentosMotocicleta = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundActualizarDatos = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAdv2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonoFlat_HeaderLabel1)
        Me.Panel1.Controls.Add(Me.EvolveControlBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 40)
        Me.Panel1.TabIndex = 3
        '
        'MonoFlat_HeaderLabel1
        '
        Me.MonoFlat_HeaderLabel1.AutoSize = True
        Me.MonoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_HeaderLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MonoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonoFlat_HeaderLabel1.Location = New System.Drawing.Point(3, 4)
        Me.MonoFlat_HeaderLabel1.Name = "MonoFlat_HeaderLabel1"
        Me.MonoFlat_HeaderLabel1.Size = New System.Drawing.Size(167, 20)
        Me.MonoFlat_HeaderLabel1.TabIndex = 1
        Me.MonoFlat_HeaderLabel1.Text = "Motocicleta Capturada"
        '
        'EvolveControlBox1
        '
        Me.EvolveControlBox1.Colors = New ConfiaAdmin.Bloom(-1) {}
        Me.EvolveControlBox1.Customization = ""
        Me.EvolveControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.EvolveControlBox1.Image = Nothing
        Me.EvolveControlBox1.Location = New System.Drawing.Point(666, 4)
        Me.EvolveControlBox1.MaxButton = False
        Me.EvolveControlBox1.MinButton = True
        Me.EvolveControlBox1.Name = "EvolveControlBox1"
        Me.EvolveControlBox1.NoRounding = False
        Me.EvolveControlBox1.Size = New System.Drawing.Size(66, 16)
        Me.EvolveControlBox1.TabIndex = 0
        Me.EvolveControlBox1.Text = "EvolveControlBox1"
        Me.EvolveControlBox1.Transparent = False
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(735, 419)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv1)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.Location = New System.Drawing.Point(1, 47)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.Size = New System.Drawing.Size(735, 419)
        Me.TabControlAdv1.TabIndex = 31
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.Controls.Add(Me.txtValor)
        Me.TabPageAdv1.Controls.Add(Me.txtAño)
        Me.TabPageAdv1.Controls.Add(Me.Label1)
        Me.TabPageAdv1.Controls.Add(Me.txtNoFactura)
        Me.TabPageAdv1.Controls.Add(Me.txtMarca)
        Me.TabPageAdv1.Controls.Add(Me.Label11)
        Me.TabPageAdv1.Controls.Add(Me.txtModelo)
        Me.TabPageAdv1.Controls.Add(Me.Label12)
        Me.TabPageAdv1.Controls.Add(Me.Label13)
        Me.TabPageAdv1.Controls.Add(Me.Label14)
        Me.TabPageAdv1.Controls.Add(Me.txtCilindraje)
        Me.TabPageAdv1.Controls.Add(Me.txtNoPedimento)
        Me.TabPageAdv1.Controls.Add(Me.Label15)
        Me.TabPageAdv1.Controls.Add(Me.Label16)
        Me.TabPageAdv1.Controls.Add(Me.txtColor)
        Me.TabPageAdv1.Controls.Add(Me.txtNoMotor)
        Me.TabPageAdv1.Controls.Add(Me.Label17)
        Me.TabPageAdv1.Controls.Add(Me.Label18)
        Me.TabPageAdv1.Controls.Add(Me.Label19)
        Me.TabPageAdv1.Controls.Add(Me.txtNCI)
        Me.TabPageAdv1.Controls.Add(Me.txtSerie)
        Me.TabPageAdv1.Controls.Add(Me.Label20)
        Me.TabPageAdv1.Image = Nothing
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv1.Location = New System.Drawing.Point(1, 25)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = False
        Me.TabPageAdv1.Size = New System.Drawing.Size(732, 392)
        Me.TabPageAdv1.TabForeColor = System.Drawing.SystemColors.Control
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = "Datos"
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'txtValor
        '
        Me.txtValor.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(238, 253)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 54
        Me.txtValor.Text = "$0.00"
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtAño.BorderColor = System.Drawing.Color.Gray
        Me.txtAño.Enabled = False
        Me.txtAño.ForeColor = System.Drawing.Color.White
        Me.txtAño.Location = New System.Drawing.Point(238, 113)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(178, 20)
        Me.txtAño.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Número de Factura"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtNoFactura.BorderColor = System.Drawing.Color.Gray
        Me.txtNoFactura.Enabled = False
        Me.txtNoFactura.ForeColor = System.Drawing.Color.White
        Me.txtNoFactura.Location = New System.Drawing.Point(10, 253)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(178, 20)
        Me.txtNoFactura.TabIndex = 51
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtMarca.BorderColor = System.Drawing.Color.Gray
        Me.txtMarca.Enabled = False
        Me.txtMarca.ForeColor = System.Drawing.Color.White
        Me.txtMarca.Location = New System.Drawing.Point(10, 46)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(178, 20)
        Me.txtMarca.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Marca"
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtModelo.BorderColor = System.Drawing.Color.Gray
        Me.txtModelo.Enabled = False
        Me.txtModelo.ForeColor = System.Drawing.Color.White
        Me.txtModelo.Location = New System.Drawing.Point(238, 46)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(178, 20)
        Me.txtModelo.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(235, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Valor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(235, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Modelo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(461, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Número de pedimento"
        '
        'txtCilindraje
        '
        Me.txtCilindraje.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtCilindraje.BorderColor = System.Drawing.Color.Gray
        Me.txtCilindraje.Enabled = False
        Me.txtCilindraje.ForeColor = System.Drawing.Color.White
        Me.txtCilindraje.Location = New System.Drawing.Point(464, 46)
        Me.txtCilindraje.Name = "txtCilindraje"
        Me.txtCilindraje.Size = New System.Drawing.Size(178, 20)
        Me.txtCilindraje.TabIndex = 35
        '
        'txtNoPedimento
        '
        Me.txtNoPedimento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtNoPedimento.BorderColor = System.Drawing.Color.Gray
        Me.txtNoPedimento.Enabled = False
        Me.txtNoPedimento.ForeColor = System.Drawing.Color.White
        Me.txtNoPedimento.Location = New System.Drawing.Point(464, 181)
        Me.txtNoPedimento.Name = "txtNoPedimento"
        Me.txtNoPedimento.Size = New System.Drawing.Size(178, 20)
        Me.txtNoPedimento.TabIndex = 46
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(461, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Cilindraje"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(235, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Número de motor"
        '
        'txtColor
        '
        Me.txtColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtColor.BorderColor = System.Drawing.Color.Gray
        Me.txtColor.Enabled = False
        Me.txtColor.ForeColor = System.Drawing.Color.White
        Me.txtColor.Location = New System.Drawing.Point(10, 113)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(178, 20)
        Me.txtColor.TabIndex = 37
        '
        'txtNoMotor
        '
        Me.txtNoMotor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtNoMotor.BorderColor = System.Drawing.Color.Gray
        Me.txtNoMotor.Enabled = False
        Me.txtNoMotor.ForeColor = System.Drawing.Color.White
        Me.txtNoMotor.Location = New System.Drawing.Point(238, 181)
        Me.txtNoMotor.Name = "txtNoMotor"
        Me.txtNoMotor.Size = New System.Drawing.Size(178, 20)
        Me.txtNoMotor.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(7, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Color"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(7, 153)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "NCI (REPUVE)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(235, 85)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Año"
        '
        'txtNCI
        '
        Me.txtNCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtNCI.BorderColor = System.Drawing.Color.Gray
        Me.txtNCI.Enabled = False
        Me.txtNCI.ForeColor = System.Drawing.Color.White
        Me.txtNCI.Location = New System.Drawing.Point(10, 181)
        Me.txtNCI.Name = "txtNCI"
        Me.txtNCI.Size = New System.Drawing.Size(178, 20)
        Me.txtNCI.TabIndex = 42
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.txtSerie.BorderColor = System.Drawing.Color.Gray
        Me.txtSerie.Enabled = False
        Me.txtSerie.ForeColor = System.Drawing.Color.White
        Me.txtSerie.Location = New System.Drawing.Point(464, 113)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(178, 20)
        Me.txtSerie.TabIndex = 40
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(461, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Serie"
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.Controls.Add(Me.TabControl2)
        Me.TabPageAdv2.Image = Nothing
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 25)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(732, 392)
        Me.TabPageAdv2.TabForeColor = System.Drawing.SystemColors.Control
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = "Documentos"
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(8, 31)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(719, 204)
        Me.TabControl2.TabIndex = 156
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dtdatosDocumentos)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(711, 178)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Documentos Cargados"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dtdatosDocumentos
        '
        Me.dtdatosDocumentos.AllowUserToAddRows = False
        Me.dtdatosDocumentos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdatosDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtdatosDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtdatosDocumentos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtdatosDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtdatosDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtdatosDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtdatosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdatosDocumentos.DoubleBuffered = True
        Me.dtdatosDocumentos.EnableHeadersVisualStyles = False
        Me.dtdatosDocumentos.HeaderBgColor = System.Drawing.Color.DarkSlateGray
        Me.dtdatosDocumentos.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtdatosDocumentos.Location = New System.Drawing.Point(6, 6)
        Me.dtdatosDocumentos.Name = "dtdatosDocumentos"
        Me.dtdatosDocumentos.ReadOnly = True
        Me.dtdatosDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtdatosDocumentos.RowHeadersVisible = False
        Me.dtdatosDocumentos.Size = New System.Drawing.Size(699, 166)
        Me.dtdatosDocumentos.TabIndex = 26
        '
        'BackgroundMotocicleta
        '
        '
        'BackgroundDocumentosMotocicleta
        '
        '
        'BackgroundDocumentos
        '
        '
        'BackgroundActualizarDatos
        '
        '
        'ConsultarMotocicleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 467)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarMotocicleta"
        Me.Text = "Motocicleta Capturada"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.TabPageAdv1.PerformLayout()
        CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAdv2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dtdatosDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonoFlat_HeaderLabel1 As MonoFlat.MonoFlat_HeaderLabel
    Friend WithEvents EvolveControlBox1 As EvolveControlBox
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents txtMarca As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents Label11 As Label
    Friend WithEvents txtModelo As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCilindraje As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents txtNoPedimento As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtColor As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents txtNoMotor As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNCI As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents txtSerie As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents Label20 As Label
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoFactura As VB.Windows.Forms.ControlExt.TextBoxEx
    Friend WithEvents BackgroundMotocicleta As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundDocumentosMotocicleta As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dtdatosDocumentos As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BackgroundDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundActualizarDatos As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtValor As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents txtAño As VB.Windows.Forms.ControlExt.TextBoxEx
End Class
