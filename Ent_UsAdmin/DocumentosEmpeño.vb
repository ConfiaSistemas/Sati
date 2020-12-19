Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DocumentosEmpeño
    Public idEmpeño As String
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarDocumentoEmpeño.ShowDialog()
    End Sub



    Private Sub dtdatosDocumentosNuevos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatosDocumentosNuevos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dtdatosDocumentosNuevos.Rows.Count <> 0 Then
                dtdatosDocumentosNuevos.Rows.RemoveAt(dtdatosDocumentosNuevos.CurrentRow.Index)
            End If

        End If
    End Sub



    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundDocumentos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundDocumentos.DoWork
        iniciarconexionempresa()

        For Each row As DataGridViewRow In dtdatosDocumentosNuevos.Rows
            Dim comandoDocumento As SqlCommand
            Dim consultaDocumento As String
            Dim imagen As Bitmap = TryCast(row.Cells(2).Value, Bitmap)
            Dim NuevaImagen As Bitmap = ImagenComprimida(imagen)
            consultaDocumento = "insert into DocumentosEmpeño values('" & idEmpeño & "','" & row.Cells(0).Value & "',@Documento)"
            Dim imgDocumento As New SqlParameter("@Documento", SqlDbType.Image)
            Dim msImgDocumento As New MemoryStream
            NuevaImagen.Save(msImgDocumento, ImageFormat.Jpeg)
            imgDocumento.Value = msImgDocumento.GetBuffer
            comandoDocumento = New SqlCommand
            comandoDocumento.Connection = conexionempresa
            comandoDocumento.CommandText = consultaDocumento
            comandoDocumento.Parameters.Add(imgDocumento)
            comandoDocumento.ExecuteNonQuery()

        Next
    End Sub
    Private Function ImagenComprimida(bmp As Bitmap) As Bitmap
        Try

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
            If Factor < Factorlimit Then
                'draw a new image with the dimensions that result from the resizing
                Dim bmpnew As New Bitmap(bmp.Width * Factor, bmp.Height * Factor,
                    Imaging.PixelFormat.Format24bppRgb)
                Dim g As Graphics = Graphics.FromImage(bmpnew)
                g.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                'and paste the resized image into it
                g.DrawImage(bmp, 0, 0, bmpnew.Width, bmpnew.Height)
                Return bmpnew
            Else
                Return bmp
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Insertando Documentos..."
        Cargando.TopMost = True
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        Me.Invoke(Sub()
                      InformacionEmpeño.BackgroundArticulos.RunWorkerAsync()

                  End Sub)
        Cargando.Close()
        Me.Close()
    End Sub
End Class