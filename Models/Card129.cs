using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Card129
{
    /// <summary>
    /// The customer’s payment card number, also known as the Primary Account Number (PAN). You can also use this field
    /// for encoded account numbers.
    /// <para>
    /// #### FDMS Nashville
    /// Required. String (19)
    /// </para>
    /// <para>
    /// #### GPX
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c>. However, this field is optional if your account is configured
    /// for relaxed requirements for address data and expiration date. <b>Important</b> It is your responsibility to determine
    /// whether a field is required for the transaction you are requesting.
    /// </para>
    /// <para>
    /// #### All other processors
    /// Required if <c>pointOfSaleInformation.entryMode=keyed</c>. However, this field is optional if your account is configured
    /// for relaxed requirements for address data and expiration date. <b>Important</b> It is your responsibility to determine
    /// whether a field is required for the transaction you are requesting.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [MaxLength(20)]
    public string? Number { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
