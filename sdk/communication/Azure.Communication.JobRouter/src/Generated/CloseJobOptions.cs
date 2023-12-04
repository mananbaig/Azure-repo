// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Request payload for closing jobs. </summary>
    public partial class CloseJobOptions
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

        /// <summary> Initializes a new instance of <see cref="CloseJobOptions"/>. </summary>
        /// <param name="dispositionCode"> Indicates the outcome of a job, populate this field with your own custom values. </param>
        /// <param name="closeAt"> If not provided, worker capacity is released immediately along with a JobClosedEvent notification. If provided, worker capacity is released along with a JobClosedEvent notification at a future time in UTC. </param>
        /// <param name="note"> A note that will be appended to a job's Notes collection with the current timestamp. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloseJobOptions(string dispositionCode, DateTimeOffset closeAt, string note, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DispositionCode = dispositionCode;
            CloseAt = closeAt;
            Note = note;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
