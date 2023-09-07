// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The ControllerConnectionDetails. </summary>
    public partial class ControllerConnectionDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ControllerConnectionDetails"/>. </summary>
        internal ControllerConnectionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ControllerConnectionDetails"/>. </summary>
        /// <param name="orchestratorSpecificConnectionDetails">
        /// Base class for types that supply values used to connect to container orchestrators
        /// Please note <see cref="OrchestratorSpecificConnectionDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KubernetesConnectionDetails"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ControllerConnectionDetails(OrchestratorSpecificConnectionDetails orchestratorSpecificConnectionDetails, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OrchestratorSpecificConnectionDetails = orchestratorSpecificConnectionDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Base class for types that supply values used to connect to container orchestrators
        /// Please note <see cref="OrchestratorSpecificConnectionDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KubernetesConnectionDetails"/>.
        /// </summary>
        public OrchestratorSpecificConnectionDetails OrchestratorSpecificConnectionDetails { get; }
    }
}
