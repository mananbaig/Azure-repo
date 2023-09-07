// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthcareApis.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _healthcareApisServiceServicesClientDiagnostics;
        private ServicesRestOperations _healthcareApisServiceServicesRestClient;
        private ClientDiagnostics _healthcareApisWorkspaceWorkspacesClientDiagnostics;
        private WorkspacesRestOperations _healthcareApisWorkspaceWorkspacesRestClient;

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

        private ClientDiagnostics HealthcareApisServiceServicesClientDiagnostics => _healthcareApisServiceServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", HealthcareApisServiceResource.ResourceType.Namespace, Diagnostics);
        private ServicesRestOperations HealthcareApisServiceServicesRestClient => _healthcareApisServiceServicesRestClient ??= new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HealthcareApisServiceResource.ResourceType));
        private ClientDiagnostics HealthcareApisWorkspaceWorkspacesClientDiagnostics => _healthcareApisWorkspaceWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", HealthcareApisWorkspaceResource.ResourceType.Namespace, Diagnostics);
        private WorkspacesRestOperations HealthcareApisWorkspaceWorkspacesRestClient => _healthcareApisWorkspaceWorkspacesRestClient ??= new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HealthcareApisWorkspaceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Get all the service instances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthcareApisServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthcareApisServiceResource> GetHealthcareApisServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HealthcareApisServiceServicesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HealthcareApisServiceServicesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HealthcareApisServiceResource(Client, HealthcareApisServiceData.DeserializeHealthcareApisServiceData(e)), HealthcareApisServiceServicesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHealthcareApisServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the service instances in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/services</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthcareApisServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthcareApisServiceResource> GetHealthcareApisServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HealthcareApisServiceServicesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HealthcareApisServiceServicesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HealthcareApisServiceResource(Client, HealthcareApisServiceData.DeserializeHealthcareApisServiceData(e)), HealthcareApisServiceServicesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHealthcareApisServices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check if a service instance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Set the name parameter in the CheckNameAvailabilityParameters structure to the name of the service instance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HealthcareApisNameAvailabilityResult>> CheckHealthcareApisNameAvailabilityAsync(HealthcareApisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = HealthcareApisServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckHealthcareApisNameAvailability");
            scope.Start();
            try
            {
                var response = await HealthcareApisServiceServicesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check if a service instance name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Set the name parameter in the CheckNameAvailabilityParameters structure to the name of the service instance to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HealthcareApisNameAvailabilityResult> CheckHealthcareApisNameAvailability(HealthcareApisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = HealthcareApisServiceServicesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckHealthcareApisNameAvailability");
            scope.Start();
            try
            {
                var response = HealthcareApisServiceServicesRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the available workspaces under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthcareApisWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthcareApisWorkspaceResource> GetHealthcareApisWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HealthcareApisWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HealthcareApisWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HealthcareApisWorkspaceResource(Client, HealthcareApisWorkspaceData.DeserializeHealthcareApisWorkspaceData(e)), HealthcareApisWorkspaceWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHealthcareApisWorkspaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available workspaces under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthcareApis/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthcareApisWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthcareApisWorkspaceResource> GetHealthcareApisWorkspaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HealthcareApisWorkspaceWorkspacesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HealthcareApisWorkspaceWorkspacesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HealthcareApisWorkspaceResource(Client, HealthcareApisWorkspaceData.DeserializeHealthcareApisWorkspaceData(e)), HealthcareApisWorkspaceWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHealthcareApisWorkspaces", "value", "nextLink", cancellationToken);
        }
    }
}
