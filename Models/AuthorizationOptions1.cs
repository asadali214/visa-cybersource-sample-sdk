using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record AuthorizationOptions1
{
    /// <summary>
    /// Field is used for back-to-back funding transaction and can be defined as a payment flow that automatically transfers funds through a real-time
    /// funding or a live-load. This type of transaction can also be connected to a purchase.
    /// In back-to-back funding of general purpose card that is used to make a purchase, two separate accounts are involved:
    /// - account one is used to make the purchase
    /// - account two is used to automatically fund or reimburse account one
    /// <para>
    /// Possible values:
    /// - 0B = back to back funding transaction
    /// - 00 = normal transaction
    /// - 01 = originator hold
    /// - 02 = Visa deferred OCT hold, default interval
    /// - 03 = Visa deferred OCT hold, user-defined interval
    /// - 09 = Cancel pending deferred OCT request
    /// - 0I = Visa Direct custom program 1
    /// - 0Q = uery the status of the deferred OCT
    /// - A0 = Alias Directory 2
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceType")]
    [MaxLength(10)]
    public string? ServiceType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
