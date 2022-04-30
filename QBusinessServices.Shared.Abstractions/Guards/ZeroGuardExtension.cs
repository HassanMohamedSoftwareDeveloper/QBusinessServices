namespace QBusinessServices.Shared.Abstractions.Guards;

/// <summary>
/// A collection of common zero guard clauses, implemented as extensions.
/// </summary>
/// <example>
/// Guard.Against.Zero(input,parameterName,message);
/// </example>
public static class ZeroGuardExtension
{
    #region Common Exceptions :
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int Zero(this IGuard guard, int input, string parameterName, string message = null)
        => Zero<int>(guard, input, parameterName, message);
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static long Zero(this IGuard guard, long input, string parameterName, string message = null)
        => Zero<long>(guard, input, parameterName, message);
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static decimal Zero(this IGuard guard, decimal input, string parameterName, string message = null)
        => Zero<decimal>(guard, input, parameterName, message);
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static float Zero(this IGuard guard, float input, string parameterName, string message = null)
        => Zero<float>(guard, input, parameterName, message);
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double Zero(this IGuard guard, double input, string parameterName, string message = null)
        => Zero<double>(guard, input, parameterName, message);
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static TimeSpan Zero(this IGuard guard, TimeSpan input, string parameterName, string message = null)
        => Zero<TimeSpan>(guard, input, parameterName, message);
    #endregion

    #region Custom Exceptions From User :
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    public static int Zero(this IGuard guard, int input, Exception exception)
        => Zero<int>(guard, input, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    public static long Zero(this IGuard guard, long input, Exception exception)
        => Zero<long>(guard, input, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    public static decimal Zero(this IGuard guard, decimal input, Exception exception)
        => Zero<decimal>(guard, input, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    public static float Zero(this IGuard guard, float input, Exception exception)
        => Zero<float>(guard, input, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    public static double Zero(this IGuard guard, double input, Exception exception)
        => Zero<double>(guard, input, exception);
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    public static TimeSpan Zero(this IGuard guard, TimeSpan input, Exception exception)
        => Zero<TimeSpan>(guard, input, exception);
    #endregion

    #region Helpers :
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="ArgumentException"></exception> 
    private static T Zero<T>(this IGuard guard, T input, string parameterName, string message = null) where T : struct
        => (EqualityComparer<T>.Default.Equals(input, default)) ?
        throw new ArgumentException(Messages.GetFormattedMessage(message, Messages.ZeroMessage, parameterName), String.Empty) : input;
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is zero.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="rangeFrom"></param>
    /// <param name="rangeTo"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns><paramref name="input" /> if the value is not zero.</returns>
    /// <exception cref="Exception"></exception>
    private static T Zero<T>(this IGuard guard, T input, Exception exception) where T : struct
       => (EqualityComparer<T>.Default.Equals(input, default)) ? throw exception : input;
    #endregion
}
