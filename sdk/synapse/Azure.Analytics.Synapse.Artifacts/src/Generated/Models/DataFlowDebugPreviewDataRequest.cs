// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for data flow preview data. </summary>
    public partial class DataFlowDebugPreviewDataRequest
    {
        /// <summary> Initializes a new instance of DataFlowDebugPreviewDataRequest. </summary>
        public DataFlowDebugPreviewDataRequest()
        {
        }

        /// <summary> Initializes a new instance of DataFlowDebugPreviewDataRequest. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="dataFlowName"> The data flow which contains the debug session. </param>
        /// <param name="streamName"> The output stream name. </param>
        /// <param name="rowLimits"> The row limit for preview request. </param>
        internal DataFlowDebugPreviewDataRequest(string sessionId, string dataFlowName, string streamName, int? rowLimits)
        {
            SessionId = sessionId;
            DataFlowName = dataFlowName;
            StreamName = streamName;
            RowLimits = rowLimits;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> The data flow which contains the debug session. </summary>
        public string DataFlowName { get; set; }
        /// <summary> The output stream name. </summary>
        public string StreamName { get; set; }
        /// <summary> The row limit for preview request. </summary>
        public int? RowLimits { get; set; }
    }
}
