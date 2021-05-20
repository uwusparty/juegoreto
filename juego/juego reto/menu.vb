Public Class menu
    Public idioma As String = "es"
    Public isLogin As Boolean = False
    Public formAmigos As amigos
    Public user As Integer = -1
    Public username As String
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isLogin = False Then
            Dim login As New Login
            lblMensaje.Hide()
            login.menu = Me
            login.Show()
            Me.Hide()
        Else
            user = -1
            If btnIdioma.Text = "CAMBIAR A INGLES" Then
                btnLogin.Text = "INICIAR SESION"
            Else
                btnLogin.Text = "LOGIN"
            End If
            isLogin = False
        End If

    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        If isLogin = False Then
            lblMensaje.Show()
        Else
            Dim categoria As New categoria
            categoria.menu = Me
            categoria.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnIdioma_Click(sender As Object, e As EventArgs) Handles btnIdioma.Click
        If btnIdioma.Text = "CAMBIAR A INGLES" Then
            btnJugar.Text = "PLAY"
            btnIdioma.Text = "CHANGE TO SPANISH"
            btnSalir.Text = "EXIT"
            idioma = "en"
            If isLogin = False Then
                btnLogin.Text = "LOGIN"
            Else
                btnLogin.Text = "LOGOUT"
            End If
        Else
            btnJugar.Text = "JUGAR"
            btnLogin.Text = "INICIAR SESIÓN"
            btnIdioma.Text = "CAMBIAR A INGLES"
            btnSalir.Text = "SALIR"
            idioma = "es"
            If isLogin = False Then
                btnLogin.Text = "INICIAR SESION"
            Else
                btnLogin.Text = "CERRAR SESION"
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnAmigos_Click(sender As Object, e As EventArgs) Handles btnAmigos.Click
        If isLogin = True Then
            If formAmigos Is Nothing Then
                formAmigos = New amigos(Me)
            End If
            If formAmigos.Visible Then
                formAmigos.Visible = False
            Else
                formAmigos.Visible = True
            End If
        End If
    End Sub
End Class