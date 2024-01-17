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

    ' Resto del código...
End Class
