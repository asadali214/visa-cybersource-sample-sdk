using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetAllSubscriptionsError : ApiError
{
    private readonly Optional<GetAllSubscriptionsException1> _getAllSubscriptionsException1Value;

    private readonly Optional<GetAllSubscriptionsException21> _getAllSubscriptionsException21Value;

    private GetAllSubscriptionsError(Optional<GetAllSubscriptionsException1> getAllSubscriptionsException1Value,
        Optional<GetAllSubscriptionsException21> getAllSubscriptionsException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _getAllSubscriptionsException1Value = getAllSubscriptionsException1Value;
        _getAllSubscriptionsException21Value = getAllSubscriptionsException21Value;
    }

    private static GetAllSubscriptionsError AsGetAllSubscriptionsException1(GetAllSubscriptionsException1 value) =>
        new(Optional<GetAllSubscriptionsException1>.Some(value), default, default);

    private static GetAllSubscriptionsError AsGetAllSubscriptionsException21(GetAllSubscriptionsException21 value) =>
        new(default, Optional<GetAllSubscriptionsException21>.Some(value), default);

    private static GetAllSubscriptionsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGetAllSubscriptionsException1(out GetAllSubscriptionsException1 value) =>
        _getAllSubscriptionsException1Value.TryGetValue(out value);

    public bool TryGetGetAllSubscriptionsException21(out GetAllSubscriptionsException21 value) =>
        _getAllSubscriptionsException21Value.TryGetValue(out value);

    internal static Task<GetAllSubscriptionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<GetAllSubscriptionsException1>(response, ct).As(AsGetAllSubscriptionsException1),
            502 => FromJson<GetAllSubscriptionsException21>(response, ct).As(AsGetAllSubscriptionsException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllSubscriptionsErrorResponse : IErrorResponse<GetAllSubscriptionsError>
{
    public static GetAllSubscriptionsErrorResponse Instance { get; } = new();

    private GetAllSubscriptionsErrorResponse()
    {
    }

    public Task<GetAllSubscriptionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllSubscriptionsError.Create(response, ct);
}
