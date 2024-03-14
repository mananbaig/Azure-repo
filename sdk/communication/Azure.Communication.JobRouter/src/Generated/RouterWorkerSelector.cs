// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a condition that must be met against a set of labels for worker selection. </summary>
    public partial class RouterWorkerSelector
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

        /// <summary> Initializes a new instance of <see cref="RouterWorkerSelector"/>. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value defined on the worker selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public RouterWorkerSelector(string key, LabelOperator labelOperator)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            LabelOperator = labelOperator;
        }

        /// <summary> Initializes a new instance of <see cref="RouterWorkerSelector"/>. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value defined on the worker selector. </param>
        /// <param name="value"> The value to compare against the actual label value with the given operator. Values must be primitive values - number, string, boolean. </param>
        /// <param name="expiresAfter"> Describes how long this label selector is valid in seconds. </param>
        /// <param name="expedite"> Pushes a job to the front of the queue as long as this selector is active. </param>
        /// <param name="status"> Status of the worker selector. </param>
        /// <param name="expiresAt"> The time at which this worker selector expires in UTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterWorkerSelector(string key, LabelOperator labelOperator, BinaryData value, TimeSpan? expiresAfter, bool? expedite, RouterWorkerSelectorStatus? status, DateTimeOffset? expiresAt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            LabelOperator = labelOperator;
            _value = value;
            ExpiresAfter = expiresAfter;
            Expedite = expedite;
            Status = status;
            ExpiresAt = expiresAt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RouterWorkerSelector"/> for deserialization. </summary>
        internal RouterWorkerSelector()
        {
        }

        /// <summary> The label key to query against. </summary>
        public string Key { get; set; }
        /// <summary> Describes how the value of the label is compared to the value defined on the worker selector. </summary>
        public LabelOperator LabelOperator { get; set; }
        /// <summary> Status of the worker selector. </summary>
        public RouterWorkerSelectorStatus? Status { get; }
        /// <summary> The time at which this worker selector expires in UTC. </summary>
        public DateTimeOffset? ExpiresAt { get; }
    }
}
