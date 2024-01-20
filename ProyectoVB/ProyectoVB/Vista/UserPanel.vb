Public Class UserPanel
    Dim controller As New Controller()
    Dim listaContactos As New List(Of Contacto)

    ' Tamaños originales
    Private Const tamañoOriginalX As Integer = 655
    Private Const tamañoOriginalY As Integer = 383
    Private Const tamañoFuenteOriginalAgendaLabel As Double = 25
    Private Const tamañoFuenteOriginalcontrolUserButton As Double = 8
    Private Const tamañoFuenteOriginalContactoGroupBox As Double = 13
    Private Const tamañoFuenteOriginalComboBox As Double = 13

    ' Escala de tamaño actual
    Private escalaX As Double = 1.0
    Private escalaY As Double = 1.0

    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamada al método para cargar los nombres de contactos en el ComboBox
        CargarNombresDeContactos()
    End Sub

    Private Sub UserPanel_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Llamamos a la función para ajustar el tamaño
        AjustarTamaño()
    End Sub

    ' Método para cargar los nombres de los contactos en el ComboBox
    Private Sub CargarNombresDeContactos()
        Try
            ' Llamar al método en el controlador para consultar los contactos
            controller.ConsultarContactos(listaContactos)

            ' Limpiar ComboBox antes de cargar los nuevos datos
            contactoComboBox.Items.Clear()

            ' Agregar objetos de Contacto al ComboBox
            For Each contacto As Contacto In listaContactos
                contactoComboBox.Items.Add(contacto.nombre)
            Next
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal al cargar los nombres de contactos
            MessageBox.Show("Error al cargar los nombres de los contactos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub controlUserButton_Click(sender As Object, e As EventArgs) Handles controlUserButton.Click
        ' Verificar si hay elementos seleccionados en el ComboBox
        If contactoComboBox.SelectedIndex <> -1 Then
            ' Obtener el contacto seleccionado
            Dim contactoSeleccionado As Contacto = listaContactos(contactoComboBox.SelectedIndex)

            ' Crear instancia de UserControl1
            Dim userControl As New UserControl1()

            ' Establecer los datos del contacto en UserControl1
            userControl._fichaTitulo = "Información de Contacto"
            userControl.nombreTextBox.Text = contactoSeleccionado.nombre
            userControl.apellidoTextBox.Text = contactoSeleccionado.apellido
            userControl.telefonoTextBox.Text = contactoSeleccionado.telefono.ToString()
            userControl.emailTextBox.Text = contactoSeleccionado.email

            ' Mostrar UserControl1
            MostrarUserControl(userControl)
        End If
    End Sub

    ' Método para mostrar UserControl1 en el panel
    Private Sub MostrarUserControl(userControl As UserControl1)
        ' Limpiar el panel antes de agregar el UserControl
        panelLayoutPanel.Controls.Clear()

        ' Añadir UserControl1 al panel
        panelLayoutPanel.Controls.Add(userControl)
        userControl.Dock = DockStyle.Fill
    End Sub

    Private Sub AjustarTamaño()
        ' Calcular la escala actual
        escalaX = Me.Width / tamañoOriginalX
        escalaY = Me.Height / tamañoOriginalY

        ' Ajustar tamaños de fuente y elementos según la escala
        agendaLabel.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalAgendaLabel * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        controlUserButton.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalcontrolUserButton * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        contactoGroupBox.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalContactoGroupBox * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        contactoComboBox.Font = New Font("Microsoft Sans Serif", CSng(tamañoFuenteOriginalComboBox * escalaY), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        ' Ajustar tamaños de elementos según la escala
        agendaBox.Size = New Size(CInt(144 * escalaX), CInt(110 * escalaY))
        controlUserButton.Size = New Size(CInt(120 * escalaX), CInt(42 * escalaY))
        contactoGroupBox.Size = New Size(CInt(306 * escalaX), CInt(110 * escalaY))
        contactoComboBox.Size = New Size(CInt(188 * escalaX), CInt(30 * escalaY))
    End Sub
End Class



