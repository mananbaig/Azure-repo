// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The PartnerEventSubscriptionDestination. </summary>
    public partial class PartnerEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of <see cref="PartnerEventSubscriptionDestination"/>. </summary>
        public PartnerEventSubscriptionDestination()
        {
            EndpointType = EndpointType.PartnerDestination;
        }

        /// <summary> Initializes a new instance of <see cref="PartnerEventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="resourceId"> The Azure Resource Id that represents the endpoint of a Partner Destination of an event subscription. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PartnerEventSubscriptionDestination(EndpointType endpointType, string resourceId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(endpointType, serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            EndpointType = endpointType;
        }

        /// <summary> The Azure Resource Id that represents the endpoint of a Partner Destination of an event subscription. </summary>
        public string ResourceId { get; set; }
    }
}
