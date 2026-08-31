using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ServiceFeeDescriptor
{
    /// <summary>
    /// Name of the service provider that is collecting the service fee. The service provider name must consist of
    /// 3, 7, or 12 characters followed by an asterisk (*). This value must also include the words “Service Fee.”
    /// <para>
    /// When you include more than one consecutive space, extra spaces are removed. Use one of the following formats
    /// for this value:
    /// - &lt;3-character name&gt;*Service Fee
    /// - &lt;7-character name&gt;*Service Fee
    /// - &lt;12-character name&gt;*Service Fee
    /// </para>
    /// <para>
    /// When payments are made in installments, this value must also include installment information such as
    /// “1 of 5” or “3 of 7.” For installment payments, use one of the following formats for this value:
    /// - &lt;3-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt;
    /// - &lt;7-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt;
    /// - &lt;12-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt;
    /// </para>
    /// <para>
    /// where &lt;N&gt; is the payment number and &lt;M&gt; is the total number of payments.
    /// </para>
    /// <para>
    /// When you do not include this value in your request, CyberSource uses the value that is in your CyberSource
    /// account.
    /// </para>
    /// <para>
    /// This value might be displayed on the cardholder’s statement.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(22)]
    public string? Name { get; init; }

    /// <summary>
    /// Contact information for the service provider that is collecting the service fee. when you include more than one
    /// consecutive space, extra spaces are removed.
    /// <para>
    /// When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.
    /// </para>
    /// <para>
    /// This value might be displayed on the cardholder’s statement.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contact")]
    [MaxLength(11)]
    public string? Contact { get; init; }

    /// <summary>
    /// State or territory in which the service provider is located.
    /// <para>
    /// When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.
    /// </para>
    /// <para>
    /// This value might be displayed on the cardholder’s statement.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    [MaxLength(20)]
    public string? State { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
