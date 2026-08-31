using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TravelInformation
{
    /// <summary>
    /// Duration of the auto rental or lodging rental.
    /// <para>
    /// #### Auto rental
    /// This field is supported for Visa, MasterCard, and American Express.
    /// <b>Important</b> If this field is not included when the <c>processingInformation.industryDataType</c> is auto rental,
    /// the transaction is declined.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    [MaxLength(2)]
    public string? Duration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agency")]
    public Agency? Agency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoRental")]
    public AutoRental? AutoRental { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging")]
    public Lodging? Lodging { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transit")]
    public Transit? Transit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vehicleData")]
    public VehicleData? VehicleData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
