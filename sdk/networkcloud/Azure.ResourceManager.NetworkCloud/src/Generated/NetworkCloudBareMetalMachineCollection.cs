// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudBareMetalMachineResource" /> and their operations.
    /// Each <see cref="NetworkCloudBareMetalMachineResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkCloudBareMetalMachineCollection" /> instance call the GetNetworkCloudBareMetalMachines method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkCloudBareMetalMachineCollection : ArmCollection, IEnumerable<NetworkCloudBareMetalMachineResource>, IAsyncEnumerable<NetworkCloudBareMetalMachineResource>
    {
        private readonly ClientDiagnostics _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics;
        private readonly BareMetalMachinesRestOperations _networkCloudBareMetalMachineBareMetalMachinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudBareMetalMachineCollection"/> class for mocking. </summary>
        protected NetworkCloudBareMetalMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudBareMetalMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudBareMetalMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudBareMetalMachineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudBareMetalMachineResource.ResourceType, out string networkCloudBareMetalMachineBareMetalMachinesApiVersion);
            _networkCloudBareMetalMachineBareMetalMachinesRestClient = new BareMetalMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudBareMetalMachineBareMetalMachinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of the provided bare metal machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines/{bareMetalMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineName"> The name of the bare metal machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudBareMetalMachineResource>> GetAsync(string bareMetalMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineName, nameof(bareMetalMachineName));

            using var scope = _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudBareMetalMachineBareMetalMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bareMetalMachineName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBareMetalMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided bare metal machine.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines/{bareMetalMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineName"> The name of the bare metal machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineName"/> is null. </exception>
        public virtual Response<NetworkCloudBareMetalMachineResource> Get(string bareMetalMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineName, nameof(bareMetalMachineName));

            using var scope = _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudBareMetalMachineBareMetalMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bareMetalMachineName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBareMetalMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of bare metal machines in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudBareMetalMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudBareMetalMachineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudBareMetalMachineBareMetalMachinesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudBareMetalMachineBareMetalMachinesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkCloudBareMetalMachineResource(Client, NetworkCloudBareMetalMachineData.DeserializeNetworkCloudBareMetalMachineData(e)), _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics, Pipeline, "NetworkCloudBareMetalMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of bare metal machines in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudBareMetalMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudBareMetalMachineResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudBareMetalMachineBareMetalMachinesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudBareMetalMachineBareMetalMachinesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkCloudBareMetalMachineResource(Client, NetworkCloudBareMetalMachineData.DeserializeNetworkCloudBareMetalMachineData(e)), _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics, Pipeline, "NetworkCloudBareMetalMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines/{bareMetalMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineName"> The name of the bare metal machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bareMetalMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineName, nameof(bareMetalMachineName));

            using var scope = _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudBareMetalMachineBareMetalMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, bareMetalMachineName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/bareMetalMachines/{bareMetalMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BareMetalMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bareMetalMachineName"> The name of the bare metal machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bareMetalMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bareMetalMachineName"/> is null. </exception>
        public virtual Response<bool> Exists(string bareMetalMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bareMetalMachineName, nameof(bareMetalMachineName));

            using var scope = _networkCloudBareMetalMachineBareMetalMachinesClientDiagnostics.CreateScope("NetworkCloudBareMetalMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudBareMetalMachineBareMetalMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, bareMetalMachineName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudBareMetalMachineResource> IEnumerable<NetworkCloudBareMetalMachineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudBareMetalMachineResource> IAsyncEnumerable<NetworkCloudBareMetalMachineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
