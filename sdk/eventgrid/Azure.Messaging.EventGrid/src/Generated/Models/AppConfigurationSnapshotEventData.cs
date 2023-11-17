// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of snapshot events. </summary>
    public partial class AppConfigurationSnapshotEventData
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

        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotEventData"/>. </summary>
        internal AppConfigurationSnapshotEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotEventData"/>. </summary>
        /// <param name="name"> The name of the snapshot. </param>
        /// <param name="eTag"> The etag representing the new state of the snapshot. </param>
        /// <param name="syncToken"> The sync token representing the server state after the event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationSnapshotEventData(string name, string eTag, string syncToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ETag = eTag;
            SyncToken = syncToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the snapshot. </summary>
        public string Name { get; }
        /// <summary> The sync token representing the server state after the event. </summary>
        public string SyncToken { get; }
    }
}
