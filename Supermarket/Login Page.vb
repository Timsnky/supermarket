Public Class LoginPage
    Private DatabaseAccess = New DBConnect

    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click

        Dim workclass As Decimal = DatabaseAccess.LoginAuthentication(UserNameTextBox.Text.ToUpper, PasswordTextBox.Text)
        If workclass <> 0 Then
            DatabaseAccess.OpenHomePage(UserNameTextBox.Text)
        Else
            UserNameTextBox.Clear()
            PasswordTextBox.Clear()
            UserNameTextBox.Focus()
        End If
    End Sub

    Private Sub LoginPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer = 2
        Dim Y As Double = Double.Parse(x)
        Console.WriteLine(x)
        Console.WriteLine(Y)
    End Sub
End Class
