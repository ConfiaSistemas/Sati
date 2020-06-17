Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class Migrar
    Public Archivo As String
    Public columna As String
    Public fila As String
    Private Sub Migrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtArchivo_OnValueChanged(sender As Object, e As EventArgs) Handles txtArchivo.OnValueChanged

    End Sub

    Private Sub txtArchivo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArchivo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim abrircarpeta As OpenFileDialog
            abrircarpeta = New OpenFileDialog
            abrircarpeta.Filter = "Archivo de Excel|*.xls;*.xlsx"
            If abrircarpeta.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtArchivo.Text = abrircarpeta.FileName
            Else
                MessageBox.Show("No se seleccionó ningún archivo")
            End If
            ImportarExcel.ShowDialog()

        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            Cargando.Show()
            Cargando.MonoFlat_Label1.Text = "Cargando datos"
            Dim intLoopCounter As Integer
            Dim contador1 As Integer
            Dim contador As Integer = 1
            Dim cantidadregistros As Integer = 1

            Dim fname As String
            Dim objXLApp As Excel.Application
            objXLApp = New Excel.Application
            fname = txtArchivo.Text
            With objXLApp
                .Workbooks.Open(fname)
                .Workbooks(1).Worksheets(1).Select()

                For intLoopCounter = fila To CInt(.ActiveSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row)
                    If Convert.ToString(.Range("" & columna & "" & intLoopCounter).Value) = "" Then
                        Exit For


                    End If

                    cantidadregistros += 1

                Next intLoopCounter

                For intLoopCounter = fila To cantidadregistros + fila - 2
                    'panelespera.Visible = True

                    '  BunifuCircleProgressbar1.MaxValue = cantidadregistros + fila - 2
                    Cargando.MonoFlat_Label1.Text = "" & contador & " registros de " & cantidadregistros - 1 & ""
                    '  BunifuCircleProgressbar1.Value = intLoopCounter
                    ' Sql = "insert into hotel(Nombre,telefono,email) values('" & .Range("" & Combonombre.Text & "" & intLoopCounter) & "','" & .Range("" & Combotelefono.Text & "" & intLoopCounter) & "','" & .Range("" & Comboemail.Text & "" & intLoopCounter) & "')"

                    dtimpuestos.Rows.Add(.Range("" & columna & "" & intLoopCounter).Value, .Range("" & columna & "" & intLoopCounter).Offset(0, 1).Value, .Range("" & columna & "" & intLoopCounter).Offset(0, 2).Value, .Range("" & columna & "" & intLoopCounter).Offset(0, 3).Value)

                    contador += 1
                Next intLoopCounter
                .Workbooks(1).Close(False)
                .Quit()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Cargando.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        iniciarconexionempresa()
        Dim canregistros As Integer
        canregistros = dtimpuestos.Rows.Count
        Dim numero As Integer = 1

        For Each row As DataGridViewRow In dtimpuestos.Rows
                Cargando.MonoFlat_Label1.Text = numero & " registros de '" & canregistros & "'"
                Dim comandoCalendario As SqlCommand
                Dim consultaCalendario As String
                Dim readerCalendario As SqlDataReader
                consultaCalendario = "select FechaPago,Monto,interes,fecha,estado,abonado,pendiente,npago,convenio from pagosext where id_credito = '" & row.Cells(0).Value & "' order by npago asc"
                comandoCalendario = New SqlCommand
                comandoCalendario.Connection = conexionempresa
                comandoCalendario.CommandText = consultaCalendario
                readerCalendario = comandoCalendario.ExecuteReader
                If readerCalendario.HasRows Then
                    While readerCalendario.Read
                        Dim consultaCalendarioSac As String
                    Dim comandoCalendarioSac As SqlCommand
                    Dim fechapago, monto, interes, pendiente, abonado, npago, id_credito, estado, convenio, fechaupago As String
                    fechapago = readerCalendario("fechapago")
                    monto = readerCalendario("monto")
                    interes = readerCalendario("interes")
                    pendiente = readerCalendario("pendiente")
                    abonado = readerCalendario("abonado")
                    npago = readerCalendario("npago")
                    id_credito = row.Cells(2).Value
                    estado = readerCalendario("estado")
                    convenio = readerCalendario("convenio")
                    fechaupago = readerCalendario("fecha")

                    consultaCalendarioSac = "insert into calendarionormal values('" & fechapago & "','" & monto & "','" & interes & "','" & pendiente & "','" & abonado & "','" & readerCalendario("npago") & "','" & id_credito & "','" & estado & "','" & convenio & "','" & fechaupago & "')"
                    comandoCalendarioSac = New SqlCommand
                        comandoCalendarioSac.Connection = conexionempresa
                        comandoCalendarioSac.CommandText = consultaCalendarioSac
                        comandoCalendarioSac.ExecuteNonQuery()

                    End While

                End If
                Dim comandoActEstado As SqlCommand
                Dim consultaActEstado As String
                consultaActEstado = "update credito set estado = '" & row.Cells(3).Value & "' where id = '" & row.Cells(2).Value & "'"
                comandoActEstado = New SqlCommand
                comandoActEstado.Connection = conexionempresa
                comandoActEstado.CommandText = consultaActEstado
                comandoActEstado.ExecuteNonQuery()

                numero += 1

            Next


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Información"
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Cargando.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class