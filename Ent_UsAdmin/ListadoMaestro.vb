Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ListadoMaestro
    Dim ConsultaListado As String
    Dim nCargando As New Cargando
    Private Sub ListadoMaestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Cargando Datos..."
        nCargando.TopMost = True
        dtimpuestos.Rows.Clear()
        dtimpuestos.ScrollBars = ScrollBars.None
        BackgroundWorker1.RunWorkerAsync()


    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Cargando Datos..."
        nCargando.TopMost = True
        dtimpuestos.Rows.Clear()
        dtimpuestos.ScrollBars = ScrollBars.None
        BackgroundWorker1.RunWorkerAsync()
    End Sub


    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            nCargando = New Cargando
            nCargando.Show()
            nCargando.MonoFlat_Label1.Text = "Cargando Datos..."
            nCargando.TopMost = True
            dtimpuestos.Rows.Clear()
            dtimpuestos.ScrollBars = ScrollBars.None
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try

            iniciarconexionempresa()

            ConsultaListado = "DECLARE @Listado TABLE (id int, Integrantes CHAR(2),[Fecha Entrega] date, Nombre varchar(MAX), Estado char(1), Monto money, plazo int, Promotor varchar(MAX),
	Gestor varchar(MAX), Telefono varchar(30), Celular varchar(30), Domicilio varchar(MAX) );
DECLARE @idCredito INT, @NombreCred VARCHAR(MAX), @NombreClie VARCHAR, @Integrantes INT,@FechaEntrega DATE;
DECLARE Nombres CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY FOR 
SELECT C.id,C.Nombre as NombreCr, Cl.Nombre as NombreCl,C.Integrantes, ISNULL(C.FechaEntrega,'') FROM Credito C
inner join Solicitud S on S.id=C.IdSolicitud
inner join DatosSolicitud DS on S.id=DS.IdSolicitud
inner join Clientes Cl on DS.IdCliente=Cl.id
where C.Nombre like '%" & txtnombre.Text & "%' or Cl.Nombre like '%" & txtnombre.Text & "%'
order by C.Nombre, C.FechaEntrega
OPEN Nombres
FETCH NEXT FROM Nombres	INTO @idCredito, @NombreCred, @NombreClie, @Integrantes, @FechaEntrega
WHILE (@@FETCH_STATUS=0)
BEGIN

if @Integrantes=1
	begin
	insert into @Listado
	select TOP 1 @idCredito,@Integrantes,@FechaEntrega,@NombreCred,Credito.Estado,Credito.Monto,Credito.Plazo,promotor.Nombre, gestor.nombre,
	DS.Telefono,DS.Celular,CONCAT(DS.Calle,' ',DS.Noext,', ',DS.Noint,', ',DS.Colonia,', ',DS.CodigoPostal)Domicilio
	from Credito
	inner join Solicitud on Solicitud.id=Credito.IdSolicitud
	inner join DatosSolicitud DS on DS.IdSolicitud=Solicitud.id
	inner join Empleados promotor on promotor.id=Credito.IdPromotor
	inner join Empleados gestor on gestor.id=Credito.IdGestor
	where Credito.id=@idCredito
	end
else
	begin
	if not exists(select id from @Listado where id=@idCredito)
		begin
		insert into @Listado
		select TOP 1 @idCredito,@Integrantes,@FechaEntrega,@NombreCred,c.Estado,c.Monto,c.Plazo,promotor.Nombre, gestor.nombre,
		'','',''
		from Credito c
		inner join Solicitud on Solicitud.id=c.IdSolicitud
		inner join DatosSolicitud DS on DS.IdSolicitud=Solicitud.id
		inner join Empleados promotor on promotor.id=c.IdPromotor
		inner join Empleados gestor on gestor.id=c.IdGestor
		where c.id=@idCredito
		insert into @Listado
		Select @idCredito,'-',@FechaEntrega,CONCAT(Cl.Nombre,' ',Cl.ApellidoPaterno,' ',Cl.ApellidoPaterno),C.Estado,
		DS.MontoAutorizado,C.Plazo,'','',DS.Telefono,DS.Celular,CONCAT(DS.Calle,' ',DS.Noext,', ',DS.Noint,', ',DS.Colonia,', ',DS.CodigoPostal)
		from Credito C
		inner join Solicitud on Solicitud.id=C.IdSolicitud
		inner join DatosSolicitud DS on DS.IdSolicitud=Solicitud.id
		inner join Clientes Cl on Cl.id=DS.IdCliente
		where C.id=@idCredito
		end
	end


FETCH NEXT FROM Nombres	INTO @idCredito, @NombreCred, @NombreClie, @Integrantes, @FechaEntrega
END
CLOSE Nombres
DEALLOCATE Nombres
Select * from @Listado"
            Dim ejec = New SqlCommand(ConsultaListado)
            ejec.Connection = conexionempresa

            Dim myreader As SqlDataReader = ejec.ExecuteReader()
            While myreader.Read
                dtimpuestos.Rows.Add(myreader("id"), myreader("Integrantes"), FormatDateTime(myreader("Fecha Entrega"), DateFormat.ShortDate), myreader("Nombre"), myreader("Estado"), FormatCurrency(myreader("Monto"), 2), myreader("Plazo"), myreader("Promotor"), myreader("Gestor"), myreader("Telefono"), myreader("Celular"), myreader("Domicilio"))
            End While
            myreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        nCargando.TopMost = False
        nCargando.Close()
        dtimpuestos.ScrollBars = ScrollBars.Both
        txtnombre.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reportes.Panel1.Visible = False
        Reportes.RadPanorama1.Visible = True
    End Sub
End Class