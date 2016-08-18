Public Class Invoicing

    Private DatabaseAccess As New DBConnect
    Private ProductsNumber As Long = 0
    Private TextBoxNumber As Integer = 0
    Private ProductCodes As New ArrayList()
    Private ProductDescriptions As New ArrayList()
    Private ProductPrices As New ArrayList()
    Private Receipt As New ArrayList()
    Private Index As Integer
    Private RowDetails(5) As String
    Private Total As Double
    Private Inventory As New ArrayList

    'A little preparation of the form for the transaction to run smoothly
    Private Sub Invoicing_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductCodesDBDataSet.ProductCodes' table. You can move, or remove it, as needed.
        Dim Today As DateTime = Now
        ProductCodes = DatabaseAccess.GetProductCodes()
        ProductDescriptions = DatabaseAccess.GetProductDescriptions()
        ProductPrices = DatabaseAccess.GetProductPrices()
        UseeNameTextBox.Text = Home_Page.UserName.ToUpper
        NameTextBox.Text = Home_Page.FirstName.ToUpper
        DateTextBox.Text = Today.ToShortDateString()
        AddRow()
    End Sub

    'Dynamically add textboxes to the groupbox depending on the search results
    Public Sub AddRow()
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(22, 20)
        Textbox1.ReadOnly = True
        Textbox1.Text = TextBoxNumber + 1
        Textbox1.Location = New Point(3, 0 + (20 * TextBoxNumber))
        InvoicePanel.Controls.Add(Textbox1)

        Dim ComboBox2 As New ComboBox
        ComboBox2.Size = New Size(129, 20)
        ComboBox2.Location = New Point(25, 0 + (20 * TextBoxNumber))
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDown
        AddProducts(ComboBox2, ProductCodes)
        ComboBox2.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems
        InvoicePanel.Controls.Add(ComboBox2)
        ComboBox2.Focus()
        AddHandler ComboBox2.LostFocus, AddressOf ComboBox_LostFocus

        Dim TextBox3 As New TextBox
        TextBox3.Size = New Size(295, 20)
        TextBox3.Tag = "R" & TextBoxNumber & "C3"
        TextBox3.ReadOnly = True
        TextBox3.Location = New Point(151, 0 + (20 * TextBoxNumber))
        InvoicePanel.Controls.Add(TextBox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(100, 20)
        TextBox4.Tag = "R" & TextBoxNumber & "C4"
        TextBox4.Text = 1
        TextBox4.Location = New Point(444, 0 + (20 * TextBoxNumber))
        InvoicePanel.Controls.Add(TextBox4)
        AddHandler TextBox4.KeyPress, AddressOf TextBox_KeyPress

        Dim TextBox5 As New TextBox
        TextBox5.Size = New Size(97, 20)
        TextBox5.Tag = "R" & TextBoxNumber & "C5"
        TextBox5.ReadOnly = True
        TextBox5.Location = New Point(541, 0 + (20 * TextBoxNumber))
        InvoicePanel.Controls.Add(TextBox5)

        Dim TextBox6 As New TextBox
        TextBox6.Size = New Size(106, 20)
        TextBox6.ReadOnly = True
        TextBox6.Tag = "R" & TextBoxNumber & "C6"
        TextBox6.Location = New Point(636, 0 + (20 * TextBoxNumber))
        InvoicePanel.Controls.Add(TextBox6)
        TextBoxNumber += 1
    End Sub

     

    'Handler when the combo box loses focus
    Private Sub ComboBox_LostFocus(sender As System.Object, e As System.EventArgs)
        Dim ComboBoxId As New ComboBox
        Index = 0
        ComboBoxId = DirectCast(sender, ComboBox)
        Index = ComboBoxId.SelectedIndex
        If Index <> -1 Then
            RowDetails(0) = ComboBoxId.SelectedItem.ToString
            RowDetails(1) = ProductDescriptions(Index)
            RowDetails(3) = ProductPrices(Index)
            For Each c As Control In InvoicePanel.Controls
                If TypeOf c Is TextBox Then
                    If c.Tag = "R" & TextBoxNumber - 1 & "C3" Then
                        c.Text = RowDetails(1)
                    ElseIf c.Tag = "R" & TextBoxNumber - 1 & "C5" Then
                        c.Text = RowDetails(3)
                    End If
                End If
            Next
        End If
    End Sub

    'Determine the Clicked search results field
    Private Sub TextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Dim TextBoxId As New TextBox
        Dim Total1 As Double = 0
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            TextBoxId = DirectCast(sender, TextBox)
            RowDetails(2) = TextBoxId.Text.ToString
            For Each c As Control In InvoicePanel.Controls
                If TypeOf c Is TextBox AndAlso c.Tag = "R" & TextBoxNumber - 1 & "C6" Then
                    Total1 = Decimal.Parse(RowDetails(2), Globalization.NumberStyles.Float) * Decimal.Parse(RowDetails(3))
                    c.Text = Total1
                    RowDetails(4) = Total1.ToString
                End If
            Next
            Total = Total1 + Total
            TotalPayTextBox.Text = Total.ToString("N2")
            Receipt.Add(RowDetails(0))
            Receipt.Add(RowDetails(1))
            Receipt.Add(RowDetails(2))
            Receipt.Add(RowDetails(3))
            Receipt.Add(RowDetails(4))
            Inventory.Add(RowDetails(0))
            Inventory.Add(RowDetails(2))
            AddRow()
        End If
    End Sub

    'Populate the Product Code Combobox with product codes from the products table
    Private Sub AddProducts(ByVal ComboBox As ComboBox, ByVal ProductCode As ArrayList)
        Dim Item As Integer = 0
        ComboBox.Items.Clear()
        While Item < ProductCodes.Count()
            ComboBox.Items.Add(ProductCodes(Item))
            Item += 1
        End While
    End Sub

    'Compute the Change as one inputs the cash
    Private Sub CashTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CashTextBox.TextChanged
        Dim Change As Double
        If ChangeTextBox.Text <> String.Empty Then
            Try
                Change = Double.Parse(CashTextBox.Text, Globalization.NumberStyles.Float) - Double.Parse(TotalPayTextBox.Text)
                ChangeTextBox.Text = Change.ToString("N2")
            Catch ex As Exception
            End Try
            
        End If
    End Sub

    'Update the Invoice list table
    Private Sub SubmitInvoiceButton_Click(sender As System.Object, e As System.EventArgs) Handles SubmitInvoiceButton.Click
        DatabaseAccess.UpdateInventory(Inventory)
        DatabaseAccess.UpdateInvoiceList(Total, DateTextBox.Text)
        InvoicePanel.Controls.Clear()
        TextBoxNumber = 0
        TotalPayTextBox.Text = 0
        ChangeTextBox.Text = 0
        CashTextBox.Text = 0
        Dim i As Integer = 0
        While i < Receipt.Count / 5
            i += 1
        End While
        Reports.GenerateReceipt(Receipt, Total)
        Reports.Show()
        Total = 0
        'AddRow()
    End Sub

    'Handle the exit button event
    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub

End Class