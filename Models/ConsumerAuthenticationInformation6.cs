using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ConsumerAuthenticationInformation6
{
    /// <summary>
    /// JSON Web Token (JWT) used to authenticate the consumer with the authentication provider, such as, CardinalCommerce or Rupay.
    /// Note - Max Length of this field is 2048 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }

    /// <summary>
    /// This identifier represents cardinal has started device data collection session and this must be passed in
    /// Authentication JWT to Cardinal when invoking the deviceDataCollectionUrl.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceId")]
    [MaxLength(50)]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The deviceDataCollectionUrl is the location to send the Authentication JWT when invoking the Device Data collection process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceDataCollectionUrl")]
    [MaxLength(100)]
    public string? DeviceDataCollectionUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
