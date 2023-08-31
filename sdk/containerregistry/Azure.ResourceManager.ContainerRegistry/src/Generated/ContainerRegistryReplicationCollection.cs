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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryReplicationResource" /> and their operations.
    /// Each <see cref="ContainerRegistryReplicationResource" /> in the collection will belong to the same instance of <see cref="ContainerRegistryResource" />.
    /// To get a <see cref="ContainerRegistryReplicationCollection" /> instance call the GetContainerRegistryReplications method from an instance of <see cref="ContainerRegistryResource" />.
    /// </summary>
    public partial class ContainerRegistryReplicationCollection : ArmCollection, IEnumerable<ContainerRegistryReplicationResource>, IAsyncEnumerable<ContainerRegistryReplicationResource>
    {
        private readonly ClientDiagnostics _containerRegistryReplicationReplicationsClientDiagnostics;
        private readonly ReplicationsRestOperations _containerRegistryReplicationReplicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryReplicationCollection"/> class for mocking. </summary>
        protected ContainerRegistryReplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryReplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryReplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryReplicationReplicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryReplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryReplicationResource.ResourceType, out string containerRegistryReplicationReplicationsApiVersion);
            _containerRegistryReplicationReplicationsRestClient = new ReplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryReplicationReplicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a replication for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications/{replicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="data"> The parameters for creating a replication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryReplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string replicationName, ContainerRegistryReplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationName, nameof(replicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryReplicationReplicationsClientDiagnostics.CreateScope("ContainerRegistryReplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryReplicationReplicationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryReplicationResource>(new ContainerRegistryReplicationOperationSource(Client), _containerRegistryReplicationReplicationsClientDiagnostics, Pipeline, _containerRegistryReplicationReplicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a replication for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications/{replicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="data"> The parameters for creating a replication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryReplicationResource> CreateOrUpdate(WaitUntil waitUntil, string replicationName, ContainerRegistryReplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationName, nameof(replicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryReplicationReplicationsClientDiagnostics.CreateScope("ContainerRegistryReplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryReplicationReplicationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryReplicationResource>(new ContainerRegistryReplicationOperationSource(Client), _containerRegistryReplicationReplicationsClientDiagnostics, Pipeline, _containerRegistryReplicationReplicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the properties of the specified replication.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications/{replicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryReplicationResource>> GetAsync(string replicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationName, nameof(replicationName));

            using var scope = _containerRegistryReplicationReplicationsClientDiagnostics.CreateScope("ContainerRegistryReplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryReplicationReplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryReplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified replication.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications/{replicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationName"/> is null. </exception>
        public virtual Response<ContainerRegistryReplicationResource> Get(string replicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationName, nameof(replicationName));

            using var scope = _containerRegistryReplicationReplicationsClientDiagnostics.CreateScope("ContainerRegistryReplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryReplicationReplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryReplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the replications for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryReplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryReplicationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryReplicationReplicationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryReplicationReplicationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryReplicationResource(Client, ContainerRegistryReplicationData.DeserializeContainerRegistryReplicationData(e)), _containerRegistryReplicationReplicationsClientDiagnostics, Pipeline, "ContainerRegistryReplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the replications for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryReplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryReplicationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryReplicationReplicationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryReplicationReplicationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryReplicationResource(Client, ContainerRegistryReplicationData.DeserializeContainerRegistryReplicationData(e)), _containerRegistryReplicationReplicationsClientDiagnostics, Pipeline, "ContainerRegistryReplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications/{replicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string replicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationName, nameof(replicationName));

            using var scope = _containerRegistryReplicationReplicationsClientDiagnostics.CreateScope("ContainerRegistryReplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryReplicationReplicationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/replications/{replicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string replicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicationName, nameof(replicationName));

            using var scope = _containerRegistryReplicationReplicationsClientDiagnostics.CreateScope("ContainerRegistryReplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryReplicationReplicationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryReplicationResource> IEnumerable<ContainerRegistryReplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryReplicationResource> IAsyncEnumerable<ContainerRegistryReplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
