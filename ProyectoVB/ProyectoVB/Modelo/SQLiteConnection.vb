Imports System.Data.SQLite

Public Class MiSQLiteConnection

    Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)

    Public Sub AbrirConexion()
        Try
            con.Open()
            MsgBox("Conexión abierta correctamente.")
            ' Puedes realizar otras operaciones con la conexión aquí.
            ' Por ejemplo, ejecutar consultas SQL, realizar operaciones en la base de datos, etc.
        Catch ex As Exception
            MsgBox("Error al abrir la conexión: " & ex.Message)
        End Try
    End Sub

    ' ... otros miembros y métodos de tu clase

End Class


