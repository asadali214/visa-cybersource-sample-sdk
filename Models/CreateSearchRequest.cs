using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record CreateSearchRequest
{
    /// <summary>
    /// Indicates whether or not you want to save this search request for future use. The options are:
    /// <list type="bullet">
    ///   <item><description><c>true</c></description></item>
    ///   <item><description><c>false</c> (default value)</description></item>
    /// </list>
    /// <para>
    /// If set to <c>true</c>, this field returns
    /// <c>searchID</c> in the response. You can use this value to retrieve the details of the saved search.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("save")]
    public bool? Save { get; init; }

    /// <summary>
    /// Name of this search. When <c>save</c> is set to <c>true</c>, this search is saved with this name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Merchant’s time zone in ISO standard, using the TZ database format. For example: <c>America/Chicago</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// String that contains the filters and variables for which you want to search. For information about supported field-filters and operators, see the <see href=" https://developer.cybersource.com/api/developer-guides/dita-txn-search-details-rest-api-dev-guide-102718/txn-search-intro/txn-filtering.html">Query Filters</see> section of the Transaction Search Developer Guide.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public string? Query { get; init; }

    /// <summary>
    /// Controls the starting point within the collection of results, which defaults to 0. The first item in the collection is retrieved by setting a zero offset.
    /// <para>
    /// For example, if you have a collection of 15 items to be retrieved from a resource and you specify limit=5, you can retrieve the entire set of results in 3 successive requests by varying the offset value like this:
    /// </para>
    /// <para>
    /// <c>offset=0</c>
    /// <c>offset=5</c>
    /// <c>offset=10</c>
    /// </para>
    /// <para>
    /// <b>Note:</b> If an offset larger than the number of results is provided, this will result in no embedded object being returned.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset")]
    public int? Offset { get; init; }

    /// <summary>
    /// Controls the maximum number of items that may be returned for a single request. The default is 20, the maximum is 2500.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// A comma separated list of the following form:
    /// <para>
    /// <c>submitTimeUtc:desc</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public string? Sort { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
