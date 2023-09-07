// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Contains a list of match conditions, and an action on how to modify the request/response. If multiple rules match, the actions from one rule that conflict with a previous rule overwrite for a singular action, or append in the case of headers manipulation. </summary>
    public partial class RulesEngineRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RulesEngineRule"/>. </summary>
        /// <param name="name"> A name to refer to this specific rule. </param>
        /// <param name="priority"> A priority assigned to this rule. </param>
        /// <param name="action"> Actions to perform on the request and response if all of the match conditions are met. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="action"/> is null. </exception>
        public RulesEngineRule(string name, int priority, RulesEngineAction action)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(action, nameof(action));

            Name = name;
            Priority = priority;
            Action = action;
            MatchConditions = new ChangeTrackingList<RulesEngineMatchCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineRule"/>. </summary>
        /// <param name="name"> A name to refer to this specific rule. </param>
        /// <param name="priority"> A priority assigned to this rule. </param>
        /// <param name="action"> Actions to perform on the request and response if all of the match conditions are met. </param>
        /// <param name="matchConditions"> A list of match conditions that must meet in order for the actions of this rule to run. Having no match conditions means the actions will always run. </param>
        /// <param name="matchProcessingBehavior"> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RulesEngineRule(string name, int priority, RulesEngineAction action, IList<RulesEngineMatchCondition> matchConditions, MatchProcessingBehavior? matchProcessingBehavior, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Priority = priority;
            Action = action;
            MatchConditions = matchConditions;
            MatchProcessingBehavior = matchProcessingBehavior;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RulesEngineRule"/> for deserialization. </summary>
        internal RulesEngineRule()
        {
        }

        /// <summary> A name to refer to this specific rule. </summary>
        public string Name { get; set; }
        /// <summary> A priority assigned to this rule. </summary>
        public int Priority { get; set; }
        /// <summary> Actions to perform on the request and response if all of the match conditions are met. </summary>
        public RulesEngineAction Action { get; set; }
        /// <summary> A list of match conditions that must meet in order for the actions of this rule to run. Having no match conditions means the actions will always run. </summary>
        public IList<RulesEngineMatchCondition> MatchConditions { get; set; }
        /// <summary> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </summary>
        public MatchProcessingBehavior? MatchProcessingBehavior { get; set; }
    }
}
