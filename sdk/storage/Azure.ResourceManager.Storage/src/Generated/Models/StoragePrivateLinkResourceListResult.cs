// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class StoragePrivateLinkResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StoragePrivateLinkResourceListResult"/>. </summary>
        internal StoragePrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<StoragePrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="StoragePrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePrivateLinkResourceListResult(IReadOnlyList<StoragePrivateLinkResourceData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<StoragePrivateLinkResourceData> Value { get; }
    }
}
