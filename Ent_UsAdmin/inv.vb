Public Class inv

    Public catservicios As New servicios
    Public catimpuestos As New impuestos
    Public ventanapanel As String
    Public catTiposDocumentos As New TiposDocumentosSolicitud
    Public CatTiposdecreditos As New CatTiposdeCredito
    Public CatCreditosActivos As New CreditosActivos
    Public catCajas As New Cajas
    Public catLegal As New CreditosEnLegal
    Private Sub MonoFlat_Button2_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button2.Click
        catimpuestos.Visible = False
        catLegal.Visible = False
        catTiposDocumentos.Visible = False
        CatTiposdecreditos.Visible = False
        CatCreditosActivos.Visible = False
        catservicios.Visible = True
        catservicios.TopLevel = False

        catservicios.Size = Panel1.Size
        catservicios.Location = New System.Drawing.Point(0, 0)
        catservicios.WindowState = FormWindowState.Normal
        catservicios.Visible = True
        ventanapanel = "servicios"
        Panel1.Controls.Add(catservicios)
    End Sub

    Private Sub inv_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Select Case ventanapanel
            Case "servicios"
                catservicios.Size = Panel1.Size
            Case "impuestos"
                catimpuestos.Size = Panel1.Size
            Case "TiposDocumentos"
                catTiposDocumentos.Size = Panel1.Size
            Case "TiposDeCredito"
                CatTiposdecreditos.Size = Panel1.Size
            Case "CreditosActivos"
                CatCreditosActivos.Size = Panel1.Size
            Case "Cajas"
                catCajas.Size = Panel1.Size
            Case "Legal"
                catLegal.Size = Panel1.Size
        End Select


    End Sub

    Private Sub MonoFlat_Button3_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button3.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModClientes") Then
                catservicios.Visible = False
                catCajas.Visible = False
                catLegal.Visible = False
                catTiposDocumentos.Visible = False
                CatTiposdecreditos.Visible = False
                CatCreditosActivos.Visible = False
                catimpuestos.Visible = True

                catimpuestos.TopLevel = False

                catimpuestos.Size = Panel1.Size
                catimpuestos.Location = New System.Drawing.Point(0, 0)
                catimpuestos.WindowState = FormWindowState.Normal
                catimpuestos.Visible = True
                ventanapanel = "impuestos"
                Panel1.Controls.Add(catimpuestos)
            Else

            End If
        Next

    End Sub

    Private Sub MonoFlat_Button4_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button4.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModTipoDocumentos") Then
                catimpuestos.Visible = False
                catCajas.Visible = False
                CatTiposdecreditos.Visible = False
                catservicios.Visible = False
                catLegal.Visible = False
                CatCreditosActivos.Visible = False
                catTiposDocumentos.Visible = True
                catTiposDocumentos.TopLevel = False

                catTiposDocumentos.Size = Panel1.Size
                catTiposDocumentos.Location = New System.Drawing.Point(0, 0)
                catTiposDocumentos.WindowState = FormWindowState.Normal
                catTiposDocumentos.Visible = True
                ventanapanel = "TiposDocumentos"
                Panel1.Controls.Add(catTiposDocumentos)
            Else

            End If
        Next


    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModTiposCreditos") Then
                catimpuestos.Visible = False
                catCajas.Visible = False
                catLegal.Visible = False
                catservicios.Visible = False
                catTiposDocumentos.Visible = False
                CatCreditosActivos.Visible = False
                CatTiposdecreditos.Visible = True
                CatTiposdecreditos.TopLevel = False

                CatTiposdecreditos.Size = Panel1.Size
                CatTiposdecreditos.Location = New System.Drawing.Point(0, 0)
                CatTiposdecreditos.WindowState = FormWindowState.Normal
                CatTiposdecreditos.Visible = True
                ventanapanel = "TiposDeCredito"
                Panel1.Controls.Add(CatTiposdecreditos)
            Else

            End If
        Next


    End Sub

    Private Sub MonoFlat_Button5_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button5.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModCreditos") Then
                catimpuestos.Visible = False
                CatTiposdecreditos.Visible = False
                catservicios.Visible = False
                catLegal.Visible = False
                catTiposDocumentos.Visible = False
                catCajas.Visible = False
                CatCreditosActivos.Visible = True
                CatCreditosActivos.TopLevel = False

                CatCreditosActivos.Size = Panel1.Size
                CatCreditosActivos.Location = New System.Drawing.Point(0, 0)
                CatCreditosActivos.WindowState = FormWindowState.Normal
                CatCreditosActivos.Visible = True
                ventanapanel = "CreditosActivos"
                Panel1.Controls.Add(CatCreditosActivos)
            Else

            End If
        Next

    End Sub

    Private Sub MonoFlat_Button6_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button6.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModTiposCreditos") Then
                catimpuestos.Visible = False
                CatTiposdecreditos.Visible = False
                catservicios.Visible = False
                catTiposDocumentos.Visible = False
                CatCreditosActivos.Visible = False
                catLegal.Visible = False
                catCajas.Visible = True
                catCajas.TopLevel = False

                catCajas.Size = Panel1.Size
                catCajas.Location = New System.Drawing.Point(0, 0)
                catCajas.WindowState = FormWindowState.Normal
                catCajas.Visible = True
                ventanapanel = "Cajas"
                Panel1.Controls.Add(catCajas)
            Else

            End If
        Next



    End Sub

    Private Sub MonoFlat_Button7_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button7.Click
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModLegal") Then
                catimpuestos.Visible = False
                CatTiposdecreditos.Visible = False
                catservicios.Visible = False
                catTiposDocumentos.Visible = False
                CatCreditosActivos.Visible = False
                catCajas.Visible = False
                catLegal.Visible = True
                catLegal.TopLevel = False

                catLegal.Size = Panel1.Size
                catLegal.Location = New System.Drawing.Point(0, 0)
                catLegal.WindowState = FormWindowState.Normal
                catLegal.Visible = True
                ventanapanel = "Legal"
                Panel1.Controls.Add(catLegal)
            Else

            End If
        Next


    End Sub
End Class