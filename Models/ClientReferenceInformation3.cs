using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ClientReferenceInformation3
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
