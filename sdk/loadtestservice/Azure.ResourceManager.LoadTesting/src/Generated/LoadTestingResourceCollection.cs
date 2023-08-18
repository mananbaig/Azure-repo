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

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary>
    /// A class representing a collection of <see cref="LoadTestingResource" /> and their operations.
    /// Each <see cref="LoadTestingResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="LoadTestingResourceCollection" /> instance call the GetLoadTestingResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class LoadTestingResourceCollection : ArmCollection, IEnumerable<LoadTestingResource>, IAsyncEnumerable<LoadTestingResource>
    {
        private readonly ClientDiagnostics _loadTestingResourceLoadTestsClientDiagnostics;
        private readonly LoadTestsRestOperations _loadTestingResourceLoadTestsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LoadTestingResourceCollection"/> class for mocking. </summary>
        protected LoadTestingResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadTestingResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LoadTestingResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadTestingResourceLoadTestsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LoadTesting", LoadTestingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LoadTestingResource.ResourceType, out string loadTestingResourceLoadTestsApiVersion);
            _loadTestingResourceLoadTestsRestClient = new LoadTestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadTestingResourceLoadTestsApiVersion);
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
        /// Create or update LoadTest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="data"> LoadTest resource data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LoadTestingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string loadTestName, LoadTestingResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadTestName, nameof(loadTestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _loadTestingResourceLoadTestsClientDiagnostics.CreateScope("LoadTestingResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _loadTestingResourceLoadTestsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LoadTestingArmOperation<LoadTestingResource>(new LoadTestingResourceOperationSource(Client), _loadTestingResourceLoadTestsClientDiagnostics, Pipeline, _loadTestingResourceLoadTestsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update LoadTest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="data"> LoadTest resource data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LoadTestingResource> CreateOrUpdate(WaitUntil waitUntil, string loadTestName, LoadTestingResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadTestName, nameof(loadTestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _loadTestingResourceLoadTestsClientDiagnostics.CreateScope("LoadTestingResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _loadTestingResourceLoadTestsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, data, cancellationToken);
                var operation = new LoadTestingArmOperation<LoadTestingResource>(new LoadTestingResourceOperationSource(Client), _loadTestingResourceLoadTestsClientDiagnostics, Pipeline, _loadTestingResourceLoadTestsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a LoadTest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> is null. </exception>
        public virtual async Task<Response<LoadTestingResource>> GetAsync(string loadTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadTestName, nameof(loadTestName));

            using var scope = _loadTestingResourceLoadTestsClientDiagnostics.CreateScope("LoadTestingResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadTestingResourceLoadTestsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> is null. </exception>
        public virtual Response<LoadTestingResource> Get(string loadTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadTestName, nameof(loadTestName));

            using var scope = _loadTestingResourceLoadTestsClientDiagnostics.CreateScope("LoadTestingResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _loadTestingResourceLoadTestsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists loadtest resources in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadTestingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadTestingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadTestingResourceLoadTestsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadTestingResourceLoadTestsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LoadTestingResource(Client, LoadTestingResourceData.DeserializeLoadTestingResourceData(e)), _loadTestingResourceLoadTestsClientDiagnostics, Pipeline, "LoadTestingResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists loadtest resources in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadTestingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadTestingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadTestingResourceLoadTestsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadTestingResourceLoadTestsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LoadTestingResource(Client, LoadTestingResourceData.DeserializeLoadTestingResourceData(e)), _loadTestingResourceLoadTestsClientDiagnostics, Pipeline, "LoadTestingResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string loadTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadTestName, nameof(loadTestName));

            using var scope = _loadTestingResourceLoadTestsClientDiagnostics.CreateScope("LoadTestingResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _loadTestingResourceLoadTestsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadTestName"/> is null. </exception>
        public virtual Response<bool> Exists(string loadTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadTestName, nameof(loadTestName));

            using var scope = _loadTestingResourceLoadTestsClientDiagnostics.CreateScope("LoadTestingResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _loadTestingResourceLoadTestsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, loadTestName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LoadTestingResource> IEnumerable<LoadTestingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadTestingResource> IAsyncEnumerable<LoadTestingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
