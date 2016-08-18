Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.OleDb
Public Class DBConnect
    Private Connect = New OleDb.OleDbConnection
    Private Command As OleDbCommand
    Private ResultSet As OleDbDataReader
    Private Query As String

    ' The Constructor for the Database Connection Class
    Public Sub New()
        Try
            Connect.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Timsnky\Dropbox\Programming\Visual Basic Projects\Supermarket\SuperMarketAccessDB.mdb"
        Catch ex As Exception
        End Try
        OpenConnection()
    End Sub

    ' Simply Open the Connection to the Database
    Private Sub OpenConnection()
        Try
            Connect.Open()
        Catch ex As Exception
        End Try
    End Sub

    'Closing the Connection from the database
    Protected Overrides Sub Finalize()
        Connect.Close()
    End Sub

    ' Authentication of the User to Access System  Returns the WorkClass of the User
    Public Function LoginAuthentication(ByVal UserName As String, ByVal Password As String) As String
        Query = "Select * from Users where Username='" + UserName + "'"
        Dim Password1 As String
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows Then
            Do While ResultSet.Read()
                Password1 = ResultSet.GetString(ResultSet.GetOrdinal("AccessPassword"))
                If Password1 = Password Then
                    Return ResultSet.GetString(ResultSet.GetOrdinal("WorkClass"))
                Else
                    MessageBox.Show("Authentication Failed")
                    Return 0
                End If
            Loop
            Return 0
        Else
            MessageBox.Show(" Invalid User Name")
            Return 0
        End If
    End Function

    '' Function to open the home page after authentication is complete
    Public Sub OpenHomePage(ByVal UserName As String)
        Dim FirstName As String = ""
        Dim JobDescription As String = ""
        Dim WorkClass As Decimal = 0
        Dim Today As DateTime = Now
        Query = "Select FirstName, WorkClass from Staff_Details where UserName ='" + UserName + "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows Then
            Do While ResultSet.Read()
                FirstName = ResultSet.GetString(ResultSet.GetOrdinal("FirstName"))
                Console.WriteLine(FirstName)
                WorkClass = Decimal.Parse(ResultSet.GetString(ResultSet.GetOrdinal("WorkClass")))
                Console.WriteLine(WorkClass)
            Loop
        End If
        If WorkClass = 999 Then
            JobDescription = " Super User "
            Home_Page.TransactionsToolStripMenuItem.Enabled = False
        ElseIf WorkClass = 150 Then
            JobDescription = " Manager "
            Home_Page.NewUserToolStripMenuItem.Enabled = False
            Home_Page.SupplierDetailsToolStripMenuItem.Enabled = False
            Home_Page.ManagerToolStripMenuItem.Enabled = False
            Home_Page.SystemUsersToolStripMenuItem.Enabled = False
        ElseIf WorkClass = 60 Then
            JobDescription = " Cashier "
            Home_Page.SupplierToolStripMenuItem.Enabled = False
            Home_Page.SupplierDetailsToolStripMenuItem.Enabled = False
            Home_Page.SystemUsersToolStripMenuItem.Enabled = False
            Home_Page.UserDetailsToolStripMenuItem.Enabled = False
            Home_Page.SuppliersToolStripMenuItem.Enabled = False
            Home_Page.InventoryReorderToolStripMenuItem.Enabled = False
        Else
            JobDescription = " Invalid Work Class "
        End If
        Home_Page.Show()
        LoginPage.Hide()
        Home_Page.WelcomeTextBox.Text = "Welcome : " & FirstName
        Home_Page.FirstName = FirstName
        Home_Page.UserName = UserName
        Home_Page.DateMaskedTextBox.Text = Today.ToShortDateString
        Home_Page.WorkClassTextBox.Text = "Work Class : " & WorkClass
        Home_Page.JobDescriptionTextBox.Text = "Job Description : " & JobDescription
    End Sub

    ''Generate a User Name for a new User
    'Public Function GetStaffNumber() As String
    '    Dim IndexNumber As Decimal
    '    Query = "Select Max(StaffNumber) As StaffNumber from Users"
    '    Command = New OleDbCommand(Query, Connect)
    '    ResultSet = Command.ExecuteReader()
    '    ResultSet.Read()
    '    IndexNumber = Decimal.Parse(ResultSet.GetString(ResultSet.GetOrdinal("StaffNumber"))) + 1

    '    Console.WriteLine("Index  " & Index)
    '    Return Index
    'End Function

    ''Generate a Supplier Code for a new Supplier
    'Public Function GenerateSupplierCode() As String
    '    Dim Index As String = ""
    '    Dim IndexNumber As Decimal
    '    Query = "Select Max(SupplierNumber) As SupplierNumber from Suppliers_Details"
    '    Command = New OleDbCommand(Query, Connect)
    '    ResultSet = Command.ExecuteReader()
    '    ResultSet.Read()
    '    IndexNumber = Decimal.Parse(ResultSet.GetString(ResultSet.GetOrdinal("SupplierNumber"))) + 1
    '    Return IndexNumber
    'End Function

    ''Check if the given id number exists in the sysem
    Public Function ConfirmIDNumber(ByVal IDNumber As String) As Boolean
        Query = " Select IDNumber from Staff_Details where IDNumber='" + IDNumber + "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows Then
            ResultSet.Read()
            Return False
        Else
            Return True
        End If
    End Function

    ''Add data for a new user into the database
    Public Sub AddNewStaff(ByVal NewStaffData As ArrayList)
        Query = "Insert into Staff_Details (FirstName, MiddleName, SurName, IDNumber, Gender, PhoneNumber," _
                + " EmailAddress, UserName, WorkClass) Values ('" + NewStaffData(0) + "','" + NewStaffData(1) + "','" + NewStaffData(2) + "','" + NewStaffData(3) + "','" + NewStaffData(4) + "','" + NewStaffData(5) + "','" + NewStaffData(6) + "','" + NewStaffData(7) + "','" + NewStaffData(8) + "')"
        Command = New OleDbCommand(Query, Connect)
        Command.ExecuteNonQuery()
    End Sub

    ' Display the Data in the Users Table
    Public Sub ShowUsersTable()
        Query = "SELECT * from Users"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Console.Write(ResultSet.GetString(0) & ControlChars.Tab)
                Console.Write(ResultSet.GetString(1) & ControlChars.Tab)
                Console.Write(ResultSet.GetString(2) & ControlChars.Tab)
                Console.Write(ResultSet.GetString(3) & ControlChars.Tab & ControlChars.NewLine)
            Loop
        Else
            Console.WriteLine("No Data")
        End If
    End Sub

    'Display the Data in the Staff_Details Table
    Public Function ShowStaffDetailsTable() As ArrayList
        Dim Staff As New ArrayList
        Query = "SELECT * from Staff_Details"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Staff.Add(ResultSet.GetString(0))
                Staff.Add(ResultSet.GetString(1))
                Staff.Add(ResultSet.GetString(2))
                Staff.Add(ResultSet.GetString(3))
                Staff.Add(ResultSet.GetString(4))
                Staff.Add(ResultSet.GetString(5))
                Staff.Add(ResultSet.GetString(6))
                Staff.Add(ResultSet.GetString(7))
                Staff.Add(ResultSet.GetString(8))
            Loop
        Else
            Console.WriteLine("No Data")
        End If
        Return Staff
    End Function

    'Add a new user into the Users table
    Public Sub AddNewUser(ByVal NewUserData As ArrayList)
        Dim StaffNumber As String = GetStaffNumber().ToString
        Query = "INSERT INTO Users( StaffNumber, UserName, AccessPassword, WorkClass) VALUES ('" + StaffNumber + "','" + NewUserData(0) + "','1234Pass','" + NewUserData(1) + "')"
        'Query = "INSERT INTO Users( StaffNumber, UserName, AccessPassword, WorkClass) VALUES ('9','DD0009','1234Pass','150')"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

    'Get the highest staff number value + 1
    Public Function GetStaffNumber() As Decimal
        Dim StaffNumber As Decimal
        Query = "Select Max(StaffNumber) As StaffNumber from Users"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        ResultSet.Read()
        StaffNumber = Decimal.Parse(ResultSet.GetString(ResultSet.GetOrdinal("StaffNumber"))) + 1
        Return StaffNumber
    End Function

    'Get the highest staff number value + 1
    Public Function GetSupplierNumber() As Decimal
        Dim SupplierNumber As Decimal
        Query = "Select Max(SupplierNumber) As SupplierNumber from Suppliers_Details"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        ResultSet.Read()
        SupplierNumber = Decimal.Parse(ResultSet.GetString(ResultSet.GetOrdinal("SupplierNumber"))) + 1
        Return SupplierNumber
    End Function

    'Adding a new Supplier into the system
    Public Sub AddNewSupplier(ByVal NewSupplierData As ArrayList)
        Query = "Insert into Suppliers_Details (SupplierNumber, SupplierCode, SupplierName, PhoneNumber, EmailAddress, Categories" _
        + ") Values ('" + NewSupplierData(0) + "','" + NewSupplierData(1) + "','" + NewSupplierData(2) + "','" + NewSupplierData(3) + "','" + NewSupplierData(4) + "','" + NewSupplierData(5) + "')"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    'Display the data in the supplier details table
    Public Function ShowSupplierDetailsTable() As ArrayList
        Dim Suppliers As New ArrayList
        Query = "SELECT * from Suppliers_Details"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Suppliers.Add(ResultSet.GetString(1))
                Suppliers.Add(ResultSet.GetString(2))
                Suppliers.Add(ResultSet.GetString(3))
                Suppliers.Add(ResultSet.GetString(4))
                Suppliers.Add(ResultSet.GetString(5))
            Loop
        Else
            Console.WriteLine("No Data")
        End If
        Return Suppliers
    End Function

    'Display Data in Products Table
    Public Function ShowProductsTable() As ArrayList
        Dim Products As New ArrayList
        Query = "SELECT * from Products"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Products.Add(ResultSet.GetString(0))
                Products.Add(ResultSet.GetString(1))
                Products.Add(ResultSet.GetString(2))
                Products.Add(ResultSet.GetString(3))
            Loop
        Else
            Console.WriteLine("No Data")
        End If
        Return Products
    End Function

    'Search in the Stafff Details Table
    Public Function GetSearchedStaff(ByVal SearchDetail As String, ByVal SearchField As String) As ArrayList
        Dim SearchResults As New ArrayList
        Query = "Select FirstName, MiddleName, SurName, UserName from Staff_Details where " & SearchField & " = '" & SearchDetail & "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                SearchResults.Add(ResultSet.GetString(0) & " " & ResultSet.GetString(1) & " " & ResultSet.GetString(2) & ControlChars.Tab & ResultSet.GetString(3))
                Console.WriteLine("3")
            Loop
        Else
            MessageBox.Show(" No Staff Found by that detail")
            Edit_Page.EditSearchDetailTextBox.Clear()
            Edit_Page.EditSearchDetailTextBox.Focus()
        End If
        Return SearchResults
    End Function

    'Get the Old detail of the selected field that is to be edited
    Public Function GetStaffDetail(ByVal EditID As String, ByVal EditField As String) As String
        Query = " Select " & EditField & " from Staff_Details where UserName = '" & EditID & "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        ResultSet.Read()
        Return ResultSet.GetString(0)
    End Function

    'Update the new detail into the database
    Public Sub UpdateEdit(ByVal NewDetail As String, ByVal EditField As String, ByVal EditID As String)
        Query = "Update Staff_Details set " & EditField & "= '" & NewDetail & "' where UserName = '" & EditID & "'"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        ShowStaffDetailsTable()
    End Sub

    'Search in the Suppliers Details Table
    Public Function GetSearchedSupplier(ByVal SearchDetail As String, ByVal SearchField As String) As ArrayList
        Dim SearchResults As New ArrayList
        Query = "Select SupplierCode, SupplierName from Suppliers_Details where " & SearchField & " = '" & SearchDetail & "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                SearchResults.Add(ResultSet.GetString(1) & ControlChars.Tab & ResultSet.GetString(0))
            Loop
        Else
            MessageBox.Show(" No Record Found by that detail")
            Edit_Page.EditSearchDetailTextBox.Clear()
            Edit_Page.EditSearchDetailTextBox.Focus()
        End If
        Return SearchResults
    End Function

    'Get the Old detail of the selected field that is to be edited
    Public Function GetSupplierDetail(ByVal EditID As String, ByVal EditField As String) As String
        Query = " Select " & EditField & " from Suppliers_Details where SupplierCode = '" & EditID & "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        ResultSet.Read()
        Return ResultSet.GetString(0)
    End Function

    'Update the new detail into the database
    Public Sub UpdateSupplierEdit(ByVal NewDetail As String, ByVal EditField As String, ByVal EditID As String)
        Query = "Update Suppliers_Details set " & EditField & "= '" & NewDetail & "' where UserName = '" & EditID & "'"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        ShowStaffDetailsTable()
    End Sub

    'Get Product Codes
    Public Function GetProductCodes() As ArrayList
        Dim Products As New ArrayList
        Query = "Select ProductCode from Products"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Products.Add(ResultSet.GetString(0))
            Loop
        End If
        Return Products
    End Function

    'Get Product Descriptions
    Public Function GetProductDescriptions() As ArrayList
        Dim Products As New ArrayList
        Query = "Select ProductDescription from Products"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Products.Add(ResultSet.GetString(0))
            Loop
        End If
        Return Products
    End Function

    'Get Product Prices
    Public Function GetProductPrices() As ArrayList
        Dim Products As New ArrayList
        Query = "Select ProductPrice from Products"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Products.Add(ResultSet.GetString(0))
            Loop
        End If
        Return Products
    End Function

    'Update Inventory
    Public Sub UpdateInventory(ByVal Inventory As ArrayList)
        Dim Index As Integer = 0
        While Index < Inventory.Count / 2
            Console.WriteLine(Inventory(Index * 2 + 1))
            Console.WriteLine(Inventory(Index * 2))
            Query = "Update Products set Quantity = Quantity - " & Inventory(Index * 2 + 1) & " where ProductCode = '" & Inventory(Index * 2) & "'"
            Command = New OleDbCommand(Query, Connect)
            Try
                Command.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Index = Index + 1
        End While
    End Sub

    'Reset the Password of the User
    Public Function ResetPassword(ByVal UserName As String) As Integer
        Query = "Update Users set AccessPassword = '1234Pass' where UserName = '" & UserName & "'"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Change the WorkClass of the User
    Public Function EditWorkClass(ByVal UserName As String, ByVal NewWorkClass As String) As Integer
        Query = "Update Users set WorkClass = '" & NewWorkClass & "' where UserName = '" & UserName & "'"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Query = "Update Staff_Details set WorkClass = '" & NewWorkClass & "' where UserName = '" & UserName & "'"
        Command = New OleDbCommand(Query, Connect)
        Try
            Command.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Get firstname, middleame, surname and workclass
    Public Function GetSeearchedStaffDetails(ByVal UserName As String) As String
        Dim SearchResults As String = ""
        Query = "Select FirstName, MiddleName, SurName, WorkClass from Staff_Details where UserName = '" & UserName & "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                SearchResults &= (ResultSet.GetString(0) & " " & ResultSet.GetString(1) & " " & ResultSet.GetString(2) & ControlChars.Tab & ResultSet.GetString(3))
            Loop
        Else
            MessageBox.Show(" No Staff Found by that detail")
            SuperUser_Edit.UserNameTextBox.Clear()
            SuperUser_Edit.UserNameTextBox.Focus()
        End If
        Return SearchResults
    End Function

    Public Function GetSearchedProduct(ByVal ProductCode As String) As String
        Dim SearchResults As String = ""
        Query = "Select ProductDescription from Products where ProductCode = '" & ProductCode & "'"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                SearchResults &= (ProductCode & " " & ResultSet.GetString(0))
            Loop
        Else
            MessageBox.Show(" No Product Found by that detail")
            Search_Page.SearchDetailTextBox.Clear()
            Search_Page.SearchDetailTextBox.Focus()
        End If
        Return SearchResults
    End Function

    'Update the transactions table to add the invoice
    Public Sub UpdateInvoiceList(ByVal Total As Integer, ByVal TransDate As String)
        Query = "Insert into Invoices (TransactionDate, Total) VALUES ('" & TransDate & "','" & Total & "')"
        Command = New OleDbCommand(Query, Connect)
        Command.ExecuteNonQuery()
    End Sub

    'Generate a a report for the days invoices
    Public Function ShowTodayInvoices(ByVal TransDate As String) As ArrayList
        Dim Invoice As New ArrayList
        Query = "SELECT * from Invoices"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Console.Write(ResultSet.GetInt32(0) & ControlChars.Tab)
                Invoice.Add(ResultSet.GetInt32(0).ToString)
                Console.Write(ResultSet.GetString(1) & ControlChars.Tab)
                Invoice.Add(ResultSet.GetString(1))
                Console.Write(ResultSet.GetString(2) & ControlChars.Tab & ControlChars.NewLine)
                Invoice.Add(ResultSet.GetString(2))
            Loop
        Else
            Console.WriteLine("No Data")
        End If
        Return Invoice
    End Function

    Public Function ShowInventoryList() As ArrayList
        Dim Inventory As New ArrayList
        Query = "Select ProductCode, ProductDescription, Quantity, Supplier from Products"
        Command = New OleDbCommand(Query, Connect)
        ResultSet = Command.ExecuteReader()
        If ResultSet.HasRows() Then
            Do While ResultSet.Read()
                Dim Quantity As Integer
                Quantity = Integer.Parse(ResultSet.GetString(2), Globalization.NumberStyles.Integer)
                If Quantity < 10 Then
                    Inventory.Add(ResultSet.GetString(0))
                    Console.WriteLine(ResultSet.GetString(0))
                    Inventory.Add(ResultSet.GetString(1))
                    Console.WriteLine(ResultSet.GetString(1))
                    Inventory.Add(ResultSet.GetString(2))
                    Console.WriteLine(ResultSet.GetString(2))
                    Inventory.Add(ResultSet.GetString(3))
                    Console.WriteLine(ResultSet.GetString(3))
                End If
            Loop
        End If
        Return Inventory
    End Function

    Public Function GetEmailAddresses(ByVal SupplerCodes As ArrayList) As ArrayList
        Dim Email As New ArrayList
        Dim Supplier As Integer = 0
        While Supplier < SupplerCodes.Count
            Query = "Select EmailAddress from Suppliers_Details where SupplierCode = '" & SupplerCodes(Supplier) & "'"
            Command = New OleDbCommand(Query, Connect)
            ResultSet = Command.ExecuteReader()
            ResultSet.Read()
            Email.Add(ResultSet.GetString(0))
            Supplier += 1
        End While
        Return Email
    End Function
End Class
