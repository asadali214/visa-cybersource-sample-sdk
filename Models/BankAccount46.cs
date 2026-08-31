using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankAccount46
{
    /// <summary>
    /// Account type.
    /// <para>
    /// Possible Values:
    ///  - checking : C
    ///  - general ledger : G This value is supported only on Wells Fargo ACH
    ///  - savings : S (U.S. dollars only)
    ///  - corporate checking : X (U.S. dollars only)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(18)]
    public string? Type { get; init; }

    /// <summary>
    /// Account number.
    /// <para>
    /// When processing encoded account numbers, use this field for the encoded account number.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(17)]
    public string? Number { get; init; }

    /// <summary>
    /// Bank routing number. This is also called the transit number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingNumber")]
    public string? RoutingNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
