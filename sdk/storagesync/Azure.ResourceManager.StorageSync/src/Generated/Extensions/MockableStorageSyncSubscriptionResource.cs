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
using Azure.ResourceManager.StorageSync;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableStorageSyncSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _storageSyncServiceClientDiagnostics;
        private StorageSyncServicesRestOperations _storageSyncServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableStorageSyncSubscriptionResource"/> class for mocking. </summary>
        protected MockableStorageSyncSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStorageSyncSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStorageSyncSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics StorageSyncServiceClientDiagnostics => _storageSyncServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageSync", StorageSyncServiceResource.ResourceType.Namespace, Diagnostics);
        private StorageSyncServicesRestOperations StorageSyncServiceRestClient => _storageSyncServiceRestClient ??= new StorageSyncServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageSyncServiceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<StorageSyncNameAvailabilityResult>> CheckStorageSyncNameAvailabilityAsync(string locationName, StorageSyncNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = StorageSyncServiceClientDiagnostics.CreateScope("MockableStorageSyncSubscriptionResource.CheckStorageSyncNameAvailability");
            scope.Start();
            try
            {
                var response = await StorageSyncServiceRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, locationName, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The desired region for the name check. </param>
        /// <param name="content"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="content"/> is null. </exception>
        public virtual Response<StorageSyncNameAvailabilityResult> CheckStorageSyncNameAvailability(string locationName, StorageSyncNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = StorageSyncServiceClientDiagnostics.CreateScope("MockableStorageSyncSubscriptionResource.CheckStorageSyncNameAvailability");
            scope.Start();
            try
            {
                var response = StorageSyncServiceRestClient.CheckNameAvailability(Id.SubscriptionId, locationName, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/storageSyncServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSyncServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSyncServiceResource> GetStorageSyncServicesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageSyncServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new StorageSyncServiceResource(Client, StorageSyncServiceData.DeserializeStorageSyncServiceData(e)), StorageSyncServiceClientDiagnostics, Pipeline, "MockableStorageSyncSubscriptionResource.GetStorageSyncServices", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageSync/storageSyncServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSyncServiceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSyncServiceResource> GetStorageSyncServices(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageSyncServiceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new StorageSyncServiceResource(Client, StorageSyncServiceData.DeserializeStorageSyncServiceData(e)), StorageSyncServiceClientDiagnostics, Pipeline, "MockableStorageSyncSubscriptionResource.GetStorageSyncServices", "value", null, cancellationToken);
        }
    }
}
