using FSD_Project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace FSD_Project.Services
{
    public class EmailSender : IEmailSender<FSD_ProjectUser>  // Corrected to implement the regular IEmailSender interface
    {
        private readonly EmailService _emailService;  // Your actual email service for sending emails

        public EmailSender(EmailService emailService)
        {
            _emailService = emailService;
        }

        // Send email confirmation link
        public async Task SendConfirmationLinkAsync(FSD_ProjectUser user, string email, string confirmationLink)
        {
            await _emailService.SendConfirmationEmailAsync(email, confirmationLink);
        }

        // Optionally implement password reset methods or remove if not needed
        public Task SendPasswordResetCodeAsync(FSD_ProjectUser user, string email, string resetCode)
        {
            throw new NotImplementedException();
        }

        public Task SendPasswordResetLinkAsync(FSD_ProjectUser user, string email, string resetLink)
        {
            throw new NotImplementedException();
        }

        // Implement the standard SendEmailAsync method if you're using the IEmailSender interface
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            await _emailService.SendConfirmationEmailAsync(email, message); // You could adapt this to handle other email types
        }
    }
}
