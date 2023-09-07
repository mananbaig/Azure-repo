// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Response body structure for creating data flow debug session. </summary>
    public partial class CreateDataFlowDebugSessionResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateDataFlowDebugSessionResponse"/>. </summary>
        internal CreateDataFlowDebugSessionResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CreateDataFlowDebugSessionResponse"/>. </summary>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateDataFlowDebugSessionResponse(string sessionId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SessionId = sessionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of data flow debug session. </summary>
        public string SessionId { get; }
    }
}
