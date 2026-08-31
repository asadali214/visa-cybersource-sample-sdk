using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PullFunds201Response
{
    /// <summary>
    /// A unique identification number to identify the submitted request. It is also appended to the endpoint of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(26)]
    public string? Id { get; init; }

    /// <summary>
    /// Time of request in UTC.
    /// Format: <c>YYYY-MM-DDThh:mm:ssZ</c>
    /// <para>
    /// <b>Example</b>
    /// <c>2016-08-11T22:47:57Z</c> equals August 11, 2016, at 22:47:57 (10:47:57 p.m.).
    /// The <c>T</c> separates the date and the time.
    /// The <c>Z</c> indicates UTC.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submitTimeUtc")]
    [StringLength(20, MinimumLength = 20)]
    public string? SubmitTimeUtc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderInformation")]
    public OrderInformation46? OrderInformation { get; init; }

    /// <summary>
    /// The status of the submitted transaction.
    /// <para>
    /// Possible values:
    /// - AUTHORIZED
    /// - DECLINED
    /// - SERVER_ERROR
    /// - INVALID_REQUEST
    /// - PARTIAL_AUTHORIZED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    [MaxLength(18)]
    public string? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorInformation")]
    public ErrorInformation30? ErrorInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorInformation")]
    public ProcessorInformation31? ProcessorInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links223? Links { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
