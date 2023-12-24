Public Class Controller

    'BBDD
    Dim conexionBBDD As New MiSQLiteConnection()

    Dim comandoBBDD As New SQLiteCommand()

    'USUARIOS
    Dim user As New Usuario()
    Dim listaUsuario As New List(Of Usuario)

    Public Sub New()
    End Sub


    Public Function verificarLogin(ByVal user As String, ByVal password As String) As String

        'VERIFICAMOS SI EL USUARIO Y CONTRASEÑA ESTAN VACIOS O NO
        If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Los campos no pueden estar vacios.", "ACESSO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





    End Function




End Class
