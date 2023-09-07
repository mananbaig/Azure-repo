// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A collection of endpoints that the managed instance service requires outbound network access to. </summary>
    internal partial class SqlOutboundEnvironmentEndpointCollection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlOutboundEnvironmentEndpointCollection"/>. </summary>
        internal SqlOutboundEnvironmentEndpointCollection()
        {
            Value = new ChangeTrackingList<SqlOutboundEnvironmentEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlOutboundEnvironmentEndpointCollection"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlOutboundEnvironmentEndpointCollection(IReadOnlyList<SqlOutboundEnvironmentEndpoint> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlOutboundEnvironmentEndpoint> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
