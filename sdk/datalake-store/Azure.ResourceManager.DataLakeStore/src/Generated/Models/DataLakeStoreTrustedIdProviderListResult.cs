// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Data Lake Store trusted identity provider list information. </summary>
    internal partial class DataLakeStoreTrustedIdProviderListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderListResult"/>. </summary>
        internal DataLakeStoreTrustedIdProviderListResult()
        {
            Value = new ChangeTrackingList<DataLakeStoreTrustedIdProviderData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderListResult"/>. </summary>
        /// <param name="value"> The results of the list operation. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreTrustedIdProviderListResult(IReadOnlyList<DataLakeStoreTrustedIdProviderData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The results of the list operation. </summary>
        public IReadOnlyList<DataLakeStoreTrustedIdProviderData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
