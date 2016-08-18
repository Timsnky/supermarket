Public Class SuperUser_Edit

    Private DatabaseAccess As New DBConnect
    'Check which radio button is checked and act accordingly
    Private Sub ResetPasswordRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ResetPasswordRadioButton.CheckedChanged
        If ResetPasswordRadioButton.Checked = True Then
            NewWorkClassComboBox.Visible = False
            NewWorkClassLabel.Visible = False
        End If
    End Sub

    'Check which radio button is checked and act accordingly
    Private Sub ModifyWorkClassRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ModifyWorkClassRadioButton.CheckedChanged
        If ModifyWorkClassRadioButton.Checked = True Then
            NewWorkClassComboBox.Visible = True
            NewWorkClassLabel.Visible = True
        End If
    End Sub

    'Handle the Get Name Button Click
    Private Sub GetNameButton_Click(sender As System.Object, e As System.EventArgs) Handles GetNameButton.Click
        UserDetailsTextBox.Text = DatabaseAccess.GetSeearchedStaffDetails(UserNameTextBox.Text.ToUpper)
    End Sub

    'Handle the submii button click
    Private Sub SuperSubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles SuperSubmitButton.Click
        Dim OutCome As Integer
        If ResetPasswordRadioButton.Checked = True Then
            OutCome = DatabaseAccess.ResetPassword(UserNameTextBox.Text)
            If OutCome = 1 Then
                MessageBox.Show("You Have Successfully Reset the User's Password")
                Me.Close()
                Home_Page.Show()
            Else
                MessageBox.Show("Password Change was not successful")
                UserNameTextBox.Clear()
                UserNameTextBox.Focus()
            End If
        ElseIf ModifyWorkClassRadioButton.Checked = True Then
            OutCome = DatabaseAccess.EditWorkClass(UserNameTextBox.Text, NewWorkClassComboBox.SelectedItem.ToString)
            If OutCome = 1 Then
                MessageBox.Show("You Have Successfully Modified the User's WorkClass")
                Me.Close()
                Home_Page.Show()
            Else
                MessageBox.Show("WorkClass Change was not successful")
                UserNameTextBox.Clear()
                UserNameTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub
End Class