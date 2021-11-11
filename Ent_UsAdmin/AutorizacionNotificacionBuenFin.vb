Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient

Public Class AutorizacionNotificacionBuenFin


    Dim adapterUsuariosCautorizacion As OleDb.OleDbDataAdapter
    Dim dataUsuariosCautorizacion As DataTable
    Dim autorizado As Boolean
    Public tipoAutorizacion As String
    Dim passwordCorrect As Boolean
    Private Sub Autorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonoFlat_Button1_ClickAsync(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        FlowEspere.Visible = True

        txtcontra.Enabled = False
        MonoFlat_Button1.Enabled = False
        MonoFlat_Button2.Enabled = False
        BackgroundWorker1.RunWorkerAsync()


    End Sub



    Private Sub MonoFlat_Button2_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button2.Click
        Select Case tipoAutorizacion
            Case "SatiAcceso"
            Case "SatiModUsuarios"
            Case "SatiModUsuariosVer"
            Case "SatiModUsuariosModificar"
                Editar_Usuario.autorizado = False
                Me.Close()
            Case "SatiModUsuariosAgregar"
                Agregar_Usuario.autorizado = False
                Me.Close()

            Case "SatiModGrupos"
            Case "SatiModGruposVer"
            Case "SatiModGruposModificar"
                PermisosGrupo.Autorizado = False
                Me.Close()
            Case "SatiModGruposAgregar"
                agregargrupos.autorizado = False
                Me.Close()
            Case "SatiModCatalogos"
            Case "SatiModClientes"
            Case "SatiModClientesVer"
            Case "SatiModClientesModificar"
            Case "SatiModClientesAgregar"
                Agregar_Impuestos.autorizado = False
                Me.Close()
            Case "SatiModDocumentos"
            Case "SatiModDocumentosVer"
            Case "SatiModDocumentosModificar"
            Case "SatiModDocumentosAgregar"
            Case "SatiModTipoDocumentos"
            Case "SatiModTipoDocumentosVer"
            Case "SatiModTipoDocumentosModificar"
            Case "SatiModTipoDocumentosAgregar"
                AgregarTipoDocumentoSolicitud.autorizado = False
                Me.Close()
            Case "SatiModSolicitudes"
            Case "SatiModSolicitudesVer"
            Case "SatiModSolicitudesModificar"
            Case "SatiModSolicitudesAgregar"
                Levantar_Solicitud.autorizado = False
                Me.Close()
            Case "SatiModSolicitudesVerificar"
                DatosVerificacion.autorizado = False
                Me.Close()
            Case "SatiModSolicitudesAprobar"
                DatosAprobacion.autorizado = False
                Me.Close()

            Case "SatiModSolicitudesCancelar"
            Case "SatiModSolicitudesAgregarRechazados"

                DatosAprobacion.autorizado = False
                Me.Close()
            Case "SatiModSolicitudesAgregarLegales"
                Levantar_Solicitud.autorizado = False
                Me.Close()
            Case "SatiModCreditos"
            Case "SatiModCreditosVer"
            Case "SatiModCreditosCrearConvenio"
                CalendarioConvenio.Autorizado = False
                Me.Close()
            Case "SatiModCreditosCrearReestructura"
                CalendarioReestructura.Autorizado = False
                Me.Close()
            Case "SatiModCreditosCrearPromesa"
                PromesaPago.Autorizado = False
                Me.Close()
            Case "SatiModReportes"
            Case "SatiModTiposCreditos"
            Case "SatiModTiposCreditosVer"
            Case "SatiModTiposCreditosModificar"
            Case "SatiModTiposCreditosAgregar"
                AgregarTipoCredito.autorizado = False
                Me.Close()
            Case "SatiModEmpleados"
            Case "SatiModEmpleadosVer"
            Case "SatiModEmpleadosModificar"
            Case "SatiModEmpleadosAgregar"
            Case "SatiModCajas"
            Case "SatiModCajasVer"
            Case "SatiModCajasModificar"
            Case "SatiModCajasAgregar"
                AgregarCaja.autorizado = False
                Me.Close()
            Case "SacCancelarTicket"
                CancelarTicket.Autorizado = False
                Me.Close()
            Case "SatiModEmpeñosAgregarSolicitud"
                Solicitud_Boleta.autorizado = False
                Me.Close()
            Case "SatiModCreditosDescuentoPromesa"
                AplicarDescuentoBuenFin.Autorizado = False
                Me.Close()
            Case "SatiModLegalAplicaDeposito"
                AplicarDepositoLegal.Autorizado = False
                Me.Close()

        End Select
    End Sub

    Private Sub Autorizacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Select Case tipoAutorizacion
            Case "SatiAcceso"
            Case "SatiModUsuarios"
            Case "SatiModUsuariosVer"
            Case "SatiModUsuariosModificar"
                If autorizado Then
                    Editar_Usuario.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Editar_Usuario.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If


            Case "SatiModUsuariosAgregar"
                If autorizado Then
                    Agregar_Usuario.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Agregar_Usuario.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If

            Case "SatiModGrupos"
            Case "SatiModGruposVer"
            Case "SatiModGruposModificar"
                If autorizado Then
                    PermisosGrupo.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    PermisosGrupo.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModGruposAgregar"
                If autorizado Then
                    agregargrupos.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    agregargrupos.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModCatalogos"
            Case "SatiModClientes"
            Case "SatiModClientesVer"
            Case "SatiModClientesModificar"
            Case "SatiModClientesAgregar"
                If autorizado Then
                    Agregar_Impuestos.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Agregar_Impuestos.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModDocumentos"
            Case "SatiModDocumentosVer"
            Case "SatiModDocumentosModificar"
            Case "SatiModDocumentosAgregar"
            Case "SatiModTipoDocumentos"
            Case "SatiModTipoDocumentosVer"
            Case "SatiModTipoDocumentosModificar"
            Case "SatiModTipoDocumentosAgregar"
                If autorizado Then
                    AgregarTipoDocumentoSolicitud.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    AgregarTipoDocumentoSolicitud.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModSolicitudes"
            Case "SatiModSolicitudesVer"
            Case "SatiModSolicitudesModificar"
            Case "SatiModSolicitudesAgregar"
                If autorizado Then
                    Levantar_Solicitud.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Levantar_Solicitud.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModSolicitudesVerificar"
                If autorizado Then
                    DatosVerificacion.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    DatosVerificacion.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModSolicitudesAprobar"
                If autorizado Then
                    DatosAprobacion.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    DatosAprobacion.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModSolicitudesCancelar"
            Case "SatiModSolicitudesAgregarRechazados"
                If autorizado Then
                    Levantar_Solicitud.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Levantar_Solicitud.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModSolicitudesAgregarLegales"
                If autorizado Then
                    Levantar_Solicitud.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Levantar_Solicitud.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModCreditos"
            Case "SatiModCreditosVer"
            Case "SatiModCreditosCrearConvenio"
                If autorizado Then
                    CalendarioConvenio.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    CalendarioConvenio.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModCreditosCrearReestructura"
                If autorizado Then
                    CalendarioReestructura.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    CalendarioReestructura.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModCreditosCrearPromesa"
                If autorizado Then
                    PromesaPago.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    PromesaPago.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModReportes"
            Case "SatiModTiposCreditos"
            Case "SatiModTiposCreditosVer"
            Case "SatiModTiposCreditosModificar"
            Case "SatiModTiposCreditosAgregar"
                If autorizado Then
                    AgregarTipoCredito.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    AgregarTipoCredito.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModEmpleados"
            Case "SatiModEmpleadosVer"
            Case "SatiModEmpleadosModificar"
            Case "SatiModEmpleadosAgregar"
            Case "SatiModCajas"
            Case "SatiModCajasVer"
            Case "SatiModCajasModificar"
            Case "SatiModCajasAgregar"
                If autorizado Then
                    AgregarCaja.autorizado = True

                    txtcontra.Text = ""
                Else
                    AgregarCaja.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SacCancelarTicket"
                If autorizado Then
                    CancelarTicket.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    CancelarTicket.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModEmpeñosAgregarSolicitud"
                If autorizado Then
                    Solicitud_Boleta.autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    Solicitud_Boleta.autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModCreditosDescuentoPromesa"
                If autorizado Then
                    AplicarDescuentoBuenFin.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    AplicarDescuentoBuenFin.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If
            Case "SatiModLegalAplicaDeposito"
                If autorizado Then
                    AplicarDepositoLegal.Autorizado = True
                    autorizado = False

                    txtcontra.Text = ""
                Else
                    AplicarDepositoLegal.Autorizado = False
                    autorizado = False

                    txtcontra.Text = ""
                End If

        End Select
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexion()
        Dim consultaUsuariosCautorizacion As String
        Dim connexion = New OleDbConnection(cn)
        consultaUsuariosCautorizacion = "select Usr.Idusr,Usr.nm from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on PermisosGrupo.idGrupo = grp.id where PermisosGrupo." & tipoAutorizacion & " = 1"
        adapterUsuariosCautorizacion = New OleDbDataAdapter(consultaUsuariosCautorizacion, connexion)
        dataUsuariosCautorizacion = New DataTable
        adapterUsuariosCautorizacion.Fill(dataUsuariosCautorizacion)
        For Each row As DataRow In dataUsuariosCautorizacion.Rows
            If row("nm").ToString.Equals(nmusr, StringComparison.InvariantCultureIgnoreCase) Then

                Try

                    Dim pass, passdecrypt As String
                    Dim s As String = ("SELECT idusr FROM usr  where nm = '" & nmusr & "'")

                    Dim connexio = New OleDbConnection(cn)
                    Dim myCommand = New OleDbCommand(s)

                    myCommand.Connection = connexio

                    connexio.Open()
                    Dim myReader As OleDbDataReader = myCommand.ExecuteReader()

                    While myReader.Read()
                        idusr = myReader("idusr")

                    End While


                    Dim strcontra As String = ("select pass from usr where idusr = '" & idusr & "'")
                    Dim ejec = New OleDbCommand(strcontra)
                    ejec.Connection = connexio


                    Dim myreader2 As OleDbDataReader = ejec.ExecuteReader()
                    While myreader2.Read()
                        pass = myreader2("pass")
                        Dim byteconverter As New UnicodeEncoding()
                        Dim CadByte As Byte() = System.Convert.FromBase64String(pass)

                        Dim DecryptedMessage As Encryption.RSAResult = Encryption.RSA.Decrypt(CadByte, "<RSAKeyValue><Modulus>1D3WnN4qZq3DGHf7i3WjEixX0Nzka28RIR9lOrT7Eg2QmJTACm/E6388wMdGgH3yTwKPp/T5zm61yvZn44oHMka8EKlACGKkADsxN/ci0RLKJ0ZGYDVPtB+KSzI+GbmX2eO00R+FlYvXTpMzGXy3e4QpeCJbIbrDGFpt3rmXy28=</Modulus><Exponent>AQAB</Exponent><P>98YU9Nkhu3qQ4Y168ZbMX+kCFUEPK9mRDEc2yZiyfABU9UlrKU4Ja1qy47WJrQNSALA9nnARZgbiY/3JkslISQ==</P><Q>20nBaoUN5QK9cuH6yX0QqAzhhB88rsI/HFzb8xrbEkceNfsTbYOVt+7biqzQQAvsyEILU+0l529eSe6S52yl9w==</Q><DP>wk3CLWkBfQZXC6ppmX9KcoRFr+k/PoH1r41BN8LZZUjVVy3mLZQW6utLkirQ9q695fBPwincWwhXDVb+dnAGkQ==</DP><DQ>Ks/0hhJiCxME37gE2W+kX9rb8IqUs13TKntqqcTVfnUKDent+hSVl2p3zFQ++DIb0WEriwAixVN16iM85RfOMw==</DQ><InverseQ>coc9FIy42//YO02qCCKfORevLIU8GIeTSYFqD9kMwhHSy1a6QMDpKaYWrYvv8FcMHglqWzdTqbSgBSrsfcnibw==</InverseQ><D>JvPie4/awFWLxOXgaMwCTceNpmukEIOl5SpZ7dhhbALJUveZ91BkF8SWZdss+VAkNJQHwY+YeWagPsvSbVRb1WylY11D8gBQEb6EOR3EsM17/5+v6nRrJ5+cySfpcahRbUjUdJFaVhMCUQ1wsnevLNY/Xo20UF4XCE5Exp7TW0E=</D></RSAKeyValue>")
                        passdecrypt = DecryptedMessage.AsString
                    End While




                    If StrComp(passdecrypt, txtcontra.Text, 0) = 0 Then



                        autorizado = True
                        'Me.Close()


                    Else
                        MessageBox.Show("Contraseña incorrecta")
                        txtcontra.Focus()
                        txtcontra.Select()
                        FlowEspere.Visible = False
                        passwordCorrect = True
                        autorizado = False

                    End If



                Catch exc As System.Exception
                    autorizado = False
                    MsgBox(exc.Message, MsgBoxStyle.Exclamation, "SATI")

                End Try
                Exit For

            Else

                autorizado = False

                'MsgBox("El usuario no tiene autorización", MsgBoxStyle.Exclamation, "SATI")
                ' Exit For

            End If
            'Exit For
        Next


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        FlowEspere.Visible = False

        txtcontra.Enabled = True
        MonoFlat_Button1.Enabled = True
        MonoFlat_Button2.Enabled = True
        If autorizado Then
            Select Case tipoAutorizacion
                Case "SatiAcceso"
                Case "SatiModUsuarios"
                Case "SatiModUsuariosVer"
                Case "SatiModUsuariosModificar"
                    Editar_Usuario.autorizado = True
                    Me.Close()
                Case "SatiModUsuariosAgregar"
                    Agregar_Usuario.autorizado = True
                    Me.Close()

                Case "SatiModGrupos"
                Case "SatiModGruposVer"
                Case "SatiModGruposModificar"
                    PermisosGrupo.Autorizado = True
                    Me.Close()
                Case "SatiModGruposAgregar"
                    agregargrupos.autorizado = True
                    Me.Close()
                Case "SatiModCatalogos"
                Case "SatiModClientes"
                Case "SatiModClientesVer"
                Case "SatiModClientesModificar"
                Case "SatiModClientesAgregar"
                    Agregar_Impuestos.autorizado = True
                    Me.Close()
                Case "SatiModDocumentos"
                Case "SatiModDocumentosVer"
                Case "SatiModDocumentosModificar"
                Case "SatiModDocumentosAgregar"
                Case "SatiModTipoDocumentos"
                Case "SatiModTipoDocumentosVer"
                Case "SatiModTipoDocumentosModificar"
                Case "SatiModTipoDocumentosAgregar"
                    AgregarTipoDocumentoSolicitud.autorizado = True
                    Me.Close()
                Case "SatiModSolicitudes"
                Case "SatiModSolicitudesVer"
                Case "SatiModSolicitudesModificar"
                Case "SatiModSolicitudesAgregar"
                    Levantar_Solicitud.autorizado = True
                    Me.Close()
                Case "SatiModSolicitudesVerificar"
                    DatosVerificacion.autorizado = True
                    Me.Close()
                Case "SatiModSolicitudesAprobar"
                    DatosAprobacion.autorizado = True
                    Me.Close()
                Case "SatiModSolicitudesCancelar"
                Case "SatiModSolicitudesAgregarRechazados"
                    Levantar_Solicitud.autorizado = True
                    Me.Close()
                Case "SatiModSolicitudesAgregarLegales"
                    Levantar_Solicitud.autorizado = True
                    Me.Close()
                Case "SatiModCreditos"
                Case "SatiModCreditosVer"
                Case "SatiModCreditosCrearConvenio"
                    CalendarioConvenio.Autorizado = True
                    Me.Close()
                Case "SatiModCreditosCrearReestructura"
                    CalendarioReestructura.Autorizado = True
                    Me.Close()
                Case "SatiModCreditosCrearPromesa"
                    PromesaPago.Autorizado = True
                    Me.Close()
                Case "SatiModReportes"

                Case "SatiModTiposCreditos"
                Case "SatiModTiposCreditosVer"
                Case "SatiModTiposCreditosModificar"
                Case "SatiModTiposCreditosAgregar"
                    AgregarTipoCredito.autorizado = True
                    Me.Close()
                Case "SatiModEmpleados"
                Case "SatiModEmpleadosVer"
                Case "SatiModEmpleadosModificar"
                Case "SatiModEmpleadosAgregar"
                Case "SatiModCajas"
                Case "SatiModCajasVer"
                Case "SatiModCajasModificar"
                Case "SatiModCajasAgregar"
                    AgregarCaja.autorizado = True
                    Me.Close()
                Case "SacCancelarTicket"
                    CancelarTicket.Autorizado = True
                    Me.Close()
                Case "SatiModEmpeñosAgregarSolicitud"
                    Solicitud_Boleta.autorizado = True
                    Me.Close()
                Case "SatiModCreditosDescuentoPromesa"
                    AplicarDescuentoBuenFin.Autorizado = True
                    Me.Close()
                Case "SatiModLegalAplicaDeposito"
                    AplicarDepositoLegal.Autorizado = True
                    Me.Close()
            End Select
        Else
            If passwordCorrect Then
                passwordCorrect = False

            Else
                passwordCorrect = False
                MsgBox("El usuario no tiene autorización", MsgBoxStyle.Exclamation, "SATI")
            End If

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub txtcontra_TextChanged(sender As Object, e As EventArgs) Handles txtcontra.TextChanged

    End Sub


End Class