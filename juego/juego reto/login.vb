Imports MySql.Data.MySqlClient

Public Class Login
    Private cn As MySqlConnection
    Private daCli As MySqlDataAdapter
    Private dsCli As DataSet
    Public menu As menu
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        menu.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If menu.idioma = "en" Then
            lblUser.Text = "User Name:"
            lblContraseña.Text = "Password:"
            btnEnviar.Text = "SEND"
            btnSalir.Text = "EXIT"
        Else
            lblUser.Text = "Nombre usuario:"
            lblContraseña.Text = "Contraseña:"
            btnEnviar.Text = "ENVIAR"
            btnSalir.Text = "SALIR"
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        cn = conectar()
        If txtUser.Text <> "" And txtPassword.Text <> "" Then
            Dim cmd As MySqlCommand
            Dim dr As MySqlDataReader
            daCli = New MySqlDataAdapter()
            cmd = New MySqlCommand("select id_user from users where username=? and password=? ", cn)
            cmd.Parameters.Add(New MySqlParameter("username", txtUser.Text()))
            cmd.Parameters.Add(New MySqlParameter("password", txtPassword.Text()))
            cmd.CommandType = CommandType.Text
            Try
                dr = cmd.ExecuteReader()
                If (dr.HasRows) Then
                    dr.Read()
                    menu.user = dr.GetInt32("id_user")
                    menu.username = txtUser.Text
                    menu.Show()
                    Me.Close()
                    menu.isLogin = True
                    If menu.idioma = "en" Then
                        menu.btnLogin.Text = "LOGOUT"
                    Else
                        menu.btnLogin.Text = "CERRAR SESION"
                    End If
                    cn.Close()
                Else
                    If menu.idioma = "es" Then
                        lblUsuario.Show()
                        lblUsuario.Text = "El nombre de usuario o la contraseña son incorrectos"
                    Else
                        lblUsuario.Show()
                        lblUsuario.Text = "The username or the password are incorrect"
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class