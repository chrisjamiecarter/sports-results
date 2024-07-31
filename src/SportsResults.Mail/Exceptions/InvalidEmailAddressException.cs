using System.Runtime.Serialization;

namespace SportsResults.Mail.Exceptions;
internal class InvalidEmailAddressException : Exception
{
    public InvalidEmailAddressException(string? message) : base(message) { }
}
