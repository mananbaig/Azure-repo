// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Base class to define the health summary of the resources contained under an Arm resource. </summary>
    public partial class ResourceHealthSummary
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

        /// <summary> Initializes a new instance of <see cref="ResourceHealthSummary"/>. </summary>
        internal ResourceHealthSummary()
        {
            Issues = new ChangeTrackingList<HealthErrorSummary>();
            CategorizedResourceCounts = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthSummary"/>. </summary>
        /// <param name="resourceCount"> The count of total resources under the container. </param>
        /// <param name="issues"> The list of summary of health errors across the resources under the container. </param>
        /// <param name="categorizedResourceCounts"> The categorized resource counts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthSummary(int? resourceCount, IReadOnlyList<HealthErrorSummary> issues, IReadOnlyDictionary<string, int> categorizedResourceCounts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceCount = resourceCount;
            Issues = issues;
            CategorizedResourceCounts = categorizedResourceCounts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The count of total resources under the container. </summary>
        public int? ResourceCount { get; }
        /// <summary> The list of summary of health errors across the resources under the container. </summary>
        public IReadOnlyList<HealthErrorSummary> Issues { get; }
        /// <summary> The categorized resource counts. </summary>
        public IReadOnlyDictionary<string, int> CategorizedResourceCounts { get; }
    }
}
