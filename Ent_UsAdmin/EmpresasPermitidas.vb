Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class EmpresasPermitidas
    Dim ncargando As Cargando
    Public idUsuario As String
    Private ButtonIndex = 0
    Private DragDropCursor As Cursor
    Private Sub EmpresasPermitidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ButtonIndex += 1

        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Cargando Información"
        ncargando.Show()

        FlowEmpresasRestringidas.AllowDrop = True
        FlowEmpresasPermitidas.AllowDrop = True
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        iniciarconexionR()
        Dim comandoEmpresasPermitidas As OleDbCommand

        Dim consultaEmpresasPermitidas As String
        Dim readerEmpresasPermitidas As OleDbDataReader
        consultaEmpresasPermitidas = "select id,nombre from empresas where id in (select idempresa from empresaspermitidas where idusuario = '" & idUsuario & "')"
        comandoEmpresasPermitidas = New OleDbCommand
        comandoEmpresasPermitidas.Connection = conexionempresaR
        comandoEmpresasPermitidas.CommandText = consultaEmpresasPermitidas
        readerEmpresasPermitidas = comandoEmpresasPermitidas.ExecuteReader
        If readerEmpresasPermitidas.HasRows Then

            While readerEmpresasPermitidas.Read
                Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                botonempresa.Iconimage = Nothing

                botonempresa.Size = New Size(197, 48)
                botonempresa.Name = readerEmpresasPermitidas("id").ToString
                botonempresa.Text = readerEmpresasPermitidas("nombre").ToString
                '  botonempresa.Tag = milector("ip")
                'AddHandler botonempresa.Click, AddressOf clickevenntAsync
                AddHandler botonempresa.MouseDown, AddressOf OnButtonMouseDown
                Me.Invoke(Sub()
                              FlowEmpresasPermitidas.Controls.Add(botonempresa)
                          End Sub)

            End While

        End If

        Dim comandoEmpresasRestringidas As OleDbCommand
        Dim consultaEmpresaRestringidas As String
        Dim readerEmpresasRestringidas As OleDbDataReader
        consultaEmpresaRestringidas = "select id,nombre from empresas where id not in (select idempresa from empresaspermitidas where idusuario = '" & idUsuario & "')"
        comandoEmpresasRestringidas = New OleDbCommand
        comandoEmpresasRestringidas.Connection = conexionempresaR
        comandoEmpresasRestringidas.CommandText = consultaEmpresaRestringidas
        readerEmpresasRestringidas = comandoEmpresasRestringidas.ExecuteReader
        If readerEmpresasRestringidas.HasRows Then

            While readerEmpresasRestringidas.Read
                Dim botonempresa As New Bunifu.Framework.UI.BunifuFlatButton

                botonempresa.Normalcolor = Color.FromArgb(48, 55, 76)
                botonempresa.Iconimage = Nothing

                botonempresa.Size = New Size(197, 48)
                botonempresa.Name = readerEmpresasRestringidas("id").ToString
                botonempresa.Text = readerEmpresasRestringidas("nombre").ToString
                '  botonempresa.Tag = milector("ip")
                'AddHandler botonempresa.Click, AddressOf clickevenntAsync
                AddHandler botonempresa.MouseDown, AddressOf OnButtonMouseDown
                Me.Invoke(Sub()
                              FlowEmpresasRestringidas.Controls.Add(botonempresa)
                          End Sub)

            End While

        End If




    End Sub

    Private Sub OnButtonMouseDown(sender As Object, e As MouseEventArgs)

        Dim button = DirectCast(sender, Bunifu.Framework.UI.BunifuFlatButton)

        Using bmp As New Bitmap(button.Width, button.Height)
            button.DrawToBitmap(bmp, New Rectangle(Point.Empty, button.Size))
            DragDropCursor = New Cursor(bmp.GetHicon)
        End Using

        button.Parent.DoDragDrop(button, DragDropEffects.Move)

    End Sub

    Private Sub OnFlowLayoutPanelDragEnter(sender As Object, e As DragEventArgs) _
        Handles FlowEmpresasPermitidas.DragEnter, FlowEmpresasRestringidas.DragEnter

        If e.AllowedEffect = DragDropEffects.Move AndAlso e.Data.GetDataPresent(GetType(Bunifu.Framework.UI.BunifuFlatButton)) Then
            e.Effect = DragDropEffects.Move
        End If

    End Sub

    Private Sub OnFlowLayoutPanelDragDrop(sender As Object, e As DragEventArgs) _
        Handles FlowEmpresasPermitidas.DragDrop, FlowEmpresasRestringidas.DragDrop

        Dim button = DirectCast(e.Data.GetData(GetType(Bunifu.Framework.UI.BunifuFlatButton)), Bunifu.Framework.UI.BunifuFlatButton)
        Dim destPanel = DirectCast(sender, FlowLayoutPanel)
        destPanel.Controls.Add(button)
        Dim targetLoc = destPanel.GetChildAtPoint(destPanel.PointToClient(New Point(e.X, e.Y)))

        If targetLoc IsNot Nothing Then
            Dim idx = destPanel.Controls.GetChildIndex(targetLoc)
            destPanel.Controls.SetChildIndex(button, idx)
        End If

    End Sub

    Private Sub OnFlowLayoutPanelGiveFeedback(sender As Object, e As GiveFeedbackEventArgs) _
        Handles FlowEmpresasPermitidas.GiveFeedback, FlowEmpresasRestringidas.GiveFeedback

        e.UseDefaultCursors = False
        Cursor.Current = DragDropCursor

    End Sub

    Private Sub EmpresasPermitidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim num_controles As Integer = FlowEmpresasPermitidas.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Control = FlowEmpresasPermitidas.Controls(n)
            FlowEmpresasPermitidas.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

        Dim num_controles2 As Integer = FlowEmpresasRestringidas.Controls.Count - 1
        For n As Integer = num_controles2 To 0 Step -1
            Dim ctrl As Control = FlowEmpresasRestringidas.Controls(n)
            FlowEmpresasRestringidas.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

    End Sub

    Private Sub BackgroundAplicar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundAplicar.DoWork
        iniciarconexionR()

        For Each ctrl As Control In FlowEmpresasPermitidas.Controls
            If TypeOf (ctrl) Is Bunifu.Framework.UI.BunifuFlatButton Then
                Dim btnctrl As Bunifu.Framework.UI.BunifuFlatButton = ctrl
                Dim comandoEmpresaPermitida As OleDbCommand
                Dim consultaEmpresaPermitida As String
                consultaEmpresaPermitida = "if not exists(select id from empresaspermitidas where idempresa = '" & btnctrl.Name & "' and idusuario = '" & idUsuario & "')
                                            begin
                                              insert into empresasPermitidas values('" & btnctrl.Name & "','" & idUsuario & "')
                                               end"
                comandoEmpresaPermitida = New OleDbCommand
                comandoEmpresaPermitida.Connection = conexionempresaR
                comandoEmpresaPermitida.CommandText = consultaEmpresaPermitida
                comandoEmpresaPermitida.ExecuteNonQuery()



            End If
        Next


        For Each ctrl As Control In FlowEmpresasRestringidas.Controls
            If TypeOf (ctrl) Is Bunifu.Framework.UI.BunifuFlatButton Then
                Dim btnctrl As Bunifu.Framework.UI.BunifuFlatButton = ctrl
                Dim comandoEmpresaRestringida As OleDbCommand
                Dim consultaEmpresaRestringida As String
                consultaEmpresaRestringida = "if exists(select id from empresaspermitidas where idempresa = '" & btnctrl.Name & "' and idusuario = '" & idUsuario & "')
                                             begin
                                            delete from empresasPermitidas where idempresa = '" & btnctrl.Name & "' and idusuario = '" & idUsuario & "' 
                                            end"
                comandoEmpresaRestringida = New OleDbCommand
                comandoEmpresaRestringida.Connection = conexionempresaR
                comandoEmpresaRestringida.CommandText = consultaEmpresaRestringida
                comandoEmpresaRestringida.ExecuteNonQuery()



            End If
        Next

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ncargando.Close()

    End Sub

    Private Sub BackgroundAplicar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundAplicar.RunWorkerCompleted
        ncargando.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ncargando = New Cargando
        ncargando.MonoFlat_Label1.Text = "Aplicando cambios"
        ncargando.Show()

        BackgroundAplicar.RunWorkerAsync()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm(Me)
        End If
    End Sub
End Class