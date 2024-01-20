Public Class UserControl1
    Private _nombre As String
    Private _Apellido As String
    Private _telefono As Integer
    Private _email As String
    Private _activoLabel As String
    Private __fichaTitulo As String
    Private _MinimumSize As Size 'INSTANCIAMOS LA VARIABLE PARA AJUSTAR EL TAMAÑO MINIMO

    Public Event ClickBoton()


    Public Overrides Property MinimumSize As Size 'ESTABLECEMOS EL TAMAÑO MINIMO, SIN QUE SE PUEDA MODIFICAR
        Get
            Return MyBase.MinimumSize
        End Get
        Set(value As Size)
            MyBase.MinimumSize = New Size(1065, 775)
        End Set
    End Property

    'CREAMOS LAS VARIABLES PARA LOS LABELS
    Property _fichaTitulo As String
        Get
            Return tituloLabel.Text
        End Get
        Set
            tituloLabel.Text = Value
        End Set
    End Property
    Property nombre As String
        Get
            Return nombreLabel.Text
        End Get
        Set
            nombreLabel.Text = Value
        End Set
    End Property

    Property apellido As String
        Get
            Return apellidoLabel.Text
        End Get
        Set
            apellidoLabel.Text = Value
        End Set
    End Property


    Property telefono As Integer
        Get
            Return telefonoLabel.Text.ToString
        End Get
        Set
            telefonoLabel.Text = Value
        End Set
    End Property

    Property email As String
        Get
            Return emailLabel.Text
        End Get
        Set
            emailLabel.Text = Value
        End Set
    End Property

    Private Sub llamarButton_Click(sender As Object, e As EventArgs) Handles llamarButton.Click
        RaiseEvent ClickBoton()
    End Sub

    Private Sub emailButton_Click(sender As Object, e As EventArgs) Handles emailButton.Click
        RaiseEvent ClickBoton()
    End Sub
End Class
