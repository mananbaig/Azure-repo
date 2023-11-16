// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Capability for the PostgreSQL server. </summary>
    internal partial class PostgreSqlFlexibleServerCapabilitiesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerCapabilitiesListResult"/>. </summary>
        internal PostgreSqlFlexibleServerCapabilitiesListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerCapabilityProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerCapabilitiesListResult"/>. </summary>
        /// <param name="value"> A list of supported capabilities. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerCapabilitiesListResult(IReadOnlyList<PostgreSqlFlexibleServerCapabilityProperties> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of supported capabilities. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerCapabilityProperties> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
