using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConfiaAdmin
{

    public partial class ReporteLegal
    {

        private DataSet dataAbogados;
        private SqlDataAdapter adapterAbogados;
        private DataTable dataConsulta;
        private SqlDataAdapter adapterConsulta;
        private double totalPendiente, pendienteSin, pendienteCon;

        public ReporteLegal()
        {
            InitializeComponent();
        }

        private void ReporteLegal_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ComboFiltro.SelectedIndex = 0;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Cargando Información";
            My.MyProject.Forms.Cargando.TopMost = true;
            txtnombre.Select();
            BackgroundAbogados.RunWorkerAsync();

        }

        private void BackgroundAbogados_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta;
            consulta = "Select id,nombre from empleados where tipo = 'L'";
            adapterAbogados = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataAbogados = new DataSet();
            adapterAbogados.Fill(dataAbogados);
        }

        private void BackgroundAbogados_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
        }

        private void ComboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboFiltro.Text ?? "")
            {
                case "Todos":
                    {
                        ComboElección.Items.Clear();
                        ComboElección.Enabled = false;
                        break;
                    }

                case "Abogado":
                    {
                        ComboElección.Enabled = true;
                        ComboElección.Items.Clear();

                        ComboElección.Items.Add("Todos");
                        foreach (DataRow row in dataAbogados.Tables[0].Rows)

                            ComboElección.Items.Add(row["nombre"]);
                        ComboElección.SelectedIndex = 0;
                        break;
                    }
            }
        }


        private int ConsultarId(string nombre)
        {
            int idEmpleado =0;
            switch (ComboFiltro.Text ?? "")
            {
                case "Abogado":
                    {
                        foreach (DataRow row in dataAbogados.Tables[0].Rows)
                        {
                            if ((row["nombre"].ToString() ?? "") == (ComboElección.Text ?? ""))
                            {
                                idEmpleado = (int)Math.Round(Conversion.Val(row["id"].ToString()));
                                break;
                            }
                        }

                        break;
                    }
            }
            return idEmpleado;
        }

        private void BackgroundConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.iniciarconexionempresa();
            string consulta ="";

            int idEmpleado;
            idEmpleado = ConsultarId(ComboElección.Text);
            switch (ComboFiltro.Text ?? "")
            {
                case "Abogado":
                    {
                        if (ComboElección.Text == "Todos")
                        {
                            consulta = @"DECLARE @Reporte TABLE (orden int NOT NULL IDENTITY(1,1),Id int,Nombre varchar(255),Abogado varchar(2525),Capital money,Moratorios money,[Deuda antes Porcentaje] money,
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
WHERE Nombre LIKE '%" + txtnombre.Text + "%' OR NombreCliente LIKE '%" + txtnombre.Text + @"%'
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
ORDER BY Orden";
                        }

                        else
                        {

                            consulta = @"DECLARE @Reporte TABLE (orden int NOT NULL IDENTITY(1,1),Id int,Nombre varchar(255),Abogado varchar(2525),Capital money,Moratorios money,[Deuda antes Porcentaje] money,
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
where (L.Estado='A' or L.Estado='C') and L.idGestorLegal=" + idEmpleado + @"
)Listado
WHERE Nombre LIKE '%" + txtnombre.Text + "%' OR NombreCliente LIKE '%" + txtnombre.Text + @"%'
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
ORDER BY Orden";
                        }

                        break;
                    }

                case "Todos":
                    {
                        consulta = @"DECLARE @Reporte TABLE (orden int NOT NULL IDENTITY(1,1),Id int,Nombre varchar(255),Abogado varchar(2525),Capital money,Moratorios money,[Deuda antes Porcentaje] money,
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
WHERE Nombre LIKE '%" + txtnombre.Text + "%' OR NombreCliente LIKE '%" + txtnombre.Text + @"%'
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
ORDER BY Orden";
                        break;
                    }
            }


            adapterConsulta = new SqlDataAdapter(consulta, Module1.conexionempresa);
            dataConsulta = new DataTable();
            adapterConsulta.Fill(dataConsulta);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            BunifuThinButton22.Enabled = false;
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundConsulta.RunWorkerAsync();
        }

        private void BackgroundConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtimpuestos.DataSource = dataConsulta;

            dtimpuestos.Columns["Deuda antes Porcentaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtimpuestos.Columns["Última Gestión"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtimpuestos.Columns["Monto Convenio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtimpuestos.Columns["Multas Generadas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtimpuestos.Columns["Multas Pendientes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtimpuestos.Columns["Deuda antes Porcentaje"].Width = 100;
            dtimpuestos.Columns["Última Gestión"].Width = 200;
            dtimpuestos.Columns["Última Gestión"].Resizable = DataGridViewTriState.False;
            dtimpuestos.Columns["Monto Convenio"].Width = 85;
            dtimpuestos.Columns["Multas Generadas"].Width = 85;
            dtimpuestos.Columns["Multas Pendientes"].Width = 85;
            dtimpuestos.Columns["Capital"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Moratorios"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Deuda antes Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Total Deuda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Gastos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Monto Convenio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Multas Generadas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Multas Pendientes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Abonado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["Pendiente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dtimpuestos.Columns["conceptoGestion"].Visible = false;
            for (int col = 0, loopTo = dtimpuestos.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1; col <= loopTo; col++)
                dtimpuestos.Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;


            totalPendiente = 0d;
            pendienteCon = 0d;
            pendienteSin = 0d;

            foreach (DataGridViewRow row in dtimpuestos.Rows)
            {
                totalPendiente = Conversions.ToDouble(Operators.AddObject(totalPendiente, row.Cells["Pendiente"].Value));
                switch (row.Cells["Monto Convenio"].Value)
                {
                    case 0:
                        {
                            pendienteSin = Conversions.ToDouble(Operators.AddObject(pendienteSin, row.Cells["Pendiente"].Value));
                            break;
                        }

                    default:
                        {
                            pendienteCon = Conversions.ToDouble(Operators.AddObject(pendienteCon, row.Cells["Pendiente"].Value));
                            break;
                        }
                }
            }

            MonoFlat_HeaderLabel2.Visible = true;
            MonoFlat_HeaderLabel6.Visible = true;
            MonoFlat_HeaderLabel8.Visible = true;
            lblTotal.Text = Strings.FormatCurrency(totalPendiente);
            lblSinConvenio.Text = Strings.FormatCurrency(pendienteSin);
            lblConConvenio.Text = Strings.FormatCurrency(pendienteCon);
            lblTotal.Visible = true;
            lblConConvenio.Visible = true;
            lblSinConvenio.Visible = true;
            My.MyProject.Forms.Cargando.Close();
            BunifuThinButton22.Enabled = true;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Cargando.Show();
            My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Exportando a Excel";
            My.MyProject.Forms.Cargando.TopMost = true;
            BackgroundExcel.RunWorkerAsync();
        }

        private void BackgroundExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Module1.nuevolibro();
            Module1.GridAExcelLegal(dtimpuestos, 'X');
            var hoja = new Microsoft.Office.Interop.Excel.Worksheet();
            hoja = (Microsoft.Office.Interop.Excel.Worksheet)Module1.exLibro.ActiveSheet;
            hoja.get_Range("R:R").NumberFormat = "DD-MM-YYYY";
            hoja.get_Range("X:X").Delete();
            hoja.get_Range("C2:C2").Select();
            hoja.Application.ActiveWindow.FreezePanes = true;
            hoja.get_Range("A2:A2").Select();
            hoja = null;
        }

        private void BackgroundExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            My.MyProject.Forms.Cargando.Close();
            Module1.cerrarlibro();

        }

        private void CreditosEnMora_Resize(object sender, EventArgs e)
        {
            BunifuThinButton22.Location = new Point(ComboElección.Location.X + ComboElección.Width + 20, ComboElección.Location.Y);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Reportes.Panel1.Visible = false;
            My.MyProject.Forms.Reportes.RadPanorama1.Visible = true;
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BunifuThinButton22.Enabled = false;
                My.MyProject.Forms.Cargando.Show();
                My.MyProject.Forms.Cargando.MonoFlat_Label1.Text = "Consultando";
                My.MyProject.Forms.Cargando.TopMost = true;
                BackgroundConsulta.RunWorkerAsync();
            }
        }

        private void dtimpuestos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex > -1 & e.ColumnIndex == dtimpuestos.Columns["Última Gestión"].Index)
            {
                var dataGridViewRowHover = dtimpuestos.Rows[e.RowIndex];
                e.ToolTipText = Conversions.ToString(dataGridViewRowHover.Cells["conceptoGestion"].Value);
            }
        }

        private void dtimpuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.ToString() != "-1")
            {
                if (Conversions.ToBoolean(Operators.AndObject(e.ColumnIndex == dtimpuestos.Columns["Última Gestión"].Index, Operators.ConditionalCompareObjectNotEqual(dtimpuestos.Rows[e.RowIndex].Cells["Última Gestión"].Value, "", false))))
                {
                    // MessageBox.Show("Aquí aparecería la última gestión de " & dtimpuestos.Rows(e.RowIndex).Cells("Nombre").Value)
                    My.MyProject.Forms.GestionesLegal.idLegal = Conversions.ToInteger(dtimpuestos.Rows[e.RowIndex].Cells[0].Value);
                    My.MyProject.Forms.GestionesLegal.Show();
                }
            }
        }
    }
}