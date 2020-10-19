Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CalendarioConvenio
    Public idCredito As Integer
    Public deuda As Double
    Public cantPagos As Integer
    Public MontoPago As Double
    Public PrimerPago As Date
    Public Modalidad As String
    Public deudaTotal As Double
    Public gestor As Integer

    Public Moratorios As Double = 0
    Public personalizado As Boolean
    Public Capital As Double = 0
    Public Autorizado As Boolean

    Private Sub CalendarioConvenioLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim proporcionMoratorio As Double
        proporcionMoratorio = ProporcionMoratorios(Moratorios, deudaTotal)

        Dim fechapago As Date
        Dim numero As Integer = 0
        Dim parteMora As Double
        Dim parteCred As Double

        If Modalidad = "S" Then
            For i As Integer = 1 To cantPagos - 1
                parteMora = MontoPago * proporcionMoratorio
                parteCred = MontoPago - parteMora
                fechapago = PrimerPago.AddDays(numero * 7)
                deuda = deuda - MontoPago
                dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago, parteCred, parteMora)
                numero += 1

            Next
            parteMora = deuda * proporcionMoratorio
            parteCred = deuda - parteMora
            fechapago = PrimerPago.AddDays(numero * 7)
            dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), deuda, parteCred, parteMora)
        Else
            For i As Integer = 1 To cantPagos - 1
                parteMora = MontoPago * proporcionMoratorio
                parteCred = MontoPago - parteMora
                If PrimerPago.Day = 16 Then
                    fechapago = PrimerPago
                    dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago, parteCred, parteMora)
                    If PrimerPago.Month = 12 Then
                        PrimerPago = Convert.ToDateTime(PrimerPago.AddYears(1).Year.ToString & "-" & PrimerPago.AddMonths(1).Month.ToString & "-" & "01")
                    Else
                        PrimerPago = Convert.ToDateTime(PrimerPago.Year.ToString & "-" & PrimerPago.AddMonths(1).Month.ToString & "-" & "01")
                    End If

                    deuda = deuda - MontoPago
                Else
                    fechapago = PrimerPago
                    dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), MontoPago, parteCred, parteMora)
                    PrimerPago = Convert.ToDateTime(PrimerPago.Year.ToString & "-" & PrimerPago.Month.ToString & "-" & "16")
                    deuda = deuda - MontoPago
                End If
            Next
            parteMora = deuda * proporcionMoratorio
            parteCred = deuda - parteMora
            fechapago = PrimerPago
            dtimpuestos.Rows.Add(fechapago.ToString("yyyy-MM-dd"), deuda, parteCred, parteMora)

        End If
    End Sub
    Private Function ProporcionMoratorios(Moratorios As Double, deuda As Double) As Double
        Dim proporcion As Double
        proporcion = Moratorios / deuda
        Return proporcion
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub dtimpuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtimpuestos.CellContentClick

    End Sub

    Private Sub dtimpuestos_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dtimpuestos.RowPostPaint
        Try
            'Captura el numero de filas del datagridview
            Dim RowsNumber As String = (e.RowIndex + 1).ToString
            While RowsNumber.Length < dtimpuestos.RowCount.ToString.Length
                RowsNumber = "0" & RowsNumber
            End While
            Dim size As SizeF = e.Graphics.MeasureString(RowsNumber, Me.Font)
            If dtimpuestos.RowHeadersWidth < CInt(size.Width + 20) Then
                dtimpuestos.RowHeadersWidth = CInt(size.Width + 20)
            End If
            Dim ob As Brush = SystemBrushes.ControlDark
            e.Graphics.DrawString(RowsNumber, Me.Font, ob, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "vb.net",
         MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackgroundConvenio_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConvenio.DoWork
        'Dim consultaConvenio As String
        Dim pagoprimero As String
        Dim ultimopago As String

        For Each row As DataGridViewRow In dtimpuestos.Rows
            If row.Index = 0 Then
                pagoprimero = row.Cells(0).Value
            End If
            ultimopago = row.Cells(0).Value
        Next

        Dim comandoConvenio As SqlCommand
        Dim consultaConvenio As String
        Dim idConvenio As Integer
        consultaConvenio = "insert into ConveniosSac values('" & idCredito & "','" & cantPagos & "','" & Moratorios & "','" & Capital & "','" & deudaTotal & "','" & pagoprimero & "','" & ultimopago & "','" & Date.Now.ToString("yyyy-MM-dd") & "','" & gestor & "','A') select SCOPE_IDENTITY()"
        comandoConvenio = New SqlCommand

        comandoConvenio.Connection = conexionempresa
        comandoConvenio.CommandText = consultaConvenio
        idConvenio = comandoConvenio.ExecuteScalar

        Dim numero As Integer = 1
        For Each row As DataGridViewRow In dtimpuestos.Rows
            Dim comandoCalendario As SqlCommand

            Dim consultaCalendario As String
            consultaCalendario = "Insert into calendarioConveniosSac values('" & numero & "','" & row.Cells(2).Value & "','" & row.Cells(1).Value & "','0','" & row.Cells(0).Value & "','','" & idConvenio & "','P','" & row.Cells(3).Value & "','0','" & row.Cells(3).Value & "')"
            comandoCalendario = New SqlCommand
            comandoCalendario.Connection = conexionempresa
            comandoCalendario.CommandText = consultaCalendario
            comandoCalendario.ExecuteNonQuery()
            numero += 1
        Next

        Dim comandoActCreditoLegal As SqlCommand
        Dim consultaActCreditoLegal As String
        consultaActCreditoLegal = "update credito set estado = 'C' where id = '" & idCredito & "'"
        comandoActCreditoLegal = New SqlCommand
        comandoActCreditoLegal.Connection = conexionempresa
        comandoActCreditoLegal.CommandText = consultaActCreditoLegal
        comandoActCreditoLegal.ExecuteNonQuery()


        Dim comandoCongelaMultas As SqlCommand
        Dim consultaCongelaMultas As String
        consultaCongelaMultas = "update calendarionormal set convenio = 1 where id_credito = '" & idCredito & "' and (estado = 'V' or estado = 'P')"
        comandoCongelaMultas = New SqlCommand
        comandoCongelaMultas.Connection = conexionempresa
        comandoCongelaMultas.CommandText = consultaCongelaMultas
        comandoCongelaMultas.ExecuteNonQuery()

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        Autorizacion.tipoAutorizacion = "SatiModCreditosCrearConvenio"
        Autorizacion.ShowDialog()
        If Autorizado Then
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Generando Convenio"
            Cargando.TopMost = True
            BackgroundConvenio.RunWorkerAsync()
        Else
            MessageBox.Show("No fue autorizado")
        End If



    End Sub

    Private Sub BackgroundConvenio_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConvenio.RunWorkerCompleted
        InformacionSolicitud.idCredito = idCredito
        InformacionSolicitud.Show()
        Cargando.Close()
        Me.Close()

    End Sub
End Class