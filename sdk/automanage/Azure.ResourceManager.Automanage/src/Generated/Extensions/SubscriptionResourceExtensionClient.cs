// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Automanage
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _configurationProfileClientDiagnostics;
        private ConfigurationProfilesRestOperations _configurationProfileRestClient;

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

        private ClientDiagnostics ConfigurationProfileClientDiagnostics => _configurationProfileClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automanage", ConfigurationProfileResource.ResourceType.Namespace, Diagnostics);
        private ConfigurationProfilesRestOperations ConfigurationProfileRestClient => _configurationProfileRestClient ??= new ConfigurationProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ConfigurationProfileResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets an object representing a ServicePrincipalResource along with the instance operations that can be performed on it in the SubscriptionResource. </summary>
        /// <returns> Returns a <see cref="ServicePrincipalResource" /> object. </returns>
        public virtual ServicePrincipalResource GetServicePrincipal()
        {
            return new ServicePrincipalResource(Client, new ResourceIdentifier(Id.ToString() + "/providers/Microsoft.Automanage/servicePrincipals/default"));
        }

        /// <summary>
        /// Retrieve a list of configuration profile within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automanage/configurationProfiles
        /// Operation Id: ConfigurationProfiles_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationProfileResource> GetConfigurationProfilesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationProfileResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ConfigurationProfileClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetConfigurationProfiles");
                scope.Start();
                try
                {
                    var response = await ConfigurationProfileRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Retrieve a list of configuration profile within a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automanage/configurationProfiles
        /// Operation Id: ConfigurationProfiles_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationProfileResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationProfileResource> GetConfigurationProfiles(CancellationToken cancellationToken = default)
        {
            Page<ConfigurationProfileResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ConfigurationProfileClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetConfigurationProfiles");
                scope.Start();
                try
                {
                    var response = ConfigurationProfileRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationProfileResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
