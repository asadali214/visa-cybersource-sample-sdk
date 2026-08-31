using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AmountDetails46
{
    /// <summary>
    /// Length: &lt;=12. Up to 3 decimal places.
    /// Type: String, with a non-negative double format.
    /// <para>
    /// The total amount of the AFT refund including all fees.
    /// a. an amount that is &lt;= the totalAmount of the original AFT
    /// b. The amount of the transaction, inclusive of all fees assessed for the transaction, including currency conversion fees.
    ///     Minimum Value: Field must be greater than zero: minimum value is the smallest amount in any given currency.
    /// c. Multiple successful reversals &amp; refunds of the original AFT transaction are allowed but the sum of the transaction amounts must not total more than the original AFT totalAmount.
    /// </para>
    /// </summary>
    [JsonPropertyName("totalAmount")]
    [MaxLength(12)]
    public required string TotalAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
