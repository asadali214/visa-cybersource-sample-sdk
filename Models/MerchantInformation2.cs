using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation2
{
    /// <summary>
    /// Date and time at your physical location.
    /// <para>
    /// Format: <c>YYYYMMDDhhmmss</c>, where:
    ///  - <c>YYYY</c> = year
    ///  - <c>MM</c> = month
    ///  - <c>DD</c> = day
    ///  - <c>hh</c> = hour
    ///  - <c>mm</c> = minutes
    ///  - <c>ss</c> = seconds
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required for these processors:
    /// - American Express Direct                                                                                                                                                                                                                                                                                                                         - American Express Direct
    /// - Credit Mutuel-CIC
    /// - FDC Nashville Global
    /// - SIX
    /// </para>
    /// <para>
    /// Optional for all other processors.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLocalDateTime")]
    [MaxLength(14)]
    public string? TransactionLocalDateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
