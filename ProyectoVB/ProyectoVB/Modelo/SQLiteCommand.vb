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

    Private Function ExecuteReader() As SQLiteDataReader
        Throw New NotImplementedException()
    End Function
End Class




