<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.fichaEmpleadoLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.apellidoTextBox = New System.Windows.Forms.TextBox()
        Me.nombreLabel = New System.Windows.Forms.Label()
        Me.apellidoLabel = New System.Windows.Forms.Label()
        Me.telefonoLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.tituloLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.emailButton = New System.Windows.Forms.Button()
        Me.llamarButton = New System.Windows.Forms.Button()
        Me.fichaEmpleadoLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fichaEmpleadoLayoutPanel
        '
        Me.fichaEmpleadoLayoutPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.fichaEmpleadoLayoutPanel.ColumnCount = 3
        Me.fichaEmpleadoLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.fichaEmpleadoLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fichaEmpleadoLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.emailTextBox, 1, 4)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.telefonoTextBox, 1, 3)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.apellidoTextBox, 1, 2)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.nombreLabel, 0, 1)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.apellidoLabel, 0, 2)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.telefonoLabel, 0, 3)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.emailLabel, 0, 4)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.nombreTextBox, 1, 1)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.tituloLabel, 1, 0)
        Me.fichaEmpleadoLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 1, 5)
        Me.fichaEmpleadoLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fichaEmpleadoLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.fichaEmpleadoLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.fichaEmpleadoLayoutPanel.MinimumSize = New System.Drawing.Size(532, 403)
        Me.fichaEmpleadoLayoutPanel.Name = "fichaEmpleadoLayoutPanel"
        Me.fichaEmpleadoLayoutPanel.Padding = New System.Windows.Forms.Padding(12, 13, 12, 13)
        Me.fichaEmpleadoLayoutPanel.RowCount = 6
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.fichaEmpleadoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.fichaEmpleadoLayoutPanel.Size = New System.Drawing.Size(532, 403)
        Me.fichaEmpleadoLayoutPanel.TabIndex = 1
        '
        'emailTextBox
        '
        Me.emailTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailTextBox.Location = New System.Drawing.Point(166, 282)
        Me.emailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(250, 20)
        Me.emailTextBox.TabIndex = 14
        '
        'telefonoTextBox
        '
        Me.telefonoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.telefonoTextBox.Location = New System.Drawing.Point(166, 220)
        Me.telefonoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.telefonoTextBox.Name = "telefonoTextBox"
        Me.telefonoTextBox.Size = New System.Drawing.Size(250, 20)
        Me.telefonoTextBox.TabIndex = 13
        '
        'apellidoTextBox
        '
        Me.apellidoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.apellidoTextBox.Location = New System.Drawing.Point(166, 158)
        Me.apellidoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.apellidoTextBox.Name = "apellidoTextBox"
        Me.apellidoTextBox.Size = New System.Drawing.Size(250, 20)
        Me.apellidoTextBox.TabIndex = 12
        '
        'nombreLabel
        '
        Me.nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nombreLabel.AutoSize = True
        Me.nombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.nombreLabel.Location = New System.Drawing.Point(79, 96)
        Me.nombreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nombreLabel.Name = "nombreLabel"
        Me.nombreLabel.Size = New System.Drawing.Size(83, 20)
        Me.nombreLabel.TabIndex = 0
        Me.nombreLabel.Text = "NOMBRE:"
        '
        'apellidoLabel
        '
        Me.apellidoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.apellidoLabel.AutoSize = True
        Me.apellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoLabel.Location = New System.Drawing.Point(66, 158)
        Me.apellidoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.apellidoLabel.Name = "apellidoLabel"
        Me.apellidoLabel.Size = New System.Drawing.Size(96, 20)
        Me.apellidoLabel.TabIndex = 1
        Me.apellidoLabel.Text = "APELLIDO: "
        '
        'telefonoLabel
        '
        Me.telefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.telefonoLabel.AutoSize = True
        Me.telefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.telefonoLabel.Location = New System.Drawing.Point(64, 220)
        Me.telefonoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.telefonoLabel.Name = "telefonoLabel"
        Me.telefonoLabel.Size = New System.Drawing.Size(98, 20)
        Me.telefonoLabel.TabIndex = 2
        Me.telefonoLabel.Text = "TELEFONO:"
        '
        'emailLabel
        '
        Me.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.emailLabel.Location = New System.Drawing.Point(100, 282)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(62, 20)
        Me.emailLabel.TabIndex = 3
        Me.emailLabel.Text = "EMAIL:"
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nombreTextBox.Location = New System.Drawing.Point(166, 96)
        Me.nombreTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(250, 20)
        Me.nombreTextBox.TabIndex = 10
        '
        'tituloLabel
        '
        Me.tituloLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tituloLabel.AutoSize = True
        Me.tituloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloLabel.Location = New System.Drawing.Point(166, 29)
        Me.tituloLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tituloLabel.MinimumSize = New System.Drawing.Size(232, 22)
        Me.tituloLabel.Name = "tituloLabel"
        Me.tituloLabel.Size = New System.Drawing.Size(250, 29)
        Me.tituloLabel.TabIndex = 5
        Me.tituloLabel.Text = "FICHA CONTACTO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.emailButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.llamarButton, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(167, 326)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(248, 61)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'emailButton
        '
        Me.emailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailButton.BackColor = System.Drawing.Color.MediumPurple
        Me.emailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailButton.Location = New System.Drawing.Point(127, 19)
        Me.emailButton.Name = "emailButton"
        Me.emailButton.Size = New System.Drawing.Size(118, 23)
        Me.emailButton.TabIndex = 1
        Me.emailButton.Text = "Email"
        Me.emailButton.UseVisualStyleBackColor = False
        '
        'llamarButton
        '
        Me.llamarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llamarButton.BackColor = System.Drawing.Color.LimeGreen
        Me.llamarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llamarButton.Location = New System.Drawing.Point(3, 19)
        Me.llamarButton.Name = "llamarButton"
        Me.llamarButton.Size = New System.Drawing.Size(118, 23)
        Me.llamarButton.TabIndex = 0
        Me.llamarButton.Text = "Llamar"
        Me.llamarButton.UseVisualStyleBackColor = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.fichaEmpleadoLayoutPanel)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(532, 403)
        Me.fichaEmpleadoLayoutPanel.ResumeLayout(False)
        Me.fichaEmpleadoLayoutPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fichaEmpleadoLayoutPanel As TableLayoutPanel
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents telefonoTextBox As TextBox
    Friend WithEvents apellidoTextBox As TextBox
    Friend WithEvents nombreLabel As Label
    Friend WithEvents apellidoLabel As Label
    Friend WithEvents telefonoLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents tituloLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents emailButton As Button
    Friend WithEvents llamarButton As Button
End Class
