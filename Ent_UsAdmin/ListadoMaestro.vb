Imports System.Data.SqlClient

Public Class ListadoMaestro
    Dim ConsultaListado As String
    Private Sub ListadoMaestro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        cargarListado()
        txtnombre.Select()

    End Sub
    Public Sub cargarListado()
        Dim nCargando As New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Cargando Datos..."
        nCargando.TopMost = True

        dtimpuestos.Rows.Clear()
        Try

            iniciarconexionempresa()

            ConsultaListado = "DECLARE @Listado TABLE (id int, Integrantes CHAR(2), Nombre varchar(MAX), Estado char(1), Monto money, plazo int, Promotor varchar(MAX),
	Gestor varchar(MAX), Telefono varchar(30), Celular varchar(30), Domicilio varchar(MAX) );
DECLARE @idCredito INT, @NombreCred VARCHAR(MAX), @NombreClie VARCHAR, @Integrantes INT;
DECLARE Nombres CURSOR LOCAL STATIC READ_ONLY FORWARD_ONLY FOR 
SELECT C.id,C.Nombre as NombreCr, Cl.Nombre as NombreCl,C.Integrantes FROM Credito C
inner join Solicitud S on S.id=C.IdSolicitud
inner join DatosSolicitud DS on S.id=DS.IdSolicitud
inner join Clientes Cl on DS.IdCliente=Cl.id
where C.Nombre like '%" & txtnombre.Text & "%' or Cl.Nombre like '%" & txtnombre.Text & "%'
OPEN Nombres
FETCH NEXT FROM Nombres	INTO @idCredito, @NombreCred, @NombreClie, @Integrantes
WHILE (@@FETCH_STATUS=0)
BEGIN

if @Integrantes=1
	begin
	insert into @Listado
	select TOP 1 @idCredito,@Integrantes,@NombreCred,Credito.Estado,Credito.Monto,Credito.Plazo,promotor.Nombre, gestor.nombre,
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
		select TOP 1 @idCredito,@Integrantes,@NombreCred,c.Estado,c.Monto,c.Plazo,promotor.Nombre, gestor.nombre,
		'','',''
		from Credito c
		inner join Solicitud on Solicitud.id=c.IdSolicitud
		inner join DatosSolicitud DS on DS.IdSolicitud=Solicitud.id
		inner join Empleados promotor on promotor.id=c.IdPromotor
		inner join Empleados gestor on gestor.id=c.IdGestor
		where c.id=@idCredito
		insert into @Listado
		Select @idCredito,'-',CONCAT(Cl.Nombre,' ',Cl.ApellidoPaterno,' ',Cl.ApellidoPaterno),C.Estado,
		DS.MontoAutorizado,C.Plazo,'','',DS.Telefono,DS.Celular,CONCAT(DS.Calle,' ',DS.Noext,', ',DS.Noint,', ',DS.Colonia,', ',DS.CodigoPostal)
		from Credito C
		inner join Solicitud on Solicitud.id=C.IdSolicitud
		inner join DatosSolicitud DS on DS.IdSolicitud=Solicitud.id
		inner join Clientes Cl on Cl.id=DS.IdCliente
		where C.id=@idCredito
		end
	end


FETCH NEXT FROM Nombres	INTO @idCredito, @NombreCred, @NombreClie, @Integrantes
END
CLOSE Nombres
DEALLOCATE Nombres
Select * from @Listado"
            Dim ejec = New SqlCommand(ConsultaListado)
            ejec.Connection = conexionempresa

            Dim myreader As SqlDataReader = ejec.ExecuteReader()
            While myreader.Read
                dtimpuestos.Rows.Add(myreader("id"), myreader("Integrantes"), myreader("Nombre"), myreader("Estado"), FormatCurrency(myreader("Monto"), 2), myreader("Plazo"), myreader("Promotor"), myreader("Gestor"), myreader("Telefono"), myreader("Celular"), myreader("Domicilio"))
            End While
            myreader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        nCargando.TopMost = False
        nCargando.Close()
    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarListado()
    End Sub


    Private Sub txtnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarListado()
        End If
    End Sub

End Class