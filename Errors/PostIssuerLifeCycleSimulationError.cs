using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PostIssuerLifeCycleSimulationError : ApiError
{
    private readonly Optional<PostIssuerLifeCycleSimulationException1> _postIssuerLifeCycleSimulationException1Value;

    private readonly Optional<PostIssuerLifeCycleSimulationException21> _postIssuerLifeCycleSimulationException21Value;

    private readonly Optional<PostIssuerLifeCycleSimulationException31> _postIssuerLifeCycleSimulationException31Value;

    private readonly Optional<PostIssuerLifeCycleSimulationException41> _postIssuerLifeCycleSimulationException41Value;

    private PostIssuerLifeCycleSimulationError(Optional<PostIssuerLifeCycleSimulationException1> postIssuerLifeCycleSimulationException1Value,
        Optional<PostIssuerLifeCycleSimulationException21> postIssuerLifeCycleSimulationException21Value,
        Optional<PostIssuerLifeCycleSimulationException31> postIssuerLifeCycleSimulationException31Value,
        Optional<PostIssuerLifeCycleSimulationException41> postIssuerLifeCycleSimulationException41Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _postIssuerLifeCycleSimulationException1Value = postIssuerLifeCycleSimulationException1Value;
        _postIssuerLifeCycleSimulationException21Value = postIssuerLifeCycleSimulationException21Value;
        _postIssuerLifeCycleSimulationException31Value = postIssuerLifeCycleSimulationException31Value;
        _postIssuerLifeCycleSimulationException41Value = postIssuerLifeCycleSimulationException41Value;
    }

    private static PostIssuerLifeCycleSimulationError AsPostIssuerLifeCycleSimulationException1(PostIssuerLifeCycleSimulationException1 value) =>
        new(Optional<PostIssuerLifeCycleSimulationException1>.Some(value), default, default, default, default);

    private static PostIssuerLifeCycleSimulationError AsPostIssuerLifeCycleSimulationException21(PostIssuerLifeCycleSimulationException21 value) =>
        new(default, Optional<PostIssuerLifeCycleSimulationException21>.Some(value), default, default, default);

    private static PostIssuerLifeCycleSimulationError AsPostIssuerLifeCycleSimulationException31(PostIssuerLifeCycleSimulationException31 value) =>
        new(default, default, Optional<PostIssuerLifeCycleSimulationException31>.Some(value), default, default);

    private static PostIssuerLifeCycleSimulationError AsPostIssuerLifeCycleSimulationException41(PostIssuerLifeCycleSimulationException41 value) =>
        new(default, default, default, Optional<PostIssuerLifeCycleSimulationException41>.Some(value), default);

    private static PostIssuerLifeCycleSimulationError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPostIssuerLifeCycleSimulationException1(out PostIssuerLifeCycleSimulationException1 value) =>
        _postIssuerLifeCycleSimulationException1Value.TryGetValue(out value);

    public bool TryGetPostIssuerLifeCycleSimulationException21(out PostIssuerLifeCycleSimulationException21 value) =>
        _postIssuerLifeCycleSimulationException21Value.TryGetValue(out value);

    public bool TryGetPostIssuerLifeCycleSimulationException31(out PostIssuerLifeCycleSimulationException31 value) =>
        _postIssuerLifeCycleSimulationException31Value.TryGetValue(out value);

    public bool TryGetPostIssuerLifeCycleSimulationException41(out PostIssuerLifeCycleSimulationException41 value) =>
        _postIssuerLifeCycleSimulationException41Value.TryGetValue(out value);

    internal static Task<PostIssuerLifeCycleSimulationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PostIssuerLifeCycleSimulationException1>(response, ct).As(AsPostIssuerLifeCycleSimulationException1),
            403 => FromJson<PostIssuerLifeCycleSimulationException21>(response, ct).As(AsPostIssuerLifeCycleSimulationException21),
            404 => FromJson<PostIssuerLifeCycleSimulationException31>(response, ct).As(AsPostIssuerLifeCycleSimulationException31),
            500 => FromJson<PostIssuerLifeCycleSimulationException41>(response, ct).As(AsPostIssuerLifeCycleSimulationException41),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostIssuerLifeCycleSimulationErrorResponse : IErrorResponse<PostIssuerLifeCycleSimulationError>
{
    public static PostIssuerLifeCycleSimulationErrorResponse Instance { get; } = new();

    private PostIssuerLifeCycleSimulationErrorResponse()
    {
    }

    public Task<PostIssuerLifeCycleSimulationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostIssuerLifeCycleSimulationError.Create(response, ct);
}
