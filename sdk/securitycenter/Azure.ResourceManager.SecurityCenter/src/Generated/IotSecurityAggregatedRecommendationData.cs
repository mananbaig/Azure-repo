// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the IotSecurityAggregatedRecommendation data model.
    /// IoT Security solution recommendation information.
    /// </summary>
    public partial class IotSecurityAggregatedRecommendationData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotSecurityAggregatedRecommendationData"/>. </summary>
        public IotSecurityAggregatedRecommendationData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="IotSecurityAggregatedRecommendationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="recommendationName"> Name of the recommendation. </param>
        /// <param name="recommendationDisplayName"> Display name of the recommendation type. </param>
        /// <param name="description"> Description of the suspected vulnerability and meaning. </param>
        /// <param name="recommendationTypeId"> Recommendation-type GUID. </param>
        /// <param name="detectedBy"> Name of the organization that made the recommendation. </param>
        /// <param name="remediationSteps"> Recommended steps for remediation. </param>
        /// <param name="reportedSeverity"> Assessed recommendation severity. </param>
        /// <param name="healthyDevices"> Number of healthy devices within the IoT Security solution. </param>
        /// <param name="unhealthyDeviceCount"> Number of unhealthy devices within the IoT Security solution. </param>
        /// <param name="logAnalyticsQuery"> Log analytics query for getting the list of affected devices/alerts. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecurityAggregatedRecommendationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string recommendationName, string recommendationDisplayName, string description, string recommendationTypeId, string detectedBy, string remediationSteps, ReportedSeverity? reportedSeverity, long? healthyDevices, long? unhealthyDeviceCount, string logAnalyticsQuery, IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            RecommendationName = recommendationName;
            RecommendationDisplayName = recommendationDisplayName;
            Description = description;
            RecommendationTypeId = recommendationTypeId;
            DetectedBy = detectedBy;
            RemediationSteps = remediationSteps;
            ReportedSeverity = reportedSeverity;
            HealthyDevices = healthyDevices;
            UnhealthyDeviceCount = unhealthyDeviceCount;
            LogAnalyticsQuery = logAnalyticsQuery;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the recommendation. </summary>
        public string RecommendationName { get; set; }
        /// <summary> Display name of the recommendation type. </summary>
        public string RecommendationDisplayName { get; }
        /// <summary> Description of the suspected vulnerability and meaning. </summary>
        public string Description { get; }
        /// <summary> Recommendation-type GUID. </summary>
        public string RecommendationTypeId { get; }
        /// <summary> Name of the organization that made the recommendation. </summary>
        public string DetectedBy { get; }
        /// <summary> Recommended steps for remediation. </summary>
        public string RemediationSteps { get; }
        /// <summary> Assessed recommendation severity. </summary>
        public ReportedSeverity? ReportedSeverity { get; }
        /// <summary> Number of healthy devices within the IoT Security solution. </summary>
        public long? HealthyDevices { get; }
        /// <summary> Number of unhealthy devices within the IoT Security solution. </summary>
        public long? UnhealthyDeviceCount { get; }
        /// <summary> Log analytics query for getting the list of affected devices/alerts. </summary>
        public string LogAnalyticsQuery { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
