Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class PagosHoy
    Dim adapterPagos As SqlDataAdapter
    Dim dataPagos As DataTable
    Dim ncargando As Cargando

    Private Sub PagosHoy_Load(sender As Object, e As EventArgs) Handles Me.Load
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Cargando Información"
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim consultaPagos As String
        consultaPagos = "select calendarionormal.id_credito as 'id Crédito',credito.nombre as Nombre,calendarionormal.monto as Monto,calendarionormal.interes as Interés,calendarionormal.abonado as Abonado,calendarionormal.pendiente As Pendiente,calendarionormal.Npago as 'No. de Pago',( case when calendarionormal.Abonado < (calendarionormal.Pendiente + calendarionormal.monto) and calendarionormal.abonado > 0 then 
'Abonado'
when Abonado = 0 then
'Sin pagar'
else
'Pagado'
END 
) AS Estado,credito.estado as 'Estado crédito' 
 from calendarionormal inner join credito on calendarionormal.id_credito = credito.id where credito.estado = 'A' and calendarionormal.fechapago >= '" & Now.Date.ToString("yyyy-MM-dd") & "' and calendarionormal.fechapago <= '" & Now.Date.ToString("yyyy-MM-dd") & "' union select credito.id,credito.nombre,calendarioconveniossac.monto,calendarioconveniossac.interes,calendarioconveniossac.abonado,calendarioconveniossac.pendiente,calendarioconveniossac.Npago,( case when calendarioconveniossac.Abonado < (calendarioconveniossac.Pendiente + calendarioconveniossac.monto) and calendarioconveniossac.abonado > 0 then 
'Abonado'
when Abonado = 0 then
'Sin pagar'
else
'Pagado'
END 
) AS Estado, credito.estado as 'Estado Crédito' 
 from calendarioconveniossac inner join conveniossac on calendarioconveniossac.idconvenio = conveniossac.id inner join credito on conveniossac.idcredito = credito.id where credito.estado = 'C' and calendarioconveniossac.fechapago >= '" & Now.Date.ToString("yyyy-MM-dd") & "' and calendarioconveniossac.fechapago <= '" & Now.Date.ToString("yyyy-MM-dd") & "' "
        adapterPagos = New SqlDataAdapter(consultaPagos, conexionempresa)
        dataPagos = New DataTable
        adapterPagos.Fill(dataPagos)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dtdatos.DataSource = dataPagos
        ncargando.Close()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Cargando Información"
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundExcel_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundExcel.DoWork
        nuevolibro()
        GridAExcel(dtdatos)
    End Sub

    Private Sub BackgroundExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundExcel.RunWorkerCompleted
        ncargando.Close()
        cerrarlibro()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Exportando a Excel"
        BackgroundExcel.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reportes.Panel1.Visible = False
        Reportes.RadPanorama1.Visible = True
    End Sub
End Class