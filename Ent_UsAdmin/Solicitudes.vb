Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class Solicitudes
    Dim consultaSolicitudes
    Dim dataSolicitudes As DataTable
    Dim adapterSolicitudes As SqlDataAdapter
    Dim estadoFiltro As String
    Dim consultaEstado As String
    Dim consultaEmpleadoAsignado As String
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Levantar_Solicitud.Show()
    End Sub

    Private Sub Solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combofiltro.SelectedIndex = 0
        For Each row As DataRow In dataPermisos.Rows
            If row("SatiModSolicitudesVer") Then
                VerSolicitudToolStripMenuItem.Visible = True
                VerificarToolStripMenuItem.Visible = True
                SeguimientoToolStripMenuItem.Visible = True
                ToolStripMenuItem1.Visible = True
                VerHistoriaToolStripMenuItem.Visible = True
                ToolStripMenuItem2.Visible = True
                VerSolicitudToolStripMenuItem.Visible = True
            Else
                VerSolicitudToolStripMenuItem.Visible = False
                VerificarToolStripMenuItem.Visible = False
                SeguimientoToolStripMenuItem.Visible = False
                ToolStripMenuItem1.Visible = False
                VerHistoriaToolStripMenuItem.Visible = False
                ToolStripMenuItem2.Visible = False
                VerSolicitudToolStripMenuItem.Visible = False
            End If


        Next
        cargarSolicitudes()
    End Sub
    Public Async Sub cargarSolicitudes()
        '  dtimpuestos.Rows.Clear()
        dtimpuestos.DataSource = Nothing

        dtimpuestos.ScrollBars = ScrollBars.None
        BunifuMaterialTextbox1.Enabled = False
        BunifuThinButton22.Enabled = False
        BunifuThinButton21.Enabled = False
        Combofiltro.Enabled = False
        Panel2.Visible = True
        Panel2.BringToFront()
        ' TransparentPanel1.Location = dtimpuestos.Location
        dtimpuestos.Visible = False

        '  TransparentPanel1.Size = dtimpuestos.Size

        Panel2.Location = New Point((Me.Size.Width / 2) + (Panel2.Width / 2) - 200, (Me.Height / 2) + (Panel2.Height / 2) - 200)

        Await Task.Factory.StartNew(Sub()
                                        Me.Invoke(Sub()
                                                      Dim strimpuestos As String
                                                      iniciarconexionempresa()
                                                      'If EmpleadoAsignado <> 0 Then

                                                      '    strimpuestos = "select id,nombre,fecha,monto,estado,tipo, from Solicitud inner join tipo where idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "' order by nombre"
                                                      'Else
                                                      '    strimpuestos = "select id,nombre,fecha,monto,estado,tipo from Solicitud order by nombre asc"
                                                      'End If

                                                      If Combofiltro.Text = "Por Nombre" Then

                                                          If EmpleadoAsignado <> 0 Then
                                                              consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,Format(asce.Monto,'C','es-mx') as Monto,Format(asce.MontoAutorizado,'C','es-mx') as 'Monto Autorizado',asce.nombretipo as Tipo,asce.interes as 'Interés',asce.nombretipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado,asce.tipo from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,solicitud.estado,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                                                              ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                                                          Else
                                                              consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,Format(asce.Monto,'C','es-mx') as Monto,Format(asce.MontoAutorizado,'C','es-mx') as 'Monto Autorizado',asce.nombretipo as Tipo,Format(asce.interes,'C','es-mx') as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.Estado,asce.tipo from
(select Solicitud.id,Solicitud.Nombre,solicitud.estado,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.nombre like '%" & BunifuMaterialTextbox1.Text & "%'  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc"
                                                              ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where nombre like '%" & BunifuMaterialTextbox1.Text & "%' "
                                                          End If
                                                      End If

                                                      'Dim ejec = New SqlCommand(consultaSolicitudes)
                                                      'ejec.Connection = conexionempresa
                                                      'Dim id, nombre, valor, factor, tipo As String

                                                      'Dim myreaderimpuestos As SqlDataReader = ejec.ExecuteReader()
                                                      'While myreaderimpuestos.Read
                                                      '    id = myreaderimpuestos("id")
                                                      '    nombre = myreaderimpuestos("nombre")
                                                      '    If IsDBNull(myreaderimpuestos("MontoAutorizado")) Then
                                                      '        valor = 0
                                                      '    Else
                                                      '        valor = myreaderimpuestos("MontoAutorizado")
                                                      '    End If
                                                      '    dtimpuestos.Rows.Add(id, nombre, myreaderimpuestos("fecha"), FormatCurrency(myreaderimpuestos("Monto"), 2), FormatCurrency(valor, 2), myreaderimpuestos("nombretipo"), myreaderimpuestos("gestor"), myreaderimpuestos("promotor"), myreaderimpuestos("estado"), myreaderimpuestos("tipo"))
                                                      'End While
                                                      'myreaderimpuestos.Close()
                                                      adapterSolicitudes = New SqlDataAdapter(consultaSolicitudes, conexionempresa)
                                                      dataSolicitudes = New DataTable
                                                      adapterSolicitudes.Fill(dataSolicitudes)


                                                  End Sub)


                                    End Sub)
        dtimpuestos.DataSource = dataSolicitudes
        dtimpuestos.Columns(10).Visible = False

        'Try
        BunifuMaterialTextbox1.Enabled = True
        BunifuThinButton22.Enabled = True
        BunifuThinButton21.Enabled = True
        Combofiltro.Enabled = True
        dtimpuestos.Visible = True
        Panel2.Visible = False

        dtimpuestos.ScrollBars = ScrollBars.Both
        ' Catch ex As Exception
        '  MessageBox.Show(ex.Message)
        ' End Try

    End Sub

    Private Sub VerificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarToolStripMenuItem.Click
        DatosVerificacion.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DatosVerificacion.tipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(10).Value
        DatosVerificacion.Show()
    End Sub


    Private Sub dtimpuestos_SelectionChanged(sender As Object, e As EventArgs) Handles dtimpuestos.SelectionChanged
        If dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(9).Value = "E" Then
            dtimpuestos.ContextMenuStrip = ContextMenuVerificar
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(9).Value = "I" Then
            dtimpuestos.ContextMenuStrip = ContextMenuIncompleto
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(9).Value = "V" Then
            dtimpuestos.ContextMenuStrip = ContextMenuAprobacion
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(9).Value = "A" Then
            dtimpuestos.ContextMenuStrip = ContextMenuAprobado
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(9).Value = "R" Then
            dtimpuestos.ContextMenuStrip = ContextMenuAprobado
        ElseIf dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(9).Value = "N" Then
            dtimpuestos.ContextMenuStrip = ContextMenuIncompleto
        Else

            dtimpuestos.ContextMenuStrip = Nothing

        End If
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click
        DatosSolicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DatosSolicitud.tipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(10).Value
        DatosSolicitud.nombreSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(1).Value
        DatosSolicitud.Show()
    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        DatosAprobacion.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        DatosAprobacion.Show()
    End Sub

    Private Sub VerHistoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerHistoriaToolStripMenuItem.Click
        Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        Historia_de_Solicitud.esEmpeño = False
        Historia_de_Solicitud.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Historia_de_Solicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        Historia_de_Solicitud.esEmpeño = False
        Historia_de_Solicitud.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        cargarSolicitudes()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub ContextMenuVerificar_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuVerificar.Opening

    End Sub

    Private Sub VerSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSolicitudToolStripMenuItem.Click
        DatosConsultaSolicitud.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        DatosConsultaSolicitud.Show()
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
                '                If EmpleadoAsignado <> 0 Then
                ''                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo AS tIPO,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                ''(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,solicitud.estado,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                ''(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                ''(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                ''                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                ''                Else
                ''                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                ''(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'R' ) asce inner join
                ''(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                ''(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'R' "
                '                End If
                consultaEstado = "where Estado ='R'"


            Case "Autorizadas"
                '                If EmpleadoAsignado <> 0 Then
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,solicitud.estado,Solicitud.Tipo,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                '                Else
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'A' ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'A' "
                '                End If
                consultaEstado = "where Estado ='A'"

            Case "En Espera"
                '                If EmpleadoAsignado <> 0 Then
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                '                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                '                Else
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'E'  ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'E' "
                '                End If
                consultaEstado = "where Estado ='E'"

            Case "Verificadas"
                '                If EmpleadoAsignado <> 0 Then
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                '                Else
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'V'  ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                '                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                '                End If
                consultaEstado = "where Estado ='V'"

            Case "Todas"
                'If EmpleadoAsignado <> 0 Then
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where  ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                '                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where  ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                '                Else
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id  ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.Nombre asc"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud "
                '                End If
                consultaEstado = ""


            Case "Incompletas"
                '                If EmpleadoAsignado <> 0 Then
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I' and ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id"
                '                    'consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' and ( idpromotor = '" & EmpleadoAsignado & "' or idgestor = '" & EmpleadoAsignado & "')"
                '                Else
                '                    consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,asce.Monto,asce.MontoAutorizado,asce.Tipo,asce.nombretipo as Tipo,asce.interes as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.estado from
                '(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id where solicitud.estado = 'I'  ) asce inner join
                '(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
                '(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id order by asce.nombre asc"
                '                    ' consultaSolicitudes = "select id,nombre,fecha,monto,estado,tipo from Solicitud where estado = 'V' "

                '                End If

                consultaEstado = "where Estado ='I'"


        End Select
        If EmpleadoAsignado <> 0 Then
            consultaEmpleadoAsignado = "  where  ( solicitud.idpromotor = '" & EmpleadoAsignado & "' or solicitud.idgestor = '" & EmpleadoAsignado & "' ) "
        Else
            consultaEmpleadoAsignado = ""
        End If
        consultaSolicitudes = "select asce.id,asce.nombre,asce.Fecha,Format(asce.Monto,'C','es-mx') as Monto,Format(asce.MontoAutorizado,'C','es-mx') as 'Monto Autorizado',asce.nombretipo as Tipo,Format(asce.interes,'C','es-mx') as 'Interés',gestores.Nombre  as Gestor,promotores.Nombre as Promotor,asce.Estado,asce.tipo from
(select Solicitud.id,Solicitud.Nombre,Solicitud.Fecha,Solicitud.Monto,Solicitud.MontoAutorizado,Solicitud.Tipo,solicitud.estado,TiposDeCredito.Nombre as nombretipo,Solicitud.IdPromotor,Solicitud.IdGestor,solicitud.interes from Solicitud inner join TiposDeCredito on Solicitud.Tipo = TiposDeCredito.id " & consultaEmpleadoAsignado & "  ) asce inner join
(select * from Empleados where Tipo = 'G') gestores on asce.IdGestor = gestores.id inner join
(select * from Empleados where Tipo = 'P') promotores on asce.IdPromotor = promotores.id " & consultaEstado & " order  by asce.nombre asc"
        cargarSolicitudes()
        '  If estadoFiltro <> "" Then
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuMaterialTextbox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarSolicitudes()
        End If
    End Sub

    Private Sub BackgroundExcel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundExcel.DoWork
        nuevolibro()
        GridAExcel(dtimpuestos)
    End Sub

    Private Sub BackgroundExcel_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundExcel.RunWorkerCompleted
        Cargando.Close()
        cerrarlibro()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Exportando a Excel"
        BackgroundExcel.RunWorkerAsync()

    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub ReenviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReenviarCorreoToolStripMenuItem.Click
        DatosSolicitudReenviarCorreo.idSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(0).Value
        '  DatosConsultaSolicitud.TipoSolicitud = dtimpuestos.Rows(dtimpuestos.CurrentRow.Index).Cells(5).Value
        DatosSolicitudReenviarCorreo.Show()
    End Sub
End Class