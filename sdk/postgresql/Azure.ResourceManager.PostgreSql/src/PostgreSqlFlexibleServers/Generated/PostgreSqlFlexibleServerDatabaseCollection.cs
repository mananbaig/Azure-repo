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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlFlexibleServerDatabaseResource" /> and their operations.
    /// Each <see cref="PostgreSqlFlexibleServerDatabaseResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlFlexibleServerResource" />.
    /// To get a <see cref="PostgreSqlFlexibleServerDatabaseCollection" /> instance call the GetPostgreSqlFlexibleServerDatabases method from an instance of <see cref="PostgreSqlFlexibleServerResource" />.
    /// </summary>
    public partial class PostgreSqlFlexibleServerDatabaseCollection : ArmCollection, IEnumerable<PostgreSqlFlexibleServerDatabaseResource>, IAsyncEnumerable<PostgreSqlFlexibleServerDatabaseResource>
    {
        private readonly ClientDiagnostics _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics;
        private readonly DatabasesRestOperations _postgreSqlFlexibleServerDatabaseDatabasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerDatabaseCollection"/> class for mocking. </summary>
        protected PostgreSqlFlexibleServerDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlFlexibleServerDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlFlexibleServerDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql.FlexibleServers", PostgreSqlFlexibleServerDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlFlexibleServerDatabaseResource.ResourceType, out string postgreSqlFlexibleServerDatabaseDatabasesApiVersion);
            _postgreSqlFlexibleServerDatabaseDatabasesRestClient = new DatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlFlexibleServerDatabaseDatabasesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlFlexibleServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlFlexibleServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new database or updates an existing database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="data"> The required parameters for creating or updating a database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlFlexibleServerDatabaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseName, PostgreSqlFlexibleServerDatabaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, data, cancellationToken).ConfigureAwait(false);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerDatabaseResource>(new PostgreSqlFlexibleServerDatabaseOperationSource(Client), _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics, Pipeline, _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new database or updates an existing database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="data"> The required parameters for creating or updating a database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlFlexibleServerDatabaseResource> CreateOrUpdate(WaitUntil waitUntil, string databaseName, PostgreSqlFlexibleServerDatabaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerDatabaseDatabasesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, data, cancellationToken);
                var operation = new FlexibleServersArmOperation<PostgreSqlFlexibleServerDatabaseResource>(new PostgreSqlFlexibleServerDatabaseOperationSource(Client), _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics, Pipeline, _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlFlexibleServerDatabaseResource>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerDatabaseDatabasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a database.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<PostgreSqlFlexibleServerDatabaseResource> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerDatabaseDatabasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlFlexibleServerDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the databases in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlFlexibleServerDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerDatabaseResource(Client, PostgreSqlFlexibleServerDatabaseData.DeserializePostgreSqlFlexibleServerDatabaseData(e)), _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the databases in a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlFlexibleServerDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlFlexibleServerDatabaseDatabasesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlFlexibleServerDatabaseResource(Client, PostgreSqlFlexibleServerDatabaseData.DeserializePostgreSqlFlexibleServerDatabaseData(e)), _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics, Pipeline, "PostgreSqlFlexibleServerDatabaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlFlexibleServerDatabaseDatabasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}/databases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Databases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _postgreSqlFlexibleServerDatabaseDatabasesClientDiagnostics.CreateScope("PostgreSqlFlexibleServerDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlFlexibleServerDatabaseDatabasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlFlexibleServerDatabaseResource> IEnumerable<PostgreSqlFlexibleServerDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlFlexibleServerDatabaseResource> IAsyncEnumerable<PostgreSqlFlexibleServerDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
