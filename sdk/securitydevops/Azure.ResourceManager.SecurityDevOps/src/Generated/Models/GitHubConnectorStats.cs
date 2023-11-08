// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The GitHubConnectorStats. </summary>
    public partial class GitHubConnectorStats : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GitHubConnectorStats"/>. </summary>
        public GitHubConnectorStats()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubConnectorStats"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubConnectorStats(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, GitHubConnectorStatsProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the properties. </summary>
        public GitHubConnectorStatsProperties Properties { get; set; }
    }
}
