namespace WebApplication1.Services
{
  public interface IEmailConfiguration
  {
    // Configurações SMTP
    string SmtpServer { get; set; }
    int SmtpPort { get; set; }
    string SmtpUsername { get; set; }
    string SmtpPassword { get; set; }

    // Configurações POP
    string PopServer { get; set; }
    int PopPort { get; set; }
    string PopUsername { get; set; }
    string PopPassword { get; set; }
    string Email { get; set; }
  }
}
