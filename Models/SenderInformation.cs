using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SenderInformation
{
    /// <summary>
    /// First name of the sender.
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported.Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(30)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Middle name of the sender.
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(30)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Last name of the sender.
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(35)]
    public string? LastName { get; init; }

    /// <summary>
    /// The street address of the sender.
    /// This field is applicable for AFT transactions.
    ///
    /// Only alpha numeric values are supported.
    /// Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(35)]
    public string? Address1 { get; init; }

    /// <summary>
    /// The city or locality of the sender.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Only alpha numeric values are supported.
    /// Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(25)]
    public string? Locality { get; init; }

    /// <summary>
    /// The state or province of the sender.
    /// This field is applicable for AFT transactions when the sender country is US or CA. Else it is optional.
    /// <para>
    /// Must be a two character value
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// The country associated with the address of the sender.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Must be a two character ISO country code.
    /// For example, see <see href="https://developer.cybersource.com/docs/cybs/en-us/country-codes/reference/all/na/country-codes/country-codes.html">ISO Country Code</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    [MaxLength(2)]
    public string? CountryCode { get; init; }

    /// <summary>
    /// Sender's alias name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasName")]
    [MaxLength(50)]
    public string? AliasName { get; init; }

    /// <summary>
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Contains a transaction reference number provided by the Merchant. Only alpha numeric values are supported.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceNumber")]
    [MaxLength(19)]
    public string? ReferenceNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public Account1? Account { get; init; }

    /// <summary>
    /// Postal code of sender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// CPF or CNPJ of the cash-in recipient. "Cadastro de Pessoas Físicas", which translates to the "Natural Persons Register."
    /// It is the individual taxpayer registry identification number in Brazil, similar to a Social Security Number (SSN) in the United States or a National Insurance Number in the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxIdNumber")]
    public double? TaxIdNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
