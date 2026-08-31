using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Features28
{
    /// <summary>
    /// This field contains the account funding source.
    /// Possible values:
    ///   - <c>CREDIT</c>
    ///   - <c>DEBIT</c>
    ///   - <c>PREPAID</c>
    ///   - <c>DEFERRED DEBIT</c>
    ///   - <c>CHARGE</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountFundingSource")]
    [MaxLength(20)]
    public string? AccountFundingSource { get; init; }

    /// <summary>
    /// This field contains the type of prepaid card.
    /// Possible values:
    ///   - <c>Reloadable</c>
    ///   - <c>Non-reloadable</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountFundingSourceSubType")]
    [MaxLength(20)]
    public string? AccountFundingSourceSubType { get; init; }

    /// <summary>
    /// This field contains the type of issuer product.
    /// Example values:
    ///   - Visa Classic
    ///   - Visa Signature
    ///   - Visa Infinite
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardProduct")]
    [MaxLength(50)]
    public string? CardProduct { get; init; }

    /// <summary>
    /// This field contains the type of BIN based authentication.
    /// Possible values:
    ///   - <c>S</c>: Single Message
    ///   - <c>D</c>: Dual Message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageType")]
    [MaxLength(1)]
    public string? MessageType { get; init; }

    /// <summary>
    /// This field contains the acceptance level of the PAN.
    /// Possible values:
    ///   - <c>0</c> : Normal
    ///   - <c>1</c> : Monitor
    ///   - <c>2</c> : Refuse
    ///   - <c>3</c> : Not Allowed
    ///   - <c>4</c> : Private
    ///   - <c>5</c> : Test
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptanceLevel")]
    [MaxLength(2)]
    public string? AcceptanceLevel { get; init; }

    /// <summary>
    /// This field contains the type of card platform.
    /// Possible values:
    ///   - <c>BUSINESS</c>
    ///   - <c>CONSUMER</c>
    ///   - <c>COMMERCIAL</c>
    ///   - <c>GOVERNMENT</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardPlatform")]
    [MaxLength(20)]
    public string? CardPlatform { get; init; }

    /// <summary>
    /// This field indicates the type of combo card.
    /// Possible values:
    ///   - 0 (Not a combo card)
    ///   - 1 (Credit and Prepaid Combo card)
    ///   - 2 (Credit and Debit Combo card)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comboCard")]
    [MaxLength(1)]
    public string? ComboCard { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
