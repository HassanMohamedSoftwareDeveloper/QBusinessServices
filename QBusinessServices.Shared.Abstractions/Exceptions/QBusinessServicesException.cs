namespace QBusinessServices.Shared.Abstractions.Exceptions;

public abstract class QBusinessServicesException : Exception
{
    protected QBusinessServicesException(string message) : base(message) { }
}
