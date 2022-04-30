namespace QBusinessServices.Shared.Abstractions.Guards;

/// <summary>
/// A collection of common null guard clauses, implemented as extensions.
/// </summary>
/// <example>
/// Guard.Against.Null(input, nameof(input));
/// </example>
public static class NullGuardExtension
{
    #region Common Exceptions :
    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static T Null<T>(this IGuard guard, T input, string parameterName, string message = null)
        => input is null ? throw new ArgumentNullException(string.Empty, Messages.GetFormattedMessage(message, Messages.NullMessage, parameterName)) : input;
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string NullOrEmpty(this IGuard guard, string input, string parameterName, string message = null)
       => string.IsNullOrEmpty(input) ? throw new ArgumentException(Messages.GetFormattedMessage(message, Messages.NullMessage, parameterName), String.Empty) : input;
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static Guid NullOrEmpty(this IGuard guard, Guid? input, string parameterName, string message = null)
       => input is null || input == Guid.Empty ? throw new ArgumentException(Messages.GetFormattedMessage(message, Messages.NullMessage, parameterName), String.Empty) : input.Value;
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static IEnumerable<T> NullOrEmpty<T>(this IGuard guard, IEnumerable<T> input, string parameterName, string message = null)
       => input is null || input.Any() is false ? throw new ArgumentException(Messages.GetFormattedMessage(message, Messages.NullMessage, parameterName), String.Empty) : input;
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="input" /> is null.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="parameterName"></param>
    /// <param name="message">Optional. Custom error message</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string NullOrWhiteSpace(this IGuard guard, string input, string parameterName, string message = null)
       => string.IsNullOrWhiteSpace(input) ? throw new ArgumentException(Messages.GetFormattedMessage(message, Messages.NullMessage, parameterName), String.Empty) : input;
    #endregion

    #region Custom Exception From User :
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="Exception"></exception>
    public static T Null<T>(this IGuard guard, T input, Exception exception)
        => input is null ? throw exception : input;
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="Exception"></exception>
    public static string NullOrEmpty(this IGuard guard, string input, Exception exception)
        => string.IsNullOrEmpty(input) ? throw exception : input;
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is null.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="Exception"></exception>
    public static Guid NullOrEmpty(this IGuard guard, Guid? input, Exception exception)
        => input is null || input == Guid.Empty ? throw exception : input.Value;
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="Exception"></exception>
    public static IEnumerable<T> NullOrEmpty<T>(this IGuard guard, IEnumerable<T> input, Exception exception)
        => input is null || input.Any() is false ? throw exception : input;
    /// <summary>
    /// Throws the passed <paramref name="exception"/> if <paramref name="input" /> is null.
    /// </summary>
    /// <param name="guard"></param>
    /// <param name="input"></param>
    /// <param name="exception">Custom Exception</param>
    /// <returns> <paramref name="input" /> if the value is not null.</returns>
    /// <exception cref="Exception"></exception>
    public static string NullOrWhiteSpace(this IGuard guard, string input, Exception exception)
        => string.IsNullOrWhiteSpace(input) ? throw exception : input;
    #endregion
}
