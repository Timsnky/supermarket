<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperUser_Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuperSubmitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ModifyWorkClassRadioButton = New System.Windows.Forms.RadioButton()
        Me.ResetPasswordRadioButton = New System.Windows.Forms.RadioButton()
        Me.NewWorkClassLabel = New System.Windows.Forms.Label()
        Me.GetNameButton = New System.Windows.Forms.Button()
        Me.NameGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.NewWorkClassComboBox = New System.Windows.Forms.ComboBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.NameGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Super User Edit Actions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the UserName"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(237, 191)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 2
        '
        'SuperSubmitButton
        '
        Me.SuperSubmitButton.Location = New System.Drawing.Point(131, 447)
        Me.SuperSubmitButton.Name = "SuperSubmitButton"
        Me.SuperSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SuperSubmitButton.TabIndex = 3
        Me.SuperSubmitButton.Text = "Submit"
        Me.SuperSubmitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ModifyWorkClassRadioButton)
        Me.GroupBox1.Controls.Add(Me.ResetPasswordRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 84)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select the Desired Action"
        '
        'ModifyWorkClassRadioButton
        '
        Me.ModifyWorkClassRadioButton.AutoSize = True
        Me.ModifyWorkClassRadioButton.Location = New System.Drawing.Point(253, 36)
        Me.ModifyWorkClassRadioButton.Name = "ModifyWorkClassRadioButton"
        Me.ModifyWorkClassRadioButton.Size = New System.Drawing.Size(110, 17)
        Me.ModifyWorkClassRadioButton.TabIndex = 1
        Me.ModifyWorkClassRadioButton.TabStop = True
        Me.ModifyWorkClassRadioButton.Text = "Modify WorkClass"
        Me.ModifyWorkClassRadioButton.UseVisualStyleBackColor = True
        '
        'ResetPasswordRadioButton
        '
        Me.ResetPasswordRadioButton.AutoSize = True
        Me.ResetPasswordRadioButton.Location = New System.Drawing.Point(105, 36)
        Me.ResetPasswordRadioButton.Name = "ResetPasswordRadioButton"
        Me.ResetPasswordRadioButton.Size = New System.Drawing.Size(102, 17)
        Me.ResetPasswordRadioButton.TabIndex = 0
        Me.ResetPasswordRadioButton.TabStop = True
        Me.ResetPasswordRadioButton.Text = "Reset Password"
        Me.ResetPasswordRadioButton.UseVisualStyleBackColor = True
        '
        'NewWorkClassLabel
        '
        Me.NewWorkClassLabel.AutoSize = True
        Me.NewWorkClassLabel.Location = New System.Drawing.Point(114, 350)
        Me.NewWorkClassLabel.Name = "NewWorkClassLabel"
        Me.NewWorkClassLabel.Size = New System.Drawing.Size(83, 13)
        Me.NewWorkClassLabel.TabIndex = 5
        Me.NewWorkClassLabel.Text = "New WorkClass"
        '
        'GetNameButton
        '
        Me.GetNameButton.Location = New System.Drawing.Point(180, 229)
        Me.GetNameButton.Name = "GetNameButton"
        Me.GetNameButton.Size = New System.Drawing.Size(75, 23)
        Me.GetNameButton.TabIndex = 7
        Me.GetNameButton.Text = "Get Name"
        Me.GetNameButton.UseVisualStyleBackColor = True
        '
        'NameGroupBox
        '
        Me.NameGroupBox.Controls.Add(Me.UserDetailsTextBox)
        Me.NameGroupBox.Location = New System.Drawing.Point(12, 258)
        Me.NameGroupBox.Name = "NameGroupBox"
        Me.NameGroupBox.Size = New System.Drawing.Size(480, 68)
        Me.NameGroupBox.TabIndex = 8
        Me.NameGroupBox.TabStop = False
        Me.NameGroupBox.Text = "User Details"
        '
        'UserDetailsTextBox
        '
        Me.UserDetailsTextBox.Location = New System.Drawing.Point(6, 28)
        Me.UserDetailsTextBox.Name = "UserDetailsTextBox"
        Me.UserDetailsTextBox.ReadOnly = True
        Me.UserDetailsTextBox.Size = New System.Drawing.Size(468, 20)
        Me.UserDetailsTextBox.TabIndex = 0
        '
        'NewWorkClassComboBox
        '
        Me.NewWorkClassComboBox.FormattingEnabled = True
        Me.NewWorkClassComboBox.Items.AddRange(New Object() {"999", "150", "60"})
        Me.NewWorkClassComboBox.Location = New System.Drawing.Point(216, 347)
        Me.NewWorkClassComboBox.Name = "NewWorkClassComboBox"
        Me.NewWorkClassComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NewWorkClassComboBox.TabIndex = 9
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(279, 447)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SuperUser_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 523)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NewWorkClassComboBox)
        Me.Controls.Add(Me.NameGroupBox)
        Me.Controls.Add(Me.GetNameButton)
        Me.Controls.Add(Me.NewWorkClassLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SuperSubmitButton)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SuperUser_Edit"
        Me.Text = "SuperUser Edit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.NameGroupBox.ResumeLayout(False)
        Me.NameGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuperSubmitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ModifyWorkClassRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ResetPasswordRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NewWorkClassLabel As System.Windows.Forms.Label
    Friend WithEvents GetNameButton As System.Windows.Forms.Button
    Friend WithEvents NameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents UserDetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewWorkClassComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
