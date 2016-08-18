<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier_Registration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PhoneNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierSubmitButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SupplierCodeTextBox = New System.Windows.Forms.TextBox()
        Me.GeneralDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContactDetailsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SupplierCategoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.ToysCheckBox = New System.Windows.Forms.CheckBox()
        Me.StationeryCheckBox = New System.Windows.Forms.CheckBox()
        Me.NonAlcoholicCheckBox = New System.Windows.Forms.CheckBox()
        Me.LaundryCheckBox = New System.Windows.Forms.CheckBox()
        Me.InteriorCheckBox = New System.Windows.Forms.CheckBox()
        Me.HouseholdCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroceriesCheckBox = New System.Windows.Forms.CheckBox()
        Me.ElectronicsCheckBox = New System.Windows.Forms.CheckBox()
        Me.DairyCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClothingCheckBox = New System.Windows.Forms.CheckBox()
        Me.BakeryCheckBox = New System.Windows.Forms.CheckBox()
        Me.AlcoholicCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GeneralDetailsGroupBox.SuspendLayout()
        Me.ContactDetailsGroupBox.SuspendLayout()
        Me.SupplierCategoryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register a New Suppler into the System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier Name"
        '
        'SupplierNameTextBox
        '
        Me.SupplierNameTextBox.Location = New System.Drawing.Point(99, 24)
        Me.SupplierNameTextBox.Name = "SupplierNameTextBox"
        Me.SupplierNameTextBox.Size = New System.Drawing.Size(280, 20)
        Me.SupplierNameTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Supplier Code"
        '
        'PhoneNumberMaskedTextBox
        '
        Me.PhoneNumberMaskedTextBox.Location = New System.Drawing.Point(99, 22)
        Me.PhoneNumberMaskedTextBox.Mask = "0000000000"
        Me.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox"
        Me.PhoneNumberMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberMaskedTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Phone Number"
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(352, 22)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(228, 20)
        Me.EmailAddressTextBox.TabIndex = 6
        '
        'SupplierSubmitButton
        '
        Me.SupplierSubmitButton.Location = New System.Drawing.Point(151, 447)
        Me.SupplierSubmitButton.Name = "SupplierSubmitButton"
        Me.SupplierSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SupplierSubmitButton.TabIndex = 7
        Me.SupplierSubmitButton.Text = "Submit"
        Me.SupplierSubmitButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email Address"
        '
        'SupplierCodeTextBox
        '
        Me.SupplierCodeTextBox.Location = New System.Drawing.Point(480, 24)
        Me.SupplierCodeTextBox.Name = "SupplierCodeTextBox"
        Me.SupplierCodeTextBox.ReadOnly = True
        Me.SupplierCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SupplierCodeTextBox.TabIndex = 9
        '
        'GeneralDetailsGroupBox
        '
        Me.GeneralDetailsGroupBox.Controls.Add(Me.Label2)
        Me.GeneralDetailsGroupBox.Controls.Add(Me.SupplierNameTextBox)
        Me.GeneralDetailsGroupBox.Controls.Add(Me.SupplierCodeTextBox)
        Me.GeneralDetailsGroupBox.Controls.Add(Me.Label3)
        Me.GeneralDetailsGroupBox.Location = New System.Drawing.Point(12, 76)
        Me.GeneralDetailsGroupBox.Name = "GeneralDetailsGroupBox"
        Me.GeneralDetailsGroupBox.Size = New System.Drawing.Size(586, 75)
        Me.GeneralDetailsGroupBox.TabIndex = 10
        Me.GeneralDetailsGroupBox.TabStop = False
        Me.GeneralDetailsGroupBox.Text = "General Details"
        '
        'ContactDetailsGroupBox
        '
        Me.ContactDetailsGroupBox.Controls.Add(Me.PhoneNumberMaskedTextBox)
        Me.ContactDetailsGroupBox.Controls.Add(Me.Label4)
        Me.ContactDetailsGroupBox.Controls.Add(Me.Label5)
        Me.ContactDetailsGroupBox.Controls.Add(Me.EmailAddressTextBox)
        Me.ContactDetailsGroupBox.Location = New System.Drawing.Point(12, 157)
        Me.ContactDetailsGroupBox.Name = "ContactDetailsGroupBox"
        Me.ContactDetailsGroupBox.Size = New System.Drawing.Size(586, 68)
        Me.ContactDetailsGroupBox.TabIndex = 0
        Me.ContactDetailsGroupBox.TabStop = False
        Me.ContactDetailsGroupBox.Text = "Contact Details"
        '
        'SupplierCategoryGroupBox
        '
        Me.SupplierCategoryGroupBox.Controls.Add(Me.ToysCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.StationeryCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.NonAlcoholicCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.LaundryCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.InteriorCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.HouseholdCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.GroceriesCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.ElectronicsCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.DairyCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.ClothingCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.BakeryCheckBox)
        Me.SupplierCategoryGroupBox.Controls.Add(Me.AlcoholicCheckBox)
        Me.SupplierCategoryGroupBox.Location = New System.Drawing.Point(12, 231)
        Me.SupplierCategoryGroupBox.Name = "SupplierCategoryGroupBox"
        Me.SupplierCategoryGroupBox.Size = New System.Drawing.Size(586, 191)
        Me.SupplierCategoryGroupBox.TabIndex = 11
        Me.SupplierCategoryGroupBox.TabStop = False
        Me.SupplierCategoryGroupBox.Text = "Supplier Category"
        '
        'ToysCheckBox
        '
        Me.ToysCheckBox.AutoSize = True
        Me.ToysCheckBox.Location = New System.Drawing.Point(416, 149)
        Me.ToysCheckBox.Name = "ToysCheckBox"
        Me.ToysCheckBox.Size = New System.Drawing.Size(49, 17)
        Me.ToysCheckBox.TabIndex = 11
        Me.ToysCheckBox.Text = "Toys"
        Me.ToysCheckBox.UseVisualStyleBackColor = True
        '
        'StationeryCheckBox
        '
        Me.StationeryCheckBox.AutoSize = True
        Me.StationeryCheckBox.Location = New System.Drawing.Point(416, 110)
        Me.StationeryCheckBox.Name = "StationeryCheckBox"
        Me.StationeryCheckBox.Size = New System.Drawing.Size(73, 17)
        Me.StationeryCheckBox.TabIndex = 10
        Me.StationeryCheckBox.Text = "Stationery"
        Me.StationeryCheckBox.UseVisualStyleBackColor = True
        '
        'NonAlcoholicCheckBox
        '
        Me.NonAlcoholicCheckBox.AutoSize = True
        Me.NonAlcoholicCheckBox.Location = New System.Drawing.Point(416, 71)
        Me.NonAlcoholicCheckBox.Name = "NonAlcoholicCheckBox"
        Me.NonAlcoholicCheckBox.Size = New System.Drawing.Size(146, 17)
        Me.NonAlcoholicCheckBox.TabIndex = 9
        Me.NonAlcoholicCheckBox.Text = "Non Alcoholic Beverages"
        Me.NonAlcoholicCheckBox.UseVisualStyleBackColor = True
        '
        'LaundryCheckBox
        '
        Me.LaundryCheckBox.AutoSize = True
        Me.LaundryCheckBox.Location = New System.Drawing.Point(416, 32)
        Me.LaundryCheckBox.Name = "LaundryCheckBox"
        Me.LaundryCheckBox.Size = New System.Drawing.Size(109, 17)
        Me.LaundryCheckBox.TabIndex = 8
        Me.LaundryCheckBox.Text = "Laundry Products"
        Me.LaundryCheckBox.UseVisualStyleBackColor = True
        '
        'InteriorCheckBox
        '
        Me.InteriorCheckBox.AutoSize = True
        Me.InteriorCheckBox.Location = New System.Drawing.Point(230, 149)
        Me.InteriorCheckBox.Name = "InteriorCheckBox"
        Me.InteriorCheckBox.Size = New System.Drawing.Size(118, 17)
        Me.InteriorCheckBox.TabIndex = 7
        Me.InteriorCheckBox.Text = "Interior Decorations"
        Me.InteriorCheckBox.UseVisualStyleBackColor = True
        '
        'HouseholdCheckBox
        '
        Me.HouseholdCheckBox.AutoSize = True
        Me.HouseholdCheckBox.Location = New System.Drawing.Point(230, 110)
        Me.HouseholdCheckBox.Name = "HouseholdCheckBox"
        Me.HouseholdCheckBox.Size = New System.Drawing.Size(132, 17)
        Me.HouseholdCheckBox.TabIndex = 6
        Me.HouseholdCheckBox.Text = "Household Appliances"
        Me.HouseholdCheckBox.UseVisualStyleBackColor = True
        '
        'GroceriesCheckBox
        '
        Me.GroceriesCheckBox.AutoSize = True
        Me.GroceriesCheckBox.Location = New System.Drawing.Point(230, 71)
        Me.GroceriesCheckBox.Name = "GroceriesCheckBox"
        Me.GroceriesCheckBox.Size = New System.Drawing.Size(71, 17)
        Me.GroceriesCheckBox.TabIndex = 5
        Me.GroceriesCheckBox.Text = "Groceries"
        Me.GroceriesCheckBox.UseVisualStyleBackColor = True
        '
        'ElectronicsCheckBox
        '
        Me.ElectronicsCheckBox.AutoSize = True
        Me.ElectronicsCheckBox.Location = New System.Drawing.Point(230, 32)
        Me.ElectronicsCheckBox.Name = "ElectronicsCheckBox"
        Me.ElectronicsCheckBox.Size = New System.Drawing.Size(78, 17)
        Me.ElectronicsCheckBox.TabIndex = 4
        Me.ElectronicsCheckBox.Text = "Electronics"
        Me.ElectronicsCheckBox.UseVisualStyleBackColor = True
        '
        'DairyCheckBox
        '
        Me.DairyCheckBox.AutoSize = True
        Me.DairyCheckBox.Location = New System.Drawing.Point(20, 149)
        Me.DairyCheckBox.Name = "DairyCheckBox"
        Me.DairyCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.DairyCheckBox.TabIndex = 3
        Me.DairyCheckBox.Text = "Dairy Products"
        Me.DairyCheckBox.UseVisualStyleBackColor = True
        '
        'ClothingCheckBox
        '
        Me.ClothingCheckBox.AutoSize = True
        Me.ClothingCheckBox.Location = New System.Drawing.Point(20, 110)
        Me.ClothingCheckBox.Name = "ClothingCheckBox"
        Me.ClothingCheckBox.Size = New System.Drawing.Size(64, 17)
        Me.ClothingCheckBox.TabIndex = 2
        Me.ClothingCheckBox.Text = "Clothing"
        Me.ClothingCheckBox.UseVisualStyleBackColor = True
        '
        'BakeryCheckBox
        '
        Me.BakeryCheckBox.AutoSize = True
        Me.BakeryCheckBox.Location = New System.Drawing.Point(20, 71)
        Me.BakeryCheckBox.Name = "BakeryCheckBox"
        Me.BakeryCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.BakeryCheckBox.TabIndex = 1
        Me.BakeryCheckBox.Text = "Bakery Products"
        Me.BakeryCheckBox.UseVisualStyleBackColor = True
        '
        'AlcoholicCheckBox
        '
        Me.AlcoholicCheckBox.AutoSize = True
        Me.AlcoholicCheckBox.Location = New System.Drawing.Point(20, 32)
        Me.AlcoholicCheckBox.Name = "AlcoholicCheckBox"
        Me.AlcoholicCheckBox.Size = New System.Drawing.Size(123, 17)
        Me.AlcoholicCheckBox.TabIndex = 0
        Me.AlcoholicCheckBox.Text = "Alcoholic Beverages"
        Me.AlcoholicCheckBox.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(316, 447)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Supplier_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 482)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SupplierCategoryGroupBox)
        Me.Controls.Add(Me.ContactDetailsGroupBox)
        Me.Controls.Add(Me.GeneralDetailsGroupBox)
        Me.Controls.Add(Me.SupplierSubmitButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Supplier_Registration"
        Me.Text = "Supplier Registration"
        Me.GeneralDetailsGroupBox.ResumeLayout(False)
        Me.GeneralDetailsGroupBox.PerformLayout()
        Me.ContactDetailsGroupBox.ResumeLayout(False)
        Me.ContactDetailsGroupBox.PerformLayout()
        Me.SupplierCategoryGroupBox.ResumeLayout(False)
        Me.SupplierCategoryGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PhoneNumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierSubmitButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SupplierCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GeneralDetailsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ContactDetailsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SupplierCategoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ToysCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StationeryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NonAlcoholicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LaundryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InteriorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HouseholdCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroceriesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ElectronicsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DairyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClothingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BakeryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AlcoholicCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
