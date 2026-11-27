namespace CurrencyApp.Models;

public class ConversionRecord
{
    public DateTime Timestamp { get; set; }
    public string FromCurrency { get; set; } = "";
    public string ToCurrency { get; set; } = "";
    public decimal Amount { get; set; }
    public decimal Rate { get; set; }
    public decimal Result { get; set; }
}