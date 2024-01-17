Public Class Controller
    Dim conexionBBDD As New MiSQLiteConnection()
    Public listaUsuarios As New List(Of Usuario)
    Public listaContactos As New List(Of Contacto)

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

    Public Function ConsultarContactos(ByVal listaContactos As List(Of Contacto)) As Boolean
        Try
            ' Llamar al método en SQLiteCommand para consultar los contactos en la base de datos
            Dim sqliteCommand As New SQLiteCommand()
            sqliteCommand.ConsultarContactos(listaContactos, conexionBBDD)

            ' Puedes realizar más validaciones o acciones después de la consulta si es necesario

            Return True
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal en la consulta
            MessageBox.Show("Error al consultar los contactos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function InsertarContacto(ByVal nombre As String, ByVal apellido As String, ByVal telefono As Integer, ByVal email As String) As Boolean
        Try
            ' Verificar que los datos sean válidos
            If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellido) Or telefono <= 0 Or String.IsNullOrEmpty(email) Then
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Verificar si el email ya existe
            If EmailExiste(email, -1) Then
                MessageBox.Show("El correo electrónico ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    Public Function ActualizarContacto(ByVal id As Integer, ByVal nuevoNombre As String, ByVal nuevoApellido As String, ByVal nuevoTelefono As Integer, ByVal nuevoEmail As String) As Boolean
        Try
            ' Verificar que los datos sean válidos
            If String.IsNullOrEmpty(nuevoNombre) Or String.IsNullOrEmpty(nuevoApellido) Or nuevoTelefono <= 0 Or String.IsNullOrEmpty(nuevoEmail) Then
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Verificar si el email ya existe
            If EmailExiste(nuevoEmail, id) Then
                MessageBox.Show("El correo electrónico ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            ' Llamar al método en SQLiteCommand para actualizar el contacto en la base de datos
            Dim sqliteCommand As New SQLiteCommand()
            sqliteCommand.ActualizarContacto(id, nuevoNombre, nuevoApellido, nuevoTelefono, nuevoEmail, conexionBBDD)

            ' Puedes realizar más validaciones o acciones después de la actualización si es necesario

            Return True
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal en la actualización
            MessageBox.Show("Error al actualizar el contacto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function EliminarContacto(ByVal idContacto As Integer) As Boolean
        Try
            ' Llamar al método en SQLiteCommand para eliminar el contacto en la base de datos
            Dim sqliteCommand As New SQLiteCommand()
            sqliteCommand.EliminarContacto(idContacto, conexionBBDD)

            ' Puedes realizar más validaciones o acciones después de la eliminación si es necesario

            Return True
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal en la eliminación
            MessageBox.Show("Error al eliminar el contacto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function EmailExiste(ByVal email As String, ByVal idExcluir As Integer) As Boolean
        ' Verificar si el correo electrónico ya existe en la base de datos, excluyendo el contacto actual
        For Each contacto As Contacto In listaContactos
            If contacto.email.ToLower() = email.ToLower() AndAlso contacto.id <> idExcluir Then
                Return True
            End If
        Next

        Return False
    End Function


End Class




