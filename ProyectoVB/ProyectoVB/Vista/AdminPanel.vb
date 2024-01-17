Public Class AdminPanel
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()
    Public listaContactos As New List(Of Contacto)

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamada al método para cargar los nombres de contactos en el ComboBox
        CargarNombresDeContactos()
    End Sub

    Private Sub contactoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles contactoComboBox.SelectedIndexChanged
        ' Verificar si hay elementos seleccionados en el ComboBox
        If contactoComboBox.SelectedIndex <> -1 Then
            ' Obtener el contacto seleccionado
            Dim contactoSeleccionado As Contacto = listaContactos(contactoComboBox.SelectedIndex)

            ' Mostrar los datos en los TextBox correspondientes
            nombreContactoTextBox.Text = contactoSeleccionado.nombre
            apellidoContactoTextBox.Text = contactoSeleccionado.apellido
            telefonoContactoTextBox.Text = contactoSeleccionado.telefono.ToString()
            emailContactoTextBox.Text = contactoSeleccionado.email
        End If
    End Sub

    ' Método para cargar los nombres de los contactos en el ComboBox
    Private Sub CargarNombresDeContactos()
        Try
            ' Llamar al método en el controlador para consultar los contactos
            controller.ConsultarContactos(listaContactos)

            ' Usar HashSet para evitar duplicados
            Dim nombresSinDuplicados As New HashSet(Of String)()

            ' Agregar nombres de contactos al HashSet
            For Each contacto As Contacto In listaContactos
                nombresSinDuplicados.Add(contacto.nombre)
            Next

            ' Limpiar ComboBox antes de cargar los nuevos datos
            contactoComboBox.Items.Clear()

            ' Agregar nombres sin duplicados al ComboBox
            For Each nombre As String In nombresSinDuplicados
                contactoComboBox.Items.Add(nombre)
            Next
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal al cargar los nombres de contactos
            MessageBox.Show("Error al cargar los nombres de los contactos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub insertarButton_Click(sender As Object, e As EventArgs) Handles insertarButton.Click
        Try
            ' Recoger los datos del formulario
            Dim nombre As String = nombreContactoTextBox.Text
            Dim apellido As String = apellidoContactoTextBox.Text
            Dim telefono As Integer = Convert.ToInt32(telefonoContactoTextBox.Text)
            Dim email As String = emailContactoTextBox.Text

            ' Llamar al método en el controlador para verificar y realizar la inserción
            If controller.InsertarContacto(nombre, apellido, telefono, email) Then
                ' Mostrar mensaje de éxito
                MessageBox.Show("Contacto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los campos del formulario después de la inserción
                LimpiarCampos()

                ' Recarga de datos en el comboBox
                CargarNombresDeContactos()
            Else
                ' Mostrar mensaje de error si la verificación en el controlador falla
                MessageBox.Show("Error al verificar o insertar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal en la recopilación de datos
            MessageBox.Show("Error al recoger datos del formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub actualizarButton_Click(sender As Object, e As EventArgs) Handles actualizarButton.Click
        Try
            ' Obtener el índice seleccionado en el ComboBox
            Dim indiceSeleccionado As Integer = contactoComboBox.SelectedIndex

            ' Verificar si hay elementos seleccionados en el ComboBox
            If indiceSeleccionado <> -1 Then
                ' Obtener el contacto seleccionado
                Dim contactoSeleccionado As Contacto = listaContactos(indiceSeleccionado)

                ' Recoger los nuevos datos del formulario
                Dim nuevoNombre As String = nombreContactoTextBox.Text
                Dim nuevoApellido As String = apellidoContactoTextBox.Text
                Dim nuevoTelefono As Integer = Convert.ToInt32(telefonoContactoTextBox.Text)
                Dim nuevoEmail As String = emailContactoTextBox.Text

                ' Llamar al método en el controlador para actualizar el contacto
                If controller.ActualizarContacto(contactoSeleccionado.id, nuevoNombre, nuevoApellido, nuevoTelefono, nuevoEmail) Then
                    ' Mostrar mensaje de éxito
                    MessageBox.Show("Contacto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    contactoComboBox.Text = ""

                    ' Actualizar la lista de contactos
                    listaContactos(indiceSeleccionado) = New Contacto(contactoSeleccionado.id, nuevoNombre, nuevoApellido, nuevoTelefono, nuevoEmail)

                    ' Actualizar la lista de nombres en el ComboBox
                    CargarNombresDeContactos()
                Else
                    ' Mostrar mensaje de error si la actualización en el controlador falla
                    MessageBox.Show("Error al actualizar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal
            MessageBox.Show("Error al actualizar el contacto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub eliminarButton_Click(sender As Object, e As EventArgs) Handles eliminarButton.Click
        Try
            ' Obtener el índice seleccionado en el ComboBox
            Dim indiceSeleccionado As Integer = contactoComboBox.SelectedIndex

            ' Verificar si hay elementos seleccionados en el ComboBox
            If indiceSeleccionado <> -1 Then
                ' Obtener el contacto seleccionado
                Dim contactoSeleccionado As Contacto = listaContactos(indiceSeleccionado)

                ' Llamar al método en el controlador para eliminar el contacto
                If controller.EliminarContacto(contactoSeleccionado.id) Then
                    ' Mostrar mensaje de éxito
                    MessageBox.Show("Contacto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Eliminar el contacto de la lista
                    listaContactos.RemoveAt(indiceSeleccionado)

                    ' Actualizar la lista de nombres en el ComboBox
                    CargarNombresDeContactos()

                    ' Limpiar los campos del formulario después de la eliminación
                    LimpiarCampos()
                Else
                    ' Mostrar mensaje de error si la eliminación en el controlador falla
                    MessageBox.Show("Error al eliminar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal
            MessageBox.Show("Error al eliminar el contacto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        nombreContactoTextBox.Text = ""
        apellidoContactoTextBox.Text = ""
        telefonoContactoTextBox.Text = ""
        emailContactoTextBox.Text = ""
        contactoComboBox.Text = ""
    End Sub
End Class
