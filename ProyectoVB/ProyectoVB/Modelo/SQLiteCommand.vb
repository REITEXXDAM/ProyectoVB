Imports System.Data.SQLite
Imports SQLiteCmd = System.Data.SQLite.SQLiteCommand

Public Class SQLiteCommand

    Public Sub ConsultarUsuarios(ByVal listaUsuarios As List(Of Usuario))
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = "SELECT ID, NAME, PASSWORD FROM USUARIO"
            conexion.Open()
            Dim cmd As New SQLiteCmd(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()

            While lector.Read()
                Dim id As Integer = lector.GetInt32(0)
                Dim nombre As String = lector.GetString(1)
                Dim password As String = lector.GetString(2)

                ' Crea un nuevo usuario y agrégalo a la lista
                Dim nuevoUsuario As New Usuario(id, nombre, password)
                listaUsuarios.Add(nuevoUsuario)
            End While

            lector.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertarContacto(ByVal nombre As String, ByVal apellido As String, ByVal telefono As Integer, ByVal email As String, ByVal conexion As MiSQLiteConnection)
        Try
            Using conexionSQLite As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
                Dim consulta As String = "INSERT INTO CONTACTO (NOMBRE, APELLIDO, TELEFONO, EMAIL) VALUES (@nombre, @apellido, @telefono, @email)"
                conexionSQLite.Open()
                Using cmd As New SQLiteCmd(consulta, conexionSQLite)
                    ' Assign parameters with the values of the new contact
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@telefono", telefono)
                    cmd.Parameters.AddWithValue("@email", email)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Ensure to close the connection after use
            conexion.CerrarConexion()
        End Try
    End Sub

    Public Sub ConsultarContactos(ByVal listaContactos As List(Of Contacto), conexionBBDD As MiSQLiteConnection)
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = "SELECT CODIGO, NOMBRE, APELLIDO, TELEFONO, EMAIL FROM CONTACTO"
            conexion.Open()
            Dim cmd As New SQLiteCmd(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()

            While lector.Read()
                Dim id As Integer = lector.GetInt32(0)
                Dim nombre As String = lector.GetString(1)
                Dim apellido As String = lector.GetString(2)
                Dim telefono As String = lector.GetString(3)
                Dim email As String = lector.GetString(4)


                ' Crea un nuevo usuario y agrégalo a la lista
                Dim nuevoContacto As New Contacto(id, nombre, apellido, telefono, email)
                listaContactos.Add(nuevoContacto)
            End While

            lector.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ExecuteReader() As SQLiteDataReader
        Throw New NotImplementedException()
    End Function
End Class




