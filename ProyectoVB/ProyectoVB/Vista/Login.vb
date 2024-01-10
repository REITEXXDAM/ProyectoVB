Public Class Login
    Dim controller As New Controller()

    Dim command As New SQLiteCommand()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama al método ConsultarUsuarios y pasa la lista de usuarios al controlador
        command.ConsultarUsuarios(controller.listaUsuarios)
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim usuario As String = userTextBox.Text.ToLower
        Dim password As String = passwordTextBox.Text
        controller.VerificarLogin(usuario, password)
    End Sub
End Class


