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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ProbeResource" /> and their operations.
    /// Each <see cref="ProbeResource" /> in the collection will belong to the same instance of <see cref="LoadBalancerResource" />.
    /// To get a <see cref="ProbeCollection" /> instance call the GetProbes method from an instance of <see cref="LoadBalancerResource" />.
    /// </summary>
    public partial class ProbeCollection : ArmCollection, IEnumerable<ProbeResource>, IAsyncEnumerable<ProbeResource>
    {
        private readonly ClientDiagnostics _probeLoadBalancerProbesClientDiagnostics;
        private readonly LoadBalancerProbesRestOperations _probeLoadBalancerProbesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProbeCollection"/> class for mocking. </summary>
        protected ProbeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProbeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProbeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _probeLoadBalancerProbesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ProbeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProbeResource.ResourceType, out string probeLoadBalancerProbesApiVersion);
            _probeLoadBalancerProbesRestClient = new LoadBalancerProbesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, probeLoadBalancerProbesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets load balancer probe.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual async Task<Response<ProbeResource>> GetAsync(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Get");
            scope.Start();
            try
            {
                var response = await _probeLoadBalancerProbesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProbeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer probe.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual Response<ProbeResource> Get(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Get");
            scope.Start();
            try
            {
                var response = _probeLoadBalancerProbesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProbeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancer probes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProbeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProbeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _probeLoadBalancerProbesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _probeLoadBalancerProbesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ProbeResource(Client, ProbeData.DeserializeProbeData(e)), _probeLoadBalancerProbesClientDiagnostics, Pipeline, "ProbeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the load balancer probes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProbeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProbeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _probeLoadBalancerProbesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _probeLoadBalancerProbesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ProbeResource(Client, ProbeData.DeserializeProbeData(e)), _probeLoadBalancerProbesClientDiagnostics, Pipeline, "ProbeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _probeLoadBalancerProbesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual Response<bool> Exists(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.Exists");
            scope.Start();
            try
            {
                var response = _probeLoadBalancerProbesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual async Task<NullableResponse<ProbeResource>> GetIfExistsAsync(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _probeLoadBalancerProbesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ProbeResource>(response.GetRawResponse());
                return Response.FromValue(new ProbeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerProbes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="probeName"> The name of the probe. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="probeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="probeName"/> is null. </exception>
        public virtual NullableResponse<ProbeResource> GetIfExists(string probeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(probeName, nameof(probeName));

            using var scope = _probeLoadBalancerProbesClientDiagnostics.CreateScope("ProbeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _probeLoadBalancerProbesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, probeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ProbeResource>(response.GetRawResponse());
                return Response.FromValue(new ProbeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ProbeResource> IEnumerable<ProbeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ProbeResource> IAsyncEnumerable<ProbeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
