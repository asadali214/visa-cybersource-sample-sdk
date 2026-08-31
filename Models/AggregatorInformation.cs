using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AggregatorInformation
{
    /// <summary>
    /// Value that identifies you as a payment aggregator. Get this value from the
    /// processor.
    /// <para>
    /// #### CyberSource through VisaNet
    /// The value for this field corresponds to the following data in the TC 33 capture file5:
    /// - Record: CP01 TCR6
    /// - Position: 95-105
    /// - Field: Payment Facilitator ID
    /// </para>
    /// <para>
    /// This field is supported for Visa, Mastercard and Discover Transactions.
    /// </para>
    /// <para>
    /// <b>FDC Compass</b>\
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregatorId")]
    [MaxLength(20)]
    public string? AggregatorId { get; init; }

    /// <summary>
    /// Your payment aggregator business name.
    /// <para>
    /// <b>American Express Direct</b>\
    /// The maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters.\
    /// </para>
    /// <para>
    /// #### CyberSource through VisaNet
    /// With American Express, the maximum length of the aggregator name depends on the length of the sub-merchant name. The combined length for both values must not exceed 36 characters. The value for this field does not map to the TC 33 capture file5.
    /// </para>
    /// <para>
    /// <b>FDC Compass</b>\
    /// This value must consist of uppercase characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(37)]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant")]
    public SubMerchant? SubMerchant { get; init; }

    /// <summary>
    /// Acquirer street name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streetAddress")]
    [MaxLength(150)]
    public string? StreetAddress { get; init; }

    /// <summary>
    /// Acquirer city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    [MaxLength(100)]
    public string? City { get; init; }

    /// <summary>
    /// Acquirer state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    [MaxLength(10)]
    public string? State { get; init; }

    /// <summary>
    /// Acquirer postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(20)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Acquirer country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(10)]
    public string? Country { get; init; }

    /// <summary>
    /// Contains transfer service provider name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceProvidername")]
    [MaxLength(50)]
    public string? ServiceProvidername { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
