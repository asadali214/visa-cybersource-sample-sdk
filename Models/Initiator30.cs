using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Initiator30
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originatorInitiatedTransaction")]
    public OriginatorInitiatedTransaction? OriginatorInitiatedTransaction { get; init; }

    /// <summary>
    /// This field indicates whether the transaction is a originator-initiated transaction or sender-initiated transaction.
    /// <para>
    /// Valid values:
    /// - <c>sender</c>
    /// - <c>originator</c>
    /// </para>
    /// <para>
    /// Conditional field. If value in this field is <c>originator</c>, this field is mandatory for originator-initated transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [MaxLength(10)]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates to an issuing bank whether an originator-initiated transaction came from a card that was already stored on file.
    /// <para>
    /// Possible values:
    /// - <c>True</c> = originator-initiated transaction came from a card that was already stored on file
    /// - <c>False</c> =  originator-initiated transaction came from a card that was not stored on file
    /// </para>
    /// <para>
    /// Conditional for MITCOF transactions
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedCredentialUsed")]
    public bool? StoredCredentialUsed { get; init; }

    /// <summary>
    /// Flag that indicates whether the transaction is the first originator-initiated transaction in a series, which means that the customer initiated the previous transaction.
    /// <para>
    /// Possible values:
    /// - <c>True</c>: First originator-initiated transaction
    /// - <c>False</c>: Not the first originator-initiated transaction
    /// </para>
    /// <para>
    /// Conditional for MITCOF transactions
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentialStoredOnFile")]
    public bool? CredentialStoredOnFile { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
