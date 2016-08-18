<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.ReportTitleLabel = New System.Windows.Forms.Label()
        Me.ReportPanel = New System.Windows.Forms.Panel()
        Me.CloseReportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportTitleLabel
        '
        Me.ReportTitleLabel.AutoSize = True
        Me.ReportTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTitleLabel.Location = New System.Drawing.Point(12, 31)
        Me.ReportTitleLabel.Name = "ReportTitleLabel"
        Me.ReportTitleLabel.Size = New System.Drawing.Size(0, 16)
        Me.ReportTitleLabel.TabIndex = 0
        '
        'ReportPanel
        '
        Me.ReportPanel.AutoScroll = True
        Me.ReportPanel.Location = New System.Drawing.Point(12, 67)
        Me.ReportPanel.Name = "ReportPanel"
        Me.ReportPanel.Size = New System.Drawing.Size(832, 456)
        Me.ReportPanel.TabIndex = 1
        '
        'CloseReportButton
        '
        Me.CloseReportButton.Location = New System.Drawing.Point(389, 540)
        Me.CloseReportButton.Name = "CloseReportButton"
        Me.CloseReportButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseReportButton.TabIndex = 0
        Me.CloseReportButton.Text = "Close"
        Me.CloseReportButton.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 575)
        Me.Controls.Add(Me.CloseReportButton)
        Me.Controls.Add(Me.ReportPanel)
        Me.Controls.Add(Me.ReportTitleLabel)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportTitleLabel As System.Windows.Forms.Label
    Friend WithEvents ReportPanel As System.Windows.Forms.Panel
    Friend WithEvents CloseReportButton As System.Windows.Forms.Button
End Class
