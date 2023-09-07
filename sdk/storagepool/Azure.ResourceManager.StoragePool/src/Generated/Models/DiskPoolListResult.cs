// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> List of Disk Pools. </summary>
    internal partial class DiskPoolListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskPoolListResult"/>. </summary>
        /// <param name="value"> An array of Disk pool objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DiskPoolListResult(IEnumerable<DiskPoolData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolListResult"/>. </summary>
        /// <param name="value"> An array of Disk pool objects. </param>
        /// <param name="nextLink"> URI to fetch the next section of the paginated response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskPoolListResult(IReadOnlyList<DiskPoolData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolListResult"/> for deserialization. </summary>
        internal DiskPoolListResult()
        {
        }

        /// <summary> An array of Disk pool objects. </summary>
        public IReadOnlyList<DiskPoolData> Value { get; }
        /// <summary> URI to fetch the next section of the paginated response. </summary>
        public string NextLink { get; }
    }
}
