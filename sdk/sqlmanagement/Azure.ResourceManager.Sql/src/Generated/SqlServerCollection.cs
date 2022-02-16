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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SqlServer and their operations over its parent. </summary>
    public partial class SqlServerCollection : ArmCollection, IEnumerable<SqlServer>, IAsyncEnumerable<SqlServer>
    {
        private readonly ClientDiagnostics _sqlServerServersClientDiagnostics;
        private readonly ServersRestOperations _sqlServerServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerCollection"/> class for mocking. </summary>
        protected SqlServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServer.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SqlServer.ResourceType, out string sqlServerServersApiVersion);
            _sqlServerServersRestClient = new ServersRestOperations(_sqlServerServersClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlServerServersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="parameters"> The requested server resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<SqlServer>> CreateOrUpdateAsync(bool waitForCompletion, string serverName, SqlServerData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerServersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServer>(new SqlServerOperationSource(Client), _sqlServerServersClientDiagnostics, Pipeline, _sqlServerServersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Creates or updates a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="parameters"> The requested server resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SqlServer> CreateOrUpdate(bool waitForCompletion, string serverName, SqlServerData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerServersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters, cancellationToken);
                var operation = new SqlArmOperation<SqlServer>(new SqlServerOperationSource(Client), _sqlServerServersClientDiagnostics, Pipeline, _sqlServerServersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, parameters).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Gets a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public async virtual Task<Response<SqlServer>> GetAsync(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sqlServerServersClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<SqlServer> Get(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken);
                if (response.Value == null)
                    throw _sqlServerServersClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of servers in a resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers
        /// Operation Id: Servers_ListByResourceGroup
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServer> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlServer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerServersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlServer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerServersRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of servers in a resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers
        /// Operation Id: Servers_ListByResourceGroup
        /// </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServer> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<SqlServer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerServersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlServer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerServersRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serverName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serverName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public async virtual Task<Response<SqlServer>> GetIfExistsAsync(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlServer>(null, response.GetRawResponse());
                return Response.FromValue(new SqlServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<SqlServer> GetIfExists(string serverName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _sqlServerServersClientDiagnostics.CreateScope("SqlServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlServer>(null, response.GetRawResponse());
                return Response.FromValue(new SqlServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServer> IEnumerable<SqlServer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServer> IAsyncEnumerable<SqlServer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
