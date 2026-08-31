using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TransactionAdviceAddendum
{
    /// <summary>
    /// Four Transaction Advice Addendum (TAA) fields. These fields are used to display descriptive information
    /// about a transaction on the customer’s American Express card statement. When you send TAA fields, start
    /// with amexdata_taa1, then ...taa2, and so on. Skipping a TAA field causes subsequent TAA fields to be
    /// ignored.
    /// <para>
    /// To use these fields, contact CyberSource Customer Support to have your account enabled for this feature.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    [MaxLength(40)]
    public string? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
