Imports System.Data.SqlClient

Public Class DocumentosNecesarios
    Public idTipo As Integer
    Private Sub DocumentosNecesarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Try
            iniciarconexion()
            Dim sql As String
            Dim comando As SqlCommand

            Dim milector As SqlDataReader
            comando = New SqlCommand

            comando.Connection = conexionempresa
            sql = "select ajas.id,ajas.Nombre,ajas.tipo,case when (select idtipo from documentosnecesariostipo where idtipo = ajas.id and idtipocredito = '" & idTipo & "')  IS null then '0' else 1 end
as Aplica from
(select * from TiposdeDocumentosSolicitud) ajas"
            comando.CommandText = sql
            milector = comando.ExecuteReader
            While milector.Read
                Dim checkTipo As New CheckBox


                checkTipo.Name = milector("id")
                checkTipo.Text = milector("nombre") & " (" & milector("tipo") & ")"
                checkTipo.CheckState = milector("Aplica")
                checkTipo.AutoSize = True
                'checkTipo.Tag = milector("ip")

                FlowLayoutPanel1.Controls.Add(checkTipo)
            End While
            milector.Close()
        Catch ex As Exception

        End Try
        '

    End Sub

    Private Sub btn_Procesar_Click(sender As Object, e As EventArgs) Handles btn_Procesar.Click
        iniciarconexionempresa()
        Dim comandoAct As SqlCommand
        Dim consulta As String
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf (ctrl) Is CheckBox Then
                Dim checkctrl As CheckBox = ctrl
                Select Case checkctrl.CheckState
                    Case CheckState.Checked
                        comandoAct = New SqlCommand
                        consulta = "IF NOT EXISTS((select * from DocumentosNecesariosTipo where idTipo = '" & checkctrl.Name & "' and idTipoCredito = '" & idTipo & "' ))
BEGIN
insert into DocumentosNecesariosTipo values('" & checkctrl.Name & "','" & idTipo & "') end"
                        comandoAct.Connection = conexionempresa
                        comandoAct.CommandText = consulta
                        comandoAct.ExecuteNonQuery()
                    Case CheckState.Unchecked
                        comandoAct = New SqlCommand
                        consulta = "IF  EXISTS((select * from DocumentosNecesariosTipo where idTipo = '" & checkctrl.Name & "' and idTipoCredito = '" & idTipo & "' ))
BEGIN
delete from DocumentosNecesariosTipo where idtipo = '" & checkctrl.Name & "' and idtipoCredito = '" & idTipo & "' end"
                        comandoAct.Connection = conexionempresa
                        comandoAct.CommandText = consulta
                        comandoAct.ExecuteNonQuery()
                End Select
            End If
        Next

    End Sub
End Class