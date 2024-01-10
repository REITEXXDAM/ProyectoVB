Public Class Login
    Dim controller As New Controller()

    Dim command As New SQLiteCommand()

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        command.ConsultarUsuarios(controller.listaUsuarios)
        Dim usuario As String = userTextBox.Text.ToLower
        Dim password As String = passwordTextBox.Text
        controller.VerificarLogin(usuario, password)
    End Sub
End Class


