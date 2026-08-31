using System.Collections.Generic;
using System.Net.Http.Headers;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Core.Extensions;

internal static class HttpRequestExtensions
{
    extension(HttpRequestHeaders requestHeaders)
    {
        public void AddRange(IReadOnlyCollection<HeaderParam> headers)
        {
            foreach (var header in headers)
                requestHeaders.Add(header.Key, ParameterFlattener.Flatten(header.Value));
        }
    }
}