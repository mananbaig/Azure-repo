// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.BotService.Models;

namespace Azure.ResourceManager.BotService
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _botClientDiagnostics;
        private BotsRestOperations _botRestClient;
        private ClientDiagnostics _botConnectionSettingBotConnectionClientDiagnostics;
        private BotConnectionRestOperations _botConnectionSettingBotConnectionRestClient;
        private ClientDiagnostics _qnAMakerEndpointKeysClientDiagnostics;
        private QnAMakerEndpointKeysRestOperations _qnAMakerEndpointKeysRestClient;
        private ClientDiagnostics _hostSettingsClientDiagnostics;
        private HostSettingsRestOperations _hostSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics BotClientDiagnostics => _botClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BotService", BotResource.ResourceType.Namespace, Diagnostics);
        private BotsRestOperations BotRestClient => _botRestClient ??= new BotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(BotResource.ResourceType));
        private ClientDiagnostics BotConnectionSettingBotConnectionClientDiagnostics => _botConnectionSettingBotConnectionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BotService", BotConnectionSettingResource.ResourceType.Namespace, Diagnostics);
        private BotConnectionRestOperations BotConnectionSettingBotConnectionRestClient => _botConnectionSettingBotConnectionRestClient ??= new BotConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(BotConnectionSettingResource.ResourceType));
        private ClientDiagnostics QnAMakerEndpointKeysClientDiagnostics => _qnAMakerEndpointKeysClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BotService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private QnAMakerEndpointKeysRestOperations QnAMakerEndpointKeysRestClient => _qnAMakerEndpointKeysRestClient ??= new QnAMakerEndpointKeysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics HostSettingsClientDiagnostics => _hostSettingsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.BotService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private HostSettingsRestOperations HostSettingsRestClient => _hostSettingsRestClient ??= new HostSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/botServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BotResource> GetBotsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BotRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BotRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new BotResource(Client, BotData.DeserializeBotData(e)), BotClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetBots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/botServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BotResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BotResource> GetBots(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BotRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => BotRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new BotResource(Client, BotData.DeserializeBotData(e)), BotClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetBots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the available Service Providers for creating Connection Settings
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listAuthServiceProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_ListServiceProviders</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BotServiceProvider" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BotServiceProvider> GetBotConnectionServiceProvidersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BotConnectionSettingBotConnectionRestClient.CreateListServiceProvidersRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, BotServiceProvider.DeserializeBotServiceProvider, BotConnectionSettingBotConnectionClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetBotConnectionServiceProviders", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the available Service Providers for creating Connection Settings
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listAuthServiceProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_ListServiceProviders</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BotServiceProvider" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BotServiceProvider> GetBotConnectionServiceProviders(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => BotConnectionSettingBotConnectionRestClient.CreateListServiceProvidersRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, BotServiceProvider.DeserializeBotServiceProvider, BotConnectionSettingBotConnectionClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetBotConnectionServiceProviders", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the QnA Maker endpoint keys
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listQnAMakerEndpointKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QnAMakerEndpointKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GetBotServiceQnAMakerEndpointKeyResult>> GetBotServiceQnAMakerEndpointKeyAsync(GetBotServiceQnAMakerEndpointKeyContent content, CancellationToken cancellationToken = default)
        {
            using var scope = QnAMakerEndpointKeysClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetBotServiceQnAMakerEndpointKey");
            scope.Start();
            try
            {
                var response = await QnAMakerEndpointKeysRestClient.GetAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the QnA Maker endpoint keys
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listQnAMakerEndpointKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QnAMakerEndpointKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GetBotServiceQnAMakerEndpointKeyResult> GetBotServiceQnAMakerEndpointKey(GetBotServiceQnAMakerEndpointKeyContent content, CancellationToken cancellationToken = default)
        {
            using var scope = QnAMakerEndpointKeysClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetBotServiceQnAMakerEndpointKey");
            scope.Start();
            try
            {
                var response = QnAMakerEndpointKeysRestClient.Get(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get per subscription settings needed to host bot in compute resource such as Azure App Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/hostSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BotServiceHostSettingsResult>> GetBotServiceHostSettingsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = HostSettingsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetBotServiceHostSettings");
            scope.Start();
            try
            {
                var response = await HostSettingsRestClient.GetAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get per subscription settings needed to host bot in compute resource such as Azure App Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/hostSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BotServiceHostSettingsResult> GetBotServiceHostSettings(CancellationToken cancellationToken = default)
        {
            using var scope = HostSettingsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetBotServiceHostSettings");
            scope.Start();
            try
            {
                var response = HostSettingsRestClient.Get(Id.SubscriptionId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
