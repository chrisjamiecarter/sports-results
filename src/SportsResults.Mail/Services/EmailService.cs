using System.Net;
using System.Net.Mail;
using SportsResults.Mail.Models;

namespace SportsResults.Mail.Services;

public class EmailService
{
    private readonly string _smtpClientHost;
    private readonly int _smtpClientPort;
    private readonly NetworkCredential _smtpClientNetworkCredential;
    private readonly bool _smtpClientEnableSsl;

    public EmailService(string smtpClientHost, int smtpClientPort, NetworkCredential smtpClientNetworkCredential, bool smtpClientEnableSsl)
    {
        _smtpClientHost = smtpClientHost;
        _smtpClientPort = smtpClientPort;
        _smtpClientNetworkCredential = smtpClientNetworkCredential;
        _smtpClientEnableSsl = smtpClientEnableSsl;
    }

    public void SendEmail(EmailMessage emailMessage)
    {
        using var mailMessage = emailMessage.ToMailMessage();

        using var client = new SmtpClient(_smtpClientHost, _smtpClientPort);
        client.Credentials = _smtpClientNetworkCredential;
        client.EnableSsl = _smtpClientEnableSsl;
        client.Send(mailMessage);
    }
}
