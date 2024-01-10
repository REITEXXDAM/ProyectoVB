<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.principalLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.agendaBox = New System.Windows.Forms.PictureBox()
        Me.agendaLabel = New System.Windows.Forms.Label()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.datosLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.passwordGroupBox = New System.Windows.Forms.GroupBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.nameGroupBox = New System.Windows.Forms.GroupBox()
        Me.userTextBox = New System.Windows.Forms.TextBox()
        Me.principalLayoutPanel.SuspendLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datosLayoutPanel.SuspendLayout()
        Me.passwordGroupBox.SuspendLayout()
        Me.nameGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'principalLayoutPanel
        '
        Me.principalLayoutPanel.ColumnCount = 2
        Me.principalLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.68821!))
        Me.principalLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.31179!))
        Me.principalLayoutPanel.Controls.Add(Me.agendaBox, 0, 1)
        Me.principalLayoutPanel.Controls.Add(Me.agendaLabel, 0, 0)
        Me.principalLayoutPanel.Controls.Add(Me.loginButton, 1, 3)
        Me.principalLayoutPanel.Controls.Add(Me.datosLayoutPanel, 1, 1)
        Me.principalLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.principalLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.principalLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.principalLayoutPanel.Name = "principalLayoutPanel"
        Me.principalLayoutPanel.RowCount = 5
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.principalLayoutPanel.Size = New System.Drawing.Size(1238, 627)
        Me.principalLayoutPanel.TabIndex = 0
        Me.principalLayoutPanel.Tag = ""
        '
        'agendaBox
        '
        Me.agendaBox.Image = Global.ProyectoVB.My.Resources.Resources.agenda
        Me.agendaBox.Location = New System.Drawing.Point(4, 129)
        Me.agendaBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.agendaBox.Name = "agendaBox"
        Me.principalLayoutPanel.SetRowSpan(Me.agendaBox, 2)
        Me.agendaBox.Size = New System.Drawing.Size(570, 242)
        Me.agendaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.agendaBox.TabIndex = 0
        Me.agendaBox.TabStop = False
        '
        'agendaLabel
        '
        Me.agendaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.agendaLabel.AutoSize = True
        Me.agendaLabel.Font = New System.Drawing.Font("Modern No. 20", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agendaLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.agendaLabel.Location = New System.Drawing.Point(129, 27)
        Me.agendaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.agendaLabel.Name = "agendaLabel"
        Me.agendaLabel.Size = New System.Drawing.Size(319, 71)
        Me.agendaLabel.TabIndex = 1
        Me.agendaLabel.Text = "AGENDA"
        '
        'loginButton
        '
        Me.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginButton.BackColor = System.Drawing.Color.BlueViolet
        Me.loginButton.Font = New System.Drawing.Font("Modern No. 20", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.SystemColors.Window
        Me.loginButton.Location = New System.Drawing.Point(770, 463)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.loginButton.Name = "loginButton"
        Me.principalLayoutPanel.SetRowSpan(Me.loginButton, 2)
        Me.loginButton.Size = New System.Drawing.Size(276, 75)
        Me.loginButton.TabIndex = 5
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'datosLayoutPanel
        '
        Me.datosLayoutPanel.AccessibleDescription = ""
        Me.datosLayoutPanel.ColumnCount = 1
        Me.datosLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.datosLayoutPanel.Controls.Add(Me.passwordGroupBox, 0, 1)
        Me.datosLayoutPanel.Controls.Add(Me.nameGroupBox, 0, 0)
        Me.datosLayoutPanel.Location = New System.Drawing.Point(584, 131)
        Me.datosLayoutPanel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.datosLayoutPanel.Name = "datosLayoutPanel"
        Me.datosLayoutPanel.RowCount = 2
        Me.principalLayoutPanel.SetRowSpan(Me.datosLayoutPanel, 2)
        Me.datosLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.datosLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.datosLayoutPanel.Size = New System.Drawing.Size(614, 238)
        Me.datosLayoutPanel.TabIndex = 8
        '
        'passwordGroupBox
        '
        Me.passwordGroupBox.Controls.Add(Me.passwordTextBox)
        Me.passwordGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.passwordGroupBox.Location = New System.Drawing.Point(4, 123)
        Me.passwordGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordGroupBox.Name = "passwordGroupBox"
        Me.passwordGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordGroupBox.Size = New System.Drawing.Size(600, 110)
        Me.passwordGroupBox.TabIndex = 10
        Me.passwordGroupBox.TabStop = False
        Me.passwordGroupBox.Text = "Password"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(96, 48)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(440, 47)
        Me.passwordTextBox.TabIndex = 0
        '
        'nameGroupBox
        '
        Me.nameGroupBox.Controls.Add(Me.userTextBox)
        Me.nameGroupBox.Font = New System.Drawing.Font("Modern No. 20", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.nameGroupBox.Location = New System.Drawing.Point(4, 4)
        Me.nameGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameGroupBox.Name = "nameGroupBox"
        Me.nameGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nameGroupBox.Size = New System.Drawing.Size(600, 111)
        Me.nameGroupBox.TabIndex = 7
        Me.nameGroupBox.TabStop = False
        Me.nameGroupBox.Text = "User"
        '
        'userTextBox
        '
        Me.userTextBox.Location = New System.Drawing.Point(96, 46)
        Me.userTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userTextBox.Name = "userTextBox"
        Me.userTextBox.Size = New System.Drawing.Size(440, 47)
        Me.userTextBox.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1238, 627)
        Me.Controls.Add(Me.principalLayoutPanel)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1244, 636)
        Me.Name = "Login"
        Me.Text = "ACCESO | AGENDA"
        Me.principalLayoutPanel.ResumeLayout(False)
        Me.principalLayoutPanel.PerformLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datosLayoutPanel.ResumeLayout(False)
        Me.passwordGroupBox.ResumeLayout(False)
        Me.passwordGroupBox.PerformLayout()
        Me.nameGroupBox.ResumeLayout(False)
        Me.nameGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents principalLayoutPanel As TableLayoutPanel
    Friend WithEvents agendaBox As PictureBox
    Friend WithEvents agendaLabel As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents datosLayoutPanel As TableLayoutPanel
    Friend WithEvents passwordGroupBox As GroupBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents nameGroupBox As GroupBox
    Friend WithEvents userTextBox As TextBox
End Class
