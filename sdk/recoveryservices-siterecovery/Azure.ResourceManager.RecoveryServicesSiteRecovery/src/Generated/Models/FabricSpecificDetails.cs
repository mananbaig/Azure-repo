// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Fabric specific details.
    /// Please note <see cref="FabricSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SiteRecoveryFabricProviderSpecificDetails"/>, <see cref="HyperVSiteDetails"/>, <see cref="InMageRcmFabricSpecificDetails"/>, <see cref="VmmFabricDetails"/>, <see cref="VMwareDetails"/> and <see cref="VMwareV2FabricSpecificDetails"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownFabricSpecificDetails))]
    public abstract partial class FabricSpecificDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FabricSpecificDetails"/>. </summary>
        protected FabricSpecificDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FabricSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FabricSpecificDetails(string instanceType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InstanceType = instanceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the class type. Overridden in derived classes. </summary>
        internal string InstanceType { get; set; }
    }
}
