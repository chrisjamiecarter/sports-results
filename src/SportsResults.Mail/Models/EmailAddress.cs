using System.Net.Mail;

namespace SportsResults.Mail.Models;

public class EmailAddress
{
    public EmailAddress(string address) : this(address, "")
    {        
    }

    public EmailAddress(string address, string displayName)
    {
        ArgumentNullException.ThrowIfNull(address, nameof(address));
        ArgumentException.ThrowIfNullOrWhiteSpace(address, nameof(address));
        
        Address = address;
        DisplayName = displayName;
    }

    public string Address { get; set; }

    public string DisplayName { get; set; }

    public bool HasDisplayName => !string.IsNullOrWhiteSpace(DisplayName);

    internal MailAddress ToMailAddress()
    {
        return HasDisplayName
            ? new MailAddress(Address, DisplayName)
            : new MailAddress(Address);
    }
}
