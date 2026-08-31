using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails3
{
    /// <summary>
    /// Additional charges that have to be authorized against a lodging or auto-rental order.
    /// This value cannot be negative. You can include a decimal point (.), but no other special characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalAmount")]
    [MaxLength(19)]
    public string? AdditionalAmount { get; init; }

    /// <summary>
    /// Currency used for the order. Use the three-character <see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// <para>
    /// #### Used by
    /// <b>Authorization</b>
    /// Required field.
    /// </para>
    /// <para>
    /// <b>Authorization Reversal</b>
    /// For an authorization reversal (<c>reversalInformation</c>) or a capture (<c>processingOptions.capture</c> is set to <c>true</c>), you must use the same currency that you used in your payment authorization request.
    /// </para>
    /// <para>
    /// #### PIN Debit
    /// Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes</see>.
    /// Returned by PIN debit purchase.
    /// </para>
    /// <para>
    /// For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing.
    /// For the possible values, see the <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes</see>.
    /// </para>
    /// <para>
    /// Required field for PIN Debit purchase and PIN Debit credit requests.
    /// Optional field for PIN Debit reversal requests.
    /// </para>
    /// <para>
    /// #### GPX
    /// This field is optional for reversing an authorization or credit.
    /// </para>
    /// <para>
    /// #### DCC for First Data
    /// Your local currency.
    /// </para>
    /// <para>
    /// #### Tax Calculation
    /// Required for international tax and value added tax only.
    /// Optional for U.S. and Canadian taxes.
    /// Your local currency.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(3)]
    public string? Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
