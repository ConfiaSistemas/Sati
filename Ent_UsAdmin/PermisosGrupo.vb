Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class PermisosGrupo
    Public idgrupousuarios As Integer
    Public Autorizado As Boolean
    Private Sub PermisosGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        BackgroundPermisos.RunWorkerAsync()
    End Sub

    Private Sub cargarPermisos()

    End Sub

    Private Sub BackgroundPermisos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundPermisos.DoWork
        Try
            iniciarconexionR()
            'Acceso Sati

            Dim sqlAccesoSati As String
            Dim comandoAccesoSati As OleDb.OleDbCommand



            Dim milectorAccesoSati As OleDb.OleDbDataReader

            comandoAccesoSati = New OleDb.OleDbCommand


            comandoAccesoSati.Connection = conexionempresaR
            sqlAccesoSati = "select permiso,valor from
(select SatiAcceso as Acceso from permisosGrupo where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceso])) unpvt"
            comandoAccesoSati.CommandText = sqlAccesoSati
            milectorAccesoSati = comandoAccesoSati.ExecuteReader
            While milectorAccesoSati.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorAccesoSati("permiso")
                checkTipo.Text = milectorAccesoSati("permiso")
                If milectorAccesoSati("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.White
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowAccesoSati.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorAccesoSati.Close()


            'Usuarios

            Dim sql As String
            Dim comando As OleDb.OleDbCommand



            Dim milector As OleDb.OleDbDataReader

            comando = New OleDb.OleDbCommand


            comando.Connection = conexionempresaR
            sql = "select permiso,valor from
(select SatiModUsuarios as Acceder,
SatiModUsuariosVer as Ver,
SatiModUsuariosModificar as Modificar,
SatiModUsuariosAgregar as Agregar from permisosGrupo where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comando.CommandText = sql
            milector = comando.ExecuteReader
            While milector.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milector("permiso")
                checkTipo.Text = milector("permiso")
                If milector("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowUsuarios.Controls.Add(checkTipo)
                          End Sub)

            End While
            milector.Close()

            'grupos

            Dim sqlgrupos As String
            Dim comandogrupos As OleDb.OleDbCommand



            Dim milectorgrupos As OleDb.OleDbDataReader

            comandogrupos = New OleDb.OleDbCommand


            comandogrupos.Connection = conexionempresaR
            sqlgrupos = "select permiso,valor from
(select SatiModGrupos as Acceder,
SatiModGruposVer as Ver,
SatiModGruposModificar as Modificar,
SatiModGruposAgregar as Agregar from permisosGrupo where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandogrupos.CommandText = sqlgrupos
            milectorgrupos = comandogrupos.ExecuteReader
            While milectorgrupos.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorgrupos("permiso")
                checkTipo.Text = milectorgrupos("permiso")
                If milectorgrupos("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowGrupos.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorgrupos.Close()

            'Catalogos
            Dim sqlcatalogos As String
            Dim comandocatalogos As OleDb.OleDbCommand



            Dim milectorcatalogos As OleDb.OleDbDataReader

            comandocatalogos = New OleDb.OleDbCommand


            comandocatalogos.Connection = conexionempresaR
            sqlcatalogos = "select permiso,valor from
(select SatiModCatalogos as Acceder from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder])) unpvt"
            comandocatalogos.CommandText = sqlcatalogos
            milectorcatalogos = comandocatalogos.ExecuteReader
            While milectorcatalogos.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorcatalogos("permiso")
                checkTipo.Text = milectorcatalogos("permiso")
                If milectorcatalogos("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowCatalogos.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorcatalogos.Close()


            'clientes
            Dim sqlclientes As String
            Dim comandoclientes As OleDb.OleDbCommand



            Dim milectorclientes As OleDb.OleDbDataReader

            comandoclientes = New OleDb.OleDbCommand


            comandoclientes.Connection = conexionempresaR
            sqlclientes = "select permiso,valor from
(select SatiModClientes as Acceder,
SatiModClientesVer as Ver,
SatiModClientesModificar as Modificar,
SatiModClientesAgregar as Agregar from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandoclientes.CommandText = sqlclientes
            milectorclientes = comandoclientes.ExecuteReader
            While milectorclientes.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorclientes("permiso")
                checkTipo.Text = milectorclientes("permiso")
                If milectorclientes("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowClientes.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorclientes.Close()

            'documentos
            Dim sqldocumentos As String
            Dim comandodocumentos As OleDb.OleDbCommand



            Dim milectordocumentos As OleDb.OleDbDataReader

            comandodocumentos = New OleDb.OleDbCommand


            comandodocumentos.Connection = conexionempresaR
            sqldocumentos = "select permiso,valor from
(select SatiModDocumentos as Acceder,
SatiModDocumentosVer as Ver,
SatiModDocumentosModificar as Modificar,
SatiModDocumentosAgregar as Agregar from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandodocumentos.CommandText = sqldocumentos
            milectordocumentos = comandodocumentos.ExecuteReader
            While milectordocumentos.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectordocumentos("permiso")
                checkTipo.Text = milectordocumentos("permiso")
                If milectordocumentos("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowDocumentos.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectordocumentos.Close()


            'tipos de documentos
            Dim sqltiposdoc As String
            Dim comandotiposdoc As OleDb.OleDbCommand



            Dim milectortiposdoc As OleDb.OleDbDataReader

            comandotiposdoc = New OleDb.OleDbCommand


            comandotiposdoc.Connection = conexionempresaR
            sqltiposdoc = "select permiso,valor from
(select SatiModTipoDocumentos as Acceder,
SatiModTipoDocumentosVer as Ver,
SatiModTipoDocumentosModificar as Modificar,
SatiModTipoDocumentosAgregar as Agregar from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandotiposdoc.CommandText = sqltiposdoc
            milectortiposdoc = comandotiposdoc.ExecuteReader
            While milectortiposdoc.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectortiposdoc("permiso")
                checkTipo.Text = milectortiposdoc("permiso")
                If milectortiposdoc("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowTiposDeDocumentos.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectortiposdoc.Close()

            'solicitudes
            Dim sqlsolicitudes As String
            Dim comandosolicitudes As OleDb.OleDbCommand



            Dim milectorsolicitudes As OleDb.OleDbDataReader

            comandosolicitudes = New OleDb.OleDbCommand


            comandosolicitudes.Connection = conexionempresaR
            sqlsolicitudes = "select permiso,valor from
(select SatiModSolicitudes as Acceder,
SatiModSolicitudesVer as Ver,
SatiModSolicitudesModificar as Modificar,
SatiModSolicitudesAgregar as Agregar,
SatiModSolicitudesVerificar as Verificar,
SatiModSolicitudesAprobar as Aprobar,
SatiModSolicitudesCancelar as Cancelar,
SatiModSolicitudesAgregarRechazados as 'Agregar Rechazados',
SatimodSolicitudesAgregarLegales as 'Agregar Legales' from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar],[Verificar],[Aprobar],[Cancelar],[Agregar Rechazados],[Agregar Legales])) unpvt"
            comandosolicitudes.CommandText = sqlsolicitudes
            milectorsolicitudes = comandosolicitudes.ExecuteReader
            While milectorsolicitudes.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorsolicitudes("permiso")
                checkTipo.Text = milectorsolicitudes("permiso")
                If milectorsolicitudes("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                If checkTipo.Name = "Agregar Rechazados" Then
                    checkTipo.AutoSize = False
                    checkTipo.Size = New Size(104, 33)
                Else
                    checkTipo.AutoSize = True

                End If

                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowSolicitudes.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorsolicitudes.Close()

            'creditos
            Dim sqlcreditos As String
            Dim comandocreditos As OleDb.OleDbCommand



            Dim milectorcreditos As OleDb.OleDbDataReader

            comandocreditos = New OleDb.OleDbCommand


            comandocreditos.Connection = conexionempresaR
            sqlcreditos = "select permiso,valor from
(select SatiModCreditos as Acceder,
SatiModCreditosVer as Ver,
SatiModCreditosCrearConvenio as 'Crear Convenio',
SatiModCreditosCrearReestructura as 'Crear Reestructura',
SatiModCreditosCrearPromesa as 'Crear Promesa' from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Crear Convenio],[Crear Reestructura],[Crear Promesa])) unpvt"
            comandocreditos.CommandText = sqlcreditos
            milectorcreditos = comandocreditos.ExecuteReader
            While milectorcreditos.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorcreditos("permiso")
                checkTipo.Text = milectorcreditos("permiso")
                If milectorcreditos("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                If checkTipo.Name = "Crear Convenio" Then
                    checkTipo.AutoSize = False
                    checkTipo.Size = New Size(104, 33)
                ElseIf checkTipo.Name = "Acceder" Then
                    checkTipo.AutoSize = False
                    checkTipo.Size = New Size(120, 20)
                Else

                    checkTipo.AutoSize = True

                End If

                checkTipo.ForeColor = Color.Black
                'checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowCreditos.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorcreditos.Close()

            'reportes
            Dim sqlreportes As String
            Dim comandoreportes As OleDb.OleDbCommand



            Dim milectorreportes As OleDb.OleDbDataReader

            comandoreportes = New OleDb.OleDbCommand


            comandoreportes.Connection = conexionempresaR
            sqlreportes = "select permiso,valor from
(select SatiModReportes as Acceder from permisosGrupo where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder])) unpvt"
            comandoreportes.CommandText = sqlreportes
            milectorreportes = comandoreportes.ExecuteReader
            While milectorreportes.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorreportes("permiso")
                checkTipo.Text = milectorreportes("permiso")
                If milectorreportes("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowReportes.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorreportes.Close()

            'Tipos de Crédito
            Dim sqltiposCredito As String
            Dim comandotiposCredito As OleDb.OleDbCommand



            Dim milectortiposCredito As OleDb.OleDbDataReader

            comandotiposCredito = New OleDb.OleDbCommand


            comandotiposCredito.Connection = conexionempresaR
            sqltiposCredito = "select permiso,valor from
(select SatiModTiposCreditos as Acceder,
SatiModTiposCreditosVer as Ver,
SatiModTiposCreditosModificar as Modificar,
SatiModTiposCreditosAgregar as Agregar from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandotiposCredito.CommandText = sqltiposCredito
            milectortiposCredito = comandotiposdoc.ExecuteReader
            While milectortiposCredito.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectortiposCredito("permiso")
                checkTipo.Text = milectortiposCredito("permiso")
                If milectortiposCredito("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowTiposCredito.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectortiposCredito.Close()

            'Empleados

            Dim sqlEmpleados As String
            Dim comandoEmpleados As OleDb.OleDbCommand



            Dim milectorEmpleados As OleDb.OleDbDataReader

            comandoEmpleados = New OleDb.OleDbCommand


            comandoEmpleados.Connection = conexionempresaR
            sqlEmpleados = "select permiso,valor from
(select SatiModEmpleados as Acceder,
SatiModEmpleadosVer as Ver,
SatiModEmpleadosModificar as Modificar,
SatiModEmpleadosAgregar as Agregar from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandoEmpleados.CommandText = sqlEmpleados
            milectorEmpleados = comandoEmpleados.ExecuteReader
            While milectorEmpleados.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorEmpleados("permiso")
                checkTipo.Text = milectorEmpleados("permiso")
                If milectorEmpleados("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowEmpleados.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorEmpleados.Close()

            'Cajas
            Dim sqlCajas As String
            Dim comandoCajas As OleDb.OleDbCommand



            Dim milectorCajas As OleDb.OleDbDataReader

            comandoCajas = New OleDb.OleDbCommand


            comandoCajas.Connection = conexionempresaR
            sqlCajas = "select permiso,valor from
(select SatiModEmpleados as Acceder,
SatiModEmpleadosVer as Ver,
SatiModEmpleadosModificar as Modificar,
SatiModEmpleadosAgregar as Agregar from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Modificar],[Agregar])) unpvt"
            comandoCajas.CommandText = sqlCajas
            milectorCajas = comandoCajas.ExecuteReader
            While milectorCajas.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorCajas("permiso")
                checkTipo.Text = milectorCajas("permiso")
                If milectorCajas("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowCajas.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorCajas.Close()

            'Legal
            Dim sqlLegal As String
            Dim comandoLegal As OleDb.OleDbCommand



            Dim milectorLegal As OleDb.OleDbDataReader

            comandoLegal = New OleDb.OleDbCommand


            comandoLegal.Connection = conexionempresaR
            sqlLegal = "select permiso,valor from
(select SatiModLegal as Acceder,
SatiModLegalVer as Ver,
SatiModLegalGestionar as Gestionar,
SatiModLegalConvenio as 'Crear Convenio' from permisosGrupo  where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceder],[Ver],[Gestionar],[Crear Convenio])) unpvt"
            comandoLegal.CommandText = sqlLegal
            milectorLegal = comandoLegal.ExecuteReader
            While milectorLegal.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorLegal("permiso")
                checkTipo.Text = milectorLegal("permiso")
                If milectorLegal("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowLegal.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorLegal.Close()


            'sac

            Dim sqlsac As String
            Dim comandosac As OleDb.OleDbCommand



            Dim milectorsac As OleDb.OleDbDataReader

            comandosac = New OleDb.OleDbCommand


            comandosac.Connection = conexionempresaR
            sqlsac = "select permiso,valor from
(select SacAcceso as Acceso,
SacConsultaCredito as Consultar,
SacCobrarCredito as Cobrar,
SacCobrarComision as 'Cobrar Comisión',
SacAplicarDescuento as 'Aplicar Descuento',
SacCancelarTicket as Cancelar,
SacDetalleCaja as Detalle,
SacConsultarTicket as 'Consultar Ticket',
SacModReportes as Reportes,
SacCobrarExtra as 'Cobrar Extra' from permisosGrupo where idGrupo = '" & idgrupousuarios & "') p unpivot(valor for permiso in ( [Acceso],[Consultar],[Cobrar],[Cobrar Comisión],[Aplicar Descuento],[Cancelar],[Detalle],[Consultar Ticket],[Reportes],[Cobrar Extra])) unpvt"
            comandosac.CommandText = sqlsac
            milectorsac = comandosac.ExecuteReader
            While milectorsac.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milectorsac("permiso")
                checkTipo.Text = milectorsac("permiso")
                If milectorsac("valor") Then
                    checkTipo.CheckState = CheckState.Checked
                Else
                    checkTipo.CheckState = CheckState.Unchecked
                End If
                checkTipo.ForeColor = Color.Black
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                Me.Invoke(Sub()
                              FlowSac.Controls.Add(checkTipo)
                          End Sub)

            End While
            milectorsac.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '

    End Sub

    Private Sub BackgroundAplicarPermisos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundAplicarPermisos.DoWork
        iniciarconexionR()
        'iniciarconexionempresa()

        Dim SatiAcceso, SatiModUsuarios, SatiModUsuariosVer, SatiModUsuariosModificar, SatiModUsuariosAgregar, SatiModGrupos, SatiModGruposVer, SatiModGruposModificar, SatiModGruposAgregar, SatiModCatalogos, SatiModClientes, SatiModClientesVer, SatiModClientesModificar, SatiModClientesAgregar, SatiModDocumentos, SatiModDocumentosVer, SatiModDocumentosModificar, SatiModDocumentosAgregar, SatiModTipoDocumentos, SatiModTipoDocumentosVer, SatiModTipoDocumentosModificar, SatiModTipoDocumentosAgregar, SatiModSolicitudes, SatiModSolicitudesVer, SatiModSolicitudesModificar, SatiModSolicitudesAgregar, SatiModSolicitudesVerificar, SatiModSolicitudesAprobar, SatiModSolicitudesCancelar, SatiModSolicitudesAgregarRechazados, SatiModSolicitudesAgregarLegales, SatiModCreditos, SatiModCreditosVer, SatiModCreditosCrearConvenio, SatiModCreditosCrearReestructura, SatiModCreditosCrearPromesa, SatiModReportes, SatiModTiposCreditos, SatiModTiposCreditosVer, SatiModTiposCreditosModificar, SatiModTiposCreditosAgregar, SatiModEmpleados, SatiModEmpleadosVer, SatiModEmpleadosModificar, SatiModEmpleadosAgregar, SatiModCajas, SatiModCajasVer, SatiModCajasModificar, SatiModCajasAgregar, SacAcceso, SacConsultaCredito, SacCobrarCredito, SacCobrarComision, SacAplicarDescuento, SacCancelarTicket, SacDetalleCaja, SacConsultarTicket, SacModReportes, SacCobrarExtra, SatiModLegal, SatiModLegalVer, SatiModLegalGestionar, SatiModLegalConvenio As Boolean


        For Each ctrl As Control In FlowAccesoSati.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                SatiAcceso = checkctrl.CheckState
            End If
        Next

        For Each ctrl As Control In FlowUsuarios.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModUsuarios = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModUsuariosVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModUsuariosModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModUsuariosAgregar = checkctrl.CheckState
                End If



            End If
        Next

        For Each ctrl As Control In FlowGrupos.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModGrupos = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModGruposVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModGruposModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModGruposAgregar = checkctrl.CheckState
                End If



            End If
        Next


        For Each ctrl As Control In FlowCatalogos.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModCatalogos = checkctrl.CheckState
                End If


            End If
        Next


        For Each ctrl As Control In FlowClientes.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModClientes = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModClientesVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModClientesModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModClientesAgregar = checkctrl.CheckState
                End If



            End If
        Next

        For Each ctrl As Control In FlowDocumentos.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModDocumentos = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModDocumentosVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModDocumentosModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModDocumentosAgregar = checkctrl.CheckState
                End If



            End If
        Next

        For Each ctrl As Control In FlowTiposDeDocumentos.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModTipoDocumentos = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModTipoDocumentosVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModTipoDocumentosModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModTipoDocumentosAgregar = checkctrl.CheckState
                End If



            End If
        Next


        For Each ctrl As Control In FlowSolicitudes.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModSolicitudes = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModSolicitudesVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModSolicitudesModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModSolicitudesAgregar = checkctrl.CheckState
                End If

                If checkctrl.Name = "Verificar" Then
                    SatiModSolicitudesVerificar = checkctrl.CheckState
                End If

                If checkctrl.Name = "Aprobar" Then
                    SatiModSolicitudesAprobar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Cancelar" Then
                    SatiModSolicitudesCancelar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar Rechazados" Then
                    SatiModSolicitudesAgregarRechazados = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar Legales" Then
                    SatiModSolicitudesAgregarLegales = checkctrl.CheckState
                End If

            End If
        Next

        For Each ctrl As Control In FlowCreditos.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModCreditos = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModCreditosVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Crear Convenio" Then
                    SatiModCreditosCrearConvenio = checkctrl.CheckState
                End If
                If checkctrl.Name = "Crear Reestructura" Then
                    SatiModCreditosCrearReestructura = checkctrl.CheckState
                End If
                If checkctrl.Name = "Crear Promesa" Then
                    SatiModCreditosCrearPromesa = checkctrl.CheckState
                End If




            End If
        Next

        For Each ctrl As Control In FlowCreditos.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModCreditos = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModCreditosVer = checkctrl.CheckState
                End If




            End If
        Next


        For Each ctrl As Control In FlowReportes.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModReportes = checkctrl.CheckState
                End If


            End If
        Next


        For Each ctrl As Control In FlowTiposCredito.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModTiposCreditos = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModTiposCreditosVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModTiposCreditosModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModTiposCreditosAgregar = checkctrl.CheckState
                End If



            End If
        Next

        For Each ctrl As Control In FlowEmpleados.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModEmpleados = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModEmpleadosVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModEmpleadosModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModEmpleadosAgregar = checkctrl.CheckState
                End If



            End If
        Next


        For Each ctrl As Control In FlowCajas.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    SatiModCajas = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModCajasVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Modificar" Then
                    SatiModCajasModificar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Agregar" Then
                    SatiModCajasAgregar = checkctrl.CheckState
                End If



            End If
        Next


        For Each ctrl As Control In FlowLegal.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceder" Then
                    satimodlegal = checkctrl.CheckState
                End If
                If checkctrl.Name = "Ver" Then
                    SatiModLegalVer = checkctrl.CheckState
                End If

                If checkctrl.Name = "Gestionar" Then
                    SatiModLegalGestionar = checkctrl.CheckState
                End If
                If checkctrl.Name = "Crear Convenio" Then
                    SatiModLegalConvenio = checkctrl.CheckState
                End If



            End If
        Next



        For Each ctrl As Control In FlowSac.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                If checkctrl.Name = "Acceso" Then
                    SacAcceso = checkctrl.CheckState
                End If
                If checkctrl.Name = "Consultar" Then
                    SacConsultaCredito = checkctrl.CheckState
                End If
                If checkctrl.Name = "Cobrar" Then
                    SacCobrarCredito = checkctrl.CheckState
                End If
                If checkctrl.Name = "Cobrar Comisión" Then
                    SacCobrarComision = checkctrl.CheckState
                End If

                If checkctrl.Name = "Aplicar Descuento" Then
                    SacAplicarDescuento = checkctrl.CheckState
                End If

                If checkctrl.Name = "Cancelar" Then
                    SacCancelarTicket = checkctrl.CheckState
                End If

                If checkctrl.Name = "Consultar Ticket" Then
                    SacConsultarTicket = checkctrl.CheckState
                End If


                If checkctrl.Name = "Detalle" Then
                    SacDetalleCaja = checkctrl.CheckState
                End If

                If checkctrl.Name = "Reportes" Then
                    SacModReportes = checkctrl.CheckState
                End If
                If checkctrl.Name = "Cobrar Extra" Then
                    SacCobrarExtra = checkctrl.CheckState
                End If

            End If
        Next




        Dim comandoActPermisos As OleDb.OleDbCommand
        Dim consultaActPermisos As String
        consultaActPermisos = "update PermisosGrupo set SatiAcceso = '" & SatiAcceso & "' ,
SatiModUsuarios = '" & SatiModUsuarios & "',
SatiModUsuariosVer = '" & SatiModUsuariosVer & "',
SatiModUsuariosModificar = '" & SatiModUsuariosModificar & "',
SatiModUsuariosAgregar ='" & SatiModUsuariosAgregar & "' ,
SatiModGrupos = '" & SatiModGrupos & "',
SatiModGruposVer = '" & SatiModGruposVer & "',
SatiModGruposModificar = '" & SatiModGruposModificar & "',
SatiModGruposAgregar = '" & SatiModGruposAgregar & "' ,
SatiModCatalogos = '" & SatiModCatalogos & "',
SatiModClientes ='" & SatiModClientes & "' ,
SatiModClientesVer ='" & SatiModClientesVer & "'  ,
SatiModClientesModificar ='" & SatiModClientesModificar & "'  ,
SatiModClientesAgregar = '" & SatiModClientesAgregar & "' ,
SatiModDocumentos = '" & SatiModDocumentos & "' ,
SatiModDocumentosVer = '" & SatiModDocumentosVer & "',
SatiModDocumentosModificar = '" & SatiModDocumentosModificar & "' ,
SatiModDocumentosAgregar = '" & SatiModDocumentosAgregar & "',
SatiModTipoDocumentos = '" & SatiModTipoDocumentos & "',
SatiModTipoDocumentosVer = '" & SatiModTipoDocumentosVer & "',
SatiModTipoDocumentosModificar = '" & SatiModTipoDocumentosModificar & "',
SatiModTipoDocumentosAgregar = '" & SatiModTipoDocumentosAgregar & "' ,
SatiModSolicitudes = '" & SatiModSolicitudes & "',
SatiModSolicitudesVer = '" & SatiModSolicitudesVer & "' ,
SatiModSolicitudesModificar = '" & SatiModSolicitudesModificar & "',
SatiModSolicitudesAgregar ='" & SatiModSolicitudesAgregar & "' ,
SatiModSolicitudesVerificar = '" & SatiModSolicitudesVerificar & "',
SatiModSolicitudesAprobar = '" & SatiModSolicitudesAprobar & "',
SatiModSolicitudesCancelar = '" & SatiModSolicitudesCancelar & "',
SatiModSolicitudesAgregarRechazados = '" & SatiModSolicitudesAgregarRechazados & "',
SatiModSolicitudesAgregarLegales = '" & SatiModSolicitudesAgregarLegales & "',
SatiModCreditos = '" & SatiModCreditos & "',
SatiModCreditosVer = '" & SatiModCreditosVer & "',
SatiModCreditosCrearConvenio = '" & SatiModCreditosCrearConvenio & "',
SatiModCreditosCrearReestructura = '" & SatiModCreditosCrearReestructura & "',
SatiModCreditosCrearPromesa = '" & SatiModCreditosCrearPromesa & "',
SatiModReportes = '" & SatiModReportes & "',
SatiModTiposCreditos = '" & SatiModTiposCreditos & "',
SatiModTiposCreditosVer = '" & SatiModTiposCreditosVer & "',
SatiModTiposCreditosModificar = '" & SatiModTiposCreditosModificar & "',
SatiModTiposCreditosAgregar = '" & SatiModTiposCreditosAgregar & "',
SatiModEmpleados ='" & SatiModEmpleados & "' ,
SatiModEmpleadosVer = '" & SatiModEmpleadosVer & "',
SatiModEmpleadosModificar = '" & SatiModEmpleadosModificar & "',
SatiModEmpleadosAgregar = '" & SatiModEmpleadosAgregar & "',
SatiModCajas = '" & SatiModCajas & "',
SatiModCajasVer = '" & SatiModCajasVer & "',
SatiModCajasModificar = '" & SatiModCajasModificar & "',
SatiModCajasAgregar = '" & SatiModCajasAgregar & "',
SacAcceso = '" & SacAcceso & "',
SacConsultaCredito = '" & SacConsultaCredito & "',
SacCobrarCredito = '" & SacCobrarCredito & "',
SacCobrarComision = '" & SacCobrarComision & "',
SacAplicarDescuento = '" & SacAplicarDescuento & "' ,
SacCancelarTicket = '" & SacCancelarTicket & "',
SacDetalleCaja = '" & SacDetalleCaja & "',
SacConsultarTicket = '" & SacConsultarTicket & "',
SacModReportes = '" & SacModReportes & "',
SacCobrarExtra = '" & SacCobrarExtra & "',
SatiModLegal = '" & SatiModLegal & "',
SatiModLegalVer = '" & SatiModLegalVer & "',
SatiModLegalGestionar = '" & SatiModLegalGestionar & "',
SatiModLegalConvenio = '" & SatiModLegalConvenio & "'    where idgrupo = '" & idgrupousuarios & "'"
        comandoActPermisos = New OleDb.OleDbCommand
        comandoActPermisos.Connection = conexionempresaR
        comandoActPermisos.CommandText = consultaActPermisos
        comandoActPermisos.ExecuteNonQuery()


    End Sub

    Private Sub BackgroundAplicarPermisos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundAplicarPermisos.RunWorkerCompleted
        MessageBox.Show("Listo")
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Autorizacion.tipoAutorizacion = "SatiModGruposModificar"
        Autorizacion.ShowDialog()
        If Autorizado Then
            BackgroundAplicarPermisos.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If

    End Sub


End Class