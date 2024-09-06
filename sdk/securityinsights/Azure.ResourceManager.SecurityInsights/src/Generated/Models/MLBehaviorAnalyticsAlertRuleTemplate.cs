// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Represents MLBehaviorAnalytics alert rule template.
    /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate
    /// </summary>
    public partial class MLBehaviorAnalyticsAlertRuleTemplate : SecurityInsightsAlertRuleTemplateData
    {
        /// <summary> Initializes a new instance of <see cref="MLBehaviorAnalyticsAlertRuleTemplate"/>. </summary>
        public MLBehaviorAnalyticsAlertRuleTemplate()
        {
            RequiredDataConnectors = new ChangeTrackingList<AlertRuleTemplateDataSource>();
            Tactics = new ChangeTrackingList<SecurityInsightsAttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            Kind = AlertRuleKind.MLBehaviorAnalytics;
        }

        /// <summary> Initializes a new instance of <see cref="MLBehaviorAnalyticsAlertRuleTemplate"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind">
        /// The kind of the alert rule
        /// Serialized Name: AlertRuleTemplate.kind
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="alertRulesCreatedByTemplateCount">
        /// the number of alert rules that were created by this template
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.alertRulesCreatedByTemplateCount
        /// </param>
        /// <param name="lastUpdatedOn">
        /// The last time that this alert rule template has been updated.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.lastUpdatedDateUTC
        /// </param>
        /// <param name="createdOn">
        /// The time that this alert rule template has been added.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.createdDateUTC
        /// </param>
        /// <param name="description">
        /// The description of the alert rule template.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.description
        /// </param>
        /// <param name="displayName">
        /// The display name for alert rule template.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.displayName
        /// </param>
        /// <param name="requiredDataConnectors">
        /// The required data sources for this template
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.requiredDataConnectors
        /// </param>
        /// <param name="status">
        /// The alert rule template status.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.status
        /// </param>
        /// <param name="tactics">
        /// The tactics of the alert rule
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.tactics
        /// </param>
        /// <param name="techniques">
        /// The techniques of the alert rule
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.techniques
        /// </param>
        /// <param name="severity">
        /// The severity for alerts created by this alert rule.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.severity
        /// </param>
        internal MLBehaviorAnalyticsAlertRuleTemplate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, int? alertRulesCreatedByTemplateCount, DateTimeOffset? lastUpdatedOn, DateTimeOffset? createdOn, string description, string displayName, IList<AlertRuleTemplateDataSource> requiredDataConnectors, SecurityInsightsAlertRuleTemplateStatus? status, IList<SecurityInsightsAttackTactic> tactics, IList<string> techniques, SecurityInsightsAlertSeverity? severity) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            LastUpdatedOn = lastUpdatedOn;
            CreatedOn = createdOn;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            Tactics = tactics;
            Techniques = techniques;
            Severity = severity;
            Kind = kind;
        }

        /// <summary>
        /// the number of alert rules that were created by this template
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.alertRulesCreatedByTemplateCount
        /// </summary>
        public int? AlertRulesCreatedByTemplateCount { get; set; }
        /// <summary>
        /// The last time that this alert rule template has been updated.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.lastUpdatedDateUTC
        /// </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary>
        /// The time that this alert rule template has been added.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.createdDateUTC
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// The description of the alert rule template.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The display name for alert rule template.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.displayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The required data sources for this template
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.requiredDataConnectors
        /// </summary>
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; }
        /// <summary>
        /// The alert rule template status.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.status
        /// </summary>
        public SecurityInsightsAlertRuleTemplateStatus? Status { get; set; }
        /// <summary>
        /// The tactics of the alert rule
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.tactics
        /// </summary>
        public IList<SecurityInsightsAttackTactic> Tactics { get; }
        /// <summary>
        /// The techniques of the alert rule
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.techniques
        /// </summary>
        public IList<string> Techniques { get; }
        /// <summary>
        /// The severity for alerts created by this alert rule.
        /// Serialized Name: MLBehaviorAnalyticsAlertRuleTemplate.properties.severity
        /// </summary>
        public SecurityInsightsAlertSeverity? Severity { get; set; }
    }
}
