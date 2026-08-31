using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Initiator34
{
    /// <summary>
    /// This field indicates whether the transaction is a merchant-initiated transaction or customer-initiated transaction.
    /// <para>
    /// Valid values:
    /// - <b>customer</b>
    /// - <b>merchant</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates to the issuing bank two things:
    /// - The merchant has received consent from the cardholder to store their card details on file
    /// - The merchant wants the issuing bank to check out the card details before the merchant initiates their first transaction for this cardholder.
    /// The purpose of the merchant-initiated transaction is to ensure that the cardholder’s credentials are valid (that the card is not stolen or has restrictions) and that the card details are good to be stored on the merchant’s file for future transactions.
    /// <para>
    /// Valid values:
    /// - <c>Y</c> means merchant will use this transaction to store payment credentials for follow-up merchant-initiated transactions.
    /// - <c>N</c> means merchant will not use this transaction to store payment credentials for follow-up merchant-initiated transactions.
    /// </para>
    /// <para>
    /// <b>NOTE:</b> The value for this field does not correspond to any data in the TC 33 capture file5.
    /// </para>
    /// <para>
    /// This field is supported only for Visa transactions on CyberSource through VisaNet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentialStoredOnFile")]
    public string? CredentialStoredOnFile { get; init; }

    /// <summary>
    /// Indicates to an issuing bank whether a merchant-initiated transaction came from a card that was already stored on file.
    /// <para>
    /// Possible values:
    /// - <b>Y</b> means the merchant-initiated transaction came from a card that was already stored on file.
    /// - <b>N</b>  means the merchant-initiated transaction came from a card that was not stored on file.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedCredentialUsed")]
    public string? StoredCredentialUsed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantInitiatedTransaction")]
    public MerchantInitiatedTransactionObject? MerchantInitiatedTransaction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
