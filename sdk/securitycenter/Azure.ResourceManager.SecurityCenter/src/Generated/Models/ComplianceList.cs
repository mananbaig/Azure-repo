// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of Compliance objects response. </summary>
    internal partial class ComplianceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComplianceList"/>. </summary>
        internal ComplianceList()
        {
            Value = new ChangeTrackingList<SecurityComplianceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ComplianceList"/>. </summary>
        /// <param name="value"> List of Compliance objects. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComplianceList(IReadOnlyList<SecurityComplianceData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Compliance objects. </summary>
        public IReadOnlyList<SecurityComplianceData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
