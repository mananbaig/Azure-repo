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

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A class representing a collection of <see cref="QuotaRequestDetailResource" /> and their operations.
    /// Each <see cref="QuotaRequestDetailResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="QuotaRequestDetailCollection" /> instance call the GetQuotaRequestDetails method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class QuotaRequestDetailCollection : ArmCollection, IEnumerable<QuotaRequestDetailResource>, IAsyncEnumerable<QuotaRequestDetailResource>
    {
        private readonly ClientDiagnostics _quotaRequestDetailQuotaRequestStatusClientDiagnostics;
        private readonly QuotaRequestStatusRestOperations _quotaRequestDetailQuotaRequestStatusRestClient;
        private readonly string _providerId;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailCollection"/> class for mocking. </summary>
        protected QuotaRequestDetailCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaRequestDetailCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> is an empty string, and was expected to be non-empty. </exception>
        internal QuotaRequestDetailCollection(ArmClient client, ResourceIdentifier id, string providerId, AzureLocation location) : base(client, id)
        {
            _providerId = providerId;
            _location = location;
            _quotaRequestDetailQuotaRequestStatusClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", QuotaRequestDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(QuotaRequestDetailResource.ResourceType, out string quotaRequestDetailQuotaRequestStatusApiVersion);
            _quotaRequestDetailQuotaRequestStatusRestClient = new QuotaRequestStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaRequestDetailQuotaRequestStatusApiVersion);
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
        /// For the specified Azure region (location), get the details and status of the quota request by the quota request ID for the resources of the resource provider. The PUT request for the quota (service limit) returns a response with the requestId parameter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota Request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QuotaRequestDetailResource>> GetAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Get");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id.SubscriptionId, _providerId, new AzureLocation(_location), id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// For the specified Azure region (location), get the details and status of the quota request by the quota request ID for the resources of the resource provider. The PUT request for the quota (service limit) returns a response with the requestId parameter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota Request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QuotaRequestDetailResource> Get(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Get");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id.SubscriptionId, _providerId, new AzureLocation(_location), id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaRequestDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// For the specified Azure region (location), subscription, and resource provider, get the history of the quota requests for the past year. To select specific quota requests, use the oData filter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field | Supported operators |
        /// |---------------------|------------------------|
        /// |requestSubmitTime | ge, le, eq, gt, lt |
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element includes a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="QuotaRequestDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<QuotaRequestDetailResource> GetAllAsync(string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListRequest(Id.SubscriptionId, _providerId, new AzureLocation(_location), filter, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _providerId, new AzureLocation(_location), filter, top, skiptoken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new QuotaRequestDetailResource(Client, QuotaRequestDetailData.DeserializeQuotaRequestDetailData(e)), _quotaRequestDetailQuotaRequestStatusClientDiagnostics, Pipeline, "QuotaRequestDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// For the specified Azure region (location), subscription, and resource provider, get the history of the quota requests for the past year. To select specific quota requests, use the oData filter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter">
        /// | Field | Supported operators |
        /// |---------------------|------------------------|
        /// |requestSubmitTime | ge, le, eq, gt, lt |
        /// </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skiptoken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element includes a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="QuotaRequestDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<QuotaRequestDetailResource> GetAll(string filter = null, int? top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListRequest(Id.SubscriptionId, _providerId, new AzureLocation(_location), filter, top, skiptoken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _quotaRequestDetailQuotaRequestStatusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _providerId, new AzureLocation(_location), filter, top, skiptoken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new QuotaRequestDetailResource(Client, QuotaRequestDetailData.DeserializeQuotaRequestDetailData(e)), _quotaRequestDetailQuotaRequestStatusClientDiagnostics, Pipeline, "QuotaRequestDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota Request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = await _quotaRequestDetailQuotaRequestStatusRestClient.GetAsync(Id.SubscriptionId, _providerId, new AzureLocation(_location), id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimitsRequests/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QuotaRequestStatus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> Quota Request ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid id, CancellationToken cancellationToken = default)
        {
            using var scope = _quotaRequestDetailQuotaRequestStatusClientDiagnostics.CreateScope("QuotaRequestDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = _quotaRequestDetailQuotaRequestStatusRestClient.Get(Id.SubscriptionId, _providerId, new AzureLocation(_location), id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<QuotaRequestDetailResource> IEnumerable<QuotaRequestDetailResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<QuotaRequestDetailResource> IAsyncEnumerable<QuotaRequestDetailResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
