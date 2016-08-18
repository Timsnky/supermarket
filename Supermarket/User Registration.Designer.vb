<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Registration
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GenderGroupBox = New System.Windows.Forms.GroupBox()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurNameTextBox = New System.Windows.Forms.TextBox()
        Me.IDNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ContactGroupBox = New System.Windows.Forms.GroupBox()
        Me.PhoneNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.OfficialDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.WorkClassComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GenderGroupBox.SuspendLayout()
        Me.ContactGroupBox.SuspendLayout()
        Me.OfficialDetailsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SurName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "User Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(242, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 8
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(179, 500)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GenderGroupBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.MiddleNameTextBox)
        Me.GroupBox1.Controls.Add(Me.SurNameTextBox)
        Me.GroupBox1.Controls.Add(Me.IDNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 151)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'GenderGroupBox
        '
        Me.GenderGroupBox.Controls.Add(Me.MaleRadioButton)
        Me.GenderGroupBox.Controls.Add(Me.FemaleRadioButton)
        Me.GenderGroupBox.Location = New System.Drawing.Point(334, 72)
        Me.GenderGroupBox.Name = "GenderGroupBox"
        Me.GenderGroupBox.Size = New System.Drawing.Size(200, 73)
        Me.GenderGroupBox.TabIndex = 16
        Me.GenderGroupBox.TabStop = False
        Me.GenderGroupBox.Text = "Gender"
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(6, 27)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioButton.TabIndex = 12
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(97, 27)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioButton.TabIndex = 13
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(79, 36)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.FirstNameTextBox.TabIndex = 12
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(300, 36)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(161, 20)
        Me.MiddleNameTextBox.TabIndex = 13
        '
        'SurNameTextBox
        '
        Me.SurNameTextBox.Location = New System.Drawing.Point(524, 36)
        Me.SurNameTextBox.Name = "SurNameTextBox"
        Me.SurNameTextBox.Size = New System.Drawing.Size(128, 20)
        Me.SurNameTextBox.TabIndex = 14
        '
        'IDNumberTextBox
        '
        Me.IDNumberTextBox.Location = New System.Drawing.Point(79, 104)
        Me.IDNumberTextBox.Name = "IDNumberTextBox"
        Me.IDNumberTextBox.Size = New System.Drawing.Size(140, 20)
        Me.IDNumberTextBox.TabIndex = 15
        '
        'ContactGroupBox
        '
        Me.ContactGroupBox.Controls.Add(Me.PhoneNumberMaskedTextBox)
        Me.ContactGroupBox.Controls.Add(Me.EmailAddressTextBox)
        Me.ContactGroupBox.Controls.Add(Me.Label4)
        Me.ContactGroupBox.Controls.Add(Me.Label5)
        Me.ContactGroupBox.Location = New System.Drawing.Point(12, 258)
        Me.ContactGroupBox.Name = "ContactGroupBox"
        Me.ContactGroupBox.Size = New System.Drawing.Size(658, 87)
        Me.ContactGroupBox.TabIndex = 0
        Me.ContactGroupBox.TabStop = False
        Me.ContactGroupBox.Text = "Contact Details"
        '
        'PhoneNumberMaskedTextBox
        '
        Me.PhoneNumberMaskedTextBox.Location = New System.Drawing.Point(102, 34)
        Me.PhoneNumberMaskedTextBox.Mask = "0000000000"
        Me.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox"
        Me.PhoneNumberMaskedTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PhoneNumberMaskedTextBox.TabIndex = 11
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(396, 34)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(213, 20)
        Me.EmailAddressTextBox.TabIndex = 10
        '
        'OfficialDetailsGroupBox
        '
        Me.OfficialDetailsGroupBox.Controls.Add(Me.WorkClassComboBox)
        Me.OfficialDetailsGroupBox.Controls.Add(Me.Label8)
        Me.OfficialDetailsGroupBox.Controls.Add(Me.UserNameTextBox)
        Me.OfficialDetailsGroupBox.Controls.Add(Me.Label9)
        Me.OfficialDetailsGroupBox.Controls.Add(Me.Label6)
        Me.OfficialDetailsGroupBox.Location = New System.Drawing.Point(12, 377)
        Me.OfficialDetailsGroupBox.Name = "OfficialDetailsGroupBox"
        Me.OfficialDetailsGroupBox.Size = New System.Drawing.Size(658, 93)
        Me.OfficialDetailsGroupBox.TabIndex = 0
        Me.OfficialDetailsGroupBox.TabStop = False
        Me.OfficialDetailsGroupBox.Text = "Official Details"
        '
        'WorkClassComboBox
        '
        Me.WorkClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WorkClassComboBox.FormattingEnabled = True
        Me.WorkClassComboBox.Items.AddRange(New Object() {"999", "150", "60"})
        Me.WorkClassComboBox.Location = New System.Drawing.Point(396, 38)
        Me.WorkClassComboBox.Name = "WorkClassComboBox"
        Me.WorkClassComboBox.Size = New System.Drawing.Size(138, 21)
        Me.WorkClassComboBox.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Work Class"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(102, 38)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.ReadOnly = True
        Me.UserNameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.UserNameTextBox.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Registration of a New User in the System"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(325, 500)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'User_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 553)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ContactGroupBox)
        Me.Controls.Add(Me.OfficialDetailsGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "User_Registration"
        Me.Text = "User Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GenderGroupBox.ResumeLayout(False)
        Me.GenderGroupBox.PerformLayout()
        Me.ContactGroupBox.ResumeLayout(False)
        Me.ContactGroupBox.PerformLayout()
        Me.OfficialDetailsGroupBox.ResumeLayout(False)
        Me.OfficialDetailsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GenderGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OfficialDetailsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents WorkClassComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
