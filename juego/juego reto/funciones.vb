Imports MySql.Data.MySqlClient
Module FuncionesBD
    Dim cn As MySqlConnection

    Public Function conectar() As MySqlConnection
        Dim conexion As New MySqlConnection("Server=192.168.6.216;user id=almi;password=Almi123;database=trivialmi")
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function obtenerDatos(strSql As String, cn As MySqlConnection)
        Dim command As MySqlCommand
        Dim dr As MySqlDataReader
        command = New MySqlCommand(strSql, cn)

        dr = command.ExecuteReader()
        Return dr
    End Function
End Module
