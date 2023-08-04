// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class FlexibleServersResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="FlexibleServersResourceGroupMockingExtension"/> class for mocking. </summary>
        protected FlexibleServersResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FlexibleServersResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FlexibleServersResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MySqlFlexibleServerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of MySqlFlexibleServerResources and their operations over a MySqlFlexibleServerResource. </returns>
        public virtual MySqlFlexibleServerCollection GetMySqlFlexibleServers()
        {
            return GetCachedClient(Client => new MySqlFlexibleServerCollection(Client, Id));
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MySqlFlexibleServerResource>> GetMySqlFlexibleServerAsync(string serverName, CancellationToken cancellationToken = default)
        {
            return await GetMySqlFlexibleServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<MySqlFlexibleServerResource> GetMySqlFlexibleServer(string serverName, CancellationToken cancellationToken = default)
        {
            return GetMySqlFlexibleServers().Get(serverName, cancellationToken);
        }
    }
}
