// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryPolicy data model.
    /// Protection profile details.
    /// </summary>
    public partial class SiteRecoveryPolicyData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryPolicyData"/>. </summary>
        internal SiteRecoveryPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The custom data. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryPolicyProperties properties, AzureLocation? location, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The custom data. </summary>
        public SiteRecoveryPolicyProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
