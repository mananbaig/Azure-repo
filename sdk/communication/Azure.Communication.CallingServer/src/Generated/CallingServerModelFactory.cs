// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.CallingServer.Models;

namespace Azure.Communication.CallingServer
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class CallingServerModelFactory
    {
        /// <summary> Initializes a new instance of PlayAudioResult. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.PlayAudioResult"/> instance for mocking. </returns>
        public static PlayAudioResult PlayAudioResult(string operationId = null, CallingOperationStatus status = default, string operationContext = null, CallingOperationResultDetails resultDetails = null)
        {
            return new PlayAudioResult(operationId, status, operationContext, resultDetails);
        }

        /// <summary> Initializes a new instance of CallingOperationResultDetails. </summary>
        /// <param name="code"> The result code associated with the operation. </param>
        /// <param name="subcode"> The subcode that further classifies the result. </param>
        /// <param name="message"> The message is a detail explanation of subcode. </param>
        /// <returns> A new <see cref="CallingServer.CallingOperationResultDetails"/> instance for mocking. </returns>
        public static CallingOperationResultDetails CallingOperationResultDetails(int code = default, int subcode = default, string message = null)
        {
            return new CallingOperationResultDetails(code, subcode, message);
        }

        /// <summary> Initializes a new instance of TransferCallResult. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.TransferCallResult"/> instance for mocking. </returns>
        public static TransferCallResult TransferCallResult(string operationId = null, CallingOperationStatus status = default, string operationContext = null, CallingOperationResultDetails resultDetails = null)
        {
            return new TransferCallResult(operationId, status, operationContext, resultDetails);
        }

        /// <summary> Initializes a new instance of CreateAudioGroupResult. </summary>
        /// <param name="audioGroupId"> The audio group id. </param>
        /// <returns> A new <see cref="CallingServer.CreateAudioGroupResult"/> instance for mocking. </returns>
        public static CreateAudioGroupResult CreateAudioGroupResult(string audioGroupId = null)
        {
            return new CreateAudioGroupResult(audioGroupId);
        }

        /// <summary> Initializes a new instance of AddParticipantResult. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultDetails"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.AddParticipantResult"/> instance for mocking. </returns>
        public static AddParticipantResult AddParticipantResult(string operationId = null, CallingOperationStatus status = default, string operationContext = null, CallingOperationResultDetails resultDetails = null)
        {
            return new AddParticipantResult(operationId, status, operationContext, resultDetails);
        }

        /// <summary> Initializes a new instance of StartCallRecordingResult. </summary>
        /// <param name="recordingId"> The recording id of the started recording. </param>
        /// <returns> A new <see cref="CallingServer.StartCallRecordingResult"/> instance for mocking. </returns>
        public static StartCallRecordingResult StartCallRecordingResult(string recordingId = null)
        {
            return new StartCallRecordingResult(recordingId);
        }

        /// <summary> Initializes a new instance of CallRecordingProperties. </summary>
        /// <param name="recordingState"> The state of the recording. </param>
        /// <returns> A new <see cref="CallingServer.CallRecordingProperties"/> instance for mocking. </returns>
        public static CallRecordingProperties CallRecordingProperties(CallRecordingState recordingState = default)
        {
            return new CallRecordingProperties(recordingState);
        }

        /// <summary> Initializes a new instance of AnswerCallResult. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <returns> A new <see cref="CallingServer.AnswerCallResult"/> instance for mocking. </returns>
        public static AnswerCallResult AnswerCallResult(string callConnectionId = null)
        {
            return new AnswerCallResult(callConnectionId);
        }

        /// <summary> Initializes a new instance of CallConnectionStateChangedEvent. </summary>
        /// <param name="callLocator"> The server call locator. </param>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <returns> A new <see cref="CallingServer.CallConnectionStateChangedEvent"/> instance for mocking. </returns>
        public static CallConnectionStateChangedEvent CallConnectionStateChangedEvent(CallLocatorModel callLocator = null, string callConnectionId = null, CallConnectionState callConnectionState = default)
        {
            return new CallConnectionStateChangedEvent(callLocator, callConnectionId, callConnectionState);
        }

        /// <summary> Initializes a new instance of CallRecordingStateChangeEvent. </summary>
        /// <param name="recordingId"> The call recording id. </param>
        /// <param name="callRecordingState"> The state of the recording. </param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        /// <param name="callLocator"> The server call locator. </param>
        /// <returns> A new <see cref="CallingServer.CallRecordingStateChangeEvent"/> instance for mocking. </returns>
        public static CallRecordingStateChangeEvent CallRecordingStateChangeEvent(string recordingId = null, CallRecordingState callRecordingState = default, DateTimeOffset startDateTime = default, CallLocatorModel callLocator = null)
        {
            return new CallRecordingStateChangeEvent(recordingId, callRecordingState, startDateTime, callLocator);
        }

        /// <summary> Initializes a new instance of AddParticipantResultEvent. </summary>
        /// <param name="resultDetails"> The result details. </param>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="callLocator"> The server call locator. </param>
        /// <returns> A new <see cref="CallingServer.AddParticipantResultEvent"/> instance for mocking. </returns>
        public static AddParticipantResultEvent AddParticipantResultEvent(CallingOperationResultDetails resultDetails = null, string operationId = null, string operationContext = null, CallingOperationStatus status = default, CallLocatorModel callLocator = null)
        {
            return new AddParticipantResultEvent(resultDetails, operationId, operationContext, status, callLocator);
        }

        /// <summary> Initializes a new instance of PlayAudioResultEvent. </summary>
        /// <param name="resultDetails"> The result details. </param>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="callLocator"> The server call locator. </param>
        /// <returns> A new <see cref="CallingServer.PlayAudioResultEvent"/> instance for mocking. </returns>
        public static PlayAudioResultEvent PlayAudioResultEvent(CallingOperationResultDetails resultDetails = null, string operationId = null, string operationContext = null, CallingOperationStatus status = default, CallLocatorModel callLocator = null)
        {
            return new PlayAudioResultEvent(resultDetails, operationId, operationContext, status, callLocator);
        }

        /// <summary> Initializes a new instance of ToneReceivedEvent. </summary>
        /// <param name="toneInfo"> The tone info. </param>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="callLocator"> The server call locator. </param>
        /// <returns> A new <see cref="CallingServer.ToneReceivedEvent"/> instance for mocking. </returns>
        public static ToneReceivedEvent ToneReceivedEvent(ToneInfo toneInfo = null, string callConnectionId = null, CallLocatorModel callLocator = null)
        {
            return new ToneReceivedEvent(toneInfo, callConnectionId, callLocator);
        }

        /// <summary> Initializes a new instance of ToneInfo. </summary>
        /// <param name="sequenceId"> The sequence id which can be used to determine if the same tone was played multiple times or if any tones were missed. </param>
        /// <param name="tone"> The tone value. </param>
        /// <returns> A new <see cref="Models.ToneInfo"/> instance for mocking. </returns>
        public static ToneInfo ToneInfo(int sequenceId = default, ToneValue tone = default)
        {
            return new ToneInfo(sequenceId, tone);
        }
    }
}
