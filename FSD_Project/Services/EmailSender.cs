using FSD_Project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace FSD_Project.Services
{
    public interface ICustomEmailSender<TUser> : IEmailSender<TUser> where TUser : class
    {
        Task SendConfirmationLinkAsync(TUser user, string email, string confirmationLink);
        Task SendReservationConfirmation(TUser user, string email, string reservationMessage);
        Task SendPasswordResetCodeAsync(TUser user, string email, string resetCode);
        Task SendPasswordResetLinkAsync(TUser user, string email, string resetLink);
    }

    public class EmailSender : ICustomEmailSender<FSD_ProjectUser>  // Changed this line to implement ICustomEmailSender
    {
        private readonly EmailService _emailService;

        public EmailSender(EmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task SendConfirmationLinkAsync(FSD_ProjectUser user, string email, string confirmationLink)
        {
            await _emailService.SendConfirmationEmailAsync(email, confirmationLink);
        }

        public async Task SendReservationConfirmation(FSD_ProjectUser user, string email, string reservationMessage)
        {
            await _emailService.SendReservationEmailAsync(email, reservationMessage);
        }

        public Task SendPasswordResetCodeAsync(FSD_ProjectUser user, string email, string resetCode)
        {
            throw new NotImplementedException();
        }

        public Task SendPasswordResetLinkAsync(FSD_ProjectUser user, string email, string resetLink)
        {
            throw new NotImplementedException();
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            await _emailService.SendConfirmationEmailAsync(email, message);
        }
    }
}