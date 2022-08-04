// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The sub-request submitted with the quota request. </summary>
    public partial class SubContent
    {
        /// <summary> Initializes a new instance of SubContent. </summary>
        internal SubContent()
        {
        }

        /// <summary> Initializes a new instance of SubContent. </summary>
        /// <param name="limit"> Quota (resource limit). </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="resourceType"> Resource type for which the quota check was made. </param>
        /// <param name="unit"> The limit units, such as **count** and **bytes**. Use the unit field provided in the response of the GET quota operation. </param>
        /// <param name="provisioningState"> The quota request status. </param>
        /// <param name="message"> User-friendly status message. </param>
        /// <param name="subRequestId"> Sub request ID for individual request. </param>
        internal SubContent(int? limit, ReservationResourceName name, string resourceType, string unit, QuotaRequestState? provisioningState, string message, Guid? subRequestId)
        {
            Limit = limit;
            Name = name;
            ResourceType = resourceType;
            Unit = unit;
            ProvisioningState = provisioningState;
            Message = message;
            SubRequestId = subRequestId;
        }

        /// <summary> Quota (resource limit). </summary>
        public int? Limit { get; }
        /// <summary> The resource name. </summary>
        public ReservationResourceName Name { get; }
        /// <summary> Resource type for which the quota check was made. </summary>
        public string ResourceType { get; }
        /// <summary> The limit units, such as **count** and **bytes**. Use the unit field provided in the response of the GET quota operation. </summary>
        public string Unit { get; }
        /// <summary> The quota request status. </summary>
        public QuotaRequestState? ProvisioningState { get; }
        /// <summary> User-friendly status message. </summary>
        public string Message { get; }
        /// <summary> Sub request ID for individual request. </summary>
        public Guid? SubRequestId { get; }
    }
}
