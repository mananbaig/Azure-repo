// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase
{
    internal class AutonomousDatabaseOperationSource : IOperationSource<AutonomousDatabaseResource>
    {
        private readonly ArmClient _client;

        internal AutonomousDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        AutonomousDatabaseResource IOperationSource<AutonomousDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AutonomousDatabaseData.DeserializeAutonomousDatabaseData(document.RootElement);
            return new AutonomousDatabaseResource(_client, data);
        }

        async ValueTask<AutonomousDatabaseResource> IOperationSource<AutonomousDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AutonomousDatabaseData.DeserializeAutonomousDatabaseData(document.RootElement);
            return new AutonomousDatabaseResource(_client, data);
        }
    }
}
