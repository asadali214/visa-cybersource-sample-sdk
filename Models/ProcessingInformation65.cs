using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation65
{
    /// <summary>
    /// &gt; This field is ignored when you provide the <c>subscriptionInformation.originalTransactionId</c> or update the subscription.
    /// <para>
    /// Commerce Indicator is a way to identify the type of transaction. Some payment card companies use this information when determining discount rates.
    /// </para>
    /// <para>
    /// Valid values:
    /// - <c>MOTO</c>
    /// - <c>RECURRING</c>
    /// - <c>INTERNET</c>
    /// </para>
    /// <para>
    /// Please add the ecommerce indicator based on the rules defined by your gateway/processor. Some gateways may not accept the Commerce Indicator <c>RECURRING</c> with a Zero Dollar Authorization, that is done for subscriptions starting at a future date.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commerceIndicator")]
    [MaxLength(20)]
    public string? CommerceIndicator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationOptions")]
    public RbsAuthorizationOptions? AuthorizationOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
