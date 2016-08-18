Public Class Search_Page
    Private DatabaseAccess As New DBConnect
    Private TextBoxNumber As Integer = 0

    Private Sub StaffSearchRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles StaffSearchRadioButton.CheckedChanged
        If StaffSearchRadioButton.Checked = True Then
            SearchFieldComboBox.Items.Clear()
            SearchResultsPanel.Controls.Clear()
            SearchFieldComboBox.Items.Add("FirstName")
            SearchFieldComboBox.Items.Add("MiddleName")
            SearchFieldComboBox.Items.Add("SurName")
            SearchFieldComboBox.Items.Add("IDNumber")
            SearchFieldComboBox.Items.Add("PhoneNumber")
            SearchFieldComboBox.Items.Add("UserName")
        End If
    End Sub

    Private Sub SupplierSearchRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles SupplierSearchRadioButton.CheckedChanged
        If SupplierSearchRadioButton.Checked = True Then
            SearchFieldComboBox.Items.Clear()
            SearchResultsPanel.Controls.Clear()
            SearchFieldComboBox.Items.Add("SupplierCode")
            SearchFieldComboBox.Items.Add("SupplierName")
            SearchFieldComboBox.Items.Add("PhoneNumber")
        End If
    End Sub

    Private Sub ProductSearchRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ProductSearchRadioButton.CheckedChanged
        If ProductSearchRadioButton.Checked = True Then
            SearchFieldComboBox.Items.Clear()
            SearchResultsPanel.Controls.Clear()
            SearchFieldComboBox.Items.Add("ProductCode")
        End If
    End Sub

    'Handle the search button click
    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        Dim SearchResults As New ArrayList
        If SearchDetailTextBox.Text = String.Empty Then
            MessageBox.Show("Enter the Detail You Wish to Search For")
            SearchDetailTextBox.Focus()
        ElseIf SearchFieldComboBox.SelectedIndex = -1 Then
            MessageBox.Show("sELECT the Search Field You Wish to Search For")
            SearchFieldComboBox.Focus()
        Else
            If (SupplierSearchRadioButton.Checked = True) Then
                SearchResults = DatabaseAccess.GetSearchedSupplier(SearchDetailTextBox.Text.ToUpper, SearchFieldComboBox.SelectedItem.ToString)
            ElseIf StaffSearchRadioButton.Checked = True Then
                SearchResults = DatabaseAccess.GetSearchedStaff(SearchDetailTextBox.Text.ToUpper, SearchFieldComboBox.SelectedItem.ToString)
            ElseIf ProductSearchRadioButton.Checked = True Then
                SearchResults.Add(DatabaseAccess.GetSearchedProduct(SearchDetailTextBox.Text.ToUpper))
            End If
            DisplayResults(SearchResults)
        End If
        TextBoxNumber = 0
    End Sub

    'Dynamically add textboxes to the groupbox depending on the search results
    Public Sub AddTextBox(ByVal Text As String)
        Dim TextBox1 As New TextBox
        TextBox1.Name = "Textbox" & TextBoxNumber
        TextBox1.Text = Text
        TextBox1.Size = New Size(507, 20)
        TextBox1.ReadOnly = True
        TextBox1.Location = New Point(0, 0 + (20 * TextBoxNumber))
        SearchResultsPanel.Controls.Add(TextBox1)
        TextBoxNumber += 1
        AddHandler TextBox1.Click, AddressOf TextBoxes_Click
    End Sub

    'Determine the Clicked search results field
    Private Sub TextBoxes_Click(sender As System.Object, e As System.EventArgs)
        Dim TextBoxId As New TextBox
        Try
            TextBoxId = DirectCast(sender, TextBox)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    'Iterate through the arraylist while addng rows appropriately
    Private Sub DisplayResults(ByVal SearchResults As ArrayList)
        Dim ArrayListSize As Integer = 0
        While ArrayListSize < SearchResults.Count()
            AddTextBox(SearchResults(ArrayListSize))
            ArrayListSize += 1
        End While
    End Sub


    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub
End Class