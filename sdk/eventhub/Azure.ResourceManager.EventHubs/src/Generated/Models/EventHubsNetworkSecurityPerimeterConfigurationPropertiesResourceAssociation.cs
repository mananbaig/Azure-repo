// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Information about resource association. </summary>
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        /// <param name="name"> Name of the resource association. </param>
        /// <param name="accessMode"> Access Mode of the resource association. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(string name, EventHubsResourceAssociationAccessMode? accessMode, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AccessMode = accessMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the resource association. </summary>
        public string Name { get; }
        /// <summary> Access Mode of the resource association. </summary>
        public EventHubsResourceAssociationAccessMode? AccessMode { get; }
    }
}
