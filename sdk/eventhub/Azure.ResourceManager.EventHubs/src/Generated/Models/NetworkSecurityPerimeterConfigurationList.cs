// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Result of the List NetworkSecurityPerimeterConfiguration operation. </summary>
    internal partial class NetworkSecurityPerimeterConfigurationList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterConfigurationList"/>. </summary>
        internal NetworkSecurityPerimeterConfigurationList()
        {
            Value = new ChangeTrackingList<EventHubsNetworkSecurityPerimeterConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterConfigurationList"/>. </summary>
        /// <param name="value"> A collection of NetworkSecurityPerimeterConfigurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterConfigurationList(IReadOnlyList<EventHubsNetworkSecurityPerimeterConfiguration> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A collection of NetworkSecurityPerimeterConfigurations. </summary>
        public IReadOnlyList<EventHubsNetworkSecurityPerimeterConfiguration> Value { get; }
    }
}
