// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a device telemetry
    /// event (DeviceTelemetry).
    /// </summary>
    public partial class DeviceTelemetryEventProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeviceTelemetryEventProperties
        /// class.
        /// </summary>
        public DeviceTelemetryEventProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceTelemetryEventProperties
        /// class.
        /// </summary>
        /// <param name="body">The content of the message from the
        /// device.</param>
        /// <param name="properties">Application properties are user-defined
        /// strings that can be added to the message. These fields are
        /// optional.</param>
        /// <param name="systemProperties">System properties help identify
        /// contents and source of the messages.</param>
        public DeviceTelemetryEventProperties(object body = default(object), object properties = default(object), object systemProperties = default(object))
        {
            Body = body;
            Properties = properties;
            SystemProperties = systemProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the content of the message from the device.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets application properties are user-defined strings that
        /// can be added to the message. These fields are optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets system properties help identify contents and source of
        /// the messages.
        /// </summary>
        [JsonProperty(PropertyName = "systemProperties")]
        public object SystemProperties { get; set; }

    }
}
