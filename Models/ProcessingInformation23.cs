using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation23
{
    /// <summary>
    /// Will have 2 values, 'U' (Update) , 'N' (New). Any other values will be rejected. Default will be 'N'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionType")]
    [MaxLength(5)]
    public string? SessionType { get; init; }

    /// <summary>
    /// Whether merchant wants to pass the flow Inline or want to invoke Klarna Hosted Page
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentFlowMode")]
    [MaxLength(50)]
    public string? PaymentFlowMode { get; init; }

    /// <summary>
    /// Possible values are one or more of follows:
    /// <list type="bullet">
    ///   <item><description><c>AP_SESSIONS</c>: Use this when Alternative Payment Sessions service is requested.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
