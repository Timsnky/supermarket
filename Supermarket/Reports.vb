Public Class Reports

    Private SupplierNumber As Long = 0
    Private DatabaseAccess As New DBConnect
    Private Today As DateTime = Now

    'Generate a report of all the suppliers in the system and display in report page
    Public Sub GenerateSuppliersReport()
        Dim Suppliers As New ArrayList
        Suppliers = DatabaseAccess.ShowSupplierDetailsTable()
        ReportTitleLabel.Text = "Report on all the Suppliers in the System"
        While SupplierNumber <= Suppliers.Count / 5
            AddSuppliersRows(Suppliers)
            SupplierNumber += 1
        End While
    End Sub

    'Generate a report of all the staff in the system and display in report page
    Public Sub GenerateStaffReport()
        Dim Staff As New ArrayList
        Staff = DatabaseAccess.ShowStaffDetailsTable()
        ReportTitleLabel.Text = "Report on all the Staff in the System"
        While SupplierNumber <= Staff.Count / 9
            AddStaffsRows(Staff)
            SupplierNumber += 1
        End While

    End Sub

    'Generate a report of all the products in the system and display in report page
    Public Sub GenerateProductsReport()
        Dim Products As New ArrayList
        Products = DatabaseAccess.ShowProductsTable()
        ReportTitleLabel.Text = "Report on all the Products in the System"
        While SupplierNumber <= Products.Count / 4
            AddProductsRows(Products)
            SupplierNumber += 1
        End While
    End Sub

    'Dynamically add th rows while displaying the suppliers
    Private Sub AddSuppliersRows(ByVal Suppliers As ArrayList)
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(100, 20)
        Textbox1.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox1.Text = "SUPPLIER CODE"
        Else
            Textbox1.Text = Suppliers(0 + 5 * (SupplierNumber - 1))
        End If
        Textbox1.Location = New Point(0, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox1)

        Dim Textbox2 As New TextBox
        Textbox2.Size = New Size(237, 20)
        Textbox2.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox2.Text = "SUPPLIER NAME"
        Else
            Textbox2.Text = Suppliers(1 + 5 * (SupplierNumber - 1))
        End If
        Textbox2.Location = New Point(100, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox2)

        Dim TextBox3 As New TextBox
        TextBox3.Size = New Size(95, 20)
        TextBox3.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox3.Text = "PHONE NUMBER"
        Else
            TextBox3.Text = Suppliers(2 + 5 * (SupplierNumber - 1))
        End If
        TextBox3.Location = New Point(337, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(170, 20)
        TextBox4.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox4.Text = "EMAIL ADDRESS"
        Else
            TextBox4.Text = Suppliers(3 + 5 * (SupplierNumber - 1))
        End If
        TextBox4.Location = New Point(432, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox4)

        Dim TextBox5 As New TextBox
        TextBox5.Size = New Size(100, 20)
        If SupplierNumber = 0 Then
            TextBox5.Text = "CATEGORY"
        Else
            TextBox5.Text = Suppliers(4 + 5 * (SupplierNumber - 1))
        End If
        TextBox5.ReadOnly = True
        TextBox5.Location = New Point(602, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox5)

    End Sub

    'Dynamically add th rows while displaying the staff
    Private Sub AddStaffsRows(ByVal Staff As ArrayList)
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(100, 20)
        Textbox1.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox1.Text = "FIRST NAME"
        Else
            Textbox1.Text = Staff(0 + 9 * (SupplierNumber - 1))
        End If
        Textbox1.Location = New Point(0, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox1)

        Dim Textbox2 As New TextBox
        Textbox2.Size = New Size(100, 20)
        Textbox2.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox2.Text = "MIDDLE NAME"
        Else
            Textbox2.Text = Staff(1 + 9 * (SupplierNumber - 1))
        End If
        Textbox2.Location = New Point(100, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox2)

        Dim TextBox3 As New TextBox
        TextBox3.Size = New Size(100, 20)
        TextBox3.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox3.Text = "SURNAME"
        Else
            TextBox3.Text = Staff(2 + 9 * (SupplierNumber - 1))
        End If
        TextBox3.Location = New Point(200, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(75, 20)
        TextBox4.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox4.Text = "ID"
        Else
            TextBox4.Text = Staff(3 + 9 * (SupplierNumber - 1))
        End If
        TextBox4.Location = New Point(300, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox4)

        Dim TextBox5 As New TextBox
        TextBox5.Size = New Size(25, 20)
        If SupplierNumber = 0 Then
            TextBox5.Text = "G"
        Else
            TextBox5.Text = Staff(4 + 9 * (SupplierNumber - 1))
        End If
        TextBox5.ReadOnly = True
        TextBox5.Location = New Point(375, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox5)

        Dim TextBox6 As New TextBox
        TextBox6.Size = New Size(100, 20)
        If SupplierNumber = 0 Then
            TextBox6.Text = "PHONE"
        Else
            TextBox6.Text = Staff(5 + 9 * (SupplierNumber - 1))
        End If
        TextBox6.ReadOnly = True
        TextBox6.Location = New Point(400, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox6)

        Dim TextBox7 As New TextBox
        TextBox7.Size = New Size(150, 20)
        If SupplierNumber = 0 Then
            TextBox7.Text = "EMAIL ADDRESS"
        Else
            TextBox7.Text = Staff(6 + 9 * (SupplierNumber - 1))
        End If
        TextBox7.ReadOnly = True
        TextBox7.Location = New Point(500, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox7)

        Dim TextBox8 As New TextBox
        TextBox8.Size = New Size(100, 20)
        If SupplierNumber = 0 Then
            TextBox8.Text = "USERNAME"
        Else
            TextBox8.Text = Staff(7 + 9 * (SupplierNumber - 1))
        End If
        TextBox8.ReadOnly = True
        TextBox8.Location = New Point(650, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox8)

        Dim TextBox9 As New TextBox
        TextBox9.Size = New Size(80, 20)
        If SupplierNumber = 0 Then
            TextBox9.Text = "WORKCLASS"
        Else
            TextBox9.Text = Staff(8 + 9 * (SupplierNumber - 1))
        End If
        TextBox9.ReadOnly = True
        TextBox9.Location = New Point(750, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox9)

    End Sub

    'Dynamically add the rows while displaying the products
    Private Sub AddProductsRows(ByVal Products As ArrayList)
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(100, 20)
        Textbox1.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox1.Text = "PRODUCT CODE"
        Else
            Textbox1.Text = Products(0 + 4 * (SupplierNumber - 1))
        End If
        Textbox1.Location = New Point(0, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox1)

        Dim Textbox2 As New TextBox
        Textbox2.Size = New Size(500, 20)
        Textbox2.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox2.Text = "PRODUCT DESCRIPTION"
        Else
            Textbox2.Text = Products(1 + 4 * (SupplierNumber - 1))
        End If
        Textbox2.Location = New Point(100, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox2)

        Dim TextBox3 As New TextBox
        TextBox3.Size = New Size(100, 20)
        TextBox3.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox3.Text = "PRICE"
        Else
            TextBox3.Text = Products(2 + 4 * (SupplierNumber - 1))
        End If
        TextBox3.Location = New Point(600, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(100, 20)
        TextBox4.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox4.Text = "QUANTITY"
        Else
            TextBox4.Text = Products(3 + 4 * (SupplierNumber - 1))
        End If
        TextBox4.Location = New Point(700, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox4)
    End Sub

    'Dynamically add the rows while displaying the invoices
    Private Sub AddInvoiceRows(ByVal Products As ArrayList)
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(30, 20)
        Textbox1.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox1.Text = "ID"
        Else
            Textbox1.Text = SupplierNumber
        End If
        Textbox1.Location = New Point(0, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox1)

        Dim Textbox2 As New TextBox
        Textbox2.Size = New Size(150, 20)
        Textbox2.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox2.Text = "TRANSACTION DATE"
        Else
            Textbox2.Text = Products(1 + 3 * (SupplierNumber - 1))
        End If
        Textbox2.Location = New Point(30, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox2)

        Dim Textbox3 As New TextBox
        Textbox3.Size = New Size(400, 20)
        Textbox3.ReadOnly = True
        Textbox3.Location = New Point(180, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(100, 20)
        TextBox4.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox4.Text = "TOTAL"
        Else
            TextBox4.Text = Products(2 + 3 * (SupplierNumber - 1))
        End If
        TextBox4.Location = New Point(580, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox4)
    End Sub

    'Close button handler
    Private Sub CloseReportButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseReportButton.Click
        Me.Close()
        Home_Page.Show()
    End Sub

    'Generate the invoices for the user for your transactions
    Public Sub GenerateInvoices()

        Dim Invoices As New ArrayList
        Invoices = DatabaseAccess.ShowTodayInvoices(Today.ToShortDateString())

        ReportTitleLabel.Text = "Report on all the Transactions for the System"
        While SupplierNumber <= Invoices.Count / 3
            AddInvoiceRows(Invoices)
            SupplierNumber += 1
        End While
    End Sub

    'Funtion call to generate the receipt for the customer after the transaction 
    Public Sub GenerateReceipt(ByVal Receipt As ArrayList, ByVal Total As Double)
        ReportTitleLabel.Text = "Receipt for the Transaction"
        While SupplierNumber <= Receipt.Count / 5
            AddReceiptRows(Receipt)
            SupplierNumber += 1
        End While
        AddTotal(Total)
    End Sub

    'Generate the rows for the recipt 
    Public Sub AddReceiptRows(ByVal Receipt As ArrayList)
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(25, 20)
        Textbox1.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox1.Text = "#"
        Else
            Textbox1.Text = SupplierNumber
        End If
        Textbox1.Location = New Point(0, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox1)

        Dim Textbox2 As New TextBox
        Textbox2.Size = New Size(130, 20)
        Textbox2.ReadOnly = True
        If SupplierNumber = 0 Then
            Textbox2.Text = "PRODUCT CODE"
        Else
            Textbox2.Text = Receipt(0 + 5 * (SupplierNumber - 1))
        End If
        Textbox2.Location = New Point(25, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(Textbox2)

        Dim TextBox3 As New TextBox
        TextBox3.Size = New Size(300, 20)
        TextBox3.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox3.Text = "DESCRIPTION"
        Else
            TextBox3.Text = Receipt(1 + 5 * (SupplierNumber - 1))
        End If
        TextBox3.Location = New Point(155, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(100, 20)
        TextBox4.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox4.Text = "QUANTITY"
        Else
            TextBox4.Text = Receipt(2 + 5 * (SupplierNumber - 1))
        End If
        TextBox4.Location = New Point(455, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox4)

        Dim TextBox5 As New TextBox
        TextBox5.Size = New Size(100, 20)
        TextBox5.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox5.Text = "PRICE"
        Else
            TextBox5.Text = Receipt(3 + 5 * (SupplierNumber - 1))
        End If
        TextBox5.Location = New Point(555, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox5)

        Dim TextBox6 As New TextBox
        TextBox6.Size = New Size(100, 20)
        TextBox6.ReadOnly = True
        If SupplierNumber = 0 Then
            TextBox6.Text = "TOTAL"
        Else
            TextBox6.Text = Receipt(4 + 5 * (SupplierNumber - 1))
        End If
        TextBox6.Location = New Point(655, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox6)
    End Sub

    'Add the total textbox on the receipt page
    Public Sub AddTotal(Total)
        Dim TextBox5 As New TextBox
        TextBox5.Size = New Size(100, 20)
        TextBox5.ReadOnly = True
        TextBox5.Text = "TOTAL"
        TextBox5.Location = New Point(555, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox5)

        Dim TextBox6 As New TextBox
        TextBox6.Size = New Size(100, 20)
        TextBox6.ReadOnly = True
        TextBox6.Text = Total
        TextBox6.Location = New Point(655, 0 + (20 * SupplierNumber))
        ReportPanel.Controls.Add(TextBox6)

    End Sub
End Class