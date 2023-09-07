// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A class representing the TenantPolicy data model.
    /// Tenant policy Information.
    /// </summary>
    public partial class TenantPolicyData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TenantPolicyData"/>. </summary>
        internal TenantPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TenantPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Tenant policy properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TenantPolicyProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tenant policy properties. </summary>
        public TenantPolicyProperties Properties { get; }
    }
}
