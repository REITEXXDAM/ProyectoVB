Public Class Login
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()

    ' Tamaños originales
    Private Const tamañoOriginalX As Integer = 630
    Private Const tamañoOriginalY As Integer = 349
    Private Const tamañoFuenteOriginalAgendaLabel As Double = 25
    Private Const tamañoFuenteOriginalDatosLayoutPanel As Double = 8
    Private Const tamañoFuenteOriginalGroupBox As Double = 13
    Private Const tamañoFuenteOriginalTextBox As Double = 13
    Private Const tamañoFuenteOriginalButton As Double = 16

    ' Escala de tamaño actual
    Private escalaX As Double = 1.0
    Private escalaY As Double = 1.0

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Llamamos a la función para ajustar el tamaño
        AjustarTamaño()
    End Sub

    Private Sub AjustarTamaño()
        ' Calcular la escala actual
        Dim escalaX As Double = Me.Width / tamañoOriginalX
        Dim escalaY As Double = Me.Height / tamañoOriginalY

        ' Ajustar tamaños de fuente y elementos según la escala
        agendaLabel.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalAgendaLabel * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        datosLayoutPanel.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalDatosLayoutPanel * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        ' Ajustar tamaños de fuente a todos los elementos del formulario
        For Each control As Control In Controls
            If TypeOf control Is GroupBox Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalGroupBox * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            ElseIf TypeOf control Is TextBox Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalTextBox * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            ElseIf TypeOf control Is Button Then
                If control.Name = "loginButton" Then
                    ' Ajustar tamaño específico del botón de login
                    control.Size = New Size(CInt(366 * escalaX), CInt(35 * escalaY))
                End If
                control.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalButton * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            End If
        Next

        ' Ajustar tamaños de elementos según la escala
        agendaBox.Size = New Size(CInt(285 * escalaX), CInt(126 * escalaY))
        datosLayoutPanel.Size = New Size(CInt(292 * escalaX), CInt(68 * escalaY))
        nameGroupBox.Size = New Size(CInt(320 * escalaX), CInt(58 * escalaY))
        passwordGroupBox.Size = New Size(CInt(320 * escalaX), CInt(58 * escalaY))
        userTextBox.Size = New Size(CInt(48 * escalaX), CInt(24 * escalaY))
        passwordTextBox.Size = New Size(CInt(48 * escalaX), CInt(24 * escalaY))
        loginButton.Size = New Size(CInt(366 * escalaX), CInt(241 * escalaY))
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




