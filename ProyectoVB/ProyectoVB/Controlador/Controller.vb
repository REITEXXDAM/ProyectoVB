Public Class Controller
    Dim conexionBBDD As New MiSQLiteConnection()
    Public listaUsuarios As New List(Of Usuario)

    Public Sub VerificarLogin(ByVal user As String, ByVal password As String)
        'VERIFICAMOS SI EL USUARIO Y CONTRASEÑA ESTÁN VACÍOS O NO
        If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Los campos no pueden estar vacíos.", "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verifica las credenciales con la lista de usuarios
        Dim usuarioEncontrado As Boolean = False
        For Each usuario In listaUsuarios
            If usuario.Nombre.ToLower() = user.ToLower() AndAlso usuario.Password = password Then
                usuarioEncontrado = True
                Exit For
            End If
        Next

        ' Muestra el mensaje correspondiente
        If usuarioEncontrado Then
            MsgBox("Inicio de sesión exitoso.", MsgBoxStyle.Information)
        Else
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class



