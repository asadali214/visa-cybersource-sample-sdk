using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CustomerAccount
{
    /// <summary>
    /// Date the cardholder’s account was last changed.
    /// This includes changes to the billing or shipping address, new payment accounts or new users added.
    /// Recommended for Discover ProtectBuy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastChangeDate")]
    [MaxLength(10)]
    public string? LastChangeDate { get; init; }

    /// <summary>
    /// The values from the enum can be:
    /// - GUEST
    /// - NEW_ACCOUNT
    /// - EXISTING_ACCOUNT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationHistory")]
    public string? CreationHistory { get; init; }

    /// <summary>
    /// This field is applicable only in case of EXISTING_ACCOUNT in creationHistory. Possible values:
    /// - ACCOUNT_UPDATED_NOW
    /// - ACCOUNT_UPDATED_PAST
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationHistory")]
    public string? ModificationHistory { get; init; }

    /// <summary>
    /// This only applies for EXISTING_ACCOUNT in creationHistory.
    /// The values from the enum can be:
    /// - PASSWORD_CHANGED_NOW
    /// - PASSWORD_CHANGED_PAST
    /// - PASSWORD_NEVER_CHANGED
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passwordHistory")]
    public string? PasswordHistory { get; init; }

    /// <summary>
    /// Date the cardholder opened the account.
    /// Recommended for Discover ProtectBuy.
    /// This only applies for EXISTING_ACCOUNT in creationHistory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createDate")]
    [MaxLength(10)]
    public string? CreateDate { get; init; }

    /// <summary>
    /// Date the cardholder last changed or reset password on account.
    /// Recommended for Discover ProtectBuy.
    /// This only applies for PASSWORD_CHANGED_PAST in passwordHistory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passwordChangeDate")]
    [MaxLength(10)]
    public string? PasswordChangeDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
