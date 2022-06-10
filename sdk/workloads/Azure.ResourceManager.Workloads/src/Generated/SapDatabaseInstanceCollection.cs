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

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing a collection of <see cref="SapDatabaseInstanceResource" /> and their operations.
    /// Each <see cref="SapDatabaseInstanceResource" /> in the collection will belong to the same instance of <see cref="SapVirtualInstanceResource" />.
    /// To get a <see cref="SapDatabaseInstanceCollection" /> instance call the GetSapDatabaseInstances method from an instance of <see cref="SapVirtualInstanceResource" />.
    /// </summary>
    public partial class SapDatabaseInstanceCollection : ArmCollection, IEnumerable<SapDatabaseInstanceResource>, IAsyncEnumerable<SapDatabaseInstanceResource>
    {
        private readonly ClientDiagnostics _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics;
        private readonly SAPDatabaseInstancesRestOperations _sapDatabaseInstanceSAPDatabaseInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SapDatabaseInstanceCollection"/> class for mocking. </summary>
        protected SapDatabaseInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapDatabaseInstanceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SapDatabaseInstanceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Workloads", SapDatabaseInstanceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SapDatabaseInstanceResource.ResourceType, out string sapDatabaseInstanceSAPDatabaseInstancesApiVersion);
            _sapDatabaseInstanceSAPDatabaseInstancesRestClient = new SAPDatabaseInstancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapDatabaseInstanceSAPDatabaseInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SapVirtualInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SapVirtualInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Puts the SAP Database Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}
        /// Operation Id: SAPDatabaseInstances_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseInstanceName"> Database Instance string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> The SAP Database Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual async Task<ArmOperation<SapDatabaseInstanceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseInstanceName, SapDatabaseInstanceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapDatabaseInstanceSAPDatabaseInstancesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadsArmOperation<SapDatabaseInstanceResource>(new SapDatabaseInstanceOperationSource(Client), _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics, Pipeline, _sapDatabaseInstanceSAPDatabaseInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Puts the SAP Database Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}
        /// Operation Id: SAPDatabaseInstances_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseInstanceName"> Database Instance string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> The SAP Database Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual ArmOperation<SapDatabaseInstanceResource> CreateOrUpdate(WaitUntil waitUntil, string databaseInstanceName, SapDatabaseInstanceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapDatabaseInstanceSAPDatabaseInstancesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data, cancellationToken);
                var operation = new WorkloadsArmOperation<SapDatabaseInstanceResource>(new SapDatabaseInstanceOperationSource(Client), _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics, Pipeline, _sapDatabaseInstanceSAPDatabaseInstancesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the SAP Database Instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}
        /// Operation Id: SAPDatabaseInstances_Get
        /// </summary>
        /// <param name="databaseInstanceName"> Database Instance string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual async Task<Response<SapDatabaseInstanceResource>> GetAsync(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sapDatabaseInstanceSAPDatabaseInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDatabaseInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SAP Database Instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}
        /// Operation Id: SAPDatabaseInstances_Get
        /// </summary>
        /// <param name="databaseInstanceName"> Database Instance string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual Response<SapDatabaseInstanceResource> Get(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _sapDatabaseInstanceSAPDatabaseInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDatabaseInstanceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the SAP Database Instances in an SVI.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances
        /// Operation Id: SAPDatabaseInstances_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapDatabaseInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SapDatabaseInstanceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SapDatabaseInstanceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sapDatabaseInstanceSAPDatabaseInstancesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SapDatabaseInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SapDatabaseInstanceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sapDatabaseInstanceSAPDatabaseInstancesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SapDatabaseInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists the SAP Database Instances in an SVI.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances
        /// Operation Id: SAPDatabaseInstances_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapDatabaseInstanceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SapDatabaseInstanceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SapDatabaseInstanceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sapDatabaseInstanceSAPDatabaseInstancesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SapDatabaseInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SapDatabaseInstanceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sapDatabaseInstanceSAPDatabaseInstancesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SapDatabaseInstanceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}
        /// Operation Id: SAPDatabaseInstances_Get
        /// </summary>
        /// <param name="databaseInstanceName"> Database Instance string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sapDatabaseInstanceSAPDatabaseInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapVirtualInstances/{sapVirtualInstanceName}/databaseInstances/{databaseInstanceName}
        /// Operation Id: SAPDatabaseInstances_Get
        /// </summary>
        /// <param name="databaseInstanceName"> Database Instance string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseInstanceName, nameof(databaseInstanceName));

            using var scope = _sapDatabaseInstanceSAPDatabaseInstancesClientDiagnostics.CreateScope("SapDatabaseInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sapDatabaseInstanceSAPDatabaseInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseInstanceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SapDatabaseInstanceResource> IEnumerable<SapDatabaseInstanceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SapDatabaseInstanceResource> IAsyncEnumerable<SapDatabaseInstanceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
