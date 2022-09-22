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

namespace Azure.ResourceManager.HealthcareApis
{
    internal class FhirServiceOperationSource : IOperationSource<FhirServiceResource>
    {
        private readonly ArmClient _client;

        internal FhirServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        FhirServiceResource IOperationSource<FhirServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FhirServiceData.DeserializeFhirServiceData(document.RootElement);
            return new FhirServiceResource(_client, data);
        }

        async ValueTask<FhirServiceResource> IOperationSource<FhirServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FhirServiceData.DeserializeFhirServiceData(document.RootElement);
            return new FhirServiceResource(_client, data);
        }
    }
}
