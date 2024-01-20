Public Class UserControl1
    Private _MinimumSize As Size 'INSTANCIAMOS LA VARIABLE PARA AJUSTAR EL TAMAÑO MINIMO

    Public Event ClickBoton()

    Public Sub New()
        InitializeComponent()

        ' Configuraciones adicionales
        Me.MinimumSize = New Size(640, 349)
        Me.AutoSize = True
    End Sub

    'CREAMOS LAS VARIABLES PARA LOS LABELS
    Property _fichaTitulo As String
        Get
            Return tituloLabel.Text
        End Get
        Set(value As String)
            tituloLabel.Text = value
        End Set
    End Property

    Property nombre As String
        Get
            Return nombreTextBox.Text
        End Get
        Set(value As String)
            nombreTextBox.Text = value
        End Set
    End Property

    Property apellido As String
        Get
            Return apellidoTextBox.Text
        End Get
        Set(value As String)
            apellidoTextBox.Text = value
        End Set
    End Property

    Property telefono As Integer
        Get
            Return Integer.Parse(telefonoTextBox.Text)
        End Get
        Set(value As Integer)
            telefonoTextBox.Text = value.ToString()
        End Set
    End Property

    Property email As String
        Get
            Return emailTextBox.Text
        End Get
        Set(value As String)
            emailTextBox.Text = value
        End Set
    End Property

    Private Sub llamarButton_Click(sender As Object, e As EventArgs) Handles llamarButton.Click
        ' Obtener el número de teléfono
        Dim numeroTelefono As String = telefonoTextBox.Text

        ' Mostrar mensaje indicando que se está llamando al número
        MessageBox.Show("Llamando al número: " & numeroTelefono, "Llamada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub emailButton_Click(sender As Object, e As EventArgs) Handles emailButton.Click
        ' Obtener la dirección de correo electrónico
        Dim direccionEmail As String = emailTextBox.Text

        ' Mostrar mensaje indicando que se está enviando un correo electrónico
        MessageBox.Show("Enviando correo electrónico a: " & direccionEmail, "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub fichaEmpleadoLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles fichaEmpleadoLayoutPanel.Paint

    End Sub
End Class


