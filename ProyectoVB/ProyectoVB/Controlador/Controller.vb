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

    Public Function InsertarContacto(ByVal nombre As String, ByVal apellido As String, ByVal telefono As Integer, ByVal email As String) As Boolean
        Try
            ' Verificar que los datos sean válidos (puedes agregar más lógica de validación según tus requerimientos)
            If String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(apellido) Or telefono <= 0 Or String.IsNullOrEmpty(email) Then
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Llamar al método en SQLiteCommand para insertar el contacto en la base de datos
            Dim sqliteCommand As New SQLiteCommand()
            sqliteCommand.InsertarContacto(nombre, apellido, telefono, email, conexionBBDD)

            ' Puedes realizar más validaciones o acciones después de la inserción si es necesario

            Return True
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal en la inserción
            MessageBox.Show("Error al insertar el contacto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


End Class




