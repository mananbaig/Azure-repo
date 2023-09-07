// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> Org onboarding info. </summary>
    public partial class AzureDevOpsOrgMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsOrgMetadata"/>. </summary>
        public AzureDevOpsOrgMetadata()
        {
            Projects = new ChangeTrackingList<AzureDevOpsProjectMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsOrgMetadata"/>. </summary>
        /// <param name="name"> Gets or sets name of the AzureDevOps Org. </param>
        /// <param name="autoDiscovery"></param>
        /// <param name="projects"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureDevOpsOrgMetadata(string name, AutoDiscovery? autoDiscovery, IList<AzureDevOpsProjectMetadata> projects, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AutoDiscovery = autoDiscovery;
            Projects = projects;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets name of the AzureDevOps Org. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the auto discovery. </summary>
        public AutoDiscovery? AutoDiscovery { get; set; }
        /// <summary> Gets the projects. </summary>
        public IList<AzureDevOpsProjectMetadata> Projects { get; }
    }
}
