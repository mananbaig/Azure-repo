// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ContainerServiceResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ContainerServiceResourceGroupMockingExtension"/> class for mocking. </summary>
        protected ContainerServiceResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ContainerServiceResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ContainerServiceManagedClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerServiceManagedClusterResources and their operations over a ContainerServiceManagedClusterResource. </returns>
        public virtual ContainerServiceManagedClusterCollection GetContainerServiceManagedClusters()
        {
            return GetCachedClient(Client => new ContainerServiceManagedClusterCollection(Client, Id));
        }

        /// <summary>
        /// Gets a managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerServiceManagedClusterResource>> GetContainerServiceManagedClusterAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetContainerServiceManagedClusters().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ContainerServiceManagedClusterResource> GetContainerServiceManagedCluster(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetContainerServiceManagedClusters().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of AgentPoolSnapshotResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AgentPoolSnapshotResources and their operations over a AgentPoolSnapshotResource. </returns>
        public virtual AgentPoolSnapshotCollection GetAgentPoolSnapshots()
        {
            return GetCachedClient(Client => new AgentPoolSnapshotCollection(Client, Id));
        }

        /// <summary>
        /// Gets a snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/snapshots/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<AgentPoolSnapshotResource>> GetAgentPoolSnapshotAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetAgentPoolSnapshots().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/snapshots/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<AgentPoolSnapshotResource> GetAgentPoolSnapshot(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetAgentPoolSnapshots().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedClusterSnapshotResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedClusterSnapshotResources and their operations over a ManagedClusterSnapshotResource. </returns>
        public virtual ManagedClusterSnapshotCollection GetManagedClusterSnapshots()
        {
            return GetCachedClient(Client => new ManagedClusterSnapshotCollection(Client, Id));
        }

        /// <summary>
        /// Gets a managed cluster snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedclustersnapshots/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedClusterSnapshotResource>> GetManagedClusterSnapshotAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetManagedClusterSnapshots().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a managed cluster snapshot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedclustersnapshots/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusterSnapshots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the managed cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ManagedClusterSnapshotResource> GetManagedClusterSnapshot(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetManagedClusterSnapshots().Get(resourceName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerServiceFleetResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerServiceFleetResources and their operations over a ContainerServiceFleetResource. </returns>
        public virtual ContainerServiceFleetCollection GetContainerServiceFleets()
        {
            return GetCachedClient(Client => new ContainerServiceFleetCollection(Client, Id));
        }

        /// <summary>
        /// Gets a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerServiceFleetResource>> GetContainerServiceFleetAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            return await GetContainerServiceFleets().GetAsync(fleetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ContainerServiceFleetResource> GetContainerServiceFleet(string fleetName, CancellationToken cancellationToken = default)
        {
            return GetContainerServiceFleets().Get(fleetName, cancellationToken);
        }
    }
}
