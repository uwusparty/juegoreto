Imports MySql.Data.MySqlClient
Module FuncionesBD
    Dim cn As MySqlConnection

    Public Function conectar() As MySqlConnection
        Dim conexion As New MySqlConnection("Server=192.168.6.61;user id=almi;password=Almi123;database=trivialmi")
        Try
            'Dim cn As String = "Server=192.168.6.61;user id=almi;password=Almi123;database=trivialmi"
            conexion.Open() 'PARA ABRIR LA BASE DE DATOS
            'conexion.Close() PARA CERRAR LA BASE DE DATOS
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
