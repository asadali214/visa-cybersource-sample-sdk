using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AggregatorInformation8
{
    /// <summary>
    /// Visa Direct(11 characters)
    /// Value that identifies you as a payment aggregator. Get this value from the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregatorId")]
    [MaxLength(20)]
    public string? AggregatorId { get; init; }

    /// <summary>
    /// Visa Direct(25 characters)
    /// Your payment aggregator business name. This field is conditionally required when aggregator id is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(37)]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant")]
    public SubMerchant8? SubMerchant { get; init; }

    /// <summary>
    /// Aggregator city.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    [MaxLength(100)]
    public string? City { get; init; }

    /// <summary>
    /// Aggregator country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? Country { get; init; }

    /// <summary>
    /// Aggregator postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(20)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Aggregator state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    [MaxLength(10)]
    public string? State { get; init; }

    /// <summary>
    /// Aggregator street name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streetAddress")]
    [MaxLength(150)]
    public string? StreetAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
