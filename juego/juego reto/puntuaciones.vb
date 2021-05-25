Imports MySql.Data.MySqlClient

Public Class Puntuaciones
    Private cn As MySqlConnection
    Public menu As menu
    Public puntuacion As Integer
    Dim contador As Integer = 1
    Dim contadorruleta As Integer = 0
    Dim rotacion(3) As RotateFlipType
    Private Sub puntuaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = conectar()
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        'cmd = New MySqlCommand("insert into scores (id_user ,score, date) VALUES (? , ?,  ?);", cn)
        cmd = New MySqlCommand("subir_puntuacion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_usuario", menu.user)
        cmd.Parameters.AddWithValue("@scoreRec", puntuacion)
        cmd.Parameters.Add("@resultado", SqlDbType.Int)
        cmd.Parameters("@resultado").Direction = ParameterDirection.ReturnValue
        cmd.ExecuteScalar()
        txtPuntuacion.Text = cmd.Parameters("@resultado").Value
        cmd = New MySqlCommand("select score from scores where id_user=? order by score desc LIMIT 10", cn)
        cmd.Parameters.Add(New MySqlParameter("id_user", menu.user))
        Try
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                While dr.Read
                    lstPuntuacion.Items.Add(contador & "- " & dr.GetInt32("score"))
                    If puntuacion = dr.GetInt32("score") Then
                        lstPuntuacion.SelectedIndex = contador - 1
                    End If
                    contador += 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        rotacion(0) = RotateFlipType.Rotate90FlipNone
        rotacion(1) = RotateFlipType.Rotate180FlipNone
        rotacion(2) = RotateFlipType.Rotate270FlipNone
        rotacion(3) = RotateFlipType.RotateNoneFlipNone
        tmRuleta.Start()
        If menu.idioma = "en" Then
            lblPuntuacion.Text = "Final Score:"
            lblTop10.Text = "Your top 10 scores:"
            btnMenu.Text = "MAIN MENU"
            btnSalir.Text = "EXIT"
        End If
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        menu.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub tmRuleta_Tick(sender As Object, e As EventArgs) Handles tmRuleta.Tick
        If contadorruleta = 4 Then
            contadorruleta = 0
        End If
        pbRuleta1.Image.RotateFlip(rotacion(contadorruleta))
        pbRuleta2.Image.RotateFlip(rotacion(contadorruleta))
        pbRuleta1.Refresh()
        pbRuleta2.Refresh()
        contadorruleta += 1
    End Sub
End Class