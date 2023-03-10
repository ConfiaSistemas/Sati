Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CrearConvenio

    Dim Modalidad As String
    Public idCredito As String
    Public ParteCredito As Double
    Public ParteMoratorios As Double
    Dim pagare As Double
    Dim abonadoSmultas As Double
    Dim PendienteSmultas As Double
    Dim multas As Double
    Dim abonadoMultas As Double
    Dim multasPendientes As Double
    Dim gestor As Integer
    Dim diasAtraso As String
    Dim pagosVencidos As Integer
    Dim modalidadCredito As String
    Public DeudaAP As Double
    Public DeudaTotal As Double
    Public incluyePorcentaje As Boolean
    Public Autorizado As Boolean

    Private Sub ZeroitMetroSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles ZeroitMetroSwitch1.CheckedChanged
        If ZeroitMetroSwitch1.Checked Then
            lblTipoPagos.Text = "Pago"
            txtPago.Enabled = True
            txtCantPagos.Enabled = False
        Else
            lblTipoPagos.Text = "Cantidad de Pagos"
            txtPago.Enabled = False
            txtCantPagos.Enabled = True
        End If
    End Sub

    Private Sub SwitchModalidad_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchModalidad.CheckedChanged
        If SwitchModalidad.Checked Then
            lblModalidad.Text = "Semanal"
            Modalidad = "S"
        Else
            lblModalidad.Text = "Quincenal"
            Modalidad = "Q"
        End If
    End Sub

    Private Sub BackgroundDatos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundDatos.DoWork
        iniciarconexionempresa()
        Dim comandoCreditoLegal As SqlCommand
        Dim consultaCreditoLegal As String
        Dim readerCreditoLegal As SqlDataReader
        consultaCreditoLegal = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,
case when FechaDeAtraso = 'Nunca' then
	case when CarteraTotal.Estado = 'C' then
	DATEDIFF(day,(select fechapago from calendarioconveniossac inner join ConveniosSac on CalendarioConveniosSac.idConvenio = ConveniosSac.id where ConveniosSac.idCredito = CarteraTotal.id and Npago = 1),GETDATE())
	when CarteraTotal.Estado = 'R' then
		DATEDIFF(day,(select fechapago from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.idConvenio = ReestructurasSac.id where ReestructurasSac.idCredito = CarteraTotal.id and Npago = 1),GETDATE())

	else
		DATEDIFF(day,(select fechapago from CalendarioNormal  where CalendarioNormal.id_Credito = CarteraTotal.id and Npago = 1),GETDATE())

	end
else (case when carteratotal.Estado = 'C' then
	datediff(day,fechadeatraso,GETDATE())
	when carteratotal.Estado = 'R' then
	datediff(day,fechadeatraso,GETDATE())
	else 
	datediff(day,fechadeatraso,GETDATE())
	end)
end as Diasdeatraso,PagosVencidos,Modalidad,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,FechaDeAtraso,IdGestor from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where Abonado <> 0 and Abonado >= interes and convenios.id_credito = Cartera.id group by id_credito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where abonado <> 0 and abonado <= interes and CalendarioConvenios.estado = 'V' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConvenios.monto) as AbonadoMultas from CalendarioConvenios inner join Convenios on Convenios.id = CalendarioConvenios.Id_Convenio where  CalendarioConvenios.estado = 'L' and Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConvenios.interes) as Multas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where  Convenios.id_credito = Cartera.id group by Convenios.id_credito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(calendarioconvenios.monto) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where convenios.id_credito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull(convert(varchar,(select top 1 CalendarioConveniosSac.Fecha from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniossac.IdConvenio = Conveniossac.id where CalendarioConveniosSac.Fecha>'1900-01-01' and ConveniosSac.idCredito = Cartera.id order by CalendarioConveniosSac.Fecha desc),23),'Nunca')
when Cartera.Estado = 'R' then
isnull(convert(varchar,(select top 1 CalendarioReestructurasSac.Fecha from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Fecha>'1900-01-01' and ReestructurasSac.idCredito = Cartera.id order by CalendarioReestructurasSac.Fecha desc),23),'Nunca')
else
isnull(convert(varchar,(select top 1 FechaUltimoPago from CalendarioNormal where FechaUltimoPago>'1900-01-01' and CalendarioNormal.id_credito = Cartera.id order by FechaUltimoPago desc),23),'Nunca')
end as FechaDeAtraso,
isnull((select COUNT(Npago) from CalendarioNormal where Estado='V' and CalendarioNormal.id_credito = Cartera.id),0)as PagosVencidos,
isnull((select Modalidad from TiposDeCredito where id=Cartera.Tipo),'')Modalidad,
case when Cartera.Estado = 'C' then
isnull((select SUM(calendarioconvenios.pendiente) from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where calendarioconvenios.Estado = 'V' and convenios.id_credito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConvenios inner join Convenios on CalendarioConvenios.Id_Convenio = Convenios.id where CalendarioConvenios.Estado ='V' and Convenios.id_credito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado, Credito.Tipo from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = '" & idCredito & "'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado, Credito.Tipo) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"
        comandoCreditoLegal = New SqlCommand
        comandoCreditoLegal.Connection = conexionempresa
        comandoCreditoLegal.CommandText = consultaCreditoLegal
        readerCreditoLegal = comandoCreditoLegal.ExecuteReader
        If readerCreditoLegal.HasRows Then
            While readerCreditoLegal.Read
                ParteCredito = readerCreditoLegal("valorCarteraSinMultas")
                ParteMoratorios = readerCreditoLegal("MultasPendientes")
                multas = readerCreditoLegal("Multas")
                abonadoMultas = readerCreditoLegal("AbonadoMultas")
                multasPendientes = readerCreditoLegal("MultasPendientes")
                pagare = readerCreditoLegal("pagare")
                abonadoSmultas = readerCreditoLegal("AbonadoSinMultas")
                gestor = readerCreditoLegal("idgestor")
                'DeudaAP = readerCreditoLegal("deudaAP")
                DeudaTotal = readerCreditoLegal("ValorCarteraConMultas")
                lblnombre.Text = readerCreditoLegal("Nombre")
                diasAtraso = readerCreditoLegal("diasdeatraso")
                pagosVencidos = readerCreditoLegal("PagosVencidos")
                modalidadCredito = readerCreditoLegal("Modalidad")
                ' incluyePorcentaje = readerCreditoLegal("incluyeporcentaje")
            End While
        End If
        '  CheckPorcentaje.Checked = incluyePorcentaje
        lblpagare.Text = FormatCurrency(pagare)
        lblAbonadoSmultas.Text = FormatCurrency(abonadoSmultas)
        lblmultas.Text = FormatCurrency(multas)
        lblMultasAbonadas.Text = FormatCurrency(abonadoMultas)
        lblPagosVencidos.Text = pagosVencidos
        lblDiasAtraso.Text = diasAtraso
        lblParteCredito.Text = FormatCurrency(ParteCredito)
        lblParteMoratorios.Text = FormatCurrency(ParteMoratorios)
        '  lblSubtotal.Text = FormatCurrency(DeudaAP)
        lblTotal.Text = FormatCurrency(DeudaTotal)

    End Sub

    Private Sub BackgroundDatos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDatos.RunWorkerCompleted
        Cargando.Close()

    End Sub

    Private Sub CrearConvenioLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Datos"
        Cargando.TopMost = True
        datePrimerPago.Value = Now
        BackgroundDatos.RunWorkerAsync()

    End Sub

    Private Sub txtPago_OnValueChanged(sender As Object, e As EventArgs) Handles txtPago.OnValueChanged

    End Sub

    Private Sub txtPago_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantPagos.Text = CInt(Math.Ceiling((DeudaTotal) / Val(txtPago.Text)))
        End If
    End Sub

    Private Sub txtCantPagos_OnValueChanged(sender As Object, e As EventArgs) Handles txtCantPagos.OnValueChanged

    End Sub

    Private Sub txtCantPagos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantPagos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPago.Text = CInt(Math.Ceiling(Val(DeudaTotal) / Val(txtCantPagos.Text)))
        End If
    End Sub

    Private Sub MonoFlat_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MonoFlat_LinkLabel1.LinkClicked
        Dim deuda As Double
        deuda = DeudaTotal
        Dim canPagos As Integer
        canPagos = Val(txtCantPagos.Text)
        Dim numero As Integer = 0
        If (DeudaTotal Mod canPagos) = 0 Then
            MessageBox.Show(canPagos & " pagos de " & txtPago.Text)
        Else
            For i As Integer = 1 To canPagos - 1
                deuda = deuda - Val(txtPago.Text)
                numero += 1

            Next
            MessageBox.Show(numero & " pagos de " & txtPago.Text & " y 1 pago de " & deuda)
        End If
    End Sub

    Private Sub btnGenerarCalendario_Click(sender As Object, e As EventArgs) Handles btnGenerarCalendario.Click

        Select Case modalidadCredito
            Case "S"
                If pagosVencidos > 3 Then
                    CalendarioConvenio.Moratorios = ParteMoratorios
                    CalendarioConvenio.Capital = ParteCredito


                    ' CalendarioConvenioLegal.personalizado = personalizado
                    CalendarioConvenio.idCredito = idCredito
                    CalendarioConvenio.deuda = DeudaTotal
                    CalendarioConvenio.cantPagos = txtCantPagos.Text
                    CalendarioConvenio.MontoPago = txtPago.Text
                    CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
                    CalendarioConvenio.Modalidad = Modalidad
                    CalendarioConvenio.deudaTotal = DeudaTotal
                    CalendarioConvenio.gestor = gestor
                    CalendarioConvenio.Show()
                Else
                    If idGrp = 1 Then
                        CalendarioConvenio.Moratorios = ParteMoratorios
                        CalendarioConvenio.Capital = ParteCredito
                        CalendarioConvenio.idCredito = idCredito
                        CalendarioConvenio.deuda = DeudaTotal
                        CalendarioConvenio.cantPagos = txtCantPagos.Text
                        CalendarioConvenio.MontoPago = txtPago.Text
                        CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
                        CalendarioConvenio.Modalidad = Modalidad
                        CalendarioConvenio.deudaTotal = DeudaTotal
                        CalendarioConvenio.gestor = gestor
                        CalendarioConvenio.Show()
                    ElseIf diasAtraso < 30 Then
                        MessageBox.Show("Para crear el convenio, el crédito debe tener por lo menos 4 pagos vencidos, o 30 días de atraso desde la última fecha de pago.")
                    Else
                        CalendarioConvenio.Moratorios = ParteMoratorios
                            CalendarioConvenio.Capital = ParteCredito


                            ' CalendarioConvenioLegal.personalizado = personalizado
                            CalendarioConvenio.idCredito = idCredito
                            CalendarioConvenio.deuda = DeudaTotal
                            CalendarioConvenio.cantPagos = txtCantPagos.Text
                            CalendarioConvenio.MontoPago = txtPago.Text
                            CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
                            CalendarioConvenio.Modalidad = Modalidad
                            CalendarioConvenio.deudaTotal = DeudaTotal
                            CalendarioConvenio.gestor = gestor
                            CalendarioConvenio.Show()
                        End If
                    End If

                    Case "Q"
                If pagosVencidos > 1 Then
                    CalendarioConvenio.Moratorios = ParteMoratorios
                    CalendarioConvenio.Capital = ParteCredito


                    ' CalendarioConvenioLegal.personalizado = personalizado
                    CalendarioConvenio.idCredito = idCredito
                    CalendarioConvenio.deuda = DeudaTotal
                    CalendarioConvenio.cantPagos = txtCantPagos.Text
                    CalendarioConvenio.MontoPago = txtPago.Text
                    CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
                    CalendarioConvenio.Modalidad = Modalidad
                    CalendarioConvenio.deudaTotal = DeudaTotal
                    CalendarioConvenio.gestor = gestor
                    CalendarioConvenio.Show()
                Else
                    If idGrp = 1 Then
                        CalendarioConvenio.Moratorios = ParteMoratorios
                        CalendarioConvenio.Capital = ParteCredito


                        ' CalendarioConvenioLegal.personalizado = personalizado
                        CalendarioConvenio.idCredito = idCredito
                        CalendarioConvenio.deuda = DeudaTotal
                        CalendarioConvenio.cantPagos = txtCantPagos.Text
                        CalendarioConvenio.MontoPago = txtPago.Text
                        CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
                        CalendarioConvenio.Modalidad = Modalidad
                        CalendarioConvenio.deudaTotal = DeudaTotal
                        CalendarioConvenio.gestor = gestor
                        CalendarioConvenio.Show()
                    ElseIf diasAtraso < 30 Then
                        MessageBox.Show("Para crear el convenio, el crédito debe tener por lo menos 2 pagos vencidos (quincenal), o 30 días de atraso desde la última fecha de pago.")
                    Else
                        CalendarioConvenio.Moratorios = ParteMoratorios
                            CalendarioConvenio.Capital = ParteCredito


                            ' CalendarioConvenioLegal.personalizado = personalizado
                            CalendarioConvenio.idCredito = idCredito
                            CalendarioConvenio.deuda = DeudaTotal
                            CalendarioConvenio.cantPagos = txtCantPagos.Text
                            CalendarioConvenio.MontoPago = txtPago.Text
                            CalendarioConvenio.PrimerPago = Convert.ToDateTime(datePrimerPago.Value.ToShortDateString)
                            CalendarioConvenio.Modalidad = Modalidad
                            CalendarioConvenio.deudaTotal = DeudaTotal
                            CalendarioConvenio.gestor = gestor
                            CalendarioConvenio.Show()
                        End If
                    End If

        End Select

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class