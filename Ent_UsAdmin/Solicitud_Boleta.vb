Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading.Tasks

Public Class Solicitud_Boleta

    Dim idtipo, tipo, nombreTipo, Modalidad, tipocredito, porcentajeSugerido As String
    Dim plazoTipo, porcentajeRefrendo As Double
    Dim consultadoTipo As Boolean
    Dim nombreCliente, idCliente As String
    Dim consultadoCliente As Boolean
    Dim totalintegrantes As Integer = 0
    Dim dataGestores As DataSet
    Dim dataPromotores As DataSet
    Dim adapterGestores As SqlDataAdapter
    Dim adapterPromotores As SqlDataAdapter
    Dim dataLegal As DataSet
    Dim adapterLegal As SqlDataAdapter
    Dim totalMoratorios As Double
    Dim empezar As Boolean
    Dim MontoTotal As Double = 0
    Dim esta As String
    Dim usarNombre As Boolean
    Public autorizado As Boolean
    Dim dataTipo As DataTable
    Dim adapterTipo As SqlDataAdapter
    Dim totalValuado As Double = 0
    Dim totalSugerido As Double = 0
    Dim errorValuado, errorSugerido As Boolean
    Dim idSolicitudBoleta As Integer
    Dim estabien As Boolean
    Dim tieneFocus As Boolean

    Private Sub Levantar_Solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargando.Show()
        Cargando.MonoFlat_Label1.Text = "Cargando Gestores"
        BackgroundGestores.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuscarClienteEmpeño.Show()
    End Sub

    Private Sub btn_agregar_click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            Dim bm As New Bitmap(txtPrenda.Text)
            dtdatos.Rows.Add(bm, "", "", "", "", "")
            For Each row As DataGridViewRow In dtdatos.Rows
                row.Height = 100
            Next
            For Each row As DataGridViewRow In dtdatos.Rows
                If row.Cells(1).Value = "" Then
                    dtdatos.Focus()
                    dtdatos.CurrentCell = dtdatos(row.Cells(1).ColumnIndex, row.Index)
                End If
            Next
        Catch ex As System.ArgumentException
            MessageBox.Show("La ruta de la imagen no es válida")
            txtPrenda.Select()

            txtPrenda.Text = ""
        End Try

    End Sub


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BackgroundGestores_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundGestores.DoWork

        Try
            iniciarconexionempresa()
            Dim consulta As String
            consulta = "Select id,nombre from empleados where tipo = 'G'"
            adapterGestores = New SqlDataAdapter(consulta, conexionempresa)
            dataGestores = New DataSet
            adapterGestores.Fill(dataGestores)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TiposDeEmpeños.Show()
    End Sub

    Private Sub BackgroundPromotores_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundPromotores.DoWork
        Try
            iniciarconexionempresa()
            Dim consulta As String
            consulta = "Select id,nombre from empleados where tipo = 'P'"
            adapterPromotores = New SqlDataAdapter(consulta, conexionempresa)
            dataPromotores = New DataSet
            adapterPromotores.Fill(dataPromotores)
            empezar = True
        Catch ex As Exception
            empezar = False
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub

    Public Sub ConsultarTipocredito()
        Try
            iniciarconexionempresa()
            Dim comando As SqlCommand
            Dim consulta As String
            Dim reader As SqlDataReader
            consulta = "select id,nombre,porcentajerefrendo, porcentajeSugerido from TiposDeEmpeño where id = '" & txtTipo.Text & "'"
            comando = New SqlCommand
            comando.Connection = conexionempresa
            comando.CommandText = consulta
            reader = comando.ExecuteReader
            If reader.HasRows Then
                While reader.Read

                    nombreTipo = reader("nombre")


                    idtipo = txtTipo.Text

                    porcentajeRefrendo = reader("porcentajerefrendo")

                    porcentajeSugerido = reader("porcentajeSugerido")
                End While
                lblTipo.Text = nombreTipo
                txtMontoTotalSugerido.Text = plazoTipo
                txtPorcentajeRefrendo.Text = porcentajeRefrendo

            Else
                lblTipo.Text = "No se encontró"
            End If


            consultadoTipo = True
        Catch ex As Exception
            lblTipo.Text = "..."
            consultadoTipo = False
            MessageBox.Show("Ha ocurrido un error " & ex.Message)
        End Try

    End Sub


    Public Sub ConsultarCliente()
        iniciarconexionempresa()
        Dim comando As SqlCommand
        Dim consulta As String
        Dim reader As SqlDataReader
        consulta = "select id,id,(nombre+' '+apellidoPaterno+' '+apellidoMaterno) as nombre from clientes where id = '" & txtIdCliente.Text & "'"
        comando = New SqlCommand
        comando.Connection = conexionempresa
        comando.CommandText = consulta
        reader = comando.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                idCliente = reader("id")
                nombreCliente = reader("nombre")
            End While

            lblCliente.Text = nombreCliente
            consultadoCliente = True
        Else
            consultadoCliente = False
            lblCliente.Text = "No se encontró"
        End If
    End Sub


    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionempresa()
        Dim comandoSolicitud As SqlCommand
        Dim consultaSolicitud As String

        consultaSolicitud = "insert into SolicitudBoleta values(" & txtIdCLiente.Text & ",'" & lblCliente.Text & "','','','','','','','','" & txtMontoTotalValuado.Text & "'," & txtMontoTotalSugerido.Text & "," & txtPorcentajeRefrendo.Text & ",'','" & Now.Date.ToString("yyyy-MM-dd") & "','I','" & txtTipo.Text & "','" & ConsultarIdPromotor(ComboPromotor.Text) & "','" & nmusr & "','','') select SCOPE_IDENTITY()"
        comandoSolicitud = New SqlCommand
        comandoSolicitud.Connection = conexionempresa
        comandoSolicitud.CommandText = consultaSolicitud
        idSolicitudBoleta = comandoSolicitud.ExecuteScalar

        For Each row As DataGridViewRow In dtdatos.Rows
            Dim consultaArticulos As String = "insert into articulosempeños values(" & idSolicitudBoleta & ",'" & ConsultarTipo(row.Cells(1).Value) & "','" & row.Cells(5).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "'," & row.Cells(6).Value & "," & row.Cells(7).Value & ",'',@imagen,1)"
            Dim comandoArticulo As SqlCommand
            Dim imagen As Bitmap = TryCast(row.Cells(0).Value, Bitmap)
            Dim imgDocumento As New SqlParameter("@imagen", SqlDbType.Image)
            Dim msImgDocumento As New MemoryStream
            imagen.Save(msImgDocumento, ImageFormat.Jpeg)
            imgDocumento.Value = msImgDocumento.GetBuffer
            comandoArticulo = New SqlCommand
            comandoArticulo.Connection = conexionempresa
            comandoArticulo.CommandText = consultaArticulos
            comandoArticulo.Parameters.Add(imgDocumento)
            comandoArticulo.ExecuteNonQuery()

        Next

        Dim comandoCronograma As SqlCommand
        Dim consultaCronograma As String
        Dim tiempo As String = TimeOfDay.ToString("HH:mm:ss")
        consultaCronograma = "insert into CronogramaSolicitudEmpeño values('" & Now.ToString("yyyy-MM-dd") & "','" & tiempo & "','" & idSolicitudBoleta & "','Se registró la solicitud por " & nmusr & "')"
        comandoCronograma = New SqlCommand
        comandoCronograma.Connection = conexionempresa
        comandoCronograma.CommandText = consultaCronograma
        comandoCronograma.ExecuteNonQuery()

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click

        If dtdatos.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dtdatos.Rows
                If row.Cells(1).Value = "" Then
                    MessageBox.Show("La columna Tipo está vacía, todos los campos son obligatorios")
                    dtdatos.Focus()
                    dtdatos.CurrentCell = dtdatos(row.Cells(1).ColumnIndex, row.Index)
                    Exit For


                Else
                    If row.Cells(2).Value = "" Then
                        MessageBox.Show("La columna Marca está vacía, todos los campos son obligatorios")
                        dtdatos.Focus()
                        dtdatos.CurrentCell = dtdatos(row.Cells(2).ColumnIndex, row.Index)
                        Exit For
                    Else
                        If row.Cells(3).Value = "" Then
                            MessageBox.Show("La columna Modelo está vacía, todos los campos son obligatorios")
                            dtdatos.Focus()
                            dtdatos.CurrentCell = dtdatos(row.Cells(3).ColumnIndex, row.Index)
                            Exit For
                        Else
                            If row.Cells(4).Value = "" Then
                                MessageBox.Show("La columna No. de Serie está vacía, todos los campos son obligatorios")
                                dtdatos.Focus()
                                dtdatos.CurrentCell = dtdatos(row.Cells(4).ColumnIndex, row.Index)
                                Exit For
                            Else
                                If row.Cells(5).Value = "" Then
                                    MessageBox.Show("La columna Descripción está vacía, todos los campos son obligatorios")
                                    dtdatos.Focus()
                                    dtdatos.CurrentCell = dtdatos(row.Cells(5).ColumnIndex, row.Index)
                                    Exit For
                                Else
                                    If row.Cells(6).Value = "" Then
                                        MessageBox.Show("La columna Monto Valuado está vacía, todos los campos son obligatorios")
                                        dtdatos.Focus()
                                        dtdatos.CurrentCell = dtdatos(row.Cells(6).ColumnIndex, row.Index)
                                        Exit For

                                    Else
                                        If IsNumeric(row.Cells(6).Value) Then
                                            If row.Cells(7).Value.ToString = "" Then
                                                MessageBox.Show("La columna Monto Sugerido está vacía, todos los campos son obligatorios")
                                                dtdatos.Focus()
                                                dtdatos.CurrentCell = dtdatos(row.Cells(7).ColumnIndex, row.Index)
                                                estabien = False
                                                Exit For
                                            Else
                                                If IsNumeric(row.Cells(7).Value) Then
                                                    estabien = True
                                                Else
                                                    MessageBox.Show("La columna Monto Sugerido solo admite valores numéricos")
                                                    dtdatos.Focus()
                                                    dtdatos.CurrentCell = dtdatos(row.Cells(7).ColumnIndex, row.Index)
                                                    estabien = False
                                                    Exit For
                                                End If
                                            End If
                                        Else
                                            MessageBox.Show("La columna Monto Valuado solo admite valores numéricos")
                                            dtdatos.Focus()
                                            dtdatos.CurrentCell = dtdatos(row.Cells(6).ColumnIndex, row.Index)
                                            Exit For
                                        End If


                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            If estabien Then
                Autorizacion.tipoAutorizacion = "SatiModEmpeñosAgregarSolicitud"
                Autorizacion.ShowDialog()
                If autorizado Then
                    Cargando.Show()
                    Cargando.MonoFlat_Label1.Text = "Procesando"
                    BackgroundWorker1.RunWorkerAsync()
                Else
                    MessageBox.Show("No fue autorizado")
                End If

            End If



        Else
            MessageBox.Show("La solicitud no cuenta con ningún artículo")
            txtPrenda.Select()
        End If

    End Sub

    Private Sub dtdatos_KeyDown(sender As Object, e As KeyEventArgs) Handles dtdatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dtdatos.Rows.Count <> 0 Then
                dtdatos.Rows.RemoveAt(dtdatos.CurrentCell.RowIndex)
            End If

        End If
    End Sub



    Private Sub ComboLegal_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundGestores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundGestores.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Cargando Promotores"
        BackgroundPromotores.RunWorkerAsync()

    End Sub


    Private Sub BackgroundPromotores_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundPromotores.RunWorkerCompleted
        Cargando.MonoFlat_Label1.Text = "Cargando Tipos"
        ComboPromotor.Items.Clear()

        For Each row As DataRow In dataPromotores.Tables(0).Rows

            ComboPromotor.Items.Add(row("nombre"))
        Next
        ComboPromotor.SelectedIndex = 0
        BackgroundTipos.RunWorkerAsync()
    End Sub


    Private Function ConsultarIdPromotor(nombre As String) As Integer
        Dim idEmpleado As Integer

        For Each row As DataRow In dataPromotores.Tables(0).Rows
            If row("nombre").ToString = nombre Then
                idEmpleado = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idEmpleado
    End Function


    Private Function ConsultarIdGestor(nombre As String) As Integer
        Dim idEmpleado As Integer

        For Each row As DataRow In dataGestores.Tables(0).Rows
            If row("nombre").ToString = nombre Then
                idEmpleado = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idEmpleado
    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellContentClick

    End Sub

    Private Sub txtPrenda_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundTipos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundTipos.DoWork
        Dim consultaTipos As String
        consultaTipos = "Select id,nombre from tipoarticulosempeño"
        adapterTipo = New SqlDataAdapter(consultaTipos, conexionempresa)
        dataTipo = New DataTable
        adapterTipo.Fill(dataTipo)
    End Sub

    Private Sub TextBoxEx1_TextChanged(sender As Object, e As EventArgs) Handles txtIdCLiente.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Cargando.Close()
        DatosSolicitudBoleta.idSolicitud = idSolicitudBoleta
        DatosSolicitudBoleta.tipoSolicitud = txtTipo.Text
        DatosSolicitudBoleta.Show()
        Me.Close()
    End Sub


    Private Sub dtdatos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dtdatos.RowsAdded
        For Each row As DataGridViewRow In dtdatos.Rows
            Dim combocolumn As DataGridViewComboBoxCell = row.Cells(1)
            If combocolumn.Items.Count = 0 Then
                For Each rowtipo As DataRow In dataTipo.Rows
                    combocolumn.Items.Add(rowtipo("nombre").ToString)

                Next

            End If
        Next
    End Sub

    Private Function ConsultarTipo(nombre As String) As Integer
        Dim idtipo As Integer

        For Each row As DataRow In dataTipo.Rows

            If row("nombre").ToString = nombre Then
                idtipo = Val(row("id").ToString)
                Exit For
            End If
        Next



        Return idtipo
    End Function

    Private Sub txtTipo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundTipos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundTipos.RunWorkerCompleted
        Cargando.Close()
    End Sub

    Private Sub dtdatos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtdatos.CellEndEdit
        totalValuado = 0

        Try
            For Each row As DataGridViewRow In dtdatos.Rows

                totalValuado = totalValuado + row.Cells(6).Value

            Next

            errorValuado = False
        Catch ex As System.InvalidCastException
            MessageBox.Show("La columna Monto Valuado solo admite valores numéricos")
            dtdatos.Focus()
            dtdatos.CurrentCell = dtdatos(dtdatos.CurrentRow.Cells(6).ColumnIndex, dtdatos.CurrentRow.Index)
            errorValuado = True
        End Try

        If errorValuado = False Then
            If dtdatos.CurrentCell.ColumnIndex = 6 Then
                dtdatos.CurrentRow.Cells(7).Value = dtdatos.CurrentRow.Cells(6).Value * porcentajeSugerido * 0.01
            End If
        End If

        totalSugerido = 0
        Try
            For Each row As DataGridViewRow In dtdatos.Rows
                totalSugerido = totalSugerido + row.Cells(7).Value
            Next
            errorSugerido = False
        Catch ex As System.InvalidCastException
            MessageBox.Show("La columna Monto Sugerido solo admite valores numéricos")
            dtdatos.Focus()
            dtdatos.CurrentCell = dtdatos(dtdatos.CurrentRow.Cells(7).ColumnIndex, dtdatos.CurrentRow.Index)
            errorSugerido = True
        End Try
        txtMontoTotalValuado.Text = totalValuado
        txtMontoTotalSugerido.Text = totalSugerido

    End Sub

    Private Sub txtPrenda_TextChanged(sender As Object, e As EventArgs) Handles txtPrenda.TextChanged

    End Sub

    Private Sub TextBoxEx1_MouseHover(sender As Object, e As EventArgs) Handles txtIdCLiente.MouseHover
        txtIdCLiente.BorderColor = Color.Blue
    End Sub

    Private Sub TextBoxEx1_MouseLeave(sender As Object, e As EventArgs) Handles txtIdCLiente.MouseLeave
        If tieneFocus Then
        Else
            txtIdCLiente.BorderColor = Color.Gray
        End If

    End Sub

    Private Sub TextBoxEx1_GotFocus(sender As Object, e As EventArgs) Handles txtIdCLiente.GotFocus
        tieneFocus = True
        txtIdCLiente.BorderColor = Color.Blue
    End Sub

    Private Sub TextBoxEx1_LostFocus(sender As Object, e As EventArgs) Handles txtIdCLiente.LostFocus
        tieneFocus = False
        txtIdCLiente.BorderColor = Color.Gray
    End Sub

    Private Sub txtIdCLiente_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtIdCLiente.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtIdCLiente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCLiente.KeyDown
        If empezar Then
            If e.KeyCode = Keys.Enter Then
                ConsultarCliente()
                If consultadoCliente Then

                    btn_agregar.Visible = True
                    txtPrenda.Select()
                End If
            End If
            If e.KeyCode = Keys.Tab Then
                ConsultarCliente()
                If consultadoCliente Then

                    btn_agregar.Visible = True
                    txtPrenda.Select()
                End If
            End If
            If e.KeyData = Keys.Shift + Keys.Tab Then
                txtTipo.Select()
            End If
        Else
            MessageBox.Show("No se han cargado los valores, espere")
        End If

        If e.KeyCode = Keys.F2 Then
            BuscarClienteEmpeño.Show()
        End If
    End Sub

    Private Sub txtPrenda_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtPrenda.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtPrenda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrenda.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim fimagen As New OpenFileDialog
            fimagen.Filter = "Archivos de imagen (*.png,*.jpg,*.jpeg,*.bmp,*.ico)|*.png;*.jpg;*.jpeg;*.bmp;*.ico"
            Dim result As DialogResult = fimagen.ShowDialog
            If result = DialogResult.OK Then
                txtPrenda.Text = fimagen.FileName
            Else
                MessageBox.Show("No se seleccionó ningún archivo")
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            Try
                Dim bm As New Bitmap(txtPrenda.Text)
                dtdatos.Rows.Add(bm, "", "", "", "", "")
                For Each row As DataGridViewRow In dtdatos.Rows
                    row.Height = 100
                Next
                For Each row As DataGridViewRow In dtdatos.Rows
                    If row.Cells(1).Value = "" Then
                        dtdatos.Focus()
                        dtdatos.CurrentCell = dtdatos(row.Cells(1).ColumnIndex, row.Index)
                        SendKeys.Send("%{DOWN}")
                    End If
                Next


            Catch ex As System.ArgumentException
                MessageBox.Show("La ruta de la imagen no es válida")
                txtPrenda.Select()

                txtPrenda.Text = ""
            End Try
        End If


        If e.KeyData = Keys.Shift + Keys.Tab Then
            txtIdCLiente.Select()
        End If

    End Sub

    Private Sub txtTipo_MouseHover(sender As Object, e As EventArgs) Handles txtTipo.MouseHover
        txtTipo.BorderColor = Color.Blue
    End Sub

    Private Sub txtTipo_MouseLeave(sender As Object, e As EventArgs) Handles txtTipo.MouseLeave
        If Not tieneFocus Then
            txtTipo.BorderColor = Color.Gray
        End If
    End Sub

    Private Sub txtTipo_GotFocus(sender As Object, e As EventArgs) Handles txtTipo.GotFocus
        tieneFocus = True
        txtTipo.BorderColor = Color.Blue
    End Sub

    Private Sub txtTipo_LostFocus(sender As Object, e As EventArgs) Handles txtTipo.LostFocus
        tieneFocus = False
        txtTipo.BorderColor = Color.Gray
    End Sub

    Private Sub txtTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTipo.KeyDown
        If empezar Then
            If e.KeyCode = Keys.Enter Then
                ConsultarTipocredito()
                txtIdCLiente.Select()
            End If

            If e.KeyCode = Keys.Tab Then
                ConsultarTipocredito()
                txtIdCLiente.Select()
            End If

            If e.KeyCode = Keys.F2 Then
                TiposDeEmpeños.Show()
            End If
        Else
            MessageBox.Show("No se han cargado los valores, espere")
        End If
    End Sub

    Private Sub txtTipo_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtTipo.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtPrenda_MouseHover(sender As Object, e As EventArgs) Handles txtPrenda.MouseHover
        txtPrenda.BorderColor = Color.Blue
    End Sub

    Private Sub txtPrenda_MouseLeave(sender As Object, e As EventArgs) Handles txtPrenda.MouseLeave
        If tieneFocus = False Then
            txtPrenda.BorderColor = Color.Gray
        End If
    End Sub

    Private Sub txtPrenda_GotFocus(sender As Object, e As EventArgs) Handles txtPrenda.GotFocus
        tieneFocus = True
        txtPrenda.BorderColor = Color.Blue
    End Sub

    Private Sub txtPrenda_LostFocus(sender As Object, e As EventArgs) Handles txtPrenda.LostFocus
        tieneFocus = False
        txtPrenda.BorderColor = Color.Gray
    End Sub
End Class