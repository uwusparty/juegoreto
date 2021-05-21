Public Class categoria
    Public menu As New menu
    Public juego As New Juego
    Dim eleccion As Integer
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        juego.Close()
        menu.Show()
    End Sub

    Private Sub btnCategoria1_Click(sender As Object, e As EventArgs) Handles btnCategoria1.Click
        juego.categoria = "category/History"
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria2_Click(sender As Object, e As EventArgs) Handles btnCategoria2.Click
        juego.categoria = "category/Celebrities"
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria3_Click(sender As Object, e As EventArgs) Handles btnCategoria3.Click
        juego.categoria = "category/Entertainment"
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria4_Click(sender As Object, e As EventArgs) Handles btnCategoria4.Click
        juego.categoria = "category/Science & Nature"
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria5_Click(sender As Object, e As EventArgs) Handles btnCategoria5.Click
        juego.categoria = "category/Sports"
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria6_Click(sender As Object, e As EventArgs) Handles btnCategoria6.Click
        juego.categoria = "category/Geography"
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        juego.categoria = ""
        juego.Show()
        Me.Close()
    End Sub

    Private Sub categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        juego.idioma = menu.idioma
        juego.menu = menu
        If menu.idioma = "en" Then
            lblCategorias.Text = "CHOOSE A CATEGORY"
            btnAtras.Text = "Back"
            btnCategoria1.Text = "History"
            btnCategoria2.Text = "Celebrities"
            btnCategoria3.Text = "Entertainment"
            btnCategoria4.Text = "Science & Nature"
            btnCategoria5.Text = "Sports"
            btnCategoria6.Text = "Geography"
            btnAleatorio.Text = "Random"
        End If
    End Sub
End Class