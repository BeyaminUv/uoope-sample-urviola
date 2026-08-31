namespace Acme.OOPrograming.Shared.Domain.Model.ValueObjects;
/// <summary>
/// Represents a monteary value with an amount and a currency.
/// </summary>
public readonly record struct Money
{
    /// <summary>
    /// The underlying amount of money. Must not be non-negative
    /// </summary>
    public decimal Amount
    {
        get;
        init
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            field=value;
        }
    }

    public Currency Currency
    {
        get;
        init
        {
            if(value== default)
                throw new ArgumentException("Currency must be provided.", nameof(Currency));
            field =value;
        }
    }
}