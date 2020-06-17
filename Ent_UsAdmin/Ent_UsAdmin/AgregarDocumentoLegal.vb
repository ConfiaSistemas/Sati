Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AgregarDocumentoLegal
    Dim nombre As String
    Dim dataDocumento As DataTable
    Dim adapterDocumento As SqlClient.SqlDataAdapter
    Dim cargado As Boolean
    Dim imagenNada As Image = My.Resources.new_seo2_38_512
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Imágenes (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png"
        openFileDialog1.FilterIndex = 1

        openFileDialog1.ShowDialog()
        If openFileDialog1.FileName <> "" Then
            nombre = openFileDialog1.FileName
            BunifuImageButton1.Image = Image.FromFile(nombre)
            ' labelimagen.Visible = False

        Else
            MessageBox.Show("No se seleccionó ningún archivo")

        End If

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        If BunifuImageButton1.Image Is My.Resources.new_seo2_38_512 Then
            MessageBox.Show("Debe seleccionar una imagen")
        Else
            Dim idTipoDocumento As Integer
            idTipoDocumento = ConsultarIdTipo(ComboDocumento.Text)
            DocumentosCreditoLegal.dtdatosDocumentosNuevos.Rows.Add(idTipoDocumento, ComboDocumento.Text, BunifuImageButton1.Image)
            BunifuImageButton1.Image = My.Resources.new_seo2_38_512
        End If


    End Sub

    Private Sub AgregarDocumentoDatosSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Tipos de Documentos"
        BackgroundTiposDocumentos.RunWorkerAsync()
    End Sub

    Private Sub BackgroundTiposDocumentos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundTiposDocumentos.DoWork

        Try
            iniciarconexionempresa()
            Dim consulta As String
            consulta = "Select id,Nombre from tiposdeDocumentosSolicitud "
            adapterDocumento = New SqlDataAdapter(consulta, conexionempresa)
            dataDocumento = New DataTable
            adapterDocumento.Fill(dataDocumento)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try
    End Sub

    Private Sub BackgroundTiposDocumentos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTiposDocumentos.RunWorkerCompleted
        ComboDocumento.Items.Clear()
        For Each row As DataRow In dataDocumento.Rows
            ComboDocumento.Items.Add(row("Nombre").ToString)

        Next
        Cargando.Close()
    End Sub
    Private Function ConsultarIdTipo(nombre As String) As Integer
        Dim idTipo As Integer

        For Each row As DataRow In dataDocumento.Rows
            If row("Nombre").ToString = nombre Then
                idTipo = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idTipo
    End Function
End Class