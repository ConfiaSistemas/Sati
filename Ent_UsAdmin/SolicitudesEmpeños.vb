Imports System.Data.SqlClient

Public Class SolicitudesEmpeños

    Dim consultaSolicitudes
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Solicitud_Boleta.Show()
    End Sub

    Private Sub Solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combofiltro.SelectedIndex = 0
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModSolicitudesVer") Then
                VerSolicitudToolStripMenuItem.Visible = True
                VerificarToolStripMenuItem.Visible = True
                SeguimientoToolStripMenuItem.Visible = True
                ToolStripMenuItem2.Visible = True
                VerSolicitudToolStripMenuItem.Visible = True
            Else
                VerSolicitudToolStripMenuItem.Visible = False
                VerificarToolStripMenuItem.Visible = False
                SeguimientoToolStripMenuItem.Visible = False
                ToolStripMenuItem2.Visible = False
                VerSolicitudToolStripMenuItem.Visible = False
            End If


        Next
        cargarSolicitudes()
    End Sub
    Public Sub cargarSolicitudes()
        dtimpuestos.Rows.Clear()
        'Try
        Dim strimpuestos As String
        iniciarconexionempresa()
        If EmpleadoAsignado <> 0 Then

            strimpuestos = "select id,nombre,fecha,monto,estado,tipo, from Solicitudboleta inner join tipo where idpromotor = '" & EmpleadoAsignado & "'  order by nombre"
        Else
            strimpuestos = "select id,nombre,fecha,monto,estado,tipo from Solicitudboleta order by nombre asc"
        End If

        If Combofiltro.Text = "Por Nombre" Then

            If EmpleadoAsignado <> 0 Then
                consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.MontoSugerido,asce.MontoAutorizado,asce.idTipoEmpeño,asce.nombretipo,promotores.Nombre as Promotor,asce.estado from
(select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.Fecha,solicitudBoleta.estado,SolicitudBoleta.MontoSugerido,SolicitudBoleta.MontoAutorizado,SolicitudBoleta.idTipoEmpeño,TiposDeEmpeño.Nombre as nombretipo,SolicitudBoleta.IdPromotor, from SolicitudBoleta inner join TiposDeEmpeño on SolicitudBoleta.idTipoEmpeño = TiposDeEmpeño.id where solicitudBoleta.nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( solicitudBoleta.idpromotor = '" & EmpleadoAsignado & "'  ) asce inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
            Else
                consultaSolicitudes = "select asce.id,asce.nombre,format(asce.Fecha,'yyyy-MM-dd')as fecha,asce.MontoSugerido,asce.MontoAutorizado,asce.idTipoEmpeño,asce.nombretipo,promotores.Nombre as Promotor,asce.estado from
(select SolicitudBoleta.id,SolicitudBoleta.Nombre,SolicitudBoleta.estado,SolicitudBoleta.Fecha,SolicitudBoleta.MontoSugerido,SolicitudBoleta.MontoAutorizado,SolicitudBoleta.idTipoEmpeño,TiposDeEmpeño.Nombre as nombretipo,SolicitudBoleta.IdPromotor from SolicitudBoleta inner join TiposDeEmpeño on SolicitudBoleta.idTipoEmpeño = TiposDeEmpeño.id where SolicitudBoleta.nombre like '%" & BunifuMaterialTextbox1.Text & "%'  ) asce inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc"
                ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' "
            End If
        End If

        Dim ejec = New SqlCommand(consultaSolicitudes)
        ejec.Connection = conexionempresa
        Dim id, nombre, valor As String

        Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
        While myreaderimpuestos.Read
            id = myreaderimpuestos("id")
            nombre = myreaderimpuestos("nombre")
            If IsDBNull(myreaderimpuestos("MontoAutorizado")) Then
                valor = 0
            Else
                valor = myreaderimpuestos("MontoAutorizado")
            End If
            dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos("fecha"), FormatCurrency(myreaderimpuestos("Montosugerido"), 2), FormatCurrency(valor, 2), myreaderimpuestos("nombretipo"), myreaderimpuestos("promotor"), myreaderimpuestos("estado"), myreaderimpuestos("idtipoempeño"))
        End While
        myreaderimpuestos.Close()
        ' Catch ex As Exception
        '  MessageBox.Show(ex.Message)
        ' End Try

    End Sub

    Private Sub VerificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarToolStripMenuItem.Click
        DatosSolicitudBoletaVerificar.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DatosSolicitudBoletaVerificar.tipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(8).Value
        DatosSolicitudBoletaVerificar.Show()
    End Sub


    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(7).Value = "E" Then
            dtimpuestos.ContextMenuStrip = ContextMenuVerificar
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(7).Value = "I" Then
            dtimpuestos.ContextMenuStrip = ContextMenuIncompleto
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(7).Value = "A" Then
            dtimpuestos.ContextMenuStrip = ContextMenuAprobado
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(7).Value = "R" Then
            dtimpuestos.ContextMenuStrip = ContextMenuAprobado

        Else

            dtimpuestos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click
        DatosSolicitudBoleta.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DatosSolicitudBoleta.tipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(8).Value
        DatosSolicitudBoleta.Show()
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        Historia_de_Solicitud.esEmpeño = True
        Historia_de_Solicitud.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()

    End Sub


    Private Sub VerSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSolicitudToolStripMenuItem.Click
        DatosSolicitudBoletaVerificar.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DatosSolicitudBoletaVerificar.tipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(8).Value
        DatosSolicitudBoletaVerificar.verSolicitud = True
        DatosSolicitudBoletaVerificar.Show()
    End Sub

    Private Sub Combofiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combofiltro.SelectedIndexChanged
        Select Case Combofiltro.Text
            Case "Por Nombre"
                If EmpleadoAsignado <> 0 Then
                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' "
                End If

            Case "Rechazadas"
                If EmpleadoAsignado <> 0 Then
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,solicitud.estado,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' "
                End If
                cargarSolicitudes()
            Case "Autorizadas"
                If EmpleadoAsignado <> 0 Then
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,solicitud.estado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' "
                End If
                cargarSolicitudes()
            Case "En Espera"
                If EmpleadoAsignado <> 0 Then
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' "
                End If
                cargarSolicitudes()
            Case "Verificadas"
                If EmpleadoAsignado <> 0 Then
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                End If
                cargarSolicitudes()
            Case "Todas"
                If EmpleadoAsignado <> 0 Then
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where  ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where  ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud "
                End If

                cargarSolicitudes()
            Case "Incompletas"
                If EmpleadoAsignado <> 0 Then
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                Else
                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                End If
                cargarSolicitudes()
        End Select
    End Sub


    Private Sub BunifuMaterialTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuMaterialTextbox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarSolicitudes()
        End If
    End Sub

    Private Sub VerHistoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerHistoriaToolStripMenuItem.Click
        Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        Historia_de_Solicitud.esEmpeño = True
        Historia_de_Solicitud.Show()
    End Sub
End Class