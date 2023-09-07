// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents a resource's usage and quota. </summary>
    public partial class SearchResourceCounter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchResourceCounter"/>. </summary>
        /// <param name="usage"> The resource usage amount. </param>
        internal SearchResourceCounter(long usage)
        {
            Usage = usage;
        }

        /// <summary> Initializes a new instance of <see cref="SearchResourceCounter"/>. </summary>
        /// <param name="usage"> The resource usage amount. </param>
        /// <param name="quota"> The resource amount quota. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchResourceCounter(long usage, long? quota, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Usage = usage;
            Quota = quota;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SearchResourceCounter"/> for deserialization. </summary>
        internal SearchResourceCounter()
        {
        }

        /// <summary> The resource usage amount. </summary>
        public long Usage { get; }
        /// <summary> The resource amount quota. </summary>
        public long? Quota { get; }
    }
}
