using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeactivatePlanError : ApiError
{
    private readonly Optional<DeactivatePlanException1> _deactivatePlanException1Value;

    private readonly Optional<DeactivatePlanException21> _deactivatePlanException21Value;

    private readonly Optional<DeactivatePlanException31> _deactivatePlanException31Value;

    private DeactivatePlanError(Optional<DeactivatePlanException1> deactivatePlanException1Value,
        Optional<DeactivatePlanException21> deactivatePlanException21Value,
        Optional<DeactivatePlanException31> deactivatePlanException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deactivatePlanException1Value = deactivatePlanException1Value;
        _deactivatePlanException21Value = deactivatePlanException21Value;
        _deactivatePlanException31Value = deactivatePlanException31Value;
    }

    private static DeactivatePlanError AsDeactivatePlanException1(DeactivatePlanException1 value) =>
        new(Optional<DeactivatePlanException1>.Some(value), default, default, default);

    private static DeactivatePlanError AsDeactivatePlanException21(DeactivatePlanException21 value) =>
        new(default, Optional<DeactivatePlanException21>.Some(value), default, default);

    private static DeactivatePlanError AsDeactivatePlanException31(DeactivatePlanException31 value) =>
        new(default, default, Optional<DeactivatePlanException31>.Some(value), default);

    private static DeactivatePlanError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeactivatePlanException1(out DeactivatePlanException1 value) =>
        _deactivatePlanException1Value.TryGetValue(out value);

    public bool TryGetDeactivatePlanException21(out DeactivatePlanException21 value) =>
        _deactivatePlanException21Value.TryGetValue(out value);

    public bool TryGetDeactivatePlanException31(out DeactivatePlanException31 value) =>
        _deactivatePlanException31Value.TryGetValue(out value);

    internal static Task<DeactivatePlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeactivatePlanException1>(response, ct).As(AsDeactivatePlanException1),
            404 => FromJson<DeactivatePlanException21>(response, ct).As(AsDeactivatePlanException21),
            502 => FromJson<DeactivatePlanException31>(response, ct).As(AsDeactivatePlanException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeactivatePlanErrorResponse : IErrorResponse<DeactivatePlanError>
{
    public static DeactivatePlanErrorResponse Instance { get; } = new();

    private DeactivatePlanErrorResponse()
    {
    }

    public Task<DeactivatePlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeactivatePlanError.Create(response, ct);
}
