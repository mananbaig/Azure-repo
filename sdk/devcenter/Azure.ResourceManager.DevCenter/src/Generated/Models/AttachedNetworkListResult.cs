// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Results of the Attached Networks list operation. </summary>
    internal partial class AttachedNetworkListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AttachedNetworkListResult"/>. </summary>
        internal AttachedNetworkListResult()
        {
            Value = new ChangeTrackingList<AttachedNetworkConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="AttachedNetworkListResult"/>. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttachedNetworkListResult(IReadOnlyList<AttachedNetworkConnectionData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<AttachedNetworkConnectionData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
