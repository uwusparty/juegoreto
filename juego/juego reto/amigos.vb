Public Class amigos
    Dim menu As menu
    Public Sub New(menu As menu)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.menu = menu
    End Sub
    Private Sub amigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        menu.formAmigos = Nothing
        Me.Close()
    End Sub
End Class