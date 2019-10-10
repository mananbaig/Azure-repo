// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// This API describe Azure Reservation
    /// </summary>
    public partial interface IAzureReservationAPIClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Supported version for this document is 2019-04-01
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IReservationOperations.
        /// </summary>
        IReservationOperations Reservation { get; }

        /// <summary>
        /// Gets the IReservationOrderOperations.
        /// </summary>
        IReservationOrderOperations ReservationOrder { get; }

        /// <summary>
        /// Gets the IOperationOperations.
        /// </summary>
        IOperationOperations Operation { get; }

        /// <summary>
        /// Get the regions and skus that are available for RI purchase for the
        /// specified Azure subscription.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of the subscription
        /// </param>
        /// <param name='reservedResourceType'>
        /// The type of the resource for which the skus should be provided.
        /// </param>
        /// <param name='location'>
        /// Filters the skus based on the location specified in this parameter.
        /// This can be an azure region or global
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<Catalog>>> GetCatalogWithHttpMessagesAsync(string subscriptionId, string reservedResourceType, string location = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get list of applicable `Reservation`s.
        /// </summary>
        /// <remarks>
        /// Get applicable `Reservation`s that are applied to this subscription
        /// or a resource group under this subscription.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Id of the subscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppliedReservations>> GetAppliedReservationListWithHttpMessagesAsync(string subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
