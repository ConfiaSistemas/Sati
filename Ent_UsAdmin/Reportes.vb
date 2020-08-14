Public Class Reportes

    Public catservicios As New servicios
    Public catimpuestos As New impuestos
    Public ventanapanel As String
    Public catTiposDocumentos As New TiposDocumentosSolicitud
    Public CatTiposdecreditos As New CatTiposdeCredito
    Public CatCreditosActivos As New CreditosActivos
    Public catCajas As New Cajas


    Public catDesembolsos As New Desembolsos
    Public CatTickets As New Tickets
    Public catTicketsDetalle As New TicketsPfecha
    Public catCreditosEnMora As New CreditosEnMora
    Public catValorCartera As New ValorCartera
    Public catRetiros As New RetirosPorFecha
    Public catPagosHoy As New PagosHoy
    Public CatMoraNiveles As New MoraPorNiveles


    Private Sub inv_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Select Case ventanapanel
            Case "Tickets"
                CatTickets.Size = Panel1.Size
            Case "Desembolsos"
                catDesembolsos.Size = Panel1.Size
            Case "TicketsDetalle"
                catTicketsDetalle.Size = Panel1.Size
            Case "TiposDocumentos"
                catTiposDocumentos.Size = Panel1.Size
            Case "TiposDeCredito"
                CatTiposdecreditos.Size = Panel1.Size
            Case "CreditosActivos"
                CatCreditosActivos.Size = Panel1.Size
            Case "Cajas"
                catCajas.Size = Panel1.Size
            Case "Mora"
                catCreditosEnMora.Size = Panel1.Size
            Case "ValorCartera"
                catValorCartera.Size = Panel1.Size
            Case "Retiros"
                catRetiros.Size = Panel1.Size
            Case "PagosHoy"
                catPagosHoy.Size = Panel1.Size
            Case "MoraNiveles"
                CatMoraNiveles.Size = Panel1.Size
        End Select


    End Sub

    Private Sub MonoFlat_Button3_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button3.Click

        'catservicios.Visible = False
        'catCajas.Visible = False
        'catTiposDocumentos.Visible = False
        'CatTiposdecreditos.Visible = False
        CatTickets.Visible = False
        catTicketsDetalle.Visible = False
        catCreditosEnMora.Visible = False
        CatMoraNiveles.Visible = False
        catValorCartera.Visible = False
        catPagosHoy.Visible = False
        catRetiros.Visible = False
        catDesembolsos.Visible = True

                catDesembolsos.TopLevel = False

                catDesembolsos.Size = Panel1.Size
                catDesembolsos.Location = New System.Drawing.Point(0, 0)
                catDesembolsos.WindowState = FormWindowState.Normal
                catDesembolsos.Visible = True
        ventanapanel = "Desembolsos"
        Panel1.Controls.Add(catDesembolsos)


    End Sub




    Private Sub MonoFlat_Button5_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button5.Click

        'catimpuestos.Visible = False
        'CatTiposdecreditos.Visible = False
        'catservicios.Visible = False
        'catTiposDocumentos.Visible = False
        'catCajas.Visible = False
        catDesembolsos.Visible = False
        catTicketsDetalle.Visible = False
        catCreditosEnMora.Visible = False
        catValorCartera.Visible = False
        CatMoraNiveles.Visible = False
        catPagosHoy.Visible = False
        catRetiros.Visible = False
        CatTickets.Visible = True
        CatTickets.TopLevel = False

        CatTickets.Size = Panel1.Size
        CatTickets.Location = New System.Drawing.Point(0, 0)
        CatTickets.WindowState = FormWindowState.Normal
        CatTickets.Visible = True
        ventanapanel = "Tickets"
        Panel1.Controls.Add(CatTickets)


    End Sub



    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        catDesembolsos.Visible = False
        CatTickets.Visible = False
        catCreditosEnMora.Visible = False
        catValorCartera.Visible = False
        catRetiros.Visible = False
        CatMoraNiveles.Visible = False
        catPagosHoy.Visible = False
        catTicketsDetalle.Visible = True
        catTicketsDetalle.Visible = True
        catTicketsDetalle.TopLevel = False

        catTicketsDetalle.Size = Panel1.Size
        catTicketsDetalle.Location = New System.Drawing.Point(0, 0)
        catTicketsDetalle.WindowState = FormWindowState.Normal
        catTicketsDetalle.Visible = True
        ventanapanel = "TicketsDetalle"
        Panel1.Controls.Add(catTicketsDetalle)
    End Sub

    Private Sub MonoFlat_Button2_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button2.Click
        catDesembolsos.Visible = False
        CatTickets.Visible = False
        catTicketsDetalle.Visible = False
        catValorCartera.Visible = False
        catRetiros.Visible = False
        CatMoraNiveles.Visible = False
        catPagosHoy.Visible = False
        catCreditosEnMora.Visible = True

        catCreditosEnMora.Visible = True
        catCreditosEnMora.Visible = True
        catCreditosEnMora.TopLevel = False

        catCreditosEnMora.Size = Panel1.Size
        catCreditosEnMora.Location = New System.Drawing.Point(0, 0)
        catCreditosEnMora.WindowState = FormWindowState.Normal
        catCreditosEnMora.Visible = True
        ventanapanel = "Mora"
        Panel1.Controls.Add(catCreditosEnMora)
    End Sub

    Private Sub MonoFlat_Button4_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button4.Click
        catDesembolsos.Visible = False
        CatTickets.Visible = False
        catTicketsDetalle.Visible = False
        catRetiros.Visible = False
        catPagosHoy.Visible = False
        CatMoraNiveles.Visible = False
        catValorCartera.Visible = True
        catCreditosEnMora.Visible = False

        catValorCartera.Visible = True
        catValorCartera.Visible = True
        catValorCartera.TopLevel = False

        catValorCartera.Size = Panel1.Size
        catValorCartera.Location = New System.Drawing.Point(0, 0)
        catValorCartera.WindowState = FormWindowState.Normal
        catValorCartera.Visible = True
        ventanapanel = "ValorCartera"
        Panel1.Controls.Add(catValorCartera)
    End Sub

    Private Sub MonoFlat_Button6_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button6.Click
        catDesembolsos.Visible = False
        CatTickets.Visible = False
        catTicketsDetalle.Visible = False
        catValorCartera.Visible = False
        catCreditosEnMora.Visible = False
        catPagosHoy.Visible = False
        CatMoraNiveles.Visible = False
        catRetiros.Visible = True
        catRetiros.Visible = True
        catRetiros.Visible = True
        catRetiros.TopLevel = False

        catRetiros.Size = Panel1.Size
        catRetiros.Location = New System.Drawing.Point(0, 0)
        catRetiros.WindowState = FormWindowState.Normal
        catRetiros.Visible = True
        ventanapanel = "Retiros"
        Panel1.Controls.Add(catRetiros)
    End Sub

    Private Sub MonoFlat_Button7_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button7.Click
        catDesembolsos.Visible = False
        CatTickets.Visible = False
        catTicketsDetalle.Visible = False
        catValorCartera.Visible = False
        catCreditosEnMora.Visible = False
        catRetiros.Visible = False
        CatMoraNiveles.Visible = False
        catPagosHoy.Visible = True
        catPagosHoy.Visible = True
        catPagosHoy.Visible = True
        catPagosHoy.TopLevel = False

        catPagosHoy.Size = Panel1.Size
        catPagosHoy.Location = New System.Drawing.Point(0, 0)
        catPagosHoy.WindowState = FormWindowState.Normal
        catPagosHoy.Visible = True
        ventanapanel = "PagosHoy"
        Panel1.Controls.Add(catPagosHoy)
    End Sub

    Private Sub MonoFlat_Button8_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button8.Click
        catDesembolsos.Visible = False
        CatTickets.Visible = False
        catTicketsDetalle.Visible = False
        catValorCartera.Visible = False
        catCreditosEnMora.Visible = False
        catRetiros.Visible = False
        catPagosHoy.Visible = False

        CatMoraNiveles.Visible = True
        CatMoraNiveles.Visible = True
        CatMoraNiveles.Visible = True
        CatMoraNiveles.TopLevel = False

        CatMoraNiveles.Size = Panel1.Size
        CatMoraNiveles.Location = New System.Drawing.Point(0, 0)
        CatMoraNiveles.WindowState = FormWindowState.Normal
        CatMoraNiveles.Visible = True
        ventanapanel = "MoraNiveles"
        Panel1.Controls.Add(CatMoraNiveles)
    End Sub
End Class