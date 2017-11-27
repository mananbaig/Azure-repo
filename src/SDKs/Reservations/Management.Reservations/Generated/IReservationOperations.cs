// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReservationOperations operations.
    /// </summary>
    public partial interface IReservationOperations
    {
        /// <summary>
        /// Split the `Reservation`.
        /// </summary>
        /// <remarks>
        /// Split a `Reservation` into two `Reservation`s with specified
        /// quantity distribution.
        ///
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='body'>
        /// Information needed to Split a reservation item
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<ReservationResponse>>> SplitWithHttpMessagesAsync(string reservationOrderId, SplitRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Merges two `Reservation`s.
        /// </summary>
        /// <remarks>
        /// Merge the specified `Reservation`s into a new `Reservation`. The
        /// two `Reservation`s being merged must have same properties.
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='body'>
        /// Information needed for commercial request for a reservation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<ReservationResponse>>> MergeWithHttpMessagesAsync(string reservationOrderId, MergeRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get `Reservation`s in a given reservation Order
        /// </summary>
        /// <remarks>
        /// List `Reservation`s within a single `ReservationOrder`.
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ReservationResponse>>> ListWithHttpMessagesAsync(string reservationOrderId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get `Reservation` details.
        /// </summary>
        /// <remarks>
        /// Get specific `Reservation` details.
        /// </remarks>
        /// <param name='reservationId'>
        /// Id of the Reservation Item
        /// </param>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ReservationResponse>> GetWithHttpMessagesAsync(string reservationId, string reservationOrderId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a `Reservation`.
        /// </summary>
        /// <remarks>
        /// Updates the applied scopes of the `Reservation`.
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='reservationId'>
        /// Id of the Reservation Item
        /// </param>
        /// <param name='parameters'>
        /// Information needed to patch a reservation item
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ReservationResponse>> UpdateWithHttpMessagesAsync(string reservationOrderId, string reservationId, Patch parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get `Reservation` revisions.
        /// </summary>
        /// <remarks>
        /// List of all the revisions for the `Reservation`.
        ///
        /// </remarks>
        /// <param name='reservationId'>
        /// Id of the Reservation Item
        /// </param>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ReservationResponse>>> ListRevisionsWithHttpMessagesAsync(string reservationId, string reservationOrderId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Split the `Reservation`.
        /// </summary>
        /// <remarks>
        /// Split a `Reservation` into two `Reservation`s with specified
        /// quantity distribution.
        ///
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='body'>
        /// Information needed to Split a reservation item
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<ReservationResponse>>> BeginSplitWithHttpMessagesAsync(string reservationOrderId, SplitRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Merges two `Reservation`s.
        /// </summary>
        /// <remarks>
        /// Merge the specified `Reservation`s into a new `Reservation`. The
        /// two `Reservation`s being merged must have same properties.
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='body'>
        /// Information needed for commercial request for a reservation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<ReservationResponse>>> BeginMergeWithHttpMessagesAsync(string reservationOrderId, MergeRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a `Reservation`.
        /// </summary>
        /// <remarks>
        /// Updates the applied scopes of the `Reservation`.
        /// </remarks>
        /// <param name='reservationOrderId'>
        /// Order Id of the reservation
        ///
        /// </param>
        /// <param name='reservationId'>
        /// Id of the Reservation Item
        /// </param>
        /// <param name='parameters'>
        /// Information needed to patch a reservation item
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ReservationResponse>> BeginUpdateWithHttpMessagesAsync(string reservationOrderId, string reservationId, Patch parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get `Reservation`s in a given reservation Order
        /// </summary>
        /// <remarks>
        /// List `Reservation`s within a single `ReservationOrder`.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ReservationResponse>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get `Reservation` revisions.
        /// </summary>
        /// <remarks>
        /// List of all the revisions for the `Reservation`.
        ///
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ReservationResponse>>> ListRevisionsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
