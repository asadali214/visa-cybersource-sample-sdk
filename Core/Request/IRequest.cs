using System.Net.Http;

namespace CyberSourceMergedSpec.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}