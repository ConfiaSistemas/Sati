Imports System.Data.OleDb
Imports System.Threading.Tasks
Imports System.IO

Public Class usuarios
    Dim vertscroll As Integer = SystemInformation.VerticalScrollBarWidth
    Dim picturecargando As PictureBox
    Dim nombrepicture As Integer = 0
    Dim nombre(1000) As String
    Dim idgrp(1000) As String
    Dim busqueda As String
    Dim ypicturebox As Integer = 0
    Dim agregarpicturetimer As Boolean = False
    Dim pictureboxusuario As Bunifu.Framework.UI.BunifuImageButton
    Dim labelusuario As Label
    Dim cantidadusuarios As Integer
    Dim numero As Integer = 0
    Dim imgpanel(1000) As String
    Dim idusrpanel(1000) As String
    Dim nombrecompleto(1000) As String
    Dim labelcargando As Label
    Private Declare Function LockWindowUpdate Lib "user32" (ByVal hwndLock As IntPtr) As Int32
    Private Declare Function ShowScrollBar Lib "user32" (ByVal hwnd As IntPtr, ByVal wBar As Int32, ByVal bShow As Int32) As Int32

    Private Const SB_VERT = 1

    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim mensajesayuda As New ToolTip
        mensajesayuda.AutoPopDelay = 5000
        mensajesayuda.InitialDelay = 500
        mensajesayuda.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        mensajesayuda.ShowAlways = True
        mensajesayuda.SetToolTip(Me.BunifuMaterialTextbox1, "Presiona F5 para iniciar la búsqueda")
        InitializeBackgroundWorker()

        Control.CheckForIllegalCrossThreadCalls = False

        BunifuMaterialTextbox1.Location = New Point(BunifuMaterialTextbox1.Location.X, Combofiltro.Location.Y)
        Combofiltro.Items.Add("Todos")
        Combofiltro.Items.Add("Grupo")
        Combofiltro.Items.Add("Con Nombre")
        Combofiltro.Items.Add("Con Usuario")
        Combogrupo.Visible = False
        Combogrupo.Location = New Point(BunifuMaterialTextbox1.Location.X, Combofiltro.Location.Y)
        Combogrupo.Size = BunifuMaterialTextbox1.Size
        iniciarconexionR()
        Combofiltro.SelectedIndex = 0

        ' cargarusuarios()
        FlowLayoutPanel1.Padding = New Padding(0, 0, vertscroll, 0)
        ShowScrollBar(FlowLayoutPanel1.Handle, SB_VERT, False)

    End Sub






    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            MoveForm(Me)
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuMaterialTextbox1.KeyDown
        If e.KeyData = Keys.F5 Then
            If busqueda = "nombre" Then
                strusuarios = "select idusr,nm_complete,imgstr from usr where nm_complete like '%" & BunifuMaterialTextbox1.Text & "%'"
            Else
                strusuarios = "select idusr,nm_complete,imgstr from usr where nm like '%" & BunifuMaterialTextbox1.Text & "%'"
            End If
            Combogrupo.Visible = False

            panelcargando.Size = FlowLayoutPanel1.Size
            panelcargando.Location = FlowLayoutPanel1.Location
            FlowLayoutPanel1.Visible = False
            panelcargando.Visible = True
            timercargando.Enabled = True
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub












    Private Sub Combofiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combofiltro.SelectedIndexChanged


        Select Case Combofiltro.Text
            Case "Todos"
               
                Combogrupo.Visible = False
                BunifuMaterialTextbox1.Visible = False
                panelcargando.Size = FlowLayoutPanel1.Size
                panelcargando.Location = FlowLayoutPanel1.Location
                FlowLayoutPanel1.Visible = False
                panelcargando.Visible = True
                timercargando.Enabled = True

                strusuarios = "select idusr,nm_complete,imgstr from usr"

                BackgroundWorker1.RunWorkerAsync()
                

            Case "Grupo"

                Combogrupo.Visible = True
                BunifuMaterialTextbox1.Visible = False
                Combogrupo.Items.Clear()
                cargargrupos()
            Case "Con Nombre"
                Combogrupo.Visible = False
                busqueda = "nombre"
                BunifuMaterialTextbox1.Visible = True



            Case "Con Usuario"
                Combogrupo.Visible = False
                busqueda = "usuario"
                BunifuMaterialTextbox1.Visible = True


        End Select
    End Sub

    Public Sub cargargrupos()
        Try
            Dim strgrupos As String
            strgrupos = "select id,nm,cdg from grp"
            Dim ejec = New OleDbCommand(strgrupos)
            ejec.Connection = conexionempresaR
            Dim codigo As String

            Dim numero As Integer = 0

            Dim myreadergrupos As OleDbDataReader = ejec.ExecuteReader()
            While myreadergrupos.Read


                codigo = myreadergrupos("cdg")
                Combogrupo.Items.Add(codigo)
                nombre(numero) = myreadergrupos("nm")
                idgrp(numero) = myreadergrupos("id")
                numero += 1
            End While
            myreadergrupos.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Combogrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combogrupo.SelectedIndexChanged
        strusuarios = "select idusr,nm_complete,imgstr from usr where grp = '" & idgrp(Combogrupo.SelectedIndex) & "'"
        nombregrupo.MonoFlat_HeaderLabel1.Text = nombre(Combogrupo.SelectedIndex)
        nombregrupo.Show()

        BunifuMaterialTextbox1.Visible = False
        panelcargando.Size = FlowLayoutPanel1.Size
        panelcargando.Location = FlowLayoutPanel1.Location
        FlowLayoutPanel1.Visible = False
        panelcargando.Visible = True
        timercargando.Enabled = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub



  

    Private Sub timercargando_Tick(sender As Object, e As EventArgs) Handles timercargando.Tick
        timercargando.Interval = 100
        If agregarpicturetimer = False Then
            If nombrepicture < 6 Then
                picturecargando = New PictureBox
                picturecargando.Image = My.Resources.lconfia
                picturecargando.Size = New Size(100, 200)
                picturecargando.Name = nombrepicture
                picturecargando.BackColor = Color.FromArgb(223, 223, 223)
                picturecargando.SizeMode = PictureBoxSizeMode.StretchImage
                picturecargando.BorderStyle = BorderStyle.FixedSingle
                picturecargando.Location = New Point(ypicturebox, 0)
                panelcargando.Controls.Add(picturecargando)
                labelcargando = New Label
                labelcargando.Text = "Cargando..."

                labelcargando.AutoSize = False
                labelcargando.Size = New Size(100, 50)
                labelcargando.BackColor = Color.FromArgb(18, 18, 18)
                labelcargando.ForeColor = Color.FromArgb(223, 223, 223)
                labelcargando.Location = New Point(0, picturecargando.Height - labelcargando.Height)
                picturecargando.Controls.Add(labelcargando)
                ypicturebox = ypicturebox + 100
                nombrepicture += 1
            Else
                agregarpicturetimer = True
            End If
           
        Else
            If nombrepicture > 0 Then
                Dim ctrl As Control = Me.panelcargando.Controls(nombrepicture - 1)
                Me.panelcargando.Controls.Remove(ctrl)
                ctrl.Dispose()
                nombrepicture -= 1
            Else
                agregarpicturetimer = False

                ypicturebox = 0
            End If

          
        End If
      
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        'strusuarios = "select idusr,nm_complete,imgstr from usr"




        'Me.Invoke(New Action(AddressOf cargarusuarios))
        'Await Task.Factory.StartNew(Sub()
        'Me.Invoke(New Action(AddressOf cargarusuarios))
        '                           End Sub)
       
       
        Dim ejec2 = New OleDbCommand(strusuarios)
        ejec2.Connection = conexionempresaR
        Dim myreaderusuarios As OleDbDataReader = ejec2.ExecuteReader()
        While myreaderusuarios.Read
            imgpanel(numero) = Convert.ToString(myreaderusuarios("imgstr"))
            idusrpanel(numero) = Convert.ToString(myreaderusuarios("idusr"))
            nombrecompleto(numero) = Convert.ToString(myreaderusuarios("nm_complete"))
            numero += 1

        End While
        cantidadusuarios = numero

    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
       
        Dim num_controles As Integer = FlowLayoutPanel1.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Control = FlowLayoutPanel1.Controls(n)
            FlowLayoutPanel1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next
        Backgroundusuarios.RunWorkerAsync()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' FlowLayoutPanel1.Visible = False
        'panelcargando.Visible = True
        'timercargando.Enabled = True

    End Sub

    Private Sub Backgroundusuarios_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Backgroundusuarios.DoWork
      
        Dim bytespanel As Byte()
        Dim streamimgpanel As System.IO.MemoryStream
        Dim bitmapimgpanel As Bitmap
        Dim botonusuario As Bunifu.Framework.UI.BunifuImageButton
        Dim labelnombre As Label
        Try
            For numero1 As Integer = 0 To cantidadusuarios - 1
                If imgpanel(numero1) <> "" Then
                    bytespanel = Convert.FromBase64String(imgpanel(numero1))
                    streamimgpanel = New MemoryStream(bytespanel, 0, bytespanel.Length)
                    streamimgpanel.Write(bytespanel, 0, bytespanel.Length)
                    bitmapimgpanel = New Bitmap(streamimgpanel)

                    botonusuario = New Bunifu.Framework.UI.BunifuImageButton
                    botonusuario.Image = bitmapimgpanel
                    botonusuario.Size = New Size(100, 200)
                    botonusuario.Name = idusrpanel(numero1)
                    botonusuario.BackColor = Color.FromArgb(223, 223, 223)
                    botonusuario.SizeMode = PictureBoxSizeMode.StretchImage
                    AddHandler botonusuario.MouseDown, AddressOf mousedownevent
                    AddHandler botonusuario.MouseMove, AddressOf MouseMoveevent
                    AddHandler botonusuario.MouseUp, AddressOf mouseupevent
                    AddHandler botonusuario.Click, AddressOf clickevent
                    FlowLayoutPanel1.PerformLayout()
                    Me.Invoke(Sub()
                                  FlowLayoutPanel1.Controls.Add(botonusuario)
                              End Sub)
                    labelnombre = New Label
                    labelnombre.Text = nombrecompleto(numero1)

                    labelnombre.AutoSize = False
                    labelnombre.Size = New Size(100, 50)
                    labelnombre.BackColor = Color.FromArgb(18, 18, 18)
                    labelnombre.ForeColor = Color.FromArgb(223, 223, 223)
                    labelnombre.Location = New Point(0, botonusuario.Height - labelnombre.Height)
                    Me.Invoke(Sub()
                                  botonusuario.Controls.Add(labelnombre)
                              End Sub)

                Else


                    botonusuario = New Bunifu.Framework.UI.BunifuImageButton
                    botonusuario.Image = ConfiaAdmin.My.Resources.Resources.usuario
                    botonusuario.Size = New Size(100, 200)
                    botonusuario.Name = idusrpanel(numero1)
                    botonusuario.BackColor = Color.FromArgb(223, 223, 223)
                    botonusuario.SizeMode = PictureBoxSizeMode.StretchImage
                    AddHandler botonusuario.MouseDown, AddressOf mousedownevent
                    AddHandler botonusuario.MouseMove, AddressOf MouseMoveevent
                    AddHandler botonusuario.MouseUp, AddressOf mouseupevent
                    AddHandler botonusuario.Click, AddressOf clickevent
                    FlowLayoutPanel1.PerformLayout()
                    Me.Invoke(Sub()
                                  FlowLayoutPanel1.Controls.Add(botonusuario)
                              End Sub)
                    labelnombre = New Label
                    labelnombre.Text = nombrecompleto(numero1)

                    labelnombre.AutoSize = False
                    labelnombre.Size = New Size(100, 50)
                    labelnombre.BackColor = Color.FromArgb(18, 18, 18)
                    labelnombre.ForeColor = Color.FromArgb(223, 223, 223)
                    labelnombre.Location = New Point(0, botonusuario.Height - labelnombre.Height)
                    Me.Invoke(Sub()
                                  botonusuario.Controls.Add(labelnombre)
                              End Sub)
                End If
            Next
            botonusuario = New Bunifu.Framework.UI.BunifuImageButton
            botonusuario.Image = My.Resources.usuario_agregar
            botonusuario.Size = New Size(100, 200)
            botonusuario.Name = "Agregar Usuario"
            botonusuario.BackColor = Color.FromArgb(223, 223, 223)
            botonusuario.SizeMode = PictureBoxSizeMode.StretchImage
            AddHandler botonusuario.MouseDown, AddressOf mousedownevent
            AddHandler botonusuario.MouseMove, AddressOf MouseMoveevent
            AddHandler botonusuario.MouseUp, AddressOf mouseupevent
            AddHandler botonusuario.Click, AddressOf clickeventagregar
            Me.Invoke(Sub()
                          FlowLayoutPanel1.Controls.Add(botonusuario)
                      End Sub)
            numero = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Public Sub mousedownevent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Capture the initial point 
        m_PanStartPoint = New Point(e.X, e.Y)

    End Sub
    Public Sub mouseupevent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Capture the initial point 
        bloquear = False


    End Sub
    Public Sub MouseMoveevent(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        'Verify Left Button is pressed while the mouse is moving
        If e.Button = Windows.Forms.MouseButtons.Left Then
            bloquear = True
            'Here we get the change in coordinates.
            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)

            'Then we set the new autoscroll position.
            'ALWAYS pass positive integers to the panels autoScrollPosition method
            FlowLayoutPanel1.AutoScrollPosition = _
            New Drawing.Point((DeltaX - FlowLayoutPanel1.AutoScrollPosition.X), _
                            (DeltaY - FlowLayoutPanel1.AutoScrollPosition.Y))

        End If

    End Sub
    Public Sub clickevent(ByVal sender As Object, ByVal e As EventArgs)

        ' Dim label = DirectCast(sender, Label)
        If bloquear = False Then
            For Each row As DataRow In dataPermisos.Rows
                If row("SatiModUsuariosVer") Then
                    Editar_Usuario.idusuario = sender.name

                    Editar_Usuario.Show()
                Else

                End If
            Next

        End If



    End Sub
    Public Sub clickeventagregar(ByVal sender As Object, ByVal e As EventArgs)

        ' Dim label = DirectCast(sender, Label)
        If bloquear = False Then


            Agregar_Usuario.Show()
        End If



    End Sub

    Private Sub Backgroundusuarios_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Backgroundusuarios.RunWorkerCompleted
        panelcargando.Visible = False

        FlowLayoutPanel1.Visible = True
        timercargando.Enabled = False
        nombrepicture = 0
        ypicturebox = 0
        Dim num_controles As Integer = panelcargando.Controls.Count - 1
        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Control = panelcargando.Controls(n)
            panelcargando.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next
    End Sub


End Class