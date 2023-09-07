// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The UnknownOrchestratorSpecificConnectionDetails. </summary>
    internal partial class UnknownOrchestratorSpecificConnectionDetails : OrchestratorSpecificConnectionDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOrchestratorSpecificConnectionDetails"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOrchestratorSpecificConnectionDetails(string instanceType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOrchestratorSpecificConnectionDetails"/> for deserialization. </summary>
        internal UnknownOrchestratorSpecificConnectionDetails()
        {
        }
    }
}
