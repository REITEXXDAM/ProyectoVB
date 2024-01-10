Public Class Usuario
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Password As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, password As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Password = password
    End Sub
End Class

