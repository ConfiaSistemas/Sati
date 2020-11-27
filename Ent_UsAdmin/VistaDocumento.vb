Public Class VistaDocumento
    Dim PicCopy As Image
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'PictureBox1.Image.Save(SaveFileDialog1.FileName)


    End Sub

    Private Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyDown

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim SaveFileDialog1 As SaveFileDialog
        SaveFileDialog1 = New SaveFileDialog

        SaveFileDialog1.Filter = "Archivo imagen (*.jpg*)|*.jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName)


        End If
    End Sub

    Private Sub VistaDocumento_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged

    End Sub

    Private Sub VistaDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Oemplus Then
            Dim btmap As New Bitmap(PictureBox1.Image)

            btmap.RotateFlip(RotateFlipType.Rotate90FlipY)
            PictureBox1.Image = btmap
        End If
    End Sub

    Private Sub VistaDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class