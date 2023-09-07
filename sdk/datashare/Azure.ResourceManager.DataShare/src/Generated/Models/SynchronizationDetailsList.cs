// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> details of synchronization. </summary>
    internal partial class SynchronizationDetailsList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetailsList"/>. </summary>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SynchronizationDetailsList(IEnumerable<SynchronizationDetails> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetailsList"/>. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynchronizationDetailsList(string nextLink, IReadOnlyList<SynchronizationDetails> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetailsList"/> for deserialization. </summary>
        internal SynchronizationDetailsList()
        {
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary> Collection of items of type DataTransferObjects. </summary>
        public IReadOnlyList<SynchronizationDetails> Value { get; }
    }
}
