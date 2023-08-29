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

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing a collection of <see cref="AppPlatformSupportedBuildpackResource" /> and their operations.
    /// Each <see cref="AppPlatformSupportedBuildpackResource" /> in the collection will belong to the same instance of <see cref="AppPlatformBuildServiceResource" />.
    /// To get an <see cref="AppPlatformSupportedBuildpackCollection" /> instance call the GetAppPlatformSupportedBuildpacks method from an instance of <see cref="AppPlatformBuildServiceResource" />.
    /// </summary>
    public partial class AppPlatformSupportedBuildpackCollection : ArmCollection, IEnumerable<AppPlatformSupportedBuildpackResource>, IAsyncEnumerable<AppPlatformSupportedBuildpackResource>
    {
        private readonly ClientDiagnostics _appPlatformSupportedBuildpackBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _appPlatformSupportedBuildpackBuildServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppPlatformSupportedBuildpackCollection"/> class for mocking. </summary>
        protected AppPlatformSupportedBuildpackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformSupportedBuildpackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppPlatformSupportedBuildpackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformSupportedBuildpackBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", AppPlatformSupportedBuildpackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppPlatformSupportedBuildpackResource.ResourceType, out string appPlatformSupportedBuildpackBuildServiceApiVersion);
            _appPlatformSupportedBuildpackBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformSupportedBuildpackBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppPlatformBuildServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppPlatformBuildServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the supported buildpack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks/{buildpackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedBuildpack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackName"> The name of the buildpack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackName"/> is null. </exception>
        public virtual async Task<Response<AppPlatformSupportedBuildpackResource>> GetAsync(string buildpackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackName, nameof(buildpackName));

            using var scope = _appPlatformSupportedBuildpackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedBuildpackCollection.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformSupportedBuildpackBuildServiceRestClient.GetSupportedBuildpackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, buildpackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformSupportedBuildpackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the supported buildpack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks/{buildpackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedBuildpack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackName"> The name of the buildpack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackName"/> is null. </exception>
        public virtual Response<AppPlatformSupportedBuildpackResource> Get(string buildpackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackName, nameof(buildpackName));

            using var scope = _appPlatformSupportedBuildpackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedBuildpackCollection.Get");
            scope.Start();
            try
            {
                var response = _appPlatformSupportedBuildpackBuildServiceRestClient.GetSupportedBuildpack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, buildpackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformSupportedBuildpackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all supported buildpacks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_ListSupportedBuildpacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppPlatformSupportedBuildpackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppPlatformSupportedBuildpackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformSupportedBuildpackBuildServiceRestClient.CreateListSupportedBuildpacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new AppPlatformSupportedBuildpackResource(Client, AppPlatformSupportedBuildpackData.DeserializeAppPlatformSupportedBuildpackData(e)), _appPlatformSupportedBuildpackBuildServiceClientDiagnostics, Pipeline, "AppPlatformSupportedBuildpackCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get all supported buildpacks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_ListSupportedBuildpacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppPlatformSupportedBuildpackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppPlatformSupportedBuildpackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appPlatformSupportedBuildpackBuildServiceRestClient.CreateListSupportedBuildpacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new AppPlatformSupportedBuildpackResource(Client, AppPlatformSupportedBuildpackData.DeserializeAppPlatformSupportedBuildpackData(e)), _appPlatformSupportedBuildpackBuildServiceClientDiagnostics, Pipeline, "AppPlatformSupportedBuildpackCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks/{buildpackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedBuildpack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackName"> The name of the buildpack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string buildpackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackName, nameof(buildpackName));

            using var scope = _appPlatformSupportedBuildpackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedBuildpackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appPlatformSupportedBuildpackBuildServiceRestClient.GetSupportedBuildpackAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, buildpackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks/{buildpackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedBuildpack</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackName"> The name of the buildpack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="buildpackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackName"/> is null. </exception>
        public virtual Response<bool> Exists(string buildpackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(buildpackName, nameof(buildpackName));

            using var scope = _appPlatformSupportedBuildpackBuildServiceClientDiagnostics.CreateScope("AppPlatformSupportedBuildpackCollection.Exists");
            scope.Start();
            try
            {
                var response = _appPlatformSupportedBuildpackBuildServiceRestClient.GetSupportedBuildpack(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, buildpackName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppPlatformSupportedBuildpackResource> IEnumerable<AppPlatformSupportedBuildpackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppPlatformSupportedBuildpackResource> IAsyncEnumerable<AppPlatformSupportedBuildpackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
