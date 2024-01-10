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
        Me.insertarButton = New System.Windows.Forms.Button()
        Me.eliminarButton = New System.Windows.Forms.Button()
        Me.actualizarButton = New System.Windows.Forms.Button()
        Me.contactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.contactoComboBox = New System.Windows.Forms.ComboBox()
        Me.agendaBox = New System.Windows.Forms.PictureBox()
        Me.nombreContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.apellidoContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.telefonoContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.emailContactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.agendaLabel = New System.Windows.Forms.Label()
        Me.panelLayoutPanel.SuspendLayout()
        Me.contactoGroupBox.SuspendLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nombreContactoGroupBox.SuspendLayout()
        Me.apellidoContactoGroupBox.SuspendLayout()
        Me.telefonoContactoGroupBox.SuspendLayout()
        Me.emailContactoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLayoutPanel
        '
        Me.panelLayoutPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.panelLayoutPanel.ColumnCount = 2
        Me.panelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84426!))
        Me.panelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15574!))
        Me.panelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.panelLayoutPanel.Name = "panelLayoutPanel"
        Me.panelLayoutPanel.RowCount = 5
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panelLayoutPanel.Size = New System.Drawing.Size(1952, 1012)
        Me.panelLayoutPanel.TabIndex = 0
        '
        'insertarButton
        '
        Me.insertarButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insertarButton.Location = New System.Drawing.Point(1604, 438)
        Me.insertarButton.Name = "insertarButton"
        Me.insertarButton.Size = New System.Drawing.Size(243, 134)
        Me.insertarButton.TabIndex = 3
        Me.insertarButton.Text = "Insertar"
        Me.insertarButton.UseVisualStyleBackColor = True
        '
        'eliminarButton
        '
        Me.eliminarButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.eliminarButton.Location = New System.Drawing.Point(1602, 843)
        Me.eliminarButton.Name = "eliminarButton"
        Me.eliminarButton.Size = New System.Drawing.Size(247, 134)
        Me.eliminarButton.TabIndex = 4
        Me.eliminarButton.Text = "Eliminar"
        Me.eliminarButton.UseVisualStyleBackColor = True
        '
        'actualizarButton
        '
        Me.actualizarButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.actualizarButton.Location = New System.Drawing.Point(1604, 640)
        Me.actualizarButton.Name = "actualizarButton"
        Me.actualizarButton.Size = New System.Drawing.Size(243, 134)
        Me.actualizarButton.TabIndex = 5
        Me.actualizarButton.Text = "Actualizar"
        Me.actualizarButton.UseVisualStyleBackColor = True
        '
        'contactoGroupBox
        '
        Me.contactoGroupBox.Controls.Add(Me.contactoComboBox)
        Me.contactoGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.contactoGroupBox.Location = New System.Drawing.Point(1504, 206)
        Me.contactoGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.contactoGroupBox.Name = "contactoGroupBox"
        Me.contactoGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.contactoGroupBox.Size = New System.Drawing.Size(437, 194)
        Me.contactoGroupBox.TabIndex = 9
        Me.contactoGroupBox.TabStop = False
        Me.contactoGroupBox.Text = "Contacto"
        '
        'contactoComboBox
        '
        Me.contactoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contactoComboBox.FormattingEnabled = True
        Me.contactoComboBox.Location = New System.Drawing.Point(46, 105)
        Me.contactoComboBox.Name = "contactoComboBox"
        Me.contactoComboBox.Size = New System.Drawing.Size(373, 46)
        Me.contactoComboBox.TabIndex = 0
        '
        'agendaBox
        '
        Me.agendaBox.Image = Global.ProyectoVB.My.Resources.Resources.agenda
        Me.agendaBox.Location = New System.Drawing.Point(1504, 4)
        Me.agendaBox.Margin = New System.Windows.Forms.Padding(4)
        Me.agendaBox.Name = "agendaBox"
        Me.agendaBox.Size = New System.Drawing.Size(444, 194)
        Me.agendaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.agendaBox.TabIndex = 11
        Me.agendaBox.TabStop = False
        '
        'nombreContactoGroupBox
        '
        Me.nombreContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nombreContactoGroupBox.Controls.Add(Me.TextBox1)
        Me.nombreContactoGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.nombreContactoGroupBox.Location = New System.Drawing.Point(450, 246)
        Me.nombreContactoGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nombreContactoGroupBox.Name = "nombreContactoGroupBox"
        Me.nombreContactoGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.nombreContactoGroupBox.Size = New System.Drawing.Size(600, 114)
        Me.nombreContactoGroupBox.TabIndex = 12
        Me.nombreContactoGroupBox.TabStop = False
        Me.nombreContactoGroupBox.Text = "NOMBRE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 46)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(440, 47)
        Me.TextBox1.TabIndex = 1
        '
        'apellidoContactoGroupBox
        '
        Me.apellidoContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.apellidoContactoGroupBox.Controls.Add(Me.TextBox2)
        Me.apellidoContactoGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.apellidoContactoGroupBox.Location = New System.Drawing.Point(450, 448)
        Me.apellidoContactoGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.apellidoContactoGroupBox.Name = "apellidoContactoGroupBox"
        Me.apellidoContactoGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.apellidoContactoGroupBox.Size = New System.Drawing.Size(600, 114)
        Me.apellidoContactoGroupBox.TabIndex = 13
        Me.apellidoContactoGroupBox.TabStop = False
        Me.apellidoContactoGroupBox.Text = "APELLIDO"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(96, 46)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(440, 47)
        Me.TextBox2.TabIndex = 1
        '
        'telefonoContactoGroupBox
        '
        Me.telefonoContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.telefonoContactoGroupBox.Controls.Add(Me.TextBox3)
        Me.telefonoContactoGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.telefonoContactoGroupBox.Location = New System.Drawing.Point(450, 650)
        Me.telefonoContactoGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.telefonoContactoGroupBox.Name = "telefonoContactoGroupBox"
        Me.telefonoContactoGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.telefonoContactoGroupBox.Size = New System.Drawing.Size(600, 114)
        Me.telefonoContactoGroupBox.TabIndex = 15
        Me.telefonoContactoGroupBox.TabStop = False
        Me.telefonoContactoGroupBox.Text = "TELEFONO CONTACTO"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(96, 46)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(440, 47)
        Me.TextBox3.TabIndex = 1
        '
        'emailContactoGroupBox
        '
        Me.emailContactoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emailContactoGroupBox.Controls.Add(Me.TextBox4)
        Me.emailContactoGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailContactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.emailContactoGroupBox.Location = New System.Drawing.Point(450, 853)
        Me.emailContactoGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.emailContactoGroupBox.Name = "emailContactoGroupBox"
        Me.emailContactoGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.emailContactoGroupBox.Size = New System.Drawing.Size(600, 114)
        Me.emailContactoGroupBox.TabIndex = 16
        Me.emailContactoGroupBox.TabStop = False
        Me.emailContactoGroupBox.Text = "EMAIL"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(96, 46)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(440, 47)
        Me.TextBox4.TabIndex = 1
        '
        'agendaLabel
        '
        Me.agendaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.agendaLabel.AutoSize = True
        Me.agendaLabel.Font = New System.Drawing.Font("Modern No. 20", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agendaLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.agendaLabel.Location = New System.Drawing.Point(300, 65)
        Me.agendaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.agendaLabel.Name = "agendaLabel"
        Me.agendaLabel.Size = New System.Drawing.Size(899, 71)
        Me.agendaLabel.TabIndex = 17
        Me.agendaLabel.Text = "AGENDA | MASTER PANEL"
        '
        'AdminPanel
        '
        Me.AccessibleDescription = "adminPanel"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1952, 1012)
        Me.Controls.Add(Me.panelLayoutPanel)
        Me.Name = "AdminPanel"
        Me.Text = "ADMINISTRACION DE CONTACTOS"
        Me.panelLayoutPanel.ResumeLayout(False)
        Me.panelLayoutPanel.PerformLayout()
        Me.contactoGroupBox.ResumeLayout(False)
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nombreContactoGroupBox.ResumeLayout(False)
        Me.nombreContactoGroupBox.PerformLayout()
        Me.apellidoContactoGroupBox.ResumeLayout(False)
        Me.apellidoContactoGroupBox.PerformLayout()
        Me.telefonoContactoGroupBox.ResumeLayout(False)
        Me.telefonoContactoGroupBox.PerformLayout()
        Me.emailContactoGroupBox.ResumeLayout(False)
        Me.emailContactoGroupBox.PerformLayout()
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents nombreContactoGroupBox As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents emailContactoGroupBox As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents telefonoContactoGroupBox As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents agendaLabel As Label
End Class
