using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Partner33
{
    /// <summary>
    /// Identifier for the partner that is integrated to CyberSource.
    /// <para>
    /// Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.
    /// </para>
    /// <para>
    /// <b>Note</b> When you see a solutionId of 999 in reports, the solutionId that was submitted is incorrect.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("solutionId")]
    [MaxLength(8)]
    public string? SolutionId { get; init; }

    /// <summary>
    /// Value that identifies the application vendor and application version for a third party gateway.
    /// CyberSource provides you with this value during testing and validation.
    /// This field is supported only on CyberSource through VisaNet.
    /// <para>
    /// #### Used by
    /// <b>Authorization, Authorization Reversal, Capture, Credit, Incremental Authorization, and Void</b>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Required field for PIN debit credit, PIN debit purchase, or PIN debit reversal request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyCertificationNumber")]
    [MaxLength(12)]
    public string? ThirdPartyCertificationNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
