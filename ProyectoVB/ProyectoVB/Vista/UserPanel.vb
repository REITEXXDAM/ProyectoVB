Public Class UserPanel
    Dim controller As New Controller()
    Dim listaContactos As New List(Of Contacto)

    Private Const tamañoOriginalX As Integer = 655
    Private Const tamañoOriginalY As Integer = 383
    Private Const tamañoFuenteOriginalAgendaLabel As Double = 25
    Private Const tamañoFuenteOriginalcontrolUserButton As Double = 8
    Private Const tamañoFuenteOriginalContactoGroupBox As Double = 13
    Private Const tamañoFuenteOriginalComboBox As Double = 13

    Private escalaX As Double = 1.0
    Private escalaY As Double = 1.0

    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNombresDeContactos()
    End Sub

    Private Sub UserPanel_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        AjustarTamaño()
    End Sub

    Private Sub CargarNombresDeContactos()
        Try
            controller.ConsultarContactos(listaContactos)
            contactoComboBox.Items.Clear()
            For Each contacto As Contacto In listaContactos
                contactoComboBox.Items.Add(contacto.nombre)
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los contactos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub controlUserButton_Click(sender As Object, e As EventArgs) Handles controlUserButton.Click
        If contactoComboBox.SelectedIndex <> -1 Then
            Dim contactoSeleccionado As Contacto = listaContactos(contactoComboBox.SelectedIndex)
            Dim userControl As New UserControl1()
            userControl._fichaTitulo = "Información de Contacto"
            userControl.nombreTextBox.Text = contactoSeleccionado.nombre
            userControl.apellidoTextBox.Text = contactoSeleccionado.apellido
            userControl.telefonoTextBox.Text = contactoSeleccionado.telefono.ToString()
            userControl.emailTextBox.Text = contactoSeleccionado.email
            MostrarUserControl(userControl)
        End If
    End Sub

    Private Sub MostrarUserControl(userControl As UserControl1)
        panelLayoutPanel.Controls.Clear()
        panelLayoutPanel.Controls.Add(userControl)
        userControl.Dock = DockStyle.Fill
    End Sub

    Private Sub AjustarTamaño()
        escalaX = Me.Width / tamañoOriginalX
        escalaY = Me.Height / tamañoOriginalY
        agendaLabel.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalAgendaLabel * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        controlUserButton.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalcontrolUserButton * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        contactoGroupBox.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalContactoGroupBox * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        contactoComboBox.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalComboBox * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        agendaBox.Size = New Size(CInt(144 * escalaX), CInt(110 * escalaY))
        controlUserButton.Size = New Size(CInt(120 * escalaX), CInt(42 * escalaY))
        contactoGroupBox.Size = New Size(CInt(306 * escalaX), CInt(110 * escalaY))
        contactoComboBox.Size = New Size(CInt(188 * escalaX), CInt(30 * escalaY))
    End Sub

    Private Sub panelLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles panelLayoutPanel.Paint

    End Sub
End Class



