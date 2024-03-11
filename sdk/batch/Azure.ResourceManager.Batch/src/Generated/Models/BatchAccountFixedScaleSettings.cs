// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Fixed scale settings for the pool. </summary>
    public partial class BatchAccountFixedScaleSettings
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

        /// <summary> Initializes a new instance of <see cref="BatchAccountFixedScaleSettings"/>. </summary>
        public BatchAccountFixedScaleSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountFixedScaleSettings"/>. </summary>
        /// <param name="resizeTimeout"> The default value is 15 minutes. Timeout values use ISO 8601 format. For example, use PT10M for 10 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service rejects the request with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="targetDedicatedNodes"> At least one of targetDedicatedNodes, targetLowPriorityNodes must be set. </param>
        /// <param name="targetLowPriorityNodes"> At least one of targetDedicatedNodes, targetLowPriorityNodes must be set. </param>
        /// <param name="nodeDeallocationOption"> If omitted, the default value is Requeue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchAccountFixedScaleSettings(TimeSpan? resizeTimeout, int? targetDedicatedNodes, int? targetLowPriorityNodes, BatchNodeDeallocationOption? nodeDeallocationOption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResizeTimeout = resizeTimeout;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            NodeDeallocationOption = nodeDeallocationOption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The default value is 15 minutes. Timeout values use ISO 8601 format. For example, use PT10M for 10 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service rejects the request with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? ResizeTimeout { get; set; }
        /// <summary> At least one of targetDedicatedNodes, targetLowPriorityNodes must be set. </summary>
        public int? TargetDedicatedNodes { get; set; }
        /// <summary> At least one of targetDedicatedNodes, targetLowPriorityNodes must be set. </summary>
        public int? TargetLowPriorityNodes { get; set; }
        /// <summary> If omitted, the default value is Requeue. </summary>
        public BatchNodeDeallocationOption? NodeDeallocationOption { get; set; }
    }
}
