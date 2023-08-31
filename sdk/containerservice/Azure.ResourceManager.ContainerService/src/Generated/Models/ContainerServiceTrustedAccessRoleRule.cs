// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Rule for trusted access role. </summary>
    public partial class ContainerServiceTrustedAccessRoleRule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleRule"/>. </summary>
        internal ContainerServiceTrustedAccessRoleRule()
        {
            Verbs = new ChangeTrackingList<string>();
            ApiGroups = new ChangeTrackingList<string>();
            Resources = new ChangeTrackingList<string>();
            ResourceNames = new ChangeTrackingList<string>();
            NonResourceUrls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleRule"/>. </summary>
        /// <param name="verbs"> List of allowed verbs. </param>
        /// <param name="apiGroups"> List of allowed apiGroups. </param>
        /// <param name="resources"> List of allowed resources. </param>
        /// <param name="resourceNames"> List of allowed names. </param>
        /// <param name="nonResourceUrls"> List of allowed nonResourceURLs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceTrustedAccessRoleRule(IReadOnlyList<string> verbs, IReadOnlyList<string> apiGroups, IReadOnlyList<string> resources, IReadOnlyList<string> resourceNames, IReadOnlyList<string> nonResourceUrls, Dictionary<string, BinaryData> rawData)
        {
            Verbs = verbs;
            ApiGroups = apiGroups;
            Resources = resources;
            ResourceNames = resourceNames;
            NonResourceUrls = nonResourceUrls;
            _rawData = rawData;
        }

        /// <summary> List of allowed verbs. </summary>
        public IReadOnlyList<string> Verbs { get; }
        /// <summary> List of allowed apiGroups. </summary>
        public IReadOnlyList<string> ApiGroups { get; }
        /// <summary> List of allowed resources. </summary>
        public IReadOnlyList<string> Resources { get; }
        /// <summary> List of allowed names. </summary>
        public IReadOnlyList<string> ResourceNames { get; }
        /// <summary> List of allowed nonResourceURLs. </summary>
        public IReadOnlyList<string> NonResourceUrls { get; }
    }
}
