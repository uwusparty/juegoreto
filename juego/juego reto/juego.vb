Imports System.Net
Imports Newtonsoft.Json
Imports System.Text
Public Class Juego
    Dim eleccion As Integer
    Dim contador As Integer
    Dim preguntas As Integer
    Dim puntuacion As Integer
    Dim puntuaciones As puntuaciones
    Dim n As WebClient = New WebClient()
    Public arrayPreg As List(Of String) = New List(Of String)
    Dim posicion As Integer = 0
    Dim guardarPreguntas As List(Of String)
    Dim random As Integer

    Public Function getPreguntas() As List(Of String)
        Dim json = n.DownloadString("http://192.168.6.218:8080/trivialmi/questions")
        Dim read = Linq.JObject.Parse(json)
        Dim arrayPreguntas As List(Of String) = New List(Of String)
        For i As Integer = 0 To read.Item("data").Count - 1
            arrayPreguntas.Add(read.Item("data")(i).ToString)
        Next
        Return arrayPreguntas
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerImagen.Tick
        contador += 1
        If preguntas < 25 Then
            If contador = 0 Then
                random = CInt(Int((guardarPreguntas.Count * Rnd()) + 0))
                MessageBox.Show(random)
            ElseIf contador = 5 Then
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
        guardarPreguntas = getPreguntas()
        Randomize()
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