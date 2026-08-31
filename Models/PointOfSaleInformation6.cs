using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PointOfSaleInformation6
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emv")]
    public Emv6? Emv { get; init; }

    /// <summary>
    /// Point-of-sale details for the transaction. This value is returned only for <b>American Express Direct</b>.
    /// CyberSource generates this value, which consists of a series of codes that identify terminal capability,
    /// security data, and specific conditions present at the time the transaction occurred. To comply with the CAPN
    /// requirements, this value must be included in all subsequent follow-on requests, such as captures and follow-on
    /// credits.
    /// <para>
    /// When you perform authorizations, captures, and credits through CyberSource, CyberSource passes this value from
    /// the authorization service to the subsequent services for you. However, when you perform authorizations through
    /// CyberSource and perform subsequent services through other financial institutions, you must ensure that your
    /// requests for captures and credits include this value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amexCapnData")]
    [MaxLength(15)]
    public string? AmexCapnData { get; init; }

    /// <summary>
    /// Identifies the Zone PIN Key (ZPK) used for Online PIN processing by providing the 10‑digit Key Set Identifier (KSI).
    /// This value indicates that the PIN block is encrypted under a ZPK and enables the Payment Security Service (PSS) to perform
    /// the correct ZPK→ZPK PIN translation during card‑present EMV PIN transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedKeyId")]
    [MaxLength(100)]
    public string? EncryptedKeyId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
