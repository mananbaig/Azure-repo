// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> Play started event. </summary>
    public partial class PlayStarted
    {
        /// <summary> Initializes a new instance of <see cref="PlayStarted"/>. </summary>
        internal PlayStarted()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PlayStarted"/>. </summary>
        /// <param name="callConnectionId"> Gets or sets call connection ID. </param>
        /// <param name="serverCallId"> Gets or sets server call ID. </param>
        /// <param name="correlationId"> Gets or sets correlation ID for event to call correlation. </param>
        /// <param name="operationContext"> Gets or sets used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Gets or sets contains the resulting SIP code, sub-code and message. </param>
        internal PlayStarted(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
        }
    }
}
