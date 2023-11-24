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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ImageVersionResource"/> and their operations.
    /// Each <see cref="ImageVersionResource"/> in the collection will belong to the same instance of <see cref="DevCenterImageResource"/>.
    /// To get an <see cref="ImageVersionCollection"/> instance call the GetImageVersions method from an instance of <see cref="DevCenterImageResource"/>.
    /// </summary>
    public partial class ImageVersionCollection : ArmCollection, IEnumerable<ImageVersionResource>, IAsyncEnumerable<ImageVersionResource>
    {
        private readonly ClientDiagnostics _imageVersionClientDiagnostics;
        private readonly ImageVersionsRestOperations _imageVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ImageVersionCollection"/> class for mocking. </summary>
        protected ImageVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ImageVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ImageVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _imageVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", ImageVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ImageVersionResource.ResourceType, out string imageVersionApiVersion);
            _imageVersionRestClient = new ImageVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, imageVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterImageResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterImageResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<ImageVersionResource>> GetAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _imageVersionClientDiagnostics.CreateScope("ImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _imageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, versionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an image version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<ImageVersionResource> Get(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _imageVersionClientDiagnostics.CreateScope("ImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _imageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, versionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists versions for an image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_ListByImage</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ImageVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ImageVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _imageVersionRestClient.CreateListByImageRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _imageVersionRestClient.CreateListByImageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ImageVersionResource(Client, ImageVersionData.DeserializeImageVersionData(e)), _imageVersionClientDiagnostics, Pipeline, "ImageVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists versions for an image.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_ListByImage</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ImageVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ImageVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _imageVersionRestClient.CreateListByImageRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _imageVersionRestClient.CreateListByImageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ImageVersionResource(Client, ImageVersionData.DeserializeImageVersionData(e)), _imageVersionClientDiagnostics, Pipeline, "ImageVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _imageVersionClientDiagnostics.CreateScope("ImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _imageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<bool> Exists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _imageVersionClientDiagnostics.CreateScope("ImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _imageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ImageVersionResource>> GetIfExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _imageVersionClientDiagnostics.CreateScope("ImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _imageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ImageVersionResource>(response.GetRawResponse());
                return Response.FromValue(new ImageVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/devcenters/{devCenterName}/galleries/{galleryName}/images/{imageName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual NullableResponse<ImageVersionResource> GetIfExists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _imageVersionClientDiagnostics.CreateScope("ImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _imageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, versionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ImageVersionResource>(response.GetRawResponse());
                return Response.FromValue(new ImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ImageVersionResource> IEnumerable<ImageVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ImageVersionResource> IAsyncEnumerable<ImageVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
