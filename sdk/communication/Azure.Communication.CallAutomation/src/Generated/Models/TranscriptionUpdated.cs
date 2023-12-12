// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TranscriptionUpdated. </summary>
    public partial class TranscriptionUpdated
    {
        /// <summary> Initializes a new instance of <see cref="TranscriptionUpdated"/>. </summary>
        internal TranscriptionUpdated()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TranscriptionUpdated"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="transcriptionUpdate"> Defines the result for TranscriptionUpdate with the current status and the details about the status. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal TranscriptionUpdated(string operationContext, ResultInformation resultInformation, TranscriptionUpdate transcriptionUpdate, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            TranscriptionUpdate = transcriptionUpdate;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }
        /// <summary> Defines the result for TranscriptionUpdate with the current status and the details about the status. </summary>
        public TranscriptionUpdate TranscriptionUpdate { get; }
    }
}
