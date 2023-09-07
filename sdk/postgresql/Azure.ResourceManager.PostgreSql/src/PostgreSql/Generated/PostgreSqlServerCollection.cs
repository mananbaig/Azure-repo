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
using Azure.ResourceManager.PostgreSql.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlServerResource" /> and their operations.
    /// Each <see cref="PostgreSqlServerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PostgreSqlServerCollection" /> instance call the GetPostgreSqlServers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PostgreSqlServerCollection : ArmCollection, IEnumerable<PostgreSqlServerResource>, IAsyncEnumerable<PostgreSqlServerResource>
    {
        private readonly ClientDiagnostics _postgreSqlServerServersClientDiagnostics;
        private readonly ServersRestOperations _postgreSqlServerServersRestClient;
        private readonly ClientDiagnostics _replicasClientDiagnostics;
        private readonly ReplicasRestOperations _replicasRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerCollection"/> class for mocking. </summary>
        protected PostgreSqlServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlServerServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", PostgreSqlServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlServerResource.ResourceType, out string postgreSqlServerServersApiVersion);
            _postgreSqlServerServersRestClient = new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlServerServersApiVersion);
            _replicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _replicasRestClient = new ReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
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
        /// Creates a new server, or will overwrite an existing server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="content"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlServerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serverName, PostgreSqlServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _postgreSqlServerServersClientDiagnostics.CreateScope("PostgreSqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerServersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, content, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<PostgreSqlServerResource>(new PostgreSqlServerOperationSource(Client), _postgreSqlServerServersClientDiagnostics, Pipeline, _postgreSqlServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates a new server, or will overwrite an existing server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="content"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlServerResource> CreateOrUpdate(WaitUntil waitUntil, string serverName, PostgreSqlServerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _postgreSqlServerServersClientDiagnostics.CreateScope("PostgreSqlServerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlServerServersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, serverName, content, cancellationToken);
                var operation = new PostgreSqlArmOperation<PostgreSqlServerResource>(new PostgreSqlServerOperationSource(Client), _postgreSqlServerServersClientDiagnostics, Pipeline, _postgreSqlServerServersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName, content).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlServerResource>> GetAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlServerServersClientDiagnostics.CreateScope("PostgreSqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<PostgreSqlServerResource> Get(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlServerServersClientDiagnostics.CreateScope("PostgreSqlServerCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the servers in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlServerServersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new PostgreSqlServerResource(Client, PostgreSqlServerData.DeserializePostgreSqlServerData(e)), _postgreSqlServerServersClientDiagnostics, Pipeline, "PostgreSqlServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlServerServersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new PostgreSqlServerResource(Client, PostgreSqlServerData.DeserializePostgreSqlServerData(e)), _postgreSqlServerServersClientDiagnostics, Pipeline, "PostgreSqlServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the replicas for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <returns> An async collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlServerResource> GetReplicasAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicasRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new PostgreSqlServerResource(Client, PostgreSqlServerData.DeserializePostgreSqlServerData(e)), _replicasClientDiagnostics, Pipeline, "PostgreSqlServerCollection.GetReplicas", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the replicas for a given server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        /// <returns> A collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlServerResource> GetReplicas(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _replicasRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, serverName);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new PostgreSqlServerResource(Client, PostgreSqlServerData.DeserializePostgreSqlServerData(e)), _replicasClientDiagnostics, Pipeline, "PostgreSqlServerCollection.GetReplicas", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlServerServersClientDiagnostics.CreateScope("PostgreSqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _postgreSqlServerServersClientDiagnostics.CreateScope("PostgreSqlServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serverName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlServerResource> IEnumerable<PostgreSqlServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlServerResource> IAsyncEnumerable<PostgreSqlServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
