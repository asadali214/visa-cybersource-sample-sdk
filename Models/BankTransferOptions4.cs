using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankTransferOptions4
{
    /// <summary>
    /// Specifies the authorization method for the transaction.
    /// <para>
    /// #### TeleCheck
    /// Possible Values:
    /// - <c>ARC</c>: account receivable conversion
    /// - <c>CCD</c>: corporate cash disbursement
    /// - <c>POP</c>: point of purchase conversion
    /// - <c>PPD</c>: prearranged payment and deposit entry
    /// - <c>TEL</c>: telephone-initiated entry
    /// - <c>WEB</c>: internet-initiated entry
    /// </para>
    /// <para>
    /// # For details, see <c>ecp_sec_code</c> field description in the <see href="https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/">Electronic Check Services Using the SCMP API Guide.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SECCode")]
    [MaxLength(3)]
    public string? SecCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
