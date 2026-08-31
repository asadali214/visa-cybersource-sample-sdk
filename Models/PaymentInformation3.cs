using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentInformation3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    public PaymentType1? PaymentType { get; init; }

    /// <summary>
    /// Mastercard One Credential merchant limited acceptance indicator. Mastercard One Credential connects multiple Mastercard payment methods and allows cardhollers to access various options and set payment preferences.
    /// <para>
    /// This field indicates which Mastercard One Credential funding PAN acceptance brands should NOT be assigned for this transaction.
    /// </para>
    /// <para>
    /// This field flows in ISO field 34, DSID 02 tag DB, mapped to Mastercard Data Element (DE) 48, Sub element 02, Subfield 01.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <c>C</c>: Do not assign a Mastercard One Credential funding PAN containing the Mastercard Credit Acceptance Brand for this transaction
    /// - <c>D</c>: Do not assign a Mastercard One Credential funding PAN containing the Debit Mastercard Acceptance Brand for this transaction
    /// - <c>M</c>: Do not assign a Mastercard One Credential funding PAN containing the Maestro Acceptance Brand for this transaction
    /// </para>
    /// <para>
    /// This field is supported for Authorization reversal request.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization Reversal Request</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantLimitedAcceptanceIndicator")]
    [MaxLength(1)]
    public string? MerchantLimitedAcceptanceIndicator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
