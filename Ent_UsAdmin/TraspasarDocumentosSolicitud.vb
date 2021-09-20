Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class TraspasarDocumentosSolicitud
    Public ipOrigen As String
    Public bdOrigen As String
    Public cnOrigen As String
    Dim conexionOrigen As SqlClient.SqlConnection
    Public ipDestino As String
    Public bdDestino As String
    Dim cnDestino As String
    Dim conexionDestino As SqlClient.SqlConnection
    Dim dataDocumentosSolicitud As DataTable
    Dim adapterDocumentosSolicitud As SqlDataAdapter
    Dim ncargando As Cargando
    Public fila As String
    Public columna As String
    Dim tipo As String


    Private Sub TraspasarDocumentosSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub iniciarconexionOrigen()
        cnOrigen = "Data Source=  " & ipOrigen & "\confia;" &
                     "Initial Catalog=" & bdOrigen & ";" &
                     "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true"
        conexionOrigen = New SqlConnection(cnOrigen)
        conexionOrigen.Open()
    End Sub
    Private Sub iniciarconexionDestino()
        cnDestino = "Data Source=  " & ipDestino & "\confia;" &
                     "Initial Catalog=" & bdDestino & ";" &
                     "User Id=sa;Password=BSi5t3Ma$CFAD;MultipleActiveResultSets=true"
        conexionDestino = New SqlConnection(cnDestino)
        conexionDestino.Open()
    End Sub

    Private Sub btnOrigen_Click(sender As Object, e As EventArgs) Handles btnOrigen.Click
        EmpresasOrigenDocSolicitud.ShowDialog()

    End Sub

    Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnDestino.Click
        EmpresasDestinoDocSolicitud.ShowDialog()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionOrigen()

        adapterDocumentosSolicitud = New SqlDataAdapter(txtSQL.Text, conexionOrigen)
        dataDocumentosSolicitud = New DataTable
        adapterDocumentosSolicitud.Fill(dataDocumentosSolicitud)

    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Consultando"
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ncargando.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim abrircarpeta As OpenFileDialog
            abrircarpeta = New OpenFileDialog
            abrircarpeta.Filter = "Archivo de Excel|*.xls;*.xlsx"
            If abrircarpeta.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = abrircarpeta.FileName
            Else
                MessageBox.Show("No se seleccionó ningún archivo")
            End If
            ImportarExcelTraspaso.ShowDialog()

        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            ncargando = New Cargando

            ncargando.Show()
            ncargando.MonoFlat_Label1.Text = "Cargando datos"
            Dim intLoopCounter As Integer
            Dim contador1 As Integer
            Dim contador As Integer = 1
            Dim cantidadregistros As Integer = 1

            Dim fname As String
            Dim objXLApp As Excel.Application
            objXLApp = New Excel.Application
            fname = TextBox1.Text
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
                    ncargando.MonoFlat_Label1.Text = "" & contador & " registros de " & cantidadregistros - 1 & ""
                    '  BunifuCircleProgressbar1.Value = intLoopCounter
                    ' Sql = "insert into hotel(Nombre,telefono,email) values('" & .Range("" & Combonombre.Text & "" & intLoopCounter) & "','" & .Range("" & Combotelefono.Text & "" & intLoopCounter) & "','" & .Range("" & Comboemail.Text & "" & intLoopCounter) & "')"

                    dtDatos.Rows.Add(.Range("" & columna & "" & intLoopCounter).Value, .Range("" & columna & "" & intLoopCounter).Offset(0, 1).Value, .Range("" & columna & "" & intLoopCounter).Offset(0, 2).Value, .Range("" & columna & "" & intLoopCounter).Offset(0, 3).Value)

                    contador += 1
                Next intLoopCounter
                .Workbooks(1).Close(False)
                .Quit()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ncargando.Close()
    End Sub

    Private Sub BackgroundTraspaso_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTraspaso.DoWork
        iniciarconexionDestino()
        If tipo = "Solicitud" Then
            For Each row As DataRow In dataDocumentosSolicitud.Rows
                For Each rowid As DataGridViewRow In dtDatos.Rows
                    If row("IdDatosSolicitud").ToString = rowid.Cells(0).Value Then
                        Dim comandoDocumento As SqlCommand
                        Dim consultaDocumento As String
                        consultaDocumento = "insert into documentossolicitud values('" & rowid.Cells(1).Value & "','" & row("Tipo") & "',@imagen)"
                        Dim imgDocumento As New SqlParameter("@imagen", SqlDbType.Image)
                        imgDocumento.Value = row("Imagen")
                        comandoDocumento = New SqlCommand
                        comandoDocumento.Connection = conexionDestino
                        comandoDocumento.CommandText = consultaDocumento
                        comandoDocumento.Parameters.Add(imgDocumento)
                        comandoDocumento.ExecuteNonQuery()


                    End If
                Next
            Next
        Else
            For Each row As DataRow In dataDocumentosSolicitud.Rows
                For Each rowid As DataGridViewRow In dtDatos.Rows
                    If row("IdCredito").ToString = rowid.Cells(0).Value Then
                        Dim comandoDocumento As SqlCommand
                        Dim consultaDocumento As String
                        consultaDocumento = "insert into documentosCredito values('" & rowid.Cells(1).Value & "','" & row("Tipo") & "',@imagen)"
                        Dim imgDocumento As New SqlParameter("@imagen", SqlDbType.Image)
                        imgDocumento.Value = row("Imagen")
                        comandoDocumento = New SqlCommand
                        comandoDocumento.Connection = conexionDestino
                        comandoDocumento.CommandText = consultaDocumento
                        comandoDocumento.Parameters.Add(imgDocumento)
                        comandoDocumento.ExecuteNonQuery()


                    End If
                Next
            Next
        End If


    End Sub

    Private Sub BackgroundTraspaso_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTraspaso.RunWorkerCompleted
        ncargando.Close()

    End Sub

    Private Sub btnTraspasar_Click(sender As Object, e As EventArgs) Handles btnTraspasar.Click
        ncargando = New Cargando
        ncargando.Show()
        ncargando.MonoFlat_Label1.Text = "Realizando traspaso de documentos"
        BackgroundTraspaso.RunWorkerAsync()

    End Sub

    Private Sub RadioSolicitud_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSolicitud.CheckedChanged
        If RadioSolicitud.Checked Then
            tipo = "Solicitud"
        Else
            tipo = "Crédito"
        End If
    End Sub

    Private Sub RadioCredito_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCredito.CheckedChanged
        If RadioCredito.Checked Then
            tipo = "Crédito"
        Else
            tipo = "Solicitud"

        End If
    End Sub
End Class