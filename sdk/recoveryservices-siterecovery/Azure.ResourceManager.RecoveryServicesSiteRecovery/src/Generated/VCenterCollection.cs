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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="VCenterResource" /> and their operations.
    /// Each <see cref="VCenterResource" /> in the collection will belong to the same instance of <see cref="FabricResource" />.
    /// To get a <see cref="VCenterCollection" /> instance call the GetVCenters method from an instance of <see cref="FabricResource" />.
    /// </summary>
    public partial class VCenterCollection : ArmCollection, IEnumerable<VCenterResource>, IAsyncEnumerable<VCenterResource>
    {
        private readonly ClientDiagnostics _vCenterReplicationvCentersClientDiagnostics;
        private readonly ReplicationvCentersRestOperations _vCenterReplicationvCentersRestClient;

        /// <summary> Initializes a new instance of the <see cref="VCenterCollection"/> class for mocking. </summary>
        protected VCenterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VCenterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VCenterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vCenterReplicationvCentersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", VCenterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VCenterResource.ResourceType, out string vCenterReplicationvCentersApiVersion);
            _vCenterReplicationvCentersRestClient = new ReplicationvCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vCenterReplicationvCentersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a vCenter object..
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}
        /// Operation Id: ReplicationvCenters_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vcenterName"> vcenter name. </param>
        /// <param name="content"> The input to the add vCenter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<VCenterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vcenterName, VCenterCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vCenterReplicationvCentersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<VCenterResource>(new VCenterOperationSource(Client), _vCenterReplicationvCentersClientDiagnostics, Pipeline, _vCenterReplicationvCentersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create a vCenter object..
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}
        /// Operation Id: ReplicationvCenters_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vcenterName"> vcenter name. </param>
        /// <param name="content"> The input to the add vCenter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<VCenterResource> CreateOrUpdate(WaitUntil waitUntil, string vcenterName, VCenterCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vCenterReplicationvCentersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<VCenterResource>(new VCenterOperationSource(Client), _vCenterReplicationvCentersClientDiagnostics, Pipeline, _vCenterReplicationvCentersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of a registered vCenter server(Add vCenter server).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}
        /// Operation Id: ReplicationvCenters_Get
        /// </summary>
        /// <param name="vcenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual async Task<Response<VCenterResource>> GetAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.Get");
            scope.Start();
            try
            {
                var response = await _vCenterReplicationvCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a registered vCenter server(Add vCenter server).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}
        /// Operation Id: ReplicationvCenters_Get
        /// </summary>
        /// <param name="vcenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<VCenterResource> Get(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.Get");
            scope.Start();
            try
            {
                var response = _vCenterReplicationvCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the vCenter servers registered in a fabric.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters
        /// Operation Id: ReplicationvCenters_ListByReplicationFabrics
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VCenterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VCenterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vCenterReplicationvCentersRestClient.ListByReplicationFabricsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VCenterResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vCenterReplicationvCentersRestClient.ListByReplicationFabricsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the vCenter servers registered in a fabric.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters
        /// Operation Id: ReplicationvCenters_ListByReplicationFabrics
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VCenterResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VCenterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vCenterReplicationvCentersRestClient.ListByReplicationFabrics(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VCenterResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vCenterReplicationvCentersRestClient.ListByReplicationFabricsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VCenterResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}
        /// Operation Id: ReplicationvCenters_Get
        /// </summary>
        /// <param name="vcenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vCenterReplicationvCentersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationvCenters/{vcenterName}
        /// Operation Id: ReplicationvCenters_Get
        /// </summary>
        /// <param name="vcenterName"> vcenter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string vcenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vcenterName, nameof(vcenterName));

            using var scope = _vCenterReplicationvCentersClientDiagnostics.CreateScope("VCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = _vCenterReplicationvCentersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vcenterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VCenterResource> IEnumerable<VCenterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VCenterResource> IAsyncEnumerable<VCenterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
