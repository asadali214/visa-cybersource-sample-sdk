using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BuyerInformation6
{
    /// <summary>
    /// Your identifier for the customer.
    /// <para>
    /// When a subscription or customer profile is being created, the maximum length for this field for most processors is 30. Otherwise, the maximum length is 100.
    /// </para>
    /// <para>
    /// #### SEPA/BACS
    /// Required for Create Mandate and Import Mandate
    /// </para>
    /// <para>
    /// #### Comercio Latino
    /// For recurring payments in Mexico, the value is the customer’s contract number.
    /// Note Before you request the authorization, you must inform the issuer of the customer contract numbers that will be used for recurring transactions.
    /// </para>
    /// <para>
    /// #### Worldpay VAP
    /// For a follow-on credit with Worldpay VAP, CyberSource checks the following locations, in the order
    /// given, for a customer account ID value and uses the first value it finds:
    /// 1. <c>customer_account_id</c> value in the follow-on credit request
    /// 2. Customer account ID value that was used for the capture that is being credited
    /// 3. Customer account ID value that was used for the original authorization
    /// If a customer account ID value cannot be found in any of these locations, then no value is used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCustomerId")]
    [MaxLength(100)]
    public string? MerchantCustomerId { get; init; }

    /// <summary>
    /// Recipient’s date of birth. <b>Format</b>: <c>YYYYMMDD</c>.
    /// <para>
    /// This field is a <c>pass-through</c>, which means that CyberSource ensures that the value is eight numeric characters
    /// but otherwise does not verify the value or modify it in any way before sending it to the processor. If the field
    /// is not required for the transaction, CyberSource does not forward it to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    [MaxLength(8)]
    public string? DateOfBirth { get; init; }

    /// <summary>
    /// Customer's gender. Possible values are F (female), M (male), O (other).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender")]
    [MaxLength(1)]
    public string? Gender { get; init; }

    /// <summary>
    /// language setting of the user
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    [MaxLength(5)]
    public string? Language { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
