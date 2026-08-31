using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PullFundsReversal400Response1
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

    /// <summary>
    /// Possible values:
    /// - INVALID_REQUEST
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The reason of the status.
    /// <para>
    /// Possible values:
    /// - INVALID_DATA
    /// - MISSING_FIELD
    /// - INVALID_MERCHANT_CONFIGURATION
    /// - INVALID_REQUEST
    /// - INVALID_PAYMENT_ID
    /// - TRANSACTION_ALREADY_SETTLED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The detail message related to the status and reason listed above.
    /// <para>
    /// Possible values:
    /// - One or more fields in the request contains invalid data.
    /// - The request is missing one or more required fields.
    /// - Declined - There is a problem with your CyberSource merchant configuration.
    /// - Decline - The transaction has already been settled or reversed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<Detail103>? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
