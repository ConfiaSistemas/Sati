Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class CrearNotificacionDescuentoPromesa
    Public idPromesa As String
    Dim dataUsuarios As DataTable
    Dim adapterUsuarios As MySqlDataAdapter
    Dim nCargando As Cargando
    Dim creada As Boolean

    Private Sub CrearNotificacionCancelarTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        creada = False
        lblPromesa.Text = idPromesa
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Consultando usuarios"
        nCargando.TopMost = True
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim conexionUsuarios As MySqlConnection
        conexionUsuarios = New MySqlConnection()
        conexionUsuarios.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
        conexionUsuarios.Open()


        Dim consulta As String


        consulta = "select Usr.nm,Usr.nm_complete from Usr inner join grp on Usr.grp = grp.id inner join PermisosGrupo on grp.id = PermisosGrupo.idGrupo where PermisosGrupo.SatiModCreditosDescuentoPromesa = 1"
        adapterUsuarios = New MySqlDataAdapter(consulta, conexionUsuarios)
        dataUsuarios = New DataTable
        adapterUsuarios.Fill(dataUsuarios)



    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ComboUsuarios.Clear()
        For Each row As DataRow In dataUsuarios.Rows
            ComboUsuarios.AddItem(row("nm").ToString)
        Next
        ComboUsuarios.selectedIndex = 0
        nCargando.Close()
    End Sub

    Private Sub ComboUsuarios_onItemSelected(sender As Object, e As EventArgs) Handles ComboUsuarios.onItemSelected
        For Each row As DataRow In dataUsuarios.Rows
            If row("nm").ToString = ComboUsuarios.selectedValue Then
                lblNombreUsuario.Text = row("nm_complete").ToString
                Exit For
            End If
        Next

    End Sub

    Private Sub BackgroundNotificacion_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundNotificacion.DoWork
        Try
            Dim conexionLogin As MySqlConnection
            conexionLogin = New MySqlConnection()
            conexionLogin.ConnectionString = "server=www.prestamosconfia.com;user id=ajas;pwd=123456;port=3306;database=USRS"
            conexionLogin.Open()
            Dim comandoLogin As MySqlCommand
            Dim consultaLogin As String
            consultaLogin = "insert into Notificaciones values(null,'DescuentoPromesa',1,'" & nmusr & "','" & ComboUsuarios.selectedValue & "','" & idPromesa & "','','" & txtComentario.Text & "',0,'0','" & Date.Now.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("HH:mm:ss") & "',0,'','','" & nombreAmostrar & "','',''); "
            comandoLogin = New MySqlCommand
            comandoLogin.Connection = conexionLogin
            comandoLogin.CommandText = consultaLogin
            comandoLogin.ExecuteNonQuery()
            conexionLogin.Close()
            creada = True
        Catch ex As MySqlException
            creada = False
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nCargando = New Cargando
        nCargando.Show()
        nCargando.MonoFlat_Label1.Text = "Notificando"
        nCargando.TopMost = True
        BunifuThinButton21.Enabled = False

        BackgroundNotificacion.RunWorkerAsync()


    End Sub

    Private Sub BackgroundNotificacion_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundNotificacion.RunWorkerCompleted
        If creada Then
            MessageBox.Show("Notificación creada con éxito")
            BunifuThinButton21.Enabled = True
            nCargando.Close()
            PromPago.creada = True
            Me.Close()
        Else
            MessageBox.Show("Ha ocurrido un error, inténtelo de nuevo")
            BunifuThinButton21.Enabled = True
            creada = False
            nCargando.Close()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub CrearNotificacionDescuentoPromesa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If creada Then
            PromPago.creada = True
        Else
            PromPago.creada = False
        End If
    End Sub
End Class