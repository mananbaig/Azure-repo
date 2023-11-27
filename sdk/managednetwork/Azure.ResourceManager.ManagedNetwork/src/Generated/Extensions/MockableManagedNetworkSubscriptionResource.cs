// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagedNetwork;

namespace Azure.ResourceManager.ManagedNetwork.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableManagedNetworkSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _managedNetworkClientDiagnostics;
        private ManagedNetworksRestOperations _managedNetworkRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableManagedNetworkSubscriptionResource"/> class for mocking. </summary>
        protected MockableManagedNetworkSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableManagedNetworkSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableManagedNetworkSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ManagedNetworkClientDiagnostics => _managedNetworkClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ManagedNetwork", ManagedNetworkResource.ResourceType.Namespace, Diagnostics);
        private ManagedNetworksRestOperations ManagedNetworkRestClient => _managedNetworkRestClient ??= new ManagedNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedNetworkResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// The ListBySubscription  ManagedNetwork operation retrieves all the Managed Network Resources in the current subscription in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetwork/managedNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedNetworkResource> GetManagedNetworksAsync(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedNetworkRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedNetworkRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedNetworkResource(Client, ManagedNetworkData.DeserializeManagedNetworkData(e)), ManagedNetworkClientDiagnostics, Pipeline, "MockableManagedNetworkSubscriptionResource.GetManagedNetworks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The ListBySubscription  ManagedNetwork operation retrieves all the Managed Network Resources in the current subscription in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetwork/managedNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedNetworks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> May be used to limit the number of results in a page for list queries. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedNetworkResource> GetManagedNetworks(int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedNetworkRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedNetworkRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedNetworkResource(Client, ManagedNetworkData.DeserializeManagedNetworkData(e)), ManagedNetworkClientDiagnostics, Pipeline, "MockableManagedNetworkSubscriptionResource.GetManagedNetworks", "value", "nextLink", cancellationToken);
        }
    }
}
