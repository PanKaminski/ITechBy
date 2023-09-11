using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using Services.Abstractions.Common;
using Services.Implementations.Utils;

namespace Services.Implementations.Common
{
    public class EmailService : IEmailService
    {
        private readonly string password = Environment.GetEnvironmentVariable("GENESIS_SENDER_PASSWORD");
        private readonly EmailSettings settings;

        public EmailService(IOptions<EmailSettings> settings)
        {
            this.settings = settings.Value ?? throw new ArgumentNullException(nameof(settings));
        }

        public Task SendAsync(EmailMessage message)
        {
            throw new NotImplementedException();
        }

        public async Task SendEmailAsync(EmailMessage message)
        {
            var email = CreateEmailMessage(message);

            using var smtp = new SmtpClient();

            await smtp.ConnectAsync(settings.SmtpServer, settings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(settings.Email, password);
            await smtp.SendAsync(email);

            await smtp.DisconnectAsync(true);
        }

        private MimeMessage CreateEmailMessage(EmailMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(settings.Name, settings.Email));
            mimeMessage.To.Add(new MailboxAddress(message.receiver.name, message.receiver.email));
            mimeMessage.Subject = message.subject;
            mimeMessage.Body = new TextPart(TextFormat.Html) { Text = message.text };

            return mimeMessage;
        }
    }
}
