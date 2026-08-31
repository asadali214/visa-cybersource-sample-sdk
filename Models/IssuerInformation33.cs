using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record IssuerInformation33
{
    /// <summary>
    /// Domestic indicator for Push funds (OCT). If no Funds Transfer Attributes Inquiry data is available
    /// for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octDomesticParticipantIndicator")]
    public bool? OctDomesticParticipantIndicator { get; init; }

    /// <summary>
    /// Cross-border indicator for push funds (OCT). If no Funds Transfer Attributes Inquiry data is available
    /// for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octCrossBorderParticipantIndicator")]
    public bool? OctCrossBorderParticipantIndicator { get; init; }

    /// <summary>
    /// Indicates whether domestic money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    ///
    /// Supported for Visa Direct.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octMoneyTransferDomesticIndicator")]
    public bool? OctMoneyTransferDomesticIndicator { get; init; }

    /// <summary>
    /// Indicates whether cross-border money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octMoneyTransferCrossBorderIndicator")]
    public bool? OctMoneyTransferCrossBorderIndicator { get; init; }

    /// <summary>
    /// Indicates whether domestic money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octMoneyTransferFastFundsDomesticIndicator")]
    public bool? OctMoneyTransferFastFundsDomesticIndicator { get; init; }

    /// <summary>
    /// Indicates whether cross-border money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octMoneyTransferFastFundsCrossBorderIndicator")]
    public bool? OctMoneyTransferFastFundsCrossBorderIndicator { get; init; }

    /// <summary>
    /// This field indicates if the recipient issuer can accept push funds (OCT) transactions from the merchant country.
    /// If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octMoneyTransferMerchantCountryRestricted")]
    public bool? OctMoneyTransferMerchantCountryRestricted { get; init; }

    /// <summary>
    /// Indicates whether domestic non-money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octNonMoneyTransferDomesticIndicator")]
    public bool? OctNonMoneyTransferDomesticIndicator { get; init; }

    /// <summary>
    /// Indicates whether cross-border non-money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octNonMoneyTransferCrossBorderIndicator")]
    public bool? OctNonMoneyTransferCrossBorderIndicator { get; init; }

    /// <summary>
    /// Indicates whether domestic non-money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octNonMoneyTransferFastFundsDomesticIndicator")]
    public bool? OctNonMoneyTransferFastFundsDomesticIndicator { get; init; }

    /// <summary>
    /// Indicates whether cross-border non-money transfer OCTs (fast push funds) are allowed. If no Funds Transfer
    /// Attributes Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octNonMoneyTransferFastFundsCrossBorderIndicator")]
    public bool? OctNonMoneyTransferFastFundsCrossBorderIndicator { get; init; }

    /// <summary>
    /// Indicates whether domestic gambling OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry
    /// data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octOnlineGamblingDomesticIndicator")]
    public bool? OctOnlineGamblingDomesticIndicator { get; init; }

    /// <summary>
    /// Indicates whether cross-border gambling OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry
    /// data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octOnlineGamblingCrossBorderIndicator")]
    public bool? OctOnlineGamblingCrossBorderIndicator { get; init; }

    /// <summary>
    /// Indicates whether domestic gambling OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry
    /// data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octOnlineGamblingFastFundsDomesticIndicator")]
    public bool? OctOnlineGamblingFastFundsDomesticIndicator { get; init; }

    /// <summary>
    /// Indicates whether cross-border gambling OCTs (fast push funds) are allowed. If no Funds Transfer Attributes
    /// Inquiry data is available for this card account, the field is omitted.
    /// <para>
    /// Supported for Visa Direct.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("octOnlineGamblingFastFundsCrossBorderIndicator")]
    public bool? OctOnlineGamblingFastFundsCrossBorderIndicator { get; init; }

    /// <summary>
    /// This field contains values that identify the service type under which the transaction should be processed.
    /// The valid value for the Visa Alias Directory Service is A0 (Alias) and 00 (normal transaction).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceProcessingType")]
    [MaxLength(2)]
    public string? ServiceProcessingType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
