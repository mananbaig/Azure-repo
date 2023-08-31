// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Azure Lab Services resource SKUs. </summary>
    public partial class AvailableLabServicesSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailableLabServicesSku"/>. </summary>
        internal AvailableLabServicesSku()
        {
            Capabilities = new ChangeTrackingList<AvailableLabServicesSkuCapability>();
            Locations = new ChangeTrackingList<AzureLocation>();
            Costs = new ChangeTrackingList<AvailableLabServicesSkuCost>();
            Restrictions = new ChangeTrackingList<AvailableLabServicesSkuRestrictions>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableLabServicesSku"/>. </summary>
        /// <param name="resourceType"> The lab services resource type. </param>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="tier"> The tier of the SKU. </param>
        /// <param name="size"> The SKU size. </param>
        /// <param name="family"> The family of the SKU. </param>
        /// <param name="capacity"> The scale out/in options of the SKU. </param>
        /// <param name="capabilities"> The capabilities of the SKU. </param>
        /// <param name="locations"> List of locations that are available for a size. </param>
        /// <param name="costs"> Metadata for retrieving price info of a lab services SKUs. </param>
        /// <param name="restrictions"> Restrictions of a lab services SKUs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableLabServicesSku(string resourceType, string name, AvailableLabServicesSkuTier? tier, string size, string family, AvailableLabServicesSkuCapacity capacity, IReadOnlyList<AvailableLabServicesSkuCapability> capabilities, IReadOnlyList<AzureLocation> locations, IReadOnlyList<AvailableLabServicesSkuCost> costs, IReadOnlyList<AvailableLabServicesSkuRestrictions> restrictions, Dictionary<string, BinaryData> rawData)
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            Capabilities = capabilities;
            Locations = locations;
            Costs = costs;
            Restrictions = restrictions;
            _rawData = rawData;
        }

        /// <summary> The lab services resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The name of the SKU. </summary>
        public string Name { get; }
        /// <summary> The tier of the SKU. </summary>
        public AvailableLabServicesSkuTier? Tier { get; }
        /// <summary> The SKU size. </summary>
        public string Size { get; }
        /// <summary> The family of the SKU. </summary>
        public string Family { get; }
        /// <summary> The scale out/in options of the SKU. </summary>
        public AvailableLabServicesSkuCapacity Capacity { get; }
        /// <summary> The capabilities of the SKU. </summary>
        public IReadOnlyList<AvailableLabServicesSkuCapability> Capabilities { get; }
        /// <summary> List of locations that are available for a size. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Metadata for retrieving price info of a lab services SKUs. </summary>
        public IReadOnlyList<AvailableLabServicesSkuCost> Costs { get; }
        /// <summary> Restrictions of a lab services SKUs. </summary>
        public IReadOnlyList<AvailableLabServicesSkuRestrictions> Restrictions { get; }
    }
}
