using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AggregatorInformation7
{
    /// <summary>
    /// Value that identifies you as a payment aggregator. Get this value from the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregatorId")]
    [MaxLength(20)]
    public string? AggregatorId { get; init; }

    /// <summary>
    /// Your payment aggregator business name. This field is conditionally required when aggregator id is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(37)]
    public string? Name { get; init; }

    /// <summary>
    /// Independent sales organization ID.
    /// This field is only used for Mastercard transactions submitted through PPGS.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("independentSalesOrganizationID")]
    [MaxLength(11)]
    public string? IndependentSalesOrganizationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant")]
    public SubMerchant7? SubMerchant { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
