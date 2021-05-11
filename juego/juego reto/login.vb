Public Class Login
    Public menu As menu
    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        menu.Show()
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If menu.esIngles = True Then
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
End Class