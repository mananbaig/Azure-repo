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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of MongoDBDatabase and their operations over its parent. </summary>
    public partial class MongoDBDatabaseCollection : ArmCollection, IEnumerable<MongoDBDatabase>, IAsyncEnumerable<MongoDBDatabase>
    {
        private readonly ClientDiagnostics _mongoDBDatabaseMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _mongoDBDatabaseMongoDBResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MongoDBDatabaseCollection"/> class for mocking. </summary>
        protected MongoDBDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MongoDBDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MongoDBDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoDBDatabaseMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", MongoDBDatabase.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(MongoDBDatabase.ResourceType, out string mongoDBDatabaseMongoDBResourcesApiVersion);
            _mongoDBDatabaseMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(_mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, mongoDBDatabaseMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseAccount.ResourceType), nameof(id));
        }

        /// <summary> Create or updates Azure Cosmos DB MongoDB database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateMongoDBDatabaseParameters"> The parameters to provide for the current MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateMongoDBDatabaseParameters"/> is null. </exception>
        public async virtual Task<MongoDBDatabaseCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string databaseName, MongoDBDatabaseCreateUpdateOptions createUpdateMongoDBDatabaseParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            if (createUpdateMongoDBDatabaseParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateMongoDBDatabaseParameters));
            }

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.CreateUpdateMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateMongoDBDatabaseParameters, cancellationToken).ConfigureAwait(false);
                var operation = new MongoDBDatabaseCreateOrUpdateOperation(Client, _mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBDatabaseMongoDBResourcesRestClient.CreateCreateUpdateMongoDBDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateMongoDBDatabaseParameters).Request, response);
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

        /// <summary> Create or updates Azure Cosmos DB MongoDB database. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="createUpdateMongoDBDatabaseParameters"> The parameters to provide for the current MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="createUpdateMongoDBDatabaseParameters"/> is null. </exception>
        public virtual MongoDBDatabaseCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string databaseName, MongoDBDatabaseCreateUpdateOptions createUpdateMongoDBDatabaseParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            if (createUpdateMongoDBDatabaseParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateMongoDBDatabaseParameters));
            }

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.CreateUpdateMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateMongoDBDatabaseParameters, cancellationToken);
                var operation = new MongoDBDatabaseCreateOrUpdateOperation(Client, _mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBDatabaseMongoDBResourcesRestClient.CreateCreateUpdateMongoDBDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, createUpdateMongoDBDatabaseParameters).Request, response);
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

        /// <summary> Gets the MongoDB databases under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<MongoDBDatabase>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MongoDBDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the MongoDB databases under an existing Azure Cosmos DB database account with the provided name. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<MongoDBDatabase> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the MongoDB databases under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MongoDBDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MongoDBDatabase> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MongoDBDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mongoDBDatabaseMongoDBResourcesRestClient.ListMongoDBDatabasesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MongoDBDatabase(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the MongoDB databases under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MongoDBDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MongoDBDatabase> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MongoDBDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mongoDBDatabaseMongoDBResourcesRestClient.ListMongoDBDatabases(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MongoDBDatabase(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Exists");
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

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Exists");
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
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public async virtual Task<Response<MongoDBDatabase>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<MongoDBDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<MongoDBDatabase> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<MongoDBDatabase>(null, response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabase(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MongoDBDatabase> IEnumerable<MongoDBDatabase>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MongoDBDatabase> IAsyncEnumerable<MongoDBDatabase>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
