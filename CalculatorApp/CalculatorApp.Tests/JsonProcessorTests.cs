using System.Text.Json;

namespace CalculatorApp.Tests;

[TestFixture]
public class JsonProcessorTests
{
    [Test]
    public void ProcessJson_ValidInput_ReturnsProcessedData()
    {
        // Arrange
        var inputJson = """
        {
            "Name": "test",
            "Value": 42
        }
        """; // Raw string literal for structured JSON data

        // Act
        var result = JsonProcessor.Process(inputJson);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null, "A null result is not acceptable for a valid JSON input.");
            Assert.That(result.Name, Is.EqualTo("test"), "TThere should be a match between the name field in the output and the input JSON..");
            Assert.That(result.Value, Is.EqualTo(42), "There needs to be a match between the 'value' field and the input JSON.");
        });
    }

    [Test]
    public void ProcessJson_InvalidInput_ThrowsException()
    {
        // Arrange
        var invalidJson = "{ invalid json }";

        // Act & Assert
        Assert.Throws<JsonException>(() => JsonProcessor.Process(invalidJson), "JSONException should be thrown when invalid JSON input is received");
    }

    [Test]
    public void ProcessJson_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        var emptyJson = "";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => JsonProcessor.Process(emptyJson), "If the JSON input is empty, it should throw an ArgumentException.");
    }

    [Test]
    public void Value_IsPositive()
    {
        // Arrange
        int value = 5;

        // Act & Assert
        CustomAssertions.AssertIsPositive(value);
    }


    [Test]
    public void ProcessAndValidateJson_ValidInput_ReturnsPositiveValue()
    {
        // Arrange
        var inputJson = """
        {
            "Name": "test",
            "Value": 42
        }
        """;

        // Act
        var result = JsonProcessor.Process(inputJson);

        // Assert
        Assert.That(result, Is.Not.Null, "Result should not be null.");
        CustomAssertions.AssertIsPositive(result.Value);
    }

}
