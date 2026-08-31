using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessorInformation7
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network")]
    public Network? Network { get; init; }

    /// <summary>
    /// Field contains the response source code that identifies the source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseSourceCode")]
    [MaxLength(1)]
    public string? ResponseSourceCode { get; init; }

    /// <summary>
    /// Supplementary transaction data for Klarna Advantage Plus.
    /// Fields to capture Interoperability Data from Merchant and transfer to Klarna for Authorization/Sale/Re-Auth/Capture APIs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supplementaryTransactionData")]
    [MaxLength(10240)]
    public string? SupplementaryTransactionData { get; init; }

    /// <summary>
    /// Merchant Commercial Enhanced Data Program (CEDP) verified indicator for capture/bill requests.
    /// <para>
    /// This field is used when the client is doing authorization with a different gateway and capture/settlement with CyberSource.
    /// </para>
    /// <para>
    /// This field flows in ISO field 34, DSID 02 tag DA, in AN, EBCDIC format.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>Y</c>: Merchant CEDP verified
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Capture Request</b>
    /// Request field for force capture/bill support when auth is done with a different gateway.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cedpVerifiedIndicator")]
    [MaxLength(1)]
    public string? CedpVerifiedIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
