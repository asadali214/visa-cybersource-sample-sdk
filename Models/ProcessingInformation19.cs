using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation19
{
    /// <summary>
    /// Type of transaction. Used to determine fees based on channel.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>aesk: American Express SafeKey authentication was successful.</description></item>
    ///   <item><description>aesk_attempted: American Express SafeKey authentication was attempted but did not succeed. • install: Installment payment.</description></item>
    ///   <item><description>install_internet: Non-U.S. e-commerce (Internet) installment payment. This value is supported only on Visa Platform Connect.</description></item>
    ///   <item><description>internet (default for authorizations): E-commerce order placed using a web site.</description></item>
    ///   <item><description>js: JCB J/Secure authentication was successful.</description></item>
    ///   <item><description>js_attempted: JCB J/Secure authentication was attempted but did not succeed.</description></item>
    ///   <item><description>moto: Mail order or telephone order.</description></item>
    ///   <item><description>moto_cc: Mail order or telephone order from a call center. This value is supported only on the Asia, Middle East, and Africa Gateway.</description></item>
    ///   <item><description>pb: ProtectBuy authentication was successful.</description></item>
    ///   <item><description>pb_attempted: ProtectBuy authentication was attempted but did not succeed.</description></item>
    ///   <item><description>recurring: Recurring payment that is a U.S. transaction or non-U.S. mail order / telephone order (MOTO) transaction.</description></item>
    ///   <item><description>recurring_internet: Recurring payment that is a non-U.S. e-commerce (Internet) transaction.</description></item>
    ///   <item><description>retail: Card-present transaction.</description></item>
    ///   <item><description>spa: For Mastercard Identity Check: Authentication was successful or was attempted but did not succeed. The e-commerce indicator for all Mastercard Identity Check transactions, including authentication attempts, must be set to spa.</description></item>
    ///   <item><description>spa_attempted: Authentication for a co-badged Mastercard and Cartes Bancaires card was attempted but did not succeed.</description></item>
    ///   <item><description>spa_failure: – For Mastercard Identity Check: Authentication failed. This value is supported only on Elavon, HSBC, and Streamline.</description></item>
    ///   <item><description>vbv: – For Visa Secure: Authentication was successful.</description></item>
    ///   <item><description>vbv_attempted: – For Visa Secure: Authentication was attempted but did not succeed.</description></item>
    ///   <item><description>vbv_failure: – For Visa Secure: Authentication failed. This value is supported only on HSBC and Streamline.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commerceIndicator")]
    [MaxLength(20)]
    public string? CommerceIndicator { get; init; }

    /// <summary>
    /// Period after which an authorization request to the consumer expires due to inactivity. Value in seconds (e.g., 86400 for one day).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentCompletionTimeout")]
    [MaxLength(7)]
    public string? PaymentCompletionTimeout { get; init; }

    /// <summary>
    /// <list type="bullet">
    ///   <item><description>Use <c>CONSUMER_AUTHENTICATION</c> to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run.</description></item>
    ///   <item><description>Use <c>WATCHLIST_SCREENING</c>  when you want to call Watchlist Screening service.</description></item>
    ///   <item><description>Use <c>UPDATE_AGREEMENT</c></description></item>
    ///   <item><description>Use <c>BILLING_AGREEMENT_CREATE</c> when Alternative Payment create mandate service is requested</description></item>
    ///   <item><description>Use <c>CANCEL_AGREEMENT</c></description></item>
    ///   <item><description>Use <c>AP_IMPORT_AGREEMENT</c> when Alternative Payment import mandate service is requested.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionList")]
    public IReadOnlyList<string>? ActionList { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
