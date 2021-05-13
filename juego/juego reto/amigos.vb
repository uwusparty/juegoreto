Imports MySql.Data.MySqlClient
Public Class amigos
    Private cn As MySqlConnection
    Private daCli As MySqlDataAdapter
    Private dsCli As DataSet
    Dim menu As menu
    Public Sub New(menu As menu)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.menu = menu
    End Sub
    Private Sub amigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = conectar()
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        daCli = New MySqlDataAdapter()
        cmd = New MySqlCommand("select u1.username, u2.username from users u1 inner join friends f1 on f1.id_sender = u1.id_user INNER JOIN users u2 ON u2.id_user = f1.id_receiver WHERE f1.id_sender =? or f1.id_receiver = ?", cn)
        cmd.Parameters.Add(New MySqlParameter("fi.id_sender", menu.user))
        cmd.Parameters.Add(New MySqlParameter("fi.id_receiver", menu.user))
        Try
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While dr.Read()
                    If menu.username = dr.GetString(0) Then
                        lstAmigos.Items.Add(dr.GetString(1))
                    Else
                        lstAmigos.Items.Add(dr.GetString(0))
                    End If
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cn.Close()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        menu.formAmigos = Nothing
        Me.Close()
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        cn = conectar()
        Dim cmd As MySqlCommand
        daCli = New MySqlDataAdapter()
        cmd = New MySqlCommand("delete from friends WHERE id_sender =? and id_receiver = (select id_user from users where username=?) or id_receiver =? and id_sender = (select id_user from users where username=?)", cn)
        cmd.Parameters.Add(New MySqlParameter("id_sender", menu.user))
        cmd.Parameters.Add(New MySqlParameter("username", lstAmigos.SelectedItem))
        cmd.Parameters.Add(New MySqlParameter("id_receiver", menu.user))
        cmd.Parameters.Add(New MySqlParameter("username1", lstAmigos.SelectedItem))
        Try
            cmd.ExecuteNonQuery()
            lstAmigos.Items.Remove(lstAmigos.SelectedItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cn.Close()
    End Sub
End Class