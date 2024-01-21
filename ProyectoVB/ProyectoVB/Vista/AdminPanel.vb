Public Class AdminPanel
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()
    Public listaContactos As New List(Of Contacto)
    Public listaNombres As New List(Of String)

    Private tamañoAnterior As Size

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tamañoAnterior = Me.Size
        AjustarTamaño()
        controller.ConsultarContactos(listaContactos)
        contactoComboBox.Items.Clear()
        listaNombres.Clear()
        For Each contacto As Contacto In listaContactos
            If Not listaNombres.Contains(contacto.nombre) Then
                listaNombres.Add(contacto.nombre)
                contactoComboBox.Items.Add(contacto.nombre)
            End If
        Next
    End Sub

    Private Sub contactoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles contactoComboBox.SelectedIndexChanged
        If contactoComboBox.SelectedIndex <> -1 Then
            Dim contactoSeleccionado As Contacto = listaContactos(contactoComboBox.SelectedIndex)
            LimpiarCampos()
            nombreContactoTextBox.Text = contactoSeleccionado.nombre
            apellidoContactoTextBox.Text = contactoSeleccionado.apellido
            telefonoContactoTextBox.Text = contactoSeleccionado.telefono.ToString()
            emailContactoTextBox.Text = contactoSeleccionado.email
        End If
    End Sub

    Private Sub CargarNombresDeContactos()
        Try
            controller.ConsultarContactos(listaContactos)
            contactoComboBox.Items.Clear()
            listaNombres.Clear()
            For Each contacto As Contacto In listaContactos
                If Not listaNombres.Contains(contacto.nombre) Then
                    listaNombres.Add(contacto.nombre)
                    contactoComboBox.Items.Add(contacto.nombre)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar los nombres de los contactos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub insertarButton_Click(sender As Object, e As EventArgs) Handles insertarButton.Click
        Try
            Dim nombre As String = nombreContactoTextBox.Text
            Dim apellido As String = apellidoContactoTextBox.Text
            Dim telefono As Integer = Convert.ToInt32(telefonoContactoTextBox.Text)
            Dim email As String = emailContactoTextBox.Text

            If controller.InsertarContacto(nombre, apellido, telefono, email) Then
                MessageBox.Show("Contacto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
                CargarNombresDeContactos()
            Else
                MessageBox.Show("Error al verificar o insertar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al recoger datos del formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub actualizarButton_Click(sender As Object, e As EventArgs) Handles actualizarButton.Click
        Try
            Dim indiceSeleccionado As Integer = contactoComboBox.SelectedIndex
            If indiceSeleccionado <> -1 Then
                Dim contactoSeleccionado As Contacto = listaContactos(indiceSeleccionado)
                Dim nuevoNombre As String = nombreContactoTextBox.Text
                Dim nuevoApellido As String = apellidoContactoTextBox.Text
                Dim nuevoTelefono As Integer = Convert.ToInt32(telefonoContactoTextBox.Text)
                Dim nuevoEmail As String = emailContactoTextBox.Text

                If controller.ActualizarContacto(contactoSeleccionado.id, nuevoNombre, nuevoApellido, nuevoTelefono, nuevoEmail) Then
                    MessageBox.Show("Contacto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    listaContactos(indiceSeleccionado) = New Contacto(contactoSeleccionado.id, nuevoNombre, nuevoApellido, nuevoTelefono, nuevoEmail)
                    LimpiarCampos()
                    CargarNombresDeContactos()
                    contactoComboBox.SelectedIndex = -1
                Else
                    MessageBox.Show("Error al actualizar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el contacto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub eliminarButton_Click(sender As Object, e As EventArgs) Handles eliminarButton.Click
        Try
            Dim indiceSeleccionado As Integer = contactoComboBox.SelectedIndex
            If indiceSeleccionado <> -1 Then
                Dim contactoSeleccionado As Contacto = listaContactos(indiceSeleccionado)
                If controller.EliminarContacto(contactoSeleccionado.id) Then
                    MessageBox.Show("Contacto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    listaContactos.RemoveAt(indiceSeleccionado)
                    contactoComboBox.Items.RemoveAt(indiceSeleccionado)
                    LimpiarCampos()
                Else
                    MessageBox.Show("Error al eliminar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
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
        AjustarTamaño()
        tamañoAnterior = Me.Size
    End Sub

    Private Sub AjustarTamaño()
        Dim tamFuenteAgenda As Double = 25 * Me.Height / 565
        tamFuenteAgenda = If(tamFuenteAgenda < 25, 25, tamFuenteAgenda)

        Dim tamFuenteGeneral As Double = 13 * Me.Height / 565
        tamFuenteGeneral = If(tamFuenteGeneral < 13, 13, tamFuenteGeneral)

        agendaLabel.Font = New Font("Microsoft Sans Serif", CSng(tamFuenteAgenda), FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

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



