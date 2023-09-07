// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents MicrosoftSecurityIncidentCreation rule. </summary>
    public partial class MicrosoftSecurityIncidentCreationAlertRule : SecurityInsightsAlertRuleData
    {
        /// <summary> Initializes a new instance of <see cref="MicrosoftSecurityIncidentCreationAlertRule"/>. </summary>
        public MicrosoftSecurityIncidentCreationAlertRule()
        {
            DisplayNamesFilter = new ChangeTrackingList<string>();
            DisplayNamesExcludeFilter = new ChangeTrackingList<string>();
            SeveritiesFilter = new ChangeTrackingList<SecurityInsightsAlertSeverity>();
            Kind = AlertRuleKind.MicrosoftSecurityIncidentCreation;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftSecurityIncidentCreationAlertRule"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The alert rule kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="displayNamesFilter"> the alerts' displayNames on which the cases will be generated. </param>
        /// <param name="displayNamesExcludeFilter"> the alerts' displayNames on which the cases will not be generated. </param>
        /// <param name="productFilter"> The alerts' productName on which the cases will be generated. </param>
        /// <param name="severitiesFilter"> the alerts' severities on which the cases will be generated. </param>
        /// <param name="alertRuleTemplateName"> The Name of the alert rule template used to create this rule. </param>
        /// <param name="description"> The description of the alert rule. </param>
        /// <param name="displayName"> The display name for alerts created by this alert rule. </param>
        /// <param name="isEnabled"> Determines whether this alert rule is enabled or disabled. </param>
        /// <param name="lastModifiedOn"> The last time that this alert has been modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MicrosoftSecurityIncidentCreationAlertRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag, IList<string> displayNamesFilter, IList<string> displayNamesExcludeFilter, MicrosoftSecurityProductName? productFilter, IList<SecurityInsightsAlertSeverity> severitiesFilter, string alertRuleTemplateName, string description, string displayName, bool? isEnabled, DateTimeOffset? lastModifiedOn, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            DisplayNamesFilter = displayNamesFilter;
            DisplayNamesExcludeFilter = displayNamesExcludeFilter;
            ProductFilter = productFilter;
            SeveritiesFilter = severitiesFilter;
            AlertRuleTemplateName = alertRuleTemplateName;
            Description = description;
            DisplayName = displayName;
            IsEnabled = isEnabled;
            LastModifiedOn = lastModifiedOn;
            Kind = kind;
        }

        /// <summary> the alerts' displayNames on which the cases will be generated. </summary>
        public IList<string> DisplayNamesFilter { get; }
        /// <summary> the alerts' displayNames on which the cases will not be generated. </summary>
        public IList<string> DisplayNamesExcludeFilter { get; }
        /// <summary> The alerts' productName on which the cases will be generated. </summary>
        public MicrosoftSecurityProductName? ProductFilter { get; set; }
        /// <summary> the alerts' severities on which the cases will be generated. </summary>
        public IList<SecurityInsightsAlertSeverity> SeveritiesFilter { get; }
        /// <summary> The Name of the alert rule template used to create this rule. </summary>
        public string AlertRuleTemplateName { get; set; }
        /// <summary> The description of the alert rule. </summary>
        public string Description { get; set; }
        /// <summary> The display name for alerts created by this alert rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> Determines whether this alert rule is enabled or disabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The last time that this alert has been modified. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
    }
}
