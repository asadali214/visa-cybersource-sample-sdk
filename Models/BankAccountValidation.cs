using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankAccountValidation
{
    /// <summary>
    /// Raw Validation Codes for routing number and account number
    /// <para>
    ///     Possible values:
    ///     • -1: Unable to perform validation/Unknown error
    ///     • -2: Service Unavailable
    ///     • 12 to 16: Validation results
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rawValidationCode")]
    public int? RawValidationCode { get; init; }

    /// <summary>
    /// Result codes for account number and routing number
    /// <para>
    ///     Possible values: 00, 04, 98, 99
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public int? ResultCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultMessage")]
    public string? ResultMessage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
