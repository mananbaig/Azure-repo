// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Response schema. Contains list of tables returned. </summary>
    internal partial class ListTableResource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListTableResource"/>. </summary>
        internal ListTableResource()
        {
            Value = new ChangeTrackingList<TableData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListTableResource"/>. </summary>
        /// <param name="value"> List of tables returned. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of tables. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListTableResource(IReadOnlyList<TableData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of tables returned. </summary>
        public IReadOnlyList<TableData> Value { get; }
        /// <summary> Request URL that can be used to query next page of tables. </summary>
        public string NextLink { get; }
    }
}
