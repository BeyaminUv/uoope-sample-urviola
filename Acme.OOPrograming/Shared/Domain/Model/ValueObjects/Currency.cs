using System.Net.Http.Headers;

namespace Acme.OOPrograming.Shared.Domain.Model.ValueObjects;
/// <summary>
/// Represents a currency in the ISO 4217 format
/// </summary>
public readonly record struct Currency
{
    
    public string Code
    {
        get => field ?? string.Empty;
        init
        {
            ArgumentException.ThrowIfNullOrEmpty(value);
            if(value.length != 3 || !value.All(char.IsAsciiLetter))
                throw new ArgumentException("Currency code must contain 3 letters ISO 4217 code");
            field = value.ToUpperInvariant();
        }
    }
    /// <summary>
    /// Prevents the deefault constructor from being used, ensuring that a valid ISO
    /// </summary>
    /// <exception cref="InvalidOperationException">Always thrown because currency to indicate that the default constructor is not supported.</exception>
    public Currency() => throw new InvalidOperationException("Currency must contain 3 letters ISO 4217 code");
    /// <summary>
    /// Creates a new instance of <see cref="Currency"/>
    /// </summary>
    /// <param name="code">The ISO 4217 code for the currency</param>
    /// <exception cref="ArgumentException">Thrown when the provided code is null, whitespace or not a valid 3-letter</exception>
    public Currency(string code) => Code = code;
    /// <summary>
    /// Returns the ISO 4217 code of the currency as a string.
    /// </summary>
    /// <returns>A string representing the ISO 4217 code of the currency</returns>
    
    public override string toString() => Code;
}