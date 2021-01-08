Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ReporteLegal

    Dim dataAbogados As DataSet
    Dim adapterAbogados As SqlDataAdapter
    Dim dataConsulta As DataTable
    Dim adapterConsulta As SqlDataAdapter
    Dim totalPendiente, pendienteSin, pendienteCon As Double

    Private Sub ReporteLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ComboFiltro.SelectedIndex = 0
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        Cargando.TopMost = True
        txtnombre.Select()
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
        Cargando.Close()
    End Sub

    Private Sub ComboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFiltro.SelectedIndexChanged
        Select Case ComboFiltro.Text
            Case "Todos"
                ComboElección.Items.Clear()
                ComboElección.Enabled = False

            Case "Abogado"
                ComboElección.Enabled = True
                ComboElección.Items.Clear()

                ComboElección.Items.Add("Todos")
                For Each row As DataRow In dataAbogados.Tables(0).Rows

                    ComboElección.Items.Add(row("nombre"))
                Next
                ComboElección.SelectedIndex = 0
        End Select
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
                    consulta = "DECLARE @Reporte TABLE (orden int NOT NULL IDENTITY(1,1),Id int,Nombre varchar(255),Abogado varchar(2525),Capital money,Moratorios money,[Deuda antes Porcentaje] money,
	[Total Deuda] money,Estado char(1), Dirección varchar (MAX),Teléfono varchar(20),Celular varchar(20), [Última Gestión] varchar(100),
	Juzgado varchar(50),[No. de Expediente]varchar(45),[Etapa Procesal]varchar(100),Actuario varchar(50),Gastos money,Fecha DATE,
	[Monto Convenio]money,[Multas Generadas]money,[Multas Pendientes]money,Abonado money,Pendiente money, conceptoGestion varchar(MAX));
DECLARE @idLegal int,@Integrantes int,@NombreLegal varchar(255),@NombreIntegrante varchar(255);
DECLARE Nombres CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY FOR
SELECT * FROM
(SELECT L.id,L.Integrantes,L.Nombre,CASE WHEN L.idSolicitud=0 THEN DL.Nombre WHEN L.idSolicitud IS NULL THEN DL.Nombre ELSE CONCAT(Cl.Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) END AS NombreCliente
FROM Legales L
LEFT JOIN DireccionesLegales DL on L.id=DL.idLegal
LEFT JOIN DatosSolicitud DS on DS.IdSolicitud=L.idSolicitud
LEFT JOIN Clientes Cl on Cl.id=DS.IdCliente
where (L.Estado='A' or L.Estado='C')
)Listado
WHERE Nombre LIKE '%" & txtnombre.Text & "%' OR NombreCliente LIKE '%" & txtnombre.Text & "%'
order by Nombre,NombreCliente
OPEN Nombres
FETCH NEXT FROM Nombres INTO @idLegal,@Integrantes,@NombreLegal,@NombreIntegrante
WHILE (@@FETCH_STATUS=0)
BEGIN

IF @Integrantes=1
	begin
	insert into @Reporte
	--Aquí va la consulta del reporte
	select top 1 leg.id,leg.Nombre,emp.Nombre as Abogado,format(Credito,'C','es-mx')[Capital],format(Moratorios,'C','es-mx')[Moratorios],format(DeudaAP,'C','es-mx')[Deuda antes Porcentaje],format(TotalDeuda,'C','es-mx')[Total Deuda],leg.Estado,
	/* aquí van la dirección y el teléfono*/
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select CONCAT(Direccion,', ',Colonia,', ',Municipio) from DireccionesLegales where idLegal=leg.id)
	else (select CONCAT(Calle,' ',Noext,', ',Noint,', ',CodigoPostal,', ',Colonia,', ',Ciudad) from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Dirección,
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select Telefono from DireccionesLegales where idLegal=leg.id)
	else (select Telefono from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Teléfono,
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select Celular from DireccionesLegales where idLegal=leg.id)
	else (select Celular from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Celular,
	case when exists (select concepto from GestionesLegales where idCredito=leg.id)
	then (select top 1 case when len(Concepto)<=50 then Concepto else left(concepto,47) + '...' end from GestionesLegales where idCredito=leg.id order by id desc)
	else '' end as [Última Gestión],
	Juzgado,NoExpediente[No. de Expediente],EtapaProcesal[Etapa Procesal],Actuario,
	format(ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0),'C','es-mx')Gastos
	,Left(leg.Fecha,10)[Fecha],format(ISNULL(MontoConvenio,0),'C','es-mx')[Monto Convenio],
	format(isnull((select SUM(interes) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Generadas],
	format(isnull((select SUM(case when Estado='V' and Abonado<Interes then Interes-Abonado else 0 end) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Pendientes],
	format(case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end,'C','es-mx')Abonado,
	format(case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end,'C','es-mx')[Pendiente],
	isnull((select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc),'')conceptoGestion
	from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
	where leg.id=@idLegal
	end
ELSE
	begin
	if not exists(select id from @Reporte where Id=@idLegal)
		begin
		--Ponemos el nombre y todos los datos del grupo
		insert into @Reporte
		select top 1 leg.id,CONCAT('(GRUPO) ',leg.Nombre),emp.Nombre as Abogado,format(Credito,'C','es-mx')[Capital],format(Moratorios,'C','es-mx')[Moratorios],format(DeudaAP,'C','es-mx')[Deuda antes Porcentaje],format(TotalDeuda,'C','es-mx')[Total Deuda],leg.Estado,
		'-' as Dirección,'-' as Teléfono,'-' as Celular,
		case when exists (select concepto from GestionesLegales where idCredito=leg.id)
		then (select top 1 case when len(Concepto)<=50 then Concepto else left(concepto,47) + '...' end from GestionesLegales where idCredito=leg.id order by id desc)
		else '' end as [Última Gestión],
		Juzgado,NoExpediente[No. de Expediente],EtapaProcesal[Etapa Procesal],Actuario,
		format(ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0),'C','es-mx')Gastos
		,Left(leg.Fecha,10)[Fecha],format(ISNULL(MontoConvenio,0),'C','es-mx')[Monto Convenio],
		format(isnull((select SUM(interes) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Generadas],
		format(isnull((select SUM(case when Estado='V' and Abonado<Interes then Interes-Abonado else 0 end) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Pendientes],
		format(case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end,'C','es-mx')Abonado,
		format(case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end,'C','es-mx')[Pendiente],
		isnull((select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc),'')conceptoGestion
		from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
		where leg.id=@idLegal
		--Agregamos los integrantes del grupo, con su dirección y teléfono
		insert into @Reporte
		SELECT L.id,CASE WHEN L.idSolicitud=0 THEN DL.Nombre WHEN L.idSolicitud IS NULL THEN DL.Nombre ELSE CONCAT(Cl.Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) END AS NombreCliente ,emp.Nombre as Abogado,
		0,0,0,0,L.Estado,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN CONCAT(DL.Direccion,', ',DL.Colonia,', ',DL.Municipio)
		ELSE CONCAT(DS.Calle,' ',DS.Noext,', ',DS.Noint,', ',DS.CodigoPostal,', ',DS.Colonia,', ',DS.Ciudad) END AS Dirección,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN DL.Telefono ELSE DS.Telefono END AS Teléfono,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN DL.Celular ELSE DS.Celular END AS Celular,
		'','','','','',0,'',0,0,0,0,0,''
		FROM Legales L
		INNER JOIN Empleados emp on emp.id=L.idGestorLegal
		LEFT JOIN DireccionesLegales DL on L.id=DL.idLegal
		LEFT JOIN DatosSolicitud DS on DS.IdSolicitud=L.idSolicitud
		LEFT JOIN Clientes Cl on Cl.id=DS.IdCliente
		where L.id=@idLegal
		order by L.Nombre,NombreCliente

		end
	end

FETCH NEXT FROM Nombres INTO @idLegal,@Integrantes,@NombreLegal,@NombreIntegrante
END
CLOSE Nombres
DEALLOCATE Nombres
SELECT Id,Nombre,Abogado,format(Capital,'C','es-mx')Capital,format(Moratorios,'C','es-mx')Moratorios,format([Deuda antes Porcentaje],'C','es-mx')[Deuda antes Porcentaje],format([Total Deuda],'C','es-mx')[Total Deuda],Estado,Dirección,Teléfono,Celular,[Última Gestión],
Juzgado,[No. de Expediente],[Etapa Procesal],Actuario,format(Gastos,'C','es-mx')Gastos,CAST(CONVERT(date,Fecha,102) AS char(10))Fecha,format([Monto Convenio],'C','es-mx')[Monto Convenio],format([Multas Generadas],'C','es-mx')[Multas Generadas],format([Multas Pendientes],'C','es-mx')[Multas Pendientes],
format(Abonado,'C','es-mx')Abonado,format(Pendiente,'C','es-mx')Pendiente,conceptoGestion
FROM @Reporte
ORDER BY Orden"

                Else

                    consulta = "DECLARE @Reporte TABLE (orden int NOT NULL IDENTITY(1,1),Id int,Nombre varchar(255),Abogado varchar(2525),Capital money,Moratorios money,[Deuda antes Porcentaje] money,
	[Total Deuda] money,Estado char(1), Dirección varchar (MAX),Teléfono varchar(20),Celular varchar(20), [Última Gestión] varchar(100),
	Juzgado varchar(50),[No. de Expediente]varchar(45),[Etapa Procesal]varchar(100),Actuario varchar(50),Gastos money,Fecha DATE,
	[Monto Convenio]money,[Multas Generadas]money,[Multas Pendientes]money,Abonado money,Pendiente money, conceptoGestion varchar(MAX));
DECLARE @idLegal int,@Integrantes int,@NombreLegal varchar(255),@NombreIntegrante varchar(255);
DECLARE Nombres CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY FOR
SELECT * FROM
(SELECT L.id,L.Integrantes,L.Nombre,CASE WHEN L.idSolicitud=0 THEN DL.Nombre WHEN L.idSolicitud IS NULL THEN DL.Nombre ELSE CONCAT(Cl.Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) END AS NombreCliente
FROM Legales L
LEFT JOIN DireccionesLegales DL on L.id=DL.idLegal
LEFT JOIN DatosSolicitud DS on DS.IdSolicitud=L.idSolicitud
LEFT JOIN Clientes Cl on Cl.id=DS.IdCliente
where (L.Estado='A' or L.Estado='C') and L.idGestorLegal=" & idEmpleado & "
)Listado
WHERE Nombre LIKE '%" & txtnombre.Text & "%' OR NombreCliente LIKE '%" & txtnombre.Text & "%'
order by Nombre,NombreCliente
OPEN Nombres
FETCH NEXT FROM Nombres INTO @idLegal,@Integrantes,@NombreLegal,@NombreIntegrante
WHILE (@@FETCH_STATUS=0)
BEGIN

IF @Integrantes=1
	begin
	insert into @Reporte
	--Aquí va la consulta del reporte
	select top 1 leg.id,leg.Nombre,emp.Nombre as Abogado,format(Credito,'C','es-mx')[Capital],format(Moratorios,'C','es-mx')[Moratorios],format(DeudaAP,'C','es-mx')[Deuda antes Porcentaje],format(TotalDeuda,'C','es-mx')[Total Deuda],leg.Estado,
	/* aquí van la dirección y el teléfono*/
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select CONCAT(Direccion,', ',Colonia,', ',Municipio) from DireccionesLegales where idLegal=leg.id)
	else (select CONCAT(Calle,' ',Noext,', ',Noint,', ',CodigoPostal,', ',Colonia,', ',Ciudad) from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Dirección,
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select Telefono from DireccionesLegales where idLegal=leg.id)
	else (select Telefono from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Teléfono,
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select Celular from DireccionesLegales where idLegal=leg.id)
	else (select Celular from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Celular,
	case when exists (select concepto from GestionesLegales where idCredito=leg.id)
	then (select top 1 case when len(Concepto)<=50 then Concepto else left(concepto,47) + '...' end from GestionesLegales where idCredito=leg.id order by id desc)
	else '' end as [Última Gestión],
	Juzgado,NoExpediente[No. de Expediente],EtapaProcesal[Etapa Procesal],Actuario,
	format(ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0),'C','es-mx')Gastos
	,Left(leg.Fecha,10)[Fecha],format(ISNULL(MontoConvenio,0),'C','es-mx')[Monto Convenio],
	format(isnull((select SUM(interes) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Generadas],
	format(isnull((select SUM(case when Estado='V' and Abonado<Interes then Interes-Abonado else 0 end) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Pendientes],
	format(case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end,'C','es-mx')Abonado,
	format(case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end,'C','es-mx')[Pendiente],
	isnull((select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc),'')conceptoGestion
	from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
	where leg.id=@idLegal
	end
ELSE
	begin
	if not exists(select id from @Reporte where Id=@idLegal)
		begin
		--Ponemos el nombre y todos los datos del grupo
		insert into @Reporte
		select top 1 leg.id,CONCAT('(GRUPO) ',leg.Nombre),emp.Nombre as Abogado,format(Credito,'C','es-mx')[Capital],format(Moratorios,'C','es-mx')[Moratorios],format(DeudaAP,'C','es-mx')[Deuda antes Porcentaje],format(TotalDeuda,'C','es-mx')[Total Deuda],leg.Estado,
		'-' as Dirección,'-' as Teléfono,'-' as Celular,
		case when exists (select concepto from GestionesLegales where idCredito=leg.id)
		then (select top 1 case when len(Concepto)<=50 then Concepto else left(concepto,47) + '...' end from GestionesLegales where idCredito=leg.id order by id desc)
		else '' end as [Última Gestión],
		Juzgado,NoExpediente[No. de Expediente],EtapaProcesal[Etapa Procesal],Actuario,
		format(ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0),'C','es-mx')Gastos
		,Left(leg.Fecha,10)[Fecha],format(ISNULL(MontoConvenio,0),'C','es-mx')[Monto Convenio],
		format(isnull((select SUM(interes) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Generadas],
		format(isnull((select SUM(case when Estado='V' and Abonado<Interes then Interes-Abonado else 0 end) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Pendientes],
		format(case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end,'C','es-mx')Abonado,
		format(case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end,'C','es-mx')[Pendiente],
		isnull((select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc),'')conceptoGestion
		from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
		where leg.id=@idLegal
		--Agregamos los integrantes del grupo, con su dirección y teléfono
		insert into @Reporte
		SELECT L.id,CASE WHEN L.idSolicitud=0 THEN DL.Nombre WHEN L.idSolicitud IS NULL THEN DL.Nombre ELSE CONCAT(Cl.Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) END AS NombreCliente ,emp.Nombre as Abogado,
		0,0,0,0,L.Estado,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN CONCAT(DL.Direccion,', ',DL.Colonia,', ',DL.Municipio)
		ELSE CONCAT(DS.Calle,' ',DS.Noext,', ',DS.Noint,', ',DS.CodigoPostal,', ',DS.Colonia,', ',DS.Ciudad) END AS Dirección,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN DL.Telefono ELSE DS.Telefono END AS Teléfono,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN DL.Celular ELSE DS.Celular END AS Celular,
		'','','','','',0,'',0,0,0,0,0,''
		FROM Legales L
		INNER JOIN Empleados emp on emp.id=L.idGestorLegal
		LEFT JOIN DireccionesLegales DL on L.id=DL.idLegal
		LEFT JOIN DatosSolicitud DS on DS.IdSolicitud=L.idSolicitud
		LEFT JOIN Clientes Cl on Cl.id=DS.IdCliente
		where L.id=@idLegal
		order by L.Nombre,NombreCliente

		end
	end

FETCH NEXT FROM Nombres INTO @idLegal,@Integrantes,@NombreLegal,@NombreIntegrante
END
CLOSE Nombres
DEALLOCATE Nombres
SELECT Id,Nombre,Abogado,format(Capital,'C','es-mx')Capital,format(Moratorios,'C','es-mx')Moratorios,format([Deuda antes Porcentaje],'C','es-mx')[Deuda antes Porcentaje],format([Total Deuda],'C','es-mx')[Total Deuda],Estado,Dirección,Teléfono,Celular,[Última Gestión],
Juzgado,[No. de Expediente],[Etapa Procesal],Actuario,format(Gastos,'C','es-mx')Gastos,CAST(CONVERT(date,Fecha,102) AS char(10))Fecha,format([Monto Convenio],'C','es-mx')[Monto Convenio],format([Multas Generadas],'C','es-mx')[Multas Generadas],format([Multas Pendientes],'C','es-mx')[Multas Pendientes],
format(Abonado,'C','es-mx')Abonado,format(Pendiente,'C','es-mx')Pendiente,conceptoGestion
FROM @Reporte
ORDER BY Orden"
                End If

            Case "Todos"
                consulta = "DECLARE @Reporte TABLE (orden int NOT NULL IDENTITY(1,1),Id int,Nombre varchar(255),Abogado varchar(2525),Capital money,Moratorios money,[Deuda antes Porcentaje] money,
	[Total Deuda] money,Estado char(1), Dirección varchar (MAX),Teléfono varchar(20),Celular varchar(20), [Última Gestión] varchar(100),
	Juzgado varchar(50),[No. de Expediente]varchar(45),[Etapa Procesal]varchar(100),Actuario varchar(50),Gastos money,Fecha DATE,
	[Monto Convenio]money,[Multas Generadas]money,[Multas Pendientes]money,Abonado money,Pendiente money, conceptoGestion varchar(MAX));
DECLARE @idLegal int,@Integrantes int,@NombreLegal varchar(255),@NombreIntegrante varchar(255);
DECLARE Nombres CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY FOR
SELECT * FROM
(SELECT L.id,L.Integrantes,L.Nombre,CASE WHEN L.idSolicitud=0 THEN DL.Nombre WHEN L.idSolicitud IS NULL THEN DL.Nombre ELSE CONCAT(Cl.Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) END AS NombreCliente
FROM Legales L
LEFT JOIN DireccionesLegales DL on L.id=DL.idLegal
LEFT JOIN DatosSolicitud DS on DS.IdSolicitud=L.idSolicitud
LEFT JOIN Clientes Cl on Cl.id=DS.IdCliente
where (L.Estado='A' or L.Estado='C')
)Listado
WHERE Nombre LIKE '%" & txtnombre.Text & "%' OR NombreCliente LIKE '%" & txtnombre.Text & "%'
order by Nombre,NombreCliente
OPEN Nombres
FETCH NEXT FROM Nombres INTO @idLegal,@Integrantes,@NombreLegal,@NombreIntegrante
WHILE (@@FETCH_STATUS=0)
BEGIN

IF @Integrantes=1
	begin
	insert into @Reporte
	--Aquí va la consulta del reporte
	select top 1 leg.id,leg.Nombre,emp.Nombre as Abogado,format(Credito,'C','es-mx')[Capital],format(Moratorios,'C','es-mx')[Moratorios],format(DeudaAP,'C','es-mx')[Deuda antes Porcentaje],format(TotalDeuda,'C','es-mx')[Total Deuda],leg.Estado,
	/* aquí van la dirección y el teléfono*/
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select CONCAT(Direccion,', ',Colonia,', ',Municipio) from DireccionesLegales where idLegal=leg.id)
	else (select CONCAT(Calle,' ',Noext,', ',Noint,', ',CodigoPostal,', ',Colonia,', ',Ciudad) from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Dirección,
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select Telefono from DireccionesLegales where idLegal=leg.id)
	else (select Telefono from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Teléfono,
	case when idSolicitud=0 OR idSolicitud IS NULL
	then (select Celular from DireccionesLegales where idLegal=leg.id)
	else (select Celular from DatosSolicitud where idSolicitud=leg.idSolicitud)end as Celular,
	case when exists (select concepto from GestionesLegales where idCredito=leg.id)
	then (select top 1 case when len(Concepto)<=50 then Concepto else left(concepto,47) + '...' end from GestionesLegales where idCredito=leg.id order by id desc)
	else '' end as [Última Gestión],
	Juzgado,NoExpediente[No. de Expediente],EtapaProcesal[Etapa Procesal],Actuario,
	format(ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0),'C','es-mx')Gastos
	,Left(leg.Fecha,10)[Fecha],format(ISNULL(MontoConvenio,0),'C','es-mx')[Monto Convenio],
	format(isnull((select SUM(interes) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Generadas],
	format(isnull((select SUM(case when Estado='V' and Abonado<Interes then Interes-Abonado else 0 end) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Pendientes],
	format(case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end,'C','es-mx')Abonado,
	format(case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end,'C','es-mx')[Pendiente],
	isnull((select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc),'')conceptoGestion
	from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
	where leg.id=@idLegal
	end
ELSE
	begin
	if not exists(select id from @Reporte where Id=@idLegal)
		begin
		--Ponemos el nombre y todos los datos del grupo
		insert into @Reporte
		select top 1 leg.id,CONCAT('(GRUPO) ',leg.Nombre),emp.Nombre as Abogado,format(Credito,'C','es-mx')[Capital],format(Moratorios,'C','es-mx')[Moratorios],format(DeudaAP,'C','es-mx')[Deuda antes Porcentaje],format(TotalDeuda,'C','es-mx')[Total Deuda],leg.Estado,
		'-' as Dirección,'-' as Teléfono,'-' as Celular,
		case when exists (select concepto from GestionesLegales where idCredito=leg.id)
		then (select top 1 case when len(Concepto)<=50 then Concepto else left(concepto,47) + '...' end from GestionesLegales where idCredito=leg.id order by id desc)
		else '' end as [Última Gestión],
		Juzgado,NoExpediente[No. de Expediente],EtapaProcesal[Etapa Procesal],Actuario,
		format(ISNULL((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0),'C','es-mx')Gastos
		,Left(leg.Fecha,10)[Fecha],format(ISNULL(MontoConvenio,0),'C','es-mx')[Monto Convenio],
		format(isnull((select SUM(interes) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Generadas],
		format(isnull((select SUM(case when Estado='V' and Abonado<Interes then Interes-Abonado else 0 end) from CalendarioLegales where idCredito=leg.id),0),'C','es-mx')[Multas Pendientes],
		format(case when leg.Estado='C' then (select SUM(Abonado) from CalendarioLegales where idCredito=Leg.id) else 0 end,'C','es-mx')Abonado,
		format(case when leg.Estado='C' then (select SUM(Pendiente) from CalendarioLegales where idCredito=Leg.id) when Estado='A' then TotalDeuda+isnull((select SUM(gl.Monto) from Legales inner join GastosLegales gl on gl.idCredito=leg.id where Legales.id=leg.id),0) else 0 end,'C','es-mx')[Pendiente],
		isnull((select top 1 concepto from GestionesLegales where idCredito=leg.id order by id desc),'')conceptoGestion
		from Legales leg inner join Empleados emp on emp.id=leg.idGestorLegal
		where leg.id=@idLegal
		--Agregamos los integrantes del grupo, con su dirección y teléfono
		insert into @Reporte
		SELECT L.id,CASE WHEN L.idSolicitud=0 THEN DL.Nombre WHEN L.idSolicitud IS NULL THEN DL.Nombre ELSE CONCAT(Cl.Nombre,' ',ApellidoPaterno,' ',ApellidoMaterno) END AS NombreCliente ,emp.Nombre as Abogado,
		0,0,0,0,L.Estado,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN CONCAT(DL.Direccion,', ',DL.Colonia,', ',DL.Municipio)
		ELSE CONCAT(DS.Calle,' ',DS.Noext,', ',DS.Noint,', ',DS.CodigoPostal,', ',DS.Colonia,', ',DS.Ciudad) END AS Dirección,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN DL.Telefono ELSE DS.Telefono END AS Teléfono,
		CASE WHEN L.idSolicitud=0 or L.idSolicitud IS NULL
		THEN DL.Celular ELSE DS.Celular END AS Celular,
		'','','','','',0,'',0,0,0,0,0,''
		FROM Legales L
		INNER JOIN Empleados emp on emp.id=L.idGestorLegal
		LEFT JOIN DireccionesLegales DL on L.id=DL.idLegal
		LEFT JOIN DatosSolicitud DS on DS.IdSolicitud=L.idSolicitud
		LEFT JOIN Clientes Cl on Cl.id=DS.IdCliente
		where L.id=@idLegal
		order by L.Nombre,NombreCliente

		end
	end

FETCH NEXT FROM Nombres INTO @idLegal,@Integrantes,@NombreLegal,@NombreIntegrante
END
CLOSE Nombres
DEALLOCATE Nombres
SELECT Id,Nombre,Abogado,format(Capital,'C','es-mx')Capital,format(Moratorios,'C','es-mx')Moratorios,format([Deuda antes Porcentaje],'C','es-mx')[Deuda antes Porcentaje],format([Total Deuda],'C','es-mx')[Total Deuda],Estado,Dirección,Teléfono,Celular,[Última Gestión],
Juzgado,[No. de Expediente],[Etapa Procesal],Actuario,format(Gastos,'C','es-mx')Gastos,CAST(CONVERT(date,Fecha,102) AS char(10))Fecha,format([Monto Convenio],'C','es-mx')[Monto Convenio],format([Multas Generadas],'C','es-mx')[Multas Generadas],format([Multas Pendientes],'C','es-mx')[Multas Pendientes],
format(Abonado,'C','es-mx')Abonado,format(Pendiente,'C','es-mx')Pendiente,conceptoGestion
FROM @Reporte
ORDER BY Orden"
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

        dtimpuestos.Columns("Deuda antes Porcentaje").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtimpuestos.Columns("Última Gestión").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtimpuestos.Columns("Monto Convenio").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtimpuestos.Columns("Multas Generadas").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtimpuestos.Columns("Multas Pendientes").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dtimpuestos.Columns("Deuda antes Porcentaje").Width = 100
        dtimpuestos.Columns("Última Gestión").Width = 200
        dtimpuestos.Columns("Última Gestión").Resizable = DataGridViewTriState.False
        dtimpuestos.Columns("Monto Convenio").Width = 85
        dtimpuestos.Columns("Multas Generadas").Width = 85
        dtimpuestos.Columns("Multas Pendientes").Width = 85
        dtimpuestos.Columns("Capital").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Moratorios").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Deuda antes Porcentaje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Total Deuda").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Gastos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Monto Convenio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Multas Generadas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Multas Pendientes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Abonado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("Pendiente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dtimpuestos.Columns("conceptoGestion").Visible = False
        For col As Integer = 0 To dtimpuestos.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1
            dtimpuestos.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable
        Next


        totalPendiente = 0
        pendienteCon = 0
        pendienteSin = 0

        For Each row As DataGridViewRow In dtimpuestos.Rows
            totalPendiente = totalPendiente + row.Cells("Pendiente").Value
            Select Case row.Cells("Monto Convenio").Value
                Case 0
                    pendienteSin = pendienteSin + row.Cells("Pendiente").Value
                Case Else
                    pendienteCon = pendienteCon + row.Cells("Pendiente").Value
            End Select
        Next

        MonoFlat_HeaderLabel2.Visible = True : MonoFlat_HeaderLabel6.Visible = True : MonoFlat_HeaderLabel8.Visible = True
        lblTotal.Text = FormatCurrency(totalPendiente)
        lblSinConvenio.Text = FormatCurrency(pendienteSin)
        lblConConvenio.Text = FormatCurrency(pendienteCon)
        lblTotal.Visible = True : lblConConvenio.Visible = True : lblSinConvenio.Visible = True
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
        GridAExcelLegal(dtimpuestos, "X")
        Dim hoja As New Microsoft.Office.Interop.Excel.Worksheet
        hoja = exLibro.ActiveSheet
        hoja.Range("R:R").NumberFormat = "DD-MM-YYYY"
        hoja.Range("X:X").Delete()
        hoja.Range("C2:C2").Select()
        hoja.Application.ActiveWindow.FreezePanes = True
        hoja.Range("A2:A2").Select()
        hoja = Nothing
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

    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuThinButton22.Enabled = False
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Consultando"
            Cargando.TopMost = True
            BackgroundConsulta.RunWorkerAsync()
        End If
    End Sub

    Private Sub dtimpuestos_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dtimpuestos.CellToolTipTextNeeded
        If e.RowIndex > -1 And e.ColumnIndex = dtimpuestos.Columns("Última Gestión").Index Then
            Dim dataGridViewRowHover As DataGridViewRow = dtimpuestos.Rows(e.RowIndex)
            e.ToolTipText = dataGridViewRowHover.Cells("conceptoGestion").Value
        End If
    End Sub

    Private Sub dtimpuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellDoubleClick
        If e.RowIndex.ToString() <> "-1" Then
            If e.ColumnIndex = dtimpuestos.Columns("Última Gestión").Index And dtimpuestos.Rows(e.RowIndex).Cells("Última Gestión").Value <> "" Then
                'MessageBox.Show("Aquí aparecería la última gestión de " & dtimpuestos.Rows(e.RowIndex).Cells("Nombre").Value)
                GestionesLegal.idLegal = dtimpuestos.Rows(e.RowIndex).Cells(0).Value
                GestionesLegal.Show()
            End If
        End If
    End Sub
End Class