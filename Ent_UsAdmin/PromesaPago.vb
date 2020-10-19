Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class PromesaPago



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
    Public DeudaAP As Double
    Public DeudaTotal As Double
    Public incluyePorcentaje As Boolean
    Dim capitalPromesa As Double
    Dim moratoriosPromesa As Double
    Dim ncargando As Cargando
    Dim conerror As Boolean
    Public Autorizado As Boolean




    Private Sub BackgroundDatos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundDatos.DoWork
        iniciarconexionempresa()
        Dim comandoCreditoLegal As SqlCommand
        Dim consultaCreditoLegal As String
        Dim readerCreditoLegal As SqlDataReader
        consultaCreditoLegal = "select nombre,id,pagare,AbonadoSinMultas,(pagare-AbonadoSinMultas) as valorCarteraSinMultas,Multas,(AbonadoMultasL + AbonadoMultasV) as AbonadoMultas,(Multas - (AbonadoMultasL+AbonadoMultasV)) as multasPendientes,((Multas-(AbonadoMultasL+AbonadoMultasV))+(pagare-AbonadoSinMultas)) as ValorCarteraConMultas, case when carteratotal.Estado = 'C' then
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
                ' incluyePorcentaje = readerCreditoLegal("incluyeporcentaje")
            End While
        End If
        '  CheckPorcentaje.Checked = incluyePorcentaje
        lblpagare.Text = FormatCurrency(pagare)
        lblAbonadoSmultas.Text = FormatCurrency(abonadoSmultas)
        lblmultas.Text = FormatCurrency(multas)
        lblMultasAbonadas.Text = FormatCurrency(abonadoMultas)

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
        dateFechaLimite.Value = Now
        BackgroundDatos.RunWorkerAsync()

    End Sub








    Private Sub btnGenerarCalendario_Click(sender As Object, e As EventArgs) Handles btnGenerarPromesa.Click
        Autorizacion.tipoAutorizacion = "SatiModCreditosCrearPromesa"
        Autorizacion.ShowDialog()
        If Autorizado Then
            If txtPago.Text < ParteCredito Then
                MessageBox.Show("No puedes ingresar una cantidad menor a " & FormatCurrency(ParteCredito, 2))
            Else
                ncargando = New Cargando
                ncargando.Show()
                ncargando.MonoFlat_Label1.Text = "Creando promesa de pago"
                btnGenerarPromesa.Enabled = False

                BackgroundCreaPromesa.RunWorkerAsync()

            End If
        Else
            MessageBox.Show("No fue autorizado")
        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundCreaPromesa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCreaPromesa.DoWork

        Try
            iniciarconexionempresa()
            Dim comandoPromesa As SqlCommand
            Dim consultaPromesa As String
            moratoriosPromesa = txtPago.Text - ParteCredito
            capitalPromesa = txtPago.Text - moratoriosPromesa

            consultaPromesa = "insert into promesadepago values('" & idCredito & "','" & txtPago.Text & "','" & capitalPromesa & "','" & moratoriosPromesa & "','" & txtPago.Text & "','0','" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','',GETDATE(),convert(char(8), getdate(), 108) ,'" & nmusr & "','A')"

            comandoPromesa = New SqlCommand
            comandoPromesa.Connection = conexionempresa
            comandoPromesa.CommandText = consultaPromesa
            comandoPromesa.ExecuteNonQuery()
            conerror = False
        Catch ex As Exception
            conerror = True
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BackgroundCreaPromesa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCreaPromesa.RunWorkerCompleted
        ncargando.Close()

        If conerror Then
            btnGenerarPromesa.Enabled = True
            MessageBox.Show("Hubo un error, intenta de nuevo")
        Else
            MessageBox.Show("Promesa generada con éxito")
            Me.Close()

        End If

    End Sub
End Class