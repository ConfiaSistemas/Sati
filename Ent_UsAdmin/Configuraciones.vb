Imports System.Drawing.Printing
Imports MadMilkman.Ini

Public Class Configuraciones
    Private Sub Configuraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIp.Text = ipser
        txtBD.Text = bdser
        For Each Impresoras In PrinterSettings.InstalledPrinters
            ComboImpresora.Items.Add(Impresoras.ToString)
        Next
        ComboImpresora.Text = ImpresoraPredeterminada

        For Each Impresoras2 In PrinterSettings.InstalledPrinters
            ComboTarjeta.Items.Add(Impresoras2.ToString)
        Next
        ComboTarjeta.Text = ImpresoraTarjetas
    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        Dim options As IniOptions = New IniOptions() With {.EncryptionPassword = "EntUs01pos"}
        Dim file As IniFile = New IniFile(options)

        Dim section As IniSection = file.Sections.Add("Conexión")
        section.Keys.Add("Ip", txtIp.Text)
        section.Keys.Add("Base", txtBD.Text)
        '  section.Keys.Add("Caja", txtcaja.Text)
        section.Keys.Add("Impresora", ComboImpresora.Text)
        section.Keys.Add("Tipo", TipoEquipo)
        section.Keys.Add("Tarjetas", ComboTarjeta.Text)
        ' Save and encrypt the file.
        file.Save("C:\ConfiaAdmin\SATI\SetConfig.ini")

        file.Sections.Clear()
        ipser = txtIp.Text
        bdser = txtBD.Text
        ImpresoraPredeterminada = ComboImpresora.Text
        ImpresoraTarjetas = ComboTarjeta.Text
        MessageBox.Show("Listo")
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class