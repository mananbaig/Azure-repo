// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageMover;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> List of Job Runs. </summary>
    internal partial class JobRunList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="JobRunList"/>. </summary>
        internal JobRunList()
        {
            Value = new ChangeTrackingList<JobRunData>();
        }

        /// <summary> Initializes a new instance of <see cref="JobRunList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed maximum page size. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JobRunList(IReadOnlyList<JobRunData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<JobRunData> Value { get; }
        /// <summary> Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
