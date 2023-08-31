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
    /// A class representing a collection of <see cref="CosmosDBServiceResource" /> and their operations.
    /// Each <see cref="CosmosDBServiceResource" /> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource" />.
    /// To get a <see cref="CosmosDBServiceCollection" /> instance call the GetCosmosDBServices method from an instance of <see cref="CosmosDBAccountResource" />.
    /// </summary>
    public partial class CosmosDBServiceCollection : ArmCollection, IEnumerable<CosmosDBServiceResource>, IAsyncEnumerable<CosmosDBServiceResource>
    {
        private readonly ClientDiagnostics _cosmosDBServiceServiceClientDiagnostics;
        private readonly ServiceRestOperations _cosmosDBServiceServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBServiceCollection"/> class for mocking. </summary>
        protected CosmosDBServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBServiceServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBServiceResource.ResourceType, out string cosmosDBServiceServiceApiVersion);
            _cosmosDBServiceServiceRestClient = new ServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBServiceServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> Cosmos DB service name. </param>
        /// <param name="content"> The Service resource parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string serviceName, CosmosDBServiceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBServiceServiceClientDiagnostics.CreateScope("CosmosDBServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBServiceServiceRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBServiceResource>(new CosmosDBServiceOperationSource(Client), _cosmosDBServiceServiceClientDiagnostics, Pipeline, _cosmosDBServiceServiceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="serviceName"> Cosmos DB service name. </param>
        /// <param name="content"> The Service resource parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CosmosDBServiceResource> CreateOrUpdate(WaitUntil waitUntil, string serviceName, CosmosDBServiceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cosmosDBServiceServiceClientDiagnostics.CreateScope("CosmosDBServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBServiceServiceRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBServiceResource>(new CosmosDBServiceOperationSource(Client), _cosmosDBServiceServiceClientDiagnostics, Pipeline, _cosmosDBServiceServiceRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the status of service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Cosmos DB service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBServiceResource>> GetAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _cosmosDBServiceServiceClientDiagnostics.CreateScope("CosmosDBServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBServiceServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the status of service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Cosmos DB service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<CosmosDBServiceResource> Get(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _cosmosDBServiceServiceClientDiagnostics.CreateScope("CosmosDBServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBServiceServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the status of service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBServiceServiceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new CosmosDBServiceResource(Client, CosmosDBServiceData.DeserializeCosmosDBServiceData(e)), _cosmosDBServiceServiceClientDiagnostics, Pipeline, "CosmosDBServiceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the status of service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBServiceServiceRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new CosmosDBServiceResource(Client, CosmosDBServiceData.DeserializeCosmosDBServiceData(e)), _cosmosDBServiceServiceClientDiagnostics, Pipeline, "CosmosDBServiceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Cosmos DB service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _cosmosDBServiceServiceClientDiagnostics.CreateScope("CosmosDBServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBServiceServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Cosmos DB service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serviceName, nameof(serviceName));

            using var scope = _cosmosDBServiceServiceClientDiagnostics.CreateScope("CosmosDBServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBServiceServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serviceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBServiceResource> IEnumerable<CosmosDBServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBServiceResource> IAsyncEnumerable<CosmosDBServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
