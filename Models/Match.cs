using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Match
{
    /// <summary>
    /// Address found on the list specified in export_matchN_list
    /// for the entity (name and address) in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addresses")]
    public IReadOnlyList<string>? Addresses { get; init; }

    /// <summary>
    /// List on which the first Denied Parties List check match appears.
    /// For a list of codes, see "Denied Parties List Check Codes," page 56.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sanctionList")]
    [MaxLength(255)]
    public string? SanctionList { get; init; }

    /// <summary>
    /// Name found on the list specified in export_matchN_list for the entity (name and address) in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliases")]
    public IReadOnlyList<string>? Aliases { get; init; }

    /// <summary>
    /// Sub-lists matched by the order data. List members are separated by carets (^).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("programs")]
    public IReadOnlyList<string>? Programs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
