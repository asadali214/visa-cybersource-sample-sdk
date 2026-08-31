using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class AddNegativeError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private AddNegativeError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static AddNegativeError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static AddNegativeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<AddNegativeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddNegativeErrorResponse : IErrorResponse<AddNegativeError>
{
    public static AddNegativeErrorResponse Instance { get; } = new();

    private AddNegativeErrorResponse()
    {
    }

    public Task<AddNegativeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddNegativeError.Create(response, ct);
}
