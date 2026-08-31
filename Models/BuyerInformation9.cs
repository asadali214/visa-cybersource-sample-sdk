using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BuyerInformation9
{
    /// <summary>
    /// Recipient’s date of birth. <b>Format</b>: <c>YYYYMMDD</c>.
    /// <para>
    /// This field is a <c>pass-through</c>, which means that CyberSource ensures that the value is eight numeric characters
    /// but otherwise does not verify the value or modify it in any way before sending it to the processor. If the field
    /// is not required for the transaction, CyberSource does not forward it to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    [MaxLength(8)]
    public string? DateOfBirth { get; init; }

    /// <summary>
    /// Customer's gender. Possible values are F (female), M (male),O (other).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender")]
    [MaxLength(3)]
    public string? Gender { get; init; }

    /// <summary>
    /// language setting of the user.
    /// Supports 2-character language codes (e.g., en, fr) and 5-character locale values (e.g., en-US, fr-CA).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    [MaxLength(5)]
    public string? Language { get; init; }

    /// <summary>
    /// Note to the recipient of the funds in this transaction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("noteToSeller")]
    [MaxLength(255)]
    public string? NoteToSeller { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdentification")]
    public IReadOnlyList<PersonalIdentification2>? PersonalIdentification { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
