// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of IoT Security solution aggregated alert data. </summary>
    internal partial class IotSecurityAggregatedAlertList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotSecurityAggregatedAlertList"/>. </summary>
        /// <param name="value"> List of aggregated alerts data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IotSecurityAggregatedAlertList(IEnumerable<IotSecurityAggregatedAlertData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IotSecurityAggregatedAlertList"/>. </summary>
        /// <param name="value"> List of aggregated alerts data. </param>
        /// <param name="nextLink"> When there is too much alert data for one page, use this URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotSecurityAggregatedAlertList(IReadOnlyList<IotSecurityAggregatedAlertData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotSecurityAggregatedAlertList"/> for deserialization. </summary>
        internal IotSecurityAggregatedAlertList()
        {
        }

        /// <summary> List of aggregated alerts data. </summary>
        public IReadOnlyList<IotSecurityAggregatedAlertData> Value { get; }
        /// <summary> When there is too much alert data for one page, use this URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
