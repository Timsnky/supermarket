Public Class Edit_Page
    Private SelectedItem As String = ""
    Private TextBoxNumber As Integer = 0
    Private EditField As String
    Private EditId As String
    Private DatabaseAccess As New DBConnect
    Private Sub EditSearchButton_Click(sender As System.Object, e As System.EventArgs) Handles EditSearchButton.Click
        Dim SearchResults As New ArrayList
        If EditSearchDetailTextBox.Text = String.Empty Then
            MessageBox.Show("Enter the Detail you want to Search For")
            EditSearchDetailTextBox.Focus()
        ElseIf EditSearchFieldComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Select the Search Field to Use")
            EditSearchFieldComboBox.Focus()
        ElseIf SupplierSearchRadioButton.Checked = False AndAlso StaffSearchRadioButton.Checked = False Then
            MessageBox.Show(" Select whether you are searching for a Supplier or Staff")
            SearchCategoryGroupBox.Focus()
        ElseIf EditItemComboBox.SelectedIndex = -1 Then
            MessageBox.Show(" Select the Field You Wish to Edit ")
            EditItemComboBox.Focus()
        Else
            EditField = EditItemComboBox.SelectedItem.ToString()
            If (SupplierSearchRadioButton.Checked = True) Then
                SearchResults = DatabaseAccess.GetSearchedSupplier(EditSearchDetailTextBox.Text.ToUpper, EditSearchFieldComboBox.SelectedItem.ToString)
            ElseIf StaffSearchRadioButton.Checked = True Then
                SearchResults = DatabaseAccess.GetSearchedStaff(EditSearchDetailTextBox.Text.ToUpper, EditSearchFieldComboBox.SelectedItem.ToString)
            End If
            DisplayResults(SearchResults)
        End If

    End Sub

    'Populate searchfield with collumn names from staff details table
    Private Sub StaffSearchRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles StaffSearchRadioButton.CheckedChanged
        If StaffSearchRadioButton.Checked = True Then
            EditSearchFieldComboBox.Items.Clear()
            EditSearchFieldComboBox.Items.Add("FirstName")
            EditSearchFieldComboBox.Items.Add("MiddleName")
            EditSearchFieldComboBox.Items.Add("SurName")
            EditSearchFieldComboBox.Items.Add("IDNumber")
            EditSearchFieldComboBox.Items.Add("PhoneNumber")
            EditSearchFieldComboBox.Items.Add("UserName")
            EditItemComboBox.Items.Add("FirstName")
            EditItemComboBox.Items.Add("MiddleName")
            EditItemComboBox.Items.Add("SurName")
            EditItemComboBox.Items.Add("IDNumber")
            EditItemComboBox.Items.Add("PhoneNumber")
            EditItemComboBox.Items.Add("EmailAddress")
        End If

    End Sub

    'Populate searchfield with collumn names from suppliers_details table
    Private Sub SupplierSearchRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles SupplierSearchRadioButton.CheckedChanged
        If SupplierSearchRadioButton.Checked = True Then
            EditSearchFieldComboBox.Items.Clear()
            EditSearchFieldComboBox.Items.Add("SupplierCode")
            EditSearchFieldComboBox.Items.Add("SupplierName")
            EditSearchFieldComboBox.Items.Add("PhoneNumber")
            EditSearchFieldComboBox.Items.Add("Categories")
            EditItemComboBox.Items.Add("SupplierName")
            EditItemComboBox.Items.Add("PhoneNumber")
            EditItemComboBox.Items.Add("EmailAddress")
        End If
    End Sub

    'Dynamically add textboxes to the groupbox depending on the search results
    Public Sub AddTextBox(ByVal Text As String)
        Dim TextBox1 As New TextBox
        TextBox1.Name = "Textbox" & TextBoxNumber
        TextBox1.Text = Text
        TextBox1.Size = New Size(507, 20)
        TextBox1.ReadOnly = True
        TextBox1.Location = New Point(6, 19 + (20 * TextBoxNumber))
        SearchResultsGroupBox.Controls.Add(TextBox1)
        TextBoxNumber += 1
        AddHandler TextBox1.Click, AddressOf TextBoxes_Click
    End Sub

    'Determine the Clicked search results field
    Private Sub TextBoxes_Click(sender As System.Object, e As System.EventArgs)
        Dim TextBoxId As New TextBox
        Try
            TextBoxId = DirectCast(sender, TextBox)
            If (SupplierSearchRadioButton.Checked = True) Then
                OldDetailTextBox.Text = DatabaseAccess.GetSupplierDetail(GetSelectedID(TextBoxId.Text), EditItemComboBox.SelectedItem.ToString())
            ElseIf StaffSearchRadioButton.Checked = True Then
                OldDetailTextBox.Text = DatabaseAccess.GetStaffDetail(GetSelectedID(TextBoxId.Text), EditItemComboBox.SelectedItem.ToString())
            End If
            OldDetailTextBox.Text = DatabaseAccess.GetStaffDetail(GetSelectedID(TextBoxId.Text), EditItemComboBox.SelectedItem.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub DisplayResults(ByVal SearchResults As ArrayList)
        Dim ArrayListSize As Integer = 0
        While ArrayListSize < SearchResults.Count()
            AddTextBox(SearchResults(ArrayListSize))
            ArrayListSize += 1
        End While
    End Sub

    Private Function GetSelectedID(ByVal Selected As String) As String
        Dim Splits As String()
        Splits = Selected.Split(ControlChars.Tab)
        EditId = Splits(Splits.Length - 1)
        Return EditId
    End Function

    Private Sub EditSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles EditSaveButton.Click
        If NewDetailTextBox.Text = String.Empty Then
            MessageBox.Show(" Enter the New Detail ")
            NewDetailTextBox.Focus()
        Else
            DatabaseAccess.UpdateEdit(NewDetailTextBox.Text.ToUpper(), EditField, EditId)
            MessageBox.Show("You have Successfully Edited the " & EditField & " from:" & ControlChars.NewLine & OldDetailTextBox.Text.ToUpper & " to " & NewDetailTextBox.Text.ToUpper)
            Me.Close()
            Home_Page.Show()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub
End Class