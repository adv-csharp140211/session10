using System.Net;
using MailKit.Net.Smtp;
using MailKit;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using MimeKit;

namespace Email;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
        var user = "nyah.kozey48@ethereal.email";
        var pass = " S2FYe6Aba3kNdjjs1a";
        var host = "smtp.ethereal.email";

        //var message = new MailMessage
        //{
        //    Subject = textBoxSubject.Text,
        //    Body = textBoxBody.Text,
        //    From = new MailAddress(user),
        //};
        //message.To.Add(textBoxTo.Text);


        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Joey Tribbiani", user));
        message.To.Add(new MailboxAddress(textBoxTo.Text, textBoxTo.Text));
        message.Subject = textBoxSubject.Text;

        message.Body = new TextPart("plain")
        {
            Text = textBoxBody.Text
        };


        //var client = new SmtpClient(host , 587);
        //client.Credentials = new NetworkCredential(user, pass);
        //client.EnableSsl = true;
        //client.UseDefaultCredentials = false;

        //client.Send(message);

        using (var client = new SmtpClient())
        {
            client.Connect(host, 587, false);

            // Note: only needed if the SMTP server requires authentication
            client.Authenticate(user, pass);

            client.Send(message);
            client.Disconnect(true);
        }


    }

    private void textBoxSubject_TextChanged(object sender, EventArgs e)
    {

    }
}
