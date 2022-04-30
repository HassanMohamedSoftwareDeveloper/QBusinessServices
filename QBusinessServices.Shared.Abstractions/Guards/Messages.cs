namespace QBusinessServices.Shared.Abstractions.Guards;

internal class Messages
{
    #region Consts :
    public const string NullMessage = "Required input {0} was empty or null.";
    public const string InvalidRangeMessage = "Range From should be less or equal than Range To.";
    public const string OutOfRangeMessage = "Input ({0}) was out of range.";
    public const string ZeroMessage = "Required input {0} cannot be zero.";
    #endregion

    #region Methods :
    public static string GetFormattedMessage(string userMessage, string customeMessage, string parameterName)
        => string.IsNullOrWhiteSpace(userMessage) ? string.Format(customeMessage, parameterName) : userMessage;
    #endregion
}
