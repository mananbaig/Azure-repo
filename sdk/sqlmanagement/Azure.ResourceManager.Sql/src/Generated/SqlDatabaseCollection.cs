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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SqlDatabase and their operations over its parent. </summary>
    public partial class SqlDatabaseCollection : ArmCollection, IEnumerable<SqlDatabase>, IAsyncEnumerable<SqlDatabase>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DatabasesRestOperations _databasesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseCollection"/> class for mocking. </summary>
        protected SqlDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlDatabaseCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlDatabaseCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SqlDatabase.ResourceType, out string apiVersion);
            _databasesRestClient = new DatabasesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: Databases_CreateOrUpdate
        /// <summary> Creates a new database or updates an existing database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="parameters"> The requested database resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SqlDatabaseCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string databaseName, SqlDatabaseData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databasesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, parameters, cancellationToken);
                var operation = new SqlDatabaseCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _databasesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: Databases_CreateOrUpdate
        /// <summary> Creates a new database or updates an existing database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="parameters"> The requested database resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SqlDatabaseCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string databaseName, SqlDatabaseData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databasesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlDatabaseCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _databasesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: Databases_Get
        /// <summary> Gets a database. </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<SqlDatabase> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _databasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: Databases_Get
        /// <summary> Gets a database. </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<SqlDatabase>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _databasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<SqlDatabase> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databasesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<SqlDatabase>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _databasesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new SqlDatabase(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(databaseName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: Databases_ListByServer
        /// <summary> Gets a list of databases. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlDatabase> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<SqlDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databasesRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlDatabase> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databasesRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: Databases_ListByServer
        /// <summary> Gets a list of databases. </summary>
        /// <param name="skipToken"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlDatabase> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databasesRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlDatabase>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SqlDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databasesRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlDatabase(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SqlDatabase> IEnumerable<SqlDatabase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlDatabase> IAsyncEnumerable<SqlDatabase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SqlDatabase, SqlDatabaseData> Construct() { }
    }
}
