// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> The response from the list namespace operation. </summary>
    internal partial class RelayNamespaceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RelayNamespaceListResult"/>. </summary>
        internal RelayNamespaceListResult()
        {
            Value = new ChangeTrackingList<RelayNamespaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="RelayNamespaceListResult"/>. </summary>
        /// <param name="value"> Result of the list namespace operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if value contains incomplete list of namespaces. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelayNamespaceListResult(IReadOnlyList<RelayNamespaceData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result of the list namespace operation. </summary>
        public IReadOnlyList<RelayNamespaceData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if value contains incomplete list of namespaces. </summary>
        public string NextLink { get; }
    }
}
