# mailkit-net-core
Enviar email utilizando Mailkit.
Criar projeto WebApplication .NET Core com autenticação do Identity User.

<strong>Criar interface de configuração</strong><br>
<img src="https://raw.githubusercontent.com/nogueirawagner/mailkit-net-core/master/WebApplication1/img/IEmailConfiguration.png" style="max-width:100%;">

<strong>Criar classe de configuração herdando a interface.</strong><br>
<img src="https://raw.githubusercontent.com/nogueirawagner/mailkit-net-core/master/WebApplication1/img/EmailConfiguration.png" style="max-width:100%;">

<strong>Criar seção na classe appsettings.json</strong><br><br>
<img src="https://raw.githubusercontent.com/nogueirawagner/mailkit-net-core/master/WebApplication1/img/AppSettings.png" style="max-width:100%;">

<strong>Adicionar no método ConfigureServices na class Startup a interface no pipeline de injeção de dependência.</strong><br>
<img src="https://raw.githubusercontent.com/nogueirawagner/mailkit-net-core/master/WebApplication1/img/ConfigureServices.png" style="max-width:100%;">

<strong>Implementar o envio de email na class de services utilizada pelo Identity EmailSender</strong><br>
<img src="https://raw.githubusercontent.com/nogueirawagner/mailkit-net-core/master/WebApplication1/img/EmailSender.png" style="max-width:100%;">

Pronto! 
Para testar utilize o método de recuperar senha do próprio Identity, rode um projeto e clique em Login -> Forgot Password.
Valeu!
