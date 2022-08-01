// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Describes an available ApiManagement SKU. </summary>
    public partial class ApiManagementSku
    {
        /// <summary> Initializes a new instance of ApiManagementSku. </summary>
        internal ApiManagementSku()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            LocationInfo = new ChangeTrackingList<ApiManagementSkuLocationInfo>();
            ApiVersions = new ChangeTrackingList<string>();
            Costs = new ChangeTrackingList<ApiManagementSkuCosts>();
            Capabilities = new ChangeTrackingList<ApiManagementSkuCapabilities>();
            Restrictions = new ChangeTrackingList<ApiManagementSkuRestrictions>();
        }

        /// <summary> Initializes a new instance of ApiManagementSku. </summary>
        /// <param name="resourceType"> The type of resource the SKU applies to. </param>
        /// <param name="name"> The name of SKU. </param>
        /// <param name="tier"> Specifies the tier of virtual machines in a scale set.&lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt;&lt;br /&gt; **Standard**&lt;br /&gt;&lt;br /&gt; **Basic**. </param>
        /// <param name="size"> The Size of the SKU. </param>
        /// <param name="family"> The Family of this particular SKU. </param>
        /// <param name="kind"> The Kind of resources that are supported in this SKU. </param>
        /// <param name="capacity"> Specifies the number of virtual machines in the scale set. </param>
        /// <param name="locations"> The set of locations that the SKU is available. </param>
        /// <param name="locationInfo"> A list of locations and availability zones in those locations where the SKU is available. </param>
        /// <param name="apiVersions"> The api versions that support this SKU. </param>
        /// <param name="costs"> Metadata for retrieving price info. </param>
        /// <param name="capabilities"> A name value pair to describe the capability. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </param>
        internal ApiManagementSku(string resourceType, string name, string tier, string size, string family, string kind, ApiManagementSkuCapacity capacity, IReadOnlyList<AzureLocation> locations, IReadOnlyList<ApiManagementSkuLocationInfo> locationInfo, IReadOnlyList<string> apiVersions, IReadOnlyList<ApiManagementSkuCosts> costs, IReadOnlyList<ApiManagementSkuCapabilities> capabilities, IReadOnlyList<ApiManagementSkuRestrictions> restrictions)
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Kind = kind;
            Capacity = capacity;
            Locations = locations;
            LocationInfo = locationInfo;
            ApiVersions = apiVersions;
            Costs = costs;
            Capabilities = capabilities;
            Restrictions = restrictions;
        }

        /// <summary> The type of resource the SKU applies to. </summary>
        public string ResourceType { get; }
        /// <summary> The name of SKU. </summary>
        public string Name { get; }
        /// <summary> Specifies the tier of virtual machines in a scale set.&lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt;&lt;br /&gt; **Standard**&lt;br /&gt;&lt;br /&gt; **Basic**. </summary>
        public string Tier { get; }
        /// <summary> The Size of the SKU. </summary>
        public string Size { get; }
        /// <summary> The Family of this particular SKU. </summary>
        public string Family { get; }
        /// <summary> The Kind of resources that are supported in this SKU. </summary>
        public string Kind { get; }
        /// <summary> Specifies the number of virtual machines in the scale set. </summary>
        public ApiManagementSkuCapacity Capacity { get; }
        /// <summary> The set of locations that the SKU is available. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> A list of locations and availability zones in those locations where the SKU is available. </summary>
        public IReadOnlyList<ApiManagementSkuLocationInfo> LocationInfo { get; }
        /// <summary> The api versions that support this SKU. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> Metadata for retrieving price info. </summary>
        public IReadOnlyList<ApiManagementSkuCosts> Costs { get; }
        /// <summary> A name value pair to describe the capability. </summary>
        public IReadOnlyList<ApiManagementSkuCapabilities> Capabilities { get; }
        /// <summary> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </summary>
        public IReadOnlyList<ApiManagementSkuRestrictions> Restrictions { get; }
    }
}
