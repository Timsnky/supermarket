Public Class User_Registration
    Private DatabaseAccess = New DBConnect
    Private SendingEmail = New Email

    'Handling of the Submit Button Click
    Private Sub SubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles SubmitButton.Click
        Dim NewStaffData As New ArrayList
        Dim NewUserData As New ArrayList
        Dim Email As New ArrayList
        If FirstNameTextBox.Text = String.Empty Then
            MessageBox.Show("First Name Cannot be Null")
            FirstNameTextBox.Focus()
        ElseIf SurNameTextBox.Text = String.Empty Then
            MessageBox.Show("SurName Cannot be Null")
            SurNameTextBox.Focus()
        ElseIf IDNumberTextBox.Text = String.Empty OrElse DatabaseAccess.ConfirmIDNumber(IDNumberTextBox.Text) = False Then
            MessageBox.Show(" Existing ID NUmber or ID Number Cannot be Null")
            IDNumberTextBox.Clear()
            IDNumberTextBox.Focus()
        ElseIf MaleRadioButton.Checked = False And FemaleRadioButton.Checked = False Then
            MessageBox.Show("Select the Appropriate Gender")
        ElseIf EmailAddressTextBox.Text <> String.Empty AndAlso ValidateEmail() = False Then
            MessageBox.Show("Invalid Email Address")
            EmailAddressTextBox.Clear()
            EmailAddressTextBox.Focus()
        ElseIf WorkClassComboBox.SelectedIndex = -1 Then
            MessageBox.Show(" Select the Appropriate Work Class ")
            WorkClassComboBox.Focus()
        Else
            NewStaffData.Add(FirstNameTextBox.Text.ToUpper)
            NewStaffData.Add(MiddleNameTextBox.Text.ToUpper)
            NewStaffData.Add(SurNameTextBox.Text.ToUpper)
            NewStaffData.Add(IDNumberTextBox.Text.ToUpper)
            NewStaffData.Add(CheckGender())
            NewStaffData.Add(PhoneNumberMaskedTextBox.Text)
            NewStaffData.Add(EmailAddressTextBox.Text.ToLower)
            NewStaffData.Add(GenerateUserName(DatabaseAccess.GetStaffNumber()).ToUpper)
            UserNameTextBox.Text = NewStaffData(7)
            NewStaffData.Add(WorkClassComboBox.SelectedItem.ToString())
            MessageBox.Show("You have Successfully Created a New User: " & ControlChars.NewLine _
                            & "Details: " & ControlChars.NewLine & "Names: " & NewStaffData(0) & " " &
                            NewStaffData(1) & " " & NewStaffData(2) & ControlChars.NewLine & "UserName: " & NewStaffData(7) &
                            ControlChars.NewLine & "Work Class: " & NewStaffData(8))
            NewUserData.Add(NewStaffData(7))
            NewUserData.Add(NewStaffData(8))
            DatabaseAccess.AddNewStaff(NewStaffData)
            DatabaseAccess.AddNewUser(NewUserData)
            Email.Add(NewStaffData(6))
            Email.Add(NewStaffData(0))
            Email.Add(NewStaffData(1))
            Email.Add(NewStaffData(2))
            Email.Add(NewStaffData(7))
            Email.Add(NewStaffData(8))
            Email.Add("1234Pass")
            SendingEmail.SendEmail(Email)
            DatabaseAccess.ShowStaffDetailsTable()
            DatabaseAccess.ShowUsersTable()
            Me.Close()
            Home_Page.Show()
        End If
    End Sub

    'Determine the appropriate gender letter
    Private Function CheckGender() As String
        If MaleRadioButton.Checked = True Then
            Return "M"
        Else
            Return "F"
        End If
    End Function

    'Validate the input email address
    Private Function ValidateEmail() As Boolean
        If EmailAddressTextBox.Text.IndexOf("@") = -1 OrElse
            EmailAddressTextBox.Text.IndexOf(".") = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Generate a UserName for the New User
    Private Function GenerateUserName(ByVal UserIndex As Decimal) As String
        Dim UserName As String = ""
        Dim Index As String = ""
        If UserIndex < 10 Then
            Index = "000" & UserIndex
        ElseIf UserIndex >= 10 And UserIndex < 100 Then
            Index = "00" & UserIndex
        ElseIf UserIndex >= 100 And UserIndex < 1000 Then
            Index = "0" & UserIndex
        Else
            Index = UserIndex
        End If
        UserName = FirstNameTextBox.Text.Substring(0, 1) & SurNameTextBox.Text.Substring(0, 1) & Index
        Return UserName
    End Function

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub
End Class