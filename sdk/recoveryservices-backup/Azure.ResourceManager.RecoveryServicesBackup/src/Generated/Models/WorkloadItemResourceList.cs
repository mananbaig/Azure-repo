// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> List of WorkloadItem resources. </summary>
    internal partial class WorkloadItemResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadItemResourceList"/>. </summary>
        internal WorkloadItemResourceList()
        {
            Value = new ChangeTrackingList<WorkloadItemResource>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadItemResourceList"/>. </summary>
        /// <param name="value"> List of resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadItemResourceList(IReadOnlyList<WorkloadItemResource> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<WorkloadItemResource> Value { get; }
        /// <summary> The uri to fetch the next page of resources. </summary>
        public string NextLink { get; }
    }
}
