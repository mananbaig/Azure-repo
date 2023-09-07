// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the endpoint properties. </summary>
    public partial class FrontDoorExperimentEndpointProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorExperimentEndpointProperties"/>. </summary>
        public FrontDoorExperimentEndpointProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorExperimentEndpointProperties"/>. </summary>
        /// <param name="name"> The name of the endpoint. </param>
        /// <param name="endpoint"> The endpoint URL. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorExperimentEndpointProperties(string name, string endpoint, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Endpoint = endpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the endpoint. </summary>
        public string Name { get; set; }
        /// <summary> The endpoint URL. </summary>
        public string Endpoint { get; set; }
    }
}
