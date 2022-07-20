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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerTrustGroupResource" /> and their operations.
    /// Each <see cref="SqlServerTrustGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SqlServerTrustGroupCollection" /> instance call the GetSqlServerTrustGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SqlServerTrustGroupCollection : ArmCollection, IEnumerable<SqlServerTrustGroupResource>, IAsyncEnumerable<SqlServerTrustGroupResource>
    {
        private readonly ClientDiagnostics _sqlServerTrustGroupServerTrustGroupsClientDiagnostics;
        private readonly ServerTrustGroupsRestOperations _sqlServerTrustGroupServerTrustGroupsRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="SqlServerTrustGroupCollection"/> class for mocking. </summary>
        protected SqlServerTrustGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerTrustGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SqlServerTrustGroupCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _sqlServerTrustGroupServerTrustGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerTrustGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerTrustGroupResource.ResourceType, out string sqlServerTrustGroupServerTrustGroupsApiVersion);
            _sqlServerTrustGroupServerTrustGroupsRestClient = new ServerTrustGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerTrustGroupServerTrustGroupsApiVersion);
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
        /// Creates or updates a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="data"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerTrustGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverTrustGroupName, SqlServerTrustGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerTrustGroupResource>(new SqlServerTrustGroupOperationSource(Client), _sqlServerTrustGroupServerTrustGroupsClientDiagnostics, Pipeline, _sqlServerTrustGroupServerTrustGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="data"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerTrustGroupResource> CreateOrUpdate(WaitUntil waitUntil, string serverTrustGroupName, SqlServerTrustGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerTrustGroupResource>(new SqlServerTrustGroupOperationSource(Client), _sqlServerTrustGroupServerTrustGroupsClientDiagnostics, Pipeline, _sqlServerTrustGroupServerTrustGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<SqlServerTrustGroupResource>> GetAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerTrustGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<SqlServerTrustGroupResource> Get(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerTrustGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups
        /// Operation Id: ServerTrustGroups_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerTrustGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerTrustGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlServerTrustGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.ListByLocationAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerTrustGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlServerTrustGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerTrustGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists a server trust group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups
        /// Operation Id: ServerTrustGroups_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerTrustGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerTrustGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlServerTrustGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerTrustGroupServerTrustGroupsRestClient.ListByLocation(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerTrustGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlServerTrustGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerTrustGroupServerTrustGroupsRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerTrustGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerTrustGroupServerTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// Operation Id: ServerTrustGroups_Get
        /// </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverTrustGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverTrustGroupName, nameof(serverTrustGroupName));

            using var scope = _sqlServerTrustGroupServerTrustGroupsClientDiagnostics.CreateScope("SqlServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerTrustGroupServerTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerTrustGroupResource> IEnumerable<SqlServerTrustGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerTrustGroupResource> IAsyncEnumerable<SqlServerTrustGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
