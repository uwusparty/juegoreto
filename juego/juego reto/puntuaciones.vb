Imports MySql.Data.MySqlClient

Public Class Puntuaciones
    Private cn As MySqlConnection
    Private daCli As MySqlDataAdapter
    Private dsCli As DataSet
    Public menu As menu
    Public puntuacion As Integer
    Dim contador As Integer = 1
    Private Sub puntuaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = conectar()
        txtPuntuacion.Text = puntuacion
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        daCli = New MySqlDataAdapter()
        cmd = New MySqlCommand("insert into scores (id_user ,score, date) VALUES (? , ?,  ?);", cn)
        cmd.Parameters.Add(New MySqlParameter("id_user", menu.user))
        cmd.Parameters.Add(New MySqlParameter("score", puntuacion))
        cmd.Parameters.Add(New MySqlParameter("date", Today))
        cmd.ExecuteNonQuery()

        cmd = New MySqlCommand("select score from scores where id_user=? order by score desc LIMIT 10", cn)
        cmd.Parameters.Add(New MySqlParameter("id_user", menu.user))
        Try
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While dr.Read
                    lstPuntuacion.Items.Add(contador & "- " & dr.GetInt32("score"))
                    If puntuacion = dr.GetInt32("score") Then
                        lstPuntuacion.SelectedIndex = contador - 1
                    End If
                    contador += 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        menu.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class