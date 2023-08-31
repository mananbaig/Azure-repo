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
    internal partial class DatadogMonitorResourceListResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatadogMonitorResourceListResponse"/>. </summary>
        internal DatadogMonitorResourceListResponse()
        {
            Value = new ChangeTrackingList<DatadogMonitorResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatadogMonitorResourceListResponse"/>. </summary>
        /// <param name="value"> Results of a list operation. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatadogMonitorResourceListResponse(IReadOnlyList<DatadogMonitorResourceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Results of a list operation. </summary>
        public IReadOnlyList<DatadogMonitorResourceData> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
