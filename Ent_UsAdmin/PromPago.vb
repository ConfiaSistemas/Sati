Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI
Imports Xceed.Words.NET

Public Class PromPago
    Public idCredito As Integer
    Public estadoCredito As String
    Dim nombreCredito As String
    Public descuentoTotal As Double
    Dim TotalTotal As Double
    Dim subTotalTotal As Double
    Public descuentoParcial As Double
    Dim totalParcial As Double
    Dim subTotalParcial As Double
    Public creada As Boolean
    Dim dataVencidos As DataTable
    Dim adapterVencidos As SqlDataAdapter
    Dim dataTotal As DataTable
    Dim adapterTotal As SqlDataAdapter
    Dim pagoNormalTotal As Double
    Dim multasTotal As Double
    Dim pagonormalParcial As Double
    Dim multasParcial As Double
    Dim existePromesa As String
    Dim ncargando As Cargando
    Dim idPromesa As String
    Private Sub PromPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        creada = False
        DoubleBuffered = True
        dateFechaLimite.Value = Now.Date.AddDays(7)
        TextBox1.BackColor = Color.FromArgb(191, 219, 255)
        TextBox1.ForeColor = Color.FromArgb(21, 66, 139)
        Panel1.BackColor = Color.FromArgb(191, 219, 255)
        Panel2.BackColor = Color.FromArgb(191, 219, 255)
        Panel3.BackColor = Color.FromArgb(191, 219, 255)
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Consultando promesas"
        ncargando.TopMost = True
        BackgroundConsultarPromesa.RunWorkerAsync()

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
        If RadWizard1.Pages.Item(1) Is RadWizard1.SelectedPage Then
            If CheckVencidos.CheckState = CheckState.Checked Then

                TextBox1.Text = "El cliente deberá pagar " & FormatCurrency(totalParcial, 2) & " antes de la fecha " & dateFechaLimite.Value.ToLongDateString
                If TextBox1.Text.Length > TextBox1.Height Then

                    TextBox1.ScrollBars = ScrollBars.Vertical
                Else
                    TextBox1.ScrollBars = ScrollBars.None

                End If

            Else

                TextBox1.Text = "El cliente deberá pagar " & FormatCurrency(TotalTotal, 2) & " antes de la fecha " & dateFechaLimite.Value.ToLongDateString
                If TextBox1.Text.Length > TextBox1.Height Then
                    TextBox1.ScrollBars = ScrollBars.Vertical
                Else
                    TextBox1.ScrollBars = ScrollBars.None

                End If

            End If

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
(select SUM(CalendarioConveniosSac.monto) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where ConveniosSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "')
when cartera.Estado = 'R' THEN 
(select SUM(CalendarioReestructurasSac.monto) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where ReestructurasSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "')
else
(select SUM(CalendarioNormal.monto) from CalendarioNormal inner join Credito on CalendarioNormal.id_credito = Credito.id where CalendarioNormal.id_credito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "') end as pagare,
case when Cartera.Estado = 'C' then
isnull((select SUM(CalendarioConveniosSac.pendiente) from CalendarioConveniosSac inner join ConveniosSac on CalendarioConveniosSac.IdConvenio = ConveniosSac.id where CalendarioConveniosSac.Estado = 'V' and ConveniosSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'),0)
when Cartera.Estado = 'R' then
isnull((select SUM(CalendarioReestructurasSac.pendiente) from CalendarioReestructurasSac inner join ReestructurasSac on CalendarioReestructurasSac.IdConvenio = ReestructurasSac.id where CalendarioReestructurasSac.Estado = 'V' and ReestructurasSac.idcredito = Cartera.id and fechapago <= '" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'),0)
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
            While readerDeudaParcial.Read
                pagonormalParcial = readerDeudaParcial("valorcarterasinmultas")
                multasParcial = readerDeudaParcial("multaspendientes")
                nombreCredito = readerDeudaParcial("nombre")
            End While


        End If
        subTotalParcial = (pagonormalParcial + multasParcial)
        totalParcial = (pagonormalParcial + multasParcial) - descuentoParcial
        lblPagoNormalParcial.Text = FormatCurrency(pagonormalParcial, 2)
        lblMultasParcial.Text = FormatCurrency(multasParcial, 2)
        lblDescuentoParcial.Text = FormatCurrency(descuentoParcial, 2)
        lblTotalParcial.Text = FormatCurrency(totalParcial, 2)





        Dim consultaVencidos As String
        Select Case estadoCredito
            Case "R"
                consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioreestructurassac.Estado,fechapago,calendarioreestructurassac.fecha from calendarioreestructurassac inner join reestructurassac on calendarioreestructurassac.idconvenio = reestructurassac.id where idcredito ='" & idCredito & "' and calendarioreestructurassac.estado <> 'L' and fechapago <='" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'"

            Case "C"
                consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioconveniossac.Estado,fechapago,calendarioconveniossac.fecha from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where idcredito ='" & idCredito & "' and calendarioconveniossac.estado <> 'L' and fechapago <='" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'"

            Case Else

                consultaVencidos = "select idPago,Monto, interes as interés,Abonado,Pendiente,Estado,fechapago,fechaultimopago from calendarionormal where id_credito ='" & idCredito & "' and estado <> 'L' and fechapago <='" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "'"

        End Select

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
            While readerDeudaTotal.Read
                pagoNormalTotal = readerDeudaTotal("valorcarterasinmultas")
                multasTotal = readerDeudaTotal("multaspendientes")
                nombreCredito = readerDeudaTotal("nombre")
            End While


        End If

        TotalTotal = (pagoNormalTotal + multasTotal) - descuentoTotal
        subTotalTotal = (pagoNormalTotal + multasTotal)
        lblPagoNormalTotal.Text = FormatCurrency(pagoNormalTotal, 2)
        lblMultasTotal.Text = FormatCurrency(multasTotal, 2)
        lblDescuentoTotal.Text = FormatCurrency(descuentoTotal, 2)
        lblTotalTotal.Text = FormatCurrency(TotalTotal, 2)

        Dim consultaTotal As String
        Select Case estadoCredito
            Case "R"
                consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioreestructurassac.Estado,fechapago,calendarioreestructurassac.fecha from calendarioreestructurassac inner join reestructurassac on calendarioreestructurassac.idconvenio = reestructurassac.id where idcredito ='" & idCredito & "' and calendarioreestructurassac.estado <> 'L'"

            Case "C"
                consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendarioconveniossac.Estado,fechapago,calendarioconveniossac.fecha from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id where idcredito ='" & idCredito & "' and calendarioconveniossac.estado <> 'L' "

            Case Else
                consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,Estado,FechaPago,FechaUltimoPago from calendarionormal where id_credito ='" & idCredito & "' and estado <> 'L' "

        End Select

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

    Private Sub RadWizard1_Help(sender As Object, e As EventArgs) Handles RadWizard1.Help

    End Sub

    Private Sub CheckTotal_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTotal.CheckedChanged
        If CheckTotal.CheckState = CheckState.Checked Then
            CheckVencidos.CheckState = CheckState.Unchecked

        End If
    End Sub

    Private Sub CheckVencidos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckVencidos.CheckedChanged
        If CheckVencidos.CheckState = CheckState.Checked Then
            CheckTotal.CheckState = CheckState.Unchecked

        End If
    End Sub

    Private Sub RadWizard1_Finish(sender As Object, e As EventArgs) Handles RadWizard1.Finish

        If CheckVencidos.CheckState = CheckState.Checked Then
            If descuentoParcial = 0 Then
                ncargando = New Cargando
                ncargando.Show()
                ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                ncargando.TopMost = True
                BackgroundCrearPromesa.RunWorkerAsync()
            Else
                For Each row As DataRow In dataPermisos.Rows
                    If row("SatiModCreditosDescuentoPromesa") Then
                        ncargando = New Cargando
                        ncargando.Show()
                        ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                        ncargando.TopMost = True
                        BackgroundCrearPromesa.RunWorkerAsync()
                        Exit For
                    Else
                        If MessageBox.Show("¿No cuenta con los permisos para aplicar descuento, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            ncargando = New Cargando
                            ncargando.Show()
                            ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                            ncargando.TopMost = True
                            BackgroundPromesaNotificacion.RunWorkerAsync()


                        End If
                    End If
                Next

            End If
        Else
            If descuentoTotal = 0 Then
                ncargando = New Cargando
                ncargando.Show()
                ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                ncargando.TopMost = True
                BackgroundCrearPromesa.RunWorkerAsync()
            Else
                For Each row As DataRow In dataPermisos.Rows
                    If row("SatiModCreditosDescuentoPromesa") Then
                        ncargando = New Cargando
                        ncargando.Show()
                        ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                        ncargando.TopMost = True
                        BackgroundCrearPromesa.RunWorkerAsync()
                        Exit For
                    Else
                        If MessageBox.Show("¿No cuenta con los permisos para aplicar descuento, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            ncargando = New Cargando
                            ncargando.Show()
                            ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                            ncargando.TopMost = True
                            BackgroundPromesaNotificacion.RunWorkerAsync()


                        End If
                    End If
                Next

            End If
        End If


    End Sub

    Private Sub BackgroundCrearPromesa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCrearPromesa.DoWork
        iniciarconexionempresa()
        Dim consultaCrearPromesa As String

        Dim comandoCrearPromesa As SqlCommand

        If CheckVencidos.CheckState = CheckState.Checked Then
            consultaCrearPromesa = "insert into PromesaDePago values('" & idCredito & "','" & totalParcial & "','" & pagonormalParcial & "','" & multasParcial & "','" & totalParcial & "',0,'" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','" & nmusr & "','A','" & estadoCredito & "','" & subTotalParcial & "','" & descuentoParcial & "',0) SELECT SCOPE_IDENTITY()"
        Else
            consultaCrearPromesa = "insert into PromesaDePago values('" & idCredito & "','" & TotalTotal & "','" & pagoNormalTotal & "','" & multasTotal & "','" & TotalTotal & "',0,'" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','" & nmusr & "','A','" & estadoCredito & "','" & subTotalTotal & "','" & descuentoTotal & "',0) SELECT SCOPE_IDENTITY()"
        End If

        comandoCrearPromesa = New SqlCommand
        comandoCrearPromesa.Connection = conexionempresa
        comandoCrearPromesa.CommandText = consultaCrearPromesa
        idPromesa = comandoCrearPromesa.ExecuteScalar

        If CheckVencidos.CheckState = CheckState.Checked Then
            For Each row As DataGridViewRow In dtVencidos.Rows
                Dim consultaDetallePromesa As String
                Dim comandoDetallePromesa As SqlCommand
                consultaDetallePromesa = "insert into DetallePromesa values('" & idPromesa & "','" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "','" & row.Cells(7).Value & "','" & estadoCredito & "')"
                comandoDetallePromesa = New SqlCommand
                comandoDetallePromesa.Connection = conexionempresa
                comandoDetallePromesa.CommandText = consultaDetallePromesa
                comandoDetallePromesa.ExecuteNonQuery()


                Dim consultaActualizaCalConvenio As String
                Dim comandoActualizaCalConvenios As SqlCommand
                Select Case estadoCredito
                    Case "C"
                        consultaActualizaCalConvenio = "Update calendarioConveniossac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"


                    Case "R"
                        consultaActualizaCalConvenio = "Update calendarioReestructurasSac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                    Case Else
                        consultaActualizaCalConvenio = "Update calendarioNormal set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                End Select
                comandoActualizaCalConvenios = New SqlCommand
                comandoActualizaCalConvenios.Connection = conexionempresa
                comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio
                comandoActualizaCalConvenios.ExecuteNonQuery()

            Next
        Else
            For Each row As DataGridViewRow In dtTotal.Rows
                Dim consultaDetallePromesa As String
                Dim comandoDetallePromesa As SqlCommand
                consultaDetallePromesa = "insert into DetallePromesa values('" & idPromesa & "','" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "','" & row.Cells(7).Value & "','" & estadoCredito & "')"
                comandoDetallePromesa = New SqlCommand
                comandoDetallePromesa.Connection = conexionempresa
                comandoDetallePromesa.CommandText = consultaDetallePromesa
                comandoDetallePromesa.ExecuteNonQuery()

                Dim consultaActualizaCalConvenio As String
                Dim comandoActualizaCalConvenios As SqlCommand
                Select Case estadoCredito
                    Case "C"
                        consultaActualizaCalConvenio = "Update calendarioConveniossac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"


                    Case "R"
                        consultaActualizaCalConvenio = "Update calendarioReestructurasSac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                    Case Else
                        consultaActualizaCalConvenio = "Update calendarioNormal set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                End Select
                comandoActualizaCalConvenios = New SqlCommand
                comandoActualizaCalConvenios.Connection = conexionempresa
                comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio
                comandoActualizaCalConvenios.ExecuteNonQuery()

            Next
        End If





    End Sub

    Private Sub BackgroundCrearPromesa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCrearPromesa.RunWorkerCompleted
        ncargando.MonoFlat_Label1.Text = "Generando Formato"

        FileCopy("C:\ConfiaAdmin\SATI\Promesa.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx")
        documento.ReplaceText("%%FECHAPROMESA%%", Date.Now.ToShortDateString)
        documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCredito)
        If CheckVencidos.CheckState = CheckState.Checked Then
            documento.ReplaceText("%%TOTALDEUDA%%", FormatCurrency(totalParcial, 2))
        Else
            documento.ReplaceText("%%TOTALDEUDA%%", FormatCurrency(TotalTotal, 2))
        End If
        documento.ReplaceText("%%FECHALIMITE%%", dateFechaLimite.Value.ToShortDateString)
        documento.Save()
        documento.Dispose()
        VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx"
        VistaPreviaDocumento.Show()
        ncargando.Close()
        Me.Close()

    End Sub

    Private Sub BackgroundConsultarPromesa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultarPromesa.DoWork
        Dim consultaPromesa As String
        consultaPromesa = "if exists(Select * from promesadepago where idcredito = '" & idCredito & "' and estado = 'A')
                            begin
                                select 'Existe'
                            end
                            else if exists(Select * from promesadepago where idcredito = '" & idCredito & "' and estado = 'E' and notificado = 0)
							begin
							 select 'Pendiente'
							end
							else if exists(select * from promesadepago where idcredito = '" & idCredito & "' and estado = 'E' and Notificado = 1)
                            begin
                             Select 'Notificado'
                            end
                            else
							select 'Noexiste'
"


        Dim comandoPromesa As SqlCommand
        comandoPromesa = New SqlCommand
        comandoPromesa.Connection = conexionempresa
        comandoPromesa.CommandText = consultaPromesa
        existePromesa = comandoPromesa.ExecuteScalar

    End Sub

    Private Sub BackgroundConsultarPromesa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultarPromesa.RunWorkerCompleted
        ncargando.Close()
        If existePromesa = "Existe" Then

            MessageBox.Show("El crédito ya cuenta con una promesa activa")
            Me.Close()
        ElseIf existePromesa = "Pendiente" Then
            MessageBox.Show("El crédito cuenta con una promesa pendiente, se intentará notificar de nuevo")

            ncargando = New Cargando
            ncargando.Show()
            ncargando.MonoFlat_Label1.Text = "Consultando Promesa"
            ncargando.TopMost = True
            BackgroundConsultaPromesaPendiente.RunWorkerAsync()

        ElseIf existePromesa = "Notificado" Then
            MessageBox.Show("El crédito cuenta con una notificación pendiente de autorizar")
            Me.Close()
        Else


        End If
    End Sub

    Private Sub PromPago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 Then

            If RadWizard1.Pages.Item(1) Is RadWizard1.SelectedPage Then
                If CheckVencidos.CheckState = CheckState.Checked Then
                    DescuentoPromesa.Maximo = multasParcial
                    DescuentoPromesa.Total = False
                    DescuentoPromesa.ShowDialog()
                    totalParcial = (pagonormalParcial + multasParcial) - descuentoParcial
                    lblDescuentoParcial.Text = FormatCurrency(descuentoParcial, 2)
                    lblTotalParcial.Text = FormatCurrency(totalParcial, 2)
                Else
                    DescuentoPromesa.Maximo = multasTotal
                    DescuentoPromesa.Total = True
                    DescuentoPromesa.ShowDialog()
                    TotalTotal = (pagoNormalTotal + multasTotal) - descuentoTotal
                    lblDescuentoTotal.Text = FormatCurrency(descuentoTotal, 2)
                    lblTotalTotal.Text = FormatCurrency(TotalTotal, 2)
                End If
            End If
        End If
    End Sub

    Private Sub BackgroundPromesaNotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPromesaNotificacion.DoWork
        iniciarconexionempresa()
        Dim consultaCrearPromesa As String

        Dim comandoCrearPromesa As SqlCommand

        If CheckVencidos.CheckState = CheckState.Checked Then
            consultaCrearPromesa = "insert into PromesaDePago values('" & idCredito & "','" & totalParcial & "','" & pagonormalParcial & "','" & multasParcial & "','" & totalParcial & "',0,'" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','" & nmusr & "','E','" & estadoCredito & "','" & subTotalParcial & "','" & descuentoParcial & "',0) SELECT SCOPE_IDENTITY()"
        Else
            consultaCrearPromesa = "insert into PromesaDePago values('" & idCredito & "','" & TotalTotal & "','" & pagoNormalTotal & "','" & multasTotal & "','" & TotalTotal & "',0,'" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','" & nmusr & "','E','" & estadoCredito & "','" & subTotalTotal & "','" & descuentoTotal & "',0) SELECT SCOPE_IDENTITY()"
        End If

        comandoCrearPromesa = New SqlCommand
        comandoCrearPromesa.Connection = conexionempresa
        comandoCrearPromesa.CommandText = consultaCrearPromesa
        idPromesa = comandoCrearPromesa.ExecuteScalar

        If CheckVencidos.CheckState = CheckState.Checked Then
            For Each row As DataGridViewRow In dtVencidos.Rows
                Dim consultaDetallePromesa As String
                Dim comandoDetallePromesa As SqlCommand
                consultaDetallePromesa = "insert into DetallePromesa values('" & idPromesa & "','" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "','" & row.Cells(7).Value & "','" & estadoCredito & "')"
                comandoDetallePromesa = New SqlCommand
                comandoDetallePromesa.Connection = conexionempresa
                comandoDetallePromesa.CommandText = consultaDetallePromesa
                comandoDetallePromesa.ExecuteNonQuery()


                Dim consultaActualizaCalConvenio As String
                Dim comandoActualizaCalConvenios As SqlCommand
                Select Case estadoCredito
                    Case "C"
                        consultaActualizaCalConvenio = "Update calendarioConveniossac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"


                    Case "R"
                        consultaActualizaCalConvenio = "Update calendarioReestructurasSac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                    Case Else
                        consultaActualizaCalConvenio = "Update calendarioNormal set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                End Select
                comandoActualizaCalConvenios = New SqlCommand
                comandoActualizaCalConvenios.Connection = conexionempresa
                comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio
                comandoActualizaCalConvenios.ExecuteNonQuery()

            Next
        Else
            For Each row As DataGridViewRow In dtTotal.Rows
                Dim consultaDetallePromesa As String
                Dim comandoDetallePromesa As SqlCommand
                consultaDetallePromesa = "insert into DetallePromesa values('" & idPromesa & "','" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "','" & row.Cells(7).Value & "','" & estadoCredito & "')"
                comandoDetallePromesa = New SqlCommand
                comandoDetallePromesa.Connection = conexionempresa
                comandoDetallePromesa.CommandText = consultaDetallePromesa
                comandoDetallePromesa.ExecuteNonQuery()
                Dim consultaActualizaCalConvenio As String
                Dim comandoActualizaCalConvenios As SqlCommand
                Select Case estadoCredito
                    Case "C"
                        consultaActualizaCalConvenio = "Update calendarioConveniossac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"


                    Case "R"
                        consultaActualizaCalConvenio = "Update calendarioReestructurasSac set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                    Case Else
                        consultaActualizaCalConvenio = "Update calendarioNormal set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"
                End Select
                comandoActualizaCalConvenios = New SqlCommand
                comandoActualizaCalConvenios.Connection = conexionempresa
                comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio
                comandoActualizaCalConvenios.ExecuteNonQuery()


            Next
        End If

    End Sub

    Private Sub BackgroundPromesaNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPromesaNotificacion.RunWorkerCompleted
        ncargando.Close()
        CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
        CrearNotificacionDescuentoPromesa.ShowDialog()

        If creada Then
            Task.Factory.StartNew(Sub()
                                      Dim comandoActualizaPromesa As SqlCommand
                                      Dim consultaActualizaPromesa As String
                                      consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                      comandoActualizaPromesa = New SqlCommand
                                      comandoActualizaPromesa.Connection = conexionempresa
                                      comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                      comandoActualizaPromesa.ExecuteNonQuery()


                                  End Sub)
            Me.Close()
        Else
            If MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
                CrearNotificacionDescuentoPromesa.ShowDialog()
                If creada Then
                    Task.Factory.StartNew(Sub()
                                              Dim comandoActualizaPromesa As SqlCommand
                                              Dim consultaActualizaPromesa As String
                                              consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                              comandoActualizaPromesa = New SqlCommand
                                              comandoActualizaPromesa.Connection = conexionempresa
                                              comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                              comandoActualizaPromesa.ExecuteNonQuery()


                                          End Sub)
                    Me.Close()
                Else
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde")
                    Me.Close()

                End If
            Else
                Me.Close()
            End If

        End If


    End Sub

    Private Sub RadWizard1_Cancel(sender As Object, e As EventArgs) Handles RadWizard1.Cancel
        Me.Close()

    End Sub

    Private Sub BackgroundConsultaPromesaPendiente_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultaPromesaPendiente.DoWork
        iniciarconexionempresa()
        Dim consultaPromesa As String
        consultaPromesa = "select id from promesadepago where idcredito = '" & idCredito & "' and estado = 'E' and notificado = 0"
        Dim comandoPromesa As SqlCommand
        comandoPromesa = New SqlCommand
        comandoPromesa.Connection = conexionempresa
        comandoPromesa.CommandText = consultaPromesa
        idPromesa = comandoPromesa.ExecuteScalar

    End Sub

    Private Sub BackgroundConsultaPromesaPendiente_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultaPromesaPendiente.RunWorkerCompleted
        ncargando.Close()
        CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
        CrearNotificacionDescuentoPromesa.ShowDialog()

        If creada Then
            Task.Factory.StartNew(Sub()
                                      Dim comandoActualizaPromesa As SqlCommand
                                      Dim consultaActualizaPromesa As String
                                      consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                      comandoActualizaPromesa = New SqlCommand
                                      comandoActualizaPromesa.Connection = conexionempresa
                                      comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                      comandoActualizaPromesa.ExecuteNonQuery()


                                  End Sub)
            Me.Close()
        Else
            If MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
                CrearNotificacionDescuentoPromesa.ShowDialog()
                If creada Then
                    Task.Factory.StartNew(Sub()
                                              Dim comandoActualizaPromesa As SqlCommand
                                              Dim consultaActualizaPromesa As String
                                              consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                              comandoActualizaPromesa = New SqlCommand
                                              comandoActualizaPromesa.Connection = conexionempresa
                                              comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                              comandoActualizaPromesa.ExecuteNonQuery()


                                          End Sub)
                    Me.Close()
                Else
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde")
                    Me.Close()

                End If
            Else
                Me.Close()
            End If

        End If
    End Sub
End Class