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
using Azure.ResourceManager.Datadog;

namespace Azure.ResourceManager.Datadog.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class DatadogResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="DatadogResourceGroupMockingExtension"/> class for mocking. </summary>
        protected DatadogResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatadogResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DatadogResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DatadogMonitorResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DatadogMonitorResources and their operations over a DatadogMonitorResource. </returns>
        public virtual DatadogMonitorResourceCollection GetDatadogMonitorResources()
        {
            return GetCachedClient(Client => new DatadogMonitorResourceCollection(Client, Id));
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DatadogMonitorResource>> GetDatadogMonitorResourceAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            return await GetDatadogMonitorResources().GetAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<DatadogMonitorResource> GetDatadogMonitorResource(string monitorName, CancellationToken cancellationToken = default)
        {
            return GetDatadogMonitorResources().Get(monitorName, cancellationToken);
        }
    }
}
