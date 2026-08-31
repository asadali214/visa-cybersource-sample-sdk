using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Customer63
{
    /// <summary>
    /// Unique identifier for the customer's card and billing information.
    /// <para>
    /// When you use Payment Tokenization or Recurring Billing and you include this value in
    /// your request, many of the fields that are normally required for an authorization or credit
    /// become optional.
    /// </para>
    /// <para>
    /// <b>NOTE</b> When you use Payment Tokenization or Recurring Billing, the value for the Customer ID is actually the Cybersource payment token for a customer. This token stores information such as the consumer’s card number so it can be applied towards bill payments, recurring payments, or one-time payments. By using this token in a payment API request, the merchant doesn't need to pass in data such as the card number or expiration date in the request itself.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// Unique identifier for the Customer token that was created as part of a bundled TOKEN_CREATE action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(32, MinimumLength = 1)]
    public string? Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
