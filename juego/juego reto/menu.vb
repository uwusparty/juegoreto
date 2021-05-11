Public Class menu
    Public esIngles As Boolean
    Public isLogin As Boolean = False
    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnJugar.BackColor = Color.FromArgb(3, 169, 244)
        btnLogin.BackColor = Color.FromArgb(57, 226, 57)
        btnIdioma.BackColor = Color.FromArgb(245, 74, 245)
        btnSalir.BackColor = Color.FromArgb(241, 241, 49)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As New Login
        lblMensaje.Hide()
        login.menu = Me
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        'If isLogin = False Then
        'lblMensaje.Show()
        'Else
        If btnIdioma.Text = "ESPAÑOL" Then
                Dim juego As New Juego
                juego.Show()
                Me.Hide()
            Else
                Dim categoria As New categoria
                categoria.menu = Me
                categoria.Show()
                Me.Hide()
            End If
        'End If
    End Sub

    Private Sub btnIdioma_Click(sender As Object, e As EventArgs) Handles btnIdioma.Click
        If btnIdioma.Text = "ENGLISH" Then
            btnJugar.Text = "PLAY"
            btnIdioma.Text = "ESPAÑOL"
            btnSalir.Text = "EXIT"
            esIngles = True
        Else
            btnJugar.Text = "JUGAR"
            btnIdioma.Text = "ENGLISH"
            btnSalir.Text = "SALIR"
            esIngles = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnAmigos_Click(sender As Object, e As EventArgs) Handles btnAmigos.Click
        Dim amigos As New amigos
        amigos.Show()
    End Sub
End Class