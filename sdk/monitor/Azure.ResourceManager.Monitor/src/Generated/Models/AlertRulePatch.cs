// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The alert rule object for patch operations. </summary>
    public partial class AlertRulePatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AlertRulePatch"/>. </summary>
        public AlertRulePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Actions = new ChangeTrackingList<AlertRuleAction>();
        }

        /// <summary> Initializes a new instance of <see cref="AlertRulePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="name"> the name of the alert rule. </param>
        /// <param name="description"> the description of the alert rule that will be included in the alert email. </param>
        /// <param name="provisioningState"> the provisioning state. </param>
        /// <param name="isEnabled"> the flag that indicates whether the alert rule is enabled. </param>
        /// <param name="condition">
        /// the condition that results in the alert rule being activated.
        /// Please note <see cref="AlertRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/> and <see cref="ThresholdRuleCondition"/>.
        /// </param>
        /// <param name="action">
        /// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="AlertRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </param>
        /// <param name="actions">
        /// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="AlertRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </param>
        /// <param name="lastUpdatedOn"> Last time the rule was updated in ISO8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertRulePatch(IDictionary<string, string> tags, string name, string description, string provisioningState, bool? isEnabled, AlertRuleCondition condition, AlertRuleAction action, IList<AlertRuleAction> actions, DateTimeOffset? lastUpdatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Name = name;
            Description = description;
            ProvisioningState = provisioningState;
            IsEnabled = isEnabled;
            Condition = condition;
            Action = action;
            Actions = actions;
            LastUpdatedOn = lastUpdatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> the name of the alert rule. </summary>
        public string Name { get; set; }
        /// <summary> the description of the alert rule that will be included in the alert email. </summary>
        public string Description { get; set; }
        /// <summary> the provisioning state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> the flag that indicates whether the alert rule is enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// the condition that results in the alert rule being activated.
        /// Please note <see cref="AlertRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/> and <see cref="ThresholdRuleCondition"/>.
        /// </summary>
        public AlertRuleCondition Condition { get; set; }
        /// <summary>
        /// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="AlertRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </summary>
        public AlertRuleAction Action { get; set; }
        /// <summary>
        /// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="AlertRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </summary>
        public IList<AlertRuleAction> Actions { get; }
        /// <summary> Last time the rule was updated in ISO8601 format. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
