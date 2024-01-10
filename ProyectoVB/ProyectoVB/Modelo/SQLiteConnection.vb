Imports System.Data.SQLite

Public Class MiSQLiteConnection
    Public con As SQLiteConnection

    Public Sub New()
        con = New SQLiteConnection(My.Settings.conexion)
    End Sub

    Public Sub AbrirConexion()
        Try
            con.Open()
            MsgBox("Conexión abierta correctamente.")
        Catch ex As Exception
            MsgBox("Error al abrir la conexión: " & ex.Message)
        End Try
    End Sub

    ' Agregamos un método para cerrar la conexión
    Public Sub CerrarConexion()
        If con.State = ConnectionState.Open Then
            con.Close()
            MsgBox("Conexión cerrada correctamente.")
        End If
    End Sub
End Class






