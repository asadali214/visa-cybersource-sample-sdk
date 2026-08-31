using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record RecipientInformation
{
    /// <summary>
    /// Identifier for the recipient’s account.
    /// This field is applicable for AFT transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountId")]
    [MaxLength(50)]
    public string? AccountId { get; init; }

    /// <summary>
    /// Identifies the recipient’s account type.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Valid values are:
    ///   - <c>00</c> for Other
    ///   - <c>01</c> for Routing Transit Number (RTN) + Bank Account Number (BAN)
    ///   - <c>02</c> for International Bank Account Number (IBAN)
    ///   - <c>03</c> for Card Account
    ///   - <c>06</c> for Bank Account Number (BAN) + Bank Identification Code (BIC), also known as a SWIFT code
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    [MaxLength(2)]
    public string? AccountType { get; init; }

    /// <summary>
    /// First name of the recipient.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(35)]
    public string? FirstName { get; init; }

    /// <summary>
    /// Middle name of the recipient.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("middleName")]
    [MaxLength(30)]
    public string? MiddleName { get; init; }

    /// <summary>
    /// Last name of the recipient.
    /// This field is applicable for AFT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set, are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(35)]
    public string? LastName { get; init; }

    /// <summary>
    /// The street address of the recipient
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Only alpha numeric values are supported. Special characters not in the standard ASCII character set are not supported and will be stripped before being sent to sent to the processor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address1")]
    [MaxLength(50)]
    public string? Address1 { get; init; }

    /// <summary>
    /// The state or province of the recipient.
    /// This field is applicable for AFT transactions when the recipient country is US or CA. Else it is optional.
    /// <para>
    /// Must be a two character value
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrativeArea")]
    [MaxLength(2)]
    public string? AdministrativeArea { get; init; }

    /// <summary>
    /// Partial postal code for the recipient’s address. For example, if the postal code is <b>NN5 7SG</b>, the value for
    /// this field should be the first part of the postal code: <b>NN5</b>. This field is a _pass-through_, which means that
    /// CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field
    /// is not required for the transaction, CyberSource does not forward it to the processor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    [MaxLength(10)]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The country associated with the address of the recipient.
    /// This field is applicable for AFT and OCT transactions.
    /// <para>
    /// Must be a two character ISO country code.
    /// For example, see <see href="https://developer.cybersource.com/docs/cybs/en-us/country-codes/reference/all/na/country-codes/country-codes.html">ISO Country Code</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [MaxLength(2)]
    public string? Country { get; init; }

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
    /// Only for e-wallets: ID, username, hash or anything uniquely identifying
    /// the ultimate beneficiary.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beneficiaryId")]
    [MaxLength(255)]
    public string? BeneficiaryId { get; init; }

    /// <summary>
    /// Only for e-wallets: The ultimate beneficiary’s full name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beneficiaryName")]
    [MaxLength(255)]
    public string? BeneficiaryName { get; init; }

    /// <summary>
    /// Only for e-wallets: The ultimate beneficiary’s street address (street,
    /// zip code, city), excluding the country. Example: “Main street 1, 12345,
    /// Barcelona
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beneficiaryAddress")]
    [MaxLength(255)]
    public string? BeneficiaryAddress { get; init; }

    /// <summary>
    /// Account owner alias name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasName")]
    [MaxLength(50)]
    public string? AliasName { get; init; }

    /// <summary>
    /// Account Owner Nationality
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nationality")]
    [MaxLength(10)]
    public string? Nationality { get; init; }

    /// <summary>
    /// Account Owner Country of Birth
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryOfBirth")]
    [MaxLength(10)]
    public string? CountryOfBirth { get; init; }

    /// <summary>
    /// Account Owner Occupation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occupation")]
    [MaxLength(50)]
    public string? Occupation { get; init; }

    /// <summary>
    /// Account Owner email address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    [MaxLength(150)]
    public string? Email { get; init; }

    /// <summary>
    /// The city of the recipient.
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
    /// CPF or CNPJ of the cash-in recipient. "Cadastro de Pessoas Físicas", which translates to the "Natural Persons Register."
    /// It is the individual taxpayer registry identification number in Brazil, similar to a Social Security Number (SSN) in the United States or a National Insurance Number in the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxIdNumber")]
    public double? TaxIdNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
