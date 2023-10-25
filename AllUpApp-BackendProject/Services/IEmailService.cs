namespace AllUpApp_BackendProject.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string body, string link, string userName);
    }
}
