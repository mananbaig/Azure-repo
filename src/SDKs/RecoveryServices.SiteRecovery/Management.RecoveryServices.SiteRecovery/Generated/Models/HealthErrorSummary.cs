// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// class to define the summary of the health error details.
    /// </summary>
    public partial class HealthErrorSummary
    {
        /// <summary>
        /// Initializes a new instance of the HealthErrorSummary class.
        /// </summary>
        public HealthErrorSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HealthErrorSummary class.
        /// </summary>
        /// <param name="summaryCode">The code of the health error.</param>
        /// <param name="category">The category of the health error. Possible
        /// values include: 'None', 'Replication', 'TestFailover',
        /// 'Configuration', 'FabricInfrastructure', 'VersionExpiry',
        /// 'AgentAutoUpdate'</param>
        /// <param name="severity">Severity of error. Possible values include:
        /// 'NONE', 'Warning', 'Error', 'Info'</param>
        /// <param name="summaryMessage">The summary message of the health
        /// error.</param>
        /// <param name="affectedResourceType">The type of affected ARM
        /// resource.</param>
        /// <param name="affectedResourceSubtype">The sub type of any
        /// subcomponent within the ARM resource that this might be applicable.
        /// Value remains null if not applicable.</param>
        /// <param name="affectedResourceCorrelationIds">The list of affected
        /// resource correlation Ids. This can be used to uniquely identify the
        /// count of items affected by a specific category and severity as well
        /// as count of item affected by an specific issue.</param>
        public HealthErrorSummary(string summaryCode = default(string), string category = default(string), string severity = default(string), string summaryMessage = default(string), string affectedResourceType = default(string), string affectedResourceSubtype = default(string), IList<string> affectedResourceCorrelationIds = default(IList<string>))
        {
            SummaryCode = summaryCode;
            Category = category;
            Severity = severity;
            SummaryMessage = summaryMessage;
            AffectedResourceType = affectedResourceType;
            AffectedResourceSubtype = affectedResourceSubtype;
            AffectedResourceCorrelationIds = affectedResourceCorrelationIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the code of the health error.
        /// </summary>
        [JsonProperty(PropertyName = "summaryCode")]
        public string SummaryCode { get; set; }

        /// <summary>
        /// Gets or sets the category of the health error. Possible values
        /// include: 'None', 'Replication', 'TestFailover', 'Configuration',
        /// 'FabricInfrastructure', 'VersionExpiry', 'AgentAutoUpdate'
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets severity of error. Possible values include: 'NONE',
        /// 'Warning', 'Error', 'Info'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the summary message of the health error.
        /// </summary>
        [JsonProperty(PropertyName = "summaryMessage")]
        public string SummaryMessage { get; set; }

        /// <summary>
        /// Gets or sets the type of affected ARM resource.
        /// </summary>
        [JsonProperty(PropertyName = "affectedResourceType")]
        public string AffectedResourceType { get; set; }

        /// <summary>
        /// Gets or sets the sub type of any subcomponent within the ARM
        /// resource that this might be applicable. Value remains null if not
        /// applicable.
        /// </summary>
        [JsonProperty(PropertyName = "affectedResourceSubtype")]
        public string AffectedResourceSubtype { get; set; }

        /// <summary>
        /// Gets or sets the list of affected resource correlation Ids. This
        /// can be used to uniquely identify the count of items affected by a
        /// specific category and severity as well as count of item affected by
        /// an specific issue.
        /// </summary>
        [JsonProperty(PropertyName = "affectedResourceCorrelationIds")]
        public IList<string> AffectedResourceCorrelationIds { get; set; }

    }
}
