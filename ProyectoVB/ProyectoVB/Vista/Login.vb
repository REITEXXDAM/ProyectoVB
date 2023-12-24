Public Class Login

    Dim controller As New Controller()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim usuario As String = userTextBox.Text.ToLower

        Dim password As String = passwordTextBox.Text

        controller.verificarLogin(usuario, password)







    End Sub

End Class