Public Class Login
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        AjustarTamaño()
    End Sub

    Private Sub AjustarTamaño()
        ' Tamaños de fuente específicos
        Dim tamFuenteAgenda As Double = 25 * Me.Height / 365
        tamFuenteAgenda = If(tamFuenteAgenda < 25, 25, tamFuenteAgenda)

        Dim tamFuenteGeneral As Double = 13 * Me.Height / 365
        tamFuenteGeneral = If(tamFuenteGeneral < 13, 13, tamFuenteGeneral)

        ' Aplicar tamaños de fuente
        agendaLabel.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteAgenda), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        ' Aplicar tamaños de fuente a todos los elementos del formulario
        For Each control As Control In Controls
            If TypeOf control Is GroupBox Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteGeneral), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            ElseIf TypeOf control Is TextBox Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteGeneral), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            ElseIf TypeOf control Is Button Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteGeneral), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            End If
        Next
    End Sub


    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        ' Resto del código del evento
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

    Private Sub principalLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles principalLayoutPanel.Paint

    End Sub
End Class



