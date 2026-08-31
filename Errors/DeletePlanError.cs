using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class DeletePlanError : ApiError
{
    private readonly Optional<DeletePlanException1> _deletePlanException1Value;

    private readonly Optional<DeletePlanException21> _deletePlanException21Value;

    private readonly Optional<DeletePlanException31> _deletePlanException31Value;

    private DeletePlanError(Optional<DeletePlanException1> deletePlanException1Value,
        Optional<DeletePlanException21> deletePlanException21Value,
        Optional<DeletePlanException31> deletePlanException31Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _deletePlanException1Value = deletePlanException1Value;
        _deletePlanException21Value = deletePlanException21Value;
        _deletePlanException31Value = deletePlanException31Value;
    }

    private static DeletePlanError AsDeletePlanException1(DeletePlanException1 value) =>
        new(Optional<DeletePlanException1>.Some(value), default, default, default);

    private static DeletePlanError AsDeletePlanException21(DeletePlanException21 value) =>
        new(default, Optional<DeletePlanException21>.Some(value), default, default);

    private static DeletePlanError AsDeletePlanException31(DeletePlanException31 value) =>
        new(default, default, Optional<DeletePlanException31>.Some(value), default);

    private static DeletePlanError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDeletePlanException1(out DeletePlanException1 value) =>
        _deletePlanException1Value.TryGetValue(out value);

    public bool TryGetDeletePlanException21(out DeletePlanException21 value) =>
        _deletePlanException21Value.TryGetValue(out value);

    public bool TryGetDeletePlanException31(out DeletePlanException31 value) =>
        _deletePlanException31Value.TryGetValue(out value);

    internal static Task<DeletePlanError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<DeletePlanException1>(response, ct).As(AsDeletePlanException1),
            404 => FromJson<DeletePlanException21>(response, ct).As(AsDeletePlanException21),
            502 => FromJson<DeletePlanException31>(response, ct).As(AsDeletePlanException31),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeletePlanErrorResponse : IErrorResponse<DeletePlanError>
{
    public static DeletePlanErrorResponse Instance { get; } = new();

    private DeletePlanErrorResponse()
    {
    }

    public Task<DeletePlanError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeletePlanError.Create(response, ct);
}
