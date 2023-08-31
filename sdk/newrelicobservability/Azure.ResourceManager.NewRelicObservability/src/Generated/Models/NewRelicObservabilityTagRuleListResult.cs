// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.NewRelicObservability;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> The response of a TagRule list operation. </summary>
    internal partial class NewRelicObservabilityTagRuleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRuleListResult"/>. </summary>
        /// <param name="value"> The TagRule items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal NewRelicObservabilityTagRuleListResult(IEnumerable<NewRelicObservabilityTagRuleData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRuleListResult"/>. </summary>
        /// <param name="value"> The TagRule items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityTagRuleListResult(IReadOnlyList<NewRelicObservabilityTagRuleData> value, Uri nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRuleListResult"/> for deserialization. </summary>
        internal NewRelicObservabilityTagRuleListResult()
        {
        }

        /// <summary> The TagRule items on this page. </summary>
        public IReadOnlyList<NewRelicObservabilityTagRuleData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
