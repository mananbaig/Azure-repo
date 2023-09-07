// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster monitoring status response. </summary>
    public partial class HDInsightClusterExtensionStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterExtensionStatus"/>. </summary>
        internal HDInsightClusterExtensionStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterExtensionStatus"/>. </summary>
        /// <param name="isClusterMonitoringEnabled"> The status of the monitor on the HDInsight cluster. </param>
        /// <param name="workspaceId"> The workspace ID of the monitor on the HDInsight cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterExtensionStatus(bool? isClusterMonitoringEnabled, string workspaceId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsClusterMonitoringEnabled = isClusterMonitoringEnabled;
            WorkspaceId = workspaceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the monitor on the HDInsight cluster. </summary>
        public bool? IsClusterMonitoringEnabled { get; }
        /// <summary> The workspace ID of the monitor on the HDInsight cluster. </summary>
        public string WorkspaceId { get; }
    }
}
