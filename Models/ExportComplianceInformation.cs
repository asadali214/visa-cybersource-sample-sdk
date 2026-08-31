using System.Collections.Generic;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ExportComplianceInformation
{
    /// <summary>
    /// Parts of the customer’s information that must match with an entry in the DPL (denied parties list)
    /// before a match occurs. This field can contain one of the following values:
    /// - AND: (default) The customer’s name or company and the customer’s address must appear in the database.
    /// - OR: The customer’s name must appear in the database.
    /// - IGNORE: You want the service to detect a match only of the customer’s name or company but not of the address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addressOperator")]
    public string? AddressOperator { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weights")]
    public Weights? Weights { get; init; }

    /// <summary>
    /// Use this field to specify which list(s) you want checked with the request.
    /// The reply will include the list name as well as the response data.
    /// To check against multiple lists, enter multiple list codes separated by a caret (^).
    /// For more information, see "Restricted and Denied Parties List," page 68.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sanctionLists")]
    public IReadOnlyList<string>? SanctionLists { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
