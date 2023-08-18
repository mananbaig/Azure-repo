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

namespace Azure.ResourceManager.EventGrid
{
    internal class EventGridDomainOperationSource : Core.IOperationSource<EventGridDomainResource>
    {
        private readonly ArmClient _client;

        internal EventGridDomainOperationSource(ArmClient client)
        {
            _client = client;
        }

        EventGridDomainResource Core.IOperationSource<EventGridDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = EventGridDomainData.DeserializeEventGridDomainData(document.RootElement);
            return new EventGridDomainResource(_client, data);
        }

        async ValueTask<EventGridDomainResource> Core.IOperationSource<EventGridDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = EventGridDomainData.DeserializeEventGridDomainData(document.RootElement);
            return new EventGridDomainResource(_client, data);
        }
    }
}
