using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Account17
{
    /// <summary>
    /// Source of funds. Possible values:
    /// - <c>01</c>: Credit card,
    /// - <c>02</c>: Debit card,
    /// - <c>03</c>: Prepaid card,
    /// - <c>04</c>: Cash,
    /// - <c>05</c>: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings,
    /// - <c>06</c>: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines,
    /// - <c>07</c>: Mobile wallet account,
    /// - <c>08</c>: Other source of funds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsSource")]
    [MaxLength(2)]
    public string? FundsSource { get; init; }

    /// <summary>
    /// - Cross-border: Account number of the recipient account being funded by the AFT, is mandatory in cross-border Money Transfer AFTs.
    /// - Domestic: Optional in domestic AFTs.
    /// - Europe Domestic and intra-EEA cross-border: Account number of the recipient account being funded is mandatory in domestic and intra-EEA Money Transfer AFTs.
    /// In an AFT, this field contains the account number of the Recipient Account being funded by the AFT.
    /// Note: Inclusion of this tag is conditional; Sender Information reference number or Sender account number are required. If this tag is not included, Sender Reference number must be present and contain a reference number for the recipient account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(34)]
    public string? Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
