Public Class Controller
    Dim conexionBBDD As New MiSQLiteConnection()
    Public listaUsuarios As New List(Of Usuario)

    Public Function VerificarLogin(ByVal user As String, ByVal password As String) As Boolean
        'VERIFICAMOS SI EL USUARIO Y CONTRASEÑA ESTÁN VACÍOS O NO
        If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Los campos no pueden estar vacíos.", "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
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
        Return usuarioEncontrado
    End Function

    Public Function UsuarioEsAdmin(ByVal user As String, ByVal password As String) As Boolean
        ' Lógica para determinar si el usuario es un administrador
        ' Puedes cambiar esto según tu implementación específica
        Return user.ToLower() = "admin" AndAlso password = "admin"
    End Function

    Public Function UsuarioEsUser(ByVal user As String, ByVal password As String) As Boolean
        ' Lógica para determinar si el usuario es un usuario normal
        ' Puedes cambiar esto según tu implementación específica
        Return user.ToLower() = "user" AndAlso password = "user"
    End Function

End Class




