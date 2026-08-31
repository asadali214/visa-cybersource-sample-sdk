using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetPlanCodeError : ApiError
{
    private readonly Optional<GetPlanCodeException1> _getPlanCodeException1Value;

    private readonly Optional<GetPlanCodeException21> _getPlanCodeException21Value;

    private GetPlanCodeError(Optional<GetPlanCodeException1> getPlanCodeException1Value,
        Optional<GetPlanCodeException21> getPlanCodeException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getPlanCodeException1Value = getPlanCodeException1Value;
        _getPlanCodeException21Value = getPlanCodeException21Value;
    }

    private static GetPlanCodeError AsGetPlanCodeException1(GetPlanCodeException1 value) =>
        new(Optional<GetPlanCodeException1>.Some(value), default, default);

    private static GetPlanCodeError AsGetPlanCodeException21(GetPlanCodeException21 value) =>
        new(default, Optional<GetPlanCodeException21>.Some(value), default);

    private static GetPlanCodeError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGetPlanCodeException1(out GetPlanCodeException1 value) =>
        _getPlanCodeException1Value.TryGetValue(out value);

    public bool TryGetGetPlanCodeException21(out GetPlanCodeException21 value) =>
        _getPlanCodeException21Value.TryGetValue(out value);

    internal static Task<GetPlanCodeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetPlanCodeException1>(response, ct).As(AsGetPlanCodeException1),
            502 => FromJson<GetPlanCodeException21>(response, ct).As(AsGetPlanCodeException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPlanCodeErrorResponse : IErrorResponse<GetPlanCodeError>
{
    public static GetPlanCodeErrorResponse Instance { get; } = new();

    private GetPlanCodeErrorResponse()
    {
    }

    public Task<GetPlanCodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPlanCodeError.Create(response, ct);
}
