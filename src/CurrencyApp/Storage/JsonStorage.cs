using CurrencyApp.Models;

namespace CurrencyApp.Storage;

public class JsonStorage
{
    public void SaveRecord(ConversionRecord record)
    {
    }
    public List<ConversionRecord> LoadHistory()
    {
        return new List<ConversionRecord>();
    }
    public void ClearHistory()
    {
    }
}
