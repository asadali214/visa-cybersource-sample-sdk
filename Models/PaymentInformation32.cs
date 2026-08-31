using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains response information about the payment.
/// </summary>
public record PaymentInformation32
{
    /// <summary>
    /// Country (two-digit country code) associated with the BIN of the customer’s card used for the payment.
    /// Returned if the information is available. Use this field for additional information when reviewing orders.
    /// This information is also displayed in the details page of the CyberSource Business Center.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("binCountry")]
    [MaxLength(255)]
    public string? BinCountry { get; init; }

    /// <summary>
    /// Type of payment card account. This field can refer to a credit card, debit card, or prepaid card
    /// account type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    [MaxLength(255)]
    public string? AccountType { get; init; }

    /// <summary>
    /// Name of the bank or entity that issued the card account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuer")]
    [MaxLength(255)]
    public string? Issuer { get; init; }

    /// <summary>
    /// Subtype of card account. This field can contain one of the following values:
    /// - Maestro International
    /// - Maestro UK Domestic
    /// - MasterCard Credit
    /// - MasterCard Debit
    /// - Visa Credit
    /// - Visa Debit
    /// - Visa Electron
    /// <para>
    /// <b>Note</b> Additional values may be present.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheme")]
    [MaxLength(255)]
    public string? Scheme { get; init; }

    /// <summary>
    /// Credit card BIN (the first six digits of the credit card).Derived either from the <c>cc_bin</c> request field
    /// or from the first six characters of the <c>customer_cc_num</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bin")]
    [MaxLength(255)]
    public string? Bin { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
