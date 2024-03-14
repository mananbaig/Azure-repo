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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudServiceOSVersionResource"/> and their operations.
    /// Each <see cref="CloudServiceOSVersionResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="CloudServiceOSVersionCollection"/> instance call the GetCloudServiceOSVersions method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class CloudServiceOSVersionCollection : ArmCollection, IEnumerable<CloudServiceOSVersionResource>, IAsyncEnumerable<CloudServiceOSVersionResource>
    {
        private readonly ClientDiagnostics _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceOSVersionCollection"/> class for mocking. </summary>
        protected CloudServiceOSVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceOSVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> Name of the location that the OS versions pertain to. </param>
        internal CloudServiceOSVersionCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", CloudServiceOSVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudServiceOSVersionResource.ResourceType, out string cloudServiceOSVersionCloudServiceOperatingSystemsApiVersion);
            _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudServiceOSVersionCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSVersion</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual async Task<Response<CloudServiceOSVersionResource>> GetAsync(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, new AzureLocation(_location), osVersionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSVersion</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<CloudServiceOSVersionResource> Get(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, new AzureLocation(_location), osVersionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all guest operating system versions available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS versions. Do this till nextLink is null to fetch all the OS versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_ListOSVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudServiceOSVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudServiceOSVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.CreateListOSVersionsRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.CreateListOSVersionsNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudServiceOSVersionResource(Client, CloudServiceOSVersionData.DeserializeCloudServiceOSVersionData(e)), _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics, Pipeline, "CloudServiceOSVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all guest operating system versions available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS versions. Do this till nextLink is null to fetch all the OS versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_ListOSVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudServiceOSVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudServiceOSVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.CreateListOSVersionsRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.CreateListOSVersionsNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudServiceOSVersionResource(Client, CloudServiceOSVersionData.DeserializeCloudServiceOSVersionData(e)), _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics, Pipeline, "CloudServiceOSVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSVersion</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, new AzureLocation(_location), osVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSVersion</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, new AzureLocation(_location), osVersionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSVersion</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudServiceOSVersionResource>> GetIfExistsAsync(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, new AzureLocation(_location), osVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceOSVersionResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceOperatingSystems_GetOSVersion</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-04</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudServiceOSVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual NullableResponse<CloudServiceOSVersionResource> GetIfExists(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _cloudServiceOSVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("CloudServiceOSVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceOSVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, new AzureLocation(_location), osVersionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudServiceOSVersionResource>(response.GetRawResponse());
                return Response.FromValue(new CloudServiceOSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudServiceOSVersionResource> IEnumerable<CloudServiceOSVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudServiceOSVersionResource> IAsyncEnumerable<CloudServiceOSVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
