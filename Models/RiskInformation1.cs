using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

/// <summary>
/// Contains the result of risk assessment.
/// </summary>
public record RiskInformation1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile")]
    public Profile1? Profile { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rules")]
    public IReadOnlyList<Rule>? Rules { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("infoCodes")]
    public InfoCodes? InfoCodes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("velocity")]
    public Velocity? Velocity { get; init; }

    /// <summary>
    /// You receive this field only if you subscribe to the Enhanced Case Management service. The priority level ranges from 1 (highest) to 5 (lowest); the default value is 3. If you do not assign a priority to your rules or to your profiles, the default value is given to the order.
    /// <para>
    /// For all possible values, see the <c>decision_case_priority</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("casePriority")]
    public int? CasePriority { get; init; }

    /// <summary>
    /// The customer's local time (<c>hh:mm:ss</c>), which is calculated from the transaction request time and the
    /// customer's billing address.
    /// <para>
    /// For details, see the <c>score_time_local</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localTime")]
    [MaxLength(255)]
    public string? LocalTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public Score? Score { get; init; }

    /// <summary>
    /// Contains detailed response information about the customer's IP address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public IpAddress? IpAddress { get; init; }

    /// <summary>
    /// Name of the 3rd party provider, for example, Emailage.
    /// For all possible values, see the <c>decision_provider_#_name</c> field description in the _Decision Manager Using the SCMP API Developer Guide_ on the <see href="https://ebc2.cybersource.com/ebc2/">CyberSource Business Center.</see> Click <b>Decision Manager</b> &gt; <b>Documentation</b> &gt; <b>Guides</b> &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("providers")]
    public IReadOnlyDictionary<string, string>? Providers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("travel")]
    public Travel? Travel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processorResults")]
    public ProcessorResults? ProcessorResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
