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
    Dim guardarPreguntas As List(Of String)
    Dim numRandom As Integer
    Dim arrayRespuestas(3) As String
    Dim arrayElegido(3) As String
    Dim arrayResPos(3) As String
    Dim respuestaCorrecta As String
    Dim acierto As Boolean
    Private readPreg As Linq.JObject
    Public idioma As String
    Public categoria As String
    Public menu As menu
    Dim milisegundos As Integer = 0

    Public Function getPreguntas() As List(Of String)
        Dim json = n.DownloadString("http://192.168.6.218:8080/trivialmi/questions/" & categoria)
        Dim read = Linq.JObject.Parse(json)
        Dim arrayPreguntas As List(Of String) = New List(Of String)
        For i As Integer = 0 To read.Item("data").Count - 1
            arrayPreguntas.Add(read.Item("data")(i).ToString)
        Next
        Return arrayPreguntas
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timerImagen.Tick
        If preguntas < 10 Then
            If contador = 0 Then
                milisegundos = 0
                lblNumpregunta.Text = preguntas + 1 & " / 10"
                btnPausa.Visible = False
                btnValorar.Visible = False
                acierto = False
                lblPregunta.Hide()
                btnRespuesta1.Hide()
                btnRespuesta2.Hide()
                btnRespuesta3.Hide()
                btnRespuesta4.Hide()
                lblElegido1.Hide()
                lblElegido2.Hide()
                lblElegido3.Hide()
                lblElegido4.Hide()
                picFoto.Show()
                btnRespuesta1.BackColor = DefaultBackColor
                btnRespuesta2.BackColor = DefaultBackColor
                btnRespuesta3.BackColor = DefaultBackColor
                btnRespuesta4.BackColor = DefaultBackColor

                numRandom = CInt(Int((guardarPreguntas.Count * Rnd()) + 0))
                readPreg = Linq.JObject.Parse(guardarPreguntas.Item(numRandom))
                Dim stImage As Bitmap
                Try
                    stImage = Bitmap.FromStream(New MemoryStream(n.DownloadData("file://///192.168.6.216/juego/categorias/" & readPreg.Item("image_url").ToString)))
                Catch ex As Exception
                    stImage = Bitmap.FromStream(New MemoryStream(n.DownloadData("file://///192.168.6.216/juego/noimage.png")))
                End Try

                picFoto.Image = stImage
                lblPregunta.Text = readPreg.Item("question")(idioma).ToString
                arrayRespuestas(0) = readPreg.Item("correct")(idioma).ToString
                respuestaCorrecta = readPreg.Item("correct")(idioma).ToString
                arrayRespuestas(1) = readPreg.Item("incorrects")(0)(idioma).ToString
                arrayRespuestas(2) = readPreg.Item("incorrects")(1)(idioma).ToString
                arrayRespuestas(3) = readPreg.Item("incorrects")(2)(idioma).ToString
                arrayElegido(0) = readPreg.Item("correct")("times").ToString
                arrayElegido(1) = readPreg.Item("incorrects")(0)("times").ToString
                arrayElegido(2) = readPreg.Item("incorrects")(1)("times").ToString
                arrayElegido(3) = readPreg.Item("incorrects")(2)("times").ToString
                arrayResPos(0) = "correct.times"
                arrayResPos(1) = "incorrects.0.times"
                arrayResPos(2) = "incorrects.1.times"
                arrayResPos(3) = "incorrects.2.times"
                Dim aux As String
                For i As Integer = 0 To 3
                    Dim respRandom = CInt(Int((3 * Rnd()) + 0))
                    aux = arrayRespuestas(i)
                    arrayRespuestas(i) = arrayRespuestas(respRandom)
                    arrayRespuestas(respRandom) = aux

                    aux = arrayElegido(i)
                    arrayElegido(i) = arrayElegido(respRandom)
                    arrayElegido(respRandom) = aux

                    aux = arrayResPos(i)
                    arrayResPos(i) = arrayResPos(respRandom)
                    arrayResPos(respRandom) = aux
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

                Dim json = n.DownloadString("http://192.168.6.218:8080/trivialmi/users/rated/id/" & menu.user)
                Dim read = Linq.JObject.Parse(json)
                If read.Item("data")(0)("rated_questions").ToString.Contains(readPreg.Item("_id").ToString) Then
                    btnValorar.BackColor = Color.CornflowerBlue
                Else
                    btnValorar.BackColor = Color.White
                End If
                btnValorar.Visible = True
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

                Dim total As Integer
                total = Val(arrayElegido(0)) + Val(arrayElegido(1)) + Val(arrayElegido(2)) + Val(arrayElegido(3))
                lblElegido1.Text = Format(arrayElegido(0) / total * 100, "0.##") & "%"
                lblElegido2.Text = Format(arrayElegido(1) / total * 100, "0.##") & "%"
                lblElegido3.Text = Format(arrayElegido(2) / total * 100, "0.##") & "%"
                lblElegido4.Text = Format(arrayElegido(3) / total * 100, "0.##") & "%"
                lblElegido1.BackColor = btnRespuesta1.BackColor
                lblElegido2.BackColor = btnRespuesta2.BackColor
                lblElegido3.BackColor = btnRespuesta3.BackColor
                lblElegido4.BackColor = btnRespuesta4.BackColor
                lblElegido1.Show()
                lblElegido2.Show()
                lblElegido3.Show()
                lblElegido4.Show()

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
        timerMilisegundos.Start()
        timerImagen.Start()
        guardarPreguntas = getPreguntas()
        Randomize()
        If idioma = "en" Then
            btnVolver.Text = "<<BACK"
            btnPausa.Text = "Pause"
            lblPausar.Text = "Game Paused"
            lblPuntu.Text = "Score"
        End If


    End Sub

    Private Sub btnRespuesta1_Click(sender As Object, e As EventArgs) Handles btnRespuesta1.Click
        If contador < 20 And contador <> 0 Then
            Dim reqparm As New Specialized.NameValueCollection
            arrayElegido(0) = arrayElegido(0) + 1
            reqparm.Add(arrayResPos(0), Val(arrayElegido(0)))
            n.UploadValues("http://192.168.6.218:8080/trivialmi/questions/times/id/" & readPreg.Item("_id").ToString, "PUT", reqparm)

            contador = 20
            If respuestaCorrecta = btnRespuesta1.Text Then
                btnRespuesta1.BackColor = Color.YellowGreen
                puntuacion += 1500 - milisegundos
                acierto = True
            Else
                btnRespuesta1.BackColor = Color.IndianRed
            End If
        End If
    End Sub
    Private Sub btnRespuesta2_Click(sender As Object, e As EventArgs) Handles btnRespuesta2.Click
        If contador < 20 And contador <> 0 Then
            Dim reqparm As New Specialized.NameValueCollection
            arrayElegido(1) = arrayElegido(1) + 1
            reqparm.Add(arrayResPos(1), Val(arrayElegido(1)))
            n.UploadValues("http://192.168.6.218:8080/trivialmi/questions/times/id/" & readPreg.Item("_id").ToString, "PUT", reqparm)

            contador = 20
            If respuestaCorrecta = btnRespuesta2.Text Then
                btnRespuesta2.BackColor = Color.YellowGreen
                puntuacion += 1500 - milisegundos
                acierto = True
            Else
                btnRespuesta2.BackColor = Color.IndianRed
            End If
        End If
    End Sub
    Private Sub btnRespuesta3_Click(sender As Object, e As EventArgs) Handles btnRespuesta3.Click
        If contador < 20 And contador <> 0 Then
            Dim reqparm As New Specialized.NameValueCollection
            arrayElegido(2) = arrayElegido(2) + 1
            reqparm.Add(arrayResPos(2), Val(arrayElegido(2)))
            n.UploadValues("http://192.168.6.218:8080/trivialmi/questions/times/id/" & readPreg.Item("_id").ToString, "PUT", reqparm)

            contador = 20
            If respuestaCorrecta = btnRespuesta3.Text Then
                btnRespuesta3.BackColor = Color.YellowGreen
                puntuacion += 1500 - milisegundos
                acierto = True
            Else
                btnRespuesta3.BackColor = Color.IndianRed
            End If
        End If
    End Sub
    Private Sub btnRespuesta4_Click(sender As Object, e As EventArgs) Handles btnRespuesta4.Click
        If contador < 20 And contador <> 0 Then
            Dim reqparm As New Specialized.NameValueCollection
            arrayElegido(3) = arrayElegido(3) + 1
            reqparm.Add(arrayResPos(3), Val(arrayElegido(3)))
            n.UploadValues("http://192.168.6.218:8080/trivialmi/questions/times/id/" & readPreg.Item("_id").ToString, "PUT", reqparm)

            contador = 20
            If respuestaCorrecta = btnRespuesta4.Text Then
                btnRespuesta4.BackColor = Color.YellowGreen
                puntuacion += 1500 - milisegundos
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

    Private Sub btnValorar_Click(sender As Object, e As EventArgs) Handles btnValorar.Click
        Dim reqparm As New Specialized.NameValueCollection

        If btnValorar.BackColor = Color.White Then
            reqparm.Add("rated_questions", readPreg.Item("_id").ToString)
            n.UploadValues("http://192.168.6.218:8080/trivialmi/users/rated/id/" & menu.user, "PUT", reqparm)
            btnValorar.BackColor = Color.CornflowerBlue
        Else

            reqparm.Add("rated_questions", readPreg.Item("_id").ToString)
            n.UploadValues("http://192.168.6.218:8080/trivialmi/users/rated/id/" & menu.user, "DELETE", reqparm)
            btnValorar.BackColor = Color.White
        End If
    End Sub

    Private Sub timerMilisegundos_Tick(sender As Object, e As EventArgs) Handles timerMilisegundos.Tick
        milisegundos += 1
    End Sub
End Class