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

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceFabricManagedNodeTypeResource"/> and their operations.
    /// Each <see cref="ServiceFabricManagedNodeTypeResource"/> in the collection will belong to the same instance of <see cref="ServiceFabricManagedClusterResource"/>.
    /// To get a <see cref="ServiceFabricManagedNodeTypeCollection"/> instance call the GetServiceFabricManagedNodeTypes method from an instance of <see cref="ServiceFabricManagedClusterResource"/>.
    /// </summary>
    public partial class ServiceFabricManagedNodeTypeCollection : ArmCollection, IEnumerable<ServiceFabricManagedNodeTypeResource>, IAsyncEnumerable<ServiceFabricManagedNodeTypeResource>
    {
        private readonly ClientDiagnostics _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics;
        private readonly NodeTypesRestOperations _serviceFabricManagedNodeTypeNodeTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricManagedNodeTypeCollection"/> class for mocking. </summary>
        protected ServiceFabricManagedNodeTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceFabricManagedNodeTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceFabricManagedNodeTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceFabricManagedClusters", ServiceFabricManagedNodeTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceFabricManagedNodeTypeResource.ResourceType, out string serviceFabricManagedNodeTypeNodeTypesApiVersion);
            _serviceFabricManagedNodeTypeNodeTypesRestClient = new NodeTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceFabricManagedNodeTypeNodeTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceFabricManagedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceFabricManagedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Service Fabric node type of a given managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="data"> The node type resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceFabricManagedNodeTypeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string nodeTypeName, ServiceFabricManagedNodeTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceFabricManagedClustersArmOperation<ServiceFabricManagedNodeTypeResource>(new ServiceFabricManagedNodeTypeOperationSource(Client), _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics, Pipeline, _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a Service Fabric node type of a given managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="data"> The node type resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceFabricManagedNodeTypeResource> CreateOrUpdate(WaitUntil waitUntil, string nodeTypeName, ServiceFabricManagedNodeTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, data, cancellationToken);
                var operation = new ServiceFabricManagedClustersArmOperation<ServiceFabricManagedNodeTypeResource>(new ServiceFabricManagedNodeTypeOperationSource(Client), _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics, Pipeline, _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Service Fabric node type of a given managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> is null. </exception>
        public virtual async Task<Response<ServiceFabricManagedNodeTypeResource>> GetAsync(string nodeTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedNodeTypeNodeTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedNodeTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Service Fabric node type of a given managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> is null. </exception>
        public virtual Response<ServiceFabricManagedNodeTypeResource> Get(string nodeTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedNodeTypeNodeTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedNodeTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Node types of the specified managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_ListByManagedClusters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricManagedNodeTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricManagedNodeTypeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateListByManagedClustersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateListByManagedClustersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceFabricManagedNodeTypeResource(Client, ServiceFabricManagedNodeTypeData.DeserializeServiceFabricManagedNodeTypeData(e)), _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics, Pipeline, "ServiceFabricManagedNodeTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all Node types of the specified managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_ListByManagedClusters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricManagedNodeTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricManagedNodeTypeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateListByManagedClustersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceFabricManagedNodeTypeNodeTypesRestClient.CreateListByManagedClustersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceFabricManagedNodeTypeResource(Client, ServiceFabricManagedNodeTypeData.DeserializeServiceFabricManagedNodeTypeData(e)), _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics, Pipeline, "ServiceFabricManagedNodeTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string nodeTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedNodeTypeNodeTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string nodeTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedNodeTypeNodeTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceFabricManagedNodeTypeResource>> GetIfExistsAsync(string nodeTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceFabricManagedNodeTypeNodeTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceFabricManagedNodeTypeResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedNodeTypeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}/nodeTypes/{nodeTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NodeTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedNodeTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeTypeName"> The name of the node type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeTypeName"/> is null. </exception>
        public virtual NullableResponse<ServiceFabricManagedNodeTypeResource> GetIfExists(string nodeTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeTypeName, nameof(nodeTypeName));

            using var scope = _serviceFabricManagedNodeTypeNodeTypesClientDiagnostics.CreateScope("ServiceFabricManagedNodeTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceFabricManagedNodeTypeNodeTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceFabricManagedNodeTypeResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceFabricManagedNodeTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceFabricManagedNodeTypeResource> IEnumerable<ServiceFabricManagedNodeTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceFabricManagedNodeTypeResource> IAsyncEnumerable<ServiceFabricManagedNodeTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
