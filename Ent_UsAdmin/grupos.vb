Imports System.Data.OleDb

Public Class grupos
    Dim strgrupos As String
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            MoveForm(Me)
        End If
    End Sub






    Private Sub grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarconexionR()
        Combofiltro.Items.Add("Todos")
        Combofiltro.Items.Add("Con Nombre")
        Combofiltro.Items.Add("Con Código")
        Combofiltro.SelectedIndex = 0
    End Sub





    Private Sub Combofiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combofiltro.SelectedIndexChanged
        If Combofiltro.Text = "Todos" Then
            strgrupos = "select id,nm,cdg from grp"
            cargargrupos()

        End If
    End Sub

    Public Sub cargargrupos()
        dtgrupos.Rows.Clear()

        Dim ejec = New OleDbCommand(strgrupos)
        ejec.Connection = conexionempresaR
        Dim nombre, codigo, id As String

        Dim myreadergrupos As OleDbDataReader = ejec.ExecuteReader()
        While myreadergrupos.Read
            id = myreadergrupos("id")
            nombre = myreadergrupos("nm")
            codigo = myreadergrupos("cdg")
            dtgrupos.Rows.Add(id, codigo, nombre)
        End While
        myreadergrupos.Close()

    End Sub

    
   
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        agregargrupos.Show()

    End Sub

    Private Sub dtgrupos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrupos.CellContentClick

    End Sub

    Private Sub dtgrupos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrupos.CellContentDoubleClick
        PermisosGrupo.idgrupousuarios = dtgrupos.Rows(dtgrupos.CurrentRow.Index).Cells(0).Value
        PermisosGrupo.Show()
    End Sub
End Class