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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="PrivateEndpointResource" /> and their operations.
    /// Each <see cref="PrivateEndpointResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PrivateEndpointCollection" /> instance call the GetPrivateEndpoints method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PrivateEndpointCollection : ArmCollection, IEnumerable<PrivateEndpointResource>, IAsyncEnumerable<PrivateEndpointResource>
    {
        private readonly ClientDiagnostics _privateEndpointClientDiagnostics;
        private readonly PrivateEndpointsRestOperations _privateEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointCollection"/> class for mocking. </summary>
        protected PrivateEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", PrivateEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PrivateEndpointResource.ResourceType, out string privateEndpointApiVersion);
            _privateEndpointRestClient = new PrivateEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateEndpointApiVersion);
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
        /// Creates or updates an private endpoint in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="data"> Parameters supplied to the create or update private endpoint operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointName, PrivateEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointClientDiagnostics.CreateScope("PrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<PrivateEndpointResource>(new PrivateEndpointOperationSource(Client), _privateEndpointClientDiagnostics, Pipeline, _privateEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates an private endpoint in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="data"> Parameters supplied to the create or update private endpoint operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointName, PrivateEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateEndpointClientDiagnostics.CreateScope("PrivateEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, data, cancellationToken);
                var operation = new NetworkArmOperation<PrivateEndpointResource>(new PrivateEndpointOperationSource(Client), _privateEndpointClientDiagnostics, Pipeline, _privateEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified private endpoint by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointResource>> GetAsync(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _privateEndpointClientDiagnostics.CreateScope("PrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified private endpoint by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<PrivateEndpointResource> Get(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _privateEndpointClientDiagnostics.CreateScope("PrivateEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all private endpoints in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateEndpointRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateEndpointRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new PrivateEndpointResource(Client, PrivateEndpointData.DeserializePrivateEndpointData(e)), _privateEndpointClientDiagnostics, Pipeline, "PrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all private endpoints in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _privateEndpointRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _privateEndpointRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new PrivateEndpointResource(Client, PrivateEndpointData.DeserializePrivateEndpointData(e)), _privateEndpointClientDiagnostics, Pipeline, "PrivateEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _privateEndpointClientDiagnostics.CreateScope("PrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateEndpoints/{privateEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointName"> The name of the private endpoint. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointName, nameof(privateEndpointName));

            using var scope = _privateEndpointClientDiagnostics.CreateScope("PrivateEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateEndpointName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateEndpointResource> IEnumerable<PrivateEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpointResource> IAsyncEnumerable<PrivateEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
