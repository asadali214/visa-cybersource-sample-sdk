using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class ActionDecisionManagerCaseError : ApiError
{
    private readonly Optional<ActionDecisionManagerCaseException1> _actionDecisionManagerCaseException1Value;

    private readonly Optional<ActionDecisionManagerCaseException21> _actionDecisionManagerCaseException21Value;

    private readonly Optional<ActionDecisionManagerCaseException31> _actionDecisionManagerCaseException31Value;

    private readonly Optional<ActionDecisionManagerCaseException41> _actionDecisionManagerCaseException41Value;

    private readonly Optional<ActionDecisionManagerCaseException51> _actionDecisionManagerCaseException51Value;

    private readonly Optional<ActionDecisionManagerCaseException61> _actionDecisionManagerCaseException61Value;

    private ActionDecisionManagerCaseError(Optional<ActionDecisionManagerCaseException1> actionDecisionManagerCaseException1Value,
        Optional<ActionDecisionManagerCaseException21> actionDecisionManagerCaseException21Value,
        Optional<ActionDecisionManagerCaseException31> actionDecisionManagerCaseException31Value,
        Optional<ActionDecisionManagerCaseException41> actionDecisionManagerCaseException41Value,
        Optional<ActionDecisionManagerCaseException51> actionDecisionManagerCaseException51Value,
        Optional<ActionDecisionManagerCaseException61> actionDecisionManagerCaseException61Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _actionDecisionManagerCaseException1Value = actionDecisionManagerCaseException1Value;
        _actionDecisionManagerCaseException21Value = actionDecisionManagerCaseException21Value;
        _actionDecisionManagerCaseException31Value = actionDecisionManagerCaseException31Value;
        _actionDecisionManagerCaseException41Value = actionDecisionManagerCaseException41Value;
        _actionDecisionManagerCaseException51Value = actionDecisionManagerCaseException51Value;
        _actionDecisionManagerCaseException61Value = actionDecisionManagerCaseException61Value;
    }

    private static ActionDecisionManagerCaseError AsActionDecisionManagerCaseException1(ActionDecisionManagerCaseException1 value) =>
        new(Optional<ActionDecisionManagerCaseException1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static ActionDecisionManagerCaseError AsActionDecisionManagerCaseException21(ActionDecisionManagerCaseException21 value) =>
        new(default,
            Optional<ActionDecisionManagerCaseException21>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static ActionDecisionManagerCaseError AsActionDecisionManagerCaseException31(ActionDecisionManagerCaseException31 value) =>
        new(default,
            default,
            Optional<ActionDecisionManagerCaseException31>.Some(value),
            default,
            default,
            default,
            default);

    private static ActionDecisionManagerCaseError AsActionDecisionManagerCaseException41(ActionDecisionManagerCaseException41 value) =>
        new(default,
            default,
            default,
            Optional<ActionDecisionManagerCaseException41>.Some(value),
            default,
            default,
            default);

    private static ActionDecisionManagerCaseError AsActionDecisionManagerCaseException51(ActionDecisionManagerCaseException51 value) =>
        new(default,
            default,
            default,
            default,
            Optional<ActionDecisionManagerCaseException51>.Some(value),
            default,
            default);

    private static ActionDecisionManagerCaseError AsActionDecisionManagerCaseException61(ActionDecisionManagerCaseException61 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<ActionDecisionManagerCaseException61>.Some(value),
            default);

    private static ActionDecisionManagerCaseError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetActionDecisionManagerCaseException1(out ActionDecisionManagerCaseException1 value) =>
        _actionDecisionManagerCaseException1Value.TryGetValue(out value);

    public bool TryGetActionDecisionManagerCaseException21(out ActionDecisionManagerCaseException21 value) =>
        _actionDecisionManagerCaseException21Value.TryGetValue(out value);

    public bool TryGetActionDecisionManagerCaseException31(out ActionDecisionManagerCaseException31 value) =>
        _actionDecisionManagerCaseException31Value.TryGetValue(out value);

    public bool TryGetActionDecisionManagerCaseException41(out ActionDecisionManagerCaseException41 value) =>
        _actionDecisionManagerCaseException41Value.TryGetValue(out value);

    public bool TryGetActionDecisionManagerCaseException51(out ActionDecisionManagerCaseException51 value) =>
        _actionDecisionManagerCaseException51Value.TryGetValue(out value);

    public bool TryGetActionDecisionManagerCaseException61(out ActionDecisionManagerCaseException61 value) =>
        _actionDecisionManagerCaseException61Value.TryGetValue(out value);

    internal static Task<ActionDecisionManagerCaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ActionDecisionManagerCaseException1>(response, ct).As(AsActionDecisionManagerCaseException1),
            403 => FromJson<ActionDecisionManagerCaseException21>(response, ct).As(AsActionDecisionManagerCaseException21),
            422 => FromJson<ActionDecisionManagerCaseException31>(response, ct).As(AsActionDecisionManagerCaseException31),
            500 => FromJson<ActionDecisionManagerCaseException41>(response, ct).As(AsActionDecisionManagerCaseException41),
            502 => FromJson<ActionDecisionManagerCaseException51>(response, ct).As(AsActionDecisionManagerCaseException51),
            503 => FromJson<ActionDecisionManagerCaseException61>(response, ct).As(AsActionDecisionManagerCaseException61),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActionDecisionManagerCaseErrorResponse : IErrorResponse<ActionDecisionManagerCaseError>
{
    public static ActionDecisionManagerCaseErrorResponse Instance { get; } = new();

    private ActionDecisionManagerCaseErrorResponse()
    {
    }

    public Task<ActionDecisionManagerCaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActionDecisionManagerCaseError.Create(response, ct);
}
