Public Class Controller

    Private user As Usuario

    Private conexionBBDD As MiSQLiteConnection

    Public Sub New()
    End Sub

    Public Sub New(user As Usuario, conexionBBDD As MiSQLiteConnection)
        Me.user = user
        Me.conexionBBDD = conexionBBDD
    End Sub

    Public Function verificarLogin(ByVal user As String, ByVal password As String) As String

        'VERIFICAMOS SI EL USUARIO Y CONTRASEÑA ESTAN VACIOS O NO
        If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Los campos no pueden estar vacios.", "ACESSO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If





    End Function


End Class
