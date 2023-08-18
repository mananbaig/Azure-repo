// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the service bus destination for an event subscription. </summary>
    public partial class ServiceBusQueueEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of ServiceBusQueueEventSubscriptionDestination. </summary>
        public ServiceBusQueueEventSubscriptionDestination()
        {
            DeliveryAttributeMappings = new Core.ChangeTrackingList<DeliveryAttributeMapping>();
            EndpointType = EndpointType.ServiceBusQueue;
        }

        /// <summary> Initializes a new instance of ServiceBusQueueEventSubscriptionDestination. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="resourceId"> The Azure Resource Id that represents the endpoint of the Service Bus destination of an event subscription. </param>
        /// <param name="deliveryAttributeMappings">
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </param>
        internal ServiceBusQueueEventSubscriptionDestination(EndpointType endpointType, ResourceIdentifier resourceId, IList<DeliveryAttributeMapping> deliveryAttributeMappings) : base(endpointType)
        {
            ResourceId = resourceId;
            DeliveryAttributeMappings = deliveryAttributeMappings;
            EndpointType = endpointType;
        }

        /// <summary> The Azure Resource Id that represents the endpoint of the Service Bus destination of an event subscription. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary>
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </summary>
        public IList<DeliveryAttributeMapping> DeliveryAttributeMappings { get; }
    }
}
