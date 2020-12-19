Imports System.ComponentModel
Imports System.IO

Public Class ComprimirImagenes
    Private Sub ComprimirImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Sub Resizer(ByVal photo As Int32)
        iniciarconexionempresa()
        Dim cmd As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader
        cmd = conexionempresa.CreateCommand()
        'query to retrieve the rows from the table that contain images 
        '(only the actual column that contains the id is retrieved for all rows 
        'that contain a non-empty blob)
        If RadioSolicitud.Checked Then
            cmd.CommandText = "SELECT imagen FROM documentosSolicitud where id = '" & photo & "' "
        End If
        If RadioCredito.Checked Then
            cmd.CommandText = "SELECT imagen FROM documentoscredito where id = '" & photo & "' "
        End If

        reader = cmd.ExecuteReader
        If reader.Read Then
            Dim imgByteArray() As Byte
            'try to resize the image, else fail with error and resume to next
            Try
                'read the image as a stream and make a bitmap out of it
                imgByteArray = CType(reader(0), Byte())
                Dim stream As New MemoryStream(imgByteArray)
                Dim bmp As New Bitmap(stream)
                stream.Close()
                'start resizing the retrieved image. First the current dimensions are checked.
                Dim Width As Integer = bmp.Width
                Dim Height As Integer = bmp.Height
                'next we declare the maximum size of the resized image. 
                'In this case, all resized images need to be constrained to a 173x173 square.
                Dim Heightmax As Integer = 1572
                Dim Widthmax As Integer = 1826
                'declare the minimum value af the resizing factor before proceeding. 
                'All images with a lower factor than this will actually be resized
                Dim Factorlimit As Decimal = 1
                'determine if it is a portrait or landscape image
                Dim Relative As Decimal = Height / Width
                Dim Factor As Decimal
                'if the image is a portrait image, calculate the resizing factor based on its height. 
                'else the image is a landscape image, 
                'and we calculate the resizing factor based on its width.
                If Relative > 1 Then
                    If Height < (Heightmax + 1) Then
                        Factor = 1
                    Else
                        Factor = Heightmax / Height
                    End If
                    '
                Else
                    If Width < (Widthmax + 1) Then
                        Factor = 1
                    Else
                        Factor = Widthmax / Width
                    End If
                End If
                'if the resizing factor is lower than the set limit, start processing the image, 
                'else proceed to the next image
                If Factor < Factorlimit Then
                    'draw a new image with the dimensions that result from the resizing
                    Dim bmpnew As New Bitmap(bmp.Width * Factor, bmp.Height * Factor,
                        Imaging.PixelFormat.Format24bppRgb)
                    Dim g As Graphics = Graphics.FromImage(bmpnew)
                    g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                    'and paste the resized image into it
                    g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height)
                    reader.Close()
                    Dim cmdstore As SqlClient.SqlCommand
                    cmdstore = conexionempresa.CreateCommand()
                    'run an update query to set the image back to its original tablerow. 
                    'Effectively reversing the retrieval mechanism, using the image stream 
                    'as a variable in the query.
                    If RadioSolicitud.Checked Then
                        cmdstore.CommandText = "Update documentossolicitud SET imagen=@image WHERE id=" & photo
                    End If
                    If RadioCredito.Checked Then
                        cmdstore.CommandText = "Update documentoscredito SET imagen=@image WHERE id=" & photo
                    End If

                    Dim streamstore As New MemoryStream
                    bmpnew.Save(streamstore, Imaging.ImageFormat.Jpeg)
                    imgByteArray = streamstore.ToArray()
                    streamstore.Close()
                    cmdstore.Parameters.AddWithValue("@Image", imgByteArray)
                    'Execute the query and report a success if succeeded, else give the error.
                    If DirectCast(cmdstore.ExecuteNonQuery(), Integer) > 0 Then
                        Console.WriteLine("{0} ", photo & " stored")
                    End If
                End If
                ' if the processing fails, give the id of the image and the error
            Catch ex As Exception
                Console.WriteLine("{0} ", photo & ": " & ex.Message)
            End Try
        End If
        'Close and dispose the objects used. Ready to proceed to the next image.
        reader.Close()

        cmd.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckForIllegalCrossThreadCalls = False

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim photo As Int32
        Dim numero As Integer = 1
        Dim cmdtotal As New SqlClient.SqlCommand
        Dim readertotal As SqlClient.SqlDataReader
        cmdtotal = conexionempresa.CreateCommand()
        'query to retrieve the rows from the table that contain images 
        '(only the actual column that contains the id is retrieved for all rows 
        'that contain a non-empty blob)
        Dim comandoTotal As SqlClient.SqlCommand

        Dim totalRegistros As Integer
        Dim consultaTotal As String
        comandoTotal = New SqlClient.SqlCommand
        If RadioSolicitud.Checked Then
            consultaTotal = "select count(id) from documentossolicitud"

        End If
        If RadioCredito.Checked Then
            consultaTotal = "select count(id) from documentoscredito"
        End If

        comandoTotal.Connection = conexionempresa
        comandoTotal.CommandText = consultaTotal
        totalRegistros = comandoTotal.ExecuteScalar


        If RadioSolicitud.Checked Then
            cmdtotal.CommandText = "SELECT id FROM documentossolicitud"
        End If
        If RadioCredito.Checked Then
            cmdtotal.CommandText = "SELECT id FROM documentoscredito"
        End If

        readertotal = cmdtotal.ExecuteReader
        'for each result in the dataset, run the resizer and pass it the id of the specific image
        Do Until readertotal.Read = False
            Label1.Text = numero & " de " & totalRegistros
            photo = readertotal.GetInt32(0)
            Resizer(photo)
            numero += 1


        Loop
        'dispose of all used objects
        readertotal.Close()

        cmdtotal.Dispose()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MessageBox.Show("Terminado")
    End Sub
End Class