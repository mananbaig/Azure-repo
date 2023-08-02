// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Matched rule. </summary>
    public partial class MatchedRule
    {
        /// <summary> Initializes a new instance of MatchedRule. </summary>
        internal MatchedRule()
        {
        }

        /// <summary> Initializes a new instance of MatchedRule. </summary>
        /// <param name="ruleName"> Name of the matched network security rule. </param>
        /// <param name="action"> The network traffic is allowed or denied. Possible values are 'Allow' and 'Deny'. </param>
        internal MatchedRule(string ruleName, string action)
        {
            RuleName = ruleName;
            Action = action;
        }

        /// <summary> Name of the matched network security rule. </summary>
        public string RuleName { get; }
        /// <summary> The network traffic is allowed or denied. Possible values are 'Allow' and 'Deny'. </summary>
        public string Action { get; }
    }
}
