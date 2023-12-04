// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class extending from the ReservationResource in Azure.ResourceManager.Consumption along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="ReservationConsumptionResource"/> from a <see cref="ResourceIdentifier"/> with a resource type of Microsoft.Capacity/reservationorders/reservations.
    /// </summary>
    public partial class ReservationConsumptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ReservationConsumptionResource"/> instance. </summary>
        /// <param name="reservationOrderId"> The reservationOrderId. </param>
        /// <param name="reservationId"> The reservationId. </param>
        internal static ResourceIdentifier CreateResourceIdentifier(string reservationOrderId, string reservationId)
        {
            var resourceId = $"/providers/Microsoft.Capacity/reservationorders/{reservationOrderId}/reservations/{reservationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _reservationsSummariesClientDiagnostics;
        private readonly ReservationsSummariesRestOperations _reservationsSummariesRestClient;
        private readonly ClientDiagnostics _reservationsDetailsClientDiagnostics;
        private readonly ReservationsDetailsRestOperations _reservationsDetailsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ReservationConsumptionResource"/> class for mocking. </summary>
        protected ReservationConsumptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationConsumptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReservationConsumptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationsSummariesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _reservationsSummariesRestClient = new ReservationsSummariesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _reservationsDetailsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _reservationsDetailsRestClient = new ReservationsDetailsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Capacity/reservationorders/reservations";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Lists the reservations summaries for daily or monthly grain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationorders/{reservationOrderId}/reservations/{reservationId}/providers/Microsoft.Consumption/reservationSummaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationsSummaries_ListByReservationOrderAndReservation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionReservationSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionReservationSummary> GetReservationSummariesAsync(ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationsSummariesRestClient.CreateListByReservationOrderAndReservationRequest(Id.Parent.Name, Id.Name, grain, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationsSummariesRestClient.CreateListByReservationOrderAndReservationNextPageRequest(nextLink, Id.Parent.Name, Id.Name, grain, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ConsumptionReservationSummary.DeserializeConsumptionReservationSummary(e), _reservationsSummariesClientDiagnostics, Pipeline, "ReservationConsumptionResource.GetReservationSummaries", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the reservations summaries for daily or monthly grain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationorders/{reservationOrderId}/reservations/{reservationId}/providers/Microsoft.Consumption/reservationSummaries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationsSummaries_ListByReservationOrderAndReservation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="grain"> Can be daily or monthly. </param>
        /// <param name="filter"> Required only for daily grain. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionReservationSummary"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionReservationSummary> GetReservationSummaries(ReservationSummaryDataGrain grain, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationsSummariesRestClient.CreateListByReservationOrderAndReservationRequest(Id.Parent.Name, Id.Name, grain, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationsSummariesRestClient.CreateListByReservationOrderAndReservationNextPageRequest(nextLink, Id.Parent.Name, Id.Name, grain, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ConsumptionReservationSummary.DeserializeConsumptionReservationSummary(e), _reservationsSummariesClientDiagnostics, Pipeline, "ReservationConsumptionResource.GetReservationSummaries", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationorders/{reservationOrderId}/reservations/{reservationId}/providers/Microsoft.Consumption/reservationDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationsDetails_ListByReservationOrderAndReservation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> An async collection of <see cref="ConsumptionReservationDetail"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionReservationDetail> GetReservationDetailsAsync(string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationsDetailsRestClient.CreateListByReservationOrderAndReservationRequest(Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationsDetailsRestClient.CreateListByReservationOrderAndReservationNextPageRequest(nextLink, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => ConsumptionReservationDetail.DeserializeConsumptionReservationDetail(e), _reservationsDetailsClientDiagnostics, Pipeline, "ReservationConsumptionResource.GetReservationDetails", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the reservations details for provided date range. Note: ARM has a payload size limit of 12MB, so currently callers get 502 when the response size exceeds the ARM limit. In such cases, API call should be made with smaller date ranges.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationorders/{reservationOrderId}/reservations/{reservationId}/providers/Microsoft.Consumption/reservationDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationsDetails_ListByReservationOrderAndReservation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter reservation details by date range. The properties/UsageDate for start date and end date. The filter supports 'le' and  'ge'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <returns> A collection of <see cref="ConsumptionReservationDetail"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionReservationDetail> GetReservationDetails(string filter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationsDetailsRestClient.CreateListByReservationOrderAndReservationRequest(Id.Parent.Name, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationsDetailsRestClient.CreateListByReservationOrderAndReservationNextPageRequest(nextLink, Id.Parent.Name, Id.Name, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => ConsumptionReservationDetail.DeserializeConsumptionReservationDetail(e), _reservationsDetailsClientDiagnostics, Pipeline, "ReservationConsumptionResource.GetReservationDetails", "value", "nextLink", cancellationToken);
        }
    }
}
