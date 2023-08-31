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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBSqlUserDefinedFunctionResource" /> and their operations.
    /// Each <see cref="CosmosDBSqlUserDefinedFunctionResource" /> in the collection will belong to the same instance of <see cref="CosmosDBSqlContainerResource" />.
    /// To get a <see cref="CosmosDBSqlUserDefinedFunctionCollection" /> instance call the GetCosmosDBSqlUserDefinedFunctions method from an instance of <see cref="CosmosDBSqlContainerResource" />.
    /// </summary>
    public partial class CosmosDBSqlUserDefinedFunctionCollection : ArmCollection, IEnumerable<CosmosDBSqlUserDefinedFunctionResource>, IAsyncEnumerable<CosmosDBSqlUserDefinedFunctionResource>
    {
        private readonly ClientDiagnostics _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlUserDefinedFunctionCollection"/> class for mocking. </summary>
        protected CosmosDBSqlUserDefinedFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBSqlUserDefinedFunctionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBSqlUserDefinedFunctionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBSqlUserDefinedFunctionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBSqlUserDefinedFunctionResource.ResourceType, out string cosmosDBSqlUserDefinedFunctionSqlResourcesApiVersion);
            _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBSqlUserDefinedFunctionSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBSqlContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBSqlContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB SQL userDefinedFunction
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlUserDefinedFunction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="content"> The parameters to provide for the current SQL userDefinedFunction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBSqlUserDefinedFunctionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string userDefinedFunctionName, CosmosDBSqlUserDefinedFunctionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlUserDefinedFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.CreateUpdateSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBSqlUserDefinedFunctionResource>(new CosmosDBSqlUserDefinedFunctionOperationSource(Client), _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.CreateCreateUpdateSqlUserDefinedFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB SQL userDefinedFunction
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_CreateUpdateSqlUserDefinedFunction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="content"> The parameters to provide for the current SQL userDefinedFunction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBSqlUserDefinedFunctionResource> CreateOrUpdate(WaitUntil waitUntil, string userDefinedFunctionName, CosmosDBSqlUserDefinedFunctionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlUserDefinedFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.CreateUpdateSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBSqlUserDefinedFunctionResource>(new CosmosDBSqlUserDefinedFunctionOperationSource(Client), _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics, Pipeline, _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.CreateCreateUpdateSqlUserDefinedFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlUserDefinedFunction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBSqlUserDefinedFunctionResource>> GetAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlUserDefinedFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlUserDefinedFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlUserDefinedFunction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<CosmosDBSqlUserDefinedFunctionResource> Get(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlUserDefinedFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBSqlUserDefinedFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlUserDefinedFunctions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBSqlUserDefinedFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBSqlUserDefinedFunctionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.CreateListSqlUserDefinedFunctionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new CosmosDBSqlUserDefinedFunctionResource(Client, CosmosDBSqlUserDefinedFunctionData.DeserializeCosmosDBSqlUserDefinedFunctionData(e)), _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlUserDefinedFunctionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_ListSqlUserDefinedFunctions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBSqlUserDefinedFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBSqlUserDefinedFunctionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.CreateListSqlUserDefinedFunctionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new CosmosDBSqlUserDefinedFunctionResource(Client, CosmosDBSqlUserDefinedFunctionData.DeserializeCosmosDBSqlUserDefinedFunctionData(e)), _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics, Pipeline, "CosmosDBSqlUserDefinedFunctionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlUserDefinedFunction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlUserDefinedFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlResources_GetSqlUserDefinedFunction</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<bool> Exists(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _cosmosDBSqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("CosmosDBSqlUserDefinedFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBSqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBSqlUserDefinedFunctionResource> IEnumerable<CosmosDBSqlUserDefinedFunctionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBSqlUserDefinedFunctionResource> IAsyncEnumerable<CosmosDBSqlUserDefinedFunctionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
