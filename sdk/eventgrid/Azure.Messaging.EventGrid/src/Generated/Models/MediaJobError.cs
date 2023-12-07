// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Details of JobOutput errors. </summary>
    public partial class MediaJobError
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaJobError"/>. </summary>
        internal MediaJobError()
        {
            Details = new ChangeTrackingList<MediaJobErrorDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobError"/>. </summary>
        /// <param name="code"> Error code describing the error. </param>
        /// <param name="message"> A human-readable language-dependent representation of the error. </param>
        /// <param name="category"> Helps with categorization of errors. </param>
        /// <param name="retry"> Indicates that it may be possible to retry the Job. If retry is unsuccessful, please contact Azure support via Azure Portal. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobError(MediaJobErrorCode? code, string message, MediaJobErrorCategory? category, MediaJobRetry? retry, IReadOnlyList<MediaJobErrorDetail> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Category = category;
            Retry = retry;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Error code describing the error. </summary>
        public MediaJobErrorCode? Code { get; }
        /// <summary> A human-readable language-dependent representation of the error. </summary>
        public string Message { get; }
        /// <summary> Helps with categorization of errors. </summary>
        public MediaJobErrorCategory? Category { get; }
        /// <summary> Indicates that it may be possible to retry the Job. If retry is unsuccessful, please contact Azure support via Azure Portal. </summary>
        public MediaJobRetry? Retry { get; }
        /// <summary> An array of details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<MediaJobErrorDetail> Details { get; }
    }
}
