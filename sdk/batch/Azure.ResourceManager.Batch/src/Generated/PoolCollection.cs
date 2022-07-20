// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing a collection of <see cref="PoolResource" /> and their operations.
    /// Each <see cref="PoolResource" /> in the collection will belong to the same instance of <see cref="BatchAccountResource" />.
    /// To get a <see cref="PoolCollection" /> instance call the GetPools method from an instance of <see cref="BatchAccountResource" />.
    /// </summary>
    public partial class PoolCollection : ArmCollection, IEnumerable<PoolResource>, IAsyncEnumerable<PoolResource>
    {
        private readonly ClientDiagnostics _poolClientDiagnostics;
        private readonly PoolRestOperations _poolRestClient;

        /// <summary> Initializes a new instance of the <see cref="PoolCollection"/> class for mocking. </summary>
        protected PoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _poolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", PoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PoolResource.ResourceType, out string poolApiVersion);
            _poolRestClient = new PoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, poolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BatchAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BatchAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new pool inside the specified account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}
        /// Operation Id: Pool_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="data"> Additional parameters for pool creation. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the pool to update. A value of &quot;*&quot; can be used to apply the operation only if the pool already exists. If omitted, this operation will always be applied. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new pool to be created, but to prevent updating an existing pool. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string poolName, PoolData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _poolRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new BatchArmOperation<PoolResource>(Response.FromValue(new PoolResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new pool inside the specified account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}
        /// Operation Id: Pool_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="data"> Additional parameters for pool creation. </param>
        /// <param name="ifMatch"> The entity state (ETag) version of the pool to update. A value of &quot;*&quot; can be used to apply the operation only if the pool already exists. If omitted, this operation will always be applied. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new pool to be created, but to prevent updating an existing pool. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PoolResource> CreateOrUpdate(WaitUntil waitUntil, string poolName, PoolData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _poolRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new BatchArmOperation<PoolResource>(Response.FromValue(new PoolResource(Client, response), response.GetRawResponse()));
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
        /// Gets information about the specified pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}
        /// Operation Id: Pool_Get
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<PoolResource>> GetAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _poolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}
        /// Operation Id: Pool_Get
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<PoolResource> Get(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Get");
            scope.Start();
            try
            {
                var response = _poolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the pools in the specified account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools
        /// Operation Id: Pool_ListByBatchAccount
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="select"> Comma separated list of properties that should be returned. e.g. &quot;properties/provisioningState&quot;. Only top level properties under properties/ are valid for selection. </param>
        /// <param name="filter">
        /// OData filter expression. Valid properties for filtering are:
        /// 
        ///  name
        ///  properties/allocationState
        ///  properties/allocationStateTransitionTime
        ///  properties/creationTime
        ///  properties/provisioningState
        ///  properties/provisioningStateTransitionTime
        ///  properties/lastModified
        ///  properties/vmSize
        ///  properties/interNodeCommunication
        ///  properties/scaleSettings/autoScale
        ///  properties/scaleSettings/fixedScale
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PoolResource> GetAllAsync(int? maxresults = null, string select = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PoolResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _poolRestClient.ListByBatchAccountAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PoolResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _poolRestClient.ListByBatchAccountNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all of the pools in the specified account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools
        /// Operation Id: Pool_ListByBatchAccount
        /// </summary>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="select"> Comma separated list of properties that should be returned. e.g. &quot;properties/provisioningState&quot;. Only top level properties under properties/ are valid for selection. </param>
        /// <param name="filter">
        /// OData filter expression. Valid properties for filtering are:
        /// 
        ///  name
        ///  properties/allocationState
        ///  properties/allocationStateTransitionTime
        ///  properties/creationTime
        ///  properties/provisioningState
        ///  properties/provisioningStateTransitionTime
        ///  properties/lastModified
        ///  properties/vmSize
        ///  properties/interNodeCommunication
        ///  properties/scaleSettings/autoScale
        ///  properties/scaleSettings/fixedScale
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PoolResource> GetAll(int? maxresults = null, string select = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<PoolResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _poolRestClient.ListByBatchAccount(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PoolResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _poolRestClient.ListByBatchAccountNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, maxresults, select, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}
        /// Operation Id: Pool_Get
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _poolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/pools/{poolName}
        /// Operation Id: Pool_Get
        /// </summary>
        /// <param name="poolName"> The pool name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<bool> Exists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _poolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PoolResource> IEnumerable<PoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PoolResource> IAsyncEnumerable<PoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
