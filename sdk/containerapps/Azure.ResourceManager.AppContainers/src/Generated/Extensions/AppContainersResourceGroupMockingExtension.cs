// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class AppContainersResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="AppContainersResourceGroupMockingExtension"/> class for mocking. </summary>
        protected AppContainersResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppContainersResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppContainersResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ContainerAppConnectedEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppConnectedEnvironmentResources and their operations over a ContainerAppConnectedEnvironmentResource. </returns>
        public virtual ContainerAppConnectedEnvironmentCollection GetContainerAppConnectedEnvironments()
        {
            return GetCachedClient(Client => new ContainerAppConnectedEnvironmentCollection(Client, Id));
        }

        /// <summary>
        /// Get the properties of an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppConnectedEnvironmentResource>> GetContainerAppConnectedEnvironmentAsync(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppConnectedEnvironments().GetAsync(connectedEnvironmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of an connectedEnvironment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectedEnvironmentName"> Name of the connectedEnvironment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppConnectedEnvironmentResource> GetContainerAppConnectedEnvironment(string connectedEnvironmentName, CancellationToken cancellationToken = default)
        {
            return GetContainerAppConnectedEnvironments().Get(connectedEnvironmentName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppResources and their operations over a ContainerAppResource. </returns>
        public virtual ContainerAppCollection GetContainerApps()
        {
            return GetCachedClient(Client => new ContainerAppCollection(Client, Id));
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppResource>> GetContainerAppAsync(string containerAppName, CancellationToken cancellationToken = default)
        {
            return await GetContainerApps().GetAsync(containerAppName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Container App.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerApps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="containerAppName"> Name of the Container App. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppResource> GetContainerApp(string containerAppName, CancellationToken cancellationToken = default)
        {
            return GetContainerApps().Get(containerAppName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppJobResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppJobResources and their operations over a ContainerAppJobResource. </returns>
        public virtual ContainerAppJobCollection GetContainerAppJobs()
        {
            return GetCachedClient(Client => new ContainerAppJobCollection(Client, Id));
        }

        /// <summary>
        /// Get the properties of a Container Apps Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Container Apps Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppJobResource>> GetContainerAppJobAsync(string jobName, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppJobs().GetAsync(jobName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Container Apps Job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobName"> Name of the Container Apps Job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppJobResource> GetContainerAppJob(string jobName, CancellationToken cancellationToken = default)
        {
            return GetContainerAppJobs().Get(jobName, cancellationToken);
        }

        /// <summary> Gets a collection of ContainerAppManagedEnvironmentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ContainerAppManagedEnvironmentResources and their operations over a ContainerAppManagedEnvironmentResource. </returns>
        public virtual ContainerAppManagedEnvironmentCollection GetContainerAppManagedEnvironments()
        {
            return GetCachedClient(Client => new ContainerAppManagedEnvironmentCollection(Client, Id));
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<ContainerAppManagedEnvironmentResource>> GetContainerAppManagedEnvironmentAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            return await GetContainerAppManagedEnvironments().GetAsync(environmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a Managed Environment used to host container apps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/managedEnvironments/{environmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<ContainerAppManagedEnvironmentResource> GetContainerAppManagedEnvironment(string environmentName, CancellationToken cancellationToken = default)
        {
            return GetContainerAppManagedEnvironments().Get(environmentName, cancellationToken);
        }
    }
}
