// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing the PeeringRegisteredAsn data model.
    /// The customer's ASN that is registered by the peering service provider.
    /// </summary>
    public partial class PeeringRegisteredAsnData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeeringRegisteredAsnData"/>. </summary>
        public PeeringRegisteredAsnData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeeringRegisteredAsnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="asn"> The customer's ASN from which traffic originates. </param>
        /// <param name="peeringServicePrefixKey"> The peering service prefix key that is to be shared with the customer. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringRegisteredAsnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? asn, string peeringServicePrefixKey, PeeringProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Asn = asn;
            PeeringServicePrefixKey = peeringServicePrefixKey;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The customer's ASN from which traffic originates. </summary>
        public int? Asn { get; set; }
        /// <summary> The peering service prefix key that is to be shared with the customer. </summary>
        public string PeeringServicePrefixKey { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public PeeringProvisioningState? ProvisioningState { get; }
    }
}
