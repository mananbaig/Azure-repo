// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventGrid;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Full endpoint url of an event subscription
    /// </summary>
    public partial class EventSubscriptionFullUrl
    {
        /// <summary>
        /// Initializes a new instance of the EventSubscriptionFullUrl class.
        /// </summary>
        public EventSubscriptionFullUrl()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSubscriptionFullUrl class.
        /// </summary>
        /// <param name="endpointUrl">The URL that represents the endpoint of
        /// the destination of an event subscription.</param>
        public EventSubscriptionFullUrl(string endpointUrl = default(string))
        {
            EndpointUrl = endpointUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL that represents the endpoint of the
        /// destination of an event subscription.
        /// </summary>
        [JsonProperty(PropertyName = "endpointUrl")]
        public string EndpointUrl { get; set; }

    }
}
