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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaServicesAccountFilterResource" /> and their operations.
    /// Each <see cref="MediaServicesAccountFilterResource" /> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource" />.
    /// To get a <see cref="MediaServicesAccountFilterCollection" /> instance call the GetMediaServicesAccountFilters method from an instance of <see cref="MediaServicesAccountResource" />.
    /// </summary>
    public partial class MediaServicesAccountFilterCollection : ArmCollection, IEnumerable<MediaServicesAccountFilterResource>, IAsyncEnumerable<MediaServicesAccountFilterResource>
    {
        private readonly ClientDiagnostics _mediaServicesAccountFilterAccountFiltersClientDiagnostics;
        private readonly AccountFiltersRestOperations _mediaServicesAccountFilterAccountFiltersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaServicesAccountFilterCollection"/> class for mocking. </summary>
        protected MediaServicesAccountFilterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaServicesAccountFilterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaServicesAccountFilterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaServicesAccountFilterAccountFiltersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaServicesAccountFilterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaServicesAccountFilterResource.ResourceType, out string mediaServicesAccountFilterAccountFiltersApiVersion);
            _mediaServicesAccountFilterAccountFiltersRestClient = new AccountFiltersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaServicesAccountFilterAccountFiltersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Account Filter in the Media Services account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="filterName"> The Account Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaServicesAccountFilterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string filterName, MediaServicesAccountFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaServicesAccountFilterAccountFiltersClientDiagnostics.CreateScope("MediaServicesAccountFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mediaServicesAccountFilterAccountFiltersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaServicesAccountFilterResource>(Response.FromValue(new MediaServicesAccountFilterResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Account Filter in the Media Services account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="filterName"> The Account Filter name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaServicesAccountFilterResource> CreateOrUpdate(WaitUntil waitUntil, string filterName, MediaServicesAccountFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaServicesAccountFilterAccountFiltersClientDiagnostics.CreateScope("MediaServicesAccountFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mediaServicesAccountFilterAccountFiltersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filterName, data, cancellationToken);
                var operation = new MediaArmOperation<MediaServicesAccountFilterResource>(Response.FromValue(new MediaServicesAccountFilterResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Account Filter in the Media Services account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Account Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual async Task<Response<MediaServicesAccountFilterResource>> GetAsync(string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var scope = _mediaServicesAccountFilterAccountFiltersClientDiagnostics.CreateScope("MediaServicesAccountFilterCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaServicesAccountFilterAccountFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaServicesAccountFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Account Filter in the Media Services account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Account Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual Response<MediaServicesAccountFilterResource> Get(string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var scope = _mediaServicesAccountFilterAccountFiltersClientDiagnostics.CreateScope("MediaServicesAccountFilterCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaServicesAccountFilterAccountFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaServicesAccountFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Account Filters in the Media Services account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaServicesAccountFilterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaServicesAccountFilterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaServicesAccountFilterAccountFiltersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaServicesAccountFilterAccountFiltersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MediaServicesAccountFilterResource(Client, MediaServicesAccountFilterData.DeserializeMediaServicesAccountFilterData(e)), _mediaServicesAccountFilterAccountFiltersClientDiagnostics, Pipeline, "MediaServicesAccountFilterCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// List Account Filters in the Media Services account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaServicesAccountFilterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaServicesAccountFilterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaServicesAccountFilterAccountFiltersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaServicesAccountFilterAccountFiltersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MediaServicesAccountFilterResource(Client, MediaServicesAccountFilterData.DeserializeMediaServicesAccountFilterData(e)), _mediaServicesAccountFilterAccountFiltersClientDiagnostics, Pipeline, "MediaServicesAccountFilterCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Account Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var scope = _mediaServicesAccountFilterAccountFiltersClientDiagnostics.CreateScope("MediaServicesAccountFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaServicesAccountFilterAccountFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/accountFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccountFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Account Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        public virtual Response<bool> Exists(string filterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(filterName, nameof(filterName));

            using var scope = _mediaServicesAccountFilterAccountFiltersClientDiagnostics.CreateScope("MediaServicesAccountFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaServicesAccountFilterAccountFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MediaServicesAccountFilterResource> IEnumerable<MediaServicesAccountFilterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MediaServicesAccountFilterResource> IAsyncEnumerable<MediaServicesAccountFilterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
