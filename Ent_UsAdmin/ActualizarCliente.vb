Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Net
Imports System.Text
Imports HtmlAgilityPack

Public Class ActualizarCliente

    Dim actualizar As Boolean
    Public autorizado As Boolean
    Dim nCargando As Cargando
    Dim curpValidada As Boolean = False
    Dim estadoValidacionCurp As String
    Dim existe As String
    Public idCliente As String
    Dim dataCreditosCliente As DataTable
    Dim adapterCreditosCliente As SqlDataAdapter
    Dim nombre As String
    Dim aPaterno As String
    Dim aMaterno As String
    Dim fechana As Date
    Dim valorAnterior As String
    Dim op As String


    Private Sub Agregar_Impuestos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If actualizar = True Then
            Me.Invoke(Sub()
                          impuestos.cargarimpuestos()
                      End Sub)


        End If
    End Sub

    Private Sub Agregar_Impuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Cargando información"
        BackgroundConsultarCliente.RunWorkerAsync()

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click


        Autorizacion.tipoAutorizacion = "SatiModClientesModificar"
            Autorizacion.ShowDialog()
            If autorizado Then
                btn_agregar.Enabled = False
                nCargando = New Cargando
                nCargando.Show()
                nCargando.MonoFlat_Label1.Text = "Validando existencia del cliente"
                BackgroundValidaExistencia.RunWorkerAsync()

            Else
                MessageBox.Show("No fue autorizado")
            End If





    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click







    End Sub

    Function ValidarCurp(curp As String) As Boolean
        Try
            Dim s As HttpWebRequest
            Dim enc As UTF8Encoding
            Dim postdata As String
            Dim postdatabytes As Byte()
            s = HttpWebRequest.Create("https://www.buholegal.com/consultacurp/")
            enc = New System.Text.UTF8Encoding()
            postdata = "curp=" & txtcurp.Text
            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"
            s.ContentType = "application/x-www-form-urlencoded"
            s.ContentLength = postdatabytes.Length

            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim result = s.GetResponse()

            Dim retorno As Boolean = True
            Dim web As New HtmlWeb()
            ' Dim doc As HtmlDocument = web.Load("http://www.renapo.sep.gob.mx/wsrenapo/MainControllerParam?curp=" & txtcurp.Text)
            Dim doc As New HtmlDocument
            doc.Load(result.GetResponseStream, True)
            ' Get all tables in the document
            Dim tables As HtmlNodeCollection = doc.DocumentNode.SelectNodes("//table")

            ' Iterate all rows in the first table
            Dim rows As HtmlNodeCollection = tables(0).SelectNodes("//tr")

            For i As Integer = 0 To rows.Count - 1

                ' Iterate all columns in this row
                Dim cols As HtmlNodeCollection = rows(i).SelectNodes("//td")
                For j As Integer = 0 To cols.Count - 1

                    ' Get the value of the column and print it
                    Dim value As String = cols(j).InnerText
                    If value = "
                        
                            Espere mientras se ejecuta su consulta...
                            
                            
                        " Then
                        MessageBox.Show("Hubo un error curp no encontrada")
                        retorno = False
                        estadoValidacionCurp = "Hubo un error curp no encontrada"

                    Else
                        If value = "Apellido Paterno:" Then
                            If String.Equals(cols(j + 1).InnerText, txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                                MessageBox.Show("El valor " & value & " es diferente al ingresado")
                                retorno = False
                                estadoValidacionCurp = "El valor " & value & " es diferente al ingresado"


                            End If

                        ElseIf value = "Apellido Materno:" Then
                            If String.Equals(cols(j + 1).InnerText, txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                                MessageBox.Show("El valor " & value & " es diferente al ingresado")
                                retorno = False
                                estadoValidacionCurp = "El valor " & value & " es diferente al ingresado"
                            End If

                        ElseIf value = "Nombre(s):" Then
                            If String.Equals(cols(j + 1).InnerText, txtnombre.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                                MessageBox.Show("El valor " & value & " es diferente al ingresado")
                                retorno = False
                                estadoValidacionCurp = "El valor " & value & " es diferente al ingresado"

                            End If


                        ElseIf value = "Fecha de Nacimiento:" Then
                            If String.Equals(cols(j + 1).InnerText, DateNacimiento.Value.ToString("dd/MM/yyyy"), StringComparison.CurrentCultureIgnoreCase) = 0 Then
                                MessageBox.Show("El valor " & value & " es diferente al ingresado")
                                retorno = False
                                estadoValidacionCurp = "El valor " & value & " es diferente al ingresado"

                            End If
                        End If
                    End If





                    'MessageBox.Show(value)
                Next
                Exit For

            Next
            If retorno Then
                estadoValidacionCurp = "Datos correctos"
            End If
            Return retorno
        Catch ex As Exception
            MessageBox.Show("Hubo un error " & ex.Message)
            Return False

        End Try

    End Function

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles btnConsultaCurp.Click
        btnConsultaCurp.Enabled = False
        btn_agregar.Enabled = False
        txtnombre.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        DateNacimiento.Value = "01/01/99"
        'txtCelular.Text = ""
        '  txtTelefono.Text = ""

        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Consultando Información"
        If op = "Op1" Then
            BackgroundConsultarCurp.RunWorkerAsync()
        Else
            BackgroundConsultaCurpOp2.RunWorkerAsync()

        End If

    End Sub

    Private Sub BackgroundConsultarCurp_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConsultarCurp.DoWork
        Try

            Dim s As HttpWebRequest
            Dim enc As UTF8Encoding
            Dim postdata As String
            Dim postdatabytes As Byte()
            s = HttpWebRequest.Create("https://www.buholegal.com/consultacurp/")
            enc = New System.Text.UTF8Encoding()
            postdata = "curp=" & txtcurp.Text
            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"
            s.ContentType = "application/x-www-form-urlencoded"
            s.ContentLength = postdatabytes.Length

            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim result = s.GetResponse()

            Dim retorno As Boolean = True
            Dim web As New HtmlWeb()
            ' Dim doc As HtmlDocument = web.Load("http://www.renapo.sep.gob.mx/wsrenapo/MainControllerParam?curp=" & txtcurp.Text)
            Dim doc As New HtmlDocument
            doc.Load(result.GetResponseStream, True)

            ' Get all tables in the document
            Dim tables As HtmlNodeCollection = doc.DocumentNode.SelectNodes("//table")

            ' Iterate all rows in the first table
            Dim rows As HtmlNodeCollection = tables(0).SelectNodes("//tr")

            For i As Integer = 0 To rows.Count - 1

                ' Iterate all columns in this row
                Dim cols As HtmlNodeCollection = rows(i).SelectNodes("//td")
                For j As Integer = 0 To cols.Count - 1

                    ' Get the value of the column and print it
                    Dim value As String = cols(j).InnerText
                    If value = "
                        
                            Espere mientras se ejecuta su consulta...
                            
                            
                        " Then
                        MessageBox.Show("Hubo un error curp no encontrada")


                    Else
                        If value = "Apellido Paterno:" Then



                            txtApellidoP.Text = cols(j + 1).InnerText



                        ElseIf value = "Apellido Materno:" Then


                            txtApellidoM.Text = cols(j + 1).InnerText





                        ElseIf value = "Fecha de Nacimiento:" Then

                            DateNacimiento.Value = cols(j + 1).InnerText


                        ElseIf value = "Nombre(s):" Then
                            txtnombre.Text = cols(j + 1).InnerText

                        End If
                    End If





                    'MessageBox.Show(value)
                Next
                Exit For

            Next
        Catch ex As Exception
            MessageBox.Show("Hubo un error " & ex.Message)

        End Try
    End Sub

    Private Sub BackgroundConsultarCurp_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultarCurp.RunWorkerCompleted
        btnConsultaCurp.Enabled = True
        btn_agregar.Enabled = True
        nCargando.Close()
    End Sub

    Private Sub BackgroundAgregar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundAgregar.DoWork

        Try
            iniciarconexionempresa()

            Dim comandoIdStr As SqlCommand
            Dim consultaIdStr As String
            consultaIdStr = "update clientes set curp='" & txtcurp.Text & "',telefono='" & txtTelefono.Text & "',celular='" & txtCelular.Text & "',estadoValidacion='" & estadoValidacionCurp & "',validado='" & curpValidada & "' where id = '" & idCliente & "'"
            comandoIdStr = New SqlCommand
            comandoIdStr.Connection = conexionempresa
            comandoIdStr.CommandText = consultaIdStr
            comandoIdStr.ExecuteNonQuery()
            actualizar = True
            MessageBox.Show("Listo")



        Catch ex As Exception
            actualizar = False
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundValidar_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundValidar.DoWork
        If op = "Op1" Then
            curpValidada = ValidarCurp(txtcurp.Text)
        Else
            curpValidada = ValidaCurpOp2(txtcurp.Text)
        End If


    End Sub

    Private Sub BackgroundValidar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundValidar.RunWorkerCompleted
        If txtnombre.Text <> nombre Or txtApellidoP.Text <> aPaterno Or txtApellidoM.Text <> aMaterno Then

            If curpValidada Then
                nCargando.MonoFlat_Label1.Text = "Consultando créditos asociados recientes"
                BackgroundCreditosActivos.RunWorkerAsync()

                '   BackgroundAgregar.RunWorkerAsync()

            Else
                MessageBox.Show("La curp no pudo ser validada")

                nCargando.Close()
                btn_agregar.Enabled = True




            End If
        Else

            If curpValidada Then
                nCargando.MonoFlat_Label1.Text = "Actualizando Cliente"
                BackgroundAgregar.RunWorkerAsync()

                '   BackgroundAgregar.RunWorkerAsync()

            Else
                MessageBox.Show("La curp no pudo ser validada")

                nCargando.Close()
                btn_agregar.Enabled = True




            End If
        End If


    End Sub

    Private Sub BackgroundValidaExistencia_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundValidaExistencia.DoWork
        iniciarconexionempresa()

        Dim comandoValidaExistencia As SqlCommand
        Dim consultaValidaExistencia As String
        consultaValidaExistencia = "if exists(select concat('id:',id,' Nombre:',Nombre,' ',apellidopaterno,' ',apellidoMaterno) as nombre from clientes where curp='" & txtcurp.Text & "' and id <> '" & idCliente & "' )
                                       begin
                                            select concat('id:',id,' Nombre:',Nombre,' ',apellidopaterno,' ',apellidoMaterno) as nombre from clientes where curp='" & txtcurp.Text & "'
                                            
                                    end
                                    else
                                    begin
                                    select 'No existe'
                                    end    "
        comandoValidaExistencia = New SqlCommand
        comandoValidaExistencia.Connection = conexionempresa
        comandoValidaExistencia.CommandText = consultaValidaExistencia
        existe = comandoValidaExistencia.ExecuteScalar


    End Sub

    Private Sub BackgroundValidaExistencia_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundValidaExistencia.RunWorkerCompleted
        If existe = "No existe" Then
            nCargando.MonoFlat_Label1.Text = "Validando información en la RENAPO"
            BackgroundValidar.RunWorkerAsync()

        Else
            MessageBox.Show("El cliente ya existe con los datos " & existe)
            nCargando.Close()
            btn_agregar.Enabled = True

        End If
    End Sub

    Private Sub BackgroundAgregar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundAgregar.RunWorkerCompleted
        nCargando.Close()
        btn_agregar.Enabled = True
    End Sub

    Private Sub BackgroundConsultarCliente_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultarCliente.DoWork
        iniciarconexionempresa()
        Dim comandoDatosCliente As SqlCommand
        Dim consultaDatosCliente As String
        Dim readerDatosCliente As SqlDataReader

        consultaDatosCliente = "select * from clientes where id='" & idCliente & "'"
        comandoDatosCliente = New SqlCommand
        comandoDatosCliente.Connection = conexionempresa
        comandoDatosCliente.CommandText = consultaDatosCliente
        readerDatosCliente = comandoDatosCliente.ExecuteReader
        If readerDatosCliente.HasRows Then
            While readerDatosCliente.Read
                If IsDBNull(readerDatosCliente("curp")) Then
                    txtcurp.Text = ""
                Else
                    txtcurp.Text = readerDatosCliente("curp")

                End If
                nombre = readerDatosCliente("nombre")
                aPaterno = readerDatosCliente("apellidopaterno")
                aMaterno = readerDatosCliente("apellidoMaterno")
                fechana = readerDatosCliente("fechanacimiento")
                DateNacimiento.Value = readerDatosCliente("fechanacimiento")
                valorAnterior = "Nombre: " & nombre & " Apellido Paterno: " & aPaterno & " Apellido Materno: " & " Fecha Nacimiento: " & fechana.ToString("aaaa-MM-dd") & " Tel: " & readerDatosCliente("telefono") & " Cel: " & readerDatosCliente("celular")
                txtnombre.Text = readerDatosCliente("nombre")
                txtApellidoP.Text = readerDatosCliente("apellidopaterno")
                txtApellidoM.Text = readerDatosCliente("apellidoMaterno")
                txtTelefono.Text = readerDatosCliente("telefono")
                txtCelular.Text = readerDatosCliente("celular")
            End While
        End If
    End Sub

    Private Sub BackgroundConsultarCliente_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultarCliente.RunWorkerCompleted
        nCargando.Close()
    End Sub

    Private Sub BackgroundCreditosActivos_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundCreditosActivos.DoWork
        iniciarconexionempresa()
        Dim consultaCreditosCliente As String
        consultaCreditosCliente = "select Credito.id,Credito.Nombre,Credito.Monto,Credito.Pagare,TiposDeCredito.Nombre as Tipo,Credito.FechaEntrega,Credito.Estado from credito inner join TiposDeCredito on Credito.Tipo = TiposDeCredito.id  where IdCliente=" & idCliente & " and Estado <>'T'  and  tiposdecredito.Tipo ='I' order by FechaEntrega desc"
        adapterCreditosCliente = New SqlDataAdapter(consultaCreditosCliente, conexionempresa)
        dataCreditosCliente = New DataTable
        adapterCreditosCliente.Fill(dataCreditosCliente)


    End Sub

    Private Sub BackgroundCreditosActivos_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundCreditosActivos.RunWorkerCompleted
        If dataCreditosCliente.Rows.Count > 0 Then
            MessageBox.Show("El cliente contiene créditos asociados, al actualizar el cliente se tiene que actualizar el nombre del crédito asociado más reciente")
            nCargando.Close()

            CreditosAsociadosActualizarCliente.dataCreditos = dataCreditosCliente
            CreditosAsociadosActualizarCliente.nombre = txtnombre.Text
            CreditosAsociadosActualizarCliente.aPaterno = txtApellidoP.Text
            CreditosAsociadosActualizarCliente.aMaterno = txtApellidoM.Text
            CreditosAsociadosActualizarCliente.FechaNacimiento = DateNacimiento.Value
            CreditosAsociadosActualizarCliente.telefono = txtTelefono.Text
            CreditosAsociadosActualizarCliente.Celular = txtCelular.Text
            CreditosAsociadosActualizarCliente.Curp = txtcurp.Text
            CreditosAsociadosActualizarCliente.EstadoValidacionCurp = estadoValidacionCurp
            CreditosAsociadosActualizarCliente.ValidadoCurp = curpValidada
            CreditosAsociadosActualizarCliente.valorAnterior = valorAnterior
            CreditosAsociadosActualizarCliente.idCliente = idCliente
            CreditosAsociadosActualizarCliente.Show()

        Else
            nCargando.MonoFlat_Label1.Text = "Actualizando cliente"
            BackgroundActualizarTodo.RunWorkerAsync()

        End If
    End Sub

    Private Sub BackgroundActualizarTodo_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundActualizarTodo.DoWork
        Try
            iniciarconexionempresa()

            Dim comandoIdStr As SqlCommand
            Dim consultaIdStr As String
            consultaIdStr = "update clientes set curp='" & txtcurp.Text & "',telefono='" & txtTelefono.Text & "',celular='" & txtCelular.Text & "',estadoValidacion='" & estadoValidacionCurp & "',validado='" & curpValidada & "',nombre='" & txtnombre.Text & "',apellidopaterno='" & txtApellidoP.Text & "',apellidoMaterno='" & txtApellidoM.Text & "',fechanacimiento='" & DateNacimiento.Value.ToString("yyyy-MM-dd") & "' where id = '" & idCliente & "'"
            comandoIdStr = New SqlCommand
            comandoIdStr.Connection = conexionempresa
            comandoIdStr.CommandText = consultaIdStr
            comandoIdStr.ExecuteNonQuery()
            actualizar = True
            MessageBox.Show("Listo")



        Catch ex As Exception
            actualizar = False
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundActualizarTodo_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundActualizarTodo.RunWorkerCompleted
        nCargando.Close()

    End Sub

    Private Function ValidaCurpOp2(curp As String) As Boolean

        Try
            Dim s As HttpWebRequest
            Dim enc As UTF8Encoding
            Dim postdata As String
            Dim postdatabytes As Byte()
            Dim tempCookies As New CookieContainer
            Dim Boundary As String = Guid.NewGuid().ToString().Replace("-", "")
            s = HttpWebRequest.Create("http://registrate.fgr.org.mx/Applicant/CheckCurp")
            enc = New System.Text.UTF8Encoding()
            postdata = "__RequestVerificationToken=U-mGkTgFNrE3HTcnjqYOAuwsSY4dE209vhiNqaS3D79oKYwphVJUvMlpVhiT0LXfcu6clJZL8k9Xv9ALOrvMITgC0pabK9x2KKXes0HfT4U1&Curp=" & curp & "&CaptchaValue_56e84f664f324334a0c40a223da4fa38=vqGBttp4Dr4AZK2OtZH/Mg==&CaptchaUserInput_5563becd985f482dace5a6c102c15453=4njyJ8"
            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"

            '.ContentType = "multipart/form-data;boundary=" & Boundary
            s.ContentType = "application/x-www-form-urlencoded"
            s.ContentLength = postdatabytes.Length
            s.CookieContainer = tempCookies
            Dim retorno As Boolean = True


            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim result = s.GetResponse()
            Dim web As New HtmlWeb()
            ' Dim doc As HtmlDocument = web.Load("http://registrate.fgr.org.mx/Applicant/Register?curp=" & txtcurp.Text & "&guid=374d9585-bec7-4c4e-8d04-62342457dad7")
            Dim doc As New HtmlDocument
            doc.Load(result.GetResponseStream, True)
            Dim nombres As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='Names']")
            Dim apePaterno As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='LastName']")
            Dim apeMaterno As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='SecondLastName']")
            Dim Fechanacimien As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='BirthDay']")


            If Not nombres Is Nothing Then
                If String.Equals(nombres.GetAttributeValue("value", ""), txtnombre.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                    MessageBox.Show("El valor Nombres es diferente al ingresado")
                    retorno = False
                    estadoValidacionCurp = "El valor Nombres es diferente al ingresado"
                ElseIf String.Equals(apePaterno.GetAttributeValue("value", ""), txtApellidoP.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                    MessageBox.Show("El valor Apellido Paterno es diferente al ingresado")
                    retorno = False
                    estadoValidacionCurp = "El valor Apellido Paterno es diferente al ingresado"
                ElseIf String.Equals(apeMaterno.GetAttributeValue("value", ""), txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                    MessageBox.Show("El valor Apellido Materno es diferente al ingresado")
                    retorno = False
                    estadoValidacionCurp = "El valor Apellido Materno es diferente al ingresado"
                ElseIf String.Equals(apeMaterno.GetAttributeValue("value", ""), txtApellidoM.Text, StringComparison.InvariantCultureIgnoreCase) = 0 Then
                    MessageBox.Show("El valor Apellido Materno es diferente al ingresado")
                    retorno = False
                    estadoValidacionCurp = "El valor Apellido Materno es diferente al ingresado"
                ElseIf String.Equals(Fechanacimien.GetAttributeValue("value", ""), DateNacimiento.Value.ToString("dd/MM/yyyy"), StringComparison.CurrentCultureIgnoreCase) = 0 Then
                    MessageBox.Show("El valor Fecha de Nacimiento es diferente al ingresado")
                    retorno = False
                    estadoValidacionCurp = "El valor Fecha de Nacimiento es diferente al ingresado"

                End If



            Else
                MessageBox.Show("Curp no encontrada")
                retorno = False

            End If
            If retorno Then
                estadoValidacionCurp = "Datos correctos"
            End If
            Return retorno
        Catch ex As Exception
            MessageBox.Show("Hubo un error " & ex.Message)
            Return False
        End Try



    End Function

    Private Sub BackgroundCurpOp2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundConsultaCurpOp2.DoWork
        Try
            Dim s As HttpWebRequest
            Dim enc As UTF8Encoding
            Dim postdata As String
            Dim postdatabytes As Byte()
            Dim tempCookies As New CookieContainer
            Dim Boundary As String = Guid.NewGuid().ToString().Replace("-", "")
            s = HttpWebRequest.Create("http://registrate.fgr.org.mx/Applicant/CheckCurp")
            enc = New System.Text.UTF8Encoding()
            postdata = "__RequestVerificationToken=U-mGkTgFNrE3HTcnjqYOAuwsSY4dE209vhiNqaS3D79oKYwphVJUvMlpVhiT0LXfcu6clJZL8k9Xv9ALOrvMITgC0pabK9x2KKXes0HfT4U1&Curp=" & txtcurp.Text & "&CaptchaValue_56e84f664f324334a0c40a223da4fa38=vqGBttp4Dr4AZK2OtZH/Mg==&CaptchaUserInput_5563becd985f482dace5a6c102c15453=4njyJ8"
            postdatabytes = enc.GetBytes(postdata)
            s.Method = "POST"

            '.ContentType = "multipart/form-data;boundary=" & Boundary
            s.ContentType = "application/x-www-form-urlencoded"
            s.ContentLength = postdatabytes.Length
            s.CookieContainer = tempCookies



            Using stream = s.GetRequestStream()
                stream.Write(postdatabytes, 0, postdatabytes.Length)
            End Using
            Dim result = s.GetResponse()
            Dim web As New HtmlWeb()
            ' Dim doc As HtmlDocument = web.Load("http://registrate.fgr.org.mx/Applicant/Register?curp=" & txtcurp.Text & "&guid=374d9585-bec7-4c4e-8d04-62342457dad7")
            Dim doc As New HtmlDocument
            doc.Load(result.GetResponseStream, True)
            Dim nombres As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='Names']")
            Dim apePaterno As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='LastName']")
            Dim apeMaterno As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='SecondLastName']")
            Dim Fechanacimien As HtmlNode = doc.DocumentNode.SelectSingleNode("//*[@id='BirthDay']")

            If Not nombres Is Nothing Then

                txtnombre.Text = nombres.GetAttributeValue("value", "")
                txtApellidoP.Text = apePaterno.GetAttributeValue("value", "")
                txtApellidoM.Text = apeMaterno.GetAttributeValue("value", "")
                DateNacimiento.Value = Fechanacimien.GetAttributeValue("value", "")


            Else
                MessageBox.Show("Curp no encontrada")
            End If



        Catch ex As Exception
            MessageBox.Show("Hubo un error " & ex.Message)

        End Try
    End Sub

    Private Sub BackgroundConsultaCurpOp2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundConsultaCurpOp2.RunWorkerCompleted
        btnConsultaCurp.Enabled = True
        btn_agregar.Enabled = True
        nCargando.Close()
    End Sub


    Private Sub RadioOp1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioOp1.CheckedChanged
        If RadioOp1.Checked Then
            op = "Op1"
        End If
    End Sub

    Private Sub RadioOp2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioOp2.CheckedChanged
        If RadioOp2.Checked Then
            op = "Op2"
        End If
    End Sub
End Class