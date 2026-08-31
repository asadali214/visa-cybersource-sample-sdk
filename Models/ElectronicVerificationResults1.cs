using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ElectronicVerificationResults1
{
    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer's email address.
    /// <para>
    /// Valid values:
    /// - '1': Verified
    /// - '2': Failed
    /// - '3': Not performed
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emailRaw")]
    [MaxLength(1)]
    public string? EmailRaw { get; init; }

    /// <summary>
    /// Raw electronic verification response code from the processor for the customer's first name.
    /// <para>
    /// Valid values:
    /// - '01': Match
    /// - '50': Partial Match
    /// - '99': No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstNameRaw")]
    [MaxLength(2)]
    public string? FirstNameRaw { get; init; }

    /// <summary>
    /// Raw electronic verification response code from the processor for the customer's last name.
    /// <para>
    /// Valid values:
    /// - '01': Match
    /// - '50': Partial Match
    /// - '99': No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastNameRaw")]
    [MaxLength(2)]
    public string? LastNameRaw { get; init; }

    /// <summary>
    /// Raw electronic verification response code from the processor for the customer's middle name.
    /// <para>
    /// Valid values:
    /// - '01': Match
    /// - '50': Partial Match
    /// - '99': No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleNameRaw")]
    [MaxLength(2)]
    public string? MiddleNameRaw { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer's name.
    /// <para>
    /// Valid values:
    /// - '01': Match
    /// - '50': Partial Match
    /// - '99': No Match
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nameRaw")]
    [MaxLength(2)]
    public string? NameRaw { get; init; }

    /// <summary>
    /// Raw Electronic Verification response code from the processor for the customer's phone number.
    /// <para>
    /// Valid values:
    /// - '1': Verified
    /// - '2': Failed
    /// - '3': Not performed
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumberRaw")]
    [MaxLength(1)]
    public string? PhoneNumberRaw { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
