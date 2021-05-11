Public Class Juego
    Dim eleccion As Integer
    Dim contador As Integer
    Dim preguntas As Integer
    Dim puntuacion As Integer
    Dim puntuaciones As puntuaciones

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerImagen.Tick
        contador += 1
        If preguntas < 25 Then
            If contador = 5 Then
                picFoto.Hide()
                lblPregunta.Show()
                btnRespuesta1.Show()
                btnRespuesta2.Show()
                btnRespuesta3.Show()
                btnRespuesta4.Show()
            ElseIf contador = 25 Then
                contador = 0
                picFoto.Show()
                lblPregunta.Hide()
                btnRespuesta1.Hide()
                btnRespuesta2.Hide()
                btnRespuesta3.Hide()
                btnRespuesta4.Hide()
                preguntas += 1
            ElseIf contador >= 20 Then
                btnRespuesta1.BackColor = Color.Red
            End If
        Else
            puntuaciones.show()
        End If
    End Sub

    Private Sub juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerImagen.Start()
    End Sub

    Private Sub btnRespuesta1_Click(sender As Object, e As EventArgs) Handles btnRespuesta1.Click
        If contador < 20 Then
            contador = 20
        End If
    End Sub
    Private Sub btnRespuesta2_Click(sender As Object, e As EventArgs) Handles btnRespuesta1.Click
        If contador < 20 Then
            contador = 20
        End If
    End Sub
    Private Sub btnRespuesta3_Click(sender As Object, e As EventArgs) Handles btnRespuesta1.Click
        If contador < 20 Then
            contador = 20
        End If
    End Sub
    Private Sub btnRespuesta4_Click(sender As Object, e As EventArgs) Handles btnRespuesta1.Click
        If contador < 20 Then
            contador = 20
        End If
    End Sub
End Class