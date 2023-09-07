// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The IotSecuritySolutionPatch. </summary>
    public partial class IotSecuritySolutionPatch : SecurityCenterTagsResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionPatch"/>. </summary>
        public IotSecuritySolutionPatch()
        {
            RecommendationsConfiguration = new ChangeTrackingList<RecommendationConfigurationProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="IotSecuritySolutionPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="userDefinedResources"> Properties of the IoT Security solution's user defined resources. </param>
        /// <param name="recommendationsConfiguration"> List of the configuration status for each recommendation type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecuritySolutionPatch(IDictionary<string, string> tags, UserDefinedResourcesProperties userDefinedResources, IList<RecommendationConfigurationProperties> recommendationsConfiguration, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(tags, serializedAdditionalRawData)
        {
            UserDefinedResources = userDefinedResources;
            RecommendationsConfiguration = recommendationsConfiguration;
        }

        /// <summary> Properties of the IoT Security solution's user defined resources. </summary>
        public UserDefinedResourcesProperties UserDefinedResources { get; set; }
        /// <summary> List of the configuration status for each recommendation type. </summary>
        public IList<RecommendationConfigurationProperties> RecommendationsConfiguration { get; }
    }
}
