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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="PaloAltoNetworksFirewallResource" /> and their operations.
    /// Each <see cref="PaloAltoNetworksFirewallResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PaloAltoNetworksFirewallCollection" /> instance call the GetPaloAltoNetworksFirewalls method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PaloAltoNetworksFirewallCollection : ArmCollection, IEnumerable<PaloAltoNetworksFirewallResource>, IAsyncEnumerable<PaloAltoNetworksFirewallResource>
    {
        private readonly ClientDiagnostics _paloAltoNetworksFirewallFirewallsClientDiagnostics;
        private readonly FirewallsRestOperations _paloAltoNetworksFirewallFirewallsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PaloAltoNetworksFirewallCollection"/> class for mocking. </summary>
        protected PaloAltoNetworksFirewallCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PaloAltoNetworksFirewallCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PaloAltoNetworksFirewallCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _paloAltoNetworksFirewallFirewallsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", PaloAltoNetworksFirewallResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PaloAltoNetworksFirewallResource.ResourceType, out string paloAltoNetworksFirewallFirewallsApiVersion);
            _paloAltoNetworksFirewallFirewallsRestClient = new FirewallsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, paloAltoNetworksFirewallFirewallsApiVersion);
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
        /// Create a FirewallResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PaloAltoNetworksFirewallResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firewallName, PaloAltoNetworksFirewallData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallName, nameof(firewallName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _paloAltoNetworksFirewallFirewallsClientDiagnostics.CreateScope("PaloAltoNetworksFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _paloAltoNetworksFirewallFirewallsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, firewallName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<PaloAltoNetworksFirewallResource>(new PaloAltoNetworksFirewallOperationSource(Client), _paloAltoNetworksFirewallFirewallsClientDiagnostics, Pipeline, _paloAltoNetworksFirewallFirewallsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, firewallName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a FirewallResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PaloAltoNetworksFirewallResource> CreateOrUpdate(WaitUntil waitUntil, string firewallName, PaloAltoNetworksFirewallData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallName, nameof(firewallName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _paloAltoNetworksFirewallFirewallsClientDiagnostics.CreateScope("PaloAltoNetworksFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _paloAltoNetworksFirewallFirewallsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, firewallName, data, cancellationToken);
                var operation = new NgfwArmOperation<PaloAltoNetworksFirewallResource>(new PaloAltoNetworksFirewallOperationSource(Client), _paloAltoNetworksFirewallFirewallsClientDiagnostics, Pipeline, _paloAltoNetworksFirewallFirewallsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, firewallName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FirewallResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> is null. </exception>
        public virtual async Task<Response<PaloAltoNetworksFirewallResource>> GetAsync(string firewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallName, nameof(firewallName));

            using var scope = _paloAltoNetworksFirewallFirewallsClientDiagnostics.CreateScope("PaloAltoNetworksFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = await _paloAltoNetworksFirewallFirewallsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, firewallName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PaloAltoNetworksFirewallResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FirewallResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> is null. </exception>
        public virtual Response<PaloAltoNetworksFirewallResource> Get(string firewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallName, nameof(firewallName));

            using var scope = _paloAltoNetworksFirewallFirewallsClientDiagnostics.CreateScope("PaloAltoNetworksFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = _paloAltoNetworksFirewallFirewallsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, firewallName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PaloAltoNetworksFirewallResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FirewallResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PaloAltoNetworksFirewallResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PaloAltoNetworksFirewallResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _paloAltoNetworksFirewallFirewallsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _paloAltoNetworksFirewallFirewallsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new PaloAltoNetworksFirewallResource(Client, PaloAltoNetworksFirewallData.DeserializePaloAltoNetworksFirewallData(e)), _paloAltoNetworksFirewallFirewallsClientDiagnostics, Pipeline, "PaloAltoNetworksFirewallCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FirewallResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PaloAltoNetworksFirewallResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PaloAltoNetworksFirewallResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _paloAltoNetworksFirewallFirewallsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _paloAltoNetworksFirewallFirewallsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new PaloAltoNetworksFirewallResource(Client, PaloAltoNetworksFirewallData.DeserializePaloAltoNetworksFirewallData(e)), _paloAltoNetworksFirewallFirewallsClientDiagnostics, Pipeline, "PaloAltoNetworksFirewallCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallName, nameof(firewallName));

            using var scope = _paloAltoNetworksFirewallFirewallsClientDiagnostics.CreateScope("PaloAltoNetworksFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = await _paloAltoNetworksFirewallFirewallsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, firewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/firewalls/{firewallName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firewalls_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> Firewall resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallName"/> is null. </exception>
        public virtual Response<bool> Exists(string firewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firewallName, nameof(firewallName));

            using var scope = _paloAltoNetworksFirewallFirewallsClientDiagnostics.CreateScope("PaloAltoNetworksFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = _paloAltoNetworksFirewallFirewallsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, firewallName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PaloAltoNetworksFirewallResource> IEnumerable<PaloAltoNetworksFirewallResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PaloAltoNetworksFirewallResource> IAsyncEnumerable<PaloAltoNetworksFirewallResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
