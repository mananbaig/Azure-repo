// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The Sku information. </summary>
    public partial class AvailableDataBoxEdgeSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailableDataBoxEdgeSku"/>. </summary>
        internal AvailableDataBoxEdgeSku()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            ApiVersions = new ChangeTrackingList<string>();
            LocationInfo = new ChangeTrackingList<DataBoxEdgeSkuLocationInfo>();
            Costs = new ChangeTrackingList<DataBoxEdgeSkuCost>();
            ShipmentTypes = new ChangeTrackingList<DataBoxEdgeShipmentType>();
            Capabilities = new ChangeTrackingList<DataBoxEdgeSkuCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableDataBoxEdgeSku"/>. </summary>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="name"> The Sku name. </param>
        /// <param name="kind"> The Sku kind. </param>
        /// <param name="tier"> The Sku tier. </param>
        /// <param name="size"> The Sku kind. </param>
        /// <param name="family"> The Sku family. </param>
        /// <param name="locations"> Availability of the Sku for the region. </param>
        /// <param name="apiVersions"> The API versions in which Sku is available. </param>
        /// <param name="locationInfo"> Availability of the Sku for the location/zone/site. </param>
        /// <param name="costs"> The pricing info of the Sku. </param>
        /// <param name="signupOption"> Sku can be signed up by customer or not. </param>
        /// <param name="version"> Availability of the Sku as preview/stable. </param>
        /// <param name="availability"> Links to the next set of results. </param>
        /// <param name="shipmentTypes"> List of Shipment Types supported by this SKU. </param>
        /// <param name="capabilities"> The capability info of the SKU. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableDataBoxEdgeSku(string resourceType, DataBoxEdgeSkuName? name, string kind, DataBoxEdgeSkuTier? tier, string size, string family, IReadOnlyList<AzureLocation> locations, IReadOnlyList<string> apiVersions, IReadOnlyList<DataBoxEdgeSkuLocationInfo> locationInfo, IReadOnlyList<DataBoxEdgeSkuCost> costs, DataBoxEdgeSkuSignupOption? signupOption, DataBoxEdgeSkuVersion? version, DataBoxEdgeSkuAvailability? availability, IReadOnlyList<DataBoxEdgeShipmentType> shipmentTypes, IReadOnlyList<DataBoxEdgeSkuCapability> capabilities, Dictionary<string, BinaryData> rawData)
        {
            ResourceType = resourceType;
            Name = name;
            Kind = kind;
            Tier = tier;
            Size = size;
            Family = family;
            Locations = locations;
            ApiVersions = apiVersions;
            LocationInfo = locationInfo;
            Costs = costs;
            SignupOption = signupOption;
            Version = version;
            Availability = availability;
            ShipmentTypes = shipmentTypes;
            Capabilities = capabilities;
            _rawData = rawData;
        }

        /// <summary> The type of the resource. </summary>
        public string ResourceType { get; }
        /// <summary> The Sku name. </summary>
        public DataBoxEdgeSkuName? Name { get; }
        /// <summary> The Sku kind. </summary>
        public string Kind { get; }
        /// <summary> The Sku tier. </summary>
        public DataBoxEdgeSkuTier? Tier { get; }
        /// <summary> The Sku kind. </summary>
        public string Size { get; }
        /// <summary> The Sku family. </summary>
        public string Family { get; }
        /// <summary> Availability of the Sku for the region. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> The API versions in which Sku is available. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> Availability of the Sku for the location/zone/site. </summary>
        public IReadOnlyList<DataBoxEdgeSkuLocationInfo> LocationInfo { get; }
        /// <summary> The pricing info of the Sku. </summary>
        public IReadOnlyList<DataBoxEdgeSkuCost> Costs { get; }
        /// <summary> Sku can be signed up by customer or not. </summary>
        public DataBoxEdgeSkuSignupOption? SignupOption { get; }
        /// <summary> Availability of the Sku as preview/stable. </summary>
        public DataBoxEdgeSkuVersion? Version { get; }
        /// <summary> Links to the next set of results. </summary>
        public DataBoxEdgeSkuAvailability? Availability { get; }
        /// <summary> List of Shipment Types supported by this SKU. </summary>
        public IReadOnlyList<DataBoxEdgeShipmentType> ShipmentTypes { get; }
        /// <summary> The capability info of the SKU. </summary>
        public IReadOnlyList<DataBoxEdgeSkuCapability> Capabilities { get; }
    }
}
