namespace CurrencyApp.Logic;

public class InputValidator
{
    private readonly CurrencyConverter _converter;

    public InputValidator(CurrencyConverter converter)
    {
        _converter = converter;
    }

    public bool ValidateCurrency(string code, out string error)
    {
        if (!_converter.IsSupported(code))
        {
            error = "Unsupported currency. Please use NGN, USD, GBP or EUR.";
            return false;
        }

        error = "";
        return true;
    }

    public bool TryValidateAmount(string input, out decimal amount, out string error)
    {
        if (!decimal.TryParse(input, out amount))
        {
            error = "Invalid amount. Please enter a number.";
            return false;
        }

        if (amount <= 0)
        {
            error = "Invalid amount. The amount must be greater than zero.";
            return false;
        }

        error = "";
        return true;
    }
}