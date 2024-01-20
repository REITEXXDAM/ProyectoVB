Public Class AdminPanel
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()
    Public listaContactos As New List(Of Contacto)
    Public listaNombres As New List(Of String)

    ' Variable para almacenar el tamaño anterior del formulario
    Private tamañoAnterior As Size

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializamos el tamaño anterior
        tamañoAnterior = Me.Size

        ' Llamamos a la función para ajustar el tamaño
        AjustarTamaño()

        ' Llamar al método en el controlador para consultar los contactos
        controller.ConsultarContactos(listaContactos)

        ' Limpiar ComboBox antes de cargar los nuevos datos
        contactoComboBox.Items.Clear()

        ' Limpiar la lista de nombres
        listaNombres.Clear()

        ' Agregar objetos de Contacto al ComboBox y a la lista de nombres
        For Each contacto As Contacto In listaContactos
            If Not listaNombres.Contains(contacto.nombre) Then
                listaNombres.Add(contacto.nombre)
                contactoComboBox.Items.Add(contacto.nombre)
            End If
        Next
    End Sub

    Private Sub contactoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles contactoComboBox.SelectedIndexChanged
        ' Verificar si hay elementos seleccionados en el ComboBox
        If contactoComboBox.SelectedIndex <> -1 Then
            ' Obtener el contacto seleccionado
            Dim contactoSeleccionado As Contacto = listaContactos(contactoComboBox.SelectedIndex)

            ' Limpiar los campos antes de cargar nuevos datos
            LimpiarCampos()

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

            ' Limpiar ComboBox antes de cargar los nuevos datos
            contactoComboBox.Items.Clear()

            ' Limpiar la lista de nombres
            listaNombres.Clear()

            ' Agregar objetos de Contacto al ComboBox y a la lista de nombres
            For Each contacto As Contacto In listaContactos
                If Not listaNombres.Contains(contacto.nombre) Then
                    listaNombres.Add(contacto.nombre)
                    contactoComboBox.Items.Add(contacto.nombre)
                End If
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

                    ' Actualizar la lista de contactos
                    listaContactos(indiceSeleccionado) = New Contacto(contactoSeleccionado.id, nuevoNombre, nuevoApellido, nuevoTelefono, nuevoEmail)

                    ' Limpiar los campos del formulario después de la actualización
                    LimpiarCampos()

                    ' Actualizar la lista de nombres en el ComboBox
                    CargarNombresDeContactos()

                    ' Establecer la selección del ComboBox en -1
                    contactoComboBox.SelectedIndex = -1
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

                    ' Quitar el nombre del ComboBox
                    contactoComboBox.Items.RemoveAt(indiceSeleccionado)

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

    Private Sub telefonoContactoTextBox_TextChanged(sender As Object, e As EventArgs) Handles telefonoContactoTextBox.TextChanged

    End Sub

    Private Sub panelLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles panelLayoutPanel.Paint

    End Sub

    Private Sub AdminPanel_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' Llamamos a la función para ajustar el tamaño
        AjustarTamaño()
        ' Actualizamos el tamaño anterior después de haber ajustado el tamaño
        tamañoAnterior = Me.Size
    End Sub

    Private Sub AjustarTamaño()
        ' Tamaños de fuente específicos
        Dim tamFuenteAgenda As Double = 25 * Me.Height / 565
        tamFuenteAgenda = If(tamFuenteAgenda < 25, 25, tamFuenteAgenda)

        Dim tamFuenteGeneral As Double = 13 * Me.Height / 565
        tamFuenteGeneral = If(tamFuenteGeneral < 13, 13, tamFuenteGeneral)

        ' Aplicar tamaños de fuente
        agendaLabel.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteAgenda), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        ' Aplicar tamaños de fuente a todos los elementos del formulario
        For Each control As Control In Controls
            If TypeOf control Is GroupBox Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteGeneral), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                For Each innerControl As Control In control.Controls
                    innerControl.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteGeneral), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                Next
            ElseIf TypeOf control Is TextBox OrElse TypeOf control Is Button Then
                control.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteGeneral), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            End If
        Next

        ' Ajustar tamaño de TextBox
        For Each control As Control In panelLayoutPanel.Controls
            If TypeOf control Is TextBox Then
                Dim nuevoAncho As Integer = CInt(control.Width * (Me.Width / tamañoAnterior.Width))
                Dim nuevoAlto As Integer = CInt(control.Height * (Me.Height / tamañoAnterior.Height))

                control.Width = If(nuevoAncho < 0, 0, nuevoAncho)
                control.Height = If(nuevoAlto < 0, 0, nuevoAlto)
            End If
        Next
    End Sub
End Class


