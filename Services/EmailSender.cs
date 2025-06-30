using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        Console.WriteLine($"[Email Sender]");
        Console.WriteLine($"To: {email}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {htmlMessage}");
        return Task.CompletedTask;
    }
}
