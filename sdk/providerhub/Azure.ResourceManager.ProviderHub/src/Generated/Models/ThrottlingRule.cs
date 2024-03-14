// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ThrottlingRule. </summary>
    public partial class ThrottlingRule
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

        /// <summary> Initializes a new instance of <see cref="ThrottlingRule"/>. </summary>
        /// <param name="action"></param>
        /// <param name="metrics"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> or <paramref name="metrics"/> is null. </exception>
        public ThrottlingRule(string action, IEnumerable<ThrottlingMetric> metrics)
        {
            Argument.AssertNotNull(action, nameof(action));
            Argument.AssertNotNull(metrics, nameof(metrics));

            Action = action;
            Metrics = metrics.ToList();
            RequiredFeatures = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ThrottlingRule"/>. </summary>
        /// <param name="action"></param>
        /// <param name="metrics"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThrottlingRule(string action, IList<ThrottlingMetric> metrics, IList<string> requiredFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            Metrics = metrics;
            RequiredFeatures = requiredFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThrottlingRule"/> for deserialization. </summary>
        internal ThrottlingRule()
        {
        }

        /// <summary> Gets or sets the action. </summary>
        public string Action { get; set; }
        /// <summary> Gets the metrics. </summary>
        public IList<ThrottlingMetric> Metrics { get; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
    }
}
