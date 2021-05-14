// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Feature of a SignalR resource, which controls the SignalR runtime
    /// behavior.
    /// </summary>
    public partial class SignalRFeature
    {
        /// <summary>
        /// Initializes a new instance of the SignalRFeature class.
        /// </summary>
        public SignalRFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRFeature class.
        /// </summary>
        /// <param name="flag">FeatureFlags is the supported features of Azure
        /// SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values
        /// allowed: "Default": have your own backend server; "Serverless":
        /// your application doesn't have a backend server; "Classic": for
        /// backward compatibility. Support both Default and Serverless mode
        /// but not recommended; "PredefinedOnly": for future use.
        /// - EnableConnectivityLogs: "true"/"false", to enable/disable the
        /// connectivity log category respectively.
        /// - EnableMessagingLogs: "true"/"false", to enable/disable the
        /// connectivity log category respectively.
        /// - EnableLiveTrace: Live Trace allows you to know what's happening
        /// inside Azure SignalR service, it will give you live traces in real
        /// time, it will be helpful when you developing your own Azure SignalR
        /// based web application or self-troubleshooting some issues. Please
        /// note that live traces are counted as outbound messages that will be
        /// charged. Values allowed: "true"/"false", to enable/disable live
        /// trace feature. Possible values include: 'ServiceMode',
        /// 'EnableConnectivityLogs', 'EnableMessagingLogs',
        /// 'EnableLiveTrace'</param>
        /// <param name="value">Value of the feature flag. See Azure SignalR
        /// service document https://docs.microsoft.com/azure/azure-signalr/
        /// for allowed values.</param>
        /// <param name="properties">Optional properties related to this
        /// feature.</param>
        public SignalRFeature(string flag, string value, IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            Flag = flag;
            Value = value;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets featureFlags is the supported features of Azure
        /// SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values
        /// allowed: "Default": have your own backend server; "Serverless":
        /// your application doesn't have a backend server; "Classic": for
        /// backward compatibility. Support both Default and Serverless mode
        /// but not recommended; "PredefinedOnly": for future use.
        /// - EnableConnectivityLogs: "true"/"false", to enable/disable the
        /// connectivity log category respectively.
        /// - EnableMessagingLogs: "true"/"false", to enable/disable the
        /// connectivity log category respectively.
        /// - EnableLiveTrace: Live Trace allows you to know what's happening
        /// inside Azure SignalR service, it will give you live traces in real
        /// time, it will be helpful when you developing your own Azure SignalR
        /// based web application or self-troubleshooting some issues. Please
        /// note that live traces are counted as outbound messages that will be
        /// charged. Values allowed: "true"/"false", to enable/disable live
        /// trace feature. Possible values include: 'ServiceMode',
        /// 'EnableConnectivityLogs', 'EnableMessagingLogs', 'EnableLiveTrace'
        /// </summary>
        [JsonProperty(PropertyName = "flag")]
        public string Flag { get; set; }

        /// <summary>
        /// Gets or sets value of the feature flag. See Azure SignalR service
        /// document https://docs.microsoft.com/azure/azure-signalr/ for
        /// allowed values.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets optional properties related to this feature.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Flag == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Flag");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (Value != null)
            {
                if (Value.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Value", 128);
                }
                if (Value.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Value", 1);
                }
            }
        }
    }
}
