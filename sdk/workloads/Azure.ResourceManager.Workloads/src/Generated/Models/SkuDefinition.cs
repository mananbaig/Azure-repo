// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SKU definition. </summary>
    public partial class SkuDefinition
    {
        /// <summary> Initializes a new instance of <see cref="SkuDefinition"/>. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal SkuDefinition(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Locations = new ChangeTrackingList<AzureLocation>();
            LocationInfo = new ChangeTrackingList<SkuLocationAndZones>();
            Costs = new ChangeTrackingList<SkuCost>();
            Capabilities = new ChangeTrackingList<SkuCapability>();
            Restrictions = new ChangeTrackingList<SkuRestriction>();
        }

        /// <summary> Initializes a new instance of <see cref="SkuDefinition"/>. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="resourceType"> Resource type the SKU applicable for. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        /// <param name="size"> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="kind"> If the service has different kinds of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="locations"> List of locations where this SKU is available. </param>
        /// <param name="locationInfo"> List of locations where this SKU is available. </param>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        /// <param name="costs"> The SKU costs. </param>
        /// <param name="capabilities"> The SKU capabilities. </param>
        /// <param name="restrictions"> The SKU restrictions. </param>
        internal SkuDefinition(string name, string resourceType, string tier, string size, string family, string kind, IReadOnlyList<AzureLocation> locations, IReadOnlyList<SkuLocationAndZones> locationInfo, BinaryData capacity, IReadOnlyList<SkuCost> costs, IReadOnlyList<SkuCapability> capabilities, IReadOnlyList<SkuRestriction> restrictions)
        {
            Name = name;
            ResourceType = resourceType;
            Tier = tier;
            Size = size;
            Family = family;
            Kind = kind;
            Locations = locations;
            LocationInfo = locationInfo;
            Capacity = capacity;
            Costs = costs;
            Capabilities = capabilities;
            Restrictions = restrictions;
        }

        /// <summary> The name of the SKU. </summary>
        public string Name { get; }
        /// <summary> Resource type the SKU applicable for. </summary>
        public string ResourceType { get; }
        /// <summary> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </summary>
        public string Tier { get; }
        /// <summary> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </summary>
        public string Size { get; }
        /// <summary> If the service has different generations of hardware, for the same SKU, then that can be captured here. </summary>
        public string Family { get; }
        /// <summary> If the service has different kinds of hardware, for the same SKU, then that can be captured here. </summary>
        public string Kind { get; }
        /// <summary> List of locations where this SKU is available. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> List of locations where this SKU is available. </summary>
        public IReadOnlyList<SkuLocationAndZones> LocationInfo { get; }
        /// <summary> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </summary>
        public BinaryData Capacity { get; }
        /// <summary> The SKU costs. </summary>
        public IReadOnlyList<SkuCost> Costs { get; }
        /// <summary> The SKU capabilities. </summary>
        public IReadOnlyList<SkuCapability> Capabilities { get; }
        /// <summary> The SKU restrictions. </summary>
        public IReadOnlyList<SkuRestriction> Restrictions { get; }
    }
}
