Public Class Inventory
    Private DatabaseAccess As New DBConnect
    Private SendingEmail As New Email
    Private InventoryNumber As Integer = 0
    Private Inventory As New ArrayList
    Private Email As New ArrayList
    'Generate a report of all the products in the system and display in report page
    Public Sub GenerateInventoryReport()
        Inventory = DatabaseAccess.ShowInventoryList()
        While InventoryNumber <= Inventory.Count / 5
            AddInventoryRows(Inventory)
            InventoryNumber += 1
        End While
    End Sub

    'Dynamically add the rows while displaying the products
    Private Sub AddInventoryRows(ByVal Products As ArrayList)
        Dim Textbox1 As New TextBox
        Textbox1.Size = New Size(20, 20)
        Textbox1.ReadOnly = True
        Textbox1.Text = InventoryNumber+1
        Textbox1.Location = New Point(0, 0 + (20 * InventoryNumber))
        InventoryPanel.Controls.Add(Textbox1)

        Dim Textbox2 As New TextBox
        Textbox2.Size = New Size(100, 20)
        Textbox2.ReadOnly = True
        Textbox2.Text = Products(0 + 4 * (InventoryNumber))
        Textbox2.Location = New Point(20, 0 + (20 * InventoryNumber))
        InventoryPanel.Controls.Add(Textbox2)

        Dim TextBox3 As New TextBox
        TextBox3.Size = New Size(250, 20)
        TextBox3.ReadOnly = True
        TextBox3.Text = Products(1 + 4 * (InventoryNumber))
        TextBox3.Location = New Point(120, 0 + (20 * InventoryNumber))
        InventoryPanel.Controls.Add(TextBox3)

        Dim TextBox4 As New TextBox
        TextBox4.Size = New Size(100, 20)
        TextBox4.ReadOnly = True
        TextBox4.Text = Products(2 + 4 * (InventoryNumber))
        TextBox4.Location = New Point(370, 0 + (20 * InventoryNumber))
        InventoryPanel.Controls.Add(TextBox4)

        Dim TextBox5 As New TextBox
        TextBox5.Size = New Size(100, 20)
        TextBox5.ReadOnly = True
        TextBox5.Text = Products(3 + 4 * (InventoryNumber))
        TextBox5.Location = New Point(470, 0 + (20 * InventoryNumber))
        InventoryPanel.Controls.Add(TextBox5)
    End Sub

    Private Sub Inventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenerateInventoryReport()
    End Sub

    Private Sub MakeReorderButton_Click(sender As System.Object, e As System.EventArgs) Handles MakeReorderButton.Click
        Dim Emaillist As Integer = 0
        Dim SupplierCodes As New ArrayList
        While Emaillist < Inventory.Count / 4
            SupplierCodes.Add(Inventory(3 + Emaillist * 4))
            Emaillist += 1
        End While
        Emaillist = 0
        Email = DatabaseAccess.GetEmailAddresses(SupplierCodes)
        While Emaillist < Inventory.Count / 4
            Dim Content As New ArrayList
            Content.Add(Email(Emaillist))
            Content.Add(Inventory(0 + 4 * (Emaillist)))
            Content.Add(Inventory(1 + 4 * (Emaillist)))
            Emaillist += 1
            SendingEmail.SendSupplierEmail(Content)
        End While
        MessageBox.Show(" Reorder Emails Sent to the Default Suppliers")
        Me.Close()
        Home_Page.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
        Home_Page.Hide()
    End Sub
End Class