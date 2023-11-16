// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of get all plan data Operation. </summary>
    internal partial class NewRelicPlanDataListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDataListResult"/>. </summary>
        /// <param name="value"> The PlanDataResource items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal NewRelicPlanDataListResult(IEnumerable<NewRelicPlanData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDataListResult"/>. </summary>
        /// <param name="value"> The PlanDataResource items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicPlanDataListResult(IReadOnlyList<NewRelicPlanData> value, Uri nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDataListResult"/> for deserialization. </summary>
        internal NewRelicPlanDataListResult()
        {
        }

        /// <summary> The PlanDataResource items on this page. </summary>
        public IReadOnlyList<NewRelicPlanData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
