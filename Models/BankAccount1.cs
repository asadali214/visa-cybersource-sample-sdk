using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankAccount1
{
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
    /// Bank routing number. This is also called the transit number.
    /// <para>
    /// # For details, see <c>ecp_rdfi</c> field description in the <see href="https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/">Electronic Check Services Using the SCMP API Guide.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingNumber")]
    public string? RoutingNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
