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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.principalLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.agendaBox = New System.Windows.Forms.PictureBox()
        Me.agendaLabel = New System.Windows.Forms.Label()
        Me.nameGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.passwordGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.principalLayoutPanel.SuspendLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nameGroupBox.SuspendLayout()
        Me.passwordGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'principalLayoutPanel
        '
        Me.principalLayoutPanel.ColumnCount = 2
        Me.principalLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.principalLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.principalLayoutPanel.Controls.Add(Me.passwordGroupBox, 1, 2)
        Me.principalLayoutPanel.Controls.Add(Me.agendaBox, 0, 1)
        Me.principalLayoutPanel.Controls.Add(Me.agendaLabel, 0, 0)
        Me.principalLayoutPanel.Controls.Add(Me.nameGroupBox, 1, 1)
        Me.principalLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.principalLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.principalLayoutPanel.Name = "principalLayoutPanel"
        Me.principalLayoutPanel.RowCount = 5
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.principalLayoutPanel.Size = New System.Drawing.Size(1238, 625)
        Me.principalLayoutPanel.TabIndex = 0
        Me.principalLayoutPanel.Tag = ""
        '
        'agendaBox
        '
        Me.agendaBox.Image = Global.ProyectoVB.My.Resources.Resources.agenda
        Me.agendaBox.Location = New System.Drawing.Point(3, 128)
        Me.agendaBox.Name = "agendaBox"
        Me.principalLayoutPanel.SetRowSpan(Me.agendaBox, 2)
        Me.agendaBox.Size = New System.Drawing.Size(613, 244)
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
        Me.agendaLabel.Location = New System.Drawing.Point(150, 27)
        Me.agendaLabel.Name = "agendaLabel"
        Me.agendaLabel.Size = New System.Drawing.Size(319, 71)
        Me.agendaLabel.TabIndex = 1
        Me.agendaLabel.Text = "AGENDA"
        '
        'nameGroupBox
        '
        Me.nameGroupBox.Controls.Add(Me.TextBox1)
        Me.nameGroupBox.Location = New System.Drawing.Point(622, 128)
        Me.nameGroupBox.Name = "nameGroupBox"
        Me.nameGroupBox.Size = New System.Drawing.Size(613, 119)
        Me.nameGroupBox.TabIndex = 2
        Me.nameGroupBox.TabStop = False
        Me.nameGroupBox.Text = "User"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 0
        '
        'passwordGroupBox
        '
        Me.passwordGroupBox.Controls.Add(Me.TextBox3)
        Me.passwordGroupBox.Location = New System.Drawing.Point(622, 253)
        Me.passwordGroupBox.Name = "passwordGroupBox"
        Me.passwordGroupBox.Size = New System.Drawing.Size(613, 119)
        Me.passwordGroupBox.TabIndex = 4
        Me.passwordGroupBox.TabStop = False
        Me.passwordGroupBox.Text = "Password"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(245, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 31)
        Me.TextBox3.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1238, 625)
        Me.Controls.Add(Me.principalLayoutPanel)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "ACCESO | AGENDA"
        Me.principalLayoutPanel.ResumeLayout(False)
        Me.principalLayoutPanel.PerformLayout()
        CType(Me.agendaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nameGroupBox.ResumeLayout(False)
        Me.nameGroupBox.PerformLayout()
        Me.passwordGroupBox.ResumeLayout(False)
        Me.passwordGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents principalLayoutPanel As TableLayoutPanel
    Friend WithEvents agendaBox As PictureBox
    Friend WithEvents agendaLabel As Label
    Friend WithEvents passwordGroupBox As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents nameGroupBox As GroupBox
    Friend WithEvents TextBox1 As TextBox
End Class
