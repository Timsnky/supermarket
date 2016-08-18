Imports System.Net.Mail
Public Class Email
    Public Sub SendEmail(ByVal Contents As ArrayList)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("supermarkevbtapplication@gmail.com", "visualbasic")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("supermarkevbtapplication@gmail.com")
            e_mail.To.Add(Contents(0))
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Welcome " & Contents(1) & " " & Contents(2) & " " & Contents(3) & ControlChars.NewLine & "Your UserName: " & Contents(4) & ControlChars.NewLine & "WorkClass: " & Contents(5) & ControlChars.NewLine & "Password: " & Contents(6)
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Public Sub SendSupplierEmail(ByVal Contents As ArrayList)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("supermarkevbtapplication@gmail.com", "visualbasic")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("supermarkevbtapplication@gmail.com")
            e_mail.To.Add(Contents(0))
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Greetings, " & ControlChars.NewLine & ControlChars.NewLine & "Kindly Supply us with the Following Products:" & _
                ControlChars.NewLine & ControlChars.NewLine & " Product Code: " & Contents(1) & ControlChars.NewLine & "Product Description: " & _
                Contents(2) & ControlChars.NewLine & "Reorder Quantity: 50" & ControlChars.NewLine & ControlChars.NewLine & "Regards, " & _
                ControlChars.NewLine & "VB Supermarket"
            Smtp_Server.Send(e_mail)
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
End Class

