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

    [Newtonsoft.Json.JsonObject("PartnerDestination")]
    [Rest.Serialization.JsonTransformation]
    public partial class PartnerEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PartnerEventSubscriptionDestination class.
        /// </summary>
        public PartnerEventSubscriptionDestination()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PartnerEventSubscriptionDestination class.
        /// </summary>
        /// <param name="resourceId">The Azure Resource Id that represents the
        /// endpoint of a Partner Destination of an event subscription.</param>
        public PartnerEventSubscriptionDestination(string resourceId = default(string))
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
        /// a Partner Destination of an event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

    }
}
