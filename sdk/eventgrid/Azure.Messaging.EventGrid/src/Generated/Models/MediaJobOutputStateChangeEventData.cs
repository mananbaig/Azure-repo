// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Media.JobOutputStateChange event. </summary>
    public partial class MediaJobOutputStateChangeEventData
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

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputStateChangeEventData"/>. </summary>
        internal MediaJobOutputStateChangeEventData()
        {
            JobCorrelationData = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputStateChangeEventData"/>. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output">
        /// Gets the output.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobOutputStateChangeEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PreviousState = previousState;
            Output = output;
            JobCorrelationData = jobCorrelationData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The previous state of the Job. </summary>
        public MediaJobState? PreviousState { get; }
        /// <summary>
        /// Gets the output.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </summary>
        public MediaJobOutput Output { get; }
        /// <summary> Gets the Job correlation data. </summary>
        public IReadOnlyDictionary<string, string> JobCorrelationData { get; }
    }
}
