Public Class Home_Page
    Public FirstName As String
    Public UserName As String
    'Registration Staff Menu
    Private Sub NewUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewUserToolStripMenuItem.Click
        User_Registration.Show()
        Me.Hide()
    End Sub

    'Registration Supplier Menu
    Private Sub SupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier_Registration.Show()
        Me.Hide()
    End Sub

    'Edit General Details Menu
    Private Sub UserDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserDetailsToolStripMenuItem.Click
        Edit_Page.Show()
        Me.Hide()
    End Sub

    'Edit Super User Edits Menu
    Private Sub SupplierDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierDetailsToolStripMenuItem.Click
        SuperUser_Edit.Show()
        Me.Hide()
    End Sub

    'Transactions Invoicing Menu
    Private Sub ManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManagerToolStripMenuItem.Click
        Invoicing.Show()
        Me.Hide()
    End Sub

    'Reports Users Menu
    Private Sub SystemUsersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SystemUsersToolStripMenuItem.Click
        Reports.Show()
        Me.Hide()
        Reports.GenerateStaffReport()
    End Sub

    'Reports Goods Menu
    Private Sub GoodsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoodsToolStripMenuItem.Click
        Reports.Show()
        Me.Hide()
        Reports.GenerateProductsReport()
    End Sub

    'Reports Suppliers Menu
    Private Sub SuppliersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Reports.Show()
        Me.Hide()
        Reports.GenerateSuppliersReport()
    End Sub

    'Reports Invoices Menu
    Private Sub InvoiceTransactionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoiceTransactionsToolStripMenuItem.Click
        Reports.Show()
        Reports.GenerateInvoices()
        Me.Hide()
    End Sub

    'Search User Menu
    Private Sub UserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UserToolStripMenuItem.Click
        Search_Page.StaffSearchRadioButton.Checked = True
        Search_Page.Show()
        Me.Hide()
    End Sub

    'Search Supplier Menu
    Private Sub SearchSupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchSupplierToolStripMenuItem.Click
        Search_Page.SupplierSearchRadioButton.Checked = True
        Search_Page.Show()
        Me.Hide()
    End Sub

    'Search Products Menu
    Private Sub SearchProductsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchProductsToolStripMenuItem.Click
        Search_Page.ProductSearchRadioButton.Checked = True
        Search_Page.Show()
        Me.Hide()
    End Sub

    'Logout Menu
    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginPage.Show()
        LoginPage.UserNameTextBox.Clear()
        LoginPage.PasswordTextBox.Clear()
    End Sub

    Private Sub InventoryReorderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventoryReorderToolStripMenuItem.Click
        Me.Close()
        Inventory.Show()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem.Click

    End Sub
End Class