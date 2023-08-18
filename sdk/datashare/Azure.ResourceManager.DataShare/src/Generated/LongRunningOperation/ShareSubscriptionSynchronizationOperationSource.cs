// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    internal class ShareSubscriptionSynchronizationOperationSource : Core.IOperationSource<ShareSubscriptionSynchronization>
    {
        ShareSubscriptionSynchronization Core.IOperationSource<ShareSubscriptionSynchronization>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ShareSubscriptionSynchronization.DeserializeShareSubscriptionSynchronization(document.RootElement);
        }

        async ValueTask<ShareSubscriptionSynchronization> Core.IOperationSource<ShareSubscriptionSynchronization>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ShareSubscriptionSynchronization.DeserializeShareSubscriptionSynchronization(document.RootElement);
        }
    }
}
