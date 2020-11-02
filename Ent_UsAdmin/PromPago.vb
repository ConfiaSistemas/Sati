Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class PromPago
    Public idCredito As Integer
    Dim dataVencidos As DataTable
    Dim adapterVencidos As SqlDataAdapter
    Dim dataTotal As DataTable
    Dim adapterTotal As SqlDataAdapter
    Dim pagoNormalTotal As Double
    Dim multasTotal As Double
    Dim pagonormalParcial As Double
    Dim multasParcial As Double

    Dim ncargando As Cargando
    Private Sub PromPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True

        Panel1.BackColor = Color.FromArgb(191, 219, 255)
        Panel2.BackColor = Color.FromArgb(191, 219, 255)
        Panel3.BackColor = Color.FromArgb(191, 219, 255)
    End Sub

    Private Sub RadCollapsiblePanel1_Expanded(sender As Object, e As EventArgs) Handles RadCollapsiblePanel1.Expanded
        ResumeLayout()
        dtTotal.Visible = True
    End Sub

    Private Sub RadCollapsiblePanel1_Expanding(sender As Object, e As CancelEventArgs) Handles RadCollapsiblePanel1.Expanding
        SuspendLayout()
        dtTotal.Visible = False
    End Sub

    Private Sub RadCollapsiblePanel1_SizeChanged(sender As Object, e As EventArgs) Handles RadCollapsiblePanel1.SizeChanged
        If RadCollapsiblePanel1.IsExpanded Then
        Else
            dtTotal.Visible = False
        End If
        RadCollapsiblePanel2.IsExpanded = False

        GroupVencidos.Location = New Point(RadCollapsiblePanel1.Location.X, RadCollapsiblePanel1.Location.Y + RadCollapsiblePanel1.Size.Height + 4)
        RadCollapsiblePanel2.Location = New Point(GroupVencidos.Location.X, GroupVencidos.Location.Y + GroupVencidos.Size.Height + 5)
    End Sub

    Private Sub RadWizard1_Next(sender As Object, e As WizardCancelEventArgs) Handles RadWizard1.[Next]
        If RadWizard1.Pages.Item(0) Is RadWizard1.SelectedPage Then
            ncargando = New Cargando
            ncargando.Show()

            ncargando.MonoFlat_Label1.Text = "Consultando información"
            ncargando.TopMost = True
            BackgroundVencidos.RunWorkerAsync()
        End If


    End Sub

    Private Sub BackgroundVencidos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundVencidos.DoWork
        iniciarconexionempresa()

        Dim consultaDeudaTotal As String
        consultaDeudaTotal = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,IdGestor from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where Abonado <> 0 and Abonado >= interes and ConveniosSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosSac.estado = 'V' and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' and ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by ReestructurasSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniosSac.monto) as AbonadoMultas from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where  CalendarioConveniosSac.estado = 'L' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniosSac.interes) as Multas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where  ConveniosSac.idcredito = Cartera.id and  fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' THEN 
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id  and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "' group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(CalendarioConveniosSac.monto) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where ConveniosSac.idcredito = Cartera.id)
when cartera.Estado = 'R' THEN 
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(CalendarioConveniosSac.pendiente) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado = 'V' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id and and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado ='V' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "')
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "')
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = '" & idCredito & "'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"

        Dim comandoDeudaParcial As SqlCommand
        Dim readerDeudaParcial As SqlDataReader
        comandoDeudaParcial = New SqlCommand
        comandoDeudaParcial.Connection = conexionempresa
        comandoDeudaParcial.CommandText = consultaDeudaTotal
        readerDeudaParcial = comandoDeudaParcial.ExecuteReader
        If readerDeudaParcial.HasRows Then
            pagoNormalTotal = readerDeudaParcial("valorcarterasinmultas")
            multasTotal = readerDeudaParcial("multaspendientes")

        End If
        lblPagoNormalParcial.Text = FormatCurrency(pagonormalParcial, 2)
        lblMultasParcial.Text = FormatCurrency(multasParcial, 2)





        Dim consultaVencidos As String
        consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,Estado,FechaUltimoPago from calendarionormal where id_credito ='" & idCredito & "' and estado <> 'L' and fechapago <='" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'"

        adapterVencidos = New SqlDataAdapter(consultaVencidos, conexionempresa)
        dataVencidos = New DataTable
        adapterVencidos.Fill(dataVencidos)

    End Sub

    Private Sub BackgroundVencidos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundVencidos.RunWorkerCompleted
        dtVencidos.DataSource = dataVencidos
        BackgroundTotal.RunWorkerAsync()


    End Sub

    Private Sub BackgroundTotal_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTotal.DoWork
        iniciarconexionempresa()

        Dim consultaDeudaTotal As String
        consultaDeudaTotal = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
when CarteraTotal.Estado = 'R' then
case when pendiente = 0 then '0' else
(pendiente - (MultasVencidas - (AbonadoMultasV)))end
else(pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) end as VencidoNormal,((Multas - (AbonadoMultasL+AbonadoMultasV)) + (pendiente - (Multas - (AbonadoMultasL+AbonadoMultasV))) ) as TotalPendiente,Gestor,Promotor,Estado,IdGestor from
(select Cartera.nombre,Cartera.id,
case when Cartera.Estado = 'C' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where Abonado <> 0 and Abonado >= interes and ConveniosSac.idcredito = Cartera.id group by idcredito),0)
when Cartera.Estado = 'R' then
 isnull((select SUM(Abonado - interes) as pagonormal from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where Abonado <> 0 and Abonado >= interes and ReestructurasSac.idcredito = Cartera.id group by idcredito),0)
else
isnull((select SUM(Abonado - interes) as pagonormal from CalendarioNormal where Abonado <> 0 and Abonado >= interes and id_credito = Cartera.id group by id_credito),0) end as AbonadoSinMultas,
case when Cartera.Estado = 'C' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioConveniosSac.estado = 'V' and ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0) 
when Cartera.Estado = 'R' then
isnull((select SUM( Abonado) as AbonadoInteres from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where abonado <> 0 and abonado <= interes and CalendarioReestructurasSac.estado = 'V' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0) 
else
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado <= CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)
+
isnull((select SUM( ((((abonado -(abonado -calendarionormal.Interes) ))) )) as AbonadoInteres from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.estado = 'V' and Abonado >=CalendarioNormal.Interes and CalendarioNormal.id_credito =cartera.id group by CalendarioNormal.id_credito),0)),0)end as AbonadoMultasV,
case when Cartera.Estado = 'C' then
isnull((select SUM(Abonado - CalendarioConveniosSac.monto) as AbonadoMultas from CalendarioConveniosSac inner join ConveniosSac on ConveniosSac.id = CalendarioConveniosSac.IdConvenio where  CalendarioConveniosSac.estado = 'L' and ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' then
isnull((select SUM(Abonado - CalendarioReestructurasSac.monto) as AbonadoMultas from CalendarioReestructurasSac inner join ReestructurasSac on ReestructurasSac.id = CalendarioReestructurasSac.IdConvenio where  CalendarioReestructurasSac.estado = 'L' and ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(Abonado - CalendarioNormal.monto) as AbonadoMultas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.estado = 'L' and CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as AbonadoMultasL,
case when Cartera.Estado = 'C' THEN 
isnull((select SUM(CalendarioConveniosSac.interes) as Multas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where  ConveniosSac.idcredito = Cartera.id group by ConveniosSac.idcredito),0)
when Cartera.Estado = 'R' THEN 
isnull((select SUM(CalendarioReestructurasSac.interes) as Multas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where  ReestructurasSac.idcredito = Cartera.id group by ReestructurasSac.idcredito),0)
else
isnull((select SUM(CalendarioNormal.interes) as Multas from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where  CalendarioNormal.id_credito = Cartera.id group by CalendarioNormal.id_credito),0) end as Multas,
case when cartera.Estado = 'C' THEN 
(select SUM(CalendarioConveniosSac.monto) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where ConveniosSac.idcredito = Cartera.id)
when cartera.Estado = 'R' THEN 
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id)
else
(select Pagare from credito where id = Cartera.id) end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(CalendarioConveniosSac.pendiente) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado = 'V' and ConveniosSac.idcredito = Cartera.id),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id),0)
else
isnull((select SUM(pendiente) from CalendarioNormal where Estado = 'V' and id_credito = Cartera.id),0) end as pendiente,
case when Cartera.Estado = 'C' then
(select SUM(interes) as MultasVencidas from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado ='V' and ConveniosSac.idcredito = Cartera.id)
when Cartera.Estado = 'R' then
(select SUM(interes) as MultasVencidas from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado ='V' and ReestructurasSac.idcredito = Cartera.id)
else '0' end as MultasVencidas
,Gestores.Nombre as Gestor,Promotores.Nombre as Promotor,cartera.Estado,Cartera.IdGestor from
(select credito.nombre,Credito.id,Credito.idgestor,Credito.IdPromotor,credito.Estado from Credito inner join CalendarioNormal on credito.id = CalendarioNormal.id_credito where Credito.Estado <> 'L' and Credito.id = '" & idCredito & "'  group by Credito.id,Credito.nombre,Credito.IdGestor,Credito.IdPromotor,Credito.estado) Cartera inner join
(select * from Empleados where Tipo = 'G') Gestores on Cartera.IdGestor = Gestores.id inner join
(select * from Empleados where Tipo = 'P') Promotores on Cartera.IdPromotor = Promotores.id ) CarteraTotal order by nombre asc"

        Dim comandoDeudaTotal As SqlCommand
        Dim readerDeudaTotal As SqlDataReader
        comandoDeudaTotal = New SqlCommand
        comandoDeudaTotal.Connection = conexionempresa
        comandoDeudaTotal.CommandText = consultaDeudaTotal
        readerDeudaTotal = comandoDeudaTotal.ExecuteReader
        If readerDeudaTotal.HasRows Then
            pagoNormalTotal = readerDeudaTotal("valorcarterasinmultas")
            multasTotal = readerDeudaTotal("multaspendientes")

        End If
        lblPagoNormalTotal.Text = FormatCurrency(pagoNormalTotal, 2)
        lblMultasTotal.Text = FormatCurrency(multasTotal, 2)
        Dim consultaTotal As String
        consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,Estado,FechaPago,FechaUltimoPago from calendarionormal where id_credito ='" & idCredito & "' and estado <> 'L' "

        adapterTotal = New SqlDataAdapter(consultaTotal, conexionempresa)
        dataTotal = New DataTable
        adapterTotal.Fill(dataTotal)
    End Sub

    Private Sub RadCollapsiblePanel2_SizeChanged(sender As Object, e As EventArgs) Handles RadCollapsiblePanel2.SizeChanged
        RadCollapsiblePanel1.IsExpanded = False

        'GroupVencidos.Location = New Point(RadCollapsiblePanel1.Location.X, RadCollapsiblePanel1.Location.Y + RadCollapsiblePanel1.Size.Height + 4)
        'RadCollapsiblePanel2.Location = New Point(GroupVencidos.Location.X, GroupVencidos.Location.Y + GroupVencidos.Size.Height + 5)
    End Sub

    Private Sub RadCollapsiblePanel2_Expanding(sender As Object, e As CancelEventArgs) Handles RadCollapsiblePanel2.Expanding
        SuspendLayout()
        dtVencidos.Visible = False

    End Sub

    Private Sub RadCollapsiblePanel2_Expanded(sender As Object, e As EventArgs) Handles RadCollapsiblePanel2.Expanded
        ResumeLayout()
        dtVencidos.Visible = True
    End Sub

    Private Sub BackgroundTotal_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTotal.RunWorkerCompleted
        dtTotal.DataSource = dataTotal
        ncargando.Close()
    End Sub
End Class