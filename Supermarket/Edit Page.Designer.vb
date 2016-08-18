<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Page
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
        Me.OldDetailTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditItemComboBox = New System.Windows.Forms.ComboBox()
        Me.NewDetailTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.EditSearchButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EditSearchFieldComboBox = New System.Windows.Forms.ComboBox()
        Me.EditSearchDetailTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SearchCategoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.SupplierSearchRadioButton = New System.Windows.Forms.RadioButton()
        Me.StaffSearchRadioButton = New System.Windows.Forms.RadioButton()
        Me.NewValuesGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchResultsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SearchCategoryGroupBox.SuspendLayout()
        Me.NewValuesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Field you wish to Edit"
        '
        'OldDetailTextBox
        '
        Me.OldDetailTextBox.Location = New System.Drawing.Point(172, 60)
        Me.OldDetailTextBox.Name = "OldDetailTextBox"
        Me.OldDetailTextBox.ReadOnly = True
        Me.OldDetailTextBox.Size = New System.Drawing.Size(150, 20)
        Me.OldDetailTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Old Detail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "New Detail"
        '
        'EditItemComboBox
        '
        Me.EditItemComboBox.FormattingEnabled = True
        Me.EditItemComboBox.Location = New System.Drawing.Point(278, 195)
        Me.EditItemComboBox.Name = "EditItemComboBox"
        Me.EditItemComboBox.Size = New System.Drawing.Size(155, 21)
        Me.EditItemComboBox.TabIndex = 5
        '
        'NewDetailTextBox
        '
        Me.NewDetailTextBox.Location = New System.Drawing.Point(172, 96)
        Me.NewDetailTextBox.Name = "NewDetailTextBox"
        Me.NewDetailTextBox.Size = New System.Drawing.Size(150, 20)
        Me.NewDetailTextBox.TabIndex = 6
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(150, 538)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 7
        Me.EditSaveButton.Text = "Save Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'EditSearchButton
        '
        Me.EditSearchButton.Location = New System.Drawing.Point(213, 230)
        Me.EditSearchButton.Name = "EditSearchButton"
        Me.EditSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSearchButton.TabIndex = 9
        Me.EditSearchButton.Text = "Edit Search"
        Me.EditSearchButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Enter Search Detail"
        '
        'EditSearchFieldComboBox
        '
        Me.EditSearchFieldComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.EditSearchFieldComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EditSearchFieldComboBox.FormattingEnabled = True
        Me.EditSearchFieldComboBox.Location = New System.Drawing.Point(371, 151)
        Me.EditSearchFieldComboBox.Name = "EditSearchFieldComboBox"
        Me.EditSearchFieldComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EditSearchFieldComboBox.TabIndex = 11
        '
        'EditSearchDetailTextBox
        '
        Me.EditSearchDetailTextBox.Location = New System.Drawing.Point(117, 151)
        Me.EditSearchDetailTextBox.Name = "EditSearchDetailTextBox"
        Me.EditSearchDetailTextBox.Size = New System.Drawing.Size(135, 20)
        Me.EditSearchDetailTextBox.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(289, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Search Field"
        '
        'SearchCategoryGroupBox
        '
        Me.SearchCategoryGroupBox.Controls.Add(Me.SupplierSearchRadioButton)
        Me.SearchCategoryGroupBox.Controls.Add(Me.StaffSearchRadioButton)
        Me.SearchCategoryGroupBox.Location = New System.Drawing.Point(15, 85)
        Me.SearchCategoryGroupBox.Name = "SearchCategoryGroupBox"
        Me.SearchCategoryGroupBox.Size = New System.Drawing.Size(519, 44)
        Me.SearchCategoryGroupBox.TabIndex = 15
        Me.SearchCategoryGroupBox.TabStop = False
        Me.SearchCategoryGroupBox.Text = "Search Category"
        '
        'SupplierSearchRadioButton
        '
        Me.SupplierSearchRadioButton.AutoSize = True
        Me.SupplierSearchRadioButton.Location = New System.Drawing.Point(263, 16)
        Me.SupplierSearchRadioButton.Name = "SupplierSearchRadioButton"
        Me.SupplierSearchRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.SupplierSearchRadioButton.TabIndex = 1
        Me.SupplierSearchRadioButton.TabStop = True
        Me.SupplierSearchRadioButton.Text = "Supplier Search"
        Me.SupplierSearchRadioButton.UseVisualStyleBackColor = True
        '
        'StaffSearchRadioButton
        '
        Me.StaffSearchRadioButton.AutoSize = True
        Me.StaffSearchRadioButton.Location = New System.Drawing.Point(126, 16)
        Me.StaffSearchRadioButton.Name = "StaffSearchRadioButton"
        Me.StaffSearchRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.StaffSearchRadioButton.TabIndex = 0
        Me.StaffSearchRadioButton.TabStop = True
        Me.StaffSearchRadioButton.Text = "Staff Search"
        Me.StaffSearchRadioButton.UseVisualStyleBackColor = True
        '
        'NewValuesGroupBox
        '
        Me.NewValuesGroupBox.Controls.Add(Me.Label2)
        Me.NewValuesGroupBox.Controls.Add(Me.OldDetailTextBox)
        Me.NewValuesGroupBox.Controls.Add(Me.Label3)
        Me.NewValuesGroupBox.Controls.Add(Me.NewDetailTextBox)
        Me.NewValuesGroupBox.Location = New System.Drawing.Point(15, 391)
        Me.NewValuesGroupBox.Name = "NewValuesGroupBox"
        Me.NewValuesGroupBox.Size = New System.Drawing.Size(519, 130)
        Me.NewValuesGroupBox.TabIndex = 16
        Me.NewValuesGroupBox.TabStop = False
        Me.NewValuesGroupBox.Text = "Input New Values"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(379, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Edit the Details of Existing Staff Members or Suppliers"
        '
        'SearchResultsGroupBox
        '
        Me.SearchResultsGroupBox.Location = New System.Drawing.Point(15, 259)
        Me.SearchResultsGroupBox.Name = "SearchResultsGroupBox"
        Me.SearchResultsGroupBox.Size = New System.Drawing.Size(519, 168)
        Me.SearchResultsGroupBox.TabIndex = 18
        Me.SearchResultsGroupBox.TabStop = False
        Me.SearchResultsGroupBox.Text = "Search Results"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(313, 538)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Edit_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 573)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EditItemComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchResultsGroupBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NewValuesGroupBox)
        Me.Controls.Add(Me.SearchCategoryGroupBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EditSearchDetailTextBox)
        Me.Controls.Add(Me.EditSearchFieldComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EditSearchButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Name = "Edit_Page"
        Me.Text = "Edit Page"
        Me.SearchCategoryGroupBox.ResumeLayout(False)
        Me.SearchCategoryGroupBox.PerformLayout()
        Me.NewValuesGroupBox.ResumeLayout(False)
        Me.NewValuesGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OldDetailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EditItemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NewDetailTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EditSaveButton As System.Windows.Forms.Button
    Friend WithEvents EditSearchButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EditSearchFieldComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditSearchDetailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SearchCategoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SupplierSearchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StaffSearchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NewValuesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SearchResultsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
