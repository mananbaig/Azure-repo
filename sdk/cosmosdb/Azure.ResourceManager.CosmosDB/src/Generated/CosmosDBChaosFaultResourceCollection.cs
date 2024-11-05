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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBChaosFaultResource"/> and their operations.
    /// Each <see cref="CosmosDBChaosFaultResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="CosmosDBChaosFaultResourceCollection"/> instance call the GetCosmosDBChaosFaultResources method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class CosmosDBChaosFaultResourceCollection : ArmCollection, IEnumerable<CosmosDBChaosFaultResource>, IAsyncEnumerable<CosmosDBChaosFaultResource>
    {
        private readonly ClientDiagnostics _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics;
        private readonly ChaosFaultRestOperations _cosmosDBChaosFaultResourceChaosFaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBChaosFaultResourceCollection"/> class for mocking. </summary>
        protected CosmosDBChaosFaultResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBChaosFaultResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBChaosFaultResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBChaosFaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBChaosFaultResource.ResourceType, out string cosmosDBChaosFaultResourceChaosFaultApiVersion);
            _cosmosDBChaosFaultResourceChaosFaultRestClient = new ChaosFaultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBChaosFaultResourceChaosFaultApiVersion);
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
        /// Enable, disable Chaos Fault in a CosmosDB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_EnableDisable</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="data"> A request object to enable/disable the chaos fault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBChaosFaultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string chaosFault, CosmosDBChaosFaultResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cosmosDBChaosFaultResourceChaosFaultRestClient.EnableDisableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBChaosFaultResource>(new CosmosDBChaosFaultResourceOperationSource(Client), _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics, Pipeline, _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateEnableDisableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, data).Request, response, OperationFinalStateVia.Location);
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
        /// Enable, disable Chaos Fault in a CosmosDB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_EnableDisable</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="data"> A request object to enable/disable the chaos fault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBChaosFaultResource> CreateOrUpdate(WaitUntil waitUntil, string chaosFault, CosmosDBChaosFaultResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cosmosDBChaosFaultResourceChaosFaultRestClient.EnableDisable(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBChaosFaultResource>(new CosmosDBChaosFaultResourceOperationSource(Client), _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics, Pipeline, _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateEnableDisableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get Chaos Fault for a CosmosdB account for a particular Chaos Fault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> is null. </exception>
        public virtual async Task<Response<CosmosDBChaosFaultResource>> GetAsync(string chaosFault, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBChaosFaultResourceChaosFaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBChaosFaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Chaos Fault for a CosmosdB account for a particular Chaos Fault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> is null. </exception>
        public virtual Response<CosmosDBChaosFaultResource> Get(string chaosFault, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBChaosFaultResourceChaosFaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBChaosFaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Chaos Faults for CosmosDB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBChaosFaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBChaosFaultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CosmosDBChaosFaultResource(Client, CosmosDBChaosFaultResourceData.DeserializeCosmosDBChaosFaultResourceData(e)), _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics, Pipeline, "CosmosDBChaosFaultResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Chaos Faults for CosmosDB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBChaosFaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBChaosFaultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CosmosDBChaosFaultResource(Client, CosmosDBChaosFaultResourceData.DeserializeCosmosDBChaosFaultResourceData(e)), _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics, Pipeline, "CosmosDBChaosFaultResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string chaosFault, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBChaosFaultResourceChaosFaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> is null. </exception>
        public virtual Response<bool> Exists(string chaosFault, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBChaosFaultResourceChaosFaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> is null. </exception>
        public virtual async Task<NullableResponse<CosmosDBChaosFaultResource>> GetIfExistsAsync(string chaosFault, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cosmosDBChaosFaultResourceChaosFaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBChaosFaultResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBChaosFaultResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chaosFault"> The name of the ChaosFault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="chaosFault"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="chaosFault"/> is null. </exception>
        public virtual NullableResponse<CosmosDBChaosFaultResource> GetIfExists(string chaosFault, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(chaosFault, nameof(chaosFault));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cosmosDBChaosFaultResourceChaosFaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, chaosFault, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CosmosDBChaosFaultResource>(response.GetRawResponse());
                return Response.FromValue(new CosmosDBChaosFaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBChaosFaultResource> IEnumerable<CosmosDBChaosFaultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBChaosFaultResource> IAsyncEnumerable<CosmosDBChaosFaultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
