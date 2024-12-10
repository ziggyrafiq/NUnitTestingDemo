using CalculatorApp.Models;
using System.Text.Json;

namespace CalculatorApp;

public class JsonProcessor
{
    public static ProcessedData Process(string json)
    {
        if (string.IsNullOrEmpty(json))
            throw new ArgumentException("Input JSON cannot be null or empty.");

        return JsonSerializer.Deserialize<ProcessedData>(json);
    }
}
