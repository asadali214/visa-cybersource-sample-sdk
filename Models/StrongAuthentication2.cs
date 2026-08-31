using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record StrongAuthentication2
{
    /// <summary>
    /// Indicates the type of Authentication request
    /// <para>
    /// 01 - Payment transaction
    /// </para>
    /// <para>
    /// 02 - Recurring transaction
    /// </para>
    /// <para>
    /// 03 - Installment transaction
    /// </para>
    /// <para>
    /// 04 - Add card
    /// </para>
    /// <para>
    /// 05 - Maintain card
    /// </para>
    /// <para>
    /// 06 - Cardholder verification as part of EMV token ID and V
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationIndicator")]
    [MaxLength(2)]
    public string? AuthenticationIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
