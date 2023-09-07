// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes an automation rule condition that evaluates a property's value change. </summary>
    public partial class SecurityInsightsPropertyChangedConditionProperties : SecurityInsightsAutomationRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsPropertyChangedConditionProperties"/>. </summary>
        public SecurityInsightsPropertyChangedConditionProperties()
        {
            ConditionType = ConditionType.PropertyChanged;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsPropertyChangedConditionProperties"/>. </summary>
        /// <param name="conditionType"></param>
        /// <param name="conditionProperties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsPropertyChangedConditionProperties(ConditionType conditionType, AutomationRulePropertyValuesChangedCondition conditionProperties, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(conditionType, serializedAdditionalRawData)
        {
            ConditionProperties = conditionProperties;
            ConditionType = conditionType;
        }

        /// <summary> Gets or sets the condition properties. </summary>
        public AutomationRulePropertyValuesChangedCondition ConditionProperties { get; set; }
    }
}
