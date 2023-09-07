// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for data flow expression preview. </summary>
    public partial class DataFlowDebugCommandRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandRequest"/>. </summary>
        public DataFlowDebugCommandRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandRequest"/>. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="command"> The command type. </param>
        /// <param name="commandPayload"> The command payload object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFlowDebugCommandRequest(string sessionId, DataFlowDebugCommandType? command, DataFlowDebugCommandPayload commandPayload, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SessionId = sessionId;
            Command = command;
            CommandPayload = commandPayload;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; set; }
        /// <summary> The command type. </summary>
        public DataFlowDebugCommandType? Command { get; set; }
        /// <summary> The command payload object. </summary>
        public DataFlowDebugCommandPayload CommandPayload { get; set; }
    }
}
