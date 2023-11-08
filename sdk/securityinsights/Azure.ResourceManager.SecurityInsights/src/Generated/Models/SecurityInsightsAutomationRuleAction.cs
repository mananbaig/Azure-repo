// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// Describes an automation rule action.
    /// Please note <see cref="SecurityInsightsAutomationRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AutomationRuleModifyPropertiesAction"/> and <see cref="AutomationRuleRunPlaybookAction"/>.
    /// </summary>
    public abstract partial class SecurityInsightsAutomationRuleAction
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAutomationRuleAction"/>. </summary>
        /// <param name="order"></param>
        protected SecurityInsightsAutomationRuleAction(int order)
        {
            Order = order;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAutomationRuleAction"/>. </summary>
        /// <param name="order"></param>
        /// <param name="actionType"> The type of the automation rule action. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsAutomationRuleAction(int order, ActionType actionType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Order = order;
            ActionType = actionType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAutomationRuleAction"/> for deserialization. </summary>
        internal SecurityInsightsAutomationRuleAction()
        {
        }

        /// <summary> Gets or sets the order. </summary>
        public int Order { get; set; }
        /// <summary> The type of the automation rule action. </summary>
        internal ActionType ActionType { get; set; }
    }
}
