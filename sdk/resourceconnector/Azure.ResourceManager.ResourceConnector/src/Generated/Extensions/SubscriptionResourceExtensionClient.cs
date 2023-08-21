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
using Azure.ResourceManager.ResourceConnector.Models;

namespace Azure.ResourceManager.ResourceConnector
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _applianceClientDiagnostics;
        private AppliancesRestOperations _applianceRestClient;

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

        private ClientDiagnostics ApplianceClientDiagnostics => _applianceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ResourceConnector", ApplianceResource.ResourceType.Namespace, Diagnostics);
        private AppliancesRestOperations ApplianceRestClient => _applianceRestClient ??= new AppliancesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ApplianceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of Appliances in the specified subscription. The operation returns properties of each Appliance
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/appliances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplianceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplianceResource> GetAppliancesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApplianceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApplianceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApplianceResource(Client, ApplianceData.DeserializeApplianceData(e)), ApplianceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAppliances", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Appliances in the specified subscription. The operation returns properties of each Appliance
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/appliances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplianceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplianceResource> GetAppliances(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ApplianceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ApplianceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApplianceResource(Client, ApplianceData.DeserializeApplianceData(e)), ApplianceClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAppliances", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the telemetry config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/telemetryconfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_GetTelemetryConfig</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplianceGetTelemetryConfigResult>> GetTelemetryConfigApplianceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = ApplianceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetTelemetryConfigAppliance");
            scope.Start();
            try
            {
                var response = await ApplianceRestClient.GetTelemetryConfigAsync(Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the telemetry config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/telemetryconfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_GetTelemetryConfig</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplianceGetTelemetryConfigResult> GetTelemetryConfigAppliance(CancellationToken cancellationToken = default)
        {
            using var scope = ApplianceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetTelemetryConfigAppliance");
            scope.Start();
            try
            {
                var response = ApplianceRestClient.GetTelemetryConfig(Id.SubscriptionId, cancellationToken);
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
