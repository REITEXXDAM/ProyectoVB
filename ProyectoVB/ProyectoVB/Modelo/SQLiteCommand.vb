Imports System.Data.SQLite
Imports SQLiteCmd = System.Data.SQLite.SQLiteCommand

Public Class SQLiteCommand

    Public Sub ConsultarUsuarios()
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = "SELECT ID, NAME, PASSWORD FROM USUARIO"
            conexion.Open()
            Dim cmd As New SQLiteCmd(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()

            Dim resultado As String = ""

            While lector.Read()
                resultado &= lector.GetInt32(0) & "-" & lector.GetString(1) & "-" & lector.GetString(2) & vbLf
            End While

            MsgBox(resultado)

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



