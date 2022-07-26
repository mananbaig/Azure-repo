// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteBuildARMResource" /> and their operations.
    /// Each <see cref="StaticSiteBuildARMResource" /> in the collection will belong to the same instance of <see cref="StaticSiteARMResource" />.
    /// To get a <see cref="StaticSiteBuildARMCollection" /> instance call the GetStaticSiteBuildARMs method from an instance of <see cref="StaticSiteARMResource" />.
    /// </summary>
    public partial class StaticSiteBuildARMCollection : ArmCollection, IEnumerable<StaticSiteBuildARMResource>, IAsyncEnumerable<StaticSiteBuildARMResource>
    {
        private readonly ClientDiagnostics _staticSiteBuildARMStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildARMStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildARMCollection"/> class for mocking. </summary>
        protected StaticSiteBuildARMCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildARMCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteBuildARMCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildARMStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteBuildARMResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteBuildARMResource.ResourceType, out string staticSiteBuildARMStaticSitesApiVersion);
            _staticSiteBuildARMStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildARMStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteARMResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteARMResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_GetStaticSiteBuild
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildARMResource>> GetAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of a static site build.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_GetStaticSiteBuild
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<StaticSiteBuildARMResource> Get(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildARMResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all static site builds for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds
        /// Operation Id: StaticSites_GetStaticSiteBuilds
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildARMResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteBuildARMResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuildsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteBuildARMResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuildsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets all static site builds for a particular static site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds
        /// Operation Id: StaticSites_GetStaticSiteBuilds
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildARMResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildARMResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteBuildARMResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuilds(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteBuildARMResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuildsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteBuildARMResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_GetStaticSiteBuild
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}
        /// Operation Id: StaticSites_GetStaticSiteBuild
        /// </summary>
        /// <param name="environmentName"> The stage site identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string environmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentName, nameof(environmentName));

            using var scope = _staticSiteBuildARMStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildARMCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildARMStaticSitesRestClient.GetStaticSiteBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteBuildARMResource> IEnumerable<StaticSiteBuildARMResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildARMResource> IAsyncEnumerable<StaticSiteBuildARMResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
