Public Class Usuario

    Public Property id As Integer

    Public Property name As String

    Public Property password As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, name As String, password As String)
        Me.id = id
        Me.name = name
        Me.password = password
    End Sub


End Class
