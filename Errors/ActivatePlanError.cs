using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class ActivatePlanError : ApiError
{
    private readonly Optional<ActivatePlanException1> _activatePlanException1Value;

    private readonly Optional<ActivatePlanException21> _activatePlanException21Value;

    private readonly Optional<ActivatePlanException31> _activatePlanException31Value;

    private ActivatePlanError(Optional<ActivatePlanException1> activatePlanException1Value,
        Optional<ActivatePlanException21> activatePlanException21Value,
        Optional<ActivatePlanException31> activatePlanException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _activatePlanException1Value = activatePlanException1Value;
        _activatePlanException21Value = activatePlanException21Value;
        _activatePlanException31Value = activatePlanException31Value;
    }

    private static ActivatePlanError AsActivatePlanException1(ActivatePlanException1 value) =>
        new(Optional<ActivatePlanException1>.Some(value), default, default, default);

    private static ActivatePlanError AsActivatePlanException21(ActivatePlanException21 value) =>
        new(default, Optional<ActivatePlanException21>.Some(value), default, default);

    private static ActivatePlanError AsActivatePlanException31(ActivatePlanException31 value) =>
        new(default, default, Optional<ActivatePlanException31>.Some(value), default);

    private static ActivatePlanError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetActivatePlanException1(out ActivatePlanException1 value) =>
        _activatePlanException1Value.TryGetValue(out value);

    public bool TryGetActivatePlanException21(out ActivatePlanException21 value) =>
        _activatePlanException21Value.TryGetValue(out value);

    public bool TryGetActivatePlanException31(out ActivatePlanException31 value) =>
        _activatePlanException31Value.TryGetValue(out value);

    internal static Task<ActivatePlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ActivatePlanException1>(response, ct).As(AsActivatePlanException1),
            404 => FromJson<ActivatePlanException21>(response, ct).As(AsActivatePlanException21),
            502 => FromJson<ActivatePlanException31>(response, ct).As(AsActivatePlanException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActivatePlanErrorResponse : IErrorResponse<ActivatePlanError>
{
    public static ActivatePlanErrorResponse Instance { get; } = new();

    private ActivatePlanErrorResponse()
    {
    }

    public Task<ActivatePlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActivatePlanError.Create(response, ct);
}
