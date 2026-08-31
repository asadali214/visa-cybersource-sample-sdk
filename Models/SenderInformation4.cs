using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record SenderInformation4
{
    /// <summary>
    /// Sender’s postal code. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// First name of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(35)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Middle Initial of sender
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleInitial")]
    [MaxLength(1)]
    public string? MiddleInitial { get; init; }

    /// <summary>
    /// This field contains the middle name of the entity funding the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(35)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Last name of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(35)]
    public string? LastName { get; init; }

    /// <summary>
    /// Street address of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(60)]
    public string? Address1 { get; init; }

    /// <summary>
    /// Second line of the sender's address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address2")]
    [MaxLength(60)]
    public string? Address2 { get; init; }

    /// <summary>
    /// City of sender. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    [MaxLength(25)]
    public string? Locality { get; init; }

    /// <summary>
    /// Sender’s state. Use the <b>State, Province, and Territory Codes for the United States and Canada</b>. This field is conditional: it is required if in the United States or Canada, and transaction is using neither a Customer nor Payment Instrument token.
    /// <para>
    /// Value must be an ISO Standard State Code: <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Country of sender. Check that this field contains 2 character alpha ISO 3166-1 standard values. This field is conditional: it is required if using neither a Customer nor Payment Instrument token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? Country { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInformation")]
    public PaymentInformation38? PaymentInformation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumerAuthentication")]
    public ConsumerAuthentication1? ConsumerAuthentication { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdentification")]
    public PersonalIdentification32? PersonalIdentification { get; init; }

    /// <summary>
    /// Visa Direct(16 characters)
    /// If the transaction is a money transfer, pre-paid load, or credit card bill pay, and if the sender intends to fund the transaction with a non-financial instrument (for example, cash), a reference number unique to the sender is required.
    /// If the transaction is a funds disbursement, the field is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenceNumber")]
    [MaxLength(19)]
    public string? ReferenceNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public Account17? Account { get; init; }

    /// <summary>
    /// Sender's alias name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasName")]
    [MaxLength(50)]
    public string? AliasName { get; init; }

    /// <summary>
    /// Account Owner Country of Birth.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryOfBirth")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? CountryOfBirth { get; init; }

    /// <summary>
    /// Sender’s date of birth. Format: YYYYMMDD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    [MaxLength(8)]
    public string? DateOfBirth { get; init; }

    /// <summary>
    /// Account Owner email address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(150)]
    public string? Email { get; init; }

    /// <summary>
    /// Name of sender. Use this field if the sender is a business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(24)]
    public string? Name { get; init; }

    /// <summary>
    /// Account Owner Nationality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [RegularExpression("^(\\s{0,2}|.{2})$")]
    public string? Nationality { get; init; }

    /// <summary>
    /// Account Owner Occupation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occupation")]
    [MaxLength(50)]
    public string? Occupation { get; init; }

    /// <summary>
    /// Sender’s phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    [MaxLength(20)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// This field identifies if the sender is a business or an individual.
    /// <para>
    /// The valid values are:
    /// </para>
    /// <para>
    /// • <c>B</c> (Business)
    /// • <c>I</c> (Individual)
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    [RegularExpression("^(\\s{0,1}|.{1})$")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
