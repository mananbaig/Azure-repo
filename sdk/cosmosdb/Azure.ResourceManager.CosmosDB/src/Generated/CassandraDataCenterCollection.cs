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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CassandraDataCenterResource" /> and their operations.
    /// Each <see cref="CassandraDataCenterResource" /> in the collection will belong to the same instance of <see cref="CassandraClusterResource" />.
    /// To get a <see cref="CassandraDataCenterCollection" /> instance call the GetCassandraDataCenters method from an instance of <see cref="CassandraClusterResource" />.
    /// </summary>
    public partial class CassandraDataCenterCollection : ArmCollection, IEnumerable<CassandraDataCenterResource>, IAsyncEnumerable<CassandraDataCenterResource>
    {
        private readonly ClientDiagnostics _cassandraDataCenterClientDiagnostics;
        private readonly CassandraDataCentersRestOperations _cassandraDataCenterRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraDataCenterCollection"/> class for mocking. </summary>
        protected CassandraDataCenterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CassandraDataCenterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CassandraDataCenterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cassandraDataCenterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CassandraDataCenterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CassandraDataCenterResource.ResourceType, out string cassandraDataCenterApiVersion);
            _cassandraDataCenterRestClient = new CassandraDataCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cassandraDataCenterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CassandraClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CassandraClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a managed Cassandra data center. When updating, overwrite all properties. To update only some properties, use PATCH.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_CreateUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="data"> Parameters specifying the managed Cassandra data center. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CassandraDataCenterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataCenterName, CassandraDataCenterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cassandraDataCenterClientDiagnostics.CreateScope("CassandraDataCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraDataCenterRestClient.CreateUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CassandraDataCenterResource>(new CassandraDataCenterOperationSource(Client), _cassandraDataCenterClientDiagnostics, Pipeline, _cassandraDataCenterRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a managed Cassandra data center. When updating, overwrite all properties. To update only some properties, use PATCH.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_CreateUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="data"> Parameters specifying the managed Cassandra data center. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CassandraDataCenterResource> CreateOrUpdate(WaitUntil waitUntil, string dataCenterName, CassandraDataCenterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cassandraDataCenterClientDiagnostics.CreateScope("CassandraDataCenterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraDataCenterRestClient.CreateUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CassandraDataCenterResource>(new CassandraDataCenterOperationSource(Client), _cassandraDataCenterClientDiagnostics, Pipeline, _cassandraDataCenterRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the properties of a managed Cassandra data center.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual async Task<Response<CassandraDataCenterResource>> GetAsync(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _cassandraDataCenterClientDiagnostics.CreateScope("CassandraDataCenterCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraDataCenterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraDataCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a managed Cassandra data center.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual Response<CassandraDataCenterResource> Get(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _cassandraDataCenterClientDiagnostics.CreateScope("CassandraDataCenterCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraDataCenterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraDataCenterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all data centers in a particular managed Cassandra cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraDataCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraDataCenterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cassandraDataCenterRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new CassandraDataCenterResource(Client, CassandraDataCenterData.DeserializeCassandraDataCenterData(e)), _cassandraDataCenterClientDiagnostics, Pipeline, "CassandraDataCenterCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all data centers in a particular managed Cassandra cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraDataCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraDataCenterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cassandraDataCenterRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new CassandraDataCenterResource(Client, CassandraDataCenterData.DeserializeCassandraDataCenterData(e)), _cassandraDataCenterClientDiagnostics, Pipeline, "CassandraDataCenterCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _cassandraDataCenterClientDiagnostics.CreateScope("CassandraDataCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cassandraDataCenterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}/dataCenters/{dataCenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraDataCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCenterName"> Data center name in a managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCenterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCenterName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataCenterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCenterName, nameof(dataCenterName));

            using var scope = _cassandraDataCenterClientDiagnostics.CreateScope("CassandraDataCenterCollection.Exists");
            scope.Start();
            try
            {
                var response = _cassandraDataCenterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dataCenterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CassandraDataCenterResource> IEnumerable<CassandraDataCenterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraDataCenterResource> IAsyncEnumerable<CassandraDataCenterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
