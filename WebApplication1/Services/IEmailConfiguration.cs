using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
  public interface IEmailConfiguration
  {
    string SmtpServer { get; set; }
    int SmtpPort { get; set; }
    string SmtpUsername { get; set; }
    string SmtpPassword { get; set; }

    string PopServer { get; set; }
    int PopPort { get; set; }
    string PopUsername { get; set; }
    string PopPassword { get; set; }
    string Email { get; set; }
  }
}
