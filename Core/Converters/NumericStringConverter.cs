using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSourceMergedSpec.Core.Converters;

/// <summary>
/// Some Cybersource endpoints (e.g. Invoicing) echo amount fields back as a JSON number even
/// though the field is documented, and used on requests, as a string. Reads either representation
/// as a string; always writes as a string to keep outgoing requests unaffected.
/// </summary>
internal sealed class NumericStringConverter : JsonConverter<string>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number => reader.GetDecimal().ToString(CultureInfo.InvariantCulture),
            JsonTokenType.Null => null,
            _ => throw new JsonException($"Cannot convert token of type {reader.TokenType} to string.")
        };

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        if (value is null)
            writer.WriteNullValue();
        else
            writer.WriteStringValue(value);
    }
}
