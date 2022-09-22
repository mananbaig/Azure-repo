// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The type of IoT Security recommendation. </summary>
    public partial class RecommendationConfigurationProperties
    {
        /// <summary> Initializes a new instance of RecommendationConfigurationProperties. </summary>
        /// <param name="recommendationType"> The type of IoT Security recommendation. </param>
        /// <param name="status"> Recommendation status. When the recommendation status is disabled recommendations are not generated. </param>
        public RecommendationConfigurationProperties(RecommendationType recommendationType, RecommendationConfigStatus status)
        {
            RecommendationType = recommendationType;
            Status = status;
        }

        /// <summary> Initializes a new instance of RecommendationConfigurationProperties. </summary>
        /// <param name="recommendationType"> The type of IoT Security recommendation. </param>
        /// <param name="name"></param>
        /// <param name="status"> Recommendation status. When the recommendation status is disabled recommendations are not generated. </param>
        internal RecommendationConfigurationProperties(RecommendationType recommendationType, string name, RecommendationConfigStatus status)
        {
            RecommendationType = recommendationType;
            Name = name;
            Status = status;
        }

        /// <summary> The type of IoT Security recommendation. </summary>
        public RecommendationType RecommendationType { get; set; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Recommendation status. When the recommendation status is disabled recommendations are not generated. </summary>
        public RecommendationConfigStatus Status { get; set; }
    }
}
