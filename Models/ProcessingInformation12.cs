using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation12
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankTransferOptions")]
    public BankTransferOptions3? BankTransferOptions { get; init; }

    /// <summary>
    /// The possible values for the reply field are:
    /// - <c>true</c> : the airline data was included in the request to the processor.
    /// - <c>false</c> : the airline data was not included in the request to the processor.
    /// <para>
    /// Returned by authorization, capture, or credit services.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedDataEnabled")]
    public bool? EnhancedDataEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
