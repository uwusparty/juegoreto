Imports System.Net
Imports Newtonsoft.Json
Imports System.Text
Imports System.IO

Public Class Juego
    Dim contador As Integer
    Dim contpregunta As Integer
    Dim preguntas As Integer
    Dim puntuacion As Integer
    Dim n As WebClient = New WebClient()
    Public arrayPreg As List(Of String) = New List(Of String)
    Dim posicion As Integer = 0
    Dim guardarPreguntas As List(Of String)
    Dim numRandom As Integer
    Dim arrayRespuestas(3) As String
    Dim respuestaCorrecta As String
    Dim acierto As Boolean
    Public idioma As String
    Public categoria As String
    Public menu As menu

    Public Function getPreguntas() As List(Of String)
        Dim json = n.DownloadString("http://192.168.6.218:8080/trivialmi/questions/category/" & categoria)
        Dim read = Linq.JObject.Parse(json)
        Dim arrayPreguntas As List(Of String) = New List(Of String)
        For i As Integer = 0 To read.Item("data").Count - 1
            arrayPreguntas.Add(read.Item("data")(i).ToString)
        Next
        Return arrayPreguntas
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerImagen.Tick
        If preguntas < 10 Then
            If contador = 0 Then
                lblNumpregunta.Text = preguntas + 1 & " / 10"
                btnPausa.Visible = False
                btnPositivo.Visible = False
                lblValorar.Visible = False
                acierto = False
                lblPregunta.Hide()
                btnRespuesta1.Hide()
                btnRespuesta2.Hide()
                btnRespuesta3.Hide()
                btnRespuesta4.Hide()
                picFoto.Show()
                btnRespuesta1.BackColor = DefaultBackColor
                btnRespuesta2.BackColor = DefaultBackColor
                btnRespuesta3.BackColor = DefaultBackColor
                btnRespuesta4.BackColor = DefaultBackColor
                numRandom = CInt(Int((guardarPreguntas.Count * Rnd()) + 0))
                Dim read = Linq.JObject.Parse(guardarPreguntas.Item(numRandom))
                Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(n.DownloadData("file://///192.168.6.216/juego/categorias/" & read.Item("image_url").ToString)))
                picFoto.Image = tImage
                lblPregunta.Text = read.Item("question")(idioma).ToString
                arrayRespuestas(0) = read.Item("correct")(idioma).ToString
                respuestaCorrecta = read.Item("correct")(idioma).ToString
                arrayRespuestas(1) = read.Item("incorrects")(0)(idioma).ToString
                arrayRespuestas(2) = read.Item("incorrects")(1)(idioma).ToString
                arrayRespuestas(3) = read.Item("incorrects")(2)(idioma).ToString
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
                lblContador.Visible = True
                contpregunta = 15
                picFoto.Hide()
                lblPregunta.Show()
                btnRespuesta1.Show()
                btnRespuesta2.Show()
                btnRespuesta3.Show()
                btnRespuesta4.Show()
                contador += 1
            ElseIf contador = 20 Then
                btnPausa.Visible = True
                btnPositivo.Visible = True
                lblValorar.Visible = True
                If acierto = False Then
                    If respuestaCorrecta = btnRespuesta1.Text Then
                        btnRespuesta1.BackColor = Color.YellowGreen
                    ElseIf respuestaCorrecta = btnRespuesta2.Text Then
                        btnRespuesta2.BackColor = Color.YellowGreen
                    ElseIf respuestaCorrecta = btnRespuesta3.Text Then
                        btnRespuesta3.BackColor = Color.YellowGreen
                    ElseIf respuestaCorrecta = btnRespuesta4.Text Then
                        btnRespuesta4.BackColor = Color.YellowGreen
                    End If
                End If
                lblContador.Visible = False
                contador += 1
            ElseIf contador = 25 Then
                contador = 0
                preguntas += 1
                guardarPreguntas.RemoveAt(numRandom)
            Else
                contador += 1
            End If
            lblPuntuacion.Text = puntuacion
            lblContador.Text = contpregunta
            contpregunta -= 1

        Else
            Dim puntuaciones As New Puntuaciones
            puntuaciones.menu = menu
            puntuaciones.puntuacion = Me.puntuacion
            puntuaciones.Show()
            Me.Close()
        End If
    End Sub

    Private Sub juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerImagen.Start()
        guardarPreguntas = getPreguntas()
        Randomize()
        If idioma = "en" Then
            btnVolver.Text = "<<BACK"
        End If
    End Sub

    Private Sub btnRespuesta1_Click(sender As Object, e As EventArgs) Handles btnRespuesta1.Click
        If contador < 20 Then
            contador = 20
            If respuestaCorrecta = btnRespuesta1.Text Then
                btnRespuesta1.BackColor = Color.YellowGreen
                puntuacion += 100 * contpregunta
                acierto = True
            Else
                btnRespuesta1.BackColor = Color.IndianRed
            End If

        End If
    End Sub
    Private Sub btnRespuesta2_Click(sender As Object, e As EventArgs) Handles btnRespuesta2.Click
        If contador < 20 Then
            contador = 20
            If respuestaCorrecta = btnRespuesta2.Text Then
                btnRespuesta2.BackColor = Color.YellowGreen
                puntuacion += 100 * contpregunta
                acierto = True
            Else
                btnRespuesta2.BackColor = Color.IndianRed
            End If
        End If
    End Sub
    Private Sub btnRespuesta3_Click(sender As Object, e As EventArgs) Handles btnRespuesta3.Click
        If contador < 20 Then
            contador = 20
            If respuestaCorrecta = btnRespuesta3.Text Then
                btnRespuesta3.BackColor = Color.YellowGreen
                puntuacion += 100 * contpregunta
                acierto = True
            Else
                btnRespuesta3.BackColor = Color.IndianRed
            End If
        End If
    End Sub
    Private Sub btnRespuesta4_Click(sender As Object, e As EventArgs) Handles btnRespuesta4.Click
        If contador < 20 Then
            contador = 20
            If respuestaCorrecta = btnRespuesta4.Text Then
                btnRespuesta4.BackColor = Color.YellowGreen
                puntuacion += 100 * contpregunta
                acierto = True
            Else
                btnRespuesta4.BackColor = Color.IndianRed
            End If
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        menu.Show()
    End Sub

    Private Sub btnPausa_Click(sender As Object, e As EventArgs) Handles btnPausa.Click
        If contador >= 20 Then
            If timerImagen.Enabled Then
                timerImagen.Stop()
                lblPausar.Visible = True
                If idioma = "en" Then
                    btnPausa.Text = "Resume"
                Else
                    btnPausa.Text = "Reanudar"
                End If
            Else
                timerImagen.Start()
                lblPausar.Visible = False
                If idioma = "en" Then
                    btnPausa.Text = "Pause"
                Else
                    btnPausa.Text = "Pausa"
                End If
            End If
        End If
    End Sub
End Class