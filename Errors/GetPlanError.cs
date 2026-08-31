using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetPlanError : ApiError
{
    private readonly Optional<GetPlanException1> _getPlanException1Value;

    private readonly Optional<GetPlanException21> _getPlanException21Value;

    private readonly Optional<GetPlanException31> _getPlanException31Value;

    private GetPlanError(Optional<GetPlanException1> getPlanException1Value,
        Optional<GetPlanException21> getPlanException21Value,
        Optional<GetPlanException31> getPlanException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getPlanException1Value = getPlanException1Value;
        _getPlanException21Value = getPlanException21Value;
        _getPlanException31Value = getPlanException31Value;
    }

    private static GetPlanError AsGetPlanException1(GetPlanException1 value) =>
        new(Optional<GetPlanException1>.Some(value), default, default, default);

    private static GetPlanError AsGetPlanException21(GetPlanException21 value) =>
        new(default, Optional<GetPlanException21>.Some(value), default, default);

    private static GetPlanError AsGetPlanException31(GetPlanException31 value) =>
        new(default, default, Optional<GetPlanException31>.Some(value), default);

    private static GetPlanError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetGetPlanException1(out GetPlanException1 value) =>
        _getPlanException1Value.TryGetValue(out value);

    public bool TryGetGetPlanException21(out GetPlanException21 value) =>
        _getPlanException21Value.TryGetValue(out value);

    public bool TryGetGetPlanException31(out GetPlanException31 value) =>
        _getPlanException31Value.TryGetValue(out value);

    internal static Task<GetPlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetPlanException1>(response, ct).As(AsGetPlanException1),
            404 => FromJson<GetPlanException21>(response, ct).As(AsGetPlanException21),
            502 => FromJson<GetPlanException31>(response, ct).As(AsGetPlanException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPlanErrorResponse : IErrorResponse<GetPlanError>
{
    public static GetPlanErrorResponse Instance { get; } = new();

    private GetPlanErrorResponse()
    {
    }

    public Task<GetPlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPlanError.Create(response, ct);
}
