Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ReporteLegal

    Dim dataAbogados As DataSet
    'Dim dataPromotores As DataSet
    Dim adapterAbogados As SqlDataAdapter

    'Dim adapterPromotores As SqlDataAdapter
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
    Private Sub ReporteLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboFiltro.SelectedIndex = 0
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        BackgroundAbogados.RunWorkerAsync()

    End Sub

    Private Sub BackgroundAbogados_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundAbogados.DoWork
        iniciarconexionempresa()
        Dim consulta As String
        consulta = "Select id,nombre from empleados where tipo = 'L'"
        adapterAbogados = New SqlDataAdapter(consulta, conexionempresa)
        dataAbogados = New DataSet
        adapterAbogados.Fill(dataAbogados)
    End Sub

    Private Sub BackgroundAbogados_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundAbogados.RunWorkerCompleted
        'BackgroundPromotores.RunWorkerAsync()
        Cargando.Close()
    End Sub

    Private Sub BackgroundPromotores_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPromotores.DoWork
        'iniciarconexionempresa()
        'Dim consulta As String
        'consulta = "Select id,nombre from empleados where tipo = 'P'"
        'adapterPromotores = New SqlDataAdapter(consulta, conexionempresa)
        'dataPromotores = New DataSet
        'adapterPromotores.Fill(dataPromotores)
    End Sub

    Private Sub ComboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFiltro.SelectedIndexChanged
        Select Case ComboFiltro.Text
            Case "Todos"
                '  txtnombre.Enabled = False
                ComboElección.Items.Clear()
                ComboElección.Enabled = False

            Case "Abogado"
                '  txtnombre.Enabled = True
                ComboElección.Enabled = True
                ComboElección.Items.Clear()

                ComboElección.Items.Add("Todos")
                For Each row As DataRow In dataAbogados.Tables(0).Rows

                    ComboElección.Items.Add(row("nombre"))
                Next
                ComboElección.SelectedIndex = 0
        End Select
    End Sub

    Private Sub BackgroundPromotores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPromotores.RunWorkerCompleted
        'Cargando.Close()
    End Sub

    Private Function ConsultarId(nombre As String) As Integer
        Dim idEmpleado As Integer
        Select Case ComboFiltro.Text
            Case "Abogado"
                For Each row As DataRow In dataAbogados.Tables(0).Rows
                    If row("nombre").ToString = ComboElección.Text Then
                        idEmpleado = Val(row("id").ToString)
                        Exit For
                    End If
                Next
        End Select
        Return idEmpleado
    End Function

    Private Sub BackgroundConsulta_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsulta.DoWork
        iniciarconexionempresa()
        Dim consulta As String

        Dim idEmpleado As Integer
        idEmpleado = ConsultarId(ComboElección.Text)
        Select Case ComboFiltro.Text
            Case "Abogado"
                If ComboElección.Text = "Todos" Then
                    consulta = "select leg.id,leg.Nombre,emp.Nombre as Abogado,Credito,Moratorios,DeudaAP,TotalDeuda,leg.Estado,
	case when exists (select concepto from GestionesLegales where idCredito=leg.id)
	then (select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc)
	else '' end as UltimaGestion,
Juzgado,NoExpediente,EtapaProcesal,Actuario,
	ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0)Gastos
,leg.Fecha,ISNULL(MontoConvenio,0)MontoConvenio,
case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end as Abonado,
case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end as Pendiente
from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
where leg.Estado='A' or leg.Estado='C'"

                Else

                    consulta = "select leg.id,leg.Nombre,emp.Nombre as Abogado,Credito,Moratorios,DeudaAP,TotalDeuda,leg.Estado,
	case when exists (select concepto from GestionesLegales where idCredito=leg.id)
	then (select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc)
	else '' end as UltimaGestion,
Juzgado,NoExpediente,EtapaProcesal,Actuario,
	ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0)Gastos
,leg.Fecha,ISNULL(MontoConvenio,0)MontoConvenio,
case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end as Abonado,
case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end as Pendiente
from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
where (leg.Estado='A' or leg.Estado='C') and leg.idGestorLegal=" & idEmpleado & ""
                End If

            Case "Todos"
                consulta = "select leg.id,leg.Nombre,emp.Nombre as Abogado,Credito,Moratorios,DeudaAP,TotalDeuda,leg.Estado,
	case when exists (select concepto from GestionesLegales where idCredito=leg.id)
	then (select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc)
	else '' end as UltimaGestion,
Juzgado,NoExpediente,EtapaProcesal,Actuario,
	ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0)Gastos
,leg.Fecha,ISNULL(MontoConvenio,0)MontoConvenio,
case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end as Abonado,
case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end as Pendiente
from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
where leg.Estado='A' or leg.Estado='C'"
        End Select


        adapterConsulta = New SqlDataAdapter(consulta, conexionempresa)
        dataConsulta = New DataTable
        adapterConsulta.Fill(dataConsulta)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuThinButton22.Enabled = False
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Consultando"
        Cargando.TopMost = True
        BackgroundConsulta.RunWorkerAsync()
    End Sub

    Private Sub BackgroundConsulta_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsulta.RunWorkerCompleted
        dtimpuestos.DataSource = dataConsulta
        Cargando.Close()
        BunifuThinButton22.Enabled = True
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Exportando a Excel"
        Cargando.TopMost = True
        BackgroundExcel.RunWorkerAsync()
    End Sub

    Private Sub BackgroundExcel_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundExcel.DoWork
        nuevolibro()
        GridAExcel(dtimpuestos)
    End Sub

    Private Sub BackgroundExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundExcel.RunWorkerCompleted
        Cargando.Close()
        cerrarlibro()

    End Sub

    Private Sub CreditosEnMora_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        BunifuThinButton22.Location = New Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reportes.Panel1.Visible = False
        Reportes.RadPanorama1.Visible = True
    End Sub
End Class