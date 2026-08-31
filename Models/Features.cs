using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Features
{
    /// <summary>
    /// This field contains the account funding source.
    /// Possible values:
    ///   - <c>CREDIT</c>
    ///   - <c>DEBIT</c>
    ///   - <c>PREPAID</c>
    ///   - <c>DEFERRED DEBIT</c>
    ///   - <c>CHARGE</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountFundingSource")]
    [MaxLength(20)]
    public string? AccountFundingSource { get; init; }

    /// <summary>
    /// This field contains the type of prepaid card.
    /// Possible values:
    ///   - <c>Reloadable</c>
    ///   - <c>Non-reloadable</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountFundingSourceSubType")]
    [MaxLength(20)]
    public string? AccountFundingSourceSubType { get; init; }

    /// <summary>
    /// This field contains the type of issuer product.
    /// Example values:
    ///   - Visa Classic
    ///   - Visa Signature
    ///   - Visa Infinite
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardProduct")]
    [MaxLength(50)]
    public string? CardProduct { get; init; }

    /// <summary>
    /// This field contains the type of BIN based authentication.
    /// Possible values:
    ///   - <c>S</c>: Single Message
    ///   - <c>D</c>: Dual Message
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageType")]
    [MaxLength(1)]
    public string? MessageType { get; init; }

    /// <summary>
    /// This field contains the acceptance level of the PAN.
    /// Possible values:
    ///   - <c>0</c> : Normal
    ///   - <c>1</c> : Monitor
    ///   - <c>2</c> : Refuse
    ///   - <c>3</c> : Not Allowed
    ///   - <c>4</c> : Private
    ///   - <c>5</c> : Test
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptanceLevel")]
    [MaxLength(2)]
    public string? AcceptanceLevel { get; init; }

    /// <summary>
    /// This field contains the type of card platform.
    /// Possible values:
    ///   - <c>BUSINESS</c>
    ///   - <c>CONSUMER</c>
    ///   - <c>CORPORATE</c>
    ///   - <c>COMMERCIAL</c>
    ///   - <c>GOVERNMENT</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardPlatform")]
    [MaxLength(20)]
    public string? CardPlatform { get; init; }

    /// <summary>
    /// This field indicates the type of combo card.
    /// Possible values:
    ///   - 0 (Not a combo card)
    ///   - 1 (Credit and Prepaid Combo card)
    ///   - 2 (Credit and Debit Combo card)
    ///   - 3 (Prepaid Credit and Prepaid Debit combo card)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comboCard")]
    [MaxLength(1)]
    public string? ComboCard { get; init; }

    /// <summary>
    /// This field indicates if the instrument can be used for corporate purchasing. This field is only applicable for American Express cards.
    /// Possible values:
    ///   - <c>true</c>
    ///   - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("corporatePurchase")]
    public bool? CorporatePurchase { get; init; }

    /// <summary>
    /// This field indicates if the BIN is for healthcare (HSA/FSA). Currently, this field is only supported for Visa BINs.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healthCard")]
    public bool? HealthCard { get; init; }

    /// <summary>
    /// This field indicates if the BIN is shared by multiple issuers
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sharedBIN")]
    public bool? SharedBin { get; init; }

    /// <summary>
    /// This field indicates if the BIN is valid only for POS domestic usage.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("posDomesticOnly")]
    public bool? PosDomesticOnly { get; init; }

    /// <summary>
    /// This field indicates if gambling transactions are allowed on the BIN.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gamblingAllowed")]
    public bool? GamblingAllowed { get; init; }

    /// <summary>
    /// This field indicates if a transaction on the instrument qualifies for level 2 interchange rates.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commercialCardLevel2")]
    public bool? CommercialCardLevel2 { get; init; }

    /// <summary>
    /// This field indicates if a transaction on the instrument qualifies for level 3 interchange rates.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commercialCardLevel3")]
    public bool? CommercialCardLevel3 { get; init; }

    /// <summary>
    /// This field indicates if a transaction on the instrument qualifies for government exempt interchange fee.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemptBIN")]
    public bool? ExemptBin { get; init; }

    /// <summary>
    /// This field indicates if the BIN participates in Account Level Management (ALM).
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountLevelManagement")]
    public bool? AccountLevelManagement { get; init; }

    /// <summary>
    /// This field indicates if online gambling is blocked on the BIN.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onlineGamblingBlock")]
    public bool? OnlineGamblingBlock { get; init; }

    /// <summary>
    /// This field indicates if auto-substantiation is enabled on the BIN.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoSubstantiation")]
    public bool? AutoSubstantiation { get; init; }

    /// <summary>
    /// This field indicates if the instrument is a flex credential.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flexCredential")]
    public bool? FlexCredential { get; init; }

    /// <summary>
    /// This field contains the Visa-assigned product identifier associated with the BIN. This field is only supported for Visa BINs.
    /// Example values:
    ///   - Q4
    ///   - P
    ///   - AX
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productId")]
    public string? ProductId { get; init; }

    /// <summary>
    /// This field contains the Visa-assigned product subtype identifier associated with the BIN. This field is only supported for Visa BINs.
    /// Example values:
    ///   - BB
    ///   - EX
    ///   - L2
    ///   - C2
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("productIdSubtype")]
    public string? ProductIdSubtype { get; init; }

    /// <summary>
    /// This field indicates if the payment instrument supports 3D Secure authentication.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSSupport")]
    public bool? ThreeDsSupport { get; init; }

    /// <summary>
    /// This field indicates if the payment instrument is eligible for Standing Instructions (recurring payments).
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("siEligible")]
    public bool? SiEligible { get; init; }

    /// <summary>
    /// This field indicates if the payment instrument is eligible for Equated Monthly Installments (EMI).
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emiEligible")]
    public bool? EmiEligible { get; init; }

    /// <summary>
    /// This field indicates if the BIN is designated for fuel/fleet usage. These specialized BINs support additional Level2/Level 3 transaction data.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fleetCard")]
    public bool? FleetCard { get; init; }

    /// <summary>
    /// This field indicates if the payment instrument is enabled for ATM usage.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("atmEnabled")]
    public bool? AtmEnabled { get; init; }

    /// <summary>
    /// This field indicates if the payment instrument is enabled for POS usage.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("posEnabled")]
    public bool? PosEnabled { get; init; }

    /// <summary>
    /// This field indicates if the payment instrument is enabled for ECOM usage.
    /// Possible values:
    ///     - <c>true</c>
    ///     - <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecomEnabled")]
    public bool? EcomEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
