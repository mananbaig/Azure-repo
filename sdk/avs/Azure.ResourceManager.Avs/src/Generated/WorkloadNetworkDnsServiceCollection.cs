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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadNetworkDnsServiceResource" /> and their operations.
    /// Each <see cref="WorkloadNetworkDnsServiceResource" /> in the collection will belong to the same instance of <see cref="AvsPrivateCloudResource" />.
    /// To get a <see cref="WorkloadNetworkDnsServiceCollection" /> instance call the GetWorkloadNetworkDnsServices method from an instance of <see cref="AvsPrivateCloudResource" />.
    /// </summary>
    public partial class WorkloadNetworkDnsServiceCollection : ArmCollection, IEnumerable<WorkloadNetworkDnsServiceResource>, IAsyncEnumerable<WorkloadNetworkDnsServiceResource>
    {
        private readonly ClientDiagnostics _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkDnsServiceWorkloadNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkDnsServiceCollection"/> class for mocking. </summary>
        protected WorkloadNetworkDnsServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkDnsServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadNetworkDnsServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", WorkloadNetworkDnsServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadNetworkDnsServiceResource.ResourceType, out string workloadNetworkDnsServiceWorkloadNetworksApiVersion);
            _workloadNetworkDnsServiceWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkDnsServiceWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvsPrivateCloudResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvsPrivateCloudResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DNS service by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices/{dnsServiceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateDnsService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsServiceId"> NSX DNS Service identifier. Generally the same as the DNS Service's display name. </param>
        /// <param name="data"> NSX DNS Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsServiceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsServiceId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadNetworkDnsServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dnsServiceId, WorkloadNetworkDnsServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsServiceId, nameof(dnsServiceId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateDnsServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<WorkloadNetworkDnsServiceResource>(new WorkloadNetworkDnsServiceOperationSource(Client), _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateCreateDnsServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a DNS service by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices/{dnsServiceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_CreateDnsService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dnsServiceId"> NSX DNS Service identifier. Generally the same as the DNS Service's display name. </param>
        /// <param name="data"> NSX DNS Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsServiceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsServiceId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadNetworkDnsServiceResource> CreateOrUpdate(WaitUntil waitUntil, string dnsServiceId, WorkloadNetworkDnsServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsServiceId, nameof(dnsServiceId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateDnsService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, data, cancellationToken);
                var operation = new AvsArmOperation<WorkloadNetworkDnsServiceResource>(new WorkloadNetworkDnsServiceOperationSource(Client), _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics, Pipeline, _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateCreateDnsServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a DNS service by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices/{dnsServiceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsServiceId"> NSX DNS Service identifier. Generally the same as the DNS Service's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsServiceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsServiceId"/> is null. </exception>
        public virtual async Task<Response<WorkloadNetworkDnsServiceResource>> GetAsync(string dnsServiceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsServiceId, nameof(dnsServiceId));

            using var scope = _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsServiceWorkloadNetworksRestClient.GetDnsServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDnsServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DNS service by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices/{dnsServiceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsServiceId"> NSX DNS Service identifier. Generally the same as the DNS Service's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsServiceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsServiceId"/> is null. </exception>
        public virtual Response<WorkloadNetworkDnsServiceResource> Get(string dnsServiceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsServiceId, nameof(dnsServiceId));

            using var scope = _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsServiceWorkloadNetworksRestClient.GetDnsService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkDnsServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of DNS services in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListDnsServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadNetworkDnsServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadNetworkDnsServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateListDnsServicesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateListDnsServicesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkDnsServiceResource(Client, WorkloadNetworkDnsServiceData.DeserializeWorkloadNetworkDnsServiceData(e)), _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkDnsServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of DNS services in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_ListDnsServices</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadNetworkDnsServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadNetworkDnsServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateListDnsServicesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadNetworkDnsServiceWorkloadNetworksRestClient.CreateListDnsServicesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WorkloadNetworkDnsServiceResource(Client, WorkloadNetworkDnsServiceData.DeserializeWorkloadNetworkDnsServiceData(e)), _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics, Pipeline, "WorkloadNetworkDnsServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices/{dnsServiceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsServiceId"> NSX DNS Service identifier. Generally the same as the DNS Service's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsServiceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsServiceId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dnsServiceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsServiceId, nameof(dnsServiceId));

            using var scope = _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadNetworkDnsServiceWorkloadNetworksRestClient.GetDnsServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/dnsServices/{dnsServiceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetDnsService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dnsServiceId"> NSX DNS Service identifier. Generally the same as the DNS Service's display name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dnsServiceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsServiceId"/> is null. </exception>
        public virtual Response<bool> Exists(string dnsServiceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dnsServiceId, nameof(dnsServiceId));

            using var scope = _workloadNetworkDnsServiceWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkDnsServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadNetworkDnsServiceWorkloadNetworksRestClient.GetDnsService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dnsServiceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadNetworkDnsServiceResource> IEnumerable<WorkloadNetworkDnsServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadNetworkDnsServiceResource> IAsyncEnumerable<WorkloadNetworkDnsServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
