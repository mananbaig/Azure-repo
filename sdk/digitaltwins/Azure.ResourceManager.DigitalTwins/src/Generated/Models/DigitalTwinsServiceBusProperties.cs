// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> Properties related to ServiceBus. </summary>
    public partial class DigitalTwinsServiceBusProperties : DigitalTwinsEndpointResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="DigitalTwinsServiceBusProperties"/>. </summary>
        public DigitalTwinsServiceBusProperties()
        {
            EndpointType = EndpointType.ServiceBus;
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsServiceBusProperties"/>. </summary>
        /// <param name="endpointType"> The type of Digital Twins endpoint. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="createdOn"> Time when the Endpoint was added to DigitalTwinsInstance. </param>
        /// <param name="authenticationType"> Specifies the authentication type being used for connecting to the endpoint. Defaults to 'KeyBased'. If 'KeyBased' is selected, a connection string must be specified (at least the primary connection string). If 'IdentityBased' is select, the endpointUri and entityPath properties must be specified. </param>
        /// <param name="deadLetterSecret"> Dead letter storage secret for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="deadLetterUri"> Dead letter storage URL for identity-based authentication. </param>
        /// <param name="identity"> Managed identity properties for the endpoint. </param>
        /// <param name="primaryConnectionString"> PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="secondaryConnectionString"> SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </param>
        /// <param name="endpointUri"> The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol 'sb://'. </param>
        /// <param name="entityPath"> The ServiceBus Topic name for identity-based authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsServiceBusProperties(EndpointType endpointType, DigitalTwinsEndpointProvisioningState? provisioningState, DateTimeOffset? createdOn, DigitalTwinsAuthenticationType? authenticationType, string deadLetterSecret, Uri deadLetterUri, DigitalTwinsManagedIdentityReference identity, string primaryConnectionString, string secondaryConnectionString, Uri endpointUri, string entityPath, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(endpointType, provisioningState, createdOn, authenticationType, deadLetterSecret, deadLetterUri, identity, serializedAdditionalRawData)
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            EndpointUri = endpointUri;
            EntityPath = entityPath;
            EndpointType = endpointType;
        }

        /// <summary> PrimaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </summary>
        public string PrimaryConnectionString { get; set; }
        /// <summary> SecondaryConnectionString of the endpoint for key-based authentication. Will be obfuscated during read. </summary>
        public string SecondaryConnectionString { get; set; }
        /// <summary> The URL of the ServiceBus namespace for identity-based authentication. It must include the protocol 'sb://'. </summary>
        public Uri EndpointUri { get; set; }
        /// <summary> The ServiceBus Topic name for identity-based authentication. </summary>
        public string EntityPath { get; set; }
    }
}
