// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for data flow statistics. </summary>
    public partial class DataFlowDebugStatisticsRequest
    {
        /// <summary> Initializes a new instance of DataFlowDebugStatisticsRequest. </summary>
        public DataFlowDebugStatisticsRequest()
        {
            Columns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DataFlowDebugStatisticsRequest. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="dataFlowName"> The data flow which contains the debug session. </param>
        /// <param name="streamName"> The output stream name. </param>
        /// <param name="columns"> List of column names. </param>
        internal DataFlowDebugStatisticsRequest(string sessionId, string dataFlowName, string streamName, IList<string> columns)
        {
            SessionId = sessionId;
            DataFlowName = dataFlowName;
            StreamName = streamName;
            Columns = columns;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> The data flow which contains the debug session. </summary>
        public string DataFlowName { get; set; }
        /// <summary> The output stream name. </summary>
        public string StreamName { get; set; }
        /// <summary> List of column names. </summary>
        public IList<string> Columns { get; }
    }
}
