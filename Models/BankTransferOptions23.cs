using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BankTransferOptions23
{
    /// <summary>
    /// Specifies the authorization method for the transaction.
    /// <para>
    /// Possible values:
    /// - <c>ARC</c>: account receivable conversion
    /// - <c>CCD</c>: corporate cash disbursement
    /// - <c>POP</c>: point of purchase conversion
    /// - <c>PPD</c>: prearranged payment and deposit entry
    /// - <c>TEL</c>: telephone-initiated entry
    /// - <c>WEB</c>: internet-initiated entry
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secCode")]
    public string? SecCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
