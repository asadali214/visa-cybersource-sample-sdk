using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ResponseInsights
{
    /// <summary>
    /// Categorization of response message from processor
    /// <para>
    /// Possible Values:
    /// - <c>ISSUER_WILL_NEVER_APPROVE</c>
    /// - <c>ISSUER_CANNOT_APPROVE_AT_THIS_TIME</c>
    /// - <c>ISSUER_CANNOT_APPROVE_WITH_THESE_DETAILS</c>
    /// - <c>GENERIC_ERROR</c>
    /// - <c>PAYMENT_INSIGHTS_INTERNAL_ERROR</c>
    /// - <c>OTHERS</c>
    /// - <c>PAYMENT_INSIGHTS_RESPONSE_CATEGORY_MATCH_NOT_FOUND</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    [MaxLength(60)]
    public string? Category { get; init; }

    /// <summary>
    /// Categorization Code of response message from processor
    /// <para>
    /// Possible Values:
    /// - <c>01</c> : ISSUER_WILL_NEVER_APPROVE
    /// - <c>02</c> : ISSUER_CANNOT_APPROVE_AT_THIS_TIME
    /// - <c>03</c> : ISSUER_CANNOT_APPROVE_WITH_THESE_DETAILS
    /// - <c>04</c> : GENERIC_ERROR
    /// - <c>97</c> : PAYMENT_INSIGHTS_INTERNAL_ERROR
    /// - <c>98</c> : OTHERS
    /// - <c>99</c> : PAYMENT_INSIGHTS_RESPONSE_CATEGORY_MATCH_NOT_FOUND
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryCode")]
    [MaxLength(2)]
    public string? CategoryCode { get; init; }

    /// <summary>
    /// Raw name of the processor used for the transaction processing, especially useful during acquirer swing to see
    /// which processor transaction settled with
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorRawName")]
    [MaxLength(40)]
    public string? ProcessorRawName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
