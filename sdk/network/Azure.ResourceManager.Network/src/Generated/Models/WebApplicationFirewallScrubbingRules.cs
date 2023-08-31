// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow certain variables to be scrubbed on WAF logs. </summary>
    public partial class WebApplicationFirewallScrubbingRules
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallScrubbingRules"/>. </summary>
        /// <param name="matchVariable"> The variable to be scrubbed from the logs. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this rule applies to. </param>
        public WebApplicationFirewallScrubbingRules(ScrubbingRuleEntryMatchVariable matchVariable, ScrubbingRuleEntryMatchOperator selectorMatchOperator)
        {
            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallScrubbingRules"/>. </summary>
        /// <param name="matchVariable"> The variable to be scrubbed from the logs. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this rule applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to. </param>
        /// <param name="state"> Defines the state of log scrubbing rule. Default value is Enabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebApplicationFirewallScrubbingRules(ScrubbingRuleEntryMatchVariable matchVariable, ScrubbingRuleEntryMatchOperator selectorMatchOperator, string selector, ScrubbingRuleEntryState? state, Dictionary<string, BinaryData> rawData)
        {
            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
            State = state;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallScrubbingRules"/> for deserialization. </summary>
        internal WebApplicationFirewallScrubbingRules()
        {
        }

        /// <summary> The variable to be scrubbed from the logs. </summary>
        public ScrubbingRuleEntryMatchVariable MatchVariable { get; set; }
        /// <summary> When matchVariable is a collection, operate on the selector to specify which elements in the collection this rule applies to. </summary>
        public ScrubbingRuleEntryMatchOperator SelectorMatchOperator { get; set; }
        /// <summary> When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to. </summary>
        public string Selector { get; set; }
        /// <summary> Defines the state of log scrubbing rule. Default value is Enabled. </summary>
        public ScrubbingRuleEntryState? State { get; set; }
    }
}
