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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CassandraViewGetResultResource"/> and their operations.
    /// Each <see cref="CassandraViewGetResultResource"/> in the collection will belong to the same instance of <see cref="CassandraKeyspaceResource"/>.
    /// To get a <see cref="CassandraViewGetResultCollection"/> instance call the GetCassandraViewGetResults method from an instance of <see cref="CassandraKeyspaceResource"/>.
    /// </summary>
    public partial class CassandraViewGetResultCollection : ArmCollection, IEnumerable<CassandraViewGetResultResource>, IAsyncEnumerable<CassandraViewGetResultResource>
    {
        private readonly ClientDiagnostics _cassandraViewGetResultCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _cassandraViewGetResultCassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraViewGetResultCollection"/> class for mocking. </summary>
        protected CassandraViewGetResultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CassandraViewGetResultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CassandraViewGetResultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cassandraViewGetResultCassandraResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CassandraViewGetResultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CassandraViewGetResultResource.ResourceType, out string cassandraViewGetResultCassandraResourcesApiVersion);
            _cassandraViewGetResultCassandraResourcesRestClient = new CassandraResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cassandraViewGetResultCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CassandraKeyspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CassandraKeyspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra View
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_CreateUpdateCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="content"> The parameters to provide for the current Cassandra View. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CassandraViewGetResultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string viewName, CassandraViewGetResultCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraViewGetResultCassandraResourcesRestClient.CreateUpdateCassandraViewAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CassandraViewGetResultResource>(new CassandraViewGetResultOperationSource(Client), _cassandraViewGetResultCassandraResourcesClientDiagnostics, Pipeline, _cassandraViewGetResultCassandraResourcesRestClient.CreateCreateUpdateCassandraViewRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB Cassandra View
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_CreateUpdateCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="content"> The parameters to provide for the current Cassandra View. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CassandraViewGetResultResource> CreateOrUpdate(WaitUntil waitUntil, string viewName, CassandraViewGetResultCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraViewGetResultCassandraResourcesRestClient.CreateUpdateCassandraView(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CassandraViewGetResultResource>(new CassandraViewGetResultOperationSource(Client), _cassandraViewGetResultCassandraResourcesClientDiagnostics, Pipeline, _cassandraViewGetResultCassandraResourcesRestClient.CreateCreateUpdateCassandraViewRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the Cassandra view under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<Response<CassandraViewGetResultResource>> GetAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraViewGetResultCassandraResourcesRestClient.GetCassandraViewAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraViewGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Cassandra view under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual Response<CassandraViewGetResultResource> Get(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraViewGetResultCassandraResourcesRestClient.GetCassandraView(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraViewGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Cassandra materialized views under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_ListCassandraViews</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraViewGetResultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraViewGetResultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cassandraViewGetResultCassandraResourcesRestClient.CreateListCassandraViewsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CassandraViewGetResultResource(Client, CassandraViewGetResultData.DeserializeCassandraViewGetResultData(e)), _cassandraViewGetResultCassandraResourcesClientDiagnostics, Pipeline, "CassandraViewGetResultCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the Cassandra materialized views under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_ListCassandraViews</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraViewGetResultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraViewGetResultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cassandraViewGetResultCassandraResourcesRestClient.CreateListCassandraViewsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CassandraViewGetResultResource(Client, CassandraViewGetResultData.DeserializeCassandraViewGetResultData(e)), _cassandraViewGetResultCassandraResourcesClientDiagnostics, Pipeline, "CassandraViewGetResultCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cassandraViewGetResultCassandraResourcesRestClient.GetCassandraViewAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual Response<bool> Exists(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.Exists");
            scope.Start();
            try
            {
                var response = _cassandraViewGetResultCassandraResourcesRestClient.GetCassandraView(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual async Task<NullableResponse<CassandraViewGetResultResource>> GetIfExistsAsync(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cassandraViewGetResultCassandraResourcesRestClient.GetCassandraViewAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CassandraViewGetResultResource>(response.GetRawResponse());
                return Response.FromValue(new CassandraViewGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/views/{viewName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraView</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraViewGetResultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="viewName"> Cosmos DB view name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="viewName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="viewName"/> is null. </exception>
        public virtual NullableResponse<CassandraViewGetResultResource> GetIfExists(string viewName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(viewName, nameof(viewName));

            using var scope = _cassandraViewGetResultCassandraResourcesClientDiagnostics.CreateScope("CassandraViewGetResultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cassandraViewGetResultCassandraResourcesRestClient.GetCassandraView(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, viewName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CassandraViewGetResultResource>(response.GetRawResponse());
                return Response.FromValue(new CassandraViewGetResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CassandraViewGetResultResource> IEnumerable<CassandraViewGetResultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraViewGetResultResource> IAsyncEnumerable<CassandraViewGetResultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
