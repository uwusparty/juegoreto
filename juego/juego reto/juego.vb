Imports System.Net
Imports Newtonsoft.Json
Imports System.Text
Imports System.IO

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
    Dim numRandom As Integer
    Dim arrayRespuestas(3) As String

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
        lblContador.Text = contador
        If preguntas < 25 Then
            If contador = 0 Then
                numRandom = CInt(Int((guardarPreguntas.Count * Rnd()) + 0))
                Dim read = Linq.JObject.Parse(guardarPreguntas.Item(numRandom))
                'Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(n.DownloadData(read.Item("image_url"))))
                'picFoto.Image = tImage

                'SEGUIR AQUI
                'CLIENT Is NEEDED TO DO THE DOWNLOAD
                'Dim MyWebClient As New System.Net.WebClient

                'BYTE ARRAY HOLDS THE DATA
                'Dim ImageInBytes() As Byte = MyWebClient.DownloadData("http://www.somesite.com/image.gif")

                'CREATE A BITMAP FROM A STREAM (STREAM IS CREATED FROM THE DOWNLOADED BYTES)
                'Dim MyImage As New Bitmap(New IO.MemoryStream(ImageInBytes))

                'SAVE THE IMAGE TO WHATEVER FILE NAME YOU WANT
                'MyImage.Save(Application.StartupPath & "\imagename.gif")

                lblPregunta.Text = read.Item("question")("en").ToString
                arrayRespuestas(0) = read.Item("correct")("en").ToString
                arrayRespuestas(1) = read.Item("incorrects")(0)("en").ToString
                arrayRespuestas(2) = read.Item("incorrects")(1)("en").ToString
                arrayRespuestas(3) = read.Item("incorrects")(2)("en").ToString
                Dim aux As String
                For i As Integer = 0 To 3
                    Dim respRandom = CInt(Int((3 * Rnd()) + 0))
                    aux = arrayRespuestas(i)
                    arrayRespuestas(i) = arrayRespuestas(respRandom)
                    arrayRespuestas(respRandom) = aux
                Next
                btnRespuesta1.Text = arrayRespuestas(0)
                btnRespuesta2.Text = arrayRespuestas(1)
                btnRespuesta3.Text = arrayRespuestas(2)
                btnRespuesta4.Text = arrayRespuestas(3)
                contador += 1
            ElseIf contador = 5 Then
                picFoto.Hide()
                lblPregunta.Show()
                btnRespuesta1.Show()
                btnRespuesta2.Show()
                btnRespuesta3.Show()
                btnRespuesta4.Show()
                contador += 1
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
                contador += 1
            Else
                contador += 1
            End If
        Else
            puntuaciones.Show()
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