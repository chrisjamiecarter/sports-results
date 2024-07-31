using SportsResults.Mail.Exceptions;
using System.Collections.ObjectModel;

namespace SportsResults.Mail.Models;

public class EmailAddressCollection : Collection<EmailAddress>
{
    private readonly static char[] EmailAddressDelimiters = [';', ','];

    public EmailAddressCollection() : base() { }

    /// <summary>
    /// Adds a collections of email addresses.
    /// Use either ';' or ',' to separate each individual address.
    /// </summary>
    /// <param name="emailAddresses">Can be one or more email addresses, separated with the ';' or ',' character.</param>
    /// <exception cref="InvalidEmailAddressException">Throw if any email address is not valid.</exception>
    public void Add(string emailAddresses)
    {
        ArgumentNullException.ThrowIfNull(emailAddresses);
        ArgumentException.ThrowIfNullOrWhiteSpace(emailAddresses);

        foreach (var emailAddressString in emailAddresses.Split(EmailAddressDelimiters))
        {
            var emailAddress = new EmailAddress(emailAddressString);
            
            var validator = new EmailAddressValidator();
            var result = validator.Validate(emailAddress);
            if (!result.IsValid)
            {
                throw new InvalidEmailAddressException(result.ToString());
            }

            Items.Add(emailAddress);
        }
    }
}
