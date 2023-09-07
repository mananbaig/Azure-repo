// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing a list of supported Private Link Resources. </summary>
    internal partial class PrivateLinkResourcesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesResult"/>. </summary>
        internal PrivateLinkResourcesResult()
        {
            Value = new ChangeTrackingList<SearchPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkResourcesResult"/>. </summary>
        /// <param name="value"> The list of supported Private Link Resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkResourcesResult(IReadOnlyList<SearchPrivateLinkResource> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of supported Private Link Resources. </summary>
        public IReadOnlyList<SearchPrivateLinkResource> Value { get; }
    }
}
