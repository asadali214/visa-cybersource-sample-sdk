using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ClientReferenceInformation48
{
    /// <summary>
    /// Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each
    /// transaction so that you can perform meaningful searches for the transaction.
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required field.
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being
    /// reversed.
    /// </para>
    /// <para>
    /// Required field for all PIN Debit requests (purchase, credit, and reversal).
    /// </para>
    /// <para>
    /// #### FDC Nashville Global
    /// Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [MaxLength(59)]
    public string? Code { get; init; }

    /// <summary>
    /// Used to resume a transaction that was paused for an order modification rule to allow for payer authentication to complete. To resume and continue with the authorization/decision service flow, call the services and include the request id from the prior decision call.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pausedRequestId")]
    [MaxLength(26)]
    public string? PausedRequestId { get; init; }

    /// <summary>
    /// Brief description of the order or any comment you wish to add to the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comments")]
    [MaxLength(255)]
    public string? Comments { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partner")]
    public Partner16? Partner { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
