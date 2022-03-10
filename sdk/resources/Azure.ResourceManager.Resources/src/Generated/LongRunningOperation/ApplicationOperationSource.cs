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

namespace Azure.ResourceManager.Resources
{
    internal class ApplicationOperationSource : IOperationSource<Application>
    {
        private readonly ArmClient _client;

        internal ApplicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        Application IOperationSource<Application>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApplicationData.DeserializeApplicationData(document.RootElement);
            return new Application(_client, data);
        }

        async ValueTask<Application> IOperationSource<Application>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApplicationData.DeserializeApplicationData(document.RootElement);
            return new Application(_client, data);
        }
    }
}
