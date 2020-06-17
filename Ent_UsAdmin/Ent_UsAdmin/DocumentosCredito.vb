Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class DocumentosCredito
    Public idCredito As String
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        AgregarDocumentoCredito.ShowDialog()
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

            consultaDocumento = "insert into DocumentosCredito values('" & idCredito & "','" & row.Cells(0).Value & "',@Documento)"
            Dim imgDocumento As New SqlParameter("@Documento", SqlDbType.Image)
            Dim msImgDocumento As New MemoryStream
            imagen.Save(msImgDocumento, ImageFormat.Jpeg)
            imgDocumento.Value = msImgDocumento.GetBuffer
            comandoDocumento = New SqlCommand
            comandoDocumento.Connection = conexionempresa
            comandoDocumento.CommandText = consultaDocumento
            comandoDocumento.Parameters.Add(imgDocumento)
            comandoDocumento.ExecuteNonQuery()

        Next
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Insertando Documentos"
        Cargando.TopMost = True
        BackgroundDocumentos.RunWorkerAsync()

    End Sub

    Private Sub BackgroundDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundDocumentos.RunWorkerCompleted
        Me.Invoke(Sub()
                      InformacionSolicitud.BackgroundClientes.RunWorkerAsync()

                  End Sub)
        Cargando.Close()
        Me.Close()
    End Sub
End Class