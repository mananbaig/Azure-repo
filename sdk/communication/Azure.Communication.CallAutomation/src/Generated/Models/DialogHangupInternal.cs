// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogHangup. </summary>
    internal partial class DialogHangupInternal
    {
        /// <summary> Initializes a new instance of <see cref="DialogHangupInternal"/>. </summary>
        internal DialogHangupInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DialogHangupInternal"/>. </summary>
        /// <param name="operationContext"> Used by customers when calling answerCall action to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="dialogInputType"> Determines the type of the dialog. </param>
        /// <param name="dialogId"> Dialog ID. </param>
        /// <param name="ivrContext"> Ivr Context. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal DialogHangupInternal(string operationContext, ResultInformation resultInformation, DialogInputType? dialogInputType, string dialogId, object ivrContext, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            DialogInputType = dialogInputType;
            DialogId = dialogId;
            IvrContext = ivrContext;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }

        /// <summary> Used by customers when calling answerCall action to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType? DialogInputType { get; }
        /// <summary> Dialog ID. </summary>
        public string DialogId { get; }
        /// <summary> Ivr Context. </summary>
        public object IvrContext { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
