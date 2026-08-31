using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessingInformation61
{
    /// <summary>
    /// Payouts transaction type.
    /// <para>
    /// Applicable Processors: FDC Compass, Paymentech, CtV
    /// </para>
    /// <para>
    /// Possible values:
    /// </para>
    /// <para>
    /// <b>Credit Card Bill Payment</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>CP</b>: credit card bill payment</description></item>
    /// </list>
    /// <para>
    /// <b>Funds Disbursement</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>FD</b>: funds disbursement</description></item>
    ///   <item><description><b>GD</b>: government disbursement</description></item>
    ///   <item><description><b>MD</b>: merchant disbursement</description></item>
    /// </list>
    /// <para>
    /// <b>Money Transfer</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>AA</b>: account to account. Sender and receiver are same person.</description></item>
    ///   <item><description><b>PP</b>: person to person. Sender and receiver are different.</description></item>
    /// </list>
    /// <para>
    /// <b>Prepaid Load</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>TU</b>: top up</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessApplicationId")]
    [MaxLength(2)]
    public string? BusinessApplicationId { get; init; }

    /// <summary>
    /// This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only.
    /// The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order.
    /// Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.
    /// <para>
    /// VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order.
    /// If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer’s preference.
    /// If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer’s routing priorities.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkRoutingOrder")]
    [MaxLength(30)]
    public string? NetworkRoutingOrder { get; init; }

    /// <summary>
    /// Type of transaction.
    /// <para>
    /// Value for an OCT transaction:
    /// - <c>internet</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commerceIndicator")]
    [MaxLength(13)]
    public string? CommerceIndicator { get; init; }

    /// <summary>
    /// Please check with Cybersource customer support to see if your merchant account is configured correctly so you
    /// can include this field in your request.
    /// * For Payouts: max length for FDCCompass is String (22).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reconciliationId")]
    [MaxLength(60)]
    public string? ReconciliationId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutsOptions")]
    public PayoutsOptions? PayoutsOptions { get; init; }

    /// <summary>
    /// Transaction reason code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionReason")]
    [MaxLength(4)]
    public string? TransactionReason { get; init; }

    /// <summary>
    /// This field is applicable for AFT and OCT transactions. For list of supported values, please refer to Developer Guide.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purposeOfPayment")]
    [MaxLength(12)]
    public string? PurposeOfPayment { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingOptions")]
    public FundingOptions? FundingOptions { get; init; }

    /// <summary>
    /// Contains the ISO 639-2 defined language Code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("languageCode")]
    [MaxLength(10)]
    public string? LanguageCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchaseOptions")]
    public PurchaseOptions3? PurchaseOptions { get; init; }

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
