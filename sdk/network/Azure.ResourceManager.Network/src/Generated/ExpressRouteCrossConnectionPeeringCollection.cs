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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteCrossConnectionPeeringResource" /> and their operations.
    /// Each <see cref="ExpressRouteCrossConnectionPeeringResource" /> in the collection will belong to the same instance of <see cref="ExpressRouteCrossConnectionResource" />.
    /// To get an <see cref="ExpressRouteCrossConnectionPeeringCollection" /> instance call the GetExpressRouteCrossConnectionPeerings method from an instance of <see cref="ExpressRouteCrossConnectionResource" />.
    /// </summary>
    public partial class ExpressRouteCrossConnectionPeeringCollection : ArmCollection, IEnumerable<ExpressRouteCrossConnectionPeeringResource>, IAsyncEnumerable<ExpressRouteCrossConnectionPeeringResource>
    {
        private readonly ClientDiagnostics _expressRouteCrossConnectionPeeringClientDiagnostics;
        private readonly ExpressRouteCrossConnectionPeeringsRestOperations _expressRouteCrossConnectionPeeringRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringCollection"/> class for mocking. </summary>
        protected ExpressRouteCrossConnectionPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteCrossConnectionPeeringCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteCrossConnectionPeeringClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteCrossConnectionPeeringResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteCrossConnectionPeeringResource.ResourceType, out string expressRouteCrossConnectionPeeringApiVersion);
            _expressRouteCrossConnectionPeeringRestClient = new ExpressRouteCrossConnectionPeeringsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteCrossConnectionPeeringApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteCrossConnectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteCrossConnectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a peering in the specified ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="data"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteCrossConnectionPeeringResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peeringName, ExpressRouteCrossConnectionPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionPeeringResource>(new ExpressRouteCrossConnectionPeeringOperationSource(Client), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a peering in the specified ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="data"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteCrossConnectionPeeringResource> CreateOrUpdate(WaitUntil waitUntil, string peeringName, ExpressRouteCrossConnectionPeeringData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteCrossConnectionPeeringResource>(new ExpressRouteCrossConnectionPeeringOperationSource(Client), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified peering for the ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteCrossConnectionPeeringResource>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified peering for the ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnectionPeeringResource> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeeringResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all peerings in a specified ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCrossConnectionPeeringResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCrossConnectionPeeringResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCrossConnectionPeeringRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCrossConnectionPeeringRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ExpressRouteCrossConnectionPeeringResource(Client, ExpressRouteCrossConnectionPeeringData.DeserializeExpressRouteCrossConnectionPeeringData(e)), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, "ExpressRouteCrossConnectionPeeringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all peerings in a specified ExpressRouteCrossConnection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCrossConnectionPeeringResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCrossConnectionPeeringResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteCrossConnectionPeeringRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteCrossConnectionPeeringRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ExpressRouteCrossConnectionPeeringResource(Client, ExpressRouteCrossConnectionPeeringData.DeserializeExpressRouteCrossConnectionPeeringData(e)), _expressRouteCrossConnectionPeeringClientDiagnostics, Pipeline, "ExpressRouteCrossConnectionPeeringCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteCrossConnections/{crossConnectionName}/peerings/{peeringName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteCrossConnectionPeerings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peeringName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string peeringName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peeringName, nameof(peeringName));

            using var scope = _expressRouteCrossConnectionPeeringClientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteCrossConnectionPeeringResource> IEnumerable<ExpressRouteCrossConnectionPeeringResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCrossConnectionPeeringResource> IAsyncEnumerable<ExpressRouteCrossConnectionPeeringResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
