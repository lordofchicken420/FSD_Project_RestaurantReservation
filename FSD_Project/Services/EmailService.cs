using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace FSD_Project.Services
{


    public class EmailService
    {
        private readonly string _smtpServer = "smtp.gmail.com"; // Change to your SMTP server
        private readonly int _smtpPort = 587;  // Typically 587 for TLS
        private readonly string _senderEmail = "athensrestauranttp@gmail.com";
        private readonly string _senderPassword = "teiqcewhdnhbspnm";

        public async Task SendConfirmationEmailAsync(string recipientEmail, string confirmationLink)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Athens", _senderEmail));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = "Please confirm your registration";

            // Build the email content (HTML)
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = $@"
                <p>Thank you for registering!</p>
                <p>Please confirm your registration by clicking the link below:</p>
                <a href='{confirmationLink}'>Confirm Registration</a>"
            };

            message.Body = bodyBuilder.ToMessageBody();

            // Send the email
            using (var client = new SmtpClient())
            {
                try
                {
                    // Connect using STARTTLS
                    await client.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);

                    // Authenticate with the SMTP server
                    await client.AuthenticateAsync(_senderEmail, _senderPassword);

                    // Send the email
                    await client.SendAsync(message);

                    // Disconnect cleanly
                    await client.DisconnectAsync(true);

                    Console.WriteLine("✅ Email sent successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ SMTP send error: {ex.Message}");
                }
            }
        }

        public async Task SendReservationEmailAsync(string recipientEmail, string reservationMessage, string reservedDateTime, string branchName)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Athens", _senderEmail));
            message.To.Add(new MailboxAddress("", recipientEmail));
            message.Subject = "Please confirm your reservation";

            // Build the email content (HTML)
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = $@"
                <p>Thank you for reserving with us!</p>
                <p>{reservationMessage}at {reservedDateTime} at our {branchName} branch</p>
                <p>We look forward to welcoming you soon.</p>
                "
            };

            message.Body = bodyBuilder.ToMessageBody();

            // Send the email
            using (var client = new SmtpClient())
            {
                try
                {
                    // Connect using STARTTLS
                    await client.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);

                    // Authenticate with the SMTP server
                    await client.AuthenticateAsync(_senderEmail, _senderPassword);

                    // Send the email
                    await client.SendAsync(message);

                    // Disconnect cleanly
                    await client.DisconnectAsync(true);

                    Console.WriteLine("✅ Email sent successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ SMTP send error: {ex.Message}");
                }
            }
        }
    }

}
