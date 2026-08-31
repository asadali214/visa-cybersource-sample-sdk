using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation63
{
    /// <summary>
    /// Type of transaction. This field identifies the level of security used in an electronic commerce transaction over an open network (for example, the internet).
    /// <para>
    /// Values for a Payouts transaction:
    /// <c>INTERNET</c>, <c>RECURRING</c>, <c>RECURRING_INTERNET</c>, <c>VBV_FAILURE</c>, <c>VBV_ATTEMPTED</c>, <c>VBV</c>, <c>SPA_FAILURE</c>, <c>SPA_ATTEMPTED</c>, <c>SPA</c>
    /// </para>
    /// <para>
    /// If no value is entered this field will set a default value = <c>INTERNET</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commerceIndicator")]
    [MaxLength(18)]
    public string? CommerceIndicator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingOptions")]
    public AftFundingOptions? FundingOptions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringOptions")]
    public RecurringOptions4? RecurringOptions { get; init; }

    /// <summary>
    /// Payouts transaction type.
    /// <para>
    /// Possible Values:
    /// - <c>AA</c> = Account to account
    /// - <c>PP</c> = Person to person
    /// - <c>TU</c> = Top-up for enhanced prepaid loads
    /// - <c>WT</c> = Wallet transfer
    /// - <c>BI</c> = Bank-Initiated
    /// - <c>FT</c> = Funds Transfer
    /// - <c>FD</c> = Funds Disbursement
    /// - <c>MP</c> = Merchant Payment
    /// - <c>PD</c> = Payroll Disbursement
    /// - <c>LA</c> = Liquid Assets
    /// </para>
    /// </summary>
    [JsonPropertyName("businessApplicationId")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public required string BusinessApplicationId { get; init; }

    /// <summary>
    /// Visa Direct
    /// Purpose of payment is required in certain markets to clearly identify the purpose of the payment based on the standard values defined for respective market.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purposeOfPayment")]
    [MaxLength(12)]
    public string? PurposeOfPayment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutsOptions")]
    public PayoutsOptions1? PayoutsOptions { get; init; }

    /// <summary>
    /// Contains the ISO 639-2 defined language Code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("languageCode")]
    [MaxLength(3)]
    public string? LanguageCode { get; init; }

    /// <summary>
    /// Account verification code will inform what Payment Account Verification should be performed. With this array of codes, a merchant can choose à la carte what verifications to run. This field is optional, and the default is 1 if it is not passed in. This means that a full validation of the fields will be performed.
    /// Valid verification codes:
    /// - <c>1</c> = Full Account Verification (Card Account, CVN, CAVV, TAVV, Address, Name, eMail, Phone, Identity)
    /// - <c>2</c> = Card Account Verification
    /// - <c>3</c> = Address Verification
    /// - <c>4</c> = Card Authentication Method (CAM) (Cryptogram)
    /// - <c>5</c> = Cardholder Authentication Verification (CAVV)
    /// - <c>6</c> = Cardholder Identity Verification
    /// - <c>7</c> = CVV2 Verification
    /// - <c>8</c> = eMail Verification
    /// - <c>9</c> = Name Verification
    /// - <c>10</c> = Phone Verification
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountVerificationCode")]
    public IReadOnlyList<string>? AccountVerificationCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
