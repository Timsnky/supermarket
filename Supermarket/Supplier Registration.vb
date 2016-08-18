Public Class Supplier_Registration
    Public DatabaseAccess = New DBConnect
    Private Sub SupplierSubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles SupplierSubmitButton.Click
        Dim DatabaseAccess = New DBConnect
        Dim NewSupplierData As New ArrayList
        Dim SupplierCode As String
        Dim Categories As String = GetCategories()
        Dim SupplierNumber As Decimal = DatabaseAccess.GetSupplierNumber()
        If SupplierNameTextBox.Text = String.Empty Then
            MessageBox.Show(" Supplier Name Cannot Be Null ")
            SupplierNameTextBox.Focus()
        ElseIf PhoneNumberMaskedTextBox.Text = String.Empty Then
            MessageBox.Show(" Supplier Phone Number Required ")
            PhoneNumberMaskedTextBox.Focus()
        ElseIf EmailAddressTextBox.Text <> String.Empty AndAlso ValidateEmail() = False Then
            MessageBox.Show("Invalid Email Address")
            EmailAddressTextBox.Clear()
            EmailAddressTextBox.Focus()
        ElseIf Categories = String.Empty Then
            MessageBox.Show(" Please Select at least 1 Category for the Supplier ")
            AlcoholicCheckBox.Focus()
        Else
            NewSupplierData.Add(SupplierNumber.ToString.ToUpper)
            SupplierCode = GenerateSupplierCode(SupplierNumber, SupplierNameTextBox.Text).ToUpper
            SupplierCodeTextBox.Text = SupplierCode
            NewSupplierData.Add(SupplierCode)
            NewSupplierData.Add(SupplierNameTextBox.Text.ToUpper)
            NewSupplierData.Add(PhoneNumberMaskedTextBox.Text)
            NewSupplierData.Add(EmailAddressTextBox.Text.ToLower)
            NewSupplierData.Add(Categories)
            DatabaseAccess.AddNewSupplier(NewSupplierData)
            DatabaseAccess.ShowSupplierDetailsTable()
            MessageBox.Show(" You Have Successfully Registered a New Supplier:" & ControlChars.NewLine & "Name: " & NewSupplierData(2) & ControlChars.NewLine & _
                            "Supplier Code: " & NewSupplierData(1))
            Me.Close()
            Home_Page.Show()
        End If

    End Sub

    'Validate the Email Address of the Supplier
    Private Function ValidateEmail() As Boolean
        If EmailAddressTextBox.Text.IndexOf("@") = -1 OrElse
            EmailAddressTextBox.Text.IndexOf(".") = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    'Get the selected categories for the supplier
    Private Function GetCategories() As String
        Dim Categories As String = ""
        If AlcoholicCheckBox.Checked = True Then
            Categories = Categories & "A"
        End If
        If BakeryCheckBox.Checked = True Then
            Categories = Categories & "B"
        End If
        If ClothingCheckBox.Checked = True Then
            Categories = Categories & "C"
        End If
        If DairyCheckBox.Checked = True Then
            Categories = Categories & "D"
        End If
        If ElectronicsCheckBox.Checked = True Then
            Categories = Categories & "E"
        End If
        If GroceriesCheckBox.Checked = True Then
            Categories = Categories & "G"
        End If
        If HouseholdCheckBox.Checked = True Then
            Categories = Categories & "H"
        End If
        If InteriorCheckBox.Checked = True Then
            Categories = Categories & "I"
        End If
        If LaundryCheckBox.Checked = True Then
            Categories = Categories & "L"
        End If
        If NonAlcoholicCheckBox.Checked = True Then
            Categories = Categories & "N"
        End If
        If StationeryCheckBox.Checked = True Then
            Categories = Categories & "S"
        End If
        If ToysCheckBox.Checked = True Then
            Categories = Categories & "T"
        End If
        Return Categories
    End Function

    'Generate the Supplier Code
    Private Function GenerateSupplierCode(ByVal SupplierNumber As Decimal, ByVal Name As String) As String
        Dim Code As String = ""
        Dim SupplierCode As String = ""
        Code = Name.Substring(0, 3)
        If SupplierNumber < 10 Then
            SupplierCode = "0000" & SupplierNumber
        ElseIf SupplierNumber >= 10 And SupplierNumber < 100 Then
            SupplierCode = "000" & SupplierNumber
        ElseIf SupplierNumber >= 100 And SupplierNumber < 1000 Then
            SupplierCode = "00" & SupplierNumber
        ElseIf SupplierNumber >= 1000 And SupplierNumber < 10000 Then
            SupplierCode = "0" & SupplierNumber
        Else
            SupplierCode = SupplierNumber
        End If
        Return Code & SupplierCode
    End Function

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub
End Class