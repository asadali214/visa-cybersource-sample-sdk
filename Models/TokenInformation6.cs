using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TokenInformation6
{
    /// <summary>
    /// A temporary ID that represents the customer's payment data (which is securely stored in Visa Data Centers). Flex
    /// Microform generates this ID and sets it to expire within 15 minutes from when the ID is generated or until the
    /// first payment authorization is carried out (whichever occurs first).
    /// <para>
    /// Valid value for the ID is a 64-character, alphanumeric string.
    /// </para>
    /// <para>
    /// Example: 1D08M4YB968R1F7YVL4TBBKYVNRIR02VZFH9CBYSQIJJXORPI1NK5C98D7F6EB53
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transientToken")]
    public string? TransientToken { get; init; }

    /// <summary>
    /// TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jti")]
    [MaxLength(64)]
    public string? Jti { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
