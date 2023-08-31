// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB PhysicalPartitionThroughputInfoResult object. </summary>
    public partial class PhysicalPartitionThroughputInfoResult : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoResult"/>. </summary>
        /// <param name="location"> The location. </param>
        public PhysicalPartitionThroughputInfoResult(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> properties of physical partition throughput info. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhysicalPartitionThroughputInfoResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, PhysicalPartitionThroughputInfoResultPropertiesResource resource, ManagedServiceIdentity identity, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoResult"/> for deserialization. </summary>
        internal PhysicalPartitionThroughputInfoResult()
        {
        }

        /// <summary> properties of physical partition throughput info. </summary>
        internal PhysicalPartitionThroughputInfoResultPropertiesResource Resource { get; set; }
        /// <summary> Array of physical partition throughput info objects. </summary>
        public IList<PhysicalPartitionThroughputInfoResource> ResourcePhysicalPartitionThroughputInfo
        {
            get
            {
                if (Resource is null)
                    Resource = new PhysicalPartitionThroughputInfoResultPropertiesResource();
                return Resource.PhysicalPartitionThroughputInfo;
            }
        }

        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
