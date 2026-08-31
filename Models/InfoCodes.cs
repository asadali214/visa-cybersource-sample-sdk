using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record InfoCodes
{
    /// <summary>
    /// List of information codes triggered by the order. These information codes were generated when you created
    /// the order and product velocity rules and are returned so that you can associate them with the rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("velocity")]
    public IReadOnlyList<string>? Velocity { get; init; }

    /// <summary>
    /// Indicates a mismatch between the customer’s billing and shipping addresses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public IReadOnlyList<string>? Address { get; init; }

    /// <summary>
    /// Indicates that customer information is associated with transactions that are either on the negative or
    /// the positive list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customerList")]
    public IReadOnlyList<string>? CustomerList { get; init; }

    /// <summary>
    /// Indicates the device behavior information code(s) returned from device fingerprinting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceBehavior")]
    public IReadOnlyList<string>? DeviceBehavior { get; init; }

    /// <summary>
    /// Indicates excessive identity changes. The threshold is variable depending on the identity elements being
    /// compared.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identityChange")]
    public IReadOnlyList<string>? IdentityChange { get; init; }

    /// <summary>
    /// Indicates a problem with the customer’s email address, IP address, or billing address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internet")]
    public IReadOnlyList<string>? Internet { get; init; }

    /// <summary>
    /// Indicates a problem with the customer’s phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public IReadOnlyList<string>? Phone { get; init; }

    /// <summary>
    /// Indicates that the customer provided potentially suspicious information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspicious")]
    public IReadOnlyList<string>? Suspicious { get; init; }

    /// <summary>
    /// Indicates that the customer has a high purchase frequency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("globalVelocity")]
    public IReadOnlyList<string>? GlobalVelocity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
