namespace QBusinessServices.Shared.Abstractions.Guards;
/// <summary>
/// A collection of common out of range guard clauses, implemented as extensions.
/// </summary>
/// <example>
/// Guard.Against.OutOfRange(input, nameof(input),rangeFrom,rangeTo,message);
/// </example>
public static class OutOfRangeGuardExtension
{
    #region Common Exceptions :
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static int OutOfRange(this IGuard guard, int input, string parameterName, int rangeFrom, int rangeTo, string message = null)
        => guard.OutOfRange<int>(input, parameterName, rangeFrom, rangeTo, message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static DateTime OutOfRange(this IGuard guard, DateTime input, string parameterName, DateTime rangeFrom, DateTime rangeTo, string message = null)
        => guard.OutOfRange<DateTime>(input, parameterName, rangeFrom, rangeTo, message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static DateTime OutOfSQLDateRange(this IGuard guard, DateTime input, string parameterName, string message = null)
        => guard.OutOfRange<DateTime>(input, parameterName, new DateTime(552877920000000000L), new DateTime(3155378975999970000L), message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static decimal OutOfRange(this IGuard guard, decimal input, string parameterName, decimal rangeFrom, decimal rangeTo, string message = null)
        => guard.OutOfRange<decimal>(input, parameterName, rangeFrom, rangeTo, message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static short OutOfRange(this IGuard guard, short input, string parameterName, short rangeFrom, short rangeTo, string message = null)
        => guard.OutOfRange<short>(input, parameterName, rangeFrom, rangeTo, message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static double OutOfRange(this IGuard guard, double input, string parameterName, double rangeFrom, double rangeTo, string message = null)
        => guard.OutOfRange<double>(input, parameterName, rangeFrom, rangeTo, message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static float OutOfRange(this IGuard guard, float input, string parameterName, float rangeFrom, float rangeTo, string message = null)
        => guard.OutOfRange<float>(input, parameterName, rangeFrom, rangeTo, message);
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    public static TimeSpan OutOfRange(this IGuard guard, TimeSpan input, string parameterName, TimeSpan rangeFrom, TimeSpan rangeTo, string message = null)
        => guard.OutOfRange<TimeSpan>(input, parameterName, rangeFrom, rangeTo, message);
    #endregion

    #region Custom Exception From User :
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static int OutOfRange(this IGuard guard, int input, int rangeFrom, int rangeTo, Exception exception)
        => guard.OutOfRange<int>(input, rangeFrom, rangeTo, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static DateTime OutOfRange(this IGuard guard, DateTime input, DateTime rangeFrom, DateTime rangeTo, Exception exception)
       => guard.OutOfRange<DateTime>(input, rangeFrom, rangeTo, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static DateTime OutOfSQLDateRange(this IGuard guard, DateTime input, Exception exception)
        => guard.OutOfRange<DateTime>(input, new DateTime(552877920000000000L), new DateTime(3155378975999970000L), exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static decimal OutOfRange(this IGuard guard, decimal input, decimal rangeFrom, decimal rangeTo, Exception exception)
       => guard.OutOfRange<decimal>(input, rangeFrom, rangeTo, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static short OutOfRange(this IGuard guard, short input, short rangeFrom, short rangeTo, Exception exception)
        => guard.OutOfRange<short>(input, rangeFrom, rangeTo, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static double OutOfRange(this IGuard guard, double input, double rangeFrom, double rangeTo, Exception exception)
        => guard.OutOfRange<double>(input, rangeFrom, rangeTo, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static float OutOfRange(this IGuard guard, float input, float rangeFrom, float rangeTo, Exception exception)
        => guard.OutOfRange<float>(input, rangeFrom, rangeTo, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    public static TimeSpan OutOfRange(this IGuard guard, TimeSpan input, TimeSpan rangeFrom, TimeSpan rangeTo, Exception exception)
        => guard.OutOfRange<TimeSpan>(input, rangeFrom, rangeTo, exception);
    #endregion

    #region Helper :
    /// <summary>
    /// Throws an <see cref="T:System.ArgumentException" /> if <paramref name="rangeFrom" /> is greater than <paramref name="rangeTo" />.
    /// Throws an <see cref="T:System.ArgumentOutOfRangeException" /> if <paramref name="input" /> is less than <paramref name="rangeFrom" /> or greater than <paramref name="rangeTo" />.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="T:System.ArgumentException"></exception>
    /// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
    private static T OutOfRange<T>(this IGuard guard, T input, string parameterName, T rangeFrom, T rangeTo, string message = null)
    {
        Comparer<T> @default = Comparer<T>.Default;
        if (@default.Compare(rangeFrom, rangeTo) > 0)
            throw new ArgumentException(Messages.InvalidRangeMessage);
        if (@default.Compare(input, rangeFrom) < 0 || @default.Compare(input, rangeTo) > 0)
            throw new ArgumentOutOfRangeException(string.Empty, Messages.GetFormattedMessage(message, Messages.OutOfRangeMessage, parameterName));
        return input;
    }
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is invalid range or out of range.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not out of range.</returns>
    /// <exception cref="Exception"></exception>
    private static T OutOfRange<T>(this IGuard guard, T input, T rangeFrom, T rangeTo, Exception exception)
    {
        Comparer<T> @default = Comparer<T>.Default;
        return @default.Compare(rangeFrom, rangeTo) > 0 || (@default.Compare(input, rangeFrom) < 0 || @default.Compare(input, rangeTo) > 0) ?
            throw exception : input;
    }
    #endregion
}
