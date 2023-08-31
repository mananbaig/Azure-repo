// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The network tap destination properties. </summary>
    public partial class NetworkTapDestinationProperties
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkTapDestinationProperties"/>. </summary>
        public NetworkTapDestinationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapDestinationProperties"/>. </summary>
        /// <param name="name"> Destination name. </param>
        /// <param name="destinationType"> Type of destination. Input can be IsolationDomain or Direct. </param>
        /// <param name="destinationId"> The destination Id. ARM Resource ID of either NNI or Internal Networks. </param>
        /// <param name="isolationDomainProperties"> Isolation Domain Properties. </param>
        /// <param name="destinationTapRuleId"> ARM Resource ID of destination Tap Rule that contains match configurations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkTapDestinationProperties(string name, NetworkTapDestinationType? destinationType, ResourceIdentifier destinationId, IsolationDomainProperties isolationDomainProperties, ResourceIdentifier destinationTapRuleId, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            DestinationType = destinationType;
            DestinationId = destinationId;
            IsolationDomainProperties = isolationDomainProperties;
            DestinationTapRuleId = destinationTapRuleId;
            _rawData = rawData;
        }

        /// <summary> Destination name. </summary>
        public string Name { get; set; }
        /// <summary> Type of destination. Input can be IsolationDomain or Direct. </summary>
        public NetworkTapDestinationType? DestinationType { get; set; }
        /// <summary> The destination Id. ARM Resource ID of either NNI or Internal Networks. </summary>
        public ResourceIdentifier DestinationId { get; set; }
        /// <summary> Isolation Domain Properties. </summary>
        public IsolationDomainProperties IsolationDomainProperties { get; set; }
        /// <summary> ARM Resource ID of destination Tap Rule that contains match configurations. </summary>
        public ResourceIdentifier DestinationTapRuleId { get; set; }
    }
}
