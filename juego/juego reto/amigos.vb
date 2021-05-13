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
        cmd = New MySqlCommand("select username from users inner join friends on users.id_user = friends.id_user", cn)
        Try
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While dr.Read()
                    lstAmigos.Items.Add(dr.GetString("username"))
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
End Class