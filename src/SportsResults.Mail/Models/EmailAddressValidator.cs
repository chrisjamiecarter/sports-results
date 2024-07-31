using FluentValidation;

namespace SportsResults.Mail.Models;

internal class EmailAddressValidator : AbstractValidator<EmailAddress>
{
    internal EmailAddressValidator()
    {
        RuleFor(x => x.Address).EmailAddress();
    }
}
