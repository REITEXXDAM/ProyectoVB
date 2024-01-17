<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPanel
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
        Me.panelLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.agendaLabel = New System.Windows.Forms.Label()
        Me.agendaBox = New System.Windows.Forms.PictureBox()
        Me.contactoGroupBox = New System.Windows.Forms.GroupBox()
        Me.contactoComboBox = New System.Windows.Forms.ComboBox()
        Me.controlUserButton = New System.Windows.Forms.Button()
        Me.panelLayoutPanel.SuspendLayout()
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
        Me.panelLayoutPanel.Controls.Add(Me.agendaLabel, 0, 0)
        Me.panelLayoutPanel.Controls.Add(Me.agendaBox, 1, 0)
        Me.panelLayoutPanel.Controls.Add(Me.contactoGroupBox, 0, 1)
        Me.panelLayoutPanel.Controls.Add(Me.controlUserButton, 1, 1)
        Me.panelLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.panelLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.panelLayoutPanel.Name = "panelLayoutPanel"
        Me.panelLayoutPanel.RowCount = 3
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.panelLayoutPanel.Size = New System.Drawing.Size(640, 349)
        Me.panelLayoutPanel.TabIndex = 1
        '
        'agendaLabel
        '
        Me.agendaLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.agendaLabel.AutoSize = True
        Me.agendaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agendaLabel.ForeColor = System.Drawing.SystemColors.Window
        Me.agendaLabel.Location = New System.Drawing.Point(41, 38)
        Me.agendaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.agendaLabel.Name = "agendaLabel"
        Me.agendaLabel.Size = New System.Drawing.Size(408, 39)
        Me.agendaLabel.TabIndex = 17
        Me.agendaLabel.Text = "AGENDA | USER PANEL"
        '
        'agendaBox
        '
        Me.agendaBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.agendaBox.Image = Global.ProyectoVB.My.Resources.Resources.agenda
        Me.agendaBox.Location = New System.Drawing.Point(493, 2)
        Me.agendaBox.Margin = New System.Windows.Forms.Padding(2)
        Me.agendaBox.Name = "agendaBox"
        Me.agendaBox.Size = New System.Drawing.Size(145, 112)
        Me.agendaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.agendaBox.TabIndex = 11
        Me.agendaBox.TabStop = False
        '
        'contactoGroupBox
        '
        Me.contactoGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.contactoGroupBox.Controls.Add(Me.contactoComboBox)
        Me.contactoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactoGroupBox.ForeColor = System.Drawing.SystemColors.Window
        Me.contactoGroupBox.Location = New System.Drawing.Point(88, 118)
        Me.contactoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.contactoGroupBox.Name = "contactoGroupBox"
        Me.contactoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.contactoGroupBox.Size = New System.Drawing.Size(315, 112)
        Me.contactoGroupBox.TabIndex = 19
        Me.contactoGroupBox.TabStop = False
        Me.contactoGroupBox.Text = "Contacto"
        '
        'contactoComboBox
        '
        Me.contactoComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.contactoComboBox.FormattingEnabled = True
        Me.contactoComboBox.Location = New System.Drawing.Point(63, 46)
        Me.contactoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.contactoComboBox.Name = "contactoComboBox"
        Me.contactoComboBox.Size = New System.Drawing.Size(188, 30)
        Me.contactoComboBox.TabIndex = 0
        '
        'controlUserButton
        '
        Me.controlUserButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.controlUserButton.Location = New System.Drawing.Point(505, 153)
        Me.controlUserButton.Margin = New System.Windows.Forms.Padding(2)
        Me.controlUserButton.Name = "controlUserButton"
        Me.controlUserButton.Size = New System.Drawing.Size(120, 42)
        Me.controlUserButton.TabIndex = 3
        Me.controlUserButton.Text = "Ver Ficha"
        Me.controlUserButton.UseVisualStyleBackColor = True
        '
        'UserPanel
        '
        Me.AccessibleDescription = "userPanel"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 344)
        Me.Controls.Add(Me.panelLayoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(655, 383)
        Me.Name = "UserPanel"
        Me.Text = "AGENDA | USER PANEL"
        Me.panelLayoutPanel.ResumeLayout(False)
        Me.panelLayoutPanel.PerformLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contactoGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLayoutPanel As TableLayoutPanel
    Friend WithEvents agendaLabel As Label
    Friend WithEvents agendaBox As PictureBox
    Friend WithEvents controlUserButton As Button
    Friend WithEvents contactoGroupBox As GroupBox
    Friend WithEvents contactoComboBox As ComboBox
End Class
