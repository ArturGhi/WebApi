using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using WebApi.Models;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    [HttpPost("send-email")]
    public IActionResult SendEmail([FromBody] EmailRequest request)
    {
        try
        {
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("example@example.com"));
            //email.To.Add(MailboxAddress.Parse(request.Email));
            //email.Subject = "Contact Form Submission";
            //email.Body = new TextPart("plain")
            //{
            //    Text = $"Name: {request.Name}\nMessage: {request.Message}"
            //};

            //using var smtp = new MailKit.Net.Smtp.SmtpClient();
            //smtp.Connect("smtp.gmail.com", 587, false);
            //smtp.Authenticate("your-email@example.com", "your-email-password");
            //smtp.Send(email);
            //smtp.Disconnect(true);

            return Ok(new { message = "Email sent successfully!" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}