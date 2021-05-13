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
        eleccion = 0
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria2_Click(sender As Object, e As EventArgs) Handles btnCategoria2.Click
        eleccion = 1
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria3_Click(sender As Object, e As EventArgs) Handles btnCategoria3.Click
        eleccion = 2
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria4_Click(sender As Object, e As EventArgs) Handles btnCategoria4.Click
        eleccion = 3
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria5_Click(sender As Object, e As EventArgs) Handles btnCategoria5.Click
        eleccion = 4
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnCategoria6_Click(sender As Object, e As EventArgs) Handles btnCategoria6.Click
        eleccion = 5
        juego.Show()
        Me.Close()
    End Sub

    Private Sub btnAleatorio_Click(sender As Object, e As EventArgs) Handles btnAleatorio.Click
        eleccion = Int((5 * Rnd()) + 0)
        juego.Show()
        Me.Close()
    End Sub

    Private Sub categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        juego.idioma = menu.idioma

    End Sub
End Class