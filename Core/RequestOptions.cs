using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using CyberSourceMergedSpec.Core.Hooks;

namespace CyberSourceMergedSpec.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
