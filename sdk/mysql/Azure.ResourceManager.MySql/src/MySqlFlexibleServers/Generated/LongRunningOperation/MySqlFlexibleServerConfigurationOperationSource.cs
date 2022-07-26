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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerConfigurationOperationSource : IOperationSource<MySqlFlexibleServerConfigurationResource>
    {
        private readonly ArmClient _client;

        internal MySqlFlexibleServerConfigurationOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFlexibleServerConfigurationResource IOperationSource<MySqlFlexibleServerConfigurationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFlexibleServerConfigurationData.DeserializeMySqlFlexibleServerConfigurationData(document.RootElement);
            return new MySqlFlexibleServerConfigurationResource(_client, data);
        }

        async ValueTask<MySqlFlexibleServerConfigurationResource> IOperationSource<MySqlFlexibleServerConfigurationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFlexibleServerConfigurationData.DeserializeMySqlFlexibleServerConfigurationData(document.RootElement);
            return new MySqlFlexibleServerConfigurationResource(_client, data);
        }
    }
}
