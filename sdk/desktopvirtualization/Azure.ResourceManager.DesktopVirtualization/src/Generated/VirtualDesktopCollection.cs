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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualDesktopResource" /> and their operations.
    /// Each <see cref="VirtualDesktopResource" /> in the collection will belong to the same instance of <see cref="VirtualApplicationGroupResource" />.
    /// To get a <see cref="VirtualDesktopCollection" /> instance call the GetVirtualDesktops method from an instance of <see cref="VirtualApplicationGroupResource" />.
    /// </summary>
    public partial class VirtualDesktopCollection : ArmCollection, IEnumerable<VirtualDesktopResource>, IAsyncEnumerable<VirtualDesktopResource>
    {
        private readonly ClientDiagnostics _virtualDesktopDesktopsClientDiagnostics;
        private readonly DesktopsRestOperations _virtualDesktopDesktopsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualDesktopCollection"/> class for mocking. </summary>
        protected VirtualDesktopCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualDesktopCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualDesktopCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualDesktopDesktopsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualDesktopResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualDesktopResource.ResourceType, out string virtualDesktopDesktopsApiVersion);
            _virtualDesktopDesktopsRestClient = new DesktopsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualDesktopDesktopsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualApplicationGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualApplicationGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a desktop.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<VirtualDesktopResource>> GetAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a desktop.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<VirtualDesktopResource> Get(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List desktops.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualDesktopResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualDesktopResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualDesktopDesktopsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualDesktopDesktopsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualDesktopResource(Client, VirtualDesktopData.DeserializeVirtualDesktopData(e)), _virtualDesktopDesktopsClientDiagnostics, Pipeline, "VirtualDesktopCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List desktops.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualDesktopResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualDesktopResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualDesktopDesktopsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualDesktopDesktopsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualDesktopResource(Client, VirtualDesktopData.DeserializeVirtualDesktopData(e)), _virtualDesktopDesktopsClientDiagnostics, Pipeline, "VirtualDesktopCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual Response<bool> Exists(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualDesktopResource>> GetIfExistsAsync(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualDesktopDesktopsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualDesktopResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/applicationGroups/{applicationGroupName}/desktops/{desktopName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Desktops_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="desktopName"> The name of the desktop within the specified desktop group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="desktopName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="desktopName"/> is null. </exception>
        public virtual NullableResponse<VirtualDesktopResource> GetIfExists(string desktopName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(desktopName, nameof(desktopName));

            using var scope = _virtualDesktopDesktopsClientDiagnostics.CreateScope("VirtualDesktopCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualDesktopDesktopsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, desktopName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualDesktopResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualDesktopResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualDesktopResource> IEnumerable<VirtualDesktopResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualDesktopResource> IAsyncEnumerable<VirtualDesktopResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
