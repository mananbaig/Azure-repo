// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Workflow model collection. </summary>
    internal partial class DataReplicationWorkflowListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataReplicationWorkflowListResult"/>. </summary>
        internal DataReplicationWorkflowListResult()
        {
            Value = new ChangeTrackingList<DataReplicationWorkflowData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationWorkflowListResult"/>. </summary>
        /// <param name="value"> Gets or sets the list of workflows. </param>
        /// <param name="nextLink"> Gets or sets the value of next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationWorkflowListResult(IReadOnlyList<DataReplicationWorkflowData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the list of workflows. </summary>
        public IReadOnlyList<DataReplicationWorkflowData> Value { get; }
        /// <summary> Gets or sets the value of next link. </summary>
        public string NextLink { get; }
    }
}
