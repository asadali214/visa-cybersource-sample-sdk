using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TransientTokenResponseOptions
{
    /// <summary>
    /// Use the transientTokenResponseOptions.includeCardPrefix field to choose your preferred card number prefix length: 6-digit, 8-digit, or no card number prefix.
    /// <para>
    /// Possible values:
    /// - True
    /// - False&lt;br&gt;&lt;br&gt;
    /// </para>
    /// <para>
    /// To select the type of card number prefix:
    /// - No field included: A 6-digit prefix is returned (default)
    /// - True: An 8-digit prefix is returned
    /// - False: No prefix is returned&lt;br&gt;&lt;br&gt;
    /// </para>
    /// <para>
    /// The following conditions apply:
    /// - 8-digit card number prefixes only apply to Discover, JCB, Mastercard, UnionPay, and Visa brands with 16-digit card numbers or more.
    /// - Any card with less than 16-digit numbers will return a 6-digit prefix even when the transientTokenResponseOptions.includeCardPrefix field is set to true.
    /// - Any card brand other than Discover, JCB, Mastercard, UnionPay, or Visa will return a 6-digit prefix even when the transientTokenResponseOptions.includeCardPrefix field is set to true.
    /// - If any card brand is co-branded with Discover, JCB, Mastercard, UnionPay, or Visa, an 8-digit prefix will be returned if the transientTokenResponseOptions.includeCardPrefix field is set to true.&lt;br&gt;&lt;br&gt;
    /// </para>
    /// <para>
    /// <b>Important:</b>
    /// If your application does NOT require a card number prefix for routing or identification purposes, set the transientTokenResponseOptions.includeCardPrefix field to False.  This will minimize your personal data exposure.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeCardPrefix")]
    public bool? IncludeCardPrefix { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
