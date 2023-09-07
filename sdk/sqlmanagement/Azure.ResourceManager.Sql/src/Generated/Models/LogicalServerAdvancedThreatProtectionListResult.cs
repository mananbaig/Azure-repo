// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of the server's Advanced Threat Protection configurations. </summary>
    internal partial class LogicalServerAdvancedThreatProtectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LogicalServerAdvancedThreatProtectionListResult"/>. </summary>
        internal LogicalServerAdvancedThreatProtectionListResult()
        {
            Value = new ChangeTrackingList<ServerAdvancedThreatProtectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicalServerAdvancedThreatProtectionListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicalServerAdvancedThreatProtectionListResult(IReadOnlyList<ServerAdvancedThreatProtectionData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerAdvancedThreatProtectionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
