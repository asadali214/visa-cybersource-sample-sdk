using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails43
{
    /// <summary>
    /// The total amount of the funds transfer including all fees.
    /// <para>
    /// This value cannot be negative.
    /// You can include a decimal point (.), but no other special characters.
    /// </para>
    /// </summary>
    [JsonPropertyName("totalAmount")]
    [MaxLength(12)]
    public required string TotalAmount { get; init; }

    /// <summary>
    /// Use a 3-character alpha currency code for currency of the sender.
    /// <para>
    /// ISO standard currencies: <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf</see>
    /// </para>
    /// <para>
    /// Currency must be supported by the processor.
    /// </para>
    /// </summary>
    [JsonPropertyName("currency")]
    [MaxLength(3)]
    public required string Currency { get; init; }

    /// <summary>
    /// When present, this field contains the sender's surcharge as assessed by the originator. Values in this field must be in the same currency and format as defined in the amount field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceFee")]
    [MaxLength(8)]
    public string? ServiceFee { get; init; }

    /// <summary>
    /// When present, this field contains the sender's foreign exchange markup fee (markup above the wholesale or VisaNet exchange rate as assessed by the originator). Values in this field must be in the same currency and format as defined in the amount field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foreignExchangeFee")]
    [MaxLength(12)]
    public string? ForeignExchangeFee { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge2? Surcharge { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
