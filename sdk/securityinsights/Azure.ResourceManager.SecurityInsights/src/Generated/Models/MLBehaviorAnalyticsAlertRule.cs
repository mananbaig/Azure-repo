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
    /// <summary> Represents MLBehaviorAnalytics alert rule. </summary>
    public partial class MLBehaviorAnalyticsAlertRule : SecurityInsightsAlertRuleData
    {
        /// <summary> Initializes a new instance of <see cref="MLBehaviorAnalyticsAlertRule"/>. </summary>
        public MLBehaviorAnalyticsAlertRule()
        {
            Tactics = new ChangeTrackingList<SecurityInsightsAttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            SubTechniques = new ChangeTrackingList<string>();
            Kind = AlertRuleKind.MLBehaviorAnalytics;
        }

        /// <summary> Initializes a new instance of <see cref="MLBehaviorAnalyticsAlertRule"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="alertRuleTemplateName"> The Name of the alert rule template used to create this rule. </param>
        /// <param name="description"> The description of the alert rule. </param>
        /// <param name="displayName"> The display name for alerts created by this alert rule. </param>
        /// <param name="isEnabled"> Determines whether this alert rule is enabled or disabled. </param>
        /// <param name="lastModifiedOn"> The last time that this alert rule has been modified. </param>
        /// <param name="severity"> The severity for alerts created by this alert rule. </param>
        /// <param name="tactics"> The tactics of the alert rule. </param>
        /// <param name="techniques"> The techniques of the alert rule. </param>
        /// <param name="subTechniques"> The sub-techniques of the alert rule. </param>
        internal MLBehaviorAnalyticsAlertRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, string alertRuleTemplateName, string description, string displayName, bool? isEnabled, DateTimeOffset? lastModifiedOn, SecurityInsightsAlertSeverity? severity, IReadOnlyList<SecurityInsightsAttackTactic> tactics, IReadOnlyList<string> techniques, IReadOnlyList<string> subTechniques) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            AlertRuleTemplateName = alertRuleTemplateName;
            Description = description;
            DisplayName = displayName;
            IsEnabled = isEnabled;
            LastModifiedOn = lastModifiedOn;
            Severity = severity;
            Tactics = tactics;
            Techniques = techniques;
            SubTechniques = subTechniques;
            Kind = kind;
        }

        /// <summary> The Name of the alert rule template used to create this rule. </summary>
        [WirePath("properties.alertRuleTemplateName")]
        public string AlertRuleTemplateName { get; set; }
        /// <summary> The description of the alert rule. </summary>
        [WirePath("properties.description")]
        public string Description { get; }
        /// <summary> The display name for alerts created by this alert rule. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; }
        /// <summary> Determines whether this alert rule is enabled or disabled. </summary>
        [WirePath("properties.enabled")]
        public bool? IsEnabled { get; set; }
        /// <summary> The last time that this alert rule has been modified. </summary>
        [WirePath("properties.lastModifiedUtc")]
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The severity for alerts created by this alert rule. </summary>
        [WirePath("properties.severity")]
        public SecurityInsightsAlertSeverity? Severity { get; }
        /// <summary> The tactics of the alert rule. </summary>
        [WirePath("properties.tactics")]
        public IReadOnlyList<SecurityInsightsAttackTactic> Tactics { get; }
        /// <summary> The techniques of the alert rule. </summary>
        [WirePath("properties.techniques")]
        public IReadOnlyList<string> Techniques { get; }
        /// <summary> The sub-techniques of the alert rule. </summary>
        [WirePath("properties.subTechniques")]
        public IReadOnlyList<string> SubTechniques { get; }
    }
}
