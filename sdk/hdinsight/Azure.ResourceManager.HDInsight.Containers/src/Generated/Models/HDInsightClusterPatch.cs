// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The patch for a cluster. </summary>
    public partial class HDInsightClusterPatch : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public HDInsightClusterPatch(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="clusterProfile"> Cluster resource patch properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, UpdatableClusterProfile clusterProfile, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ClusterProfile = clusterProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPatch"/> for deserialization. </summary>
        internal HDInsightClusterPatch()
        {
        }

        /// <summary> Cluster resource patch properties. </summary>
        public UpdatableClusterProfile ClusterProfile { get; set; }
    }
}
