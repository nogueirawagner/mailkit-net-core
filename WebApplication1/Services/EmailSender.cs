using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
  // This class is used by the application to send email for account confirmation and password reset.
  // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
  public class EmailSender : IEmailSender
  {
    private readonly IEmailConfiguration _emailConfiguration;
    public EmailSender(IEmailConfiguration emailConfiguration)
    {
      _emailConfiguration = emailConfiguration;
    }

    public Task SendEmailAsync(string email, string subject, string message)
    {
      var mensagem = new MimeMessage();
      mensagem.To.Add(new MailboxAddress(email));
      mensagem.From.Add(new MailboxAddress(_emailConfiguration.SmtpUsername));

      mensagem.Subject = subject;
      mensagem.Body = new TextPart(TextFormat.Html)
      {
        Text = message
      };

      using (var emailClient = new SmtpClient())
      {
        //The last parameter here is to use SSL (Which you should!)
        emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);

        //Remove any OAuth functionality as we won't be using it. 
        emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

        emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);

        emailClient.Send(mensagem);

        emailClient.Disconnect(true);
      }
      return Task.CompletedTask;
    }
  }
}
