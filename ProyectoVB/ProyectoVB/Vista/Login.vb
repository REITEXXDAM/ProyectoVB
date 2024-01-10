Public Class Login
    Dim controller As New Controller()

    Dim command As New SQLiteCommand()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No es necesario cargar los usuarios aquí, ya que el controlador se encarga de cargarlos al inicializarse.
        ' Puedes quitar esta línea si decides cargar los usuarios en otro momento.

        command.ConsultarUsuarios()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim usuario As String = userTextBox.Text.ToLower
        Dim password As String = passwordTextBox.Text
        controller.VerificarLogin(usuario, password)
    End Sub
End Class

