namespace Services.Abstractions.Common
{
    public record EmailAddress(string email, string name);
    public record EmailMessage(string subject, string text, EmailAddress receiver);

    public interface IEmailService
    {
        Task SendAsync(EmailMessage message);
    }
}
