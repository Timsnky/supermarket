<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Page
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
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchFieldComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchDetailTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchResultsPanel = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StaffSearchRadioButton = New System.Windows.Forms.RadioButton()
        Me.SupplierSearchRadioButton = New System.Windows.Forms.RadioButton()
        Me.ProductSearchRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(252, 203)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchFieldComboBox
        '
        Me.SearchFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchFieldComboBox.FormattingEnabled = True
        Me.SearchFieldComboBox.Location = New System.Drawing.Point(417, 164)
        Me.SearchFieldComboBox.Name = "SearchFieldComboBox"
        Me.SearchFieldComboBox.Size = New System.Drawing.Size(170, 21)
        Me.SearchFieldComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Search Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search Field"
        '
        'SearchDetailTextBox
        '
        Me.SearchDetailTextBox.Location = New System.Drawing.Point(117, 164)
        Me.SearchDetailTextBox.Name = "SearchDetailTextBox"
        Me.SearchDetailTextBox.Size = New System.Drawing.Size(193, 20)
        Me.SearchDetailTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search Results"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search for Record in the System"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProductSearchRadioButton)
        Me.GroupBox1.Controls.Add(Me.SupplierSearchRadioButton)
        Me.GroupBox1.Controls.Add(Me.StaffSearchRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 63)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Category"
        '
        'SearchResultsPanel
        '
        Me.SearchResultsPanel.AutoScroll = True
        Me.SearchResultsPanel.Location = New System.Drawing.Point(12, 258)
        Me.SearchResultsPanel.Name = "SearchResultsPanel"
        Me.SearchResultsPanel.Size = New System.Drawing.Size(615, 212)
        Me.SearchResultsPanel.TabIndex = 9
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(252, 537)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StaffSearchRadioButton
        '
        Me.StaffSearchRadioButton.AutoSize = True
        Me.StaffSearchRadioButton.Location = New System.Drawing.Point(34, 24)
        Me.StaffSearchRadioButton.Name = "StaffSearchRadioButton"
        Me.StaffSearchRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.StaffSearchRadioButton.TabIndex = 0
        Me.StaffSearchRadioButton.TabStop = True
        Me.StaffSearchRadioButton.Text = "Staff Search"
        Me.StaffSearchRadioButton.UseVisualStyleBackColor = True
        '
        'SupplierSearchRadioButton
        '
        Me.SupplierSearchRadioButton.AutoSize = True
        Me.SupplierSearchRadioButton.Location = New System.Drawing.Point(215, 24)
        Me.SupplierSearchRadioButton.Name = "SupplierSearchRadioButton"
        Me.SupplierSearchRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.SupplierSearchRadioButton.TabIndex = 2
        Me.SupplierSearchRadioButton.TabStop = True
        Me.SupplierSearchRadioButton.Text = "Supplier Search"
        Me.SupplierSearchRadioButton.UseVisualStyleBackColor = True
        '
        'ProductSearchRadioButton
        '
        Me.ProductSearchRadioButton.AutoSize = True
        Me.ProductSearchRadioButton.Location = New System.Drawing.Point(415, 24)
        Me.ProductSearchRadioButton.Name = "ProductSearchRadioButton"
        Me.ProductSearchRadioButton.Size = New System.Drawing.Size(99, 17)
        Me.ProductSearchRadioButton.TabIndex = 3
        Me.ProductSearchRadioButton.TabStop = True
        Me.ProductSearchRadioButton.Text = "Product Search"
        Me.ProductSearchRadioButton.UseVisualStyleBackColor = True
        '
        'Search_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 581)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SearchResultsPanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SearchDetailTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchFieldComboBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Name = "Search_Page"
        Me.Text = "Search Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents SearchFieldComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchDetailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SupplierSearchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StaffSearchRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SearchResultsPanel As System.Windows.Forms.Panel
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ProductSearchRadioButton As System.Windows.Forms.RadioButton
End Class
