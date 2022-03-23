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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="GremlinDatabaseResource" /> and their operations.
    /// Each <see cref="GremlinDatabaseResource" /> in the collection will belong to the same instance of <see cref="DatabaseAccountResource" />.
    /// To get a <see cref="GremlinDatabaseCollection" /> instance call the GetGremlinDatabases method from an instance of <see cref="DatabaseAccountResource" />.
    /// </summary>
    public partial class GremlinDatabaseCollection : ArmCollection, IEnumerable<GremlinDatabaseResource>, IAsyncEnumerable<GremlinDatabaseResource>
    {
        private readonly ClientDiagnostics _gremlinDatabaseGremlinResourcesClientDiagnostics;
        private readonly GremlinResourcesRestOperations _gremlinDatabaseGremlinResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GremlinDatabaseCollection"/> class for mocking. </summary>
        protected GremlinDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GremlinDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GremlinDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gremlinDatabaseGremlinResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", GremlinDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GremlinDatabaseResource.ResourceType, out string gremlinDatabaseGremlinResourcesApiVersion);
            _gremlinDatabaseGremlinResourcesRestClient = new GremlinResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gremlinDatabaseGremlinResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Gremlin database
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_CreateUpdateGremlinDatabase
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateGremlinDatabaseParameters"> The parameters to provide for the current Gremlin database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateGremlinDatabaseParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<GremlinDatabaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseName, GremlinDatabaseCreateUpdateData createUpdateGremlinDatabaseParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(createUpdateGremlinDatabaseParameters, nameof(createUpdateGremlinDatabaseParameters));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.CreateUpdateGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateGremlinDatabaseParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<GremlinDatabaseResource>(new GremlinDatabaseOperationSource(Client), _gremlinDatabaseGremlinResourcesClientDiagnostics, Pipeline, _gremlinDatabaseGremlinResourcesRestClient.CreateCreateUpdateGremlinDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateGremlinDatabaseParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB Gremlin database
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_CreateUpdateGremlinDatabase
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateGremlinDatabaseParameters"> The parameters to provide for the current Gremlin database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateGremlinDatabaseParameters"/> is null. </exception>
        public virtual ArmOperation<GremlinDatabaseResource> CreateOrUpdate(WaitUntil waitUntil, string databaseName, GremlinDatabaseCreateUpdateData createUpdateGremlinDatabaseParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(createUpdateGremlinDatabaseParameters, nameof(createUpdateGremlinDatabaseParameters));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.CreateUpdateGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateGremlinDatabaseParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<GremlinDatabaseResource>(new GremlinDatabaseOperationSource(Client), _gremlinDatabaseGremlinResourcesClientDiagnostics, Pipeline, _gremlinDatabaseGremlinResourcesRestClient.CreateCreateUpdateGremlinDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateGremlinDatabaseParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the Gremlin databases under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_GetGremlinDatabase
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<GremlinDatabaseResource>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Gremlin databases under an existing Azure Cosmos DB database account with the provided name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_GetGremlinDatabase
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<GremlinDatabaseResource> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Gremlin databases under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases
        /// Operation Id: GremlinResources_ListGremlinDatabases
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GremlinDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GremlinDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GremlinDatabaseResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _gremlinDatabaseGremlinResourcesRestClient.ListGremlinDatabasesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GremlinDatabaseResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists the Gremlin databases under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases
        /// Operation Id: GremlinResources_ListGremlinDatabases
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GremlinDatabaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GremlinDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GremlinDatabaseResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _gremlinDatabaseGremlinResourcesRestClient.ListGremlinDatabases(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GremlinDatabaseResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_GetGremlinDatabase
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Exists");
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_GetGremlinDatabase
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.Exists");
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

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_GetGremlinDatabase
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<GremlinDatabaseResource>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GremlinDatabaseResource>(null, response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/gremlinDatabases/{databaseName}
        /// Operation Id: GremlinResources_GetGremlinDatabase
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<GremlinDatabaseResource> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _gremlinDatabaseGremlinResourcesClientDiagnostics.CreateScope("GremlinDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _gremlinDatabaseGremlinResourcesRestClient.GetGremlinDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GremlinDatabaseResource>(null, response.GetRawResponse());
                return Response.FromValue(new GremlinDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GremlinDatabaseResource> IEnumerable<GremlinDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GremlinDatabaseResource> IAsyncEnumerable<GremlinDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
