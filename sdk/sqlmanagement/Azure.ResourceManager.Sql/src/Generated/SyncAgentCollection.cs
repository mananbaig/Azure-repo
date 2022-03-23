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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SyncAgentResource" /> and their operations.
    /// Each <see cref="SyncAgentResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="SyncAgentCollection" /> instance call the GetSyncAgents method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class SyncAgentCollection : ArmCollection, IEnumerable<SyncAgentResource>, IAsyncEnumerable<SyncAgentResource>
    {
        private readonly ClientDiagnostics _syncAgentClientDiagnostics;
        private readonly SyncAgentsRestOperations _syncAgentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SyncAgentCollection"/> class for mocking. </summary>
        protected SyncAgentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SyncAgentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SyncAgentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _syncAgentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SyncAgentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SyncAgentResource.ResourceType, out string syncAgentApiVersion);
            _syncAgentRestClient = new SyncAgentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, syncAgentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a sync agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="parameters"> The requested sync agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<SyncAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string syncAgentName, SyncAgentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SyncAgentResource>(new SyncAgentOperationSource(Client), _syncAgentClientDiagnostics, Pipeline, _syncAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a sync agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="parameters"> The requested sync agent resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SyncAgentResource> CreateOrUpdate(WaitUntil waitUntil, string syncAgentName, SyncAgentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, parameters, cancellationToken);
                var operation = new SqlArmOperation<SyncAgentResource>(new SyncAgentOperationSource(Client), _syncAgentClientDiagnostics, Pipeline, _syncAgentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a sync agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_Get
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual async Task<Response<SyncAgentResource>> GetAsync(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Get");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a sync agent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_Get
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual Response<SyncAgentResource> Get(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Get");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists sync agents in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents
        /// Operation Id: SyncAgents_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SyncAgentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SyncAgentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SyncAgentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _syncAgentRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SyncAgentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _syncAgentRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists sync agents in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents
        /// Operation Id: SyncAgents_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SyncAgentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SyncAgentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SyncAgentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _syncAgentRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SyncAgentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _syncAgentRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SyncAgentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_Get
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(syncAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_Get
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual Response<bool> Exists(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(syncAgentName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_Get
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual async Task<Response<SyncAgentResource>> GetIfExistsAsync(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _syncAgentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SyncAgentResource>(null, response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/syncAgents/{syncAgentName}
        /// Operation Id: SyncAgents_Get
        /// </summary>
        /// <param name="syncAgentName"> The name of the sync agent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="syncAgentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="syncAgentName"/> is null. </exception>
        public virtual Response<SyncAgentResource> GetIfExists(string syncAgentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(syncAgentName, nameof(syncAgentName));

            using var scope = _syncAgentClientDiagnostics.CreateScope("SyncAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _syncAgentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, syncAgentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SyncAgentResource>(null, response.GetRawResponse());
                return Response.FromValue(new SyncAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SyncAgentResource> IEnumerable<SyncAgentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SyncAgentResource> IAsyncEnumerable<SyncAgentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
