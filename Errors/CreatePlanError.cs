using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreatePlanError : ApiError
{
    private readonly Optional<CreatePlanException1> _createPlanException1Value;

    private readonly Optional<CreatePlanException21> _createPlanException21Value;

    private CreatePlanError(Optional<CreatePlanException1> createPlanException1Value,
        Optional<CreatePlanException21> createPlanException21Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _createPlanException1Value = createPlanException1Value;
        _createPlanException21Value = createPlanException21Value;
    }

    private static CreatePlanError AsCreatePlanException1(CreatePlanException1 value) =>
        new(Optional<CreatePlanException1>.Some(value), default, default);

    private static CreatePlanError AsCreatePlanException21(CreatePlanException21 value) =>
        new(default, Optional<CreatePlanException21>.Some(value), default);

    private static CreatePlanError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetCreatePlanException1(out CreatePlanException1 value) =>
        _createPlanException1Value.TryGetValue(out value);

    public bool TryGetCreatePlanException21(out CreatePlanException21 value) =>
        _createPlanException21Value.TryGetValue(out value);

    internal static Task<CreatePlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<CreatePlanException1>(response, ct).As(AsCreatePlanException1),
            502 => FromJson<CreatePlanException21>(response, ct).As(AsCreatePlanException21),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreatePlanErrorResponse : IErrorResponse<CreatePlanError>
{
    public static CreatePlanErrorResponse Instance { get; } = new();

    private CreatePlanErrorResponse()
    {
    }

    public Task<CreatePlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreatePlanError.Create(response, ct);
}
