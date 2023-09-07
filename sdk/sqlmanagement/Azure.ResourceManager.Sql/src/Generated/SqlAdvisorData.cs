// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlAdvisor data model.
    /// Database, Server or Elastic Pool Advisor.
    /// </summary>
    public partial class SqlAdvisorData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlAdvisorData"/>. </summary>
        public SqlAdvisorData()
        {
            RecommendedActions = new ChangeTrackingList<RecommendedActionData>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlAdvisorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Resource kind. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="advisorStatus"> Gets the status of availability of this advisor to customers. Possible values are 'GA', 'PublicPreview', 'LimitedPublicPreview' and 'PrivatePreview'. </param>
        /// <param name="autoExecuteStatus"> Gets the auto-execute status (whether to let the system execute the recommendations) of this advisor. Possible values are 'Enabled' and 'Disabled'. </param>
        /// <param name="autoExecuteStatusInheritedFrom"> Gets the resource from which current value of auto-execute status is inherited. Auto-execute status can be set on (and inherited from) different levels in the resource hierarchy. Possible values are 'Subscription', 'Server', 'ElasticPool', 'Database' and 'Default' (when status is not explicitly set on any level). </param>
        /// <param name="recommendationsStatus"> Gets that status of recommendations for this advisor and reason for not having any recommendations. Possible values include, but are not limited to, 'Ok' (Recommendations available),LowActivity (not enough workload to analyze), 'DbSeemsTuned' (Database is doing well), etc. </param>
        /// <param name="lastCheckedOn"> Gets the time when the current resource was analyzed for recommendations by this advisor. </param>
        /// <param name="recommendedActions"> Gets the recommended actions for this advisor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlAdvisorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, AzureLocation? location, SqlAdvisorStatus? advisorStatus, AutoExecuteStatus? autoExecuteStatus, AutoExecuteStatusInheritedFrom? autoExecuteStatusInheritedFrom, string recommendationsStatus, DateTimeOffset? lastCheckedOn, IReadOnlyList<RecommendedActionData> recommendedActions, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Location = location;
            AdvisorStatus = advisorStatus;
            AutoExecuteStatus = autoExecuteStatus;
            AutoExecuteStatusInheritedFrom = autoExecuteStatusInheritedFrom;
            RecommendationsStatus = recommendationsStatus;
            LastCheckedOn = lastCheckedOn;
            RecommendedActions = recommendedActions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource kind. </summary>
        public string Kind { get; }
        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Gets the status of availability of this advisor to customers. Possible values are 'GA', 'PublicPreview', 'LimitedPublicPreview' and 'PrivatePreview'. </summary>
        public SqlAdvisorStatus? AdvisorStatus { get; }
        /// <summary> Gets the auto-execute status (whether to let the system execute the recommendations) of this advisor. Possible values are 'Enabled' and 'Disabled'. </summary>
        public AutoExecuteStatus? AutoExecuteStatus { get; set; }
        /// <summary> Gets the resource from which current value of auto-execute status is inherited. Auto-execute status can be set on (and inherited from) different levels in the resource hierarchy. Possible values are 'Subscription', 'Server', 'ElasticPool', 'Database' and 'Default' (when status is not explicitly set on any level). </summary>
        public AutoExecuteStatusInheritedFrom? AutoExecuteStatusInheritedFrom { get; }
        /// <summary> Gets that status of recommendations for this advisor and reason for not having any recommendations. Possible values include, but are not limited to, 'Ok' (Recommendations available),LowActivity (not enough workload to analyze), 'DbSeemsTuned' (Database is doing well), etc. </summary>
        public string RecommendationsStatus { get; }
        /// <summary> Gets the time when the current resource was analyzed for recommendations by this advisor. </summary>
        public DateTimeOffset? LastCheckedOn { get; }
        /// <summary> Gets the recommended actions for this advisor. </summary>
        public IReadOnlyList<RecommendedActionData> RecommendedActions { get; }
    }
}
