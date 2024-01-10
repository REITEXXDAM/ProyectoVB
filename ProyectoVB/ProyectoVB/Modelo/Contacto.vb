Public Class Contacto

    Public Property nombre As String
    Public Property apellido As String

    Public Property telefono As Integer
    Public Property email As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, apellido As String, telefono As Integer, email As String)

        Me.nombre = nombre
        Me.apellido = apellido
        Me.telefono = telefono
        Me.email = email
    End Sub
End Class
