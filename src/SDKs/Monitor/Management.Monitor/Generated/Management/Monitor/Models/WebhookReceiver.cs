// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A webhook receiver.
    /// </summary>
    public partial class WebhookReceiver
    {
        /// <summary>
        /// Initializes a new instance of the WebhookReceiver class.
        /// </summary>
        public WebhookReceiver() { }

        /// <summary>
        /// Initializes a new instance of the WebhookReceiver class.
        /// </summary>
        /// <param name="name">The name of the webhook receiver. Names must be
        /// unique across all receivers within an action group.</param>
        /// <param name="serviceUri">The URI where webhooks should be
        /// sent.</param>
        public WebhookReceiver(string name, string serviceUri)
        {
            Name = name;
            ServiceUri = serviceUri;
        }

        /// <summary>
        /// Gets or sets the name of the webhook receiver. Names must be unique
        /// across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URI where webhooks should be sent.
        /// </summary>
        [JsonProperty(PropertyName = "serviceUri")]
        public string ServiceUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (ServiceUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceUri");
            }
        }
    }
}
