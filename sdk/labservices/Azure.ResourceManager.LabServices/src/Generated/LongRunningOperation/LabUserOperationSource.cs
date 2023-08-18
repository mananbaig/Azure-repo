// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.LabServices
{
    internal class LabUserOperationSource : Core.IOperationSource<LabUserResource>
    {
        private readonly ArmClient _client;

        internal LabUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        LabUserResource Core.IOperationSource<LabUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LabUserData.DeserializeLabUserData(document.RootElement);
            return new LabUserResource(_client, data);
        }

        async ValueTask<LabUserResource> Core.IOperationSource<LabUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LabUserData.DeserializeLabUserData(document.RootElement);
            return new LabUserResource(_client, data);
        }
    }
}
