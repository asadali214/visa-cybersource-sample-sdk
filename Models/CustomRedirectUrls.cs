using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Object containing custom redirect URLs for different payment outcomes. Each property allows specifying a URL to which the customer will be redirected after a payment event.
/// </summary>
public record CustomRedirectUrls
{
    /// <summary>
    /// URL to redirect the customer after a successful payment. If not provided, the default page and message will be shown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccepted")]
    [MaxLength(500)]
    public string? PaymentAccepted { get; init; }

    /// <summary>
    /// URL to redirect the customer after a payment is rejected. If not provided, the default page and message will be shown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentRejected")]
    [MaxLength(500)]
    public string? PaymentRejected { get; init; }

    /// <summary>
    /// URL to redirect the customer after a payment is pending. If not provided, the default page and message will be shown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentPending")]
    [MaxLength(500)]
    public string? PaymentPending { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
