Public Class UserPanel
    Dim controller As New Controller()
    Dim listaContactos As New List(Of Contacto)

    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamada al método para cargar los nombres de contactos en el ComboBox
        CargarNombresDeContactos()
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

    Private Sub panelLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles panelLayoutPanel.Paint

    End Sub
End Class


