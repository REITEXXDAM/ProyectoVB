Public Class AdminPanel
    Dim controller As New Controller()
    Dim command As New SQLiteCommand()

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
            Else
                ' Mostrar mensaje de error si la verificación en el controlador falla
                MessageBox.Show("Error al verificar o insertar el contacto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Mostrar mensaje de error si algo sale mal en la recopilación de datos
            MessageBox.Show("Error al recoger datos del formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        nombreContactoTextBox.Text = ""
        apellidoContactoTextBox.Text = ""
        telefonoContactoTextBox.Text = ""
        emailContactoTextBox.Text = ""
    End Sub

    Private Sub panelLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles panelLayoutPanel.Paint

    End Sub
End Class
