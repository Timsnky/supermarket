<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.WelcomeTextBox = New System.Windows.Forms.TextBox()
        Me.WorkClassTextBox = New System.Windows.Forms.TextBox()
        Me.JobDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.EditToolStripMenuItem, Me.TransactionsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SearchToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(692, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewUserToolStripMenuItem.Text = "Staff"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserDetailsToolStripMenuItem, Me.SupplierDetailsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UserDetailsToolStripMenuItem
        '
        Me.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem"
        Me.UserDetailsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UserDetailsToolStripMenuItem.Text = "General Details"
        '
        'SupplierDetailsToolStripMenuItem
        '
        Me.SupplierDetailsToolStripMenuItem.Name = "SupplierDetailsToolStripMenuItem"
        Me.SupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SupplierDetailsToolStripMenuItem.Text = "SuperUser Actions"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagerToolStripMenuItem, Me.InventoryReorderToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'ManagerToolStripMenuItem
        '
        Me.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem"
        Me.ManagerToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ManagerToolStripMenuItem.Text = "Invoicing"
        '
        'InventoryReorderToolStripMenuItem
        '
        Me.InventoryReorderToolStripMenuItem.Name = "InventoryReorderToolStripMenuItem"
        Me.InventoryReorderToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.InventoryReorderToolStripMenuItem.Text = "Inventory Reorder"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceTransactionsToolStripMenuItem, Me.GoodsToolStripMenuItem, Me.SystemUsersToolStripMenuItem, Me.SuppliersToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'InvoiceTransactionsToolStripMenuItem
        '
        Me.InvoiceTransactionsToolStripMenuItem.Name = "InvoiceTransactionsToolStripMenuItem"
        Me.InvoiceTransactionsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.InvoiceTransactionsToolStripMenuItem.Text = "Invoice Transactions"
        '
        'GoodsToolStripMenuItem
        '
        Me.GoodsToolStripMenuItem.Name = "GoodsToolStripMenuItem"
        Me.GoodsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.GoodsToolStripMenuItem.Text = "Goods"
        '
        'SystemUsersToolStripMenuItem
        '
        Me.SystemUsersToolStripMenuItem.Name = "SystemUsersToolStripMenuItem"
        Me.SystemUsersToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SystemUsersToolStripMenuItem.Text = "System Users"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.SearchSupplierToolStripMenuItem, Me.SearchProductsToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UserToolStripMenuItem.Text = "Search User"
        '
        'SearchSupplierToolStripMenuItem
        '
        Me.SearchSupplierToolStripMenuItem.Name = "SearchSupplierToolStripMenuItem"
        Me.SearchSupplierToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SearchSupplierToolStripMenuItem.Text = "Search Supplier"
        '
        'SearchProductsToolStripMenuItem
        '
        Me.SearchProductsToolStripMenuItem.Name = "SearchProductsToolStripMenuItem"
        Me.SearchProductsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SearchProductsToolStripMenuItem.Text = "Search Products"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DateMaskedTextBox
        '
        Me.DateMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateMaskedTextBox.Location = New System.Drawing.Point(503, 39)
        Me.DateMaskedTextBox.Name = "DateMaskedTextBox"
        Me.DateMaskedTextBox.ReadOnly = True
        Me.DateMaskedTextBox.Size = New System.Drawing.Size(177, 13)
        Me.DateMaskedTextBox.TabIndex = 1
        Me.DateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'WelcomeTextBox
        '
        Me.WelcomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WelcomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeTextBox.Location = New System.Drawing.Point(12, 39)
        Me.WelcomeTextBox.Name = "WelcomeTextBox"
        Me.WelcomeTextBox.ReadOnly = True
        Me.WelcomeTextBox.Size = New System.Drawing.Size(159, 13)
        Me.WelcomeTextBox.TabIndex = 2
        '
        'WorkClassTextBox
        '
        Me.WorkClassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorkClassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkClassTextBox.Location = New System.Drawing.Point(12, 76)
        Me.WorkClassTextBox.Name = "WorkClassTextBox"
        Me.WorkClassTextBox.ReadOnly = True
        Me.WorkClassTextBox.Size = New System.Drawing.Size(159, 13)
        Me.WorkClassTextBox.TabIndex = 3
        '
        'JobDescriptionTextBox
        '
        Me.JobDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.JobDescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobDescriptionTextBox.Location = New System.Drawing.Point(12, 104)
        Me.JobDescriptionTextBox.Name = "JobDescriptionTextBox"
        Me.JobDescriptionTextBox.ReadOnly = True
        Me.JobDescriptionTextBox.Size = New System.Drawing.Size(215, 13)
        Me.JobDescriptionTextBox.TabIndex = 4
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColorToolStripMenuItem.Text = "Color..."
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 462)
        Me.Controls.Add(Me.JobDescriptionTextBox)
        Me.Controls.Add(Me.WorkClassTextBox)
        Me.Controls.Add(Me.WelcomeTextBox)
        Me.Controls.Add(Me.DateMaskedTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home_Page"
        Me.Text = "Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceTransactionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoodsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents WelcomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JobDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryReorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
