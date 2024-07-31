using System.Net;

namespace SportsResults.Mail.Models;
public class EmailBody
{
    public EmailBody() : this(string.Empty, false) { }

    public EmailBody(string bodyText) : this(bodyText, false) { }

    public EmailBody(string bodyText, bool isHtml)
    {
        ArgumentNullException.ThrowIfNull(bodyText, nameof(bodyText));
        
        Text = bodyText;
        IsHtml = isHtml;
    }

    public string Text { get; set; }

    public bool IsHtml { get; set; }
}
