// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the service bus topic destination for an event
    /// subscription.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServiceBusTopic")]
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceBusTopicEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusTopicEventSubscriptionDestination class.
        /// </summary>
        public ServiceBusTopicEventSubscriptionDestination()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusTopicEventSubscriptionDestination class.
        /// </summary>
        /// <param name="resourceId">The Azure Resource Id that represents the
        /// endpoint of the Service Bus Topic destination of an event
        /// subscription.</param>
        public ServiceBusTopicEventSubscriptionDestination(string resourceId = default(string))
        {
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Resource Id that represents the endpoint of
        /// the Service Bus Topic destination of an event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

    }
}
