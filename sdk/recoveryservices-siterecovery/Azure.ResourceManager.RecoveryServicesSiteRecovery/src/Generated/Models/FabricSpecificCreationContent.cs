// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Fabric provider specific settings.
    /// Please note <see cref="FabricSpecificCreationContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SiteRecoveryFabricProviderCreationContent"/>, <see cref="InMageRcmFabricCreationContent"/> and <see cref="VMwareV2FabricCreationContent"/>.
    /// </summary>
    public abstract partial class FabricSpecificCreationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FabricSpecificCreationContent"/>. </summary>
        protected FabricSpecificCreationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FabricSpecificCreationContent"/>. </summary>
        /// <param name="instanceType"> Gets the class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FabricSpecificCreationContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the class type. </summary>
        internal string InstanceType { get; set; }
    }
}
