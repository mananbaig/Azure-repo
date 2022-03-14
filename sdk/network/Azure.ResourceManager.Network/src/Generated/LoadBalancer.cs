// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
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

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a LoadBalancer along with the instance operations that can be performed on it. </summary>
    public partial class LoadBalancer : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LoadBalancer"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string loadBalancerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _loadBalancerClientDiagnostics;
        private readonly LoadBalancersRestOperations _loadBalancerRestClient;
        private readonly ClientDiagnostics _loadBalancerNetworkInterfacesClientDiagnostics;
        private readonly LoadBalancerNetworkInterfacesRestOperations _loadBalancerNetworkInterfacesRestClient;
        private readonly LoadBalancerData _data;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancer"/> class for mocking. </summary>
        protected LoadBalancer()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LoadBalancer"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LoadBalancer(ArmClient client, LoadBalancerData data) : this(client, new ResourceIdentifier(data.Id))
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancer"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadBalancer(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadBalancerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string loadBalancerApiVersion);
            _loadBalancerRestClient = new LoadBalancersRestOperations(_loadBalancerClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, loadBalancerApiVersion);
            _loadBalancerNetworkInterfacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _loadBalancerNetworkInterfacesRestClient = new LoadBalancerNetworkInterfacesRestOperations(_loadBalancerNetworkInterfacesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/loadBalancers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LoadBalancerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of BackendAddressPools in the BackendAddressPool. </summary>
        /// <returns> An object representing collection of BackendAddressPools and their operations over a BackendAddressPool. </returns>
        public virtual BackendAddressPoolCollection GetBackendAddressPools()
        {
            return new BackendAddressPoolCollection(Client, Id);
        }

        /// <summary> Gets a collection of FrontendIPConfigurations in the FrontendIPConfiguration. </summary>
        /// <returns> An object representing collection of FrontendIPConfigurations and their operations over a FrontendIPConfiguration. </returns>
        public virtual FrontendIPConfigurationCollection GetFrontendIPConfigurations()
        {
            return new FrontendIPConfigurationCollection(Client, Id);
        }

        /// <summary> Gets a collection of InboundNatRules in the InboundNatRule. </summary>
        /// <returns> An object representing collection of InboundNatRules and their operations over a InboundNatRule. </returns>
        public virtual InboundNatRuleCollection GetInboundNatRules()
        {
            return new InboundNatRuleCollection(Client, Id);
        }

        /// <summary> Gets a collection of LoadBalancingRules in the LoadBalancingRule. </summary>
        /// <returns> An object representing collection of LoadBalancingRules and their operations over a LoadBalancingRule. </returns>
        public virtual LoadBalancingRuleCollection GetLoadBalancingRules()
        {
            return new LoadBalancingRuleCollection(Client, Id);
        }

        /// <summary> Gets a collection of OutboundRules in the OutboundRule. </summary>
        /// <returns> An object representing collection of OutboundRules and their operations over a OutboundRule. </returns>
        public virtual OutboundRuleCollection GetOutboundRules()
        {
            return new OutboundRuleCollection(Client, Id);
        }

        /// <summary> Gets a collection of Probes in the Probe. </summary>
        /// <returns> An object representing collection of Probes and their operations over a Probe. </returns>
        public virtual ProbeCollection GetProbes()
        {
            return new ProbeCollection(Client, Id);
        }

        /// <summary>
        /// Gets the specified load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LoadBalancer>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _loadBalancerClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LoadBalancer> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _loadBalancerClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.Delete");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation(_loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified load balancer.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.Delete");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkArmOperation(_loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets associated load balancer network interfaces.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/networkInterfaces
        /// Operation Id: LoadBalancerNetworkInterfaces_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterface" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterface> GetLoadBalancerNetworkInterfacesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterface>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadBalancerNetworkInterfacesClientDiagnostics.CreateScope("LoadBalancer.GetLoadBalancerNetworkInterfaces");
                scope.Start();
                try
                {
                    var response = await _loadBalancerNetworkInterfacesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterface>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadBalancerNetworkInterfacesClientDiagnostics.CreateScope("LoadBalancer.GetLoadBalancerNetworkInterfaces");
                scope.Start();
                try
                {
                    var response = await _loadBalancerNetworkInterfacesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets associated load balancer network interfaces.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/networkInterfaces
        /// Operation Id: LoadBalancerNetworkInterfaces_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterface" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterface> GetLoadBalancerNetworkInterfaces(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterface> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadBalancerNetworkInterfacesClientDiagnostics.CreateScope("LoadBalancer.GetLoadBalancerNetworkInterfaces");
                scope.Start();
                try
                {
                    var response = _loadBalancerNetworkInterfacesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterface> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadBalancerNetworkInterfacesClientDiagnostics.CreateScope("LoadBalancer.GetLoadBalancerNetworkInterfaces");
                scope.Start();
                try
                {
                    var response = _loadBalancerNetworkInterfacesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterface(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _loadBalancerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<LoadBalancer> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _loadBalancerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new LoadBalancer(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _loadBalancerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<LoadBalancer> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _loadBalancerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new LoadBalancer(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<LoadBalancer>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _loadBalancerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LoadBalancer(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
        /// Operation Id: LoadBalancers_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<LoadBalancer> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancer.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _loadBalancerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new LoadBalancer(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
