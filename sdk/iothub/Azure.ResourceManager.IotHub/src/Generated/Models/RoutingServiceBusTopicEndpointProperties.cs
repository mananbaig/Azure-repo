// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties related to service bus topic endpoint types. </summary>
    public partial class RoutingServiceBusTopicEndpointProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoutingServiceBusTopicEndpointProperties"/>. </summary>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types.  The name need not be the same as the actual topic name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RoutingServiceBusTopicEndpointProperties(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingServiceBusTopicEndpointProperties"/>. </summary>
        /// <param name="id"> Id of the service bus topic endpoint. </param>
        /// <param name="connectionString"> The connection string of the service bus topic endpoint. </param>
        /// <param name="endpoint"> The url of the service bus topic endpoint. It must include the protocol sb://. </param>
        /// <param name="entityPath"> Queue name on the service bus topic. </param>
        /// <param name="authenticationType"> Method used to authenticate against the service bus topic endpoint. </param>
        /// <param name="identity"> Managed identity properties of routing service bus topic endpoint. </param>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types.  The name need not be the same as the actual topic name. </param>
        /// <param name="subscriptionId"> The subscription identifier of the service bus topic endpoint. </param>
        /// <param name="resourceGroup"> The name of the resource group of the service bus topic endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingServiceBusTopicEndpointProperties(Guid? id, string connectionString, string endpoint, string entityPath, IotHubAuthenticationType? authenticationType, ManagedIdentity identity, string name, string subscriptionId, string resourceGroup, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ConnectionString = connectionString;
            Endpoint = endpoint;
            EntityPath = entityPath;
            AuthenticationType = authenticationType;
            Identity = identity;
            Name = name;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingServiceBusTopicEndpointProperties"/> for deserialization. </summary>
        internal RoutingServiceBusTopicEndpointProperties()
        {
        }

        /// <summary> Id of the service bus topic endpoint. </summary>
        public Guid? Id { get; set; }
        /// <summary> The connection string of the service bus topic endpoint. </summary>
        public string ConnectionString { get; set; }
        /// <summary> The url of the service bus topic endpoint. It must include the protocol sb://. </summary>
        public string Endpoint { get; set; }
        /// <summary> Queue name on the service bus topic. </summary>
        public string EntityPath { get; set; }
        /// <summary> Method used to authenticate against the service bus topic endpoint. </summary>
        public IotHubAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Managed identity properties of routing service bus topic endpoint. </summary>
        internal ManagedIdentity Identity { get; set; }
        /// <summary> The user assigned identity. </summary>
        public ResourceIdentifier UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new ManagedIdentity();
                Identity.UserAssignedIdentity = value;
            }
        }

        /// <summary> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types.  The name need not be the same as the actual topic name. </summary>
        public string Name { get; set; }
        /// <summary> The subscription identifier of the service bus topic endpoint. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> The name of the resource group of the service bus topic endpoint. </summary>
        public string ResourceGroup { get; set; }
    }
}
