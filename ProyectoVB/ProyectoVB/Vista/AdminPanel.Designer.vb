<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.agendaLabel = New System.Windows.Forms.Label()
        Me.emailContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.emailContactoTextBox = New System.Windows.Forms.TextBox()
        Me.telefonoContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.telefonoContactoTextBox = New System.Windows.Forms.TextBox()
        Me.apellidoContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.apellidoContactoTextBox = New System.Windows.Forms.TextBox()
        Me.nombreContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.nombreContactoTextBox = New System.Windows.Forms.TextBox()
        Me.agendaBox = New System.Windows.Forms.PictureBox()
        Me.eliminarButton = New System.Windows.Forms.Button()
        Me.actualizarButton = New System.Windows.Forms.Button()
        Me.insertarButton = New System.Windows.Forms.Button()
        Me.contactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.contactoComboBox = New System.Windows.Forms.ComboBox()
        Me.panelLayoutPanel.SuspendLayout()
        Me.emailContactoGroupBox.SuspendLayout()
        Me.telefonoContactoGroupBox.SuspendLayout()
        Me.apellidoContactoGroupBox.SuspendLayout()
        Me.nombreContactoGroupBox.SuspendLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contactoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLayoutPanel
        '
        Me.panelLayoutPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.panelLayoutPanel.ColumnCount = 2
        Me.panelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84426!))
        Me.panelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15574!))
        Me.panelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.panelLayoutPanel.Controls.Add(Me.agendaLabel, 0, 0)
        Me.panelLayoutPanel.Controls.Add(Me.emailContactoGroupBox, 0, 4)
        Me.panelLayoutPanel.Controls.Add(Me.telefonoContactoGroupBox, 0, 3)
        Me.panelLayoutPanel.Controls.Add(Me.apellidoContactoGroupBox, 0, 2)
        Me.panelLayoutPanel.Controls.Add(Me.nombreContactoGroupBox, 0, 1)
        Me.panelLayoutPanel.Controls.Add(Me.agendaBox, 1, 0)
        Me.panelLayoutPanel.Controls.Add(Me.eliminarButton, 1, 4)
        Me.panelLayoutPanel.Controls.Add(Me.actualizarButton, 1, 3)
        Me.panelLayoutPanel.Controls.Add(Me.insertarButton, 1, 2)
        Me.panelLayoutPanel.Controls.Add(Me.contactoGroupBox, 1, 1)
        Me.panelLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.panelLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.panelLayoutPanel.Name = "panelLayoutPanel"
        Me.panelLayoutPanel.RowCount = 5
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.Size = New System.Drawing.Size(976, 526)
        Me.panelLayoutPanel.TabIndex = 0
        '
        'agendaLabel
        '
        Me.agendaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.agendaLabel.AutoSize = True
        Me.agendaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agendaLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.agendaLabel.Location = New System.Drawing.Point(147, 33)
        Me.agendaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.agendaLabel.Name = "agendaLabel"
        Me.agendaLabel.Size = New System.Drawing.Size(456, 39)
        Me.agendaLabel.TabIndex = 17
        Me.agendaLabel.Text = "AGENDA | MASTER PANEL"
        '
        'emailContactoGroupBox
        '
        Me.emailContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailContactoGroupBox.Controls.Add(Me.emailContactoTextBox)
        Me.emailContactoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.emailContactoGroupBox.Location = New System.Drawing.Point(225, 443)
        Me.emailContactoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.emailContactoGroupBox.Name = "emailContactoGroupBox"
        Me.emailContactoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.emailContactoGroupBox.Size = New System.Drawing.Size(300, 59)
        Me.emailContactoGroupBox.TabIndex = 16
        Me.emailContactoGroupBox.TabStop = False
        Me.emailContactoGroupBox.Text = "EMAIL"
        '
        'emailContactoTextBox
        '
        Me.emailContactoTextBox.Location = New System.Drawing.Point(48, 24)
        Me.emailContactoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.emailContactoTextBox.Name = "emailContactoTextBox"
        Me.emailContactoTextBox.Size = New System.Drawing.Size(222, 28)
        Me.emailContactoTextBox.TabIndex = 1
        '
        'telefonoContactoGroupBox
        '
        Me.telefonoContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.telefonoContactoGroupBox.Controls.Add(Me.telefonoContactoTextBox)
        Me.telefonoContactoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.telefonoContactoGroupBox.Location = New System.Drawing.Point(225, 338)
        Me.telefonoContactoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.telefonoContactoGroupBox.Name = "telefonoContactoGroupBox"
        Me.telefonoContactoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.telefonoContactoGroupBox.Size = New System.Drawing.Size(300, 59)
        Me.telefonoContactoGroupBox.TabIndex = 15
        Me.telefonoContactoGroupBox.TabStop = False
        Me.telefonoContactoGroupBox.Text = "TELEFONO CONTACTO"
        '
        'telefonoContactoTextBox
        '
        Me.telefonoContactoTextBox.Location = New System.Drawing.Point(48, 24)
        Me.telefonoContactoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.telefonoContactoTextBox.Name = "telefonoContactoTextBox"
        Me.telefonoContactoTextBox.Size = New System.Drawing.Size(222, 28)
        Me.telefonoContactoTextBox.TabIndex = 1
        '
        'apellidoContactoGroupBox
        '
        Me.apellidoContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.apellidoContactoGroupBox.Controls.Add(Me.apellidoContactoTextBox)
        Me.apellidoContactoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.apellidoContactoGroupBox.Location = New System.Drawing.Point(225, 233)
        Me.apellidoContactoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.apellidoContactoGroupBox.Name = "apellidoContactoGroupBox"
        Me.apellidoContactoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.apellidoContactoGroupBox.Size = New System.Drawing.Size(300, 59)
        Me.apellidoContactoGroupBox.TabIndex = 13
        Me.apellidoContactoGroupBox.TabStop = False
        Me.apellidoContactoGroupBox.Text = "APELLIDO"
        '
        'apellidoContactoTextBox
        '
        Me.apellidoContactoTextBox.Location = New System.Drawing.Point(48, 24)
        Me.apellidoContactoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.apellidoContactoTextBox.Name = "apellidoContactoTextBox"
        Me.apellidoContactoTextBox.Size = New System.Drawing.Size(222, 28)
        Me.apellidoContactoTextBox.TabIndex = 1
        '
        'nombreContactoGroupBox
        '
        Me.nombreContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nombreContactoGroupBox.Controls.Add(Me.nombreContactoTextBox)
        Me.nombreContactoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.nombreContactoGroupBox.Location = New System.Drawing.Point(225, 128)
        Me.nombreContactoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nombreContactoGroupBox.Name = "nombreContactoGroupBox"
        Me.nombreContactoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.nombreContactoGroupBox.Size = New System.Drawing.Size(300, 59)
        Me.nombreContactoGroupBox.TabIndex = 12
        Me.nombreContactoGroupBox.TabStop = False
        Me.nombreContactoGroupBox.Text = "NOMBRE"
        '
        'nombreContactoTextBox
        '
        Me.nombreContactoTextBox.Location = New System.Drawing.Point(48, 24)
        Me.nombreContactoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nombreContactoTextBox.Name = "nombreContactoTextBox"
        Me.nombreContactoTextBox.Size = New System.Drawing.Size(222, 28)
        Me.nombreContactoTextBox.TabIndex = 1
        '
        'agendaBox
        '
        Me.agendaBox.Image = Global.ProyectoVB.My.Resources.Resources.agenda
        Me.agendaBox.Location = New System.Drawing.Point(752, 2)
        Me.agendaBox.Margin = New System.Windows.Forms.Padding(2)
        Me.agendaBox.Name = "agendaBox"
        Me.agendaBox.Size = New System.Drawing.Size(222, 101)
        Me.agendaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.agendaBox.TabIndex = 11
        Me.agendaBox.TabStop = False
        '
        'eliminarButton
        '
        Me.eliminarButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.eliminarButton.Location = New System.Drawing.Point(801, 438)
        Me.eliminarButton.Margin = New System.Windows.Forms.Padding(2)
        Me.eliminarButton.Name = "eliminarButton"
        Me.eliminarButton.Size = New System.Drawing.Size(124, 70)
        Me.eliminarButton.TabIndex = 4
        Me.eliminarButton.Text = "Eliminar"
        Me.eliminarButton.UseVisualStyleBackColor = True
        '
        'actualizarButton
        '
        Me.actualizarButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.actualizarButton.Location = New System.Drawing.Point(802, 332)
        Me.actualizarButton.Margin = New System.Windows.Forms.Padding(2)
        Me.actualizarButton.Name = "actualizarButton"
        Me.actualizarButton.Size = New System.Drawing.Size(122, 70)
        Me.actualizarButton.TabIndex = 5
        Me.actualizarButton.Text = "Actualizar"
        Me.actualizarButton.UseVisualStyleBackColor = True
        '
        'insertarButton
        '
        Me.insertarButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insertarButton.Location = New System.Drawing.Point(802, 227)
        Me.insertarButton.Margin = New System.Windows.Forms.Padding(2)
        Me.insertarButton.Name = "insertarButton"
        Me.insertarButton.Size = New System.Drawing.Size(122, 70)
        Me.insertarButton.TabIndex = 3
        Me.insertarButton.Text = "Insertar"
        Me.insertarButton.UseVisualStyleBackColor = True
        '
        'contactoGroupBox
        '
        Me.contactoGroupBox.Controls.Add(Me.contactoComboBox)
        Me.contactoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.contactoGroupBox.Location = New System.Drawing.Point(752, 107)
        Me.contactoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.contactoGroupBox.Name = "contactoGroupBox"
        Me.contactoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.contactoGroupBox.Size = New System.Drawing.Size(218, 101)
        Me.contactoGroupBox.TabIndex = 9
        Me.contactoGroupBox.TabStop = False
        Me.contactoGroupBox.Text = "Contacto"
        '
        'contactoComboBox
        '
        Me.contactoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contactoComboBox.FormattingEnabled = True
        Me.contactoComboBox.Location = New System.Drawing.Point(23, 55)
        Me.contactoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.contactoComboBox.Name = "contactoComboBox"
        Me.contactoComboBox.Size = New System.Drawing.Size(188, 30)
        Me.contactoComboBox.TabIndex = 0
        '
        'AdminPanel
        '
        Me.AccessibleDescription = "adminPanel"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 526)
        Me.Controls.Add(Me.panelLayoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(992, 565)
        Me.Name = "AdminPanel"
        Me.Text = "ADMINISTRACION DE CONTACTOS"
        Me.panelLayoutPanel.ResumeLayout(False)
        Me.panelLayoutPanel.PerformLayout()
        Me.emailContactoGroupBox.ResumeLayout(False)
        Me.emailContactoGroupBox.PerformLayout()
        Me.telefonoContactoGroupBox.ResumeLayout(False)
        Me.telefonoContactoGroupBox.PerformLayout()
        Me.apellidoContactoGroupBox.ResumeLayout(False)
        Me.apellidoContactoGroupBox.PerformLayout()
        Me.nombreContactoGroupBox.ResumeLayout(False)
        Me.nombreContactoGroupBox.PerformLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contactoGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLayoutPanel As TableLayoutPanel
    Friend WithEvents insertarButton As Button
    Friend WithEvents eliminarButton As Button
    Friend WithEvents actualizarButton As Button
    Friend WithEvents contactoGroupBox As GroupBox
    Friend WithEvents contactoComboBox As ComboBox
    Friend WithEvents agendaBox As PictureBox
    Friend WithEvents apellidoContactoGroupBox As GroupBox
    Friend WithEvents apellidoContactoTextBox As TextBox
    Friend WithEvents nombreContactoGroupBox As GroupBox
    Friend WithEvents nombreContactoTextBox As TextBox
    Friend WithEvents emailContactoGroupBox As GroupBox
    Friend WithEvents emailContactoTextBox As TextBox
    Friend WithEvents telefonoContactoGroupBox As GroupBox
    Friend WithEvents telefonoContactoTextBox As TextBox
    Friend WithEvents agendaLabel As Label
End Class
