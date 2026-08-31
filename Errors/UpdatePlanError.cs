using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class UpdatePlanError : ApiError
{
    private readonly Optional<UpdatePlanException1> _updatePlanException1Value;

    private readonly Optional<UpdatePlanException21> _updatePlanException21Value;

    private UpdatePlanError(Optional<UpdatePlanException1> updatePlanException1Value,
        Optional<UpdatePlanException21> updatePlanException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _updatePlanException1Value = updatePlanException1Value;
        _updatePlanException21Value = updatePlanException21Value;
    }

    private static UpdatePlanError AsUpdatePlanException1(UpdatePlanException1 value) =>
        new(Optional<UpdatePlanException1>.Some(value), default, default);

    private static UpdatePlanError AsUpdatePlanException21(UpdatePlanException21 value) =>
        new(default, Optional<UpdatePlanException21>.Some(value), default);

    private static UpdatePlanError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetUpdatePlanException1(out UpdatePlanException1 value) =>
        _updatePlanException1Value.TryGetValue(out value);

    public bool TryGetUpdatePlanException21(out UpdatePlanException21 value) =>
        _updatePlanException21Value.TryGetValue(out value);

    internal static Task<UpdatePlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<UpdatePlanException1>(response, ct).As(AsUpdatePlanException1),
            502 => FromJson<UpdatePlanException21>(response, ct).As(AsUpdatePlanException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdatePlanErrorResponse : IErrorResponse<UpdatePlanError>
{
    public static UpdatePlanErrorResponse Instance { get; } = new();

    private UpdatePlanErrorResponse()
    {
    }

    public Task<UpdatePlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdatePlanError.Create(response, ct);
}
