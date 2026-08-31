using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ApplicationInformation1
{
    /// <summary>
    /// Indicates the reason why a request succeeded or failed and possible action to take if a request fails.
    /// <para>
    /// For details, see the appendix of reason codes in the documentation for the relevant payment method.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasonCode")]
    public string? ReasonCode { get; init; }

    /// <summary>
    /// Indicates whether the service request was successful.
    /// Possible values:
    /// <list type="bullet">
    ///   <item><description><c>-1</c>: An error occurred.</description></item>
    ///   <item><description><c>0</c>: The request was declined.</description></item>
    ///   <item><description><c>1</c>: The request was successful.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rCode")]
    public string? RCode { get; init; }

    /// <summary>
    /// One-word description of the result of the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rFlag")]
    public string? RFlag { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applications")]
    public IReadOnlyList<Application1>? Applications { get; init; }

    /// <summary>
    /// The description for this field is not available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnCode")]
    public int? ReturnCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
