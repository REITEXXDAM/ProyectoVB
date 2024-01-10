Public Class Login
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        command.ConsultarUsuarios(controller.listaUsuarios)
        Dim usuario As String = userTextBox.Text.ToLower
        Dim password As String = passwordTextBox.Text

        ' Verifica las credenciales
        If controller.VerificarLogin(usuario, password) Then
            ' Si las credenciales son correctas, abre el formulario correspondiente
            If controller.UsuarioEsAdmin(usuario, password) Then
                ' Abrir el formulario de administrador
                Dim adminPanel As New AdminPanel()
                adminPanel.Show()
            ElseIf controller.UsuarioEsUser(usuario, password) Then
                ' Abrir el formulario de usuario normal
                Dim userPanel As New UserPanel()
                userPanel.Show()
            End If
        Else
            ' Si las credenciales son incorrectas, muestra un mensaje
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub agendaBox_Click(sender As Object, e As EventArgs) Handles agendaBox.Click
        ' Código para el evento de hacer clic en agendaBox
    End Sub

    Private Sub Login_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Código para el evento de cambio de tamaño del formulario
    End Sub
End Class


