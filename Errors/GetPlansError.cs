using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetPlansError : ApiError
{
    private readonly Optional<GetPlansException1> _getPlansException1Value;

    private readonly Optional<GetPlansException21> _getPlansException21Value;

    private GetPlansError(Optional<GetPlansException1> getPlansException1Value,
        Optional<GetPlansException21> getPlansException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getPlansException1Value = getPlansException1Value;
        _getPlansException21Value = getPlansException21Value;
    }

    private static GetPlansError AsGetPlansException1(GetPlansException1 value) =>
        new(Optional<GetPlansException1>.Some(value), default, default);

    private static GetPlansError AsGetPlansException21(GetPlansException21 value) =>
        new(default, Optional<GetPlansException21>.Some(value), default);

    private static GetPlansError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGetPlansException1(out GetPlansException1 value) =>
        _getPlansException1Value.TryGetValue(out value);

    public bool TryGetGetPlansException21(out GetPlansException21 value) =>
        _getPlansException21Value.TryGetValue(out value);

    internal static Task<GetPlansError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetPlansException1>(response, ct).As(AsGetPlansException1),
            502 => FromJson<GetPlansException21>(response, ct).As(AsGetPlansException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPlansErrorResponse : IErrorResponse<GetPlansError>
{
    public static GetPlansErrorResponse Instance { get; } = new();

    private GetPlansErrorResponse()
    {
    }

    public Task<GetPlansError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPlansError.Create(response, ct);
}
