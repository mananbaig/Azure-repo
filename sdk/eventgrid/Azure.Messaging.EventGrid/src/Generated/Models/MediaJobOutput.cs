// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary>
    /// The event data for a Job output.
    /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
    /// </summary>
    public partial class MediaJobOutput
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
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaJobOutput"/>. </summary>
        /// <param name="progress"> Gets the Job output progress. </param>
        /// <param name="state"> Gets the Job output state. </param>
        internal MediaJobOutput(long progress, MediaJobState state)
        {
            Progress = progress;
            State = state;
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutput"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="error"> Gets the Job output error. </param>
        /// <param name="label"> Gets the Job output label. </param>
        /// <param name="progress"> Gets the Job output progress. </param>
        /// <param name="state"> Gets the Job output state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobOutput(string odataType, MediaJobError error, string label, long progress, MediaJobState state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            Error = error;
            Label = label;
            Progress = progress;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutput"/> for deserialization. </summary>
        internal MediaJobOutput()
        {
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> Gets the Job output error. </summary>
        public MediaJobError Error { get; }
        /// <summary> Gets the Job output label. </summary>
        public string Label { get; }
        /// <summary> Gets the Job output progress. </summary>
        public long Progress { get; }
        /// <summary> Gets the Job output state. </summary>
        public MediaJobState State { get; }
    }
}
