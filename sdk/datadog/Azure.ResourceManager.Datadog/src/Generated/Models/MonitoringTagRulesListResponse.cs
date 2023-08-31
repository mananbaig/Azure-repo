// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Datadog;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Response of a list operation. </summary>
    internal partial class MonitoringTagRulesListResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitoringTagRulesListResponse"/>. </summary>
        internal MonitoringTagRulesListResponse()
        {
            Value = new ChangeTrackingList<MonitoringTagRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringTagRulesListResponse"/>. </summary>
        /// <param name="value"> Results of a list operation. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoringTagRulesListResponse(IReadOnlyList<MonitoringTagRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Results of a list operation. </summary>
        public IReadOnlyList<MonitoringTagRuleData> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
