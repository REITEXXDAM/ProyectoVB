Public Class Contacto

    Public Property id As Integer
    Public Property nombre As String
    Public Property apellido As String

    Public Property telefono As Integer
    Public Property email As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, apellido As String, telefono As Integer, email As String)

        Me.id = id
        Me.nombre = nombre
        Me.apellido = apellido
        Me.telefono = telefono
        Me.email = email
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim contacto = TryCast(obj, Contacto)
        Return contacto IsNot Nothing AndAlso
               email = contacto.email
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -1970842681
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(email)).GetHashCode()
        Return hashCode
    End Function
End Class
