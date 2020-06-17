Imports System.IO

Public Class slider
    Dim ARCHIVOS As ObjectModel.ReadOnlyCollection(Of String)
    Dim CONTADOR As Integer = 0
    Dim extension As String
    Private Sub slider_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        Timer1.Start()

        Try
            If CONTADOR < ARCHIVOS.Count - 1 Then
                extension = Path.GetExtension(ARCHIVOS(CONTADOR))
                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Or extension = ".ico" Then
                    PictureBox1.Image = Bitmap.FromFile(ARCHIVOS(CONTADOR))

                    CONTADOR += 1
                Else

                    CONTADOR += 1
                End If
               

            Else
                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Or extension = ".ico" Then
                    PictureBox1.Image = Bitmap.FromFile(ARCHIVOS(CONTADOR))



                    CONTADOR = 0
                Else
                    CONTADOR = 0

                End If
            End If
        Catch ex As Exception
            Timer1.Stop()

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim CARPETA As String
            CARPETA = FolderBrowserDialog1.SelectedPath
            ARCHIVOS = My.Computer.FileSystem.GetFiles(CARPETA)
        End If
        Timer1.Enabled = True

    End Sub
End Class