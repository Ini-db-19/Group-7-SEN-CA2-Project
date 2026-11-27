using CurrencyApp.Models;

namespace CurrencyApp.Logic;

public class CurrencyConverter
{
    private Dictionary<string, decimal> _ratesPerUsd = new()
    {
        { "USD", 1m },
        { "NGN", 1500m },
        { "GBP", 0.79m },
        { "EUR", 0.92m }
    };

    public bool IsSupported(string code)
    {
        return _ratesPerUsd.ContainsKey(code);
    }

    public IEnumerable<string> SupportedCurrencies => _ratesPerUsd.Keys;

    public ConversionRecord Convert(decimal amount, string fromCurrency, string toCurrency)
{
    decimal rate = _ratesPerUsd[toCurrency] / _ratesPerUsd[fromCurrency];

    return new ConversionRecord
{
    Timestamp = DateTime.Now,
    FromCurrency = fromCurrency,
    ToCurrency = toCurrency,
    Amount = amount,
    Rate = rate,
    Result = Math.Round(amount * rate, 2)
};
}
}