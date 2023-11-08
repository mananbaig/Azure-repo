// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Provider specific input for pairing operations.
    /// Please note <see cref="ReplicationProviderSpecificContainerMappingContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2AContainerMappingContent"/> and <see cref="VMwareCbtContainerMappingContent"/>.
    /// </summary>
    public abstract partial class ReplicationProviderSpecificContainerMappingContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReplicationProviderSpecificContainerMappingContent"/>. </summary>
        protected ReplicationProviderSpecificContainerMappingContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationProviderSpecificContainerMappingContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReplicationProviderSpecificContainerMappingContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
