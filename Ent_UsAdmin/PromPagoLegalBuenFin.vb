Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI
Imports Xceed.Words.NET

Public Class PromPagoLegalBuenFin


    Public idCredito As Integer
    Public estadoCredito As String
    Dim nombreCredito As String
    Public descuentoTotal As Double
    Dim TotalTotal As Double
    Dim subTotalTotal As Double
    Public descuentoParcial As Double
    Dim totalParcial As Double
    Dim subTotalParcial As Double
    Public creada As Boolean
    Dim dataVencidos As DataTable
    Dim adapterVencidos As SqlDataAdapter
    Dim dataTotal As DataTable
    Dim adapterTotal As SqlDataAdapter
    Dim pagoNormalTotal As Double
    Dim multasTotal As Double
    Dim pagonormalParcial As Double
    Dim multasParcial As Double
    Dim existePromesa As String
    Dim ncargando As Cargando
    Dim idPromesa As String
    Public TipoCredito As String

    Private Sub PromPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        creada = False
        DoubleBuffered = True
        dateFechaLimite.Value = Now.Date.AddDays(7)
        TextBox1.BackColor = Color.FromArgb(191, 219, 255)
        TextBox1.ForeColor = Color.FromArgb(21, 66, 139)
        Panel1.BackColor = Color.FromArgb(191, 219, 255)
        Panel2.BackColor = Color.FromArgb(191, 219, 255)
        Panel3.BackColor = Color.FromArgb(191, 219, 255)
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Consultando promesas"
        ncargando.TopMost = True
        BackgroundConsultarPromesa.RunWorkerAsync()

    End Sub

    Private Sub RadCollapsiblePanel1_Expanded(sender As Object, e As EventArgs) Handles RadCollapsiblePanel1.Expanded
        ResumeLayout()
        dtTotal.Visible = True
    End Sub

    Private Sub RadCollapsiblePanel1_Expanding(sender As Object, e As CancelEventArgs) Handles RadCollapsiblePanel1.Expanding
        SuspendLayout()
        dtTotal.Visible = False
    End Sub

    Private Sub RadCollapsiblePanel1_SizeChanged(sender As Object, e As EventArgs) Handles RadCollapsiblePanel1.SizeChanged
        If RadCollapsiblePanel1.IsExpanded Then
        Else
            dtTotal.Visible = False
        End If

    End Sub

    Private Sub RadWizard1_Next(sender As Object, e As WizardCancelEventArgs) Handles RadWizard1.[Next]
        If RadWizard1.Pages.Item(0) Is RadWizard1.SelectedPage Then

            If dateFechaLimite.Value > Date.Now.AddMonths(2) Then
                MessageBox.Show("La fecha límite no puede ser mayor a 2 meses", "SATI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            Else
                ncargando = New Cargando
                ncargando.Show()

                ncargando.MonoFlat_Label1.Text = "Consultando información"
                ncargando.TopMost = True
                BackgroundTotal.RunWorkerAsync()

            End If


        End If
        If RadWizard1.Pages.Item(1) Is RadWizard1.SelectedPage Then


            TextBox1.Text = "El cliente deberá pagar " & FormatCurrency(TotalTotal, 2) & " antes de la fecha " & dateFechaLimite.Value.ToLongDateString
            If TextBox1.Text.Length > TextBox1.Height Then
                TextBox1.ScrollBars = ScrollBars.Vertical
            Else
                TextBox1.ScrollBars = ScrollBars.None

            End If



        End If


    End Sub





    Private Sub BackgroundTotal_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTotal.DoWork
        iniciarconexionempresa()

        Dim consultaDeudaTotal As String
        consultaDeudaTotal = "select *,(interesL+AbonadoInteresV) as abonadoInteresTotal,(Abonado- (AbonadoInteresV+interesL)) as AbonadoSinInteres,(Intereses-(interesL+AbonadoInteresV)) as InteresPendiente,
case when multas <> 0 then
(PendienteLegal-(Intereses-(interesL+AbonadoInteresV)))
else ((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) ) - ((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) * PorcentajeMoratorio) end as PendienteSinteres,
 case when multas <> 0 then
 Intereses - (AbonadoInteresV + interesL)
 else
 ((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) * PorcentajeMoratorio) end as MoratoriosPendientes,
 case when multas <> 0 then
 Intereses - (AbonadoInteresV + interesL)
 else
 (((PendienteLegal-(Intereses-(interesL+AbonadoInteresV))) * PorcentajeMoratorio) + (Intereses-(interesL+AbonadoInteresV))) end as MoratorioMmultas from
(select *, case when DatosLegal.Gastos + DatosLegal.DeudaAP = DatosLegal.MontoConvenio
then Moratorios/MontoConvenio else (Moratorios*1.30) / MontoConvenio end as PorcentajeMoratorio,
Abonado - interesL as AbonadoSinteres,
case when DatosLegal.Multas <> 0 then
isnull((select isnull((select SUM( ((((abonado ))) )) as AbonadoInteres from CalendarioLegales  where CalendarioLegales.estado = 'V' and Abonado <= CalendarioLegales.Interes and CalendarioLegales.idcredito =datoslegal.id group by CalendarioLegales.idcredito),0)
+
isnull((select SUM( ((((abonado -(abonado -CalendarioLegales.Interes) ))) )) as AbonadoInteres from CalendarioLegales  where CalendarioLegales.estado = 'V' and Abonado >=CalendarioLegales.Interes and CalendarioLegales.idCredito =DatosLegal.id group by CalendarioLegales.idcredito),0)),0)

 else
 case when AbonadoV<=InteresV1 then AbonadoV else InteresV1 end end as AbonadoInteresV
 from
(select *,ISNULL((select sum(monto) as monto from CalendarioLegales where idCredito = legal.id),0) as Monto,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id),0) as Abonado,isnull((select sum(Interes) from CalendarioLegales where idCredito = legal.id),0) as Intereses,isnull((select sum(Multas) from CalendarioLegales where idCredito = legal.id),0) as Multas,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id and Estado = 'L'),0) as AbonadoL,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id and Estado = 'V'),0) as AbonadoV,isnull((select sum(abonado) from CalendarioLegales where idCredito = legal.id and Estado = 'P'),0) as Abonadop,isnull((select sum(Interes) from CalendarioLegales where idCredito = legal.id and Estado = 'V'),0) as interesV,

isnull((select sum(Interes) from CalendarioLegales where idCredito = legal.id and Estado = 'L'),0) as interesL,
ISNULL((SELECT SUM(pendiente) from CalendarioLegales where idCredito = legal.id and Estado in ('P','V')),0) as PendienteLegal, ISNULL((select SUM(Monto) from GastosLegales where idCredito = Legal.id),0) as Gastos,
ISNULL((select top 1 Interes from CalendarioLegales where Estado = 'V' and idCredito = legal.id order by NPago asc),0) as InteresV1
 from
(select * from legales where Estado = 'C' and id = '" & idCredito & "') legal) DatosLegal) DatosPlegal"

        Dim comandoDeudaTotal As SqlCommand
        Dim readerDeudaTotal As SqlDataReader
        comandoDeudaTotal = New SqlCommand
        comandoDeudaTotal.Connection = conexionempresa
        comandoDeudaTotal.CommandText = consultaDeudaTotal
        readerDeudaTotal = comandoDeudaTotal.ExecuteReader
        If readerDeudaTotal.HasRows Then
            While readerDeudaTotal.Read
                pagoNormalTotal = readerDeudaTotal("pendientesinteres")
                multasTotal = readerDeudaTotal("moratoriommultas")
                nombreCredito = readerDeudaTotal("nombre")
            End While


        End If
        descuentoTotal = multasTotal

        TotalTotal = (pagoNormalTotal + multasTotal) - descuentoTotal
        subTotalTotal = (pagoNormalTotal + multasTotal)
        lblPagoNormalTotal.Text = FormatCurrency(pagoNormalTotal, 2)
        lblMultasTotal.Text = FormatCurrency(multasTotal, 2)
        lblDescuentoTotal.Text = FormatCurrency(descuentoTotal, 2)
        lblTotalTotal.Text = FormatCurrency(TotalTotal, 2)

        Dim consultaTotal As String

        consultaTotal = "select idPago,Monto, interes as interés,Abonado,Pendiente,calendariolegales.Estado,fechapago,calendariolegales.fechaultimopago from calendariolegales  where idcredito ='" & idCredito & "' and calendariolegales.estado <> 'L'"



        adapterTotal = New SqlDataAdapter(consultaTotal, conexionempresa)
        dataTotal = New DataTable
        adapterTotal.Fill(dataTotal)
    End Sub

    Private Sub RadCollapsiblePanel2_SizeChanged(sender As Object, e As EventArgs)
        RadCollapsiblePanel1.IsExpanded = False

        'GroupVencidos.Location = New Point(RadCollapsiblePanel1.Location.X, RadCollapsiblePanel1.Location.Y + RadCollapsiblePanel1.Size.Height + 4)
        'RadCollapsiblePanel2.Location = New Point(GroupVencidos.Location.X, GroupVencidos.Location.Y + GroupVencidos.Size.Height + 5)
    End Sub





    Private Sub BackgroundTotal_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTotal.RunWorkerCompleted
        dtTotal.DataSource = dataTotal
        ncargando.Close()
    End Sub







    Private Sub RadWizard1_Finish(sender As Object, e As EventArgs) Handles RadWizard1.Finish


        If descuentoTotal = 0 Then
            ncargando = New Cargando
            ncargando.Show()
            ncargando.MonoFlat_Label1.Text = "Creando Promesa"
            ncargando.TopMost = True
            BackgroundCrearPromesa.RunWorkerAsync()
        Else
            For Each row As DataRow In dataPermisos.Rows
                If row("SatiModCreditosDescuentoPromesa") Then
                    ncargando = New Cargando
                    ncargando.Show()
                    ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                    ncargando.TopMost = True
                    BackgroundCrearPromesa.RunWorkerAsync()
                    Exit For
                Else
                    If MessageBox.Show("¿No cuenta con los permisos para aplicar descuento, desea notificar a un usuario?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        ncargando = New Cargando
                        ncargando.Show()
                        ncargando.MonoFlat_Label1.Text = "Creando Promesa"
                        ncargando.TopMost = True
                        BackgroundPromesaNotificacion.RunWorkerAsync()


                    End If
                End If
            Next

        End If



    End Sub

    Private Sub BackgroundCrearPromesa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCrearPromesa.DoWork
        iniciarconexionempresa()
        Dim consultaCrearPromesa As String

        Dim comandoCrearPromesa As SqlCommand


        consultaCrearPromesa = "insert into PromesaDePago values('" & idCredito & "','" & TotalTotal & "','" & pagoNormalTotal & "','" & multasTotal & "','" & TotalTotal & "',0,'" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','" & nmusr & "','A','" & estadoCredito & "','" & subTotalTotal & "','" & descuentoTotal & "',0) SELECT SCOPE_IDENTITY()"


        comandoCrearPromesa = New SqlCommand
        comandoCrearPromesa.Connection = conexionempresa
        comandoCrearPromesa.CommandText = consultaCrearPromesa
        idPromesa = comandoCrearPromesa.ExecuteScalar


        For Each row As DataGridViewRow In dtTotal.Rows
            Dim consultaDetallePromesa As String
            Dim comandoDetallePromesa As SqlCommand
            consultaDetallePromesa = "insert into DetallePromesa values('" & idPromesa & "','" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "','" & row.Cells(7).Value & "','" & estadoCredito & "')"
            comandoDetallePromesa = New SqlCommand
            comandoDetallePromesa.Connection = conexionempresa
            comandoDetallePromesa.CommandText = consultaDetallePromesa
            comandoDetallePromesa.ExecuteNonQuery()

            Dim consultaActualizaCalConvenio As String
            Dim comandoActualizaCalConvenios As SqlCommand

            consultaActualizaCalConvenio = "Update calendariolegales set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"

            comandoActualizaCalConvenios = New SqlCommand
            comandoActualizaCalConvenios.Connection = conexionempresa
            comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio
            comandoActualizaCalConvenios.ExecuteNonQuery()

        Next





    End Sub

    Private Sub BackgroundCrearPromesa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCrearPromesa.RunWorkerCompleted
        ncargando.MonoFlat_Label1.Text = "Generando Formato"

        FileCopy("C:\ConfiaAdmin\SATI\Promesa.docx", "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx")
        Dim documento As DocX = DocX.Load("C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx")
        documento.ReplaceText("%%FECHAPROMESA%%", Date.Now.ToShortDateString)
        documento.ReplaceText("%%NOMBRECLIENTE%%", nombreCredito)

        documento.ReplaceText("%%TOTALDEUDA%%", FormatCurrency(TotalTotal, 2))

        documento.ReplaceText("%%FECHALIMITE%%", dateFechaLimite.Value.ToShortDateString)
        documento.Save()
        documento.Dispose()
        VistaPreviaDocumento.ruta = "C:\ConfiaAdmin\SATI\TEMPDOCS\TempPromesa.docx"
        VistaPreviaDocumento.Show()
        ncargando.Close()
        Me.Close()

    End Sub

    Private Sub BackgroundConsultarPromesa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultarPromesa.DoWork
        Dim consultaPromesa As String
        consultaPromesa = "if exists(Select * from promesadepago where idcredito = '" & idCredito & "' and estado = 'A' and tipocredito = '" & estadoCredito & "')
                            begin
                                select 'Existe'
                            end
                            else if exists(Select * from promesadepago where idcredito = '" & idCredito & "' and estado = 'E' and notificado = 0 and tipocredito = '" & estadoCredito & "')
							begin
							 select 'Pendiente'
							end
							else if exists(select * from promesadepago where idcredito = '" & idCredito & "' and estado = 'E' and Notificado = 1 and tipocredito = '" & estadoCredito & "')
                            begin
                             Select 'Notificado'
                            end
                            else
							select 'Noexiste'
"


        Dim comandoPromesa As SqlCommand
        comandoPromesa = New SqlCommand
        comandoPromesa.Connection = conexionempresa
        comandoPromesa.CommandText = consultaPromesa
        existePromesa = comandoPromesa.ExecuteScalar

    End Sub

    Private Sub BackgroundConsultarPromesa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultarPromesa.RunWorkerCompleted
        ncargando.Close()
        If existePromesa = "Existe" Then

            MessageBox.Show("El crédito ya cuenta con una promesa activa")
            Me.Close()
        ElseIf existePromesa = "Pendiente" Then
            MessageBox.Show("El crédito cuenta con una promesa pendiente, se intentará notificar de nuevo")

            ncargando = New Cargando
            ncargando.Show()
            ncargando.MonoFlat_Label1.Text = "Consultando Promesa"
            ncargando.TopMost = True
            BackgroundConsultaPromesaPendiente.RunWorkerAsync()

        ElseIf existePromesa = "Notificado" Then
            MessageBox.Show("El crédito cuenta con una notificación pendiente de autorizar")
            Me.Close()
        Else


        End If
    End Sub



    Private Sub BackgroundPromesaNotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPromesaNotificacion.DoWork
        iniciarconexionempresa()
        Dim consultaCrearPromesa As String

        Dim comandoCrearPromesa As SqlCommand


        consultaCrearPromesa = "insert into PromesaDePago values('" & idCredito & "','" & TotalTotal & "','" & pagoNormalTotal & "','" & multasTotal & "','" & TotalTotal & "',0,'" & dateFechaLimite.Value.ToString("yyyy-MM-dd") & "','','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "','" & nmusr & "','E','" & estadoCredito & "','" & subTotalTotal & "','" & descuentoTotal & "',0) SELECT SCOPE_IDENTITY()"


        comandoCrearPromesa = New SqlCommand
        comandoCrearPromesa.Connection = conexionempresa
        comandoCrearPromesa.CommandText = consultaCrearPromesa
        idPromesa = comandoCrearPromesa.ExecuteScalar


        For Each row As DataGridViewRow In dtTotal.Rows
            Dim consultaDetallePromesa As String
            Dim comandoDetallePromesa As SqlCommand
            consultaDetallePromesa = "insert into DetallePromesa values('" & idPromesa & "','" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "','" & row.Cells(5).Value & "','" & row.Cells(6).Value & "','" & row.Cells(7).Value & "','" & estadoCredito & "')"
            comandoDetallePromesa = New SqlCommand
            comandoDetallePromesa.Connection = conexionempresa
            comandoDetallePromesa.CommandText = consultaDetallePromesa
            comandoDetallePromesa.ExecuteNonQuery()
            Dim consultaActualizaCalConvenio As String
            Dim comandoActualizaCalConvenios As SqlCommand

            consultaActualizaCalConvenio = "Update calendariolegales set convenio = 1 where idpago = '" & row.Cells(0).Value & "'"

            comandoActualizaCalConvenios = New SqlCommand
            comandoActualizaCalConvenios.Connection = conexionempresa
            comandoActualizaCalConvenios.CommandText = consultaActualizaCalConvenio
            comandoActualizaCalConvenios.ExecuteNonQuery()


        Next


    End Sub

    Private Sub BackgroundPromesaNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPromesaNotificacion.RunWorkerCompleted
        ncargando.Close()
        CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
        CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
        CrearNotificacionDescuentoPromesa.ShowDialog()

        If creada Then
            Task.Factory.StartNew(Sub()
                                      Dim comandoActualizaPromesa As SqlCommand
                                      Dim consultaActualizaPromesa As String
                                      consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                      comandoActualizaPromesa = New SqlCommand
                                      comandoActualizaPromesa.Connection = conexionempresa
                                      comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                      comandoActualizaPromesa.ExecuteNonQuery()


                                  End Sub)
            Me.Close()
        Else
            If MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
                CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
                CrearNotificacionDescuentoPromesa.ShowDialog()
                If creada Then
                    Task.Factory.StartNew(Sub()
                                              Dim comandoActualizaPromesa As SqlCommand
                                              Dim consultaActualizaPromesa As String
                                              consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                              comandoActualizaPromesa = New SqlCommand
                                              comandoActualizaPromesa.Connection = conexionempresa
                                              comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                              comandoActualizaPromesa.ExecuteNonQuery()


                                          End Sub)
                    Me.Close()
                Else
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde")
                    Me.Close()

                End If
            Else
                Me.Close()
            End If

        End If


    End Sub

    Private Sub RadWizard1_Cancel(sender As Object, e As EventArgs) Handles RadWizard1.Cancel
        Me.Close()

    End Sub

    Private Sub BackgroundConsultaPromesaPendiente_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultaPromesaPendiente.DoWork
        iniciarconexionempresa()
        Dim consultaPromesa As String
        consultaPromesa = "select id from promesadepago where idcredito = '" & idCredito & "' and estado = 'E' and notificado = 0 and tipocredito = '" & estadoCredito & "'"
        Dim comandoPromesa As SqlCommand
        comandoPromesa = New SqlCommand
        comandoPromesa.Connection = conexionempresa
        comandoPromesa.CommandText = consultaPromesa
        idPromesa = comandoPromesa.ExecuteScalar

    End Sub

    Private Sub BackgroundConsultaPromesaPendiente_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultaPromesaPendiente.RunWorkerCompleted
        ncargando.Close()
        CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
        CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
        CrearNotificacionDescuentoPromesa.ShowDialog()

        If creada Then
            Task.Factory.StartNew(Sub()
                                      Dim comandoActualizaPromesa As SqlCommand
                                      Dim consultaActualizaPromesa As String
                                      consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                      comandoActualizaPromesa = New SqlCommand
                                      comandoActualizaPromesa.Connection = conexionempresa
                                      comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                      comandoActualizaPromesa.ExecuteNonQuery()


                                  End Sub)
            Me.Close()
        Else
            If MessageBox.Show("¿La notificación no fue creada, desea volver a intentarlo?", "SATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CrearNotificacionDescuentoPromesa.idPromesa = idPromesa
                CrearNotificacionDescuentoPromesa.tipoCredito = TipoCredito
                CrearNotificacionDescuentoPromesa.ShowDialog()
                If creada Then
                    Task.Factory.StartNew(Sub()
                                              Dim comandoActualizaPromesa As SqlCommand
                                              Dim consultaActualizaPromesa As String
                                              consultaActualizaPromesa = "update promesadepago set notificado = 1 where id = '" & idPromesa & "'"
                                              comandoActualizaPromesa = New SqlCommand
                                              comandoActualizaPromesa.Connection = conexionempresa
                                              comandoActualizaPromesa.CommandText = consultaActualizaPromesa
                                              comandoActualizaPromesa.ExecuteNonQuery()


                                          End Sub)
                    Me.Close()
                Else
                    MessageBox.Show("La notificación no fue creada, puedes intentarlo más tarde")
                    Me.Close()

                End If
            Else
                Me.Close()
            End If

        End If
    End Sub


End Class