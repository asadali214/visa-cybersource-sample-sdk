using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation57
{
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
    /// Identifier for the <b>Visa Checkout</b> order. Visa Checkout provides a unique order ID for every transaction in
    /// the Visa Checkout <b>callID</b> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaCheckoutId")]
    [MaxLength(48)]
    public string? VisaCheckoutId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
