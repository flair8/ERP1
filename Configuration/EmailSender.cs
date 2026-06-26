using Microsoft.AspNetCore.Identity.UI.Services;

namespace ERP1.Configuration
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Apenas simula envio (DEV)
            Console.WriteLine($"EMAIL PARA: {email}");
            Console.WriteLine($"ASSUNTO: {subject}");
            Console.WriteLine(htmlMessage);

            return Task.CompletedTask;
        }
    }
}
