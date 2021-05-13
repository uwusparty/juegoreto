﻿Imports MySql.Data.MySqlClient

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
        If cn Is Nothing Then
            Return
        End If
        If menu.idioma = "en" Then
            lblUser.Text = "User Name/Email:"
            lblContraseña.Text = "Password:"
            btnEnviar.Text = "Send"
            btnSalir.Text = "Exit"
        Else
            lblUser.Text = "Nombre usuario/ Correo:"
            lblContraseña.Text = "Contraseña:"
            btnEnviar.Text = "Enviar"
            btnSalir.Text = "Salir"
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        cn = conectar()
        If txtUser.Text <> "" And txtPassword.Text <> "" Then
            Dim cmd As MySqlCommand
            Dim dr As MySqlDataReader
            daCli = New MySqlDataAdapter()
            cmd = New MySqlCommand("select id_user from users where username=? and password=? ", cn)
            MessageBox.Show(cmd.ToString)
            cmd.Parameters.Add(New MySqlParameter("username", txtUser.Text()))
            cmd.Parameters.Add(New MySqlParameter("password", txtPassword.Text()))
            cmd.CommandType = CommandType.Text
            Try
                dr = cmd.ExecuteReader()
                If (dr.HasRows) Then
                    dr.Read()
                    menu.user = dr.GetInt32("id_user")
                    menu.Show()
                    Me.Close()
                    menu.isLogin = True
                    menu.btnLogin.Text = "CERRAR SESION"
                Else
                    MessageBox.Show("USUARIO NO EXISTENTE")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        cn.Close()
    End Sub
End Class