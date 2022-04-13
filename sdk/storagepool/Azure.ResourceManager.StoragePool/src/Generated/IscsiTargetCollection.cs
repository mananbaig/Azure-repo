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
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary>
    /// A class representing a collection of <see cref="IscsiTargetResource" /> and their operations.
    /// Each <see cref="IscsiTargetResource" /> in the collection will belong to the same instance of <see cref="DiskPoolResource" />.
    /// To get an <see cref="IscsiTargetCollection" /> instance call the GetIscsiTargets method from an instance of <see cref="DiskPoolResource" />.
    /// </summary>
    public partial class IscsiTargetCollection : ArmCollection, IEnumerable<IscsiTargetResource>, IAsyncEnumerable<IscsiTargetResource>
    {
        private readonly ClientDiagnostics _iscsiTargetClientDiagnostics;
        private readonly IscsiTargetsRestOperations _iscsiTargetRestClient;

        /// <summary> Initializes a new instance of the <see cref="IscsiTargetCollection"/> class for mocking. </summary>
        protected IscsiTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IscsiTargetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IscsiTargetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iscsiTargetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StoragePool", IscsiTargetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IscsiTargetResource.ResourceType, out string iscsiTargetApiVersion);
            _iscsiTargetRestClient = new IscsiTargetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iscsiTargetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DiskPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DiskPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update an iSCSI Target.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// Operation Id: IscsiTargets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="content"> Request payload for iSCSI Target create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<IscsiTargetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string iscsiTargetName, IscsiTargetCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iscsiTargetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content, cancellationToken).ConfigureAwait(false);
                var operation = new StoragePoolArmOperation<IscsiTargetResource>(new IscsiTargetOperationSource(Client), _iscsiTargetClientDiagnostics, Pipeline, _iscsiTargetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or Update an iSCSI Target.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// Operation Id: IscsiTargets_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="content"> Request payload for iSCSI Target create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<IscsiTargetResource> CreateOrUpdate(WaitUntil waitUntil, string iscsiTargetName, IscsiTargetCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iscsiTargetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content, cancellationToken);
                var operation = new StoragePoolArmOperation<IscsiTargetResource>(new IscsiTargetOperationSource(Client), _iscsiTargetClientDiagnostics, Pipeline, _iscsiTargetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, content).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get an iSCSI Target.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// Operation Id: IscsiTargets_Get
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual async Task<Response<IscsiTargetResource>> GetAsync(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _iscsiTargetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an iSCSI Target.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// Operation Id: IscsiTargets_Get
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual Response<IscsiTargetResource> Get(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _iscsiTargetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IscsiTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get iSCSI Targets in a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets
        /// Operation Id: IscsiTargets_ListByDiskPool
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IscsiTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IscsiTargetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IscsiTargetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _iscsiTargetRestClient.ListByDiskPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IscsiTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IscsiTargetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _iscsiTargetRestClient.ListByDiskPoolNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IscsiTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Get iSCSI Targets in a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets
        /// Operation Id: IscsiTargets_ListByDiskPool
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IscsiTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IscsiTargetResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IscsiTargetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _iscsiTargetRestClient.ListByDiskPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IscsiTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IscsiTargetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _iscsiTargetRestClient.ListByDiskPoolNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IscsiTargetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// Operation Id: IscsiTargets_Get
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iscsiTargetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}/iscsiTargets/{iscsiTargetName}
        /// Operation Id: IscsiTargets_Get
        /// </summary>
        /// <param name="iscsiTargetName"> The name of the iSCSI Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="iscsiTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="iscsiTargetName"/> is null. </exception>
        public virtual Response<bool> Exists(string iscsiTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(iscsiTargetName, nameof(iscsiTargetName));

            using var scope = _iscsiTargetClientDiagnostics.CreateScope("IscsiTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = _iscsiTargetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, iscsiTargetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IscsiTargetResource> IEnumerable<IscsiTargetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IscsiTargetResource> IAsyncEnumerable<IscsiTargetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
