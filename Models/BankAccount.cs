using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankAccount
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
