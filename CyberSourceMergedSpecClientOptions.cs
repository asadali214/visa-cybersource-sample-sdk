using System.Collections.Generic;
using CyberSourceMergedSpec.Core.Configuration;
using CyberSourceMergedSpec.Core.Hooks;
using CyberSourceMergedSpec.Servers;

namespace CyberSourceMergedSpec;

public class CyberSourceMergedSpecClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
}
