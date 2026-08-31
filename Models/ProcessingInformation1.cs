using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankTransferOptions")]
    public BankTransferOptions1? BankTransferOptions { get; init; }

    /// <summary>
    /// Type of digital payment solution for the transaction. Possible Values:
    /// <list type="bullet">
    ///   <item><description><c>visacheckout</c>: Visa Checkout. This value is required for Visa Checkout transactions. For details, see <c>payment_solution</c> field description in <see href="https://developer.cybersource.com/content/dam/docs/cybs/en-us/apifields/reference/all/rest/api-fields.pdf">Visa Checkout Using the REST API.</see></description></item>
    ///   <item><description><c>001</c>: Apple Pay.</description></item>
    ///   <item><description><c>004</c>: Cybersource In-App Solution.</description></item>
    ///   <item><description><c>005</c>: Masterpass. This value is required for Masterpass transactions on OmniPay Direct.</description></item>
    ///   <item><description><c>006</c>: Android Pay.</description></item>
    ///   <item><description><c>007</c>: Chase Pay.</description></item>
    ///   <item><description><c>008</c>: Samsung Pay.</description></item>
    ///   <item><description><c>012</c>: Google Pay.</description></item>
    ///   <item><description><c>013</c>: Cybersource P2PE Decryption</description></item>
    ///   <item><description><c>014</c>: Mastercard credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.</description></item>
    ///   <item><description><c>015</c>: Visa credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.</description></item>
    ///   <item><description><c>027</c>: Click to Pay.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentSolution")]
    [MaxLength(12)]
    public string? PaymentSolution { get; init; }

    /// <summary>
    /// The possible values for the reply field are:
    /// - <c>true</c> : the airline data was included in the request to the processor.
    /// - <c>false</c> : the airline data was not included in the request to the processor.
    /// <para>
    /// Returned by authorization, capture, or credit services.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedDataEnabled")]
    public bool? EnhancedDataEnabled { get; init; }

    /// <summary>
    /// Mastercard Digital Enablement Service (MDES) digital service indicators received in the authorization response message for MDES transactions.
    /// <para>
    /// This data is provided in the 0110 response in the Field 34—Acceptance Environment Data (TLV Format), Dataset ID 04—Additional Service Result Data, Tag DF1F—Mastercard Digital Enablement Service Indicator for Acquirer to acquirers.
    /// </para>
    /// <para>
    /// This field is in ANS, EBCDIC format and flows in Field 34, DSID 04 Tag DF1F, mapped to Mastercard Data Element DE119, Sub-element 004.
    /// </para>
    /// <para>
    /// This field is supported for all flavors of Authorization response only.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Authorization Response</b>
    /// Response field only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("digitalServiceIndicator")]
    [MaxLength(104)]
    public string? DigitalServiceIndicator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureOptions")]
    public CaptureOptions1? CaptureOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizationOptions")]
    public AuthorizationOptions1? AuthorizationOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseOptions")]
    public PurchaseOptions1? PurchaseOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
