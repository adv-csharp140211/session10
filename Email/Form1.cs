using System.Net;
using System.Net.Mail;

namespace Email;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
        var user = "koby.bode@ethereal.email";
        var pass = "63RHdDdhEbYJtsAsXy";
        var host = "smtp.ethereal.email";

        var message = new MailMessage
        {
            Subject = textBoxSubject.Text,
            Body = textBoxBody.Text,
            From = new MailAddress(user),
        };
        message.To.Add(textBoxTo.Text);

        var client = new System.Net.Mail.SmtpClient(host, 587);
        client.Credentials = new NetworkCredential(user, pass);
        client.EnableSsl = true;
        client.UseDefaultCredentials = false;

        client.Send(message);
        


    }

    private void textBoxSubject_TextChanged(object sender, EventArgs e)
    {

    }
}
