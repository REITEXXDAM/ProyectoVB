Imports System.Data.SQLite

Public Class SQLiteConnectionWrapper

    Public Sub AbrirConexion()
        Dim connectionString As String = "Data Source=C:\ruta\a\tu\base\de\datos.db;Version=3;"
        Dim con As SQLiteConnection = New SQLiteConnection(connectionString)

        Try
            con.Open()
            MsgBox("Conexión abierta correctamente.")
            ' Puedes realizar otras operaciones con la conexión aquí.
            ' Por ejemplo, ejecutar consultas SQL, realizar operaciones en la base de datos, etc.
        Catch ex As Exception
            MsgBox("Error al abrir la conexión: " & ex.Message)
        Finally
            ' Asegúrate de cerrar la conexión al finalizar.
            If con.State = ConnectionState.Open Then
                con.Close()
                MsgBox("Conexión cerrada correctamente.")
            End If
        End Try
    End Sub

End Class

